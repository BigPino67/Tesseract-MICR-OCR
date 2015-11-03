Public Class TemplateOcrAnchor
    Inherits Template

    Friend Overrides Property Language As String = "ocr"
    Friend Overrides Property EndSpace As Integer = 10
    Private Const AnchorSuccessTresshold As Decimal = 0.75D
    Friend Overrides Property XOffset As Integer = 260
    Friend Overrides Property YOffset As Integer = 100
    Friend Overrides Property WhiteList As String = "0123456789"

    Public Property ImageTemplate As Image

    Public Sub New(ByVal sourceImage As Image)
        Me.SourceImage = sourceImage

        ImageTemplate = Image.FromFile("templateOcr.png")
        CroppedHeight = 58
    End Sub

    Public Overrides Sub DrawAnchor(ByRef pictBox As PictureBox)
        Dim xScale As Double = SourceImage.Width / pictBox.Width
        Dim yScale As Double = SourceImage.Height / pictBox.Height


        ScaledRegionTemplate = New Rectangle(RegionTemplate.X / xScale, RegionTemplate.Y / yScale, _
                                             ImageTemplate.Size.Width / xScale, ImageTemplate.Size.Height / yScale)

        Dim graphics As Graphics = pictBox.CreateGraphics()
        graphics.DrawRectangle(Pens.Blue, Me.ScaledRegionTemplate)
        graphics.Dispose()
    End Sub

    Public Overrides Function DefineROI() As Boolean
        Dim source = New Emgu.CV.Image(Of Emgu.CV.Structure.Bgr, Byte)(SourceImage)
        Dim ocrTemplate = New Emgu.CV.Image(Of Emgu.CV.Structure.Bgr, Byte)(ImageTemplate)
        Using result = source.MatchTemplate(ocrTemplate, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed)
            Dim minValues() As Double, maxValues() As Double
            Dim minLoc() As Point, maxLoc() As Point
            result.MinMax(minValues, maxValues, minLoc, maxLoc)
            MatchingTemplateRate = CDec(Math.Round(maxValues(0) * 100, 2, MidpointRounding.AwayFromZero))

            If (maxValues(0) > AnchorSuccessTresshold) Then
                If maxLoc.Count > 0 Then
                    CropFromWidth = maxLoc(0).X + XOffset
                    CropFromHeight = maxLoc(0).Y + YOffset
                    CroppedWidth = SourceImage.Width - CropFromWidth - EndSpace
                    RegionTemplate = New Rectangle(maxLoc(0), ocrTemplate.Size)
                End If
            Else
                ''Can't locate successfully image template from source image
                Return False
            End If
        End Using
        Return True
    End Function

    Public Sub Dispose()
        Me.ImageTemplate.Dispose()
        Me.Dispose()
    End Sub

End Class
