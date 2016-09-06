<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnodeData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnodeData))
        Me.Panel_Header = New System.Windows.Forms.Panel()
        Me.RadButton_WhereUsedThisFoil = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_WhereUsedThisFoilAndVoltage = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_ShowAllFoils = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_JustThisVoltage = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_JustThisFoilType = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox_KemetLogo = New System.Windows.Forms.PictureBox()
        Me.RadLabel_Title = New Telerik.WinControls.UI.RadLabel()
        Me.RadCheckBox_Obsolete = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_Active = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadDropDownList_AnodeName = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_AnodeName = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Anode = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Anode = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_OracleData = New Telerik.WinControls.UI.RadLabel()
        Me.Panel_OracleData = New System.Windows.Forms.Panel()
        Me.RadLabel_ShrinkPercentage = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_ShrinkPercentage = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_RateCode = New Telerik.WinControls.UI.RadTextBox()
        Me.RadCheckBox_MultilevelBackflushFlag = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_BackflushFlag = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_StagingFlag = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel_BackflushWarehouse = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_StagingWarehouse = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_FirstOp = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_BackflushWarehouse = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_StagingWarehouse = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_FirstOp = New Telerik.WinControls.UI.RadTextBox()
        Me.RadCheckBox_Purchased = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel_TestData = New Telerik.WinControls.UI.RadLabel()
        Me.Panel_TestData = New System.Windows.Forms.Panel()
        Me.RadButton_AddStdVals = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel_MaxACPFChange = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_MaxACPFChange = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_MaxACPF = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_MaxACPF = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_MaxBoil = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_MaxRise = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_MaxBoil = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_MaxRise = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_MinFV = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_MinFV = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_MaxTD = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_MaxTD = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_GainVar = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_MaxGain = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_MinGain = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_GainVar = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_MaxGain = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_MinGain = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Formation = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Formation = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_FormationUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_OxideFactorUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_OxideFactor = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_OxideFactor = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_PurityUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Purity = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Purity = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_AreaWeightRatioUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_AreaWeightRatio = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_AreaWeightRatio = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_ThicknessUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Thickness = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Thickness = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_GainUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Gain = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Gain = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_ResistanceUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Resistance = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Resistance = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Description = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Description = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_CurrentCostBase = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_PreviousCostBase = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_PreviousCostSource = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_PreviousCost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_PreviousCost = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_MatOnly = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_CurrentCostSource = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_CurrentCost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_CurrentCost = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_MSpecNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_MSpecNo = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Supplier = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Supplier = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Specification = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabe_Specification = New Telerik.WinControls.UI.RadLabel()
        Me.Panel_Header.SuspendLayout()
        CType(Me.RadButton_WhereUsedThisFoil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_WhereUsedThisFoilAndVoltage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_ShowAllFoils, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_JustThisVoltage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_JustThisFoilType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_Obsolete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_Active, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_AnodeName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_AnodeName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Anode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Anode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_OracleData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_OracleData.SuspendLayout()
        CType(Me.RadLabel_ShrinkPercentage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ShrinkPercentage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_RateCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_MultilevelBackflushFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_BackflushFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_StagingFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_BackflushWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_StagingWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_FirstOp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_BackflushWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_StagingWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_FirstOp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_Purchased, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TestData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_TestData.SuspendLayout()
        CType(Me.RadButton_AddStdVals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_MaxACPFChange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_MaxACPFChange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_MaxACPF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_MaxACPF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_MaxBoil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_MaxRise, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_MaxBoil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_MaxRise, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_MinFV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_MinFV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_MaxTD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_MaxTD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_GainVar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_MaxGain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_MinGain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_GainVar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_MaxGain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_MinGain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Formation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Formation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_FormationUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_OxideFactorUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_OxideFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_OxideFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PurityUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Purity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Purity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_AreaWeightRatioUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_AreaWeightRatio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_AreaWeightRatio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ThicknessUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Thickness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Thickness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_GainUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Gain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Gain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ResistanceUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Resistance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Resistance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CurrentCostBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_PreviousCostBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_PreviousCostSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_PreviousCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PreviousCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_MatOnly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CurrentCostSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CurrentCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_CurrentCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_MSpecNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_MSpecNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Specification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabe_Specification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Header
        '
        Me.Panel_Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Header.Controls.Add(Me.RadButton_WhereUsedThisFoil)
        Me.Panel_Header.Controls.Add(Me.RadButton_WhereUsedThisFoilAndVoltage)
        Me.Panel_Header.Controls.Add(Me.RadButton_ShowAllFoils)
        Me.Panel_Header.Controls.Add(Me.RadButton_JustThisVoltage)
        Me.Panel_Header.Controls.Add(Me.RadButton_JustThisFoilType)
        Me.Panel_Header.Controls.Add(Me.PictureBox_KemetLogo)
        Me.Panel_Header.Controls.Add(Me.RadLabel_Title)
        Me.Panel_Header.Location = New System.Drawing.Point(-5, -2)
        Me.Panel_Header.Name = "Panel_Header"
        Me.Panel_Header.Size = New System.Drawing.Size(1158, 68)
        Me.Panel_Header.TabIndex = 5
        '
        'RadButton_WhereUsedThisFoil
        '
        Me.RadButton_WhereUsedThisFoil.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_WhereUsedThisFoil.Location = New System.Drawing.Point(760, 8)
        Me.RadButton_WhereUsedThisFoil.Name = "RadButton_WhereUsedThisFoil"
        Me.RadButton_WhereUsedThisFoil.Size = New System.Drawing.Size(110, 50)
        Me.RadButton_WhereUsedThisFoil.TabIndex = 16
        Me.RadButton_WhereUsedThisFoil.Text = "AnodeData_WhereUsedThisFoil"
        Me.RadButton_WhereUsedThisFoil.TextWrap = True
        Me.RadButton_WhereUsedThisFoil.ThemeName = "Windows8"
        '
        'RadButton_WhereUsedThisFoilAndVoltage
        '
        Me.RadButton_WhereUsedThisFoilAndVoltage.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_WhereUsedThisFoilAndVoltage.Location = New System.Drawing.Point(610, 8)
        Me.RadButton_WhereUsedThisFoilAndVoltage.Name = "RadButton_WhereUsedThisFoilAndVoltage"
        Me.RadButton_WhereUsedThisFoilAndVoltage.Size = New System.Drawing.Size(130, 50)
        Me.RadButton_WhereUsedThisFoilAndVoltage.TabIndex = 15
        Me.RadButton_WhereUsedThisFoilAndVoltage.Text = "AnodeData_WhereUsedThisFoilAndVoltage"
        Me.RadButton_WhereUsedThisFoilAndVoltage.TextWrap = True
        Me.RadButton_WhereUsedThisFoilAndVoltage.ThemeName = "Windows8"
        '
        'RadButton_ShowAllFoils
        '
        Me.RadButton_ShowAllFoils.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_ShowAllFoils.Location = New System.Drawing.Point(490, 8)
        Me.RadButton_ShowAllFoils.Name = "RadButton_ShowAllFoils"
        Me.RadButton_ShowAllFoils.Size = New System.Drawing.Size(100, 50)
        Me.RadButton_ShowAllFoils.TabIndex = 14
        Me.RadButton_ShowAllFoils.Text = "AnodeData_ShowAllFoils"
        Me.RadButton_ShowAllFoils.TextWrap = True
        Me.RadButton_ShowAllFoils.ThemeName = "Windows8"
        '
        'RadButton_JustThisVoltage
        '
        Me.RadButton_JustThisVoltage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_JustThisVoltage.Location = New System.Drawing.Point(370, 8)
        Me.RadButton_JustThisVoltage.Name = "RadButton_JustThisVoltage"
        Me.RadButton_JustThisVoltage.Size = New System.Drawing.Size(100, 50)
        Me.RadButton_JustThisVoltage.TabIndex = 13
        Me.RadButton_JustThisVoltage.Text = "AnodeData_JustThisVoltage"
        Me.RadButton_JustThisVoltage.TextWrap = True
        Me.RadButton_JustThisVoltage.ThemeName = "Windows8"
        '
        'RadButton_JustThisFoilType
        '
        Me.RadButton_JustThisFoilType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_JustThisFoilType.Location = New System.Drawing.Point(250, 8)
        Me.RadButton_JustThisFoilType.Name = "RadButton_JustThisFoilType"
        Me.RadButton_JustThisFoilType.Size = New System.Drawing.Size(100, 50)
        Me.RadButton_JustThisFoilType.TabIndex = 12
        Me.RadButton_JustThisFoilType.Text = "AnodeData_JustThisFoilType"
        Me.RadButton_JustThisFoilType.TextWrap = True
        Me.RadButton_JustThisFoilType.ThemeName = "Windows8"
        '
        'PictureBox_KemetLogo
        '
        Me.PictureBox_KemetLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox_KemetLogo.Image = Global.ECAD.My.Resources.Resources.kemet_logo_small
        Me.PictureBox_KemetLogo.Location = New System.Drawing.Point(993, 4)
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
        Me.RadLabel_Title.Size = New System.Drawing.Size(209, 68)
        Me.RadLabel_Title.TabIndex = 0
        Me.RadLabel_Title.Text = "AnodeData_Title"
        Me.RadLabel_Title.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Title.TextWrap = False
        Me.RadLabel_Title.ThemeName = "Windows8"
        '
        'RadCheckBox_Obsolete
        '
        Me.RadCheckBox_Obsolete.AutoSize = False
        Me.RadCheckBox_Obsolete.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Obsolete.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_Obsolete.Location = New System.Drawing.Point(567, 89)
        Me.RadCheckBox_Obsolete.Name = "RadCheckBox_Obsolete"
        Me.RadCheckBox_Obsolete.Size = New System.Drawing.Size(102, 20)
        Me.RadCheckBox_Obsolete.TabIndex = 97
        Me.RadCheckBox_Obsolete.Text = "AnodeData_Obsolete"
        Me.RadCheckBox_Obsolete.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Obsolete.ThemeName = "Windows8"
        '
        'RadCheckBox_Active
        '
        Me.RadCheckBox_Active.AutoSize = False
        Me.RadCheckBox_Active.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Active.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_Active.Location = New System.Drawing.Point(436, 89)
        Me.RadCheckBox_Active.Name = "RadCheckBox_Active"
        Me.RadCheckBox_Active.Size = New System.Drawing.Size(102, 20)
        Me.RadCheckBox_Active.TabIndex = 96
        Me.RadCheckBox_Active.Text = "AnodeData_Active"
        Me.RadCheckBox_Active.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Active.ThemeName = "Windows8"
        '
        'RadDropDownList_AnodeName
        '
        Me.RadDropDownList_AnodeName.AutoSize = False
        Me.RadDropDownList_AnodeName.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.RadDropDownList_AnodeName.Location = New System.Drawing.Point(178, 84)
        Me.RadDropDownList_AnodeName.Name = "RadDropDownList_AnodeName"
        Me.RadDropDownList_AnodeName.Size = New System.Drawing.Size(234, 30)
        Me.RadDropDownList_AnodeName.TabIndex = 95
        Me.RadDropDownList_AnodeName.ThemeName = "Windows8"
        '
        'RadLabel_AnodeName
        '
        Me.RadLabel_AnodeName.AutoSize = False
        Me.RadLabel_AnodeName.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.RadLabel_AnodeName.Location = New System.Drawing.Point(22, 84)
        Me.RadLabel_AnodeName.Name = "RadLabel_AnodeName"
        Me.RadLabel_AnodeName.Size = New System.Drawing.Size(150, 30)
        Me.RadLabel_AnodeName.TabIndex = 94
        Me.RadLabel_AnodeName.Text = "AnodeData_AnodeName"
        Me.RadLabel_AnodeName.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_AnodeName.TextWrap = False
        Me.RadLabel_AnodeName.ThemeName = "Windows8"
        '
        'RadTextBox_Anode
        '
        Me.RadTextBox_Anode.AutoSize = False
        Me.RadTextBox_Anode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Anode.Location = New System.Drawing.Point(1045, 91)
        Me.RadTextBox_Anode.Name = "RadTextBox_Anode"
        Me.RadTextBox_Anode.Size = New System.Drawing.Size(77, 15)
        Me.RadTextBox_Anode.TabIndex = 133
        Me.RadTextBox_Anode.ThemeName = "Windows8"
        '
        'RadLabel_Anode
        '
        Me.RadLabel_Anode.AutoSize = False
        Me.RadLabel_Anode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel_Anode.Location = New System.Drawing.Point(953, 91)
        Me.RadLabel_Anode.Name = "RadLabel_Anode"
        Me.RadLabel_Anode.Size = New System.Drawing.Size(86, 15)
        Me.RadLabel_Anode.TabIndex = 132
        Me.RadLabel_Anode.Text = "AnodeData_Anode"
        Me.RadLabel_Anode.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Anode.TextWrap = False
        Me.RadLabel_Anode.ThemeName = "Windows8"
        '
        'RadLabel_OracleData
        '
        Me.RadLabel_OracleData.AutoSize = False
        Me.RadLabel_OracleData.BorderVisible = True
        Me.RadLabel_OracleData.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_OracleData.Location = New System.Drawing.Point(850, 132)
        Me.RadLabel_OracleData.Name = "RadLabel_OracleData"
        Me.RadLabel_OracleData.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_OracleData.TabIndex = 135
        Me.RadLabel_OracleData.Text = "AnodeData_OracleData"
        Me.RadLabel_OracleData.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_OracleData.TextWrap = False
        Me.RadLabel_OracleData.ThemeName = "Windows8"
        '
        'Panel_OracleData
        '
        Me.Panel_OracleData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_OracleData.Controls.Add(Me.RadLabel_ShrinkPercentage)
        Me.Panel_OracleData.Controls.Add(Me.RadTextBox_ShrinkPercentage)
        Me.Panel_OracleData.Controls.Add(Me.RadLabel1)
        Me.Panel_OracleData.Controls.Add(Me.RadTextBox_RateCode)
        Me.Panel_OracleData.Controls.Add(Me.RadCheckBox_MultilevelBackflushFlag)
        Me.Panel_OracleData.Controls.Add(Me.RadCheckBox_BackflushFlag)
        Me.Panel_OracleData.Controls.Add(Me.RadCheckBox_StagingFlag)
        Me.Panel_OracleData.Controls.Add(Me.RadLabel_BackflushWarehouse)
        Me.Panel_OracleData.Controls.Add(Me.RadLabel_StagingWarehouse)
        Me.Panel_OracleData.Controls.Add(Me.RadLabel_FirstOp)
        Me.Panel_OracleData.Controls.Add(Me.RadTextBox_BackflushWarehouse)
        Me.Panel_OracleData.Controls.Add(Me.RadTextBox_StagingWarehouse)
        Me.Panel_OracleData.Controls.Add(Me.RadTextBox_FirstOp)
        Me.Panel_OracleData.Location = New System.Drawing.Point(833, 148)
        Me.Panel_OracleData.Name = "Panel_OracleData"
        Me.Panel_OracleData.Size = New System.Drawing.Size(287, 319)
        Me.Panel_OracleData.TabIndex = 134
        '
        'RadLabel_ShrinkPercentage
        '
        Me.RadLabel_ShrinkPercentage.AutoSize = False
        Me.RadLabel_ShrinkPercentage.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_ShrinkPercentage.Location = New System.Drawing.Point(3, 137)
        Me.RadLabel_ShrinkPercentage.Name = "RadLabel_ShrinkPercentage"
        Me.RadLabel_ShrinkPercentage.Size = New System.Drawing.Size(173, 25)
        Me.RadLabel_ShrinkPercentage.TabIndex = 137
        Me.RadLabel_ShrinkPercentage.Text = "AnodeData_ShrinkPercentage"
        Me.RadLabel_ShrinkPercentage.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_ShrinkPercentage.TextWrap = False
        Me.RadLabel_ShrinkPercentage.ThemeName = "Windows8"
        '
        'RadTextBox_ShrinkPercentage
        '
        Me.RadTextBox_ShrinkPercentage.AutoSize = False
        Me.RadTextBox_ShrinkPercentage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_ShrinkPercentage.Location = New System.Drawing.Point(182, 137)
        Me.RadTextBox_ShrinkPercentage.Name = "RadTextBox_ShrinkPercentage"
        Me.RadTextBox_ShrinkPercentage.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_ShrinkPercentage.TabIndex = 136
        Me.RadTextBox_ShrinkPercentage.ThemeName = "Windows8"
        '
        'RadLabel1
        '
        Me.RadLabel1.AutoSize = False
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel1.Location = New System.Drawing.Point(3, 106)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(173, 25)
        Me.RadLabel1.TabIndex = 45
        Me.RadLabel1.Text = "AnodeData_RateCode"
        Me.RadLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel1.TextWrap = False
        Me.RadLabel1.ThemeName = "Windows8"
        '
        'RadTextBox_RateCode
        '
        Me.RadTextBox_RateCode.AutoSize = False
        Me.RadTextBox_RateCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_RateCode.Location = New System.Drawing.Point(182, 106)
        Me.RadTextBox_RateCode.Name = "RadTextBox_RateCode"
        Me.RadTextBox_RateCode.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_RateCode.TabIndex = 44
        Me.RadTextBox_RateCode.ThemeName = "Windows8"
        '
        'RadCheckBox_MultilevelBackflushFlag
        '
        Me.RadCheckBox_MultilevelBackflushFlag.AutoSize = False
        Me.RadCheckBox_MultilevelBackflushFlag.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_MultilevelBackflushFlag.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_MultilevelBackflushFlag.Location = New System.Drawing.Point(-14, 249)
        Me.RadCheckBox_MultilevelBackflushFlag.Name = "RadCheckBox_MultilevelBackflushFlag"
        Me.RadCheckBox_MultilevelBackflushFlag.Size = New System.Drawing.Size(248, 20)
        Me.RadCheckBox_MultilevelBackflushFlag.TabIndex = 43
        Me.RadCheckBox_MultilevelBackflushFlag.Text = "AnodeData_MultilevelBackflushFlag"
        Me.RadCheckBox_MultilevelBackflushFlag.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_MultilevelBackflushFlag.ThemeName = "Windows8"
        '
        'RadCheckBox_BackflushFlag
        '
        Me.RadCheckBox_BackflushFlag.AutoSize = False
        Me.RadCheckBox_BackflushFlag.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_BackflushFlag.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_BackflushFlag.Location = New System.Drawing.Point(-22, 218)
        Me.RadCheckBox_BackflushFlag.Name = "RadCheckBox_BackflushFlag"
        Me.RadCheckBox_BackflushFlag.Size = New System.Drawing.Size(256, 20)
        Me.RadCheckBox_BackflushFlag.TabIndex = 42
        Me.RadCheckBox_BackflushFlag.Text = "AnodeData_BackflushFlag"
        Me.RadCheckBox_BackflushFlag.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_BackflushFlag.ThemeName = "Windows8"
        '
        'RadCheckBox_StagingFlag
        '
        Me.RadCheckBox_StagingFlag.AutoSize = False
        Me.RadCheckBox_StagingFlag.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_StagingFlag.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_StagingFlag.Location = New System.Drawing.Point(-22, 187)
        Me.RadCheckBox_StagingFlag.Name = "RadCheckBox_StagingFlag"
        Me.RadCheckBox_StagingFlag.Size = New System.Drawing.Size(256, 20)
        Me.RadCheckBox_StagingFlag.TabIndex = 41
        Me.RadCheckBox_StagingFlag.Text = "AnodeData_StagingFlag"
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
        Me.RadLabel_BackflushWarehouse.Text = "AnodeData_BackflushWarehouse"
        Me.RadLabel_BackflushWarehouse.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_BackflushWarehouse.TextWrap = False
        Me.RadLabel_BackflushWarehouse.ThemeName = "Windows8"
        '
        'RadLabel_StagingWarehouse
        '
        Me.RadLabel_StagingWarehouse.AutoSize = False
        Me.RadLabel_StagingWarehouse.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_StagingWarehouse.Location = New System.Drawing.Point(3, 44)
        Me.RadLabel_StagingWarehouse.Name = "RadLabel_StagingWarehouse"
        Me.RadLabel_StagingWarehouse.Size = New System.Drawing.Size(173, 25)
        Me.RadLabel_StagingWarehouse.TabIndex = 39
        Me.RadLabel_StagingWarehouse.Text = "AnodeData_StagingWarehouse"
        Me.RadLabel_StagingWarehouse.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_StagingWarehouse.TextWrap = False
        Me.RadLabel_StagingWarehouse.ThemeName = "Windows8"
        '
        'RadLabel_FirstOp
        '
        Me.RadLabel_FirstOp.AutoSize = False
        Me.RadLabel_FirstOp.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_FirstOp.Location = New System.Drawing.Point(3, 13)
        Me.RadLabel_FirstOp.Name = "RadLabel_FirstOp"
        Me.RadLabel_FirstOp.Size = New System.Drawing.Size(173, 25)
        Me.RadLabel_FirstOp.TabIndex = 38
        Me.RadLabel_FirstOp.Text = "AnodeData_FirstOp"
        Me.RadLabel_FirstOp.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_FirstOp.TextWrap = False
        Me.RadLabel_FirstOp.ThemeName = "Windows8"
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
        'RadTextBox_StagingWarehouse
        '
        Me.RadTextBox_StagingWarehouse.AutoSize = False
        Me.RadTextBox_StagingWarehouse.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_StagingWarehouse.Location = New System.Drawing.Point(182, 44)
        Me.RadTextBox_StagingWarehouse.Name = "RadTextBox_StagingWarehouse"
        Me.RadTextBox_StagingWarehouse.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_StagingWarehouse.TabIndex = 36
        Me.RadTextBox_StagingWarehouse.ThemeName = "Windows8"
        '
        'RadTextBox_FirstOp
        '
        Me.RadTextBox_FirstOp.AutoSize = False
        Me.RadTextBox_FirstOp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_FirstOp.Location = New System.Drawing.Point(182, 13)
        Me.RadTextBox_FirstOp.Name = "RadTextBox_FirstOp"
        Me.RadTextBox_FirstOp.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_FirstOp.TabIndex = 35
        Me.RadTextBox_FirstOp.ThemeName = "Windows8"
        '
        'RadCheckBox_Purchased
        '
        Me.RadCheckBox_Purchased.AutoSize = False
        Me.RadCheckBox_Purchased.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Purchased.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_Purchased.Location = New System.Drawing.Point(837, 429)
        Me.RadCheckBox_Purchased.Name = "RadCheckBox_Purchased"
        Me.RadCheckBox_Purchased.Size = New System.Drawing.Size(231, 20)
        Me.RadCheckBox_Purchased.TabIndex = 138
        Me.RadCheckBox_Purchased.Text = "AnodeData_Purchased"
        Me.RadCheckBox_Purchased.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Purchased.ThemeName = "Windows8"
        '
        'RadLabel_TestData
        '
        Me.RadLabel_TestData.AutoSize = False
        Me.RadLabel_TestData.BorderVisible = True
        Me.RadLabel_TestData.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_TestData.Location = New System.Drawing.Point(526, 132)
        Me.RadLabel_TestData.Name = "RadLabel_TestData"
        Me.RadLabel_TestData.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_TestData.TabIndex = 140
        Me.RadLabel_TestData.Text = "AnodeData_TestData"
        Me.RadLabel_TestData.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_TestData.TextWrap = False
        Me.RadLabel_TestData.ThemeName = "Windows8"
        '
        'Panel_TestData
        '
        Me.Panel_TestData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_TestData.Controls.Add(Me.RadButton_AddStdVals)
        Me.Panel_TestData.Controls.Add(Me.RadLabel_MaxACPFChange)
        Me.Panel_TestData.Controls.Add(Me.RadTextBox_MaxACPFChange)
        Me.Panel_TestData.Controls.Add(Me.RadLabel_MaxACPF)
        Me.Panel_TestData.Controls.Add(Me.RadTextBox_MaxACPF)
        Me.Panel_TestData.Controls.Add(Me.RadLabel_MaxBoil)
        Me.Panel_TestData.Controls.Add(Me.RadLabel_MaxRise)
        Me.Panel_TestData.Controls.Add(Me.RadTextBox_MaxBoil)
        Me.Panel_TestData.Controls.Add(Me.RadTextBox_MaxRise)
        Me.Panel_TestData.Controls.Add(Me.RadLabel_MinFV)
        Me.Panel_TestData.Controls.Add(Me.RadTextBox_MinFV)
        Me.Panel_TestData.Controls.Add(Me.RadLabel_MaxTD)
        Me.Panel_TestData.Controls.Add(Me.RadTextBox_MaxTD)
        Me.Panel_TestData.Controls.Add(Me.RadLabel_GainVar)
        Me.Panel_TestData.Controls.Add(Me.RadLabel_MaxGain)
        Me.Panel_TestData.Controls.Add(Me.RadLabel_MinGain)
        Me.Panel_TestData.Controls.Add(Me.RadTextBox_GainVar)
        Me.Panel_TestData.Controls.Add(Me.RadTextBox_MaxGain)
        Me.Panel_TestData.Controls.Add(Me.RadTextBox_MinGain)
        Me.Panel_TestData.Location = New System.Drawing.Point(509, 148)
        Me.Panel_TestData.Name = "Panel_TestData"
        Me.Panel_TestData.Size = New System.Drawing.Size(287, 345)
        Me.Panel_TestData.TabIndex = 139
        '
        'RadButton_AddStdVals
        '
        Me.RadButton_AddStdVals.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadButton_AddStdVals.Location = New System.Drawing.Point(16, 292)
        Me.RadButton_AddStdVals.Name = "RadButton_AddStdVals"
        Me.RadButton_AddStdVals.Size = New System.Drawing.Size(256, 44)
        Me.RadButton_AddStdVals.TabIndex = 141
        Me.RadButton_AddStdVals.Text = "AnodeData_AddStdVals"
        Me.RadButton_AddStdVals.TextWrap = True
        Me.RadButton_AddStdVals.ThemeName = "Windows8"
        '
        'RadLabel_MaxACPFChange
        '
        Me.RadLabel_MaxACPFChange.AutoSize = False
        Me.RadLabel_MaxACPFChange.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MaxACPFChange.Location = New System.Drawing.Point(3, 261)
        Me.RadLabel_MaxACPFChange.Name = "RadLabel_MaxACPFChange"
        Me.RadLabel_MaxACPFChange.Size = New System.Drawing.Size(173, 25)
        Me.RadLabel_MaxACPFChange.TabIndex = 145
        Me.RadLabel_MaxACPFChange.Text = "AnodeData_MaxACPFChange"
        Me.RadLabel_MaxACPFChange.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_MaxACPFChange.TextWrap = False
        Me.RadLabel_MaxACPFChange.ThemeName = "Windows8"
        '
        'RadTextBox_MaxACPFChange
        '
        Me.RadTextBox_MaxACPFChange.AutoSize = False
        Me.RadTextBox_MaxACPFChange.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_MaxACPFChange.Location = New System.Drawing.Point(182, 261)
        Me.RadTextBox_MaxACPFChange.Name = "RadTextBox_MaxACPFChange"
        Me.RadTextBox_MaxACPFChange.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_MaxACPFChange.TabIndex = 144
        Me.RadTextBox_MaxACPFChange.ThemeName = "Windows8"
        '
        'RadLabel_MaxACPF
        '
        Me.RadLabel_MaxACPF.AutoSize = False
        Me.RadLabel_MaxACPF.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MaxACPF.Location = New System.Drawing.Point(3, 230)
        Me.RadLabel_MaxACPF.Name = "RadLabel_MaxACPF"
        Me.RadLabel_MaxACPF.Size = New System.Drawing.Size(173, 25)
        Me.RadLabel_MaxACPF.TabIndex = 143
        Me.RadLabel_MaxACPF.Text = "AnodeData_MaxACPF"
        Me.RadLabel_MaxACPF.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_MaxACPF.TextWrap = False
        Me.RadLabel_MaxACPF.ThemeName = "Windows8"
        '
        'RadTextBox_MaxACPF
        '
        Me.RadTextBox_MaxACPF.AutoSize = False
        Me.RadTextBox_MaxACPF.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_MaxACPF.Location = New System.Drawing.Point(182, 230)
        Me.RadTextBox_MaxACPF.Name = "RadTextBox_MaxACPF"
        Me.RadTextBox_MaxACPF.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_MaxACPF.TabIndex = 142
        Me.RadTextBox_MaxACPF.ThemeName = "Windows8"
        '
        'RadLabel_MaxBoil
        '
        Me.RadLabel_MaxBoil.AutoSize = False
        Me.RadLabel_MaxBoil.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MaxBoil.Location = New System.Drawing.Point(3, 199)
        Me.RadLabel_MaxBoil.Name = "RadLabel_MaxBoil"
        Me.RadLabel_MaxBoil.Size = New System.Drawing.Size(173, 25)
        Me.RadLabel_MaxBoil.TabIndex = 141
        Me.RadLabel_MaxBoil.Text = "AnodeData_MaxBoil"
        Me.RadLabel_MaxBoil.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_MaxBoil.TextWrap = False
        Me.RadLabel_MaxBoil.ThemeName = "Windows8"
        '
        'RadLabel_MaxRise
        '
        Me.RadLabel_MaxRise.AutoSize = False
        Me.RadLabel_MaxRise.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MaxRise.Location = New System.Drawing.Point(3, 168)
        Me.RadLabel_MaxRise.Name = "RadLabel_MaxRise"
        Me.RadLabel_MaxRise.Size = New System.Drawing.Size(173, 25)
        Me.RadLabel_MaxRise.TabIndex = 140
        Me.RadLabel_MaxRise.Text = "AnodeData_MaxRise"
        Me.RadLabel_MaxRise.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_MaxRise.TextWrap = False
        Me.RadLabel_MaxRise.ThemeName = "Windows8"
        '
        'RadTextBox_MaxBoil
        '
        Me.RadTextBox_MaxBoil.AutoSize = False
        Me.RadTextBox_MaxBoil.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_MaxBoil.Location = New System.Drawing.Point(182, 199)
        Me.RadTextBox_MaxBoil.Name = "RadTextBox_MaxBoil"
        Me.RadTextBox_MaxBoil.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_MaxBoil.TabIndex = 139
        Me.RadTextBox_MaxBoil.ThemeName = "Windows8"
        '
        'RadTextBox_MaxRise
        '
        Me.RadTextBox_MaxRise.AutoSize = False
        Me.RadTextBox_MaxRise.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_MaxRise.Location = New System.Drawing.Point(182, 168)
        Me.RadTextBox_MaxRise.Name = "RadTextBox_MaxRise"
        Me.RadTextBox_MaxRise.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_MaxRise.TabIndex = 138
        Me.RadTextBox_MaxRise.ThemeName = "Windows8"
        '
        'RadLabel_MinFV
        '
        Me.RadLabel_MinFV.AutoSize = False
        Me.RadLabel_MinFV.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MinFV.Location = New System.Drawing.Point(3, 137)
        Me.RadLabel_MinFV.Name = "RadLabel_MinFV"
        Me.RadLabel_MinFV.Size = New System.Drawing.Size(173, 25)
        Me.RadLabel_MinFV.TabIndex = 137
        Me.RadLabel_MinFV.Text = "AnodeData_MinFV"
        Me.RadLabel_MinFV.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_MinFV.TextWrap = False
        Me.RadLabel_MinFV.ThemeName = "Windows8"
        '
        'RadTextBox_MinFV
        '
        Me.RadTextBox_MinFV.AutoSize = False
        Me.RadTextBox_MinFV.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_MinFV.Location = New System.Drawing.Point(182, 137)
        Me.RadTextBox_MinFV.Name = "RadTextBox_MinFV"
        Me.RadTextBox_MinFV.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_MinFV.TabIndex = 136
        Me.RadTextBox_MinFV.ThemeName = "Windows8"
        '
        'RadLabel_MaxTD
        '
        Me.RadLabel_MaxTD.AutoSize = False
        Me.RadLabel_MaxTD.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MaxTD.Location = New System.Drawing.Point(3, 106)
        Me.RadLabel_MaxTD.Name = "RadLabel_MaxTD"
        Me.RadLabel_MaxTD.Size = New System.Drawing.Size(173, 25)
        Me.RadLabel_MaxTD.TabIndex = 45
        Me.RadLabel_MaxTD.Text = "AnodeData_MaxTD"
        Me.RadLabel_MaxTD.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_MaxTD.TextWrap = False
        Me.RadLabel_MaxTD.ThemeName = "Windows8"
        '
        'RadTextBox_MaxTD
        '
        Me.RadTextBox_MaxTD.AutoSize = False
        Me.RadTextBox_MaxTD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_MaxTD.Location = New System.Drawing.Point(182, 106)
        Me.RadTextBox_MaxTD.Name = "RadTextBox_MaxTD"
        Me.RadTextBox_MaxTD.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_MaxTD.TabIndex = 44
        Me.RadTextBox_MaxTD.ThemeName = "Windows8"
        '
        'RadLabel_GainVar
        '
        Me.RadLabel_GainVar.AutoSize = False
        Me.RadLabel_GainVar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_GainVar.Location = New System.Drawing.Point(3, 75)
        Me.RadLabel_GainVar.Name = "RadLabel_GainVar"
        Me.RadLabel_GainVar.Size = New System.Drawing.Size(173, 25)
        Me.RadLabel_GainVar.TabIndex = 40
        Me.RadLabel_GainVar.Text = "AnodeData_GainVar"
        Me.RadLabel_GainVar.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_GainVar.TextWrap = False
        Me.RadLabel_GainVar.ThemeName = "Windows8"
        '
        'RadLabel_MaxGain
        '
        Me.RadLabel_MaxGain.AutoSize = False
        Me.RadLabel_MaxGain.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MaxGain.Location = New System.Drawing.Point(3, 44)
        Me.RadLabel_MaxGain.Name = "RadLabel_MaxGain"
        Me.RadLabel_MaxGain.Size = New System.Drawing.Size(173, 25)
        Me.RadLabel_MaxGain.TabIndex = 39
        Me.RadLabel_MaxGain.Text = "AnodeData_MaxGain"
        Me.RadLabel_MaxGain.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_MaxGain.TextWrap = False
        Me.RadLabel_MaxGain.ThemeName = "Windows8"
        '
        'RadLabel_MinGain
        '
        Me.RadLabel_MinGain.AutoSize = False
        Me.RadLabel_MinGain.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MinGain.Location = New System.Drawing.Point(3, 13)
        Me.RadLabel_MinGain.Name = "RadLabel_MinGain"
        Me.RadLabel_MinGain.Size = New System.Drawing.Size(173, 25)
        Me.RadLabel_MinGain.TabIndex = 38
        Me.RadLabel_MinGain.Text = "AnodeData_MinGain"
        Me.RadLabel_MinGain.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_MinGain.TextWrap = False
        Me.RadLabel_MinGain.ThemeName = "Windows8"
        '
        'RadTextBox_GainVar
        '
        Me.RadTextBox_GainVar.AutoSize = False
        Me.RadTextBox_GainVar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_GainVar.Location = New System.Drawing.Point(182, 75)
        Me.RadTextBox_GainVar.Name = "RadTextBox_GainVar"
        Me.RadTextBox_GainVar.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_GainVar.TabIndex = 37
        Me.RadTextBox_GainVar.ThemeName = "Windows8"
        '
        'RadTextBox_MaxGain
        '
        Me.RadTextBox_MaxGain.AutoSize = False
        Me.RadTextBox_MaxGain.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_MaxGain.Location = New System.Drawing.Point(182, 44)
        Me.RadTextBox_MaxGain.Name = "RadTextBox_MaxGain"
        Me.RadTextBox_MaxGain.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_MaxGain.TabIndex = 36
        Me.RadTextBox_MaxGain.ThemeName = "Windows8"
        '
        'RadTextBox_MinGain
        '
        Me.RadTextBox_MinGain.AutoSize = False
        Me.RadTextBox_MinGain.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_MinGain.Location = New System.Drawing.Point(182, 13)
        Me.RadTextBox_MinGain.Name = "RadTextBox_MinGain"
        Me.RadTextBox_MinGain.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_MinGain.TabIndex = 35
        Me.RadTextBox_MinGain.ThemeName = "Windows8"
        '
        'RadLabel_Formation
        '
        Me.RadLabel_Formation.AutoSize = False
        Me.RadLabel_Formation.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.RadLabel_Formation.Location = New System.Drawing.Point(22, 131)
        Me.RadLabel_Formation.Name = "RadLabel_Formation"
        Me.RadLabel_Formation.Size = New System.Drawing.Size(150, 30)
        Me.RadLabel_Formation.TabIndex = 141
        Me.RadLabel_Formation.Text = "AnodeData_Formation"
        Me.RadLabel_Formation.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Formation.TextWrap = False
        Me.RadLabel_Formation.ThemeName = "Windows8"
        '
        'RadTextBox_Formation
        '
        Me.RadTextBox_Formation.AutoSize = False
        Me.RadTextBox_Formation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Formation.Location = New System.Drawing.Point(178, 131)
        Me.RadTextBox_Formation.Name = "RadTextBox_Formation"
        Me.RadTextBox_Formation.Size = New System.Drawing.Size(109, 30)
        Me.RadTextBox_Formation.TabIndex = 142
        Me.RadTextBox_Formation.ThemeName = "Windows8"
        '
        'RadLabel_FormationUnit
        '
        Me.RadLabel_FormationUnit.AutoSize = False
        Me.RadLabel_FormationUnit.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.RadLabel_FormationUnit.Location = New System.Drawing.Point(293, 131)
        Me.RadLabel_FormationUnit.Name = "RadLabel_FormationUnit"
        Me.RadLabel_FormationUnit.Size = New System.Drawing.Size(40, 30)
        Me.RadLabel_FormationUnit.TabIndex = 143
        Me.RadLabel_FormationUnit.Text = "Global_V"
        Me.RadLabel_FormationUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_FormationUnit.TextWrap = False
        Me.RadLabel_FormationUnit.ThemeName = "Windows8"
        '
        'RadLabel_OxideFactorUnit
        '
        Me.RadLabel_OxideFactorUnit.AutoSize = False
        Me.RadLabel_OxideFactorUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_OxideFactorUnit.Location = New System.Drawing.Point(260, 295)
        Me.RadLabel_OxideFactorUnit.Name = "RadLabel_OxideFactorUnit"
        Me.RadLabel_OxideFactorUnit.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_OxideFactorUnit.TabIndex = 158
        Me.RadLabel_OxideFactorUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_OxideFactorUnit.TextWrap = False
        Me.RadLabel_OxideFactorUnit.ThemeName = "Windows8"
        '
        'RadTextBox_OxideFactor
        '
        Me.RadTextBox_OxideFactor.AutoSize = False
        Me.RadTextBox_OxideFactor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_OxideFactor.Location = New System.Drawing.Point(178, 295)
        Me.RadTextBox_OxideFactor.Name = "RadTextBox_OxideFactor"
        Me.RadTextBox_OxideFactor.Size = New System.Drawing.Size(78, 25)
        Me.RadTextBox_OxideFactor.TabIndex = 157
        Me.RadTextBox_OxideFactor.ThemeName = "Windows8"
        '
        'RadLabel_OxideFactor
        '
        Me.RadLabel_OxideFactor.AutoSize = False
        Me.RadLabel_OxideFactor.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_OxideFactor.Location = New System.Drawing.Point(37, 295)
        Me.RadLabel_OxideFactor.Name = "RadLabel_OxideFactor"
        Me.RadLabel_OxideFactor.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_OxideFactor.TabIndex = 156
        Me.RadLabel_OxideFactor.Text = "AnodeData_OxideFactor"
        Me.RadLabel_OxideFactor.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_OxideFactor.TextWrap = False
        Me.RadLabel_OxideFactor.ThemeName = "Windows8"
        '
        'RadLabel_PurityUnit
        '
        Me.RadLabel_PurityUnit.AutoSize = False
        Me.RadLabel_PurityUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_PurityUnit.Location = New System.Drawing.Point(260, 264)
        Me.RadLabel_PurityUnit.Name = "RadLabel_PurityUnit"
        Me.RadLabel_PurityUnit.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_PurityUnit.TabIndex = 155
        Me.RadLabel_PurityUnit.Text = "Global_Percentage"
        Me.RadLabel_PurityUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_PurityUnit.TextWrap = False
        Me.RadLabel_PurityUnit.ThemeName = "Windows8"
        '
        'RadTextBox_Purity
        '
        Me.RadTextBox_Purity.AutoSize = False
        Me.RadTextBox_Purity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Purity.Location = New System.Drawing.Point(178, 264)
        Me.RadTextBox_Purity.Name = "RadTextBox_Purity"
        Me.RadTextBox_Purity.Size = New System.Drawing.Size(78, 25)
        Me.RadTextBox_Purity.TabIndex = 154
        Me.RadTextBox_Purity.ThemeName = "Windows8"
        '
        'RadLabel_Purity
        '
        Me.RadLabel_Purity.AutoSize = False
        Me.RadLabel_Purity.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Purity.Location = New System.Drawing.Point(37, 264)
        Me.RadLabel_Purity.Name = "RadLabel_Purity"
        Me.RadLabel_Purity.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_Purity.TabIndex = 153
        Me.RadLabel_Purity.Text = "AnodeData_Purity"
        Me.RadLabel_Purity.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Purity.TextWrap = False
        Me.RadLabel_Purity.ThemeName = "Windows8"
        '
        'RadLabel_AreaWeightRatioUnit
        '
        Me.RadLabel_AreaWeightRatioUnit.AutoSize = False
        Me.RadLabel_AreaWeightRatioUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_AreaWeightRatioUnit.Location = New System.Drawing.Point(260, 233)
        Me.RadLabel_AreaWeightRatioUnit.Name = "RadLabel_AreaWeightRatioUnit"
        Me.RadLabel_AreaWeightRatioUnit.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_AreaWeightRatioUnit.TabIndex = 152
        Me.RadLabel_AreaWeightRatioUnit.Text = "Units_MeterSquarePerKilogram"
        Me.RadLabel_AreaWeightRatioUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_AreaWeightRatioUnit.TextWrap = False
        Me.RadLabel_AreaWeightRatioUnit.ThemeName = "Windows8"
        '
        'RadTextBox_AreaWeightRatio
        '
        Me.RadTextBox_AreaWeightRatio.AutoSize = False
        Me.RadTextBox_AreaWeightRatio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_AreaWeightRatio.Location = New System.Drawing.Point(178, 233)
        Me.RadTextBox_AreaWeightRatio.Name = "RadTextBox_AreaWeightRatio"
        Me.RadTextBox_AreaWeightRatio.Size = New System.Drawing.Size(78, 25)
        Me.RadTextBox_AreaWeightRatio.TabIndex = 151
        Me.RadTextBox_AreaWeightRatio.ThemeName = "Windows8"
        '
        'RadLabel_AreaWeightRatio
        '
        Me.RadLabel_AreaWeightRatio.AutoSize = False
        Me.RadLabel_AreaWeightRatio.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_AreaWeightRatio.Location = New System.Drawing.Point(37, 233)
        Me.RadLabel_AreaWeightRatio.Name = "RadLabel_AreaWeightRatio"
        Me.RadLabel_AreaWeightRatio.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_AreaWeightRatio.TabIndex = 150
        Me.RadLabel_AreaWeightRatio.Text = "AnodeData_AreaWeightRatio"
        Me.RadLabel_AreaWeightRatio.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_AreaWeightRatio.TextWrap = False
        Me.RadLabel_AreaWeightRatio.ThemeName = "Windows8"
        '
        'RadLabel_ThicknessUnit
        '
        Me.RadLabel_ThicknessUnit.AutoSize = False
        Me.RadLabel_ThicknessUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_ThicknessUnit.Location = New System.Drawing.Point(260, 202)
        Me.RadLabel_ThicknessUnit.Name = "RadLabel_ThicknessUnit"
        Me.RadLabel_ThicknessUnit.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_ThicknessUnit.TabIndex = 149
        Me.RadLabel_ThicknessUnit.Text = "Units_MicroMeter"
        Me.RadLabel_ThicknessUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_ThicknessUnit.TextWrap = False
        Me.RadLabel_ThicknessUnit.ThemeName = "Windows8"
        '
        'RadTextBox_Thickness
        '
        Me.RadTextBox_Thickness.AutoSize = False
        Me.RadTextBox_Thickness.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Thickness.Location = New System.Drawing.Point(178, 202)
        Me.RadTextBox_Thickness.Name = "RadTextBox_Thickness"
        Me.RadTextBox_Thickness.Size = New System.Drawing.Size(78, 25)
        Me.RadTextBox_Thickness.TabIndex = 148
        Me.RadTextBox_Thickness.ThemeName = "Windows8"
        '
        'RadLabel_Thickness
        '
        Me.RadLabel_Thickness.AutoSize = False
        Me.RadLabel_Thickness.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Thickness.Location = New System.Drawing.Point(37, 202)
        Me.RadLabel_Thickness.Name = "RadLabel_Thickness"
        Me.RadLabel_Thickness.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_Thickness.TabIndex = 147
        Me.RadLabel_Thickness.Text = "AnodeData_Thickness"
        Me.RadLabel_Thickness.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Thickness.TextWrap = False
        Me.RadLabel_Thickness.ThemeName = "Windows8"
        '
        'RadLabel_GainUnit
        '
        Me.RadLabel_GainUnit.AutoSize = False
        Me.RadLabel_GainUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_GainUnit.Location = New System.Drawing.Point(260, 171)
        Me.RadLabel_GainUnit.Name = "RadLabel_GainUnit"
        Me.RadLabel_GainUnit.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_GainUnit.TabIndex = 146
        Me.RadLabel_GainUnit.Text = "Units_MicroFaradPerSquareCm"
        Me.RadLabel_GainUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_GainUnit.TextWrap = False
        Me.RadLabel_GainUnit.ThemeName = "Windows8"
        '
        'RadTextBox_Gain
        '
        Me.RadTextBox_Gain.AutoSize = False
        Me.RadTextBox_Gain.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Gain.Location = New System.Drawing.Point(178, 171)
        Me.RadTextBox_Gain.Name = "RadTextBox_Gain"
        Me.RadTextBox_Gain.Size = New System.Drawing.Size(78, 25)
        Me.RadTextBox_Gain.TabIndex = 145
        Me.RadTextBox_Gain.ThemeName = "Windows8"
        '
        'RadLabel_Gain
        '
        Me.RadLabel_Gain.AutoSize = False
        Me.RadLabel_Gain.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Gain.Location = New System.Drawing.Point(37, 171)
        Me.RadLabel_Gain.Name = "RadLabel_Gain"
        Me.RadLabel_Gain.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_Gain.TabIndex = 144
        Me.RadLabel_Gain.Text = "AnodeData_Gain"
        Me.RadLabel_Gain.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Gain.TextWrap = False
        Me.RadLabel_Gain.ThemeName = "Windows8"
        '
        'RadLabel_ResistanceUnit
        '
        Me.RadLabel_ResistanceUnit.AutoSize = False
        Me.RadLabel_ResistanceUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_ResistanceUnit.Location = New System.Drawing.Point(260, 326)
        Me.RadLabel_ResistanceUnit.Name = "RadLabel_ResistanceUnit"
        Me.RadLabel_ResistanceUnit.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_ResistanceUnit.TabIndex = 161
        Me.RadLabel_ResistanceUnit.Text = "Units_OhmSymbol"
        Me.RadLabel_ResistanceUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_ResistanceUnit.TextWrap = False
        Me.RadLabel_ResistanceUnit.ThemeName = "Windows8"
        '
        'RadTextBox_Resistance
        '
        Me.RadTextBox_Resistance.AutoSize = False
        Me.RadTextBox_Resistance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Resistance.Location = New System.Drawing.Point(178, 326)
        Me.RadTextBox_Resistance.Name = "RadTextBox_Resistance"
        Me.RadTextBox_Resistance.Size = New System.Drawing.Size(78, 25)
        Me.RadTextBox_Resistance.TabIndex = 160
        Me.RadTextBox_Resistance.ThemeName = "Windows8"
        '
        'RadLabel_Resistance
        '
        Me.RadLabel_Resistance.AutoSize = False
        Me.RadLabel_Resistance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Resistance.Location = New System.Drawing.Point(37, 326)
        Me.RadLabel_Resistance.Name = "RadLabel_Resistance"
        Me.RadLabel_Resistance.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_Resistance.TabIndex = 159
        Me.RadLabel_Resistance.Text = "AnodeData_Resistance"
        Me.RadLabel_Resistance.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Resistance.TextWrap = False
        Me.RadLabel_Resistance.ThemeName = "Windows8"
        '
        'RadTextBox_Description
        '
        Me.RadTextBox_Description.AutoSize = False
        Me.RadTextBox_Description.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Description.Location = New System.Drawing.Point(178, 369)
        Me.RadTextBox_Description.Name = "RadTextBox_Description"
        Me.RadTextBox_Description.Size = New System.Drawing.Size(274, 62)
        Me.RadTextBox_Description.TabIndex = 178
        Me.RadTextBox_Description.ThemeName = "Windows8"
        '
        'RadLabel_Description
        '
        Me.RadLabel_Description.AutoSize = False
        Me.RadLabel_Description.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Description.Location = New System.Drawing.Point(37, 369)
        Me.RadLabel_Description.Name = "RadLabel_Description"
        Me.RadLabel_Description.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_Description.TabIndex = 177
        Me.RadLabel_Description.Text = "AnodeData_Description"
        Me.RadLabel_Description.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Description.TextWrap = False
        Me.RadLabel_Description.ThemeName = "Windows8"
        '
        'RadTextBox_CurrentCostBase
        '
        Me.RadTextBox_CurrentCostBase.AutoSize = False
        Me.RadTextBox_CurrentCostBase.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_CurrentCostBase.Location = New System.Drawing.Point(499, 545)
        Me.RadTextBox_CurrentCostBase.Name = "RadTextBox_CurrentCostBase"
        Me.RadTextBox_CurrentCostBase.Size = New System.Drawing.Size(126, 25)
        Me.RadTextBox_CurrentCostBase.TabIndex = 171
        Me.RadTextBox_CurrentCostBase.ThemeName = "Windows8"
        '
        'RadTextBox_PreviousCostBase
        '
        Me.RadTextBox_PreviousCostBase.AutoSize = False
        Me.RadTextBox_PreviousCostBase.Enabled = False
        Me.RadTextBox_PreviousCostBase.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_PreviousCostBase.Location = New System.Drawing.Point(499, 576)
        Me.RadTextBox_PreviousCostBase.Name = "RadTextBox_PreviousCostBase"
        Me.RadTextBox_PreviousCostBase.Size = New System.Drawing.Size(126, 25)
        Me.RadTextBox_PreviousCostBase.TabIndex = 176
        Me.RadTextBox_PreviousCostBase.ThemeName = "Windows8"
        '
        'RadTextBox_PreviousCostSource
        '
        Me.RadTextBox_PreviousCostSource.AutoSize = False
        Me.RadTextBox_PreviousCostSource.Enabled = False
        Me.RadTextBox_PreviousCostSource.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_PreviousCostSource.Location = New System.Drawing.Point(326, 576)
        Me.RadTextBox_PreviousCostSource.Name = "RadTextBox_PreviousCostSource"
        Me.RadTextBox_PreviousCostSource.Size = New System.Drawing.Size(151, 25)
        Me.RadTextBox_PreviousCostSource.TabIndex = 175
        Me.RadTextBox_PreviousCostSource.ThemeName = "Windows8"
        '
        'RadTextBox_PreviousCost
        '
        Me.RadTextBox_PreviousCost.AutoSize = False
        Me.RadTextBox_PreviousCost.Enabled = False
        Me.RadTextBox_PreviousCost.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_PreviousCost.Location = New System.Drawing.Point(178, 576)
        Me.RadTextBox_PreviousCost.Name = "RadTextBox_PreviousCost"
        Me.RadTextBox_PreviousCost.Size = New System.Drawing.Size(126, 25)
        Me.RadTextBox_PreviousCost.TabIndex = 174
        Me.RadTextBox_PreviousCost.ThemeName = "Windows8"
        '
        'RadLabel_PreviousCost
        '
        Me.RadLabel_PreviousCost.AutoSize = False
        Me.RadLabel_PreviousCost.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_PreviousCost.Location = New System.Drawing.Point(37, 576)
        Me.RadLabel_PreviousCost.Name = "RadLabel_PreviousCost"
        Me.RadLabel_PreviousCost.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_PreviousCost.TabIndex = 173
        Me.RadLabel_PreviousCost.Text = "AnodeData_PreviousCost"
        Me.RadLabel_PreviousCost.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_PreviousCost.TextWrap = False
        Me.RadLabel_PreviousCost.ThemeName = "Windows8"
        '
        'RadLabel_MatOnly
        '
        Me.RadLabel_MatOnly.AutoSize = False
        Me.RadLabel_MatOnly.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MatOnly.Location = New System.Drawing.Point(499, 521)
        Me.RadLabel_MatOnly.Name = "RadLabel_MatOnly"
        Me.RadLabel_MatOnly.Size = New System.Drawing.Size(126, 25)
        Me.RadLabel_MatOnly.TabIndex = 172
        Me.RadLabel_MatOnly.Text = "AnodeData_MatOnly"
        Me.RadLabel_MatOnly.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_MatOnly.TextWrap = False
        Me.RadLabel_MatOnly.ThemeName = "Windows8"
        '
        'RadTextBox_CurrentCostSource
        '
        Me.RadTextBox_CurrentCostSource.AutoSize = False
        Me.RadTextBox_CurrentCostSource.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_CurrentCostSource.Location = New System.Drawing.Point(326, 545)
        Me.RadTextBox_CurrentCostSource.Name = "RadTextBox_CurrentCostSource"
        Me.RadTextBox_CurrentCostSource.Size = New System.Drawing.Size(151, 25)
        Me.RadTextBox_CurrentCostSource.TabIndex = 170
        Me.RadTextBox_CurrentCostSource.ThemeName = "Windows8"
        '
        'RadTextBox_CurrentCost
        '
        Me.RadTextBox_CurrentCost.AutoSize = False
        Me.RadTextBox_CurrentCost.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_CurrentCost.Location = New System.Drawing.Point(178, 545)
        Me.RadTextBox_CurrentCost.Name = "RadTextBox_CurrentCost"
        Me.RadTextBox_CurrentCost.Size = New System.Drawing.Size(126, 25)
        Me.RadTextBox_CurrentCost.TabIndex = 169
        Me.RadTextBox_CurrentCost.ThemeName = "Windows8"
        '
        'RadLabel_CurrentCost
        '
        Me.RadLabel_CurrentCost.AutoSize = False
        Me.RadLabel_CurrentCost.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_CurrentCost.Location = New System.Drawing.Point(37, 545)
        Me.RadLabel_CurrentCost.Name = "RadLabel_CurrentCost"
        Me.RadLabel_CurrentCost.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_CurrentCost.TabIndex = 168
        Me.RadLabel_CurrentCost.Text = "AnodeData_CurrentCost"
        Me.RadLabel_CurrentCost.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_CurrentCost.TextWrap = False
        Me.RadLabel_CurrentCost.ThemeName = "Windows8"
        '
        'RadTextBox_MSpecNo
        '
        Me.RadTextBox_MSpecNo.AutoSize = False
        Me.RadTextBox_MSpecNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_MSpecNo.Location = New System.Drawing.Point(178, 501)
        Me.RadTextBox_MSpecNo.Name = "RadTextBox_MSpecNo"
        Me.RadTextBox_MSpecNo.Size = New System.Drawing.Size(126, 25)
        Me.RadTextBox_MSpecNo.TabIndex = 167
        Me.RadTextBox_MSpecNo.ThemeName = "Windows8"
        '
        'RadLabel_MSpecNo
        '
        Me.RadLabel_MSpecNo.AutoSize = False
        Me.RadLabel_MSpecNo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MSpecNo.Location = New System.Drawing.Point(37, 501)
        Me.RadLabel_MSpecNo.Name = "RadLabel_MSpecNo"
        Me.RadLabel_MSpecNo.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_MSpecNo.TabIndex = 166
        Me.RadLabel_MSpecNo.Text = "AnodeData_MSpecNo"
        Me.RadLabel_MSpecNo.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_MSpecNo.TextWrap = False
        Me.RadLabel_MSpecNo.ThemeName = "Windows8"
        '
        'RadTextBox_Supplier
        '
        Me.RadTextBox_Supplier.AutoSize = False
        Me.RadTextBox_Supplier.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Supplier.Location = New System.Drawing.Point(178, 470)
        Me.RadTextBox_Supplier.Name = "RadTextBox_Supplier"
        Me.RadTextBox_Supplier.Size = New System.Drawing.Size(274, 25)
        Me.RadTextBox_Supplier.TabIndex = 165
        Me.RadTextBox_Supplier.ThemeName = "Windows8"
        '
        'RadLabel_Supplier
        '
        Me.RadLabel_Supplier.AutoSize = False
        Me.RadLabel_Supplier.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Supplier.Location = New System.Drawing.Point(37, 470)
        Me.RadLabel_Supplier.Name = "RadLabel_Supplier"
        Me.RadLabel_Supplier.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_Supplier.TabIndex = 164
        Me.RadLabel_Supplier.Text = "AnodeData_Supplier"
        Me.RadLabel_Supplier.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Supplier.TextWrap = False
        Me.RadLabel_Supplier.ThemeName = "Windows8"
        '
        'RadTextBox_Specification
        '
        Me.RadTextBox_Specification.AutoSize = False
        Me.RadTextBox_Specification.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Specification.Location = New System.Drawing.Point(178, 437)
        Me.RadTextBox_Specification.Multiline = True
        Me.RadTextBox_Specification.Name = "RadTextBox_Specification"
        Me.RadTextBox_Specification.Size = New System.Drawing.Size(274, 25)
        Me.RadTextBox_Specification.TabIndex = 163
        Me.RadTextBox_Specification.ThemeName = "Windows8"
        '
        'RadLabe_Specification
        '
        Me.RadLabe_Specification.AutoSize = False
        Me.RadLabe_Specification.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabe_Specification.Location = New System.Drawing.Point(37, 437)
        Me.RadLabe_Specification.Name = "RadLabe_Specification"
        Me.RadLabe_Specification.Size = New System.Drawing.Size(135, 25)
        Me.RadLabe_Specification.TabIndex = 162
        Me.RadLabe_Specification.Text = "AnodeData_Specification"
        Me.RadLabe_Specification.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabe_Specification.TextWrap = False
        Me.RadLabe_Specification.ThemeName = "Windows8"
        '
        'AnodeData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1147, 614)
        Me.Controls.Add(Me.RadTextBox_Description)
        Me.Controls.Add(Me.RadLabel_Description)
        Me.Controls.Add(Me.RadTextBox_CurrentCostBase)
        Me.Controls.Add(Me.RadTextBox_PreviousCostBase)
        Me.Controls.Add(Me.RadTextBox_PreviousCostSource)
        Me.Controls.Add(Me.RadTextBox_PreviousCost)
        Me.Controls.Add(Me.RadLabel_PreviousCost)
        Me.Controls.Add(Me.RadLabel_MatOnly)
        Me.Controls.Add(Me.RadTextBox_CurrentCostSource)
        Me.Controls.Add(Me.RadTextBox_CurrentCost)
        Me.Controls.Add(Me.RadLabel_CurrentCost)
        Me.Controls.Add(Me.RadTextBox_MSpecNo)
        Me.Controls.Add(Me.RadLabel_MSpecNo)
        Me.Controls.Add(Me.RadTextBox_Supplier)
        Me.Controls.Add(Me.RadLabel_Supplier)
        Me.Controls.Add(Me.RadTextBox_Specification)
        Me.Controls.Add(Me.RadLabe_Specification)
        Me.Controls.Add(Me.RadLabel_ResistanceUnit)
        Me.Controls.Add(Me.RadTextBox_Resistance)
        Me.Controls.Add(Me.RadLabel_Resistance)
        Me.Controls.Add(Me.RadLabel_OxideFactorUnit)
        Me.Controls.Add(Me.RadTextBox_OxideFactor)
        Me.Controls.Add(Me.RadLabel_OxideFactor)
        Me.Controls.Add(Me.RadLabel_PurityUnit)
        Me.Controls.Add(Me.RadTextBox_Purity)
        Me.Controls.Add(Me.RadLabel_Purity)
        Me.Controls.Add(Me.RadLabel_AreaWeightRatioUnit)
        Me.Controls.Add(Me.RadTextBox_AreaWeightRatio)
        Me.Controls.Add(Me.RadLabel_AreaWeightRatio)
        Me.Controls.Add(Me.RadLabel_ThicknessUnit)
        Me.Controls.Add(Me.RadTextBox_Thickness)
        Me.Controls.Add(Me.RadLabel_Thickness)
        Me.Controls.Add(Me.RadLabel_GainUnit)
        Me.Controls.Add(Me.RadTextBox_Gain)
        Me.Controls.Add(Me.RadLabel_Gain)
        Me.Controls.Add(Me.RadLabel_FormationUnit)
        Me.Controls.Add(Me.RadTextBox_Formation)
        Me.Controls.Add(Me.RadLabel_Formation)
        Me.Controls.Add(Me.RadLabel_TestData)
        Me.Controls.Add(Me.Panel_TestData)
        Me.Controls.Add(Me.RadCheckBox_Purchased)
        Me.Controls.Add(Me.RadLabel_OracleData)
        Me.Controls.Add(Me.Panel_OracleData)
        Me.Controls.Add(Me.RadTextBox_Anode)
        Me.Controls.Add(Me.RadLabel_Anode)
        Me.Controls.Add(Me.RadCheckBox_Obsolete)
        Me.Controls.Add(Me.RadCheckBox_Active)
        Me.Controls.Add(Me.RadDropDownList_AnodeName)
        Me.Controls.Add(Me.RadLabel_AnodeName)
        Me.Controls.Add(Me.Panel_Header)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AnodeData"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "AnodeData_TitleWindow"
        Me.ThemeName = "Windows8"
        Me.Panel_Header.ResumeLayout(False)
        CType(Me.RadButton_WhereUsedThisFoil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_WhereUsedThisFoilAndVoltage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_ShowAllFoils, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_JustThisVoltage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_JustThisFoilType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_Obsolete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_Active, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_AnodeName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_AnodeName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Anode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Anode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_OracleData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_OracleData.ResumeLayout(False)
        CType(Me.RadLabel_ShrinkPercentage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ShrinkPercentage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_RateCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_MultilevelBackflushFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_BackflushFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_StagingFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_BackflushWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_StagingWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_FirstOp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_BackflushWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_StagingWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_FirstOp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_Purchased, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TestData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_TestData.ResumeLayout(False)
        CType(Me.RadButton_AddStdVals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_MaxACPFChange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_MaxACPFChange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_MaxACPF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_MaxACPF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_MaxBoil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_MaxRise, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_MaxBoil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_MaxRise, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_MinFV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_MinFV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_MaxTD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_MaxTD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_GainVar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_MaxGain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_MinGain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_GainVar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_MaxGain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_MinGain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Formation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Formation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_FormationUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_OxideFactorUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_OxideFactor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_OxideFactor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PurityUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Purity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Purity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_AreaWeightRatioUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_AreaWeightRatio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_AreaWeightRatio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ThicknessUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Thickness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Thickness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_GainUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Gain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Gain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ResistanceUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Resistance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Resistance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Description, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Description, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CurrentCostBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_PreviousCostBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_PreviousCostSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_PreviousCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PreviousCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_MatOnly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CurrentCostSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CurrentCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_CurrentCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_MSpecNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_MSpecNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Specification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabe_Specification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Header As System.Windows.Forms.Panel
    Friend WithEvents RadButton_JustThisVoltage As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_JustThisFoilType As Telerik.WinControls.UI.RadButton
    Friend WithEvents PictureBox_KemetLogo As System.Windows.Forms.PictureBox
    Friend WithEvents RadLabel_Title As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadCheckBox_Obsolete As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_Active As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadDropDownList_AnodeName As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_AnodeName As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton_WhereUsedThisFoil As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_WhereUsedThisFoilAndVoltage As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_ShowAllFoils As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadTextBox_Anode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Anode As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_OracleData As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel_OracleData As System.Windows.Forms.Panel
    Friend WithEvents RadCheckBox_MultilevelBackflushFlag As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_BackflushFlag As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_StagingFlag As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel_BackflushWarehouse As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_StagingWarehouse As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_FirstOp As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_BackflushWarehouse As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_StagingWarehouse As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_FirstOp As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_RateCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_ShrinkPercentage As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_ShrinkPercentage As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadCheckBox_Purchased As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel_TestData As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_MinFV As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Panel_TestData As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_MinFV As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_MaxTD As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_MaxTD As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_GainVar As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_MaxGain As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_MinGain As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_GainVar As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_MaxGain As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_MinGain As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_MaxACPFChange As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_MaxACPFChange As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_MaxACPF As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_MaxACPF As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_MaxBoil As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_MaxRise As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_MaxBoil As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_MaxRise As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadButton_AddStdVals As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel_Formation As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Formation As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_FormationUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_OxideFactorUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_OxideFactor As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_OxideFactor As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_PurityUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Purity As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Purity As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_AreaWeightRatioUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_AreaWeightRatio As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_AreaWeightRatio As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_ThicknessUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Thickness As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Thickness As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_GainUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Gain As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Gain As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_ResistanceUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Resistance As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Resistance As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Description As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Description As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_CurrentCostBase As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_PreviousCostBase As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_PreviousCostSource As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_PreviousCost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_PreviousCost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_MatOnly As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_CurrentCostSource As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_CurrentCost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_CurrentCost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_MSpecNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_MSpecNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Supplier As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Supplier As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Specification As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabe_Specification As Telerik.WinControls.UI.RadLabel
End Class

