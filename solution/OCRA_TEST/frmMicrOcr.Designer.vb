<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMicrOcr
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.pctPiece = New System.Windows.Forms.PictureBox()
        Me.pctOcrRoi = New System.Windows.Forms.PictureBox()
        Me.txtOcrResult = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblOcrResult = New System.Windows.Forms.Label()
        Me.chtRate = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.txtMicrResult = New System.Windows.Forms.RichTextBox()
        Me.pctMicrRoi = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblMicrResult = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOcrTemplate = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblMicrTemplate = New System.Windows.Forms.Label()
        Me.lblTsOcrMatch = New System.Windows.Forms.Label()
        Me.lblTsMicrMatch = New System.Windows.Forms.Label()
        Me.lblTsMicrResult = New System.Windows.Forms.Label()
        Me.lblTsOcrResult = New System.Windows.Forms.Label()
        CType(Me.pctPiece, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctOcrRoi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctMicrRoi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctPiece
        '
        Me.pctPiece.Location = New System.Drawing.Point(12, 12)
        Me.pctPiece.Name = "pctPiece"
        Me.pctPiece.Size = New System.Drawing.Size(860, 346)
        Me.pctPiece.TabIndex = 0
        Me.pctPiece.TabStop = False
        '
        'pctOcrRoi
        '
        Me.pctOcrRoi.Location = New System.Drawing.Point(12, 391)
        Me.pctOcrRoi.Name = "pctOcrRoi"
        Me.pctOcrRoi.Size = New System.Drawing.Size(860, 52)
        Me.pctOcrRoi.TabIndex = 1
        Me.pctOcrRoi.TabStop = False
        '
        'txtOcrResult
        '
        Me.txtOcrResult.Location = New System.Drawing.Point(12, 475)
        Me.txtOcrResult.Name = "txtOcrResult"
        Me.txtOcrResult.Size = New System.Drawing.Size(860, 49)
        Me.txtOcrResult.TabIndex = 2
        Me.txtOcrResult.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1615, 268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 36)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Process image"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblOcrResult
        '
        Me.lblOcrResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcrResult.Location = New System.Drawing.Point(896, 151)
        Me.lblOcrResult.Name = "lblOcrResult"
        Me.lblOcrResult.Size = New System.Drawing.Size(285, 136)
        Me.lblOcrResult.TabIndex = 7
        Me.lblOcrResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chtRate
        '
        Me.chtRate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        ChartArea4.Name = "ChartArea1"
        Me.chtRate.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.chtRate.Legends.Add(Legend4)
        Me.chtRate.Location = New System.Drawing.Point(12, 554)
        Me.chtRate.Name = "chtRate"
        Me.chtRate.Size = New System.Drawing.Size(1747, 300)
        Me.chtRate.TabIndex = 8
        Me.chtRate.Text = "Chart1"
        '
        'txtMicrResult
        '
        Me.txtMicrResult.Location = New System.Drawing.Point(899, 475)
        Me.txtMicrResult.Name = "txtMicrResult"
        Me.txtMicrResult.Size = New System.Drawing.Size(860, 49)
        Me.txtMicrResult.TabIndex = 10
        Me.txtMicrResult.Text = ""
        '
        'pctMicrRoi
        '
        Me.pctMicrRoi.Location = New System.Drawing.Point(899, 389)
        Me.pctMicrRoi.Name = "pctMicrRoi"
        Me.pctMicrRoi.Size = New System.Drawing.Size(860, 52)
        Me.pctMicrRoi.TabIndex = 9
        Me.pctMicrRoi.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 371)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "OCR Region of Interest (ROI)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(896, 369)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "MICR Region of Interest (ROI)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 455)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "OCR Result"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(896, 455)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "MICR Result"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 534)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "OCR Confidence"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(956, 257)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "OCR Recognition result"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1276, 257)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "MICR Recognition result"
        '
        'lblMicrResult
        '
        Me.lblMicrResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMicrResult.Location = New System.Drawing.Point(1218, 151)
        Me.lblMicrResult.Name = "lblMicrResult"
        Me.lblMicrResult.Size = New System.Drawing.Size(285, 136)
        Me.lblMicrResult.TabIndex = 18
        Me.lblMicrResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(936, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "OCR Matching template result"
        '
        'lblOcrTemplate
        '
        Me.lblOcrTemplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcrTemplate.Location = New System.Drawing.Point(896, -2)
        Me.lblOcrTemplate.Name = "lblOcrTemplate"
        Me.lblOcrTemplate.Size = New System.Drawing.Size(285, 136)
        Me.lblOcrTemplate.TabIndex = 20
        Me.lblOcrTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1258, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(199, 17)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "MICR Matching template result"
        '
        'lblMicrTemplate
        '
        Me.lblMicrTemplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMicrTemplate.Location = New System.Drawing.Point(1218, -2)
        Me.lblMicrTemplate.Name = "lblMicrTemplate"
        Me.lblMicrTemplate.Size = New System.Drawing.Size(285, 136)
        Me.lblMicrTemplate.TabIndex = 22
        Me.lblMicrTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTsOcrMatch
        '
        Me.lblTsOcrMatch.Location = New System.Drawing.Point(936, 134)
        Me.lblTsOcrMatch.Name = "lblTsOcrMatch"
        Me.lblTsOcrMatch.Size = New System.Drawing.Size(196, 17)
        Me.lblTsOcrMatch.TabIndex = 24
        Me.lblTsOcrMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTsMicrMatch
        '
        Me.lblTsMicrMatch.Location = New System.Drawing.Point(1258, 134)
        Me.lblTsMicrMatch.Name = "lblTsMicrMatch"
        Me.lblTsMicrMatch.Size = New System.Drawing.Size(196, 17)
        Me.lblTsMicrMatch.TabIndex = 25
        Me.lblTsMicrMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTsMicrResult
        '
        Me.lblTsMicrResult.Location = New System.Drawing.Point(1258, 287)
        Me.lblTsMicrResult.Name = "lblTsMicrResult"
        Me.lblTsMicrResult.Size = New System.Drawing.Size(196, 17)
        Me.lblTsMicrResult.TabIndex = 26
        Me.lblTsMicrResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTsOcrResult
        '
        Me.lblTsOcrResult.Location = New System.Drawing.Point(936, 287)
        Me.lblTsOcrResult.Name = "lblTsOcrResult"
        Me.lblTsOcrResult.Size = New System.Drawing.Size(196, 17)
        Me.lblTsOcrResult.TabIndex = 27
        Me.lblTsOcrResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMicrOcr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1776, 866)
        Me.Controls.Add(Me.lblTsOcrResult)
        Me.Controls.Add(Me.lblTsMicrResult)
        Me.Controls.Add(Me.lblTsMicrMatch)
        Me.Controls.Add(Me.lblTsOcrMatch)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblMicrTemplate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblOcrTemplate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblMicrResult)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMicrResult)
        Me.Controls.Add(Me.pctMicrRoi)
        Me.Controls.Add(Me.chtRate)
        Me.Controls.Add(Me.lblOcrResult)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtOcrResult)
        Me.Controls.Add(Me.pctOcrRoi)
        Me.Controls.Add(Me.pctPiece)
        Me.Name = "frmMicrOcr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Testing Tesseract for MICR and OCR language"
        CType(Me.pctPiece, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctOcrRoi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctMicrRoi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pctPiece As System.Windows.Forms.PictureBox
    Friend WithEvents pctOcrRoi As System.Windows.Forms.PictureBox
    Friend WithEvents txtOcrResult As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents lblOcrResult As System.Windows.Forms.Label
    Friend WithEvents chtRate As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents txtMicrResult As System.Windows.Forms.RichTextBox
    Friend WithEvents pctMicrRoi As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents lblMicrResult As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents lblOcrTemplate As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents lblMicrTemplate As System.Windows.Forms.Label
    Friend WithEvents lblTsOcrMatch As System.Windows.Forms.Label
    Friend WithEvents lblTsMicrMatch As System.Windows.Forms.Label
    Friend WithEvents lblTsMicrResult As System.Windows.Forms.Label
    Friend WithEvents lblTsOcrResult As System.Windows.Forms.Label

End Class
