<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TissueData
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TissueData))
        Me.Panel_Header = New System.Windows.Forms.Panel()
        Me.RadButton_WhereUsed = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox_KemetLogo = New System.Windows.Forms.PictureBox()
        Me.RadLabel_Title = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_OracleData = New Telerik.WinControls.UI.RadLabel()
        Me.Panel_OracleData = New System.Windows.Forms.Panel()
        Me.RadLabel_RateCode = New Telerik.WinControls.UI.RadLabel()
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
        Me.RadLabel_Tissue = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Tissue = New Telerik.WinControls.UI.RadTextBox()
        Me.RadCheckBox_Obsolete = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_Active = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadDropDownList_PaperName = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_PaperName = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_ThicknessUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Thickness = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Thickness = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_DensityUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Density = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Density = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_VoidVolumeUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_VoidVolume = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_VoidVolume = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_ParticleDensityUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_ParticleDensity = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_ParticleDensity = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_ElectrolyteData = New Telerik.WinControls.UI.RadLabel()
        Me.Panel_ElectrolyteData = New System.Windows.Forms.Panel()
        Me.RadCheckBox_OkForBLO = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_OkForGlycol = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel_ResRatio6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_ResRatio6 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_ResRatio5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_ResRatio5 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_ResRatio4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_ResRatio4 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_ResRatio3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_ResRatio3 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_ResRatio2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_ResRatio2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_ResRatio1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_ResRatio1 = New Telerik.WinControls.UI.RadTextBox()
        Me.Panel_Suppliers = New System.Windows.Forms.Panel()
        Me.RadTextBox_VendorDescription3 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_VendorDescription2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_VendorDescription1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Supplier3 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Supplier2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Supplier1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_VendorDescription = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Supplier = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Specification = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Specification = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_MSpecNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_MSpecNo = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_CurrentCost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_CurrentCost = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_CurrentCostSource = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_PreviousCostSource = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_PreviousCost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_PreviousCost = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_PreviousCostBase = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_CurrentCostBase = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_TissueIndexDataSubform = New Telerik.WinControls.UI.RadLabel()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.Panel_Header.SuspendLayout()
        CType(Me.RadButton_WhereUsed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_OracleData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_OracleData.SuspendLayout()
        CType(Me.RadLabel_RateCode, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.RadLabel_Tissue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Tissue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_Obsolete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_Active, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_PaperName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PaperName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ThicknessUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Thickness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Thickness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_DensityUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Density, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Density, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_VoidVolumeUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_VoidVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_VoidVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ParticleDensityUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ParticleDensity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ParticleDensity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ElectrolyteData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_ElectrolyteData.SuspendLayout()
        CType(Me.RadCheckBox_OkForBLO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_OkForGlycol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ResRatio6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ResRatio6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ResRatio5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ResRatio5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ResRatio4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ResRatio4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ResRatio3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ResRatio3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ResRatio2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ResRatio2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ResRatio1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ResRatio1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Suppliers.SuspendLayout()
        CType(Me.RadTextBox_VendorDescription3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_VendorDescription2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_VendorDescription1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Supplier3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Supplier2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Supplier1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_VendorDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Specification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Specification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_MSpecNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_MSpecNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CurrentCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_CurrentCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CurrentCostSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_PreviousCostSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_PreviousCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PreviousCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_PreviousCostBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CurrentCostBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TissueIndexDataSubform, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel_Header.Size = New System.Drawing.Size(1110, 68)
        Me.Panel_Header.TabIndex = 4
        '
        'RadButton_WhereUsed
        '
        Me.RadButton_WhereUsed.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_WhereUsed.Location = New System.Drawing.Point(224, 8)
        Me.RadButton_WhereUsed.Name = "RadButton_WhereUsed"
        Me.RadButton_WhereUsed.Size = New System.Drawing.Size(100, 50)
        Me.RadButton_WhereUsed.TabIndex = 12
        Me.RadButton_WhereUsed.Text = "TissueData_WhereUsed"
        Me.RadButton_WhereUsed.TextWrap = True
        Me.RadButton_WhereUsed.ThemeName = "Windows8"
        '
        'PictureBox_KemetLogo
        '
        Me.PictureBox_KemetLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox_KemetLogo.Image = Global.ECAD.My.Resources.Resources.kemet_logo_small
        Me.PictureBox_KemetLogo.Location = New System.Drawing.Point(948, 4)
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
        Me.RadLabel_Title.Size = New System.Drawing.Size(192, 68)
        Me.RadLabel_Title.TabIndex = 0
        Me.RadLabel_Title.Text = "TissueData_Title"
        Me.RadLabel_Title.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Title.TextWrap = False
        Me.RadLabel_Title.ThemeName = "Windows8"
        '
        'RadLabel_OracleData
        '
        Me.RadLabel_OracleData.AutoSize = False
        Me.RadLabel_OracleData.BorderVisible = True
        Me.RadLabel_OracleData.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_OracleData.Location = New System.Drawing.Point(792, 120)
        Me.RadLabel_OracleData.Name = "RadLabel_OracleData"
        Me.RadLabel_OracleData.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_OracleData.TabIndex = 51
        Me.RadLabel_OracleData.Text = "TissueData_OracleData"
        Me.RadLabel_OracleData.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_OracleData.TextWrap = False
        Me.RadLabel_OracleData.ThemeName = "Windows8"
        '
        'Panel_OracleData
        '
        Me.Panel_OracleData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_OracleData.Controls.Add(Me.RadLabel_RateCode)
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
        Me.Panel_OracleData.Location = New System.Drawing.Point(775, 136)
        Me.Panel_OracleData.Name = "Panel_OracleData"
        Me.Panel_OracleData.Size = New System.Drawing.Size(287, 229)
        Me.Panel_OracleData.TabIndex = 50
        '
        'RadLabel_RateCode
        '
        Me.RadLabel_RateCode.AutoSize = False
        Me.RadLabel_RateCode.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_RateCode.Location = New System.Drawing.Point(3, 106)
        Me.RadLabel_RateCode.Name = "RadLabel_RateCode"
        Me.RadLabel_RateCode.Size = New System.Drawing.Size(173, 25)
        Me.RadLabel_RateCode.TabIndex = 45
        Me.RadLabel_RateCode.Text = "TissueData_RateCode"
        Me.RadLabel_RateCode.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_RateCode.TextWrap = False
        Me.RadLabel_RateCode.ThemeName = "Windows8"
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
        Me.RadCheckBox_MultilevelBackflushFlag.Location = New System.Drawing.Point(-22, 195)
        Me.RadCheckBox_MultilevelBackflushFlag.Name = "RadCheckBox_MultilevelBackflushFlag"
        Me.RadCheckBox_MultilevelBackflushFlag.Size = New System.Drawing.Size(256, 20)
        Me.RadCheckBox_MultilevelBackflushFlag.TabIndex = 43
        Me.RadCheckBox_MultilevelBackflushFlag.Text = "TissueData_MultilevelBackflushFlag"
        Me.RadCheckBox_MultilevelBackflushFlag.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_MultilevelBackflushFlag.ThemeName = "Windows8"
        '
        'RadCheckBox_BackflushFlag
        '
        Me.RadCheckBox_BackflushFlag.AutoSize = False
        Me.RadCheckBox_BackflushFlag.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_BackflushFlag.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_BackflushFlag.Location = New System.Drawing.Point(-22, 169)
        Me.RadCheckBox_BackflushFlag.Name = "RadCheckBox_BackflushFlag"
        Me.RadCheckBox_BackflushFlag.Size = New System.Drawing.Size(256, 20)
        Me.RadCheckBox_BackflushFlag.TabIndex = 42
        Me.RadCheckBox_BackflushFlag.Text = "TissueData_BackflushFlag"
        Me.RadCheckBox_BackflushFlag.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_BackflushFlag.ThemeName = "Windows8"
        '
        'RadCheckBox_StagingFlag
        '
        Me.RadCheckBox_StagingFlag.AutoSize = False
        Me.RadCheckBox_StagingFlag.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_StagingFlag.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_StagingFlag.Location = New System.Drawing.Point(-22, 143)
        Me.RadCheckBox_StagingFlag.Name = "RadCheckBox_StagingFlag"
        Me.RadCheckBox_StagingFlag.Size = New System.Drawing.Size(256, 20)
        Me.RadCheckBox_StagingFlag.TabIndex = 41
        Me.RadCheckBox_StagingFlag.Text = "TissueData_StagingFlag"
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
        Me.RadLabel_BackflushWarehouse.Text = "TissueData_BackflushWarehouse"
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
        Me.RadLabel_StagingWarehouse.Text = "TissueData_StagingWarehouse"
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
        Me.RadLabel_FirstOp.Text = "TissueData_FirstOp"
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
        'RadLabel_Tissue
        '
        Me.RadLabel_Tissue.AutoSize = False
        Me.RadLabel_Tissue.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel_Tissue.Location = New System.Drawing.Point(879, 81)
        Me.RadLabel_Tissue.Name = "RadLabel_Tissue"
        Me.RadLabel_Tissue.Size = New System.Drawing.Size(69, 15)
        Me.RadLabel_Tissue.TabIndex = 53
        Me.RadLabel_Tissue.Text = "TissueData_Tissue"
        Me.RadLabel_Tissue.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Tissue.TextWrap = False
        Me.RadLabel_Tissue.ThemeName = "Windows8"
        '
        'RadTextBox_Tissue
        '
        Me.RadTextBox_Tissue.AutoSize = False
        Me.RadTextBox_Tissue.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Tissue.Location = New System.Drawing.Point(954, 81)
        Me.RadTextBox_Tissue.Name = "RadTextBox_Tissue"
        Me.RadTextBox_Tissue.Size = New System.Drawing.Size(90, 15)
        Me.RadTextBox_Tissue.TabIndex = 52
        Me.RadTextBox_Tissue.ThemeName = "Windows8"
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
        Me.RadCheckBox_Obsolete.Text = "TissueData_Obsolete"
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
        Me.RadCheckBox_Active.Text = "TissueData_Active"
        Me.RadCheckBox_Active.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Active.ThemeName = "Windows8"
        '
        'RadDropDownList_PaperName
        '
        Me.RadDropDownList_PaperName.AutoSize = False
        Me.RadDropDownList_PaperName.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.RadDropDownList_PaperName.Location = New System.Drawing.Point(178, 81)
        Me.RadDropDownList_PaperName.Name = "RadDropDownList_PaperName"
        Me.RadDropDownList_PaperName.Size = New System.Drawing.Size(234, 30)
        Me.RadDropDownList_PaperName.TabIndex = 55
        Me.RadDropDownList_PaperName.ThemeName = "Windows8"
        '
        'RadLabel_PaperName
        '
        Me.RadLabel_PaperName.AutoSize = False
        Me.RadLabel_PaperName.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.RadLabel_PaperName.Location = New System.Drawing.Point(22, 81)
        Me.RadLabel_PaperName.Name = "RadLabel_PaperName"
        Me.RadLabel_PaperName.Size = New System.Drawing.Size(150, 30)
        Me.RadLabel_PaperName.TabIndex = 54
        Me.RadLabel_PaperName.Text = "TissueData_PaperName"
        Me.RadLabel_PaperName.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_PaperName.TextWrap = False
        Me.RadLabel_PaperName.ThemeName = "Windows8"
        '
        'RadLabel_ThicknessUnit
        '
        Me.RadLabel_ThicknessUnit.AutoSize = False
        Me.RadLabel_ThicknessUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_ThicknessUnit.Location = New System.Drawing.Point(260, 136)
        Me.RadLabel_ThicknessUnit.Name = "RadLabel_ThicknessUnit"
        Me.RadLabel_ThicknessUnit.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_ThicknessUnit.TabIndex = 64
        Me.RadLabel_ThicknessUnit.Text = "Units_MicroMeter"
        Me.RadLabel_ThicknessUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_ThicknessUnit.TextWrap = False
        Me.RadLabel_ThicknessUnit.ThemeName = "Windows8"
        '
        'RadTextBox_Thickness
        '
        Me.RadTextBox_Thickness.AutoSize = False
        Me.RadTextBox_Thickness.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Thickness.Location = New System.Drawing.Point(178, 136)
        Me.RadTextBox_Thickness.Name = "RadTextBox_Thickness"
        Me.RadTextBox_Thickness.Size = New System.Drawing.Size(78, 25)
        Me.RadTextBox_Thickness.TabIndex = 63
        Me.RadTextBox_Thickness.ThemeName = "Windows8"
        '
        'RadLabel_Thickness
        '
        Me.RadLabel_Thickness.AutoSize = False
        Me.RadLabel_Thickness.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Thickness.Location = New System.Drawing.Point(37, 136)
        Me.RadLabel_Thickness.Name = "RadLabel_Thickness"
        Me.RadLabel_Thickness.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_Thickness.TabIndex = 62
        Me.RadLabel_Thickness.Text = "TissueData_Thickness"
        Me.RadLabel_Thickness.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Thickness.TextWrap = False
        Me.RadLabel_Thickness.ThemeName = "Windows8"
        '
        'RadLabel_DensityUnit
        '
        Me.RadLabel_DensityUnit.AutoSize = False
        Me.RadLabel_DensityUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_DensityUnit.Location = New System.Drawing.Point(260, 167)
        Me.RadLabel_DensityUnit.Name = "RadLabel_DensityUnit"
        Me.RadLabel_DensityUnit.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_DensityUnit.TabIndex = 67
        Me.RadLabel_DensityUnit.Text = "Unit_GramPerCubicCm"
        Me.RadLabel_DensityUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_DensityUnit.TextWrap = False
        Me.RadLabel_DensityUnit.ThemeName = "Windows8"
        '
        'RadTextBox_Density
        '
        Me.RadTextBox_Density.AutoSize = False
        Me.RadTextBox_Density.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Density.Location = New System.Drawing.Point(178, 167)
        Me.RadTextBox_Density.Name = "RadTextBox_Density"
        Me.RadTextBox_Density.Size = New System.Drawing.Size(78, 25)
        Me.RadTextBox_Density.TabIndex = 66
        Me.RadTextBox_Density.ThemeName = "Windows8"
        '
        'RadLabel_Density
        '
        Me.RadLabel_Density.AutoSize = False
        Me.RadLabel_Density.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Density.Location = New System.Drawing.Point(37, 167)
        Me.RadLabel_Density.Name = "RadLabel_Density"
        Me.RadLabel_Density.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_Density.TabIndex = 65
        Me.RadLabel_Density.Text = "TissueData_Density"
        Me.RadLabel_Density.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Density.TextWrap = False
        Me.RadLabel_Density.ThemeName = "Windows8"
        '
        'RadLabel_VoidVolumeUnit
        '
        Me.RadLabel_VoidVolumeUnit.AutoSize = False
        Me.RadLabel_VoidVolumeUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_VoidVolumeUnit.Location = New System.Drawing.Point(260, 198)
        Me.RadLabel_VoidVolumeUnit.Name = "RadLabel_VoidVolumeUnit"
        Me.RadLabel_VoidVolumeUnit.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_VoidVolumeUnit.TabIndex = 70
        Me.RadLabel_VoidVolumeUnit.Text = "Units_CubicCm"
        Me.RadLabel_VoidVolumeUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_VoidVolumeUnit.TextWrap = False
        Me.RadLabel_VoidVolumeUnit.ThemeName = "Windows8"
        '
        'RadTextBox_VoidVolume
        '
        Me.RadTextBox_VoidVolume.AutoSize = False
        Me.RadTextBox_VoidVolume.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_VoidVolume.Location = New System.Drawing.Point(178, 198)
        Me.RadTextBox_VoidVolume.Name = "RadTextBox_VoidVolume"
        Me.RadTextBox_VoidVolume.Size = New System.Drawing.Size(78, 25)
        Me.RadTextBox_VoidVolume.TabIndex = 69
        Me.RadTextBox_VoidVolume.ThemeName = "Windows8"
        '
        'RadLabel_VoidVolume
        '
        Me.RadLabel_VoidVolume.AutoSize = False
        Me.RadLabel_VoidVolume.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_VoidVolume.Location = New System.Drawing.Point(37, 198)
        Me.RadLabel_VoidVolume.Name = "RadLabel_VoidVolume"
        Me.RadLabel_VoidVolume.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_VoidVolume.TabIndex = 68
        Me.RadLabel_VoidVolume.Text = "TissueData_VoidVolume"
        Me.RadLabel_VoidVolume.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_VoidVolume.TextWrap = False
        Me.RadLabel_VoidVolume.ThemeName = "Windows8"
        '
        'RadLabel_ParticleDensityUnit
        '
        Me.RadLabel_ParticleDensityUnit.AutoSize = False
        Me.RadLabel_ParticleDensityUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_ParticleDensityUnit.Location = New System.Drawing.Point(260, 229)
        Me.RadLabel_ParticleDensityUnit.Name = "RadLabel_ParticleDensityUnit"
        Me.RadLabel_ParticleDensityUnit.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_ParticleDensityUnit.TabIndex = 73
        Me.RadLabel_ParticleDensityUnit.Text = "Units_OnePerCubicCm"
        Me.RadLabel_ParticleDensityUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_ParticleDensityUnit.TextWrap = False
        Me.RadLabel_ParticleDensityUnit.ThemeName = "Windows8"
        '
        'RadTextBox_ParticleDensity
        '
        Me.RadTextBox_ParticleDensity.AutoSize = False
        Me.RadTextBox_ParticleDensity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_ParticleDensity.Location = New System.Drawing.Point(178, 229)
        Me.RadTextBox_ParticleDensity.Name = "RadTextBox_ParticleDensity"
        Me.RadTextBox_ParticleDensity.Size = New System.Drawing.Size(78, 25)
        Me.RadTextBox_ParticleDensity.TabIndex = 72
        Me.RadTextBox_ParticleDensity.ThemeName = "Windows8"
        '
        'RadLabel_ParticleDensity
        '
        Me.RadLabel_ParticleDensity.AutoSize = False
        Me.RadLabel_ParticleDensity.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_ParticleDensity.Location = New System.Drawing.Point(37, 229)
        Me.RadLabel_ParticleDensity.Name = "RadLabel_ParticleDensity"
        Me.RadLabel_ParticleDensity.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_ParticleDensity.TabIndex = 71
        Me.RadLabel_ParticleDensity.Text = "TissueData_ParticleDensity"
        Me.RadLabel_ParticleDensity.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_ParticleDensity.TextWrap = False
        Me.RadLabel_ParticleDensity.ThemeName = "Windows8"
        '
        'RadLabel_ElectrolyteData
        '
        Me.RadLabel_ElectrolyteData.AutoSize = False
        Me.RadLabel_ElectrolyteData.BorderVisible = True
        Me.RadLabel_ElectrolyteData.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_ElectrolyteData.Location = New System.Drawing.Point(427, 120)
        Me.RadLabel_ElectrolyteData.Name = "RadLabel_ElectrolyteData"
        Me.RadLabel_ElectrolyteData.Size = New System.Drawing.Size(186, 25)
        Me.RadLabel_ElectrolyteData.TabIndex = 75
        Me.RadLabel_ElectrolyteData.Text = "TissueData_ElectrolyteData"
        Me.RadLabel_ElectrolyteData.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_ElectrolyteData.TextWrap = False
        Me.RadLabel_ElectrolyteData.ThemeName = "Windows8"
        '
        'Panel_ElectrolyteData
        '
        Me.Panel_ElectrolyteData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_ElectrolyteData.Controls.Add(Me.RadCheckBox_OkForBLO)
        Me.Panel_ElectrolyteData.Controls.Add(Me.RadCheckBox_OkForGlycol)
        Me.Panel_ElectrolyteData.Controls.Add(Me.RadLabel_ResRatio6)
        Me.Panel_ElectrolyteData.Controls.Add(Me.RadTextBox_ResRatio6)
        Me.Panel_ElectrolyteData.Controls.Add(Me.RadLabel_ResRatio5)
        Me.Panel_ElectrolyteData.Controls.Add(Me.RadTextBox_ResRatio5)
        Me.Panel_ElectrolyteData.Controls.Add(Me.RadLabel_ResRatio4)
        Me.Panel_ElectrolyteData.Controls.Add(Me.RadTextBox_ResRatio4)
        Me.Panel_ElectrolyteData.Controls.Add(Me.RadLabel_ResRatio3)
        Me.Panel_ElectrolyteData.Controls.Add(Me.RadTextBox_ResRatio3)
        Me.Panel_ElectrolyteData.Controls.Add(Me.RadLabel_ResRatio2)
        Me.Panel_ElectrolyteData.Controls.Add(Me.RadTextBox_ResRatio2)
        Me.Panel_ElectrolyteData.Controls.Add(Me.RadLabel_ResRatio1)
        Me.Panel_ElectrolyteData.Controls.Add(Me.RadTextBox_ResRatio1)
        Me.Panel_ElectrolyteData.Location = New System.Drawing.Point(410, 136)
        Me.Panel_ElectrolyteData.Name = "Panel_ElectrolyteData"
        Me.Panel_ElectrolyteData.Size = New System.Drawing.Size(338, 229)
        Me.Panel_ElectrolyteData.TabIndex = 74
        '
        'RadCheckBox_OkForBLO
        '
        Me.RadCheckBox_OkForBLO.AutoSize = False
        Me.RadCheckBox_OkForBLO.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_OkForBLO.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_OkForBLO.Location = New System.Drawing.Point(-4, 184)
        Me.RadCheckBox_OkForBLO.Name = "RadCheckBox_OkForBLO"
        Me.RadCheckBox_OkForBLO.Size = New System.Drawing.Size(149, 20)
        Me.RadCheckBox_OkForBLO.TabIndex = 76
        Me.RadCheckBox_OkForBLO.Text = "TissueData_OkForBLO"
        Me.RadCheckBox_OkForBLO.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_OkForBLO.ThemeName = "Windows8"
        '
        'RadCheckBox_OkForGlycol
        '
        Me.RadCheckBox_OkForGlycol.AutoSize = False
        Me.RadCheckBox_OkForGlycol.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_OkForGlycol.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_OkForGlycol.Location = New System.Drawing.Point(159, 184)
        Me.RadCheckBox_OkForGlycol.Name = "RadCheckBox_OkForGlycol"
        Me.RadCheckBox_OkForGlycol.Size = New System.Drawing.Size(149, 20)
        Me.RadCheckBox_OkForGlycol.TabIndex = 51
        Me.RadCheckBox_OkForGlycol.Text = "TissueData_OkForGlycol"
        Me.RadCheckBox_OkForGlycol.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_OkForGlycol.ThemeName = "Windows8"
        '
        'RadLabel_ResRatio6
        '
        Me.RadLabel_ResRatio6.AutoSize = False
        Me.RadLabel_ResRatio6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel_ResRatio6.Location = New System.Drawing.Point(234, 101)
        Me.RadLabel_ResRatio6.Name = "RadLabel_ResRatio6"
        Me.RadLabel_ResRatio6.Size = New System.Drawing.Size(90, 25)
        Me.RadLabel_ResRatio6.TabIndex = 50
        Me.RadLabel_ResRatio6.Text = "TissueData_ResRatio6"
        Me.RadLabel_ResRatio6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_ResRatio6.TextWrap = False
        Me.RadLabel_ResRatio6.ThemeName = "Windows8"
        '
        'RadTextBox_ResRatio6
        '
        Me.RadTextBox_ResRatio6.AutoSize = False
        Me.RadTextBox_ResRatio6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_ResRatio6.Location = New System.Drawing.Point(234, 132)
        Me.RadTextBox_ResRatio6.Name = "RadTextBox_ResRatio6"
        Me.RadTextBox_ResRatio6.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_ResRatio6.TabIndex = 49
        Me.RadTextBox_ResRatio6.ThemeName = "Windows8"
        '
        'RadLabel_ResRatio5
        '
        Me.RadLabel_ResRatio5.AutoSize = False
        Me.RadLabel_ResRatio5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel_ResRatio5.Location = New System.Drawing.Point(123, 101)
        Me.RadLabel_ResRatio5.Name = "RadLabel_ResRatio5"
        Me.RadLabel_ResRatio5.Size = New System.Drawing.Size(90, 25)
        Me.RadLabel_ResRatio5.TabIndex = 48
        Me.RadLabel_ResRatio5.Text = "TissueData_ResRatio5"
        Me.RadLabel_ResRatio5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_ResRatio5.TextWrap = False
        Me.RadLabel_ResRatio5.ThemeName = "Windows8"
        '
        'RadTextBox_ResRatio5
        '
        Me.RadTextBox_ResRatio5.AutoSize = False
        Me.RadTextBox_ResRatio5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_ResRatio5.Location = New System.Drawing.Point(123, 132)
        Me.RadTextBox_ResRatio5.Name = "RadTextBox_ResRatio5"
        Me.RadTextBox_ResRatio5.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_ResRatio5.TabIndex = 47
        Me.RadTextBox_ResRatio5.ThemeName = "Windows8"
        '
        'RadLabel_ResRatio4
        '
        Me.RadLabel_ResRatio4.AutoSize = False
        Me.RadLabel_ResRatio4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel_ResRatio4.Location = New System.Drawing.Point(12, 101)
        Me.RadLabel_ResRatio4.Name = "RadLabel_ResRatio4"
        Me.RadLabel_ResRatio4.Size = New System.Drawing.Size(90, 25)
        Me.RadLabel_ResRatio4.TabIndex = 46
        Me.RadLabel_ResRatio4.Text = "TissueData_ResRatio4"
        Me.RadLabel_ResRatio4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_ResRatio4.TextWrap = False
        Me.RadLabel_ResRatio4.ThemeName = "Windows8"
        '
        'RadTextBox_ResRatio4
        '
        Me.RadTextBox_ResRatio4.AutoSize = False
        Me.RadTextBox_ResRatio4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_ResRatio4.Location = New System.Drawing.Point(12, 132)
        Me.RadTextBox_ResRatio4.Name = "RadTextBox_ResRatio4"
        Me.RadTextBox_ResRatio4.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_ResRatio4.TabIndex = 45
        Me.RadTextBox_ResRatio4.ThemeName = "Windows8"
        '
        'RadLabel_ResRatio3
        '
        Me.RadLabel_ResRatio3.AutoSize = False
        Me.RadLabel_ResRatio3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel_ResRatio3.Location = New System.Drawing.Point(234, 30)
        Me.RadLabel_ResRatio3.Name = "RadLabel_ResRatio3"
        Me.RadLabel_ResRatio3.Size = New System.Drawing.Size(90, 25)
        Me.RadLabel_ResRatio3.TabIndex = 44
        Me.RadLabel_ResRatio3.Text = "TissueData_ResRatio3"
        Me.RadLabel_ResRatio3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_ResRatio3.TextWrap = False
        Me.RadLabel_ResRatio3.ThemeName = "Windows8"
        '
        'RadTextBox_ResRatio3
        '
        Me.RadTextBox_ResRatio3.AutoSize = False
        Me.RadTextBox_ResRatio3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_ResRatio3.Location = New System.Drawing.Point(234, 61)
        Me.RadTextBox_ResRatio3.Name = "RadTextBox_ResRatio3"
        Me.RadTextBox_ResRatio3.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_ResRatio3.TabIndex = 43
        Me.RadTextBox_ResRatio3.ThemeName = "Windows8"
        '
        'RadLabel_ResRatio2
        '
        Me.RadLabel_ResRatio2.AutoSize = False
        Me.RadLabel_ResRatio2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel_ResRatio2.Location = New System.Drawing.Point(123, 30)
        Me.RadLabel_ResRatio2.Name = "RadLabel_ResRatio2"
        Me.RadLabel_ResRatio2.Size = New System.Drawing.Size(90, 25)
        Me.RadLabel_ResRatio2.TabIndex = 42
        Me.RadLabel_ResRatio2.Text = "TissueData_ResRatio2"
        Me.RadLabel_ResRatio2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_ResRatio2.TextWrap = False
        Me.RadLabel_ResRatio2.ThemeName = "Windows8"
        '
        'RadTextBox_ResRatio2
        '
        Me.RadTextBox_ResRatio2.AutoSize = False
        Me.RadTextBox_ResRatio2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_ResRatio2.Location = New System.Drawing.Point(123, 61)
        Me.RadTextBox_ResRatio2.Name = "RadTextBox_ResRatio2"
        Me.RadTextBox_ResRatio2.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_ResRatio2.TabIndex = 41
        Me.RadTextBox_ResRatio2.ThemeName = "Windows8"
        '
        'RadLabel_ResRatio1
        '
        Me.RadLabel_ResRatio1.AutoSize = False
        Me.RadLabel_ResRatio1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel_ResRatio1.Location = New System.Drawing.Point(12, 30)
        Me.RadLabel_ResRatio1.Name = "RadLabel_ResRatio1"
        Me.RadLabel_ResRatio1.Size = New System.Drawing.Size(90, 25)
        Me.RadLabel_ResRatio1.TabIndex = 40
        Me.RadLabel_ResRatio1.Text = "TissueData_ResRatio1"
        Me.RadLabel_ResRatio1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_ResRatio1.TextWrap = False
        Me.RadLabel_ResRatio1.ThemeName = "Windows8"
        '
        'RadTextBox_ResRatio1
        '
        Me.RadTextBox_ResRatio1.AutoSize = False
        Me.RadTextBox_ResRatio1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_ResRatio1.Location = New System.Drawing.Point(12, 61)
        Me.RadTextBox_ResRatio1.Name = "RadTextBox_ResRatio1"
        Me.RadTextBox_ResRatio1.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_ResRatio1.TabIndex = 39
        Me.RadTextBox_ResRatio1.ThemeName = "Windows8"
        '
        'Panel_Suppliers
        '
        Me.Panel_Suppliers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Suppliers.Controls.Add(Me.RadTextBox_VendorDescription3)
        Me.Panel_Suppliers.Controls.Add(Me.RadTextBox_VendorDescription2)
        Me.Panel_Suppliers.Controls.Add(Me.RadTextBox_VendorDescription1)
        Me.Panel_Suppliers.Controls.Add(Me.RadTextBox_Supplier3)
        Me.Panel_Suppliers.Controls.Add(Me.RadTextBox_Supplier2)
        Me.Panel_Suppliers.Controls.Add(Me.RadTextBox_Supplier1)
        Me.Panel_Suppliers.Controls.Add(Me.RadLabel_VendorDescription)
        Me.Panel_Suppliers.Controls.Add(Me.RadLabel_Supplier)
        Me.Panel_Suppliers.Controls.Add(Me.RadLabel_1)
        Me.Panel_Suppliers.Controls.Add(Me.RadLabel_2)
        Me.Panel_Suppliers.Controls.Add(Me.RadLabel_3)
        Me.Panel_Suppliers.Location = New System.Drawing.Point(460, 398)
        Me.Panel_Suppliers.Name = "Panel_Suppliers"
        Me.Panel_Suppliers.Size = New System.Drawing.Size(602, 133)
        Me.Panel_Suppliers.TabIndex = 76
        '
        'RadTextBox_VendorDescription3
        '
        Me.RadTextBox_VendorDescription3.AutoSize = False
        Me.RadTextBox_VendorDescription3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_VendorDescription3.Location = New System.Drawing.Point(456, 66)
        Me.RadTextBox_VendorDescription3.Multiline = True
        Me.RadTextBox_VendorDescription3.Name = "RadTextBox_VendorDescription3"
        Me.RadTextBox_VendorDescription3.Size = New System.Drawing.Size(122, 46)
        Me.RadTextBox_VendorDescription3.TabIndex = 38
        Me.RadTextBox_VendorDescription3.ThemeName = "Windows8"
        '
        'RadTextBox_VendorDescription2
        '
        Me.RadTextBox_VendorDescription2.AutoSize = False
        Me.RadTextBox_VendorDescription2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_VendorDescription2.Location = New System.Drawing.Point(309, 65)
        Me.RadTextBox_VendorDescription2.Multiline = True
        Me.RadTextBox_VendorDescription2.Name = "RadTextBox_VendorDescription2"
        Me.RadTextBox_VendorDescription2.Size = New System.Drawing.Size(122, 46)
        Me.RadTextBox_VendorDescription2.TabIndex = 37
        Me.RadTextBox_VendorDescription2.ThemeName = "Windows8"
        '
        'RadTextBox_VendorDescription1
        '
        Me.RadTextBox_VendorDescription1.AutoSize = False
        Me.RadTextBox_VendorDescription1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_VendorDescription1.Location = New System.Drawing.Point(161, 65)
        Me.RadTextBox_VendorDescription1.Multiline = True
        Me.RadTextBox_VendorDescription1.Name = "RadTextBox_VendorDescription1"
        Me.RadTextBox_VendorDescription1.Size = New System.Drawing.Size(122, 46)
        Me.RadTextBox_VendorDescription1.TabIndex = 36
        Me.RadTextBox_VendorDescription1.ThemeName = "Windows8"
        '
        'RadTextBox_Supplier3
        '
        Me.RadTextBox_Supplier3.AutoSize = False
        Me.RadTextBox_Supplier3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Supplier3.Location = New System.Drawing.Point(456, 35)
        Me.RadTextBox_Supplier3.Name = "RadTextBox_Supplier3"
        Me.RadTextBox_Supplier3.Size = New System.Drawing.Size(122, 25)
        Me.RadTextBox_Supplier3.TabIndex = 35
        Me.RadTextBox_Supplier3.ThemeName = "Windows8"
        '
        'RadTextBox_Supplier2
        '
        Me.RadTextBox_Supplier2.AutoSize = False
        Me.RadTextBox_Supplier2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Supplier2.Location = New System.Drawing.Point(309, 34)
        Me.RadTextBox_Supplier2.Name = "RadTextBox_Supplier2"
        Me.RadTextBox_Supplier2.Size = New System.Drawing.Size(122, 25)
        Me.RadTextBox_Supplier2.TabIndex = 34
        Me.RadTextBox_Supplier2.ThemeName = "Windows8"
        '
        'RadTextBox_Supplier1
        '
        Me.RadTextBox_Supplier1.AutoSize = False
        Me.RadTextBox_Supplier1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Supplier1.Location = New System.Drawing.Point(161, 34)
        Me.RadTextBox_Supplier1.Name = "RadTextBox_Supplier1"
        Me.RadTextBox_Supplier1.Size = New System.Drawing.Size(122, 25)
        Me.RadTextBox_Supplier1.TabIndex = 33
        Me.RadTextBox_Supplier1.ThemeName = "Windows8"
        '
        'RadLabel_VendorDescription
        '
        Me.RadLabel_VendorDescription.AutoSize = False
        Me.RadLabel_VendorDescription.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_VendorDescription.Location = New System.Drawing.Point(3, 64)
        Me.RadLabel_VendorDescription.Name = "RadLabel_VendorDescription"
        Me.RadLabel_VendorDescription.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_VendorDescription.TabIndex = 32
        Me.RadLabel_VendorDescription.Text = "TissueData_VendorDescription"
        Me.RadLabel_VendorDescription.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_VendorDescription.TextWrap = False
        Me.RadLabel_VendorDescription.ThemeName = "Windows8"
        '
        'RadLabel_Supplier
        '
        Me.RadLabel_Supplier.AutoSize = False
        Me.RadLabel_Supplier.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Supplier.Location = New System.Drawing.Point(3, 34)
        Me.RadLabel_Supplier.Name = "RadLabel_Supplier"
        Me.RadLabel_Supplier.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_Supplier.TabIndex = 31
        Me.RadLabel_Supplier.Text = "TissueData_Supplier"
        Me.RadLabel_Supplier.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Supplier.TextWrap = False
        Me.RadLabel_Supplier.ThemeName = "Windows8"
        '
        'RadLabel_1
        '
        Me.RadLabel_1.AutoSize = False
        Me.RadLabel_1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_1.Location = New System.Drawing.Point(161, 7)
        Me.RadLabel_1.Name = "RadLabel_1"
        Me.RadLabel_1.Size = New System.Drawing.Size(122, 25)
        Me.RadLabel_1.TabIndex = 30
        Me.RadLabel_1.Text = "1"
        Me.RadLabel_1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_1.TextWrap = False
        Me.RadLabel_1.ThemeName = "Windows8"
        '
        'RadLabel_2
        '
        Me.RadLabel_2.AutoSize = False
        Me.RadLabel_2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_2.Location = New System.Drawing.Point(309, 7)
        Me.RadLabel_2.Name = "RadLabel_2"
        Me.RadLabel_2.Size = New System.Drawing.Size(122, 25)
        Me.RadLabel_2.TabIndex = 29
        Me.RadLabel_2.Text = "2"
        Me.RadLabel_2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_2.TextWrap = False
        Me.RadLabel_2.ThemeName = "Windows8"
        '
        'RadLabel_3
        '
        Me.RadLabel_3.AutoSize = False
        Me.RadLabel_3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_3.Location = New System.Drawing.Point(456, 7)
        Me.RadLabel_3.Name = "RadLabel_3"
        Me.RadLabel_3.Size = New System.Drawing.Size(122, 25)
        Me.RadLabel_3.TabIndex = 28
        Me.RadLabel_3.Text = "3"
        Me.RadLabel_3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_3.TextWrap = False
        Me.RadLabel_3.ThemeName = "Windows8"
        '
        'RadTextBox_Specification
        '
        Me.RadTextBox_Specification.AutoSize = False
        Me.RadTextBox_Specification.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Specification.Location = New System.Drawing.Point(178, 292)
        Me.RadTextBox_Specification.Name = "RadTextBox_Specification"
        Me.RadTextBox_Specification.Size = New System.Drawing.Size(130, 25)
        Me.RadTextBox_Specification.TabIndex = 78
        Me.RadTextBox_Specification.ThemeName = "Windows8"
        '
        'RadLabel_Specification
        '
        Me.RadLabel_Specification.AutoSize = False
        Me.RadLabel_Specification.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Specification.Location = New System.Drawing.Point(37, 292)
        Me.RadLabel_Specification.Name = "RadLabel_Specification"
        Me.RadLabel_Specification.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_Specification.TabIndex = 77
        Me.RadLabel_Specification.Text = "TissueData_Specification"
        Me.RadLabel_Specification.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Specification.TextWrap = False
        Me.RadLabel_Specification.ThemeName = "Windows8"
        '
        'RadTextBox_MSpecNo
        '
        Me.RadTextBox_MSpecNo.AutoSize = False
        Me.RadTextBox_MSpecNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_MSpecNo.Location = New System.Drawing.Point(178, 323)
        Me.RadTextBox_MSpecNo.Name = "RadTextBox_MSpecNo"
        Me.RadTextBox_MSpecNo.Size = New System.Drawing.Size(130, 25)
        Me.RadTextBox_MSpecNo.TabIndex = 80
        Me.RadTextBox_MSpecNo.ThemeName = "Windows8"
        '
        'RadLabel_MSpecNo
        '
        Me.RadLabel_MSpecNo.AutoSize = False
        Me.RadLabel_MSpecNo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MSpecNo.Location = New System.Drawing.Point(37, 323)
        Me.RadLabel_MSpecNo.Name = "RadLabel_MSpecNo"
        Me.RadLabel_MSpecNo.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_MSpecNo.TabIndex = 79
        Me.RadLabel_MSpecNo.Text = "TissueData_MSpecNo"
        Me.RadLabel_MSpecNo.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_MSpecNo.TextWrap = False
        Me.RadLabel_MSpecNo.ThemeName = "Windows8"
        '
        'RadTextBox_CurrentCost
        '
        Me.RadTextBox_CurrentCost.AutoSize = False
        Me.RadTextBox_CurrentCost.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_CurrentCost.Location = New System.Drawing.Point(178, 398)
        Me.RadTextBox_CurrentCost.Name = "RadTextBox_CurrentCost"
        Me.RadTextBox_CurrentCost.Size = New System.Drawing.Size(89, 25)
        Me.RadTextBox_CurrentCost.TabIndex = 82
        Me.RadTextBox_CurrentCost.ThemeName = "Windows8"
        '
        'RadLabel_CurrentCost
        '
        Me.RadLabel_CurrentCost.AutoSize = False
        Me.RadLabel_CurrentCost.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_CurrentCost.Location = New System.Drawing.Point(37, 398)
        Me.RadLabel_CurrentCost.Name = "RadLabel_CurrentCost"
        Me.RadLabel_CurrentCost.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_CurrentCost.TabIndex = 81
        Me.RadLabel_CurrentCost.Text = "TissueData_CurrentCost"
        Me.RadLabel_CurrentCost.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_CurrentCost.TextWrap = False
        Me.RadLabel_CurrentCost.ThemeName = "Windows8"
        '
        'RadTextBox_CurrentCostSource
        '
        Me.RadTextBox_CurrentCostSource.AutoSize = False
        Me.RadTextBox_CurrentCostSource.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_CurrentCostSource.Location = New System.Drawing.Point(282, 398)
        Me.RadTextBox_CurrentCostSource.Name = "RadTextBox_CurrentCostSource"
        Me.RadTextBox_CurrentCostSource.Size = New System.Drawing.Size(162, 25)
        Me.RadTextBox_CurrentCostSource.TabIndex = 83
        Me.RadTextBox_CurrentCostSource.ThemeName = "Windows8"
        '
        'RadTextBox_PreviousCostSource
        '
        Me.RadTextBox_PreviousCostSource.AutoSize = False
        Me.RadTextBox_PreviousCostSource.Enabled = False
        Me.RadTextBox_PreviousCostSource.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_PreviousCostSource.Location = New System.Drawing.Point(282, 429)
        Me.RadTextBox_PreviousCostSource.Name = "RadTextBox_PreviousCostSource"
        Me.RadTextBox_PreviousCostSource.Size = New System.Drawing.Size(162, 25)
        Me.RadTextBox_PreviousCostSource.TabIndex = 86
        Me.RadTextBox_PreviousCostSource.ThemeName = "Windows8"
        '
        'RadTextBox_PreviousCost
        '
        Me.RadTextBox_PreviousCost.AutoSize = False
        Me.RadTextBox_PreviousCost.Enabled = False
        Me.RadTextBox_PreviousCost.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_PreviousCost.Location = New System.Drawing.Point(178, 429)
        Me.RadTextBox_PreviousCost.Name = "RadTextBox_PreviousCost"
        Me.RadTextBox_PreviousCost.Size = New System.Drawing.Size(89, 25)
        Me.RadTextBox_PreviousCost.TabIndex = 85
        Me.RadTextBox_PreviousCost.ThemeName = "Windows8"
        '
        'RadLabel_PreviousCost
        '
        Me.RadLabel_PreviousCost.AutoSize = False
        Me.RadLabel_PreviousCost.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_PreviousCost.Location = New System.Drawing.Point(37, 429)
        Me.RadLabel_PreviousCost.Name = "RadLabel_PreviousCost"
        Me.RadLabel_PreviousCost.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_PreviousCost.TabIndex = 84
        Me.RadLabel_PreviousCost.Text = "TissueData_PreviousCost"
        Me.RadLabel_PreviousCost.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_PreviousCost.TextWrap = False
        Me.RadLabel_PreviousCost.ThemeName = "Windows8"
        '
        'RadTextBox_PreviousCostBase
        '
        Me.RadTextBox_PreviousCostBase.AutoSize = False
        Me.RadTextBox_PreviousCostBase.Enabled = False
        Me.RadTextBox_PreviousCostBase.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_PreviousCostBase.Location = New System.Drawing.Point(178, 506)
        Me.RadTextBox_PreviousCostBase.Name = "RadTextBox_PreviousCostBase"
        Me.RadTextBox_PreviousCostBase.Size = New System.Drawing.Size(89, 25)
        Me.RadTextBox_PreviousCostBase.TabIndex = 87
        Me.RadTextBox_PreviousCostBase.ThemeName = "Windows8"
        '
        'RadTextBox_CurrentCostBase
        '
        Me.RadTextBox_CurrentCostBase.AutoSize = False
        Me.RadTextBox_CurrentCostBase.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_CurrentCostBase.Location = New System.Drawing.Point(178, 478)
        Me.RadTextBox_CurrentCostBase.Name = "RadTextBox_CurrentCostBase"
        Me.RadTextBox_CurrentCostBase.Size = New System.Drawing.Size(89, 25)
        Me.RadTextBox_CurrentCostBase.TabIndex = 88
        Me.RadTextBox_CurrentCostBase.ThemeName = "Windows8"
        '
        'RadLabel_TissueIndexDataSubform
        '
        Me.RadLabel_TissueIndexDataSubform.AutoSize = False
        Me.RadLabel_TissueIndexDataSubform.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_TissueIndexDataSubform.Location = New System.Drawing.Point(282, 461)
        Me.RadLabel_TissueIndexDataSubform.Name = "RadLabel_TissueIndexDataSubform"
        Me.RadLabel_TissueIndexDataSubform.Size = New System.Drawing.Size(162, 15)
        Me.RadLabel_TissueIndexDataSubform.TabIndex = 89
        Me.RadLabel_TissueIndexDataSubform.Text = "TissueData_TissueIndexDataSubform"
        Me.RadLabel_TissueIndexDataSubform.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_TissueIndexDataSubform.TextWrap = False
        Me.RadLabel_TissueIndexDataSubform.ThemeName = "Windows8"
        '
        'RadGridView1
        '
        Me.RadGridView1.Location = New System.Drawing.Point(282, 478)
        '
        '
        '
        Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.Size = New System.Drawing.Size(162, 53)
        Me.RadGridView1.TabIndex = 90
        Me.RadGridView1.Text = "RadGridView1"
        '
        'TissueData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1099, 566)
        Me.Controls.Add(Me.RadGridView1)
        Me.Controls.Add(Me.RadLabel_TissueIndexDataSubform)
        Me.Controls.Add(Me.RadTextBox_CurrentCostBase)
        Me.Controls.Add(Me.RadTextBox_PreviousCostBase)
        Me.Controls.Add(Me.RadTextBox_PreviousCostSource)
        Me.Controls.Add(Me.RadTextBox_PreviousCost)
        Me.Controls.Add(Me.RadLabel_PreviousCost)
        Me.Controls.Add(Me.RadTextBox_CurrentCostSource)
        Me.Controls.Add(Me.RadTextBox_CurrentCost)
        Me.Controls.Add(Me.RadLabel_CurrentCost)
        Me.Controls.Add(Me.RadTextBox_MSpecNo)
        Me.Controls.Add(Me.RadLabel_MSpecNo)
        Me.Controls.Add(Me.RadTextBox_Specification)
        Me.Controls.Add(Me.RadLabel_Specification)
        Me.Controls.Add(Me.Panel_Suppliers)
        Me.Controls.Add(Me.RadLabel_ElectrolyteData)
        Me.Controls.Add(Me.Panel_ElectrolyteData)
        Me.Controls.Add(Me.RadLabel_ParticleDensityUnit)
        Me.Controls.Add(Me.RadTextBox_ParticleDensity)
        Me.Controls.Add(Me.RadLabel_ParticleDensity)
        Me.Controls.Add(Me.RadLabel_VoidVolumeUnit)
        Me.Controls.Add(Me.RadTextBox_VoidVolume)
        Me.Controls.Add(Me.RadLabel_VoidVolume)
        Me.Controls.Add(Me.RadLabel_DensityUnit)
        Me.Controls.Add(Me.RadTextBox_Density)
        Me.Controls.Add(Me.RadLabel_Density)
        Me.Controls.Add(Me.RadLabel_ThicknessUnit)
        Me.Controls.Add(Me.RadTextBox_Thickness)
        Me.Controls.Add(Me.RadLabel_Thickness)
        Me.Controls.Add(Me.RadCheckBox_Obsolete)
        Me.Controls.Add(Me.RadCheckBox_Active)
        Me.Controls.Add(Me.RadDropDownList_PaperName)
        Me.Controls.Add(Me.RadLabel_PaperName)
        Me.Controls.Add(Me.RadLabel_Tissue)
        Me.Controls.Add(Me.RadTextBox_Tissue)
        Me.Controls.Add(Me.RadLabel_OracleData)
        Me.Controls.Add(Me.Panel_OracleData)
        Me.Controls.Add(Me.Panel_Header)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TissueData"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "TissueData_TitleWindow"
        Me.ThemeName = "Windows8"
        Me.Panel_Header.ResumeLayout(False)
        CType(Me.RadButton_WhereUsed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_OracleData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_OracleData.ResumeLayout(False)
        CType(Me.RadLabel_RateCode, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.RadLabel_Tissue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Tissue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_Obsolete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_Active, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_PaperName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PaperName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ThicknessUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Thickness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Thickness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_DensityUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Density, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Density, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_VoidVolumeUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_VoidVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_VoidVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ParticleDensityUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ParticleDensity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ParticleDensity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ElectrolyteData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_ElectrolyteData.ResumeLayout(False)
        CType(Me.RadCheckBox_OkForBLO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_OkForGlycol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ResRatio6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ResRatio6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ResRatio5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ResRatio5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ResRatio4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ResRatio4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ResRatio3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ResRatio3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ResRatio2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ResRatio2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ResRatio1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ResRatio1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Suppliers.ResumeLayout(False)
        CType(Me.RadTextBox_VendorDescription3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_VendorDescription2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_VendorDescription1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Supplier3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Supplier2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Supplier1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_VendorDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Specification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Specification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_MSpecNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_MSpecNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CurrentCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_CurrentCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CurrentCostSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_PreviousCostSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_PreviousCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PreviousCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_PreviousCostBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CurrentCostBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TissueIndexDataSubform, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Header As System.Windows.Forms.Panel
    Friend WithEvents RadButton_WhereUsed As Telerik.WinControls.UI.RadButton
    Friend WithEvents PictureBox_KemetLogo As System.Windows.Forms.PictureBox
    Friend WithEvents RadLabel_Title As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_OracleData As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel_OracleData As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_RateCode As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_RateCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadCheckBox_MultilevelBackflushFlag As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_BackflushFlag As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_StagingFlag As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel_BackflushWarehouse As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_StagingWarehouse As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_FirstOp As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_BackflushWarehouse As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_StagingWarehouse As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_FirstOp As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Tissue As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Tissue As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadCheckBox_Obsolete As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_Active As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadDropDownList_PaperName As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_PaperName As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_ThicknessUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Thickness As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Thickness As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_DensityUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Density As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Density As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_VoidVolumeUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_VoidVolume As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_VoidVolume As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_ParticleDensityUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_ParticleDensity As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_ParticleDensity As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_ElectrolyteData As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel_ElectrolyteData As System.Windows.Forms.Panel
    Friend WithEvents RadCheckBox_OkForBLO As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_OkForGlycol As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel_ResRatio6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_ResRatio6 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_ResRatio5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_ResRatio5 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_ResRatio4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_ResRatio4 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_ResRatio3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_ResRatio3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_ResRatio2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_ResRatio2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_ResRatio1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_ResRatio1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Panel_Suppliers As System.Windows.Forms.Panel
    Friend WithEvents RadTextBox_VendorDescription3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_VendorDescription2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_VendorDescription1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Supplier3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Supplier2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Supplier1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_VendorDescription As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Supplier As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Specification As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Specification As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_MSpecNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_MSpecNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_CurrentCostSource As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_PreviousCost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_CurrentCost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_CurrentCost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_PreviousCostSource As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_PreviousCost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_PreviousCostBase As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_CurrentCostBase As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_TissueIndexDataSubform As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
End Class

