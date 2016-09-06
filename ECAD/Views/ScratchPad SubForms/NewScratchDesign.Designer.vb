<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewScratchDesign
    Inherits Telerik.WinControls.UI.RadForm

    Public Sub New()
        InitializeComponent()

        Me.SuspendLayout()
        ' Localize all the ui elements from a common Resource
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewScratchDesign))
        Me.Panel_Options = New System.Windows.Forms.Panel()
        Me.RadCheckBox_UseArchive = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadDropDownList_ArchiveDesign = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_Design = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_ArchiveDesign = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Design = New Telerik.WinControls.UI.RadLabel()
        Me.RadRadioButton_Wizard = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadRadioButton_Basic = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadRadioButton_PartNumber = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadRadioButton_Outlines = New Telerik.WinControls.UI.RadRadioButton()
        Me.Panel_Text = New System.Windows.Forms.Panel()
        Me.RadLabel_Counter = New Telerik.WinControls.UI.RadLabel()
        Me.RadButton_Cancel = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_OK = New Telerik.WinControls.UI.RadButton()
        Me.RadTextBox_FirstAnodeName = New Telerik.WinControls.UI.RadTextBox()
        Me.Panel_Options.SuspendLayout()
        CType(Me.RadCheckBox_UseArchive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_ArchiveDesign, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_Design, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ArchiveDesign, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Design, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton_Wizard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton_Basic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton_PartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton_Outlines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Text.SuspendLayout()
        CType(Me.RadLabel_Counter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_OK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_FirstAnodeName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Options
        '
        Me.Panel_Options.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Options.Controls.Add(Me.RadCheckBox_UseArchive)
        Me.Panel_Options.Controls.Add(Me.RadDropDownList_ArchiveDesign)
        Me.Panel_Options.Controls.Add(Me.RadDropDownList_Design)
        Me.Panel_Options.Controls.Add(Me.RadLabel_ArchiveDesign)
        Me.Panel_Options.Controls.Add(Me.RadLabel_Design)
        Me.Panel_Options.Controls.Add(Me.RadRadioButton_Wizard)
        Me.Panel_Options.Controls.Add(Me.RadRadioButton_Basic)
        Me.Panel_Options.Controls.Add(Me.RadRadioButton_PartNumber)
        Me.Panel_Options.Controls.Add(Me.RadRadioButton_Outlines)
        Me.Panel_Options.Location = New System.Drawing.Point(14, 20)
        Me.Panel_Options.Name = "Panel_Options"
        Me.Panel_Options.Size = New System.Drawing.Size(244, 144)
        Me.Panel_Options.TabIndex = 0
        '
        'RadCheckBox_UseArchive
        '
        Me.RadCheckBox_UseArchive.AutoSize = False
        Me.RadCheckBox_UseArchive.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadCheckBox_UseArchive.Location = New System.Drawing.Point(121, 98)
        Me.RadCheckBox_UseArchive.Name = "RadCheckBox_UseArchive"
        Me.RadCheckBox_UseArchive.Size = New System.Drawing.Size(80, 16)
        Me.RadCheckBox_UseArchive.TabIndex = 89
        Me.RadCheckBox_UseArchive.Text = "NewScratchDesign_UseArchive"
        '
        'RadDropDownList_ArchiveDesign
        '
        Me.RadDropDownList_ArchiveDesign.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_ArchiveDesign.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadDropDownList_ArchiveDesign.Location = New System.Drawing.Point(8, 114)
        Me.RadDropDownList_ArchiveDesign.Name = "RadDropDownList_ArchiveDesign"
        Me.RadDropDownList_ArchiveDesign.Size = New System.Drawing.Size(200, 20)
        Me.RadDropDownList_ArchiveDesign.TabIndex = 45
        Me.RadDropDownList_ArchiveDesign.Text = "Unbound"
        Me.RadDropDownList_ArchiveDesign.Visible = False
        '
        'RadDropDownList_Design
        '
        Me.RadDropDownList_Design.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Design.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadDropDownList_Design.Location = New System.Drawing.Point(8, 74)
        Me.RadDropDownList_Design.Name = "RadDropDownList_Design"
        Me.RadDropDownList_Design.Size = New System.Drawing.Size(200, 20)
        Me.RadDropDownList_Design.TabIndex = 44
        Me.RadDropDownList_Design.Text = "Unbound"
        '
        'RadLabel_ArchiveDesign
        '
        Me.RadLabel_ArchiveDesign.AutoSize = False
        Me.RadLabel_ArchiveDesign.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadLabel_ArchiveDesign.Location = New System.Drawing.Point(8, 99)
        Me.RadLabel_ArchiveDesign.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_ArchiveDesign.Name = "RadLabel_ArchiveDesign"
        Me.RadLabel_ArchiveDesign.Size = New System.Drawing.Size(110, 15)
        Me.RadLabel_ArchiveDesign.TabIndex = 43
        Me.RadLabel_ArchiveDesign.Text = "Global_ArchiveDesign"
        Me.RadLabel_ArchiveDesign.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_ArchiveDesign.Visible = False
        '
        'RadLabel_Design
        '
        Me.RadLabel_Design.AutoSize = False
        Me.RadLabel_Design.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadLabel_Design.Location = New System.Drawing.Point(8, 59)
        Me.RadLabel_Design.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Design.Name = "RadLabel_Design"
        Me.RadLabel_Design.Size = New System.Drawing.Size(140, 15)
        Me.RadLabel_Design.TabIndex = 42
        Me.RadLabel_Design.Text = "Global_Design"
        Me.RadLabel_Design.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadRadioButton_Wizard
        '
        Me.RadRadioButton_Wizard.AutoSize = False
        Me.RadRadioButton_Wizard.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadRadioButton_Wizard.Location = New System.Drawing.Point(122, 37)
        Me.RadRadioButton_Wizard.Name = "RadRadioButton_Wizard"
        Me.RadRadioButton_Wizard.Size = New System.Drawing.Size(100, 18)
        Me.RadRadioButton_Wizard.TabIndex = 41
        Me.RadRadioButton_Wizard.Text = "Global_Wizard"
        '
        'RadRadioButton_Basic
        '
        Me.RadRadioButton_Basic.AutoSize = False
        Me.RadRadioButton_Basic.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadRadioButton_Basic.Location = New System.Drawing.Point(122, 13)
        Me.RadRadioButton_Basic.Name = "RadRadioButton_Basic"
        Me.RadRadioButton_Basic.Size = New System.Drawing.Size(100, 18)
        Me.RadRadioButton_Basic.TabIndex = 40
        Me.RadRadioButton_Basic.Text = "Global_Basic"
        '
        'RadRadioButton_PartNumber
        '
        Me.RadRadioButton_PartNumber.AutoSize = False
        Me.RadRadioButton_PartNumber.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadRadioButton_PartNumber.Location = New System.Drawing.Point(19, 37)
        Me.RadRadioButton_PartNumber.Name = "RadRadioButton_PartNumber"
        Me.RadRadioButton_PartNumber.Size = New System.Drawing.Size(100, 18)
        Me.RadRadioButton_PartNumber.TabIndex = 40
        Me.RadRadioButton_PartNumber.Text = "Global_PartNumbers"
        '
        'RadRadioButton_Outlines
        '
        Me.RadRadioButton_Outlines.AutoSize = False
        Me.RadRadioButton_Outlines.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadRadioButton_Outlines.Location = New System.Drawing.Point(19, 13)
        Me.RadRadioButton_Outlines.Name = "RadRadioButton_Outlines"
        Me.RadRadioButton_Outlines.Size = New System.Drawing.Size(100, 18)
        Me.RadRadioButton_Outlines.TabIndex = 39
        Me.RadRadioButton_Outlines.Text = "Global_Outlines"
        '
        'Panel_Text
        '
        Me.Panel_Text.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Text.Controls.Add(Me.RadLabel_Counter)
        Me.Panel_Text.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Panel_Text.Location = New System.Drawing.Point(24, 8)
        Me.Panel_Text.Name = "Panel_Text"
        Me.Panel_Text.Size = New System.Drawing.Size(140, 23)
        Me.Panel_Text.TabIndex = 1
        '
        'RadLabel_Counter
        '
        Me.RadLabel_Counter.AutoSize = False
        Me.RadLabel_Counter.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadLabel_Counter.Location = New System.Drawing.Point(-2, 2)
        Me.RadLabel_Counter.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Counter.Name = "RadLabel_Counter"
        Me.RadLabel_Counter.Size = New System.Drawing.Size(140, 16)
        Me.RadLabel_Counter.TabIndex = 31
        Me.RadLabel_Counter.Text = "NewScratchDesign_Header"
        Me.RadLabel_Counter.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadButton_Cancel
        '
        Me.RadButton_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_Cancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Cancel.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Cancel.Location = New System.Drawing.Point(139, 172)
        Me.RadButton_Cancel.Name = "RadButton_Cancel"
        Me.RadButton_Cancel.Size = New System.Drawing.Size(117, 27)
        Me.RadButton_Cancel.TabIndex = 10
        Me.RadButton_Cancel.Text = "Global_Cancel"
        Me.RadButton_Cancel.TextWrap = True
        '
        'RadButton_OK
        '
        Me.RadButton_OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_OK.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_OK.ForeColor = System.Drawing.Color.Black
        Me.RadButton_OK.Location = New System.Drawing.Point(14, 172)
        Me.RadButton_OK.Name = "RadButton_OK"
        Me.RadButton_OK.Size = New System.Drawing.Size(117, 27)
        Me.RadButton_OK.TabIndex = 11
        Me.RadButton_OK.Text = "Global_OK"
        Me.RadButton_OK.TextWrap = True
        '
        'RadTextBox_FirstAnodeName
        '
        Me.RadTextBox_FirstAnodeName.AutoSize = False
        Me.RadTextBox_FirstAnodeName.BackColor = System.Drawing.Color.White
        Me.RadTextBox_FirstAnodeName.Enabled = False
        Me.RadTextBox_FirstAnodeName.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_FirstAnodeName.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_FirstAnodeName.Location = New System.Drawing.Point(181, 8)
        Me.RadTextBox_FirstAnodeName.Name = "RadTextBox_FirstAnodeName"
        Me.RadTextBox_FirstAnodeName.Size = New System.Drawing.Size(42, 23)
        Me.RadTextBox_FirstAnodeName.TabIndex = 94
        Me.RadTextBox_FirstAnodeName.Text = "=[des_outline_combo_archive].[Column](1)"
        Me.RadTextBox_FirstAnodeName.Visible = False
        '
        'NewScratchDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(272, 207)
        Me.Controls.Add(Me.RadTextBox_FirstAnodeName)
        Me.Controls.Add(Me.RadButton_OK)
        Me.Controls.Add(Me.RadButton_Cancel)
        Me.Controls.Add(Me.Panel_Text)
        Me.Controls.Add(Me.Panel_Options)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewScratchDesign"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewScratchDesign_Title"
        Me.ThemeName = "Windows8"
        Me.Panel_Options.ResumeLayout(False)
        Me.Panel_Options.PerformLayout()
        CType(Me.RadCheckBox_UseArchive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_ArchiveDesign, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_Design, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ArchiveDesign, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Design, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton_Wizard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton_Basic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton_PartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton_Outlines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Text.ResumeLayout(False)
        CType(Me.RadLabel_Counter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_OK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_FirstAnodeName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Options As System.Windows.Forms.Panel
    Friend WithEvents Panel_Text As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_Counter As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton_Cancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_OK As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadRadioButton_Outlines As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadRadioButton_Wizard As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadRadioButton_Basic As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadRadioButton_PartNumber As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadLabel_ArchiveDesign As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Design As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_ArchiveDesign As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_Design As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadCheckBox_UseArchive As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadTextBox_FirstAnodeName As Telerik.WinControls.UI.RadTextBox
End Class

