Imports Tesseract
Imports Emgu
Imports Emgu.CV.Structure
Imports System.Windows.Forms.DataVisualization.Charting


Public Class frmMicrOcr

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pctPiece.BackgroundImage = Image.FromFile("example.tif")
        pctPiece.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DoOcr(Me.pctPiece)
        DoMicr(Me.pctPiece)

    End Sub


    Private Sub DoOcr(ByRef pctPiece As PictureBox)
        Try
            Dim d1 = DateTime.Now


            Dim template As ITemplate = New TemplateOcrAnchor(pctPiece.BackgroundImage.Clone)
            If template.DefineROI() Then
                lblOcrTemplate.Text = CInt(template.MatchingTemplateRate) & " %"
            Else
                lblOcrTemplate.Text = CInt(template.MatchingTemplateRate) & " %"
                template = New TemplateOcrXY(pctPiece.BackgroundImage.Clone)
            End If
            template.ApplyTemplate()
            pctOcrRoi.BackgroundImage = template.CroppedImage

            Dim d2 = DateTime.Now

            template.ProcessImage()
            lblOcrResult.Text = template.RecognitionConfidence & " %"
            txtOcrResult.Text = template.RecognitionResult

            Dim d3 = DateTime.Now

            template.DrawAnchor(pctPiece)
            template.DrawRoi(pctPiece)
            lblTsOcrMatch.Text = String.Format("Template choice in {0} ms", d2.Subtract(d1).Milliseconds)
            lblTsOcrResult.Text = String.Format("Recognition in {0} ms", d3.Subtract(d2).Milliseconds)

            chtRate.Series.Clear()
            chtRate.ChartAreas(0).AxisX.Interval = 1
            Dim serie As New DataVisualization.Charting.Series
            For Each ch In template.CharsConfidence
                serie.Points.AddXY(ch.Text, ch.Confidence)
            Next
            chtRate.Series.Add(serie)

        Catch ex As Exception
            Dim i = 0
        End Try
    End Sub

    Private Sub DoMicr(ByRef pctPiece As PictureBox)
        Try
            Dim d4 = DateTime.Now
            Dim templateMicr As ITemplate = New TemplateMicrAnchor(pctPiece.BackgroundImage)
            If templateMicr.DefineROI() Then
                lblMicrTemplate.Text = CInt(templateMicr.MatchingTemplateRate) & " %"
            Else
                lblMicrTemplate.Text = CInt(templateMicr.MatchingTemplateRate) & " %"
                templateMicr = New TemplateMicrXY(pctPiece.BackgroundImage)
            End If
            templateMicr.ApplyTemplate()
            pctMicrRoi.BackgroundImage = templateMicr.CroppedImage

            Dim d5 = DateTime.Now

            templateMicr.ProcessImage()
            lblMicrResult.Text = templateMicr.RecognitionConfidence & " %"
            txtMicrResult.Text = templateMicr.RecognitionResult.Replace(" ", "")

            Dim d6 = DateTime.Now

            templateMicr.DrawAnchor(pctPiece)
            templateMicr.DrawRoi(pctPiece)
            lblTsMicrMatch.Text = String.Format("Template choice in {0} ms", d5.Subtract(d4).Milliseconds)
            lblTsMicrResult.Text = String.Format("Recognition in {0} ms", d6.Subtract(d5).Milliseconds)
        Catch ex As Exception
            Dim i = 0
        End Try
    End Sub


End Class
