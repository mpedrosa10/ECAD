<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservePartNumber
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReservePartNumber))
        Me.Panel_Header = New System.Windows.Forms.Panel()
        Me.RadButton_Reserve = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox_KemetLogo = New System.Windows.Forms.PictureBox()
        Me.RadLabel_InnerTitle = New Telerik.WinControls.UI.RadLabel()
        Me.RadButton_Cancel = New Telerik.WinControls.UI.RadButton()
        Me.RadTextBox_PartNumber = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_PartNumber = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_User = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_User = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_NSNumber = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_NSNumber = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_DateAllocated = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_DateAllocated = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_CaseSize = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_CaseSize = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Voltage = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Voltage = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Capacitance = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Capacitance = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Range = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Range = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Comments = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Comments = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Specification = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Specification = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Customer = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Customer = New Telerik.WinControls.UI.RadLabel()
        Me.Panel_Header.SuspendLayout()
        CType(Me.RadButton_Reserve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_InnerTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_PartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_User, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_User, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_NSNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_NSNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_DateAllocated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_DateAllocated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CaseSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_CaseSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Voltage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Voltage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Capacitance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Capacitance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Range, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Range, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Comments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Comments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Specification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Specification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Header
        '
        Me.Panel_Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel_Header.Controls.Add(Me.RadButton_Reserve)
        Me.Panel_Header.Controls.Add(Me.PictureBox_KemetLogo)
        Me.Panel_Header.Controls.Add(Me.RadLabel_InnerTitle)
        Me.Panel_Header.Controls.Add(Me.RadButton_Cancel)
        Me.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Header.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Header.Name = "Panel_Header"
        Me.Panel_Header.Size = New System.Drawing.Size(600, 56)
        Me.Panel_Header.TabIndex = 0
        '
        'RadButton_Reserve
        '
        Me.RadButton_Reserve.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_Reserve.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Reserve.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Reserve.Location = New System.Drawing.Point(231, 5)
        Me.RadButton_Reserve.Name = "RadButton_Reserve"
        Me.RadButton_Reserve.Size = New System.Drawing.Size(106, 46)
        Me.RadButton_Reserve.TabIndex = 17
        Me.RadButton_Reserve.Text = "Global_Reserve"
        Me.RadButton_Reserve.TextWrap = True
        '
        'PictureBox_KemetLogo
        '
        Me.PictureBox_KemetLogo.Image = Global.ECAD.My.Resources.Resources.kemet_logo_small
        Me.PictureBox_KemetLogo.Location = New System.Drawing.Point(458, 0)
        Me.PictureBox_KemetLogo.Name = "PictureBox_KemetLogo"
        Me.PictureBox_KemetLogo.Size = New System.Drawing.Size(128, 56)
        Me.PictureBox_KemetLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_KemetLogo.TabIndex = 16
        Me.PictureBox_KemetLogo.TabStop = False
        '
        'RadLabel_InnerTitle
        '
        Me.RadLabel_InnerTitle.AutoSize = False
        Me.RadLabel_InnerTitle.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_InnerTitle.Location = New System.Drawing.Point(5, 5)
        Me.RadLabel_InnerTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_InnerTitle.Name = "RadLabel_InnerTitle"
        Me.RadLabel_InnerTitle.Size = New System.Drawing.Size(235, 46)
        Me.RadLabel_InnerTitle.TabIndex = 15
        Me.RadLabel_InnerTitle.Text = "ReservePN_InnerTitle"
        Me.RadLabel_InnerTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadButton_Cancel
        '
        Me.RadButton_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_Cancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Cancel.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Cancel.Location = New System.Drawing.Point(343, 5)
        Me.RadButton_Cancel.Name = "RadButton_Cancel"
        Me.RadButton_Cancel.Size = New System.Drawing.Size(106, 46)
        Me.RadButton_Cancel.TabIndex = 14
        Me.RadButton_Cancel.Text = "Global_Cancel"
        Me.RadButton_Cancel.TextWrap = True
        '
        'RadTextBox_PartNumber
        '
        Me.RadTextBox_PartNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_PartNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.RadTextBox_PartNumber.Location = New System.Drawing.Point(160, 65)
        Me.RadTextBox_PartNumber.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_PartNumber.Name = "RadTextBox_PartNumber"
        '
        '
        '
        Me.RadTextBox_PartNumber.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_PartNumber.Size = New System.Drawing.Size(255, 27)
        Me.RadTextBox_PartNumber.TabIndex = 84
        Me.RadTextBox_PartNumber.Text = "Unbound"
        '
        'RadLabel_PartNumber
        '
        Me.RadLabel_PartNumber.AutoSize = False
        Me.RadLabel_PartNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_PartNumber.ForeColor = System.Drawing.Color.Black
        Me.RadLabel_PartNumber.Location = New System.Drawing.Point(15, 65)
        Me.RadLabel_PartNumber.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_PartNumber.Name = "RadLabel_PartNumber"
        Me.RadLabel_PartNumber.Size = New System.Drawing.Size(140, 27)
        Me.RadLabel_PartNumber.TabIndex = 83
        Me.RadLabel_PartNumber.Text = "Global_PartNumber"
        Me.RadLabel_PartNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_User
        '
        Me.RadTextBox_User.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_User.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.RadTextBox_User.Location = New System.Drawing.Point(160, 95)
        Me.RadTextBox_User.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_User.Name = "RadTextBox_User"
        '
        '
        '
        Me.RadTextBox_User.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_User.Size = New System.Drawing.Size(255, 27)
        Me.RadTextBox_User.TabIndex = 86
        Me.RadTextBox_User.Text = "Unbound"
        '
        'RadLabel_User
        '
        Me.RadLabel_User.AutoSize = False
        Me.RadLabel_User.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_User.ForeColor = System.Drawing.Color.Black
        Me.RadLabel_User.Location = New System.Drawing.Point(15, 95)
        Me.RadLabel_User.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_User.Name = "RadLabel_User"
        Me.RadLabel_User.Size = New System.Drawing.Size(140, 27)
        Me.RadLabel_User.TabIndex = 85
        Me.RadLabel_User.Text = "Global_User"
        Me.RadLabel_User.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_NSNumber
        '
        Me.RadTextBox_NSNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_NSNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.RadTextBox_NSNumber.Location = New System.Drawing.Point(160, 155)
        Me.RadTextBox_NSNumber.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_NSNumber.Name = "RadTextBox_NSNumber"
        '
        '
        '
        Me.RadTextBox_NSNumber.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_NSNumber.Size = New System.Drawing.Size(255, 27)
        Me.RadTextBox_NSNumber.TabIndex = 90
        Me.RadTextBox_NSNumber.Text = "Unbound"
        '
        'RadLabel_NSNumber
        '
        Me.RadLabel_NSNumber.AutoSize = False
        Me.RadLabel_NSNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_NSNumber.ForeColor = System.Drawing.Color.Black
        Me.RadLabel_NSNumber.Location = New System.Drawing.Point(15, 155)
        Me.RadLabel_NSNumber.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_NSNumber.Name = "RadLabel_NSNumber"
        Me.RadLabel_NSNumber.Size = New System.Drawing.Size(140, 27)
        Me.RadLabel_NSNumber.TabIndex = 89
        Me.RadLabel_NSNumber.Text = "Global_NSNumber"
        Me.RadLabel_NSNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_DateAllocated
        '
        Me.RadTextBox_DateAllocated.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_DateAllocated.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.RadTextBox_DateAllocated.Location = New System.Drawing.Point(160, 125)
        Me.RadTextBox_DateAllocated.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_DateAllocated.Name = "RadTextBox_DateAllocated"
        '
        '
        '
        Me.RadTextBox_DateAllocated.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_DateAllocated.Size = New System.Drawing.Size(255, 27)
        Me.RadTextBox_DateAllocated.TabIndex = 88
        Me.RadTextBox_DateAllocated.Text = "Unbound"
        '
        'RadLabel_DateAllocated
        '
        Me.RadLabel_DateAllocated.AutoSize = False
        Me.RadLabel_DateAllocated.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_DateAllocated.ForeColor = System.Drawing.Color.Black
        Me.RadLabel_DateAllocated.Location = New System.Drawing.Point(15, 125)
        Me.RadLabel_DateAllocated.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_DateAllocated.Name = "RadLabel_DateAllocated"
        Me.RadLabel_DateAllocated.Size = New System.Drawing.Size(140, 27)
        Me.RadLabel_DateAllocated.TabIndex = 87
        Me.RadLabel_DateAllocated.Text = "Global_DateAllocated"
        Me.RadLabel_DateAllocated.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_CaseSize
        '
        Me.RadTextBox_CaseSize.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_CaseSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.RadTextBox_CaseSize.Location = New System.Drawing.Point(160, 275)
        Me.RadTextBox_CaseSize.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_CaseSize.Name = "RadTextBox_CaseSize"
        '
        '
        '
        Me.RadTextBox_CaseSize.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_CaseSize.Size = New System.Drawing.Size(255, 27)
        Me.RadTextBox_CaseSize.TabIndex = 98
        Me.RadTextBox_CaseSize.Text = "Unbound"
        '
        'RadLabel_CaseSize
        '
        Me.RadLabel_CaseSize.AutoSize = False
        Me.RadLabel_CaseSize.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_CaseSize.ForeColor = System.Drawing.Color.Black
        Me.RadLabel_CaseSize.Location = New System.Drawing.Point(15, 275)
        Me.RadLabel_CaseSize.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_CaseSize.Name = "RadLabel_CaseSize"
        Me.RadLabel_CaseSize.Size = New System.Drawing.Size(140, 27)
        Me.RadLabel_CaseSize.TabIndex = 97
        Me.RadLabel_CaseSize.Text = "Global_CaseSize"
        Me.RadLabel_CaseSize.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_Voltage
        '
        Me.RadTextBox_Voltage.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_Voltage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.RadTextBox_Voltage.Location = New System.Drawing.Point(160, 245)
        Me.RadTextBox_Voltage.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_Voltage.Name = "RadTextBox_Voltage"
        '
        '
        '
        Me.RadTextBox_Voltage.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Voltage.Size = New System.Drawing.Size(255, 27)
        Me.RadTextBox_Voltage.TabIndex = 96
        Me.RadTextBox_Voltage.Text = "Unbound"
        '
        'RadLabel_Voltage
        '
        Me.RadLabel_Voltage.AutoSize = False
        Me.RadLabel_Voltage.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Voltage.ForeColor = System.Drawing.Color.Black
        Me.RadLabel_Voltage.Location = New System.Drawing.Point(15, 245)
        Me.RadLabel_Voltage.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Voltage.Name = "RadLabel_Voltage"
        Me.RadLabel_Voltage.Size = New System.Drawing.Size(140, 27)
        Me.RadLabel_Voltage.TabIndex = 95
        Me.RadLabel_Voltage.Text = "Global_Voltage"
        Me.RadLabel_Voltage.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_Capacitance
        '
        Me.RadTextBox_Capacitance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_Capacitance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.RadTextBox_Capacitance.Location = New System.Drawing.Point(160, 215)
        Me.RadTextBox_Capacitance.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_Capacitance.Name = "RadTextBox_Capacitance"
        '
        '
        '
        Me.RadTextBox_Capacitance.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Capacitance.Size = New System.Drawing.Size(255, 27)
        Me.RadTextBox_Capacitance.TabIndex = 94
        Me.RadTextBox_Capacitance.Text = "Unbound"
        '
        'RadLabel_Capacitance
        '
        Me.RadLabel_Capacitance.AutoSize = False
        Me.RadLabel_Capacitance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Capacitance.ForeColor = System.Drawing.Color.Black
        Me.RadLabel_Capacitance.Location = New System.Drawing.Point(15, 215)
        Me.RadLabel_Capacitance.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Capacitance.Name = "RadLabel_Capacitance"
        Me.RadLabel_Capacitance.Size = New System.Drawing.Size(140, 27)
        Me.RadLabel_Capacitance.TabIndex = 93
        Me.RadLabel_Capacitance.Text = "Global_Capacitance"
        Me.RadLabel_Capacitance.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_Range
        '
        Me.RadTextBox_Range.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_Range.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.RadTextBox_Range.Location = New System.Drawing.Point(160, 185)
        Me.RadTextBox_Range.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_Range.Name = "RadTextBox_Range"
        '
        '
        '
        Me.RadTextBox_Range.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Range.Size = New System.Drawing.Size(255, 27)
        Me.RadTextBox_Range.TabIndex = 92
        Me.RadTextBox_Range.Text = "Unbound"
        '
        'RadLabel_Range
        '
        Me.RadLabel_Range.AutoSize = False
        Me.RadLabel_Range.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Range.ForeColor = System.Drawing.Color.Black
        Me.RadLabel_Range.Location = New System.Drawing.Point(15, 185)
        Me.RadLabel_Range.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Range.Name = "RadLabel_Range"
        Me.RadLabel_Range.Size = New System.Drawing.Size(140, 27)
        Me.RadLabel_Range.TabIndex = 91
        Me.RadLabel_Range.Text = "Global_Range"
        Me.RadLabel_Range.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_Comments
        '
        Me.RadTextBox_Comments.AutoSize = False
        Me.RadTextBox_Comments.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_Comments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.RadTextBox_Comments.Location = New System.Drawing.Point(160, 365)
        Me.RadTextBox_Comments.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_Comments.Multiline = True
        Me.RadTextBox_Comments.Name = "RadTextBox_Comments"
        '
        '
        '
        Me.RadTextBox_Comments.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Comments.Size = New System.Drawing.Size(255, 70)
        Me.RadTextBox_Comments.TabIndex = 104
        Me.RadTextBox_Comments.Text = "Unbound"
        '
        'RadLabel_Comments
        '
        Me.RadLabel_Comments.AutoSize = False
        Me.RadLabel_Comments.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Comments.ForeColor = System.Drawing.Color.Black
        Me.RadLabel_Comments.Location = New System.Drawing.Point(15, 365)
        Me.RadLabel_Comments.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Comments.Name = "RadLabel_Comments"
        Me.RadLabel_Comments.Size = New System.Drawing.Size(140, 27)
        Me.RadLabel_Comments.TabIndex = 103
        Me.RadLabel_Comments.Text = "Global_Comments"
        Me.RadLabel_Comments.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_Specification
        '
        Me.RadTextBox_Specification.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_Specification.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.RadTextBox_Specification.Location = New System.Drawing.Point(160, 335)
        Me.RadTextBox_Specification.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_Specification.Name = "RadTextBox_Specification"
        '
        '
        '
        Me.RadTextBox_Specification.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Specification.Size = New System.Drawing.Size(255, 27)
        Me.RadTextBox_Specification.TabIndex = 102
        Me.RadTextBox_Specification.Text = "Unbound"
        '
        'RadLabel_Specification
        '
        Me.RadLabel_Specification.AutoSize = False
        Me.RadLabel_Specification.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Specification.ForeColor = System.Drawing.Color.Black
        Me.RadLabel_Specification.Location = New System.Drawing.Point(15, 335)
        Me.RadLabel_Specification.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Specification.Name = "RadLabel_Specification"
        Me.RadLabel_Specification.Size = New System.Drawing.Size(140, 27)
        Me.RadLabel_Specification.TabIndex = 101
        Me.RadLabel_Specification.Text = "Global_Specification"
        Me.RadLabel_Specification.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_Customer
        '
        Me.RadTextBox_Customer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_Customer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.RadTextBox_Customer.Location = New System.Drawing.Point(160, 305)
        Me.RadTextBox_Customer.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_Customer.Name = "RadTextBox_Customer"
        '
        '
        '
        Me.RadTextBox_Customer.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Customer.Size = New System.Drawing.Size(255, 27)
        Me.RadTextBox_Customer.TabIndex = 100
        Me.RadTextBox_Customer.Text = "Unbound"
        '
        'RadLabel_Customer
        '
        Me.RadLabel_Customer.AutoSize = False
        Me.RadLabel_Customer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Customer.ForeColor = System.Drawing.Color.Black
        Me.RadLabel_Customer.Location = New System.Drawing.Point(15, 305)
        Me.RadLabel_Customer.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Customer.Name = "RadLabel_Customer"
        Me.RadLabel_Customer.Size = New System.Drawing.Size(140, 27)
        Me.RadLabel_Customer.TabIndex = 99
        Me.RadLabel_Customer.Text = "Global_Customer"
        Me.RadLabel_Customer.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'ReservePartNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(600, 445)
        Me.Controls.Add(Me.RadTextBox_Comments)
        Me.Controls.Add(Me.RadLabel_Comments)
        Me.Controls.Add(Me.RadTextBox_Specification)
        Me.Controls.Add(Me.RadLabel_Specification)
        Me.Controls.Add(Me.RadTextBox_Customer)
        Me.Controls.Add(Me.RadLabel_Customer)
        Me.Controls.Add(Me.RadTextBox_CaseSize)
        Me.Controls.Add(Me.RadLabel_CaseSize)
        Me.Controls.Add(Me.RadTextBox_Voltage)
        Me.Controls.Add(Me.RadLabel_Voltage)
        Me.Controls.Add(Me.RadTextBox_Capacitance)
        Me.Controls.Add(Me.RadLabel_Capacitance)
        Me.Controls.Add(Me.RadTextBox_Range)
        Me.Controls.Add(Me.RadLabel_Range)
        Me.Controls.Add(Me.RadTextBox_NSNumber)
        Me.Controls.Add(Me.RadLabel_NSNumber)
        Me.Controls.Add(Me.RadTextBox_DateAllocated)
        Me.Controls.Add(Me.RadLabel_DateAllocated)
        Me.Controls.Add(Me.RadTextBox_User)
        Me.Controls.Add(Me.RadLabel_User)
        Me.Controls.Add(Me.RadTextBox_PartNumber)
        Me.Controls.Add(Me.RadLabel_PartNumber)
        Me.Controls.Add(Me.Panel_Header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReservePartNumber"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReservePN_Title"
        Me.ThemeName = "Windows8"
        Me.Panel_Header.ResumeLayout(False)
        CType(Me.RadButton_Reserve, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_InnerTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_PartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_User, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_User, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_NSNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_NSNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_DateAllocated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_DateAllocated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CaseSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_CaseSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Voltage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Voltage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Capacitance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Capacitance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Range, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Range, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Comments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Comments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Specification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Specification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel_Header As System.Windows.Forms.Panel
    Friend WithEvents RadButton_Cancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents PictureBox_KemetLogo As System.Windows.Forms.PictureBox
    Friend WithEvents RadLabel_InnerTitle As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton_Reserve As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadTextBox_PartNumber As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_PartNumber As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_User As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_User As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_NSNumber As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_NSNumber As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_DateAllocated As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_DateAllocated As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_CaseSize As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_CaseSize As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Voltage As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Voltage As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Capacitance As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Capacitance As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Range As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Range As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Comments As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Comments As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Specification As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Specification As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Customer As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Customer As Telerik.WinControls.UI.RadLabel
End Class

