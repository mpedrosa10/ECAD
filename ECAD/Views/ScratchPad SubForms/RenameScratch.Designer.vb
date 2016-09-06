<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RenameScratch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RenameScratch))
        Me.Panel_SourceDesign = New System.Windows.Forms.Panel()
        Me.RadTextBox_volts = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_volts = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_cap = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_CanSize = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_cap = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_CanSize = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Range = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Range = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_ID = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_ID = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_User = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_User = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_PartNumber = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_PartNumber = New Telerik.WinControls.UI.RadLabel()
        Me.Panel_NewDesign = New System.Windows.Forms.Panel()
        Me.RadTextBox_NewName = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_NewRange = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_NewRange = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_NewName = New Telerik.WinControls.UI.RadLabel()
        Me.Panel_NewDesignText = New System.Windows.Forms.Panel()
        Me.RadLabel_NewDesign = New Telerik.WinControls.UI.RadLabel()
        Me.Panel_SourceDesignText = New System.Windows.Forms.Panel()
        Me.RadLabel_SourceDesign = New Telerik.WinControls.UI.RadLabel()
        Me.RadButton_ReserveName = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_RenameorCopy = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_AllocateNewName = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_GetName = New Telerik.WinControls.UI.RadButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadLabel_HelpMessage = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_HelpGuide = New Telerik.WinControls.UI.RadLabel()
        Me.Panel_SourceDesign.SuspendLayout()
        CType(Me.RadTextBox_volts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_volts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_cap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CanSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_cap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_CanSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Range, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Range, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_User, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_User, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_PartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_NewDesign.SuspendLayout()
        CType(Me.RadTextBox_NewName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_NewRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_NewRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_NewName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_NewDesignText.SuspendLayout()
        CType(Me.RadLabel_NewDesign, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_SourceDesignText.SuspendLayout()
        CType(Me.RadLabel_SourceDesign, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_ReserveName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_RenameorCopy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_AllocateNewName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_GetName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.RadLabel_HelpMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadLabel_HelpMessage.SuspendLayout()
        CType(Me.RadLabel_HelpGuide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_SourceDesign
        '
        Me.Panel_SourceDesign.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_SourceDesign.Controls.Add(Me.RadTextBox_volts)
        Me.Panel_SourceDesign.Controls.Add(Me.RadLabel_volts)
        Me.Panel_SourceDesign.Controls.Add(Me.RadTextBox_cap)
        Me.Panel_SourceDesign.Controls.Add(Me.RadTextBox_CanSize)
        Me.Panel_SourceDesign.Controls.Add(Me.RadLabel_cap)
        Me.Panel_SourceDesign.Controls.Add(Me.RadLabel_CanSize)
        Me.Panel_SourceDesign.Controls.Add(Me.RadTextBox_Range)
        Me.Panel_SourceDesign.Controls.Add(Me.RadLabel_Range)
        Me.Panel_SourceDesign.Controls.Add(Me.RadTextBox_ID)
        Me.Panel_SourceDesign.Controls.Add(Me.RadLabel_ID)
        Me.Panel_SourceDesign.Controls.Add(Me.RadTextBox_User)
        Me.Panel_SourceDesign.Controls.Add(Me.RadLabel_User)
        Me.Panel_SourceDesign.Controls.Add(Me.RadTextBox_PartNumber)
        Me.Panel_SourceDesign.Controls.Add(Me.RadLabel_PartNumber)
        Me.Panel_SourceDesign.Location = New System.Drawing.Point(5, 19)
        Me.Panel_SourceDesign.Name = "Panel_SourceDesign"
        Me.Panel_SourceDesign.Size = New System.Drawing.Size(320, 230)
        Me.Panel_SourceDesign.TabIndex = 32
        '
        'RadTextBox_volts
        '
        Me.RadTextBox_volts.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_volts.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_volts.Location = New System.Drawing.Point(123, 196)
        Me.RadTextBox_volts.Name = "RadTextBox_volts"
        Me.RadTextBox_volts.Size = New System.Drawing.Size(185, 25)
        Me.RadTextBox_volts.TabIndex = 107
        Me.RadTextBox_volts.Text = "Unbound"
        '
        'RadLabel_volts
        '
        Me.RadLabel_volts.AutoSize = False
        Me.RadLabel_volts.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_volts.Location = New System.Drawing.Point(6, 196)
        Me.RadLabel_volts.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_volts.Name = "RadLabel_volts"
        Me.RadLabel_volts.Size = New System.Drawing.Size(115, 25)
        Me.RadLabel_volts.TabIndex = 106
        Me.RadLabel_volts.Text = "Global_minvolts"
        Me.RadLabel_volts.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_cap
        '
        Me.RadTextBox_cap.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_cap.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_cap.Location = New System.Drawing.Point(123, 166)
        Me.RadTextBox_cap.Name = "RadTextBox_cap"
        Me.RadTextBox_cap.Size = New System.Drawing.Size(185, 25)
        Me.RadTextBox_cap.TabIndex = 105
        Me.RadTextBox_cap.Text = "Unbound"
        '
        'RadTextBox_CanSize
        '
        Me.RadTextBox_CanSize.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_CanSize.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_CanSize.Location = New System.Drawing.Point(123, 106)
        Me.RadTextBox_CanSize.Name = "RadTextBox_CanSize"
        Me.RadTextBox_CanSize.Size = New System.Drawing.Size(185, 25)
        Me.RadTextBox_CanSize.TabIndex = 101
        Me.RadTextBox_CanSize.Text = "Unbound"
        '
        'RadLabel_cap
        '
        Me.RadLabel_cap.AutoSize = False
        Me.RadLabel_cap.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_cap.Location = New System.Drawing.Point(6, 166)
        Me.RadLabel_cap.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_cap.Name = "RadLabel_cap"
        Me.RadLabel_cap.Size = New System.Drawing.Size(115, 25)
        Me.RadLabel_cap.TabIndex = 104
        Me.RadLabel_cap.Text = "RenameScratch_cap"
        Me.RadLabel_cap.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_CanSize
        '
        Me.RadLabel_CanSize.AutoSize = False
        Me.RadLabel_CanSize.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_CanSize.Location = New System.Drawing.Point(6, 106)
        Me.RadLabel_CanSize.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_CanSize.Name = "RadLabel_CanSize"
        Me.RadLabel_CanSize.Size = New System.Drawing.Size(115, 25)
        Me.RadLabel_CanSize.TabIndex = 100
        Me.RadLabel_CanSize.Text = "Global_CanSize"
        Me.RadLabel_CanSize.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_Range
        '
        Me.RadTextBox_Range.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Range.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Range.Location = New System.Drawing.Point(123, 136)
        Me.RadTextBox_Range.Name = "RadTextBox_Range"
        Me.RadTextBox_Range.Size = New System.Drawing.Size(185, 25)
        Me.RadTextBox_Range.TabIndex = 103
        Me.RadTextBox_Range.Text = "Unbound"
        '
        'RadLabel_Range
        '
        Me.RadLabel_Range.AutoSize = False
        Me.RadLabel_Range.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Range.Location = New System.Drawing.Point(6, 136)
        Me.RadLabel_Range.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Range.Name = "RadLabel_Range"
        Me.RadLabel_Range.Size = New System.Drawing.Size(115, 25)
        Me.RadLabel_Range.TabIndex = 102
        Me.RadLabel_Range.Text = "Global_Range"
        Me.RadLabel_Range.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_ID
        '
        Me.RadTextBox_ID.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_ID.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_ID.Location = New System.Drawing.Point(123, 76)
        Me.RadTextBox_ID.Name = "RadTextBox_ID"
        Me.RadTextBox_ID.Size = New System.Drawing.Size(185, 25)
        Me.RadTextBox_ID.TabIndex = 99
        Me.RadTextBox_ID.Text = "Unbound"
        '
        'RadLabel_ID
        '
        Me.RadLabel_ID.AutoSize = False
        Me.RadLabel_ID.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_ID.Location = New System.Drawing.Point(6, 76)
        Me.RadLabel_ID.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_ID.Name = "RadLabel_ID"
        Me.RadLabel_ID.Size = New System.Drawing.Size(115, 25)
        Me.RadLabel_ID.TabIndex = 98
        Me.RadLabel_ID.Text = "Global_ID"
        Me.RadLabel_ID.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_User
        '
        Me.RadTextBox_User.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_User.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_User.Location = New System.Drawing.Point(123, 46)
        Me.RadTextBox_User.Name = "RadTextBox_User"
        Me.RadTextBox_User.Size = New System.Drawing.Size(185, 25)
        Me.RadTextBox_User.TabIndex = 97
        Me.RadTextBox_User.Text = "Unbound"
        '
        'RadLabel_User
        '
        Me.RadLabel_User.AutoSize = False
        Me.RadLabel_User.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_User.Location = New System.Drawing.Point(6, 46)
        Me.RadLabel_User.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_User.Name = "RadLabel_User"
        Me.RadLabel_User.Size = New System.Drawing.Size(115, 25)
        Me.RadLabel_User.TabIndex = 96
        Me.RadLabel_User.Text = "Global_User"
        Me.RadLabel_User.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_PartNumber
        '
        Me.RadTextBox_PartNumber.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_PartNumber.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_PartNumber.Location = New System.Drawing.Point(123, 16)
        Me.RadTextBox_PartNumber.Name = "RadTextBox_PartNumber"
        Me.RadTextBox_PartNumber.Size = New System.Drawing.Size(185, 25)
        Me.RadTextBox_PartNumber.TabIndex = 95
        Me.RadTextBox_PartNumber.Text = "Unbound"
        '
        'RadLabel_PartNumber
        '
        Me.RadLabel_PartNumber.AutoSize = False
        Me.RadLabel_PartNumber.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_PartNumber.Location = New System.Drawing.Point(6, 16)
        Me.RadLabel_PartNumber.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_PartNumber.Name = "RadLabel_PartNumber"
        Me.RadLabel_PartNumber.Size = New System.Drawing.Size(115, 25)
        Me.RadLabel_PartNumber.TabIndex = 94
        Me.RadLabel_PartNumber.Text = "Global_PartNumber"
        Me.RadLabel_PartNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel_NewDesign
        '
        Me.Panel_NewDesign.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_NewDesign.Controls.Add(Me.RadTextBox_NewName)
        Me.Panel_NewDesign.Controls.Add(Me.RadTextBox_NewRange)
        Me.Panel_NewDesign.Controls.Add(Me.RadLabel_NewRange)
        Me.Panel_NewDesign.Controls.Add(Me.RadLabel_NewName)
        Me.Panel_NewDesign.Location = New System.Drawing.Point(331, 19)
        Me.Panel_NewDesign.Name = "Panel_NewDesign"
        Me.Panel_NewDesign.Size = New System.Drawing.Size(312, 78)
        Me.Panel_NewDesign.TabIndex = 34
        '
        'RadTextBox_NewName
        '
        Me.RadTextBox_NewName.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_NewName.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_NewName.Location = New System.Drawing.Point(103, 15)
        Me.RadTextBox_NewName.Name = "RadTextBox_NewName"
        Me.RadTextBox_NewName.Size = New System.Drawing.Size(200, 25)
        Me.RadTextBox_NewName.TabIndex = 97
        Me.RadTextBox_NewName.Text = "Unbound"
        '
        'RadTextBox_NewRange
        '
        Me.RadTextBox_NewRange.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_NewRange.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_NewRange.Location = New System.Drawing.Point(103, 45)
        Me.RadTextBox_NewRange.Name = "RadTextBox_NewRange"
        Me.RadTextBox_NewRange.Size = New System.Drawing.Size(200, 25)
        Me.RadTextBox_NewRange.TabIndex = 98
        Me.RadTextBox_NewRange.Text = "Unbound"
        '
        'RadLabel_NewRange
        '
        Me.RadLabel_NewRange.AutoSize = False
        Me.RadLabel_NewRange.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_NewRange.Location = New System.Drawing.Point(3, 45)
        Me.RadLabel_NewRange.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_NewRange.Name = "RadLabel_NewRange"
        Me.RadLabel_NewRange.Size = New System.Drawing.Size(100, 25)
        Me.RadLabel_NewRange.TabIndex = 103
        Me.RadLabel_NewRange.Text = "Global_Range"
        Me.RadLabel_NewRange.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_NewName
        '
        Me.RadLabel_NewName.AutoSize = False
        Me.RadLabel_NewName.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_NewName.Location = New System.Drawing.Point(3, 15)
        Me.RadLabel_NewName.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_NewName.Name = "RadLabel_NewName"
        Me.RadLabel_NewName.Size = New System.Drawing.Size(100, 25)
        Me.RadLabel_NewName.TabIndex = 96
        Me.RadLabel_NewName.Text = "New Name"
        Me.RadLabel_NewName.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel_NewDesignText
        '
        Me.Panel_NewDesignText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_NewDesignText.Controls.Add(Me.RadLabel_NewDesign)
        Me.Panel_NewDesignText.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Panel_NewDesignText.Location = New System.Drawing.Point(341, 8)
        Me.Panel_NewDesignText.Name = "Panel_NewDesignText"
        Me.Panel_NewDesignText.Size = New System.Drawing.Size(130, 25)
        Me.Panel_NewDesignText.TabIndex = 36
        '
        'RadLabel_NewDesign
        '
        Me.RadLabel_NewDesign.AutoSize = False
        Me.RadLabel_NewDesign.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_NewDesign.Location = New System.Drawing.Point(-2, 0)
        Me.RadLabel_NewDesign.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_NewDesign.Name = "RadLabel_NewDesign"
        Me.RadLabel_NewDesign.Size = New System.Drawing.Size(130, 23)
        Me.RadLabel_NewDesign.TabIndex = 31
        Me.RadLabel_NewDesign.Text = "RenameScratch_NewDesign"
        Me.RadLabel_NewDesign.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_SourceDesignText
        '
        Me.Panel_SourceDesignText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_SourceDesignText.Controls.Add(Me.RadLabel_SourceDesign)
        Me.Panel_SourceDesignText.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Panel_SourceDesignText.Location = New System.Drawing.Point(15, 7)
        Me.Panel_SourceDesignText.Name = "Panel_SourceDesignText"
        Me.Panel_SourceDesignText.Size = New System.Drawing.Size(140, 25)
        Me.Panel_SourceDesignText.TabIndex = 37
        '
        'RadLabel_SourceDesign
        '
        Me.RadLabel_SourceDesign.AutoSize = False
        Me.RadLabel_SourceDesign.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_SourceDesign.Location = New System.Drawing.Point(-2, 0)
        Me.RadLabel_SourceDesign.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_SourceDesign.Name = "RadLabel_SourceDesign"
        Me.RadLabel_SourceDesign.Size = New System.Drawing.Size(140, 23)
        Me.RadLabel_SourceDesign.TabIndex = 31
        Me.RadLabel_SourceDesign.Text = "RenameScratch_SourceDesign"
        Me.RadLabel_SourceDesign.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadButton_ReserveName
        '
        Me.RadButton_ReserveName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_ReserveName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_ReserveName.ForeColor = System.Drawing.Color.Black
        Me.RadButton_ReserveName.Location = New System.Drawing.Point(73, 255)
        Me.RadButton_ReserveName.Name = "RadButton_ReserveName"
        Me.RadButton_ReserveName.Size = New System.Drawing.Size(110, 47)
        Me.RadButton_ReserveName.TabIndex = 38
        Me.RadButton_ReserveName.Text = "RenameScratch_ReserveName"
        Me.RadButton_ReserveName.TextWrap = True
        '
        'RadButton_RenameorCopy
        '
        Me.RadButton_RenameorCopy.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_RenameorCopy.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_RenameorCopy.ForeColor = System.Drawing.Color.Black
        Me.RadButton_RenameorCopy.Location = New System.Drawing.Point(203, 255)
        Me.RadButton_RenameorCopy.Name = "RadButton_RenameorCopy"
        Me.RadButton_RenameorCopy.Size = New System.Drawing.Size(110, 47)
        Me.RadButton_RenameorCopy.TabIndex = 39
        Me.RadButton_RenameorCopy.Text = "RenameScratch_RenameorCopy"
        Me.RadButton_RenameorCopy.TextWrap = True
        '
        'RadButton_AllocateNewName
        '
        Me.RadButton_AllocateNewName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_AllocateNewName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_AllocateNewName.ForeColor = System.Drawing.Color.Black
        Me.RadButton_AllocateNewName.Location = New System.Drawing.Point(333, 255)
        Me.RadButton_AllocateNewName.Name = "RadButton_AllocateNewName"
        Me.RadButton_AllocateNewName.Size = New System.Drawing.Size(110, 47)
        Me.RadButton_AllocateNewName.TabIndex = 40
        Me.RadButton_AllocateNewName.Text = "RenameScratch_AllocateNewName"
        Me.RadButton_AllocateNewName.TextWrap = True
        '
        'RadButton_GetName
        '
        Me.RadButton_GetName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_GetName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_GetName.ForeColor = System.Drawing.Color.Black
        Me.RadButton_GetName.Location = New System.Drawing.Point(463, 255)
        Me.RadButton_GetName.Name = "RadButton_GetName"
        Me.RadButton_GetName.Size = New System.Drawing.Size(110, 47)
        Me.RadButton_GetName.TabIndex = 41
        Me.RadButton_GetName.Text = "RenameScratch_GetName"
        Me.RadButton_GetName.TextWrap = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.RadLabel_HelpMessage)
        Me.Panel1.Location = New System.Drawing.Point(331, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 145)
        Me.Panel1.TabIndex = 42
        '
        'RadLabel_HelpMessage
        '
        Me.RadLabel_HelpMessage.AutoSize = False
        Me.RadLabel_HelpMessage.Controls.Add(Me.RadLabel_HelpGuide)
        Me.RadLabel_HelpMessage.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_HelpMessage.Location = New System.Drawing.Point(-1, 0)
        Me.RadLabel_HelpMessage.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_HelpMessage.Name = "RadLabel_HelpMessage"
        Me.RadLabel_HelpMessage.Size = New System.Drawing.Size(310, 140)
        Me.RadLabel_HelpMessage.TabIndex = 32
        Me.RadLabel_HelpMessage.Text = "Unbound"
        Me.RadLabel_HelpMessage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadLabel_HelpGuide
        '
        Me.RadLabel_HelpGuide.AutoSize = False
        Me.RadLabel_HelpGuide.Font = New System.Drawing.Font("Segoe UI", 24.0!)
        Me.RadLabel_HelpGuide.ForeColor = System.Drawing.Color.Gray
        Me.RadLabel_HelpGuide.Location = New System.Drawing.Point(0, 0)
        Me.RadLabel_HelpGuide.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_HelpGuide.Name = "RadLabel_HelpGuide"
        Me.RadLabel_HelpGuide.Size = New System.Drawing.Size(310, 140)
        Me.RadLabel_HelpGuide.TabIndex = 33
        Me.RadLabel_HelpGuide.Text = "RenameScratch_HelpGuideMessage"
        Me.RadLabel_HelpGuide.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RenameScratch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(648, 308)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RadButton_GetName)
        Me.Controls.Add(Me.RadButton_AllocateNewName)
        Me.Controls.Add(Me.RadButton_RenameorCopy)
        Me.Controls.Add(Me.RadButton_ReserveName)
        Me.Controls.Add(Me.Panel_SourceDesignText)
        Me.Controls.Add(Me.Panel_NewDesignText)
        Me.Controls.Add(Me.Panel_NewDesign)
        Me.Controls.Add(Me.Panel_SourceDesign)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RenameScratch"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RenameScratch_Title"
        Me.ThemeName = "Windows8"
        Me.Panel_SourceDesign.ResumeLayout(False)
        Me.Panel_SourceDesign.PerformLayout()
        CType(Me.RadTextBox_volts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_volts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_cap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CanSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_cap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_CanSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Range, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Range, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_User, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_User, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_PartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_NewDesign.ResumeLayout(False)
        Me.Panel_NewDesign.PerformLayout()
        CType(Me.RadTextBox_NewName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_NewRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_NewRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_NewName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_NewDesignText.ResumeLayout(False)
        CType(Me.RadLabel_NewDesign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_SourceDesignText.ResumeLayout(False)
        CType(Me.RadLabel_SourceDesign, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_ReserveName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_RenameorCopy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_AllocateNewName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_GetName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.RadLabel_HelpMessage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadLabel_HelpMessage.ResumeLayout(False)
        CType(Me.RadLabel_HelpGuide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_SourceDesign As System.Windows.Forms.Panel
    Friend WithEvents Panel_NewDesign As System.Windows.Forms.Panel
    Friend WithEvents Panel_NewDesignText As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_NewDesign As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_SourceDesign As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel_SourceDesignText As System.Windows.Forms.Panel
    Friend WithEvents RadTextBox_PartNumber As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_PartNumber As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_volts As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_volts As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_cap As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_CanSize As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_cap As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_CanSize As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Range As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Range As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_ID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_ID As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_User As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_User As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_NewName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_NewRange As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_NewRange As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_NewName As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton_ReserveName As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_RenameorCopy As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_AllocateNewName As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_GetName As Telerik.WinControls.UI.RadButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_HelpMessage As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_HelpGuide As Telerik.WinControls.UI.RadLabel
End Class

