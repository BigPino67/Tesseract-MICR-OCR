Public Class TemplateOcrXY
    Inherits Template

    Friend Overrides Property Language As String = "ocr"
    Friend Overrides Property EndSpace As Integer = 10
    Friend Overrides Property XOffset As Integer = 300
    Friend Overrides Property YOffset As Integer = 120
    Friend Overrides Property WhiteList As String = "0123456789"

    Public Sub New(ByVal sourceImage As Image)
        Me.SourceImage = sourceImage

        CroppedHeight = 80
        MatchingTemplateRate = 0
        CropFromHeight = YOffset

        DefineROI()
        ApplyTemplate()
    End Sub

End Class
