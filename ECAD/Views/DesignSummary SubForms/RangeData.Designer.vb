<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RangeData
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
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition4 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RangeData))
        Me.Panel_Header = New System.Windows.Forms.Panel()
        Me.RadDropDownList_FromHere = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadButton_CopyToHereFrom = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_CopyThisRecordToNewRecord = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox_KemetLogo = New System.Windows.Forms.PictureBox()
        Me.RadLabel_Title = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_Range = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_Range = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Description = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Description = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_StdOpTemp = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_StdOpTemp = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_YieldRange = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_YieldRange = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_StdImpFreq = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_StdImpFreq = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_StdESRTemp = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_StdESRTemp = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_StdESRFreq = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_StdESRFreq = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_ThermalRange = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_ThermalRange = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_LifeRange = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Leakage = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Leakage = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_CostingGroup = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_CostingGroup = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_ParameterRange = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_ParameterRange = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_EndOfLifeRange = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_EndOfLifeRange = New Telerik.WinControls.UI.RadLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_Thermal = New System.Windows.Forms.TabPage()
        Me.RadButton_Thermal_EditThermalTable = New Telerik.WinControls.UI.RadButton()
        Me.RadGridView_Thermal = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabel_Thermal_RHAInUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Thermal_RHAIn = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Thermal_LensInUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Thermal_LensIn = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_Thermal_ThermalRange = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_Thermal_ThermalRange = New Telerik.WinControls.UI.RadLabel()
        Me.TabPage_Life = New System.Windows.Forms.TabPage()
        Me.RadGridView_Life = New Telerik.WinControls.UI.RadGridView()
        Me.RadButton_Life_EditLifeTable = New Telerik.WinControls.UI.RadButton()
        Me.RadDropDownList_Life_LifeRange = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_Life_LifeRange = New Telerik.WinControls.UI.RadLabel()
        Me.TabPage_Other = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadTextBox_Other_StdShippingCostVAR = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Other_StdOHMultiplierVAR = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Other_StdLabourRateVAR = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Other_StdMaterialYieldVAR = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Other_StdWindingYieldVAR = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Other_StdShippingCostSTD = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Other_StdOHMultiplierSTD = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Other_StdLabourRateSTD = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Other_StdMaterialYieldSTD = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Other_StdWindingYieldSTD = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Other_Var = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Other_Std = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Other_StdShippingCost = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Other_StdOHMultiplier = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Other_StdLabourRate = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Other_StdMaterialYield = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Other_StdWindingYield = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Other_CostGroupDesc = New Telerik.WinControls.UI.RadTextBox()
        Me.RadDropDownList_Other_CostingGroup = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_Other_CostingGroup = New Telerik.WinControls.UI.RadLabel()
        Me.Panel_Leakage = New System.Windows.Forms.Panel()
        Me.RadTextBox_Other_MaxValue = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Other_MaxValue = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Other_Description = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Other_Description = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Equation = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Equation = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Other_Multiplier = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Other_Multiplier = New Telerik.WinControls.UI.RadLabel()
        Me.RadButton_Other_EditLeakTable = New Telerik.WinControls.UI.RadButton()
        Me.RadDropDownList_Other_Leakage = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel1_Other_Leakage = New Telerik.WinControls.UI.RadLabel()
        Me.TabPage_Parameters = New System.Windows.Forms.TabPage()
        Me.RadGridView_Parameters = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabel_Parameter_ParameterData = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Parameter_ParameterRange = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Parameter_ParameterRange = New Telerik.WinControls.UI.RadLabel()
        Me.TabPage_EOL = New System.Windows.Forms.TabPage()
        Me.RadGridView_EOL = New Telerik.WinControls.UI.RadGridView()
        Me.RadDropDownList_EOL_EOLRange = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_EOL_EOLRange = New Telerik.WinControls.UI.RadLabel()
        Me.Panel_Header.SuspendLayout()
        CType(Me.RadDropDownList_FromHere, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_CopyToHereFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_CopyThisRecordToNewRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_Range, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Range, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_StdOpTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_StdOpTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_YieldRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_YieldRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_StdImpFreq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_StdImpFreq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_StdESRTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_StdESRTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_StdESRFreq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_StdESRFreq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ThermalRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ThermalRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_LifeRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Leakage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Leakage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CostingGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_CostingGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ParameterRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ParameterRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_EndOfLifeRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_EndOfLifeRange, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_Thermal.SuspendLayout()
        CType(Me.RadButton_Thermal_EditThermalTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_Thermal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_Thermal.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Thermal_RHAInUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Thermal_RHAIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Thermal_LensInUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Thermal_LensIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_Thermal_ThermalRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Thermal_ThermalRange, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Life.SuspendLayout()
        CType(Me.RadGridView_Life, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_Life.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Life_EditLifeTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_Life_LifeRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Life_LifeRange, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Other.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.RadTextBox_Other_StdShippingCostVAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Other_StdOHMultiplierVAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Other_StdLabourRateVAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Other_StdMaterialYieldVAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Other_StdWindingYieldVAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Other_StdShippingCostSTD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Other_StdOHMultiplierSTD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Other_StdLabourRateSTD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Other_StdMaterialYieldSTD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Other_StdWindingYieldSTD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Other_Var, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Other_Std, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Other_StdShippingCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Other_StdOHMultiplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Other_StdLabourRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Other_StdMaterialYield, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Other_StdWindingYield, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Other_CostGroupDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_Other_CostingGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Other_CostingGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Leakage.SuspendLayout()
        CType(Me.RadTextBox_Other_MaxValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Other_MaxValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Other_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Other_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Equation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Equation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Other_Multiplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Other_Multiplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Other_EditLeakTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_Other_Leakage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1_Other_Leakage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Parameters.SuspendLayout()
        CType(Me.RadGridView_Parameters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_Parameters.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Parameter_ParameterData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Parameter_ParameterRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Parameter_ParameterRange, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_EOL.SuspendLayout()
        CType(Me.RadGridView_EOL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_EOL.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_EOL_EOLRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_EOL_EOLRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Header
        '
        Me.Panel_Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Header.Controls.Add(Me.RadDropDownList_FromHere)
        Me.Panel_Header.Controls.Add(Me.RadButton_CopyToHereFrom)
        Me.Panel_Header.Controls.Add(Me.RadButton_CopyThisRecordToNewRecord)
        Me.Panel_Header.Controls.Add(Me.PictureBox_KemetLogo)
        Me.Panel_Header.Controls.Add(Me.RadLabel_Title)
        Me.Panel_Header.Location = New System.Drawing.Point(-5, -2)
        Me.Panel_Header.Name = "Panel_Header"
        Me.Panel_Header.Size = New System.Drawing.Size(1216, 68)
        Me.Panel_Header.TabIndex = 5
        '
        'RadDropDownList_FromHere
        '
        Me.RadDropDownList_FromHere.AutoSize = False
        Me.RadDropDownList_FromHere.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadDropDownList_FromHere.Location = New System.Drawing.Point(556, 23)
        Me.RadDropDownList_FromHere.Name = "RadDropDownList_FromHere"
        Me.RadDropDownList_FromHere.Size = New System.Drawing.Size(117, 20)
        Me.RadDropDownList_FromHere.TabIndex = 58
        Me.RadDropDownList_FromHere.ThemeName = "Windows8"
        '
        'RadButton_CopyToHereFrom
        '
        Me.RadButton_CopyToHereFrom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_CopyToHereFrom.Location = New System.Drawing.Point(393, 8)
        Me.RadButton_CopyToHereFrom.Name = "RadButton_CopyToHereFrom"
        Me.RadButton_CopyToHereFrom.Size = New System.Drawing.Size(144, 50)
        Me.RadButton_CopyToHereFrom.TabIndex = 13
        Me.RadButton_CopyToHereFrom.Text = "RangeData_CopyToHereFrom"
        Me.RadButton_CopyToHereFrom.TextWrap = True
        Me.RadButton_CopyToHereFrom.ThemeName = "Windows8"
        '
        'RadButton_CopyThisRecordToNewRecord
        '
        Me.RadButton_CopyThisRecordToNewRecord.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_CopyThisRecordToNewRecord.Location = New System.Drawing.Point(224, 8)
        Me.RadButton_CopyThisRecordToNewRecord.Name = "RadButton_CopyThisRecordToNewRecord"
        Me.RadButton_CopyThisRecordToNewRecord.Size = New System.Drawing.Size(144, 50)
        Me.RadButton_CopyThisRecordToNewRecord.TabIndex = 12
        Me.RadButton_CopyThisRecordToNewRecord.Text = "RangeData_CopyThisRecordToNewRecord"
        Me.RadButton_CopyThisRecordToNewRecord.TextWrap = True
        Me.RadButton_CopyThisRecordToNewRecord.ThemeName = "Windows8"
        '
        'PictureBox_KemetLogo
        '
        Me.PictureBox_KemetLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox_KemetLogo.Image = Global.ECAD.My.Resources.Resources.kemet_logo_small
        Me.PictureBox_KemetLogo.Location = New System.Drawing.Point(1049, 4)
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
        Me.RadLabel_Title.Text = "RangeData_Title"
        Me.RadLabel_Title.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Title.TextWrap = False
        Me.RadLabel_Title.ThemeName = "Windows8"
        '
        'RadDropDownList_Range
        '
        Me.RadDropDownList_Range.AutoSize = False
        Me.RadDropDownList_Range.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.RadDropDownList_Range.Location = New System.Drawing.Point(178, 91)
        Me.RadDropDownList_Range.Name = "RadDropDownList_Range"
        Me.RadDropDownList_Range.Size = New System.Drawing.Size(117, 30)
        Me.RadDropDownList_Range.TabIndex = 57
        Me.RadDropDownList_Range.ThemeName = "Windows8"
        '
        'RadLabel_Range
        '
        Me.RadLabel_Range.AutoSize = False
        Me.RadLabel_Range.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.RadLabel_Range.Location = New System.Drawing.Point(22, 91)
        Me.RadLabel_Range.Name = "RadLabel_Range"
        Me.RadLabel_Range.Size = New System.Drawing.Size(150, 30)
        Me.RadLabel_Range.TabIndex = 56
        Me.RadLabel_Range.Text = "RangeData_Range"
        Me.RadLabel_Range.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Range.TextWrap = False
        Me.RadLabel_Range.ThemeName = "Windows8"
        '
        'RadTextBox_Description
        '
        Me.RadTextBox_Description.AutoSize = False
        Me.RadTextBox_Description.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Description.Location = New System.Drawing.Point(456, 91)
        Me.RadTextBox_Description.Multiline = True
        Me.RadTextBox_Description.Name = "RadTextBox_Description"
        Me.RadTextBox_Description.Size = New System.Drawing.Size(214, 60)
        Me.RadTextBox_Description.TabIndex = 65
        Me.RadTextBox_Description.ThemeName = "Windows8"
        '
        'RadLabel_Description
        '
        Me.RadLabel_Description.AutoSize = False
        Me.RadLabel_Description.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Description.Location = New System.Drawing.Point(315, 91)
        Me.RadLabel_Description.Name = "RadLabel_Description"
        Me.RadLabel_Description.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_Description.TabIndex = 64
        Me.RadLabel_Description.Text = "RangeData_Description"
        Me.RadLabel_Description.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Description.TextWrap = False
        Me.RadLabel_Description.ThemeName = "Windows8"
        '
        'RadTextBox_StdOpTemp
        '
        Me.RadTextBox_StdOpTemp.AutoSize = False
        Me.RadTextBox_StdOpTemp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_StdOpTemp.Location = New System.Drawing.Point(801, 91)
        Me.RadTextBox_StdOpTemp.Name = "RadTextBox_StdOpTemp"
        Me.RadTextBox_StdOpTemp.Size = New System.Drawing.Size(113, 25)
        Me.RadTextBox_StdOpTemp.TabIndex = 67
        Me.RadTextBox_StdOpTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_StdOpTemp.ThemeName = "Windows8"
        '
        'RadLabel_StdOpTemp
        '
        Me.RadLabel_StdOpTemp.AutoSize = False
        Me.RadLabel_StdOpTemp.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_StdOpTemp.Location = New System.Drawing.Point(695, 91)
        Me.RadLabel_StdOpTemp.Name = "RadLabel_StdOpTemp"
        Me.RadLabel_StdOpTemp.Size = New System.Drawing.Size(100, 25)
        Me.RadLabel_StdOpTemp.TabIndex = 66
        Me.RadLabel_StdOpTemp.Text = "RangeData_StdOpTemp"
        Me.RadLabel_StdOpTemp.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_StdOpTemp.TextWrap = False
        Me.RadLabel_StdOpTemp.ThemeName = "Windows8"
        '
        'RadTextBox_YieldRange
        '
        Me.RadTextBox_YieldRange.AutoSize = False
        Me.RadTextBox_YieldRange.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_YieldRange.Location = New System.Drawing.Point(1042, 91)
        Me.RadTextBox_YieldRange.Name = "RadTextBox_YieldRange"
        Me.RadTextBox_YieldRange.Size = New System.Drawing.Size(120, 25)
        Me.RadTextBox_YieldRange.TabIndex = 69
        Me.RadTextBox_YieldRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_YieldRange.ThemeName = "Windows8"
        '
        'RadLabel_YieldRange
        '
        Me.RadLabel_YieldRange.AutoSize = False
        Me.RadLabel_YieldRange.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_YieldRange.Location = New System.Drawing.Point(936, 91)
        Me.RadLabel_YieldRange.Name = "RadLabel_YieldRange"
        Me.RadLabel_YieldRange.Size = New System.Drawing.Size(100, 25)
        Me.RadLabel_YieldRange.TabIndex = 68
        Me.RadLabel_YieldRange.Text = "RangeData_YieldRange"
        Me.RadLabel_YieldRange.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_YieldRange.TextWrap = False
        Me.RadLabel_YieldRange.ThemeName = "Windows8"
        '
        'RadTextBox_StdImpFreq
        '
        Me.RadTextBox_StdImpFreq.AutoSize = False
        Me.RadTextBox_StdImpFreq.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_StdImpFreq.Location = New System.Drawing.Point(1042, 126)
        Me.RadTextBox_StdImpFreq.Name = "RadTextBox_StdImpFreq"
        Me.RadTextBox_StdImpFreq.Size = New System.Drawing.Size(120, 25)
        Me.RadTextBox_StdImpFreq.TabIndex = 73
        Me.RadTextBox_StdImpFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_StdImpFreq.ThemeName = "Windows8"
        '
        'RadLabel_StdImpFreq
        '
        Me.RadLabel_StdImpFreq.AutoSize = False
        Me.RadLabel_StdImpFreq.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_StdImpFreq.Location = New System.Drawing.Point(936, 126)
        Me.RadLabel_StdImpFreq.Name = "RadLabel_StdImpFreq"
        Me.RadLabel_StdImpFreq.Size = New System.Drawing.Size(100, 25)
        Me.RadLabel_StdImpFreq.TabIndex = 72
        Me.RadLabel_StdImpFreq.Text = "RangeData_StdImpFreq"
        Me.RadLabel_StdImpFreq.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_StdImpFreq.TextWrap = False
        Me.RadLabel_StdImpFreq.ThemeName = "Windows8"
        '
        'RadTextBox_StdESRTemp
        '
        Me.RadTextBox_StdESRTemp.AutoSize = False
        Me.RadTextBox_StdESRTemp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_StdESRTemp.Location = New System.Drawing.Point(801, 126)
        Me.RadTextBox_StdESRTemp.Name = "RadTextBox_StdESRTemp"
        Me.RadTextBox_StdESRTemp.Size = New System.Drawing.Size(113, 25)
        Me.RadTextBox_StdESRTemp.TabIndex = 71
        Me.RadTextBox_StdESRTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_StdESRTemp.ThemeName = "Windows8"
        '
        'RadLabel_StdESRTemp
        '
        Me.RadLabel_StdESRTemp.AutoSize = False
        Me.RadLabel_StdESRTemp.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_StdESRTemp.Location = New System.Drawing.Point(695, 126)
        Me.RadLabel_StdESRTemp.Name = "RadLabel_StdESRTemp"
        Me.RadLabel_StdESRTemp.Size = New System.Drawing.Size(100, 25)
        Me.RadLabel_StdESRTemp.TabIndex = 70
        Me.RadLabel_StdESRTemp.Text = "RangeData_StdESRTemp"
        Me.RadLabel_StdESRTemp.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_StdESRTemp.TextWrap = False
        Me.RadLabel_StdESRTemp.ThemeName = "Windows8"
        '
        'RadTextBox_StdESRFreq
        '
        Me.RadTextBox_StdESRFreq.AutoSize = False
        Me.RadTextBox_StdESRFreq.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_StdESRFreq.Location = New System.Drawing.Point(1042, 161)
        Me.RadTextBox_StdESRFreq.Name = "RadTextBox_StdESRFreq"
        Me.RadTextBox_StdESRFreq.Size = New System.Drawing.Size(120, 25)
        Me.RadTextBox_StdESRFreq.TabIndex = 75
        Me.RadTextBox_StdESRFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_StdESRFreq.ThemeName = "Windows8"
        '
        'RadLabel_StdESRFreq
        '
        Me.RadLabel_StdESRFreq.AutoSize = False
        Me.RadLabel_StdESRFreq.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_StdESRFreq.Location = New System.Drawing.Point(936, 161)
        Me.RadLabel_StdESRFreq.Name = "RadLabel_StdESRFreq"
        Me.RadLabel_StdESRFreq.Size = New System.Drawing.Size(100, 25)
        Me.RadLabel_StdESRFreq.TabIndex = 74
        Me.RadLabel_StdESRFreq.Text = "RangeData_StdESRFreq"
        Me.RadLabel_StdESRFreq.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_StdESRFreq.TextWrap = False
        Me.RadLabel_StdESRFreq.ThemeName = "Windows8"
        '
        'RadTextBox_ThermalRange
        '
        Me.RadTextBox_ThermalRange.AutoSize = False
        Me.RadTextBox_ThermalRange.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_ThermalRange.Location = New System.Drawing.Point(22, 192)
        Me.RadTextBox_ThermalRange.Name = "RadTextBox_ThermalRange"
        Me.RadTextBox_ThermalRange.Size = New System.Drawing.Size(113, 25)
        Me.RadTextBox_ThermalRange.TabIndex = 77
        Me.RadTextBox_ThermalRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_ThermalRange.ThemeName = "Windows8"
        '
        'RadLabel_ThermalRange
        '
        Me.RadLabel_ThermalRange.AutoSize = False
        Me.RadLabel_ThermalRange.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_ThermalRange.Location = New System.Drawing.Point(22, 161)
        Me.RadLabel_ThermalRange.Name = "RadLabel_ThermalRange"
        Me.RadLabel_ThermalRange.Size = New System.Drawing.Size(113, 25)
        Me.RadLabel_ThermalRange.TabIndex = 76
        Me.RadLabel_ThermalRange.Text = "RangeData_ThermalRange"
        Me.RadLabel_ThermalRange.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_ThermalRange.TextWrap = False
        Me.RadLabel_ThermalRange.ThemeName = "Windows8"
        '
        'RadTextBox2
        '
        Me.RadTextBox2.AutoSize = False
        Me.RadTextBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox2.Location = New System.Drawing.Point(160, 192)
        Me.RadTextBox2.Name = "RadTextBox2"
        Me.RadTextBox2.Size = New System.Drawing.Size(113, 25)
        Me.RadTextBox2.TabIndex = 79
        Me.RadTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox2.ThemeName = "Windows8"
        '
        'RadLabel_LifeRange
        '
        Me.RadLabel_LifeRange.AutoSize = False
        Me.RadLabel_LifeRange.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_LifeRange.Location = New System.Drawing.Point(160, 161)
        Me.RadLabel_LifeRange.Name = "RadLabel_LifeRange"
        Me.RadLabel_LifeRange.Size = New System.Drawing.Size(113, 25)
        Me.RadLabel_LifeRange.TabIndex = 78
        Me.RadLabel_LifeRange.Text = "RangeData_LifeRange"
        Me.RadLabel_LifeRange.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_LifeRange.TextWrap = False
        Me.RadLabel_LifeRange.ThemeName = "Windows8"
        '
        'RadTextBox_Leakage
        '
        Me.RadTextBox_Leakage.AutoSize = False
        Me.RadTextBox_Leakage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Leakage.Location = New System.Drawing.Point(298, 192)
        Me.RadTextBox_Leakage.Name = "RadTextBox_Leakage"
        Me.RadTextBox_Leakage.Size = New System.Drawing.Size(113, 25)
        Me.RadTextBox_Leakage.TabIndex = 81
        Me.RadTextBox_Leakage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Leakage.ThemeName = "Windows8"
        '
        'RadLabel_Leakage
        '
        Me.RadLabel_Leakage.AutoSize = False
        Me.RadLabel_Leakage.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Leakage.Location = New System.Drawing.Point(298, 161)
        Me.RadLabel_Leakage.Name = "RadLabel_Leakage"
        Me.RadLabel_Leakage.Size = New System.Drawing.Size(113, 25)
        Me.RadLabel_Leakage.TabIndex = 80
        Me.RadLabel_Leakage.Text = "RangeData_Leakage"
        Me.RadLabel_Leakage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Leakage.TextWrap = False
        Me.RadLabel_Leakage.ThemeName = "Windows8"
        '
        'RadTextBox_CostingGroup
        '
        Me.RadTextBox_CostingGroup.AutoSize = False
        Me.RadTextBox_CostingGroup.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_CostingGroup.Location = New System.Drawing.Point(436, 192)
        Me.RadTextBox_CostingGroup.Name = "RadTextBox_CostingGroup"
        Me.RadTextBox_CostingGroup.Size = New System.Drawing.Size(113, 25)
        Me.RadTextBox_CostingGroup.TabIndex = 83
        Me.RadTextBox_CostingGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_CostingGroup.ThemeName = "Windows8"
        '
        'RadLabel_CostingGroup
        '
        Me.RadLabel_CostingGroup.AutoSize = False
        Me.RadLabel_CostingGroup.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_CostingGroup.Location = New System.Drawing.Point(436, 161)
        Me.RadLabel_CostingGroup.Name = "RadLabel_CostingGroup"
        Me.RadLabel_CostingGroup.Size = New System.Drawing.Size(113, 25)
        Me.RadLabel_CostingGroup.TabIndex = 82
        Me.RadLabel_CostingGroup.Text = "RangeData_CostingGroup"
        Me.RadLabel_CostingGroup.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_CostingGroup.TextWrap = False
        Me.RadLabel_CostingGroup.ThemeName = "Windows8"
        '
        'RadTextBox_ParameterRange
        '
        Me.RadTextBox_ParameterRange.AutoSize = False
        Me.RadTextBox_ParameterRange.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_ParameterRange.Location = New System.Drawing.Point(574, 192)
        Me.RadTextBox_ParameterRange.Name = "RadTextBox_ParameterRange"
        Me.RadTextBox_ParameterRange.Size = New System.Drawing.Size(113, 25)
        Me.RadTextBox_ParameterRange.TabIndex = 85
        Me.RadTextBox_ParameterRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_ParameterRange.ThemeName = "Windows8"
        '
        'RadLabel_ParameterRange
        '
        Me.RadLabel_ParameterRange.AutoSize = False
        Me.RadLabel_ParameterRange.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_ParameterRange.Location = New System.Drawing.Point(574, 161)
        Me.RadLabel_ParameterRange.Name = "RadLabel_ParameterRange"
        Me.RadLabel_ParameterRange.Size = New System.Drawing.Size(113, 25)
        Me.RadLabel_ParameterRange.TabIndex = 84
        Me.RadLabel_ParameterRange.Text = "RangeData_ParameterRange"
        Me.RadLabel_ParameterRange.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_ParameterRange.TextWrap = False
        Me.RadLabel_ParameterRange.ThemeName = "Windows8"
        '
        'RadTextBox_EndOfLifeRange
        '
        Me.RadTextBox_EndOfLifeRange.AutoSize = False
        Me.RadTextBox_EndOfLifeRange.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_EndOfLifeRange.Location = New System.Drawing.Point(712, 192)
        Me.RadTextBox_EndOfLifeRange.Name = "RadTextBox_EndOfLifeRange"
        Me.RadTextBox_EndOfLifeRange.Size = New System.Drawing.Size(202, 25)
        Me.RadTextBox_EndOfLifeRange.TabIndex = 87
        Me.RadTextBox_EndOfLifeRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_EndOfLifeRange.ThemeName = "Windows8"
        '
        'RadLabel_EndOfLifeRange
        '
        Me.RadLabel_EndOfLifeRange.AutoSize = False
        Me.RadLabel_EndOfLifeRange.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_EndOfLifeRange.Location = New System.Drawing.Point(712, 161)
        Me.RadLabel_EndOfLifeRange.Name = "RadLabel_EndOfLifeRange"
        Me.RadLabel_EndOfLifeRange.Size = New System.Drawing.Size(202, 25)
        Me.RadLabel_EndOfLifeRange.TabIndex = 86
        Me.RadLabel_EndOfLifeRange.Text = "RangeData_EndOfLifeRange"
        Me.RadLabel_EndOfLifeRange.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_EndOfLifeRange.TextWrap = False
        Me.RadLabel_EndOfLifeRange.ThemeName = "Windows8"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_Thermal)
        Me.TabControl1.Controls.Add(Me.TabPage_Life)
        Me.TabControl1.Controls.Add(Me.TabPage_Other)
        Me.TabControl1.Controls.Add(Me.TabPage_Parameters)
        Me.TabControl1.Controls.Add(Me.TabPage_EOL)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TabControl1.Location = New System.Drawing.Point(22, 224)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1158, 540)
        Me.TabControl1.TabIndex = 88
        '
        'TabPage_Thermal
        '
        Me.TabPage_Thermal.BackColor = System.Drawing.Color.Silver
        Me.TabPage_Thermal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage_Thermal.Controls.Add(Me.RadButton_Thermal_EditThermalTable)
        Me.TabPage_Thermal.Controls.Add(Me.RadGridView_Thermal)
        Me.TabPage_Thermal.Controls.Add(Me.RadLabel_Thermal_RHAInUnit)
        Me.TabPage_Thermal.Controls.Add(Me.RadLabel_Thermal_RHAIn)
        Me.TabPage_Thermal.Controls.Add(Me.RadLabel_Thermal_LensInUnit)
        Me.TabPage_Thermal.Controls.Add(Me.RadLabel_Thermal_LensIn)
        Me.TabPage_Thermal.Controls.Add(Me.RadDropDownList_Thermal_ThermalRange)
        Me.TabPage_Thermal.Controls.Add(Me.RadLabel_Thermal_ThermalRange)
        Me.TabPage_Thermal.Location = New System.Drawing.Point(4, 30)
        Me.TabPage_Thermal.Name = "TabPage_Thermal"
        Me.TabPage_Thermal.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Thermal.Size = New System.Drawing.Size(1150, 506)
        Me.TabPage_Thermal.TabIndex = 0
        Me.TabPage_Thermal.Text = "RangeData_Thermal"
        '
        'RadButton_Thermal_EditThermalTable
        '
        Me.RadButton_Thermal_EditThermalTable.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadButton_Thermal_EditThermalTable.Location = New System.Drawing.Point(371, 19)
        Me.RadButton_Thermal_EditThermalTable.Name = "RadButton_Thermal_EditThermalTable"
        Me.RadButton_Thermal_EditThermalTable.Size = New System.Drawing.Size(113, 72)
        Me.RadButton_Thermal_EditThermalTable.TabIndex = 32
        Me.RadButton_Thermal_EditThermalTable.Text = "RangeData_Thermal_EditThermalTable"
        Me.RadButton_Thermal_EditThermalTable.TextWrap = True
        Me.RadButton_Thermal_EditThermalTable.ThemeName = "Windows8"
        '
        'RadGridView_Thermal
        '
        Me.RadGridView_Thermal.AutoScroll = True
        Me.RadGridView_Thermal.Location = New System.Drawing.Point(30, 98)
        '
        '
        '
        Me.RadGridView_Thermal.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView_Thermal.Name = "RadGridView_Thermal"
        Me.RadGridView_Thermal.Size = New System.Drawing.Size(454, 389)
        Me.RadGridView_Thermal.TabIndex = 31
        Me.RadGridView_Thermal.Text = "RadGridView1"
        '
        'RadLabel_Thermal_RHAInUnit
        '
        Me.RadLabel_Thermal_RHAInUnit.AutoSize = False
        Me.RadLabel_Thermal_RHAInUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Thermal_RHAInUnit.Location = New System.Drawing.Point(245, 66)
        Me.RadLabel_Thermal_RHAInUnit.Name = "RadLabel_Thermal_RHAInUnit"
        Me.RadLabel_Thermal_RHAInUnit.Size = New System.Drawing.Size(60, 25)
        Me.RadLabel_Thermal_RHAInUnit.TabIndex = 30
        Me.RadLabel_Thermal_RHAInUnit.Text = "RangeData_Thermal_CentigradeDegreeByWatt"
        Me.RadLabel_Thermal_RHAInUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Thermal_RHAInUnit.TextWrap = False
        Me.RadLabel_Thermal_RHAInUnit.ThemeName = "Windows8"
        '
        'RadLabel_Thermal_RHAIn
        '
        Me.RadLabel_Thermal_RHAIn.AutoSize = False
        Me.RadLabel_Thermal_RHAIn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Thermal_RHAIn.Location = New System.Drawing.Point(179, 67)
        Me.RadLabel_Thermal_RHAIn.Name = "RadLabel_Thermal_RHAIn"
        Me.RadLabel_Thermal_RHAIn.Size = New System.Drawing.Size(60, 25)
        Me.RadLabel_Thermal_RHAIn.TabIndex = 29
        Me.RadLabel_Thermal_RHAIn.Text = "RangeData_Thermal_RHAIn"
        Me.RadLabel_Thermal_RHAIn.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Thermal_RHAIn.TextWrap = False
        Me.RadLabel_Thermal_RHAIn.ThemeName = "Windows8"
        '
        'RadLabel_Thermal_LensInUnit
        '
        Me.RadLabel_Thermal_LensInUnit.AutoSize = False
        Me.RadLabel_Thermal_LensInUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Thermal_LensInUnit.Location = New System.Drawing.Point(96, 66)
        Me.RadLabel_Thermal_LensInUnit.Name = "RadLabel_Thermal_LensInUnit"
        Me.RadLabel_Thermal_LensInUnit.Size = New System.Drawing.Size(60, 25)
        Me.RadLabel_Thermal_LensInUnit.TabIndex = 28
        Me.RadLabel_Thermal_LensInUnit.Text = "Units_Mm"
        Me.RadLabel_Thermal_LensInUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Thermal_LensInUnit.TextWrap = False
        Me.RadLabel_Thermal_LensInUnit.ThemeName = "Windows8"
        '
        'RadLabel_Thermal_LensIn
        '
        Me.RadLabel_Thermal_LensIn.AutoSize = False
        Me.RadLabel_Thermal_LensIn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Thermal_LensIn.Location = New System.Drawing.Point(30, 66)
        Me.RadLabel_Thermal_LensIn.Name = "RadLabel_Thermal_LensIn"
        Me.RadLabel_Thermal_LensIn.Size = New System.Drawing.Size(60, 25)
        Me.RadLabel_Thermal_LensIn.TabIndex = 27
        Me.RadLabel_Thermal_LensIn.Text = "RangeData_Thermal_LensIn"
        Me.RadLabel_Thermal_LensIn.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Thermal_LensIn.TextWrap = False
        Me.RadLabel_Thermal_LensIn.ThemeName = "Windows8"
        '
        'RadDropDownList_Thermal_ThermalRange
        '
        Me.RadDropDownList_Thermal_ThermalRange.AutoSize = False
        Me.RadDropDownList_Thermal_ThermalRange.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDropDownList_Thermal_ThermalRange.Location = New System.Drawing.Point(171, 19)
        Me.RadDropDownList_Thermal_ThermalRange.Name = "RadDropDownList_Thermal_ThermalRange"
        Me.RadDropDownList_Thermal_ThermalRange.Size = New System.Drawing.Size(179, 25)
        Me.RadDropDownList_Thermal_ThermalRange.TabIndex = 26
        Me.RadDropDownList_Thermal_ThermalRange.ThemeName = "Windows8"
        '
        'RadLabel_Thermal_ThermalRange
        '
        Me.RadLabel_Thermal_ThermalRange.AutoSize = False
        Me.RadLabel_Thermal_ThermalRange.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Thermal_ThermalRange.Location = New System.Drawing.Point(30, 19)
        Me.RadLabel_Thermal_ThermalRange.Name = "RadLabel_Thermal_ThermalRange"
        Me.RadLabel_Thermal_ThermalRange.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_Thermal_ThermalRange.TabIndex = 25
        Me.RadLabel_Thermal_ThermalRange.Text = "RangeData_Thermal_ThermalRange"
        Me.RadLabel_Thermal_ThermalRange.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Thermal_ThermalRange.TextWrap = False
        Me.RadLabel_Thermal_ThermalRange.ThemeName = "Windows8"
        '
        'TabPage_Life
        '
        Me.TabPage_Life.BackColor = System.Drawing.Color.Silver
        Me.TabPage_Life.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage_Life.Controls.Add(Me.RadGridView_Life)
        Me.TabPage_Life.Controls.Add(Me.RadButton_Life_EditLifeTable)
        Me.TabPage_Life.Controls.Add(Me.RadDropDownList_Life_LifeRange)
        Me.TabPage_Life.Controls.Add(Me.RadLabel_Life_LifeRange)
        Me.TabPage_Life.Location = New System.Drawing.Point(4, 30)
        Me.TabPage_Life.Name = "TabPage_Life"
        Me.TabPage_Life.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Life.Size = New System.Drawing.Size(1150, 506)
        Me.TabPage_Life.TabIndex = 1
        Me.TabPage_Life.Text = "RangeData_Life"
        '
        'RadGridView_Life
        '
        Me.RadGridView_Life.AutoScroll = True
        Me.RadGridView_Life.Location = New System.Drawing.Point(11, 51)
        '
        '
        '
        Me.RadGridView_Life.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.RadGridView_Life.Name = "RadGridView_Life"
        Me.RadGridView_Life.Size = New System.Drawing.Size(1125, 437)
        Me.RadGridView_Life.TabIndex = 36
        Me.RadGridView_Life.Text = "RadGridView1"
        '
        'RadButton_Life_EditLifeTable
        '
        Me.RadButton_Life_EditLifeTable.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadButton_Life_EditLifeTable.Location = New System.Drawing.Point(352, 19)
        Me.RadButton_Life_EditLifeTable.Name = "RadButton_Life_EditLifeTable"
        Me.RadButton_Life_EditLifeTable.Size = New System.Drawing.Size(156, 25)
        Me.RadButton_Life_EditLifeTable.TabIndex = 35
        Me.RadButton_Life_EditLifeTable.Text = "RangeData_Life_EditLifeTable"
        Me.RadButton_Life_EditLifeTable.TextWrap = True
        Me.RadButton_Life_EditLifeTable.ThemeName = "Windows8"
        '
        'RadDropDownList_Life_LifeRange
        '
        Me.RadDropDownList_Life_LifeRange.AutoSize = False
        Me.RadDropDownList_Life_LifeRange.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDropDownList_Life_LifeRange.Location = New System.Drawing.Point(152, 19)
        Me.RadDropDownList_Life_LifeRange.Name = "RadDropDownList_Life_LifeRange"
        Me.RadDropDownList_Life_LifeRange.Size = New System.Drawing.Size(179, 25)
        Me.RadDropDownList_Life_LifeRange.TabIndex = 34
        Me.RadDropDownList_Life_LifeRange.ThemeName = "Windows8"
        '
        'RadLabel_Life_LifeRange
        '
        Me.RadLabel_Life_LifeRange.AutoSize = False
        Me.RadLabel_Life_LifeRange.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Life_LifeRange.Location = New System.Drawing.Point(11, 19)
        Me.RadLabel_Life_LifeRange.Name = "RadLabel_Life_LifeRange"
        Me.RadLabel_Life_LifeRange.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_Life_LifeRange.TabIndex = 33
        Me.RadLabel_Life_LifeRange.Text = "RangeData_Life_LifeRange"
        Me.RadLabel_Life_LifeRange.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Life_LifeRange.TextWrap = False
        Me.RadLabel_Life_LifeRange.ThemeName = "Windows8"
        '
        'TabPage_Other
        '
        Me.TabPage_Other.BackColor = System.Drawing.Color.Silver
        Me.TabPage_Other.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage_Other.Controls.Add(Me.Panel1)
        Me.TabPage_Other.Controls.Add(Me.Panel_Leakage)
        Me.TabPage_Other.Location = New System.Drawing.Point(4, 30)
        Me.TabPage_Other.Name = "TabPage_Other"
        Me.TabPage_Other.Size = New System.Drawing.Size(1150, 506)
        Me.TabPage_Other.TabIndex = 2
        Me.TabPage_Other.Text = "RangeData_Other"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.RadTextBox_Other_StdShippingCostVAR)
        Me.Panel1.Controls.Add(Me.RadTextBox_Other_StdOHMultiplierVAR)
        Me.Panel1.Controls.Add(Me.RadTextBox_Other_StdLabourRateVAR)
        Me.Panel1.Controls.Add(Me.RadTextBox_Other_StdMaterialYieldVAR)
        Me.Panel1.Controls.Add(Me.RadTextBox_Other_StdWindingYieldVAR)
        Me.Panel1.Controls.Add(Me.RadTextBox_Other_StdShippingCostSTD)
        Me.Panel1.Controls.Add(Me.RadTextBox_Other_StdOHMultiplierSTD)
        Me.Panel1.Controls.Add(Me.RadTextBox_Other_StdLabourRateSTD)
        Me.Panel1.Controls.Add(Me.RadTextBox_Other_StdMaterialYieldSTD)
        Me.Panel1.Controls.Add(Me.RadTextBox_Other_StdWindingYieldSTD)
        Me.Panel1.Controls.Add(Me.RadLabel_Other_Var)
        Me.Panel1.Controls.Add(Me.RadLabel_Other_Std)
        Me.Panel1.Controls.Add(Me.RadLabel_Other_StdShippingCost)
        Me.Panel1.Controls.Add(Me.RadLabel_Other_StdOHMultiplier)
        Me.Panel1.Controls.Add(Me.RadLabel_Other_StdLabourRate)
        Me.Panel1.Controls.Add(Me.RadLabel_Other_StdMaterialYield)
        Me.Panel1.Controls.Add(Me.RadLabel_Other_StdWindingYield)
        Me.Panel1.Controls.Add(Me.RadTextBox_Other_CostGroupDesc)
        Me.Panel1.Controls.Add(Me.RadDropDownList_Other_CostingGroup)
        Me.Panel1.Controls.Add(Me.RadLabel_Other_CostingGroup)
        Me.Panel1.Location = New System.Drawing.Point(362, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(390, 270)
        Me.Panel1.TabIndex = 1
        '
        'RadTextBox_Other_StdShippingCostVAR
        '
        Me.RadTextBox_Other_StdShippingCostVAR.AutoSize = False
        Me.RadTextBox_Other_StdShippingCostVAR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Other_StdShippingCostVAR.Location = New System.Drawing.Point(270, 230)
        Me.RadTextBox_Other_StdShippingCostVAR.Name = "RadTextBox_Other_StdShippingCostVAR"
        Me.RadTextBox_Other_StdShippingCostVAR.Size = New System.Drawing.Size(100, 25)
        Me.RadTextBox_Other_StdShippingCostVAR.TabIndex = 89
        Me.RadTextBox_Other_StdShippingCostVAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Other_StdShippingCostVAR.ThemeName = "Windows8"
        '
        'RadTextBox_Other_StdOHMultiplierVAR
        '
        Me.RadTextBox_Other_StdOHMultiplierVAR.AutoSize = False
        Me.RadTextBox_Other_StdOHMultiplierVAR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Other_StdOHMultiplierVAR.Location = New System.Drawing.Point(270, 199)
        Me.RadTextBox_Other_StdOHMultiplierVAR.Name = "RadTextBox_Other_StdOHMultiplierVAR"
        Me.RadTextBox_Other_StdOHMultiplierVAR.Size = New System.Drawing.Size(100, 25)
        Me.RadTextBox_Other_StdOHMultiplierVAR.TabIndex = 88
        Me.RadTextBox_Other_StdOHMultiplierVAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Other_StdOHMultiplierVAR.ThemeName = "Windows8"
        '
        'RadTextBox_Other_StdLabourRateVAR
        '
        Me.RadTextBox_Other_StdLabourRateVAR.AutoSize = False
        Me.RadTextBox_Other_StdLabourRateVAR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Other_StdLabourRateVAR.Location = New System.Drawing.Point(270, 168)
        Me.RadTextBox_Other_StdLabourRateVAR.Name = "RadTextBox_Other_StdLabourRateVAR"
        Me.RadTextBox_Other_StdLabourRateVAR.Size = New System.Drawing.Size(100, 25)
        Me.RadTextBox_Other_StdLabourRateVAR.TabIndex = 87
        Me.RadTextBox_Other_StdLabourRateVAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Other_StdLabourRateVAR.ThemeName = "Windows8"
        '
        'RadTextBox_Other_StdMaterialYieldVAR
        '
        Me.RadTextBox_Other_StdMaterialYieldVAR.AutoSize = False
        Me.RadTextBox_Other_StdMaterialYieldVAR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Other_StdMaterialYieldVAR.Location = New System.Drawing.Point(270, 137)
        Me.RadTextBox_Other_StdMaterialYieldVAR.Name = "RadTextBox_Other_StdMaterialYieldVAR"
        Me.RadTextBox_Other_StdMaterialYieldVAR.Size = New System.Drawing.Size(100, 25)
        Me.RadTextBox_Other_StdMaterialYieldVAR.TabIndex = 86
        Me.RadTextBox_Other_StdMaterialYieldVAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Other_StdMaterialYieldVAR.ThemeName = "Windows8"
        '
        'RadTextBox_Other_StdWindingYieldVAR
        '
        Me.RadTextBox_Other_StdWindingYieldVAR.AutoSize = False
        Me.RadTextBox_Other_StdWindingYieldVAR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Other_StdWindingYieldVAR.Location = New System.Drawing.Point(270, 106)
        Me.RadTextBox_Other_StdWindingYieldVAR.Name = "RadTextBox_Other_StdWindingYieldVAR"
        Me.RadTextBox_Other_StdWindingYieldVAR.Size = New System.Drawing.Size(100, 25)
        Me.RadTextBox_Other_StdWindingYieldVAR.TabIndex = 85
        Me.RadTextBox_Other_StdWindingYieldVAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Other_StdWindingYieldVAR.ThemeName = "Windows8"
        '
        'RadTextBox_Other_StdShippingCostSTD
        '
        Me.RadTextBox_Other_StdShippingCostSTD.AutoSize = False
        Me.RadTextBox_Other_StdShippingCostSTD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Other_StdShippingCostSTD.Location = New System.Drawing.Point(163, 230)
        Me.RadTextBox_Other_StdShippingCostSTD.Name = "RadTextBox_Other_StdShippingCostSTD"
        Me.RadTextBox_Other_StdShippingCostSTD.Size = New System.Drawing.Size(101, 25)
        Me.RadTextBox_Other_StdShippingCostSTD.TabIndex = 84
        Me.RadTextBox_Other_StdShippingCostSTD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Other_StdShippingCostSTD.ThemeName = "Windows8"
        '
        'RadTextBox_Other_StdOHMultiplierSTD
        '
        Me.RadTextBox_Other_StdOHMultiplierSTD.AutoSize = False
        Me.RadTextBox_Other_StdOHMultiplierSTD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Other_StdOHMultiplierSTD.Location = New System.Drawing.Point(163, 199)
        Me.RadTextBox_Other_StdOHMultiplierSTD.Name = "RadTextBox_Other_StdOHMultiplierSTD"
        Me.RadTextBox_Other_StdOHMultiplierSTD.Size = New System.Drawing.Size(101, 25)
        Me.RadTextBox_Other_StdOHMultiplierSTD.TabIndex = 83
        Me.RadTextBox_Other_StdOHMultiplierSTD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Other_StdOHMultiplierSTD.ThemeName = "Windows8"
        '
        'RadTextBox_Other_StdLabourRateSTD
        '
        Me.RadTextBox_Other_StdLabourRateSTD.AutoSize = False
        Me.RadTextBox_Other_StdLabourRateSTD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Other_StdLabourRateSTD.Location = New System.Drawing.Point(163, 168)
        Me.RadTextBox_Other_StdLabourRateSTD.Name = "RadTextBox_Other_StdLabourRateSTD"
        Me.RadTextBox_Other_StdLabourRateSTD.Size = New System.Drawing.Size(101, 25)
        Me.RadTextBox_Other_StdLabourRateSTD.TabIndex = 82
        Me.RadTextBox_Other_StdLabourRateSTD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Other_StdLabourRateSTD.ThemeName = "Windows8"
        '
        'RadTextBox_Other_StdMaterialYieldSTD
        '
        Me.RadTextBox_Other_StdMaterialYieldSTD.AutoSize = False
        Me.RadTextBox_Other_StdMaterialYieldSTD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Other_StdMaterialYieldSTD.Location = New System.Drawing.Point(163, 137)
        Me.RadTextBox_Other_StdMaterialYieldSTD.Name = "RadTextBox_Other_StdMaterialYieldSTD"
        Me.RadTextBox_Other_StdMaterialYieldSTD.Size = New System.Drawing.Size(101, 25)
        Me.RadTextBox_Other_StdMaterialYieldSTD.TabIndex = 81
        Me.RadTextBox_Other_StdMaterialYieldSTD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Other_StdMaterialYieldSTD.ThemeName = "Windows8"
        '
        'RadTextBox_Other_StdWindingYieldSTD
        '
        Me.RadTextBox_Other_StdWindingYieldSTD.AutoSize = False
        Me.RadTextBox_Other_StdWindingYieldSTD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Other_StdWindingYieldSTD.Location = New System.Drawing.Point(163, 106)
        Me.RadTextBox_Other_StdWindingYieldSTD.Name = "RadTextBox_Other_StdWindingYieldSTD"
        Me.RadTextBox_Other_StdWindingYieldSTD.Size = New System.Drawing.Size(101, 25)
        Me.RadTextBox_Other_StdWindingYieldSTD.TabIndex = 80
        Me.RadTextBox_Other_StdWindingYieldSTD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Other_StdWindingYieldSTD.ThemeName = "Windows8"
        '
        'RadLabel_Other_Var
        '
        Me.RadLabel_Other_Var.AutoSize = False
        Me.RadLabel_Other_Var.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Other_Var.Location = New System.Drawing.Point(270, 75)
        Me.RadLabel_Other_Var.Name = "RadLabel_Other_Var"
        Me.RadLabel_Other_Var.Size = New System.Drawing.Size(100, 25)
        Me.RadLabel_Other_Var.TabIndex = 79
        Me.RadLabel_Other_Var.Text = "RangeData_Other_Var"
        Me.RadLabel_Other_Var.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_Other_Var.TextWrap = False
        Me.RadLabel_Other_Var.ThemeName = "Windows8"
        '
        'RadLabel_Other_Std
        '
        Me.RadLabel_Other_Std.AutoSize = False
        Me.RadLabel_Other_Std.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Other_Std.Location = New System.Drawing.Point(164, 75)
        Me.RadLabel_Other_Std.Name = "RadLabel_Other_Std"
        Me.RadLabel_Other_Std.Size = New System.Drawing.Size(100, 25)
        Me.RadLabel_Other_Std.TabIndex = 78
        Me.RadLabel_Other_Std.Text = "RangeData_Other_Std"
        Me.RadLabel_Other_Std.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_Other_Std.TextWrap = False
        Me.RadLabel_Other_Std.ThemeName = "Windows8"
        '
        'RadLabel_Other_StdShippingCost
        '
        Me.RadLabel_Other_StdShippingCost.AutoSize = False
        Me.RadLabel_Other_StdShippingCost.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.RadLabel_Other_StdShippingCost.Location = New System.Drawing.Point(19, 230)
        Me.RadLabel_Other_StdShippingCost.Name = "RadLabel_Other_StdShippingCost"
        Me.RadLabel_Other_StdShippingCost.Size = New System.Drawing.Size(138, 25)
        Me.RadLabel_Other_StdShippingCost.TabIndex = 77
        Me.RadLabel_Other_StdShippingCost.Text = "RangeData_Other_StdShippingCost"
        Me.RadLabel_Other_StdShippingCost.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Other_StdShippingCost.TextWrap = False
        Me.RadLabel_Other_StdShippingCost.ThemeName = "Windows8"
        '
        'RadLabel_Other_StdOHMultiplier
        '
        Me.RadLabel_Other_StdOHMultiplier.AutoSize = False
        Me.RadLabel_Other_StdOHMultiplier.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.RadLabel_Other_StdOHMultiplier.Location = New System.Drawing.Point(19, 199)
        Me.RadLabel_Other_StdOHMultiplier.Name = "RadLabel_Other_StdOHMultiplier"
        Me.RadLabel_Other_StdOHMultiplier.Size = New System.Drawing.Size(138, 25)
        Me.RadLabel_Other_StdOHMultiplier.TabIndex = 76
        Me.RadLabel_Other_StdOHMultiplier.Text = "RangeData_Other_StdOHMultiplier"
        Me.RadLabel_Other_StdOHMultiplier.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Other_StdOHMultiplier.TextWrap = False
        Me.RadLabel_Other_StdOHMultiplier.ThemeName = "Windows8"
        '
        'RadLabel_Other_StdLabourRate
        '
        Me.RadLabel_Other_StdLabourRate.AutoSize = False
        Me.RadLabel_Other_StdLabourRate.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.RadLabel_Other_StdLabourRate.Location = New System.Drawing.Point(19, 168)
        Me.RadLabel_Other_StdLabourRate.Name = "RadLabel_Other_StdLabourRate"
        Me.RadLabel_Other_StdLabourRate.Size = New System.Drawing.Size(138, 25)
        Me.RadLabel_Other_StdLabourRate.TabIndex = 75
        Me.RadLabel_Other_StdLabourRate.Text = "RangeData_Other_StdLabourRate"
        Me.RadLabel_Other_StdLabourRate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Other_StdLabourRate.TextWrap = False
        Me.RadLabel_Other_StdLabourRate.ThemeName = "Windows8"
        '
        'RadLabel_Other_StdMaterialYield
        '
        Me.RadLabel_Other_StdMaterialYield.AutoSize = False
        Me.RadLabel_Other_StdMaterialYield.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.RadLabel_Other_StdMaterialYield.Location = New System.Drawing.Point(19, 137)
        Me.RadLabel_Other_StdMaterialYield.Name = "RadLabel_Other_StdMaterialYield"
        Me.RadLabel_Other_StdMaterialYield.Size = New System.Drawing.Size(138, 25)
        Me.RadLabel_Other_StdMaterialYield.TabIndex = 74
        Me.RadLabel_Other_StdMaterialYield.Text = "RangeData_Other_StdMaterialYield"
        Me.RadLabel_Other_StdMaterialYield.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Other_StdMaterialYield.TextWrap = False
        Me.RadLabel_Other_StdMaterialYield.ThemeName = "Windows8"
        '
        'RadLabel_Other_StdWindingYield
        '
        Me.RadLabel_Other_StdWindingYield.AutoSize = False
        Me.RadLabel_Other_StdWindingYield.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.RadLabel_Other_StdWindingYield.Location = New System.Drawing.Point(19, 106)
        Me.RadLabel_Other_StdWindingYield.Name = "RadLabel_Other_StdWindingYield"
        Me.RadLabel_Other_StdWindingYield.Size = New System.Drawing.Size(138, 25)
        Me.RadLabel_Other_StdWindingYield.TabIndex = 73
        Me.RadLabel_Other_StdWindingYield.Text = "RangeData_Other_StdWindingYield"
        Me.RadLabel_Other_StdWindingYield.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Other_StdWindingYield.TextWrap = False
        Me.RadLabel_Other_StdWindingYield.ThemeName = "Windows8"
        '
        'RadTextBox_Other_CostGroupDesc
        '
        Me.RadTextBox_Other_CostGroupDesc.AutoSize = False
        Me.RadTextBox_Other_CostGroupDesc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Other_CostGroupDesc.Location = New System.Drawing.Point(19, 44)
        Me.RadTextBox_Other_CostGroupDesc.Name = "RadTextBox_Other_CostGroupDesc"
        Me.RadTextBox_Other_CostGroupDesc.Size = New System.Drawing.Size(351, 25)
        Me.RadTextBox_Other_CostGroupDesc.TabIndex = 72
        Me.RadTextBox_Other_CostGroupDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Other_CostGroupDesc.ThemeName = "Windows8"
        '
        'RadDropDownList_Other_CostingGroup
        '
        Me.RadDropDownList_Other_CostingGroup.AutoSize = False
        Me.RadDropDownList_Other_CostingGroup.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDropDownList_Other_CostingGroup.Location = New System.Drawing.Point(148, 13)
        Me.RadDropDownList_Other_CostingGroup.Name = "RadDropDownList_Other_CostingGroup"
        Me.RadDropDownList_Other_CostingGroup.Size = New System.Drawing.Size(87, 25)
        Me.RadDropDownList_Other_CostingGroup.TabIndex = 37
        Me.RadDropDownList_Other_CostingGroup.ThemeName = "Windows8"
        '
        'RadLabel_Other_CostingGroup
        '
        Me.RadLabel_Other_CostingGroup.AutoSize = False
        Me.RadLabel_Other_CostingGroup.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Other_CostingGroup.Location = New System.Drawing.Point(19, 13)
        Me.RadLabel_Other_CostingGroup.Name = "RadLabel_Other_CostingGroup"
        Me.RadLabel_Other_CostingGroup.Size = New System.Drawing.Size(123, 25)
        Me.RadLabel_Other_CostingGroup.TabIndex = 36
        Me.RadLabel_Other_CostingGroup.Text = "RangeData_Other_CostingGroup"
        Me.RadLabel_Other_CostingGroup.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Other_CostingGroup.TextWrap = False
        Me.RadLabel_Other_CostingGroup.ThemeName = "Windows8"
        '
        'Panel_Leakage
        '
        Me.Panel_Leakage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Leakage.Controls.Add(Me.RadTextBox_Other_MaxValue)
        Me.Panel_Leakage.Controls.Add(Me.RadLabel_Other_MaxValue)
        Me.Panel_Leakage.Controls.Add(Me.RadTextBox_Other_Description)
        Me.Panel_Leakage.Controls.Add(Me.RadLabel_Other_Description)
        Me.Panel_Leakage.Controls.Add(Me.RadTextBox_Equation)
        Me.Panel_Leakage.Controls.Add(Me.RadLabel_Equation)
        Me.Panel_Leakage.Controls.Add(Me.RadTextBox_Other_Multiplier)
        Me.Panel_Leakage.Controls.Add(Me.RadLabel_Other_Multiplier)
        Me.Panel_Leakage.Controls.Add(Me.RadButton_Other_EditLeakTable)
        Me.Panel_Leakage.Controls.Add(Me.RadDropDownList_Other_Leakage)
        Me.Panel_Leakage.Controls.Add(Me.RadLabel1_Other_Leakage)
        Me.Panel_Leakage.Location = New System.Drawing.Point(15, 15)
        Me.Panel_Leakage.Name = "Panel_Leakage"
        Me.Panel_Leakage.Size = New System.Drawing.Size(322, 327)
        Me.Panel_Leakage.TabIndex = 0
        '
        'RadTextBox_Other_MaxValue
        '
        Me.RadTextBox_Other_MaxValue.AutoSize = False
        Me.RadTextBox_Other_MaxValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Other_MaxValue.Location = New System.Drawing.Point(117, 168)
        Me.RadTextBox_Other_MaxValue.Name = "RadTextBox_Other_MaxValue"
        Me.RadTextBox_Other_MaxValue.Size = New System.Drawing.Size(187, 25)
        Me.RadTextBox_Other_MaxValue.TabIndex = 77
        Me.RadTextBox_Other_MaxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Other_MaxValue.ThemeName = "Windows8"
        '
        'RadLabel_Other_MaxValue
        '
        Me.RadLabel_Other_MaxValue.AutoSize = False
        Me.RadLabel_Other_MaxValue.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Other_MaxValue.Location = New System.Drawing.Point(11, 168)
        Me.RadLabel_Other_MaxValue.Name = "RadLabel_Other_MaxValue"
        Me.RadLabel_Other_MaxValue.Size = New System.Drawing.Size(100, 25)
        Me.RadLabel_Other_MaxValue.TabIndex = 76
        Me.RadLabel_Other_MaxValue.Text = "RangeData_Other_MaxValue"
        Me.RadLabel_Other_MaxValue.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Other_MaxValue.TextWrap = False
        Me.RadLabel_Other_MaxValue.ThemeName = "Windows8"
        '
        'RadTextBox_Other_Description
        '
        Me.RadTextBox_Other_Description.AutoSize = False
        Me.RadTextBox_Other_Description.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Other_Description.Location = New System.Drawing.Point(117, 132)
        Me.RadTextBox_Other_Description.Name = "RadTextBox_Other_Description"
        Me.RadTextBox_Other_Description.Size = New System.Drawing.Size(187, 25)
        Me.RadTextBox_Other_Description.TabIndex = 75
        Me.RadTextBox_Other_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Other_Description.ThemeName = "Windows8"
        '
        'RadLabel_Other_Description
        '
        Me.RadLabel_Other_Description.AutoSize = False
        Me.RadLabel_Other_Description.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Other_Description.Location = New System.Drawing.Point(11, 132)
        Me.RadLabel_Other_Description.Name = "RadLabel_Other_Description"
        Me.RadLabel_Other_Description.Size = New System.Drawing.Size(100, 25)
        Me.RadLabel_Other_Description.TabIndex = 74
        Me.RadLabel_Other_Description.Text = "RangeData_Other_Description"
        Me.RadLabel_Other_Description.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Other_Description.TextWrap = False
        Me.RadLabel_Other_Description.ThemeName = "Windows8"
        '
        'RadTextBox_Equation
        '
        Me.RadTextBox_Equation.AutoSize = False
        Me.RadTextBox_Equation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Equation.Location = New System.Drawing.Point(117, 96)
        Me.RadTextBox_Equation.Name = "RadTextBox_Equation"
        Me.RadTextBox_Equation.Size = New System.Drawing.Size(187, 25)
        Me.RadTextBox_Equation.TabIndex = 73
        Me.RadTextBox_Equation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Equation.ThemeName = "Windows8"
        '
        'RadLabel_Equation
        '
        Me.RadLabel_Equation.AutoSize = False
        Me.RadLabel_Equation.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Equation.Location = New System.Drawing.Point(11, 96)
        Me.RadLabel_Equation.Name = "RadLabel_Equation"
        Me.RadLabel_Equation.Size = New System.Drawing.Size(100, 25)
        Me.RadLabel_Equation.TabIndex = 72
        Me.RadLabel_Equation.Text = "RangeData_Equation"
        Me.RadLabel_Equation.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Equation.TextWrap = False
        Me.RadLabel_Equation.ThemeName = "Windows8"
        '
        'RadTextBox_Other_Multiplier
        '
        Me.RadTextBox_Other_Multiplier.AutoSize = False
        Me.RadTextBox_Other_Multiplier.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Other_Multiplier.Location = New System.Drawing.Point(117, 60)
        Me.RadTextBox_Other_Multiplier.Name = "RadTextBox_Other_Multiplier"
        Me.RadTextBox_Other_Multiplier.Size = New System.Drawing.Size(187, 25)
        Me.RadTextBox_Other_Multiplier.TabIndex = 71
        Me.RadTextBox_Other_Multiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Other_Multiplier.ThemeName = "Windows8"
        '
        'RadLabel_Other_Multiplier
        '
        Me.RadLabel_Other_Multiplier.AutoSize = False
        Me.RadLabel_Other_Multiplier.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Other_Multiplier.Location = New System.Drawing.Point(11, 60)
        Me.RadLabel_Other_Multiplier.Name = "RadLabel_Other_Multiplier"
        Me.RadLabel_Other_Multiplier.Size = New System.Drawing.Size(100, 25)
        Me.RadLabel_Other_Multiplier.TabIndex = 70
        Me.RadLabel_Other_Multiplier.Text = "RangeData_Other_Multiplier"
        Me.RadLabel_Other_Multiplier.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Other_Multiplier.TextWrap = False
        Me.RadLabel_Other_Multiplier.ThemeName = "Windows8"
        '
        'RadButton_Other_EditLeakTable
        '
        Me.RadButton_Other_EditLeakTable.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadButton_Other_EditLeakTable.Location = New System.Drawing.Point(172, 15)
        Me.RadButton_Other_EditLeakTable.Name = "RadButton_Other_EditLeakTable"
        Me.RadButton_Other_EditLeakTable.Size = New System.Drawing.Size(132, 25)
        Me.RadButton_Other_EditLeakTable.TabIndex = 37
        Me.RadButton_Other_EditLeakTable.Text = "RangeData_Other_EditLeakTable"
        Me.RadButton_Other_EditLeakTable.TextWrap = True
        Me.RadButton_Other_EditLeakTable.ThemeName = "Windows8"
        '
        'RadDropDownList_Other_Leakage
        '
        Me.RadDropDownList_Other_Leakage.AutoSize = False
        Me.RadDropDownList_Other_Leakage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDropDownList_Other_Leakage.Location = New System.Drawing.Point(96, 15)
        Me.RadDropDownList_Other_Leakage.Name = "RadDropDownList_Other_Leakage"
        Me.RadDropDownList_Other_Leakage.Size = New System.Drawing.Size(62, 25)
        Me.RadDropDownList_Other_Leakage.TabIndex = 36
        Me.RadDropDownList_Other_Leakage.ThemeName = "Windows8"
        '
        'RadLabel1_Other_Leakage
        '
        Me.RadLabel1_Other_Leakage.AutoSize = False
        Me.RadLabel1_Other_Leakage.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel1_Other_Leakage.Location = New System.Drawing.Point(11, 15)
        Me.RadLabel1_Other_Leakage.Name = "RadLabel1_Other_Leakage"
        Me.RadLabel1_Other_Leakage.Size = New System.Drawing.Size(85, 25)
        Me.RadLabel1_Other_Leakage.TabIndex = 35
        Me.RadLabel1_Other_Leakage.Text = "RangeData_Other_Leakage"
        Me.RadLabel1_Other_Leakage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel1_Other_Leakage.TextWrap = False
        Me.RadLabel1_Other_Leakage.ThemeName = "Windows8"
        '
        'TabPage_Parameters
        '
        Me.TabPage_Parameters.BackColor = System.Drawing.Color.Silver
        Me.TabPage_Parameters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage_Parameters.Controls.Add(Me.RadGridView_Parameters)
        Me.TabPage_Parameters.Controls.Add(Me.RadLabel_Parameter_ParameterData)
        Me.TabPage_Parameters.Controls.Add(Me.RadTextBox_Parameter_ParameterRange)
        Me.TabPage_Parameters.Controls.Add(Me.RadLabel_Parameter_ParameterRange)
        Me.TabPage_Parameters.Location = New System.Drawing.Point(4, 30)
        Me.TabPage_Parameters.Name = "TabPage_Parameters"
        Me.TabPage_Parameters.Size = New System.Drawing.Size(1150, 506)
        Me.TabPage_Parameters.TabIndex = 3
        Me.TabPage_Parameters.Text = "RangeData_Parameters"
        '
        'RadGridView_Parameters
        '
        Me.RadGridView_Parameters.AutoScroll = True
        Me.RadGridView_Parameters.Location = New System.Drawing.Point(15, 88)
        '
        '
        '
        Me.RadGridView_Parameters.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.RadGridView_Parameters.Name = "RadGridView_Parameters"
        Me.RadGridView_Parameters.Size = New System.Drawing.Size(1119, 398)
        Me.RadGridView_Parameters.TabIndex = 75
        Me.RadGridView_Parameters.Text = "RadGridView1"
        '
        'RadLabel_Parameter_ParameterData
        '
        Me.RadLabel_Parameter_ParameterData.AutoSize = False
        Me.RadLabel_Parameter_ParameterData.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Parameter_ParameterData.Location = New System.Drawing.Point(15, 56)
        Me.RadLabel_Parameter_ParameterData.Name = "RadLabel_Parameter_ParameterData"
        Me.RadLabel_Parameter_ParameterData.Size = New System.Drawing.Size(100, 25)
        Me.RadLabel_Parameter_ParameterData.TabIndex = 74
        Me.RadLabel_Parameter_ParameterData.Text = "RangeData_Parameter_ParameterData"
        Me.RadLabel_Parameter_ParameterData.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Parameter_ParameterData.TextWrap = False
        Me.RadLabel_Parameter_ParameterData.ThemeName = "Windows8"
        '
        'RadTextBox_Parameter_ParameterRange
        '
        Me.RadTextBox_Parameter_ParameterRange.AutoSize = False
        Me.RadTextBox_Parameter_ParameterRange.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Parameter_ParameterRange.Location = New System.Drawing.Point(160, 15)
        Me.RadTextBox_Parameter_ParameterRange.Name = "RadTextBox_Parameter_ParameterRange"
        Me.RadTextBox_Parameter_ParameterRange.Size = New System.Drawing.Size(94, 25)
        Me.RadTextBox_Parameter_ParameterRange.TabIndex = 73
        Me.RadTextBox_Parameter_ParameterRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Parameter_ParameterRange.ThemeName = "Windows8"
        '
        'RadLabel_Parameter_ParameterRange
        '
        Me.RadLabel_Parameter_ParameterRange.AutoSize = False
        Me.RadLabel_Parameter_ParameterRange.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Parameter_ParameterRange.Location = New System.Drawing.Point(15, 15)
        Me.RadLabel_Parameter_ParameterRange.Name = "RadLabel_Parameter_ParameterRange"
        Me.RadLabel_Parameter_ParameterRange.Size = New System.Drawing.Size(139, 25)
        Me.RadLabel_Parameter_ParameterRange.TabIndex = 72
        Me.RadLabel_Parameter_ParameterRange.Text = "RangeData_Parameter_ParameterRange"
        Me.RadLabel_Parameter_ParameterRange.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Parameter_ParameterRange.TextWrap = False
        Me.RadLabel_Parameter_ParameterRange.ThemeName = "Windows8"
        '
        'TabPage_EOL
        '
        Me.TabPage_EOL.BackColor = System.Drawing.Color.Silver
        Me.TabPage_EOL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage_EOL.Controls.Add(Me.RadGridView_EOL)
        Me.TabPage_EOL.Controls.Add(Me.RadDropDownList_EOL_EOLRange)
        Me.TabPage_EOL.Controls.Add(Me.RadLabel_EOL_EOLRange)
        Me.TabPage_EOL.Location = New System.Drawing.Point(4, 30)
        Me.TabPage_EOL.Name = "TabPage_EOL"
        Me.TabPage_EOL.Size = New System.Drawing.Size(1150, 506)
        Me.TabPage_EOL.TabIndex = 4
        Me.TabPage_EOL.Text = "RangeData_EOL"
        '
        'RadGridView_EOL
        '
        Me.RadGridView_EOL.AutoScroll = True
        Me.RadGridView_EOL.Location = New System.Drawing.Point(15, 47)
        '
        '
        '
        Me.RadGridView_EOL.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.RadGridView_EOL.Name = "RadGridView_EOL"
        Me.RadGridView_EOL.Size = New System.Drawing.Size(1119, 439)
        Me.RadGridView_EOL.TabIndex = 37
        Me.RadGridView_EOL.Text = "RadGridView1"
        '
        'RadDropDownList_EOL_EOLRange
        '
        Me.RadDropDownList_EOL_EOLRange.AutoSize = False
        Me.RadDropDownList_EOL_EOLRange.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDropDownList_EOL_EOLRange.Location = New System.Drawing.Point(159, 17)
        Me.RadDropDownList_EOL_EOLRange.Name = "RadDropDownList_EOL_EOLRange"
        Me.RadDropDownList_EOL_EOLRange.Size = New System.Drawing.Size(179, 25)
        Me.RadDropDownList_EOL_EOLRange.TabIndex = 36
        Me.RadDropDownList_EOL_EOLRange.ThemeName = "Windows8"
        '
        'RadLabel_EOL_EOLRange
        '
        Me.RadLabel_EOL_EOLRange.AutoSize = False
        Me.RadLabel_EOL_EOLRange.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_EOL_EOLRange.Location = New System.Drawing.Point(15, 15)
        Me.RadLabel_EOL_EOLRange.Name = "RadLabel_EOL_EOLRange"
        Me.RadLabel_EOL_EOLRange.Size = New System.Drawing.Size(138, 25)
        Me.RadLabel_EOL_EOLRange.TabIndex = 35
        Me.RadLabel_EOL_EOLRange.Text = "RangeData_EOL_EOLRange"
        Me.RadLabel_EOL_EOLRange.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_EOL_EOLRange.TextWrap = False
        Me.RadLabel_EOL_EOLRange.ThemeName = "Windows8"
        '
        'RangeData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1206, 776)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.RadTextBox_EndOfLifeRange)
        Me.Controls.Add(Me.RadLabel_EndOfLifeRange)
        Me.Controls.Add(Me.RadTextBox_ParameterRange)
        Me.Controls.Add(Me.RadLabel_ParameterRange)
        Me.Controls.Add(Me.RadTextBox_CostingGroup)
        Me.Controls.Add(Me.RadLabel_CostingGroup)
        Me.Controls.Add(Me.RadTextBox_Leakage)
        Me.Controls.Add(Me.RadLabel_Leakage)
        Me.Controls.Add(Me.RadTextBox2)
        Me.Controls.Add(Me.RadLabel_LifeRange)
        Me.Controls.Add(Me.RadTextBox_ThermalRange)
        Me.Controls.Add(Me.RadLabel_ThermalRange)
        Me.Controls.Add(Me.RadTextBox_StdESRFreq)
        Me.Controls.Add(Me.RadLabel_StdESRFreq)
        Me.Controls.Add(Me.RadTextBox_StdImpFreq)
        Me.Controls.Add(Me.RadLabel_StdImpFreq)
        Me.Controls.Add(Me.RadTextBox_StdESRTemp)
        Me.Controls.Add(Me.RadLabel_StdESRTemp)
        Me.Controls.Add(Me.RadTextBox_YieldRange)
        Me.Controls.Add(Me.RadLabel_YieldRange)
        Me.Controls.Add(Me.RadTextBox_StdOpTemp)
        Me.Controls.Add(Me.RadLabel_StdOpTemp)
        Me.Controls.Add(Me.RadTextBox_Description)
        Me.Controls.Add(Me.RadLabel_Description)
        Me.Controls.Add(Me.RadDropDownList_Range)
        Me.Controls.Add(Me.RadLabel_Range)
        Me.Controls.Add(Me.Panel_Header)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RangeData"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RangeData_TitleWindow"
        Me.ThemeName = "Windows8"
        Me.Panel_Header.ResumeLayout(False)
        CType(Me.RadDropDownList_FromHere, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_CopyToHereFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_CopyThisRecordToNewRecord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_Range, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Range, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Description, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Description, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_StdOpTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_StdOpTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_YieldRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_YieldRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_StdImpFreq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_StdImpFreq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_StdESRTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_StdESRTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_StdESRFreq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_StdESRFreq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ThermalRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ThermalRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_LifeRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Leakage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Leakage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CostingGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_CostingGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ParameterRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ParameterRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_EndOfLifeRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_EndOfLifeRange, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_Thermal.ResumeLayout(False)
        CType(Me.RadButton_Thermal_EditThermalTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_Thermal.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_Thermal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Thermal_RHAInUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Thermal_RHAIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Thermal_LensInUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Thermal_LensIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_Thermal_ThermalRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Thermal_ThermalRange, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Life.ResumeLayout(False)
        CType(Me.RadGridView_Life.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_Life, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Life_EditLifeTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_Life_LifeRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Life_LifeRange, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Other.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.RadTextBox_Other_StdShippingCostVAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Other_StdOHMultiplierVAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Other_StdLabourRateVAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Other_StdMaterialYieldVAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Other_StdWindingYieldVAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Other_StdShippingCostSTD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Other_StdOHMultiplierSTD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Other_StdLabourRateSTD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Other_StdMaterialYieldSTD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Other_StdWindingYieldSTD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Other_Var, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Other_Std, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Other_StdShippingCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Other_StdOHMultiplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Other_StdLabourRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Other_StdMaterialYield, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Other_StdWindingYield, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Other_CostGroupDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_Other_CostingGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Other_CostingGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Leakage.ResumeLayout(False)
        CType(Me.RadTextBox_Other_MaxValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Other_MaxValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Other_Description, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Other_Description, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Equation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Equation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Other_Multiplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Other_Multiplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Other_EditLeakTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_Other_Leakage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1_Other_Leakage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Parameters.ResumeLayout(False)
        CType(Me.RadGridView_Parameters.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_Parameters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Parameter_ParameterData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Parameter_ParameterRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Parameter_ParameterRange, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_EOL.ResumeLayout(False)
        CType(Me.RadGridView_EOL.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_EOL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_EOL_EOLRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_EOL_EOLRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Header As System.Windows.Forms.Panel
    Friend WithEvents RadButton_CopyThisRecordToNewRecord As Telerik.WinControls.UI.RadButton
    Friend WithEvents PictureBox_KemetLogo As System.Windows.Forms.PictureBox
    Friend WithEvents RadLabel_Title As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton_CopyToHereFrom As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadDropDownList_Range As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_Range As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Description As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Description As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_FromHere As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadTextBox_StdOpTemp As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_StdOpTemp As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_YieldRange As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_YieldRange As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_StdImpFreq As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_StdImpFreq As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_StdESRTemp As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_StdESRTemp As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_StdESRFreq As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_StdESRFreq As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_ThermalRange As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_ThermalRange As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_LifeRange As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Leakage As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Leakage As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_CostingGroup As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_CostingGroup As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_ParameterRange As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_ParameterRange As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_EndOfLifeRange As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_EndOfLifeRange As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Thermal As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Life As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Other As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Parameters As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_EOL As System.Windows.Forms.TabPage
    Friend WithEvents RadGridView_Thermal As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel_Thermal_RHAInUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Thermal_RHAIn As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Thermal_LensInUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Thermal_LensIn As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_Thermal_ThermalRange As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_Thermal_ThermalRange As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton_Thermal_EditThermalTable As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Life_EditLifeTable As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadDropDownList_Life_LifeRange As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_Life_LifeRange As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGridView_Life As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Panel_Leakage As System.Windows.Forms.Panel
    Friend WithEvents RadDropDownList_Other_Leakage As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel1_Other_Leakage As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton_Other_EditLeakTable As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadTextBox_Other_MaxValue As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Other_MaxValue As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Other_Description As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Other_Description As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Equation As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Equation As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Other_Multiplier As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Other_Multiplier As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RadDropDownList_Other_CostingGroup As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_Other_CostingGroup As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Other_StdShippingCost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Other_StdOHMultiplier As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Other_StdLabourRate As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Other_StdMaterialYield As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Other_StdWindingYield As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Other_CostGroupDesc As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Other_StdShippingCostVAR As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Other_StdOHMultiplierVAR As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Other_StdLabourRateVAR As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Other_StdMaterialYieldVAR As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Other_StdWindingYieldVAR As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Other_StdShippingCostSTD As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Other_StdOHMultiplierSTD As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Other_StdLabourRateSTD As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Other_StdMaterialYieldSTD As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Other_StdWindingYieldSTD As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Other_Var As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Other_Std As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Parameter_ParameterRange As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Parameter_ParameterRange As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Parameter_ParameterData As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGridView_Parameters As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadDropDownList_EOL_EOLRange As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_EOL_EOLRange As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGridView_EOL As Telerik.WinControls.UI.RadGridView
End Class

