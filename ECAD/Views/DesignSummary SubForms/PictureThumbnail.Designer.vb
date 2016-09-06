<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PictureThumbnail
    Inherits Telerik.WinControls.UI.RadForm

    Public Sub New()
        InitializeComponent()
        LocalizeComponent()

    End Sub

    ' Localizes all the ui elements from a common Resource
    Private Sub LocalizeComponent()
        Me.SuspendLayout()

        Helpers.LocalizationHelper.LocalizeForm(Me)

        Me.ResumeLayout(False)
    End Sub

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PictureThumbnail))
        Me.Panel_Header = New System.Windows.Forms.Panel()
        Me.RadGroupBox = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadRadioButton1 = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadRadioButton3 = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadRadioButton4 = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadButton_PiecePartsForm = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox_KemetLogo = New System.Windows.Forms.PictureBox()
        Me.RadLabel_Title = New Telerik.WinControls.UI.RadLabel()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.RadScrollablePanel_MainPanel = New Telerik.WinControls.UI.RadScrollablePanel()
        Me.Panel_FormToReplicate = New System.Windows.Forms.Panel()
        Me.RadTextBox_Path = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Path = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Description = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Description = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_PictureReference = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_PictureReference = New Telerik.WinControls.UI.RadLabel()
        Me.PictureBox_Image = New System.Windows.Forms.PictureBox()
        Me.Panel_Header.SuspendLayout()
        CType(Me.RadGroupBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox.SuspendLayout()
        CType(Me.RadRadioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_PiecePartsForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadScrollablePanel_MainPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadScrollablePanel_MainPanel.PanelContainer.SuspendLayout()
        Me.RadScrollablePanel_MainPanel.SuspendLayout()
        Me.Panel_FormToReplicate.SuspendLayout()
        CType(Me.RadTextBox_Path, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Path, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_PictureReference, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PictureReference, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Header
        '
        Me.Panel_Header.BackColor = System.Drawing.Color.White
        Me.Panel_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Header.Controls.Add(Me.RadGroupBox)
        Me.Panel_Header.Controls.Add(Me.RadButton_PiecePartsForm)
        Me.Panel_Header.Controls.Add(Me.PictureBox_KemetLogo)
        Me.Panel_Header.Controls.Add(Me.RadLabel_Title)
        Me.Panel_Header.Location = New System.Drawing.Point(-12, -3)
        Me.Panel_Header.Name = "Panel_Header"
        Me.Panel_Header.Size = New System.Drawing.Size(935, 71)
        Me.Panel_Header.TabIndex = 2
        '
        'RadGroupBox
        '
        Me.RadGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox.BackColor = System.Drawing.Color.White
        Me.RadGroupBox.Controls.Add(Me.RadRadioButton1)
        Me.RadGroupBox.Controls.Add(Me.RadRadioButton2)
        Me.RadGroupBox.Controls.Add(Me.RadRadioButton3)
        Me.RadGroupBox.Controls.Add(Me.RadRadioButton4)
        Me.RadGroupBox.HeaderText = ""
        Me.RadGroupBox.Location = New System.Drawing.Point(302, 15)
        Me.RadGroupBox.Name = "RadGroupBox"
        Me.RadGroupBox.Size = New System.Drawing.Size(280, 38)
        Me.RadGroupBox.TabIndex = 3
        Me.RadGroupBox.ThemeName = "Windows8"
        '
        'RadRadioButton1
        '
        Me.RadRadioButton1.AutoSize = False
        Me.RadRadioButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadRadioButton1.Location = New System.Drawing.Point(221, 10)
        Me.RadRadioButton1.Name = "RadRadioButton1"
        Me.RadRadioButton1.Size = New System.Drawing.Size(54, 20)
        Me.RadRadioButton1.TabIndex = 9
        Me.RadRadioButton1.Text = "PictureThumbnail_All"
        Me.RadRadioButton1.ThemeName = "Windows8"
        '
        'RadRadioButton2
        '
        Me.RadRadioButton2.AutoSize = False
        Me.RadRadioButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadRadioButton2.Location = New System.Drawing.Point(151, 10)
        Me.RadRadioButton2.Name = "RadRadioButton2"
        Me.RadRadioButton2.Size = New System.Drawing.Size(70, 20)
        Me.RadRadioButton2.TabIndex = 8
        Me.RadRadioButton2.Text = "PictureThumbnail_Spec"
        Me.RadRadioButton2.ThemeName = "Windows8"
        '
        'RadRadioButton3
        '
        Me.RadRadioButton3.AutoSize = False
        Me.RadRadioButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadRadioButton3.Location = New System.Drawing.Point(81, 10)
        Me.RadRadioButton3.Name = "RadRadioButton3"
        Me.RadRadioButton3.Size = New System.Drawing.Size(70, 20)
        Me.RadRadioButton3.TabIndex = 7
        Me.RadRadioButton3.Text = "PictureThumbnail_Dims"
        Me.RadRadioButton3.ThemeName = "Windows8"
        '
        'RadRadioButton4
        '
        Me.RadRadioButton4.AutoSize = False
        Me.RadRadioButton4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadRadioButton4.Location = New System.Drawing.Point(11, 10)
        Me.RadRadioButton4.Name = "RadRadioButton4"
        Me.RadRadioButton4.Size = New System.Drawing.Size(70, 20)
        Me.RadRadioButton4.TabIndex = 6
        Me.RadRadioButton4.Text = "PictureThumbnail_Wind"
        Me.RadRadioButton4.ThemeName = "Windows8"
        '
        'RadButton_PiecePartsForm
        '
        Me.RadButton_PiecePartsForm.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadButton_PiecePartsForm.Location = New System.Drawing.Point(625, 15)
        Me.RadButton_PiecePartsForm.Name = "RadButton_PiecePartsForm"
        Me.RadButton_PiecePartsForm.Size = New System.Drawing.Size(130, 38)
        Me.RadButton_PiecePartsForm.TabIndex = 14
        Me.RadButton_PiecePartsForm.Text = "PictureThumbnail_ReturnToPictures"
        Me.RadButton_PiecePartsForm.TextWrap = True
        Me.RadButton_PiecePartsForm.ThemeName = "Windows8"
        '
        'PictureBox_KemetLogo
        '
        Me.PictureBox_KemetLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox_KemetLogo.Image = Global.ECAD.My.Resources.Resources.kemet_logo_small
        Me.PictureBox_KemetLogo.Location = New System.Drawing.Point(795, 7)
        Me.PictureBox_KemetLogo.MaximumSize = New System.Drawing.Size(142, 61)
        Me.PictureBox_KemetLogo.Name = "PictureBox_KemetLogo"
        Me.PictureBox_KemetLogo.Size = New System.Drawing.Size(116, 55)
        Me.PictureBox_KemetLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_KemetLogo.TabIndex = 11
        Me.PictureBox_KemetLogo.TabStop = False
        '
        'RadLabel_Title
        '
        Me.RadLabel_Title.AutoSize = False
        Me.RadLabel_Title.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Title.Location = New System.Drawing.Point(25, -2)
        Me.RadLabel_Title.Name = "RadLabel_Title"
        Me.RadLabel_Title.Size = New System.Drawing.Size(251, 68)
        Me.RadLabel_Title.TabIndex = 0
        Me.RadLabel_Title.Text = "PictureThumbnail_Title"
        Me.RadLabel_Title.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Title.TextWrap = False
        Me.RadLabel_Title.ThemeName = "Windows8"
        '
        'RadScrollablePanel_MainPanel
        '
        Me.RadScrollablePanel_MainPanel.BackColor = System.Drawing.Color.Silver
        Me.RadScrollablePanel_MainPanel.Location = New System.Drawing.Point(0, 66)
        Me.RadScrollablePanel_MainPanel.Name = "RadScrollablePanel_MainPanel"
        '
        'RadScrollablePanel_MainPanel.PanelContainer
        '
        Me.RadScrollablePanel_MainPanel.PanelContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RadScrollablePanel_MainPanel.PanelContainer.Controls.Add(Me.Panel_FormToReplicate)
        Me.RadScrollablePanel_MainPanel.PanelContainer.Size = New System.Drawing.Size(910, 473)
        Me.RadScrollablePanel_MainPanel.Size = New System.Drawing.Size(912, 475)
        Me.RadScrollablePanel_MainPanel.TabIndex = 3
        Me.RadScrollablePanel_MainPanel.Text = "RadScrollablePanel1"
        Me.RadScrollablePanel_MainPanel.ThemeName = "Windows8"
        '
        'Panel_FormToReplicate
        '
        Me.Panel_FormToReplicate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_FormToReplicate.Controls.Add(Me.RadTextBox_Path)
        Me.Panel_FormToReplicate.Controls.Add(Me.RadLabel_Path)
        Me.Panel_FormToReplicate.Controls.Add(Me.RadTextBox_Description)
        Me.Panel_FormToReplicate.Controls.Add(Me.RadLabel_Description)
        Me.Panel_FormToReplicate.Controls.Add(Me.RadTextBox_PictureReference)
        Me.Panel_FormToReplicate.Controls.Add(Me.RadLabel_PictureReference)
        Me.Panel_FormToReplicate.Controls.Add(Me.PictureBox_Image)
        Me.Panel_FormToReplicate.Location = New System.Drawing.Point(0, 0)
        Me.Panel_FormToReplicate.Name = "Panel_FormToReplicate"
        Me.Panel_FormToReplicate.Size = New System.Drawing.Size(906, 154)
        Me.Panel_FormToReplicate.TabIndex = 0
        '
        'RadTextBox_Path
        '
        Me.RadTextBox_Path.AutoSize = False
        Me.RadTextBox_Path.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_Path.Location = New System.Drawing.Point(56, 127)
        Me.RadTextBox_Path.Name = "RadTextBox_Path"
        Me.RadTextBox_Path.Size = New System.Drawing.Size(206, 15)
        Me.RadTextBox_Path.TabIndex = 6
        Me.RadTextBox_Path.ThemeName = "Windows8"
        '
        'RadLabel_Path
        '
        Me.RadLabel_Path.AutoSize = False
        Me.RadLabel_Path.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadLabel_Path.Location = New System.Drawing.Point(11, 127)
        Me.RadLabel_Path.Name = "RadLabel_Path"
        Me.RadLabel_Path.Size = New System.Drawing.Size(66, 15)
        Me.RadLabel_Path.TabIndex = 5
        Me.RadLabel_Path.Text = "PictureThumbnail_Path"
        Me.RadLabel_Path.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Path.TextWrap = False
        Me.RadLabel_Path.ThemeName = "Windows8"
        '
        'RadTextBox_Description
        '
        Me.RadTextBox_Description.AutoSize = False
        Me.RadTextBox_Description.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_Description.Location = New System.Drawing.Point(12, 96)
        Me.RadTextBox_Description.Name = "RadTextBox_Description"
        Me.RadTextBox_Description.Size = New System.Drawing.Size(251, 25)
        Me.RadTextBox_Description.TabIndex = 4
        Me.RadTextBox_Description.ThemeName = "Windows8"
        '
        'RadLabel_Description
        '
        Me.RadLabel_Description.AutoSize = False
        Me.RadLabel_Description.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Description.Location = New System.Drawing.Point(11, 67)
        Me.RadLabel_Description.Name = "RadLabel_Description"
        Me.RadLabel_Description.Size = New System.Drawing.Size(173, 25)
        Me.RadLabel_Description.TabIndex = 3
        Me.RadLabel_Description.Text = "PictureThumbnail_Description"
        Me.RadLabel_Description.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Description.TextWrap = False
        Me.RadLabel_Description.ThemeName = "Windows8"
        '
        'RadTextBox_PictureReference
        '
        Me.RadTextBox_PictureReference.AutoSize = False
        Me.RadTextBox_PictureReference.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_PictureReference.Location = New System.Drawing.Point(11, 38)
        Me.RadTextBox_PictureReference.Name = "RadTextBox_PictureReference"
        Me.RadTextBox_PictureReference.Size = New System.Drawing.Size(251, 25)
        Me.RadTextBox_PictureReference.TabIndex = 2
        Me.RadTextBox_PictureReference.ThemeName = "Windows8"
        '
        'RadLabel_PictureReference
        '
        Me.RadLabel_PictureReference.AutoSize = False
        Me.RadLabel_PictureReference.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_PictureReference.Location = New System.Drawing.Point(10, 10)
        Me.RadLabel_PictureReference.Name = "RadLabel_PictureReference"
        Me.RadLabel_PictureReference.Size = New System.Drawing.Size(173, 25)
        Me.RadLabel_PictureReference.TabIndex = 1
        Me.RadLabel_PictureReference.Text = "PictureThumbnail_PictureReference"
        Me.RadLabel_PictureReference.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_PictureReference.TextWrap = False
        Me.RadLabel_PictureReference.ThemeName = "Windows8"
        '
        'PictureBox_Image
        '
        Me.PictureBox_Image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox_Image.Location = New System.Drawing.Point(313, 10)
        Me.PictureBox_Image.Name = "PictureBox_Image"
        Me.PictureBox_Image.Size = New System.Drawing.Size(584, 132)
        Me.PictureBox_Image.TabIndex = 0
        Me.PictureBox_Image.TabStop = False
        '
        'PictureThumbnail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(913, 541)
        Me.Controls.Add(Me.RadScrollablePanel_MainPanel)
        Me.Controls.Add(Me.Panel_Header)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(921, 574)
        Me.MinimumSize = New System.Drawing.Size(921, 574)
        Me.Name = "PictureThumbnail"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(921, 574)
        Me.Text = "PictureThumbnail_TitleWindow"
        Me.ThemeName = "Windows8"
        Me.Panel_Header.ResumeLayout(False)
        CType(Me.RadGroupBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox.ResumeLayout(False)
        CType(Me.RadRadioButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_PiecePartsForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Title, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadScrollablePanel_MainPanel.PanelContainer.ResumeLayout(False)
        CType(Me.RadScrollablePanel_MainPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadScrollablePanel_MainPanel.ResumeLayout(False)
        Me.Panel_FormToReplicate.ResumeLayout(False)
        CType(Me.RadTextBox_Path, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Path, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Description, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Description, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_PictureReference, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PictureReference, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Header As System.Windows.Forms.Panel
    Friend WithEvents RadButton_PiecePartsForm As Telerik.WinControls.UI.RadButton
    Friend WithEvents PictureBox_KemetLogo As System.Windows.Forms.PictureBox
    Friend WithEvents RadLabel_Title As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGroupBox As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadRadioButton1 As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadRadioButton2 As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadRadioButton3 As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadRadioButton4 As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents RadScrollablePanel_MainPanel As Telerik.WinControls.UI.RadScrollablePanel
    Friend WithEvents Panel_FormToReplicate As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_PictureReference As Telerik.WinControls.UI.RadLabel
    Friend WithEvents PictureBox_Image As System.Windows.Forms.PictureBox
    Friend WithEvents RadTextBox_PictureReference As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Description As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Description As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Path As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Path As Telerik.WinControls.UI.RadTextBox
End Class

