<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CathodeData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CathodeData))
        Me.Panel_Header = New System.Windows.Forms.Panel()
        Me.RadButton_ShowAllCathodes = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_WhereUsed = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox_KemetLogo = New System.Windows.Forms.PictureBox()
        Me.RadLabel_Title = New Telerik.WinControls.UI.RadLabel()
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
        Me.RadTextBox_Description = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Description = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_ResistanceUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Resistance = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Resistance = New Telerik.WinControls.UI.RadLabel()
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
        Me.RadCheckBox_Obsolete = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_Active = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadDropDownList_CathodeName = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_CathodeName = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_OracleData = New Telerik.WinControls.UI.RadLabel()
        Me.Panel_OracleData = New System.Windows.Forms.Panel()
        Me.RadCheckBox_MultilevelBackflushFlag = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_BackflushFlag = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_StagingFlag = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel_BackflushWarehouse = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_StagingWarehouse = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_FirstOp = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_BackflushWarehouse = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_StagingWarehouse = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_FirstOp = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Specification = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Specification = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Cathode = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Cathode = New Telerik.WinControls.UI.RadLabel()
        Me.Panel_Header.SuspendLayout()
        CType(Me.RadButton_ShowAllCathodes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_WhereUsed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Title, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.RadTextBox_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ResistanceUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Resistance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Resistance, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.RadCheckBox_Obsolete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_Active, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_CathodeName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_CathodeName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_OracleData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_OracleData.SuspendLayout()
        CType(Me.RadCheckBox_MultilevelBackflushFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_BackflushFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_StagingFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_BackflushWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_StagingWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_FirstOp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_BackflushWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_StagingWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_FirstOp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Specification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Specification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Cathode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Cathode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Header
        '
        Me.Panel_Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Header.Controls.Add(Me.RadButton_ShowAllCathodes)
        Me.Panel_Header.Controls.Add(Me.RadButton_WhereUsed)
        Me.Panel_Header.Controls.Add(Me.PictureBox_KemetLogo)
        Me.Panel_Header.Controls.Add(Me.RadLabel_Title)
        Me.Panel_Header.Location = New System.Drawing.Point(-5, -2)
        Me.Panel_Header.Name = "Panel_Header"
        Me.Panel_Header.Size = New System.Drawing.Size(900, 68)
        Me.Panel_Header.TabIndex = 4
        '
        'RadButton_ShowAllCathodes
        '
        Me.RadButton_ShowAllCathodes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_ShowAllCathodes.Location = New System.Drawing.Point(373, 8)
        Me.RadButton_ShowAllCathodes.Name = "RadButton_ShowAllCathodes"
        Me.RadButton_ShowAllCathodes.Size = New System.Drawing.Size(100, 50)
        Me.RadButton_ShowAllCathodes.TabIndex = 13
        Me.RadButton_ShowAllCathodes.Text = "CathodeData_ShowAllCathodes"
        Me.RadButton_ShowAllCathodes.TextWrap = True
        Me.RadButton_ShowAllCathodes.ThemeName = "Windows8"
        '
        'RadButton_WhereUsed
        '
        Me.RadButton_WhereUsed.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_WhereUsed.Location = New System.Drawing.Point(254, 8)
        Me.RadButton_WhereUsed.Name = "RadButton_WhereUsed"
        Me.RadButton_WhereUsed.Size = New System.Drawing.Size(100, 50)
        Me.RadButton_WhereUsed.TabIndex = 12
        Me.RadButton_WhereUsed.Text = "CathodeData_WhereUsed"
        Me.RadButton_WhereUsed.TextWrap = True
        Me.RadButton_WhereUsed.ThemeName = "Windows8"
        '
        'PictureBox_KemetLogo
        '
        Me.PictureBox_KemetLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox_KemetLogo.Image = Global.ECAD.My.Resources.Resources.kemet_logo_small
        Me.PictureBox_KemetLogo.Location = New System.Drawing.Point(762, 4)
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
        Me.RadLabel_Title.Text = "CathodeData_Title"
        Me.RadLabel_Title.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Title.TextWrap = False
        Me.RadLabel_Title.ThemeName = "Windows8"
        '
        'RadTextBox_CurrentCostBase
        '
        Me.RadTextBox_CurrentCostBase.AutoSize = False
        Me.RadTextBox_CurrentCostBase.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_CurrentCostBase.Location = New System.Drawing.Point(498, 502)
        Me.RadTextBox_CurrentCostBase.Name = "RadTextBox_CurrentCostBase"
        Me.RadTextBox_CurrentCostBase.Size = New System.Drawing.Size(126, 25)
        Me.RadTextBox_CurrentCostBase.TabIndex = 122
        Me.RadTextBox_CurrentCostBase.ThemeName = "Windows8"
        '
        'RadTextBox_PreviousCostBase
        '
        Me.RadTextBox_PreviousCostBase.AutoSize = False
        Me.RadTextBox_PreviousCostBase.Enabled = False
        Me.RadTextBox_PreviousCostBase.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_PreviousCostBase.Location = New System.Drawing.Point(498, 533)
        Me.RadTextBox_PreviousCostBase.Name = "RadTextBox_PreviousCostBase"
        Me.RadTextBox_PreviousCostBase.Size = New System.Drawing.Size(126, 25)
        Me.RadTextBox_PreviousCostBase.TabIndex = 127
        Me.RadTextBox_PreviousCostBase.ThemeName = "Windows8"
        '
        'RadTextBox_PreviousCostSource
        '
        Me.RadTextBox_PreviousCostSource.AutoSize = False
        Me.RadTextBox_PreviousCostSource.Enabled = False
        Me.RadTextBox_PreviousCostSource.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_PreviousCostSource.Location = New System.Drawing.Point(325, 533)
        Me.RadTextBox_PreviousCostSource.Name = "RadTextBox_PreviousCostSource"
        Me.RadTextBox_PreviousCostSource.Size = New System.Drawing.Size(151, 25)
        Me.RadTextBox_PreviousCostSource.TabIndex = 126
        Me.RadTextBox_PreviousCostSource.ThemeName = "Windows8"
        '
        'RadTextBox_PreviousCost
        '
        Me.RadTextBox_PreviousCost.AutoSize = False
        Me.RadTextBox_PreviousCost.Enabled = False
        Me.RadTextBox_PreviousCost.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_PreviousCost.Location = New System.Drawing.Point(177, 533)
        Me.RadTextBox_PreviousCost.Name = "RadTextBox_PreviousCost"
        Me.RadTextBox_PreviousCost.Size = New System.Drawing.Size(126, 25)
        Me.RadTextBox_PreviousCost.TabIndex = 125
        Me.RadTextBox_PreviousCost.ThemeName = "Windows8"
        '
        'RadLabel_PreviousCost
        '
        Me.RadLabel_PreviousCost.AutoSize = False
        Me.RadLabel_PreviousCost.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_PreviousCost.Location = New System.Drawing.Point(36, 533)
        Me.RadLabel_PreviousCost.Name = "RadLabel_PreviousCost"
        Me.RadLabel_PreviousCost.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_PreviousCost.TabIndex = 124
        Me.RadLabel_PreviousCost.Text = "CathodeData_PreviousCost"
        Me.RadLabel_PreviousCost.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_PreviousCost.TextWrap = False
        Me.RadLabel_PreviousCost.ThemeName = "Windows8"
        '
        'RadLabel_MatOnly
        '
        Me.RadLabel_MatOnly.AutoSize = False
        Me.RadLabel_MatOnly.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_MatOnly.Location = New System.Drawing.Point(498, 478)
        Me.RadLabel_MatOnly.Name = "RadLabel_MatOnly"
        Me.RadLabel_MatOnly.Size = New System.Drawing.Size(126, 25)
        Me.RadLabel_MatOnly.TabIndex = 123
        Me.RadLabel_MatOnly.Text = "CathodeData_MatOnly"
        Me.RadLabel_MatOnly.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_MatOnly.TextWrap = False
        Me.RadLabel_MatOnly.ThemeName = "Windows8"
        '
        'RadTextBox_CurrentCostSource
        '
        Me.RadTextBox_CurrentCostSource.AutoSize = False
        Me.RadTextBox_CurrentCostSource.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_CurrentCostSource.Location = New System.Drawing.Point(325, 502)
        Me.RadTextBox_CurrentCostSource.Name = "RadTextBox_CurrentCostSource"
        Me.RadTextBox_CurrentCostSource.Size = New System.Drawing.Size(151, 25)
        Me.RadTextBox_CurrentCostSource.TabIndex = 121
        Me.RadTextBox_CurrentCostSource.ThemeName = "Windows8"
        '
        'RadTextBox_CurrentCost
        '
        Me.RadTextBox_CurrentCost.AutoSize = False
        Me.RadTextBox_CurrentCost.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_CurrentCost.Location = New System.Drawing.Point(177, 502)
        Me.RadTextBox_CurrentCost.Name = "RadTextBox_CurrentCost"
        Me.RadTextBox_CurrentCost.Size = New System.Drawing.Size(126, 25)
        Me.RadTextBox_CurrentCost.TabIndex = 120
        Me.RadTextBox_CurrentCost.ThemeName = "Windows8"
        '
        'RadLabel_CurrentCost
        '
        Me.RadLabel_CurrentCost.AutoSize = False
        Me.RadLabel_CurrentCost.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_CurrentCost.Location = New System.Drawing.Point(36, 502)
        Me.RadLabel_CurrentCost.Name = "RadLabel_CurrentCost"
        Me.RadLabel_CurrentCost.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_CurrentCost.TabIndex = 119
        Me.RadLabel_CurrentCost.Text = "CathodeData_CurrentCost"
        Me.RadLabel_CurrentCost.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_CurrentCost.TextWrap = False
        Me.RadLabel_CurrentCost.ThemeName = "Windows8"
        '
        'RadTextBox_MSpecNo
        '
        Me.RadTextBox_MSpecNo.AutoSize = False
        Me.RadTextBox_MSpecNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_MSpecNo.Location = New System.Drawing.Point(177, 458)
        Me.RadTextBox_MSpecNo.Name = "RadTextBox_MSpecNo"
        Me.RadTextBox_MSpecNo.Size = New System.Drawing.Size(126, 25)
        Me.RadTextBox_MSpecNo.TabIndex = 118
        Me.RadTextBox_MSpecNo.ThemeName = "Windows8"
        '
        'RadLabel_MSpecNo
        '
        Me.RadLabel_MSpecNo.AutoSize = False
        Me.RadLabel_MSpecNo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MSpecNo.Location = New System.Drawing.Point(36, 458)
        Me.RadLabel_MSpecNo.Name = "RadLabel_MSpecNo"
        Me.RadLabel_MSpecNo.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_MSpecNo.TabIndex = 117
        Me.RadLabel_MSpecNo.Text = "CathodeData_MSpecNo"
        Me.RadLabel_MSpecNo.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_MSpecNo.TextWrap = False
        Me.RadLabel_MSpecNo.ThemeName = "Windows8"
        '
        'RadTextBox_Supplier
        '
        Me.RadTextBox_Supplier.AutoSize = False
        Me.RadTextBox_Supplier.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Supplier.Location = New System.Drawing.Point(177, 427)
        Me.RadTextBox_Supplier.Name = "RadTextBox_Supplier"
        Me.RadTextBox_Supplier.Size = New System.Drawing.Size(274, 25)
        Me.RadTextBox_Supplier.TabIndex = 116
        Me.RadTextBox_Supplier.ThemeName = "Windows8"
        '
        'RadLabel_Supplier
        '
        Me.RadLabel_Supplier.AutoSize = False
        Me.RadLabel_Supplier.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Supplier.Location = New System.Drawing.Point(36, 427)
        Me.RadLabel_Supplier.Name = "RadLabel_Supplier"
        Me.RadLabel_Supplier.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_Supplier.TabIndex = 115
        Me.RadLabel_Supplier.Text = "CathodeData_Supplier"
        Me.RadLabel_Supplier.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Supplier.TextWrap = False
        Me.RadLabel_Supplier.ThemeName = "Windows8"
        '
        'RadTextBox_Description
        '
        Me.RadTextBox_Description.AutoSize = False
        Me.RadTextBox_Description.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Description.Location = New System.Drawing.Point(177, 343)
        Me.RadTextBox_Description.Multiline = True
        Me.RadTextBox_Description.Name = "RadTextBox_Description"
        Me.RadTextBox_Description.Size = New System.Drawing.Size(274, 75)
        Me.RadTextBox_Description.TabIndex = 114
        Me.RadTextBox_Description.ThemeName = "Windows8"
        '
        'RadLabel_Description
        '
        Me.RadLabel_Description.AutoSize = False
        Me.RadLabel_Description.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Description.Location = New System.Drawing.Point(36, 343)
        Me.RadLabel_Description.Name = "RadLabel_Description"
        Me.RadLabel_Description.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_Description.TabIndex = 113
        Me.RadLabel_Description.Text = "CathodeData_Description"
        Me.RadLabel_Description.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Description.TextWrap = False
        Me.RadLabel_Description.ThemeName = "Windows8"
        '
        'RadLabel_ResistanceUnit
        '
        Me.RadLabel_ResistanceUnit.AutoSize = False
        Me.RadLabel_ResistanceUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_ResistanceUnit.Location = New System.Drawing.Point(259, 266)
        Me.RadLabel_ResistanceUnit.Name = "RadLabel_ResistanceUnit"
        Me.RadLabel_ResistanceUnit.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_ResistanceUnit.TabIndex = 110
        Me.RadLabel_ResistanceUnit.Text = "Units_Ohm"
        Me.RadLabel_ResistanceUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_ResistanceUnit.TextWrap = False
        Me.RadLabel_ResistanceUnit.ThemeName = "Windows8"
        '
        'RadTextBox_Resistance
        '
        Me.RadTextBox_Resistance.AutoSize = False
        Me.RadTextBox_Resistance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Resistance.Location = New System.Drawing.Point(177, 266)
        Me.RadTextBox_Resistance.Name = "RadTextBox_Resistance"
        Me.RadTextBox_Resistance.Size = New System.Drawing.Size(78, 25)
        Me.RadTextBox_Resistance.TabIndex = 109
        Me.RadTextBox_Resistance.ThemeName = "Windows8"
        '
        'RadLabel_Resistance
        '
        Me.RadLabel_Resistance.AutoSize = False
        Me.RadLabel_Resistance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Resistance.Location = New System.Drawing.Point(36, 266)
        Me.RadLabel_Resistance.Name = "RadLabel_Resistance"
        Me.RadLabel_Resistance.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_Resistance.TabIndex = 108
        Me.RadLabel_Resistance.Text = "CathodeData_Resistance"
        Me.RadLabel_Resistance.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Resistance.TextWrap = False
        Me.RadLabel_Resistance.ThemeName = "Windows8"
        '
        'RadLabel_PurityUnit
        '
        Me.RadLabel_PurityUnit.AutoSize = False
        Me.RadLabel_PurityUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_PurityUnit.Location = New System.Drawing.Point(259, 235)
        Me.RadLabel_PurityUnit.Name = "RadLabel_PurityUnit"
        Me.RadLabel_PurityUnit.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_PurityUnit.TabIndex = 107
        Me.RadLabel_PurityUnit.Text = "Global_Percentage"
        Me.RadLabel_PurityUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_PurityUnit.TextWrap = False
        Me.RadLabel_PurityUnit.ThemeName = "Windows8"
        '
        'RadTextBox_Purity
        '
        Me.RadTextBox_Purity.AutoSize = False
        Me.RadTextBox_Purity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Purity.Location = New System.Drawing.Point(177, 235)
        Me.RadTextBox_Purity.Name = "RadTextBox_Purity"
        Me.RadTextBox_Purity.Size = New System.Drawing.Size(78, 25)
        Me.RadTextBox_Purity.TabIndex = 106
        Me.RadTextBox_Purity.ThemeName = "Windows8"
        '
        'RadLabel_Purity
        '
        Me.RadLabel_Purity.AutoSize = False
        Me.RadLabel_Purity.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Purity.Location = New System.Drawing.Point(36, 235)
        Me.RadLabel_Purity.Name = "RadLabel_Purity"
        Me.RadLabel_Purity.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_Purity.TabIndex = 105
        Me.RadLabel_Purity.Text = "CathodeData_Purity"
        Me.RadLabel_Purity.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Purity.TextWrap = False
        Me.RadLabel_Purity.ThemeName = "Windows8"
        '
        'RadLabel_AreaWeightRatioUnit
        '
        Me.RadLabel_AreaWeightRatioUnit.AutoSize = False
        Me.RadLabel_AreaWeightRatioUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_AreaWeightRatioUnit.Location = New System.Drawing.Point(259, 204)
        Me.RadLabel_AreaWeightRatioUnit.Name = "RadLabel_AreaWeightRatioUnit"
        Me.RadLabel_AreaWeightRatioUnit.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_AreaWeightRatioUnit.TabIndex = 104
        Me.RadLabel_AreaWeightRatioUnit.Text = "Units_GramPerSquareCm"
        Me.RadLabel_AreaWeightRatioUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_AreaWeightRatioUnit.TextWrap = False
        Me.RadLabel_AreaWeightRatioUnit.ThemeName = "Windows8"
        '
        'RadTextBox_AreaWeightRatio
        '
        Me.RadTextBox_AreaWeightRatio.AutoSize = False
        Me.RadTextBox_AreaWeightRatio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_AreaWeightRatio.Location = New System.Drawing.Point(177, 204)
        Me.RadTextBox_AreaWeightRatio.Name = "RadTextBox_AreaWeightRatio"
        Me.RadTextBox_AreaWeightRatio.Size = New System.Drawing.Size(78, 25)
        Me.RadTextBox_AreaWeightRatio.TabIndex = 103
        Me.RadTextBox_AreaWeightRatio.ThemeName = "Windows8"
        '
        'RadLabel_AreaWeightRatio
        '
        Me.RadLabel_AreaWeightRatio.AutoSize = False
        Me.RadLabel_AreaWeightRatio.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_AreaWeightRatio.Location = New System.Drawing.Point(36, 204)
        Me.RadLabel_AreaWeightRatio.Name = "RadLabel_AreaWeightRatio"
        Me.RadLabel_AreaWeightRatio.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_AreaWeightRatio.TabIndex = 102
        Me.RadLabel_AreaWeightRatio.Text = "CathodeData_AreaWeightRatio"
        Me.RadLabel_AreaWeightRatio.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_AreaWeightRatio.TextWrap = False
        Me.RadLabel_AreaWeightRatio.ThemeName = "Windows8"
        '
        'RadLabel_ThicknessUnit
        '
        Me.RadLabel_ThicknessUnit.AutoSize = False
        Me.RadLabel_ThicknessUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_ThicknessUnit.Location = New System.Drawing.Point(259, 173)
        Me.RadLabel_ThicknessUnit.Name = "RadLabel_ThicknessUnit"
        Me.RadLabel_ThicknessUnit.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_ThicknessUnit.TabIndex = 101
        Me.RadLabel_ThicknessUnit.Text = "Units_MicroMeter"
        Me.RadLabel_ThicknessUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_ThicknessUnit.TextWrap = False
        Me.RadLabel_ThicknessUnit.ThemeName = "Windows8"
        '
        'RadTextBox_Thickness
        '
        Me.RadTextBox_Thickness.AutoSize = False
        Me.RadTextBox_Thickness.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Thickness.Location = New System.Drawing.Point(177, 173)
        Me.RadTextBox_Thickness.Name = "RadTextBox_Thickness"
        Me.RadTextBox_Thickness.Size = New System.Drawing.Size(78, 25)
        Me.RadTextBox_Thickness.TabIndex = 100
        Me.RadTextBox_Thickness.ThemeName = "Windows8"
        '
        'RadLabel_Thickness
        '
        Me.RadLabel_Thickness.AutoSize = False
        Me.RadLabel_Thickness.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Thickness.Location = New System.Drawing.Point(36, 173)
        Me.RadLabel_Thickness.Name = "RadLabel_Thickness"
        Me.RadLabel_Thickness.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_Thickness.TabIndex = 99
        Me.RadLabel_Thickness.Text = "CathodeData_Thickness"
        Me.RadLabel_Thickness.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Thickness.TextWrap = False
        Me.RadLabel_Thickness.ThemeName = "Windows8"
        '
        'RadLabel_GainUnit
        '
        Me.RadLabel_GainUnit.AutoSize = False
        Me.RadLabel_GainUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_GainUnit.Location = New System.Drawing.Point(259, 142)
        Me.RadLabel_GainUnit.Name = "RadLabel_GainUnit"
        Me.RadLabel_GainUnit.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_GainUnit.TabIndex = 98
        Me.RadLabel_GainUnit.Text = "Units_MicroFaradPerSquareCm"
        Me.RadLabel_GainUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_GainUnit.TextWrap = False
        Me.RadLabel_GainUnit.ThemeName = "Windows8"
        '
        'RadTextBox_Gain
        '
        Me.RadTextBox_Gain.AutoSize = False
        Me.RadTextBox_Gain.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Gain.Location = New System.Drawing.Point(177, 142)
        Me.RadTextBox_Gain.Name = "RadTextBox_Gain"
        Me.RadTextBox_Gain.Size = New System.Drawing.Size(78, 25)
        Me.RadTextBox_Gain.TabIndex = 97
        Me.RadTextBox_Gain.ThemeName = "Windows8"
        '
        'RadLabel_Gain
        '
        Me.RadLabel_Gain.AutoSize = False
        Me.RadLabel_Gain.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Gain.Location = New System.Drawing.Point(36, 142)
        Me.RadLabel_Gain.Name = "RadLabel_Gain"
        Me.RadLabel_Gain.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_Gain.TabIndex = 96
        Me.RadLabel_Gain.Text = "CathodeData_Gain"
        Me.RadLabel_Gain.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Gain.TextWrap = False
        Me.RadLabel_Gain.ThemeName = "Windows8"
        '
        'RadCheckBox_Obsolete
        '
        Me.RadCheckBox_Obsolete.AutoSize = False
        Me.RadCheckBox_Obsolete.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Obsolete.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_Obsolete.Location = New System.Drawing.Point(566, 85)
        Me.RadCheckBox_Obsolete.Name = "RadCheckBox_Obsolete"
        Me.RadCheckBox_Obsolete.Size = New System.Drawing.Size(102, 20)
        Me.RadCheckBox_Obsolete.TabIndex = 93
        Me.RadCheckBox_Obsolete.Text = "CathodeData_Obsolete"
        Me.RadCheckBox_Obsolete.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Obsolete.ThemeName = "Windows8"
        '
        'RadCheckBox_Active
        '
        Me.RadCheckBox_Active.AutoSize = False
        Me.RadCheckBox_Active.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Active.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_Active.Location = New System.Drawing.Point(435, 85)
        Me.RadCheckBox_Active.Name = "RadCheckBox_Active"
        Me.RadCheckBox_Active.Size = New System.Drawing.Size(102, 20)
        Me.RadCheckBox_Active.TabIndex = 92
        Me.RadCheckBox_Active.Text = "CathodeData_Active"
        Me.RadCheckBox_Active.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Active.ThemeName = "Windows8"
        '
        'RadDropDownList_CathodeName
        '
        Me.RadDropDownList_CathodeName.AutoSize = False
        Me.RadDropDownList_CathodeName.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.RadDropDownList_CathodeName.Location = New System.Drawing.Point(177, 80)
        Me.RadDropDownList_CathodeName.Name = "RadDropDownList_CathodeName"
        Me.RadDropDownList_CathodeName.Size = New System.Drawing.Size(234, 30)
        Me.RadDropDownList_CathodeName.TabIndex = 91
        Me.RadDropDownList_CathodeName.ThemeName = "Windows8"
        '
        'RadLabel_CathodeName
        '
        Me.RadLabel_CathodeName.AutoSize = False
        Me.RadLabel_CathodeName.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.RadLabel_CathodeName.Location = New System.Drawing.Point(21, 80)
        Me.RadLabel_CathodeName.Name = "RadLabel_CathodeName"
        Me.RadLabel_CathodeName.Size = New System.Drawing.Size(150, 30)
        Me.RadLabel_CathodeName.TabIndex = 90
        Me.RadLabel_CathodeName.Text = "CathodeData_CathodeName"
        Me.RadLabel_CathodeName.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_CathodeName.TextWrap = False
        Me.RadLabel_CathodeName.ThemeName = "Windows8"
        '
        'RadLabel_OracleData
        '
        Me.RadLabel_OracleData.AutoSize = False
        Me.RadLabel_OracleData.BorderVisible = True
        Me.RadLabel_OracleData.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_OracleData.Location = New System.Drawing.Point(598, 153)
        Me.RadLabel_OracleData.Name = "RadLabel_OracleData"
        Me.RadLabel_OracleData.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_OracleData.TabIndex = 89
        Me.RadLabel_OracleData.Text = "CathodeData_OracleData"
        Me.RadLabel_OracleData.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_OracleData.TextWrap = False
        Me.RadLabel_OracleData.ThemeName = "Windows8"
        '
        'Panel_OracleData
        '
        Me.Panel_OracleData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_OracleData.Controls.Add(Me.RadCheckBox_MultilevelBackflushFlag)
        Me.Panel_OracleData.Controls.Add(Me.RadCheckBox_BackflushFlag)
        Me.Panel_OracleData.Controls.Add(Me.RadCheckBox_StagingFlag)
        Me.Panel_OracleData.Controls.Add(Me.RadLabel_BackflushWarehouse)
        Me.Panel_OracleData.Controls.Add(Me.RadLabel_StagingWarehouse)
        Me.Panel_OracleData.Controls.Add(Me.RadLabel_FirstOp)
        Me.Panel_OracleData.Controls.Add(Me.RadTextBox_BackflushWarehouse)
        Me.Panel_OracleData.Controls.Add(Me.RadTextBox_StagingWarehouse)
        Me.Panel_OracleData.Controls.Add(Me.RadTextBox_FirstOp)
        Me.Panel_OracleData.Location = New System.Drawing.Point(581, 169)
        Me.Panel_OracleData.Name = "Panel_OracleData"
        Me.Panel_OracleData.Size = New System.Drawing.Size(287, 189)
        Me.Panel_OracleData.TabIndex = 88
        '
        'RadCheckBox_MultilevelBackflushFlag
        '
        Me.RadCheckBox_MultilevelBackflushFlag.AutoSize = False
        Me.RadCheckBox_MultilevelBackflushFlag.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_MultilevelBackflushFlag.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_MultilevelBackflushFlag.Location = New System.Drawing.Point(-22, 161)
        Me.RadCheckBox_MultilevelBackflushFlag.Name = "RadCheckBox_MultilevelBackflushFlag"
        Me.RadCheckBox_MultilevelBackflushFlag.Size = New System.Drawing.Size(256, 20)
        Me.RadCheckBox_MultilevelBackflushFlag.TabIndex = 43
        Me.RadCheckBox_MultilevelBackflushFlag.Text = "CathodeData_MultilevelBackflushFlag"
        Me.RadCheckBox_MultilevelBackflushFlag.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_MultilevelBackflushFlag.ThemeName = "Windows8"
        '
        'RadCheckBox_BackflushFlag
        '
        Me.RadCheckBox_BackflushFlag.AutoSize = False
        Me.RadCheckBox_BackflushFlag.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_BackflushFlag.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_BackflushFlag.Location = New System.Drawing.Point(-22, 135)
        Me.RadCheckBox_BackflushFlag.Name = "RadCheckBox_BackflushFlag"
        Me.RadCheckBox_BackflushFlag.Size = New System.Drawing.Size(256, 20)
        Me.RadCheckBox_BackflushFlag.TabIndex = 42
        Me.RadCheckBox_BackflushFlag.Text = "CathodeData_BackflushFlag"
        Me.RadCheckBox_BackflushFlag.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_BackflushFlag.ThemeName = "Windows8"
        '
        'RadCheckBox_StagingFlag
        '
        Me.RadCheckBox_StagingFlag.AutoSize = False
        Me.RadCheckBox_StagingFlag.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_StagingFlag.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_StagingFlag.Location = New System.Drawing.Point(-22, 109)
        Me.RadCheckBox_StagingFlag.Name = "RadCheckBox_StagingFlag"
        Me.RadCheckBox_StagingFlag.Size = New System.Drawing.Size(256, 20)
        Me.RadCheckBox_StagingFlag.TabIndex = 41
        Me.RadCheckBox_StagingFlag.Text = "CathodeData_StagingFlag"
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
        Me.RadLabel_BackflushWarehouse.Text = "CathodeData_BackflushWarehouse"
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
        Me.RadLabel_StagingWarehouse.Text = "CathodeData_StagingWarehouse"
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
        Me.RadLabel_FirstOp.Text = "CathodeData_FirstOp"
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
        'RadTextBox_Specification
        '
        Me.RadTextBox_Specification.AutoSize = False
        Me.RadTextBox_Specification.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Specification.Location = New System.Drawing.Point(177, 312)
        Me.RadTextBox_Specification.Name = "RadTextBox_Specification"
        Me.RadTextBox_Specification.Size = New System.Drawing.Size(274, 25)
        Me.RadTextBox_Specification.TabIndex = 129
        Me.RadTextBox_Specification.ThemeName = "Windows8"
        '
        'RadLabel_Specification
        '
        Me.RadLabel_Specification.AutoSize = False
        Me.RadLabel_Specification.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Specification.Location = New System.Drawing.Point(36, 312)
        Me.RadLabel_Specification.Name = "RadLabel_Specification"
        Me.RadLabel_Specification.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_Specification.TabIndex = 128
        Me.RadLabel_Specification.Text = "CathodeData_Specification"
        Me.RadLabel_Specification.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Specification.TextWrap = False
        Me.RadLabel_Specification.ThemeName = "Windows8"
        '
        'RadTextBox_Cathode
        '
        Me.RadTextBox_Cathode.AutoSize = False
        Me.RadTextBox_Cathode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Cathode.Location = New System.Drawing.Point(798, 87)
        Me.RadTextBox_Cathode.Name = "RadTextBox_Cathode"
        Me.RadTextBox_Cathode.Size = New System.Drawing.Size(77, 15)
        Me.RadTextBox_Cathode.TabIndex = 131
        Me.RadTextBox_Cathode.ThemeName = "Windows8"
        '
        'RadLabel_Cathode
        '
        Me.RadLabel_Cathode.AutoSize = False
        Me.RadLabel_Cathode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel_Cathode.Location = New System.Drawing.Point(706, 87)
        Me.RadLabel_Cathode.Name = "RadLabel_Cathode"
        Me.RadLabel_Cathode.Size = New System.Drawing.Size(86, 15)
        Me.RadLabel_Cathode.TabIndex = 130
        Me.RadLabel_Cathode.Text = "CathodeData_Cathode"
        Me.RadLabel_Cathode.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Cathode.TextWrap = False
        Me.RadLabel_Cathode.ThemeName = "Windows8"
        '
        'CathodeData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(889, 609)
        Me.Controls.Add(Me.RadTextBox_Cathode)
        Me.Controls.Add(Me.RadLabel_Cathode)
        Me.Controls.Add(Me.RadTextBox_Specification)
        Me.Controls.Add(Me.RadLabel_Specification)
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
        Me.Controls.Add(Me.RadTextBox_Description)
        Me.Controls.Add(Me.RadLabel_Description)
        Me.Controls.Add(Me.RadLabel_ResistanceUnit)
        Me.Controls.Add(Me.RadTextBox_Resistance)
        Me.Controls.Add(Me.RadLabel_Resistance)
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
        Me.Controls.Add(Me.RadCheckBox_Obsolete)
        Me.Controls.Add(Me.RadCheckBox_Active)
        Me.Controls.Add(Me.RadDropDownList_CathodeName)
        Me.Controls.Add(Me.RadLabel_CathodeName)
        Me.Controls.Add(Me.RadLabel_OracleData)
        Me.Controls.Add(Me.Panel_OracleData)
        Me.Controls.Add(Me.Panel_Header)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CathodeData"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "CathodeData_TitleWindow"
        Me.ThemeName = "Windows8"
        Me.Panel_Header.ResumeLayout(False)
        CType(Me.RadButton_ShowAllCathodes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_WhereUsed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Title, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.RadTextBox_Description, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Description, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ResistanceUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Resistance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Resistance, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.RadCheckBox_Obsolete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_Active, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_CathodeName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_CathodeName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_OracleData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_OracleData.ResumeLayout(False)
        CType(Me.RadCheckBox_MultilevelBackflushFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_BackflushFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_StagingFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_BackflushWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_StagingWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_FirstOp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_BackflushWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_StagingWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_FirstOp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Specification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Specification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Cathode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Cathode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Header As System.Windows.Forms.Panel
    Friend WithEvents RadButton_WhereUsed As Telerik.WinControls.UI.RadButton
    Friend WithEvents PictureBox_KemetLogo As System.Windows.Forms.PictureBox
    Friend WithEvents RadLabel_Title As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton_ShowAllCathodes As Telerik.WinControls.UI.RadButton
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
    Friend WithEvents RadTextBox_Description As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Description As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_ResistanceUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Resistance As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Resistance As Telerik.WinControls.UI.RadLabel
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
    Friend WithEvents RadCheckBox_Obsolete As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_Active As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadDropDownList_CathodeName As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_CathodeName As Telerik.WinControls.UI.RadLabel
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
    Friend WithEvents RadTextBox_Specification As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Specification As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Cathode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Cathode As Telerik.WinControls.UI.RadLabel
End Class

