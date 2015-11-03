Imports System.Drawing
Imports System.Windows.Forms
Imports Tesseract

Public MustInherit Class Template
    Implements ITemplate

    Friend MustOverride Property Language As String
    Friend MustOverride Property XOffset As Integer
    Friend MustOverride Property YOffset As Integer
    Friend MustOverride Property EndSpace As Integer
    Friend MustOverride Property WhiteList As String

    Friend Property CropFromWidth As Integer Implements ITemplate.CropFromWidth
    Friend Property CropFromHeight As Integer Implements ITemplate.CropFromHeight

    Friend Property SourceImage As Image Implements ITemplate.SouceImage

    Friend Property CroppedWidth As Integer Implements ITemplate.CroppedWidth
    Friend Property CroppedHeight As Integer Implements ITemplate.CroppedHeight
    Public Property CroppedImage As Image Implements ITemplate.CroppedImage
    Public Property RegionOfInterest As Rectangle Implements ITemplate.RegionOfInterest
    Public Property ScaledRegionOfInterest As Rectangle Implements ITemplate.ScaledRegionOfInterest
    Public Property RegionTemplate As Rectangle Implements ITemplate.RegionTemplate
    Public Property ScaledRegionTemplate As Rectangle Implements ITemplate.ScaledRegionTemplate

    Public Property MatchingTemplateRate() As Decimal Implements ITemplate.MatchingTemplateRate
    Public Property RecognitionResult() As String Implements ITemplate.RecognitionResult
    Public Property RecognitionConfidence As Decimal Implements ITemplate.RecognitionConfidence
    Public Property CharsConfidence As New List(Of CharData) Implements ITemplate.CharsConfidence

    Public Overridable Function DefineROI() As Boolean Implements ITemplate.DefineROI
        CropFromWidth = XOffset
        CroppedWidth = SourceImage.Width - XOffset - EndSpace
        Return True
    End Function


    Public Overridable Function ApplyTemplate() As Boolean Implements ITemplate.ApplyTemplate
        Try
            Dim RegionOfInterest = New Rectangle(CropFromWidth, CropFromHeight, CroppedWidth, CroppedHeight)
            CroppedImage = New Bitmap(CroppedWidth, CroppedHeight)

            Dim img As Image = SourceImage.Clone
            Using grp = Graphics.FromImage(CroppedImage)
                grp.DrawImage(img, New Rectangle(0, 0, CroppedWidth, CroppedHeight), RegionOfInterest, GraphicsUnit.Pixel)
            End Using

            img.Dispose()

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Overridable Function ProcessImage() As Boolean Implements ITemplate.ProcessImage
        Using engine As New TesseractEngine("", Language, EngineMode.TesseractOnly)
            engine.SetVariable("tessedit_char_whitelist", Me.WhiteList)
            engine.SetVariable("save_best_choices", "T")
            Using Page = engine.Process(Me.CroppedImage)
                Me.RecognitionResult = Page.GetText.Trim
                Me.RecognitionResult = Me.RecognitionResult.Replace(vbLf, "")
                Me.RecognitionConfidence = Math.Round(Page.GetMeanConfidence() * 100, 2, MidpointRounding.AwayFromZero)

                Dim iter = Page.GetIterator
                iter.Begin()
                Do
                    Dim ch As New CharData() With {.Text = iter.GetText(PageIteratorLevel.Symbol), _
                                                .Confidence = iter.GetConfidence(PageIteratorLevel.Symbol)}
                    CharsConfidence.Add(ch)
                Loop While iter.Next(PageIteratorLevel.Symbol)
            End Using
        End Using
        Return True
    End Function

    Public Overridable Sub DrawAnchor(ByRef pictBox As PictureBox) Implements ITemplate.DrawAnchor
        ''Nothing to do here
    End Sub

    Public Sub DrawRoi(ByRef pictBox As PictureBox) Implements ITemplate.DrawRoi
        Dim xScale As Double = SourceImage.Width / pictBox.Width
        Dim yScale As Double = SourceImage.Height / pictBox.Height

        ScaledRegionOfInterest = New Rectangle(CropFromWidth / xScale, CropFromHeight / yScale, _
                                                CroppedWidth / xScale, CroppedHeight / yScale)

        Dim graphics1 As Graphics = pictBox.CreateGraphics()
        graphics1.DrawRectangle(Pens.Red, Me.ScaledRegionOfInterest)
        graphics1.Dispose()
    End Sub


End Class
