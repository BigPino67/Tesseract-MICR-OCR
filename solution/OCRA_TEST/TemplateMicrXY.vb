Public Class TemplateMicrXY
    Inherits Template

    Friend Overrides Property Language As String = "mcr"
    Friend Overrides Property EndSpace As Integer = 300
    Friend Overrides Property XOffset As Integer = 60
    Friend Overrides Property YOffset As Integer = 120
    Friend Overrides Property WhiteList As String = "0123456789abcd"

    Public Property ImageTemplate As Image

    Public Sub New(ByVal sourceImage As Image)
        Me.SourceImage = sourceImage

        CroppedHeight = 80
        MatchingTemplateRate = 0
        CropFromHeight = sourceImage.Height - YOffset

        DefineROI()
        ApplyTemplate()
    End Sub

End Class
