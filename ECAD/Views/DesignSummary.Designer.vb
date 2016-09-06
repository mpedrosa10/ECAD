<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DesignSummary
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
        Dim ListViewDetailColumn1 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Key")
        Dim ListViewDetailColumn2 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Value")
        Dim ListViewDataItem1 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("xkkk")
        Dim ListViewDataItem2 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("xxx")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DesignSummary))
        Me.RadDropDownList_SpecDrawing = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_DimensionDWG = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_WindingPicture = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_Routing = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_PartsFile = New Telerik.WinControls.UI.RadDropDownList()
        Me.Panel_Prices = New System.Windows.Forms.Panel()
        Me.RadLabel_ImageCoverPrices = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_VariableTotal = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_VariableOH = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_StandardTotal = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_StandardOH = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Labor = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Material = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_PriceTotal = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_OH = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Labor = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Material = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Variable = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Standard = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_NoLabData = New Telerik.WinControls.UI.RadLabel()
        Me.RadCheckBox_SEV = New Telerik.WinControls.UI.RadCheckBox()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.RadButton_SampleCost = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_ShowAllCriteria = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_HideAllCriteria = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_ShowAllRecords = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_FilterRecords = New Telerik.WinControls.UI.RadButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadTextBox_KemetPartNumber = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Issue = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Date = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_TestVoltage = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_ASNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_LenTolerance = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Len = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_SurgeVoltage = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Temp = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_DiaTolerance = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Dia = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_WorkVoltage = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_HighTolCapacitance = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_LowTolCapacitance = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_LowTemp = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Capacitance = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox10 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Issue = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Date = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_PSIPartStyle = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_TestVoltageUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadCheckBox_DesignChecked = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel_TestVoltage = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_ASNo = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Len = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_SurgeVoltageUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_SurgeVoltage = New Telerik.WinControls.UI.RadLabel()
        Me.RadCheckBox_ac = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel_TempUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Dia = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_WorkVoltageUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_WorkVoltage = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_PSIPartStyle = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_Range = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_Range = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_PartNumber = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_Minus = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_CapacitanceUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Plus = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_PercentageLowTolCapacitance = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_PercentageHighTolCapacitance = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_LowTempUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RadButton_SetOutline = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_SetObs = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_SetHold = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_SetLive = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox_KemetLogo = New System.Windows.Forms.PictureBox()
        Me.RadButton_Delete = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Transfer = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_GoToScratchPad = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_AddToList = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_StockOrders = New Telerik.WinControls.UI.RadButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.RadTextBox_DesApp = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_QAApp = New Telerik.WinControls.UI.RadTextBox()
        Me.RadButton_DesApp = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_QAApp = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_CleapApps = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_NewSpec = New Telerik.WinControls.UI.RadButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl_AddCatData = New System.Windows.Forms.TabControl()
        Me.TabPage_pgeCatData = New System.Windows.Forms.TabPage()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.RadTextBox_TableCondy = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_TableCondy = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox6 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox7 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox8 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox9 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox4 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox3 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_TableRiseT = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_TableRbc = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_TableRwb = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_TableRhw = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_TableOxide = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_TableTissue = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_TableTabbing = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_TableFoil = New Telerik.WinControls.UI.RadLabel()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.RadLabel_CatalogueData = New Telerik.WinControls.UI.RadLabel()
        Me.TabPage_pgeAddData = New System.Windows.Forms.TabPage()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.RadLabel_SpecificationDetails = New Telerik.WinControls.UI.RadLabel()
        Me.Label_At1 = New System.Windows.Forms.Label()
        Me.Label_At2 = New System.Windows.Forms.Label()
        Me.RadTextBox_Customer = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_CustomerPartNumber = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Distributor = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_SpecDrawingSpecs = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Terminals = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Dimensions = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_SpecNotes = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_RatedIR = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_IRFreq = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_IRTemp = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Customer = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_CustomerPartNumber = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Distributor = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_SpecDrawingSpecs = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Terminals = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Dimensions = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_SpecNotes = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_RatedIR = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_RatedIRUnit = New Telerik.WinControls.UI.RadLabel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.RadLabel_IRTempUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_IRFreqUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_PartsFile = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Routing = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_WindingPicture = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_DimensionDWG = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_SpecDrawing = New Telerik.WinControls.UI.RadLabel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.RadLabel_NoLabData2 = New Telerik.WinControls.UI.RadLabel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.RadTextBox_LimitValue = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_TestValue3 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_TestValue2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_TestValue1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadDropDownList_LimitCondition = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_LimitMethod = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_TestCondition3 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_TestParameter3 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_TestCondition2 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_TestParameter2 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_TestCondition1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_TestParameter1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.RadLabel_TestParameteres = New Telerik.WinControls.UI.RadLabel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.RadLabel_WindingMaterials = New Telerik.WinControls.UI.RadLabel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.RadLabel_AnodeNone2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox5 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox11 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox12 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox13 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox14 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox15 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox16 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox17 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox18 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_03 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_AnodeCost2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_AnodeCost1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_AnodeAmount2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_AnodeAmount1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_AnodeUnitCost2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_AnodeUnitCost1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_AnodeUnitCost2Unit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_AnodeUnitCost1Unit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_AnodeDetail2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_AnodeDetail1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_AnodeDetail2Unit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_AnodeDetail1Unit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_AnodeThick2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_AnodeThick1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_AnodeThick2Unit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_AnodeThick1Unit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_AnodeGain2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_AnodeGain2Unit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_AnodeGain1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_AnodeGain1Unit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_AnodeWidth2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_AnodeVoltage2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_AnodePartNumber2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_AnodeWidth1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_AnodeVoltage1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_AnodePartNumber1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_02 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_01 = New Telerik.WinControls.UI.RadLabel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.RadLabel_Anodes = New Telerik.WinControls.UI.RadLabel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.RadTextBox_AnodeLenGain2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_AnodeLenGain1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_AnodeLenGain2Unit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_AnodeLenGain1Unit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_AnodeLen2Unit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_AnodeLen1Unit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_AnodeLen2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_AnodeLen1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Cath = New Telerik.WinControls.UI.RadLabel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.RadDropDownList_TissuePart3 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_TissuePart2 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_TissuePart1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadTextBox_TissueCost3 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_TissueCost2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_TissueAmount3 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_TissueAmount2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_TissueUnitCost3 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_TissueUnitCost2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_TissueCost1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_TissueUnitCost1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_TissueAmount1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_TissueUnitCost3Unit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_TissueUnitCost2Unit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_TissueUnitCost1Unit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_TissueDetail1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_TissueDetail2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_TabDetail = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_TissueDetail3Unit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_TissueDetail2Unit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_TissueDetail1Unit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_TissueThick3 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_TissueThick2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_TissueThick1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_TissueThick3Unit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_TissueThick2Unit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_TissueThick1Unit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_TissueWidth3 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_TissueWidth2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_TissueWidth1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_13 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_12 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_11 = New Telerik.WinControls.UI.RadLabel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.RadLabel_Tissues = New Telerik.WinControls.UI.RadLabel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.RadLabel_MaxCapUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_MaxCap = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_PercentageFit = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_WFactor = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_MaxLengthGain = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_MaxLengthGainUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_MaxLengthUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_MaxLength = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Cap = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_CapPercentageFit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_CapAt = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_PercentageFit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_WFactor = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_MaxLength = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Tab = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Elyte = New Telerik.WinControls.UI.RadLabel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.RadTextBox_MelQty = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_HoleTheta = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Melinex = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_No = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_L2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Mandrel = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_L1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_PreWrap = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_CathExt = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_CanIntTheta = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_CathExt = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_CathExtUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Mandrel = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_CanIntThetaUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_MandrelUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_No = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_HoleTheta = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_HoleThetaUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_MelQty = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Melinex = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_L2Unit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_L2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_L1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_PreWrap = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_CanIntTheta = New Telerik.WinControls.UI.RadLabel()
        Me.RadCheckBox_Swage = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_AW = New Telerik.WinControls.UI.RadCheckBox()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.RadTextBox_Z10KHz = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_ESR100Hz = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_ESRFoil10Percent = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_ESRFoil10 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_ESROxide10Percent = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_ESRTabbing10Percent = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_ESRTissue10Percent = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_ESRTabbing10 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_ESROxide10 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_ESRFoil100Percent = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_ESRTissue10 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_ESROxide100Percent = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_ESRTissue100Percent = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_ESRTabbing100Percent = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_ESRFoil100 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_ESROxide100 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_ESRTissue100 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_ESRTabbing100 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Z10KHz = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_ESR100Hz = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Total = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_ESRFoil = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_ESROxide = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_ESRTissue = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_ESRTabbing = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_At10kHz = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_At100Hz = New Telerik.WinControls.UI.RadLabel()
        Me.RadButton_ESRGraphForm = New Telerik.WinControls.UI.RadButton()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.RadLabel_ESRData = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_NoESRDataOnStyleDesign = New Telerik.WinControls.UI.RadLabel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.RadDropDownList_ElytePartNumber = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_TabPartNumber = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_CathPartNumber = New Telerik.WinControls.UI.RadDropDownList()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.RadLabel_CoverSampleCostButtons = New Telerik.WinControls.UI.RadLabel()
        Me.RadListView_AssemblyNotes = New Telerik.WinControls.UI.RadListView()
        Me.RadLabel_PrintDrawing = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_DesignNotes = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_PrintNotes = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_AssemblyNotes = New Telerik.WinControls.UI.RadLabel()
        Me.RadCheckBox_Scrollbar = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadButton_Center = New Telerik.WinControls.UI.RadButton()
        Me.RadDropDownList_PrintNumber = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadTextBox_DesignNotes = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_PrintNotes = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_ElyteUnitCost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_ElyteAmount = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_ElyteUnitCostUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_ElyteCost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_TabCost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_TabAmount = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_TabUnitCost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_TabUnitCostUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_TabDetailUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_TabThick = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_TabThickUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_CathCost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_CathAmount = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_CathUnitCost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_CathUnitCostUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_CathDetail = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_CathDetailUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_CathThick = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_CathThickUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_CathGain = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_CathGainUnit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_CathWidth = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_WindingMaterialsName = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_WindingMaterialsFV = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_WindingMaterialsWidth = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_WindingMaterialsGain = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_WindingMaterialsThick = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_WindingMaterialsDetail = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_WindingMaterialsUnitcost = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_WindingMaterialsAmount = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_WindingMaterialsCost = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_WindingMaterialsLengths = New Telerik.WinControls.UI.RadLabel()
        Me.RadScrollablePanel1 = New Telerik.WinControls.UI.RadScrollablePanel()
        Me.RadLabel_AnodeNone3 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadDropDownList_SpecDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_DimensionDWG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_WindingPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_Routing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_PartsFile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Prices.SuspendLayout()
        CType(Me.RadLabel_ImageCoverPrices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_VariableTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_VariableOH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_StandardTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_StandardOH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Labor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Material, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PriceTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_OH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Labor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Material, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Variable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Standard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_NoLabData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_SEV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel19.SuspendLayout()
        CType(Me.RadButton_SampleCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_ShowAllCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_HideAllCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_ShowAllRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_FilterRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.RadTextBox_KemetPartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Issue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TestVoltage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ASNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_LenTolerance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Len, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_SurgeVoltage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Temp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_DiaTolerance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Dia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_WorkVoltage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_HighTolCapacitance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_LowTolCapacitance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_LowTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Capacitance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Issue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_PSIPartStyle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TestVoltageUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_DesignChecked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TestVoltage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ASNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Len, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_SurgeVoltageUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_SurgeVoltage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_ac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TempUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Dia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_WorkVoltageUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_WorkVoltage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PSIPartStyle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_Range, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Range, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_PartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Minus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_CapacitanceUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Plus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PercentageLowTolCapacitance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PercentageHighTolCapacitance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_LowTempUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.RadButton_SetOutline, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_SetObs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_SetHold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_SetLive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Transfer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_GoToScratchPad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_AddToList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_StockOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.RadTextBox_DesApp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_QAApp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_DesApp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_QAApp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_CleapApps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_NewSpec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabControl_AddCatData.SuspendLayout()
        Me.TabPage_pgeCatData.SuspendLayout()
        Me.Panel21.SuspendLayout()
        CType(Me.RadTextBox_TableCondy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TableCondy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TableRiseT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TableRbc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TableRwb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TableRhw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TableOxide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TableTissue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TableTabbing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TableFoil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel25.SuspendLayout()
        CType(Me.RadLabel_CatalogueData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_pgeAddData.SuspendLayout()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.RadLabel_SpecificationDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CustomerPartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Distributor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_SpecDrawingSpecs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Terminals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Dimensions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_SpecNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_RatedIR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_IRFreq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_IRTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_CustomerPartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Distributor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_SpecDrawingSpecs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Terminals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Dimensions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_SpecNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_RatedIR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_RatedIRUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.RadLabel_IRTempUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_IRFreqUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PartsFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Routing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_WindingPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_DimensionDWG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_SpecDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.RadLabel_NoLabData2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel22.SuspendLayout()
        CType(Me.RadTextBox_LimitValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TestValue3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TestValue2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TestValue1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_LimitCondition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_LimitMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_TestCondition3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_TestParameter3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_TestCondition2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_TestParameter2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_TestCondition1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_TestParameter1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel24.SuspendLayout()
        CType(Me.RadLabel_TestParameteres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        CType(Me.RadLabel_WindingMaterials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        CType(Me.RadLabel_AnodeNone2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_AnodeCost2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_AnodeCost1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_AnodeAmount2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_AnodeAmount1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_AnodeUnitCost2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_AnodeUnitCost1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_AnodeUnitCost2Unit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_AnodeUnitCost1Unit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_AnodeDetail2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_AnodeDetail1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_AnodeDetail2Unit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_AnodeDetail1Unit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_AnodeThick2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_AnodeThick1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_AnodeThick2Unit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_AnodeThick1Unit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_AnodeGain2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_AnodeGain2Unit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_AnodeGain1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_AnodeGain1Unit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_AnodeWidth2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_AnodeVoltage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_AnodePartNumber2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_AnodeWidth1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_AnodeVoltage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_AnodePartNumber1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        CType(Me.RadLabel_Anodes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        CType(Me.RadTextBox_AnodeLenGain2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_AnodeLenGain1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_AnodeLenGain2Unit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_AnodeLenGain1Unit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_AnodeLen2Unit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_AnodeLen1Unit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_AnodeLen2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_AnodeLen1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Cath, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel16.SuspendLayout()
        CType(Me.RadDropDownList_TissuePart3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_TissuePart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_TissuePart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TissueCost3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TissueCost2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TissueAmount3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TissueAmount2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TissueUnitCost3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TissueUnitCost2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TissueCost1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TissueUnitCost1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TissueAmount1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TissueUnitCost3Unit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TissueUnitCost2Unit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TissueUnitCost1Unit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TissueDetail1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TissueDetail2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TabDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TissueDetail3Unit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TissueDetail2Unit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TissueDetail1Unit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TissueThick3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TissueThick2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TissueThick1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TissueThick3Unit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TissueThick2Unit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TissueThick1Unit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TissueWidth3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TissueWidth2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TissueWidth1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel17.SuspendLayout()
        CType(Me.RadLabel_Tissues, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel15.SuspendLayout()
        CType(Me.RadLabel_MaxCapUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_MaxCap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_PercentageFit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_WFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_MaxLengthGain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_MaxLengthGainUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_MaxLengthUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_MaxLength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Cap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadLabel_Cap.SuspendLayout()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_CapPercentageFit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_CapAt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PercentageFit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_WFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_MaxLength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Tab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Elyte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel18.SuspendLayout()
        CType(Me.RadTextBox_MelQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_HoleTheta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Melinex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_L2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Mandrel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_L1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_PreWrap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CathExt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CanIntTheta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_CathExt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_CathExtUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Mandrel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_CanIntThetaUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_MandrelUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_HoleTheta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_HoleThetaUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_MelQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Melinex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_L2Unit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_L2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_L1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PreWrap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_CanIntTheta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_Swage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_AW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel23.SuspendLayout()
        CType(Me.RadTextBox_Z10KHz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ESR100Hz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ESRFoil10Percent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ESRFoil10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ESROxide10Percent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ESRTabbing10Percent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ESRTissue10Percent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ESRTabbing10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ESROxide10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ESRFoil100Percent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ESRTissue10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ESROxide100Percent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ESRTissue100Percent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ESRTabbing100Percent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ESRFoil100, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ESROxide100, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ESRTissue100, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ESRTabbing100, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Z10KHz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ESR100Hz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Total, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ESRFoil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ESROxide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ESRTissue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ESRTabbing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_At10kHz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_At100Hz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_ESRGraphForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel20.SuspendLayout()
        CType(Me.RadLabel_ESRData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_NoESRDataOnStyleDesign, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.RadDropDownList_ElytePartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_TabPartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_CathPartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.RadLabel_CoverSampleCostButtons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadListView_AssemblyNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PrintDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_DesignNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PrintNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_AssemblyNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_Scrollbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Center, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_PrintNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_DesignNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_PrintNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ElyteUnitCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ElyteAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ElyteUnitCostUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ElyteCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TabCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TabAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TabUnitCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TabUnitCostUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TabDetailUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_TabThick, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TabThickUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CathCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CathAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CathUnitCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_CathUnitCostUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CathDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_CathDetailUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CathThick, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_CathThickUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CathGain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_CathGainUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CathWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_WindingMaterialsName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_WindingMaterialsFV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_WindingMaterialsWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_WindingMaterialsGain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_WindingMaterialsThick, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_WindingMaterialsDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_WindingMaterialsUnitcost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_WindingMaterialsAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_WindingMaterialsCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_WindingMaterialsLengths, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadScrollablePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadScrollablePanel1.PanelContainer.SuspendLayout()
        Me.RadScrollablePanel1.SuspendLayout()
        CType(Me.RadLabel_AnodeNone3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadDropDownList_SpecDrawing
        '
        Me.RadDropDownList_SpecDrawing.AutoSize = False
        Me.RadDropDownList_SpecDrawing.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadDropDownList_SpecDrawing.Location = New System.Drawing.Point(151, 127)
        Me.RadDropDownList_SpecDrawing.Name = "RadDropDownList_SpecDrawing"
        Me.RadDropDownList_SpecDrawing.Size = New System.Drawing.Size(176, 27)
        Me.RadDropDownList_SpecDrawing.TabIndex = 8
        Me.RadDropDownList_SpecDrawing.Text = "ALSPSPEC"
        Me.RadDropDownList_SpecDrawing.ThemeName = "Windows8"
        '
        'RadDropDownList_DimensionDWG
        '
        Me.RadDropDownList_DimensionDWG.AutoSize = False
        Me.RadDropDownList_DimensionDWG.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadDropDownList_DimensionDWG.Location = New System.Drawing.Point(151, 97)
        Me.RadDropDownList_DimensionDWG.Name = "RadDropDownList_DimensionDWG"
        Me.RadDropDownList_DimensionDWG.Size = New System.Drawing.Size(176, 27)
        Me.RadDropDownList_DimensionDWG.TabIndex = 12
        Me.RadDropDownList_DimensionDWG.Text = "ALSP"
        Me.RadDropDownList_DimensionDWG.ThemeName = "Windows8"
        '
        'RadDropDownList_WindingPicture
        '
        Me.RadDropDownList_WindingPicture.AutoSize = False
        Me.RadDropDownList_WindingPicture.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadDropDownList_WindingPicture.Location = New System.Drawing.Point(151, 67)
        Me.RadDropDownList_WindingPicture.Name = "RadDropDownList_WindingPicture"
        Me.RadDropDownList_WindingPicture.Size = New System.Drawing.Size(176, 27)
        Me.RadDropDownList_WindingPicture.TabIndex = 10
        Me.RadDropDownList_WindingPicture.Text = "ALSE2"
        Me.RadDropDownList_WindingPicture.ThemeName = "Windows8"
        '
        'RadDropDownList_Routing
        '
        Me.RadDropDownList_Routing.AutoSize = False
        Me.RadDropDownList_Routing.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadDropDownList_Routing.Location = New System.Drawing.Point(151, 37)
        Me.RadDropDownList_Routing.Name = "RadDropDownList_Routing"
        Me.RadDropDownList_Routing.Size = New System.Drawing.Size(176, 27)
        Me.RadDropDownList_Routing.TabIndex = 8
        Me.RadDropDownList_Routing.Text = "ALS50"
        Me.RadDropDownList_Routing.ThemeName = "Windows8"
        '
        'RadDropDownList_PartsFile
        '
        Me.RadDropDownList_PartsFile.AutoSize = False
        Me.RadDropDownList_PartsFile.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadDropDownList_PartsFile.Location = New System.Drawing.Point(151, 7)
        Me.RadDropDownList_PartsFile.Name = "RadDropDownList_PartsFile"
        Me.RadDropDownList_PartsFile.Size = New System.Drawing.Size(176, 27)
        Me.RadDropDownList_PartsFile.TabIndex = 6
        Me.RadDropDownList_PartsFile.Text = "QP_ALS36HK2CPC"
        Me.RadDropDownList_PartsFile.ThemeName = "Windows8"
        '
        'Panel_Prices
        '
        Me.Panel_Prices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Prices.Controls.Add(Me.RadLabel_ImageCoverPrices)
        Me.Panel_Prices.Controls.Add(Me.RadTextBox_VariableTotal)
        Me.Panel_Prices.Controls.Add(Me.RadTextBox_VariableOH)
        Me.Panel_Prices.Controls.Add(Me.RadTextBox_StandardTotal)
        Me.Panel_Prices.Controls.Add(Me.RadTextBox_StandardOH)
        Me.Panel_Prices.Controls.Add(Me.RadTextBox_Labor)
        Me.Panel_Prices.Controls.Add(Me.RadTextBox_Material)
        Me.Panel_Prices.Controls.Add(Me.RadLabel_PriceTotal)
        Me.Panel_Prices.Controls.Add(Me.RadLabel_OH)
        Me.Panel_Prices.Controls.Add(Me.RadLabel_Labor)
        Me.Panel_Prices.Controls.Add(Me.RadLabel_Material)
        Me.Panel_Prices.Controls.Add(Me.RadLabel_Variable)
        Me.Panel_Prices.Controls.Add(Me.RadLabel_Standard)
        Me.Panel_Prices.Controls.Add(Me.RadLabel_NoLabData)
        Me.Panel_Prices.Controls.Add(Me.RadCheckBox_SEV)
        Me.Panel_Prices.Location = New System.Drawing.Point(955, 721)
        Me.Panel_Prices.Name = "Panel_Prices"
        Me.Panel_Prices.Size = New System.Drawing.Size(357, 237)
        Me.Panel_Prices.TabIndex = 16
        '
        'RadLabel_ImageCoverPrices
        '
        Me.RadLabel_ImageCoverPrices.AutoSize = False
        Me.RadLabel_ImageCoverPrices.BackgroundImage = Global.ECAD.My.Resources.Resources.Ecad_icon
        Me.RadLabel_ImageCoverPrices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadLabel_ImageCoverPrices.Location = New System.Drawing.Point(0, 0)
        Me.RadLabel_ImageCoverPrices.Name = "RadLabel_ImageCoverPrices"
        Me.RadLabel_ImageCoverPrices.Size = New System.Drawing.Size(347, 201)
        Me.RadLabel_ImageCoverPrices.TabIndex = 122
        Me.RadLabel_ImageCoverPrices.Visible = False
        '
        'RadTextBox_VariableTotal
        '
        Me.RadTextBox_VariableTotal.AutoSize = False
        Me.RadTextBox_VariableTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_VariableTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_VariableTotal.Location = New System.Drawing.Point(209, 160)
        Me.RadTextBox_VariableTotal.Name = "RadTextBox_VariableTotal"
        Me.RadTextBox_VariableTotal.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_VariableTotal.TabIndex = 126
        Me.RadTextBox_VariableTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_VariableTotal.ThemeName = "Windows8"
        '
        'RadTextBox_VariableOH
        '
        Me.RadTextBox_VariableOH.AutoSize = False
        Me.RadTextBox_VariableOH.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_VariableOH.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_VariableOH.Location = New System.Drawing.Point(209, 123)
        Me.RadTextBox_VariableOH.Name = "RadTextBox_VariableOH"
        Me.RadTextBox_VariableOH.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_VariableOH.TabIndex = 124
        Me.RadTextBox_VariableOH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_VariableOH.ThemeName = "Windows8"
        '
        'RadTextBox_StandardTotal
        '
        Me.RadTextBox_StandardTotal.AutoSize = False
        Me.RadTextBox_StandardTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_StandardTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_StandardTotal.Location = New System.Drawing.Point(112, 160)
        Me.RadTextBox_StandardTotal.Name = "RadTextBox_StandardTotal"
        Me.RadTextBox_StandardTotal.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_StandardTotal.TabIndex = 125
        Me.RadTextBox_StandardTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_StandardTotal.ThemeName = "Windows8"
        '
        'RadTextBox_StandardOH
        '
        Me.RadTextBox_StandardOH.AutoSize = False
        Me.RadTextBox_StandardOH.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_StandardOH.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_StandardOH.Location = New System.Drawing.Point(112, 123)
        Me.RadTextBox_StandardOH.Name = "RadTextBox_StandardOH"
        Me.RadTextBox_StandardOH.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_StandardOH.TabIndex = 123
        Me.RadTextBox_StandardOH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_StandardOH.ThemeName = "Windows8"
        '
        'RadTextBox_Labor
        '
        Me.RadTextBox_Labor.AutoSize = False
        Me.RadTextBox_Labor.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_Labor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Labor.Location = New System.Drawing.Point(145, 79)
        Me.RadTextBox_Labor.Name = "RadTextBox_Labor"
        Me.RadTextBox_Labor.Size = New System.Drawing.Size(100, 29)
        Me.RadTextBox_Labor.TabIndex = 122
        Me.RadTextBox_Labor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Labor.ThemeName = "Windows8"
        '
        'RadTextBox_Material
        '
        Me.RadTextBox_Material.AutoSize = False
        Me.RadTextBox_Material.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_Material.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Material.Location = New System.Drawing.Point(145, 44)
        Me.RadTextBox_Material.Name = "RadTextBox_Material"
        Me.RadTextBox_Material.Size = New System.Drawing.Size(100, 29)
        Me.RadTextBox_Material.TabIndex = 121
        Me.RadTextBox_Material.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Material.ThemeName = "Windows8"
        '
        'RadLabel_PriceTotal
        '
        Me.RadLabel_PriceTotal.AutoSize = False
        Me.RadLabel_PriceTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_PriceTotal.Location = New System.Drawing.Point(29, 160)
        Me.RadLabel_PriceTotal.Name = "RadLabel_PriceTotal"
        Me.RadLabel_PriceTotal.Size = New System.Drawing.Size(73, 31)
        Me.RadLabel_PriceTotal.TabIndex = 142
        Me.RadLabel_PriceTotal.Text = "DesignSummary_Total"
        Me.RadLabel_PriceTotal.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_PriceTotal.TextWrap = False
        Me.RadLabel_PriceTotal.ThemeName = "Windows8"
        '
        'RadLabel_OH
        '
        Me.RadLabel_OH.AutoSize = False
        Me.RadLabel_OH.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_OH.Location = New System.Drawing.Point(29, 123)
        Me.RadLabel_OH.Name = "RadLabel_OH"
        Me.RadLabel_OH.Size = New System.Drawing.Size(73, 31)
        Me.RadLabel_OH.TabIndex = 142
        Me.RadLabel_OH.Text = "DesignSummary_OH"
        Me.RadLabel_OH.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_OH.TextWrap = False
        Me.RadLabel_OH.ThemeName = "Windows8"
        '
        'RadLabel_Labor
        '
        Me.RadLabel_Labor.AutoSize = False
        Me.RadLabel_Labor.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Labor.Location = New System.Drawing.Point(29, 79)
        Me.RadLabel_Labor.Name = "RadLabel_Labor"
        Me.RadLabel_Labor.Size = New System.Drawing.Size(73, 31)
        Me.RadLabel_Labor.TabIndex = 141
        Me.RadLabel_Labor.Text = "DesignSummary_Labor"
        Me.RadLabel_Labor.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Labor.TextWrap = False
        Me.RadLabel_Labor.ThemeName = "Windows8"
        '
        'RadLabel_Material
        '
        Me.RadLabel_Material.AutoSize = False
        Me.RadLabel_Material.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Material.Location = New System.Drawing.Point(29, 42)
        Me.RadLabel_Material.Name = "RadLabel_Material"
        Me.RadLabel_Material.Size = New System.Drawing.Size(73, 31)
        Me.RadLabel_Material.TabIndex = 140
        Me.RadLabel_Material.Text = "DesignSummary_Material"
        Me.RadLabel_Material.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Material.TextWrap = False
        Me.RadLabel_Material.ThemeName = "Windows8"
        '
        'RadLabel_Variable
        '
        Me.RadLabel_Variable.AutoSize = False
        Me.RadLabel_Variable.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Variable.Location = New System.Drawing.Point(205, 7)
        Me.RadLabel_Variable.Name = "RadLabel_Variable"
        Me.RadLabel_Variable.Size = New System.Drawing.Size(73, 31)
        Me.RadLabel_Variable.TabIndex = 140
        Me.RadLabel_Variable.Text = "DesignSummary_Variable"
        Me.RadLabel_Variable.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_Variable.TextWrap = False
        Me.RadLabel_Variable.ThemeName = "Windows8"
        '
        'RadLabel_Standard
        '
        Me.RadLabel_Standard.AutoSize = False
        Me.RadLabel_Standard.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Standard.Location = New System.Drawing.Point(108, 7)
        Me.RadLabel_Standard.Name = "RadLabel_Standard"
        Me.RadLabel_Standard.Size = New System.Drawing.Size(73, 31)
        Me.RadLabel_Standard.TabIndex = 139
        Me.RadLabel_Standard.Text = "DesignSummary_Standard"
        Me.RadLabel_Standard.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_Standard.TextWrap = False
        Me.RadLabel_Standard.ThemeName = "Windows8"
        '
        'RadLabel_NoLabData
        '
        Me.RadLabel_NoLabData.AutoSize = False
        Me.RadLabel_NoLabData.BackColor = System.Drawing.Color.Red
        Me.RadLabel_NoLabData.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_NoLabData.ForeColor = System.Drawing.Color.White
        Me.RadLabel_NoLabData.Location = New System.Drawing.Point(255, 55)
        Me.RadLabel_NoLabData.Name = "RadLabel_NoLabData"
        Me.RadLabel_NoLabData.Size = New System.Drawing.Size(66, 53)
        Me.RadLabel_NoLabData.TabIndex = 121
        Me.RadLabel_NoLabData.Text = "DesignSummary_NoLabData"
        Me.RadLabel_NoLabData.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_NoLabData.ThemeName = "Windows8"
        '
        'RadCheckBox_SEV
        '
        Me.RadCheckBox_SEV.AutoSize = False
        Me.RadCheckBox_SEV.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_SEV.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_SEV.Location = New System.Drawing.Point(126, 198)
        Me.RadCheckBox_SEV.Name = "RadCheckBox_SEV"
        Me.RadCheckBox_SEV.Size = New System.Drawing.Size(101, 29)
        Me.RadCheckBox_SEV.TabIndex = 108
        Me.RadCheckBox_SEV.Text = "DesignSummary_SEV"
        Me.RadCheckBox_SEV.ThemeName = "Windows8"
        '
        'Panel19
        '
        Me.Panel19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel19.Controls.Add(Me.RadLabel_CoverSampleCostButtons)
        Me.Panel19.Controls.Add(Me.RadButton_SampleCost)
        Me.Panel19.Controls.Add(Me.RadButton_ShowAllCriteria)
        Me.Panel19.Controls.Add(Me.RadButton_HideAllCriteria)
        Me.Panel19.Controls.Add(Me.RadButton_ShowAllRecords)
        Me.Panel19.Controls.Add(Me.RadButton_FilterRecords)
        Me.Panel19.Location = New System.Drawing.Point(-3, 646)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(432, 73)
        Me.Panel19.TabIndex = 98
        '
        'RadButton_SampleCost
        '
        Me.RadButton_SampleCost.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadButton_SampleCost.ForeColor = System.Drawing.Color.Black
        Me.RadButton_SampleCost.Location = New System.Drawing.Point(14, 6)
        Me.RadButton_SampleCost.Name = "RadButton_SampleCost"
        Me.RadButton_SampleCost.Size = New System.Drawing.Size(110, 55)
        Me.RadButton_SampleCost.TabIndex = 4
        Me.RadButton_SampleCost.Text = "DesignSummary_SampleCost"
        Me.RadButton_SampleCost.TextWrap = True
        Me.RadButton_SampleCost.ThemeName = "Windows8"
        '
        'RadButton_ShowAllCriteria
        '
        Me.RadButton_ShowAllCriteria.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.RadButton_ShowAllCriteria.ForeColor = System.Drawing.Color.Black
        Me.RadButton_ShowAllCriteria.Location = New System.Drawing.Point(272, 38)
        Me.RadButton_ShowAllCriteria.Name = "RadButton_ShowAllCriteria"
        Me.RadButton_ShowAllCriteria.Size = New System.Drawing.Size(127, 24)
        Me.RadButton_ShowAllCriteria.TabIndex = 3
        Me.RadButton_ShowAllCriteria.Text = "DesignSummary_ShowAllCriteria"
        Me.RadButton_ShowAllCriteria.ThemeName = "Windows8"
        '
        'RadButton_HideAllCriteria
        '
        Me.RadButton_HideAllCriteria.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.RadButton_HideAllCriteria.ForeColor = System.Drawing.Color.Black
        Me.RadButton_HideAllCriteria.Location = New System.Drawing.Point(140, 37)
        Me.RadButton_HideAllCriteria.Name = "RadButton_HideAllCriteria"
        Me.RadButton_HideAllCriteria.Size = New System.Drawing.Size(126, 24)
        Me.RadButton_HideAllCriteria.TabIndex = 2
        Me.RadButton_HideAllCriteria.Text = "DesignSummary_HideAllCriteria"
        Me.RadButton_HideAllCriteria.ThemeName = "Windows8"
        '
        'RadButton_ShowAllRecords
        '
        Me.RadButton_ShowAllRecords.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.RadButton_ShowAllRecords.ForeColor = System.Drawing.Color.Black
        Me.RadButton_ShowAllRecords.Location = New System.Drawing.Point(272, 6)
        Me.RadButton_ShowAllRecords.Name = "RadButton_ShowAllRecords"
        Me.RadButton_ShowAllRecords.Size = New System.Drawing.Size(127, 24)
        Me.RadButton_ShowAllRecords.TabIndex = 1
        Me.RadButton_ShowAllRecords.Text = "DesignSummary_ShowAllRecords"
        Me.RadButton_ShowAllRecords.ThemeName = "Windows8"
        '
        'RadButton_FilterRecords
        '
        Me.RadButton_FilterRecords.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.RadButton_FilterRecords.ForeColor = System.Drawing.Color.Black
        Me.RadButton_FilterRecords.Location = New System.Drawing.Point(140, 6)
        Me.RadButton_FilterRecords.Name = "RadButton_FilterRecords"
        Me.RadButton_FilterRecords.Size = New System.Drawing.Size(126, 24)
        Me.RadButton_FilterRecords.TabIndex = 0
        Me.RadButton_FilterRecords.Text = "DesignSummary_FilterRecords"
        Me.RadButton_FilterRecords.ThemeName = "Windows8"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.RadTextBox_KemetPartNumber)
        Me.Panel1.Controls.Add(Me.RadTextBox_Issue)
        Me.Panel1.Controls.Add(Me.RadTextBox_Date)
        Me.Panel1.Controls.Add(Me.RadTextBox_TestVoltage)
        Me.Panel1.Controls.Add(Me.RadTextBox_ASNo)
        Me.Panel1.Controls.Add(Me.RadTextBox_LenTolerance)
        Me.Panel1.Controls.Add(Me.RadTextBox_Len)
        Me.Panel1.Controls.Add(Me.RadTextBox_SurgeVoltage)
        Me.Panel1.Controls.Add(Me.RadTextBox_Temp)
        Me.Panel1.Controls.Add(Me.RadTextBox_DiaTolerance)
        Me.Panel1.Controls.Add(Me.RadTextBox_Dia)
        Me.Panel1.Controls.Add(Me.RadTextBox_WorkVoltage)
        Me.Panel1.Controls.Add(Me.RadTextBox_HighTolCapacitance)
        Me.Panel1.Controls.Add(Me.RadTextBox_LowTolCapacitance)
        Me.Panel1.Controls.Add(Me.RadTextBox_LowTemp)
        Me.Panel1.Controls.Add(Me.RadTextBox_Capacitance)
        Me.Panel1.Controls.Add(Me.RadTextBox10)
        Me.Panel1.Controls.Add(Me.RadLabel_Issue)
        Me.Panel1.Controls.Add(Me.RadLabel_Date)
        Me.Panel1.Controls.Add(Me.RadDropDownList_PSIPartStyle)
        Me.Panel1.Controls.Add(Me.RadLabel_TestVoltageUnit)
        Me.Panel1.Controls.Add(Me.RadCheckBox_DesignChecked)
        Me.Panel1.Controls.Add(Me.RadLabel_TestVoltage)
        Me.Panel1.Controls.Add(Me.RadLabel_ASNo)
        Me.Panel1.Controls.Add(Me.RadLabel_Len)
        Me.Panel1.Controls.Add(Me.RadLabel_SurgeVoltageUnit)
        Me.Panel1.Controls.Add(Me.RadLabel_SurgeVoltage)
        Me.Panel1.Controls.Add(Me.RadCheckBox_ac)
        Me.Panel1.Controls.Add(Me.RadLabel_TempUnit)
        Me.Panel1.Controls.Add(Me.RadLabel_Dia)
        Me.Panel1.Controls.Add(Me.RadLabel_WorkVoltageUnit)
        Me.Panel1.Controls.Add(Me.RadLabel_WorkVoltage)
        Me.Panel1.Controls.Add(Me.RadLabel_PSIPartStyle)
        Me.Panel1.Controls.Add(Me.RadDropDownList_Range)
        Me.Panel1.Controls.Add(Me.RadLabel_Range)
        Me.Panel1.Controls.Add(Me.RadDropDownList_PartNumber)
        Me.Panel1.Controls.Add(Me.RadLabel_Minus)
        Me.Panel1.Controls.Add(Me.RadLabel_CapacitanceUnit)
        Me.Panel1.Controls.Add(Me.RadLabel_Plus)
        Me.Panel1.Controls.Add(Me.RadLabel_PercentageLowTolCapacitance)
        Me.Panel1.Controls.Add(Me.RadLabel_PercentageHighTolCapacitance)
        Me.Panel1.Controls.Add(Me.RadLabel_LowTempUnit)
        Me.Panel1.Location = New System.Drawing.Point(11, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1062, 110)
        Me.Panel1.TabIndex = 0
        '
        'RadTextBox_KemetPartNumber
        '
        Me.RadTextBox_KemetPartNumber.AutoSize = False
        Me.RadTextBox_KemetPartNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.RadTextBox_KemetPartNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_KemetPartNumber.Location = New System.Drawing.Point(4, 41)
        Me.RadTextBox_KemetPartNumber.Name = "RadTextBox_KemetPartNumber"
        Me.RadTextBox_KemetPartNumber.Size = New System.Drawing.Size(203, 27)
        Me.RadTextBox_KemetPartNumber.TabIndex = 141
        Me.RadTextBox_KemetPartNumber.Text = "A335LC103Q063H"
        Me.RadTextBox_KemetPartNumber.ThemeName = "Windows8"
        '
        'RadTextBox_Issue
        '
        Me.RadTextBox_Issue.AutoSize = False
        Me.RadTextBox_Issue.BackColor = System.Drawing.Color.Silver
        Me.RadTextBox_Issue.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_Issue.Location = New System.Drawing.Point(1008, 76)
        Me.RadTextBox_Issue.Name = "RadTextBox_Issue"
        Me.RadTextBox_Issue.Size = New System.Drawing.Size(41, 29)
        Me.RadTextBox_Issue.TabIndex = 129
        Me.RadTextBox_Issue.ThemeName = "Windows8"
        '
        'RadTextBox_Date
        '
        Me.RadTextBox_Date.AutoSize = False
        Me.RadTextBox_Date.BackColor = System.Drawing.Color.Silver
        Me.RadTextBox_Date.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_Date.Location = New System.Drawing.Point(855, 76)
        Me.RadTextBox_Date.Name = "RadTextBox_Date"
        Me.RadTextBox_Date.Size = New System.Drawing.Size(94, 29)
        Me.RadTextBox_Date.TabIndex = 128
        Me.RadTextBox_Date.ThemeName = "Windows8"
        '
        'RadTextBox_TestVoltage
        '
        Me.RadTextBox_TestVoltage.AutoSize = False
        Me.RadTextBox_TestVoltage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_TestVoltage.Location = New System.Drawing.Point(728, 76)
        Me.RadTextBox_TestVoltage.Name = "RadTextBox_TestVoltage"
        Me.RadTextBox_TestVoltage.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_TestVoltage.TabIndex = 127
        Me.RadTextBox_TestVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TestVoltage.ThemeName = "Windows8"
        '
        'RadTextBox_ASNo
        '
        Me.RadTextBox_ASNo.AutoSize = False
        Me.RadTextBox_ASNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_ASNo.Location = New System.Drawing.Point(420, 76)
        Me.RadTextBox_ASNo.Name = "RadTextBox_ASNo"
        Me.RadTextBox_ASNo.Size = New System.Drawing.Size(109, 29)
        Me.RadTextBox_ASNo.TabIndex = 126
        Me.RadTextBox_ASNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_ASNo.ThemeName = "Windows8"
        '
        'RadTextBox_LenTolerance
        '
        Me.RadTextBox_LenTolerance.AutoSize = False
        Me.RadTextBox_LenTolerance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_LenTolerance.Location = New System.Drawing.Point(916, 41)
        Me.RadTextBox_LenTolerance.Name = "RadTextBox_LenTolerance"
        Me.RadTextBox_LenTolerance.Size = New System.Drawing.Size(101, 29)
        Me.RadTextBox_LenTolerance.TabIndex = 125
        Me.RadTextBox_LenTolerance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_LenTolerance.ThemeName = "Windows8"
        '
        'RadTextBox_Len
        '
        Me.RadTextBox_Len.AutoSize = False
        Me.RadTextBox_Len.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Len.Location = New System.Drawing.Point(855, 41)
        Me.RadTextBox_Len.Name = "RadTextBox_Len"
        Me.RadTextBox_Len.Size = New System.Drawing.Size(55, 29)
        Me.RadTextBox_Len.TabIndex = 124
        Me.RadTextBox_Len.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Len.ThemeName = "Windows8"
        '
        'RadTextBox_SurgeVoltage
        '
        Me.RadTextBox_SurgeVoltage.AutoSize = False
        Me.RadTextBox_SurgeVoltage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_SurgeVoltage.Location = New System.Drawing.Point(728, 41)
        Me.RadTextBox_SurgeVoltage.Name = "RadTextBox_SurgeVoltage"
        Me.RadTextBox_SurgeVoltage.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_SurgeVoltage.TabIndex = 123
        Me.RadTextBox_SurgeVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_SurgeVoltage.ThemeName = "Windows8"
        '
        'RadTextBox_Temp
        '
        Me.RadTextBox_Temp.AutoSize = False
        Me.RadTextBox_Temp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Temp.Location = New System.Drawing.Point(397, 41)
        Me.RadTextBox_Temp.Name = "RadTextBox_Temp"
        Me.RadTextBox_Temp.Size = New System.Drawing.Size(59, 29)
        Me.RadTextBox_Temp.TabIndex = 122
        Me.RadTextBox_Temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Temp.ThemeName = "Windows8"
        '
        'RadTextBox_DiaTolerance
        '
        Me.RadTextBox_DiaTolerance.AutoSize = False
        Me.RadTextBox_DiaTolerance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_DiaTolerance.Location = New System.Drawing.Point(916, 5)
        Me.RadTextBox_DiaTolerance.Name = "RadTextBox_DiaTolerance"
        Me.RadTextBox_DiaTolerance.Size = New System.Drawing.Size(101, 29)
        Me.RadTextBox_DiaTolerance.TabIndex = 121
        Me.RadTextBox_DiaTolerance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_DiaTolerance.ThemeName = "Windows8"
        '
        'RadTextBox_Dia
        '
        Me.RadTextBox_Dia.AutoSize = False
        Me.RadTextBox_Dia.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Dia.Location = New System.Drawing.Point(855, 5)
        Me.RadTextBox_Dia.Name = "RadTextBox_Dia"
        Me.RadTextBox_Dia.Size = New System.Drawing.Size(55, 29)
        Me.RadTextBox_Dia.TabIndex = 120
        Me.RadTextBox_Dia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Dia.ThemeName = "Windows8"
        '
        'RadTextBox_WorkVoltage
        '
        Me.RadTextBox_WorkVoltage.AutoSize = False
        Me.RadTextBox_WorkVoltage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_WorkVoltage.Location = New System.Drawing.Point(728, 5)
        Me.RadTextBox_WorkVoltage.Name = "RadTextBox_WorkVoltage"
        Me.RadTextBox_WorkVoltage.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_WorkVoltage.TabIndex = 119
        Me.RadTextBox_WorkVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_WorkVoltage.ThemeName = "Windows8"
        '
        'RadTextBox_HighTolCapacitance
        '
        Me.RadTextBox_HighTolCapacitance.AutoSize = False
        Me.RadTextBox_HighTolCapacitance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_HighTolCapacitance.Location = New System.Drawing.Point(522, 5)
        Me.RadTextBox_HighTolCapacitance.Name = "RadTextBox_HighTolCapacitance"
        Me.RadTextBox_HighTolCapacitance.Size = New System.Drawing.Size(41, 29)
        Me.RadTextBox_HighTolCapacitance.TabIndex = 118
        Me.RadTextBox_HighTolCapacitance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_HighTolCapacitance.ThemeName = "Windows8"
        '
        'RadTextBox_LowTolCapacitance
        '
        Me.RadTextBox_LowTolCapacitance.AutoSize = False
        Me.RadTextBox_LowTolCapacitance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_LowTolCapacitance.Location = New System.Drawing.Point(437, 5)
        Me.RadTextBox_LowTolCapacitance.Name = "RadTextBox_LowTolCapacitance"
        Me.RadTextBox_LowTolCapacitance.Size = New System.Drawing.Size(41, 29)
        Me.RadTextBox_LowTolCapacitance.TabIndex = 117
        Me.RadTextBox_LowTolCapacitance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_LowTolCapacitance.ThemeName = "Windows8"
        '
        'RadTextBox_LowTemp
        '
        Me.RadTextBox_LowTemp.AutoSize = False
        Me.RadTextBox_LowTemp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_LowTemp.Location = New System.Drawing.Point(289, 41)
        Me.RadTextBox_LowTemp.Name = "RadTextBox_LowTemp"
        Me.RadTextBox_LowTemp.Size = New System.Drawing.Size(59, 29)
        Me.RadTextBox_LowTemp.TabIndex = 116
        Me.RadTextBox_LowTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_LowTemp.ThemeName = "Windows8"
        '
        'RadTextBox_Capacitance
        '
        Me.RadTextBox_Capacitance.AutoSize = False
        Me.RadTextBox_Capacitance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Capacitance.Location = New System.Drawing.Point(289, 5)
        Me.RadTextBox_Capacitance.Name = "RadTextBox_Capacitance"
        Me.RadTextBox_Capacitance.Size = New System.Drawing.Size(95, 29)
        Me.RadTextBox_Capacitance.TabIndex = 115
        Me.RadTextBox_Capacitance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Capacitance.ThemeName = "Windows8"
        '
        'RadTextBox10
        '
        Me.RadTextBox10.AutoSize = False
        Me.RadTextBox10.BackColor = System.Drawing.Color.Silver
        Me.RadTextBox10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox10.Location = New System.Drawing.Point(213, 41)
        Me.RadTextBox10.Name = "RadTextBox10"
        Me.RadTextBox10.Size = New System.Drawing.Size(61, 27)
        Me.RadTextBox10.TabIndex = 19
        Me.RadTextBox10.ThemeName = "Windows8"
        '
        'RadLabel_Issue
        '
        Me.RadLabel_Issue.AutoSize = False
        Me.RadLabel_Issue.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Issue.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_Issue.Location = New System.Drawing.Point(955, 76)
        Me.RadLabel_Issue.Name = "RadLabel_Issue"
        Me.RadLabel_Issue.Size = New System.Drawing.Size(51, 29)
        Me.RadLabel_Issue.TabIndex = 114
        Me.RadLabel_Issue.Text = "DesignSummary_Issue"
        Me.RadLabel_Issue.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Issue.TextWrap = False
        Me.RadLabel_Issue.ThemeName = "Windows8"
        '
        'RadLabel_Date
        '
        Me.RadLabel_Date.AutoSize = False
        Me.RadLabel_Date.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Date.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_Date.Location = New System.Drawing.Point(802, 76)
        Me.RadLabel_Date.Name = "RadLabel_Date"
        Me.RadLabel_Date.Size = New System.Drawing.Size(51, 31)
        Me.RadLabel_Date.TabIndex = 113
        Me.RadLabel_Date.Text = "DesignSummary_Date"
        Me.RadLabel_Date.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Date.TextWrap = False
        Me.RadLabel_Date.ThemeName = "Windows8"
        '
        'RadDropDownList_PSIPartStyle
        '
        Me.RadDropDownList_PSIPartStyle.AutoSize = False
        Me.RadDropDownList_PSIPartStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadDropDownList_PSIPartStyle.Location = New System.Drawing.Point(289, 76)
        Me.RadDropDownList_PSIPartStyle.Name = "RadDropDownList_PSIPartStyle"
        Me.RadDropDownList_PSIPartStyle.Size = New System.Drawing.Size(59, 27)
        Me.RadDropDownList_PSIPartStyle.TabIndex = 5
        Me.RadDropDownList_PSIPartStyle.Text = "DC"
        Me.RadDropDownList_PSIPartStyle.ThemeName = "Windows8"
        '
        'RadLabel_TestVoltageUnit
        '
        Me.RadLabel_TestVoltageUnit.AutoSize = False
        Me.RadLabel_TestVoltageUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_TestVoltageUnit.Location = New System.Drawing.Point(778, 76)
        Me.RadLabel_TestVoltageUnit.Name = "RadLabel_TestVoltageUnit"
        Me.RadLabel_TestVoltageUnit.Size = New System.Drawing.Size(24, 29)
        Me.RadLabel_TestVoltageUnit.TabIndex = 112
        Me.RadLabel_TestVoltageUnit.Text = "Global_V"
        Me.RadLabel_TestVoltageUnit.ThemeName = "Windows8"
        '
        'RadCheckBox_DesignChecked
        '
        Me.RadCheckBox_DesignChecked.AutoSize = False
        Me.RadCheckBox_DesignChecked.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_DesignChecked.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadCheckBox_DesignChecked.Location = New System.Drawing.Point(539, 76)
        Me.RadCheckBox_DesignChecked.Name = "RadCheckBox_DesignChecked"
        Me.RadCheckBox_DesignChecked.Size = New System.Drawing.Size(79, 30)
        Me.RadCheckBox_DesignChecked.TabIndex = 25
        Me.RadCheckBox_DesignChecked.Text = "DesignSummary_DesignChecked"
        Me.RadCheckBox_DesignChecked.TextWrap = True
        Me.RadCheckBox_DesignChecked.ThemeName = "Windows8"
        '
        'RadLabel_TestVoltage
        '
        Me.RadLabel_TestVoltage.AutoSize = False
        Me.RadLabel_TestVoltage.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_TestVoltage.Location = New System.Drawing.Point(597, 76)
        Me.RadLabel_TestVoltage.Name = "RadLabel_TestVoltage"
        Me.RadLabel_TestVoltage.Size = New System.Drawing.Size(133, 27)
        Me.RadLabel_TestVoltage.TabIndex = 111
        Me.RadLabel_TestVoltage.Text = "DesignSummary_TestVoltage"
        Me.RadLabel_TestVoltage.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_TestVoltage.TextWrap = False
        Me.RadLabel_TestVoltage.ThemeName = "Windows8"
        '
        'RadLabel_ASNo
        '
        Me.RadLabel_ASNo.AutoSize = False
        Me.RadLabel_ASNo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_ASNo.Location = New System.Drawing.Point(348, 76)
        Me.RadLabel_ASNo.Name = "RadLabel_ASNo"
        Me.RadLabel_ASNo.Size = New System.Drawing.Size(66, 27)
        Me.RadLabel_ASNo.TabIndex = 18
        Me.RadLabel_ASNo.Text = "DesignSummary_ASNo"
        Me.RadLabel_ASNo.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_ASNo.TextWrap = False
        Me.RadLabel_ASNo.ThemeName = "Windows8"
        '
        'RadLabel_Len
        '
        Me.RadLabel_Len.AutoSize = False
        Me.RadLabel_Len.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Len.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_Len.Location = New System.Drawing.Point(802, 41)
        Me.RadLabel_Len.Name = "RadLabel_Len"
        Me.RadLabel_Len.Size = New System.Drawing.Size(51, 31)
        Me.RadLabel_Len.TabIndex = 110
        Me.RadLabel_Len.Text = "DesignSummary_Len"
        Me.RadLabel_Len.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Len.TextWrap = False
        Me.RadLabel_Len.ThemeName = "Windows8"
        '
        'RadLabel_SurgeVoltageUnit
        '
        Me.RadLabel_SurgeVoltageUnit.AutoSize = False
        Me.RadLabel_SurgeVoltageUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_SurgeVoltageUnit.Location = New System.Drawing.Point(778, 41)
        Me.RadLabel_SurgeVoltageUnit.Name = "RadLabel_SurgeVoltageUnit"
        Me.RadLabel_SurgeVoltageUnit.Size = New System.Drawing.Size(24, 29)
        Me.RadLabel_SurgeVoltageUnit.TabIndex = 109
        Me.RadLabel_SurgeVoltageUnit.Text = "Global_V"
        Me.RadLabel_SurgeVoltageUnit.ThemeName = "Windows8"
        '
        'RadLabel_SurgeVoltage
        '
        Me.RadLabel_SurgeVoltage.AutoSize = False
        Me.RadLabel_SurgeVoltage.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_SurgeVoltage.Location = New System.Drawing.Point(597, 41)
        Me.RadLabel_SurgeVoltage.Name = "RadLabel_SurgeVoltage"
        Me.RadLabel_SurgeVoltage.Size = New System.Drawing.Size(133, 27)
        Me.RadLabel_SurgeVoltage.TabIndex = 108
        Me.RadLabel_SurgeVoltage.Text = "DesignSummary_SurgeVoltage"
        Me.RadLabel_SurgeVoltage.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_SurgeVoltage.TextWrap = False
        Me.RadLabel_SurgeVoltage.ThemeName = "Windows8"
        '
        'RadCheckBox_ac
        '
        Me.RadCheckBox_ac.AutoSize = False
        Me.RadCheckBox_ac.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_ac.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_ac.Location = New System.Drawing.Point(511, 41)
        Me.RadCheckBox_ac.Name = "RadCheckBox_ac"
        Me.RadCheckBox_ac.Size = New System.Drawing.Size(62, 29)
        Me.RadCheckBox_ac.TabIndex = 20
        Me.RadCheckBox_ac.Text = "DesignSummary_ac"
        Me.RadCheckBox_ac.ThemeName = "Windows8"
        '
        'RadLabel_TempUnit
        '
        Me.RadLabel_TempUnit.AutoSize = False
        Me.RadLabel_TempUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_TempUnit.Location = New System.Drawing.Point(454, 41)
        Me.RadLabel_TempUnit.Name = "RadLabel_TempUnit"
        Me.RadLabel_TempUnit.Size = New System.Drawing.Size(75, 27)
        Me.RadLabel_TempUnit.TabIndex = 107
        Me.RadLabel_TempUnit.Text = "Global_CelsiusDegrees"
        Me.RadLabel_TempUnit.ThemeName = "Windows8"
        '
        'RadLabel_Dia
        '
        Me.RadLabel_Dia.AutoSize = False
        Me.RadLabel_Dia.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Dia.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_Dia.Location = New System.Drawing.Point(802, 5)
        Me.RadLabel_Dia.Name = "RadLabel_Dia"
        Me.RadLabel_Dia.Size = New System.Drawing.Size(51, 31)
        Me.RadLabel_Dia.TabIndex = 106
        Me.RadLabel_Dia.Text = "DesignSummary_Dia"
        Me.RadLabel_Dia.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Dia.TextWrap = False
        Me.RadLabel_Dia.ThemeName = "Windows8"
        '
        'RadLabel_WorkVoltageUnit
        '
        Me.RadLabel_WorkVoltageUnit.AutoSize = False
        Me.RadLabel_WorkVoltageUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_WorkVoltageUnit.Location = New System.Drawing.Point(778, 5)
        Me.RadLabel_WorkVoltageUnit.Name = "RadLabel_WorkVoltageUnit"
        Me.RadLabel_WorkVoltageUnit.Size = New System.Drawing.Size(24, 29)
        Me.RadLabel_WorkVoltageUnit.TabIndex = 105
        Me.RadLabel_WorkVoltageUnit.Text = "Global_V"
        Me.RadLabel_WorkVoltageUnit.ThemeName = "Windows8"
        '
        'RadLabel_WorkVoltage
        '
        Me.RadLabel_WorkVoltage.AutoSize = False
        Me.RadLabel_WorkVoltage.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_WorkVoltage.Location = New System.Drawing.Point(593, 5)
        Me.RadLabel_WorkVoltage.Name = "RadLabel_WorkVoltage"
        Me.RadLabel_WorkVoltage.Size = New System.Drawing.Size(133, 27)
        Me.RadLabel_WorkVoltage.TabIndex = 101
        Me.RadLabel_WorkVoltage.Text = "DesignSummary_WorkingVoltage"
        Me.RadLabel_WorkVoltage.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_WorkVoltage.TextWrap = False
        Me.RadLabel_WorkVoltage.ThemeName = "Windows8"
        '
        'RadLabel_PSIPartStyle
        '
        Me.RadLabel_PSIPartStyle.AutoSize = False
        Me.RadLabel_PSIPartStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_PSIPartStyle.Location = New System.Drawing.Point(202, 76)
        Me.RadLabel_PSIPartStyle.Name = "RadLabel_PSIPartStyle"
        Me.RadLabel_PSIPartStyle.Size = New System.Drawing.Size(81, 27)
        Me.RadLabel_PSIPartStyle.TabIndex = 17
        Me.RadLabel_PSIPartStyle.Text = "DesignSummary_Style"
        Me.RadLabel_PSIPartStyle.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_PSIPartStyle.TextWrap = False
        Me.RadLabel_PSIPartStyle.ThemeName = "Windows8"
        '
        'RadDropDownList_Range
        '
        Me.RadDropDownList_Range.AutoSize = False
        Me.RadDropDownList_Range.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Range.Location = New System.Drawing.Point(70, 76)
        Me.RadDropDownList_Range.Name = "RadDropDownList_Range"
        Me.RadDropDownList_Range.Size = New System.Drawing.Size(125, 27)
        Me.RadDropDownList_Range.TabIndex = 4
        Me.RadDropDownList_Range.Text = "ALS36H"
        Me.RadDropDownList_Range.ThemeName = "Windows8"
        '
        'RadLabel_Range
        '
        Me.RadLabel_Range.AutoSize = False
        Me.RadLabel_Range.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.RadLabel_Range.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Range.Location = New System.Drawing.Point(-3, 76)
        Me.RadLabel_Range.Name = "RadLabel_Range"
        Me.RadLabel_Range.Size = New System.Drawing.Size(73, 27)
        Me.RadLabel_Range.TabIndex = 99
        Me.RadLabel_Range.Text = "DesignSummary_Range"
        Me.RadLabel_Range.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Range.TextWrap = False
        Me.RadLabel_Range.ThemeName = "Windows8"
        '
        'RadDropDownList_PartNumber
        '
        Me.RadDropDownList_PartNumber.AutoSize = False
        Me.RadDropDownList_PartNumber.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_PartNumber.ForeColor = System.Drawing.Color.Blue
        Me.RadDropDownList_PartNumber.Location = New System.Drawing.Point(4, 5)
        Me.RadDropDownList_PartNumber.Name = "RadDropDownList_PartNumber"
        Me.RadDropDownList_PartNumber.Size = New System.Drawing.Size(270, 31)
        Me.RadDropDownList_PartNumber.TabIndex = 0
        Me.RadDropDownList_PartNumber.Text = "ALS36H103K2C063"
        Me.RadDropDownList_PartNumber.ThemeName = "Windows8"
        '
        'RadLabel_Minus
        '
        Me.RadLabel_Minus.AutoSize = False
        Me.RadLabel_Minus.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Minus.Location = New System.Drawing.Point(422, 4)
        Me.RadLabel_Minus.Name = "RadLabel_Minus"
        Me.RadLabel_Minus.Size = New System.Drawing.Size(56, 30)
        Me.RadLabel_Minus.TabIndex = 101
        Me.RadLabel_Minus.Text = "Global_Negative"
        Me.RadLabel_Minus.ThemeName = "Windows8"
        '
        'RadLabel_CapacitanceUnit
        '
        Me.RadLabel_CapacitanceUnit.AutoSize = False
        Me.RadLabel_CapacitanceUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_CapacitanceUnit.Location = New System.Drawing.Point(381, 5)
        Me.RadLabel_CapacitanceUnit.Name = "RadLabel_CapacitanceUnit"
        Me.RadLabel_CapacitanceUnit.Size = New System.Drawing.Size(75, 27)
        Me.RadLabel_CapacitanceUnit.TabIndex = 100
        Me.RadLabel_CapacitanceUnit.Text = "Unis_MicroFarad"
        Me.RadLabel_CapacitanceUnit.ThemeName = "Windows8"
        '
        'RadLabel_Plus
        '
        Me.RadLabel_Plus.AutoSize = False
        Me.RadLabel_Plus.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Plus.Location = New System.Drawing.Point(505, 5)
        Me.RadLabel_Plus.Name = "RadLabel_Plus"
        Me.RadLabel_Plus.Size = New System.Drawing.Size(56, 30)
        Me.RadLabel_Plus.TabIndex = 103
        Me.RadLabel_Plus.Text = "Global_Positive"
        Me.RadLabel_Plus.ThemeName = "Windows8"
        '
        'RadLabel_PercentageLowTolCapacitance
        '
        Me.RadLabel_PercentageLowTolCapacitance.AutoSize = False
        Me.RadLabel_PercentageLowTolCapacitance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_PercentageLowTolCapacitance.Location = New System.Drawing.Point(477, 5)
        Me.RadLabel_PercentageLowTolCapacitance.Name = "RadLabel_PercentageLowTolCapacitance"
        Me.RadLabel_PercentageLowTolCapacitance.Size = New System.Drawing.Size(75, 27)
        Me.RadLabel_PercentageLowTolCapacitance.TabIndex = 102
        Me.RadLabel_PercentageLowTolCapacitance.Text = "Global_Percentage"
        Me.RadLabel_PercentageLowTolCapacitance.ThemeName = "Windows8"
        '
        'RadLabel_PercentageHighTolCapacitance
        '
        Me.RadLabel_PercentageHighTolCapacitance.AutoSize = False
        Me.RadLabel_PercentageHighTolCapacitance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_PercentageHighTolCapacitance.Location = New System.Drawing.Point(562, 5)
        Me.RadLabel_PercentageHighTolCapacitance.Name = "RadLabel_PercentageHighTolCapacitance"
        Me.RadLabel_PercentageHighTolCapacitance.Size = New System.Drawing.Size(75, 27)
        Me.RadLabel_PercentageHighTolCapacitance.TabIndex = 104
        Me.RadLabel_PercentageHighTolCapacitance.Text = "Global_Percentage"
        Me.RadLabel_PercentageHighTolCapacitance.ThemeName = "Windows8"
        '
        'RadLabel_LowTempUnit
        '
        Me.RadLabel_LowTempUnit.AutoSize = False
        Me.RadLabel_LowTempUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_LowTempUnit.Location = New System.Drawing.Point(345, 41)
        Me.RadLabel_LowTempUnit.Name = "RadLabel_LowTempUnit"
        Me.RadLabel_LowTempUnit.Size = New System.Drawing.Size(75, 27)
        Me.RadLabel_LowTempUnit.TabIndex = 101
        Me.RadLabel_LowTempUnit.Text = "Global_CelsiusDegrees"
        Me.RadLabel_LowTempUnit.ThemeName = "Windows8"
        '
        'RadLabel1
        '
        Me.RadLabel1.AutoSize = False
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel1.Location = New System.Drawing.Point(11, 10)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(268, 53)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "DesignSummary_Title"
        Me.RadLabel1.ThemeName = "Windows8"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.RadButton_SetOutline)
        Me.Panel3.Controls.Add(Me.RadButton_SetObs)
        Me.Panel3.Controls.Add(Me.RadButton_SetHold)
        Me.Panel3.Controls.Add(Me.RadButton_SetLive)
        Me.Panel3.Location = New System.Drawing.Point(1080, 63)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(75, 123)
        Me.Panel3.TabIndex = 1
        '
        'RadButton_SetOutline
        '
        Me.RadButton_SetOutline.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadButton_SetOutline.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.RadButton_SetOutline.ForeColor = System.Drawing.Color.Black
        Me.RadButton_SetOutline.Location = New System.Drawing.Point(3, 92)
        Me.RadButton_SetOutline.Name = "RadButton_SetOutline"
        Me.RadButton_SetOutline.Size = New System.Drawing.Size(65, 24)
        Me.RadButton_SetOutline.TabIndex = 3
        Me.RadButton_SetOutline.Text = "DesignSummary_Outline"
        Me.RadButton_SetOutline.ThemeName = "Windows8"
        '
        'RadButton_SetObs
        '
        Me.RadButton_SetObs.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadButton_SetObs.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.RadButton_SetObs.ForeColor = System.Drawing.Color.Black
        Me.RadButton_SetObs.Location = New System.Drawing.Point(3, 62)
        Me.RadButton_SetObs.Name = "RadButton_SetObs"
        Me.RadButton_SetObs.Size = New System.Drawing.Size(65, 24)
        Me.RadButton_SetObs.TabIndex = 3
        Me.RadButton_SetObs.Text = "DesignSummary_Obs"
        Me.RadButton_SetObs.ThemeName = "Windows8"
        '
        'RadButton_SetHold
        '
        Me.RadButton_SetHold.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadButton_SetHold.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.RadButton_SetHold.ForeColor = System.Drawing.Color.Black
        Me.RadButton_SetHold.Location = New System.Drawing.Point(3, 32)
        Me.RadButton_SetHold.Name = "RadButton_SetHold"
        Me.RadButton_SetHold.Size = New System.Drawing.Size(65, 24)
        Me.RadButton_SetHold.TabIndex = 3
        Me.RadButton_SetHold.Text = "DesignSummary_Hold"
        Me.RadButton_SetHold.ThemeName = "Windows8"
        '
        'RadButton_SetLive
        '
        Me.RadButton_SetLive.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadButton_SetLive.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.RadButton_SetLive.ForeColor = System.Drawing.Color.Black
        Me.RadButton_SetLive.Location = New System.Drawing.Point(3, 2)
        Me.RadButton_SetLive.Name = "RadButton_SetLive"
        Me.RadButton_SetLive.Size = New System.Drawing.Size(65, 24)
        Me.RadButton_SetLive.TabIndex = 2
        Me.RadButton_SetLive.Text = "DesignSummary_Live"
        Me.RadButton_SetLive.ThemeName = "Windows8"
        '
        'PictureBox_KemetLogo
        '
        Me.PictureBox_KemetLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox_KemetLogo.Image = Global.ECAD.My.Resources.Resources.kemet_logo_small
        Me.PictureBox_KemetLogo.Location = New System.Drawing.Point(1194, 3)
        Me.PictureBox_KemetLogo.MaximumSize = New System.Drawing.Size(142, 61)
        Me.PictureBox_KemetLogo.Name = "PictureBox_KemetLogo"
        Me.PictureBox_KemetLogo.Size = New System.Drawing.Size(116, 54)
        Me.PictureBox_KemetLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_KemetLogo.TabIndex = 10
        Me.PictureBox_KemetLogo.TabStop = False
        '
        'RadButton_Delete
        '
        Me.RadButton_Delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadButton_Delete.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Delete.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Delete.Location = New System.Drawing.Point(285, 10)
        Me.RadButton_Delete.Name = "RadButton_Delete"
        Me.RadButton_Delete.Size = New System.Drawing.Size(89, 53)
        Me.RadButton_Delete.TabIndex = 11
        Me.RadButton_Delete.Text = "DesignSummary_Delete"
        Me.RadButton_Delete.TextWrap = True
        Me.RadButton_Delete.ThemeName = "Windows8"
        '
        'RadButton_Transfer
        '
        Me.RadButton_Transfer.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadButton_Transfer.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Transfer.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Transfer.Location = New System.Drawing.Point(497, 10)
        Me.RadButton_Transfer.Name = "RadButton_Transfer"
        Me.RadButton_Transfer.Size = New System.Drawing.Size(89, 53)
        Me.RadButton_Transfer.TabIndex = 13
        Me.RadButton_Transfer.Text = "DesignSummary_Transfer"
        Me.RadButton_Transfer.TextWrap = True
        Me.RadButton_Transfer.ThemeName = "Windows8"
        '
        'RadButton_GoToScratchPad
        '
        Me.RadButton_GoToScratchPad.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadButton_GoToScratchPad.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_GoToScratchPad.ForeColor = System.Drawing.Color.Black
        Me.RadButton_GoToScratchPad.Location = New System.Drawing.Point(380, 10)
        Me.RadButton_GoToScratchPad.Name = "RadButton_GoToScratchPad"
        Me.RadButton_GoToScratchPad.Size = New System.Drawing.Size(111, 53)
        Me.RadButton_GoToScratchPad.TabIndex = 12
        Me.RadButton_GoToScratchPad.Text = "DesignSummary_GoToScratchPad"
        Me.RadButton_GoToScratchPad.TextWrap = True
        Me.RadButton_GoToScratchPad.ThemeName = "Windows8"
        '
        'RadButton_AddToList
        '
        Me.RadButton_AddToList.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadButton_AddToList.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_AddToList.ForeColor = System.Drawing.Color.Black
        Me.RadButton_AddToList.Location = New System.Drawing.Point(592, 10)
        Me.RadButton_AddToList.Name = "RadButton_AddToList"
        Me.RadButton_AddToList.Size = New System.Drawing.Size(105, 53)
        Me.RadButton_AddToList.TabIndex = 14
        Me.RadButton_AddToList.Text = "DesignSummary_AddToList"
        Me.RadButton_AddToList.TextWrap = True
        Me.RadButton_AddToList.ThemeName = "Windows8"
        '
        'RadButton_StockOrders
        '
        Me.RadButton_StockOrders.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadButton_StockOrders.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_StockOrders.ForeColor = System.Drawing.Color.Black
        Me.RadButton_StockOrders.Location = New System.Drawing.Point(703, 10)
        Me.RadButton_StockOrders.Name = "RadButton_StockOrders"
        Me.RadButton_StockOrders.Size = New System.Drawing.Size(136, 53)
        Me.RadButton_StockOrders.TabIndex = 15
        Me.RadButton_StockOrders.Text = "DesignSummary_StockOrders"
        Me.RadButton_StockOrders.TextWrap = True
        Me.RadButton_StockOrders.ThemeName = "Windows8"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.RadTextBox_DesApp)
        Me.Panel4.Controls.Add(Me.RadTextBox_QAApp)
        Me.Panel4.Controls.Add(Me.RadButton_DesApp)
        Me.Panel4.Controls.Add(Me.RadButton_QAApp)
        Me.Panel4.Controls.Add(Me.RadButton_CleapApps)
        Me.Panel4.Location = New System.Drawing.Point(1155, 63)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(156, 123)
        Me.Panel4.TabIndex = 2
        '
        'RadTextBox_DesApp
        '
        Me.RadTextBox_DesApp.AutoSize = False
        Me.RadTextBox_DesApp.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_DesApp.Location = New System.Drawing.Point(96, 47)
        Me.RadTextBox_DesApp.Name = "RadTextBox_DesApp"
        Me.RadTextBox_DesApp.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_DesApp.TabIndex = 18
        Me.RadTextBox_DesApp.ThemeName = "Windows8"
        '
        'RadTextBox_QAApp
        '
        Me.RadTextBox_QAApp.AutoSize = False
        Me.RadTextBox_QAApp.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_QAApp.Location = New System.Drawing.Point(96, 5)
        Me.RadTextBox_QAApp.Name = "RadTextBox_QAApp"
        Me.RadTextBox_QAApp.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_QAApp.TabIndex = 17
        Me.RadTextBox_QAApp.ThemeName = "Windows8"
        '
        'RadButton_DesApp
        '
        Me.RadButton_DesApp.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadButton_DesApp.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadButton_DesApp.ForeColor = System.Drawing.Color.Black
        Me.RadButton_DesApp.Location = New System.Drawing.Point(3, 44)
        Me.RadButton_DesApp.Name = "RadButton_DesApp"
        Me.RadButton_DesApp.Size = New System.Drawing.Size(87, 35)
        Me.RadButton_DesApp.TabIndex = 4
        Me.RadButton_DesApp.Text = "DesignSummary_DesApp"
        Me.RadButton_DesApp.ThemeName = "Windows8"
        '
        'RadButton_QAApp
        '
        Me.RadButton_QAApp.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadButton_QAApp.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadButton_QAApp.ForeColor = System.Drawing.Color.Black
        Me.RadButton_QAApp.Location = New System.Drawing.Point(3, 2)
        Me.RadButton_QAApp.Name = "RadButton_QAApp"
        Me.RadButton_QAApp.Size = New System.Drawing.Size(87, 35)
        Me.RadButton_QAApp.TabIndex = 3
        Me.RadButton_QAApp.Text = "DesignSummary_QAApp"
        Me.RadButton_QAApp.ThemeName = "Windows8"
        '
        'RadButton_CleapApps
        '
        Me.RadButton_CleapApps.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadButton_CleapApps.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadButton_CleapApps.ForeColor = System.Drawing.Color.Black
        Me.RadButton_CleapApps.Location = New System.Drawing.Point(3, 85)
        Me.RadButton_CleapApps.Name = "RadButton_CleapApps"
        Me.RadButton_CleapApps.Size = New System.Drawing.Size(146, 29)
        Me.RadButton_CleapApps.TabIndex = 4
        Me.RadButton_CleapApps.Text = "DesignSummary_ClearApps"
        Me.RadButton_CleapApps.ThemeName = "Windows8"
        '
        'RadButton_NewSpec
        '
        Me.RadButton_NewSpec.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadButton_NewSpec.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_NewSpec.ForeColor = System.Drawing.Color.Black
        Me.RadButton_NewSpec.Location = New System.Drawing.Point(845, 10)
        Me.RadButton_NewSpec.Name = "RadButton_NewSpec"
        Me.RadButton_NewSpec.Size = New System.Drawing.Size(136, 53)
        Me.RadButton_NewSpec.TabIndex = 16
        Me.RadButton_NewSpec.Text = "DesignSummary_NewSpec"
        Me.RadButton_NewSpec.TextWrap = True
        Me.RadButton_NewSpec.ThemeName = "Windows8"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.RadButton_NewSpec)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.RadButton_StockOrders)
        Me.Panel2.Controls.Add(Me.RadButton_AddToList)
        Me.Panel2.Controls.Add(Me.RadButton_GoToScratchPad)
        Me.Panel2.Controls.Add(Me.RadButton_Transfer)
        Me.Panel2.Controls.Add(Me.RadButton_Delete)
        Me.Panel2.Controls.Add(Me.PictureBox_KemetLogo)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.RadLabel1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1333, 194)
        Me.Panel2.TabIndex = 1
        '
        'TabControl_AddCatData
        '
        Me.TabControl_AddCatData.Controls.Add(Me.TabPage_pgeCatData)
        Me.TabControl_AddCatData.Controls.Add(Me.TabPage_pgeAddData)
        Me.TabControl_AddCatData.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TabControl_AddCatData.Location = New System.Drawing.Point(6, 4)
        Me.TabControl_AddCatData.Name = "TabControl_AddCatData"
        Me.TabControl_AddCatData.SelectedIndex = 0
        Me.TabControl_AddCatData.Size = New System.Drawing.Size(342, 192)
        Me.TabControl_AddCatData.TabIndex = 0
        '
        'TabPage_pgeCatData
        '
        Me.TabPage_pgeCatData.BackColor = System.Drawing.Color.Silver
        Me.TabPage_pgeCatData.Controls.Add(Me.Panel21)
        Me.TabPage_pgeCatData.Location = New System.Drawing.Point(4, 26)
        Me.TabPage_pgeCatData.Name = "TabPage_pgeCatData"
        Me.TabPage_pgeCatData.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_pgeCatData.Size = New System.Drawing.Size(334, 162)
        Me.TabPage_pgeCatData.TabIndex = 0
        Me.TabPage_pgeCatData.Text = "DesignSummary_pgeCatData"
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.Color.White
        Me.Panel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel21.Controls.Add(Me.RadTextBox_TableCondy)
        Me.Panel21.Controls.Add(Me.RadLabel_TableCondy)
        Me.Panel21.Controls.Add(Me.RadTextBox1)
        Me.Panel21.Controls.Add(Me.RadTextBox6)
        Me.Panel21.Controls.Add(Me.RadTextBox7)
        Me.Panel21.Controls.Add(Me.RadTextBox8)
        Me.Panel21.Controls.Add(Me.RadTextBox9)
        Me.Panel21.Controls.Add(Me.RadTextBox4)
        Me.Panel21.Controls.Add(Me.RadTextBox3)
        Me.Panel21.Controls.Add(Me.RadTextBox2)
        Me.Panel21.Controls.Add(Me.RadLabel_TableRiseT)
        Me.Panel21.Controls.Add(Me.RadLabel_TableRbc)
        Me.Panel21.Controls.Add(Me.RadLabel_TableRwb)
        Me.Panel21.Controls.Add(Me.RadLabel_TableRhw)
        Me.Panel21.Controls.Add(Me.RadLabel_TableOxide)
        Me.Panel21.Controls.Add(Me.RadLabel_TableTissue)
        Me.Panel21.Controls.Add(Me.RadLabel_TableTabbing)
        Me.Panel21.Controls.Add(Me.RadLabel_TableFoil)
        Me.Panel21.Controls.Add(Me.Panel25)
        Me.Panel21.Location = New System.Drawing.Point(20, 6)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(296, 150)
        Me.Panel21.TabIndex = 0
        '
        'RadTextBox_TableCondy
        '
        Me.RadTextBox_TableCondy.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadTextBox_TableCondy.Location = New System.Drawing.Point(72, 122)
        Me.RadTextBox_TableCondy.Name = "RadTextBox_TableCondy"
        Me.RadTextBox_TableCondy.Size = New System.Drawing.Size(206, 23)
        Me.RadTextBox_TableCondy.TabIndex = 2
        Me.RadTextBox_TableCondy.ThemeName = "Windows8"
        '
        'RadLabel_TableCondy
        '
        Me.RadLabel_TableCondy.AutoSize = False
        Me.RadLabel_TableCondy.BackColor = System.Drawing.Color.White
        Me.RadLabel_TableCondy.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_TableCondy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadLabel_TableCondy.Location = New System.Drawing.Point(0, 121)
        Me.RadLabel_TableCondy.Name = "RadLabel_TableCondy"
        Me.RadLabel_TableCondy.Size = New System.Drawing.Size(73, 23)
        Me.RadLabel_TableCondy.TabIndex = 143
        Me.RadLabel_TableCondy.Text = "DesignSummary_TableCondy"
        Me.RadLabel_TableCondy.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_TableCondy.TextWrap = False
        Me.RadLabel_TableCondy.ThemeName = "Windows8"
        '
        'RadTextBox1
        '
        Me.RadTextBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadTextBox1.Location = New System.Drawing.Point(72, 23)
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.Size = New System.Drawing.Size(69, 23)
        Me.RadTextBox1.TabIndex = 1
        Me.RadTextBox1.ThemeName = "Windows8"
        '
        'RadTextBox6
        '
        Me.RadTextBox6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadTextBox6.Location = New System.Drawing.Point(209, 95)
        Me.RadTextBox6.Name = "RadTextBox6"
        Me.RadTextBox6.Size = New System.Drawing.Size(69, 23)
        Me.RadTextBox6.TabIndex = 8
        Me.RadTextBox6.ThemeName = "Windows8"
        '
        'RadTextBox7
        '
        Me.RadTextBox7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadTextBox7.Location = New System.Drawing.Point(209, 71)
        Me.RadTextBox7.Name = "RadTextBox7"
        Me.RadTextBox7.Size = New System.Drawing.Size(69, 23)
        Me.RadTextBox7.TabIndex = 7
        Me.RadTextBox7.ThemeName = "Windows8"
        '
        'RadTextBox8
        '
        Me.RadTextBox8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadTextBox8.Location = New System.Drawing.Point(209, 47)
        Me.RadTextBox8.Name = "RadTextBox8"
        Me.RadTextBox8.Size = New System.Drawing.Size(69, 23)
        Me.RadTextBox8.TabIndex = 6
        Me.RadTextBox8.ThemeName = "Windows8"
        '
        'RadTextBox9
        '
        Me.RadTextBox9.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadTextBox9.Location = New System.Drawing.Point(209, 23)
        Me.RadTextBox9.Name = "RadTextBox9"
        Me.RadTextBox9.Size = New System.Drawing.Size(69, 23)
        Me.RadTextBox9.TabIndex = 5
        Me.RadTextBox9.ThemeName = "Windows8"
        '
        'RadTextBox4
        '
        Me.RadTextBox4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadTextBox4.Location = New System.Drawing.Point(72, 95)
        Me.RadTextBox4.Name = "RadTextBox4"
        Me.RadTextBox4.Size = New System.Drawing.Size(69, 23)
        Me.RadTextBox4.TabIndex = 4
        Me.RadTextBox4.ThemeName = "Windows8"
        '
        'RadTextBox3
        '
        Me.RadTextBox3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadTextBox3.Location = New System.Drawing.Point(72, 71)
        Me.RadTextBox3.Name = "RadTextBox3"
        Me.RadTextBox3.Size = New System.Drawing.Size(69, 23)
        Me.RadTextBox3.TabIndex = 3
        Me.RadTextBox3.ThemeName = "Windows8"
        '
        'RadTextBox2
        '
        Me.RadTextBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadTextBox2.Location = New System.Drawing.Point(72, 47)
        Me.RadTextBox2.Name = "RadTextBox2"
        Me.RadTextBox2.Size = New System.Drawing.Size(69, 23)
        Me.RadTextBox2.TabIndex = 2
        Me.RadTextBox2.ThemeName = "Windows8"
        '
        'RadLabel_TableRiseT
        '
        Me.RadLabel_TableRiseT.AutoSize = False
        Me.RadLabel_TableRiseT.BackColor = System.Drawing.Color.White
        Me.RadLabel_TableRiseT.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_TableRiseT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadLabel_TableRiseT.Location = New System.Drawing.Point(153, 95)
        Me.RadLabel_TableRiseT.Name = "RadLabel_TableRiseT"
        Me.RadLabel_TableRiseT.Size = New System.Drawing.Size(50, 23)
        Me.RadLabel_TableRiseT.TabIndex = 143
        Me.RadLabel_TableRiseT.Text = "DesignSummary_TableRiseT"
        Me.RadLabel_TableRiseT.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_TableRiseT.TextWrap = False
        Me.RadLabel_TableRiseT.ThemeName = "Windows8"
        '
        'RadLabel_TableRbc
        '
        Me.RadLabel_TableRbc.AutoSize = False
        Me.RadLabel_TableRbc.BackColor = System.Drawing.Color.White
        Me.RadLabel_TableRbc.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_TableRbc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadLabel_TableRbc.Location = New System.Drawing.Point(153, 71)
        Me.RadLabel_TableRbc.Name = "RadLabel_TableRbc"
        Me.RadLabel_TableRbc.Size = New System.Drawing.Size(50, 23)
        Me.RadLabel_TableRbc.TabIndex = 142
        Me.RadLabel_TableRbc.Text = "DesignSummary_TableRbc"
        Me.RadLabel_TableRbc.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_TableRbc.TextWrap = False
        Me.RadLabel_TableRbc.ThemeName = "Windows8"
        '
        'RadLabel_TableRwb
        '
        Me.RadLabel_TableRwb.AutoSize = False
        Me.RadLabel_TableRwb.BackColor = System.Drawing.Color.White
        Me.RadLabel_TableRwb.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_TableRwb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadLabel_TableRwb.Location = New System.Drawing.Point(153, 47)
        Me.RadLabel_TableRwb.Name = "RadLabel_TableRwb"
        Me.RadLabel_TableRwb.Size = New System.Drawing.Size(50, 23)
        Me.RadLabel_TableRwb.TabIndex = 141
        Me.RadLabel_TableRwb.Text = "DesignSummary_TableRwb"
        Me.RadLabel_TableRwb.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_TableRwb.TextWrap = False
        Me.RadLabel_TableRwb.ThemeName = "Windows8"
        '
        'RadLabel_TableRhw
        '
        Me.RadLabel_TableRhw.AutoSize = False
        Me.RadLabel_TableRhw.BackColor = System.Drawing.Color.White
        Me.RadLabel_TableRhw.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_TableRhw.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadLabel_TableRhw.Location = New System.Drawing.Point(153, 23)
        Me.RadLabel_TableRhw.Name = "RadLabel_TableRhw"
        Me.RadLabel_TableRhw.Size = New System.Drawing.Size(50, 23)
        Me.RadLabel_TableRhw.TabIndex = 140
        Me.RadLabel_TableRhw.Text = "DesignSummary_TableRhw"
        Me.RadLabel_TableRhw.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_TableRhw.TextWrap = False
        Me.RadLabel_TableRhw.ThemeName = "Windows8"
        '
        'RadLabel_TableOxide
        '
        Me.RadLabel_TableOxide.AutoSize = False
        Me.RadLabel_TableOxide.BackColor = System.Drawing.Color.White
        Me.RadLabel_TableOxide.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_TableOxide.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadLabel_TableOxide.Location = New System.Drawing.Point(0, 95)
        Me.RadLabel_TableOxide.Name = "RadLabel_TableOxide"
        Me.RadLabel_TableOxide.Size = New System.Drawing.Size(73, 23)
        Me.RadLabel_TableOxide.TabIndex = 142
        Me.RadLabel_TableOxide.Text = "DesignSummary_TableOxide"
        Me.RadLabel_TableOxide.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_TableOxide.TextWrap = False
        Me.RadLabel_TableOxide.ThemeName = "Windows8"
        '
        'RadLabel_TableTissue
        '
        Me.RadLabel_TableTissue.AutoSize = False
        Me.RadLabel_TableTissue.BackColor = System.Drawing.Color.White
        Me.RadLabel_TableTissue.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_TableTissue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadLabel_TableTissue.Location = New System.Drawing.Point(0, 71)
        Me.RadLabel_TableTissue.Name = "RadLabel_TableTissue"
        Me.RadLabel_TableTissue.Size = New System.Drawing.Size(73, 23)
        Me.RadLabel_TableTissue.TabIndex = 141
        Me.RadLabel_TableTissue.Text = "DesignSummary_TableTissue"
        Me.RadLabel_TableTissue.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_TableTissue.TextWrap = False
        Me.RadLabel_TableTissue.ThemeName = "Windows8"
        '
        'RadLabel_TableTabbing
        '
        Me.RadLabel_TableTabbing.AutoSize = False
        Me.RadLabel_TableTabbing.BackColor = System.Drawing.Color.White
        Me.RadLabel_TableTabbing.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_TableTabbing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadLabel_TableTabbing.Location = New System.Drawing.Point(0, 47)
        Me.RadLabel_TableTabbing.Name = "RadLabel_TableTabbing"
        Me.RadLabel_TableTabbing.Size = New System.Drawing.Size(73, 23)
        Me.RadLabel_TableTabbing.TabIndex = 140
        Me.RadLabel_TableTabbing.Text = "DesignSummary_TableTabbing"
        Me.RadLabel_TableTabbing.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_TableTabbing.TextWrap = False
        Me.RadLabel_TableTabbing.ThemeName = "Windows8"
        '
        'RadLabel_TableFoil
        '
        Me.RadLabel_TableFoil.AutoSize = False
        Me.RadLabel_TableFoil.BackColor = System.Drawing.Color.White
        Me.RadLabel_TableFoil.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_TableFoil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadLabel_TableFoil.Location = New System.Drawing.Point(0, 23)
        Me.RadLabel_TableFoil.Name = "RadLabel_TableFoil"
        Me.RadLabel_TableFoil.Size = New System.Drawing.Size(73, 23)
        Me.RadLabel_TableFoil.TabIndex = 139
        Me.RadLabel_TableFoil.Text = "DesignSummary_TableFoil"
        Me.RadLabel_TableFoil.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_TableFoil.TextWrap = False
        Me.RadLabel_TableFoil.ThemeName = "Windows8"
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel25.Controls.Add(Me.RadLabel_CatalogueData)
        Me.Panel25.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Panel25.Location = New System.Drawing.Point(0, 0)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(296, 20)
        Me.Panel25.TabIndex = 0
        '
        'RadLabel_CatalogueData
        '
        Me.RadLabel_CatalogueData.AutoSize = False
        Me.RadLabel_CatalogueData.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadLabel_CatalogueData.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_CatalogueData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadLabel_CatalogueData.Location = New System.Drawing.Point(8, 0)
        Me.RadLabel_CatalogueData.Name = "RadLabel_CatalogueData"
        Me.RadLabel_CatalogueData.Size = New System.Drawing.Size(212, 18)
        Me.RadLabel_CatalogueData.TabIndex = 140
        Me.RadLabel_CatalogueData.Text = "DesignSummary_CatalogueData"
        Me.RadLabel_CatalogueData.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_CatalogueData.TextWrap = False
        Me.RadLabel_CatalogueData.ThemeName = "Windows8"
        '
        'TabPage_pgeAddData
        '
        Me.TabPage_pgeAddData.BackColor = System.Drawing.Color.Silver
        Me.TabPage_pgeAddData.Controls.Add(Me.RadGridView1)
        Me.TabPage_pgeAddData.Location = New System.Drawing.Point(4, 26)
        Me.TabPage_pgeAddData.Name = "TabPage_pgeAddData"
        Me.TabPage_pgeAddData.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_pgeAddData.Size = New System.Drawing.Size(334, 162)
        Me.TabPage_pgeAddData.TabIndex = 1
        Me.TabPage_pgeAddData.Text = "DesignSummary_pgeAddData"
        '
        'RadGridView1
        '
        Me.RadGridView1.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.Size = New System.Drawing.Size(334, 162)
        Me.RadGridView1.TabIndex = 0
        Me.RadGridView1.Text = "RadGridView1"
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel10.Controls.Add(Me.TabControl_AddCatData)
        Me.Panel10.Location = New System.Drawing.Point(955, 517)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(357, 207)
        Me.Panel10.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel9.Controls.Add(Me.RadLabel_SpecificationDetails)
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(162, 29)
        Me.Panel9.TabIndex = 7
        '
        'RadLabel_SpecificationDetails
        '
        Me.RadLabel_SpecificationDetails.AutoSize = False
        Me.RadLabel_SpecificationDetails.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_SpecificationDetails.Location = New System.Drawing.Point(0, 0)
        Me.RadLabel_SpecificationDetails.Name = "RadLabel_SpecificationDetails"
        Me.RadLabel_SpecificationDetails.Size = New System.Drawing.Size(160, 22)
        Me.RadLabel_SpecificationDetails.TabIndex = 132
        Me.RadLabel_SpecificationDetails.Text = "DesignSummary_SpecificationsDetails"
        Me.RadLabel_SpecificationDetails.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_SpecificationDetails.TextWrap = False
        Me.RadLabel_SpecificationDetails.ThemeName = "Windows8"
        '
        'Label_At1
        '
        Me.Label_At1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label_At1.Location = New System.Drawing.Point(147, 321)
        Me.Label_At1.Name = "Label_At1"
        Me.Label_At1.Size = New System.Drawing.Size(24, 29)
        Me.Label_At1.TabIndex = 25
        Me.Label_At1.Text = "@"
        Me.Label_At1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_At2
        '
        Me.Label_At2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label_At2.Location = New System.Drawing.Point(235, 320)
        Me.Label_At2.Name = "Label_At2"
        Me.Label_At2.Size = New System.Drawing.Size(24, 29)
        Me.Label_At2.TabIndex = 27
        Me.Label_At2.Text = "@"
        Me.Label_At2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_Customer
        '
        Me.RadTextBox_Customer.AutoSize = False
        Me.RadTextBox_Customer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_Customer.Location = New System.Drawing.Point(127, 43)
        Me.RadTextBox_Customer.Name = "RadTextBox_Customer"
        Me.RadTextBox_Customer.Size = New System.Drawing.Size(196, 29)
        Me.RadTextBox_Customer.TabIndex = 121
        Me.RadTextBox_Customer.ThemeName = "Windows8"
        '
        'RadTextBox_CustomerPartNumber
        '
        Me.RadTextBox_CustomerPartNumber.AutoSize = False
        Me.RadTextBox_CustomerPartNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_CustomerPartNumber.Location = New System.Drawing.Point(127, 79)
        Me.RadTextBox_CustomerPartNumber.Name = "RadTextBox_CustomerPartNumber"
        Me.RadTextBox_CustomerPartNumber.Size = New System.Drawing.Size(196, 29)
        Me.RadTextBox_CustomerPartNumber.TabIndex = 122
        Me.RadTextBox_CustomerPartNumber.ThemeName = "Windows8"
        '
        'RadTextBox_Distributor
        '
        Me.RadTextBox_Distributor.AutoSize = False
        Me.RadTextBox_Distributor.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_Distributor.Location = New System.Drawing.Point(127, 115)
        Me.RadTextBox_Distributor.Name = "RadTextBox_Distributor"
        Me.RadTextBox_Distributor.Size = New System.Drawing.Size(196, 29)
        Me.RadTextBox_Distributor.TabIndex = 123
        Me.RadTextBox_Distributor.ThemeName = "Windows8"
        '
        'RadTextBox_SpecDrawingSpecs
        '
        Me.RadTextBox_SpecDrawingSpecs.AutoSize = False
        Me.RadTextBox_SpecDrawingSpecs.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_SpecDrawingSpecs.Location = New System.Drawing.Point(127, 151)
        Me.RadTextBox_SpecDrawingSpecs.Name = "RadTextBox_SpecDrawingSpecs"
        Me.RadTextBox_SpecDrawingSpecs.Size = New System.Drawing.Size(196, 29)
        Me.RadTextBox_SpecDrawingSpecs.TabIndex = 124
        Me.RadTextBox_SpecDrawingSpecs.ThemeName = "Windows8"
        '
        'RadTextBox_Terminals
        '
        Me.RadTextBox_Terminals.AutoSize = False
        Me.RadTextBox_Terminals.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_Terminals.Location = New System.Drawing.Point(127, 187)
        Me.RadTextBox_Terminals.Name = "RadTextBox_Terminals"
        Me.RadTextBox_Terminals.Size = New System.Drawing.Size(196, 29)
        Me.RadTextBox_Terminals.TabIndex = 125
        Me.RadTextBox_Terminals.ThemeName = "Windows8"
        '
        'RadTextBox_Dimensions
        '
        Me.RadTextBox_Dimensions.AutoSize = False
        Me.RadTextBox_Dimensions.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_Dimensions.Location = New System.Drawing.Point(127, 222)
        Me.RadTextBox_Dimensions.Name = "RadTextBox_Dimensions"
        Me.RadTextBox_Dimensions.Size = New System.Drawing.Size(196, 29)
        Me.RadTextBox_Dimensions.TabIndex = 126
        Me.RadTextBox_Dimensions.ThemeName = "Windows8"
        '
        'RadTextBox_SpecNotes
        '
        Me.RadTextBox_SpecNotes.AutoSize = False
        Me.RadTextBox_SpecNotes.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_SpecNotes.Location = New System.Drawing.Point(127, 257)
        Me.RadTextBox_SpecNotes.Name = "RadTextBox_SpecNotes"
        Me.RadTextBox_SpecNotes.Size = New System.Drawing.Size(196, 58)
        Me.RadTextBox_SpecNotes.TabIndex = 127
        Me.RadTextBox_SpecNotes.ThemeName = "Windows8"
        '
        'RadTextBox_RatedIR
        '
        Me.RadTextBox_RatedIR.AutoSize = False
        Me.RadTextBox_RatedIR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_RatedIR.Location = New System.Drawing.Point(87, 321)
        Me.RadTextBox_RatedIR.Name = "RadTextBox_RatedIR"
        Me.RadTextBox_RatedIR.Size = New System.Drawing.Size(41, 29)
        Me.RadTextBox_RatedIR.TabIndex = 128
        Me.RadTextBox_RatedIR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_RatedIR.ThemeName = "Windows8"
        '
        'RadTextBox_IRFreq
        '
        Me.RadTextBox_IRFreq.AutoSize = False
        Me.RadTextBox_IRFreq.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_IRFreq.Location = New System.Drawing.Point(168, 321)
        Me.RadTextBox_IRFreq.Name = "RadTextBox_IRFreq"
        Me.RadTextBox_IRFreq.Size = New System.Drawing.Size(41, 29)
        Me.RadTextBox_IRFreq.TabIndex = 129
        Me.RadTextBox_IRFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_IRFreq.ThemeName = "Windows8"
        '
        'RadTextBox_IRTemp
        '
        Me.RadTextBox_IRTemp.AutoSize = False
        Me.RadTextBox_IRTemp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_IRTemp.Location = New System.Drawing.Point(257, 320)
        Me.RadTextBox_IRTemp.Name = "RadTextBox_IRTemp"
        Me.RadTextBox_IRTemp.Size = New System.Drawing.Size(41, 29)
        Me.RadTextBox_IRTemp.TabIndex = 130
        Me.RadTextBox_IRTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_IRTemp.ThemeName = "Windows8"
        '
        'RadLabel_Customer
        '
        Me.RadLabel_Customer.AutoSize = False
        Me.RadLabel_Customer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Customer.Location = New System.Drawing.Point(7, 43)
        Me.RadLabel_Customer.Name = "RadLabel_Customer"
        Me.RadLabel_Customer.Size = New System.Drawing.Size(114, 27)
        Me.RadLabel_Customer.TabIndex = 131
        Me.RadLabel_Customer.Text = "DesignSummary_Customer"
        Me.RadLabel_Customer.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Customer.TextWrap = False
        Me.RadLabel_Customer.ThemeName = "Windows8"
        '
        'RadLabel_CustomerPartNumber
        '
        Me.RadLabel_CustomerPartNumber.AutoSize = False
        Me.RadLabel_CustomerPartNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_CustomerPartNumber.Location = New System.Drawing.Point(7, 79)
        Me.RadLabel_CustomerPartNumber.Name = "RadLabel_CustomerPartNumber"
        Me.RadLabel_CustomerPartNumber.Size = New System.Drawing.Size(114, 27)
        Me.RadLabel_CustomerPartNumber.TabIndex = 132
        Me.RadLabel_CustomerPartNumber.Text = "DesignSummary_CustPNo"
        Me.RadLabel_CustomerPartNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_CustomerPartNumber.TextWrap = False
        Me.RadLabel_CustomerPartNumber.ThemeName = "Windows8"
        '
        'RadLabel_Distributor
        '
        Me.RadLabel_Distributor.AutoSize = False
        Me.RadLabel_Distributor.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Distributor.Location = New System.Drawing.Point(7, 115)
        Me.RadLabel_Distributor.Name = "RadLabel_Distributor"
        Me.RadLabel_Distributor.Size = New System.Drawing.Size(114, 27)
        Me.RadLabel_Distributor.TabIndex = 133
        Me.RadLabel_Distributor.Text = "DesignSummary_Distributor"
        Me.RadLabel_Distributor.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Distributor.TextWrap = False
        Me.RadLabel_Distributor.ThemeName = "Windows8"
        '
        'RadLabel_SpecDrawingSpecs
        '
        Me.RadLabel_SpecDrawingSpecs.AutoSize = False
        Me.RadLabel_SpecDrawingSpecs.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_SpecDrawingSpecs.Location = New System.Drawing.Point(7, 151)
        Me.RadLabel_SpecDrawingSpecs.Name = "RadLabel_SpecDrawingSpecs"
        Me.RadLabel_SpecDrawingSpecs.Size = New System.Drawing.Size(114, 27)
        Me.RadLabel_SpecDrawingSpecs.TabIndex = 134
        Me.RadLabel_SpecDrawingSpecs.Text = "DesignSummary_SpecDrawing"
        Me.RadLabel_SpecDrawingSpecs.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_SpecDrawingSpecs.TextWrap = False
        Me.RadLabel_SpecDrawingSpecs.ThemeName = "Windows8"
        '
        'RadLabel_Terminals
        '
        Me.RadLabel_Terminals.AutoSize = False
        Me.RadLabel_Terminals.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Terminals.Location = New System.Drawing.Point(7, 187)
        Me.RadLabel_Terminals.Name = "RadLabel_Terminals"
        Me.RadLabel_Terminals.Size = New System.Drawing.Size(114, 27)
        Me.RadLabel_Terminals.TabIndex = 135
        Me.RadLabel_Terminals.Text = "DesignSummary_Terminals"
        Me.RadLabel_Terminals.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Terminals.TextWrap = False
        Me.RadLabel_Terminals.ThemeName = "Windows8"
        '
        'RadLabel_Dimensions
        '
        Me.RadLabel_Dimensions.AutoSize = False
        Me.RadLabel_Dimensions.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Dimensions.Location = New System.Drawing.Point(7, 222)
        Me.RadLabel_Dimensions.Name = "RadLabel_Dimensions"
        Me.RadLabel_Dimensions.Size = New System.Drawing.Size(114, 27)
        Me.RadLabel_Dimensions.TabIndex = 136
        Me.RadLabel_Dimensions.Text = "DesignSummary_Dimensions"
        Me.RadLabel_Dimensions.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Dimensions.TextWrap = False
        Me.RadLabel_Dimensions.ThemeName = "Windows8"
        '
        'RadLabel_SpecNotes
        '
        Me.RadLabel_SpecNotes.AutoSize = False
        Me.RadLabel_SpecNotes.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_SpecNotes.Location = New System.Drawing.Point(7, 257)
        Me.RadLabel_SpecNotes.Name = "RadLabel_SpecNotes"
        Me.RadLabel_SpecNotes.Size = New System.Drawing.Size(114, 27)
        Me.RadLabel_SpecNotes.TabIndex = 137
        Me.RadLabel_SpecNotes.Text = "DesignSummary_SpecNotes"
        Me.RadLabel_SpecNotes.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_SpecNotes.TextWrap = False
        Me.RadLabel_SpecNotes.ThemeName = "Windows8"
        '
        'RadLabel_RatedIR
        '
        Me.RadLabel_RatedIR.AutoSize = False
        Me.RadLabel_RatedIR.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_RatedIR.Location = New System.Drawing.Point(-1, 323)
        Me.RadLabel_RatedIR.Name = "RadLabel_RatedIR"
        Me.RadLabel_RatedIR.Size = New System.Drawing.Size(90, 27)
        Me.RadLabel_RatedIR.TabIndex = 138
        Me.RadLabel_RatedIR.Text = "DesignSummary_RatedIR"
        Me.RadLabel_RatedIR.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_RatedIR.TextWrap = False
        Me.RadLabel_RatedIR.ThemeName = "Windows8"
        '
        'RadLabel_RatedIRUnit
        '
        Me.RadLabel_RatedIRUnit.AutoSize = False
        Me.RadLabel_RatedIRUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_RatedIRUnit.Location = New System.Drawing.Point(125, 321)
        Me.RadLabel_RatedIRUnit.Name = "RadLabel_RatedIRUnit"
        Me.RadLabel_RatedIRUnit.Size = New System.Drawing.Size(24, 29)
        Me.RadLabel_RatedIRUnit.TabIndex = 139
        Me.RadLabel_RatedIRUnit.Text = "Global_Ampere"
        Me.RadLabel_RatedIRUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_RatedIRUnit.TextWrap = False
        Me.RadLabel_RatedIRUnit.ThemeName = "Windows8"
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Controls.Add(Me.RadTextBox_IRTemp)
        Me.Panel8.Controls.Add(Me.RadLabel_IRTempUnit)
        Me.Panel8.Controls.Add(Me.RadTextBox_IRFreq)
        Me.Panel8.Controls.Add(Me.RadLabel_IRFreqUnit)
        Me.Panel8.Controls.Add(Me.RadLabel_RatedIRUnit)
        Me.Panel8.Controls.Add(Me.RadLabel_RatedIR)
        Me.Panel8.Controls.Add(Me.RadLabel_SpecNotes)
        Me.Panel8.Controls.Add(Me.RadLabel_Dimensions)
        Me.Panel8.Controls.Add(Me.RadLabel_Terminals)
        Me.Panel8.Controls.Add(Me.RadLabel_SpecDrawingSpecs)
        Me.Panel8.Controls.Add(Me.RadLabel_Distributor)
        Me.Panel8.Controls.Add(Me.RadLabel_CustomerPartNumber)
        Me.Panel8.Controls.Add(Me.RadLabel_Customer)
        Me.Panel8.Controls.Add(Me.RadTextBox_RatedIR)
        Me.Panel8.Controls.Add(Me.RadTextBox_SpecNotes)
        Me.Panel8.Controls.Add(Me.RadTextBox_Dimensions)
        Me.Panel8.Controls.Add(Me.RadTextBox_Terminals)
        Me.Panel8.Controls.Add(Me.RadTextBox_SpecDrawingSpecs)
        Me.Panel8.Controls.Add(Me.RadTextBox_Distributor)
        Me.Panel8.Controls.Add(Me.RadTextBox_CustomerPartNumber)
        Me.Panel8.Controls.Add(Me.RadTextBox_Customer)
        Me.Panel8.Controls.Add(Me.Label_At2)
        Me.Panel8.Controls.Add(Me.Label_At1)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Location = New System.Drawing.Point(955, 162)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(357, 358)
        Me.Panel8.TabIndex = 14
        '
        'RadLabel_IRTempUnit
        '
        Me.RadLabel_IRTempUnit.AutoSize = False
        Me.RadLabel_IRTempUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_IRTempUnit.Location = New System.Drawing.Point(296, 320)
        Me.RadLabel_IRTempUnit.Name = "RadLabel_IRTempUnit"
        Me.RadLabel_IRTempUnit.Size = New System.Drawing.Size(27, 29)
        Me.RadLabel_IRTempUnit.TabIndex = 141
        Me.RadLabel_IRTempUnit.Text = "Global_CelsiusDegrees"
        Me.RadLabel_IRTempUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_IRTempUnit.TextWrap = False
        Me.RadLabel_IRTempUnit.ThemeName = "Windows8"
        '
        'RadLabel_IRFreqUnit
        '
        Me.RadLabel_IRFreqUnit.AutoSize = False
        Me.RadLabel_IRFreqUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_IRFreqUnit.Location = New System.Drawing.Point(206, 321)
        Me.RadLabel_IRFreqUnit.Name = "RadLabel_IRFreqUnit"
        Me.RadLabel_IRFreqUnit.Size = New System.Drawing.Size(27, 29)
        Me.RadLabel_IRFreqUnit.TabIndex = 140
        Me.RadLabel_IRFreqUnit.Text = "Global_Hz"
        Me.RadLabel_IRFreqUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_IRFreqUnit.TextWrap = False
        Me.RadLabel_IRFreqUnit.ThemeName = "Windows8"
        '
        'RadLabel_PartsFile
        '
        Me.RadLabel_PartsFile.AutoSize = False
        Me.RadLabel_PartsFile.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_PartsFile.Location = New System.Drawing.Point(57, 6)
        Me.RadLabel_PartsFile.Name = "RadLabel_PartsFile"
        Me.RadLabel_PartsFile.Size = New System.Drawing.Size(80, 27)
        Me.RadLabel_PartsFile.TabIndex = 109
        Me.RadLabel_PartsFile.Text = "DesignSummary_PartsFile"
        Me.RadLabel_PartsFile.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_PartsFile.TextWrap = False
        Me.RadLabel_PartsFile.ThemeName = "Windows8"
        '
        'RadLabel_Routing
        '
        Me.RadLabel_Routing.AutoSize = False
        Me.RadLabel_Routing.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Routing.Location = New System.Drawing.Point(57, 36)
        Me.RadLabel_Routing.Name = "RadLabel_Routing"
        Me.RadLabel_Routing.Size = New System.Drawing.Size(80, 27)
        Me.RadLabel_Routing.TabIndex = 110
        Me.RadLabel_Routing.Text = "DesignSummary_Routing"
        Me.RadLabel_Routing.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Routing.TextWrap = False
        Me.RadLabel_Routing.ThemeName = "Windows8"
        '
        'RadLabel_WindingPicture
        '
        Me.RadLabel_WindingPicture.AutoSize = False
        Me.RadLabel_WindingPicture.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_WindingPicture.Location = New System.Drawing.Point(11, 66)
        Me.RadLabel_WindingPicture.Name = "RadLabel_WindingPicture"
        Me.RadLabel_WindingPicture.Size = New System.Drawing.Size(126, 27)
        Me.RadLabel_WindingPicture.TabIndex = 111
        Me.RadLabel_WindingPicture.Text = "DesignSummary_WindingPicture"
        Me.RadLabel_WindingPicture.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_WindingPicture.TextWrap = False
        Me.RadLabel_WindingPicture.ThemeName = "Windows8"
        '
        'RadLabel_DimensionDWG
        '
        Me.RadLabel_DimensionDWG.AutoSize = False
        Me.RadLabel_DimensionDWG.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_DimensionDWG.Location = New System.Drawing.Point(11, 96)
        Me.RadLabel_DimensionDWG.Name = "RadLabel_DimensionDWG"
        Me.RadLabel_DimensionDWG.Size = New System.Drawing.Size(126, 27)
        Me.RadLabel_DimensionDWG.TabIndex = 112
        Me.RadLabel_DimensionDWG.Text = "DesignSummary_DimensionDWG"
        Me.RadLabel_DimensionDWG.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_DimensionDWG.TextWrap = False
        Me.RadLabel_DimensionDWG.ThemeName = "Windows8"
        '
        'RadLabel_SpecDrawing
        '
        Me.RadLabel_SpecDrawing.AutoSize = False
        Me.RadLabel_SpecDrawing.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_SpecDrawing.Location = New System.Drawing.Point(11, 126)
        Me.RadLabel_SpecDrawing.Name = "RadLabel_SpecDrawing"
        Me.RadLabel_SpecDrawing.Size = New System.Drawing.Size(126, 27)
        Me.RadLabel_SpecDrawing.TabIndex = 131
        Me.RadLabel_SpecDrawing.Text = "DesignSummary_SpecDrawing"
        Me.RadLabel_SpecDrawing.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_SpecDrawing.TextWrap = False
        Me.RadLabel_SpecDrawing.ThemeName = "Windows8"
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.RadLabel_NoLabData2)
        Me.Panel7.Controls.Add(Me.RadDropDownList_SpecDrawing)
        Me.Panel7.Controls.Add(Me.RadDropDownList_PartsFile)
        Me.Panel7.Controls.Add(Me.RadDropDownList_DimensionDWG)
        Me.Panel7.Controls.Add(Me.RadDropDownList_Routing)
        Me.Panel7.Controls.Add(Me.RadDropDownList_WindingPicture)
        Me.Panel7.Controls.Add(Me.RadLabel_SpecDrawing)
        Me.Panel7.Controls.Add(Me.RadLabel_DimensionDWG)
        Me.Panel7.Controls.Add(Me.RadLabel_WindingPicture)
        Me.Panel7.Controls.Add(Me.RadLabel_Routing)
        Me.Panel7.Controls.Add(Me.RadLabel_PartsFile)
        Me.Panel7.Location = New System.Drawing.Point(955, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(357, 165)
        Me.Panel7.TabIndex = 13
        '
        'RadLabel_NoLabData2
        '
        Me.RadLabel_NoLabData2.AutoSize = False
        Me.RadLabel_NoLabData2.BackColor = System.Drawing.Color.Red
        Me.RadLabel_NoLabData2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_NoLabData2.ForeColor = System.Drawing.Color.White
        Me.RadLabel_NoLabData2.Location = New System.Drawing.Point(4, 4)
        Me.RadLabel_NoLabData2.Name = "RadLabel_NoLabData2"
        Me.RadLabel_NoLabData2.Size = New System.Drawing.Size(66, 53)
        Me.RadLabel_NoLabData2.TabIndex = 132
        Me.RadLabel_NoLabData2.Text = "DesignSummary_NoLabData2"
        Me.RadLabel_NoLabData2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_NoLabData2.ThemeName = "Windows8"
        '
        'Panel22
        '
        Me.Panel22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel22.Controls.Add(Me.RadTextBox_LimitValue)
        Me.Panel22.Controls.Add(Me.RadTextBox_TestValue3)
        Me.Panel22.Controls.Add(Me.RadTextBox_TestValue2)
        Me.Panel22.Controls.Add(Me.RadTextBox_TestValue1)
        Me.Panel22.Controls.Add(Me.RadDropDownList_LimitCondition)
        Me.Panel22.Controls.Add(Me.RadDropDownList_LimitMethod)
        Me.Panel22.Controls.Add(Me.RadDropDownList_TestCondition3)
        Me.Panel22.Controls.Add(Me.RadDropDownList_TestParameter3)
        Me.Panel22.Controls.Add(Me.RadDropDownList_TestCondition2)
        Me.Panel22.Controls.Add(Me.RadDropDownList_TestParameter2)
        Me.Panel22.Controls.Add(Me.RadDropDownList_TestCondition1)
        Me.Panel22.Controls.Add(Me.RadDropDownList_TestParameter1)
        Me.Panel22.Controls.Add(Me.Panel24)
        Me.Panel22.Location = New System.Drawing.Point(-2, 506)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(422, 142)
        Me.Panel22.TabIndex = 96
        '
        'RadTextBox_LimitValue
        '
        Me.RadTextBox_LimitValue.AutoSize = False
        Me.RadTextBox_LimitValue.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadTextBox_LimitValue.Location = New System.Drawing.Point(162, 111)
        Me.RadTextBox_LimitValue.Name = "RadTextBox_LimitValue"
        Me.RadTextBox_LimitValue.Size = New System.Drawing.Size(55, 25)
        Me.RadTextBox_LimitValue.TabIndex = 133
        Me.RadTextBox_LimitValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_LimitValue.ThemeName = "Windows8"
        '
        'RadTextBox_TestValue3
        '
        Me.RadTextBox_TestValue3.AutoSize = False
        Me.RadTextBox_TestValue3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadTextBox_TestValue3.Location = New System.Drawing.Point(162, 84)
        Me.RadTextBox_TestValue3.Name = "RadTextBox_TestValue3"
        Me.RadTextBox_TestValue3.Size = New System.Drawing.Size(55, 25)
        Me.RadTextBox_TestValue3.TabIndex = 132
        Me.RadTextBox_TestValue3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TestValue3.ThemeName = "Windows8"
        '
        'RadTextBox_TestValue2
        '
        Me.RadTextBox_TestValue2.AutoSize = False
        Me.RadTextBox_TestValue2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadTextBox_TestValue2.Location = New System.Drawing.Point(162, 57)
        Me.RadTextBox_TestValue2.Name = "RadTextBox_TestValue2"
        Me.RadTextBox_TestValue2.Size = New System.Drawing.Size(55, 25)
        Me.RadTextBox_TestValue2.TabIndex = 131
        Me.RadTextBox_TestValue2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TestValue2.ThemeName = "Windows8"
        '
        'RadTextBox_TestValue1
        '
        Me.RadTextBox_TestValue1.AutoSize = False
        Me.RadTextBox_TestValue1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadTextBox_TestValue1.Location = New System.Drawing.Point(162, 30)
        Me.RadTextBox_TestValue1.Name = "RadTextBox_TestValue1"
        Me.RadTextBox_TestValue1.Size = New System.Drawing.Size(55, 25)
        Me.RadTextBox_TestValue1.TabIndex = 130
        Me.RadTextBox_TestValue1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TestValue1.ThemeName = "Windows8"
        '
        'RadDropDownList_LimitCondition
        '
        Me.RadDropDownList_LimitCondition.AutoSize = False
        Me.RadDropDownList_LimitCondition.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadDropDownList_LimitCondition.Location = New System.Drawing.Point(224, 111)
        Me.RadDropDownList_LimitCondition.Name = "RadDropDownList_LimitCondition"
        Me.RadDropDownList_LimitCondition.Size = New System.Drawing.Size(172, 25)
        Me.RadDropDownList_LimitCondition.TabIndex = 51
        Me.RadDropDownList_LimitCondition.Text = "mA max @ Test Volts"
        Me.RadDropDownList_LimitCondition.ThemeName = "Windows8"
        '
        'RadDropDownList_LimitMethod
        '
        Me.RadDropDownList_LimitMethod.AutoSize = False
        Me.RadDropDownList_LimitMethod.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadDropDownList_LimitMethod.Location = New System.Drawing.Point(14, 111)
        Me.RadDropDownList_LimitMethod.Name = "RadDropDownList_LimitMethod"
        Me.RadDropDownList_LimitMethod.Size = New System.Drawing.Size(142, 25)
        Me.RadDropDownList_LimitMethod.TabIndex = 50
        Me.RadDropDownList_LimitMethod.Text = "DC LEAKAGE"
        Me.RadDropDownList_LimitMethod.ThemeName = "Windows8"
        '
        'RadDropDownList_TestCondition3
        '
        Me.RadDropDownList_TestCondition3.AutoSize = False
        Me.RadDropDownList_TestCondition3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadDropDownList_TestCondition3.Location = New System.Drawing.Point(224, 84)
        Me.RadDropDownList_TestCondition3.Name = "RadDropDownList_TestCondition3"
        Me.RadDropDownList_TestCondition3.Size = New System.Drawing.Size(172, 25)
        Me.RadDropDownList_TestCondition3.TabIndex = 48
        Me.RadDropDownList_TestCondition3.ThemeName = "Windows8"
        '
        'RadDropDownList_TestParameter3
        '
        Me.RadDropDownList_TestParameter3.AutoSize = False
        Me.RadDropDownList_TestParameter3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadDropDownList_TestParameter3.Location = New System.Drawing.Point(14, 84)
        Me.RadDropDownList_TestParameter3.Name = "RadDropDownList_TestParameter3"
        Me.RadDropDownList_TestParameter3.Size = New System.Drawing.Size(142, 25)
        Me.RadDropDownList_TestParameter3.TabIndex = 47
        Me.RadDropDownList_TestParameter3.ThemeName = "Windows8"
        '
        'RadDropDownList_TestCondition2
        '
        Me.RadDropDownList_TestCondition2.AutoSize = False
        Me.RadDropDownList_TestCondition2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadDropDownList_TestCondition2.Location = New System.Drawing.Point(224, 57)
        Me.RadDropDownList_TestCondition2.Name = "RadDropDownList_TestCondition2"
        Me.RadDropDownList_TestCondition2.Size = New System.Drawing.Size(172, 25)
        Me.RadDropDownList_TestCondition2.TabIndex = 45
        Me.RadDropDownList_TestCondition2.Text = "m'Ohms MAX @ 10 KHZ,25°C"
        Me.RadDropDownList_TestCondition2.ThemeName = "Windows8"
        '
        'RadDropDownList_TestParameter2
        '
        Me.RadDropDownList_TestParameter2.AutoSize = False
        Me.RadDropDownList_TestParameter2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadDropDownList_TestParameter2.Location = New System.Drawing.Point(14, 57)
        Me.RadDropDownList_TestParameter2.Name = "RadDropDownList_TestParameter2"
        Me.RadDropDownList_TestParameter2.Size = New System.Drawing.Size(142, 25)
        Me.RadDropDownList_TestParameter2.TabIndex = 44
        Me.RadDropDownList_TestParameter2.Text = "ESR"
        Me.RadDropDownList_TestParameter2.ThemeName = "Windows8"
        '
        'RadDropDownList_TestCondition1
        '
        Me.RadDropDownList_TestCondition1.AutoSize = False
        Me.RadDropDownList_TestCondition1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadDropDownList_TestCondition1.Location = New System.Drawing.Point(224, 30)
        Me.RadDropDownList_TestCondition1.Name = "RadDropDownList_TestCondition1"
        Me.RadDropDownList_TestCondition1.Size = New System.Drawing.Size(172, 25)
        Me.RadDropDownList_TestCondition1.TabIndex = 42
        Me.RadDropDownList_TestCondition1.Text = "m'Ohms MAX @ 120 HZ,25°C"
        Me.RadDropDownList_TestCondition1.ThemeName = "Windows8"
        '
        'RadDropDownList_TestParameter1
        '
        Me.RadDropDownList_TestParameter1.AutoSize = False
        Me.RadDropDownList_TestParameter1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadDropDownList_TestParameter1.Location = New System.Drawing.Point(14, 30)
        Me.RadDropDownList_TestParameter1.Name = "RadDropDownList_TestParameter1"
        Me.RadDropDownList_TestParameter1.Size = New System.Drawing.Size(142, 25)
        Me.RadDropDownList_TestParameter1.TabIndex = 41
        Me.RadDropDownList_TestParameter1.Text = "ESR"
        Me.RadDropDownList_TestParameter1.ThemeName = "Windows8"
        '
        'Panel24
        '
        Me.Panel24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel24.Controls.Add(Me.RadLabel_TestParameteres)
        Me.Panel24.Location = New System.Drawing.Point(0, 0)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(127, 26)
        Me.Panel24.TabIndex = 24
        '
        'RadLabel_TestParameteres
        '
        Me.RadLabel_TestParameteres.AutoSize = False
        Me.RadLabel_TestParameteres.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_TestParameteres.Location = New System.Drawing.Point(-1, -1)
        Me.RadLabel_TestParameteres.Name = "RadLabel_TestParameteres"
        Me.RadLabel_TestParameteres.Size = New System.Drawing.Size(124, 23)
        Me.RadLabel_TestParameteres.TabIndex = 133
        Me.RadLabel_TestParameteres.Text = "DesignSummary_TestParameteres"
        Me.RadLabel_TestParameteres.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_TestParameteres.TextWrap = False
        Me.RadLabel_TestParameteres.ThemeName = "Windows8"
        '
        'Panel11
        '
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel11.Controls.Add(Me.RadLabel_WindingMaterials)
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(156, 26)
        Me.Panel11.TabIndex = 0
        '
        'RadLabel_WindingMaterials
        '
        Me.RadLabel_WindingMaterials.AutoSize = False
        Me.RadLabel_WindingMaterials.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_WindingMaterials.Location = New System.Drawing.Point(0, 0)
        Me.RadLabel_WindingMaterials.Name = "RadLabel_WindingMaterials"
        Me.RadLabel_WindingMaterials.Size = New System.Drawing.Size(149, 26)
        Me.RadLabel_WindingMaterials.TabIndex = 134
        Me.RadLabel_WindingMaterials.Text = "DesignSummary_WindingMaterials"
        Me.RadLabel_WindingMaterials.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_WindingMaterials.TextWrap = False
        Me.RadLabel_WindingMaterials.ThemeName = "Windows8"
        '
        'Panel12
        '
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel12.Controls.Add(Me.RadLabel_AnodeNone3)
        Me.Panel12.Controls.Add(Me.RadLabel_AnodeNone2)
        Me.Panel12.Controls.Add(Me.RadTextBox5)
        Me.Panel12.Controls.Add(Me.RadTextBox11)
        Me.Panel12.Controls.Add(Me.RadTextBox12)
        Me.Panel12.Controls.Add(Me.RadLabel2)
        Me.Panel12.Controls.Add(Me.RadTextBox13)
        Me.Panel12.Controls.Add(Me.RadLabel3)
        Me.Panel12.Controls.Add(Me.RadTextBox14)
        Me.Panel12.Controls.Add(Me.RadLabel4)
        Me.Panel12.Controls.Add(Me.RadTextBox15)
        Me.Panel12.Controls.Add(Me.RadLabel5)
        Me.Panel12.Controls.Add(Me.RadTextBox16)
        Me.Panel12.Controls.Add(Me.RadTextBox17)
        Me.Panel12.Controls.Add(Me.RadTextBox18)
        Me.Panel12.Controls.Add(Me.RadLabel_03)
        Me.Panel12.Controls.Add(Me.RadTextBox_AnodeCost2)
        Me.Panel12.Controls.Add(Me.RadTextBox_AnodeCost1)
        Me.Panel12.Controls.Add(Me.RadTextBox_AnodeAmount2)
        Me.Panel12.Controls.Add(Me.RadTextBox_AnodeAmount1)
        Me.Panel12.Controls.Add(Me.RadTextBox_AnodeUnitCost2)
        Me.Panel12.Controls.Add(Me.RadTextBox_AnodeUnitCost1)
        Me.Panel12.Controls.Add(Me.RadLabel_AnodeUnitCost2Unit)
        Me.Panel12.Controls.Add(Me.RadLabel_AnodeUnitCost1Unit)
        Me.Panel12.Controls.Add(Me.RadTextBox_AnodeDetail2)
        Me.Panel12.Controls.Add(Me.RadTextBox_AnodeDetail1)
        Me.Panel12.Controls.Add(Me.RadLabel_AnodeDetail2Unit)
        Me.Panel12.Controls.Add(Me.RadLabel_AnodeDetail1Unit)
        Me.Panel12.Controls.Add(Me.RadTextBox_AnodeThick2)
        Me.Panel12.Controls.Add(Me.RadTextBox_AnodeThick1)
        Me.Panel12.Controls.Add(Me.RadLabel_AnodeThick2Unit)
        Me.Panel12.Controls.Add(Me.RadLabel_AnodeThick1Unit)
        Me.Panel12.Controls.Add(Me.RadTextBox_AnodeGain2)
        Me.Panel12.Controls.Add(Me.RadLabel_AnodeGain2Unit)
        Me.Panel12.Controls.Add(Me.RadTextBox_AnodeGain1)
        Me.Panel12.Controls.Add(Me.RadLabel_AnodeGain1Unit)
        Me.Panel12.Controls.Add(Me.RadTextBox_AnodeWidth2)
        Me.Panel12.Controls.Add(Me.RadTextBox_AnodeVoltage2)
        Me.Panel12.Controls.Add(Me.RadTextBox_AnodePartNumber2)
        Me.Panel12.Controls.Add(Me.RadTextBox_AnodeWidth1)
        Me.Panel12.Controls.Add(Me.RadTextBox_AnodeVoltage1)
        Me.Panel12.Controls.Add(Me.RadTextBox_AnodePartNumber1)
        Me.Panel12.Controls.Add(Me.RadLabel_02)
        Me.Panel12.Controls.Add(Me.RadLabel_01)
        Me.Panel12.Controls.Add(Me.Panel13)
        Me.Panel12.Location = New System.Drawing.Point(7, 54)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(937, 128)
        Me.Panel12.TabIndex = 1
        '
        'RadLabel_AnodeNone2
        '
        Me.RadLabel_AnodeNone2.AutoSize = False
        Me.RadLabel_AnodeNone2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_AnodeNone2.Location = New System.Drawing.Point(25, 59)
        Me.RadLabel_AnodeNone2.Name = "RadLabel_AnodeNone2"
        Me.RadLabel_AnodeNone2.Size = New System.Drawing.Size(708, 33)
        Me.RadLabel_AnodeNone2.TabIndex = 65
        Me.RadLabel_AnodeNone2.Text = "DesignSummary_AnodeNone"
        Me.RadLabel_AnodeNone2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_AnodeNone2.ThemeName = "Windows8"
        Me.RadLabel_AnodeNone2.Visible = False
        '
        'RadTextBox5
        '
        Me.RadTextBox5.AutoSize = False
        Me.RadTextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox5.Location = New System.Drawing.Point(660, 92)
        Me.RadTextBox5.Name = "RadTextBox5"
        Me.RadTextBox5.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox5.TabIndex = 171
        Me.RadTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox5.ThemeName = "Windows8"
        '
        'RadTextBox11
        '
        Me.RadTextBox11.AutoSize = False
        Me.RadTextBox11.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox11.Location = New System.Drawing.Point(583, 92)
        Me.RadTextBox11.Name = "RadTextBox11"
        Me.RadTextBox11.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox11.TabIndex = 168
        Me.RadTextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox11.ThemeName = "Windows8"
        '
        'RadTextBox12
        '
        Me.RadTextBox12.AutoSize = False
        Me.RadTextBox12.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox12.Location = New System.Drawing.Point(497, 93)
        Me.RadTextBox12.Name = "RadTextBox12"
        Me.RadTextBox12.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox12.TabIndex = 170
        Me.RadTextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox12.ThemeName = "Windows8"
        '
        'RadLabel2
        '
        Me.RadLabel2.AutoSize = False
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel2.Location = New System.Drawing.Point(548, 92)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(42, 30)
        Me.RadLabel2.TabIndex = 163
        Me.RadLabel2.Text = "Units_PerMeterSquare"
        Me.RadLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel2.TextWrap = False
        Me.RadLabel2.ThemeName = "Windows8"
        '
        'RadTextBox13
        '
        Me.RadTextBox13.AutoSize = False
        Me.RadTextBox13.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox13.Location = New System.Drawing.Point(393, 93)
        Me.RadTextBox13.Name = "RadTextBox13"
        Me.RadTextBox13.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox13.TabIndex = 169
        Me.RadTextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox13.ThemeName = "Windows8"
        '
        'RadLabel3
        '
        Me.RadLabel3.AutoSize = False
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel3.Location = New System.Drawing.Point(444, 93)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(61, 30)
        Me.RadLabel3.TabIndex = 161
        Me.RadLabel3.Text = "Units_MeterSquarePerKilogram"
        Me.RadLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel3.TextWrap = False
        Me.RadLabel3.ThemeName = "Windows8"
        '
        'RadTextBox14
        '
        Me.RadTextBox14.AutoSize = False
        Me.RadTextBox14.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox14.Location = New System.Drawing.Point(325, 93)
        Me.RadTextBox14.Name = "RadTextBox14"
        Me.RadTextBox14.Size = New System.Drawing.Size(41, 29)
        Me.RadTextBox14.TabIndex = 166
        Me.RadTextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox14.ThemeName = "Windows8"
        '
        'RadLabel4
        '
        Me.RadLabel4.AutoSize = False
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel4.Location = New System.Drawing.Point(363, 94)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(42, 30)
        Me.RadLabel4.TabIndex = 159
        Me.RadLabel4.Text = "Units_MicroMeter"
        Me.RadLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel4.TextWrap = False
        Me.RadLabel4.ThemeName = "Windows8"
        '
        'RadTextBox15
        '
        Me.RadTextBox15.AutoSize = False
        Me.RadTextBox15.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox15.Location = New System.Drawing.Point(215, 94)
        Me.RadTextBox15.Name = "RadTextBox15"
        Me.RadTextBox15.Size = New System.Drawing.Size(58, 29)
        Me.RadTextBox15.TabIndex = 167
        Me.RadTextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox15.ThemeName = "Windows8"
        '
        'RadLabel5
        '
        Me.RadLabel5.AutoSize = False
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel5.Location = New System.Drawing.Point(270, 96)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(64, 30)
        Me.RadLabel5.TabIndex = 160
        Me.RadLabel5.Text = "Units_MicroFaradPerSquareCm"
        Me.RadLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel5.TextWrap = False
        Me.RadLabel5.ThemeName = "Windows8"
        '
        'RadTextBox16
        '
        Me.RadTextBox16.AutoSize = False
        Me.RadTextBox16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox16.Location = New System.Drawing.Point(167, 94)
        Me.RadTextBox16.Name = "RadTextBox16"
        Me.RadTextBox16.Size = New System.Drawing.Size(41, 29)
        Me.RadTextBox16.TabIndex = 165
        Me.RadTextBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox16.ThemeName = "Windows8"
        '
        'RadTextBox17
        '
        Me.RadTextBox17.AutoSize = False
        Me.RadTextBox17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox17.Location = New System.Drawing.Point(120, 93)
        Me.RadTextBox17.Name = "RadTextBox17"
        Me.RadTextBox17.Size = New System.Drawing.Size(41, 29)
        Me.RadTextBox17.TabIndex = 164
        Me.RadTextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox17.ThemeName = "Windows8"
        '
        'RadTextBox18
        '
        Me.RadTextBox18.AutoSize = False
        Me.RadTextBox18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox18.Location = New System.Drawing.Point(25, 93)
        Me.RadTextBox18.Name = "RadTextBox18"
        Me.RadTextBox18.Size = New System.Drawing.Size(90, 29)
        Me.RadTextBox18.TabIndex = 162
        Me.RadTextBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox18.ThemeName = "Windows8"
        '
        'RadLabel_03
        '
        Me.RadLabel_03.AutoSize = False
        Me.RadLabel_03.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_03.Location = New System.Drawing.Point(6, 94)
        Me.RadLabel_03.Name = "RadLabel_03"
        Me.RadLabel_03.Size = New System.Drawing.Size(26, 27)
        Me.RadLabel_03.TabIndex = 158
        Me.RadLabel_03.Text = "3"
        Me.RadLabel_03.ThemeName = "Windows8"
        '
        'RadTextBox_AnodeCost2
        '
        Me.RadTextBox_AnodeCost2.AutoSize = False
        Me.RadTextBox_AnodeCost2.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_AnodeCost2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_AnodeCost2.Location = New System.Drawing.Point(660, 60)
        Me.RadTextBox_AnodeCost2.Name = "RadTextBox_AnodeCost2"
        Me.RadTextBox_AnodeCost2.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_AnodeCost2.TabIndex = 157
        Me.RadTextBox_AnodeCost2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_AnodeCost2.ThemeName = "Windows8"
        '
        'RadTextBox_AnodeCost1
        '
        Me.RadTextBox_AnodeCost1.AutoSize = False
        Me.RadTextBox_AnodeCost1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_AnodeCost1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_AnodeCost1.Location = New System.Drawing.Point(660, 29)
        Me.RadTextBox_AnodeCost1.Name = "RadTextBox_AnodeCost1"
        Me.RadTextBox_AnodeCost1.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_AnodeCost1.TabIndex = 156
        Me.RadTextBox_AnodeCost1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_AnodeCost1.ThemeName = "Windows8"
        '
        'RadTextBox_AnodeAmount2
        '
        Me.RadTextBox_AnodeAmount2.AutoSize = False
        Me.RadTextBox_AnodeAmount2.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_AnodeAmount2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_AnodeAmount2.Location = New System.Drawing.Point(583, 60)
        Me.RadTextBox_AnodeAmount2.Name = "RadTextBox_AnodeAmount2"
        Me.RadTextBox_AnodeAmount2.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_AnodeAmount2.TabIndex = 155
        Me.RadTextBox_AnodeAmount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_AnodeAmount2.ThemeName = "Windows8"
        '
        'RadTextBox_AnodeAmount1
        '
        Me.RadTextBox_AnodeAmount1.AutoSize = False
        Me.RadTextBox_AnodeAmount1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_AnodeAmount1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_AnodeAmount1.Location = New System.Drawing.Point(583, 29)
        Me.RadTextBox_AnodeAmount1.Name = "RadTextBox_AnodeAmount1"
        Me.RadTextBox_AnodeAmount1.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_AnodeAmount1.TabIndex = 154
        Me.RadTextBox_AnodeAmount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_AnodeAmount1.ThemeName = "Windows8"
        '
        'RadTextBox_AnodeUnitCost2
        '
        Me.RadTextBox_AnodeUnitCost2.AutoSize = False
        Me.RadTextBox_AnodeUnitCost2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_AnodeUnitCost2.Location = New System.Drawing.Point(497, 61)
        Me.RadTextBox_AnodeUnitCost2.Name = "RadTextBox_AnodeUnitCost2"
        Me.RadTextBox_AnodeUnitCost2.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_AnodeUnitCost2.TabIndex = 156
        Me.RadTextBox_AnodeUnitCost2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_AnodeUnitCost2.ThemeName = "Windows8"
        '
        'RadTextBox_AnodeUnitCost1
        '
        Me.RadTextBox_AnodeUnitCost1.AutoSize = False
        Me.RadTextBox_AnodeUnitCost1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_AnodeUnitCost1.Location = New System.Drawing.Point(497, 30)
        Me.RadTextBox_AnodeUnitCost1.Name = "RadTextBox_AnodeUnitCost1"
        Me.RadTextBox_AnodeUnitCost1.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_AnodeUnitCost1.TabIndex = 155
        Me.RadTextBox_AnodeUnitCost1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_AnodeUnitCost1.ThemeName = "Windows8"
        '
        'RadLabel_AnodeUnitCost2Unit
        '
        Me.RadLabel_AnodeUnitCost2Unit.AutoSize = False
        Me.RadLabel_AnodeUnitCost2Unit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_AnodeUnitCost2Unit.Location = New System.Drawing.Point(548, 60)
        Me.RadLabel_AnodeUnitCost2Unit.Name = "RadLabel_AnodeUnitCost2Unit"
        Me.RadLabel_AnodeUnitCost2Unit.Size = New System.Drawing.Size(42, 30)
        Me.RadLabel_AnodeUnitCost2Unit.TabIndex = 152
        Me.RadLabel_AnodeUnitCost2Unit.Text = "Units_PerMeterSquare"
        Me.RadLabel_AnodeUnitCost2Unit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_AnodeUnitCost2Unit.TextWrap = False
        Me.RadLabel_AnodeUnitCost2Unit.ThemeName = "Windows8"
        '
        'RadLabel_AnodeUnitCost1Unit
        '
        Me.RadLabel_AnodeUnitCost1Unit.AutoSize = False
        Me.RadLabel_AnodeUnitCost1Unit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_AnodeUnitCost1Unit.Location = New System.Drawing.Point(548, 29)
        Me.RadLabel_AnodeUnitCost1Unit.Name = "RadLabel_AnodeUnitCost1Unit"
        Me.RadLabel_AnodeUnitCost1Unit.Size = New System.Drawing.Size(42, 30)
        Me.RadLabel_AnodeUnitCost1Unit.TabIndex = 151
        Me.RadLabel_AnodeUnitCost1Unit.Text = "Units_PerMeterSquare"
        Me.RadLabel_AnodeUnitCost1Unit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_AnodeUnitCost1Unit.TextWrap = False
        Me.RadLabel_AnodeUnitCost1Unit.ThemeName = "Windows8"
        '
        'RadTextBox_AnodeDetail2
        '
        Me.RadTextBox_AnodeDetail2.AutoSize = False
        Me.RadTextBox_AnodeDetail2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_AnodeDetail2.Location = New System.Drawing.Point(393, 61)
        Me.RadTextBox_AnodeDetail2.Name = "RadTextBox_AnodeDetail2"
        Me.RadTextBox_AnodeDetail2.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_AnodeDetail2.TabIndex = 155
        Me.RadTextBox_AnodeDetail2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_AnodeDetail2.ThemeName = "Windows8"
        '
        'RadTextBox_AnodeDetail1
        '
        Me.RadTextBox_AnodeDetail1.AutoSize = False
        Me.RadTextBox_AnodeDetail1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_AnodeDetail1.Location = New System.Drawing.Point(393, 30)
        Me.RadTextBox_AnodeDetail1.Name = "RadTextBox_AnodeDetail1"
        Me.RadTextBox_AnodeDetail1.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_AnodeDetail1.TabIndex = 154
        Me.RadTextBox_AnodeDetail1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_AnodeDetail1.ThemeName = "Windows8"
        '
        'RadLabel_AnodeDetail2Unit
        '
        Me.RadLabel_AnodeDetail2Unit.AutoSize = False
        Me.RadLabel_AnodeDetail2Unit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_AnodeDetail2Unit.Location = New System.Drawing.Point(444, 61)
        Me.RadLabel_AnodeDetail2Unit.Name = "RadLabel_AnodeDetail2Unit"
        Me.RadLabel_AnodeDetail2Unit.Size = New System.Drawing.Size(61, 30)
        Me.RadLabel_AnodeDetail2Unit.TabIndex = 151
        Me.RadLabel_AnodeDetail2Unit.Text = "Units_MeterSquarePerKilogram"
        Me.RadLabel_AnodeDetail2Unit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_AnodeDetail2Unit.TextWrap = False
        Me.RadLabel_AnodeDetail2Unit.ThemeName = "Windows8"
        '
        'RadLabel_AnodeDetail1Unit
        '
        Me.RadLabel_AnodeDetail1Unit.AutoSize = False
        Me.RadLabel_AnodeDetail1Unit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_AnodeDetail1Unit.Location = New System.Drawing.Point(444, 30)
        Me.RadLabel_AnodeDetail1Unit.Name = "RadLabel_AnodeDetail1Unit"
        Me.RadLabel_AnodeDetail1Unit.Size = New System.Drawing.Size(61, 30)
        Me.RadLabel_AnodeDetail1Unit.TabIndex = 150
        Me.RadLabel_AnodeDetail1Unit.Text = "Units_MeterSquarePerKilogram"
        Me.RadLabel_AnodeDetail1Unit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_AnodeDetail1Unit.TextWrap = False
        Me.RadLabel_AnodeDetail1Unit.ThemeName = "Windows8"
        '
        'RadTextBox_AnodeThick2
        '
        Me.RadTextBox_AnodeThick2.AutoSize = False
        Me.RadTextBox_AnodeThick2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_AnodeThick2.Location = New System.Drawing.Point(325, 61)
        Me.RadTextBox_AnodeThick2.Name = "RadTextBox_AnodeThick2"
        Me.RadTextBox_AnodeThick2.Size = New System.Drawing.Size(41, 29)
        Me.RadTextBox_AnodeThick2.TabIndex = 154
        Me.RadTextBox_AnodeThick2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_AnodeThick2.ThemeName = "Windows8"
        '
        'RadTextBox_AnodeThick1
        '
        Me.RadTextBox_AnodeThick1.AutoSize = False
        Me.RadTextBox_AnodeThick1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_AnodeThick1.Location = New System.Drawing.Point(325, 30)
        Me.RadTextBox_AnodeThick1.Name = "RadTextBox_AnodeThick1"
        Me.RadTextBox_AnodeThick1.Size = New System.Drawing.Size(41, 29)
        Me.RadTextBox_AnodeThick1.TabIndex = 153
        Me.RadTextBox_AnodeThick1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_AnodeThick1.ThemeName = "Windows8"
        '
        'RadLabel_AnodeThick2Unit
        '
        Me.RadLabel_AnodeThick2Unit.AutoSize = False
        Me.RadLabel_AnodeThick2Unit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_AnodeThick2Unit.Location = New System.Drawing.Point(363, 62)
        Me.RadLabel_AnodeThick2Unit.Name = "RadLabel_AnodeThick2Unit"
        Me.RadLabel_AnodeThick2Unit.Size = New System.Drawing.Size(42, 30)
        Me.RadLabel_AnodeThick2Unit.TabIndex = 149
        Me.RadLabel_AnodeThick2Unit.Text = "Units_MicroMeter"
        Me.RadLabel_AnodeThick2Unit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_AnodeThick2Unit.TextWrap = False
        Me.RadLabel_AnodeThick2Unit.ThemeName = "Windows8"
        '
        'RadLabel_AnodeThick1Unit
        '
        Me.RadLabel_AnodeThick1Unit.AutoSize = False
        Me.RadLabel_AnodeThick1Unit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_AnodeThick1Unit.Location = New System.Drawing.Point(363, 31)
        Me.RadLabel_AnodeThick1Unit.Name = "RadLabel_AnodeThick1Unit"
        Me.RadLabel_AnodeThick1Unit.Size = New System.Drawing.Size(42, 30)
        Me.RadLabel_AnodeThick1Unit.TabIndex = 148
        Me.RadLabel_AnodeThick1Unit.Text = "Units_MicroMeter"
        Me.RadLabel_AnodeThick1Unit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_AnodeThick1Unit.TextWrap = False
        Me.RadLabel_AnodeThick1Unit.ThemeName = "Windows8"
        '
        'RadTextBox_AnodeGain2
        '
        Me.RadTextBox_AnodeGain2.AutoSize = False
        Me.RadTextBox_AnodeGain2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_AnodeGain2.Location = New System.Drawing.Point(215, 62)
        Me.RadTextBox_AnodeGain2.Name = "RadTextBox_AnodeGain2"
        Me.RadTextBox_AnodeGain2.Size = New System.Drawing.Size(58, 29)
        Me.RadTextBox_AnodeGain2.TabIndex = 154
        Me.RadTextBox_AnodeGain2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_AnodeGain2.ThemeName = "Windows8"
        '
        'RadLabel_AnodeGain2Unit
        '
        Me.RadLabel_AnodeGain2Unit.AutoSize = False
        Me.RadLabel_AnodeGain2Unit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_AnodeGain2Unit.Location = New System.Drawing.Point(270, 64)
        Me.RadLabel_AnodeGain2Unit.Name = "RadLabel_AnodeGain2Unit"
        Me.RadLabel_AnodeGain2Unit.Size = New System.Drawing.Size(64, 30)
        Me.RadLabel_AnodeGain2Unit.TabIndex = 150
        Me.RadLabel_AnodeGain2Unit.Text = "Units_MicroFaradPerSquareCm"
        Me.RadLabel_AnodeGain2Unit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_AnodeGain2Unit.TextWrap = False
        Me.RadLabel_AnodeGain2Unit.ThemeName = "Windows8"
        '
        'RadTextBox_AnodeGain1
        '
        Me.RadTextBox_AnodeGain1.AutoSize = False
        Me.RadTextBox_AnodeGain1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_AnodeGain1.Location = New System.Drawing.Point(215, 31)
        Me.RadTextBox_AnodeGain1.Name = "RadTextBox_AnodeGain1"
        Me.RadTextBox_AnodeGain1.Size = New System.Drawing.Size(58, 29)
        Me.RadTextBox_AnodeGain1.TabIndex = 153
        Me.RadTextBox_AnodeGain1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_AnodeGain1.ThemeName = "Windows8"
        '
        'RadLabel_AnodeGain1Unit
        '
        Me.RadLabel_AnodeGain1Unit.AutoSize = False
        Me.RadLabel_AnodeGain1Unit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_AnodeGain1Unit.Location = New System.Drawing.Point(270, 30)
        Me.RadLabel_AnodeGain1Unit.Name = "RadLabel_AnodeGain1Unit"
        Me.RadLabel_AnodeGain1Unit.Size = New System.Drawing.Size(64, 30)
        Me.RadLabel_AnodeGain1Unit.TabIndex = 149
        Me.RadLabel_AnodeGain1Unit.Text = "Units_MicroFaradPerSquareCm"
        Me.RadLabel_AnodeGain1Unit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_AnodeGain1Unit.TextWrap = False
        Me.RadLabel_AnodeGain1Unit.ThemeName = "Windows8"
        '
        'RadTextBox_AnodeWidth2
        '
        Me.RadTextBox_AnodeWidth2.AutoSize = False
        Me.RadTextBox_AnodeWidth2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_AnodeWidth2.Location = New System.Drawing.Point(167, 62)
        Me.RadTextBox_AnodeWidth2.Name = "RadTextBox_AnodeWidth2"
        Me.RadTextBox_AnodeWidth2.Size = New System.Drawing.Size(41, 29)
        Me.RadTextBox_AnodeWidth2.TabIndex = 153
        Me.RadTextBox_AnodeWidth2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_AnodeWidth2.ThemeName = "Windows8"
        '
        'RadTextBox_AnodeVoltage2
        '
        Me.RadTextBox_AnodeVoltage2.AutoSize = False
        Me.RadTextBox_AnodeVoltage2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_AnodeVoltage2.Location = New System.Drawing.Point(120, 61)
        Me.RadTextBox_AnodeVoltage2.Name = "RadTextBox_AnodeVoltage2"
        Me.RadTextBox_AnodeVoltage2.Size = New System.Drawing.Size(41, 29)
        Me.RadTextBox_AnodeVoltage2.TabIndex = 152
        Me.RadTextBox_AnodeVoltage2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_AnodeVoltage2.ThemeName = "Windows8"
        '
        'RadTextBox_AnodePartNumber2
        '
        Me.RadTextBox_AnodePartNumber2.AutoSize = False
        Me.RadTextBox_AnodePartNumber2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_AnodePartNumber2.Location = New System.Drawing.Point(25, 61)
        Me.RadTextBox_AnodePartNumber2.Name = "RadTextBox_AnodePartNumber2"
        Me.RadTextBox_AnodePartNumber2.Size = New System.Drawing.Size(90, 29)
        Me.RadTextBox_AnodePartNumber2.TabIndex = 151
        Me.RadTextBox_AnodePartNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_AnodePartNumber2.ThemeName = "Windows8"
        '
        'RadTextBox_AnodeWidth1
        '
        Me.RadTextBox_AnodeWidth1.AutoSize = False
        Me.RadTextBox_AnodeWidth1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_AnodeWidth1.Location = New System.Drawing.Point(167, 31)
        Me.RadTextBox_AnodeWidth1.Name = "RadTextBox_AnodeWidth1"
        Me.RadTextBox_AnodeWidth1.Size = New System.Drawing.Size(41, 29)
        Me.RadTextBox_AnodeWidth1.TabIndex = 152
        Me.RadTextBox_AnodeWidth1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_AnodeWidth1.ThemeName = "Windows8"
        '
        'RadTextBox_AnodeVoltage1
        '
        Me.RadTextBox_AnodeVoltage1.AutoSize = False
        Me.RadTextBox_AnodeVoltage1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_AnodeVoltage1.Location = New System.Drawing.Point(120, 30)
        Me.RadTextBox_AnodeVoltage1.Name = "RadTextBox_AnodeVoltage1"
        Me.RadTextBox_AnodeVoltage1.Size = New System.Drawing.Size(41, 29)
        Me.RadTextBox_AnodeVoltage1.TabIndex = 151
        Me.RadTextBox_AnodeVoltage1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_AnodeVoltage1.ThemeName = "Windows8"
        '
        'RadTextBox_AnodePartNumber1
        '
        Me.RadTextBox_AnodePartNumber1.AutoSize = False
        Me.RadTextBox_AnodePartNumber1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_AnodePartNumber1.Location = New System.Drawing.Point(25, 30)
        Me.RadTextBox_AnodePartNumber1.Name = "RadTextBox_AnodePartNumber1"
        Me.RadTextBox_AnodePartNumber1.Size = New System.Drawing.Size(90, 29)
        Me.RadTextBox_AnodePartNumber1.TabIndex = 150
        Me.RadTextBox_AnodePartNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_AnodePartNumber1.ThemeName = "Windows8"
        '
        'RadLabel_02
        '
        Me.RadLabel_02.AutoSize = False
        Me.RadLabel_02.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_02.Location = New System.Drawing.Point(5, 62)
        Me.RadLabel_02.Name = "RadLabel_02"
        Me.RadLabel_02.Size = New System.Drawing.Size(26, 27)
        Me.RadLabel_02.TabIndex = 37
        Me.RadLabel_02.Text = "2"
        Me.RadLabel_02.ThemeName = "Windows8"
        '
        'RadLabel_01
        '
        Me.RadLabel_01.AutoSize = False
        Me.RadLabel_01.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_01.Location = New System.Drawing.Point(5, 31)
        Me.RadLabel_01.Name = "RadLabel_01"
        Me.RadLabel_01.Size = New System.Drawing.Size(26, 28)
        Me.RadLabel_01.TabIndex = 23
        Me.RadLabel_01.Text = "1"
        Me.RadLabel_01.ThemeName = "Windows8"
        '
        'Panel13
        '
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel13.Controls.Add(Me.RadLabel_Anodes)
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(76, 26)
        Me.Panel13.TabIndex = 22
        '
        'RadLabel_Anodes
        '
        Me.RadLabel_Anodes.AutoSize = False
        Me.RadLabel_Anodes.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Anodes.Location = New System.Drawing.Point(0, 0)
        Me.RadLabel_Anodes.Name = "RadLabel_Anodes"
        Me.RadLabel_Anodes.Size = New System.Drawing.Size(71, 23)
        Me.RadLabel_Anodes.TabIndex = 135
        Me.RadLabel_Anodes.Text = "DesignSummary_Anodes"
        Me.RadLabel_Anodes.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Anodes.TextWrap = False
        Me.RadLabel_Anodes.ThemeName = "Windows8"
        '
        'Panel14
        '
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel14.Controls.Add(Me.RadTextBox_AnodeLenGain2)
        Me.Panel14.Controls.Add(Me.RadTextBox_AnodeLenGain1)
        Me.Panel14.Controls.Add(Me.RadLabel_AnodeLenGain2Unit)
        Me.Panel14.Controls.Add(Me.RadLabel_AnodeLenGain1Unit)
        Me.Panel14.Controls.Add(Me.RadLabel_AnodeLen2Unit)
        Me.Panel14.Controls.Add(Me.RadLabel_AnodeLen1Unit)
        Me.Panel14.Controls.Add(Me.RadTextBox_AnodeLen2)
        Me.Panel14.Controls.Add(Me.RadTextBox_AnodeLen1)
        Me.Panel14.Location = New System.Drawing.Point(746, 54)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(207, 100)
        Me.Panel14.TabIndex = 37
        '
        'RadTextBox_AnodeLenGain2
        '
        Me.RadTextBox_AnodeLenGain2.AutoSize = False
        Me.RadTextBox_AnodeLenGain2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_AnodeLenGain2.Location = New System.Drawing.Point(91, 60)
        Me.RadTextBox_AnodeLenGain2.Name = "RadTextBox_AnodeLenGain2"
        Me.RadTextBox_AnodeLenGain2.Size = New System.Drawing.Size(58, 29)
        Me.RadTextBox_AnodeLenGain2.TabIndex = 150
        Me.RadTextBox_AnodeLenGain2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_AnodeLenGain2.ThemeName = "Windows8"
        '
        'RadTextBox_AnodeLenGain1
        '
        Me.RadTextBox_AnodeLenGain1.AutoSize = False
        Me.RadTextBox_AnodeLenGain1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_AnodeLenGain1.Location = New System.Drawing.Point(91, 29)
        Me.RadTextBox_AnodeLenGain1.Name = "RadTextBox_AnodeLenGain1"
        Me.RadTextBox_AnodeLenGain1.Size = New System.Drawing.Size(58, 29)
        Me.RadTextBox_AnodeLenGain1.TabIndex = 149
        Me.RadTextBox_AnodeLenGain1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_AnodeLenGain1.ThemeName = "Windows8"
        '
        'RadLabel_AnodeLenGain2Unit
        '
        Me.RadLabel_AnodeLenGain2Unit.AutoSize = False
        Me.RadLabel_AnodeLenGain2Unit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_AnodeLenGain2Unit.Location = New System.Drawing.Point(145, 61)
        Me.RadLabel_AnodeLenGain2Unit.Name = "RadLabel_AnodeLenGain2Unit"
        Me.RadLabel_AnodeLenGain2Unit.Size = New System.Drawing.Size(69, 30)
        Me.RadLabel_AnodeLenGain2Unit.TabIndex = 149
        Me.RadLabel_AnodeLenGain2Unit.Text = "UniMicroFaradPerCm"
        Me.RadLabel_AnodeLenGain2Unit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_AnodeLenGain2Unit.TextWrap = False
        Me.RadLabel_AnodeLenGain2Unit.ThemeName = "Windows8"
        '
        'RadLabel_AnodeLenGain1Unit
        '
        Me.RadLabel_AnodeLenGain1Unit.AutoSize = False
        Me.RadLabel_AnodeLenGain1Unit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_AnodeLenGain1Unit.Location = New System.Drawing.Point(145, 30)
        Me.RadLabel_AnodeLenGain1Unit.Name = "RadLabel_AnodeLenGain1Unit"
        Me.RadLabel_AnodeLenGain1Unit.Size = New System.Drawing.Size(69, 30)
        Me.RadLabel_AnodeLenGain1Unit.TabIndex = 148
        Me.RadLabel_AnodeLenGain1Unit.Text = "UniMicroFaradPerCm"
        Me.RadLabel_AnodeLenGain1Unit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_AnodeLenGain1Unit.TextWrap = False
        Me.RadLabel_AnodeLenGain1Unit.ThemeName = "Windows8"
        '
        'RadLabel_AnodeLen2Unit
        '
        Me.RadLabel_AnodeLen2Unit.AutoSize = False
        Me.RadLabel_AnodeLen2Unit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_AnodeLen2Unit.Location = New System.Drawing.Point(53, 60)
        Me.RadLabel_AnodeLen2Unit.Name = "RadLabel_AnodeLen2Unit"
        Me.RadLabel_AnodeLen2Unit.Size = New System.Drawing.Size(42, 29)
        Me.RadLabel_AnodeLen2Unit.TabIndex = 148
        Me.RadLabel_AnodeLen2Unit.Text = "Units_Mm"
        Me.RadLabel_AnodeLen2Unit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_AnodeLen2Unit.TextWrap = False
        Me.RadLabel_AnodeLen2Unit.ThemeName = "Windows8"
        '
        'RadLabel_AnodeLen1Unit
        '
        Me.RadLabel_AnodeLen1Unit.AutoSize = False
        Me.RadLabel_AnodeLen1Unit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_AnodeLen1Unit.Location = New System.Drawing.Point(53, 29)
        Me.RadLabel_AnodeLen1Unit.Name = "RadLabel_AnodeLen1Unit"
        Me.RadLabel_AnodeLen1Unit.Size = New System.Drawing.Size(42, 29)
        Me.RadLabel_AnodeLen1Unit.TabIndex = 147
        Me.RadLabel_AnodeLen1Unit.Text = "Units_Mm"
        Me.RadLabel_AnodeLen1Unit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_AnodeLen1Unit.TextWrap = False
        Me.RadLabel_AnodeLen1Unit.ThemeName = "Windows8"
        '
        'RadTextBox_AnodeLen2
        '
        Me.RadTextBox_AnodeLen2.AutoSize = False
        Me.RadTextBox_AnodeLen2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_AnodeLen2.Location = New System.Drawing.Point(5, 60)
        Me.RadTextBox_AnodeLen2.Name = "RadTextBox_AnodeLen2"
        Me.RadTextBox_AnodeLen2.Size = New System.Drawing.Size(50, 29)
        Me.RadTextBox_AnodeLen2.TabIndex = 149
        Me.RadTextBox_AnodeLen2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_AnodeLen2.ThemeName = "Windows8"
        '
        'RadTextBox_AnodeLen1
        '
        Me.RadTextBox_AnodeLen1.AutoSize = False
        Me.RadTextBox_AnodeLen1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_AnodeLen1.Location = New System.Drawing.Point(5, 29)
        Me.RadTextBox_AnodeLen1.Name = "RadTextBox_AnodeLen1"
        Me.RadTextBox_AnodeLen1.Size = New System.Drawing.Size(50, 29)
        Me.RadTextBox_AnodeLen1.TabIndex = 148
        Me.RadTextBox_AnodeLen1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_AnodeLen1.ThemeName = "Windows8"
        '
        'RadLabel_Cath
        '
        Me.RadLabel_Cath.AutoSize = False
        Me.RadLabel_Cath.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Cath.Location = New System.Drawing.Point(14, 188)
        Me.RadLabel_Cath.Name = "RadLabel_Cath"
        Me.RadLabel_Cath.Size = New System.Drawing.Size(49, 27)
        Me.RadLabel_Cath.TabIndex = 51
        Me.RadLabel_Cath.Text = "DesignSummary_Cath"
        Me.RadLabel_Cath.ThemeName = "Windows8"
        '
        'Panel16
        '
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel16.Controls.Add(Me.RadDropDownList_TissuePart3)
        Me.Panel16.Controls.Add(Me.RadDropDownList_TissuePart2)
        Me.Panel16.Controls.Add(Me.RadDropDownList_TissuePart1)
        Me.Panel16.Controls.Add(Me.RadTextBox_TissueCost3)
        Me.Panel16.Controls.Add(Me.RadTextBox_TissueCost2)
        Me.Panel16.Controls.Add(Me.RadTextBox_TissueAmount3)
        Me.Panel16.Controls.Add(Me.RadTextBox_TissueAmount2)
        Me.Panel16.Controls.Add(Me.RadTextBox_TissueUnitCost3)
        Me.Panel16.Controls.Add(Me.RadTextBox_TissueUnitCost2)
        Me.Panel16.Controls.Add(Me.RadTextBox_TissueCost1)
        Me.Panel16.Controls.Add(Me.RadTextBox_TissueUnitCost1)
        Me.Panel16.Controls.Add(Me.RadTextBox_TissueAmount1)
        Me.Panel16.Controls.Add(Me.RadLabel_TissueUnitCost3Unit)
        Me.Panel16.Controls.Add(Me.RadLabel_TissueUnitCost2Unit)
        Me.Panel16.Controls.Add(Me.RadLabel_TissueUnitCost1Unit)
        Me.Panel16.Controls.Add(Me.RadTextBox_TissueDetail1)
        Me.Panel16.Controls.Add(Me.RadTextBox_TissueDetail2)
        Me.Panel16.Controls.Add(Me.RadTextBox_TabDetail)
        Me.Panel16.Controls.Add(Me.RadLabel_TissueDetail3Unit)
        Me.Panel16.Controls.Add(Me.RadLabel_TissueDetail2Unit)
        Me.Panel16.Controls.Add(Me.RadLabel_TissueDetail1Unit)
        Me.Panel16.Controls.Add(Me.RadTextBox_TissueThick3)
        Me.Panel16.Controls.Add(Me.RadTextBox_TissueThick2)
        Me.Panel16.Controls.Add(Me.RadTextBox_TissueThick1)
        Me.Panel16.Controls.Add(Me.RadLabel_TissueThick3Unit)
        Me.Panel16.Controls.Add(Me.RadLabel_TissueThick2Unit)
        Me.Panel16.Controls.Add(Me.RadLabel_TissueThick1Unit)
        Me.Panel16.Controls.Add(Me.RadTextBox_TissueWidth3)
        Me.Panel16.Controls.Add(Me.RadTextBox_TissueWidth2)
        Me.Panel16.Controls.Add(Me.RadTextBox_TissueWidth1)
        Me.Panel16.Controls.Add(Me.RadLabel_13)
        Me.Panel16.Controls.Add(Me.RadLabel_12)
        Me.Panel16.Controls.Add(Me.RadLabel_11)
        Me.Panel16.Controls.Add(Me.Panel17)
        Me.Panel16.Location = New System.Drawing.Point(7, 219)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(744, 126)
        Me.Panel16.TabIndex = 65
        '
        'RadDropDownList_TissuePart3
        '
        Me.RadDropDownList_TissuePart3.AutoSize = False
        Me.RadDropDownList_TissuePart3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_TissuePart3.Location = New System.Drawing.Point(25, 91)
        Me.RadDropDownList_TissuePart3.Name = "RadDropDownList_TissuePart3"
        Me.RadDropDownList_TissuePart3.Size = New System.Drawing.Size(90, 29)
        Me.RadDropDownList_TissuePart3.TabIndex = 168
        Me.RadDropDownList_TissuePart3.ThemeName = "Windows8"
        '
        'RadDropDownList_TissuePart2
        '
        Me.RadDropDownList_TissuePart2.AutoSize = False
        Me.RadDropDownList_TissuePart2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_TissuePart2.Location = New System.Drawing.Point(25, 59)
        Me.RadDropDownList_TissuePart2.Name = "RadDropDownList_TissuePart2"
        Me.RadDropDownList_TissuePart2.Size = New System.Drawing.Size(90, 29)
        Me.RadDropDownList_TissuePart2.TabIndex = 167
        Me.RadDropDownList_TissuePart2.ThemeName = "Windows8"
        '
        'RadDropDownList_TissuePart1
        '
        Me.RadDropDownList_TissuePart1.AutoSize = False
        Me.RadDropDownList_TissuePart1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_TissuePart1.Location = New System.Drawing.Point(25, 27)
        Me.RadDropDownList_TissuePart1.Name = "RadDropDownList_TissuePart1"
        Me.RadDropDownList_TissuePart1.Size = New System.Drawing.Size(90, 29)
        Me.RadDropDownList_TissuePart1.TabIndex = 166
        Me.RadDropDownList_TissuePart1.ThemeName = "Windows8"
        '
        'RadTextBox_TissueCost3
        '
        Me.RadTextBox_TissueCost3.AutoSize = False
        Me.RadTextBox_TissueCost3.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_TissueCost3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_TissueCost3.Location = New System.Drawing.Point(660, 90)
        Me.RadTextBox_TissueCost3.Name = "RadTextBox_TissueCost3"
        Me.RadTextBox_TissueCost3.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_TissueCost3.TabIndex = 159
        Me.RadTextBox_TissueCost3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TissueCost3.ThemeName = "Windows8"
        '
        'RadTextBox_TissueCost2
        '
        Me.RadTextBox_TissueCost2.AutoSize = False
        Me.RadTextBox_TissueCost2.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_TissueCost2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_TissueCost2.Location = New System.Drawing.Point(660, 58)
        Me.RadTextBox_TissueCost2.Name = "RadTextBox_TissueCost2"
        Me.RadTextBox_TissueCost2.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_TissueCost2.TabIndex = 163
        Me.RadTextBox_TissueCost2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TissueCost2.ThemeName = "Windows8"
        '
        'RadTextBox_TissueAmount3
        '
        Me.RadTextBox_TissueAmount3.AutoSize = False
        Me.RadTextBox_TissueAmount3.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_TissueAmount3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_TissueAmount3.Location = New System.Drawing.Point(583, 90)
        Me.RadTextBox_TissueAmount3.Name = "RadTextBox_TissueAmount3"
        Me.RadTextBox_TissueAmount3.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_TissueAmount3.TabIndex = 158
        Me.RadTextBox_TissueAmount3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TissueAmount3.ThemeName = "Windows8"
        '
        'RadTextBox_TissueAmount2
        '
        Me.RadTextBox_TissueAmount2.AutoSize = False
        Me.RadTextBox_TissueAmount2.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_TissueAmount2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_TissueAmount2.Location = New System.Drawing.Point(583, 58)
        Me.RadTextBox_TissueAmount2.Name = "RadTextBox_TissueAmount2"
        Me.RadTextBox_TissueAmount2.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_TissueAmount2.TabIndex = 162
        Me.RadTextBox_TissueAmount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TissueAmount2.ThemeName = "Windows8"
        '
        'RadTextBox_TissueUnitCost3
        '
        Me.RadTextBox_TissueUnitCost3.AutoSize = False
        Me.RadTextBox_TissueUnitCost3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_TissueUnitCost3.Location = New System.Drawing.Point(497, 91)
        Me.RadTextBox_TissueUnitCost3.Name = "RadTextBox_TissueUnitCost3"
        Me.RadTextBox_TissueUnitCost3.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_TissueUnitCost3.TabIndex = 160
        Me.RadTextBox_TissueUnitCost3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TissueUnitCost3.ThemeName = "Windows8"
        '
        'RadTextBox_TissueUnitCost2
        '
        Me.RadTextBox_TissueUnitCost2.AutoSize = False
        Me.RadTextBox_TissueUnitCost2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_TissueUnitCost2.Location = New System.Drawing.Point(497, 59)
        Me.RadTextBox_TissueUnitCost2.Name = "RadTextBox_TissueUnitCost2"
        Me.RadTextBox_TissueUnitCost2.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_TissueUnitCost2.TabIndex = 159
        Me.RadTextBox_TissueUnitCost2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TissueUnitCost2.ThemeName = "Windows8"
        '
        'RadTextBox_TissueCost1
        '
        Me.RadTextBox_TissueCost1.AutoSize = False
        Me.RadTextBox_TissueCost1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_TissueCost1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_TissueCost1.Location = New System.Drawing.Point(660, 26)
        Me.RadTextBox_TissueCost1.Name = "RadTextBox_TissueCost1"
        Me.RadTextBox_TissueCost1.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_TissueCost1.TabIndex = 161
        Me.RadTextBox_TissueCost1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TissueCost1.ThemeName = "Windows8"
        '
        'RadTextBox_TissueUnitCost1
        '
        Me.RadTextBox_TissueUnitCost1.AutoSize = False
        Me.RadTextBox_TissueUnitCost1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_TissueUnitCost1.Location = New System.Drawing.Point(497, 27)
        Me.RadTextBox_TissueUnitCost1.Name = "RadTextBox_TissueUnitCost1"
        Me.RadTextBox_TissueUnitCost1.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_TissueUnitCost1.TabIndex = 158
        Me.RadTextBox_TissueUnitCost1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TissueUnitCost1.ThemeName = "Windows8"
        '
        'RadTextBox_TissueAmount1
        '
        Me.RadTextBox_TissueAmount1.AutoSize = False
        Me.RadTextBox_TissueAmount1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_TissueAmount1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_TissueAmount1.Location = New System.Drawing.Point(583, 26)
        Me.RadTextBox_TissueAmount1.Name = "RadTextBox_TissueAmount1"
        Me.RadTextBox_TissueAmount1.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_TissueAmount1.TabIndex = 160
        Me.RadTextBox_TissueAmount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TissueAmount1.ThemeName = "Windows8"
        '
        'RadLabel_TissueUnitCost3Unit
        '
        Me.RadLabel_TissueUnitCost3Unit.AutoSize = False
        Me.RadLabel_TissueUnitCost3Unit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_TissueUnitCost3Unit.Location = New System.Drawing.Point(548, 90)
        Me.RadLabel_TissueUnitCost3Unit.Name = "RadLabel_TissueUnitCost3Unit"
        Me.RadLabel_TissueUnitCost3Unit.Size = New System.Drawing.Size(42, 30)
        Me.RadLabel_TissueUnitCost3Unit.TabIndex = 154
        Me.RadLabel_TissueUnitCost3Unit.Text = "Units_PerKg"
        Me.RadLabel_TissueUnitCost3Unit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_TissueUnitCost3Unit.TextWrap = False
        Me.RadLabel_TissueUnitCost3Unit.ThemeName = "Windows8"
        '
        'RadLabel_TissueUnitCost2Unit
        '
        Me.RadLabel_TissueUnitCost2Unit.AutoSize = False
        Me.RadLabel_TissueUnitCost2Unit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_TissueUnitCost2Unit.Location = New System.Drawing.Point(548, 58)
        Me.RadLabel_TissueUnitCost2Unit.Name = "RadLabel_TissueUnitCost2Unit"
        Me.RadLabel_TissueUnitCost2Unit.Size = New System.Drawing.Size(42, 30)
        Me.RadLabel_TissueUnitCost2Unit.TabIndex = 155
        Me.RadLabel_TissueUnitCost2Unit.Text = "Units_PerKg"
        Me.RadLabel_TissueUnitCost2Unit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_TissueUnitCost2Unit.TextWrap = False
        Me.RadLabel_TissueUnitCost2Unit.ThemeName = "Windows8"
        '
        'RadLabel_TissueUnitCost1Unit
        '
        Me.RadLabel_TissueUnitCost1Unit.AutoSize = False
        Me.RadLabel_TissueUnitCost1Unit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_TissueUnitCost1Unit.Location = New System.Drawing.Point(548, 26)
        Me.RadLabel_TissueUnitCost1Unit.Name = "RadLabel_TissueUnitCost1Unit"
        Me.RadLabel_TissueUnitCost1Unit.Size = New System.Drawing.Size(42, 30)
        Me.RadLabel_TissueUnitCost1Unit.TabIndex = 156
        Me.RadLabel_TissueUnitCost1Unit.Text = "Units_PerKg"
        Me.RadLabel_TissueUnitCost1Unit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_TissueUnitCost1Unit.TextWrap = False
        Me.RadLabel_TissueUnitCost1Unit.ThemeName = "Windows8"
        '
        'RadTextBox_TissueDetail1
        '
        Me.RadTextBox_TissueDetail1.AutoSize = False
        Me.RadTextBox_TissueDetail1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_TissueDetail1.Location = New System.Drawing.Point(393, 27)
        Me.RadTextBox_TissueDetail1.Name = "RadTextBox_TissueDetail1"
        Me.RadTextBox_TissueDetail1.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_TissueDetail1.TabIndex = 160
        Me.RadTextBox_TissueDetail1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TissueDetail1.ThemeName = "Windows8"
        '
        'RadTextBox_TissueDetail2
        '
        Me.RadTextBox_TissueDetail2.AutoSize = False
        Me.RadTextBox_TissueDetail2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_TissueDetail2.Location = New System.Drawing.Point(393, 59)
        Me.RadTextBox_TissueDetail2.Name = "RadTextBox_TissueDetail2"
        Me.RadTextBox_TissueDetail2.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_TissueDetail2.TabIndex = 162
        Me.RadTextBox_TissueDetail2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TissueDetail2.ThemeName = "Windows8"
        '
        'RadTextBox_TabDetail
        '
        Me.RadTextBox_TabDetail.AutoSize = False
        Me.RadTextBox_TabDetail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_TabDetail.Location = New System.Drawing.Point(393, 91)
        Me.RadTextBox_TabDetail.Name = "RadTextBox_TabDetail"
        Me.RadTextBox_TabDetail.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_TabDetail.TabIndex = 156
        Me.RadTextBox_TabDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TabDetail.ThemeName = "Windows8"
        '
        'RadLabel_TissueDetail3Unit
        '
        Me.RadLabel_TissueDetail3Unit.AutoSize = False
        Me.RadLabel_TissueDetail3Unit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_TissueDetail3Unit.Location = New System.Drawing.Point(444, 91)
        Me.RadLabel_TissueDetail3Unit.Name = "RadLabel_TissueDetail3Unit"
        Me.RadLabel_TissueDetail3Unit.Size = New System.Drawing.Size(61, 30)
        Me.RadLabel_TissueDetail3Unit.TabIndex = 162
        Me.RadLabel_TissueDetail3Unit.Text = "Unit_GramPerCubicCm"
        Me.RadLabel_TissueDetail3Unit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_TissueDetail3Unit.TextWrap = False
        Me.RadLabel_TissueDetail3Unit.ThemeName = "Windows8"
        '
        'RadLabel_TissueDetail2Unit
        '
        Me.RadLabel_TissueDetail2Unit.AutoSize = False
        Me.RadLabel_TissueDetail2Unit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_TissueDetail2Unit.Location = New System.Drawing.Point(444, 59)
        Me.RadLabel_TissueDetail2Unit.Name = "RadLabel_TissueDetail2Unit"
        Me.RadLabel_TissueDetail2Unit.Size = New System.Drawing.Size(61, 30)
        Me.RadLabel_TissueDetail2Unit.TabIndex = 163
        Me.RadLabel_TissueDetail2Unit.Text = "Unit_GramPerCubicCm"
        Me.RadLabel_TissueDetail2Unit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_TissueDetail2Unit.TextWrap = False
        Me.RadLabel_TissueDetail2Unit.ThemeName = "Windows8"
        '
        'RadLabel_TissueDetail1Unit
        '
        Me.RadLabel_TissueDetail1Unit.AutoSize = False
        Me.RadLabel_TissueDetail1Unit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_TissueDetail1Unit.Location = New System.Drawing.Point(444, 27)
        Me.RadLabel_TissueDetail1Unit.Name = "RadLabel_TissueDetail1Unit"
        Me.RadLabel_TissueDetail1Unit.Size = New System.Drawing.Size(61, 30)
        Me.RadLabel_TissueDetail1Unit.TabIndex = 164
        Me.RadLabel_TissueDetail1Unit.Text = "Unit_GramPerCubicCm"
        Me.RadLabel_TissueDetail1Unit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_TissueDetail1Unit.TextWrap = False
        Me.RadLabel_TissueDetail1Unit.ThemeName = "Windows8"
        '
        'RadTextBox_TissueThick3
        '
        Me.RadTextBox_TissueThick3.AutoSize = False
        Me.RadTextBox_TissueThick3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_TissueThick3.Location = New System.Drawing.Point(325, 91)
        Me.RadTextBox_TissueThick3.Name = "RadTextBox_TissueThick3"
        Me.RadTextBox_TissueThick3.Size = New System.Drawing.Size(41, 29)
        Me.RadTextBox_TissueThick3.TabIndex = 156
        Me.RadTextBox_TissueThick3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TissueThick3.ThemeName = "Windows8"
        '
        'RadTextBox_TissueThick2
        '
        Me.RadTextBox_TissueThick2.AutoSize = False
        Me.RadTextBox_TissueThick2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_TissueThick2.Location = New System.Drawing.Point(325, 59)
        Me.RadTextBox_TissueThick2.Name = "RadTextBox_TissueThick2"
        Me.RadTextBox_TissueThick2.Size = New System.Drawing.Size(41, 29)
        Me.RadTextBox_TissueThick2.TabIndex = 155
        Me.RadTextBox_TissueThick2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TissueThick2.ThemeName = "Windows8"
        '
        'RadTextBox_TissueThick1
        '
        Me.RadTextBox_TissueThick1.AutoSize = False
        Me.RadTextBox_TissueThick1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_TissueThick1.Location = New System.Drawing.Point(325, 27)
        Me.RadTextBox_TissueThick1.Name = "RadTextBox_TissueThick1"
        Me.RadTextBox_TissueThick1.Size = New System.Drawing.Size(41, 29)
        Me.RadTextBox_TissueThick1.TabIndex = 154
        Me.RadTextBox_TissueThick1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TissueThick1.ThemeName = "Windows8"
        '
        'RadLabel_TissueThick3Unit
        '
        Me.RadLabel_TissueThick3Unit.AutoSize = False
        Me.RadLabel_TissueThick3Unit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_TissueThick3Unit.Location = New System.Drawing.Point(363, 92)
        Me.RadLabel_TissueThick3Unit.Name = "RadLabel_TissueThick3Unit"
        Me.RadLabel_TissueThick3Unit.Size = New System.Drawing.Size(42, 30)
        Me.RadLabel_TissueThick3Unit.TabIndex = 157
        Me.RadLabel_TissueThick3Unit.Text = "Units_MicroMeter"
        Me.RadLabel_TissueThick3Unit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_TissueThick3Unit.TextWrap = False
        Me.RadLabel_TissueThick3Unit.ThemeName = "Windows8"
        '
        'RadLabel_TissueThick2Unit
        '
        Me.RadLabel_TissueThick2Unit.AutoSize = False
        Me.RadLabel_TissueThick2Unit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_TissueThick2Unit.Location = New System.Drawing.Point(363, 62)
        Me.RadLabel_TissueThick2Unit.Name = "RadLabel_TissueThick2Unit"
        Me.RadLabel_TissueThick2Unit.Size = New System.Drawing.Size(42, 30)
        Me.RadLabel_TissueThick2Unit.TabIndex = 152
        Me.RadLabel_TissueThick2Unit.Text = "Units_MicroMeter"
        Me.RadLabel_TissueThick2Unit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_TissueThick2Unit.TextWrap = False
        Me.RadLabel_TissueThick2Unit.ThemeName = "Windows8"
        '
        'RadLabel_TissueThick1Unit
        '
        Me.RadLabel_TissueThick1Unit.AutoSize = False
        Me.RadLabel_TissueThick1Unit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_TissueThick1Unit.Location = New System.Drawing.Point(363, 28)
        Me.RadLabel_TissueThick1Unit.Name = "RadLabel_TissueThick1Unit"
        Me.RadLabel_TissueThick1Unit.Size = New System.Drawing.Size(42, 30)
        Me.RadLabel_TissueThick1Unit.TabIndex = 151
        Me.RadLabel_TissueThick1Unit.Text = "Units_MicroMeter"
        Me.RadLabel_TissueThick1Unit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_TissueThick1Unit.TextWrap = False
        Me.RadLabel_TissueThick1Unit.ThemeName = "Windows8"
        '
        'RadTextBox_TissueWidth3
        '
        Me.RadTextBox_TissueWidth3.AutoSize = False
        Me.RadTextBox_TissueWidth3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_TissueWidth3.Location = New System.Drawing.Point(167, 92)
        Me.RadTextBox_TissueWidth3.Name = "RadTextBox_TissueWidth3"
        Me.RadTextBox_TissueWidth3.Size = New System.Drawing.Size(41, 29)
        Me.RadTextBox_TissueWidth3.TabIndex = 155
        Me.RadTextBox_TissueWidth3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TissueWidth3.ThemeName = "Windows8"
        '
        'RadTextBox_TissueWidth2
        '
        Me.RadTextBox_TissueWidth2.AutoSize = False
        Me.RadTextBox_TissueWidth2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_TissueWidth2.Location = New System.Drawing.Point(167, 60)
        Me.RadTextBox_TissueWidth2.Name = "RadTextBox_TissueWidth2"
        Me.RadTextBox_TissueWidth2.Size = New System.Drawing.Size(41, 29)
        Me.RadTextBox_TissueWidth2.TabIndex = 154
        Me.RadTextBox_TissueWidth2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TissueWidth2.ThemeName = "Windows8"
        '
        'RadTextBox_TissueWidth1
        '
        Me.RadTextBox_TissueWidth1.AutoSize = False
        Me.RadTextBox_TissueWidth1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_TissueWidth1.Location = New System.Drawing.Point(167, 28)
        Me.RadTextBox_TissueWidth1.Name = "RadTextBox_TissueWidth1"
        Me.RadTextBox_TissueWidth1.Size = New System.Drawing.Size(41, 29)
        Me.RadTextBox_TissueWidth1.TabIndex = 153
        Me.RadTextBox_TissueWidth1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TissueWidth1.ThemeName = "Windows8"
        '
        'RadLabel_13
        '
        Me.RadLabel_13.AutoSize = False
        Me.RadLabel_13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_13.Location = New System.Drawing.Point(5, 92)
        Me.RadLabel_13.Name = "RadLabel_13"
        Me.RadLabel_13.Size = New System.Drawing.Size(26, 27)
        Me.RadLabel_13.TabIndex = 80
        Me.RadLabel_13.Text = "3"
        Me.RadLabel_13.ThemeName = "Windows8"
        '
        'RadLabel_12
        '
        Me.RadLabel_12.AutoSize = False
        Me.RadLabel_12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_12.Location = New System.Drawing.Point(5, 60)
        Me.RadLabel_12.Name = "RadLabel_12"
        Me.RadLabel_12.Size = New System.Drawing.Size(26, 27)
        Me.RadLabel_12.TabIndex = 65
        Me.RadLabel_12.Text = "2"
        Me.RadLabel_12.ThemeName = "Windows8"
        '
        'RadLabel_11
        '
        Me.RadLabel_11.AutoSize = False
        Me.RadLabel_11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_11.Location = New System.Drawing.Point(5, 28)
        Me.RadLabel_11.Name = "RadLabel_11"
        Me.RadLabel_11.Size = New System.Drawing.Size(26, 28)
        Me.RadLabel_11.TabIndex = 51
        Me.RadLabel_11.Text = "1"
        Me.RadLabel_11.ThemeName = "Windows8"
        '
        'Panel17
        '
        Me.Panel17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel17.Controls.Add(Me.RadLabel_Tissues)
        Me.Panel17.Location = New System.Drawing.Point(0, 0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(76, 26)
        Me.Panel17.TabIndex = 22
        '
        'RadLabel_Tissues
        '
        Me.RadLabel_Tissues.AutoSize = False
        Me.RadLabel_Tissues.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Tissues.Location = New System.Drawing.Point(0, 0)
        Me.RadLabel_Tissues.Name = "RadLabel_Tissues"
        Me.RadLabel_Tissues.Size = New System.Drawing.Size(71, 23)
        Me.RadLabel_Tissues.TabIndex = 160
        Me.RadLabel_Tissues.Text = "DesignSummary_Tissues"
        Me.RadLabel_Tissues.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Tissues.TextWrap = False
        Me.RadLabel_Tissues.ThemeName = "Windows8"
        '
        'Panel15
        '
        Me.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel15.Controls.Add(Me.RadLabel_MaxCapUnit)
        Me.Panel15.Controls.Add(Me.RadTextBox_MaxCap)
        Me.Panel15.Controls.Add(Me.RadTextBox_PercentageFit)
        Me.Panel15.Controls.Add(Me.RadTextBox_WFactor)
        Me.Panel15.Controls.Add(Me.RadTextBox_MaxLengthGain)
        Me.Panel15.Controls.Add(Me.RadLabel_MaxLengthGainUnit)
        Me.Panel15.Controls.Add(Me.RadLabel_MaxLengthUnit)
        Me.Panel15.Controls.Add(Me.RadTextBox_MaxLength)
        Me.Panel15.Controls.Add(Me.RadLabel_Cap)
        Me.Panel15.Controls.Add(Me.RadLabel_CapPercentageFit)
        Me.Panel15.Controls.Add(Me.RadLabel_CapAt)
        Me.Panel15.Controls.Add(Me.RadLabel_PercentageFit)
        Me.Panel15.Controls.Add(Me.RadLabel_WFactor)
        Me.Panel15.Controls.Add(Me.RadLabel_MaxLength)
        Me.Panel15.Location = New System.Drawing.Point(746, 151)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(207, 269)
        Me.Panel15.TabIndex = 38
        '
        'RadLabel_MaxCapUnit
        '
        Me.RadLabel_MaxCapUnit.AutoSize = False
        Me.RadLabel_MaxCapUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MaxCapUnit.Location = New System.Drawing.Point(113, 208)
        Me.RadLabel_MaxCapUnit.Name = "RadLabel_MaxCapUnit"
        Me.RadLabel_MaxCapUnit.Size = New System.Drawing.Size(69, 30)
        Me.RadLabel_MaxCapUnit.TabIndex = 151
        Me.RadLabel_MaxCapUnit.Text = "Units_MicroFarad"
        Me.RadLabel_MaxCapUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_MaxCapUnit.TextWrap = False
        Me.RadLabel_MaxCapUnit.ThemeName = "Windows8"
        '
        'RadTextBox_MaxCap
        '
        Me.RadTextBox_MaxCap.AutoSize = False
        Me.RadTextBox_MaxCap.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_MaxCap.Location = New System.Drawing.Point(57, 207)
        Me.RadTextBox_MaxCap.Name = "RadTextBox_MaxCap"
        Me.RadTextBox_MaxCap.Size = New System.Drawing.Size(58, 29)
        Me.RadTextBox_MaxCap.TabIndex = 151
        Me.RadTextBox_MaxCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_MaxCap.ThemeName = "Windows8"
        '
        'RadTextBox_PercentageFit
        '
        Me.RadTextBox_PercentageFit.AutoSize = False
        Me.RadTextBox_PercentageFit.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_PercentageFit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_PercentageFit.Location = New System.Drawing.Point(97, 136)
        Me.RadTextBox_PercentageFit.Name = "RadTextBox_PercentageFit"
        Me.RadTextBox_PercentageFit.Size = New System.Drawing.Size(58, 29)
        Me.RadTextBox_PercentageFit.TabIndex = 153
        Me.RadTextBox_PercentageFit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_PercentageFit.ThemeName = "Windows8"
        '
        'RadTextBox_WFactor
        '
        Me.RadTextBox_WFactor.AutoSize = False
        Me.RadTextBox_WFactor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_WFactor.Location = New System.Drawing.Point(97, 87)
        Me.RadTextBox_WFactor.Name = "RadTextBox_WFactor"
        Me.RadTextBox_WFactor.Size = New System.Drawing.Size(58, 29)
        Me.RadTextBox_WFactor.TabIndex = 152
        Me.RadTextBox_WFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_WFactor.ThemeName = "Windows8"
        '
        'RadTextBox_MaxLengthGain
        '
        Me.RadTextBox_MaxLengthGain.AutoSize = False
        Me.RadTextBox_MaxLengthGain.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_MaxLengthGain.Location = New System.Drawing.Point(97, 38)
        Me.RadTextBox_MaxLengthGain.Name = "RadTextBox_MaxLengthGain"
        Me.RadTextBox_MaxLengthGain.Size = New System.Drawing.Size(58, 29)
        Me.RadTextBox_MaxLengthGain.TabIndex = 151
        Me.RadTextBox_MaxLengthGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_MaxLengthGain.ThemeName = "Windows8"
        '
        'RadLabel_MaxLengthGainUnit
        '
        Me.RadLabel_MaxLengthGainUnit.AutoSize = False
        Me.RadLabel_MaxLengthGainUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MaxLengthGainUnit.Location = New System.Drawing.Point(151, 39)
        Me.RadLabel_MaxLengthGainUnit.Name = "RadLabel_MaxLengthGainUnit"
        Me.RadLabel_MaxLengthGainUnit.Size = New System.Drawing.Size(69, 30)
        Me.RadLabel_MaxLengthGainUnit.TabIndex = 150
        Me.RadLabel_MaxLengthGainUnit.Text = "UniMicroFaradPerCm"
        Me.RadLabel_MaxLengthGainUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_MaxLengthGainUnit.TextWrap = False
        Me.RadLabel_MaxLengthGainUnit.ThemeName = "Windows8"
        '
        'RadLabel_MaxLengthUnit
        '
        Me.RadLabel_MaxLengthUnit.AutoSize = False
        Me.RadLabel_MaxLengthUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MaxLengthUnit.Location = New System.Drawing.Point(53, 39)
        Me.RadLabel_MaxLengthUnit.Name = "RadLabel_MaxLengthUnit"
        Me.RadLabel_MaxLengthUnit.Size = New System.Drawing.Size(42, 30)
        Me.RadLabel_MaxLengthUnit.TabIndex = 149
        Me.RadLabel_MaxLengthUnit.Text = "Units_Mm"
        Me.RadLabel_MaxLengthUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_MaxLengthUnit.TextWrap = False
        Me.RadLabel_MaxLengthUnit.ThemeName = "Windows8"
        '
        'RadTextBox_MaxLength
        '
        Me.RadTextBox_MaxLength.AutoSize = False
        Me.RadTextBox_MaxLength.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_MaxLength.Location = New System.Drawing.Point(5, 38)
        Me.RadTextBox_MaxLength.Name = "RadTextBox_MaxLength"
        Me.RadTextBox_MaxLength.Size = New System.Drawing.Size(50, 29)
        Me.RadTextBox_MaxLength.TabIndex = 150
        Me.RadTextBox_MaxLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_MaxLength.ThemeName = "Windows8"
        '
        'RadLabel_Cap
        '
        Me.RadLabel_Cap.AutoSize = False
        Me.RadLabel_Cap.Controls.Add(Me.RadLabel11)
        Me.RadLabel_Cap.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Cap.Location = New System.Drawing.Point(71, 181)
        Me.RadLabel_Cap.Name = "RadLabel_Cap"
        Me.RadLabel_Cap.Size = New System.Drawing.Size(34, 28)
        Me.RadLabel_Cap.TabIndex = 51
        Me.RadLabel_Cap.Text = "90"
        Me.RadLabel_Cap.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_Cap.TextWrap = False
        Me.RadLabel_Cap.ThemeName = "Windows8"
        '
        'RadLabel11
        '
        Me.RadLabel11.AutoSize = False
        Me.RadLabel11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel11.Location = New System.Drawing.Point(33, 0)
        Me.RadLabel11.Name = "RadLabel11"
        Me.RadLabel11.Size = New System.Drawing.Size(40, 28)
        Me.RadLabel11.TabIndex = 51
        Me.RadLabel11.Text = "90"
        Me.RadLabel11.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel11.ThemeName = "Windows8"
        '
        'RadLabel_CapPercentageFit
        '
        Me.RadLabel_CapPercentageFit.AutoSize = False
        Me.RadLabel_CapPercentageFit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_CapPercentageFit.Location = New System.Drawing.Point(107, 180)
        Me.RadLabel_CapPercentageFit.Name = "RadLabel_CapPercentageFit"
        Me.RadLabel_CapPercentageFit.Size = New System.Drawing.Size(76, 28)
        Me.RadLabel_CapPercentageFit.TabIndex = 50
        Me.RadLabel_CapPercentageFit.Text = "DesignSummary_PercentageFit"
        Me.RadLabel_CapPercentageFit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_CapPercentageFit.TextWrap = False
        Me.RadLabel_CapPercentageFit.ThemeName = "Windows8"
        '
        'RadLabel_CapAt
        '
        Me.RadLabel_CapAt.AutoSize = False
        Me.RadLabel_CapAt.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_CapAt.Location = New System.Drawing.Point(5, 180)
        Me.RadLabel_CapAt.Name = "RadLabel_CapAt"
        Me.RadLabel_CapAt.Size = New System.Drawing.Size(73, 28)
        Me.RadLabel_CapAt.TabIndex = 49
        Me.RadLabel_CapAt.Text = "DesignSummary_CapAt"
        Me.RadLabel_CapAt.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_CapAt.TextWrap = False
        Me.RadLabel_CapAt.ThemeName = "Windows8"
        '
        'RadLabel_PercentageFit
        '
        Me.RadLabel_PercentageFit.AutoSize = False
        Me.RadLabel_PercentageFit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_PercentageFit.Location = New System.Drawing.Point(5, 136)
        Me.RadLabel_PercentageFit.Name = "RadLabel_PercentageFit"
        Me.RadLabel_PercentageFit.Size = New System.Drawing.Size(90, 28)
        Me.RadLabel_PercentageFit.TabIndex = 45
        Me.RadLabel_PercentageFit.Text = "DesignSummary_PercentageFit"
        Me.RadLabel_PercentageFit.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_PercentageFit.TextWrap = False
        Me.RadLabel_PercentageFit.ThemeName = "Windows8"
        '
        'RadLabel_WFactor
        '
        Me.RadLabel_WFactor.AutoSize = False
        Me.RadLabel_WFactor.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_WFactor.Location = New System.Drawing.Point(5, 87)
        Me.RadLabel_WFactor.Name = "RadLabel_WFactor"
        Me.RadLabel_WFactor.Size = New System.Drawing.Size(90, 28)
        Me.RadLabel_WFactor.TabIndex = 43
        Me.RadLabel_WFactor.Text = "DesignSummary_WFactor"
        Me.RadLabel_WFactor.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_WFactor.TextWrap = False
        Me.RadLabel_WFactor.ThemeName = "Windows8"
        '
        'RadLabel_MaxLength
        '
        Me.RadLabel_MaxLength.AutoSize = False
        Me.RadLabel_MaxLength.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MaxLength.Location = New System.Drawing.Point(5, 6)
        Me.RadLabel_MaxLength.Name = "RadLabel_MaxLength"
        Me.RadLabel_MaxLength.Size = New System.Drawing.Size(100, 28)
        Me.RadLabel_MaxLength.TabIndex = 0
        Me.RadLabel_MaxLength.Text = "DesignSummary_MaxLength"
        Me.RadLabel_MaxLength.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_MaxLength.TextWrap = False
        Me.RadLabel_MaxLength.ThemeName = "Windows8"
        '
        'RadLabel_Tab
        '
        Me.RadLabel_Tab.AutoSize = False
        Me.RadLabel_Tab.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Tab.Location = New System.Drawing.Point(14, 352)
        Me.RadLabel_Tab.Name = "RadLabel_Tab"
        Me.RadLabel_Tab.Size = New System.Drawing.Size(49, 27)
        Me.RadLabel_Tab.TabIndex = 66
        Me.RadLabel_Tab.Text = "DesignSummary_Tab"
        Me.RadLabel_Tab.ThemeName = "Windows8"
        '
        'RadLabel_Elyte
        '
        Me.RadLabel_Elyte.AutoSize = False
        Me.RadLabel_Elyte.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Elyte.Location = New System.Drawing.Point(14, 383)
        Me.RadLabel_Elyte.Name = "RadLabel_Elyte"
        Me.RadLabel_Elyte.Size = New System.Drawing.Size(49, 27)
        Me.RadLabel_Elyte.TabIndex = 79
        Me.RadLabel_Elyte.Text = "DesignSummary_Elyte"
        Me.RadLabel_Elyte.ThemeName = "Windows8"
        '
        'Panel18
        '
        Me.Panel18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel18.Controls.Add(Me.RadTextBox_MelQty)
        Me.Panel18.Controls.Add(Me.RadTextBox_HoleTheta)
        Me.Panel18.Controls.Add(Me.RadTextBox_Melinex)
        Me.Panel18.Controls.Add(Me.RadTextBox_No)
        Me.Panel18.Controls.Add(Me.RadTextBox_L2)
        Me.Panel18.Controls.Add(Me.RadTextBox_Mandrel)
        Me.Panel18.Controls.Add(Me.RadTextBox_L1)
        Me.Panel18.Controls.Add(Me.RadTextBox_PreWrap)
        Me.Panel18.Controls.Add(Me.RadTextBox_CathExt)
        Me.Panel18.Controls.Add(Me.RadTextBox_CanIntTheta)
        Me.Panel18.Controls.Add(Me.RadLabel_CathExt)
        Me.Panel18.Controls.Add(Me.RadLabel_CathExtUnit)
        Me.Panel18.Controls.Add(Me.RadLabel_Mandrel)
        Me.Panel18.Controls.Add(Me.RadLabel_CanIntThetaUnit)
        Me.Panel18.Controls.Add(Me.RadLabel_MandrelUnit)
        Me.Panel18.Controls.Add(Me.RadLabel_No)
        Me.Panel18.Controls.Add(Me.RadLabel_HoleTheta)
        Me.Panel18.Controls.Add(Me.RadLabel_HoleThetaUnit)
        Me.Panel18.Controls.Add(Me.RadLabel_MelQty)
        Me.Panel18.Controls.Add(Me.RadLabel_Melinex)
        Me.Panel18.Controls.Add(Me.RadLabel_L2Unit)
        Me.Panel18.Controls.Add(Me.RadLabel_L2)
        Me.Panel18.Controls.Add(Me.RadLabel_L1)
        Me.Panel18.Controls.Add(Me.RadLabel_PreWrap)
        Me.Panel18.Controls.Add(Me.RadLabel_CanIntTheta)
        Me.Panel18.Controls.Add(Me.RadCheckBox_Swage)
        Me.Panel18.Controls.Add(Me.RadCheckBox_AW)
        Me.Panel18.Location = New System.Drawing.Point(-2, 414)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(955, 94)
        Me.Panel18.TabIndex = 92
        '
        'RadTextBox_MelQty
        '
        Me.RadTextBox_MelQty.AutoSize = False
        Me.RadTextBox_MelQty.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_MelQty.Location = New System.Drawing.Point(703, 51)
        Me.RadTextBox_MelQty.Name = "RadTextBox_MelQty"
        Me.RadTextBox_MelQty.Size = New System.Drawing.Size(55, 29)
        Me.RadTextBox_MelQty.TabIndex = 148
        Me.RadTextBox_MelQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_MelQty.ThemeName = "Windows8"
        '
        'RadTextBox_HoleTheta
        '
        Me.RadTextBox_HoleTheta.AutoSize = False
        Me.RadTextBox_HoleTheta.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_HoleTheta.Location = New System.Drawing.Point(497, 51)
        Me.RadTextBox_HoleTheta.Name = "RadTextBox_HoleTheta"
        Me.RadTextBox_HoleTheta.Size = New System.Drawing.Size(55, 29)
        Me.RadTextBox_HoleTheta.TabIndex = 146
        Me.RadTextBox_HoleTheta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_HoleTheta.ThemeName = "Windows8"
        '
        'RadTextBox_Melinex
        '
        Me.RadTextBox_Melinex.AutoSize = False
        Me.RadTextBox_Melinex.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_Melinex.Location = New System.Drawing.Point(703, 10)
        Me.RadTextBox_Melinex.Name = "RadTextBox_Melinex"
        Me.RadTextBox_Melinex.Size = New System.Drawing.Size(55, 29)
        Me.RadTextBox_Melinex.TabIndex = 147
        Me.RadTextBox_Melinex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Melinex.ThemeName = "Windows8"
        '
        'RadTextBox_No
        '
        Me.RadTextBox_No.AutoSize = False
        Me.RadTextBox_No.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_No.Location = New System.Drawing.Point(383, 51)
        Me.RadTextBox_No.Name = "RadTextBox_No"
        Me.RadTextBox_No.Size = New System.Drawing.Size(55, 29)
        Me.RadTextBox_No.TabIndex = 144
        Me.RadTextBox_No.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_No.ThemeName = "Windows8"
        '
        'RadTextBox_L2
        '
        Me.RadTextBox_L2.AutoSize = False
        Me.RadTextBox_L2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_L2.Location = New System.Drawing.Point(497, 10)
        Me.RadTextBox_L2.Name = "RadTextBox_L2"
        Me.RadTextBox_L2.Size = New System.Drawing.Size(55, 29)
        Me.RadTextBox_L2.TabIndex = 145
        Me.RadTextBox_L2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_L2.ThemeName = "Windows8"
        '
        'RadTextBox_Mandrel
        '
        Me.RadTextBox_Mandrel.AutoSize = False
        Me.RadTextBox_Mandrel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_Mandrel.Location = New System.Drawing.Point(249, 51)
        Me.RadTextBox_Mandrel.Name = "RadTextBox_Mandrel"
        Me.RadTextBox_Mandrel.Size = New System.Drawing.Size(55, 29)
        Me.RadTextBox_Mandrel.TabIndex = 142
        Me.RadTextBox_Mandrel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Mandrel.ThemeName = "Windows8"
        '
        'RadTextBox_L1
        '
        Me.RadTextBox_L1.AutoSize = False
        Me.RadTextBox_L1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_L1.Location = New System.Drawing.Point(383, 10)
        Me.RadTextBox_L1.Name = "RadTextBox_L1"
        Me.RadTextBox_L1.Size = New System.Drawing.Size(55, 29)
        Me.RadTextBox_L1.TabIndex = 143
        Me.RadTextBox_L1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_L1.ThemeName = "Windows8"
        '
        'RadTextBox_PreWrap
        '
        Me.RadTextBox_PreWrap.AutoSize = False
        Me.RadTextBox_PreWrap.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_PreWrap.Location = New System.Drawing.Point(249, 10)
        Me.RadTextBox_PreWrap.Name = "RadTextBox_PreWrap"
        Me.RadTextBox_PreWrap.Size = New System.Drawing.Size(55, 29)
        Me.RadTextBox_PreWrap.TabIndex = 141
        Me.RadTextBox_PreWrap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_PreWrap.ThemeName = "Windows8"
        '
        'RadTextBox_CathExt
        '
        Me.RadTextBox_CathExt.AutoSize = False
        Me.RadTextBox_CathExt.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_CathExt.Location = New System.Drawing.Point(75, 51)
        Me.RadTextBox_CathExt.Name = "RadTextBox_CathExt"
        Me.RadTextBox_CathExt.Size = New System.Drawing.Size(55, 29)
        Me.RadTextBox_CathExt.TabIndex = 141
        Me.RadTextBox_CathExt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_CathExt.ThemeName = "Windows8"
        '
        'RadTextBox_CanIntTheta
        '
        Me.RadTextBox_CanIntTheta.AutoSize = False
        Me.RadTextBox_CanIntTheta.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_CanIntTheta.Location = New System.Drawing.Point(75, 10)
        Me.RadTextBox_CanIntTheta.Name = "RadTextBox_CanIntTheta"
        Me.RadTextBox_CanIntTheta.Size = New System.Drawing.Size(55, 29)
        Me.RadTextBox_CanIntTheta.TabIndex = 140
        Me.RadTextBox_CanIntTheta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_CanIntTheta.ThemeName = "Windows8"
        '
        'RadLabel_CathExt
        '
        Me.RadLabel_CathExt.AutoSize = False
        Me.RadLabel_CathExt.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_CathExt.Location = New System.Drawing.Point(0, 51)
        Me.RadLabel_CathExt.Name = "RadLabel_CathExt"
        Me.RadLabel_CathExt.Size = New System.Drawing.Size(78, 31)
        Me.RadLabel_CathExt.TabIndex = 141
        Me.RadLabel_CathExt.Text = "DesignSummary_CathExt"
        Me.RadLabel_CathExt.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_CathExt.TextWrap = False
        Me.RadLabel_CathExt.ThemeName = "Windows8"
        '
        'RadLabel_CathExtUnit
        '
        Me.RadLabel_CathExtUnit.AutoSize = False
        Me.RadLabel_CathExtUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_CathExtUnit.Location = New System.Drawing.Point(128, 51)
        Me.RadLabel_CathExtUnit.Name = "RadLabel_CathExtUnit"
        Me.RadLabel_CathExtUnit.Size = New System.Drawing.Size(42, 31)
        Me.RadLabel_CathExtUnit.TabIndex = 148
        Me.RadLabel_CathExtUnit.Text = "Units_Mm"
        Me.RadLabel_CathExtUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_CathExtUnit.TextWrap = False
        Me.RadLabel_CathExtUnit.ThemeName = "Windows8"
        '
        'RadLabel_Mandrel
        '
        Me.RadLabel_Mandrel.AutoSize = False
        Me.RadLabel_Mandrel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Mandrel.Location = New System.Drawing.Point(172, 51)
        Me.RadLabel_Mandrel.Name = "RadLabel_Mandrel"
        Me.RadLabel_Mandrel.Size = New System.Drawing.Size(78, 31)
        Me.RadLabel_Mandrel.TabIndex = 142
        Me.RadLabel_Mandrel.Text = "DesignSummary_Mandrel"
        Me.RadLabel_Mandrel.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Mandrel.TextWrap = False
        Me.RadLabel_Mandrel.ThemeName = "Windows8"
        '
        'RadLabel_CanIntThetaUnit
        '
        Me.RadLabel_CanIntThetaUnit.AutoSize = False
        Me.RadLabel_CanIntThetaUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_CanIntThetaUnit.Location = New System.Drawing.Point(128, 10)
        Me.RadLabel_CanIntThetaUnit.Name = "RadLabel_CanIntThetaUnit"
        Me.RadLabel_CanIntThetaUnit.Size = New System.Drawing.Size(42, 31)
        Me.RadLabel_CanIntThetaUnit.TabIndex = 147
        Me.RadLabel_CanIntThetaUnit.Text = "Units_Mm"
        Me.RadLabel_CanIntThetaUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_CanIntThetaUnit.TextWrap = False
        Me.RadLabel_CanIntThetaUnit.ThemeName = "Windows8"
        '
        'RadLabel_MandrelUnit
        '
        Me.RadLabel_MandrelUnit.AutoSize = False
        Me.RadLabel_MandrelUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MandrelUnit.Location = New System.Drawing.Point(302, 51)
        Me.RadLabel_MandrelUnit.Name = "RadLabel_MandrelUnit"
        Me.RadLabel_MandrelUnit.Size = New System.Drawing.Size(42, 31)
        Me.RadLabel_MandrelUnit.TabIndex = 146
        Me.RadLabel_MandrelUnit.Text = "Units_Mm"
        Me.RadLabel_MandrelUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_MandrelUnit.TextWrap = False
        Me.RadLabel_MandrelUnit.ThemeName = "Windows8"
        '
        'RadLabel_No
        '
        Me.RadLabel_No.AutoSize = False
        Me.RadLabel_No.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_No.Location = New System.Drawing.Point(334, 51)
        Me.RadLabel_No.Name = "RadLabel_No"
        Me.RadLabel_No.Size = New System.Drawing.Size(50, 31)
        Me.RadLabel_No.TabIndex = 143
        Me.RadLabel_No.Text = "DesignSummary_No"
        Me.RadLabel_No.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_No.TextWrap = False
        Me.RadLabel_No.ThemeName = "Windows8"
        '
        'RadLabel_HoleTheta
        '
        Me.RadLabel_HoleTheta.AutoSize = False
        Me.RadLabel_HoleTheta.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_HoleTheta.Location = New System.Drawing.Point(440, 51)
        Me.RadLabel_HoleTheta.Name = "RadLabel_HoleTheta"
        Me.RadLabel_HoleTheta.Size = New System.Drawing.Size(61, 30)
        Me.RadLabel_HoleTheta.TabIndex = 144
        Me.RadLabel_HoleTheta.Text = "DesignSummary_HoleTheta"
        Me.RadLabel_HoleTheta.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_HoleTheta.TextWrap = False
        Me.RadLabel_HoleTheta.ThemeName = "Windows8"
        '
        'RadLabel_HoleThetaUnit
        '
        Me.RadLabel_HoleThetaUnit.AutoSize = False
        Me.RadLabel_HoleThetaUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_HoleThetaUnit.Location = New System.Drawing.Point(553, 51)
        Me.RadLabel_HoleThetaUnit.Name = "RadLabel_HoleThetaUnit"
        Me.RadLabel_HoleThetaUnit.Size = New System.Drawing.Size(42, 31)
        Me.RadLabel_HoleThetaUnit.TabIndex = 145
        Me.RadLabel_HoleThetaUnit.Text = "Units_Mm"
        Me.RadLabel_HoleThetaUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_HoleThetaUnit.TextWrap = False
        Me.RadLabel_HoleThetaUnit.ThemeName = "Windows8"
        '
        'RadLabel_MelQty
        '
        Me.RadLabel_MelQty.AutoSize = False
        Me.RadLabel_MelQty.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MelQty.Location = New System.Drawing.Point(626, 51)
        Me.RadLabel_MelQty.Name = "RadLabel_MelQty"
        Me.RadLabel_MelQty.Size = New System.Drawing.Size(78, 31)
        Me.RadLabel_MelQty.TabIndex = 145
        Me.RadLabel_MelQty.Text = "DesignSummary_MelQty"
        Me.RadLabel_MelQty.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_MelQty.TextWrap = False
        Me.RadLabel_MelQty.ThemeName = "Windows8"
        '
        'RadLabel_Melinex
        '
        Me.RadLabel_Melinex.AutoSize = False
        Me.RadLabel_Melinex.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Melinex.Location = New System.Drawing.Point(626, 10)
        Me.RadLabel_Melinex.Name = "RadLabel_Melinex"
        Me.RadLabel_Melinex.Size = New System.Drawing.Size(78, 31)
        Me.RadLabel_Melinex.TabIndex = 144
        Me.RadLabel_Melinex.Text = "DesignSummary_Melinex"
        Me.RadLabel_Melinex.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Melinex.TextWrap = False
        Me.RadLabel_Melinex.ThemeName = "Windows8"
        '
        'RadLabel_L2Unit
        '
        Me.RadLabel_L2Unit.AutoSize = False
        Me.RadLabel_L2Unit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_L2Unit.Location = New System.Drawing.Point(553, 10)
        Me.RadLabel_L2Unit.Name = "RadLabel_L2Unit"
        Me.RadLabel_L2Unit.Size = New System.Drawing.Size(42, 31)
        Me.RadLabel_L2Unit.TabIndex = 144
        Me.RadLabel_L2Unit.Text = "Units_Mm"
        Me.RadLabel_L2Unit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_L2Unit.TextWrap = False
        Me.RadLabel_L2Unit.ThemeName = "Windows8"
        '
        'RadLabel_L2
        '
        Me.RadLabel_L2.AutoSize = False
        Me.RadLabel_L2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_L2.Location = New System.Drawing.Point(448, 10)
        Me.RadLabel_L2.Name = "RadLabel_L2"
        Me.RadLabel_L2.Size = New System.Drawing.Size(50, 31)
        Me.RadLabel_L2.TabIndex = 143
        Me.RadLabel_L2.Text = "DesignSummary_L2"
        Me.RadLabel_L2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_L2.TextWrap = False
        Me.RadLabel_L2.ThemeName = "Windows8"
        '
        'RadLabel_L1
        '
        Me.RadLabel_L1.AutoSize = False
        Me.RadLabel_L1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_L1.Location = New System.Drawing.Point(334, 10)
        Me.RadLabel_L1.Name = "RadLabel_L1"
        Me.RadLabel_L1.Size = New System.Drawing.Size(50, 31)
        Me.RadLabel_L1.TabIndex = 142
        Me.RadLabel_L1.Text = "DesignSummary_L1"
        Me.RadLabel_L1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_L1.TextWrap = False
        Me.RadLabel_L1.ThemeName = "Windows8"
        '
        'RadLabel_PreWrap
        '
        Me.RadLabel_PreWrap.AutoSize = False
        Me.RadLabel_PreWrap.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_PreWrap.Location = New System.Drawing.Point(172, 10)
        Me.RadLabel_PreWrap.Name = "RadLabel_PreWrap"
        Me.RadLabel_PreWrap.Size = New System.Drawing.Size(78, 31)
        Me.RadLabel_PreWrap.TabIndex = 141
        Me.RadLabel_PreWrap.Text = "DesignSummary_PreWrap"
        Me.RadLabel_PreWrap.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_PreWrap.TextWrap = False
        Me.RadLabel_PreWrap.ThemeName = "Windows8"
        '
        'RadLabel_CanIntTheta
        '
        Me.RadLabel_CanIntTheta.AutoSize = False
        Me.RadLabel_CanIntTheta.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_CanIntTheta.Location = New System.Drawing.Point(-2, 10)
        Me.RadLabel_CanIntTheta.Name = "RadLabel_CanIntTheta"
        Me.RadLabel_CanIntTheta.Size = New System.Drawing.Size(78, 31)
        Me.RadLabel_CanIntTheta.TabIndex = 140
        Me.RadLabel_CanIntTheta.Text = "DesignSummary_CanIntTheta"
        Me.RadLabel_CanIntTheta.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_CanIntTheta.TextWrap = False
        Me.RadLabel_CanIntTheta.ThemeName = "Windows8"
        '
        'RadCheckBox_Swage
        '
        Me.RadCheckBox_Swage.AutoSize = False
        Me.RadCheckBox_Swage.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Swage.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_Swage.Location = New System.Drawing.Point(791, 51)
        Me.RadCheckBox_Swage.Name = "RadCheckBox_Swage"
        Me.RadCheckBox_Swage.Size = New System.Drawing.Size(101, 29)
        Me.RadCheckBox_Swage.TabIndex = 53
        Me.RadCheckBox_Swage.Text = "DesignSummary_Swage"
        Me.RadCheckBox_Swage.ThemeName = "Windows8"
        '
        'RadCheckBox_AW
        '
        Me.RadCheckBox_AW.AutoSize = False
        Me.RadCheckBox_AW.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_AW.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_AW.Location = New System.Drawing.Point(791, 10)
        Me.RadCheckBox_AW.Name = "RadCheckBox_AW"
        Me.RadCheckBox_AW.Size = New System.Drawing.Size(101, 29)
        Me.RadCheckBox_AW.TabIndex = 52
        Me.RadCheckBox_AW.Text = "DesignSummary_AW"
        Me.RadCheckBox_AW.ThemeName = "Windows8"
        '
        'Panel23
        '
        Me.Panel23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel23.Controls.Add(Me.RadLabel_NoESRDataOnStyleDesign)
        Me.Panel23.Controls.Add(Me.RadTextBox_Z10KHz)
        Me.Panel23.Controls.Add(Me.RadTextBox_ESR100Hz)
        Me.Panel23.Controls.Add(Me.RadTextBox_ESRFoil10Percent)
        Me.Panel23.Controls.Add(Me.RadTextBox_ESRFoil10)
        Me.Panel23.Controls.Add(Me.RadTextBox_ESROxide10Percent)
        Me.Panel23.Controls.Add(Me.RadTextBox_ESRTabbing10Percent)
        Me.Panel23.Controls.Add(Me.RadTextBox_ESRTissue10Percent)
        Me.Panel23.Controls.Add(Me.RadTextBox_ESRTabbing10)
        Me.Panel23.Controls.Add(Me.RadTextBox_ESROxide10)
        Me.Panel23.Controls.Add(Me.RadTextBox_ESRFoil100Percent)
        Me.Panel23.Controls.Add(Me.RadTextBox_ESRTissue10)
        Me.Panel23.Controls.Add(Me.RadTextBox_ESROxide100Percent)
        Me.Panel23.Controls.Add(Me.RadTextBox_ESRTissue100Percent)
        Me.Panel23.Controls.Add(Me.RadTextBox_ESRTabbing100Percent)
        Me.Panel23.Controls.Add(Me.RadTextBox_ESRFoil100)
        Me.Panel23.Controls.Add(Me.RadTextBox_ESROxide100)
        Me.Panel23.Controls.Add(Me.RadTextBox_ESRTissue100)
        Me.Panel23.Controls.Add(Me.RadTextBox_ESRTabbing100)
        Me.Panel23.Controls.Add(Me.RadLabel_Z10KHz)
        Me.Panel23.Controls.Add(Me.RadLabel_ESR100Hz)
        Me.Panel23.Controls.Add(Me.RadLabel_Total)
        Me.Panel23.Controls.Add(Me.RadLabel_ESRFoil)
        Me.Panel23.Controls.Add(Me.RadLabel_ESROxide)
        Me.Panel23.Controls.Add(Me.RadLabel_ESRTissue)
        Me.Panel23.Controls.Add(Me.RadLabel_ESRTabbing)
        Me.Panel23.Controls.Add(Me.RadLabel_At10kHz)
        Me.Panel23.Controls.Add(Me.RadLabel_At100Hz)
        Me.Panel23.Controls.Add(Me.RadButton_ESRGraphForm)
        Me.Panel23.Controls.Add(Me.Panel20)
        Me.Panel23.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Panel23.Location = New System.Drawing.Point(418, 506)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(537, 218)
        Me.Panel23.TabIndex = 97
        '
        'RadTextBox_Z10KHz
        '
        Me.RadTextBox_Z10KHz.AutoSize = False
        Me.RadTextBox_Z10KHz.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_Z10KHz.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Z10KHz.Location = New System.Drawing.Point(407, 124)
        Me.RadTextBox_Z10KHz.Name = "RadTextBox_Z10KHz"
        Me.RadTextBox_Z10KHz.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_Z10KHz.TabIndex = 126
        Me.RadTextBox_Z10KHz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_Z10KHz.ThemeName = "Windows8"
        '
        'RadTextBox_ESR100Hz
        '
        Me.RadTextBox_ESR100Hz.AutoSize = False
        Me.RadTextBox_ESR100Hz.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_ESR100Hz.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_ESR100Hz.Location = New System.Drawing.Point(408, 58)
        Me.RadTextBox_ESR100Hz.Name = "RadTextBox_ESR100Hz"
        Me.RadTextBox_ESR100Hz.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_ESR100Hz.TabIndex = 125
        Me.RadTextBox_ESR100Hz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_ESR100Hz.ThemeName = "Windows8"
        '
        'RadTextBox_ESRFoil10Percent
        '
        Me.RadTextBox_ESRFoil10Percent.AutoSize = False
        Me.RadTextBox_ESRFoil10Percent.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_ESRFoil10Percent.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_ESRFoil10Percent.Location = New System.Drawing.Point(326, 135)
        Me.RadTextBox_ESRFoil10Percent.Name = "RadTextBox_ESRFoil10Percent"
        Me.RadTextBox_ESRFoil10Percent.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_ESRFoil10Percent.TabIndex = 134
        Me.RadTextBox_ESRFoil10Percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_ESRFoil10Percent.ThemeName = "Windows8"
        '
        'RadTextBox_ESRFoil10
        '
        Me.RadTextBox_ESRFoil10.AutoSize = False
        Me.RadTextBox_ESRFoil10.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_ESRFoil10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_ESRFoil10.Location = New System.Drawing.Point(267, 135)
        Me.RadTextBox_ESRFoil10.Name = "RadTextBox_ESRFoil10"
        Me.RadTextBox_ESRFoil10.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_ESRFoil10.TabIndex = 130
        Me.RadTextBox_ESRFoil10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_ESRFoil10.ThemeName = "Windows8"
        '
        'RadTextBox_ESROxide10Percent
        '
        Me.RadTextBox_ESROxide10Percent.AutoSize = False
        Me.RadTextBox_ESROxide10Percent.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_ESROxide10Percent.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_ESROxide10Percent.Location = New System.Drawing.Point(326, 104)
        Me.RadTextBox_ESROxide10Percent.Name = "RadTextBox_ESROxide10Percent"
        Me.RadTextBox_ESROxide10Percent.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_ESROxide10Percent.TabIndex = 133
        Me.RadTextBox_ESROxide10Percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_ESROxide10Percent.ThemeName = "Windows8"
        '
        'RadTextBox_ESRTabbing10Percent
        '
        Me.RadTextBox_ESRTabbing10Percent.AutoSize = False
        Me.RadTextBox_ESRTabbing10Percent.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_ESRTabbing10Percent.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_ESRTabbing10Percent.Location = New System.Drawing.Point(326, 42)
        Me.RadTextBox_ESRTabbing10Percent.Name = "RadTextBox_ESRTabbing10Percent"
        Me.RadTextBox_ESRTabbing10Percent.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_ESRTabbing10Percent.TabIndex = 131
        Me.RadTextBox_ESRTabbing10Percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_ESRTabbing10Percent.ThemeName = "Windows8"
        '
        'RadTextBox_ESRTissue10Percent
        '
        Me.RadTextBox_ESRTissue10Percent.AutoSize = False
        Me.RadTextBox_ESRTissue10Percent.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_ESRTissue10Percent.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_ESRTissue10Percent.Location = New System.Drawing.Point(326, 73)
        Me.RadTextBox_ESRTissue10Percent.Name = "RadTextBox_ESRTissue10Percent"
        Me.RadTextBox_ESRTissue10Percent.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_ESRTissue10Percent.TabIndex = 132
        Me.RadTextBox_ESRTissue10Percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_ESRTissue10Percent.ThemeName = "Windows8"
        '
        'RadTextBox_ESRTabbing10
        '
        Me.RadTextBox_ESRTabbing10.AutoSize = False
        Me.RadTextBox_ESRTabbing10.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_ESRTabbing10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_ESRTabbing10.Location = New System.Drawing.Point(267, 42)
        Me.RadTextBox_ESRTabbing10.Name = "RadTextBox_ESRTabbing10"
        Me.RadTextBox_ESRTabbing10.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_ESRTabbing10.TabIndex = 126
        Me.RadTextBox_ESRTabbing10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_ESRTabbing10.ThemeName = "Windows8"
        '
        'RadTextBox_ESROxide10
        '
        Me.RadTextBox_ESROxide10.AutoSize = False
        Me.RadTextBox_ESROxide10.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_ESROxide10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_ESROxide10.Location = New System.Drawing.Point(267, 104)
        Me.RadTextBox_ESROxide10.Name = "RadTextBox_ESROxide10"
        Me.RadTextBox_ESROxide10.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_ESROxide10.TabIndex = 129
        Me.RadTextBox_ESROxide10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_ESROxide10.ThemeName = "Windows8"
        '
        'RadTextBox_ESRFoil100Percent
        '
        Me.RadTextBox_ESRFoil100Percent.AutoSize = False
        Me.RadTextBox_ESRFoil100Percent.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_ESRFoil100Percent.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_ESRFoil100Percent.Location = New System.Drawing.Point(195, 135)
        Me.RadTextBox_ESRFoil100Percent.Name = "RadTextBox_ESRFoil100Percent"
        Me.RadTextBox_ESRFoil100Percent.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_ESRFoil100Percent.TabIndex = 127
        Me.RadTextBox_ESRFoil100Percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_ESRFoil100Percent.ThemeName = "Windows8"
        '
        'RadTextBox_ESRTissue10
        '
        Me.RadTextBox_ESRTissue10.AutoSize = False
        Me.RadTextBox_ESRTissue10.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_ESRTissue10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_ESRTissue10.Location = New System.Drawing.Point(267, 73)
        Me.RadTextBox_ESRTissue10.Name = "RadTextBox_ESRTissue10"
        Me.RadTextBox_ESRTissue10.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_ESRTissue10.TabIndex = 128
        Me.RadTextBox_ESRTissue10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_ESRTissue10.ThemeName = "Windows8"
        '
        'RadTextBox_ESROxide100Percent
        '
        Me.RadTextBox_ESROxide100Percent.AutoSize = False
        Me.RadTextBox_ESROxide100Percent.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_ESROxide100Percent.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_ESROxide100Percent.Location = New System.Drawing.Point(195, 104)
        Me.RadTextBox_ESROxide100Percent.Name = "RadTextBox_ESROxide100Percent"
        Me.RadTextBox_ESROxide100Percent.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_ESROxide100Percent.TabIndex = 127
        Me.RadTextBox_ESROxide100Percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_ESROxide100Percent.ThemeName = "Windows8"
        '
        'RadTextBox_ESRTissue100Percent
        '
        Me.RadTextBox_ESRTissue100Percent.AutoSize = False
        Me.RadTextBox_ESRTissue100Percent.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_ESRTissue100Percent.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_ESRTissue100Percent.Location = New System.Drawing.Point(195, 73)
        Me.RadTextBox_ESRTissue100Percent.Name = "RadTextBox_ESRTissue100Percent"
        Me.RadTextBox_ESRTissue100Percent.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_ESRTissue100Percent.TabIndex = 126
        Me.RadTextBox_ESRTissue100Percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_ESRTissue100Percent.ThemeName = "Windows8"
        '
        'RadTextBox_ESRTabbing100Percent
        '
        Me.RadTextBox_ESRTabbing100Percent.AutoSize = False
        Me.RadTextBox_ESRTabbing100Percent.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_ESRTabbing100Percent.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_ESRTabbing100Percent.Location = New System.Drawing.Point(195, 42)
        Me.RadTextBox_ESRTabbing100Percent.Name = "RadTextBox_ESRTabbing100Percent"
        Me.RadTextBox_ESRTabbing100Percent.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_ESRTabbing100Percent.TabIndex = 125
        Me.RadTextBox_ESRTabbing100Percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_ESRTabbing100Percent.ThemeName = "Windows8"
        '
        'RadTextBox_ESRFoil100
        '
        Me.RadTextBox_ESRFoil100.AutoSize = False
        Me.RadTextBox_ESRFoil100.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_ESRFoil100.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_ESRFoil100.Location = New System.Drawing.Point(118, 135)
        Me.RadTextBox_ESRFoil100.Name = "RadTextBox_ESRFoil100"
        Me.RadTextBox_ESRFoil100.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_ESRFoil100.TabIndex = 126
        Me.RadTextBox_ESRFoil100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_ESRFoil100.ThemeName = "Windows8"
        '
        'RadTextBox_ESROxide100
        '
        Me.RadTextBox_ESROxide100.AutoSize = False
        Me.RadTextBox_ESROxide100.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_ESROxide100.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_ESROxide100.Location = New System.Drawing.Point(118, 104)
        Me.RadTextBox_ESROxide100.Name = "RadTextBox_ESROxide100"
        Me.RadTextBox_ESROxide100.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_ESROxide100.TabIndex = 126
        Me.RadTextBox_ESROxide100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_ESROxide100.ThemeName = "Windows8"
        '
        'RadTextBox_ESRTissue100
        '
        Me.RadTextBox_ESRTissue100.AutoSize = False
        Me.RadTextBox_ESRTissue100.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_ESRTissue100.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_ESRTissue100.Location = New System.Drawing.Point(118, 73)
        Me.RadTextBox_ESRTissue100.Name = "RadTextBox_ESRTissue100"
        Me.RadTextBox_ESRTissue100.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_ESRTissue100.TabIndex = 125
        Me.RadTextBox_ESRTissue100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_ESRTissue100.ThemeName = "Windows8"
        '
        'RadTextBox_ESRTabbing100
        '
        Me.RadTextBox_ESRTabbing100.AutoSize = False
        Me.RadTextBox_ESRTabbing100.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_ESRTabbing100.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_ESRTabbing100.Location = New System.Drawing.Point(118, 42)
        Me.RadTextBox_ESRTabbing100.Name = "RadTextBox_ESRTabbing100"
        Me.RadTextBox_ESRTabbing100.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_ESRTabbing100.TabIndex = 124
        Me.RadTextBox_ESRTabbing100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_ESRTabbing100.ThemeName = "Windows8"
        '
        'RadLabel_Z10KHz
        '
        Me.RadLabel_Z10KHz.AutoSize = False
        Me.RadLabel_Z10KHz.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Z10KHz.Location = New System.Drawing.Point(390, 93)
        Me.RadLabel_Z10KHz.Name = "RadLabel_Z10KHz"
        Me.RadLabel_Z10KHz.Size = New System.Drawing.Size(124, 31)
        Me.RadLabel_Z10KHz.TabIndex = 140
        Me.RadLabel_Z10KHz.Text = "DesignSummary_Z10KHz"
        Me.RadLabel_Z10KHz.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_Z10KHz.TextWrap = False
        Me.RadLabel_Z10KHz.ThemeName = "Windows8"
        '
        'RadLabel_ESR100Hz
        '
        Me.RadLabel_ESR100Hz.AutoSize = False
        Me.RadLabel_ESR100Hz.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_ESR100Hz.Location = New System.Drawing.Point(386, 24)
        Me.RadLabel_ESR100Hz.Name = "RadLabel_ESR100Hz"
        Me.RadLabel_ESR100Hz.Size = New System.Drawing.Size(124, 31)
        Me.RadLabel_ESR100Hz.TabIndex = 139
        Me.RadLabel_ESR100Hz.Text = "DesignSummary_ESR100Hz"
        Me.RadLabel_ESR100Hz.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_ESR100Hz.TextWrap = False
        Me.RadLabel_ESR100Hz.ThemeName = "Windows8"
        '
        'RadLabel_Total
        '
        Me.RadLabel_Total.AutoSize = False
        Me.RadLabel_Total.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Total.Location = New System.Drawing.Point(42, 176)
        Me.RadLabel_Total.Name = "RadLabel_Total"
        Me.RadLabel_Total.Size = New System.Drawing.Size(73, 24)
        Me.RadLabel_Total.TabIndex = 141
        Me.RadLabel_Total.Text = "Total"
        Me.RadLabel_Total.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Total.TextWrap = False
        Me.RadLabel_Total.ThemeName = "Windows8"
        '
        'RadLabel_ESRFoil
        '
        Me.RadLabel_ESRFoil.AutoSize = False
        Me.RadLabel_ESRFoil.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_ESRFoil.Location = New System.Drawing.Point(42, 134)
        Me.RadLabel_ESRFoil.Name = "RadLabel_ESRFoil"
        Me.RadLabel_ESRFoil.Size = New System.Drawing.Size(73, 31)
        Me.RadLabel_ESRFoil.TabIndex = 140
        Me.RadLabel_ESRFoil.Text = "DesignSummary_ESRFoil"
        Me.RadLabel_ESRFoil.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_ESRFoil.TextWrap = False
        Me.RadLabel_ESRFoil.ThemeName = "Windows8"
        '
        'RadLabel_ESROxide
        '
        Me.RadLabel_ESROxide.AutoSize = False
        Me.RadLabel_ESROxide.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_ESROxide.Location = New System.Drawing.Point(42, 103)
        Me.RadLabel_ESROxide.Name = "RadLabel_ESROxide"
        Me.RadLabel_ESROxide.Size = New System.Drawing.Size(73, 31)
        Me.RadLabel_ESROxide.TabIndex = 139
        Me.RadLabel_ESROxide.Text = "DesignSummary_ESROxide"
        Me.RadLabel_ESROxide.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_ESROxide.TextWrap = False
        Me.RadLabel_ESROxide.ThemeName = "Windows8"
        '
        'RadLabel_ESRTissue
        '
        Me.RadLabel_ESRTissue.AutoSize = False
        Me.RadLabel_ESRTissue.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_ESRTissue.Location = New System.Drawing.Point(42, 72)
        Me.RadLabel_ESRTissue.Name = "RadLabel_ESRTissue"
        Me.RadLabel_ESRTissue.Size = New System.Drawing.Size(73, 31)
        Me.RadLabel_ESRTissue.TabIndex = 138
        Me.RadLabel_ESRTissue.Text = "DesignSummary_ESRTissue"
        Me.RadLabel_ESRTissue.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_ESRTissue.TextWrap = False
        Me.RadLabel_ESRTissue.ThemeName = "Windows8"
        '
        'RadLabel_ESRTabbing
        '
        Me.RadLabel_ESRTabbing.AutoSize = False
        Me.RadLabel_ESRTabbing.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_ESRTabbing.Location = New System.Drawing.Point(42, 41)
        Me.RadLabel_ESRTabbing.Name = "RadLabel_ESRTabbing"
        Me.RadLabel_ESRTabbing.Size = New System.Drawing.Size(73, 31)
        Me.RadLabel_ESRTabbing.TabIndex = 137
        Me.RadLabel_ESRTabbing.Text = "DesignSummary_ESRTabbing"
        Me.RadLabel_ESRTabbing.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_ESRTabbing.TextWrap = False
        Me.RadLabel_ESRTabbing.ThemeName = "Windows8"
        '
        'RadLabel_At10kHz
        '
        Me.RadLabel_At10kHz.AutoSize = False
        Me.RadLabel_At10kHz.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_At10kHz.Location = New System.Drawing.Point(281, 11)
        Me.RadLabel_At10kHz.Name = "RadLabel_At10kHz"
        Me.RadLabel_At10kHz.Size = New System.Drawing.Size(73, 31)
        Me.RadLabel_At10kHz.TabIndex = 136
        Me.RadLabel_At10kHz.Text = "DesignSummary_At10kHz"
        Me.RadLabel_At10kHz.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_At10kHz.TextWrap = False
        Me.RadLabel_At10kHz.ThemeName = "Windows8"
        '
        'RadLabel_At100Hz
        '
        Me.RadLabel_At100Hz.AutoSize = False
        Me.RadLabel_At100Hz.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_At100Hz.Location = New System.Drawing.Point(151, 9)
        Me.RadLabel_At100Hz.Name = "RadLabel_At100Hz"
        Me.RadLabel_At100Hz.Size = New System.Drawing.Size(73, 31)
        Me.RadLabel_At100Hz.TabIndex = 135
        Me.RadLabel_At100Hz.Text = "DesignSummary_At100Hz"
        Me.RadLabel_At100Hz.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_At100Hz.TextWrap = False
        Me.RadLabel_At100Hz.ThemeName = "Windows8"
        '
        'RadButton_ESRGraphForm
        '
        Me.RadButton_ESRGraphForm.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadButton_ESRGraphForm.Location = New System.Drawing.Point(151, 174)
        Me.RadButton_ESRGraphForm.Name = "RadButton_ESRGraphForm"
        Me.RadButton_ESRGraphForm.Size = New System.Drawing.Size(203, 27)
        Me.RadButton_ESRGraphForm.TabIndex = 86
        Me.RadButton_ESRGraphForm.Text = "DesignSummary_ESRGraphForm"
        Me.RadButton_ESRGraphForm.ThemeName = "Windows8"
        '
        'Panel20
        '
        Me.Panel20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel20.Controls.Add(Me.RadLabel_ESRData)
        Me.Panel20.Location = New System.Drawing.Point(0, 0)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(127, 26)
        Me.Panel20.TabIndex = 40
        '
        'RadLabel_ESRData
        '
        Me.RadLabel_ESRData.AutoSize = False
        Me.RadLabel_ESRData.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_ESRData.Location = New System.Drawing.Point(0, 0)
        Me.RadLabel_ESRData.Name = "RadLabel_ESRData"
        Me.RadLabel_ESRData.Size = New System.Drawing.Size(124, 23)
        Me.RadLabel_ESRData.TabIndex = 134
        Me.RadLabel_ESRData.Text = "DesignSummary_ESRData"
        Me.RadLabel_ESRData.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_ESRData.TextWrap = False
        Me.RadLabel_ESRData.ThemeName = "Windows8"
        '
        'RadLabel_NoESRDataOnStyleDesign
        '
        Me.RadLabel_NoESRDataOnStyleDesign.AutoSize = False
        Me.RadLabel_NoESRDataOnStyleDesign.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_NoESRDataOnStyleDesign.Location = New System.Drawing.Point(0, 0)
        Me.RadLabel_NoESRDataOnStyleDesign.Name = "RadLabel_NoESRDataOnStyleDesign"
        Me.RadLabel_NoESRDataOnStyleDesign.Size = New System.Drawing.Size(530, 233)
        Me.RadLabel_NoESRDataOnStyleDesign.TabIndex = 88
        Me.RadLabel_NoESRDataOnStyleDesign.Text = "DesignSummary_NoESRDataOnStyleDesign"
        Me.RadLabel_NoESRDataOnStyleDesign.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.RadDropDownList_ElytePartNumber)
        Me.Panel6.Controls.Add(Me.RadDropDownList_TabPartNumber)
        Me.Panel6.Controls.Add(Me.RadDropDownList_CathPartNumber)
        Me.Panel6.Controls.Add(Me.Panel5)
        Me.Panel6.Controls.Add(Me.Panel23)
        Me.Panel6.Controls.Add(Me.Panel19)
        Me.Panel6.Controls.Add(Me.Panel22)
        Me.Panel6.Controls.Add(Me.RadTextBox_ElyteUnitCost)
        Me.Panel6.Controls.Add(Me.RadTextBox_ElyteAmount)
        Me.Panel6.Controls.Add(Me.RadLabel_ElyteUnitCostUnit)
        Me.Panel6.Controls.Add(Me.RadTextBox_ElyteCost)
        Me.Panel6.Controls.Add(Me.RadTextBox_TabCost)
        Me.Panel6.Controls.Add(Me.RadTextBox_TabAmount)
        Me.Panel6.Controls.Add(Me.RadTextBox_TabUnitCost)
        Me.Panel6.Controls.Add(Me.RadLabel_TabUnitCostUnit)
        Me.Panel6.Controls.Add(Me.RadLabel_TabDetailUnit)
        Me.Panel6.Controls.Add(Me.RadTextBox_TabThick)
        Me.Panel6.Controls.Add(Me.RadLabel_TabThickUnit)
        Me.Panel6.Controls.Add(Me.RadTextBox_CathCost)
        Me.Panel6.Controls.Add(Me.RadTextBox_CathAmount)
        Me.Panel6.Controls.Add(Me.RadTextBox_CathUnitCost)
        Me.Panel6.Controls.Add(Me.RadLabel_CathUnitCostUnit)
        Me.Panel6.Controls.Add(Me.RadTextBox_CathDetail)
        Me.Panel6.Controls.Add(Me.RadLabel_CathDetailUnit)
        Me.Panel6.Controls.Add(Me.RadTextBox_CathThick)
        Me.Panel6.Controls.Add(Me.RadLabel_CathThickUnit)
        Me.Panel6.Controls.Add(Me.RadTextBox_CathGain)
        Me.Panel6.Controls.Add(Me.RadLabel_CathGainUnit)
        Me.Panel6.Controls.Add(Me.RadTextBox_CathWidth)
        Me.Panel6.Controls.Add(Me.RadLabel_WindingMaterialsName)
        Me.Panel6.Controls.Add(Me.RadLabel_WindingMaterialsFV)
        Me.Panel6.Controls.Add(Me.RadLabel_WindingMaterialsWidth)
        Me.Panel6.Controls.Add(Me.RadLabel_WindingMaterialsGain)
        Me.Panel6.Controls.Add(Me.RadLabel_WindingMaterialsThick)
        Me.Panel6.Controls.Add(Me.RadLabel_WindingMaterialsDetail)
        Me.Panel6.Controls.Add(Me.RadLabel_WindingMaterialsUnitcost)
        Me.Panel6.Controls.Add(Me.RadLabel_WindingMaterialsAmount)
        Me.Panel6.Controls.Add(Me.RadLabel_WindingMaterialsCost)
        Me.Panel6.Controls.Add(Me.RadLabel_WindingMaterialsLengths)
        Me.Panel6.Controls.Add(Me.Panel18)
        Me.Panel6.Controls.Add(Me.RadLabel_Elyte)
        Me.Panel6.Controls.Add(Me.RadLabel_Tab)
        Me.Panel6.Controls.Add(Me.Panel15)
        Me.Panel6.Controls.Add(Me.Panel16)
        Me.Panel6.Controls.Add(Me.RadLabel_Cath)
        Me.Panel6.Controls.Add(Me.Panel14)
        Me.Panel6.Controls.Add(Me.Panel12)
        Me.Panel6.Controls.Add(Me.Panel11)
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(955, 955)
        Me.Panel6.TabIndex = 0
        '
        'RadDropDownList_ElytePartNumber
        '
        Me.RadDropDownList_ElytePartNumber.AutoSize = False
        Me.RadDropDownList_ElytePartNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_ElytePartNumber.Location = New System.Drawing.Point(63, 382)
        Me.RadDropDownList_ElytePartNumber.Name = "RadDropDownList_ElytePartNumber"
        Me.RadDropDownList_ElytePartNumber.Size = New System.Drawing.Size(107, 29)
        Me.RadDropDownList_ElytePartNumber.TabIndex = 170
        Me.RadDropDownList_ElytePartNumber.ThemeName = "Windows8"
        '
        'RadDropDownList_TabPartNumber
        '
        Me.RadDropDownList_TabPartNumber.AutoSize = False
        Me.RadDropDownList_TabPartNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_TabPartNumber.Location = New System.Drawing.Point(63, 351)
        Me.RadDropDownList_TabPartNumber.Name = "RadDropDownList_TabPartNumber"
        Me.RadDropDownList_TabPartNumber.Size = New System.Drawing.Size(107, 29)
        Me.RadDropDownList_TabPartNumber.TabIndex = 169
        Me.RadDropDownList_TabPartNumber.ThemeName = "Windows8"
        '
        'RadDropDownList_CathPartNumber
        '
        Me.RadDropDownList_CathPartNumber.AutoSize = False
        Me.RadDropDownList_CathPartNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_CathPartNumber.Location = New System.Drawing.Point(63, 187)
        Me.RadDropDownList_CathPartNumber.Name = "RadDropDownList_CathPartNumber"
        Me.RadDropDownList_CathPartNumber.Size = New System.Drawing.Size(107, 29)
        Me.RadDropDownList_CathPartNumber.TabIndex = 165
        Me.RadDropDownList_CathPartNumber.ThemeName = "Windows8"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.RadListView_AssemblyNotes)
        Me.Panel5.Controls.Add(Me.RadLabel_PrintDrawing)
        Me.Panel5.Controls.Add(Me.RadLabel_DesignNotes)
        Me.Panel5.Controls.Add(Me.RadLabel_PrintNotes)
        Me.Panel5.Controls.Add(Me.RadLabel_AssemblyNotes)
        Me.Panel5.Controls.Add(Me.RadCheckBox_Scrollbar)
        Me.Panel5.Controls.Add(Me.RadButton_Center)
        Me.Panel5.Controls.Add(Me.RadDropDownList_PrintNumber)
        Me.Panel5.Controls.Add(Me.RadTextBox_DesignNotes)
        Me.Panel5.Controls.Add(Me.RadTextBox_PrintNotes)
        Me.Panel5.Location = New System.Drawing.Point(-3, 716)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(962, 237)
        Me.Panel5.TabIndex = 160
        '
        'RadLabel_CoverSampleCostButtons
        '
        Me.RadLabel_CoverSampleCostButtons.AutoSize = False
        Me.RadLabel_CoverSampleCostButtons.Location = New System.Drawing.Point(0, 0)
        Me.RadLabel_CoverSampleCostButtons.Name = "RadLabel_CoverSampleCostButtons"
        Me.RadLabel_CoverSampleCostButtons.Size = New System.Drawing.Size(421, 79)
        Me.RadLabel_CoverSampleCostButtons.TabIndex = 5
        '
        'RadListView_AssemblyNotes
        '
        ListViewDetailColumn1.HeaderText = "Key"
        ListViewDetailColumn1.Width = 85.0!
        ListViewDetailColumn2.HeaderText = "Value"
        ListViewDetailColumn2.Width = 299.0!
        Me.RadListView_AssemblyNotes.Columns.AddRange(New Telerik.WinControls.UI.ListViewDetailColumn() {ListViewDetailColumn1, ListViewDetailColumn2})
        ListViewDataItem1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ListViewDataItem1.ForeColor = System.Drawing.Color.Black
        ListViewDataItem1.Key = "x"
        ListViewDataItem1.Tag = "x"
        ListViewDataItem1.Text = "xkkk"
        ListViewDataItem2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ListViewDataItem2.ForeColor = System.Drawing.Color.Black
        ListViewDataItem2.Key = "xxx"
        ListViewDataItem2.Tag = "xxxx"
        ListViewDataItem2.Text = "xxx"
        Me.RadListView_AssemblyNotes.Items.AddRange(New Telerik.WinControls.UI.ListViewDataItem() {ListViewDataItem1, ListViewDataItem2})
        Me.RadListView_AssemblyNotes.ItemSize = New System.Drawing.Size(385, 20)
        Me.RadListView_AssemblyNotes.ItemSpacing = -1
        Me.RadListView_AssemblyNotes.Location = New System.Drawing.Point(14, 38)
        Me.RadListView_AssemblyNotes.Name = "RadListView_AssemblyNotes"
        Me.RadListView_AssemblyNotes.ShowColumnHeaders = False
        Me.RadListView_AssemblyNotes.ShowGridLines = True
        Me.RadListView_AssemblyNotes.Size = New System.Drawing.Size(385, 191)
        Me.RadListView_AssemblyNotes.TabIndex = 153
        Me.RadListView_AssemblyNotes.ThemeName = "Windows8"
        Me.RadListView_AssemblyNotes.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'RadLabel_PrintDrawing
        '
        Me.RadLabel_PrintDrawing.AutoSize = False
        Me.RadLabel_PrintDrawing.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_PrintDrawing.Location = New System.Drawing.Point(435, 170)
        Me.RadLabel_PrintDrawing.Name = "RadLabel_PrintDrawing"
        Me.RadLabel_PrintDrawing.Size = New System.Drawing.Size(111, 31)
        Me.RadLabel_PrintDrawing.TabIndex = 149
        Me.RadLabel_PrintDrawing.Text = "DesignSummary_PrintDrawing"
        Me.RadLabel_PrintDrawing.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_PrintDrawing.TextWrap = False
        Me.RadLabel_PrintDrawing.ThemeName = "Windows8"
        '
        'RadLabel_DesignNotes
        '
        Me.RadLabel_DesignNotes.AutoSize = False
        Me.RadLabel_DesignNotes.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_DesignNotes.Location = New System.Drawing.Point(715, 6)
        Me.RadLabel_DesignNotes.Name = "RadLabel_DesignNotes"
        Me.RadLabel_DesignNotes.Size = New System.Drawing.Size(217, 31)
        Me.RadLabel_DesignNotes.TabIndex = 148
        Me.RadLabel_DesignNotes.Text = "DesignSummary_DesignNotes"
        Me.RadLabel_DesignNotes.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_DesignNotes.TextWrap = False
        Me.RadLabel_DesignNotes.ThemeName = "Windows8"
        '
        'RadLabel_PrintNotes
        '
        Me.RadLabel_PrintNotes.AutoSize = False
        Me.RadLabel_PrintNotes.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_PrintNotes.Location = New System.Drawing.Point(438, 6)
        Me.RadLabel_PrintNotes.Name = "RadLabel_PrintNotes"
        Me.RadLabel_PrintNotes.Size = New System.Drawing.Size(217, 31)
        Me.RadLabel_PrintNotes.TabIndex = 147
        Me.RadLabel_PrintNotes.Text = "DesignSummary_PrintNotes"
        Me.RadLabel_PrintNotes.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_PrintNotes.TextWrap = False
        Me.RadLabel_PrintNotes.ThemeName = "Windows8"
        '
        'RadLabel_AssemblyNotes
        '
        Me.RadLabel_AssemblyNotes.AutoSize = False
        Me.RadLabel_AssemblyNotes.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_AssemblyNotes.Location = New System.Drawing.Point(16, 6)
        Me.RadLabel_AssemblyNotes.Name = "RadLabel_AssemblyNotes"
        Me.RadLabel_AssemblyNotes.Size = New System.Drawing.Size(327, 31)
        Me.RadLabel_AssemblyNotes.TabIndex = 146
        Me.RadLabel_AssemblyNotes.Text = "DesignSummary_AssemblyNotes"
        Me.RadLabel_AssemblyNotes.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_AssemblyNotes.TextWrap = False
        Me.RadLabel_AssemblyNotes.ThemeName = "Windows8"
        '
        'RadCheckBox_Scrollbar
        '
        Me.RadCheckBox_Scrollbar.AutoSize = False
        Me.RadCheckBox_Scrollbar.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Scrollbar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_Scrollbar.Location = New System.Drawing.Point(716, 191)
        Me.RadCheckBox_Scrollbar.Name = "RadCheckBox_Scrollbar"
        Me.RadCheckBox_Scrollbar.Size = New System.Drawing.Size(101, 29)
        Me.RadCheckBox_Scrollbar.TabIndex = 145
        Me.RadCheckBox_Scrollbar.Text = "DesignSummary_Scrollbar"
        Me.RadCheckBox_Scrollbar.ThemeName = "Windows8"
        '
        'RadButton_Center
        '
        Me.RadButton_Center.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadButton_Center.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Center.Location = New System.Drawing.Point(560, 170)
        Me.RadButton_Center.Name = "RadButton_Center"
        Me.RadButton_Center.Size = New System.Drawing.Size(95, 27)
        Me.RadButton_Center.TabIndex = 144
        Me.RadButton_Center.Text = "DesignSummary_Center"
        Me.RadButton_Center.TextWrap = True
        Me.RadButton_Center.ThemeName = "Windows8"
        '
        'RadDropDownList_PrintNumber
        '
        Me.RadDropDownList_PrintNumber.AutoSize = False
        Me.RadDropDownList_PrintNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadDropDownList_PrintNumber.Location = New System.Drawing.Point(439, 204)
        Me.RadDropDownList_PrintNumber.Name = "RadDropDownList_PrintNumber"
        Me.RadDropDownList_PrintNumber.Size = New System.Drawing.Size(218, 25)
        Me.RadDropDownList_PrintNumber.TabIndex = 143
        Me.RadDropDownList_PrintNumber.ThemeName = "Windows8"
        '
        'RadTextBox_DesignNotes
        '
        Me.RadTextBox_DesignNotes.AutoSize = False
        Me.RadTextBox_DesignNotes.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_DesignNotes.Location = New System.Drawing.Point(716, 38)
        Me.RadTextBox_DesignNotes.Multiline = True
        Me.RadTextBox_DesignNotes.Name = "RadTextBox_DesignNotes"
        Me.RadTextBox_DesignNotes.Size = New System.Drawing.Size(216, 126)
        Me.RadTextBox_DesignNotes.TabIndex = 142
        Me.RadTextBox_DesignNotes.ThemeName = "Windows8"
        '
        'RadTextBox_PrintNotes
        '
        Me.RadTextBox_PrintNotes.AutoSize = False
        Me.RadTextBox_PrintNotes.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_PrintNotes.Location = New System.Drawing.Point(439, 38)
        Me.RadTextBox_PrintNotes.Multiline = True
        Me.RadTextBox_PrintNotes.Name = "RadTextBox_PrintNotes"
        Me.RadTextBox_PrintNotes.Size = New System.Drawing.Size(216, 126)
        Me.RadTextBox_PrintNotes.TabIndex = 141
        Me.RadTextBox_PrintNotes.ThemeName = "Windows8"
        '
        'RadTextBox_ElyteUnitCost
        '
        Me.RadTextBox_ElyteUnitCost.AutoSize = False
        Me.RadTextBox_ElyteUnitCost.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_ElyteUnitCost.Location = New System.Drawing.Point(506, 382)
        Me.RadTextBox_ElyteUnitCost.Name = "RadTextBox_ElyteUnitCost"
        Me.RadTextBox_ElyteUnitCost.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_ElyteUnitCost.TabIndex = 158
        Me.RadTextBox_ElyteUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_ElyteUnitCost.ThemeName = "Windows8"
        '
        'RadTextBox_ElyteAmount
        '
        Me.RadTextBox_ElyteAmount.AutoSize = False
        Me.RadTextBox_ElyteAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_ElyteAmount.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_ElyteAmount.Location = New System.Drawing.Point(592, 381)
        Me.RadTextBox_ElyteAmount.Name = "RadTextBox_ElyteAmount"
        Me.RadTextBox_ElyteAmount.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_ElyteAmount.TabIndex = 158
        Me.RadTextBox_ElyteAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_ElyteAmount.ThemeName = "Windows8"
        '
        'RadLabel_ElyteUnitCostUnit
        '
        Me.RadLabel_ElyteUnitCostUnit.AutoSize = False
        Me.RadLabel_ElyteUnitCostUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_ElyteUnitCostUnit.Location = New System.Drawing.Point(557, 381)
        Me.RadLabel_ElyteUnitCostUnit.Name = "RadLabel_ElyteUnitCostUnit"
        Me.RadLabel_ElyteUnitCostUnit.Size = New System.Drawing.Size(42, 30)
        Me.RadLabel_ElyteUnitCostUnit.TabIndex = 154
        Me.RadLabel_ElyteUnitCostUnit.Text = "Units_PerKg"
        Me.RadLabel_ElyteUnitCostUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_ElyteUnitCostUnit.TextWrap = False
        Me.RadLabel_ElyteUnitCostUnit.ThemeName = "Windows8"
        '
        'RadTextBox_ElyteCost
        '
        Me.RadTextBox_ElyteCost.AutoSize = False
        Me.RadTextBox_ElyteCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_ElyteCost.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_ElyteCost.Location = New System.Drawing.Point(669, 381)
        Me.RadTextBox_ElyteCost.Name = "RadTextBox_ElyteCost"
        Me.RadTextBox_ElyteCost.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_ElyteCost.TabIndex = 159
        Me.RadTextBox_ElyteCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_ElyteCost.ThemeName = "Windows8"
        '
        'RadTextBox_TabCost
        '
        Me.RadTextBox_TabCost.AutoSize = False
        Me.RadTextBox_TabCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_TabCost.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_TabCost.Location = New System.Drawing.Point(669, 350)
        Me.RadTextBox_TabCost.Name = "RadTextBox_TabCost"
        Me.RadTextBox_TabCost.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_TabCost.TabIndex = 157
        Me.RadTextBox_TabCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TabCost.ThemeName = "Windows8"
        '
        'RadTextBox_TabAmount
        '
        Me.RadTextBox_TabAmount.AutoSize = False
        Me.RadTextBox_TabAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_TabAmount.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_TabAmount.Location = New System.Drawing.Point(592, 350)
        Me.RadTextBox_TabAmount.Name = "RadTextBox_TabAmount"
        Me.RadTextBox_TabAmount.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_TabAmount.TabIndex = 156
        Me.RadTextBox_TabAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TabAmount.ThemeName = "Windows8"
        '
        'RadTextBox_TabUnitCost
        '
        Me.RadTextBox_TabUnitCost.AutoSize = False
        Me.RadTextBox_TabUnitCost.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_TabUnitCost.Location = New System.Drawing.Point(506, 351)
        Me.RadTextBox_TabUnitCost.Name = "RadTextBox_TabUnitCost"
        Me.RadTextBox_TabUnitCost.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_TabUnitCost.TabIndex = 157
        Me.RadTextBox_TabUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TabUnitCost.ThemeName = "Windows8"
        '
        'RadLabel_TabUnitCostUnit
        '
        Me.RadLabel_TabUnitCostUnit.AutoSize = False
        Me.RadLabel_TabUnitCostUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_TabUnitCostUnit.Location = New System.Drawing.Point(557, 350)
        Me.RadLabel_TabUnitCostUnit.Name = "RadLabel_TabUnitCostUnit"
        Me.RadLabel_TabUnitCostUnit.Size = New System.Drawing.Size(42, 30)
        Me.RadLabel_TabUnitCostUnit.TabIndex = 153
        Me.RadLabel_TabUnitCostUnit.Text = "Units_PerKg"
        Me.RadLabel_TabUnitCostUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_TabUnitCostUnit.TextWrap = False
        Me.RadLabel_TabUnitCostUnit.ThemeName = "Windows8"
        '
        'RadLabel_TabDetailUnit
        '
        Me.RadLabel_TabDetailUnit.AutoSize = False
        Me.RadLabel_TabDetailUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_TabDetailUnit.Location = New System.Drawing.Point(453, 351)
        Me.RadLabel_TabDetailUnit.Name = "RadLabel_TabDetailUnit"
        Me.RadLabel_TabDetailUnit.Size = New System.Drawing.Size(61, 30)
        Me.RadLabel_TabDetailUnit.TabIndex = 152
        Me.RadLabel_TabDetailUnit.Text = "Unit_GramPerCubicCm"
        Me.RadLabel_TabDetailUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_TabDetailUnit.TextWrap = False
        Me.RadLabel_TabDetailUnit.ThemeName = "Windows8"
        '
        'RadTextBox_TabThick
        '
        Me.RadTextBox_TabThick.AutoSize = False
        Me.RadTextBox_TabThick.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_TabThick.Location = New System.Drawing.Point(334, 351)
        Me.RadTextBox_TabThick.Name = "RadTextBox_TabThick"
        Me.RadTextBox_TabThick.Size = New System.Drawing.Size(41, 29)
        Me.RadTextBox_TabThick.TabIndex = 155
        Me.RadTextBox_TabThick.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_TabThick.ThemeName = "Windows8"
        '
        'RadLabel_TabThickUnit
        '
        Me.RadLabel_TabThickUnit.AutoSize = False
        Me.RadLabel_TabThickUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_TabThickUnit.Location = New System.Drawing.Point(372, 352)
        Me.RadLabel_TabThickUnit.Name = "RadLabel_TabThickUnit"
        Me.RadLabel_TabThickUnit.Size = New System.Drawing.Size(42, 30)
        Me.RadLabel_TabThickUnit.TabIndex = 150
        Me.RadLabel_TabThickUnit.Text = "Units_MicroMeter"
        Me.RadLabel_TabThickUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_TabThickUnit.TextWrap = False
        Me.RadLabel_TabThickUnit.ThemeName = "Windows8"
        '
        'RadTextBox_CathCost
        '
        Me.RadTextBox_CathCost.AutoSize = False
        Me.RadTextBox_CathCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_CathCost.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_CathCost.Location = New System.Drawing.Point(669, 186)
        Me.RadTextBox_CathCost.Name = "RadTextBox_CathCost"
        Me.RadTextBox_CathCost.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_CathCost.TabIndex = 157
        Me.RadTextBox_CathCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_CathCost.ThemeName = "Windows8"
        '
        'RadTextBox_CathAmount
        '
        Me.RadTextBox_CathAmount.AutoSize = False
        Me.RadTextBox_CathAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox_CathAmount.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_CathAmount.Location = New System.Drawing.Point(592, 186)
        Me.RadTextBox_CathAmount.Name = "RadTextBox_CathAmount"
        Me.RadTextBox_CathAmount.Size = New System.Drawing.Size(71, 29)
        Me.RadTextBox_CathAmount.TabIndex = 155
        Me.RadTextBox_CathAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_CathAmount.ThemeName = "Windows8"
        '
        'RadTextBox_CathUnitCost
        '
        Me.RadTextBox_CathUnitCost.AutoSize = False
        Me.RadTextBox_CathUnitCost.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_CathUnitCost.Location = New System.Drawing.Point(506, 187)
        Me.RadTextBox_CathUnitCost.Name = "RadTextBox_CathUnitCost"
        Me.RadTextBox_CathUnitCost.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_CathUnitCost.TabIndex = 156
        Me.RadTextBox_CathUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_CathUnitCost.ThemeName = "Windows8"
        '
        'RadLabel_CathUnitCostUnit
        '
        Me.RadLabel_CathUnitCostUnit.AutoSize = False
        Me.RadLabel_CathUnitCostUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_CathUnitCostUnit.Location = New System.Drawing.Point(557, 187)
        Me.RadLabel_CathUnitCostUnit.Name = "RadLabel_CathUnitCostUnit"
        Me.RadLabel_CathUnitCostUnit.Size = New System.Drawing.Size(42, 30)
        Me.RadLabel_CathUnitCostUnit.TabIndex = 152
        Me.RadLabel_CathUnitCostUnit.Text = "Units_PerMeterSquare"
        Me.RadLabel_CathUnitCostUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_CathUnitCostUnit.TextWrap = False
        Me.RadLabel_CathUnitCostUnit.ThemeName = "Windows8"
        '
        'RadTextBox_CathDetail
        '
        Me.RadTextBox_CathDetail.AutoSize = False
        Me.RadTextBox_CathDetail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_CathDetail.Location = New System.Drawing.Point(402, 187)
        Me.RadTextBox_CathDetail.Name = "RadTextBox_CathDetail"
        Me.RadTextBox_CathDetail.Size = New System.Drawing.Size(53, 29)
        Me.RadTextBox_CathDetail.TabIndex = 155
        Me.RadTextBox_CathDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_CathDetail.ThemeName = "Windows8"
        '
        'RadLabel_CathDetailUnit
        '
        Me.RadLabel_CathDetailUnit.AutoSize = False
        Me.RadLabel_CathDetailUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_CathDetailUnit.Location = New System.Drawing.Point(453, 187)
        Me.RadLabel_CathDetailUnit.Name = "RadLabel_CathDetailUnit"
        Me.RadLabel_CathDetailUnit.Size = New System.Drawing.Size(61, 30)
        Me.RadLabel_CathDetailUnit.TabIndex = 151
        Me.RadLabel_CathDetailUnit.Text = "Units_MeterSquarePerKilogram"
        Me.RadLabel_CathDetailUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_CathDetailUnit.TextWrap = False
        Me.RadLabel_CathDetailUnit.ThemeName = "Windows8"
        '
        'RadTextBox_CathThick
        '
        Me.RadTextBox_CathThick.AutoSize = False
        Me.RadTextBox_CathThick.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_CathThick.Location = New System.Drawing.Point(334, 187)
        Me.RadTextBox_CathThick.Name = "RadTextBox_CathThick"
        Me.RadTextBox_CathThick.Size = New System.Drawing.Size(41, 29)
        Me.RadTextBox_CathThick.TabIndex = 154
        Me.RadTextBox_CathThick.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_CathThick.ThemeName = "Windows8"
        '
        'RadLabel_CathThickUnit
        '
        Me.RadLabel_CathThickUnit.AutoSize = False
        Me.RadLabel_CathThickUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_CathThickUnit.Location = New System.Drawing.Point(372, 188)
        Me.RadLabel_CathThickUnit.Name = "RadLabel_CathThickUnit"
        Me.RadLabel_CathThickUnit.Size = New System.Drawing.Size(42, 30)
        Me.RadLabel_CathThickUnit.TabIndex = 149
        Me.RadLabel_CathThickUnit.Text = "Units_MicroMeter"
        Me.RadLabel_CathThickUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_CathThickUnit.TextWrap = False
        Me.RadLabel_CathThickUnit.ThemeName = "Windows8"
        '
        'RadTextBox_CathGain
        '
        Me.RadTextBox_CathGain.AutoSize = False
        Me.RadTextBox_CathGain.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_CathGain.Location = New System.Drawing.Point(224, 188)
        Me.RadTextBox_CathGain.Name = "RadTextBox_CathGain"
        Me.RadTextBox_CathGain.Size = New System.Drawing.Size(58, 29)
        Me.RadTextBox_CathGain.TabIndex = 154
        Me.RadTextBox_CathGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_CathGain.ThemeName = "Windows8"
        '
        'RadLabel_CathGainUnit
        '
        Me.RadLabel_CathGainUnit.AutoSize = False
        Me.RadLabel_CathGainUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_CathGainUnit.Location = New System.Drawing.Point(279, 190)
        Me.RadLabel_CathGainUnit.Name = "RadLabel_CathGainUnit"
        Me.RadLabel_CathGainUnit.Size = New System.Drawing.Size(64, 30)
        Me.RadLabel_CathGainUnit.TabIndex = 150
        Me.RadLabel_CathGainUnit.Text = "Units_MicroFaradPerSquareCm"
        Me.RadLabel_CathGainUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_CathGainUnit.TextWrap = False
        Me.RadLabel_CathGainUnit.ThemeName = "Windows8"
        '
        'RadTextBox_CathWidth
        '
        Me.RadTextBox_CathWidth.AutoSize = False
        Me.RadTextBox_CathWidth.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_CathWidth.Location = New System.Drawing.Point(176, 188)
        Me.RadTextBox_CathWidth.Name = "RadTextBox_CathWidth"
        Me.RadTextBox_CathWidth.Size = New System.Drawing.Size(41, 29)
        Me.RadTextBox_CathWidth.TabIndex = 152
        Me.RadTextBox_CathWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_CathWidth.ThemeName = "Windows8"
        '
        'RadLabel_WindingMaterialsName
        '
        Me.RadLabel_WindingMaterialsName.AutoSize = False
        Me.RadLabel_WindingMaterialsName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_WindingMaterialsName.Location = New System.Drawing.Point(59, 28)
        Me.RadLabel_WindingMaterialsName.Name = "RadLabel_WindingMaterialsName"
        Me.RadLabel_WindingMaterialsName.Size = New System.Drawing.Size(66, 26)
        Me.RadLabel_WindingMaterialsName.TabIndex = 117
        Me.RadLabel_WindingMaterialsName.Text = "DesignSummary_Name"
        Me.RadLabel_WindingMaterialsName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_WindingMaterialsName.TextWrap = False
        Me.RadLabel_WindingMaterialsName.ThemeName = "Windows8"
        '
        'RadLabel_WindingMaterialsFV
        '
        Me.RadLabel_WindingMaterialsFV.AutoSize = False
        Me.RadLabel_WindingMaterialsFV.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_WindingMaterialsFV.Location = New System.Drawing.Point(130, 28)
        Me.RadLabel_WindingMaterialsFV.Name = "RadLabel_WindingMaterialsFV"
        Me.RadLabel_WindingMaterialsFV.Size = New System.Drawing.Size(42, 26)
        Me.RadLabel_WindingMaterialsFV.TabIndex = 118
        Me.RadLabel_WindingMaterialsFV.Text = "DesignSummary_FV"
        Me.RadLabel_WindingMaterialsFV.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_WindingMaterialsFV.TextWrap = False
        Me.RadLabel_WindingMaterialsFV.ThemeName = "Windows8"
        '
        'RadLabel_WindingMaterialsWidth
        '
        Me.RadLabel_WindingMaterialsWidth.AutoSize = False
        Me.RadLabel_WindingMaterialsWidth.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_WindingMaterialsWidth.Location = New System.Drawing.Point(177, 28)
        Me.RadLabel_WindingMaterialsWidth.Name = "RadLabel_WindingMaterialsWidth"
        Me.RadLabel_WindingMaterialsWidth.Size = New System.Drawing.Size(61, 26)
        Me.RadLabel_WindingMaterialsWidth.TabIndex = 117
        Me.RadLabel_WindingMaterialsWidth.Text = "DesignSummary_Width"
        Me.RadLabel_WindingMaterialsWidth.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_WindingMaterialsWidth.TextWrap = False
        Me.RadLabel_WindingMaterialsWidth.ThemeName = "Windows8"
        '
        'RadLabel_WindingMaterialsGain
        '
        Me.RadLabel_WindingMaterialsGain.AutoSize = False
        Me.RadLabel_WindingMaterialsGain.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_WindingMaterialsGain.Location = New System.Drawing.Point(241, 28)
        Me.RadLabel_WindingMaterialsGain.Name = "RadLabel_WindingMaterialsGain"
        Me.RadLabel_WindingMaterialsGain.Size = New System.Drawing.Size(53, 26)
        Me.RadLabel_WindingMaterialsGain.TabIndex = 116
        Me.RadLabel_WindingMaterialsGain.Text = "DesignSummary_Gain"
        Me.RadLabel_WindingMaterialsGain.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_WindingMaterialsGain.TextWrap = False
        Me.RadLabel_WindingMaterialsGain.ThemeName = "Windows8"
        '
        'RadLabel_WindingMaterialsThick
        '
        Me.RadLabel_WindingMaterialsThick.AutoSize = False
        Me.RadLabel_WindingMaterialsThick.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_WindingMaterialsThick.Location = New System.Drawing.Point(321, 28)
        Me.RadLabel_WindingMaterialsThick.Name = "RadLabel_WindingMaterialsThick"
        Me.RadLabel_WindingMaterialsThick.Size = New System.Drawing.Size(64, 26)
        Me.RadLabel_WindingMaterialsThick.TabIndex = 115
        Me.RadLabel_WindingMaterialsThick.Text = "DesignSummary_Thick"
        Me.RadLabel_WindingMaterialsThick.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_WindingMaterialsThick.TextWrap = False
        Me.RadLabel_WindingMaterialsThick.ThemeName = "Windows8"
        '
        'RadLabel_WindingMaterialsDetail
        '
        Me.RadLabel_WindingMaterialsDetail.AutoSize = False
        Me.RadLabel_WindingMaterialsDetail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_WindingMaterialsDetail.Location = New System.Drawing.Point(401, 28)
        Me.RadLabel_WindingMaterialsDetail.Name = "RadLabel_WindingMaterialsDetail"
        Me.RadLabel_WindingMaterialsDetail.Size = New System.Drawing.Size(64, 26)
        Me.RadLabel_WindingMaterialsDetail.TabIndex = 114
        Me.RadLabel_WindingMaterialsDetail.Text = "DesignSummary_Detail"
        Me.RadLabel_WindingMaterialsDetail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_WindingMaterialsDetail.TextWrap = False
        Me.RadLabel_WindingMaterialsDetail.ThemeName = "Windows8"
        '
        'RadLabel_WindingMaterialsUnitcost
        '
        Me.RadLabel_WindingMaterialsUnitcost.AutoSize = False
        Me.RadLabel_WindingMaterialsUnitcost.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_WindingMaterialsUnitcost.Location = New System.Drawing.Point(500, 28)
        Me.RadLabel_WindingMaterialsUnitcost.Name = "RadLabel_WindingMaterialsUnitcost"
        Me.RadLabel_WindingMaterialsUnitcost.Size = New System.Drawing.Size(101, 26)
        Me.RadLabel_WindingMaterialsUnitcost.TabIndex = 113
        Me.RadLabel_WindingMaterialsUnitcost.Text = "DesignSummary_UnitCost"
        Me.RadLabel_WindingMaterialsUnitcost.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_WindingMaterialsUnitcost.TextWrap = False
        Me.RadLabel_WindingMaterialsUnitcost.ThemeName = "Windows8"
        '
        'RadLabel_WindingMaterialsAmount
        '
        Me.RadLabel_WindingMaterialsAmount.AutoSize = False
        Me.RadLabel_WindingMaterialsAmount.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_WindingMaterialsAmount.Location = New System.Drawing.Point(595, 28)
        Me.RadLabel_WindingMaterialsAmount.Name = "RadLabel_WindingMaterialsAmount"
        Me.RadLabel_WindingMaterialsAmount.Size = New System.Drawing.Size(75, 26)
        Me.RadLabel_WindingMaterialsAmount.TabIndex = 112
        Me.RadLabel_WindingMaterialsAmount.Text = "DesignSummary_Amount"
        Me.RadLabel_WindingMaterialsAmount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_WindingMaterialsAmount.TextWrap = False
        Me.RadLabel_WindingMaterialsAmount.ThemeName = "Windows8"
        '
        'RadLabel_WindingMaterialsCost
        '
        Me.RadLabel_WindingMaterialsCost.AutoSize = False
        Me.RadLabel_WindingMaterialsCost.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_WindingMaterialsCost.Location = New System.Drawing.Point(676, 28)
        Me.RadLabel_WindingMaterialsCost.Name = "RadLabel_WindingMaterialsCost"
        Me.RadLabel_WindingMaterialsCost.Size = New System.Drawing.Size(68, 26)
        Me.RadLabel_WindingMaterialsCost.TabIndex = 111
        Me.RadLabel_WindingMaterialsCost.Text = "DesignSummary_Cost"
        Me.RadLabel_WindingMaterialsCost.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_WindingMaterialsCost.TextWrap = False
        Me.RadLabel_WindingMaterialsCost.ThemeName = "Windows8"
        '
        'RadLabel_WindingMaterialsLengths
        '
        Me.RadLabel_WindingMaterialsLengths.AutoSize = False
        Me.RadLabel_WindingMaterialsLengths.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_WindingMaterialsLengths.Location = New System.Drawing.Point(830, 28)
        Me.RadLabel_WindingMaterialsLengths.Name = "RadLabel_WindingMaterialsLengths"
        Me.RadLabel_WindingMaterialsLengths.Size = New System.Drawing.Size(101, 26)
        Me.RadLabel_WindingMaterialsLengths.TabIndex = 110
        Me.RadLabel_WindingMaterialsLengths.Text = "DesignSummary_LengthsETC"
        Me.RadLabel_WindingMaterialsLengths.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_WindingMaterialsLengths.TextWrap = False
        Me.RadLabel_WindingMaterialsLengths.ThemeName = "Windows8"
        '
        'RadScrollablePanel1
        '
        Me.RadScrollablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadScrollablePanel1.Location = New System.Drawing.Point(0, 194)
        Me.RadScrollablePanel1.Name = "RadScrollablePanel1"
        '
        'RadScrollablePanel1.PanelContainer
        '
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.Panel_Prices)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.Panel10)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.Panel8)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.Panel7)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.Panel6)
        Me.RadScrollablePanel1.PanelContainer.Size = New System.Drawing.Size(1314, 575)
        Me.RadScrollablePanel1.Size = New System.Drawing.Size(1333, 577)
        Me.RadScrollablePanel1.TabIndex = 99
        Me.RadScrollablePanel1.Text = "RadScrollablePanel1"
        '
        'RadLabel_AnodeNone3
        '
        Me.RadLabel_AnodeNone3.AutoSize = False
        Me.RadLabel_AnodeNone3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_AnodeNone3.Location = New System.Drawing.Point(25, 93)
        Me.RadLabel_AnodeNone3.Name = "RadLabel_AnodeNone3"
        Me.RadLabel_AnodeNone3.Size = New System.Drawing.Size(708, 33)
        Me.RadLabel_AnodeNone3.TabIndex = 169
        Me.RadLabel_AnodeNone3.Text = "DesignSummary_AnodeNone"
        Me.RadLabel_AnodeNone3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_AnodeNone3.ThemeName = "Windows8"
        Me.RadLabel_AnodeNone3.Visible = False
        '
        'DesignSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1333, 771)
        Me.Controls.Add(Me.RadScrollablePanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1329, 600)
        Me.Name = "DesignSummary"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DesignSummary_Title"
        Me.ThemeName = "Windows8"
        CType(Me.RadDropDownList_SpecDrawing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_DimensionDWG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_WindingPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_Routing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_PartsFile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Prices.ResumeLayout(False)
        CType(Me.RadLabel_ImageCoverPrices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_VariableTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_VariableOH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_StandardTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_StandardOH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Labor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Material, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PriceTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_OH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Labor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Material, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Variable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Standard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_NoLabData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_SEV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel19.ResumeLayout(False)
        CType(Me.RadButton_SampleCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_ShowAllCriteria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_HideAllCriteria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_ShowAllRecords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_FilterRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.RadTextBox_KemetPartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Issue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TestVoltage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ASNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_LenTolerance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Len, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_SurgeVoltage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Temp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_DiaTolerance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Dia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_WorkVoltage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_HighTolCapacitance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_LowTolCapacitance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_LowTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Capacitance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Issue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_PSIPartStyle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TestVoltageUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_DesignChecked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TestVoltage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ASNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Len, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_SurgeVoltageUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_SurgeVoltage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_ac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TempUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Dia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_WorkVoltageUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_WorkVoltage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PSIPartStyle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_Range, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Range, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_PartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Minus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_CapacitanceUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Plus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PercentageLowTolCapacitance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PercentageHighTolCapacitance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_LowTempUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.RadButton_SetOutline, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_SetObs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_SetHold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_SetLive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Transfer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_GoToScratchPad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_AddToList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_StockOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.RadTextBox_DesApp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_QAApp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_DesApp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_QAApp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_CleapApps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_NewSpec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TabControl_AddCatData.ResumeLayout(False)
        Me.TabPage_pgeCatData.ResumeLayout(False)
        Me.Panel21.ResumeLayout(False)
        Me.Panel21.PerformLayout()
        CType(Me.RadTextBox_TableCondy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TableCondy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TableRiseT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TableRbc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TableRwb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TableRhw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TableOxide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TableTissue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TableTabbing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TableFoil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel25.ResumeLayout(False)
        CType(Me.RadLabel_CatalogueData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_pgeAddData.ResumeLayout(False)
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        CType(Me.RadLabel_SpecificationDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CustomerPartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Distributor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_SpecDrawingSpecs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Terminals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Dimensions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_SpecNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_RatedIR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_IRFreq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_IRTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_CustomerPartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Distributor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_SpecDrawingSpecs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Terminals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Dimensions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_SpecNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_RatedIR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_RatedIRUnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        CType(Me.RadLabel_IRTempUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_IRFreqUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PartsFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Routing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_WindingPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_DimensionDWG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_SpecDrawing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        CType(Me.RadLabel_NoLabData2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel22.ResumeLayout(False)
        CType(Me.RadTextBox_LimitValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TestValue3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TestValue2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TestValue1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_LimitCondition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_LimitMethod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_TestCondition3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_TestParameter3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_TestCondition2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_TestParameter2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_TestCondition1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_TestParameter1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel24.ResumeLayout(False)
        CType(Me.RadLabel_TestParameteres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        CType(Me.RadLabel_WindingMaterials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        CType(Me.RadLabel_AnodeNone2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_AnodeCost2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_AnodeCost1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_AnodeAmount2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_AnodeAmount1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_AnodeUnitCost2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_AnodeUnitCost1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_AnodeUnitCost2Unit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_AnodeUnitCost1Unit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_AnodeDetail2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_AnodeDetail1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_AnodeDetail2Unit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_AnodeDetail1Unit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_AnodeThick2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_AnodeThick1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_AnodeThick2Unit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_AnodeThick1Unit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_AnodeGain2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_AnodeGain2Unit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_AnodeGain1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_AnodeGain1Unit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_AnodeWidth2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_AnodeVoltage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_AnodePartNumber2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_AnodeWidth1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_AnodeVoltage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_AnodePartNumber1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        CType(Me.RadLabel_Anodes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        CType(Me.RadTextBox_AnodeLenGain2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_AnodeLenGain1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_AnodeLenGain2Unit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_AnodeLenGain1Unit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_AnodeLen2Unit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_AnodeLen1Unit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_AnodeLen2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_AnodeLen1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Cath, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel16.ResumeLayout(False)
        CType(Me.RadDropDownList_TissuePart3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_TissuePart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_TissuePart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TissueCost3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TissueCost2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TissueAmount3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TissueAmount2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TissueUnitCost3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TissueUnitCost2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TissueCost1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TissueUnitCost1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TissueAmount1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TissueUnitCost3Unit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TissueUnitCost2Unit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TissueUnitCost1Unit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TissueDetail1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TissueDetail2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TabDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TissueDetail3Unit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TissueDetail2Unit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TissueDetail1Unit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TissueThick3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TissueThick2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TissueThick1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TissueThick3Unit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TissueThick2Unit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TissueThick1Unit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TissueWidth3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TissueWidth2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TissueWidth1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel17.ResumeLayout(False)
        CType(Me.RadLabel_Tissues, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel15.ResumeLayout(False)
        CType(Me.RadLabel_MaxCapUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_MaxCap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_PercentageFit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_WFactor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_MaxLengthGain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_MaxLengthGainUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_MaxLengthUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_MaxLength, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Cap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadLabel_Cap.ResumeLayout(False)
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_CapPercentageFit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_CapAt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PercentageFit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_WFactor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_MaxLength, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Tab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Elyte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel18.ResumeLayout(False)
        CType(Me.RadTextBox_MelQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_HoleTheta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Melinex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_L2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Mandrel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_L1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_PreWrap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CathExt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CanIntTheta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_CathExt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_CathExtUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Mandrel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_CanIntThetaUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_MandrelUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_HoleTheta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_HoleThetaUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_MelQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Melinex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_L2Unit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_L2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_L1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PreWrap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_CanIntTheta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_Swage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_AW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel23.ResumeLayout(False)
        CType(Me.RadTextBox_Z10KHz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ESR100Hz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ESRFoil10Percent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ESRFoil10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ESROxide10Percent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ESRTabbing10Percent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ESRTissue10Percent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ESRTabbing10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ESROxide10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ESRFoil100Percent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ESRTissue10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ESROxide100Percent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ESRTissue100Percent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ESRTabbing100Percent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ESRFoil100, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ESROxide100, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ESRTissue100, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ESRTabbing100, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Z10KHz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ESR100Hz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Total, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ESRFoil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ESROxide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ESRTissue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ESRTabbing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_At10kHz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_At100Hz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_ESRGraphForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel20.ResumeLayout(False)
        CType(Me.RadLabel_ESRData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_NoESRDataOnStyleDesign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.RadDropDownList_ElytePartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_TabPartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_CathPartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.RadLabel_CoverSampleCostButtons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadListView_AssemblyNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PrintDrawing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_DesignNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PrintNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_AssemblyNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_Scrollbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Center, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_PrintNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_DesignNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_PrintNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ElyteUnitCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ElyteAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ElyteUnitCostUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ElyteCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TabCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TabAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TabUnitCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TabUnitCostUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TabDetailUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_TabThick, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TabThickUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CathCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CathAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CathUnitCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_CathUnitCostUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CathDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_CathDetailUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CathThick, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_CathThickUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CathGain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_CathGainUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CathWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_WindingMaterialsName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_WindingMaterialsFV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_WindingMaterialsWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_WindingMaterialsGain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_WindingMaterialsThick, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_WindingMaterialsDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_WindingMaterialsUnitcost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_WindingMaterialsAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_WindingMaterialsCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_WindingMaterialsLengths, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadScrollablePanel1.PanelContainer.ResumeLayout(False)
        CType(Me.RadScrollablePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadScrollablePanel1.ResumeLayout(False)
        CType(Me.RadLabel_AnodeNone3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadDropDownList_SpecDrawing As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_DimensionDWG As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_WindingPicture As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_Routing As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_PartsFile As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Panel_Prices As System.Windows.Forms.Panel
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents RadButton_SampleCost As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_ShowAllCriteria As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_HideAllCriteria As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_ShowAllRecords As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_FilterRecords As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadCheckBox_SEV As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel_NoLabData As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_VariableTotal As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_VariableOH As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_StandardTotal As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_StandardOH As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Labor As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Material As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_PriceTotal As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_OH As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Labor As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Material As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Variable As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Standard As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel23 As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_NoESRDataOnStyleDesign As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Z10KHz As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_ESR100Hz As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_ESRFoil10Percent As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_ESRFoil10 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_ESROxide10Percent As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_ESRTabbing10Percent As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_ESRTissue10Percent As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_ESRTabbing10 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_ESROxide10 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_ESRFoil100Percent As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_ESRTissue10 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_ESROxide100Percent As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_ESRTissue100Percent As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_ESRTabbing100Percent As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_ESRFoil100 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_ESROxide100 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_ESRTissue100 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_ESRTabbing100 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Z10KHz As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_ESR100Hz As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Total As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_ESRFoil As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_ESROxide As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_ESRTissue As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_ESRTabbing As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_At10kHz As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_At100Hz As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton_ESRGraphForm As Telerik.WinControls.UI.RadButton
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_ESRData As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents RadTextBox_MelQty As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_HoleTheta As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Melinex As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_No As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_L2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Mandrel As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_L1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_PreWrap As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_CathExt As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_CanIntTheta As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_CathExt As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_CathExtUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Mandrel As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_CanIntThetaUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_MandrelUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_No As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_HoleTheta As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_HoleThetaUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_MelQty As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Melinex As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_L2Unit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_L2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_L1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_PreWrap As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_CanIntTheta As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadCheckBox_Swage As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_AW As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel_Elyte As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Tab As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_Cap As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel11 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_CapPercentageFit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_CapAt As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_PercentageFit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_WFactor As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_MaxLength As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_13 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_12 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_11 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_Cath As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_AnodeNone2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_02 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_01 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents RadTextBox_LimitValue As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_TestValue3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_TestValue2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_TestValue1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadDropDownList_LimitCondition As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_LimitMethod As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_TestCondition3 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_TestParameter3 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_TestCondition2 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_TestParameter2 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_TestCondition1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_TestParameter1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Panel24 As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_TestParameteres As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_SpecDrawing As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_DimensionDWG As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_WindingPicture As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Routing As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_PartsFile As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_RatedIRUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_RatedIR As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_SpecNotes As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Dimensions As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Terminals As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_SpecDrawingSpecs As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Distributor As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_CustomerPartNumber As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Customer As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_IRTemp As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_IRFreq As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_RatedIR As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_SpecNotes As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Dimensions As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Terminals As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_SpecDrawingSpecs As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Distributor As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_CustomerPartNumber As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Customer As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label_At2 As System.Windows.Forms.Label
    Friend WithEvents Label_At1 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_SpecificationDetails As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents TabControl_AddCatData As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_pgeCatData As System.Windows.Forms.TabPage
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents RadTextBox_TableCondy As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_TableCondy As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox6 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox7 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox8 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox9 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox4 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_TableRiseT As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_TableRbc As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_TableRwb As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_TableRhw As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_TableOxide As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_TableTissue As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_TableTabbing As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_TableFoil As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel25 As System.Windows.Forms.Panel
    Friend WithEvents TabPage_pgeAddData As System.Windows.Forms.TabPage
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel_ImageCoverPrices As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RadTextBox_Issue As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Date As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_TestVoltage As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_ASNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_LenTolerance As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Len As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_SurgeVoltage As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Temp As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_DiaTolerance As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Dia As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_WorkVoltage As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_HighTolCapacitance As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_LowTolCapacitance As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_LowTemp As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Capacitance As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox10 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Issue As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Date As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_PSIPartStyle As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_TestVoltageUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadCheckBox_DesignChecked As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel_TestVoltage As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_ASNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Len As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_SurgeVoltageUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_SurgeVoltage As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadCheckBox_ac As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel_TempUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Dia As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_WorkVoltageUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_WorkVoltage As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_PSIPartStyle As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_Range As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_Range As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_PartNumber As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_Minus As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_CapacitanceUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Plus As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_PercentageLowTolCapacitance As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_PercentageHighTolCapacitance As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_LowTempUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents RadButton_SetOutline As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_SetObs As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_SetHold As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_SetLive As Telerik.WinControls.UI.RadButton
    Friend WithEvents PictureBox_KemetLogo As System.Windows.Forms.PictureBox
    Friend WithEvents RadButton_Delete As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Transfer As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_GoToScratchPad As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_AddToList As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_StockOrders As Telerik.WinControls.UI.RadButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents RadTextBox_DesApp As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_QAApp As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadButton_DesApp As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_QAApp As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_CleapApps As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_NewSpec As Telerik.WinControls.UI.RadButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RadScrollablePanel1 As Telerik.WinControls.UI.RadScrollablePanel
    Friend WithEvents RadTextBox_AnodeLenGain2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_AnodeLenGain1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_AnodeLenGain2Unit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_AnodeLenGain1Unit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_AnodeLen2Unit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_AnodeLen1Unit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_AnodeLen2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_AnodeLen1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_PercentageFit As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_WFactor As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_MaxLengthGain As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_MaxLengthGainUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_MaxLengthUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_MaxLength As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_MaxCapUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_MaxCap As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_WindingMaterials As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_WindingMaterialsName As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_WindingMaterialsFV As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_WindingMaterialsWidth As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_WindingMaterialsGain As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_WindingMaterialsThick As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_WindingMaterialsDetail As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_WindingMaterialsUnitcost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_WindingMaterialsAmount As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_WindingMaterialsCost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_WindingMaterialsLengths As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Anodes As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_AnodePartNumber1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_AnodeDetail2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_AnodeDetail1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_AnodeThick2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_AnodeThick1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_AnodeThick2Unit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_AnodeDetail1Unit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_AnodeThick1Unit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_AnodeGain2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_AnodeGain2Unit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_AnodeGain1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_AnodeGain1Unit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_AnodeWidth2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_AnodeVoltage2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_AnodePartNumber2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_AnodeWidth1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_AnodeVoltage1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_AnodeCost2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_AnodeCost1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_AnodeAmount2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_AnodeAmount1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_AnodeUnitCost2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_AnodeUnitCost1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_AnodeUnitCost2Unit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_AnodeUnitCost1Unit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_AnodeDetail2Unit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_CathCost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_CathAmount As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_CathUnitCost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_CathUnitCostUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_CathDetail As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_CathDetailUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_CathThick As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_CathThickUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_CathGain As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_CathGainUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_CathWidth As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_ElyteUnitCost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_ElyteAmount As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_ElyteUnitCostUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_ElyteCost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_TabCost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_TabAmount As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_TabUnitCost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_TabUnitCostUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_TabDetail As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_TabDetailUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_TabThick As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_TabThickUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_TissueCost3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_TissueCost2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_TissueAmount3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_TissueAmount2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_TissueUnitCost3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_TissueUnitCost2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_TissueCost1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_TissueUnitCost1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_TissueAmount1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_TissueUnitCost3Unit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_TissueUnitCost2Unit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_TissueUnitCost1Unit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_TissueDetail1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_TissueDetail2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_TissueDetail3Unit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_TissueDetail2Unit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_TissueDetail1Unit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_TissueThick3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_TissueThick2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_TissueThick1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_TissueThick3Unit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_TissueThick2Unit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_TissueThick1Unit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_TissueWidth3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_TissueWidth2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_TissueWidth1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Tissues As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_CatalogueData As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_KemetPartNumber As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_IRTempUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_IRFreqUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_NoLabData2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_PrintDrawing As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_DesignNotes As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_PrintNotes As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_AssemblyNotes As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadCheckBox_Scrollbar As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadButton_Center As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadDropDownList_PrintNumber As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadTextBox_DesignNotes As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_PrintNotes As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadListView_AssemblyNotes As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadDropDownList_CathPartNumber As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_TissuePart1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_TissuePart3 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_TissuePart2 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_ElytePartNumber As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_TabPartNumber As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_CoverSampleCostButtons As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox5 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox11 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox12 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox13 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox14 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox15 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox16 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox17 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox18 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_03 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_AnodeNone3 As Telerik.WinControls.UI.RadLabel
End Class

