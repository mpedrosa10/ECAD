<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ElectrolyteData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ElectrolyteData))
        Me.Panel_Header = New System.Windows.Forms.Panel()
        Me.RadButton_WhereUsed = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox_KemetLogo = New System.Windows.Forms.PictureBox()
        Me.RadLabel_Title = New Telerik.WinControls.UI.RadLabel()
        Me.RadCheckBox_Obsolete = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_Active = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadDropDownList_ElectrolyteName = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_ElectrolyteName = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_OracleData = New Telerik.WinControls.UI.RadLabel()
        Me.Panel_OracleData = New System.Windows.Forms.Panel()
        Me.RadCheckBox_BackflushFlag = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel_StagingWarehouse = New Telerik.WinControls.UI.RadLabel()
        Me.RadCheckBox_MultilevelBackflushFlag = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadTextBox_StagingWarehouse = New Telerik.WinControls.UI.RadTextBox()
        Me.RadCheckBox_StagingFlag = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel_BackflushWarehouse = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_FirstOpDC = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_FirstOpAC = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_BackflushWarehouse = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_FirstOpDC = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_FirstOpAC = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_ResistivityAtTemperature = New Telerik.WinControls.UI.RadLabel()
        Me.Panel_ResistivityAtTemperature = New System.Windows.Forms.Panel()
        Me.RadLabel_125CelsiusDegrees = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_125CelsiusDegrees = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_105CelsiusDegrees = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_105CelsiusDegrees = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_85CelsiusDegrees = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_85CelsiusDegrees = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_65CelsiusDegrees = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_65CelsiusDegrees = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_45CelsiusDegrees = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_45CelsiusDegrees = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_25CelsiusDegrees = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_25CelsiusDegrees = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_20CelsiusDegrees = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_20CelsiusDegrees = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_0CelsiusDegrees = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_0CelsiusDegrees = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Minus20CelsiusDegrees = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Minus20CelsiusDegrees = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Minus40CelsiusDegrees = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Minus40CelsiusDegrees = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Minus55CelsiusDegrees = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Minus55CelsiusDegrees = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_MaxVoltageAtVolts = New Telerik.WinControls.UI.RadLabel()
        Me.Panel_MaxVoltageAtVolts = New System.Windows.Forms.Panel()
        Me.RadLabel_MaxV125CelsiusDegrees = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_MaxV125CelsiusDegrees = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_MaxV105CelsiusDegrees = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_MaxV105CelsiusDegrees = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_MaxV85CelsiusDegrees = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_MaxV85CelsiusDegrees = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_MaxV65CelsiusDegrees = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_MaxV65CelsiusDegrees = New Telerik.WinControls.UI.RadTextBox()
        Me.RadCheckBox_Glycol = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel_Class = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Class = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_SpecificGravity = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_SpecificGravity = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_SpecificGravityUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Description = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Description = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Specification = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Specification = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Supplier = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Supplier = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_MSpecNo = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_MSpecNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_CurrentCostBase = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_PreviousCostBase = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_PreviousCostSource = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_PreviousCost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_PreviousCost = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_MatOnly = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_CurrentCostSource = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_CurrentCost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_CurrentCost = New Telerik.WinControls.UI.RadLabel()
        Me.Panel_Header.SuspendLayout()
        CType(Me.RadButton_WhereUsed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_Obsolete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_Active, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_ElectrolyteName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ElectrolyteName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_OracleData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_OracleData.SuspendLayout()
        CType(Me.RadCheckBox_BackflushFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_StagingWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_MultilevelBackflushFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_StagingWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_StagingFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_BackflushWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_FirstOpDC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_FirstOpAC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_BackflushWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_FirstOpDC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_FirstOpAC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ResistivityAtTemperature, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_ResistivityAtTemperature.SuspendLayout()
        CType(Me.RadLabel_125CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_125CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_105CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_105CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_85CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_85CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_65CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_65CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_45CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_45CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_25CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_25CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_20CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_20CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_0CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_0CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Minus20CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Minus20CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Minus40CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Minus40CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Minus55CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Minus55CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_MaxVoltageAtVolts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_MaxVoltageAtVolts.SuspendLayout()
        CType(Me.RadLabel_MaxV125CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_MaxV125CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_MaxV105CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_MaxV105CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_MaxV85CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_MaxV85CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_MaxV65CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_MaxV65CelsiusDegrees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_Glycol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Class, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Class, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_SpecificGravity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_SpecificGravity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_SpecificGravityUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Specification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Specification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_MSpecNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_MSpecNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CurrentCostBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_PreviousCostBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_PreviousCostSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_PreviousCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PreviousCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_MatOnly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CurrentCostSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CurrentCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_CurrentCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Header
        '
        Me.Panel_Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Header.Controls.Add(Me.RadButton_WhereUsed)
        Me.Panel_Header.Controls.Add(Me.PictureBox_KemetLogo)
        Me.Panel_Header.Controls.Add(Me.RadLabel_Title)
        Me.Panel_Header.Location = New System.Drawing.Point(-5, -2)
        Me.Panel_Header.Name = "Panel_Header"
        Me.Panel_Header.Size = New System.Drawing.Size(1049, 68)
        Me.Panel_Header.TabIndex = 4
        '
        'RadButton_WhereUsed
        '
        Me.RadButton_WhereUsed.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_WhereUsed.Location = New System.Drawing.Point(302, 8)
        Me.RadButton_WhereUsed.Name = "RadButton_WhereUsed"
        Me.RadButton_WhereUsed.Size = New System.Drawing.Size(100, 50)
        Me.RadButton_WhereUsed.TabIndex = 12
        Me.RadButton_WhereUsed.Text = "ElecData_WhereUsed"
        Me.RadButton_WhereUsed.TextWrap = True
        Me.RadButton_WhereUsed.ThemeName = "Windows8"
        '
        'PictureBox_KemetLogo
        '
        Me.PictureBox_KemetLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox_KemetLogo.Image = Global.ECAD.My.Resources.Resources.kemet_logo_small
        Me.PictureBox_KemetLogo.Location = New System.Drawing.Point(886, 4)
        Me.PictureBox_KemetLogo.MaximumSize = New System.Drawing.Size(142, 61)
        Me.PictureBox_KemetLogo.Name = "PictureBox_KemetLogo"
        Me.PictureBox_KemetLogo.Size = New System.Drawing.Size(116, 54)
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
        Me.RadLabel_Title.Size = New System.Drawing.Size(282, 68)
        Me.RadLabel_Title.TabIndex = 0
        Me.RadLabel_Title.Text = "ElecData_Title"
        Me.RadLabel_Title.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Title.ThemeName = "Windows8"
        '
        'RadCheckBox_Obsolete
        '
        Me.RadCheckBox_Obsolete.AutoSize = False
        Me.RadCheckBox_Obsolete.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Obsolete.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_Obsolete.Location = New System.Drawing.Point(567, 86)
        Me.RadCheckBox_Obsolete.Name = "RadCheckBox_Obsolete"
        Me.RadCheckBox_Obsolete.Size = New System.Drawing.Size(102, 20)
        Me.RadCheckBox_Obsolete.TabIndex = 57
        Me.RadCheckBox_Obsolete.Text = "ElecData_Obsolete"
        Me.RadCheckBox_Obsolete.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Obsolete.ThemeName = "Windows8"
        '
        'RadCheckBox_Active
        '
        Me.RadCheckBox_Active.AutoSize = False
        Me.RadCheckBox_Active.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Active.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_Active.Location = New System.Drawing.Point(436, 86)
        Me.RadCheckBox_Active.Name = "RadCheckBox_Active"
        Me.RadCheckBox_Active.Size = New System.Drawing.Size(102, 20)
        Me.RadCheckBox_Active.TabIndex = 56
        Me.RadCheckBox_Active.Text = "ElecData_Active"
        Me.RadCheckBox_Active.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Active.ThemeName = "Windows8"
        '
        'RadDropDownList_ElectrolyteName
        '
        Me.RadDropDownList_ElectrolyteName.AutoSize = False
        Me.RadDropDownList_ElectrolyteName.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.RadDropDownList_ElectrolyteName.Location = New System.Drawing.Point(206, 81)
        Me.RadDropDownList_ElectrolyteName.Name = "RadDropDownList_ElectrolyteName"
        Me.RadDropDownList_ElectrolyteName.Size = New System.Drawing.Size(206, 30)
        Me.RadDropDownList_ElectrolyteName.TabIndex = 55
        Me.RadDropDownList_ElectrolyteName.ThemeName = "Windows8"
        '
        'RadLabel_ElectrolyteName
        '
        Me.RadLabel_ElectrolyteName.AutoSize = False
        Me.RadLabel_ElectrolyteName.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.RadLabel_ElectrolyteName.Location = New System.Drawing.Point(22, 81)
        Me.RadLabel_ElectrolyteName.Name = "RadLabel_ElectrolyteName"
        Me.RadLabel_ElectrolyteName.Size = New System.Drawing.Size(178, 30)
        Me.RadLabel_ElectrolyteName.TabIndex = 54
        Me.RadLabel_ElectrolyteName.Text = "ElecData_ElectrolyteName"
        Me.RadLabel_ElectrolyteName.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_ElectrolyteName.TextWrap = False
        Me.RadLabel_ElectrolyteName.ThemeName = "Windows8"
        '
        'RadLabel_OracleData
        '
        Me.RadLabel_OracleData.AutoSize = False
        Me.RadLabel_OracleData.BorderVisible = True
        Me.RadLabel_OracleData.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_OracleData.Location = New System.Drawing.Point(732, 145)
        Me.RadLabel_OracleData.Name = "RadLabel_OracleData"
        Me.RadLabel_OracleData.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_OracleData.TabIndex = 59
        Me.RadLabel_OracleData.Text = "ElecData_OracleData"
        Me.RadLabel_OracleData.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_OracleData.TextWrap = False
        Me.RadLabel_OracleData.ThemeName = "Windows8"
        '
        'Panel_OracleData
        '
        Me.Panel_OracleData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_OracleData.Controls.Add(Me.RadCheckBox_BackflushFlag)
        Me.Panel_OracleData.Controls.Add(Me.RadLabel_StagingWarehouse)
        Me.Panel_OracleData.Controls.Add(Me.RadCheckBox_MultilevelBackflushFlag)
        Me.Panel_OracleData.Controls.Add(Me.RadTextBox_StagingWarehouse)
        Me.Panel_OracleData.Controls.Add(Me.RadCheckBox_StagingFlag)
        Me.Panel_OracleData.Controls.Add(Me.RadLabel_BackflushWarehouse)
        Me.Panel_OracleData.Controls.Add(Me.RadLabel_FirstOpDC)
        Me.Panel_OracleData.Controls.Add(Me.RadLabel_FirstOpAC)
        Me.Panel_OracleData.Controls.Add(Me.RadTextBox_BackflushWarehouse)
        Me.Panel_OracleData.Controls.Add(Me.RadTextBox_FirstOpDC)
        Me.Panel_OracleData.Controls.Add(Me.RadTextBox_FirstOpAC)
        Me.Panel_OracleData.Location = New System.Drawing.Point(715, 161)
        Me.Panel_OracleData.Name = "Panel_OracleData"
        Me.Panel_OracleData.Size = New System.Drawing.Size(284, 258)
        Me.Panel_OracleData.TabIndex = 58
        '
        'RadCheckBox_BackflushFlag
        '
        Me.RadCheckBox_BackflushFlag.AutoSize = False
        Me.RadCheckBox_BackflushFlag.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_BackflushFlag.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_BackflushFlag.Location = New System.Drawing.Point(16, 170)
        Me.RadCheckBox_BackflushFlag.Name = "RadCheckBox_BackflushFlag"
        Me.RadCheckBox_BackflushFlag.Size = New System.Drawing.Size(256, 20)
        Me.RadCheckBox_BackflushFlag.TabIndex = 43
        Me.RadCheckBox_BackflushFlag.Text = "ElecData_BackflushFlag"
        Me.RadCheckBox_BackflushFlag.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_BackflushFlag.ThemeName = "Windows8"
        '
        'RadLabel_StagingWarehouse
        '
        Me.RadLabel_StagingWarehouse.AutoSize = False
        Me.RadLabel_StagingWarehouse.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_StagingWarehouse.Location = New System.Drawing.Point(3, 106)
        Me.RadLabel_StagingWarehouse.Name = "RadLabel_StagingWarehouse"
        Me.RadLabel_StagingWarehouse.Size = New System.Drawing.Size(173, 25)
        Me.RadLabel_StagingWarehouse.TabIndex = 42
        Me.RadLabel_StagingWarehouse.Text = "ElecData_StagingWarehouse"
        Me.RadLabel_StagingWarehouse.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_StagingWarehouse.TextWrap = False
        Me.RadLabel_StagingWarehouse.ThemeName = "Windows8"
        '
        'RadCheckBox_MultilevelBackflushFlag
        '
        Me.RadCheckBox_MultilevelBackflushFlag.AutoSize = False
        Me.RadCheckBox_MultilevelBackflushFlag.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_MultilevelBackflushFlag.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_MultilevelBackflushFlag.Location = New System.Drawing.Point(16, 196)
        Me.RadCheckBox_MultilevelBackflushFlag.Name = "RadCheckBox_MultilevelBackflushFlag"
        Me.RadCheckBox_MultilevelBackflushFlag.Size = New System.Drawing.Size(256, 20)
        Me.RadCheckBox_MultilevelBackflushFlag.TabIndex = 41
        Me.RadCheckBox_MultilevelBackflushFlag.Text = "ElecData_MultilevelBackflushFlag"
        Me.RadCheckBox_MultilevelBackflushFlag.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_MultilevelBackflushFlag.ThemeName = "Windows8"
        '
        'RadTextBox_StagingWarehouse
        '
        Me.RadTextBox_StagingWarehouse.AutoSize = False
        Me.RadTextBox_StagingWarehouse.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_StagingWarehouse.Location = New System.Drawing.Point(182, 106)
        Me.RadTextBox_StagingWarehouse.Name = "RadTextBox_StagingWarehouse"
        Me.RadTextBox_StagingWarehouse.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_StagingWarehouse.TabIndex = 41
        Me.RadTextBox_StagingWarehouse.ThemeName = "Windows8"
        '
        'RadCheckBox_StagingFlag
        '
        Me.RadCheckBox_StagingFlag.AutoSize = False
        Me.RadCheckBox_StagingFlag.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_StagingFlag.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_StagingFlag.Location = New System.Drawing.Point(16, 144)
        Me.RadCheckBox_StagingFlag.Name = "RadCheckBox_StagingFlag"
        Me.RadCheckBox_StagingFlag.Size = New System.Drawing.Size(256, 20)
        Me.RadCheckBox_StagingFlag.TabIndex = 42
        Me.RadCheckBox_StagingFlag.Text = "ElecData_StagingFlag"
        Me.RadCheckBox_StagingFlag.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_StagingFlag.ThemeName = "Windows8"
        '
        'RadLabel_BackflushWarehouse
        '
        Me.RadLabel_BackflushWarehouse.AutoSize = False
        Me.RadLabel_BackflushWarehouse.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_BackflushWarehouse.Location = New System.Drawing.Point(3, 75)
        Me.RadLabel_BackflushWarehouse.Name = "RadLabel_BackflushWarehouse"
        Me.RadLabel_BackflushWarehouse.Size = New System.Drawing.Size(173, 25)
        Me.RadLabel_BackflushWarehouse.TabIndex = 40
        Me.RadLabel_BackflushWarehouse.Text = "ElecData_BackflushWarehouse"
        Me.RadLabel_BackflushWarehouse.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_BackflushWarehouse.TextWrap = False
        Me.RadLabel_BackflushWarehouse.ThemeName = "Windows8"
        '
        'RadLabel_FirstOpDC
        '
        Me.RadLabel_FirstOpDC.AutoSize = False
        Me.RadLabel_FirstOpDC.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_FirstOpDC.Location = New System.Drawing.Point(3, 44)
        Me.RadLabel_FirstOpDC.Name = "RadLabel_FirstOpDC"
        Me.RadLabel_FirstOpDC.Size = New System.Drawing.Size(173, 25)
        Me.RadLabel_FirstOpDC.TabIndex = 39
        Me.RadLabel_FirstOpDC.Text = "ElecData_FirstOpDC"
        Me.RadLabel_FirstOpDC.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_FirstOpDC.TextWrap = False
        Me.RadLabel_FirstOpDC.ThemeName = "Windows8"
        '
        'RadLabel_FirstOpAC
        '
        Me.RadLabel_FirstOpAC.AutoSize = False
        Me.RadLabel_FirstOpAC.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_FirstOpAC.Location = New System.Drawing.Point(3, 13)
        Me.RadLabel_FirstOpAC.Name = "RadLabel_FirstOpAC"
        Me.RadLabel_FirstOpAC.Size = New System.Drawing.Size(173, 25)
        Me.RadLabel_FirstOpAC.TabIndex = 38
        Me.RadLabel_FirstOpAC.Text = "ElecData_FirstOpAC"
        Me.RadLabel_FirstOpAC.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_FirstOpAC.TextWrap = False
        Me.RadLabel_FirstOpAC.ThemeName = "Windows8"
        '
        'RadTextBox_BackflushWarehouse
        '
        Me.RadTextBox_BackflushWarehouse.AutoSize = False
        Me.RadTextBox_BackflushWarehouse.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_BackflushWarehouse.Location = New System.Drawing.Point(182, 75)
        Me.RadTextBox_BackflushWarehouse.Name = "RadTextBox_BackflushWarehouse"
        Me.RadTextBox_BackflushWarehouse.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_BackflushWarehouse.TabIndex = 37
        Me.RadTextBox_BackflushWarehouse.ThemeName = "Windows8"
        '
        'RadTextBox_FirstOpDC
        '
        Me.RadTextBox_FirstOpDC.AutoSize = False
        Me.RadTextBox_FirstOpDC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_FirstOpDC.Location = New System.Drawing.Point(182, 44)
        Me.RadTextBox_FirstOpDC.Name = "RadTextBox_FirstOpDC"
        Me.RadTextBox_FirstOpDC.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_FirstOpDC.TabIndex = 36
        Me.RadTextBox_FirstOpDC.ThemeName = "Windows8"
        '
        'RadTextBox_FirstOpAC
        '
        Me.RadTextBox_FirstOpAC.AutoSize = False
        Me.RadTextBox_FirstOpAC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_FirstOpAC.Location = New System.Drawing.Point(182, 13)
        Me.RadTextBox_FirstOpAC.Name = "RadTextBox_FirstOpAC"
        Me.RadTextBox_FirstOpAC.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_FirstOpAC.TabIndex = 35
        Me.RadTextBox_FirstOpAC.ThemeName = "Windows8"
        '
        'RadLabel_ResistivityAtTemperature
        '
        Me.RadLabel_ResistivityAtTemperature.AutoSize = False
        Me.RadLabel_ResistivityAtTemperature.BorderVisible = True
        Me.RadLabel_ResistivityAtTemperature.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_ResistivityAtTemperature.Location = New System.Drawing.Point(376, 145)
        Me.RadLabel_ResistivityAtTemperature.Name = "RadLabel_ResistivityAtTemperature"
        Me.RadLabel_ResistivityAtTemperature.Size = New System.Drawing.Size(293, 25)
        Me.RadLabel_ResistivityAtTemperature.TabIndex = 61
        Me.RadLabel_ResistivityAtTemperature.Text = "ElecData_ResistivityAtTemperature"
        Me.RadLabel_ResistivityAtTemperature.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_ResistivityAtTemperature.TextWrap = False
        Me.RadLabel_ResistivityAtTemperature.ThemeName = "Windows8"
        '
        'Panel_ResistivityAtTemperature
        '
        Me.Panel_ResistivityAtTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_ResistivityAtTemperature.Controls.Add(Me.RadLabel_125CelsiusDegrees)
        Me.Panel_ResistivityAtTemperature.Controls.Add(Me.RadTextBox_125CelsiusDegrees)
        Me.Panel_ResistivityAtTemperature.Controls.Add(Me.RadLabel_105CelsiusDegrees)
        Me.Panel_ResistivityAtTemperature.Controls.Add(Me.RadTextBox_105CelsiusDegrees)
        Me.Panel_ResistivityAtTemperature.Controls.Add(Me.RadLabel_85CelsiusDegrees)
        Me.Panel_ResistivityAtTemperature.Controls.Add(Me.RadTextBox_85CelsiusDegrees)
        Me.Panel_ResistivityAtTemperature.Controls.Add(Me.RadLabel_65CelsiusDegrees)
        Me.Panel_ResistivityAtTemperature.Controls.Add(Me.RadTextBox_65CelsiusDegrees)
        Me.Panel_ResistivityAtTemperature.Controls.Add(Me.RadLabel_45CelsiusDegrees)
        Me.Panel_ResistivityAtTemperature.Controls.Add(Me.RadTextBox_45CelsiusDegrees)
        Me.Panel_ResistivityAtTemperature.Controls.Add(Me.RadLabel_25CelsiusDegrees)
        Me.Panel_ResistivityAtTemperature.Controls.Add(Me.RadTextBox_25CelsiusDegrees)
        Me.Panel_ResistivityAtTemperature.Controls.Add(Me.RadLabel_20CelsiusDegrees)
        Me.Panel_ResistivityAtTemperature.Controls.Add(Me.RadTextBox_20CelsiusDegrees)
        Me.Panel_ResistivityAtTemperature.Controls.Add(Me.RadLabel_0CelsiusDegrees)
        Me.Panel_ResistivityAtTemperature.Controls.Add(Me.RadTextBox_0CelsiusDegrees)
        Me.Panel_ResistivityAtTemperature.Controls.Add(Me.RadLabel_Minus20CelsiusDegrees)
        Me.Panel_ResistivityAtTemperature.Controls.Add(Me.RadTextBox_Minus20CelsiusDegrees)
        Me.Panel_ResistivityAtTemperature.Controls.Add(Me.RadLabel_Minus40CelsiusDegrees)
        Me.Panel_ResistivityAtTemperature.Controls.Add(Me.RadTextBox_Minus40CelsiusDegrees)
        Me.Panel_ResistivityAtTemperature.Controls.Add(Me.RadLabel_Minus55CelsiusDegrees)
        Me.Panel_ResistivityAtTemperature.Controls.Add(Me.RadTextBox_Minus55CelsiusDegrees)
        Me.Panel_ResistivityAtTemperature.Location = New System.Drawing.Point(354, 161)
        Me.Panel_ResistivityAtTemperature.Name = "Panel_ResistivityAtTemperature"
        Me.Panel_ResistivityAtTemperature.Size = New System.Drawing.Size(341, 258)
        Me.Panel_ResistivityAtTemperature.TabIndex = 60
        '
        'RadLabel_125CelsiusDegrees
        '
        Me.RadLabel_125CelsiusDegrees.AutoSize = False
        Me.RadLabel_125CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_125CelsiusDegrees.Location = New System.Drawing.Point(176, 200)
        Me.RadLabel_125CelsiusDegrees.Name = "RadLabel_125CelsiusDegrees"
        Me.RadLabel_125CelsiusDegrees.Size = New System.Drawing.Size(64, 25)
        Me.RadLabel_125CelsiusDegrees.TabIndex = 60
        Me.RadLabel_125CelsiusDegrees.Text = "ElecData_125CelsiusDegrees"
        Me.RadLabel_125CelsiusDegrees.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_125CelsiusDegrees.TextWrap = False
        Me.RadLabel_125CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadTextBox_125CelsiusDegrees
        '
        Me.RadTextBox_125CelsiusDegrees.AutoSize = False
        Me.RadTextBox_125CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_125CelsiusDegrees.Location = New System.Drawing.Point(246, 200)
        Me.RadTextBox_125CelsiusDegrees.Name = "RadTextBox_125CelsiusDegrees"
        Me.RadTextBox_125CelsiusDegrees.Size = New System.Drawing.Size(81, 25)
        Me.RadTextBox_125CelsiusDegrees.TabIndex = 59
        Me.RadTextBox_125CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadLabel_105CelsiusDegrees
        '
        Me.RadLabel_105CelsiusDegrees.AutoSize = False
        Me.RadLabel_105CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_105CelsiusDegrees.Location = New System.Drawing.Point(176, 169)
        Me.RadLabel_105CelsiusDegrees.Name = "RadLabel_105CelsiusDegrees"
        Me.RadLabel_105CelsiusDegrees.Size = New System.Drawing.Size(64, 25)
        Me.RadLabel_105CelsiusDegrees.TabIndex = 58
        Me.RadLabel_105CelsiusDegrees.Text = "ElecData_105CelsiusDegrees"
        Me.RadLabel_105CelsiusDegrees.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_105CelsiusDegrees.TextWrap = False
        Me.RadLabel_105CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadTextBox_105CelsiusDegrees
        '
        Me.RadTextBox_105CelsiusDegrees.AutoSize = False
        Me.RadTextBox_105CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_105CelsiusDegrees.Location = New System.Drawing.Point(246, 169)
        Me.RadTextBox_105CelsiusDegrees.Name = "RadTextBox_105CelsiusDegrees"
        Me.RadTextBox_105CelsiusDegrees.Size = New System.Drawing.Size(81, 25)
        Me.RadTextBox_105CelsiusDegrees.TabIndex = 57
        Me.RadTextBox_105CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadLabel_85CelsiusDegrees
        '
        Me.RadLabel_85CelsiusDegrees.AutoSize = False
        Me.RadLabel_85CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_85CelsiusDegrees.Location = New System.Drawing.Point(176, 138)
        Me.RadLabel_85CelsiusDegrees.Name = "RadLabel_85CelsiusDegrees"
        Me.RadLabel_85CelsiusDegrees.Size = New System.Drawing.Size(64, 25)
        Me.RadLabel_85CelsiusDegrees.TabIndex = 56
        Me.RadLabel_85CelsiusDegrees.Text = "ElecData_85CelsiusDegrees"
        Me.RadLabel_85CelsiusDegrees.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_85CelsiusDegrees.TextWrap = False
        Me.RadLabel_85CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadTextBox_85CelsiusDegrees
        '
        Me.RadTextBox_85CelsiusDegrees.AutoSize = False
        Me.RadTextBox_85CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_85CelsiusDegrees.Location = New System.Drawing.Point(246, 138)
        Me.RadTextBox_85CelsiusDegrees.Name = "RadTextBox_85CelsiusDegrees"
        Me.RadTextBox_85CelsiusDegrees.Size = New System.Drawing.Size(81, 25)
        Me.RadTextBox_85CelsiusDegrees.TabIndex = 55
        Me.RadTextBox_85CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadLabel_65CelsiusDegrees
        '
        Me.RadLabel_65CelsiusDegrees.AutoSize = False
        Me.RadLabel_65CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_65CelsiusDegrees.Location = New System.Drawing.Point(176, 107)
        Me.RadLabel_65CelsiusDegrees.Name = "RadLabel_65CelsiusDegrees"
        Me.RadLabel_65CelsiusDegrees.Size = New System.Drawing.Size(64, 25)
        Me.RadLabel_65CelsiusDegrees.TabIndex = 54
        Me.RadLabel_65CelsiusDegrees.Text = "ElecData_65CelsiusDegrees"
        Me.RadLabel_65CelsiusDegrees.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_65CelsiusDegrees.TextWrap = False
        Me.RadLabel_65CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadTextBox_65CelsiusDegrees
        '
        Me.RadTextBox_65CelsiusDegrees.AutoSize = False
        Me.RadTextBox_65CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_65CelsiusDegrees.Location = New System.Drawing.Point(246, 107)
        Me.RadTextBox_65CelsiusDegrees.Name = "RadTextBox_65CelsiusDegrees"
        Me.RadTextBox_65CelsiusDegrees.Size = New System.Drawing.Size(81, 25)
        Me.RadTextBox_65CelsiusDegrees.TabIndex = 53
        Me.RadTextBox_65CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadLabel_45CelsiusDegrees
        '
        Me.RadLabel_45CelsiusDegrees.AutoSize = False
        Me.RadLabel_45CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_45CelsiusDegrees.Location = New System.Drawing.Point(176, 76)
        Me.RadLabel_45CelsiusDegrees.Name = "RadLabel_45CelsiusDegrees"
        Me.RadLabel_45CelsiusDegrees.Size = New System.Drawing.Size(64, 25)
        Me.RadLabel_45CelsiusDegrees.TabIndex = 52
        Me.RadLabel_45CelsiusDegrees.Text = "ElecData_45CelsiusDegrees"
        Me.RadLabel_45CelsiusDegrees.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_45CelsiusDegrees.TextWrap = False
        Me.RadLabel_45CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadTextBox_45CelsiusDegrees
        '
        Me.RadTextBox_45CelsiusDegrees.AutoSize = False
        Me.RadTextBox_45CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_45CelsiusDegrees.Location = New System.Drawing.Point(246, 76)
        Me.RadTextBox_45CelsiusDegrees.Name = "RadTextBox_45CelsiusDegrees"
        Me.RadTextBox_45CelsiusDegrees.Size = New System.Drawing.Size(81, 25)
        Me.RadTextBox_45CelsiusDegrees.TabIndex = 51
        Me.RadTextBox_45CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadLabel_25CelsiusDegrees
        '
        Me.RadLabel_25CelsiusDegrees.AutoSize = False
        Me.RadLabel_25CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_25CelsiusDegrees.Location = New System.Drawing.Point(176, 45)
        Me.RadLabel_25CelsiusDegrees.Name = "RadLabel_25CelsiusDegrees"
        Me.RadLabel_25CelsiusDegrees.Size = New System.Drawing.Size(64, 25)
        Me.RadLabel_25CelsiusDegrees.TabIndex = 50
        Me.RadLabel_25CelsiusDegrees.Text = "ElecData_25CelsiusDegrees"
        Me.RadLabel_25CelsiusDegrees.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_25CelsiusDegrees.TextWrap = False
        Me.RadLabel_25CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadTextBox_25CelsiusDegrees
        '
        Me.RadTextBox_25CelsiusDegrees.AutoSize = False
        Me.RadTextBox_25CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_25CelsiusDegrees.Location = New System.Drawing.Point(246, 45)
        Me.RadTextBox_25CelsiusDegrees.Name = "RadTextBox_25CelsiusDegrees"
        Me.RadTextBox_25CelsiusDegrees.Size = New System.Drawing.Size(81, 25)
        Me.RadTextBox_25CelsiusDegrees.TabIndex = 49
        Me.RadTextBox_25CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadLabel_20CelsiusDegrees
        '
        Me.RadLabel_20CelsiusDegrees.AutoSize = False
        Me.RadLabel_20CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_20CelsiusDegrees.Location = New System.Drawing.Point(176, 14)
        Me.RadLabel_20CelsiusDegrees.Name = "RadLabel_20CelsiusDegrees"
        Me.RadLabel_20CelsiusDegrees.Size = New System.Drawing.Size(64, 25)
        Me.RadLabel_20CelsiusDegrees.TabIndex = 48
        Me.RadLabel_20CelsiusDegrees.Text = "ElecData_20CelsiusDegrees"
        Me.RadLabel_20CelsiusDegrees.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_20CelsiusDegrees.TextWrap = False
        Me.RadLabel_20CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadTextBox_20CelsiusDegrees
        '
        Me.RadTextBox_20CelsiusDegrees.AutoSize = False
        Me.RadTextBox_20CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_20CelsiusDegrees.Location = New System.Drawing.Point(246, 14)
        Me.RadTextBox_20CelsiusDegrees.Name = "RadTextBox_20CelsiusDegrees"
        Me.RadTextBox_20CelsiusDegrees.Size = New System.Drawing.Size(81, 25)
        Me.RadTextBox_20CelsiusDegrees.TabIndex = 47
        Me.RadTextBox_20CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadLabel_0CelsiusDegrees
        '
        Me.RadLabel_0CelsiusDegrees.AutoSize = False
        Me.RadLabel_0CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_0CelsiusDegrees.Location = New System.Drawing.Point(3, 107)
        Me.RadLabel_0CelsiusDegrees.Name = "RadLabel_0CelsiusDegrees"
        Me.RadLabel_0CelsiusDegrees.Size = New System.Drawing.Size(64, 25)
        Me.RadLabel_0CelsiusDegrees.TabIndex = 46
        Me.RadLabel_0CelsiusDegrees.Text = "ElecData_0CelsiusDegrees"
        Me.RadLabel_0CelsiusDegrees.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_0CelsiusDegrees.TextWrap = False
        Me.RadLabel_0CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadTextBox_0CelsiusDegrees
        '
        Me.RadTextBox_0CelsiusDegrees.AutoSize = False
        Me.RadTextBox_0CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_0CelsiusDegrees.Location = New System.Drawing.Point(73, 107)
        Me.RadTextBox_0CelsiusDegrees.Name = "RadTextBox_0CelsiusDegrees"
        Me.RadTextBox_0CelsiusDegrees.Size = New System.Drawing.Size(81, 25)
        Me.RadTextBox_0CelsiusDegrees.TabIndex = 45
        Me.RadTextBox_0CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadLabel_Minus20CelsiusDegrees
        '
        Me.RadLabel_Minus20CelsiusDegrees.AutoSize = False
        Me.RadLabel_Minus20CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Minus20CelsiusDegrees.Location = New System.Drawing.Point(3, 76)
        Me.RadLabel_Minus20CelsiusDegrees.Name = "RadLabel_Minus20CelsiusDegrees"
        Me.RadLabel_Minus20CelsiusDegrees.Size = New System.Drawing.Size(64, 25)
        Me.RadLabel_Minus20CelsiusDegrees.TabIndex = 44
        Me.RadLabel_Minus20CelsiusDegrees.Text = "ElecData_Minus20CelsiusDegrees"
        Me.RadLabel_Minus20CelsiusDegrees.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Minus20CelsiusDegrees.TextWrap = False
        Me.RadLabel_Minus20CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadTextBox_Minus20CelsiusDegrees
        '
        Me.RadTextBox_Minus20CelsiusDegrees.AutoSize = False
        Me.RadTextBox_Minus20CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Minus20CelsiusDegrees.Location = New System.Drawing.Point(73, 76)
        Me.RadTextBox_Minus20CelsiusDegrees.Name = "RadTextBox_Minus20CelsiusDegrees"
        Me.RadTextBox_Minus20CelsiusDegrees.Size = New System.Drawing.Size(81, 25)
        Me.RadTextBox_Minus20CelsiusDegrees.TabIndex = 43
        Me.RadTextBox_Minus20CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadLabel_Minus40CelsiusDegrees
        '
        Me.RadLabel_Minus40CelsiusDegrees.AutoSize = False
        Me.RadLabel_Minus40CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Minus40CelsiusDegrees.Location = New System.Drawing.Point(3, 45)
        Me.RadLabel_Minus40CelsiusDegrees.Name = "RadLabel_Minus40CelsiusDegrees"
        Me.RadLabel_Minus40CelsiusDegrees.Size = New System.Drawing.Size(64, 25)
        Me.RadLabel_Minus40CelsiusDegrees.TabIndex = 42
        Me.RadLabel_Minus40CelsiusDegrees.Text = "ElecData_Minus40CelsiusDegrees"
        Me.RadLabel_Minus40CelsiusDegrees.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Minus40CelsiusDegrees.TextWrap = False
        Me.RadLabel_Minus40CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadTextBox_Minus40CelsiusDegrees
        '
        Me.RadTextBox_Minus40CelsiusDegrees.AutoSize = False
        Me.RadTextBox_Minus40CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Minus40CelsiusDegrees.Location = New System.Drawing.Point(73, 45)
        Me.RadTextBox_Minus40CelsiusDegrees.Name = "RadTextBox_Minus40CelsiusDegrees"
        Me.RadTextBox_Minus40CelsiusDegrees.Size = New System.Drawing.Size(81, 25)
        Me.RadTextBox_Minus40CelsiusDegrees.TabIndex = 41
        Me.RadTextBox_Minus40CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadLabel_Minus55CelsiusDegrees
        '
        Me.RadLabel_Minus55CelsiusDegrees.AutoSize = False
        Me.RadLabel_Minus55CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Minus55CelsiusDegrees.Location = New System.Drawing.Point(3, 14)
        Me.RadLabel_Minus55CelsiusDegrees.Name = "RadLabel_Minus55CelsiusDegrees"
        Me.RadLabel_Minus55CelsiusDegrees.Size = New System.Drawing.Size(64, 25)
        Me.RadLabel_Minus55CelsiusDegrees.TabIndex = 40
        Me.RadLabel_Minus55CelsiusDegrees.Text = "ElecData_Minus55CelsiusDegrees"
        Me.RadLabel_Minus55CelsiusDegrees.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Minus55CelsiusDegrees.TextWrap = False
        Me.RadLabel_Minus55CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadTextBox_Minus55CelsiusDegrees
        '
        Me.RadTextBox_Minus55CelsiusDegrees.AutoSize = False
        Me.RadTextBox_Minus55CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Minus55CelsiusDegrees.Location = New System.Drawing.Point(73, 14)
        Me.RadTextBox_Minus55CelsiusDegrees.Name = "RadTextBox_Minus55CelsiusDegrees"
        Me.RadTextBox_Minus55CelsiusDegrees.Size = New System.Drawing.Size(81, 25)
        Me.RadTextBox_Minus55CelsiusDegrees.TabIndex = 39
        Me.RadTextBox_Minus55CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadLabel_MaxVoltageAtVolts
        '
        Me.RadLabel_MaxVoltageAtVolts.AutoSize = False
        Me.RadLabel_MaxVoltageAtVolts.BorderVisible = True
        Me.RadLabel_MaxVoltageAtVolts.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MaxVoltageAtVolts.Location = New System.Drawing.Point(560, 439)
        Me.RadLabel_MaxVoltageAtVolts.Name = "RadLabel_MaxVoltageAtVolts"
        Me.RadLabel_MaxVoltageAtVolts.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_MaxVoltageAtVolts.TabIndex = 63
        Me.RadLabel_MaxVoltageAtVolts.Text = "ElecData_MaxVoltageAtVolts"
        Me.RadLabel_MaxVoltageAtVolts.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_MaxVoltageAtVolts.TextWrap = False
        Me.RadLabel_MaxVoltageAtVolts.ThemeName = "Windows8"
        '
        'Panel_MaxVoltageAtVolts
        '
        Me.Panel_MaxVoltageAtVolts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_MaxVoltageAtVolts.Controls.Add(Me.RadLabel_MaxV125CelsiusDegrees)
        Me.Panel_MaxVoltageAtVolts.Controls.Add(Me.RadTextBox_MaxV125CelsiusDegrees)
        Me.Panel_MaxVoltageAtVolts.Controls.Add(Me.RadLabel_MaxV105CelsiusDegrees)
        Me.Panel_MaxVoltageAtVolts.Controls.Add(Me.RadTextBox_MaxV105CelsiusDegrees)
        Me.Panel_MaxVoltageAtVolts.Controls.Add(Me.RadLabel_MaxV85CelsiusDegrees)
        Me.Panel_MaxVoltageAtVolts.Controls.Add(Me.RadTextBox_MaxV85CelsiusDegrees)
        Me.Panel_MaxVoltageAtVolts.Controls.Add(Me.RadLabel_MaxV65CelsiusDegrees)
        Me.Panel_MaxVoltageAtVolts.Controls.Add(Me.RadTextBox_MaxV65CelsiusDegrees)
        Me.Panel_MaxVoltageAtVolts.Location = New System.Drawing.Point(543, 455)
        Me.Panel_MaxVoltageAtVolts.Name = "Panel_MaxVoltageAtVolts"
        Me.Panel_MaxVoltageAtVolts.Size = New System.Drawing.Size(334, 99)
        Me.Panel_MaxVoltageAtVolts.TabIndex = 62
        '
        'RadLabel_MaxV125CelsiusDegrees
        '
        Me.RadLabel_MaxV125CelsiusDegrees.AutoSize = False
        Me.RadLabel_MaxV125CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MaxV125CelsiusDegrees.Location = New System.Drawing.Point(176, 55)
        Me.RadLabel_MaxV125CelsiusDegrees.Name = "RadLabel_MaxV125CelsiusDegrees"
        Me.RadLabel_MaxV125CelsiusDegrees.Size = New System.Drawing.Size(64, 25)
        Me.RadLabel_MaxV125CelsiusDegrees.TabIndex = 58
        Me.RadLabel_MaxV125CelsiusDegrees.Text = "ElecData_MaxV125CelsiusDegrees"
        Me.RadLabel_MaxV125CelsiusDegrees.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_MaxV125CelsiusDegrees.TextWrap = False
        Me.RadLabel_MaxV125CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadTextBox_MaxV125CelsiusDegrees
        '
        Me.RadTextBox_MaxV125CelsiusDegrees.AutoSize = False
        Me.RadTextBox_MaxV125CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_MaxV125CelsiusDegrees.Location = New System.Drawing.Point(246, 55)
        Me.RadTextBox_MaxV125CelsiusDegrees.Name = "RadTextBox_MaxV125CelsiusDegrees"
        Me.RadTextBox_MaxV125CelsiusDegrees.Size = New System.Drawing.Size(81, 25)
        Me.RadTextBox_MaxV125CelsiusDegrees.TabIndex = 57
        Me.RadTextBox_MaxV125CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadLabel_MaxV105CelsiusDegrees
        '
        Me.RadLabel_MaxV105CelsiusDegrees.AutoSize = False
        Me.RadLabel_MaxV105CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MaxV105CelsiusDegrees.Location = New System.Drawing.Point(176, 24)
        Me.RadLabel_MaxV105CelsiusDegrees.Name = "RadLabel_MaxV105CelsiusDegrees"
        Me.RadLabel_MaxV105CelsiusDegrees.Size = New System.Drawing.Size(64, 25)
        Me.RadLabel_MaxV105CelsiusDegrees.TabIndex = 56
        Me.RadLabel_MaxV105CelsiusDegrees.Text = "ElecData_MaxV105CelsiusDegrees"
        Me.RadLabel_MaxV105CelsiusDegrees.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_MaxV105CelsiusDegrees.TextWrap = False
        Me.RadLabel_MaxV105CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadTextBox_MaxV105CelsiusDegrees
        '
        Me.RadTextBox_MaxV105CelsiusDegrees.AutoSize = False
        Me.RadTextBox_MaxV105CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_MaxV105CelsiusDegrees.Location = New System.Drawing.Point(246, 24)
        Me.RadTextBox_MaxV105CelsiusDegrees.Name = "RadTextBox_MaxV105CelsiusDegrees"
        Me.RadTextBox_MaxV105CelsiusDegrees.Size = New System.Drawing.Size(81, 25)
        Me.RadTextBox_MaxV105CelsiusDegrees.TabIndex = 55
        Me.RadTextBox_MaxV105CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadLabel_MaxV85CelsiusDegrees
        '
        Me.RadLabel_MaxV85CelsiusDegrees.AutoSize = False
        Me.RadLabel_MaxV85CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MaxV85CelsiusDegrees.Location = New System.Drawing.Point(3, 55)
        Me.RadLabel_MaxV85CelsiusDegrees.Name = "RadLabel_MaxV85CelsiusDegrees"
        Me.RadLabel_MaxV85CelsiusDegrees.Size = New System.Drawing.Size(64, 25)
        Me.RadLabel_MaxV85CelsiusDegrees.TabIndex = 54
        Me.RadLabel_MaxV85CelsiusDegrees.Text = "ElecData_MaxV85CelsiusDegrees"
        Me.RadLabel_MaxV85CelsiusDegrees.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_MaxV85CelsiusDegrees.TextWrap = False
        Me.RadLabel_MaxV85CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadTextBox_MaxV85CelsiusDegrees
        '
        Me.RadTextBox_MaxV85CelsiusDegrees.AutoSize = False
        Me.RadTextBox_MaxV85CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_MaxV85CelsiusDegrees.Location = New System.Drawing.Point(73, 55)
        Me.RadTextBox_MaxV85CelsiusDegrees.Name = "RadTextBox_MaxV85CelsiusDegrees"
        Me.RadTextBox_MaxV85CelsiusDegrees.Size = New System.Drawing.Size(81, 25)
        Me.RadTextBox_MaxV85CelsiusDegrees.TabIndex = 53
        Me.RadTextBox_MaxV85CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadLabel_MaxV65CelsiusDegrees
        '
        Me.RadLabel_MaxV65CelsiusDegrees.AutoSize = False
        Me.RadLabel_MaxV65CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MaxV65CelsiusDegrees.Location = New System.Drawing.Point(3, 24)
        Me.RadLabel_MaxV65CelsiusDegrees.Name = "RadLabel_MaxV65CelsiusDegrees"
        Me.RadLabel_MaxV65CelsiusDegrees.Size = New System.Drawing.Size(64, 25)
        Me.RadLabel_MaxV65CelsiusDegrees.TabIndex = 52
        Me.RadLabel_MaxV65CelsiusDegrees.Text = "ElecData_MaxV65CelsiusDegrees"
        Me.RadLabel_MaxV65CelsiusDegrees.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_MaxV65CelsiusDegrees.TextWrap = False
        Me.RadLabel_MaxV65CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadTextBox_MaxV65CelsiusDegrees
        '
        Me.RadTextBox_MaxV65CelsiusDegrees.AutoSize = False
        Me.RadTextBox_MaxV65CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_MaxV65CelsiusDegrees.Location = New System.Drawing.Point(73, 24)
        Me.RadTextBox_MaxV65CelsiusDegrees.Name = "RadTextBox_MaxV65CelsiusDegrees"
        Me.RadTextBox_MaxV65CelsiusDegrees.Size = New System.Drawing.Size(81, 25)
        Me.RadTextBox_MaxV65CelsiusDegrees.TabIndex = 51
        Me.RadTextBox_MaxV65CelsiusDegrees.ThemeName = "Windows8"
        '
        'RadCheckBox_Glycol
        '
        Me.RadCheckBox_Glycol.AutoSize = False
        Me.RadCheckBox_Glycol.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Glycol.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_Glycol.Location = New System.Drawing.Point(56, 147)
        Me.RadCheckBox_Glycol.Name = "RadCheckBox_Glycol"
        Me.RadCheckBox_Glycol.Size = New System.Drawing.Size(100, 20)
        Me.RadCheckBox_Glycol.TabIndex = 64
        Me.RadCheckBox_Glycol.Text = "ElecData_Glycol"
        Me.RadCheckBox_Glycol.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Glycol.ThemeName = "Windows8"
        '
        'RadLabel_Class
        '
        Me.RadLabel_Class.AutoSize = False
        Me.RadLabel_Class.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Class.Location = New System.Drawing.Point(-9, 173)
        Me.RadLabel_Class.Name = "RadLabel_Class"
        Me.RadLabel_Class.Size = New System.Drawing.Size(143, 25)
        Me.RadLabel_Class.TabIndex = 66
        Me.RadLabel_Class.Text = "ElecData_Class"
        Me.RadLabel_Class.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Class.TextWrap = False
        Me.RadLabel_Class.ThemeName = "Windows8"
        '
        'RadTextBox_Class
        '
        Me.RadTextBox_Class.AutoSize = False
        Me.RadTextBox_Class.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Class.Location = New System.Drawing.Point(140, 173)
        Me.RadTextBox_Class.Name = "RadTextBox_Class"
        Me.RadTextBox_Class.Size = New System.Drawing.Size(36, 25)
        Me.RadTextBox_Class.TabIndex = 65
        Me.RadTextBox_Class.ThemeName = "Windows8"
        '
        'RadLabel_SpecificGravity
        '
        Me.RadLabel_SpecificGravity.AutoSize = False
        Me.RadLabel_SpecificGravity.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_SpecificGravity.Location = New System.Drawing.Point(-9, 204)
        Me.RadLabel_SpecificGravity.Name = "RadLabel_SpecificGravity"
        Me.RadLabel_SpecificGravity.Size = New System.Drawing.Size(143, 25)
        Me.RadLabel_SpecificGravity.TabIndex = 68
        Me.RadLabel_SpecificGravity.Text = "ElecData_SpecificGravity"
        Me.RadLabel_SpecificGravity.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_SpecificGravity.TextWrap = False
        Me.RadLabel_SpecificGravity.ThemeName = "Windows8"
        '
        'RadTextBox_SpecificGravity
        '
        Me.RadTextBox_SpecificGravity.AutoSize = False
        Me.RadTextBox_SpecificGravity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_SpecificGravity.Location = New System.Drawing.Point(140, 204)
        Me.RadTextBox_SpecificGravity.Name = "RadTextBox_SpecificGravity"
        Me.RadTextBox_SpecificGravity.Size = New System.Drawing.Size(81, 25)
        Me.RadTextBox_SpecificGravity.TabIndex = 67
        Me.RadTextBox_SpecificGravity.ThemeName = "Windows8"
        '
        'RadLabel_SpecificGravityUnit
        '
        Me.RadLabel_SpecificGravityUnit.AutoSize = False
        Me.RadLabel_SpecificGravityUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_SpecificGravityUnit.Location = New System.Drawing.Point(227, 204)
        Me.RadLabel_SpecificGravityUnit.Name = "RadLabel_SpecificGravityUnit"
        Me.RadLabel_SpecificGravityUnit.Size = New System.Drawing.Size(81, 25)
        Me.RadLabel_SpecificGravityUnit.TabIndex = 69
        Me.RadLabel_SpecificGravityUnit.Text = "Unit_GramPerCubicCm"
        Me.RadLabel_SpecificGravityUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_SpecificGravityUnit.TextWrap = False
        Me.RadLabel_SpecificGravityUnit.ThemeName = "Windows8"
        '
        'RadLabel_Description
        '
        Me.RadLabel_Description.AutoSize = False
        Me.RadLabel_Description.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Description.Location = New System.Drawing.Point(-9, 269)
        Me.RadLabel_Description.Name = "RadLabel_Description"
        Me.RadLabel_Description.Size = New System.Drawing.Size(143, 25)
        Me.RadLabel_Description.TabIndex = 71
        Me.RadLabel_Description.Text = "ElecData_Description"
        Me.RadLabel_Description.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Description.TextWrap = False
        Me.RadLabel_Description.ThemeName = "Windows8"
        '
        'RadTextBox_Description
        '
        Me.RadTextBox_Description.AutoSize = False
        Me.RadTextBox_Description.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Description.Location = New System.Drawing.Point(140, 269)
        Me.RadTextBox_Description.Multiline = True
        Me.RadTextBox_Description.Name = "RadTextBox_Description"
        Me.RadTextBox_Description.Size = New System.Drawing.Size(191, 83)
        Me.RadTextBox_Description.TabIndex = 70
        Me.RadTextBox_Description.ThemeName = "Windows8"
        '
        'RadLabel_Specification
        '
        Me.RadLabel_Specification.AutoSize = False
        Me.RadLabel_Specification.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Specification.Location = New System.Drawing.Point(25, 362)
        Me.RadLabel_Specification.Name = "RadLabel_Specification"
        Me.RadLabel_Specification.Size = New System.Drawing.Size(109, 25)
        Me.RadLabel_Specification.TabIndex = 73
        Me.RadLabel_Specification.Text = "ElecData_Specification"
        Me.RadLabel_Specification.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Specification.TextWrap = False
        Me.RadLabel_Specification.ThemeName = "Windows8"
        '
        'RadTextBox_Specification
        '
        Me.RadTextBox_Specification.AutoSize = False
        Me.RadTextBox_Specification.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Specification.Location = New System.Drawing.Point(140, 362)
        Me.RadTextBox_Specification.Name = "RadTextBox_Specification"
        Me.RadTextBox_Specification.Size = New System.Drawing.Size(191, 25)
        Me.RadTextBox_Specification.TabIndex = 72
        Me.RadTextBox_Specification.ThemeName = "Windows8"
        '
        'RadLabel_Supplier
        '
        Me.RadLabel_Supplier.AutoSize = False
        Me.RadLabel_Supplier.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Supplier.Location = New System.Drawing.Point(25, 394)
        Me.RadLabel_Supplier.Name = "RadLabel_Supplier"
        Me.RadLabel_Supplier.Size = New System.Drawing.Size(109, 25)
        Me.RadLabel_Supplier.TabIndex = 75
        Me.RadLabel_Supplier.Text = "ElecData_Supplier"
        Me.RadLabel_Supplier.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Supplier.TextWrap = False
        Me.RadLabel_Supplier.ThemeName = "Windows8"
        '
        'RadTextBox_Supplier
        '
        Me.RadTextBox_Supplier.AutoSize = False
        Me.RadTextBox_Supplier.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Supplier.Location = New System.Drawing.Point(140, 394)
        Me.RadTextBox_Supplier.Name = "RadTextBox_Supplier"
        Me.RadTextBox_Supplier.Size = New System.Drawing.Size(191, 25)
        Me.RadTextBox_Supplier.TabIndex = 74
        Me.RadTextBox_Supplier.ThemeName = "Windows8"
        '
        'RadLabel_MSpecNo
        '
        Me.RadLabel_MSpecNo.AutoSize = False
        Me.RadLabel_MSpecNo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MSpecNo.Location = New System.Drawing.Point(25, 425)
        Me.RadLabel_MSpecNo.Name = "RadLabel_MSpecNo"
        Me.RadLabel_MSpecNo.Size = New System.Drawing.Size(109, 25)
        Me.RadLabel_MSpecNo.TabIndex = 77
        Me.RadLabel_MSpecNo.Text = "ElecData_MSpecNo"
        Me.RadLabel_MSpecNo.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_MSpecNo.TextWrap = False
        Me.RadLabel_MSpecNo.ThemeName = "Windows8"
        '
        'RadTextBox_MSpecNo
        '
        Me.RadTextBox_MSpecNo.AutoSize = False
        Me.RadTextBox_MSpecNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_MSpecNo.Location = New System.Drawing.Point(140, 425)
        Me.RadTextBox_MSpecNo.Name = "RadTextBox_MSpecNo"
        Me.RadTextBox_MSpecNo.Size = New System.Drawing.Size(133, 25)
        Me.RadTextBox_MSpecNo.TabIndex = 76
        Me.RadTextBox_MSpecNo.ThemeName = "Windows8"
        '
        'RadTextBox_CurrentCostBase
        '
        Me.RadTextBox_CurrentCostBase.AutoSize = False
        Me.RadTextBox_CurrentCostBase.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_CurrentCostBase.Location = New System.Drawing.Point(362, 479)
        Me.RadTextBox_CurrentCostBase.Name = "RadTextBox_CurrentCostBase"
        Me.RadTextBox_CurrentCostBase.Size = New System.Drawing.Size(126, 25)
        Me.RadTextBox_CurrentCostBase.TabIndex = 91
        Me.RadTextBox_CurrentCostBase.ThemeName = "Windows8"
        '
        'RadTextBox_PreviousCostBase
        '
        Me.RadTextBox_PreviousCostBase.AutoSize = False
        Me.RadTextBox_PreviousCostBase.Enabled = False
        Me.RadTextBox_PreviousCostBase.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_PreviousCostBase.Location = New System.Drawing.Point(362, 510)
        Me.RadTextBox_PreviousCostBase.Name = "RadTextBox_PreviousCostBase"
        Me.RadTextBox_PreviousCostBase.Size = New System.Drawing.Size(126, 25)
        Me.RadTextBox_PreviousCostBase.TabIndex = 96
        Me.RadTextBox_PreviousCostBase.ThemeName = "Windows8"
        '
        'RadTextBox_PreviousCostSource
        '
        Me.RadTextBox_PreviousCostSource.AutoSize = False
        Me.RadTextBox_PreviousCostSource.Enabled = False
        Me.RadTextBox_PreviousCostSource.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_PreviousCostSource.Location = New System.Drawing.Point(251, 511)
        Me.RadTextBox_PreviousCostSource.Name = "RadTextBox_PreviousCostSource"
        Me.RadTextBox_PreviousCostSource.Size = New System.Drawing.Size(105, 25)
        Me.RadTextBox_PreviousCostSource.TabIndex = 95
        Me.RadTextBox_PreviousCostSource.ThemeName = "Windows8"
        '
        'RadTextBox_PreviousCost
        '
        Me.RadTextBox_PreviousCost.AutoSize = False
        Me.RadTextBox_PreviousCost.Enabled = False
        Me.RadTextBox_PreviousCost.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_PreviousCost.Location = New System.Drawing.Point(140, 511)
        Me.RadTextBox_PreviousCost.Name = "RadTextBox_PreviousCost"
        Me.RadTextBox_PreviousCost.Size = New System.Drawing.Size(105, 25)
        Me.RadTextBox_PreviousCost.TabIndex = 94
        Me.RadTextBox_PreviousCost.ThemeName = "Windows8"
        '
        'RadLabel_PreviousCost
        '
        Me.RadLabel_PreviousCost.AutoSize = False
        Me.RadLabel_PreviousCost.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_PreviousCost.Location = New System.Drawing.Point(-1, 511)
        Me.RadLabel_PreviousCost.Name = "RadLabel_PreviousCost"
        Me.RadLabel_PreviousCost.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_PreviousCost.TabIndex = 93
        Me.RadLabel_PreviousCost.Text = "ElecData_PreviousCost"
        Me.RadLabel_PreviousCost.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_PreviousCost.TextWrap = False
        Me.RadLabel_PreviousCost.ThemeName = "Windows8"
        '
        'RadLabel_MatOnly
        '
        Me.RadLabel_MatOnly.AutoSize = False
        Me.RadLabel_MatOnly.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_MatOnly.Location = New System.Drawing.Point(362, 455)
        Me.RadLabel_MatOnly.Name = "RadLabel_MatOnly"
        Me.RadLabel_MatOnly.Size = New System.Drawing.Size(126, 25)
        Me.RadLabel_MatOnly.TabIndex = 92
        Me.RadLabel_MatOnly.Text = "ElecData_MatOnly"
        Me.RadLabel_MatOnly.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_MatOnly.TextWrap = False
        Me.RadLabel_MatOnly.ThemeName = "Windows8"
        '
        'RadTextBox_CurrentCostSource
        '
        Me.RadTextBox_CurrentCostSource.AutoSize = False
        Me.RadTextBox_CurrentCostSource.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_CurrentCostSource.Location = New System.Drawing.Point(251, 480)
        Me.RadTextBox_CurrentCostSource.Name = "RadTextBox_CurrentCostSource"
        Me.RadTextBox_CurrentCostSource.Size = New System.Drawing.Size(105, 25)
        Me.RadTextBox_CurrentCostSource.TabIndex = 90
        Me.RadTextBox_CurrentCostSource.ThemeName = "Windows8"
        '
        'RadTextBox_CurrentCost
        '
        Me.RadTextBox_CurrentCost.AutoSize = False
        Me.RadTextBox_CurrentCost.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_CurrentCost.Location = New System.Drawing.Point(140, 480)
        Me.RadTextBox_CurrentCost.Name = "RadTextBox_CurrentCost"
        Me.RadTextBox_CurrentCost.Size = New System.Drawing.Size(105, 25)
        Me.RadTextBox_CurrentCost.TabIndex = 89
        Me.RadTextBox_CurrentCost.ThemeName = "Windows8"
        '
        'RadLabel_CurrentCost
        '
        Me.RadLabel_CurrentCost.AutoSize = False
        Me.RadLabel_CurrentCost.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_CurrentCost.Location = New System.Drawing.Point(-1, 480)
        Me.RadLabel_CurrentCost.Name = "RadLabel_CurrentCost"
        Me.RadLabel_CurrentCost.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_CurrentCost.TabIndex = 88
        Me.RadLabel_CurrentCost.Text = "ElecData_CurrentCost"
        Me.RadLabel_CurrentCost.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_CurrentCost.TextWrap = False
        Me.RadLabel_CurrentCost.ThemeName = "Windows8"
        '
        'ElectrolyteData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1036, 577)
        Me.Controls.Add(Me.RadTextBox_CurrentCostBase)
        Me.Controls.Add(Me.RadTextBox_PreviousCostBase)
        Me.Controls.Add(Me.RadTextBox_PreviousCostSource)
        Me.Controls.Add(Me.RadTextBox_PreviousCost)
        Me.Controls.Add(Me.RadLabel_PreviousCost)
        Me.Controls.Add(Me.RadLabel_MatOnly)
        Me.Controls.Add(Me.RadTextBox_CurrentCostSource)
        Me.Controls.Add(Me.RadTextBox_CurrentCost)
        Me.Controls.Add(Me.RadLabel_CurrentCost)
        Me.Controls.Add(Me.RadLabel_MSpecNo)
        Me.Controls.Add(Me.RadTextBox_MSpecNo)
        Me.Controls.Add(Me.RadLabel_Supplier)
        Me.Controls.Add(Me.RadTextBox_Supplier)
        Me.Controls.Add(Me.RadLabel_Specification)
        Me.Controls.Add(Me.RadTextBox_Specification)
        Me.Controls.Add(Me.RadLabel_Description)
        Me.Controls.Add(Me.RadTextBox_Description)
        Me.Controls.Add(Me.RadLabel_SpecificGravityUnit)
        Me.Controls.Add(Me.RadLabel_SpecificGravity)
        Me.Controls.Add(Me.RadTextBox_SpecificGravity)
        Me.Controls.Add(Me.RadLabel_Class)
        Me.Controls.Add(Me.RadTextBox_Class)
        Me.Controls.Add(Me.RadCheckBox_Glycol)
        Me.Controls.Add(Me.RadLabel_MaxVoltageAtVolts)
        Me.Controls.Add(Me.Panel_MaxVoltageAtVolts)
        Me.Controls.Add(Me.RadLabel_ResistivityAtTemperature)
        Me.Controls.Add(Me.Panel_ResistivityAtTemperature)
        Me.Controls.Add(Me.RadLabel_OracleData)
        Me.Controls.Add(Me.Panel_OracleData)
        Me.Controls.Add(Me.RadCheckBox_Obsolete)
        Me.Controls.Add(Me.RadCheckBox_Active)
        Me.Controls.Add(Me.RadDropDownList_ElectrolyteName)
        Me.Controls.Add(Me.RadLabel_ElectrolyteName)
        Me.Controls.Add(Me.Panel_Header)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ElectrolyteData"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "ElecData_TitleWindow"
        Me.ThemeName = "Windows8"
        Me.Panel_Header.ResumeLayout(False)
        CType(Me.RadButton_WhereUsed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_Obsolete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_Active, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_ElectrolyteName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ElectrolyteName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_OracleData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_OracleData.ResumeLayout(False)
        CType(Me.RadCheckBox_BackflushFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_StagingWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_MultilevelBackflushFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_StagingWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_StagingFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_BackflushWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_FirstOpDC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_FirstOpAC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_BackflushWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_FirstOpDC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_FirstOpAC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ResistivityAtTemperature, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_ResistivityAtTemperature.ResumeLayout(False)
        CType(Me.RadLabel_125CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_125CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_105CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_105CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_85CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_85CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_65CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_65CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_45CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_45CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_25CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_25CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_20CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_20CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_0CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_0CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Minus20CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Minus20CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Minus40CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Minus40CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Minus55CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Minus55CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_MaxVoltageAtVolts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_MaxVoltageAtVolts.ResumeLayout(False)
        CType(Me.RadLabel_MaxV125CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_MaxV125CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_MaxV105CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_MaxV105CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_MaxV85CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_MaxV85CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_MaxV65CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_MaxV65CelsiusDegrees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_Glycol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Class, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Class, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_SpecificGravity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_SpecificGravity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_SpecificGravityUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Description, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Description, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Specification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Specification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_MSpecNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_MSpecNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CurrentCostBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_PreviousCostBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_PreviousCostSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_PreviousCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PreviousCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_MatOnly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CurrentCostSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CurrentCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_CurrentCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Header As System.Windows.Forms.Panel
    Friend WithEvents RadButton_WhereUsed As Telerik.WinControls.UI.RadButton
    Friend WithEvents PictureBox_KemetLogo As System.Windows.Forms.PictureBox
    Friend WithEvents RadLabel_Title As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadCheckBox_Obsolete As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_Active As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadDropDownList_ElectrolyteName As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_ElectrolyteName As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_OracleData As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel_OracleData As System.Windows.Forms.Panel
    Friend WithEvents RadCheckBox_BackflushFlag As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel_StagingWarehouse As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadCheckBox_MultilevelBackflushFlag As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadTextBox_StagingWarehouse As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadCheckBox_StagingFlag As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel_BackflushWarehouse As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_FirstOpDC As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_FirstOpAC As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_BackflushWarehouse As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_FirstOpDC As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_FirstOpAC As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_ResistivityAtTemperature As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel_ResistivityAtTemperature As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_Minus55CelsiusDegrees As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Minus55CelsiusDegrees As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_125CelsiusDegrees As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_125CelsiusDegrees As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_105CelsiusDegrees As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_105CelsiusDegrees As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_85CelsiusDegrees As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_85CelsiusDegrees As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_65CelsiusDegrees As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_65CelsiusDegrees As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_45CelsiusDegrees As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_45CelsiusDegrees As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_25CelsiusDegrees As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_25CelsiusDegrees As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_20CelsiusDegrees As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_20CelsiusDegrees As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_0CelsiusDegrees As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_0CelsiusDegrees As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Minus20CelsiusDegrees As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Minus20CelsiusDegrees As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Minus40CelsiusDegrees As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Minus40CelsiusDegrees As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_MaxVoltageAtVolts As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel_MaxVoltageAtVolts As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_MaxV125CelsiusDegrees As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_MaxV125CelsiusDegrees As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_MaxV105CelsiusDegrees As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_MaxV105CelsiusDegrees As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_MaxV85CelsiusDegrees As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_MaxV85CelsiusDegrees As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_MaxV65CelsiusDegrees As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_MaxV65CelsiusDegrees As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadCheckBox_Glycol As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel_Class As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Class As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_SpecificGravity As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_SpecificGravity As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_SpecificGravityUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Description As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Description As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Specification As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Specification As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Supplier As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Supplier As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_MSpecNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_MSpecNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_CurrentCostBase As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_PreviousCostBase As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_PreviousCostSource As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_PreviousCost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_PreviousCost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_MatOnly As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_CurrentCostSource As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_CurrentCost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_CurrentCost As Telerik.WinControls.UI.RadLabel
End Class

