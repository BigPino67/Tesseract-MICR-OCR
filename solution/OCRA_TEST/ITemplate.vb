Imports System.Drawing
Imports System.Windows.Forms

Public Interface ITemplate
    Property SouceImage As Image
    Property CropFromHeight As Integer
    Property CropFromWidth As Integer

    Property CroppedHeight As Integer
    Property CroppedWidth As Integer
    Property CroppedImage As Image
    Property RegionTemplate As Rectangle
    Property ScaledRegionTemplate As Rectangle
    Property RegionOfInterest As Rectangle
    Property ScaledRegionOfInterest As Rectangle

    Property MatchingTemplateRate As Decimal
    Property RecognitionResult As String
    Property RecognitionConfidence As Decimal
    Property CharsConfidence As List(Of CharData)

    Function DefineROI() As Boolean
    Function ApplyTemplate() As Boolean
    Function ProcessImage() As Boolean
    Sub DrawAnchor(ByRef pictBox As PictureBox)
    Sub DrawRoi(ByRef pictBox As PictureBox)
End Interface
