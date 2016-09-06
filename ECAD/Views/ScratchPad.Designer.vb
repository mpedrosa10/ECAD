<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScratchPad
    Inherits Telerik.WinControls.UI.RadForm

    Public Sub New()
        InitializeComponent()

        Me.SuspendLayout()
        ' Localize all the ui elements from a common Resource
        Helpers.LocalizationHelper.LocalizeForm(Me)

        HandleCostsVisibility()

        Me.ResumeLayout(False)
    End Sub

        'Hide tabs until checkbox selected
    Protected Sub HandleCostsVisibility()
        Me.SuspendLayout()
        If (RadCheckBox_DisplayCosts.Checked) Then
            Me.TabControl_Ctl.TabPages.Insert(1, Tab_Cost)
            Me.TabControl_Ctl.TabPages.Insert(2, Tab_Yield)
            Me.TabControl_Ctl.TabPages.Insert(3, Tab_Lab)
            Me.TabControl_Ctl.TabPages.Insert(4, Tab_OldTab)
            Me.TabControl_Ctl.TabPages.Insert(5, Tab_OldTab2)

            Me.RadLabel_Cost.Visible = True
            Me.RadTextBox_Anode1Cost.Visible = True
            Me.RadTextBox_Anode2Cost.Visible = True
            Me.RadTextBox_Anode3Cost.Visible = True
            Me.RadTextBox_CathodeCost.Visible = True
            Me.RadTextBox_Tissue1Cost.Visible = True
            Me.RadTextBox_Tissue2Cost.Visible = True
            Me.RadTextBox_Tissue3Cost.Visible = True
            Me.RadTextBox_TabCost.Visible = True
            RadTextBox_ElyteCost.Visible = True
        Else
            Me.TabControl_Ctl.TabPages.Remove(Tab_Cost)
            Me.TabControl_Ctl.TabPages.Remove(Tab_Yield)
            Me.TabControl_Ctl.TabPages.Remove(Tab_Lab)
            Me.TabControl_Ctl.TabPages.Remove(Tab_OldTab)
            Me.TabControl_Ctl.TabPages.Remove(Tab_OldTab2)

            Me.RadLabel_Cost.Visible = False
            Me.RadTextBox_Anode1Cost.Visible = False
            Me.RadTextBox_Anode2Cost.Visible = False
            Me.RadTextBox_Anode3Cost.Visible = False
            Me.RadTextBox_CathodeCost.Visible = False
            Me.RadTextBox_Tissue1Cost.Visible = False
            Me.RadTextBox_Tissue2Cost.Visible = False
            Me.RadTextBox_Tissue3Cost.Visible = False
            Me.RadTextBox_TabCost.Visible = False
            RadTextBox_ElyteCost.Visible = False
        End If
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScratchPad))
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.RadPanel_MenuTop = New Telerik.WinControls.UI.RadPanel()
        Me.RadCheckBox_UsePRMSCostReport = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_DesChecked = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel_KPartNumber = New Telerik.WinControls.UI.RadLabel()
        Me.Panel_TopBarGroup2 = New System.Windows.Forms.Panel()
        Me.RadTextBox_DesApp = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Issue = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_QAApp = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Issue = New Telerik.WinControls.UI.RadTextBox()
        Me.RadButton_DesApp = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel_Date = New Telerik.WinControls.UI.RadLabel()
        Me.RadButton_QAApp = New Telerik.WinControls.UI.RadButton()
        Me.RadTextBox_Date = New Telerik.WinControls.UI.RadTextBox()
        Me.RadButton_ClearApps = New Telerik.WinControls.UI.RadButton()
        Me.Panel_TopBarRadioButtons = New System.Windows.Forms.Panel()
        Me.RadioButton_Outline = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Live = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Obs = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Hold = New System.Windows.Forms.RadioButton()
        Me.RadTextBox_SQApp_2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_SQApp = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_SQApp = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_SDApp = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_SDApp = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Summary = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Summary = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_CelsiusDegreesMin = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_CelsiusDegreesMax = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_CelsiusDegreesMin = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_CelsiusDegreesMax = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_Percentage_2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Percentage = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_PositivePercentage = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_NegativePercentage = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Positive = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Negative = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_MicroFarad = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_V = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Volts = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Volts = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Cap = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_ASNo = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Dia = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Len = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Len = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_ASNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Dia_2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Len_2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Dia = New Telerik.WinControls.UI.RadTextBox()
        Me.RadButton_PrintCost = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_ShowSpec = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_PrintDesign = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_PrevSpec = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_PrintEsr = New Telerik.WinControls.UI.RadButton()
        Me.RadTextBox_DeUser = New Telerik.WinControls.UI.RadTextBox()
        Me.RadDropDownList_Range = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_U = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_R = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Cap = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_PartNumber = New Telerik.WinControls.UI.RadTextBox()
        Me.RadDropDownList_PartStyle = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadButton_DeleteScratch = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Evaluate = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Refresh = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_ShowAllRecs = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Rename = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_UpdateMain = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_GoToSummary = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_NewDesign = New Telerik.WinControls.UI.RadButton()
        Me.RadScrollablePanel_Container = New Telerik.WinControls.UI.RadScrollablePanel()
        Me.Panel_SpecificationDetails = New System.Windows.Forms.Panel()
        Me.RadLabel_SEVtestvoltage = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_SurgeOrVDEvoltage = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_SEVtestvoltage = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_SurgeOrVDEvoltage = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_CelsiusDegrees = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_RatedIr3 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_RatedIr3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_RatedIr2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_RatedIr2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Notes = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_RatedIr = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Notes = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_RatedIr = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Dimensions = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Terminals = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_SpecDwg = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Distributor = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_CustPNo = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Dimensions = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Terminals = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_SpecDwg = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Distributor = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_CustPNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadButton_SpecificationDetails = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel_Customer = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Customer = New Telerik.WinControls.UI.RadTextBox()
        Me.TabControl_PrintCatExtra = New System.Windows.Forms.TabControl()
        Me.ScratchP_PrintDetail = New System.Windows.Forms.TabPage()
        Me.RadGroupBox_PrintDetail = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadTextBox_PartsCost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_MelCostRaw = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_MelTCost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_MelQty = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_MelinexCost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadDropDownList_PrintDrawing = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_PrintDrawing = New Telerik.WinControls.UI.RadLabel()
        Me.RadButton_ViewCentred = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel_PrintDetailMax13Lines = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_PrintNotes = New Telerik.WinControls.UI.RadTextBox()
        Me.ScratchP_CatData = New System.Windows.Forms.TabPage()
        Me.Panel_CatalogueData = New System.Windows.Forms.Panel()
        Me.RadTextBox_condy_eq = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_IrT = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_IrF = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Rise_T = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Rbo = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Rwb = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_IrT = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_IrF = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Rise_T = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Rbo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Rwb = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Rhw = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Ir = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Rha = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_condy_eq = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_oxide_fi = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_tissue_ti = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_tabbing = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_foil = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Ir = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Rha = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_oxide_fi = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_tissue_ti = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_tabbing = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Rhw = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_foil = New Telerik.WinControls.UI.RadTextBox()
        Me.Panel_CatalogueDataTitle = New System.Windows.Forms.Panel()
        Me.RadLabel_CatalogueData = New Telerik.WinControls.UI.RadLabel()
        Me.RadButton_ViewAllCatData = New Telerik.WinControls.UI.RadButton()
        Me.RadGridView2 = New Telerik.WinControls.UI.RadGridView()
        Me.ScratchP_ExtraFields = New System.Windows.Forms.TabPage()
        Me.RadButton_EditFields = New Telerik.WinControls.UI.RadButton()
        Me.RadGridView_ExtraFields = New Telerik.WinControls.UI.RadGridView()
        Me.Panel_Anode = New System.Windows.Forms.Panel()
        Me.RadLabel_Cost = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Anode3Cost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Anode2Cost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Anode1Cost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadDropDownList_Melinex = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_Mm3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Mm2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_AnodeLenght2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_AnodeLenght = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Melinex = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_FaradPerSquareCm3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_FaradPerSquareCm2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_MinGain = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_MinGain = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Anode3Amount = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_StdLength = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Anode2Amount = New Telerik.WinControls.UI.RadTextBox()
        Me.RadDropDownList_Anode3Width = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_Anode1Width = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_Anode3Vf = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadTextBox_AnodeGain2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadDropDownList_Anode3 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_Anode2 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_Anode3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Anode2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_MaxLen = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_PercentageFit = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Factor = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Anode1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_AnodeGain = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Factor = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_WindingDetails = New Telerik.WinControls.UI.RadLabel()
        Me.RadCheckBox_UserGain = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel_Anode_Vertical = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_MaxLen = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_PercentageFit = New Telerik.WinControls.UI.RadTextBox()
        Me.RadDropDownList_Anode1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_Vf = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_Anode1Vf = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_Anode2Vf = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_Width = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_Anode2Width = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_Amount = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Anode1Amount = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Mm = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_FaradPerSquareCm = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_PercentageFit2 = New Telerik.WinControls.UI.RadTextBox()
        Me.Panel_Parameters = New System.Windows.Forms.Panel()
        Me.RadLabel_TestVolts = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_IMPAt10000HzAt20C = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_IMPAt10000HzAt20C = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_ESRAt100HzAt20C = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_ESRAt100HzAt20C = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_ParameterCondition = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_ParameterValue = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Parameter = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_ParameterCondition4 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadTextBox_ParameterValue4 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadDropDownList_ParameterCondition3 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadTextBox_ParameterValue3 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadDropDownList_ParameterCondition2 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadTextBox_ParameterValue2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadCheckBox_ac = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadTextBox_TestVolts = New Telerik.WinControls.UI.RadTextBox()
        Me.RadDropDownList_ParameterCondition1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadTextBox_ParameterValue1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadDropDownList_Parameter4 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_Parameter3 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_Parameter2 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_MicroFarad4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Capacitance2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_to = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_MicroFarad3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Capacitance = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Capacitance = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_Parameter1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadButton_GetLimits = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_TestParameters = New Telerik.WinControls.UI.RadButton()
        Me.Panel_Cathode = New System.Windows.Forms.Panel()
        Me.RadTextBox_CathodeCost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadCheckBox_Swage = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel_Swage = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Mm4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_CathExtension = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_CathExtension = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_CathodeVf = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadTextBox_CathodeAmount = New Telerik.WinControls.UI.RadTextBox()
        Me.RadDropDownList_CathodeWidth = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_Cath = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_Cathode = New Telerik.WinControls.UI.RadDropDownList()
        Me.Panel_Notes = New System.Windows.Forms.Panel()
        Me.RadDropDownList_Note3 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_Note3Type = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_Note2 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadTextBox_Note3 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadDropDownList_Note2Type = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadTextBox_Note2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadDropDownList_Note1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_Note = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_NoteType = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_Note1Type = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadTextBox_Note1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Sequence = New Telerik.WinControls.UI.RadLabel()
        Me.RadButton_ArrowRight = New Telerik.WinControls.UI.RadButton()
        Me.Panel_NotesLanguages = New System.Windows.Forms.Panel()
        Me.RadioButton_English = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Spanish = New System.Windows.Forms.RadioButton()
        Me.RadButton_NotesMax10escroutnotes = New Telerik.WinControls.UI.RadButton()
        Me.Panel_TopRight = New System.Windows.Forms.Panel()
        Me.RadLabel_SpecDrawing = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_WindingPicture = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_DimensionDwg = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_WindingPicture = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Routing = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_PartsFile = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_SpecDrawing = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_PartsFile = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_DimensionDwg = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_Routing = New Telerik.WinControls.UI.RadDropDownList()
        Me.Panel_Elyte = New System.Windows.Forms.Panel()
        Me.RadLabel_MiniPrewrap = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_MiniPrewrap = New Telerik.WinControls.UI.RadTextBox()
        Me.RadCheckBox_AutoWidth = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadTextBox_ElyteCost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadCheckBox_Scrollbar = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel_Scrollbar = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_ElyteAmount = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Elyte = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_Elyte = New Telerik.WinControls.UI.RadDropDownList()
        Me.Panel_Tissue = New System.Windows.Forms.Panel()
        Me.RadTextBox_Tissue3Cost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Tissue2Cost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Tissue1Cost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadCheckBox_AfterWrap = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel_AfterWrap = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_PreWrapLength = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_PreWrapLength = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_PreWrapTurns = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_PreWrapTurns = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Tissue3Amount = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Tissue2Amount = New Telerik.WinControls.UI.RadTextBox()
        Me.RadDropDownList_Tissue3Width = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_Tissue1Width = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_Tissue3Vf = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_Tissue_Vertical = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_Tissue3 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_Tissue2 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_Tissue3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Tissue2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Tissue1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_Tissue1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_Tissue1Vf = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_Tissue2Width = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadTextBox_Tissue1Amount = New Telerik.WinControls.UI.RadTextBox()
        Me.RadDropDownList_Tissue2Vf = New Telerik.WinControls.UI.RadDropDownList()
        Me.Panel_Freqs = New System.Windows.Forms.Panel()
        Me.RadButton_MoreDetail = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_LifeCalc = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_WriteCatData = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Refresh2 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_GetData = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_DefaultFreqs = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel_HSink = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_EDType = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Mm9 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_VFactorMm = New Telerik.WinControls.UI.RadTextBox()
        Me.RadDropDownList_EDType = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList_AirflowMs = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadCheckBox_UseActualEsr = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel_ATc = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_FailMode = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_LifeLop = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_FailMode = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_LifeLop = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_ActEsrTemp = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_UseActualEsr = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_ActEsrTemp = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_ESRFactorKe = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_MaxESRx = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_ESRFactorKe = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_MaxESRx = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_TrForCalcIr = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_MaxCoreTm = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_TrForCalcIr = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_MaxCoreTm = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_VFactorKv = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_StdVfs = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_VFactorKv = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_StdVfs = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_CurrentPaths = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_CurrentPaths = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_AirflowMs = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_ActTrxAtEOLTx = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_ArrheniusT2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_ActTrxAtEOLTx = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_ArrheniusT2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_TrCoreRise = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_AverageTh = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_TrCoreRise = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_AverageTh = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_HSink = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_OpVop = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_OpVop = New Telerik.WinControls.UI.RadLabel()
        Me.RadCheckBox_old = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadTextBox_RHaCperWatt = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_RHaCperWatt = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_LifeFactorLe = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_LifeFactorLe = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_ATc = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_AmbientTa = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_AmbientTa = New Telerik.WinControls.UI.RadLabel()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.Panel_Tab = New System.Windows.Forms.Panel()
        Me.RadTextBox_MatCost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_TabCost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Mm8 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Hole = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Hole = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_NoDot = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_NoDot = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_L2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_L2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_L1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_L1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Mm7 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_TabAmount = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Tab = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_Tab = New Telerik.WinControls.UI.RadDropDownList()
        Me.Panel_TissueRight = New System.Windows.Forms.Panel()
        Me.RadLabel_Mm5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Mandrel = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_CanCode = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_CanInt = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_CanInt = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Mandrel = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_CanCode = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Mm6 = New Telerik.WinControls.UI.RadLabel()
        Me.TabControl_Ctl = New System.Windows.Forms.TabControl()
        Me.Tab_Ctl = New System.Windows.Forms.TabPage()
        Me.RadLabel_Ctl = New Telerik.WinControls.UI.RadLabel()
        Me.RadButton_RelForm = New Telerik.WinControls.UI.RadButton()
        Me.RadCheckBox_DisplayCosts = New Telerik.WinControls.UI.RadCheckBox()
        Me.Tab_Cost = New System.Windows.Forms.TabPage()
        Me.RadLabel_NoLABData = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_StandardCost = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_VariableCost = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Labour = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_StandardCost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_VariableCost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Labour = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Material = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Material = New Telerik.WinControls.UI.RadLabel()
        Me.Tab_Yield = New System.Windows.Forms.TabPage()
        Me.RadTextBox_An3 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_An2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Tiytg = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Anytg = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_CaYC = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_An1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Ti3 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Ti2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Ti1YC = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_OY = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_OY = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Caytg = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Caytg = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Tiytg = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_CaYC = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_An3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Anytg = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_An2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_An1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Ti3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Ti2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Ti1YC = New Telerik.WinControls.UI.RadLabel()
        Me.Tab_Lab = New System.Windows.Forms.TabPage()
        Me.RadTextBox_Dep = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Dep = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Fix = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Fix = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Var = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Var = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_WLC = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_WLC = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_RCost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_RCost = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_CLC = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_CLC = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_T3LC = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_T3LC = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_A3LC = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_A3LC = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_T2LC = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_T2LC = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_A2LC = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_A2LC = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_T1LC = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_T1LC = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_A1LC = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_A1LC = New Telerik.WinControls.UI.RadLabel()
        Me.Tab_OldTab = New System.Windows.Forms.TabPage()
        Me.RadLabel_Variable = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_TotalCostVariable = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_OHCostVariable = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_LabourCostVariable = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_PartsCostVariable = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_WindCostVariable = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_TotalCostGross = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_TotalCost = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_OHCostGross = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_OHCost = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_LabourCostGross = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_LabourCost = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_PartsCostGross = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_PartsCost = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_WindCostGross = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_WindCost = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Gross = New Telerik.WinControls.UI.RadLabel()
        Me.Tab_OldTab2 = New System.Windows.Forms.TabPage()
        Me.RadTextBox_SMV = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_SMV = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Group = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Group = New Telerik.WinControls.UI.RadLabel()
        Me.Panel_CapAndNotes = New System.Windows.Forms.Panel()
        Me.RadTextBox_GasLife120 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_GasLife = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_GasLife70 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_VoidSpacecm3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_VoidSpacecm3 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadButton_ESR = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Store = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel_MicroFarad2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_PhysicalCaseFill = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_MaxCapAt90Fit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_MaxCapAt90Fit = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_PhysicalCaseFill = New Telerik.WinControls.UI.RadTextBox()
        Me.RadCheckBox_Show = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel_DesignNotes = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_DesignNotes = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_GasLife120 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_GasLife70 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadPanel_MenuTop,System.ComponentModel.ISupportInitialize).BeginInit
        Me.RadPanel_MenuTop.SuspendLayout
        CType(Me.RadCheckBox_UsePRMSCostReport,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadCheckBox_DesChecked,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_KPartNumber,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel_TopBarGroup2.SuspendLayout
        CType(Me.RadTextBox_DesApp,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Issue,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_QAApp,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Issue,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_DesApp,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Date,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_QAApp,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Date,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_ClearApps,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel_TopBarRadioButtons.SuspendLayout
        CType(Me.RadTextBox_SQApp_2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_SQApp,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_SQApp,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_SDApp,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_SDApp,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Summary,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Summary,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_CelsiusDegreesMin,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_CelsiusDegreesMax,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_CelsiusDegreesMin,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_CelsiusDegreesMax,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Percentage_2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Percentage,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_PositivePercentage,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_NegativePercentage,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Positive,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Negative,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_MicroFarad,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_V,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Volts,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Volts,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Cap,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_ASNo,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Dia,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Len,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Len,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_ASNo,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Dia_2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Len_2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Dia,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_PrintCost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_ShowSpec,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_PrintDesign,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_PrevSpec,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_PrintEsr,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_DeUser,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Range,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_U,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_R,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Cap,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_PartNumber,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_PartStyle,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_DeleteScratch,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_Evaluate,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_Refresh,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_ShowAllRecs,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_Rename,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_UpdateMain,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_GoToSummary,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_NewDesign,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadScrollablePanel_Container,System.ComponentModel.ISupportInitialize).BeginInit
        Me.RadScrollablePanel_Container.PanelContainer.SuspendLayout
        Me.RadScrollablePanel_Container.SuspendLayout
        Me.Panel_SpecificationDetails.SuspendLayout
        CType(Me.RadLabel_SEVtestvoltage,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_SurgeOrVDEvoltage,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_SEVtestvoltage,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_SurgeOrVDEvoltage,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_CelsiusDegrees,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_RatedIr3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_RatedIr3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_RatedIr2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_RatedIr2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Notes,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_RatedIr,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Notes,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_RatedIr,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Dimensions,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Terminals,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_SpecDwg,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Distributor,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_CustPNo,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Dimensions,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Terminals,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_SpecDwg,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Distributor,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_CustPNo,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_SpecificationDetails,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Customer,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Customer,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabControl_PrintCatExtra.SuspendLayout
        Me.ScratchP_PrintDetail.SuspendLayout
        CType(Me.RadGroupBox_PrintDetail,System.ComponentModel.ISupportInitialize).BeginInit
        Me.RadGroupBox_PrintDetail.SuspendLayout
        CType(Me.RadTextBox_PartsCost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_MelCostRaw,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_MelTCost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_MelQty,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_MelinexCost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_PrintDrawing,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_PrintDrawing,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_ViewCentred,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_PrintDetailMax13Lines,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_PrintNotes,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ScratchP_CatData.SuspendLayout
        Me.Panel_CatalogueData.SuspendLayout
        CType(Me.RadTextBox_condy_eq,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_IrT,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_IrF,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Rise_T,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Rbo,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Rwb,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_IrT,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_IrF,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Rise_T,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Rbo,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Rwb,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Rhw,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Ir,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Rha,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_condy_eq,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_oxide_fi,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_tissue_ti,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_tabbing,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_foil,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Ir,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Rha,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_oxide_fi,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_tissue_ti,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_tabbing,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Rhw,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_foil,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel_CatalogueDataTitle.SuspendLayout
        CType(Me.RadLabel_CatalogueData,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_ViewAllCatData,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadGridView2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadGridView2.MasterTemplate,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ScratchP_ExtraFields.SuspendLayout
        CType(Me.RadButton_EditFields,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadGridView_ExtraFields,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadGridView_ExtraFields.MasterTemplate,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel_Anode.SuspendLayout
        CType(Me.RadLabel_Cost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Anode3Cost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Anode2Cost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Anode1Cost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Melinex,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Mm3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Mm2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_AnodeLenght2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_AnodeLenght,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Melinex,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_FaradPerSquareCm3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_FaradPerSquareCm2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_MinGain,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_MinGain,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Anode3Amount,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_StdLength,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Anode2Amount,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Anode3Width,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Anode1Width,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Anode3Vf,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_AnodeGain2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Anode3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Anode2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Anode3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Anode2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_MaxLen,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_PercentageFit,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Factor,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Anode1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_AnodeGain,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Factor,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_WindingDetails,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadCheckBox_UserGain,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Anode_Vertical,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_MaxLen,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_PercentageFit,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Anode1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Vf,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Anode1Vf,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Anode2Vf,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Width,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Anode2Width,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Amount,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Anode1Amount,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Mm,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_FaradPerSquareCm,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_PercentageFit2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel_Parameters.SuspendLayout
        CType(Me.RadLabel_TestVolts,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_IMPAt10000HzAt20C,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_IMPAt10000HzAt20C,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_ESRAt100HzAt20C,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_ESRAt100HzAt20C,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_ParameterCondition,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_ParameterValue,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Parameter,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_ParameterCondition4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_ParameterValue4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_ParameterCondition3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_ParameterValue3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_ParameterCondition2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_ParameterValue2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadCheckBox_ac,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_TestVolts,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_ParameterCondition1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_ParameterValue1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Parameter4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Parameter3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Parameter2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_MicroFarad4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Capacitance2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_to,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_MicroFarad3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Capacitance,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Capacitance,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Parameter1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_GetLimits,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_TestParameters,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel_Cathode.SuspendLayout
        CType(Me.RadTextBox_CathodeCost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadCheckBox_Swage,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Swage,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Mm4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_CathExtension,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_CathExtension,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_CathodeVf,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_CathodeAmount,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_CathodeWidth,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Cath,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Cathode,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel_Notes.SuspendLayout
        CType(Me.RadDropDownList_Note3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Note3Type,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Note2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Note3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Note2Type,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Note2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Note1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Note,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_NoteType,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Note1Type,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Note1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Sequence,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_ArrowRight,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel_NotesLanguages.SuspendLayout
        CType(Me.RadButton_NotesMax10escroutnotes,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel_TopRight.SuspendLayout
        CType(Me.RadLabel_SpecDrawing,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_WindingPicture,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_DimensionDwg,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_WindingPicture,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Routing,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_PartsFile,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_SpecDrawing,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_PartsFile,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_DimensionDwg,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Routing,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel_Elyte.SuspendLayout
        CType(Me.RadLabel_MiniPrewrap,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_MiniPrewrap,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadCheckBox_AutoWidth,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_ElyteCost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadCheckBox_Scrollbar,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Scrollbar,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_ElyteAmount,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Elyte,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Elyte,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel_Tissue.SuspendLayout
        CType(Me.RadTextBox_Tissue3Cost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Tissue2Cost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Tissue1Cost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadCheckBox_AfterWrap,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_AfterWrap,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_PreWrapLength,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_PreWrapLength,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_PreWrapTurns,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_PreWrapTurns,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Tissue3Amount,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Tissue2Amount,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Tissue3Width,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Tissue1Width,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Tissue3Vf,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Tissue_Vertical,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Tissue3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Tissue2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Tissue3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Tissue2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Tissue1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Tissue1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Tissue1Vf,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Tissue2Width,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Tissue1Amount,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Tissue2Vf,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel_Freqs.SuspendLayout
        CType(Me.RadButton_MoreDetail,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_LifeCalc,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_WriteCatData,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_Refresh2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_GetData,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_DefaultFreqs,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_HSink,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_EDType,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Mm9,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_VFactorMm,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_EDType,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_AirflowMs,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadCheckBox_UseActualEsr,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_ATc,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_FailMode,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_LifeLop,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_FailMode,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_LifeLop,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_ActEsrTemp,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_UseActualEsr,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_ActEsrTemp,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_ESRFactorKe,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_MaxESRx,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_ESRFactorKe,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_MaxESRx,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_TrForCalcIr,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_MaxCoreTm,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_TrForCalcIr,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_MaxCoreTm,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_VFactorKv,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_StdVfs,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_VFactorKv,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_StdVfs,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_CurrentPaths,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_CurrentPaths,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_AirflowMs,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_ActTrxAtEOLTx,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_ArrheniusT2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_ActTrxAtEOLTx,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_ArrheniusT2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_TrCoreRise,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_AverageTh,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_TrCoreRise,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_AverageTh,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_HSink,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_OpVop,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_OpVop,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadCheckBox_old,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_RHaCperWatt,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_RHaCperWatt,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_LifeFactorLe,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_LifeFactorLe,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_ATc,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_AmbientTa,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_AmbientTa,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadGridView1.MasterTemplate,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel_Tab.SuspendLayout
        CType(Me.RadTextBox_MatCost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_TabCost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Mm8,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Hole,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Hole,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_NoDot,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_NoDot,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_L2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_L2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_L1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_L1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Mm7,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_TabAmount,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Tab,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadDropDownList_Tab,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel_TissueRight.SuspendLayout
        CType(Me.RadLabel_Mm5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Mandrel,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_CanCode,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_CanInt,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_CanInt,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Mandrel,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_CanCode,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Mm6,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabControl_Ctl.SuspendLayout
        Me.Tab_Ctl.SuspendLayout
        CType(Me.RadLabel_Ctl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_RelForm,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadCheckBox_DisplayCosts,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Tab_Cost.SuspendLayout
        CType(Me.RadLabel_NoLABData,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_StandardCost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_VariableCost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Labour,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_StandardCost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_VariableCost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Labour,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Material,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Material,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Tab_Yield.SuspendLayout
        CType(Me.RadTextBox_An3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_An2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Tiytg,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Anytg,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_CaYC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_An1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Ti3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Ti2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Ti1YC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_OY,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_OY,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Caytg,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Caytg,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Tiytg,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_CaYC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_An3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Anytg,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_An2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_An1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Ti3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Ti2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Ti1YC,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Tab_Lab.SuspendLayout
        CType(Me.RadTextBox_Dep,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Dep,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Fix,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Fix,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Var,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Var,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_WLC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_WLC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_RCost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_RCost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_CLC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_CLC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_T3LC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_T3LC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_A3LC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_A3LC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_T2LC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_T2LC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_A2LC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_A2LC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_T1LC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_T1LC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_A1LC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_A1LC,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Tab_OldTab.SuspendLayout
        CType(Me.RadLabel_Variable,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_TotalCostVariable,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_OHCostVariable,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_LabourCostVariable,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_PartsCostVariable,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_WindCostVariable,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_TotalCostGross,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_TotalCost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_OHCostGross,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_OHCost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_LabourCostGross,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_LabourCost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_PartsCostGross,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_PartsCost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_WindCostGross,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_WindCost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Gross,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Tab_OldTab2.SuspendLayout
        CType(Me.RadTextBox_SMV,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_SMV,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_Group,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_Group,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel_CapAndNotes.SuspendLayout
        CType(Me.RadTextBox_GasLife120,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_GasLife,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_GasLife70,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_VoidSpacecm3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_VoidSpacecm3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_ESR,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadButton_Store,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_MicroFarad2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_PhysicalCaseFill,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_MaxCapAt90Fit,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_MaxCapAt90Fit,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_PhysicalCaseFill,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadCheckBox_Show,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_DesignNotes,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadTextBox_DesignNotes,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_GasLife120,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabel_GasLife70,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'RadPanel_MenuTop
        '
        Me.RadPanel_MenuTop.AutoScroll = true
        Me.RadPanel_MenuTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(173,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(217,Byte),Integer))
        Me.RadPanel_MenuTop.Controls.Add(Me.RadCheckBox_DesChecked)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadLabel_KPartNumber)
        Me.RadPanel_MenuTop.Controls.Add(Me.Panel_TopBarGroup2)
        Me.RadPanel_MenuTop.Controls.Add(Me.Panel_TopBarRadioButtons)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadTextBox_SQApp_2)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadLabel_SQApp)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadTextBox_SQApp)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadLabel_SDApp)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadTextBox_SDApp)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadLabel_Summary)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadTextBox_Summary)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadLabel_CelsiusDegreesMin)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadLabel_CelsiusDegreesMax)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadDropDownList_CelsiusDegreesMin)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadDropDownList_CelsiusDegreesMax)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadLabel_Percentage_2)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadLabel_Percentage)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadTextBox_PositivePercentage)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadTextBox_NegativePercentage)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadLabel_Positive)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadLabel_Negative)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadLabel_MicroFarad)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadLabel_V)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadLabel_Volts)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadTextBox_Volts)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadLabel_Cap)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadLabel_ASNo)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadLabel_Dia)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadLabel_Len)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadTextBox_Len)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadTextBox_ASNo)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadTextBox_Dia_2)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadTextBox_Len_2)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadTextBox_Dia)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadButton_PrintCost)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadButton_ShowSpec)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadButton_PrintDesign)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadButton_PrevSpec)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadButton_PrintEsr)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadTextBox_DeUser)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadDropDownList_Range)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadLabel_U)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadLabel_R)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadTextBox_Cap)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadTextBox_PartNumber)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadDropDownList_PartStyle)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadButton_DeleteScratch)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadButton_Evaluate)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadButton_Refresh)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadButton_ShowAllRecs)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadButton_Rename)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadButton_UpdateMain)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadButton_GoToSummary)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadButton_NewDesign)
        Me.RadPanel_MenuTop.Controls.Add(Me.RadCheckBox_UsePRMSCostReport)
        Me.RadPanel_MenuTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel_MenuTop.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel_MenuTop.MinimumSize = New System.Drawing.Size(992, 125)
        Me.RadPanel_MenuTop.Name = "RadPanel_MenuTop"
        '
        '
        '
        Me.RadPanel_MenuTop.RootElement.MinSize = New System.Drawing.Size(992, 125)
        Me.RadPanel_MenuTop.Size = New System.Drawing.Size(992, 125)
        Me.RadPanel_MenuTop.TabIndex = 0
        '
        'RadCheckBox_UsePRMSCostReport
        '
        Me.RadCheckBox_UsePRMSCostReport.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadCheckBox_UsePRMSCostReport.AutoSize = false
        Me.RadCheckBox_UsePRMSCostReport.CheckAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.RadCheckBox_UsePRMSCostReport.EnableGestures = false
        Me.RadCheckBox_UsePRMSCostReport.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.RadCheckBox_UsePRMSCostReport.Location = New System.Drawing.Point(421, 84)
        Me.RadCheckBox_UsePRMSCostReport.Name = "RadCheckBox_UsePRMSCostReport"
        Me.RadCheckBox_UsePRMSCostReport.Size = New System.Drawing.Size(65, 40)
        Me.RadCheckBox_UsePRMSCostReport.TabIndex = 89
        Me.RadCheckBox_UsePRMSCostReport.Text = "ScratchP_UsePRMSCostReport"
        Me.RadCheckBox_UsePRMSCostReport.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadCheckBox_UsePRMSCostReport.Visible = false
        '
        'RadCheckBox_DesChecked
        '
        Me.RadCheckBox_DesChecked.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadCheckBox_DesChecked.AutoSize = false
        Me.RadCheckBox_DesChecked.CheckAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.RadCheckBox_DesChecked.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadCheckBox_DesChecked.Location = New System.Drawing.Point(421, 89)
        Me.RadCheckBox_DesChecked.Name = "RadCheckBox_DesChecked"
        Me.RadCheckBox_DesChecked.Size = New System.Drawing.Size(65, 30)
        Me.RadCheckBox_DesChecked.TabIndex = 88
        Me.RadCheckBox_DesChecked.Text = "Global_Checked"
        Me.RadCheckBox_DesChecked.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadCheckBox_DesChecked.Visible = false
        '
        'RadLabel_KPartNumber
        '
        Me.RadLabel_KPartNumber.AutoSize = false
        Me.RadLabel_KPartNumber.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_KPartNumber.Location = New System.Drawing.Point(12, 33)
        Me.RadLabel_KPartNumber.Name = "RadLabel_KPartNumber"
        Me.RadLabel_KPartNumber.Size = New System.Drawing.Size(226, 23)
        Me.RadLabel_KPartNumber.TabIndex = 51
        Me.RadLabel_KPartNumber.Text = "A902GF025V330AV502"
        Me.RadLabel_KPartNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel_TopBarGroup2
        '
        Me.Panel_TopBarGroup2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_TopBarGroup2.Controls.Add(Me.RadTextBox_DesApp)
        Me.Panel_TopBarGroup2.Controls.Add(Me.RadLabel_Issue)
        Me.Panel_TopBarGroup2.Controls.Add(Me.RadTextBox_QAApp)
        Me.Panel_TopBarGroup2.Controls.Add(Me.RadTextBox_Issue)
        Me.Panel_TopBarGroup2.Controls.Add(Me.RadButton_DesApp)
        Me.Panel_TopBarGroup2.Controls.Add(Me.RadLabel_Date)
        Me.Panel_TopBarGroup2.Controls.Add(Me.RadButton_QAApp)
        Me.Panel_TopBarGroup2.Controls.Add(Me.RadTextBox_Date)
        Me.Panel_TopBarGroup2.Controls.Add(Me.RadButton_ClearApps)
        Me.Panel_TopBarGroup2.Location = New System.Drawing.Point(861, 5)
        Me.Panel_TopBarGroup2.Name = "Panel_TopBarGroup2"
        Me.Panel_TopBarGroup2.Size = New System.Drawing.Size(119, 117)
        Me.Panel_TopBarGroup2.TabIndex = 50
        '
        'RadTextBox_DesApp
        '
        Me.RadTextBox_DesApp.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_DesApp.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_DesApp.Location = New System.Drawing.Point(66, 90)
        Me.RadTextBox_DesApp.MinimumSize = New System.Drawing.Size(46, 20)
        Me.RadTextBox_DesApp.Name = "RadTextBox_DesApp"
        '
        '
        '
        Me.RadTextBox_DesApp.RootElement.MinSize = New System.Drawing.Size(46, 20)
        Me.RadTextBox_DesApp.Size = New System.Drawing.Size(46, 20)
        Me.RadTextBox_DesApp.TabIndex = 29
        Me.RadTextBox_DesApp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_Issue
        '
        Me.RadLabel_Issue.AutoSize = false
        Me.RadLabel_Issue.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Issue.Location = New System.Drawing.Point(3, 4)
        Me.RadLabel_Issue.Name = "RadLabel_Issue"
        Me.RadLabel_Issue.Size = New System.Drawing.Size(48, 23)
        Me.RadLabel_Issue.TabIndex = 22
        Me.RadLabel_Issue.Text = "ScratchP_Issue"
        Me.RadLabel_Issue.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_QAApp
        '
        Me.RadTextBox_QAApp.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_QAApp.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_QAApp.Location = New System.Drawing.Point(66, 69)
        Me.RadTextBox_QAApp.MinimumSize = New System.Drawing.Size(46, 20)
        Me.RadTextBox_QAApp.Name = "RadTextBox_QAApp"
        '
        '
        '
        Me.RadTextBox_QAApp.RootElement.MinSize = New System.Drawing.Size(46, 20)
        Me.RadTextBox_QAApp.Size = New System.Drawing.Size(46, 20)
        Me.RadTextBox_QAApp.TabIndex = 24
        Me.RadTextBox_QAApp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_Issue
        '
        Me.RadTextBox_Issue.Enabled = false
        Me.RadTextBox_Issue.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Issue.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Issue.Location = New System.Drawing.Point(52, 5)
        Me.RadTextBox_Issue.Name = "RadTextBox_Issue"
        Me.RadTextBox_Issue.Size = New System.Drawing.Size(60, 20)
        Me.RadTextBox_Issue.TabIndex = 23
        Me.RadTextBox_Issue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadButton_DesApp
        '
        Me.RadButton_DesApp.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_DesApp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_DesApp.ForeColor = System.Drawing.Color.Black
        Me.RadButton_DesApp.Location = New System.Drawing.Point(3, 90)
        Me.RadButton_DesApp.Name = "RadButton_DesApp"
        Me.RadButton_DesApp.Size = New System.Drawing.Size(58, 20)
        Me.RadButton_DesApp.TabIndex = 28
        Me.RadButton_DesApp.Text = "ScratchP_DesApp"
        Me.RadButton_DesApp.TextWrap = true
        '
        'RadLabel_Date
        '
        Me.RadLabel_Date.AutoSize = false
        Me.RadLabel_Date.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Date.Location = New System.Drawing.Point(3, 23)
        Me.RadLabel_Date.Name = "RadLabel_Date"
        Me.RadLabel_Date.Size = New System.Drawing.Size(48, 23)
        Me.RadLabel_Date.TabIndex = 24
        Me.RadLabel_Date.Text = "ScratchP_Date"
        Me.RadLabel_Date.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadButton_QAApp
        '
        Me.RadButton_QAApp.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_QAApp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_QAApp.ForeColor = System.Drawing.Color.Black
        Me.RadButton_QAApp.Location = New System.Drawing.Point(3, 69)
        Me.RadButton_QAApp.Name = "RadButton_QAApp"
        Me.RadButton_QAApp.Size = New System.Drawing.Size(58, 20)
        Me.RadButton_QAApp.TabIndex = 27
        Me.RadButton_QAApp.Text = "ScratchP_QAApp"
        Me.RadButton_QAApp.TextWrap = true
        '
        'RadTextBox_Date
        '
        Me.RadTextBox_Date.Enabled = false
        Me.RadTextBox_Date.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Date.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Date.Location = New System.Drawing.Point(52, 24)
        Me.RadTextBox_Date.Name = "RadTextBox_Date"
        Me.RadTextBox_Date.Size = New System.Drawing.Size(60, 20)
        Me.RadTextBox_Date.TabIndex = 25
        Me.RadTextBox_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadButton_ClearApps
        '
        Me.RadButton_ClearApps.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_ClearApps.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_ClearApps.ForeColor = System.Drawing.Color.Black
        Me.RadButton_ClearApps.Location = New System.Drawing.Point(3, 47)
        Me.RadButton_ClearApps.Name = "RadButton_ClearApps"
        Me.RadButton_ClearApps.Size = New System.Drawing.Size(109, 20)
        Me.RadButton_ClearApps.TabIndex = 26
        Me.RadButton_ClearApps.Text = "ScratchP_ClearApps"
        Me.RadButton_ClearApps.TextWrap = true
        '
        'Panel_TopBarRadioButtons
        '
        Me.Panel_TopBarRadioButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_TopBarRadioButtons.Controls.Add(Me.RadioButton_Outline)
        Me.Panel_TopBarRadioButtons.Controls.Add(Me.RadioButton_Live)
        Me.Panel_TopBarRadioButtons.Controls.Add(Me.RadioButton_Obs)
        Me.Panel_TopBarRadioButtons.Controls.Add(Me.RadioButton_Hold)
        Me.Panel_TopBarRadioButtons.Location = New System.Drawing.Point(792, 5)
        Me.Panel_TopBarRadioButtons.Name = "Panel_TopBarRadioButtons"
        Me.Panel_TopBarRadioButtons.Size = New System.Drawing.Size(63, 117)
        Me.Panel_TopBarRadioButtons.TabIndex = 49
        '
        'RadioButton_Outline
        '
        Me.RadioButton_Outline.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton_Outline.BackColor = System.Drawing.Color.Gainsboro
        Me.RadioButton_Outline.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton_Outline.Location = New System.Drawing.Point(3, 85)
        Me.RadioButton_Outline.Name = "RadioButton_Outline"
        Me.RadioButton_Outline.Size = New System.Drawing.Size(54, 23)
        Me.RadioButton_Outline.TabIndex = 3
        Me.RadioButton_Outline.TabStop = true
        Me.RadioButton_Outline.Text = "ScratchP_Outline"
        Me.RadioButton_Outline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton_Outline.UseVisualStyleBackColor = false
        '
        'RadioButton_Live
        '
        Me.RadioButton_Live.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton_Live.BackColor = System.Drawing.Color.Gainsboro
        Me.RadioButton_Live.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton_Live.Location = New System.Drawing.Point(3, 6)
        Me.RadioButton_Live.Name = "RadioButton_Live"
        Me.RadioButton_Live.Size = New System.Drawing.Size(54, 23)
        Me.RadioButton_Live.TabIndex = 1
        Me.RadioButton_Live.TabStop = true
        Me.RadioButton_Live.Text = "ScratchP_Live"
        Me.RadioButton_Live.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton_Live.UseVisualStyleBackColor = false
        '
        'RadioButton_Obs
        '
        Me.RadioButton_Obs.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton_Obs.BackColor = System.Drawing.Color.Gainsboro
        Me.RadioButton_Obs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton_Obs.Location = New System.Drawing.Point(3, 54)
        Me.RadioButton_Obs.Name = "RadioButton_Obs"
        Me.RadioButton_Obs.Size = New System.Drawing.Size(54, 23)
        Me.RadioButton_Obs.TabIndex = 2
        Me.RadioButton_Obs.TabStop = true
        Me.RadioButton_Obs.Text = "ScratchP_Obs"
        Me.RadioButton_Obs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton_Obs.UseVisualStyleBackColor = false
        '
        'RadioButton_Hold
        '
        Me.RadioButton_Hold.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton_Hold.BackColor = System.Drawing.Color.Gainsboro
        Me.RadioButton_Hold.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton_Hold.Location = New System.Drawing.Point(3, 30)
        Me.RadioButton_Hold.Name = "RadioButton_Hold"
        Me.RadioButton_Hold.Size = New System.Drawing.Size(54, 23)
        Me.RadioButton_Hold.TabIndex = 0
        Me.RadioButton_Hold.TabStop = true
        Me.RadioButton_Hold.Text = "ScratchP_Hold"
        Me.RadioButton_Hold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton_Hold.UseVisualStyleBackColor = false
        '
        'RadTextBox_SQApp_2
        '
        Me.RadTextBox_SQApp_2.Enabled = false
        Me.RadTextBox_SQApp_2.Font = New System.Drawing.Font("Segoe UI", 7!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_SQApp_2.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_SQApp_2.Location = New System.Drawing.Point(542, 60)
        Me.RadTextBox_SQApp_2.Name = "RadTextBox_SQApp_2"
        Me.RadTextBox_SQApp_2.Size = New System.Drawing.Size(50, 18)
        Me.RadTextBox_SQApp_2.TabIndex = 48
        Me.RadTextBox_SQApp_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_SQApp
        '
        Me.RadLabel_SQApp.AutoSize = false
        Me.RadLabel_SQApp.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_SQApp.Location = New System.Drawing.Point(447, 61)
        Me.RadLabel_SQApp.Name = "RadLabel_SQApp"
        Me.RadLabel_SQApp.Size = New System.Drawing.Size(50, 18)
        Me.RadLabel_SQApp.TabIndex = 48
        Me.RadLabel_SQApp.Text = "ScratchP_SQApp"
        Me.RadLabel_SQApp.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_SQApp
        '
        Me.RadTextBox_SQApp.Enabled = false
        Me.RadTextBox_SQApp.Font = New System.Drawing.Font("Segoe UI", 7!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_SQApp.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_SQApp.Location = New System.Drawing.Point(496, 60)
        Me.RadTextBox_SQApp.Name = "RadTextBox_SQApp"
        Me.RadTextBox_SQApp.Size = New System.Drawing.Size(40, 18)
        Me.RadTextBox_SQApp.TabIndex = 47
        Me.RadTextBox_SQApp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_SDApp
        '
        Me.RadLabel_SDApp.AutoSize = false
        Me.RadLabel_SDApp.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_SDApp.Location = New System.Drawing.Point(356, 61)
        Me.RadLabel_SDApp.Name = "RadLabel_SDApp"
        Me.RadLabel_SDApp.Size = New System.Drawing.Size(50, 18)
        Me.RadLabel_SDApp.TabIndex = 46
        Me.RadLabel_SDApp.Text = "ScratchP_SDApp"
        Me.RadLabel_SDApp.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_SDApp
        '
        Me.RadTextBox_SDApp.Enabled = false
        Me.RadTextBox_SDApp.Font = New System.Drawing.Font("Segoe UI", 7!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_SDApp.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_SDApp.Location = New System.Drawing.Point(406, 60)
        Me.RadTextBox_SDApp.Name = "RadTextBox_SDApp"
        Me.RadTextBox_SDApp.Size = New System.Drawing.Size(40, 18)
        Me.RadTextBox_SDApp.TabIndex = 45
        Me.RadTextBox_SDApp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_Summary
        '
        Me.RadLabel_Summary.AutoSize = false
        Me.RadLabel_Summary.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Summary.Location = New System.Drawing.Point(270, 61)
        Me.RadLabel_Summary.Name = "RadLabel_Summary"
        Me.RadLabel_Summary.Size = New System.Drawing.Size(58, 18)
        Me.RadLabel_Summary.TabIndex = 44
        Me.RadLabel_Summary.Text = "ScratchP_Summary"
        Me.RadLabel_Summary.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_Summary
        '
        Me.RadTextBox_Summary.Enabled = false
        Me.RadTextBox_Summary.Font = New System.Drawing.Font("Segoe UI", 7!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Summary.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Summary.Location = New System.Drawing.Point(327, 60)
        Me.RadTextBox_Summary.Name = "RadTextBox_Summary"
        Me.RadTextBox_Summary.Size = New System.Drawing.Size(29, 18)
        Me.RadTextBox_Summary.TabIndex = 43
        Me.RadTextBox_Summary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_CelsiusDegreesMin
        '
        Me.RadLabel_CelsiusDegreesMin.AutoSize = false
        Me.RadLabel_CelsiusDegreesMin.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel_CelsiusDegreesMin.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_CelsiusDegreesMin.Location = New System.Drawing.Point(560, 35)
        Me.RadLabel_CelsiusDegreesMin.Name = "RadLabel_CelsiusDegreesMin"
        Me.RadLabel_CelsiusDegreesMin.Size = New System.Drawing.Size(24, 23)
        Me.RadLabel_CelsiusDegreesMin.TabIndex = 42
        Me.RadLabel_CelsiusDegreesMin.Text = "Global_CelsiusDegrees"
        Me.RadLabel_CelsiusDegreesMin.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_CelsiusDegreesMax
        '
        Me.RadLabel_CelsiusDegreesMax.AutoSize = false
        Me.RadLabel_CelsiusDegreesMax.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel_CelsiusDegreesMax.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_CelsiusDegreesMax.Location = New System.Drawing.Point(487, 35)
        Me.RadLabel_CelsiusDegreesMax.Name = "RadLabel_CelsiusDegreesMax"
        Me.RadLabel_CelsiusDegreesMax.Size = New System.Drawing.Size(24, 23)
        Me.RadLabel_CelsiusDegreesMax.TabIndex = 41
        Me.RadLabel_CelsiusDegreesMax.Text = "Global_CelsiusDegrees"
        Me.RadLabel_CelsiusDegreesMax.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadDropDownList_CelsiusDegreesMin
        '
        Me.RadDropDownList_CelsiusDegreesMin.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_CelsiusDegreesMin.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_CelsiusDegreesMin.Location = New System.Drawing.Point(512, 35)
        Me.RadDropDownList_CelsiusDegreesMin.Name = "RadDropDownList_CelsiusDegreesMin"
        Me.RadDropDownList_CelsiusDegreesMin.Size = New System.Drawing.Size(49, 23)
        Me.RadDropDownList_CelsiusDegreesMin.TabIndex = 40
        Me.RadDropDownList_CelsiusDegreesMin.Text = "-40"
        '
        'RadDropDownList_CelsiusDegreesMax
        '
        Me.RadDropDownList_CelsiusDegreesMax.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_CelsiusDegreesMax.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_CelsiusDegreesMax.Location = New System.Drawing.Point(439, 35)
        Me.RadDropDownList_CelsiusDegreesMax.Name = "RadDropDownList_CelsiusDegreesMax"
        Me.RadDropDownList_CelsiusDegreesMax.Size = New System.Drawing.Size(49, 23)
        Me.RadDropDownList_CelsiusDegreesMax.TabIndex = 39
        Me.RadDropDownList_CelsiusDegreesMax.Text = "85"
        '
        'RadLabel_Percentage_2
        '
        Me.RadLabel_Percentage_2.AutoSize = false
        Me.RadLabel_Percentage_2.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Percentage_2.Location = New System.Drawing.Point(561, 8)
        Me.RadLabel_Percentage_2.Name = "RadLabel_Percentage_2"
        Me.RadLabel_Percentage_2.Size = New System.Drawing.Size(17, 23)
        Me.RadLabel_Percentage_2.TabIndex = 38
        Me.RadLabel_Percentage_2.Text = "Global_Percentage"
        Me.RadLabel_Percentage_2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_Percentage
        '
        Me.RadLabel_Percentage.AutoSize = false
        Me.RadLabel_Percentage.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Percentage.Location = New System.Drawing.Point(489, 8)
        Me.RadLabel_Percentage.Name = "RadLabel_Percentage"
        Me.RadLabel_Percentage.Size = New System.Drawing.Size(17, 23)
        Me.RadLabel_Percentage.TabIndex = 35
        Me.RadLabel_Percentage.Text = "Global_Percentage"
        Me.RadLabel_Percentage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadTextBox_PositivePercentage
        '
        Me.RadTextBox_PositivePercentage.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_PositivePercentage.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_PositivePercentage.Location = New System.Drawing.Point(529, 7)
        Me.RadTextBox_PositivePercentage.Name = "RadTextBox_PositivePercentage"
        Me.RadTextBox_PositivePercentage.Size = New System.Drawing.Size(32, 25)
        Me.RadTextBox_PositivePercentage.TabIndex = 37
        Me.RadTextBox_PositivePercentage.Text = "20"
        Me.RadTextBox_PositivePercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_NegativePercentage
        '
        Me.RadTextBox_NegativePercentage.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_NegativePercentage.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_NegativePercentage.Location = New System.Drawing.Point(456, 7)
        Me.RadTextBox_NegativePercentage.Name = "RadTextBox_NegativePercentage"
        Me.RadTextBox_NegativePercentage.Size = New System.Drawing.Size(32, 25)
        Me.RadTextBox_NegativePercentage.TabIndex = 34
        Me.RadTextBox_NegativePercentage.Text = "20"
        Me.RadTextBox_NegativePercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_Positive
        '
        Me.RadLabel_Positive.AutoSize = false
        Me.RadLabel_Positive.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Positive.Location = New System.Drawing.Point(514, 7)
        Me.RadLabel_Positive.Name = "RadLabel_Positive"
        Me.RadLabel_Positive.Size = New System.Drawing.Size(17, 23)
        Me.RadLabel_Positive.TabIndex = 36
        Me.RadLabel_Positive.Text = "Global_Positive"
        Me.RadLabel_Positive.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_Negative
        '
        Me.RadLabel_Negative.AutoSize = false
        Me.RadLabel_Negative.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Negative.Location = New System.Drawing.Point(441, 7)
        Me.RadLabel_Negative.Name = "RadLabel_Negative"
        Me.RadLabel_Negative.Size = New System.Drawing.Size(17, 23)
        Me.RadLabel_Negative.TabIndex = 33
        Me.RadLabel_Negative.Text = "Global_Negative"
        Me.RadLabel_Negative.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_MicroFarad
        '
        Me.RadLabel_MicroFarad.AutoSize = false
        Me.RadLabel_MicroFarad.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_MicroFarad.Location = New System.Drawing.Point(411, 8)
        Me.RadLabel_MicroFarad.Name = "RadLabel_MicroFarad"
        Me.RadLabel_MicroFarad.Size = New System.Drawing.Size(25, 23)
        Me.RadLabel_MicroFarad.TabIndex = 32
        Me.RadLabel_MicroFarad.Text = "Units_MicroFarad"
        Me.RadLabel_MicroFarad.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_V
        '
        Me.RadLabel_V.AutoSize = false
        Me.RadLabel_V.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_V.Location = New System.Drawing.Point(379, 35)
        Me.RadLabel_V.Name = "RadLabel_V"
        Me.RadLabel_V.Size = New System.Drawing.Size(31, 23)
        Me.RadLabel_V.TabIndex = 31
        Me.RadLabel_V.Text = "Global_V"
        Me.RadLabel_V.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_Volts
        '
        Me.RadLabel_Volts.AutoSize = false
        Me.RadLabel_Volts.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Volts.Location = New System.Drawing.Point(244, 33)
        Me.RadLabel_Volts.Name = "RadLabel_Volts"
        Me.RadLabel_Volts.Size = New System.Drawing.Size(61, 23)
        Me.RadLabel_Volts.TabIndex = 30
        Me.RadLabel_Volts.Text = "Global_Volts"
        Me.RadLabel_Volts.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_Volts
        '
        Me.RadTextBox_Volts.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Volts.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Volts.Location = New System.Drawing.Point(311, 33)
        Me.RadTextBox_Volts.Name = "RadTextBox_Volts"
        Me.RadTextBox_Volts.Size = New System.Drawing.Size(62, 25)
        Me.RadTextBox_Volts.TabIndex = 29
        Me.RadTextBox_Volts.Text = "400"
        Me.RadTextBox_Volts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_Cap
        '
        Me.RadLabel_Cap.AutoSize = false
        Me.RadLabel_Cap.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Cap.Location = New System.Drawing.Point(244, 8)
        Me.RadLabel_Cap.Name = "RadLabel_Cap"
        Me.RadLabel_Cap.Size = New System.Drawing.Size(61, 23)
        Me.RadLabel_Cap.TabIndex = 28
        Me.RadLabel_Cap.Text = "ScratchP_Cap"
        Me.RadLabel_Cap.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_ASNo
        '
        Me.RadLabel_ASNo.AutoSize = false
        Me.RadLabel_ASNo.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_ASNo.Location = New System.Drawing.Point(591, 7)
        Me.RadLabel_ASNo.Name = "RadLabel_ASNo"
        Me.RadLabel_ASNo.Size = New System.Drawing.Size(80, 23)
        Me.RadLabel_ASNo.TabIndex = 27
        Me.RadLabel_ASNo.Text = "ScratchP_ASNo"
        Me.RadLabel_ASNo.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_Dia
        '
        Me.RadLabel_Dia.AutoSize = false
        Me.RadLabel_Dia.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Dia.Location = New System.Drawing.Point(591, 33)
        Me.RadLabel_Dia.Name = "RadLabel_Dia"
        Me.RadLabel_Dia.Size = New System.Drawing.Size(49, 23)
        Me.RadLabel_Dia.TabIndex = 26
        Me.RadLabel_Dia.Text = "ScratchP_Dia"
        Me.RadLabel_Dia.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_Len
        '
        Me.RadLabel_Len.AutoSize = false
        Me.RadLabel_Len.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Len.Location = New System.Drawing.Point(592, 58)
        Me.RadLabel_Len.Name = "RadLabel_Len"
        Me.RadLabel_Len.Size = New System.Drawing.Size(49, 23)
        Me.RadLabel_Len.TabIndex = 25
        Me.RadLabel_Len.Text = "ScratchP_Len"
        Me.RadLabel_Len.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_Len
        '
        Me.RadTextBox_Len.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Len.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Len.Location = New System.Drawing.Point(642, 57)
        Me.RadTextBox_Len.Name = "RadTextBox_Len"
        Me.RadTextBox_Len.Size = New System.Drawing.Size(56, 25)
        Me.RadTextBox_Len.TabIndex = 24
        Me.RadTextBox_Len.Text = "220"
        Me.RadTextBox_Len.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_ASNo
        '
        Me.RadTextBox_ASNo.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_ASNo.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_ASNo.Location = New System.Drawing.Point(674, 5)
        Me.RadTextBox_ASNo.Name = "RadTextBox_ASNo"
        Me.RadTextBox_ASNo.Size = New System.Drawing.Size(116, 25)
        Me.RadTextBox_ASNo.TabIndex = 23
        Me.RadTextBox_ASNo.Text = "AS7015"
        '
        'RadTextBox_Dia_2
        '
        Me.RadTextBox_Dia_2.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Dia_2.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Dia_2.Location = New System.Drawing.Point(704, 31)
        Me.RadTextBox_Dia_2.Name = "RadTextBox_Dia_2"
        Me.RadTextBox_Dia_2.Size = New System.Drawing.Size(86, 25)
        Me.RadTextBox_Dia_2.TabIndex = 22
        Me.RadTextBox_Dia_2.Text = "+/-1"
        '
        'RadTextBox_Len_2
        '
        Me.RadTextBox_Len_2.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Len_2.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Len_2.Location = New System.Drawing.Point(704, 57)
        Me.RadTextBox_Len_2.Name = "RadTextBox_Len_2"
        Me.RadTextBox_Len_2.Size = New System.Drawing.Size(86, 25)
        Me.RadTextBox_Len_2.TabIndex = 12
        Me.RadTextBox_Len_2.Text = "+/-2"
        '
        'RadTextBox_Dia
        '
        Me.RadTextBox_Dia.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Dia.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Dia.Location = New System.Drawing.Point(642, 31)
        Me.RadTextBox_Dia.Name = "RadTextBox_Dia"
        Me.RadTextBox_Dia.Size = New System.Drawing.Size(56, 25)
        Me.RadTextBox_Dia.TabIndex = 11
        Me.RadTextBox_Dia.Text = "90"
        Me.RadTextBox_Dia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadButton_PrintCost
        '
        Me.RadButton_PrintCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_PrintCost.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_PrintCost.ForeColor = System.Drawing.Color.Black
        Me.RadButton_PrintCost.Location = New System.Drawing.Point(488, 85)
        Me.RadButton_PrintCost.Name = "RadButton_PrintCost"
        Me.RadButton_PrintCost.Size = New System.Drawing.Size(50, 40)
        Me.RadButton_PrintCost.TabIndex = 15
        Me.RadButton_PrintCost.Text = "ScratchP_PrintCost"
        Me.RadButton_PrintCost.TextWrap = true
        '
        'RadButton_ShowSpec
        '
        Me.RadButton_ShowSpec.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_ShowSpec.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_ShowSpec.ForeColor = System.Drawing.Color.Black
        Me.RadButton_ShowSpec.Location = New System.Drawing.Point(635, 85)
        Me.RadButton_ShowSpec.Name = "RadButton_ShowSpec"
        Me.RadButton_ShowSpec.Size = New System.Drawing.Size(50, 40)
        Me.RadButton_ShowSpec.TabIndex = 17
        Me.RadButton_ShowSpec.Text = "ScratchP_ShowSpec"
        Me.RadButton_ShowSpec.TextWrap = true
        '
        'RadButton_PrintDesign
        '
        Me.RadButton_PrintDesign.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_PrintDesign.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_PrintDesign.ForeColor = System.Drawing.Color.Black
        Me.RadButton_PrintDesign.Location = New System.Drawing.Point(586, 85)
        Me.RadButton_PrintDesign.Name = "RadButton_PrintDesign"
        Me.RadButton_PrintDesign.Size = New System.Drawing.Size(50, 40)
        Me.RadButton_PrintDesign.TabIndex = 18
        Me.RadButton_PrintDesign.Text = "ScratchP_PrintDesign"
        Me.RadButton_PrintDesign.TextWrap = true
        '
        'RadButton_PrevSpec
        '
        Me.RadButton_PrevSpec.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_PrevSpec.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_PrevSpec.ForeColor = System.Drawing.Color.Black
        Me.RadButton_PrevSpec.Location = New System.Drawing.Point(684, 85)
        Me.RadButton_PrevSpec.Name = "RadButton_PrevSpec"
        Me.RadButton_PrevSpec.Size = New System.Drawing.Size(50, 40)
        Me.RadButton_PrevSpec.TabIndex = 19
        Me.RadButton_PrevSpec.Text = "ScratchP_PrevSpec"
        Me.RadButton_PrevSpec.TextWrap = true
        '
        'RadButton_PrintEsr
        '
        Me.RadButton_PrintEsr.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_PrintEsr.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_PrintEsr.ForeColor = System.Drawing.Color.Black
        Me.RadButton_PrintEsr.Location = New System.Drawing.Point(537, 85)
        Me.RadButton_PrintEsr.Name = "RadButton_PrintEsr"
        Me.RadButton_PrintEsr.Size = New System.Drawing.Size(50, 40)
        Me.RadButton_PrintEsr.TabIndex = 16
        Me.RadButton_PrintEsr.Text = "ScratchP_PrintEsr"
        Me.RadButton_PrintEsr.TextWrap = true
        '
        'RadTextBox_DeUser
        '
        Me.RadTextBox_DeUser.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_DeUser.ForeColor = System.Drawing.Color.Blue
        Me.RadTextBox_DeUser.Location = New System.Drawing.Point(205, 56)
        Me.RadTextBox_DeUser.Name = "RadTextBox_DeUser"
        Me.RadTextBox_DeUser.Size = New System.Drawing.Size(63, 23)
        Me.RadTextBox_DeUser.TabIndex = 14
        Me.RadTextBox_DeUser.Text = "NMason"
        '
        'RadDropDownList_Range
        '
        Me.RadDropDownList_Range.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Range.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Range.Location = New System.Drawing.Point(85, 56)
        Me.RadDropDownList_Range.Name = "RadDropDownList_Range"
        Me.RadDropDownList_Range.Size = New System.Drawing.Size(102, 23)
        Me.RadDropDownList_Range.TabIndex = 9
        Me.RadDropDownList_Range.Text = "ALS30A"
        '
        'RadLabel_U
        '
        Me.RadLabel_U.AutoSize = false
        Me.RadLabel_U.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_U.Location = New System.Drawing.Point(190, 56)
        Me.RadLabel_U.Name = "RadLabel_U"
        Me.RadLabel_U.Size = New System.Drawing.Size(17, 23)
        Me.RadLabel_U.TabIndex = 13
        Me.RadLabel_U.Text = "Global_U"
        Me.RadLabel_U.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_R
        '
        Me.RadLabel_R.AutoSize = false
        Me.RadLabel_R.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_R.Location = New System.Drawing.Point(68, 56)
        Me.RadLabel_R.Name = "RadLabel_R"
        Me.RadLabel_R.Size = New System.Drawing.Size(17, 23)
        Me.RadLabel_R.TabIndex = 11
        Me.RadLabel_R.Text = "Global_R"
        Me.RadLabel_R.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_Cap
        '
        Me.RadTextBox_Cap.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Cap.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Cap.Location = New System.Drawing.Point(311, 7)
        Me.RadTextBox_Cap.Name = "RadTextBox_Cap"
        Me.RadTextBox_Cap.Size = New System.Drawing.Size(99, 25)
        Me.RadTextBox_Cap.TabIndex = 10
        Me.RadTextBox_Cap.Text = "13 000"
        Me.RadTextBox_Cap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_PartNumber
        '
        Me.RadTextBox_PartNumber.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_PartNumber.ForeColor = System.Drawing.Color.Blue
        Me.RadTextBox_PartNumber.Location = New System.Drawing.Point(12, 5)
        Me.RadTextBox_PartNumber.Name = "RadTextBox_PartNumber"
        Me.RadTextBox_PartNumber.Size = New System.Drawing.Size(226, 27)
        Me.RadTextBox_PartNumber.TabIndex = 8
        Me.RadTextBox_PartNumber.Text = "ALC10A1346DH"
        '
        'RadDropDownList_PartStyle
        '
        Me.RadDropDownList_PartStyle.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_PartStyle.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_PartStyle.Location = New System.Drawing.Point(12, 56)
        Me.RadDropDownList_PartStyle.Name = "RadDropDownList_PartStyle"
        Me.RadDropDownList_PartStyle.Size = New System.Drawing.Size(50, 23)
        Me.RadDropDownList_PartStyle.TabIndex = 7
        Me.RadDropDownList_PartStyle.Text = "SER"
        '
        'RadButton_DeleteScratch
        '
        Me.RadButton_DeleteScratch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_DeleteScratch.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_DeleteScratch.ForeColor = System.Drawing.Color.Black
        Me.RadButton_DeleteScratch.Location = New System.Drawing.Point(159, 85)
        Me.RadButton_DeleteScratch.Name = "RadButton_DeleteScratch"
        Me.RadButton_DeleteScratch.Size = New System.Drawing.Size(50, 40)
        Me.RadButton_DeleteScratch.TabIndex = 5
        Me.RadButton_DeleteScratch.Text = "ScratchP_DeleteScratch"
        Me.RadButton_DeleteScratch.TextWrap = true
        '
        'RadButton_Evaluate
        '
        Me.RadButton_Evaluate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_Evaluate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Evaluate.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Evaluate.Location = New System.Drawing.Point(316, 85)
        Me.RadButton_Evaluate.Name = "RadButton_Evaluate"
        Me.RadButton_Evaluate.Size = New System.Drawing.Size(55, 40)
        Me.RadButton_Evaluate.TabIndex = 6
        Me.RadButton_Evaluate.Text = "ScratchP_Evaluate"
        Me.RadButton_Evaluate.TextWrap = true
        '
        'RadButton_Refresh
        '
        Me.RadButton_Refresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_Refresh.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Refresh.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Refresh.Location = New System.Drawing.Point(267, 85)
        Me.RadButton_Refresh.Name = "RadButton_Refresh"
        Me.RadButton_Refresh.Size = New System.Drawing.Size(50, 40)
        Me.RadButton_Refresh.TabIndex = 6
        Me.RadButton_Refresh.Text = "ScratchP_Refresh"
        Me.RadButton_Refresh.TextWrap = true
        '
        'RadButton_ShowAllRecs
        '
        Me.RadButton_ShowAllRecs.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_ShowAllRecs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_ShowAllRecs.ForeColor = System.Drawing.Color.Black
        Me.RadButton_ShowAllRecs.Location = New System.Drawing.Point(370, 85)
        Me.RadButton_ShowAllRecs.Margin = New System.Windows.Forms.Padding(5)
        Me.RadButton_ShowAllRecs.Name = "RadButton_ShowAllRecs"
        Me.RadButton_ShowAllRecs.Size = New System.Drawing.Size(50, 40)
        Me.RadButton_ShowAllRecs.TabIndex = 6
        Me.RadButton_ShowAllRecs.Text = "ScratchP_ShowAllRecs"
        Me.RadButton_ShowAllRecs.TextWrap = true
        '
        'RadButton_Rename
        '
        Me.RadButton_Rename.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_Rename.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Rename.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Rename.Location = New System.Drawing.Point(61, 85)
        Me.RadButton_Rename.Name = "RadButton_Rename"
        Me.RadButton_Rename.Size = New System.Drawing.Size(50, 40)
        Me.RadButton_Rename.TabIndex = 5
        Me.RadButton_Rename.Text = "ScratchP_Rename"
        Me.RadButton_Rename.TextWrap = true
        '
        'RadButton_UpdateMain
        '
        Me.RadButton_UpdateMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_UpdateMain.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_UpdateMain.ForeColor = System.Drawing.Color.Black
        Me.RadButton_UpdateMain.Location = New System.Drawing.Point(110, 85)
        Me.RadButton_UpdateMain.Name = "RadButton_UpdateMain"
        Me.RadButton_UpdateMain.Size = New System.Drawing.Size(50, 40)
        Me.RadButton_UpdateMain.TabIndex = 5
        Me.RadButton_UpdateMain.Text = "ScratchP_UpdateMain"
        Me.RadButton_UpdateMain.TextWrap = true
        '
        'RadButton_GoToSummary
        '
        Me.RadButton_GoToSummary.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_GoToSummary.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_GoToSummary.ForeColor = System.Drawing.Color.Black
        Me.RadButton_GoToSummary.Location = New System.Drawing.Point(208, 85)
        Me.RadButton_GoToSummary.Name = "RadButton_GoToSummary"
        Me.RadButton_GoToSummary.Size = New System.Drawing.Size(60, 40)
        Me.RadButton_GoToSummary.TabIndex = 5
        Me.RadButton_GoToSummary.Text = "ScratchP_GoToSummary"
        Me.RadButton_GoToSummary.TextWrap = true
        '
        'RadButton_NewDesign
        '
        Me.RadButton_NewDesign.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_NewDesign.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_NewDesign.ForeColor = System.Drawing.Color.Black
        Me.RadButton_NewDesign.Location = New System.Drawing.Point(12, 85)
        Me.RadButton_NewDesign.Name = "RadButton_NewDesign"
        Me.RadButton_NewDesign.Size = New System.Drawing.Size(50, 40)
        Me.RadButton_NewDesign.TabIndex = 4
        Me.RadButton_NewDesign.Text = "ScratchP_NewDesign"
        Me.RadButton_NewDesign.TextWrap = true
        '
        'RadScrollablePanel_Container
        '
        Me.RadScrollablePanel_Container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadScrollablePanel_Container.Location = New System.Drawing.Point(0, 125)
        Me.RadScrollablePanel_Container.Name = "RadScrollablePanel_Container"
        '
        'RadScrollablePanel_Container.PanelContainer
        '
        Me.RadScrollablePanel_Container.PanelContainer.Controls.Add(Me.Panel_SpecificationDetails)
        Me.RadScrollablePanel_Container.PanelContainer.Controls.Add(Me.TabControl_PrintCatExtra)
        Me.RadScrollablePanel_Container.PanelContainer.Controls.Add(Me.Panel_Anode)
        Me.RadScrollablePanel_Container.PanelContainer.Controls.Add(Me.Panel_Parameters)
        Me.RadScrollablePanel_Container.PanelContainer.Controls.Add(Me.Panel_Cathode)
        Me.RadScrollablePanel_Container.PanelContainer.Controls.Add(Me.Panel_Notes)
        Me.RadScrollablePanel_Container.PanelContainer.Controls.Add(Me.Panel_TopRight)
        Me.RadScrollablePanel_Container.PanelContainer.Controls.Add(Me.Panel_Elyte)
        Me.RadScrollablePanel_Container.PanelContainer.Controls.Add(Me.Panel_Tissue)
        Me.RadScrollablePanel_Container.PanelContainer.Controls.Add(Me.Panel_Freqs)
        Me.RadScrollablePanel_Container.PanelContainer.Controls.Add(Me.Panel_Tab)
        Me.RadScrollablePanel_Container.PanelContainer.Controls.Add(Me.Panel_TissueRight)
        Me.RadScrollablePanel_Container.PanelContainer.Controls.Add(Me.TabControl_Ctl)
        Me.RadScrollablePanel_Container.PanelContainer.Controls.Add(Me.Panel_CapAndNotes)
        Me.RadScrollablePanel_Container.PanelContainer.Size = New System.Drawing.Size(973, 505)
        Me.RadScrollablePanel_Container.Size = New System.Drawing.Size(992, 507)
        Me.RadScrollablePanel_Container.TabIndex = 3
        '
        'Panel_SpecificationDetails
        '
        Me.Panel_SpecificationDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadLabel_SEVtestvoltage)
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadLabel_SurgeOrVDEvoltage)
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadTextBox_SEVtestvoltage)
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadTextBox_SurgeOrVDEvoltage)
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadLabel_CelsiusDegrees)
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadTextBox_RatedIr3)
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadLabel_RatedIr3)
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadTextBox_RatedIr2)
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadLabel_RatedIr2)
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadTextBox_Notes)
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadTextBox_RatedIr)
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadLabel_Notes)
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadLabel_RatedIr)
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadLabel_Dimensions)
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadLabel_Terminals)
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadLabel_SpecDwg)
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadLabel_Distributor)
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadLabel_CustPNo)
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadTextBox_Dimensions)
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadTextBox_Terminals)
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadTextBox_SpecDwg)
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadTextBox_Distributor)
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadTextBox_CustPNo)
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadButton_SpecificationDetails)
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadLabel_Customer)
        Me.Panel_SpecificationDetails.Controls.Add(Me.RadTextBox_Customer)
        Me.Panel_SpecificationDetails.Location = New System.Drawing.Point(424, 747)
        Me.Panel_SpecificationDetails.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Panel_SpecificationDetails.Name = "Panel_SpecificationDetails"
        Me.Panel_SpecificationDetails.Size = New System.Drawing.Size(549, 292)
        Me.Panel_SpecificationDetails.TabIndex = 20
        '
        'RadLabel_SEVtestvoltage
        '
        Me.RadLabel_SEVtestvoltage.AutoSize = false
        Me.RadLabel_SEVtestvoltage.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_SEVtestvoltage.Location = New System.Drawing.Point(360, 54)
        Me.RadLabel_SEVtestvoltage.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_SEVtestvoltage.Name = "RadLabel_SEVtestvoltage"
        Me.RadLabel_SEVtestvoltage.Size = New System.Drawing.Size(125, 20)
        Me.RadLabel_SEVtestvoltage.TabIndex = 191
        Me.RadLabel_SEVtestvoltage.Text = "ScratchP_SEVtestvoltage"
        Me.RadLabel_SEVtestvoltage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_SurgeOrVDEvoltage
        '
        Me.RadLabel_SurgeOrVDEvoltage.AutoSize = false
        Me.RadLabel_SurgeOrVDEvoltage.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_SurgeOrVDEvoltage.Location = New System.Drawing.Point(360, 32)
        Me.RadLabel_SurgeOrVDEvoltage.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_SurgeOrVDEvoltage.Name = "RadLabel_SurgeOrVDEvoltage"
        Me.RadLabel_SurgeOrVDEvoltage.Size = New System.Drawing.Size(125, 20)
        Me.RadLabel_SurgeOrVDEvoltage.TabIndex = 190
        Me.RadLabel_SurgeOrVDEvoltage.Text = "ScratchP_SurgeOrVDEvoltage"
        Me.RadLabel_SurgeOrVDEvoltage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadTextBox_SEVtestvoltage
        '
        Me.RadTextBox_SEVtestvoltage.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_SEVtestvoltage.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_SEVtestvoltage.Location = New System.Drawing.Point(486, 54)
        Me.RadTextBox_SEVtestvoltage.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_SEVtestvoltage.Name = "RadTextBox_SEVtestvoltage"
        '
        '
        '
        Me.RadTextBox_SEVtestvoltage.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_SEVtestvoltage.Size = New System.Drawing.Size(48, 20)
        Me.RadTextBox_SEVtestvoltage.TabIndex = 189
        Me.RadTextBox_SEVtestvoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_SurgeOrVDEvoltage
        '
        Me.RadTextBox_SurgeOrVDEvoltage.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_SurgeOrVDEvoltage.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_SurgeOrVDEvoltage.Location = New System.Drawing.Point(486, 32)
        Me.RadTextBox_SurgeOrVDEvoltage.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_SurgeOrVDEvoltage.Name = "RadTextBox_SurgeOrVDEvoltage"
        '
        '
        '
        Me.RadTextBox_SurgeOrVDEvoltage.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_SurgeOrVDEvoltage.Size = New System.Drawing.Size(48, 20)
        Me.RadTextBox_SurgeOrVDEvoltage.TabIndex = 188
        Me.RadTextBox_SurgeOrVDEvoltage.Text = "495"
        Me.RadTextBox_SurgeOrVDEvoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_CelsiusDegrees
        '
        Me.RadLabel_CelsiusDegrees.AutoSize = false
        Me.RadLabel_CelsiusDegrees.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_CelsiusDegrees.Location = New System.Drawing.Point(302, 164)
        Me.RadLabel_CelsiusDegrees.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_CelsiusDegrees.Name = "RadLabel_CelsiusDegrees"
        Me.RadLabel_CelsiusDegrees.Size = New System.Drawing.Size(35, 20)
        Me.RadLabel_CelsiusDegrees.TabIndex = 187
        Me.RadLabel_CelsiusDegrees.Text = "Global_CelsiusDegrees"
        Me.RadLabel_CelsiusDegrees.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadTextBox_RatedIr3
        '
        Me.RadTextBox_RatedIr3.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_RatedIr3.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_RatedIr3.Location = New System.Drawing.Point(261, 164)
        Me.RadTextBox_RatedIr3.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_RatedIr3.Name = "RadTextBox_RatedIr3"
        '
        '
        '
        Me.RadTextBox_RatedIr3.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_RatedIr3.Size = New System.Drawing.Size(40, 20)
        Me.RadTextBox_RatedIr3.TabIndex = 186
        Me.RadTextBox_RatedIr3.Text = "85"
        Me.RadTextBox_RatedIr3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_RatedIr3
        '
        Me.RadLabel_RatedIr3.AutoSize = false
        Me.RadLabel_RatedIr3.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_RatedIr3.Location = New System.Drawing.Point(226, 164)
        Me.RadLabel_RatedIr3.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_RatedIr3.Name = "RadLabel_RatedIr3"
        Me.RadLabel_RatedIr3.Size = New System.Drawing.Size(35, 20)
        Me.RadLabel_RatedIr3.TabIndex = 185
        Me.RadLabel_RatedIr3.Text = "ScratchP_HzAt"
        Me.RadLabel_RatedIr3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadTextBox_RatedIr2
        '
        Me.RadTextBox_RatedIr2.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_RatedIr2.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_RatedIr2.Location = New System.Drawing.Point(169, 164)
        Me.RadTextBox_RatedIr2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_RatedIr2.Name = "RadTextBox_RatedIr2"
        '
        '
        '
        Me.RadTextBox_RatedIr2.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_RatedIr2.Size = New System.Drawing.Size(56, 20)
        Me.RadTextBox_RatedIr2.TabIndex = 184
        Me.RadTextBox_RatedIr2.Text = "100"
        Me.RadTextBox_RatedIr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_RatedIr2
        '
        Me.RadLabel_RatedIr2.AutoSize = false
        Me.RadLabel_RatedIr2.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_RatedIr2.Location = New System.Drawing.Point(138, 164)
        Me.RadLabel_RatedIr2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_RatedIr2.Name = "RadLabel_RatedIr2"
        Me.RadLabel_RatedIr2.Size = New System.Drawing.Size(30, 20)
        Me.RadLabel_RatedIr2.TabIndex = 183
        Me.RadLabel_RatedIr2.Text = "ScratchP_AAt"
        Me.RadLabel_RatedIr2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadTextBox_Notes
        '
        Me.RadTextBox_Notes.AutoSize = false
        Me.RadTextBox_Notes.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Notes.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Notes.Location = New System.Drawing.Point(89, 190)
        Me.RadTextBox_Notes.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_Notes.Multiline = true
        Me.RadTextBox_Notes.Name = "RadTextBox_Notes"
        '
        '
        '
        Me.RadTextBox_Notes.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Notes.Size = New System.Drawing.Size(445, 98)
        Me.RadTextBox_Notes.TabIndex = 182
        '
        'RadTextBox_RatedIr
        '
        Me.RadTextBox_RatedIr.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_RatedIr.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_RatedIr.Location = New System.Drawing.Point(89, 164)
        Me.RadTextBox_RatedIr.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_RatedIr.Name = "RadTextBox_RatedIr"
        '
        '
        '
        Me.RadTextBox_RatedIr.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_RatedIr.Size = New System.Drawing.Size(48, 20)
        Me.RadTextBox_RatedIr.TabIndex = 181
        Me.RadTextBox_RatedIr.Text = "3,1"
        Me.RadTextBox_RatedIr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_Notes
        '
        Me.RadLabel_Notes.AutoSize = false
        Me.RadLabel_Notes.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Notes.Location = New System.Drawing.Point(6, 190)
        Me.RadLabel_Notes.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Notes.Name = "RadLabel_Notes"
        Me.RadLabel_Notes.Size = New System.Drawing.Size(80, 20)
        Me.RadLabel_Notes.TabIndex = 180
        Me.RadLabel_Notes.Text = "Global_Notes"
        Me.RadLabel_Notes.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_RatedIr
        '
        Me.RadLabel_RatedIr.AutoSize = false
        Me.RadLabel_RatedIr.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_RatedIr.Location = New System.Drawing.Point(6, 164)
        Me.RadLabel_RatedIr.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_RatedIr.Name = "RadLabel_RatedIr"
        Me.RadLabel_RatedIr.Size = New System.Drawing.Size(80, 20)
        Me.RadLabel_RatedIr.TabIndex = 179
        Me.RadLabel_RatedIr.Text = "ScratchP_RatedIr"
        Me.RadLabel_RatedIr.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_Dimensions
        '
        Me.RadLabel_Dimensions.AutoSize = false
        Me.RadLabel_Dimensions.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Dimensions.Location = New System.Drawing.Point(6, 142)
        Me.RadLabel_Dimensions.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Dimensions.Name = "RadLabel_Dimensions"
        Me.RadLabel_Dimensions.Size = New System.Drawing.Size(80, 20)
        Me.RadLabel_Dimensions.TabIndex = 178
        Me.RadLabel_Dimensions.Text = "Global_Dimensions"
        Me.RadLabel_Dimensions.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_Terminals
        '
        Me.RadLabel_Terminals.AutoSize = false
        Me.RadLabel_Terminals.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Terminals.Location = New System.Drawing.Point(6, 120)
        Me.RadLabel_Terminals.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Terminals.Name = "RadLabel_Terminals"
        Me.RadLabel_Terminals.Size = New System.Drawing.Size(80, 20)
        Me.RadLabel_Terminals.TabIndex = 177
        Me.RadLabel_Terminals.Text = "Global_Terminals"
        Me.RadLabel_Terminals.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_SpecDwg
        '
        Me.RadLabel_SpecDwg.AutoSize = false
        Me.RadLabel_SpecDwg.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_SpecDwg.Location = New System.Drawing.Point(6, 98)
        Me.RadLabel_SpecDwg.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_SpecDwg.Name = "RadLabel_SpecDwg"
        Me.RadLabel_SpecDwg.Size = New System.Drawing.Size(80, 20)
        Me.RadLabel_SpecDwg.TabIndex = 176
        Me.RadLabel_SpecDwg.Text = "ScratchP_SpecDwg"
        Me.RadLabel_SpecDwg.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_Distributor
        '
        Me.RadLabel_Distributor.AutoSize = false
        Me.RadLabel_Distributor.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Distributor.Location = New System.Drawing.Point(6, 76)
        Me.RadLabel_Distributor.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Distributor.Name = "RadLabel_Distributor"
        Me.RadLabel_Distributor.Size = New System.Drawing.Size(80, 20)
        Me.RadLabel_Distributor.TabIndex = 175
        Me.RadLabel_Distributor.Text = "Global_Distributor"
        Me.RadLabel_Distributor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_CustPNo
        '
        Me.RadLabel_CustPNo.AutoSize = false
        Me.RadLabel_CustPNo.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_CustPNo.Location = New System.Drawing.Point(6, 54)
        Me.RadLabel_CustPNo.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_CustPNo.Name = "RadLabel_CustPNo"
        Me.RadLabel_CustPNo.Size = New System.Drawing.Size(80, 20)
        Me.RadLabel_CustPNo.TabIndex = 174
        Me.RadLabel_CustPNo.Text = "ScratchP_CustPNo"
        Me.RadLabel_CustPNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadTextBox_Dimensions
        '
        Me.RadTextBox_Dimensions.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_Dimensions.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Dimensions.Location = New System.Drawing.Point(89, 142)
        Me.RadTextBox_Dimensions.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_Dimensions.Name = "RadTextBox_Dimensions"
        '
        '
        '
        Me.RadTextBox_Dimensions.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Dimensions.Size = New System.Drawing.Size(230, 20)
        Me.RadTextBox_Dimensions.TabIndex = 173
        '
        'RadTextBox_Terminals
        '
        Me.RadTextBox_Terminals.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_Terminals.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Terminals.Location = New System.Drawing.Point(89, 120)
        Me.RadTextBox_Terminals.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_Terminals.Name = "RadTextBox_Terminals"
        '
        '
        '
        Me.RadTextBox_Terminals.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Terminals.Size = New System.Drawing.Size(230, 20)
        Me.RadTextBox_Terminals.TabIndex = 172
        Me.RadTextBox_Terminals.Text = "2 pin snap-in"
        '
        'RadTextBox_SpecDwg
        '
        Me.RadTextBox_SpecDwg.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_SpecDwg.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_SpecDwg.Location = New System.Drawing.Point(89, 98)
        Me.RadTextBox_SpecDwg.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_SpecDwg.Name = "RadTextBox_SpecDwg"
        '
        '
        '
        Me.RadTextBox_SpecDwg.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_SpecDwg.Size = New System.Drawing.Size(230, 20)
        Me.RadTextBox_SpecDwg.TabIndex = 171
        '
        'RadTextBox_Distributor
        '
        Me.RadTextBox_Distributor.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_Distributor.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Distributor.Location = New System.Drawing.Point(89, 76)
        Me.RadTextBox_Distributor.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_Distributor.Name = "RadTextBox_Distributor"
        '
        '
        '
        Me.RadTextBox_Distributor.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Distributor.Size = New System.Drawing.Size(230, 20)
        Me.RadTextBox_Distributor.TabIndex = 170
        '
        'RadTextBox_CustPNo
        '
        Me.RadTextBox_CustPNo.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_CustPNo.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_CustPNo.Location = New System.Drawing.Point(89, 54)
        Me.RadTextBox_CustPNo.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_CustPNo.Name = "RadTextBox_CustPNo"
        '
        '
        '
        Me.RadTextBox_CustPNo.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_CustPNo.Size = New System.Drawing.Size(230, 20)
        Me.RadTextBox_CustPNo.TabIndex = 169
        '
        'RadButton_SpecificationDetails
        '
        Me.RadButton_SpecificationDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_SpecificationDetails.Enabled = false
        Me.RadButton_SpecificationDetails.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_SpecificationDetails.ForeColor = System.Drawing.Color.Black
        Me.RadButton_SpecificationDetails.Location = New System.Drawing.Point(5, 5)
        Me.RadButton_SpecificationDetails.Name = "RadButton_SpecificationDetails"
        Me.RadButton_SpecificationDetails.Size = New System.Drawing.Size(125, 20)
        Me.RadButton_SpecificationDetails.TabIndex = 168
        Me.RadButton_SpecificationDetails.Text = "ScratchP_SpecificationDetails"
        Me.RadButton_SpecificationDetails.TextWrap = true
        '
        'RadLabel_Customer
        '
        Me.RadLabel_Customer.AutoSize = false
        Me.RadLabel_Customer.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Customer.Location = New System.Drawing.Point(6, 32)
        Me.RadLabel_Customer.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Customer.Name = "RadLabel_Customer"
        Me.RadLabel_Customer.Size = New System.Drawing.Size(80, 20)
        Me.RadLabel_Customer.TabIndex = 167
        Me.RadLabel_Customer.Text = "Global_Customer"
        Me.RadLabel_Customer.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadTextBox_Customer
        '
        Me.RadTextBox_Customer.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_Customer.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Customer.Location = New System.Drawing.Point(89, 32)
        Me.RadTextBox_Customer.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_Customer.Name = "RadTextBox_Customer"
        '
        '
        '
        Me.RadTextBox_Customer.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Customer.Size = New System.Drawing.Size(230, 20)
        Me.RadTextBox_Customer.TabIndex = 166
        Me.RadTextBox_Customer.Text = "Sicon"
        '
        'TabControl_PrintCatExtra
        '
        Me.TabControl_PrintCatExtra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TabControl_PrintCatExtra.Controls.Add(Me.ScratchP_PrintDetail)
        Me.TabControl_PrintCatExtra.Controls.Add(Me.ScratchP_CatData)
        Me.TabControl_PrintCatExtra.Controls.Add(Me.ScratchP_ExtraFields)
        Me.TabControl_PrintCatExtra.Location = New System.Drawing.Point(2, 519)
        Me.TabControl_PrintCatExtra.Name = "TabControl_PrintCatExtra"
        Me.TabControl_PrintCatExtra.SelectedIndex = 0
        Me.TabControl_PrintCatExtra.Size = New System.Drawing.Size(548, 224)
        Me.TabControl_PrintCatExtra.TabIndex = 19
        '
        'ScratchP_PrintDetail
        '
        Me.ScratchP_PrintDetail.BackColor = System.Drawing.Color.Silver
        Me.ScratchP_PrintDetail.Controls.Add(Me.RadGroupBox_PrintDetail)
        Me.ScratchP_PrintDetail.Location = New System.Drawing.Point(4, 22)
        Me.ScratchP_PrintDetail.Name = "ScratchP_PrintDetail"
        Me.ScratchP_PrintDetail.Padding = New System.Windows.Forms.Padding(3)
        Me.ScratchP_PrintDetail.Size = New System.Drawing.Size(540, 198)
        Me.ScratchP_PrintDetail.TabIndex = 0
        Me.ScratchP_PrintDetail.Text = "ScratchP_PrintDetail"
        '
        'RadGroupBox_PrintDetail
        '
        Me.RadGroupBox_PrintDetail.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox_PrintDetail.Controls.Add(Me.RadTextBox_PartsCost)
        Me.RadGroupBox_PrintDetail.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox_PrintDetail.Controls.Add(Me.RadTextBox_MelCostRaw)
        Me.RadGroupBox_PrintDetail.Controls.Add(Me.RadTextBox_MelTCost)
        Me.RadGroupBox_PrintDetail.Controls.Add(Me.RadTextBox_MelQty)
        Me.RadGroupBox_PrintDetail.Controls.Add(Me.RadTextBox_MelinexCost)
        Me.RadGroupBox_PrintDetail.Controls.Add(Me.RadDropDownList_PrintDrawing)
        Me.RadGroupBox_PrintDetail.Controls.Add(Me.RadLabel_PrintDrawing)
        Me.RadGroupBox_PrintDetail.Controls.Add(Me.RadButton_ViewCentred)
        Me.RadGroupBox_PrintDetail.Controls.Add(Me.RadLabel_PrintDetailMax13Lines)
        Me.RadGroupBox_PrintDetail.Controls.Add(Me.RadTextBox_PrintNotes)
        Me.RadGroupBox_PrintDetail.HeaderText = ""
        Me.RadGroupBox_PrintDetail.Location = New System.Drawing.Point(14, 15)
        Me.RadGroupBox_PrintDetail.Name = "RadGroupBox_PrintDetail"
        Me.RadGroupBox_PrintDetail.Size = New System.Drawing.Size(510, 168)
        Me.RadGroupBox_PrintDetail.TabIndex = 0
        '
        'RadTextBox_PartsCost
        '
        Me.RadTextBox_PartsCost.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_PartsCost.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_PartsCost.Location = New System.Drawing.Point(96, 135)
        Me.RadTextBox_PartsCost.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_PartsCost.Name = "RadTextBox_PartsCost"
        '
        '
        '
        Me.RadTextBox_PartsCost.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_PartsCost.Size = New System.Drawing.Size(40, 20)
        Me.RadTextBox_PartsCost.TabIndex = 177
        Me.RadTextBox_PartsCost.Text = "0"
        Me.RadTextBox_PartsCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_PartsCost.Visible = false
        '
        'RadLabel1
        '
        Me.RadLabel1.AutoSize = false
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel1.Location = New System.Drawing.Point(37, 135)
        Me.RadLabel1.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(59, 22)
        Me.RadLabel1.TabIndex = 176
        Me.RadLabel1.Text = "Text567:"
        Me.RadLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel1.Visible = false
        '
        'RadTextBox_MelCostRaw
        '
        Me.RadTextBox_MelCostRaw.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_MelCostRaw.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_MelCostRaw.Location = New System.Drawing.Point(139, 114)
        Me.RadTextBox_MelCostRaw.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_MelCostRaw.Name = "RadTextBox_MelCostRaw"
        '
        '
        '
        Me.RadTextBox_MelCostRaw.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_MelCostRaw.Size = New System.Drawing.Size(31, 20)
        Me.RadTextBox_MelCostRaw.TabIndex = 175
        Me.RadTextBox_MelCostRaw.Text = "0"
        Me.RadTextBox_MelCostRaw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_MelCostRaw.Visible = false
        '
        'RadTextBox_MelTCost
        '
        Me.RadTextBox_MelTCost.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_MelTCost.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_MelTCost.Location = New System.Drawing.Point(108, 114)
        Me.RadTextBox_MelTCost.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_MelTCost.Name = "RadTextBox_MelTCost"
        '
        '
        '
        Me.RadTextBox_MelTCost.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_MelTCost.Size = New System.Drawing.Size(31, 20)
        Me.RadTextBox_MelTCost.TabIndex = 174
        Me.RadTextBox_MelTCost.Text = "0"
        Me.RadTextBox_MelTCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_MelTCost.Visible = false
        '
        'RadTextBox_MelQty
        '
        Me.RadTextBox_MelQty.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_MelQty.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_MelQty.Location = New System.Drawing.Point(76, 114)
        Me.RadTextBox_MelQty.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_MelQty.Name = "RadTextBox_MelQty"
        '
        '
        '
        Me.RadTextBox_MelQty.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_MelQty.Size = New System.Drawing.Size(20, 20)
        Me.RadTextBox_MelQty.TabIndex = 173
        Me.RadTextBox_MelQty.Text = "0"
        Me.RadTextBox_MelQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_MelQty.Visible = false
        '
        'RadTextBox_MelinexCost
        '
        Me.RadTextBox_MelinexCost.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_MelinexCost.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_MelinexCost.Location = New System.Drawing.Point(37, 114)
        Me.RadTextBox_MelinexCost.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_MelinexCost.Name = "RadTextBox_MelinexCost"
        '
        '
        '
        Me.RadTextBox_MelinexCost.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_MelinexCost.Size = New System.Drawing.Size(40, 20)
        Me.RadTextBox_MelinexCost.TabIndex = 172
        Me.RadTextBox_MelinexCost.Text = "0"
        Me.RadTextBox_MelinexCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_MelinexCost.Visible = false
        '
        'RadDropDownList_PrintDrawing
        '
        Me.RadDropDownList_PrintDrawing.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_PrintDrawing.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_PrintDrawing.Location = New System.Drawing.Point(37, 93)
        Me.RadDropDownList_PrintDrawing.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_PrintDrawing.Name = "RadDropDownList_PrintDrawing"
        '
        '
        '
        Me.RadDropDownList_PrintDrawing.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_PrintDrawing.Size = New System.Drawing.Size(111, 20)
        Me.RadDropDownList_PrintDrawing.TabIndex = 152
        Me.RadDropDownList_PrintDrawing.Text = "P019"
        '
        'RadLabel_PrintDrawing
        '
        Me.RadLabel_PrintDrawing.AutoSize = false
        Me.RadLabel_PrintDrawing.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_PrintDrawing.Location = New System.Drawing.Point(37, 70)
        Me.RadLabel_PrintDrawing.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_PrintDrawing.Name = "RadLabel_PrintDrawing"
        Me.RadLabel_PrintDrawing.Size = New System.Drawing.Size(111, 22)
        Me.RadLabel_PrintDrawing.TabIndex = 151
        Me.RadLabel_PrintDrawing.Text = "ScratchP_PrintDrawing"
        Me.RadLabel_PrintDrawing.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadButton_ViewCentred
        '
        Me.RadButton_ViewCentred.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_ViewCentred.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_ViewCentred.ForeColor = System.Drawing.Color.Black
        Me.RadButton_ViewCentred.Location = New System.Drawing.Point(37, 36)
        Me.RadButton_ViewCentred.Name = "RadButton_ViewCentred"
        Me.RadButton_ViewCentred.Size = New System.Drawing.Size(96, 20)
        Me.RadButton_ViewCentred.TabIndex = 150
        Me.RadButton_ViewCentred.Text = "ScratchP_ViewCentred"
        Me.RadButton_ViewCentred.TextWrap = true
        '
        'RadLabel_PrintDetailMax13Lines
        '
        Me.RadLabel_PrintDetailMax13Lines.AutoSize = false
        Me.RadLabel_PrintDetailMax13Lines.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_PrintDetailMax13Lines.Location = New System.Drawing.Point(19, 11)
        Me.RadLabel_PrintDetailMax13Lines.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_PrintDetailMax13Lines.Name = "RadLabel_PrintDetailMax13Lines"
        Me.RadLabel_PrintDetailMax13Lines.Size = New System.Drawing.Size(157, 22)
        Me.RadLabel_PrintDetailMax13Lines.TabIndex = 143
        Me.RadLabel_PrintDetailMax13Lines.Text = "ScratchP_PrintDetailMax13Lines"
        Me.RadLabel_PrintDetailMax13Lines.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadTextBox_PrintNotes
        '
        Me.RadTextBox_PrintNotes.AutoSize = false
        Me.RadTextBox_PrintNotes.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_PrintNotes.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_PrintNotes.Location = New System.Drawing.Point(204, 11)
        Me.RadTextBox_PrintNotes.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_PrintNotes.Multiline = true
        Me.RadTextBox_PrintNotes.Name = "RadTextBox_PrintNotes"
        '
        '
        '
        Me.RadTextBox_PrintNotes.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_PrintNotes.Size = New System.Drawing.Size(285, 146)
        Me.RadTextBox_PrintNotes.TabIndex = 109
        '
        'ScratchP_CatData
        '
        Me.ScratchP_CatData.BackColor = System.Drawing.Color.Silver
        Me.ScratchP_CatData.Controls.Add(Me.Panel_CatalogueData)
        Me.ScratchP_CatData.Controls.Add(Me.RadButton_ViewAllCatData)
        Me.ScratchP_CatData.Controls.Add(Me.RadGridView2)
        Me.ScratchP_CatData.Location = New System.Drawing.Point(4, 22)
        Me.ScratchP_CatData.Name = "ScratchP_CatData"
        Me.ScratchP_CatData.Size = New System.Drawing.Size(540, 198)
        Me.ScratchP_CatData.TabIndex = 1
        Me.ScratchP_CatData.Text = "ScratchP_CatData"
        '
        'Panel_CatalogueData
        '
        Me.Panel_CatalogueData.BackColor = System.Drawing.Color.White
        Me.Panel_CatalogueData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_CatalogueData.Controls.Add(Me.RadTextBox_condy_eq)
        Me.Panel_CatalogueData.Controls.Add(Me.RadLabel_IrT)
        Me.Panel_CatalogueData.Controls.Add(Me.RadLabel_IrF)
        Me.Panel_CatalogueData.Controls.Add(Me.RadLabel_Rise_T)
        Me.Panel_CatalogueData.Controls.Add(Me.RadLabel_Rbo)
        Me.Panel_CatalogueData.Controls.Add(Me.RadLabel_Rwb)
        Me.Panel_CatalogueData.Controls.Add(Me.RadTextBox_IrT)
        Me.Panel_CatalogueData.Controls.Add(Me.RadTextBox_IrF)
        Me.Panel_CatalogueData.Controls.Add(Me.RadTextBox_Rise_T)
        Me.Panel_CatalogueData.Controls.Add(Me.RadTextBox_Rbo)
        Me.Panel_CatalogueData.Controls.Add(Me.RadTextBox_Rwb)
        Me.Panel_CatalogueData.Controls.Add(Me.RadLabel_Rhw)
        Me.Panel_CatalogueData.Controls.Add(Me.RadLabel_Ir)
        Me.Panel_CatalogueData.Controls.Add(Me.RadLabel_Rha)
        Me.Panel_CatalogueData.Controls.Add(Me.RadLabel_condy_eq)
        Me.Panel_CatalogueData.Controls.Add(Me.RadLabel_oxide_fi)
        Me.Panel_CatalogueData.Controls.Add(Me.RadLabel_tissue_ti)
        Me.Panel_CatalogueData.Controls.Add(Me.RadLabel_tabbing)
        Me.Panel_CatalogueData.Controls.Add(Me.RadLabel_foil)
        Me.Panel_CatalogueData.Controls.Add(Me.RadTextBox_Ir)
        Me.Panel_CatalogueData.Controls.Add(Me.RadTextBox_Rha)
        Me.Panel_CatalogueData.Controls.Add(Me.RadTextBox_oxide_fi)
        Me.Panel_CatalogueData.Controls.Add(Me.RadTextBox_tissue_ti)
        Me.Panel_CatalogueData.Controls.Add(Me.RadTextBox_tabbing)
        Me.Panel_CatalogueData.Controls.Add(Me.RadTextBox_Rhw)
        Me.Panel_CatalogueData.Controls.Add(Me.RadTextBox_foil)
        Me.Panel_CatalogueData.Controls.Add(Me.Panel_CatalogueDataTitle)
        Me.Panel_CatalogueData.Location = New System.Drawing.Point(8, 9)
        Me.Panel_CatalogueData.Name = "Panel_CatalogueData"
        Me.Panel_CatalogueData.Size = New System.Drawing.Size(263, 180)
        Me.Panel_CatalogueData.TabIndex = 153
        '
        'RadTextBox_condy_eq
        '
        Me.RadTextBox_condy_eq.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_condy_eq.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_condy_eq.Location = New System.Drawing.Point(64, 108)
        Me.RadTextBox_condy_eq.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_condy_eq.Name = "RadTextBox_condy_eq"
        '
        '
        '
        Me.RadTextBox_condy_eq.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_condy_eq.Size = New System.Drawing.Size(170, 20)
        Me.RadTextBox_condy_eq.TabIndex = 113
        Me.RadTextBox_condy_eq.Text = ".02*(x^2)+2*x+7"
        '
        'RadLabel_IrT
        '
        Me.RadLabel_IrT.AutoSize = false
        Me.RadLabel_IrT.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_IrT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RadLabel_IrT.Location = New System.Drawing.Point(131, 146)
        Me.RadLabel_IrT.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_IrT.Name = "RadLabel_IrT"
        Me.RadLabel_IrT.Size = New System.Drawing.Size(40, 20)
        Me.RadLabel_IrT.TabIndex = 132
        Me.RadLabel_IrT.Text = "ScratchP_IrT"
        Me.RadLabel_IrT.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_IrF
        '
        Me.RadLabel_IrF.AutoSize = false
        Me.RadLabel_IrF.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_IrF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RadLabel_IrF.Location = New System.Drawing.Point(131, 127)
        Me.RadLabel_IrF.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_IrF.Name = "RadLabel_IrF"
        Me.RadLabel_IrF.Size = New System.Drawing.Size(40, 20)
        Me.RadLabel_IrF.TabIndex = 131
        Me.RadLabel_IrF.Text = "ScratchP_IrF"
        Me.RadLabel_IrF.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_Rise_T
        '
        Me.RadLabel_Rise_T.AutoSize = false
        Me.RadLabel_Rise_T.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_Rise_T.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RadLabel_Rise_T.Location = New System.Drawing.Point(131, 89)
        Me.RadLabel_Rise_T.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Rise_T.Name = "RadLabel_Rise_T"
        Me.RadLabel_Rise_T.Size = New System.Drawing.Size(40, 19)
        Me.RadLabel_Rise_T.TabIndex = 130
        Me.RadLabel_Rise_T.Text = "ScratchP_Rise_T"
        Me.RadLabel_Rise_T.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_Rbo
        '
        Me.RadLabel_Rbo.AutoSize = false
        Me.RadLabel_Rbo.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_Rbo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RadLabel_Rbo.Location = New System.Drawing.Point(131, 70)
        Me.RadLabel_Rbo.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Rbo.Name = "RadLabel_Rbo"
        Me.RadLabel_Rbo.Size = New System.Drawing.Size(40, 20)
        Me.RadLabel_Rbo.TabIndex = 129
        Me.RadLabel_Rbo.Text = "ScratchP_Rbo"
        Me.RadLabel_Rbo.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_Rwb
        '
        Me.RadLabel_Rwb.AutoSize = false
        Me.RadLabel_Rwb.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_Rwb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RadLabel_Rwb.Location = New System.Drawing.Point(131, 51)
        Me.RadLabel_Rwb.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Rwb.Name = "RadLabel_Rwb"
        Me.RadLabel_Rwb.Size = New System.Drawing.Size(40, 20)
        Me.RadLabel_Rwb.TabIndex = 127
        Me.RadLabel_Rwb.Text = "ScratchP_Rwb"
        Me.RadLabel_Rwb.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_IrT
        '
        Me.RadTextBox_IrT.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_IrT.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_IrT.Location = New System.Drawing.Point(174, 146)
        Me.RadTextBox_IrT.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_IrT.Name = "RadTextBox_IrT"
        '
        '
        '
        Me.RadTextBox_IrT.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_IrT.Size = New System.Drawing.Size(60, 20)
        Me.RadTextBox_IrT.TabIndex = 128
        '
        'RadTextBox_IrF
        '
        Me.RadTextBox_IrF.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_IrF.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_IrF.Location = New System.Drawing.Point(174, 127)
        Me.RadTextBox_IrF.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_IrF.Name = "RadTextBox_IrF"
        '
        '
        '
        Me.RadTextBox_IrF.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_IrF.Size = New System.Drawing.Size(60, 20)
        Me.RadTextBox_IrF.TabIndex = 127
        '
        'RadTextBox_Rise_T
        '
        Me.RadTextBox_Rise_T.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Rise_T.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Rise_T.Location = New System.Drawing.Point(174, 89)
        Me.RadTextBox_Rise_T.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_Rise_T.Name = "RadTextBox_Rise_T"
        '
        '
        '
        Me.RadTextBox_Rise_T.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Rise_T.Size = New System.Drawing.Size(60, 20)
        Me.RadTextBox_Rise_T.TabIndex = 114
        Me.RadTextBox_Rise_T.Text = "5,00"
        '
        'RadTextBox_Rbo
        '
        Me.RadTextBox_Rbo.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Rbo.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Rbo.Location = New System.Drawing.Point(174, 70)
        Me.RadTextBox_Rbo.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_Rbo.Name = "RadTextBox_Rbo"
        '
        '
        '
        Me.RadTextBox_Rbo.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Rbo.Size = New System.Drawing.Size(60, 20)
        Me.RadTextBox_Rbo.TabIndex = 114
        Me.RadTextBox_Rbo.Text = "0,05"
        '
        'RadTextBox_Rwb
        '
        Me.RadTextBox_Rwb.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Rwb.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Rwb.Location = New System.Drawing.Point(174, 51)
        Me.RadTextBox_Rwb.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_Rwb.Name = "RadTextBox_Rwb"
        '
        '
        '
        Me.RadTextBox_Rwb.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Rwb.Size = New System.Drawing.Size(60, 20)
        Me.RadTextBox_Rwb.TabIndex = 114
        Me.RadTextBox_Rwb.Text = "40,74"
        '
        'RadLabel_Rhw
        '
        Me.RadLabel_Rhw.AutoSize = false
        Me.RadLabel_Rhw.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_Rhw.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RadLabel_Rhw.Location = New System.Drawing.Point(131, 32)
        Me.RadLabel_Rhw.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Rhw.Name = "RadLabel_Rhw"
        Me.RadLabel_Rhw.Size = New System.Drawing.Size(40, 20)
        Me.RadLabel_Rhw.TabIndex = 126
        Me.RadLabel_Rhw.Text = "ScratchP_Rhw"
        Me.RadLabel_Rhw.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_Ir
        '
        Me.RadLabel_Ir.AutoSize = false
        Me.RadLabel_Ir.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_Ir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RadLabel_Ir.Location = New System.Drawing.Point(3, 146)
        Me.RadLabel_Ir.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Ir.Name = "RadLabel_Ir"
        Me.RadLabel_Ir.Size = New System.Drawing.Size(60, 20)
        Me.RadLabel_Ir.TabIndex = 125
        Me.RadLabel_Ir.Text = "ScratchP_Ir"
        Me.RadLabel_Ir.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_Rha
        '
        Me.RadLabel_Rha.AutoSize = false
        Me.RadLabel_Rha.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_Rha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RadLabel_Rha.Location = New System.Drawing.Point(3, 127)
        Me.RadLabel_Rha.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Rha.Name = "RadLabel_Rha"
        Me.RadLabel_Rha.Size = New System.Drawing.Size(60, 20)
        Me.RadLabel_Rha.TabIndex = 124
        Me.RadLabel_Rha.Text = "ScratchP_Rha"
        Me.RadLabel_Rha.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_condy_eq
        '
        Me.RadLabel_condy_eq.AutoSize = false
        Me.RadLabel_condy_eq.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_condy_eq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RadLabel_condy_eq.Location = New System.Drawing.Point(3, 108)
        Me.RadLabel_condy_eq.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_condy_eq.Name = "RadLabel_condy_eq"
        Me.RadLabel_condy_eq.Size = New System.Drawing.Size(60, 20)
        Me.RadLabel_condy_eq.TabIndex = 123
        Me.RadLabel_condy_eq.Text = "ScratchP_condy_eq"
        Me.RadLabel_condy_eq.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_oxide_fi
        '
        Me.RadLabel_oxide_fi.AutoSize = false
        Me.RadLabel_oxide_fi.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_oxide_fi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RadLabel_oxide_fi.Location = New System.Drawing.Point(3, 89)
        Me.RadLabel_oxide_fi.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_oxide_fi.Name = "RadLabel_oxide_fi"
        Me.RadLabel_oxide_fi.Size = New System.Drawing.Size(60, 20)
        Me.RadLabel_oxide_fi.TabIndex = 122
        Me.RadLabel_oxide_fi.Text = "ScratchP_oxide_fi"
        Me.RadLabel_oxide_fi.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_tissue_ti
        '
        Me.RadLabel_tissue_ti.AutoSize = false
        Me.RadLabel_tissue_ti.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_tissue_ti.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RadLabel_tissue_ti.Location = New System.Drawing.Point(3, 70)
        Me.RadLabel_tissue_ti.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_tissue_ti.Name = "RadLabel_tissue_ti"
        Me.RadLabel_tissue_ti.Size = New System.Drawing.Size(60, 20)
        Me.RadLabel_tissue_ti.TabIndex = 121
        Me.RadLabel_tissue_ti.Text = "ScratchP_tissue_ti"
        Me.RadLabel_tissue_ti.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_tabbing
        '
        Me.RadLabel_tabbing.AutoSize = false
        Me.RadLabel_tabbing.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_tabbing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RadLabel_tabbing.Location = New System.Drawing.Point(3, 51)
        Me.RadLabel_tabbing.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_tabbing.Name = "RadLabel_tabbing"
        Me.RadLabel_tabbing.Size = New System.Drawing.Size(60, 20)
        Me.RadLabel_tabbing.TabIndex = 121
        Me.RadLabel_tabbing.Text = "ScratchP_tabbing"
        Me.RadLabel_tabbing.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_foil
        '
        Me.RadLabel_foil.AutoSize = false
        Me.RadLabel_foil.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_foil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RadLabel_foil.Location = New System.Drawing.Point(3, 32)
        Me.RadLabel_foil.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_foil.Name = "RadLabel_foil"
        Me.RadLabel_foil.Size = New System.Drawing.Size(60, 20)
        Me.RadLabel_foil.TabIndex = 120
        Me.RadLabel_foil.Text = "ScratchP_foil"
        Me.RadLabel_foil.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_Ir
        '
        Me.RadTextBox_Ir.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Ir.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Ir.Location = New System.Drawing.Point(64, 146)
        Me.RadTextBox_Ir.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_Ir.Name = "RadTextBox_Ir"
        '
        '
        '
        Me.RadTextBox_Ir.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Ir.Size = New System.Drawing.Size(66, 20)
        Me.RadTextBox_Ir.TabIndex = 113
        '
        'RadTextBox_Rha
        '
        Me.RadTextBox_Rha.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Rha.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Rha.Location = New System.Drawing.Point(64, 127)
        Me.RadTextBox_Rha.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_Rha.Name = "RadTextBox_Rha"
        '
        '
        '
        Me.RadTextBox_Rha.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Rha.Size = New System.Drawing.Size(66, 20)
        Me.RadTextBox_Rha.TabIndex = 113
        '
        'RadTextBox_oxide_fi
        '
        Me.RadTextBox_oxide_fi.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_oxide_fi.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_oxide_fi.Location = New System.Drawing.Point(64, 89)
        Me.RadTextBox_oxide_fi.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_oxide_fi.Name = "RadTextBox_oxide_fi"
        '
        '
        '
        Me.RadTextBox_oxide_fi.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_oxide_fi.Size = New System.Drawing.Size(66, 20)
        Me.RadTextBox_oxide_fi.TabIndex = 113
        Me.RadTextBox_oxide_fi.Text = "4025,00"
        '
        'RadTextBox_tissue_ti
        '
        Me.RadTextBox_tissue_ti.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_tissue_ti.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_tissue_ti.Location = New System.Drawing.Point(64, 70)
        Me.RadTextBox_tissue_ti.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_tissue_ti.Name = "RadTextBox_tissue_ti"
        '
        '
        '
        Me.RadTextBox_tissue_ti.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_tissue_ti.Size = New System.Drawing.Size(66, 20)
        Me.RadTextBox_tissue_ti.TabIndex = 113
        Me.RadTextBox_tissue_ti.Text = "0,2756727"
        '
        'RadTextBox_tabbing
        '
        Me.RadTextBox_tabbing.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_tabbing.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_tabbing.Location = New System.Drawing.Point(64, 51)
        Me.RadTextBox_tabbing.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_tabbing.Name = "RadTextBox_tabbing"
        '
        '
        '
        Me.RadTextBox_tabbing.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_tabbing.Size = New System.Drawing.Size(66, 20)
        Me.RadTextBox_tabbing.TabIndex = 113
        Me.RadTextBox_tabbing.Text = "1,47"
        '
        'RadTextBox_Rhw
        '
        Me.RadTextBox_Rhw.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Rhw.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Rhw.Location = New System.Drawing.Point(174, 32)
        Me.RadTextBox_Rhw.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_Rhw.Name = "RadTextBox_Rhw"
        '
        '
        '
        Me.RadTextBox_Rhw.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Rhw.Size = New System.Drawing.Size(60, 20)
        Me.RadTextBox_Rhw.TabIndex = 113
        Me.RadTextBox_Rhw.Text = "98,15"
        '
        'RadTextBox_foil
        '
        Me.RadTextBox_foil.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_foil.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_foil.Location = New System.Drawing.Point(64, 32)
        Me.RadTextBox_foil.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_foil.Name = "RadTextBox_foil"
        '
        '
        '
        Me.RadTextBox_foil.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_foil.Size = New System.Drawing.Size(66, 20)
        Me.RadTextBox_foil.TabIndex = 112
        Me.RadTextBox_foil.Text = "2,97"
        '
        'Panel_CatalogueDataTitle
        '
        Me.Panel_CatalogueDataTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(198,Byte),Integer), CType(CType(217,Byte),Integer), CType(CType(241,Byte),Integer))
        Me.Panel_CatalogueDataTitle.Controls.Add(Me.RadLabel_CatalogueData)
        Me.Panel_CatalogueDataTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_CatalogueDataTitle.Location = New System.Drawing.Point(0, 0)
        Me.Panel_CatalogueDataTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_CatalogueDataTitle.Name = "Panel_CatalogueDataTitle"
        Me.Panel_CatalogueDataTitle.Size = New System.Drawing.Size(259, 21)
        Me.Panel_CatalogueDataTitle.TabIndex = 0
        '
        'RadLabel_CatalogueData
        '
        Me.RadLabel_CatalogueData.AutoSize = false
        Me.RadLabel_CatalogueData.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_CatalogueData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RadLabel_CatalogueData.Location = New System.Drawing.Point(3, 0)
        Me.RadLabel_CatalogueData.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_CatalogueData.Name = "RadLabel_CatalogueData"
        Me.RadLabel_CatalogueData.Size = New System.Drawing.Size(248, 20)
        Me.RadLabel_CatalogueData.TabIndex = 119
        Me.RadLabel_CatalogueData.Text = "ScratchP_CatalogueData"
        Me.RadLabel_CatalogueData.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadButton_ViewAllCatData
        '
        Me.RadButton_ViewAllCatData.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_ViewAllCatData.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_ViewAllCatData.ForeColor = System.Drawing.Color.Black
        Me.RadButton_ViewAllCatData.Location = New System.Drawing.Point(472, 9)
        Me.RadButton_ViewAllCatData.Name = "RadButton_ViewAllCatData"
        Me.RadButton_ViewAllCatData.Size = New System.Drawing.Size(62, 49)
        Me.RadButton_ViewAllCatData.TabIndex = 152
        Me.RadButton_ViewAllCatData.Text = "ScratchP_ViewAllData"
        Me.RadButton_ViewAllCatData.TextWrap = true
        '
        'RadGridView2
        '
        Me.RadGridView2.Location = New System.Drawing.Point(277, 9)
        '
        '
        '
        Me.RadGridView2.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView2.Name = "RadGridView2"
        Me.RadGridView2.Size = New System.Drawing.Size(189, 180)
        Me.RadGridView2.TabIndex = 151
        Me.RadGridView2.Text = "RadGridView2"
        '
        'ScratchP_ExtraFields
        '
        Me.ScratchP_ExtraFields.BackColor = System.Drawing.Color.Silver
        Me.ScratchP_ExtraFields.Controls.Add(Me.RadButton_EditFields)
        Me.ScratchP_ExtraFields.Controls.Add(Me.RadGridView_ExtraFields)
        Me.ScratchP_ExtraFields.Location = New System.Drawing.Point(4, 22)
        Me.ScratchP_ExtraFields.Name = "ScratchP_ExtraFields"
        Me.ScratchP_ExtraFields.Size = New System.Drawing.Size(540, 198)
        Me.ScratchP_ExtraFields.TabIndex = 2
        Me.ScratchP_ExtraFields.Text = "ScratchP_ExtraFields"
        '
        'RadButton_EditFields
        '
        Me.RadButton_EditFields.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_EditFields.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_EditFields.ForeColor = System.Drawing.Color.Black
        Me.RadButton_EditFields.Location = New System.Drawing.Point(397, 30)
        Me.RadButton_EditFields.Name = "RadButton_EditFields"
        Me.RadButton_EditFields.Size = New System.Drawing.Size(129, 41)
        Me.RadButton_EditFields.TabIndex = 150
        Me.RadButton_EditFields.Text = "ScratchP_EditFields"
        Me.RadButton_EditFields.TextWrap = true
        '
        'RadGridView_ExtraFields
        '
        Me.RadGridView_ExtraFields.Location = New System.Drawing.Point(9, 8)
        '
        '
        '
        Me.RadGridView_ExtraFields.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.RadGridView_ExtraFields.Name = "RadGridView_ExtraFields"
        Me.RadGridView_ExtraFields.Size = New System.Drawing.Size(375, 180)
        Me.RadGridView_ExtraFields.TabIndex = 1
        Me.RadGridView_ExtraFields.Text = "RadGridView2"
        '
        'Panel_Anode
        '
        Me.Panel_Anode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Anode.Controls.Add(Me.RadLabel_Cost)
        Me.Panel_Anode.Controls.Add(Me.RadTextBox_Anode3Cost)
        Me.Panel_Anode.Controls.Add(Me.RadTextBox_Anode2Cost)
        Me.Panel_Anode.Controls.Add(Me.RadTextBox_Anode1Cost)
        Me.Panel_Anode.Controls.Add(Me.RadDropDownList_Melinex)
        Me.Panel_Anode.Controls.Add(Me.RadLabel_Mm3)
        Me.Panel_Anode.Controls.Add(Me.RadLabel_Mm2)
        Me.Panel_Anode.Controls.Add(Me.RadTextBox_AnodeLenght2)
        Me.Panel_Anode.Controls.Add(Me.RadTextBox_AnodeLenght)
        Me.Panel_Anode.Controls.Add(Me.RadLabel_Melinex)
        Me.Panel_Anode.Controls.Add(Me.RadLabel_FaradPerSquareCm3)
        Me.Panel_Anode.Controls.Add(Me.RadLabel_FaradPerSquareCm2)
        Me.Panel_Anode.Controls.Add(Me.RadLabel_MinGain)
        Me.Panel_Anode.Controls.Add(Me.RadTextBox_MinGain)
        Me.Panel_Anode.Controls.Add(Me.RadTextBox_Anode3Amount)
        Me.Panel_Anode.Controls.Add(Me.RadLabel_StdLength)
        Me.Panel_Anode.Controls.Add(Me.RadTextBox_Anode2Amount)
        Me.Panel_Anode.Controls.Add(Me.RadDropDownList_Anode3Width)
        Me.Panel_Anode.Controls.Add(Me.RadDropDownList_Anode1Width)
        Me.Panel_Anode.Controls.Add(Me.RadDropDownList_Anode3Vf)
        Me.Panel_Anode.Controls.Add(Me.RadTextBox_AnodeGain2)
        Me.Panel_Anode.Controls.Add(Me.RadDropDownList_Anode3)
        Me.Panel_Anode.Controls.Add(Me.RadDropDownList_Anode2)
        Me.Panel_Anode.Controls.Add(Me.RadLabel_Anode3)
        Me.Panel_Anode.Controls.Add(Me.RadLabel_Anode2)
        Me.Panel_Anode.Controls.Add(Me.RadLabel_MaxLen)
        Me.Panel_Anode.Controls.Add(Me.RadLabel_PercentageFit)
        Me.Panel_Anode.Controls.Add(Me.RadLabel_Factor)
        Me.Panel_Anode.Controls.Add(Me.RadLabel_Anode1)
        Me.Panel_Anode.Controls.Add(Me.RadTextBox_AnodeGain)
        Me.Panel_Anode.Controls.Add(Me.RadTextBox_Factor)
        Me.Panel_Anode.Controls.Add(Me.RadLabel_WindingDetails)
        Me.Panel_Anode.Controls.Add(Me.RadCheckBox_UserGain)
        Me.Panel_Anode.Controls.Add(Me.RadLabel_Anode_Vertical)
        Me.Panel_Anode.Controls.Add(Me.RadTextBox_MaxLen)
        Me.Panel_Anode.Controls.Add(Me.RadTextBox_PercentageFit)
        Me.Panel_Anode.Controls.Add(Me.RadDropDownList_Anode1)
        Me.Panel_Anode.Controls.Add(Me.RadLabel_Vf)
        Me.Panel_Anode.Controls.Add(Me.RadDropDownList_Anode1Vf)
        Me.Panel_Anode.Controls.Add(Me.RadDropDownList_Anode2Vf)
        Me.Panel_Anode.Controls.Add(Me.RadLabel_Width)
        Me.Panel_Anode.Controls.Add(Me.RadDropDownList_Anode2Width)
        Me.Panel_Anode.Controls.Add(Me.RadLabel_Amount)
        Me.Panel_Anode.Controls.Add(Me.RadTextBox_Anode1Amount)
        Me.Panel_Anode.Controls.Add(Me.RadLabel_Mm)
        Me.Panel_Anode.Controls.Add(Me.RadLabel_FaradPerSquareCm)
        Me.Panel_Anode.Controls.Add(Me.RadTextBox_PercentageFit2)
        Me.Panel_Anode.Location = New System.Drawing.Point(2, 2)
        Me.Panel_Anode.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Anode.MinimumSize = New System.Drawing.Size(731, 100)
        Me.Panel_Anode.Name = "Panel_Anode"
        Me.Panel_Anode.Size = New System.Drawing.Size(731, 100)
        Me.Panel_Anode.TabIndex = 9
        '
        'RadLabel_Cost
        '
        Me.RadLabel_Cost.AutoSize = false
        Me.RadLabel_Cost.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Cost.Location = New System.Drawing.Point(340, 0)
        Me.RadLabel_Cost.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Cost.Name = "RadLabel_Cost"
        Me.RadLabel_Cost.Size = New System.Drawing.Size(36, 25)
        Me.RadLabel_Cost.TabIndex = 86
        Me.RadLabel_Cost.Text = "ScratchP_Cost"
        Me.RadLabel_Cost.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadTextBox_Anode3Cost
        '
        Me.RadTextBox_Anode3Cost.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_Anode3Cost.Enabled = false
        Me.RadTextBox_Anode3Cost.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Anode3Cost.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Anode3Cost.Location = New System.Drawing.Point(340, 74)
        Me.RadTextBox_Anode3Cost.Name = "RadTextBox_Anode3Cost"
        '
        '
        '
        Me.RadTextBox_Anode3Cost.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Anode3Cost.Size = New System.Drawing.Size(36, 20)
        Me.RadTextBox_Anode3Cost.TabIndex = 85
        Me.RadTextBox_Anode3Cost.Text = "0"
        Me.RadTextBox_Anode3Cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_Anode2Cost
        '
        Me.RadTextBox_Anode2Cost.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_Anode2Cost.Enabled = false
        Me.RadTextBox_Anode2Cost.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Anode2Cost.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Anode2Cost.Location = New System.Drawing.Point(340, 50)
        Me.RadTextBox_Anode2Cost.Name = "RadTextBox_Anode2Cost"
        '
        '
        '
        Me.RadTextBox_Anode2Cost.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Anode2Cost.Size = New System.Drawing.Size(36, 20)
        Me.RadTextBox_Anode2Cost.TabIndex = 84
        Me.RadTextBox_Anode2Cost.Text = "0"
        Me.RadTextBox_Anode2Cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_Anode1Cost
        '
        Me.RadTextBox_Anode1Cost.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_Anode1Cost.Enabled = false
        Me.RadTextBox_Anode1Cost.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Anode1Cost.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Anode1Cost.Location = New System.Drawing.Point(340, 26)
        Me.RadTextBox_Anode1Cost.Name = "RadTextBox_Anode1Cost"
        '
        '
        '
        Me.RadTextBox_Anode1Cost.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Anode1Cost.Size = New System.Drawing.Size(36, 20)
        Me.RadTextBox_Anode1Cost.TabIndex = 83
        Me.RadTextBox_Anode1Cost.Text = "0"
        Me.RadTextBox_Anode1Cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadDropDownList_Melinex
        '
        Me.RadDropDownList_Melinex.AutoSizeItems = true
        Me.RadDropDownList_Melinex.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Melinex.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Melinex.Location = New System.Drawing.Point(447, 74)
        Me.RadDropDownList_Melinex.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Melinex.MinimumSize = New System.Drawing.Size(74, 20)
        Me.RadDropDownList_Melinex.Name = "RadDropDownList_Melinex"
        '
        '
        '
        Me.RadDropDownList_Melinex.RootElement.MinSize = New System.Drawing.Size(74, 20)
        Me.RadDropDownList_Melinex.Size = New System.Drawing.Size(74, 20)
        Me.RadDropDownList_Melinex.TabIndex = 80
        Me.RadDropDownList_Melinex.Visible = false
        '
        'RadLabel_Mm3
        '
        Me.RadLabel_Mm3.AutoSize = false
        Me.RadLabel_Mm3.Font = New System.Drawing.Font("Segoe UI", 7!)
        Me.RadLabel_Mm3.Location = New System.Drawing.Point(433, 50)
        Me.RadLabel_Mm3.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Mm3.Name = "RadLabel_Mm3"
        Me.RadLabel_Mm3.Size = New System.Drawing.Size(35, 20)
        Me.RadLabel_Mm3.TabIndex = 82
        Me.RadLabel_Mm3.Text = "Units_Mm"
        Me.RadLabel_Mm3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_Mm2
        '
        Me.RadLabel_Mm2.AutoSize = false
        Me.RadLabel_Mm2.Font = New System.Drawing.Font("Segoe UI", 7!)
        Me.RadLabel_Mm2.Location = New System.Drawing.Point(433, 26)
        Me.RadLabel_Mm2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Mm2.Name = "RadLabel_Mm2"
        Me.RadLabel_Mm2.Size = New System.Drawing.Size(35, 20)
        Me.RadLabel_Mm2.TabIndex = 81
        Me.RadLabel_Mm2.Text = "Units_Mm"
        Me.RadLabel_Mm2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadTextBox_AnodeLenght2
        '
        Me.RadTextBox_AnodeLenght2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_AnodeLenght2.Enabled = false
        Me.RadTextBox_AnodeLenght2.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_AnodeLenght2.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_AnodeLenght2.Location = New System.Drawing.Point(384, 50)
        Me.RadTextBox_AnodeLenght2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_AnodeLenght2.MinimumSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_AnodeLenght2.Name = "RadTextBox_AnodeLenght2"
        '
        '
        '
        Me.RadTextBox_AnodeLenght2.RootElement.MinSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_AnodeLenght2.Size = New System.Drawing.Size(47, 20)
        Me.RadTextBox_AnodeLenght2.TabIndex = 78
        Me.RadTextBox_AnodeLenght2.Text = "0"
        Me.RadTextBox_AnodeLenght2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadTextBox_AnodeLenght
        '
        Me.RadTextBox_AnodeLenght.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_AnodeLenght.Enabled = false
        Me.RadTextBox_AnodeLenght.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_AnodeLenght.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_AnodeLenght.Location = New System.Drawing.Point(384, 26)
        Me.RadTextBox_AnodeLenght.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_AnodeLenght.MinimumSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_AnodeLenght.Name = "RadTextBox_AnodeLenght"
        '
        '
        '
        Me.RadTextBox_AnodeLenght.RootElement.MinSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_AnodeLenght.Size = New System.Drawing.Size(47, 20)
        Me.RadTextBox_AnodeLenght.TabIndex = 79
        Me.RadTextBox_AnodeLenght.Text = "12537"
        Me.RadTextBox_AnodeLenght.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel_Melinex
        '
        Me.RadLabel_Melinex.AutoSize = false
        Me.RadLabel_Melinex.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Melinex.Location = New System.Drawing.Point(384, 74)
        Me.RadLabel_Melinex.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Melinex.Name = "RadLabel_Melinex"
        Me.RadLabel_Melinex.Size = New System.Drawing.Size(59, 20)
        Me.RadLabel_Melinex.TabIndex = 75
        Me.RadLabel_Melinex.Text = "ScratchP_Melinex"
        Me.RadLabel_Melinex.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_Melinex.Visible = false
        '
        'RadLabel_FaradPerSquareCm3
        '
        Me.RadLabel_FaradPerSquareCm3.AutoSize = false
        Me.RadLabel_FaradPerSquareCm3.Font = New System.Drawing.Font("Segoe UI", 6.5!)
        Me.RadLabel_FaradPerSquareCm3.Location = New System.Drawing.Point(522, 50)
        Me.RadLabel_FaradPerSquareCm3.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_FaradPerSquareCm3.Name = "RadLabel_FaradPerSquareCm3"
        Me.RadLabel_FaradPerSquareCm3.Size = New System.Drawing.Size(58, 20)
        Me.RadLabel_FaradPerSquareCm3.TabIndex = 80
        Me.RadLabel_FaradPerSquareCm3.Text = "Units_MicroFaradPerSquareCm"
        Me.RadLabel_FaradPerSquareCm3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_FaradPerSquareCm2
        '
        Me.RadLabel_FaradPerSquareCm2.AutoSize = false
        Me.RadLabel_FaradPerSquareCm2.Font = New System.Drawing.Font("Segoe UI", 6.5!)
        Me.RadLabel_FaradPerSquareCm2.Location = New System.Drawing.Point(522, 26)
        Me.RadLabel_FaradPerSquareCm2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_FaradPerSquareCm2.Name = "RadLabel_FaradPerSquareCm2"
        Me.RadLabel_FaradPerSquareCm2.Size = New System.Drawing.Size(58, 20)
        Me.RadLabel_FaradPerSquareCm2.TabIndex = 79
        Me.RadLabel_FaradPerSquareCm2.Text = "Units_MicroFaradPerSquareCm"
        Me.RadLabel_FaradPerSquareCm2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_MinGain
        '
        Me.RadLabel_MinGain.AutoSize = false
        Me.RadLabel_MinGain.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_MinGain.Location = New System.Drawing.Point(588, 74)
        Me.RadLabel_MinGain.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_MinGain.Name = "RadLabel_MinGain"
        Me.RadLabel_MinGain.Size = New System.Drawing.Size(56, 20)
        Me.RadLabel_MinGain.TabIndex = 78
        Me.RadLabel_MinGain.Text = "ScratchP_MinGain"
        Me.RadLabel_MinGain.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadTextBox_MinGain
        '
        Me.RadTextBox_MinGain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_MinGain.Enabled = false
        Me.RadTextBox_MinGain.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_MinGain.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_MinGain.Location = New System.Drawing.Point(644, 74)
        Me.RadTextBox_MinGain.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_MinGain.MinimumSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_MinGain.Name = "RadTextBox_MinGain"
        '
        '
        '
        Me.RadTextBox_MinGain.RootElement.MinSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_MinGain.Size = New System.Drawing.Size(47, 20)
        Me.RadTextBox_MinGain.TabIndex = 77
        Me.RadTextBox_MinGain.Text = "0,518"
        Me.RadTextBox_MinGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadTextBox_Anode3Amount
        '
        Me.RadTextBox_Anode3Amount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_Anode3Amount.Enabled = false
        Me.RadTextBox_Anode3Amount.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Anode3Amount.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Anode3Amount.Location = New System.Drawing.Point(285, 74)
        Me.RadTextBox_Anode3Amount.MinimumSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_Anode3Amount.Name = "RadTextBox_Anode3Amount"
        '
        '
        '
        Me.RadTextBox_Anode3Amount.RootElement.MinSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_Anode3Amount.Size = New System.Drawing.Size(48, 20)
        Me.RadTextBox_Anode3Amount.TabIndex = 74
        Me.RadTextBox_Anode3Amount.Text = "0"
        Me.RadTextBox_Anode3Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_StdLength
        '
        Me.RadLabel_StdLength.AutoSize = false
        Me.RadLabel_StdLength.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_StdLength.Location = New System.Drawing.Point(383, 0)
        Me.RadLabel_StdLength.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_StdLength.Name = "RadLabel_StdLength"
        Me.RadLabel_StdLength.Size = New System.Drawing.Size(85, 25)
        Me.RadLabel_StdLength.TabIndex = 80
        Me.RadLabel_StdLength.Text = "ScratchP_StdLength"
        Me.RadLabel_StdLength.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadTextBox_Anode2Amount
        '
        Me.RadTextBox_Anode2Amount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_Anode2Amount.Enabled = false
        Me.RadTextBox_Anode2Amount.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Anode2Amount.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Anode2Amount.Location = New System.Drawing.Point(285, 50)
        Me.RadTextBox_Anode2Amount.MinimumSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_Anode2Amount.Name = "RadTextBox_Anode2Amount"
        '
        '
        '
        Me.RadTextBox_Anode2Amount.RootElement.MinSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_Anode2Amount.Size = New System.Drawing.Size(48, 20)
        Me.RadTextBox_Anode2Amount.TabIndex = 73
        Me.RadTextBox_Anode2Amount.Text = "0"
        Me.RadTextBox_Anode2Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadDropDownList_Anode3Width
        '
        Me.RadDropDownList_Anode3Width.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Anode3Width.Enabled = false
        Me.RadDropDownList_Anode3Width.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Anode3Width.Location = New System.Drawing.Point(214, 72)
        Me.RadDropDownList_Anode3Width.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Anode3Width.MinimumSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Anode3Width.Name = "RadDropDownList_Anode3Width"
        '
        '
        '
        Me.RadDropDownList_Anode3Width.RootElement.MinSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Anode3Width.Size = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Anode3Width.TabIndex = 72
        Me.RadDropDownList_Anode3Width.Text = "0"
        '
        'RadDropDownList_Anode1Width
        '
        Me.RadDropDownList_Anode1Width.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Anode1Width.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Anode1Width.Location = New System.Drawing.Point(214, 24)
        Me.RadDropDownList_Anode1Width.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Anode1Width.MinimumSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Anode1Width.Name = "RadDropDownList_Anode1Width"
        '
        '
        '
        Me.RadDropDownList_Anode1Width.RootElement.MinSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Anode1Width.Size = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Anode1Width.TabIndex = 71
        Me.RadDropDownList_Anode1Width.Text = "45"
        '
        'RadDropDownList_Anode3Vf
        '
        Me.RadDropDownList_Anode3Vf.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Anode3Vf.Enabled = false
        Me.RadDropDownList_Anode3Vf.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Anode3Vf.Location = New System.Drawing.Point(154, 72)
        Me.RadDropDownList_Anode3Vf.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Anode3Vf.MinimumSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Anode3Vf.Name = "RadDropDownList_Anode3Vf"
        '
        '
        '
        Me.RadDropDownList_Anode3Vf.RootElement.MinSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Anode3Vf.Size = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Anode3Vf.TabIndex = 70
        Me.RadDropDownList_Anode3Vf.Text = "0"
        '
        'RadTextBox_AnodeGain2
        '
        Me.RadTextBox_AnodeGain2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_AnodeGain2.Enabled = false
        Me.RadTextBox_AnodeGain2.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_AnodeGain2.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_AnodeGain2.Location = New System.Drawing.Point(473, 50)
        Me.RadTextBox_AnodeGain2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_AnodeGain2.MinimumSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_AnodeGain2.Name = "RadTextBox_AnodeGain2"
        '
        '
        '
        Me.RadTextBox_AnodeGain2.RootElement.MinSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_AnodeGain2.Size = New System.Drawing.Size(47, 20)
        Me.RadTextBox_AnodeGain2.TabIndex = 77
        Me.RadTextBox_AnodeGain2.Text = "0"
        Me.RadTextBox_AnodeGain2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadDropDownList_Anode3
        '
        Me.RadDropDownList_Anode3.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Anode3.Enabled = false
        Me.RadDropDownList_Anode3.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Anode3.Location = New System.Drawing.Point(48, 72)
        Me.RadDropDownList_Anode3.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Anode3.MinimumSize = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Anode3.Name = "RadDropDownList_Anode3"
        '
        '
        '
        Me.RadDropDownList_Anode3.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Anode3.RootElement.MinSize = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Anode3.Size = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Anode3.TabIndex = 60
        Me.RadDropDownList_Anode3.Text = "none"
        '
        'RadDropDownList_Anode2
        '
        Me.RadDropDownList_Anode2.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Anode2.Enabled = false
        Me.RadDropDownList_Anode2.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Anode2.Location = New System.Drawing.Point(48, 48)
        Me.RadDropDownList_Anode2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Anode2.MinimumSize = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Anode2.Name = "RadDropDownList_Anode2"
        '
        '
        '
        Me.RadDropDownList_Anode2.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Anode2.RootElement.MinSize = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Anode2.Size = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Anode2.TabIndex = 59
        Me.RadDropDownList_Anode2.Text = "none"
        '
        'RadLabel_Anode3
        '
        Me.RadLabel_Anode3.AutoSize = false
        Me.RadLabel_Anode3.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Anode3.Location = New System.Drawing.Point(24, 73)
        Me.RadLabel_Anode3.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Anode3.Name = "RadLabel_Anode3"
        Me.RadLabel_Anode3.Size = New System.Drawing.Size(22, 25)
        Me.RadLabel_Anode3.TabIndex = 58
        Me.RadLabel_Anode3.Text = "Global_3"
        Me.RadLabel_Anode3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_Anode2
        '
        Me.RadLabel_Anode2.AutoSize = false
        Me.RadLabel_Anode2.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Anode2.Location = New System.Drawing.Point(24, 49)
        Me.RadLabel_Anode2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Anode2.Name = "RadLabel_Anode2"
        Me.RadLabel_Anode2.Size = New System.Drawing.Size(22, 25)
        Me.RadLabel_Anode2.TabIndex = 57
        Me.RadLabel_Anode2.Text = "Global_2"
        Me.RadLabel_Anode2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_MaxLen
        '
        Me.RadLabel_MaxLen.AutoSize = false
        Me.RadLabel_MaxLen.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_MaxLen.Location = New System.Drawing.Point(588, 50)
        Me.RadLabel_MaxLen.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_MaxLen.Name = "RadLabel_MaxLen"
        Me.RadLabel_MaxLen.Size = New System.Drawing.Size(56, 20)
        Me.RadLabel_MaxLen.TabIndex = 74
        Me.RadLabel_MaxLen.Text = "ScratchP_MaxLen"
        Me.RadLabel_MaxLen.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadLabel_PercentageFit
        '
        Me.RadLabel_PercentageFit.AutoSize = false
        Me.RadLabel_PercentageFit.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_PercentageFit.Location = New System.Drawing.Point(588, 26)
        Me.RadLabel_PercentageFit.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_PercentageFit.Name = "RadLabel_PercentageFit"
        Me.RadLabel_PercentageFit.Size = New System.Drawing.Size(56, 20)
        Me.RadLabel_PercentageFit.TabIndex = 74
        Me.RadLabel_PercentageFit.Text = "ScratchP_PercentageFit"
        Me.RadLabel_PercentageFit.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadLabel_Factor
        '
        Me.RadLabel_Factor.AutoSize = false
        Me.RadLabel_Factor.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_Factor.Location = New System.Drawing.Point(588, 1)
        Me.RadLabel_Factor.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Factor.Name = "RadLabel_Factor"
        Me.RadLabel_Factor.Size = New System.Drawing.Size(56, 20)
        Me.RadLabel_Factor.TabIndex = 74
        Me.RadLabel_Factor.Text = "ScratchP_Factor"
        Me.RadLabel_Factor.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadLabel_Anode1
        '
        Me.RadLabel_Anode1.AutoSize = false
        Me.RadLabel_Anode1.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Anode1.Location = New System.Drawing.Point(24, 25)
        Me.RadLabel_Anode1.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Anode1.Name = "RadLabel_Anode1"
        Me.RadLabel_Anode1.Size = New System.Drawing.Size(22, 25)
        Me.RadLabel_Anode1.TabIndex = 56
        Me.RadLabel_Anode1.Text = "Global_1"
        Me.RadLabel_Anode1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_AnodeGain
        '
        Me.RadTextBox_AnodeGain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_AnodeGain.Enabled = false
        Me.RadTextBox_AnodeGain.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_AnodeGain.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_AnodeGain.Location = New System.Drawing.Point(473, 26)
        Me.RadTextBox_AnodeGain.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_AnodeGain.MinimumSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_AnodeGain.Name = "RadTextBox_AnodeGain"
        '
        '
        '
        Me.RadTextBox_AnodeGain.RootElement.MinSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_AnodeGain.Size = New System.Drawing.Size(47, 20)
        Me.RadTextBox_AnodeGain.TabIndex = 76
        Me.RadTextBox_AnodeGain.Text = "0,64"
        Me.RadTextBox_AnodeGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadTextBox_Factor
        '
        Me.RadTextBox_Factor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_Factor.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Factor.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Factor.Location = New System.Drawing.Point(644, 1)
        Me.RadTextBox_Factor.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_Factor.MinimumSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_Factor.Name = "RadTextBox_Factor"
        '
        '
        '
        Me.RadTextBox_Factor.RootElement.MinSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_Factor.Size = New System.Drawing.Size(47, 20)
        Me.RadTextBox_Factor.TabIndex = 72
        Me.RadTextBox_Factor.Text = "0,90"
        Me.RadTextBox_Factor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel_WindingDetails
        '
        Me.RadLabel_WindingDetails.AutoSize = false
        Me.RadLabel_WindingDetails.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_WindingDetails.Location = New System.Drawing.Point(1, 0)
        Me.RadLabel_WindingDetails.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_WindingDetails.Name = "RadLabel_WindingDetails"
        Me.RadLabel_WindingDetails.Size = New System.Drawing.Size(151, 25)
        Me.RadLabel_WindingDetails.TabIndex = 53
        Me.RadLabel_WindingDetails.Text = "ScratchP_WindingDetails"
        Me.RadLabel_WindingDetails.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadCheckBox_UserGain
        '
        Me.RadCheckBox_UserGain.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadCheckBox_UserGain.AutoSize = false
        Me.RadCheckBox_UserGain.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadCheckBox_UserGain.Location = New System.Drawing.Point(471, 2)
        Me.RadCheckBox_UserGain.Name = "RadCheckBox_UserGain"
        Me.RadCheckBox_UserGain.Size = New System.Drawing.Size(110, 18)
        Me.RadCheckBox_UserGain.TabIndex = 78
        Me.RadCheckBox_UserGain.Text = "ScratchP_UserGain"
        '
        'RadLabel_Anode_Vertical
        '
        Me.RadLabel_Anode_Vertical.AutoSize = false
        Me.RadLabel_Anode_Vertical.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(1,Byte), true)
        Me.RadLabel_Anode_Vertical.Location = New System.Drawing.Point(2, 22)
        Me.RadLabel_Anode_Vertical.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Anode_Vertical.Name = "RadLabel_Anode_Vertical"
        Me.RadLabel_Anode_Vertical.Size = New System.Drawing.Size(20, 75)
        Me.RadLabel_Anode_Vertical.TabIndex = 54
        Me.RadLabel_Anode_Vertical.Text = "ScratchP_Anode_Vertical"
        Me.RadLabel_Anode_Vertical.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_MaxLen
        '
        Me.RadTextBox_MaxLen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_MaxLen.Enabled = false
        Me.RadTextBox_MaxLen.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_MaxLen.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_MaxLen.Location = New System.Drawing.Point(644, 50)
        Me.RadTextBox_MaxLen.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_MaxLen.MinimumSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_MaxLen.Name = "RadTextBox_MaxLen"
        '
        '
        '
        Me.RadTextBox_MaxLen.RootElement.MinSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_MaxLen.Size = New System.Drawing.Size(47, 20)
        Me.RadTextBox_MaxLen.TabIndex = 71
        Me.RadTextBox_MaxLen.Text = "14024"
        Me.RadTextBox_MaxLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadTextBox_PercentageFit
        '
        Me.RadTextBox_PercentageFit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_PercentageFit.Enabled = false
        Me.RadTextBox_PercentageFit.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_PercentageFit.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_PercentageFit.Location = New System.Drawing.Point(644, 26)
        Me.RadTextBox_PercentageFit.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_PercentageFit.MinimumSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_PercentageFit.Name = "RadTextBox_PercentageFit"
        '
        '
        '
        Me.RadTextBox_PercentageFit.RootElement.MinSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_PercentageFit.Size = New System.Drawing.Size(47, 20)
        Me.RadTextBox_PercentageFit.TabIndex = 71
        Me.RadTextBox_PercentageFit.Text = "89,3"
        Me.RadTextBox_PercentageFit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadDropDownList_Anode1
        '
        Me.RadDropDownList_Anode1.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Anode1.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Anode1.Location = New System.Drawing.Point(48, 24)
        Me.RadDropDownList_Anode1.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Anode1.MinimumSize = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Anode1.Name = "RadDropDownList_Anode1"
        '
        '
        '
        Me.RadDropDownList_Anode1.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Anode1.RootElement.MinSize = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Anode1.Size = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Anode1.TabIndex = 58
        Me.RadDropDownList_Anode1.Text = "A961S"
        '
        'RadLabel_Vf
        '
        Me.RadLabel_Vf.AutoSize = false
        Me.RadLabel_Vf.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Vf.Location = New System.Drawing.Point(155, 0)
        Me.RadLabel_Vf.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Vf.Name = "RadLabel_Vf"
        Me.RadLabel_Vf.Size = New System.Drawing.Size(58, 25)
        Me.RadLabel_Vf.TabIndex = 61
        Me.RadLabel_Vf.Text = "ScratchP_Vf"
        Me.RadLabel_Vf.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadDropDownList_Anode1Vf
        '
        Me.RadDropDownList_Anode1Vf.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Anode1Vf.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Anode1Vf.Location = New System.Drawing.Point(154, 24)
        Me.RadDropDownList_Anode1Vf.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Anode1Vf.MinimumSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Anode1Vf.Name = "RadDropDownList_Anode1Vf"
        '
        '
        '
        Me.RadDropDownList_Anode1Vf.RootElement.MinSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Anode1Vf.Size = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Anode1Vf.TabIndex = 68
        Me.RadDropDownList_Anode1Vf.Text = "590"
        '
        'RadDropDownList_Anode2Vf
        '
        Me.RadDropDownList_Anode2Vf.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Anode2Vf.Enabled = false
        Me.RadDropDownList_Anode2Vf.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Anode2Vf.Location = New System.Drawing.Point(154, 48)
        Me.RadDropDownList_Anode2Vf.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Anode2Vf.MinimumSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Anode2Vf.Name = "RadDropDownList_Anode2Vf"
        '
        '
        '
        Me.RadDropDownList_Anode2Vf.RootElement.MinSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Anode2Vf.Size = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Anode2Vf.TabIndex = 69
        Me.RadDropDownList_Anode2Vf.Text = "0"
        '
        'RadLabel_Width
        '
        Me.RadLabel_Width.AutoSize = false
        Me.RadLabel_Width.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Width.Location = New System.Drawing.Point(214, 0)
        Me.RadLabel_Width.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Width.Name = "RadLabel_Width"
        Me.RadLabel_Width.Size = New System.Drawing.Size(60, 25)
        Me.RadLabel_Width.TabIndex = 65
        Me.RadLabel_Width.Text = "Global_Width"
        Me.RadLabel_Width.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadDropDownList_Anode2Width
        '
        Me.RadDropDownList_Anode2Width.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Anode2Width.Enabled = false
        Me.RadDropDownList_Anode2Width.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Anode2Width.Location = New System.Drawing.Point(214, 48)
        Me.RadDropDownList_Anode2Width.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Anode2Width.MinimumSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Anode2Width.Name = "RadDropDownList_Anode2Width"
        '
        '
        '
        Me.RadDropDownList_Anode2Width.RootElement.MinSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Anode2Width.Size = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Anode2Width.TabIndex = 66
        Me.RadDropDownList_Anode2Width.Text = "0"
        '
        'RadLabel_Amount
        '
        Me.RadLabel_Amount.AutoSize = false
        Me.RadLabel_Amount.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Amount.Location = New System.Drawing.Point(279, 0)
        Me.RadLabel_Amount.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Amount.Name = "RadLabel_Amount"
        Me.RadLabel_Amount.Size = New System.Drawing.Size(61, 25)
        Me.RadLabel_Amount.TabIndex = 69
        Me.RadLabel_Amount.Text = "ScratchP_Amount"
        Me.RadLabel_Amount.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadTextBox_Anode1Amount
        '
        Me.RadTextBox_Anode1Amount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_Anode1Amount.Enabled = false
        Me.RadTextBox_Anode1Amount.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Anode1Amount.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Anode1Amount.Location = New System.Drawing.Point(285, 26)
        Me.RadTextBox_Anode1Amount.MinimumSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_Anode1Amount.Name = "RadTextBox_Anode1Amount"
        '
        '
        '
        Me.RadTextBox_Anode1Amount.RootElement.MinSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_Anode1Amount.Size = New System.Drawing.Size(48, 20)
        Me.RadTextBox_Anode1Amount.TabIndex = 70
        Me.RadTextBox_Anode1Amount.Text = "0"
        Me.RadTextBox_Anode1Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_Mm
        '
        Me.RadLabel_Mm.AutoSize = false
        Me.RadLabel_Mm.Font = New System.Drawing.Font("Segoe UI", 7!)
        Me.RadLabel_Mm.Location = New System.Drawing.Point(692, 50)
        Me.RadLabel_Mm.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Mm.Name = "RadLabel_Mm"
        Me.RadLabel_Mm.Size = New System.Drawing.Size(35, 20)
        Me.RadLabel_Mm.TabIndex = 74
        Me.RadLabel_Mm.Text = "Units_Mm"
        Me.RadLabel_Mm.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_FaradPerSquareCm
        '
        Me.RadLabel_FaradPerSquareCm.AutoSize = false
        Me.RadLabel_FaradPerSquareCm.Font = New System.Drawing.Font("Segoe UI", 6.5!)
        Me.RadLabel_FaradPerSquareCm.Location = New System.Drawing.Point(692, 74)
        Me.RadLabel_FaradPerSquareCm.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_FaradPerSquareCm.Name = "RadLabel_FaradPerSquareCm"
        '
        '
        '
        Me.RadLabel_FaradPerSquareCm.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadLabel_FaradPerSquareCm.Size = New System.Drawing.Size(35, 20)
        Me.RadLabel_FaradPerSquareCm.TabIndex = 76
        Me.RadLabel_FaradPerSquareCm.Text = "Units_MicroFaradPerSquareCm"
        Me.RadLabel_FaradPerSquareCm.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadTextBox_PercentageFit2
        '
        Me.RadTextBox_PercentageFit2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_PercentageFit2.Enabled = false
        Me.RadTextBox_PercentageFit2.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_PercentageFit2.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_PercentageFit2.Location = New System.Drawing.Point(693, 26)
        Me.RadTextBox_PercentageFit2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_PercentageFit2.MinimumSize = New System.Drawing.Size(32, 20)
        Me.RadTextBox_PercentageFit2.Name = "RadTextBox_PercentageFit2"
        '
        '
        '
        Me.RadTextBox_PercentageFit2.RootElement.MinSize = New System.Drawing.Size(32, 20)
        Me.RadTextBox_PercentageFit2.Size = New System.Drawing.Size(32, 20)
        Me.RadTextBox_PercentageFit2.TabIndex = 72
        Me.RadTextBox_PercentageFit2.Text = "88"
        Me.RadTextBox_PercentageFit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel_Parameters
        '
        Me.Panel_Parameters.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Panel_Parameters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Parameters.Controls.Add(Me.RadLabel_TestVolts)
        Me.Panel_Parameters.Controls.Add(Me.RadTextBox_IMPAt10000HzAt20C)
        Me.Panel_Parameters.Controls.Add(Me.RadLabel_IMPAt10000HzAt20C)
        Me.Panel_Parameters.Controls.Add(Me.RadTextBox_ESRAt100HzAt20C)
        Me.Panel_Parameters.Controls.Add(Me.RadLabel_ESRAt100HzAt20C)
        Me.Panel_Parameters.Controls.Add(Me.RadLabel_ParameterCondition)
        Me.Panel_Parameters.Controls.Add(Me.RadLabel_ParameterValue)
        Me.Panel_Parameters.Controls.Add(Me.RadLabel_Parameter)
        Me.Panel_Parameters.Controls.Add(Me.RadDropDownList_ParameterCondition4)
        Me.Panel_Parameters.Controls.Add(Me.RadTextBox_ParameterValue4)
        Me.Panel_Parameters.Controls.Add(Me.RadDropDownList_ParameterCondition3)
        Me.Panel_Parameters.Controls.Add(Me.RadTextBox_ParameterValue3)
        Me.Panel_Parameters.Controls.Add(Me.RadDropDownList_ParameterCondition2)
        Me.Panel_Parameters.Controls.Add(Me.RadTextBox_ParameterValue2)
        Me.Panel_Parameters.Controls.Add(Me.RadCheckBox_ac)
        Me.Panel_Parameters.Controls.Add(Me.RadTextBox_TestVolts)
        Me.Panel_Parameters.Controls.Add(Me.RadDropDownList_ParameterCondition1)
        Me.Panel_Parameters.Controls.Add(Me.RadTextBox_ParameterValue1)
        Me.Panel_Parameters.Controls.Add(Me.RadDropDownList_Parameter4)
        Me.Panel_Parameters.Controls.Add(Me.RadDropDownList_Parameter3)
        Me.Panel_Parameters.Controls.Add(Me.RadDropDownList_Parameter2)
        Me.Panel_Parameters.Controls.Add(Me.RadLabel_MicroFarad4)
        Me.Panel_Parameters.Controls.Add(Me.RadTextBox_Capacitance2)
        Me.Panel_Parameters.Controls.Add(Me.RadLabel_to)
        Me.Panel_Parameters.Controls.Add(Me.RadLabel_MicroFarad3)
        Me.Panel_Parameters.Controls.Add(Me.RadTextBox_Capacitance)
        Me.Panel_Parameters.Controls.Add(Me.RadLabel_Capacitance)
        Me.Panel_Parameters.Controls.Add(Me.RadDropDownList_Parameter1)
        Me.Panel_Parameters.Controls.Add(Me.RadButton_GetLimits)
        Me.Panel_Parameters.Controls.Add(Me.RadButton_TestParameters)
        Me.Panel_Parameters.Location = New System.Drawing.Point(557, 519)
        Me.Panel_Parameters.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Parameters.Name = "Panel_Parameters"
        Me.Panel_Parameters.Size = New System.Drawing.Size(416, 224)
        Me.Panel_Parameters.TabIndex = 18
        '
        'RadLabel_TestVolts
        '
        Me.RadLabel_TestVolts.AutoSize = false
        Me.RadLabel_TestVolts.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_TestVolts.Location = New System.Drawing.Point(323, 134)
        Me.RadLabel_TestVolts.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_TestVolts.Name = "RadLabel_TestVolts"
        Me.RadLabel_TestVolts.Size = New System.Drawing.Size(78, 20)
        Me.RadLabel_TestVolts.TabIndex = 182
        Me.RadLabel_TestVolts.Text = "ScratchP_TestVolts"
        Me.RadLabel_TestVolts.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadTextBox_IMPAt10000HzAt20C
        '
        Me.RadTextBox_IMPAt10000HzAt20C.Enabled = false
        Me.RadTextBox_IMPAt10000HzAt20C.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_IMPAt10000HzAt20C.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_IMPAt10000HzAt20C.Location = New System.Drawing.Point(339, 190)
        Me.RadTextBox_IMPAt10000HzAt20C.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_IMPAt10000HzAt20C.Name = "RadTextBox_IMPAt10000HzAt20C"
        '
        '
        '
        Me.RadTextBox_IMPAt10000HzAt20C.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_IMPAt10000HzAt20C.Size = New System.Drawing.Size(55, 20)
        Me.RadTextBox_IMPAt10000HzAt20C.TabIndex = 181
        Me.RadTextBox_IMPAt10000HzAt20C.Text = "58,4"
        Me.RadTextBox_IMPAt10000HzAt20C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_IMPAt10000HzAt20C
        '
        Me.RadLabel_IMPAt10000HzAt20C.AutoSize = false
        Me.RadLabel_IMPAt10000HzAt20C.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_IMPAt10000HzAt20C.Location = New System.Drawing.Point(201, 190)
        Me.RadLabel_IMPAt10000HzAt20C.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_IMPAt10000HzAt20C.Name = "RadLabel_IMPAt10000HzAt20C"
        Me.RadLabel_IMPAt10000HzAt20C.Size = New System.Drawing.Size(140, 20)
        Me.RadLabel_IMPAt10000HzAt20C.TabIndex = 180
        Me.RadLabel_IMPAt10000HzAt20C.Text = "ScratchP_IMPAt10000HzAt20C"
        Me.RadLabel_IMPAt10000HzAt20C.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadTextBox_ESRAt100HzAt20C
        '
        Me.RadTextBox_ESRAt100HzAt20C.Enabled = false
        Me.RadTextBox_ESRAt100HzAt20C.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_ESRAt100HzAt20C.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_ESRAt100HzAt20C.Location = New System.Drawing.Point(130, 190)
        Me.RadTextBox_ESRAt100HzAt20C.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_ESRAt100HzAt20C.Name = "RadTextBox_ESRAt100HzAt20C"
        '
        '
        '
        Me.RadTextBox_ESRAt100HzAt20C.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_ESRAt100HzAt20C.Size = New System.Drawing.Size(65, 20)
        Me.RadTextBox_ESRAt100HzAt20C.TabIndex = 179
        Me.RadTextBox_ESRAt100HzAt20C.Text = "96,2"
        Me.RadTextBox_ESRAt100HzAt20C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_ESRAt100HzAt20C
        '
        Me.RadLabel_ESRAt100HzAt20C.AutoSize = false
        Me.RadLabel_ESRAt100HzAt20C.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_ESRAt100HzAt20C.Location = New System.Drawing.Point(10, 190)
        Me.RadLabel_ESRAt100HzAt20C.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_ESRAt100HzAt20C.Name = "RadLabel_ESRAt100HzAt20C"
        Me.RadLabel_ESRAt100HzAt20C.Size = New System.Drawing.Size(120, 20)
        Me.RadLabel_ESRAt100HzAt20C.TabIndex = 178
        Me.RadLabel_ESRAt100HzAt20C.Text = "ScratchP_ESRAt100HzAt20C"
        Me.RadLabel_ESRAt100HzAt20C.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadLabel_ParameterCondition
        '
        Me.RadLabel_ParameterCondition.AutoSize = false
        Me.RadLabel_ParameterCondition.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_ParameterCondition.Location = New System.Drawing.Point(150, 64)
        Me.RadLabel_ParameterCondition.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_ParameterCondition.Name = "RadLabel_ParameterCondition"
        Me.RadLabel_ParameterCondition.Size = New System.Drawing.Size(171, 20)
        Me.RadLabel_ParameterCondition.TabIndex = 177
        Me.RadLabel_ParameterCondition.Text = "Global_Condition"
        Me.RadLabel_ParameterCondition.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadLabel_ParameterValue
        '
        Me.RadLabel_ParameterValue.AutoSize = false
        Me.RadLabel_ParameterValue.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_ParameterValue.Location = New System.Drawing.Point(102, 64)
        Me.RadLabel_ParameterValue.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_ParameterValue.Name = "RadLabel_ParameterValue"
        Me.RadLabel_ParameterValue.Size = New System.Drawing.Size(45, 20)
        Me.RadLabel_ParameterValue.TabIndex = 176
        Me.RadLabel_ParameterValue.Text = "Global_Value"
        Me.RadLabel_ParameterValue.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadLabel_Parameter
        '
        Me.RadLabel_Parameter.AutoSize = false
        Me.RadLabel_Parameter.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Parameter.Location = New System.Drawing.Point(10, 64)
        Me.RadLabel_Parameter.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Parameter.Name = "RadLabel_Parameter"
        Me.RadLabel_Parameter.Size = New System.Drawing.Size(90, 20)
        Me.RadLabel_Parameter.TabIndex = 175
        Me.RadLabel_Parameter.Text = "Global_Parameter"
        Me.RadLabel_Parameter.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadDropDownList_ParameterCondition4
        '
        Me.RadDropDownList_ParameterCondition4.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_ParameterCondition4.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadDropDownList_ParameterCondition4.Location = New System.Drawing.Point(149, 159)
        Me.RadDropDownList_ParameterCondition4.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_ParameterCondition4.Name = "RadDropDownList_ParameterCondition4"
        '
        '
        '
        Me.RadDropDownList_ParameterCondition4.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_ParameterCondition4.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_ParameterCondition4.Size = New System.Drawing.Size(172, 20)
        Me.RadDropDownList_ParameterCondition4.TabIndex = 174
        Me.RadDropDownList_ParameterCondition4.Text = "mA max @ Test Volts"
        '
        'RadTextBox_ParameterValue4
        '
        Me.RadTextBox_ParameterValue4.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_ParameterValue4.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_ParameterValue4.Location = New System.Drawing.Point(102, 159)
        Me.RadTextBox_ParameterValue4.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_ParameterValue4.Name = "RadTextBox_ParameterValue4"
        '
        '
        '
        Me.RadTextBox_ParameterValue4.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_ParameterValue4.Size = New System.Drawing.Size(45, 20)
        Me.RadTextBox_ParameterValue4.TabIndex = 173
        Me.RadTextBox_ParameterValue4.Text = "2,214"
        Me.RadTextBox_ParameterValue4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadDropDownList_ParameterCondition3
        '
        Me.RadDropDownList_ParameterCondition3.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_ParameterCondition3.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadDropDownList_ParameterCondition3.Location = New System.Drawing.Point(149, 134)
        Me.RadDropDownList_ParameterCondition3.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_ParameterCondition3.Name = "RadDropDownList_ParameterCondition3"
        '
        '
        '
        Me.RadDropDownList_ParameterCondition3.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_ParameterCondition3.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_ParameterCondition3.Size = New System.Drawing.Size(172, 20)
        Me.RadDropDownList_ParameterCondition3.TabIndex = 172
        '
        'RadTextBox_ParameterValue3
        '
        Me.RadTextBox_ParameterValue3.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_ParameterValue3.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_ParameterValue3.Location = New System.Drawing.Point(102, 134)
        Me.RadTextBox_ParameterValue3.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_ParameterValue3.Name = "RadTextBox_ParameterValue3"
        '
        '
        '
        Me.RadTextBox_ParameterValue3.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_ParameterValue3.Size = New System.Drawing.Size(45, 20)
        Me.RadTextBox_ParameterValue3.TabIndex = 171
        Me.RadTextBox_ParameterValue3.Text = "0"
        Me.RadTextBox_ParameterValue3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadDropDownList_ParameterCondition2
        '
        Me.RadDropDownList_ParameterCondition2.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_ParameterCondition2.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadDropDownList_ParameterCondition2.Location = New System.Drawing.Point(149, 109)
        Me.RadDropDownList_ParameterCondition2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_ParameterCondition2.Name = "RadDropDownList_ParameterCondition2"
        '
        '
        '
        Me.RadDropDownList_ParameterCondition2.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_ParameterCondition2.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_ParameterCondition2.Size = New System.Drawing.Size(172, 20)
        Me.RadDropDownList_ParameterCondition2.TabIndex = 170
        Me.RadDropDownList_ParameterCondition2.Text = "m'Ohms MAX @ 10 KHZ,20°C"
        '
        'RadTextBox_ParameterValue2
        '
        Me.RadTextBox_ParameterValue2.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_ParameterValue2.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_ParameterValue2.Location = New System.Drawing.Point(102, 109)
        Me.RadTextBox_ParameterValue2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_ParameterValue2.Name = "RadTextBox_ParameterValue2"
        '
        '
        '
        Me.RadTextBox_ParameterValue2.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_ParameterValue2.Size = New System.Drawing.Size(45, 20)
        Me.RadTextBox_ParameterValue2.TabIndex = 169
        Me.RadTextBox_ParameterValue2.Text = "88"
        Me.RadTextBox_ParameterValue2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadCheckBox_ac
        '
        Me.RadCheckBox_ac.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadCheckBox_ac.AutoSize = false
        Me.RadCheckBox_ac.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_ac.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadCheckBox_ac.Location = New System.Drawing.Point(369, 159)
        Me.RadCheckBox_ac.Name = "RadCheckBox_ac"
        Me.RadCheckBox_ac.Size = New System.Drawing.Size(35, 20)
        Me.RadCheckBox_ac.TabIndex = 168
        Me.RadCheckBox_ac.Text = "ScratchP_ac"
        Me.RadCheckBox_ac.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_TestVolts
        '
        Me.RadTextBox_TestVolts.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_TestVolts.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_TestVolts.Location = New System.Drawing.Point(323, 159)
        Me.RadTextBox_TestVolts.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_TestVolts.Name = "RadTextBox_TestVolts"
        '
        '
        '
        Me.RadTextBox_TestVolts.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_TestVolts.Size = New System.Drawing.Size(45, 20)
        Me.RadTextBox_TestVolts.TabIndex = 167
        Me.RadTextBox_TestVolts.Text = "450"
        Me.RadTextBox_TestVolts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadDropDownList_ParameterCondition1
        '
        Me.RadDropDownList_ParameterCondition1.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_ParameterCondition1.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadDropDownList_ParameterCondition1.Location = New System.Drawing.Point(149, 84)
        Me.RadDropDownList_ParameterCondition1.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_ParameterCondition1.Name = "RadDropDownList_ParameterCondition1"
        '
        '
        '
        Me.RadDropDownList_ParameterCondition1.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_ParameterCondition1.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_ParameterCondition1.Size = New System.Drawing.Size(172, 20)
        Me.RadDropDownList_ParameterCondition1.TabIndex = 166
        Me.RadDropDownList_ParameterCondition1.Text = "m'Ohms MAX @ 10 KHZ,20°C"
        '
        'RadTextBox_ParameterValue1
        '
        Me.RadTextBox_ParameterValue1.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_ParameterValue1.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_ParameterValue1.Location = New System.Drawing.Point(102, 84)
        Me.RadTextBox_ParameterValue1.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_ParameterValue1.Name = "RadTextBox_ParameterValue1"
        '
        '
        '
        Me.RadTextBox_ParameterValue1.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_ParameterValue1.Size = New System.Drawing.Size(45, 20)
        Me.RadTextBox_ParameterValue1.TabIndex = 165
        Me.RadTextBox_ParameterValue1.Text = "145"
        Me.RadTextBox_ParameterValue1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadDropDownList_Parameter4
        '
        Me.RadDropDownList_Parameter4.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Parameter4.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadDropDownList_Parameter4.Location = New System.Drawing.Point(10, 159)
        Me.RadDropDownList_Parameter4.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Parameter4.Name = "RadDropDownList_Parameter4"
        '
        '
        '
        Me.RadDropDownList_Parameter4.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Parameter4.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Parameter4.Size = New System.Drawing.Size(90, 20)
        Me.RadDropDownList_Parameter4.TabIndex = 164
        Me.RadDropDownList_Parameter4.Text = "DC LEAKAGE"
        '
        'RadDropDownList_Parameter3
        '
        Me.RadDropDownList_Parameter3.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Parameter3.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadDropDownList_Parameter3.Location = New System.Drawing.Point(10, 134)
        Me.RadDropDownList_Parameter3.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Parameter3.Name = "RadDropDownList_Parameter3"
        '
        '
        '
        Me.RadDropDownList_Parameter3.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Parameter3.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Parameter3.Size = New System.Drawing.Size(90, 20)
        Me.RadDropDownList_Parameter3.TabIndex = 163
        '
        'RadDropDownList_Parameter2
        '
        Me.RadDropDownList_Parameter2.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Parameter2.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadDropDownList_Parameter2.Location = New System.Drawing.Point(10, 109)
        Me.RadDropDownList_Parameter2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Parameter2.Name = "RadDropDownList_Parameter2"
        '
        '
        '
        Me.RadDropDownList_Parameter2.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Parameter2.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Parameter2.Size = New System.Drawing.Size(90, 20)
        Me.RadDropDownList_Parameter2.TabIndex = 162
        Me.RadDropDownList_Parameter2.Text = "IMPEDANCE"
        '
        'RadLabel_MicroFarad4
        '
        Me.RadLabel_MicroFarad4.AutoSize = false
        Me.RadLabel_MicroFarad4.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_MicroFarad4.Location = New System.Drawing.Point(250, 26)
        Me.RadLabel_MicroFarad4.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_MicroFarad4.Name = "RadLabel_MicroFarad4"
        Me.RadLabel_MicroFarad4.Size = New System.Drawing.Size(25, 20)
        Me.RadLabel_MicroFarad4.TabIndex = 161
        Me.RadLabel_MicroFarad4.Text = "Units_MicroFarad"
        Me.RadLabel_MicroFarad4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadTextBox_Capacitance2
        '
        Me.RadTextBox_Capacitance2.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Capacitance2.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Capacitance2.Location = New System.Drawing.Point(196, 26)
        Me.RadTextBox_Capacitance2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_Capacitance2.Name = "RadTextBox_Capacitance2"
        '
        '
        '
        Me.RadTextBox_Capacitance2.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Capacitance2.Size = New System.Drawing.Size(54, 20)
        Me.RadTextBox_Capacitance2.TabIndex = 160
        Me.RadTextBox_Capacitance2.Text = "656"
        Me.RadTextBox_Capacitance2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_to
        '
        Me.RadLabel_to.AutoSize = false
        Me.RadLabel_to.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_to.Location = New System.Drawing.Point(170, 26)
        Me.RadLabel_to.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_to.Name = "RadLabel_to"
        Me.RadLabel_to.Size = New System.Drawing.Size(25, 20)
        Me.RadLabel_to.TabIndex = 159
        Me.RadLabel_to.Text = "Global_to"
        Me.RadLabel_to.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_MicroFarad3
        '
        Me.RadLabel_MicroFarad3.AutoSize = false
        Me.RadLabel_MicroFarad3.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_MicroFarad3.Location = New System.Drawing.Point(145, 26)
        Me.RadLabel_MicroFarad3.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_MicroFarad3.Name = "RadLabel_MicroFarad3"
        Me.RadLabel_MicroFarad3.Size = New System.Drawing.Size(25, 20)
        Me.RadLabel_MicroFarad3.TabIndex = 158
        Me.RadLabel_MicroFarad3.Text = "Units_MicroFarad"
        Me.RadLabel_MicroFarad3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_Capacitance
        '
        Me.RadTextBox_Capacitance.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Capacitance.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Capacitance.Location = New System.Drawing.Point(91, 26)
        Me.RadTextBox_Capacitance.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_Capacitance.Name = "RadTextBox_Capacitance"
        '
        '
        '
        Me.RadTextBox_Capacitance.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Capacitance.Size = New System.Drawing.Size(54, 20)
        Me.RadTextBox_Capacitance.TabIndex = 157
        Me.RadTextBox_Capacitance.Text = "656"
        Me.RadTextBox_Capacitance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_Capacitance
        '
        Me.RadLabel_Capacitance.AutoSize = false
        Me.RadLabel_Capacitance.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Capacitance.Location = New System.Drawing.Point(2, 26)
        Me.RadLabel_Capacitance.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Capacitance.Name = "RadLabel_Capacitance"
        Me.RadLabel_Capacitance.Size = New System.Drawing.Size(85, 20)
        Me.RadLabel_Capacitance.TabIndex = 156
        Me.RadLabel_Capacitance.Text = "ScratchP_Capacitance"
        Me.RadLabel_Capacitance.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadDropDownList_Parameter1
        '
        Me.RadDropDownList_Parameter1.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Parameter1.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadDropDownList_Parameter1.Location = New System.Drawing.Point(10, 84)
        Me.RadDropDownList_Parameter1.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Parameter1.Name = "RadDropDownList_Parameter1"
        '
        '
        '
        Me.RadDropDownList_Parameter1.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Parameter1.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Parameter1.Size = New System.Drawing.Size(90, 20)
        Me.RadDropDownList_Parameter1.TabIndex = 153
        Me.RadDropDownList_Parameter1.Text = "ESR"
        '
        'RadButton_GetLimits
        '
        Me.RadButton_GetLimits.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_GetLimits.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_GetLimits.ForeColor = System.Drawing.Color.Black
        Me.RadButton_GetLimits.Location = New System.Drawing.Point(128, 3)
        Me.RadButton_GetLimits.Name = "RadButton_GetLimits"
        Me.RadButton_GetLimits.Size = New System.Drawing.Size(77, 20)
        Me.RadButton_GetLimits.TabIndex = 152
        Me.RadButton_GetLimits.Text = "ScratchP_GetLimits"
        Me.RadButton_GetLimits.TextWrap = true
        '
        'RadButton_TestParameters
        '
        Me.RadButton_TestParameters.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_TestParameters.Enabled = false
        Me.RadButton_TestParameters.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_TestParameters.ForeColor = System.Drawing.Color.Black
        Me.RadButton_TestParameters.Location = New System.Drawing.Point(2, 3)
        Me.RadButton_TestParameters.Name = "RadButton_TestParameters"
        Me.RadButton_TestParameters.Size = New System.Drawing.Size(102, 20)
        Me.RadButton_TestParameters.TabIndex = 151
        Me.RadButton_TestParameters.Text = "ScratchP_TestParameters"
        Me.RadButton_TestParameters.TextWrap = true
        '
        'Panel_Cathode
        '
        Me.Panel_Cathode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Cathode.Controls.Add(Me.RadTextBox_CathodeCost)
        Me.Panel_Cathode.Controls.Add(Me.RadCheckBox_Swage)
        Me.Panel_Cathode.Controls.Add(Me.RadLabel_Swage)
        Me.Panel_Cathode.Controls.Add(Me.RadLabel_Mm4)
        Me.Panel_Cathode.Controls.Add(Me.RadTextBox_CathExtension)
        Me.Panel_Cathode.Controls.Add(Me.RadLabel_CathExtension)
        Me.Panel_Cathode.Controls.Add(Me.RadDropDownList_CathodeVf)
        Me.Panel_Cathode.Controls.Add(Me.RadTextBox_CathodeAmount)
        Me.Panel_Cathode.Controls.Add(Me.RadDropDownList_CathodeWidth)
        Me.Panel_Cathode.Controls.Add(Me.RadLabel_Cath)
        Me.Panel_Cathode.Controls.Add(Me.RadDropDownList_Cathode)
        Me.Panel_Cathode.Location = New System.Drawing.Point(2, 105)
        Me.Panel_Cathode.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Cathode.MinimumSize = New System.Drawing.Size(731, 31)
        Me.Panel_Cathode.Name = "Panel_Cathode"
        Me.Panel_Cathode.Size = New System.Drawing.Size(731, 31)
        Me.Panel_Cathode.TabIndex = 10
        '
        'RadTextBox_CathodeCost
        '
        Me.RadTextBox_CathodeCost.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_CathodeCost.Enabled = false
        Me.RadTextBox_CathodeCost.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_CathodeCost.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_CathodeCost.Location = New System.Drawing.Point(340, 3)
        Me.RadTextBox_CathodeCost.Name = "RadTextBox_CathodeCost"
        '
        '
        '
        Me.RadTextBox_CathodeCost.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_CathodeCost.Size = New System.Drawing.Size(36, 20)
        Me.RadTextBox_CathodeCost.TabIndex = 85
        Me.RadTextBox_CathodeCost.Text = "0"
        Me.RadTextBox_CathodeCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadCheckBox_Swage
        '
        Me.RadCheckBox_Swage.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadCheckBox_Swage.AutoSize = false
        Me.RadCheckBox_Swage.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadCheckBox_Swage.Location = New System.Drawing.Point(650, 3)
        Me.RadCheckBox_Swage.Name = "RadCheckBox_Swage"
        Me.RadCheckBox_Swage.Size = New System.Drawing.Size(20, 20)
        Me.RadCheckBox_Swage.TabIndex = 84
        '
        'RadLabel_Swage
        '
        Me.RadLabel_Swage.AutoSize = false
        Me.RadLabel_Swage.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_Swage.Location = New System.Drawing.Point(588, 3)
        Me.RadLabel_Swage.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Swage.Name = "RadLabel_Swage"
        Me.RadLabel_Swage.Size = New System.Drawing.Size(59, 20)
        Me.RadLabel_Swage.TabIndex = 83
        Me.RadLabel_Swage.Text = "ScratchP_Swage"
        Me.RadLabel_Swage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadLabel_Mm4
        '
        Me.RadLabel_Mm4.AutoSize = false
        Me.RadLabel_Mm4.Font = New System.Drawing.Font("Segoe UI", 7!)
        Me.RadLabel_Mm4.Location = New System.Drawing.Point(553, 3)
        Me.RadLabel_Mm4.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Mm4.Name = "RadLabel_Mm4"
        Me.RadLabel_Mm4.Size = New System.Drawing.Size(30, 20)
        Me.RadLabel_Mm4.TabIndex = 82
        Me.RadLabel_Mm4.Text = "Units_Mm"
        Me.RadLabel_Mm4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadTextBox_CathExtension
        '
        Me.RadTextBox_CathExtension.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_CathExtension.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_CathExtension.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_CathExtension.Location = New System.Drawing.Point(522, 3)
        Me.RadTextBox_CathExtension.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_CathExtension.Name = "RadTextBox_CathExtension"
        '
        '
        '
        Me.RadTextBox_CathExtension.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_CathExtension.Size = New System.Drawing.Size(30, 20)
        Me.RadTextBox_CathExtension.TabIndex = 80
        Me.RadTextBox_CathExtension.Text = "0"
        Me.RadTextBox_CathExtension.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel_CathExtension
        '
        Me.RadLabel_CathExtension.AutoSize = false
        Me.RadLabel_CathExtension.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_CathExtension.Location = New System.Drawing.Point(407, 3)
        Me.RadLabel_CathExtension.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_CathExtension.Name = "RadLabel_CathExtension"
        Me.RadLabel_CathExtension.Size = New System.Drawing.Size(110, 20)
        Me.RadLabel_CathExtension.TabIndex = 79
        Me.RadLabel_CathExtension.Text = "ScratchP_CathExtension"
        Me.RadLabel_CathExtension.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadDropDownList_CathodeVf
        '
        Me.RadDropDownList_CathodeVf.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_CathodeVf.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_CathodeVf.Location = New System.Drawing.Point(154, 2)
        Me.RadDropDownList_CathodeVf.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_CathodeVf.MinimumSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_CathodeVf.Name = "RadDropDownList_CathodeVf"
        '
        '
        '
        Me.RadDropDownList_CathodeVf.RootElement.MinSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_CathodeVf.Size = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_CathodeVf.TabIndex = 72
        Me.RadDropDownList_CathodeVf.Text = "590"
        Me.RadDropDownList_CathodeVf.Visible = false
        '
        'RadTextBox_CathodeAmount
        '
        Me.RadTextBox_CathodeAmount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_CathodeAmount.Enabled = false
        Me.RadTextBox_CathodeAmount.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_CathodeAmount.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_CathodeAmount.Location = New System.Drawing.Point(285, 3)
        Me.RadTextBox_CathodeAmount.MinimumSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_CathodeAmount.Name = "RadTextBox_CathodeAmount"
        '
        '
        '
        Me.RadTextBox_CathodeAmount.RootElement.MinSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_CathodeAmount.Size = New System.Drawing.Size(48, 20)
        Me.RadTextBox_CathodeAmount.TabIndex = 71
        Me.RadTextBox_CathodeAmount.Text = "2,705"
        Me.RadTextBox_CathodeAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadDropDownList_CathodeWidth
        '
        Me.RadDropDownList_CathodeWidth.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadDropDownList_CathodeWidth.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_CathodeWidth.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_CathodeWidth.Location = New System.Drawing.Point(214, 2)
        Me.RadDropDownList_CathodeWidth.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_CathodeWidth.MinimumSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_CathodeWidth.Name = "RadDropDownList_CathodeWidth"
        '
        '
        '
        Me.RadDropDownList_CathodeWidth.RootElement.MinSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_CathodeWidth.Size = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_CathodeWidth.TabIndex = 67
        Me.RadDropDownList_CathodeWidth.Text = "198"
        '
        'RadLabel_Cath
        '
        Me.RadLabel_Cath.AutoSize = false
        Me.RadLabel_Cath.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Cath.Location = New System.Drawing.Point(2, 1)
        Me.RadLabel_Cath.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Cath.Name = "RadLabel_Cath"
        Me.RadLabel_Cath.Size = New System.Drawing.Size(42, 25)
        Me.RadLabel_Cath.TabIndex = 55
        Me.RadLabel_Cath.Text = "ScratchP_Cath"
        Me.RadLabel_Cath.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadDropDownList_Cathode
        '
        Me.RadDropDownList_Cathode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadDropDownList_Cathode.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Cathode.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Cathode.Location = New System.Drawing.Point(48, 2)
        Me.RadDropDownList_Cathode.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Cathode.MinimumSize = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Cathode.Name = "RadDropDownList_Cathode"
        '
        '
        '
        Me.RadDropDownList_Cathode.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Cathode.RootElement.MinSize = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Cathode.Size = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Cathode.TabIndex = 62
        Me.RadDropDownList_Cathode.Text = "K204"
        '
        'Panel_Notes
        '
        Me.Panel_Notes.BackColor = System.Drawing.Color.Silver
        Me.Panel_Notes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Notes.Controls.Add(Me.RadDropDownList_Note3)
        Me.Panel_Notes.Controls.Add(Me.RadDropDownList_Note3Type)
        Me.Panel_Notes.Controls.Add(Me.RadDropDownList_Note2)
        Me.Panel_Notes.Controls.Add(Me.RadTextBox_Note3)
        Me.Panel_Notes.Controls.Add(Me.RadDropDownList_Note2Type)
        Me.Panel_Notes.Controls.Add(Me.RadTextBox_Note2)
        Me.Panel_Notes.Controls.Add(Me.RadDropDownList_Note1)
        Me.Panel_Notes.Controls.Add(Me.RadLabel_Note)
        Me.Panel_Notes.Controls.Add(Me.RadLabel_NoteType)
        Me.Panel_Notes.Controls.Add(Me.RadDropDownList_Note1Type)
        Me.Panel_Notes.Controls.Add(Me.RadTextBox_Note1)
        Me.Panel_Notes.Controls.Add(Me.RadLabel_Sequence)
        Me.Panel_Notes.Controls.Add(Me.RadButton_ArrowRight)
        Me.Panel_Notes.Controls.Add(Me.Panel_NotesLanguages)
        Me.Panel_Notes.Controls.Add(Me.RadButton_NotesMax10escroutnotes)
        Me.Panel_Notes.Location = New System.Drawing.Point(2, 747)
        Me.Panel_Notes.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Panel_Notes.Name = "Panel_Notes"
        Me.Panel_Notes.Size = New System.Drawing.Size(418, 292)
        Me.Panel_Notes.TabIndex = 17
        '
        'RadDropDownList_Note3
        '
        Me.RadDropDownList_Note3.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Note3.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadDropDownList_Note3.Location = New System.Drawing.Point(190, 106)
        Me.RadDropDownList_Note3.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Note3.Name = "RadDropDownList_Note3"
        '
        '
        '
        Me.RadDropDownList_Note3.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Note3.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Note3.Size = New System.Drawing.Size(220, 20)
        Me.RadDropDownList_Note3.TabIndex = 187
        Me.RadDropDownList_Note3.Text = "ALIGN SLEEVE LINE WITH NEG TAG"
        '
        'RadDropDownList_Note3Type
        '
        Me.RadDropDownList_Note3Type.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Note3Type.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadDropDownList_Note3Type.Location = New System.Drawing.Point(90, 106)
        Me.RadDropDownList_Note3Type.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Note3Type.Name = "RadDropDownList_Note3Type"
        '
        '
        '
        Me.RadDropDownList_Note3Type.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Note3Type.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Note3Type.Size = New System.Drawing.Size(85, 20)
        Me.RadDropDownList_Note3Type.TabIndex = 186
        Me.RadDropDownList_Note3Type.Text = "Routing"
        '
        'RadDropDownList_Note2
        '
        Me.RadDropDownList_Note2.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Note2.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadDropDownList_Note2.Location = New System.Drawing.Point(190, 76)
        Me.RadDropDownList_Note2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Note2.Name = "RadDropDownList_Note2"
        '
        '
        '
        Me.RadDropDownList_Note2.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Note2.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Note2.Size = New System.Drawing.Size(220, 20)
        Me.RadDropDownList_Note2.TabIndex = 187
        Me.RadDropDownList_Note2.Text = "ALIGN SLEEVE LINE WITH NEG TAG"
        '
        'RadTextBox_Note3
        '
        Me.RadTextBox_Note3.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_Note3.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Note3.Location = New System.Drawing.Point(12, 106)
        Me.RadTextBox_Note3.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_Note3.Name = "RadTextBox_Note3"
        '
        '
        '
        Me.RadTextBox_Note3.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Note3.Size = New System.Drawing.Size(60, 20)
        Me.RadTextBox_Note3.TabIndex = 185
        Me.RadTextBox_Note3.Text = "160"
        Me.RadTextBox_Note3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadDropDownList_Note2Type
        '
        Me.RadDropDownList_Note2Type.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Note2Type.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadDropDownList_Note2Type.Location = New System.Drawing.Point(90, 76)
        Me.RadDropDownList_Note2Type.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Note2Type.Name = "RadDropDownList_Note2Type"
        '
        '
        '
        Me.RadDropDownList_Note2Type.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Note2Type.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Note2Type.Size = New System.Drawing.Size(85, 20)
        Me.RadDropDownList_Note2Type.TabIndex = 186
        Me.RadDropDownList_Note2Type.Text = "Finishing"
        '
        'RadTextBox_Note2
        '
        Me.RadTextBox_Note2.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_Note2.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Note2.Location = New System.Drawing.Point(12, 76)
        Me.RadTextBox_Note2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_Note2.Name = "RadTextBox_Note2"
        '
        '
        '
        Me.RadTextBox_Note2.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Note2.Size = New System.Drawing.Size(60, 20)
        Me.RadTextBox_Note2.TabIndex = 185
        Me.RadTextBox_Note2.Text = "70"
        Me.RadTextBox_Note2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadDropDownList_Note1
        '
        Me.RadDropDownList_Note1.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Note1.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadDropDownList_Note1.Location = New System.Drawing.Point(190, 47)
        Me.RadDropDownList_Note1.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Note1.Name = "RadDropDownList_Note1"
        '
        '
        '
        Me.RadDropDownList_Note1.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Note1.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Note1.Size = New System.Drawing.Size(220, 20)
        Me.RadDropDownList_Note1.TabIndex = 184
        Me.RadDropDownList_Note1.Text = "WELD TABS TO DECK"
        '
        'RadLabel_Note
        '
        Me.RadLabel_Note.AutoSize = false
        Me.RadLabel_Note.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Note.Location = New System.Drawing.Point(190, 27)
        Me.RadLabel_Note.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Note.Name = "RadLabel_Note"
        Me.RadLabel_Note.Size = New System.Drawing.Size(220, 20)
        Me.RadLabel_Note.TabIndex = 170
        Me.RadLabel_Note.Text = "Global_Note"
        Me.RadLabel_Note.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_NoteType
        '
        Me.RadLabel_NoteType.AutoSize = false
        Me.RadLabel_NoteType.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_NoteType.Location = New System.Drawing.Point(90, 27)
        Me.RadLabel_NoteType.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_NoteType.Name = "RadLabel_NoteType"
        Me.RadLabel_NoteType.Size = New System.Drawing.Size(85, 20)
        Me.RadLabel_NoteType.TabIndex = 169
        Me.RadLabel_NoteType.Text = "Global_Type"
        Me.RadLabel_NoteType.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadDropDownList_Note1Type
        '
        Me.RadDropDownList_Note1Type.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Note1Type.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadDropDownList_Note1Type.Location = New System.Drawing.Point(90, 47)
        Me.RadDropDownList_Note1Type.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Note1Type.Name = "RadDropDownList_Note1Type"
        '
        '
        '
        Me.RadDropDownList_Note1Type.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Note1Type.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Note1Type.Size = New System.Drawing.Size(85, 20)
        Me.RadDropDownList_Note1Type.TabIndex = 183
        Me.RadDropDownList_Note1Type.Text = "Assembly"
        '
        'RadTextBox_Note1
        '
        Me.RadTextBox_Note1.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadTextBox_Note1.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Note1.Location = New System.Drawing.Point(12, 47)
        Me.RadTextBox_Note1.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_Note1.Name = "RadTextBox_Note1"
        '
        '
        '
        Me.RadTextBox_Note1.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Note1.Size = New System.Drawing.Size(60, 20)
        Me.RadTextBox_Note1.TabIndex = 182
        Me.RadTextBox_Note1.Text = "10"
        Me.RadTextBox_Note1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_Sequence
        '
        Me.RadLabel_Sequence.AutoSize = false
        Me.RadLabel_Sequence.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Sequence.Location = New System.Drawing.Point(2, 27)
        Me.RadLabel_Sequence.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Sequence.Name = "RadLabel_Sequence"
        Me.RadLabel_Sequence.Size = New System.Drawing.Size(80, 20)
        Me.RadLabel_Sequence.TabIndex = 168
        Me.RadLabel_Sequence.Text = "ScratchP_Sequence"
        Me.RadLabel_Sequence.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadButton_ArrowRight
        '
        Me.RadButton_ArrowRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_ArrowRight.Font = New System.Drawing.Font("Wingdings", 18!, System.Drawing.FontStyle.Bold)
        Me.RadButton_ArrowRight.ForeColor = System.Drawing.Color.Black
        Me.RadButton_ArrowRight.Location = New System.Drawing.Point(381, 2)
        Me.RadButton_ArrowRight.Name = "RadButton_ArrowRight"
        Me.RadButton_ArrowRight.Size = New System.Drawing.Size(31, 25)
        Me.RadButton_ArrowRight.TabIndex = 155
        Me.RadButton_ArrowRight.Text = "ð"
        Me.RadButton_ArrowRight.TextWrap = true
        '
        'Panel_NotesLanguages
        '
        Me.Panel_NotesLanguages.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_NotesLanguages.Controls.Add(Me.RadioButton_English)
        Me.Panel_NotesLanguages.Controls.Add(Me.RadioButton_Spanish)
        Me.Panel_NotesLanguages.Location = New System.Drawing.Point(235, 2)
        Me.Panel_NotesLanguages.Name = "Panel_NotesLanguages"
        Me.Panel_NotesLanguages.Size = New System.Drawing.Size(143, 25)
        Me.Panel_NotesLanguages.TabIndex = 154
        '
        'RadioButton_English
        '
        Me.RadioButton_English.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton_English.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadioButton_English.Location = New System.Drawing.Point(1, 2)
        Me.RadioButton_English.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton_English.Name = "RadioButton_English"
        Me.RadioButton_English.Size = New System.Drawing.Size(70, 17)
        Me.RadioButton_English.TabIndex = 157
        Me.RadioButton_English.TabStop = true
        Me.RadioButton_English.Text = "Global_English"
        Me.RadioButton_English.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton_English.UseVisualStyleBackColor = true
        '
        'RadioButton_Spanish
        '
        Me.RadioButton_Spanish.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton_Spanish.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadioButton_Spanish.Location = New System.Drawing.Point(68, 2)
        Me.RadioButton_Spanish.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton_Spanish.Name = "RadioButton_Spanish"
        Me.RadioButton_Spanish.Size = New System.Drawing.Size(70, 17)
        Me.RadioButton_Spanish.TabIndex = 156
        Me.RadioButton_Spanish.TabStop = true
        Me.RadioButton_Spanish.Text = "Global_Spanish"
        Me.RadioButton_Spanish.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton_Spanish.UseVisualStyleBackColor = true
        '
        'RadButton_NotesMax10escroutnotes
        '
        Me.RadButton_NotesMax10escroutnotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_NotesMax10escroutnotes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_NotesMax10escroutnotes.ForeColor = System.Drawing.Color.Black
        Me.RadButton_NotesMax10escroutnotes.Location = New System.Drawing.Point(2, 4)
        Me.RadButton_NotesMax10escroutnotes.Name = "RadButton_NotesMax10escroutnotes"
        Me.RadButton_NotesMax10escroutnotes.Size = New System.Drawing.Size(230, 20)
        Me.RadButton_NotesMax10escroutnotes.TabIndex = 153
        Me.RadButton_NotesMax10escroutnotes.Text = "ScratchP_NotesMax10escroutnotes"
        Me.RadButton_NotesMax10escroutnotes.TextWrap = true
        '
        'Panel_TopRight
        '
        Me.Panel_TopRight.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Panel_TopRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_TopRight.Controls.Add(Me.RadLabel_SpecDrawing)
        Me.Panel_TopRight.Controls.Add(Me.RadDropDownList_WindingPicture)
        Me.Panel_TopRight.Controls.Add(Me.RadLabel_DimensionDwg)
        Me.Panel_TopRight.Controls.Add(Me.RadLabel_WindingPicture)
        Me.Panel_TopRight.Controls.Add(Me.RadLabel_Routing)
        Me.Panel_TopRight.Controls.Add(Me.RadLabel_PartsFile)
        Me.Panel_TopRight.Controls.Add(Me.RadDropDownList_SpecDrawing)
        Me.Panel_TopRight.Controls.Add(Me.RadDropDownList_PartsFile)
        Me.Panel_TopRight.Controls.Add(Me.RadDropDownList_DimensionDwg)
        Me.Panel_TopRight.Controls.Add(Me.RadDropDownList_Routing)
        Me.Panel_TopRight.Location = New System.Drawing.Point(736, 2)
        Me.Panel_TopRight.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_TopRight.MaximumSize = New System.Drawing.Size(252, 134)
        Me.Panel_TopRight.MinimumSize = New System.Drawing.Size(237, 134)
        Me.Panel_TopRight.Name = "Panel_TopRight"
        Me.Panel_TopRight.Size = New System.Drawing.Size(237, 134)
        Me.Panel_TopRight.TabIndex = 10
        '
        'RadLabel_SpecDrawing
        '
        Me.RadLabel_SpecDrawing.AutoSize = false
        Me.RadLabel_SpecDrawing.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_SpecDrawing.Location = New System.Drawing.Point(0, 104)
        Me.RadLabel_SpecDrawing.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_SpecDrawing.Name = "RadLabel_SpecDrawing"
        Me.RadLabel_SpecDrawing.Size = New System.Drawing.Size(96, 21)
        Me.RadLabel_SpecDrawing.TabIndex = 52
        Me.RadLabel_SpecDrawing.Text = "ScratchP_SpecDrawing"
        Me.RadLabel_SpecDrawing.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadDropDownList_WindingPicture
        '
        Me.RadDropDownList_WindingPicture.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.RadDropDownList_WindingPicture.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_WindingPicture.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_WindingPicture.Location = New System.Drawing.Point(104, 54)
        Me.RadDropDownList_WindingPicture.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_WindingPicture.Name = "RadDropDownList_WindingPicture"
        '
        '
        '
        Me.RadDropDownList_WindingPicture.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_WindingPicture.Size = New System.Drawing.Size(127, 21)
        Me.RadDropDownList_WindingPicture.TabIndex = 13
        Me.RadDropDownList_WindingPicture.Text = "ALSE4"
        '
        'RadLabel_DimensionDwg
        '
        Me.RadLabel_DimensionDwg.AutoSize = false
        Me.RadLabel_DimensionDwg.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_DimensionDwg.Location = New System.Drawing.Point(0, 80)
        Me.RadLabel_DimensionDwg.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_DimensionDwg.Name = "RadLabel_DimensionDwg"
        Me.RadLabel_DimensionDwg.Size = New System.Drawing.Size(96, 20)
        Me.RadLabel_DimensionDwg.TabIndex = 51
        Me.RadLabel_DimensionDwg.Text = "ScratchP_DimensionDwg"
        Me.RadLabel_DimensionDwg.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_WindingPicture
        '
        Me.RadLabel_WindingPicture.AutoSize = false
        Me.RadLabel_WindingPicture.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_WindingPicture.Location = New System.Drawing.Point(0, 55)
        Me.RadLabel_WindingPicture.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_WindingPicture.Name = "RadLabel_WindingPicture"
        Me.RadLabel_WindingPicture.Size = New System.Drawing.Size(96, 20)
        Me.RadLabel_WindingPicture.TabIndex = 50
        Me.RadLabel_WindingPicture.Text = "ScratchP_WindingPicture"
        Me.RadLabel_WindingPicture.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_Routing
        '
        Me.RadLabel_Routing.AutoSize = false
        Me.RadLabel_Routing.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Routing.Location = New System.Drawing.Point(0, 30)
        Me.RadLabel_Routing.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Routing.Name = "RadLabel_Routing"
        Me.RadLabel_Routing.Size = New System.Drawing.Size(96, 20)
        Me.RadLabel_Routing.TabIndex = 48
        Me.RadLabel_Routing.Text = "ScratchP_Routing"
        Me.RadLabel_Routing.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_PartsFile
        '
        Me.RadLabel_PartsFile.AutoSize = false
        Me.RadLabel_PartsFile.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_PartsFile.Location = New System.Drawing.Point(0, 5)
        Me.RadLabel_PartsFile.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_PartsFile.Name = "RadLabel_PartsFile"
        Me.RadLabel_PartsFile.Size = New System.Drawing.Size(96, 20)
        Me.RadLabel_PartsFile.TabIndex = 49
        Me.RadLabel_PartsFile.Text = "ScratchP_PartsFile"
        Me.RadLabel_PartsFile.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadDropDownList_SpecDrawing
        '
        Me.RadDropDownList_SpecDrawing.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.RadDropDownList_SpecDrawing.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_SpecDrawing.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_SpecDrawing.Location = New System.Drawing.Point(104, 104)
        Me.RadDropDownList_SpecDrawing.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_SpecDrawing.Name = "RadDropDownList_SpecDrawing"
        '
        '
        '
        Me.RadDropDownList_SpecDrawing.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_SpecDrawing.Size = New System.Drawing.Size(127, 21)
        Me.RadDropDownList_SpecDrawing.TabIndex = 15
        Me.RadDropDownList_SpecDrawing.Text = "ALCASPEC"
        '
        'RadDropDownList_PartsFile
        '
        Me.RadDropDownList_PartsFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.RadDropDownList_PartsFile.AutoSizeItems = true
        Me.RadDropDownList_PartsFile.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_PartsFile.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_PartsFile.Location = New System.Drawing.Point(104, 4)
        Me.RadDropDownList_PartsFile.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_PartsFile.Name = "RadDropDownList_PartsFile"
        '
        '
        '
        Me.RadDropDownList_PartsFile.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_PartsFile.Size = New System.Drawing.Size(127, 21)
        Me.RadDropDownList_PartsFile.TabIndex = 80
        Me.RadDropDownList_PartsFile.Text = "ALS31AQTPR"
        '
        'RadDropDownList_DimensionDwg
        '
        Me.RadDropDownList_DimensionDwg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.RadDropDownList_DimensionDwg.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_DimensionDwg.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_DimensionDwg.Location = New System.Drawing.Point(104, 79)
        Me.RadDropDownList_DimensionDwg.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_DimensionDwg.Name = "RadDropDownList_DimensionDwg"
        '
        '
        '
        Me.RadDropDownList_DimensionDwg.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_DimensionDwg.Size = New System.Drawing.Size(127, 21)
        Me.RadDropDownList_DimensionDwg.TabIndex = 14
        Me.RadDropDownList_DimensionDwg.Text = "ALCA"
        '
        'RadDropDownList_Routing
        '
        Me.RadDropDownList_Routing.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.RadDropDownList_Routing.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Routing.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Routing.Location = New System.Drawing.Point(104, 29)
        Me.RadDropDownList_Routing.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Routing.Name = "RadDropDownList_Routing"
        '
        '
        '
        Me.RadDropDownList_Routing.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Routing.Size = New System.Drawing.Size(127, 21)
        Me.RadDropDownList_Routing.TabIndex = 13
        Me.RadDropDownList_Routing.Text = "ALSNT/90"
        '
        'Panel_Elyte
        '
        Me.Panel_Elyte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Elyte.Controls.Add(Me.RadLabel_MiniPrewrap)
        Me.Panel_Elyte.Controls.Add(Me.RadTextBox_MiniPrewrap)
        Me.Panel_Elyte.Controls.Add(Me.RadCheckBox_AutoWidth)
        Me.Panel_Elyte.Controls.Add(Me.RadTextBox_ElyteCost)
        Me.Panel_Elyte.Controls.Add(Me.RadCheckBox_Scrollbar)
        Me.Panel_Elyte.Controls.Add(Me.RadLabel_Scrollbar)
        Me.Panel_Elyte.Controls.Add(Me.RadTextBox_ElyteAmount)
        Me.Panel_Elyte.Controls.Add(Me.RadLabel_Elyte)
        Me.Panel_Elyte.Controls.Add(Me.RadDropDownList_Elyte)
        Me.Panel_Elyte.Location = New System.Drawing.Point(2, 255)
        Me.Panel_Elyte.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Elyte.MinimumSize = New System.Drawing.Size(731, 31)
        Me.Panel_Elyte.Name = "Panel_Elyte"
        Me.Panel_Elyte.Size = New System.Drawing.Size(731, 33)
        Me.Panel_Elyte.TabIndex = 13
        '
        'RadLabel_MiniPrewrap
        '
        Me.RadLabel_MiniPrewrap.AutoSize = false
        Me.RadLabel_MiniPrewrap.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_MiniPrewrap.Location = New System.Drawing.Point(407, 3)
        Me.RadLabel_MiniPrewrap.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_MiniPrewrap.Name = "RadLabel_MiniPrewrap"
        Me.RadLabel_MiniPrewrap.Size = New System.Drawing.Size(110, 20)
        Me.RadLabel_MiniPrewrap.TabIndex = 92
        Me.RadLabel_MiniPrewrap.Text = "ScratchP_MaxAt"
        Me.RadLabel_MiniPrewrap.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_MiniPrewrap
        '
        Me.RadTextBox_MiniPrewrap.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_MiniPrewrap.Enabled = false
        Me.RadTextBox_MiniPrewrap.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_MiniPrewrap.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_MiniPrewrap.Location = New System.Drawing.Point(522, 4)
        Me.RadTextBox_MiniPrewrap.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_MiniPrewrap.MinimumSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_MiniPrewrap.Name = "RadTextBox_MiniPrewrap"
        '
        '
        '
        Me.RadTextBox_MiniPrewrap.RootElement.MinSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_MiniPrewrap.Size = New System.Drawing.Size(50, 20)
        Me.RadTextBox_MiniPrewrap.TabIndex = 91
        Me.RadTextBox_MiniPrewrap.Text = "0"
        Me.RadTextBox_MiniPrewrap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadCheckBox_AutoWidth
        '
        Me.RadCheckBox_AutoWidth.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadCheckBox_AutoWidth.AutoSize = false
        Me.RadCheckBox_AutoWidth.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_AutoWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadCheckBox_AutoWidth.Location = New System.Drawing.Point(155, 3)
        Me.RadCheckBox_AutoWidth.Name = "RadCheckBox_AutoWidth"
        Me.RadCheckBox_AutoWidth.Size = New System.Drawing.Size(93, 23)
        Me.RadCheckBox_AutoWidth.TabIndex = 90
        Me.RadCheckBox_AutoWidth.Tag = ""
        Me.RadCheckBox_AutoWidth.Text = "ScratchP_AutoWidth"
        '
        'RadTextBox_ElyteCost
        '
        Me.RadTextBox_ElyteCost.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_ElyteCost.Enabled = false
        Me.RadTextBox_ElyteCost.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_ElyteCost.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_ElyteCost.Location = New System.Drawing.Point(340, 4)
        Me.RadTextBox_ElyteCost.Name = "RadTextBox_ElyteCost"
        '
        '
        '
        Me.RadTextBox_ElyteCost.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_ElyteCost.Size = New System.Drawing.Size(36, 20)
        Me.RadTextBox_ElyteCost.TabIndex = 89
        Me.RadTextBox_ElyteCost.Text = "0"
        Me.RadTextBox_ElyteCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadCheckBox_Scrollbar
        '
        Me.RadCheckBox_Scrollbar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadCheckBox_Scrollbar.AutoSize = false
        Me.RadCheckBox_Scrollbar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadCheckBox_Scrollbar.Location = New System.Drawing.Point(650, 5)
        Me.RadCheckBox_Scrollbar.Name = "RadCheckBox_Scrollbar"
        Me.RadCheckBox_Scrollbar.Size = New System.Drawing.Size(20, 20)
        Me.RadCheckBox_Scrollbar.TabIndex = 86
        '
        'RadLabel_Scrollbar
        '
        Me.RadLabel_Scrollbar.AutoSize = false
        Me.RadLabel_Scrollbar.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_Scrollbar.Location = New System.Drawing.Point(588, 5)
        Me.RadLabel_Scrollbar.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Scrollbar.Name = "RadLabel_Scrollbar"
        Me.RadLabel_Scrollbar.Size = New System.Drawing.Size(59, 20)
        Me.RadLabel_Scrollbar.TabIndex = 85
        Me.RadLabel_Scrollbar.Text = "ScratchP_Scrollbar"
        Me.RadLabel_Scrollbar.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadTextBox_ElyteAmount
        '
        Me.RadTextBox_ElyteAmount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_ElyteAmount.Enabled = false
        Me.RadTextBox_ElyteAmount.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_ElyteAmount.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_ElyteAmount.Location = New System.Drawing.Point(285, 4)
        Me.RadTextBox_ElyteAmount.MinimumSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_ElyteAmount.Name = "RadTextBox_ElyteAmount"
        '
        '
        '
        Me.RadTextBox_ElyteAmount.RootElement.MinSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_ElyteAmount.Size = New System.Drawing.Size(48, 20)
        Me.RadTextBox_ElyteAmount.TabIndex = 77
        Me.RadTextBox_ElyteAmount.Text = "2,705"
        Me.RadTextBox_ElyteAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_Elyte
        '
        Me.RadLabel_Elyte.AutoSize = false
        Me.RadLabel_Elyte.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Elyte.Location = New System.Drawing.Point(2, 1)
        Me.RadLabel_Elyte.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Elyte.Name = "RadLabel_Elyte"
        '
        '
        '
        Me.RadLabel_Elyte.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadLabel_Elyte.Size = New System.Drawing.Size(42, 25)
        Me.RadLabel_Elyte.TabIndex = 75
        Me.RadLabel_Elyte.Text = "ScratchP_Elyte"
        Me.RadLabel_Elyte.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadDropDownList_Elyte
        '
        Me.RadDropDownList_Elyte.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadDropDownList_Elyte.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Elyte.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Elyte.Location = New System.Drawing.Point(48, 3)
        Me.RadDropDownList_Elyte.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Elyte.MinimumSize = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Elyte.Name = "RadDropDownList_Elyte"
        '
        '
        '
        Me.RadDropDownList_Elyte.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Elyte.RootElement.MinSize = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Elyte.Size = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Elyte.TabIndex = 76
        Me.RadDropDownList_Elyte.Text = "HG400"
        '
        'Panel_Tissue
        '
        Me.Panel_Tissue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Tissue.Controls.Add(Me.RadTextBox_Tissue3Cost)
        Me.Panel_Tissue.Controls.Add(Me.RadTextBox_Tissue2Cost)
        Me.Panel_Tissue.Controls.Add(Me.RadTextBox_Tissue1Cost)
        Me.Panel_Tissue.Controls.Add(Me.RadCheckBox_AfterWrap)
        Me.Panel_Tissue.Controls.Add(Me.RadLabel_AfterWrap)
        Me.Panel_Tissue.Controls.Add(Me.RadLabel_PreWrapLength)
        Me.Panel_Tissue.Controls.Add(Me.RadTextBox_PreWrapLength)
        Me.Panel_Tissue.Controls.Add(Me.RadTextBox_PreWrapTurns)
        Me.Panel_Tissue.Controls.Add(Me.RadLabel_PreWrapTurns)
        Me.Panel_Tissue.Controls.Add(Me.RadTextBox_Tissue3Amount)
        Me.Panel_Tissue.Controls.Add(Me.RadTextBox_Tissue2Amount)
        Me.Panel_Tissue.Controls.Add(Me.RadDropDownList_Tissue3Width)
        Me.Panel_Tissue.Controls.Add(Me.RadDropDownList_Tissue1Width)
        Me.Panel_Tissue.Controls.Add(Me.RadDropDownList_Tissue3Vf)
        Me.Panel_Tissue.Controls.Add(Me.RadLabel_Tissue_Vertical)
        Me.Panel_Tissue.Controls.Add(Me.RadDropDownList_Tissue3)
        Me.Panel_Tissue.Controls.Add(Me.RadDropDownList_Tissue2)
        Me.Panel_Tissue.Controls.Add(Me.RadLabel_Tissue3)
        Me.Panel_Tissue.Controls.Add(Me.RadLabel_Tissue2)
        Me.Panel_Tissue.Controls.Add(Me.RadLabel_Tissue1)
        Me.Panel_Tissue.Controls.Add(Me.RadDropDownList_Tissue1)
        Me.Panel_Tissue.Controls.Add(Me.RadDropDownList_Tissue1Vf)
        Me.Panel_Tissue.Controls.Add(Me.RadDropDownList_Tissue2Width)
        Me.Panel_Tissue.Controls.Add(Me.RadTextBox_Tissue1Amount)
        Me.Panel_Tissue.Controls.Add(Me.RadDropDownList_Tissue2Vf)
        Me.Panel_Tissue.Location = New System.Drawing.Point(2, 139)
        Me.Panel_Tissue.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Tissue.MinimumSize = New System.Drawing.Size(587, 75)
        Me.Panel_Tissue.Name = "Panel_Tissue"
        Me.Panel_Tissue.Size = New System.Drawing.Size(587, 77)
        Me.Panel_Tissue.TabIndex = 11
        '
        'RadTextBox_Tissue3Cost
        '
        Me.RadTextBox_Tissue3Cost.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_Tissue3Cost.Enabled = false
        Me.RadTextBox_Tissue3Cost.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Tissue3Cost.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Tissue3Cost.Location = New System.Drawing.Point(340, 52)
        Me.RadTextBox_Tissue3Cost.Name = "RadTextBox_Tissue3Cost"
        '
        '
        '
        Me.RadTextBox_Tissue3Cost.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Tissue3Cost.Size = New System.Drawing.Size(36, 20)
        Me.RadTextBox_Tissue3Cost.TabIndex = 88
        Me.RadTextBox_Tissue3Cost.Text = "0"
        Me.RadTextBox_Tissue3Cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_Tissue2Cost
        '
        Me.RadTextBox_Tissue2Cost.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_Tissue2Cost.Enabled = false
        Me.RadTextBox_Tissue2Cost.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Tissue2Cost.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Tissue2Cost.Location = New System.Drawing.Point(340, 28)
        Me.RadTextBox_Tissue2Cost.Name = "RadTextBox_Tissue2Cost"
        '
        '
        '
        Me.RadTextBox_Tissue2Cost.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Tissue2Cost.Size = New System.Drawing.Size(36, 20)
        Me.RadTextBox_Tissue2Cost.TabIndex = 87
        Me.RadTextBox_Tissue2Cost.Text = "0"
        Me.RadTextBox_Tissue2Cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_Tissue1Cost
        '
        Me.RadTextBox_Tissue1Cost.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_Tissue1Cost.Enabled = false
        Me.RadTextBox_Tissue1Cost.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Tissue1Cost.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Tissue1Cost.Location = New System.Drawing.Point(340, 3)
        Me.RadTextBox_Tissue1Cost.Name = "RadTextBox_Tissue1Cost"
        '
        '
        '
        Me.RadTextBox_Tissue1Cost.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Tissue1Cost.Size = New System.Drawing.Size(36, 20)
        Me.RadTextBox_Tissue1Cost.TabIndex = 86
        Me.RadTextBox_Tissue1Cost.Text = "0"
        Me.RadTextBox_Tissue1Cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadCheckBox_AfterWrap
        '
        Me.RadCheckBox_AfterWrap.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadCheckBox_AfterWrap.AutoSize = false
        Me.RadCheckBox_AfterWrap.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadCheckBox_AfterWrap.Location = New System.Drawing.Point(522, 52)
        Me.RadCheckBox_AfterWrap.Name = "RadCheckBox_AfterWrap"
        Me.RadCheckBox_AfterWrap.Size = New System.Drawing.Size(20, 20)
        Me.RadCheckBox_AfterWrap.TabIndex = 82
        '
        'RadLabel_AfterWrap
        '
        Me.RadLabel_AfterWrap.AutoSize = false
        Me.RadLabel_AfterWrap.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_AfterWrap.Location = New System.Drawing.Point(407, 52)
        Me.RadLabel_AfterWrap.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_AfterWrap.Name = "RadLabel_AfterWrap"
        Me.RadLabel_AfterWrap.Size = New System.Drawing.Size(110, 20)
        Me.RadLabel_AfterWrap.TabIndex = 81
        Me.RadLabel_AfterWrap.Text = "ScratchP_AfterWrap"
        Me.RadLabel_AfterWrap.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_PreWrapLength
        '
        Me.RadLabel_PreWrapLength.AutoSize = false
        Me.RadLabel_PreWrapLength.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_PreWrapLength.Location = New System.Drawing.Point(407, 28)
        Me.RadLabel_PreWrapLength.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_PreWrapLength.Name = "RadLabel_PreWrapLength"
        Me.RadLabel_PreWrapLength.Size = New System.Drawing.Size(110, 20)
        Me.RadLabel_PreWrapLength.TabIndex = 80
        Me.RadLabel_PreWrapLength.Text = "ScratchP_PreWrapLength"
        Me.RadLabel_PreWrapLength.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadTextBox_PreWrapLength
        '
        Me.RadTextBox_PreWrapLength.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_PreWrapLength.Enabled = false
        Me.RadTextBox_PreWrapLength.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_PreWrapLength.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_PreWrapLength.Location = New System.Drawing.Point(522, 28)
        Me.RadTextBox_PreWrapLength.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_PreWrapLength.MinimumSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_PreWrapLength.Name = "RadTextBox_PreWrapLength"
        '
        '
        '
        Me.RadTextBox_PreWrapLength.RootElement.MinSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_PreWrapLength.Size = New System.Drawing.Size(50, 20)
        Me.RadTextBox_PreWrapLength.TabIndex = 79
        Me.RadTextBox_PreWrapLength.Text = "0"
        Me.RadTextBox_PreWrapLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadTextBox_PreWrapTurns
        '
        Me.RadTextBox_PreWrapTurns.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_PreWrapTurns.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_PreWrapTurns.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_PreWrapTurns.Location = New System.Drawing.Point(522, 3)
        Me.RadTextBox_PreWrapTurns.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_PreWrapTurns.MinimumSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_PreWrapTurns.Name = "RadTextBox_PreWrapTurns"
        '
        '
        '
        Me.RadTextBox_PreWrapTurns.RootElement.MinSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_PreWrapTurns.Size = New System.Drawing.Size(50, 20)
        Me.RadTextBox_PreWrapTurns.TabIndex = 78
        Me.RadTextBox_PreWrapTurns.Text = "0"
        Me.RadTextBox_PreWrapTurns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel_PreWrapTurns
        '
        Me.RadLabel_PreWrapTurns.AutoSize = false
        Me.RadLabel_PreWrapTurns.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_PreWrapTurns.Location = New System.Drawing.Point(407, 3)
        Me.RadLabel_PreWrapTurns.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_PreWrapTurns.Name = "RadLabel_PreWrapTurns"
        Me.RadLabel_PreWrapTurns.Size = New System.Drawing.Size(110, 20)
        Me.RadLabel_PreWrapTurns.TabIndex = 76
        Me.RadLabel_PreWrapTurns.Text = "ScratchP_PreWrapTurns"
        Me.RadLabel_PreWrapTurns.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadTextBox_Tissue3Amount
        '
        Me.RadTextBox_Tissue3Amount.Enabled = false
        Me.RadTextBox_Tissue3Amount.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Tissue3Amount.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Tissue3Amount.Location = New System.Drawing.Point(285, 51)
        Me.RadTextBox_Tissue3Amount.MinimumSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_Tissue3Amount.Name = "RadTextBox_Tissue3Amount"
        '
        '
        '
        Me.RadTextBox_Tissue3Amount.RootElement.MinSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_Tissue3Amount.Size = New System.Drawing.Size(48, 20)
        Me.RadTextBox_Tissue3Amount.TabIndex = 74
        Me.RadTextBox_Tissue3Amount.Text = "0"
        Me.RadTextBox_Tissue3Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_Tissue2Amount
        '
        Me.RadTextBox_Tissue2Amount.Enabled = false
        Me.RadTextBox_Tissue2Amount.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Tissue2Amount.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Tissue2Amount.Location = New System.Drawing.Point(285, 27)
        Me.RadTextBox_Tissue2Amount.MinimumSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_Tissue2Amount.Name = "RadTextBox_Tissue2Amount"
        '
        '
        '
        Me.RadTextBox_Tissue2Amount.RootElement.MinSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_Tissue2Amount.Size = New System.Drawing.Size(48, 20)
        Me.RadTextBox_Tissue2Amount.TabIndex = 73
        Me.RadTextBox_Tissue2Amount.Text = "0"
        Me.RadTextBox_Tissue2Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadDropDownList_Tissue3Width
        '
        Me.RadDropDownList_Tissue3Width.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Tissue3Width.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Tissue3Width.Location = New System.Drawing.Point(214, 49)
        Me.RadDropDownList_Tissue3Width.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Tissue3Width.MinimumSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Tissue3Width.Name = "RadDropDownList_Tissue3Width"
        '
        '
        '
        Me.RadDropDownList_Tissue3Width.RootElement.MinSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Tissue3Width.Size = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Tissue3Width.TabIndex = 72
        Me.RadDropDownList_Tissue3Width.Text = "0"
        '
        'RadDropDownList_Tissue1Width
        '
        Me.RadDropDownList_Tissue1Width.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Tissue1Width.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Tissue1Width.Location = New System.Drawing.Point(214, 1)
        Me.RadDropDownList_Tissue1Width.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Tissue1Width.MinimumSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Tissue1Width.Name = "RadDropDownList_Tissue1Width"
        '
        '
        '
        Me.RadDropDownList_Tissue1Width.RootElement.MinSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Tissue1Width.Size = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Tissue1Width.TabIndex = 71
        Me.RadDropDownList_Tissue1Width.Text = "45"
        '
        'RadDropDownList_Tissue3Vf
        '
        Me.RadDropDownList_Tissue3Vf.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Tissue3Vf.Enabled = false
        Me.RadDropDownList_Tissue3Vf.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Tissue3Vf.Location = New System.Drawing.Point(154, 49)
        Me.RadDropDownList_Tissue3Vf.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Tissue3Vf.MinimumSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Tissue3Vf.Name = "RadDropDownList_Tissue3Vf"
        '
        '
        '
        Me.RadDropDownList_Tissue3Vf.RootElement.MinSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Tissue3Vf.Size = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Tissue3Vf.TabIndex = 70
        Me.RadDropDownList_Tissue3Vf.Text = "0"
        Me.RadDropDownList_Tissue3Vf.Visible = false
        '
        'RadLabel_Tissue_Vertical
        '
        Me.RadLabel_Tissue_Vertical.AutoSize = false
        Me.RadLabel_Tissue_Vertical.Font = New System.Drawing.Font("Segoe UI", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(1,Byte), true)
        Me.RadLabel_Tissue_Vertical.Location = New System.Drawing.Point(1, 1)
        Me.RadLabel_Tissue_Vertical.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Tissue_Vertical.Name = "RadLabel_Tissue_Vertical"
        Me.RadLabel_Tissue_Vertical.Size = New System.Drawing.Size(20, 75)
        Me.RadLabel_Tissue_Vertical.TabIndex = 55
        Me.RadLabel_Tissue_Vertical.Text = "ScratchP_Tissue_Vertical"
        Me.RadLabel_Tissue_Vertical.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadDropDownList_Tissue3
        '
        Me.RadDropDownList_Tissue3.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Tissue3.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Tissue3.Location = New System.Drawing.Point(48, 49)
        Me.RadDropDownList_Tissue3.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Tissue3.MinimumSize = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Tissue3.Name = "RadDropDownList_Tissue3"
        '
        '
        '
        Me.RadDropDownList_Tissue3.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Tissue3.RootElement.MinSize = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Tissue3.Size = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Tissue3.TabIndex = 60
        Me.RadDropDownList_Tissue3.Text = "none"
        '
        'RadDropDownList_Tissue2
        '
        Me.RadDropDownList_Tissue2.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Tissue2.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Tissue2.Location = New System.Drawing.Point(48, 25)
        Me.RadDropDownList_Tissue2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Tissue2.MinimumSize = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Tissue2.Name = "RadDropDownList_Tissue2"
        '
        '
        '
        Me.RadDropDownList_Tissue2.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Tissue2.RootElement.MinSize = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Tissue2.Size = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Tissue2.TabIndex = 59
        Me.RadDropDownList_Tissue2.Text = "none"
        '
        'RadLabel_Tissue3
        '
        Me.RadLabel_Tissue3.AutoSize = false
        Me.RadLabel_Tissue3.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Tissue3.Location = New System.Drawing.Point(24, 49)
        Me.RadLabel_Tissue3.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Tissue3.Name = "RadLabel_Tissue3"
        Me.RadLabel_Tissue3.Size = New System.Drawing.Size(22, 23)
        Me.RadLabel_Tissue3.TabIndex = 58
        Me.RadLabel_Tissue3.Text = "Global_3"
        Me.RadLabel_Tissue3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_Tissue2
        '
        Me.RadLabel_Tissue2.AutoSize = false
        Me.RadLabel_Tissue2.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Tissue2.Location = New System.Drawing.Point(24, 25)
        Me.RadLabel_Tissue2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Tissue2.Name = "RadLabel_Tissue2"
        Me.RadLabel_Tissue2.Size = New System.Drawing.Size(22, 23)
        Me.RadLabel_Tissue2.TabIndex = 57
        Me.RadLabel_Tissue2.Text = "Global_2"
        Me.RadLabel_Tissue2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_Tissue1
        '
        Me.RadLabel_Tissue1.AutoSize = false
        Me.RadLabel_Tissue1.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Tissue1.Location = New System.Drawing.Point(24, 1)
        Me.RadLabel_Tissue1.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Tissue1.Name = "RadLabel_Tissue1"
        Me.RadLabel_Tissue1.Size = New System.Drawing.Size(22, 23)
        Me.RadLabel_Tissue1.TabIndex = 56
        Me.RadLabel_Tissue1.Text = "Global_1"
        Me.RadLabel_Tissue1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadDropDownList_Tissue1
        '
        Me.RadDropDownList_Tissue1.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Tissue1.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Tissue1.Location = New System.Drawing.Point(48, 1)
        Me.RadDropDownList_Tissue1.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Tissue1.MinimumSize = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Tissue1.Name = "RadDropDownList_Tissue1"
        '
        '
        '
        Me.RadDropDownList_Tissue1.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Tissue1.RootElement.MinSize = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Tissue1.Size = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Tissue1.TabIndex = 58
        Me.RadDropDownList_Tissue1.Text = "A961S"
        '
        'RadDropDownList_Tissue1Vf
        '
        Me.RadDropDownList_Tissue1Vf.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Tissue1Vf.Enabled = false
        Me.RadDropDownList_Tissue1Vf.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Tissue1Vf.Location = New System.Drawing.Point(154, 1)
        Me.RadDropDownList_Tissue1Vf.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Tissue1Vf.MinimumSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Tissue1Vf.Name = "RadDropDownList_Tissue1Vf"
        '
        '
        '
        Me.RadDropDownList_Tissue1Vf.RootElement.MinSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Tissue1Vf.Size = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Tissue1Vf.TabIndex = 68
        Me.RadDropDownList_Tissue1Vf.Text = "590"
        Me.RadDropDownList_Tissue1Vf.Visible = false
        '
        'RadDropDownList_Tissue2Width
        '
        Me.RadDropDownList_Tissue2Width.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Tissue2Width.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Tissue2Width.Location = New System.Drawing.Point(214, 25)
        Me.RadDropDownList_Tissue2Width.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Tissue2Width.MinimumSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Tissue2Width.Name = "RadDropDownList_Tissue2Width"
        '
        '
        '
        Me.RadDropDownList_Tissue2Width.RootElement.MinSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Tissue2Width.Size = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Tissue2Width.TabIndex = 66
        Me.RadDropDownList_Tissue2Width.Text = "0"
        '
        'RadTextBox_Tissue1Amount
        '
        Me.RadTextBox_Tissue1Amount.Enabled = false
        Me.RadTextBox_Tissue1Amount.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Tissue1Amount.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Tissue1Amount.Location = New System.Drawing.Point(285, 2)
        Me.RadTextBox_Tissue1Amount.MinimumSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_Tissue1Amount.Name = "RadTextBox_Tissue1Amount"
        '
        '
        '
        Me.RadTextBox_Tissue1Amount.RootElement.MinSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_Tissue1Amount.Size = New System.Drawing.Size(48, 20)
        Me.RadTextBox_Tissue1Amount.TabIndex = 70
        Me.RadTextBox_Tissue1Amount.Text = "0"
        Me.RadTextBox_Tissue1Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadDropDownList_Tissue2Vf
        '
        Me.RadDropDownList_Tissue2Vf.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Tissue2Vf.Enabled = false
        Me.RadDropDownList_Tissue2Vf.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Tissue2Vf.Location = New System.Drawing.Point(154, 25)
        Me.RadDropDownList_Tissue2Vf.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Tissue2Vf.MinimumSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Tissue2Vf.Name = "RadDropDownList_Tissue2Vf"
        '
        '
        '
        Me.RadDropDownList_Tissue2Vf.RootElement.MinSize = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Tissue2Vf.Size = New System.Drawing.Size(59, 23)
        Me.RadDropDownList_Tissue2Vf.TabIndex = 69
        Me.RadDropDownList_Tissue2Vf.Text = "0"
        Me.RadDropDownList_Tissue2Vf.Visible = false
        '
        'Panel_Freqs
        '
        Me.Panel_Freqs.BackColor = System.Drawing.Color.FromArgb(CType(CType(181,Byte),Integer), CType(CType(203,Byte),Integer), CType(CType(136,Byte),Integer))
        Me.Panel_Freqs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Freqs.Controls.Add(Me.RadButton_MoreDetail)
        Me.Panel_Freqs.Controls.Add(Me.RadButton_LifeCalc)
        Me.Panel_Freqs.Controls.Add(Me.RadButton_WriteCatData)
        Me.Panel_Freqs.Controls.Add(Me.RadButton_Refresh2)
        Me.Panel_Freqs.Controls.Add(Me.RadButton_GetData)
        Me.Panel_Freqs.Controls.Add(Me.RadButton_DefaultFreqs)
        Me.Panel_Freqs.Controls.Add(Me.RadLabel_HSink)
        Me.Panel_Freqs.Controls.Add(Me.RadLabel_EDType)
        Me.Panel_Freqs.Controls.Add(Me.RadLabel_Mm9)
        Me.Panel_Freqs.Controls.Add(Me.RadTextBox_VFactorMm)
        Me.Panel_Freqs.Controls.Add(Me.RadDropDownList_EDType)
        Me.Panel_Freqs.Controls.Add(Me.RadDropDownList_AirflowMs)
        Me.Panel_Freqs.Controls.Add(Me.RadCheckBox_UseActualEsr)
        Me.Panel_Freqs.Controls.Add(Me.RadLabel_ATc)
        Me.Panel_Freqs.Controls.Add(Me.RadTextBox_FailMode)
        Me.Panel_Freqs.Controls.Add(Me.RadTextBox_LifeLop)
        Me.Panel_Freqs.Controls.Add(Me.RadLabel_FailMode)
        Me.Panel_Freqs.Controls.Add(Me.RadLabel_LifeLop)
        Me.Panel_Freqs.Controls.Add(Me.RadTextBox_ActEsrTemp)
        Me.Panel_Freqs.Controls.Add(Me.RadLabel_UseActualEsr)
        Me.Panel_Freqs.Controls.Add(Me.RadLabel_ActEsrTemp)
        Me.Panel_Freqs.Controls.Add(Me.RadTextBox_ESRFactorKe)
        Me.Panel_Freqs.Controls.Add(Me.RadTextBox_MaxESRx)
        Me.Panel_Freqs.Controls.Add(Me.RadLabel_ESRFactorKe)
        Me.Panel_Freqs.Controls.Add(Me.RadLabel_MaxESRx)
        Me.Panel_Freqs.Controls.Add(Me.RadTextBox_TrForCalcIr)
        Me.Panel_Freqs.Controls.Add(Me.RadTextBox_MaxCoreTm)
        Me.Panel_Freqs.Controls.Add(Me.RadLabel_TrForCalcIr)
        Me.Panel_Freqs.Controls.Add(Me.RadLabel_MaxCoreTm)
        Me.Panel_Freqs.Controls.Add(Me.RadTextBox_VFactorKv)
        Me.Panel_Freqs.Controls.Add(Me.RadTextBox_StdVfs)
        Me.Panel_Freqs.Controls.Add(Me.RadLabel_VFactorKv)
        Me.Panel_Freqs.Controls.Add(Me.RadLabel_StdVfs)
        Me.Panel_Freqs.Controls.Add(Me.RadTextBox_CurrentPaths)
        Me.Panel_Freqs.Controls.Add(Me.RadLabel_CurrentPaths)
        Me.Panel_Freqs.Controls.Add(Me.RadLabel_AirflowMs)
        Me.Panel_Freqs.Controls.Add(Me.RadTextBox_ActTrxAtEOLTx)
        Me.Panel_Freqs.Controls.Add(Me.RadTextBox_ArrheniusT2)
        Me.Panel_Freqs.Controls.Add(Me.RadLabel_ActTrxAtEOLTx)
        Me.Panel_Freqs.Controls.Add(Me.RadLabel_ArrheniusT2)
        Me.Panel_Freqs.Controls.Add(Me.RadTextBox_TrCoreRise)
        Me.Panel_Freqs.Controls.Add(Me.RadTextBox_AverageTh)
        Me.Panel_Freqs.Controls.Add(Me.RadLabel_TrCoreRise)
        Me.Panel_Freqs.Controls.Add(Me.RadLabel_AverageTh)
        Me.Panel_Freqs.Controls.Add(Me.RadTextBox_HSink)
        Me.Panel_Freqs.Controls.Add(Me.RadTextBox_OpVop)
        Me.Panel_Freqs.Controls.Add(Me.RadLabel_OpVop)
        Me.Panel_Freqs.Controls.Add(Me.RadCheckBox_old)
        Me.Panel_Freqs.Controls.Add(Me.RadTextBox_RHaCperWatt)
        Me.Panel_Freqs.Controls.Add(Me.RadLabel_RHaCperWatt)
        Me.Panel_Freqs.Controls.Add(Me.RadTextBox_LifeFactorLe)
        Me.Panel_Freqs.Controls.Add(Me.RadLabel_LifeFactorLe)
        Me.Panel_Freqs.Controls.Add(Me.RadTextBox_ATc)
        Me.Panel_Freqs.Controls.Add(Me.RadTextBox_AmbientTa)
        Me.Panel_Freqs.Controls.Add(Me.RadLabel_AmbientTa)
        Me.Panel_Freqs.Controls.Add(Me.RadGridView1)
        Me.Panel_Freqs.Location = New System.Drawing.Point(2, 291)
        Me.Panel_Freqs.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Freqs.MinimumSize = New System.Drawing.Size(731, 216)
        Me.Panel_Freqs.Name = "Panel_Freqs"
        Me.Panel_Freqs.Size = New System.Drawing.Size(731, 224)
        Me.Panel_Freqs.TabIndex = 16
        '
        'RadButton_MoreDetail
        '
        Me.RadButton_MoreDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_MoreDetail.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_MoreDetail.ForeColor = System.Drawing.Color.Black
        Me.RadButton_MoreDetail.Location = New System.Drawing.Point(8, 200)
        Me.RadButton_MoreDetail.Name = "RadButton_MoreDetail"
        Me.RadButton_MoreDetail.Size = New System.Drawing.Size(90, 20)
        Me.RadButton_MoreDetail.TabIndex = 148
        Me.RadButton_MoreDetail.Text = "ScratchP_MoreDetail"
        Me.RadButton_MoreDetail.TextWrap = true
        '
        'RadButton_LifeCalc
        '
        Me.RadButton_LifeCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_LifeCalc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_LifeCalc.ForeColor = System.Drawing.Color.Black
        Me.RadButton_LifeCalc.Location = New System.Drawing.Point(8, 178)
        Me.RadButton_LifeCalc.Name = "RadButton_LifeCalc"
        Me.RadButton_LifeCalc.Size = New System.Drawing.Size(90, 20)
        Me.RadButton_LifeCalc.TabIndex = 149
        Me.RadButton_LifeCalc.Text = "ScratchP_LifeCalc"
        Me.RadButton_LifeCalc.TextWrap = true
        '
        'RadButton_WriteCatData
        '
        Me.RadButton_WriteCatData.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_WriteCatData.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.RadButton_WriteCatData.ForeColor = System.Drawing.Color.Black
        Me.RadButton_WriteCatData.Location = New System.Drawing.Point(62, 134)
        Me.RadButton_WriteCatData.Name = "RadButton_WriteCatData"
        Me.RadButton_WriteCatData.Size = New System.Drawing.Size(36, 42)
        Me.RadButton_WriteCatData.TabIndex = 148
        Me.RadButton_WriteCatData.Text = "ScratchP_WriteCatData"
        Me.RadButton_WriteCatData.TextWrap = true
        '
        'RadButton_Refresh2
        '
        Me.RadButton_Refresh2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_Refresh2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Refresh2.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Refresh2.Location = New System.Drawing.Point(8, 156)
        Me.RadButton_Refresh2.Name = "RadButton_Refresh2"
        Me.RadButton_Refresh2.Size = New System.Drawing.Size(52, 20)
        Me.RadButton_Refresh2.TabIndex = 148
        Me.RadButton_Refresh2.Text = "ScratchP_Refresh"
        Me.RadButton_Refresh2.TextWrap = true
        '
        'RadButton_GetData
        '
        Me.RadButton_GetData.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_GetData.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadButton_GetData.ForeColor = System.Drawing.Color.Black
        Me.RadButton_GetData.Location = New System.Drawing.Point(8, 134)
        Me.RadButton_GetData.Name = "RadButton_GetData"
        Me.RadButton_GetData.Size = New System.Drawing.Size(52, 20)
        Me.RadButton_GetData.TabIndex = 147
        Me.RadButton_GetData.Text = "ScratchP_GetData"
        Me.RadButton_GetData.TextWrap = true
        '
        'RadButton_DefaultFreqs
        '
        Me.RadButton_DefaultFreqs.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_DefaultFreqs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_DefaultFreqs.ForeColor = System.Drawing.Color.Black
        Me.RadButton_DefaultFreqs.Location = New System.Drawing.Point(8, 112)
        Me.RadButton_DefaultFreqs.Name = "RadButton_DefaultFreqs"
        Me.RadButton_DefaultFreqs.Size = New System.Drawing.Size(90, 20)
        Me.RadButton_DefaultFreqs.TabIndex = 146
        Me.RadButton_DefaultFreqs.Text = "ScratchP_DefaultFreqs"
        Me.RadButton_DefaultFreqs.TextWrap = true
        '
        'RadLabel_HSink
        '
        Me.RadLabel_HSink.AutoSize = false
        Me.RadLabel_HSink.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_HSink.Location = New System.Drawing.Point(657, 68)
        Me.RadLabel_HSink.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_HSink.Name = "RadLabel_HSink"
        Me.RadLabel_HSink.Size = New System.Drawing.Size(50, 22)
        Me.RadLabel_HSink.TabIndex = 131
        Me.RadLabel_HSink.Text = "ScratchP_HSink"
        Me.RadLabel_HSink.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_EDType
        '
        Me.RadLabel_EDType.AutoSize = false
        Me.RadLabel_EDType.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_EDType.Location = New System.Drawing.Point(657, 1)
        Me.RadLabel_EDType.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_EDType.Name = "RadLabel_EDType"
        Me.RadLabel_EDType.Size = New System.Drawing.Size(50, 22)
        Me.RadLabel_EDType.TabIndex = 130
        Me.RadLabel_EDType.Text = "ScratchP_EDType"
        Me.RadLabel_EDType.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_Mm9
        '
        Me.RadLabel_Mm9.AutoSize = false
        Me.RadLabel_Mm9.Font = New System.Drawing.Font("Segoe UI", 7!)
        Me.RadLabel_Mm9.Location = New System.Drawing.Point(682, 46)
        Me.RadLabel_Mm9.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Mm9.Name = "RadLabel_Mm9"
        Me.RadLabel_Mm9.Size = New System.Drawing.Size(30, 20)
        Me.RadLabel_Mm9.TabIndex = 129
        Me.RadLabel_Mm9.Text = "Units_Mm"
        Me.RadLabel_Mm9.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadTextBox_VFactorMm
        '
        Me.RadTextBox_VFactorMm.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_VFactorMm.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_VFactorMm.Location = New System.Drawing.Point(657, 44)
        Me.RadTextBox_VFactorMm.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_VFactorMm.Name = "RadTextBox_VFactorMm"
        '
        '
        '
        Me.RadTextBox_VFactorMm.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_VFactorMm.Size = New System.Drawing.Size(25, 20)
        Me.RadTextBox_VFactorMm.TabIndex = 128
        Me.RadTextBox_VFactorMm.Text = "0,1"
        Me.RadTextBox_VFactorMm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadDropDownList_EDType
        '
        Me.RadDropDownList_EDType.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_EDType.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_EDType.Location = New System.Drawing.Point(657, 21)
        Me.RadDropDownList_EDType.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_EDType.Name = "RadDropDownList_EDType"
        '
        '
        '
        Me.RadDropDownList_EDType.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_EDType.Size = New System.Drawing.Size(50, 20)
        Me.RadDropDownList_EDType.TabIndex = 127
        Me.RadDropDownList_EDType.Text = "bare"
        '
        'RadDropDownList_AirflowMs
        '
        Me.RadDropDownList_AirflowMs.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_AirflowMs.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_AirflowMs.Location = New System.Drawing.Point(419, 22)
        Me.RadDropDownList_AirflowMs.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_AirflowMs.Name = "RadDropDownList_AirflowMs"
        '
        '
        '
        Me.RadDropDownList_AirflowMs.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_AirflowMs.Size = New System.Drawing.Size(50, 20)
        Me.RadDropDownList_AirflowMs.TabIndex = 126
        Me.RadDropDownList_AirflowMs.Text = "0"
        '
        'RadCheckBox_UseActualEsr
        '
        Me.RadCheckBox_UseActualEsr.AutoSize = false
        Me.RadCheckBox_UseActualEsr.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadCheckBox_UseActualEsr.Location = New System.Drawing.Point(420, 88)
        Me.RadCheckBox_UseActualEsr.Name = "RadCheckBox_UseActualEsr"
        Me.RadCheckBox_UseActualEsr.Size = New System.Drawing.Size(20, 20)
        Me.RadCheckBox_UseActualEsr.TabIndex = 125
        '
        'RadLabel_ATc
        '
        Me.RadLabel_ATc.AutoSize = false
        Me.RadLabel_ATc.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_ATc.Location = New System.Drawing.Point(151, 8)
        Me.RadLabel_ATc.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_ATc.Name = "RadLabel_ATc"
        Me.RadLabel_ATc.Size = New System.Drawing.Size(30, 15)
        Me.RadLabel_ATc.TabIndex = 124
        Me.RadLabel_ATc.Text = "ScratchP_ATc"
        Me.RadLabel_ATc.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadTextBox_FailMode
        '
        Me.RadTextBox_FailMode.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_FailMode.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_FailMode.Location = New System.Drawing.Point(593, 88)
        Me.RadTextBox_FailMode.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_FailMode.Name = "RadTextBox_FailMode"
        '
        '
        '
        Me.RadTextBox_FailMode.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_FailMode.Size = New System.Drawing.Size(50, 20)
        Me.RadTextBox_FailMode.TabIndex = 123
        Me.RadTextBox_FailMode.Text = "ESR"
        Me.RadTextBox_FailMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadTextBox_LifeLop
        '
        Me.RadTextBox_LifeLop.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_LifeLop.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_LifeLop.Location = New System.Drawing.Point(593, 66)
        Me.RadTextBox_LifeLop.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_LifeLop.Name = "RadTextBox_LifeLop"
        '
        '
        '
        Me.RadTextBox_LifeLop.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_LifeLop.Size = New System.Drawing.Size(50, 20)
        Me.RadTextBox_LifeLop.TabIndex = 115
        Me.RadTextBox_LifeLop.Text = "57521"
        Me.RadTextBox_LifeLop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel_FailMode
        '
        Me.RadLabel_FailMode.AutoSize = false
        Me.RadLabel_FailMode.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_FailMode.Location = New System.Drawing.Point(511, 89)
        Me.RadLabel_FailMode.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_FailMode.Name = "RadLabel_FailMode"
        Me.RadLabel_FailMode.Size = New System.Drawing.Size(80, 22)
        Me.RadLabel_FailMode.TabIndex = 122
        Me.RadLabel_FailMode.Text = "ScratchP_FailMode"
        Me.RadLabel_FailMode.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_LifeLop
        '
        Me.RadLabel_LifeLop.AutoSize = false
        Me.RadLabel_LifeLop.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_LifeLop.Location = New System.Drawing.Point(511, 67)
        Me.RadLabel_LifeLop.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_LifeLop.Name = "RadLabel_LifeLop"
        Me.RadLabel_LifeLop.Size = New System.Drawing.Size(80, 22)
        Me.RadLabel_LifeLop.TabIndex = 114
        Me.RadLabel_LifeLop.Text = "ScratchP_LifeLop"
        Me.RadLabel_LifeLop.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_ActEsrTemp
        '
        Me.RadTextBox_ActEsrTemp.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_ActEsrTemp.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_ActEsrTemp.Location = New System.Drawing.Point(419, 66)
        Me.RadTextBox_ActEsrTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_ActEsrTemp.Name = "RadTextBox_ActEsrTemp"
        '
        '
        '
        Me.RadTextBox_ActEsrTemp.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_ActEsrTemp.Size = New System.Drawing.Size(50, 20)
        Me.RadTextBox_ActEsrTemp.TabIndex = 113
        Me.RadTextBox_ActEsrTemp.Text = "0,0"
        Me.RadTextBox_ActEsrTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel_UseActualEsr
        '
        Me.RadLabel_UseActualEsr.AutoSize = false
        Me.RadLabel_UseActualEsr.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_UseActualEsr.Location = New System.Drawing.Point(337, 89)
        Me.RadLabel_UseActualEsr.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_UseActualEsr.Name = "RadLabel_UseActualEsr"
        Me.RadLabel_UseActualEsr.Size = New System.Drawing.Size(80, 22)
        Me.RadLabel_UseActualEsr.TabIndex = 120
        Me.RadLabel_UseActualEsr.Text = "ScratchP_UseActualEsr"
        Me.RadLabel_UseActualEsr.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_ActEsrTemp
        '
        Me.RadLabel_ActEsrTemp.AutoSize = false
        Me.RadLabel_ActEsrTemp.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_ActEsrTemp.Location = New System.Drawing.Point(337, 67)
        Me.RadLabel_ActEsrTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_ActEsrTemp.Name = "RadLabel_ActEsrTemp"
        Me.RadLabel_ActEsrTemp.Size = New System.Drawing.Size(80, 22)
        Me.RadLabel_ActEsrTemp.TabIndex = 112
        Me.RadLabel_ActEsrTemp.Text = "ScratchP_ActEsrTemp"
        Me.RadLabel_ActEsrTemp.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_ESRFactorKe
        '
        Me.RadTextBox_ESRFactorKe.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_ESRFactorKe.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_ESRFactorKe.Location = New System.Drawing.Point(285, 88)
        Me.RadTextBox_ESRFactorKe.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_ESRFactorKe.Name = "RadTextBox_ESRFactorKe"
        '
        '
        '
        Me.RadTextBox_ESRFactorKe.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_ESRFactorKe.Size = New System.Drawing.Size(50, 20)
        Me.RadTextBox_ESRFactorKe.TabIndex = 119
        Me.RadTextBox_ESRFactorKe.Text = "1"
        Me.RadTextBox_ESRFactorKe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadTextBox_MaxESRx
        '
        Me.RadTextBox_MaxESRx.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_MaxESRx.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_MaxESRx.Location = New System.Drawing.Point(285, 66)
        Me.RadTextBox_MaxESRx.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_MaxESRx.Name = "RadTextBox_MaxESRx"
        '
        '
        '
        Me.RadTextBox_MaxESRx.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_MaxESRx.Size = New System.Drawing.Size(50, 20)
        Me.RadTextBox_MaxESRx.TabIndex = 111
        Me.RadTextBox_MaxESRx.Text = "2"
        Me.RadTextBox_MaxESRx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel_ESRFactorKe
        '
        Me.RadLabel_ESRFactorKe.AutoSize = false
        Me.RadLabel_ESRFactorKe.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_ESRFactorKe.Location = New System.Drawing.Point(183, 89)
        Me.RadLabel_ESRFactorKe.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_ESRFactorKe.Name = "RadLabel_ESRFactorKe"
        Me.RadLabel_ESRFactorKe.Size = New System.Drawing.Size(100, 20)
        Me.RadLabel_ESRFactorKe.TabIndex = 118
        Me.RadLabel_ESRFactorKe.Text = "ScratchP_ESRFactorKe"
        Me.RadLabel_ESRFactorKe.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_MaxESRx
        '
        Me.RadLabel_MaxESRx.AutoSize = false
        Me.RadLabel_MaxESRx.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_MaxESRx.Location = New System.Drawing.Point(183, 67)
        Me.RadLabel_MaxESRx.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_MaxESRx.Name = "RadLabel_MaxESRx"
        Me.RadLabel_MaxESRx.Size = New System.Drawing.Size(100, 20)
        Me.RadLabel_MaxESRx.TabIndex = 110
        Me.RadLabel_MaxESRx.Text = "ScratchP_MaxESRx"
        Me.RadLabel_MaxESRx.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_TrForCalcIr
        '
        Me.RadTextBox_TrForCalcIr.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_TrForCalcIr.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_TrForCalcIr.Location = New System.Drawing.Point(99, 88)
        Me.RadTextBox_TrForCalcIr.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_TrForCalcIr.Name = "RadTextBox_TrForCalcIr"
        '
        '
        '
        Me.RadTextBox_TrForCalcIr.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_TrForCalcIr.Size = New System.Drawing.Size(50, 20)
        Me.RadTextBox_TrForCalcIr.TabIndex = 117
        Me.RadTextBox_TrForCalcIr.Text = "7,0"
        Me.RadTextBox_TrForCalcIr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadTextBox_MaxCoreTm
        '
        Me.RadTextBox_MaxCoreTm.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_MaxCoreTm.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_MaxCoreTm.Location = New System.Drawing.Point(99, 66)
        Me.RadTextBox_MaxCoreTm.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_MaxCoreTm.Name = "RadTextBox_MaxCoreTm"
        '
        '
        '
        Me.RadTextBox_MaxCoreTm.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_MaxCoreTm.Size = New System.Drawing.Size(50, 20)
        Me.RadTextBox_MaxCoreTm.TabIndex = 109
        Me.RadTextBox_MaxCoreTm.Text = "105,0"
        Me.RadTextBox_MaxCoreTm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel_TrForCalcIr
        '
        Me.RadLabel_TrForCalcIr.AutoSize = false
        Me.RadLabel_TrForCalcIr.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_TrForCalcIr.Location = New System.Drawing.Point(9, 89)
        Me.RadLabel_TrForCalcIr.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_TrForCalcIr.Name = "RadLabel_TrForCalcIr"
        Me.RadLabel_TrForCalcIr.Size = New System.Drawing.Size(90, 22)
        Me.RadLabel_TrForCalcIr.TabIndex = 116
        Me.RadLabel_TrForCalcIr.Text = "ScratchP_TrForCalcIr"
        Me.RadLabel_TrForCalcIr.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_MaxCoreTm
        '
        Me.RadLabel_MaxCoreTm.AutoSize = false
        Me.RadLabel_MaxCoreTm.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_MaxCoreTm.Location = New System.Drawing.Point(9, 67)
        Me.RadLabel_MaxCoreTm.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_MaxCoreTm.Name = "RadLabel_MaxCoreTm"
        Me.RadLabel_MaxCoreTm.Size = New System.Drawing.Size(90, 22)
        Me.RadLabel_MaxCoreTm.TabIndex = 108
        Me.RadLabel_MaxCoreTm.Text = "ScratchP_MaxCoreTm"
        Me.RadLabel_MaxCoreTm.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_VFactorKv
        '
        Me.RadTextBox_VFactorKv.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_VFactorKv.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_VFactorKv.Location = New System.Drawing.Point(593, 44)
        Me.RadTextBox_VFactorKv.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_VFactorKv.Name = "RadTextBox_VFactorKv"
        '
        '
        '
        Me.RadTextBox_VFactorKv.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_VFactorKv.Size = New System.Drawing.Size(50, 20)
        Me.RadTextBox_VFactorKv.TabIndex = 107
        Me.RadTextBox_VFactorKv.Text = "1,388"
        Me.RadTextBox_VFactorKv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadTextBox_StdVfs
        '
        Me.RadTextBox_StdVfs.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_StdVfs.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_StdVfs.Location = New System.Drawing.Point(593, 22)
        Me.RadTextBox_StdVfs.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_StdVfs.Name = "RadTextBox_StdVfs"
        '
        '
        '
        Me.RadTextBox_StdVfs.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_StdVfs.Size = New System.Drawing.Size(50, 20)
        Me.RadTextBox_StdVfs.TabIndex = 99
        Me.RadTextBox_StdVfs.Text = "525"
        Me.RadTextBox_StdVfs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel_VFactorKv
        '
        Me.RadLabel_VFactorKv.AutoSize = false
        Me.RadLabel_VFactorKv.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_VFactorKv.Location = New System.Drawing.Point(511, 45)
        Me.RadLabel_VFactorKv.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_VFactorKv.Name = "RadLabel_VFactorKv"
        Me.RadLabel_VFactorKv.Size = New System.Drawing.Size(80, 22)
        Me.RadLabel_VFactorKv.TabIndex = 106
        Me.RadLabel_VFactorKv.Text = "ScratchP_VFactorKv"
        Me.RadLabel_VFactorKv.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_StdVfs
        '
        Me.RadLabel_StdVfs.AutoSize = false
        Me.RadLabel_StdVfs.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_StdVfs.Location = New System.Drawing.Point(511, 23)
        Me.RadLabel_StdVfs.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_StdVfs.Name = "RadLabel_StdVfs"
        Me.RadLabel_StdVfs.Size = New System.Drawing.Size(80, 22)
        Me.RadLabel_StdVfs.TabIndex = 98
        Me.RadLabel_StdVfs.Text = "ScratchP_StdVfs"
        Me.RadLabel_StdVfs.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_CurrentPaths
        '
        Me.RadTextBox_CurrentPaths.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_CurrentPaths.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_CurrentPaths.Location = New System.Drawing.Point(419, 44)
        Me.RadTextBox_CurrentPaths.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_CurrentPaths.Name = "RadTextBox_CurrentPaths"
        '
        '
        '
        Me.RadTextBox_CurrentPaths.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_CurrentPaths.Size = New System.Drawing.Size(50, 20)
        Me.RadTextBox_CurrentPaths.TabIndex = 105
        Me.RadTextBox_CurrentPaths.Text = "1"
        Me.RadTextBox_CurrentPaths.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel_CurrentPaths
        '
        Me.RadLabel_CurrentPaths.AutoSize = false
        Me.RadLabel_CurrentPaths.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_CurrentPaths.Location = New System.Drawing.Point(337, 45)
        Me.RadLabel_CurrentPaths.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_CurrentPaths.Name = "RadLabel_CurrentPaths"
        Me.RadLabel_CurrentPaths.Size = New System.Drawing.Size(80, 22)
        Me.RadLabel_CurrentPaths.TabIndex = 104
        Me.RadLabel_CurrentPaths.Text = "ScratchP_CurrentPaths"
        Me.RadLabel_CurrentPaths.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_AirflowMs
        '
        Me.RadLabel_AirflowMs.AutoSize = false
        Me.RadLabel_AirflowMs.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_AirflowMs.Location = New System.Drawing.Point(337, 23)
        Me.RadLabel_AirflowMs.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_AirflowMs.Name = "RadLabel_AirflowMs"
        Me.RadLabel_AirflowMs.Size = New System.Drawing.Size(80, 22)
        Me.RadLabel_AirflowMs.TabIndex = 96
        Me.RadLabel_AirflowMs.Text = "ScratchP_AirflowMs"
        Me.RadLabel_AirflowMs.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_ActTrxAtEOLTx
        '
        Me.RadTextBox_ActTrxAtEOLTx.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_ActTrxAtEOLTx.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_ActTrxAtEOLTx.Location = New System.Drawing.Point(285, 44)
        Me.RadTextBox_ActTrxAtEOLTx.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_ActTrxAtEOLTx.Name = "RadTextBox_ActTrxAtEOLTx"
        '
        '
        '
        Me.RadTextBox_ActTrxAtEOLTx.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_ActTrxAtEOLTx.Size = New System.Drawing.Size(50, 20)
        Me.RadTextBox_ActTrxAtEOLTx.TabIndex = 103
        Me.RadTextBox_ActTrxAtEOLTx.Text = "2"
        Me.RadTextBox_ActTrxAtEOLTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadTextBox_ArrheniusT2
        '
        Me.RadTextBox_ArrheniusT2.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_ArrheniusT2.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_ArrheniusT2.Location = New System.Drawing.Point(285, 22)
        Me.RadTextBox_ArrheniusT2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_ArrheniusT2.Name = "RadTextBox_ArrheniusT2"
        '
        '
        '
        Me.RadTextBox_ArrheniusT2.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_ArrheniusT2.Size = New System.Drawing.Size(50, 20)
        Me.RadTextBox_ArrheniusT2.TabIndex = 95
        Me.RadTextBox_ArrheniusT2.Text = "10"
        Me.RadTextBox_ArrheniusT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel_ActTrxAtEOLTx
        '
        Me.RadLabel_ActTrxAtEOLTx.AutoSize = false
        Me.RadLabel_ActTrxAtEOLTx.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_ActTrxAtEOLTx.Location = New System.Drawing.Point(183, 45)
        Me.RadLabel_ActTrxAtEOLTx.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_ActTrxAtEOLTx.Name = "RadLabel_ActTrxAtEOLTx"
        Me.RadLabel_ActTrxAtEOLTx.Size = New System.Drawing.Size(100, 20)
        Me.RadLabel_ActTrxAtEOLTx.TabIndex = 102
        Me.RadLabel_ActTrxAtEOLTx.Text = "ScratchP_ActTrxAtEOLTx"
        Me.RadLabel_ActTrxAtEOLTx.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_ArrheniusT2
        '
        Me.RadLabel_ArrheniusT2.AutoSize = false
        Me.RadLabel_ArrheniusT2.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_ArrheniusT2.Location = New System.Drawing.Point(183, 23)
        Me.RadLabel_ArrheniusT2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_ArrheniusT2.Name = "RadLabel_ArrheniusT2"
        Me.RadLabel_ArrheniusT2.Size = New System.Drawing.Size(100, 20)
        Me.RadLabel_ArrheniusT2.TabIndex = 94
        Me.RadLabel_ArrheniusT2.Text = "ScratchP_ArrheniusT2"
        Me.RadLabel_ArrheniusT2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_TrCoreRise
        '
        Me.RadTextBox_TrCoreRise.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_TrCoreRise.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_TrCoreRise.Location = New System.Drawing.Point(99, 44)
        Me.RadTextBox_TrCoreRise.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_TrCoreRise.Name = "RadTextBox_TrCoreRise"
        '
        '
        '
        Me.RadTextBox_TrCoreRise.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_TrCoreRise.Size = New System.Drawing.Size(50, 20)
        Me.RadTextBox_TrCoreRise.TabIndex = 101
        Me.RadTextBox_TrCoreRise.Text = "0,0"
        Me.RadTextBox_TrCoreRise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadTextBox_AverageTh
        '
        Me.RadTextBox_AverageTh.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_AverageTh.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_AverageTh.Location = New System.Drawing.Point(99, 22)
        Me.RadTextBox_AverageTh.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_AverageTh.Name = "RadTextBox_AverageTh"
        '
        '
        '
        Me.RadTextBox_AverageTh.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_AverageTh.Size = New System.Drawing.Size(50, 20)
        Me.RadTextBox_AverageTh.TabIndex = 93
        Me.RadTextBox_AverageTh.Text = "85"
        Me.RadTextBox_AverageTh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel_TrCoreRise
        '
        Me.RadLabel_TrCoreRise.AutoSize = false
        Me.RadLabel_TrCoreRise.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_TrCoreRise.Location = New System.Drawing.Point(9, 45)
        Me.RadLabel_TrCoreRise.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_TrCoreRise.Name = "RadLabel_TrCoreRise"
        Me.RadLabel_TrCoreRise.Size = New System.Drawing.Size(95, 22)
        Me.RadLabel_TrCoreRise.TabIndex = 100
        Me.RadLabel_TrCoreRise.Text = "ScratchP_TrCoreRise"
        Me.RadLabel_TrCoreRise.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_AverageTh
        '
        Me.RadLabel_AverageTh.AutoSize = false
        Me.RadLabel_AverageTh.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_AverageTh.Location = New System.Drawing.Point(9, 23)
        Me.RadLabel_AverageTh.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_AverageTh.Name = "RadLabel_AverageTh"
        Me.RadLabel_AverageTh.Size = New System.Drawing.Size(90, 22)
        Me.RadLabel_AverageTh.TabIndex = 92
        Me.RadLabel_AverageTh.Text = "ScratchP_AverageTh"
        Me.RadLabel_AverageTh.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_HSink
        '
        Me.RadTextBox_HSink.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_HSink.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_HSink.Location = New System.Drawing.Point(657, 88)
        Me.RadTextBox_HSink.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_HSink.Name = "RadTextBox_HSink"
        '
        '
        '
        Me.RadTextBox_HSink.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_HSink.Size = New System.Drawing.Size(50, 20)
        Me.RadTextBox_HSink.TabIndex = 91
        Me.RadTextBox_HSink.Text = "0"
        Me.RadTextBox_HSink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadTextBox_OpVop
        '
        Me.RadTextBox_OpVop.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_OpVop.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_OpVop.Location = New System.Drawing.Point(593, 0)
        Me.RadTextBox_OpVop.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_OpVop.Name = "RadTextBox_OpVop"
        '
        '
        '
        Me.RadTextBox_OpVop.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_OpVop.Size = New System.Drawing.Size(50, 20)
        Me.RadTextBox_OpVop.TabIndex = 90
        Me.RadTextBox_OpVop.Text = "400"
        Me.RadTextBox_OpVop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel_OpVop
        '
        Me.RadLabel_OpVop.AutoSize = false
        Me.RadLabel_OpVop.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_OpVop.Location = New System.Drawing.Point(511, 1)
        Me.RadLabel_OpVop.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_OpVop.Name = "RadLabel_OpVop"
        Me.RadLabel_OpVop.Size = New System.Drawing.Size(80, 22)
        Me.RadLabel_OpVop.TabIndex = 89
        Me.RadLabel_OpVop.Text = "ScratchP_OpVop"
        Me.RadLabel_OpVop.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadCheckBox_old
        '
        Me.RadCheckBox_old.AutoSize = false
        Me.RadCheckBox_old.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_old.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadCheckBox_old.Location = New System.Drawing.Point(468, 0)
        Me.RadCheckBox_old.Name = "RadCheckBox_old"
        Me.RadCheckBox_old.Size = New System.Drawing.Size(40, 20)
        Me.RadCheckBox_old.TabIndex = 88
        Me.RadCheckBox_old.Text = "ScratchP_old"
        Me.RadCheckBox_old.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_RHaCperWatt
        '
        Me.RadTextBox_RHaCperWatt.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_RHaCperWatt.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_RHaCperWatt.Location = New System.Drawing.Point(419, 0)
        Me.RadTextBox_RHaCperWatt.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_RHaCperWatt.Name = "RadTextBox_RHaCperWatt"
        '
        '
        '
        Me.RadTextBox_RHaCperWatt.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_RHaCperWatt.Size = New System.Drawing.Size(50, 20)
        Me.RadTextBox_RHaCperWatt.TabIndex = 85
        Me.RadTextBox_RHaCperWatt.Text = "1,829"
        Me.RadTextBox_RHaCperWatt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel_RHaCperWatt
        '
        Me.RadLabel_RHaCperWatt.AutoSize = false
        Me.RadLabel_RHaCperWatt.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_RHaCperWatt.Location = New System.Drawing.Point(337, 1)
        Me.RadLabel_RHaCperWatt.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_RHaCperWatt.Name = "RadLabel_RHaCperWatt"
        Me.RadLabel_RHaCperWatt.Size = New System.Drawing.Size(80, 22)
        Me.RadLabel_RHaCperWatt.TabIndex = 84
        Me.RadLabel_RHaCperWatt.Text = "ScratchP_RHaCperWatt"
        Me.RadLabel_RHaCperWatt.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_LifeFactorLe
        '
        Me.RadTextBox_LifeFactorLe.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_LifeFactorLe.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_LifeFactorLe.Location = New System.Drawing.Point(285, 0)
        Me.RadTextBox_LifeFactorLe.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_LifeFactorLe.Name = "RadTextBox_LifeFactorLe"
        '
        '
        '
        Me.RadTextBox_LifeFactorLe.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_LifeFactorLe.Size = New System.Drawing.Size(50, 20)
        Me.RadTextBox_LifeFactorLe.TabIndex = 83
        Me.RadTextBox_LifeFactorLe.Text = "41450"
        Me.RadTextBox_LifeFactorLe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel_LifeFactorLe
        '
        Me.RadLabel_LifeFactorLe.AutoSize = false
        Me.RadLabel_LifeFactorLe.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_LifeFactorLe.Location = New System.Drawing.Point(183, 1)
        Me.RadLabel_LifeFactorLe.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_LifeFactorLe.Name = "RadLabel_LifeFactorLe"
        Me.RadLabel_LifeFactorLe.Size = New System.Drawing.Size(100, 20)
        Me.RadLabel_LifeFactorLe.TabIndex = 82
        Me.RadLabel_LifeFactorLe.Text = "ScratchP_LifeFactorLe"
        Me.RadLabel_LifeFactorLe.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_ATc
        '
        Me.RadTextBox_ATc.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_ATc.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_ATc.Location = New System.Drawing.Point(151, 22)
        Me.RadTextBox_ATc.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_ATc.Name = "RadTextBox_ATc"
        '
        '
        '
        Me.RadTextBox_ATc.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_ATc.Size = New System.Drawing.Size(30, 20)
        Me.RadTextBox_ATc.TabIndex = 81
        Me.RadTextBox_ATc.Text = "0"
        Me.RadTextBox_ATc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadTextBox_AmbientTa
        '
        Me.RadTextBox_AmbientTa.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_AmbientTa.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_AmbientTa.Location = New System.Drawing.Point(99, 0)
        Me.RadTextBox_AmbientTa.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_AmbientTa.Name = "RadTextBox_AmbientTa"
        '
        '
        '
        Me.RadTextBox_AmbientTa.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_AmbientTa.Size = New System.Drawing.Size(50, 20)
        Me.RadTextBox_AmbientTa.TabIndex = 80
        Me.RadTextBox_AmbientTa.Text = "85,0"
        Me.RadTextBox_AmbientTa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel_AmbientTa
        '
        Me.RadLabel_AmbientTa.AutoSize = false
        Me.RadLabel_AmbientTa.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_AmbientTa.Location = New System.Drawing.Point(9, 1)
        Me.RadLabel_AmbientTa.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_AmbientTa.Name = "RadLabel_AmbientTa"
        Me.RadLabel_AmbientTa.Size = New System.Drawing.Size(90, 22)
        Me.RadLabel_AmbientTa.TabIndex = 79
        Me.RadLabel_AmbientTa.Text = "ScratchP_AmbientTa"
        Me.RadLabel_AmbientTa.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadGridView1
        '
        Me.RadGridView1.Location = New System.Drawing.Point(105, 112)
        '
        '
        '
        Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.Size = New System.Drawing.Size(607, 108)
        Me.RadGridView1.TabIndex = 0
        Me.RadGridView1.Text = "RadGridView1"
        '
        'Panel_Tab
        '
        Me.Panel_Tab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Tab.Controls.Add(Me.RadTextBox_MatCost)
        Me.Panel_Tab.Controls.Add(Me.RadTextBox_TabCost)
        Me.Panel_Tab.Controls.Add(Me.RadLabel_Mm8)
        Me.Panel_Tab.Controls.Add(Me.RadTextBox_Hole)
        Me.Panel_Tab.Controls.Add(Me.RadLabel_Hole)
        Me.Panel_Tab.Controls.Add(Me.RadTextBox_NoDot)
        Me.Panel_Tab.Controls.Add(Me.RadLabel_NoDot)
        Me.Panel_Tab.Controls.Add(Me.RadTextBox_L2)
        Me.Panel_Tab.Controls.Add(Me.RadLabel_L2)
        Me.Panel_Tab.Controls.Add(Me.RadTextBox_L1)
        Me.Panel_Tab.Controls.Add(Me.RadLabel_L1)
        Me.Panel_Tab.Controls.Add(Me.RadLabel_Mm7)
        Me.Panel_Tab.Controls.Add(Me.RadTextBox_TabAmount)
        Me.Panel_Tab.Controls.Add(Me.RadLabel_Tab)
        Me.Panel_Tab.Controls.Add(Me.RadDropDownList_Tab)
        Me.Panel_Tab.Location = New System.Drawing.Point(2, 219)
        Me.Panel_Tab.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Tab.MinimumSize = New System.Drawing.Size(731, 31)
        Me.Panel_Tab.Name = "Panel_Tab"
        Me.Panel_Tab.Size = New System.Drawing.Size(731, 33)
        Me.Panel_Tab.TabIndex = 12
        '
        'RadTextBox_MatCost
        '
        Me.RadTextBox_MatCost.Enabled = false
        Me.RadTextBox_MatCost.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_MatCost.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_MatCost.Location = New System.Drawing.Point(159, 4)
        Me.RadTextBox_MatCost.MinimumSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_MatCost.Name = "RadTextBox_MatCost"
        '
        '
        '
        Me.RadTextBox_MatCost.RootElement.MinSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_MatCost.Size = New System.Drawing.Size(48, 20)
        Me.RadTextBox_MatCost.TabIndex = 93
        Me.RadTextBox_MatCost.Text = "0"
        Me.RadTextBox_MatCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_MatCost.Visible = false
        '
        'RadTextBox_TabCost
        '
        Me.RadTextBox_TabCost.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_TabCost.Enabled = false
        Me.RadTextBox_TabCost.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_TabCost.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_TabCost.Location = New System.Drawing.Point(340, 4)
        Me.RadTextBox_TabCost.Name = "RadTextBox_TabCost"
        '
        '
        '
        Me.RadTextBox_TabCost.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_TabCost.Size = New System.Drawing.Size(36, 20)
        Me.RadTextBox_TabCost.TabIndex = 92
        Me.RadTextBox_TabCost.Text = "0"
        Me.RadTextBox_TabCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_Mm8
        '
        Me.RadLabel_Mm8.AutoSize = false
        Me.RadLabel_Mm8.Font = New System.Drawing.Font("Segoe UI", 7!)
        Me.RadLabel_Mm8.Location = New System.Drawing.Point(675, 4)
        Me.RadLabel_Mm8.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Mm8.Name = "RadLabel_Mm8"
        Me.RadLabel_Mm8.Size = New System.Drawing.Size(30, 20)
        Me.RadLabel_Mm8.TabIndex = 91
        Me.RadLabel_Mm8.Text = "Units_Mm"
        Me.RadLabel_Mm8.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadTextBox_Hole
        '
        Me.RadTextBox_Hole.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_Hole.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Hole.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Hole.Location = New System.Drawing.Point(650, 4)
        Me.RadTextBox_Hole.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_Hole.Name = "RadTextBox_Hole"
        '
        '
        '
        Me.RadTextBox_Hole.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Hole.Size = New System.Drawing.Size(25, 20)
        Me.RadTextBox_Hole.TabIndex = 90
        Me.RadTextBox_Hole.Text = "6"
        Me.RadTextBox_Hole.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_Hole
        '
        Me.RadLabel_Hole.AutoSize = false
        Me.RadLabel_Hole.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_Hole.Location = New System.Drawing.Point(595, 4)
        Me.RadLabel_Hole.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Hole.Name = "RadLabel_Hole"
        Me.RadLabel_Hole.Size = New System.Drawing.Size(52, 20)
        Me.RadLabel_Hole.TabIndex = 89
        Me.RadLabel_Hole.Text = "ScratchP_Hole"
        Me.RadLabel_Hole.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_NoDot
        '
        Me.RadTextBox_NoDot.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_NoDot.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_NoDot.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_NoDot.Location = New System.Drawing.Point(575, 4)
        Me.RadTextBox_NoDot.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_NoDot.Name = "RadTextBox_NoDot"
        '
        '
        '
        Me.RadTextBox_NoDot.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_NoDot.Size = New System.Drawing.Size(20, 20)
        Me.RadTextBox_NoDot.TabIndex = 88
        Me.RadTextBox_NoDot.Text = "6"
        Me.RadTextBox_NoDot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_NoDot
        '
        Me.RadLabel_NoDot.AutoSize = false
        Me.RadLabel_NoDot.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_NoDot.Location = New System.Drawing.Point(542, 4)
        Me.RadLabel_NoDot.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_NoDot.Name = "RadLabel_NoDot"
        Me.RadLabel_NoDot.Size = New System.Drawing.Size(30, 20)
        Me.RadLabel_NoDot.TabIndex = 87
        Me.RadLabel_NoDot.Text = "ScratchP_NoDot"
        Me.RadLabel_NoDot.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_L2
        '
        Me.RadTextBox_L2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_L2.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_L2.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_L2.Location = New System.Drawing.Point(488, 4)
        Me.RadTextBox_L2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_L2.Name = "RadTextBox_L2"
        '
        '
        '
        Me.RadTextBox_L2.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_L2.Size = New System.Drawing.Size(25, 20)
        Me.RadTextBox_L2.TabIndex = 86
        Me.RadTextBox_L2.Text = "60"
        Me.RadTextBox_L2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_L2
        '
        Me.RadLabel_L2.AutoSize = false
        Me.RadLabel_L2.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_L2.Location = New System.Drawing.Point(460, 4)
        Me.RadLabel_L2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_L2.Name = "RadLabel_L2"
        Me.RadLabel_L2.Size = New System.Drawing.Size(25, 20)
        Me.RadLabel_L2.TabIndex = 85
        Me.RadLabel_L2.Text = "ScratchP_L2"
        Me.RadLabel_L2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_L1
        '
        Me.RadTextBox_L1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_L1.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_L1.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_L1.Location = New System.Drawing.Point(435, 4)
        Me.RadTextBox_L1.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_L1.Name = "RadTextBox_L1"
        '
        '
        '
        Me.RadTextBox_L1.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_L1.Size = New System.Drawing.Size(25, 20)
        Me.RadTextBox_L1.TabIndex = 84
        Me.RadTextBox_L1.Text = "60"
        Me.RadTextBox_L1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_L1
        '
        Me.RadLabel_L1.AutoSize = false
        Me.RadLabel_L1.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_L1.Location = New System.Drawing.Point(407, 4)
        Me.RadLabel_L1.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_L1.Name = "RadLabel_L1"
        Me.RadLabel_L1.Size = New System.Drawing.Size(25, 20)
        Me.RadLabel_L1.TabIndex = 83
        Me.RadLabel_L1.Text = "ScratchP_L1"
        Me.RadLabel_L1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_Mm7
        '
        Me.RadLabel_Mm7.AutoSize = false
        Me.RadLabel_Mm7.Font = New System.Drawing.Font("Segoe UI", 7!)
        Me.RadLabel_Mm7.Location = New System.Drawing.Point(513, 4)
        Me.RadLabel_Mm7.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Mm7.Name = "RadLabel_Mm7"
        Me.RadLabel_Mm7.Size = New System.Drawing.Size(30, 20)
        Me.RadLabel_Mm7.TabIndex = 82
        Me.RadLabel_Mm7.Text = "Units_Mm"
        Me.RadLabel_Mm7.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadTextBox_TabAmount
        '
        Me.RadTextBox_TabAmount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_TabAmount.Enabled = false
        Me.RadTextBox_TabAmount.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_TabAmount.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_TabAmount.Location = New System.Drawing.Point(285, 4)
        Me.RadTextBox_TabAmount.MinimumSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_TabAmount.Name = "RadTextBox_TabAmount"
        '
        '
        '
        Me.RadTextBox_TabAmount.RootElement.MinSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_TabAmount.Size = New System.Drawing.Size(48, 20)
        Me.RadTextBox_TabAmount.TabIndex = 74
        Me.RadTextBox_TabAmount.Text = "2,705"
        Me.RadTextBox_TabAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_Tab
        '
        Me.RadLabel_Tab.AutoSize = false
        Me.RadLabel_Tab.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Tab.Location = New System.Drawing.Point(2, 1)
        Me.RadLabel_Tab.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Tab.Name = "RadLabel_Tab"
        '
        '
        '
        Me.RadLabel_Tab.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadLabel_Tab.Size = New System.Drawing.Size(42, 25)
        Me.RadLabel_Tab.TabIndex = 72
        Me.RadLabel_Tab.Text = "ScratchP_Tab"
        Me.RadLabel_Tab.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadDropDownList_Tab
        '
        Me.RadDropDownList_Tab.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadDropDownList_Tab.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Tab.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Tab.Location = New System.Drawing.Point(48, 3)
        Me.RadDropDownList_Tab.Margin = New System.Windows.Forms.Padding(0)
        Me.RadDropDownList_Tab.MinimumSize = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Tab.Name = "RadDropDownList_Tab"
        '
        '
        '
        Me.RadDropDownList_Tab.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.RadDropDownList_Tab.RootElement.MinSize = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Tab.Size = New System.Drawing.Size(104, 23)
        Me.RadDropDownList_Tab.TabIndex = 73
        Me.RadDropDownList_Tab.Text = "P200008800"
        '
        'Panel_TissueRight
        '
        Me.Panel_TissueRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_TissueRight.Controls.Add(Me.RadLabel_Mm5)
        Me.Panel_TissueRight.Controls.Add(Me.RadLabel_Mandrel)
        Me.Panel_TissueRight.Controls.Add(Me.RadLabel_CanCode)
        Me.Panel_TissueRight.Controls.Add(Me.RadLabel_CanInt)
        Me.Panel_TissueRight.Controls.Add(Me.RadTextBox_CanInt)
        Me.Panel_TissueRight.Controls.Add(Me.RadTextBox_Mandrel)
        Me.Panel_TissueRight.Controls.Add(Me.RadTextBox_CanCode)
        Me.Panel_TissueRight.Controls.Add(Me.RadLabel_Mm6)
        Me.Panel_TissueRight.Location = New System.Drawing.Point(592, 139)
        Me.Panel_TissueRight.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_TissueRight.MinimumSize = New System.Drawing.Size(141, 75)
        Me.Panel_TissueRight.Name = "Panel_TissueRight"
        Me.Panel_TissueRight.Size = New System.Drawing.Size(141, 77)
        Me.Panel_TissueRight.TabIndex = 15
        '
        'RadLabel_Mm5
        '
        Me.RadLabel_Mm5.AutoSize = false
        Me.RadLabel_Mm5.Font = New System.Drawing.Font("Segoe UI", 7!)
        Me.RadLabel_Mm5.Location = New System.Drawing.Point(106, 2)
        Me.RadLabel_Mm5.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Mm5.Name = "RadLabel_Mm5"
        Me.RadLabel_Mm5.Size = New System.Drawing.Size(30, 20)
        Me.RadLabel_Mm5.TabIndex = 82
        Me.RadLabel_Mm5.Text = "Units_Mm"
        Me.RadLabel_Mm5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_Mandrel
        '
        Me.RadLabel_Mandrel.AutoSize = false
        Me.RadLabel_Mandrel.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_Mandrel.Location = New System.Drawing.Point(-1, 51)
        Me.RadLabel_Mandrel.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Mandrel.Name = "RadLabel_Mandrel"
        Me.RadLabel_Mandrel.Size = New System.Drawing.Size(59, 20)
        Me.RadLabel_Mandrel.TabIndex = 78
        Me.RadLabel_Mandrel.Text = "ScratchP_Mandrel"
        Me.RadLabel_Mandrel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadLabel_CanCode
        '
        Me.RadLabel_CanCode.AutoSize = false
        Me.RadLabel_CanCode.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_CanCode.Location = New System.Drawing.Point(-1, 27)
        Me.RadLabel_CanCode.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_CanCode.Name = "RadLabel_CanCode"
        Me.RadLabel_CanCode.Size = New System.Drawing.Size(59, 20)
        Me.RadLabel_CanCode.TabIndex = 79
        Me.RadLabel_CanCode.Text = "ScratchP_CanCode"
        Me.RadLabel_CanCode.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadLabel_CanInt
        '
        Me.RadLabel_CanInt.AutoSize = false
        Me.RadLabel_CanInt.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_CanInt.Location = New System.Drawing.Point(-1, 2)
        Me.RadLabel_CanInt.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_CanInt.Name = "RadLabel_CanInt"
        Me.RadLabel_CanInt.Size = New System.Drawing.Size(59, 20)
        Me.RadLabel_CanInt.TabIndex = 80
        Me.RadLabel_CanInt.Text = "ScratchP_CanInt"
        Me.RadLabel_CanInt.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadTextBox_CanInt
        '
        Me.RadTextBox_CanInt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_CanInt.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_CanInt.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_CanInt.Location = New System.Drawing.Point(60, 2)
        Me.RadTextBox_CanInt.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_CanInt.MinimumSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_CanInt.Name = "RadTextBox_CanInt"
        '
        '
        '
        Me.RadTextBox_CanInt.RootElement.MinSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_CanInt.Size = New System.Drawing.Size(47, 20)
        Me.RadTextBox_CanInt.TabIndex = 77
        Me.RadTextBox_CanInt.Text = "83,5"
        Me.RadTextBox_CanInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadTextBox_Mandrel
        '
        Me.RadTextBox_Mandrel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_Mandrel.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Mandrel.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Mandrel.Location = New System.Drawing.Point(60, 51)
        Me.RadTextBox_Mandrel.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_Mandrel.MinimumSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_Mandrel.Name = "RadTextBox_Mandrel"
        '
        '
        '
        Me.RadTextBox_Mandrel.RootElement.MinSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_Mandrel.Size = New System.Drawing.Size(47, 20)
        Me.RadTextBox_Mandrel.TabIndex = 75
        Me.RadTextBox_Mandrel.Text = "10"
        Me.RadTextBox_Mandrel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadTextBox_CanCode
        '
        Me.RadTextBox_CanCode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_CanCode.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_CanCode.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_CanCode.Location = New System.Drawing.Point(60, 27)
        Me.RadTextBox_CanCode.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_CanCode.MinimumSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_CanCode.Name = "RadTextBox_CanCode"
        '
        '
        '
        Me.RadTextBox_CanCode.RootElement.MinSize = New System.Drawing.Size(47, 20)
        Me.RadTextBox_CanCode.Size = New System.Drawing.Size(47, 20)
        Me.RadTextBox_CanCode.TabIndex = 76
        Me.RadTextBox_CanCode.Text = "QT/Q8L"
        Me.RadTextBox_CanCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel_Mm6
        '
        Me.RadLabel_Mm6.AutoSize = false
        Me.RadLabel_Mm6.Font = New System.Drawing.Font("Segoe UI", 7!)
        Me.RadLabel_Mm6.Location = New System.Drawing.Point(106, 51)
        Me.RadLabel_Mm6.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Mm6.Name = "RadLabel_Mm6"
        Me.RadLabel_Mm6.Size = New System.Drawing.Size(30, 20)
        Me.RadLabel_Mm6.TabIndex = 81
        Me.RadLabel_Mm6.Text = "Units_Mm"
        Me.RadLabel_Mm6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl_Ctl
        '
        Me.TabControl_Ctl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TabControl_Ctl.Controls.Add(Me.Tab_Ctl)
        Me.TabControl_Ctl.Controls.Add(Me.Tab_Cost)
        Me.TabControl_Ctl.Controls.Add(Me.Tab_Yield)
        Me.TabControl_Ctl.Controls.Add(Me.Tab_Lab)
        Me.TabControl_Ctl.Controls.Add(Me.Tab_OldTab)
        Me.TabControl_Ctl.Controls.Add(Me.Tab_OldTab2)
        Me.TabControl_Ctl.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.TabControl_Ctl.ItemSize = New System.Drawing.Size(38, 18)
        Me.TabControl_Ctl.Location = New System.Drawing.Point(736, 138)
        Me.TabControl_Ctl.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl_Ctl.MaximumSize = New System.Drawing.Size(252, 150)
        Me.TabControl_Ctl.MinimumSize = New System.Drawing.Size(237, 150)
        Me.TabControl_Ctl.Name = "TabControl_Ctl"
        Me.TabControl_Ctl.SelectedIndex = 0
        Me.TabControl_Ctl.Size = New System.Drawing.Size(237, 150)
        Me.TabControl_Ctl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl_Ctl.TabIndex = 13
        '
        'Tab_Ctl
        '
        Me.Tab_Ctl.BackColor = System.Drawing.Color.Silver
        Me.Tab_Ctl.Controls.Add(Me.RadLabel_Ctl)
        Me.Tab_Ctl.Controls.Add(Me.RadButton_RelForm)
        Me.Tab_Ctl.Controls.Add(Me.RadCheckBox_DisplayCosts)
        Me.Tab_Ctl.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Ctl.Name = "Tab_Ctl"
        Me.Tab_Ctl.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Ctl.Size = New System.Drawing.Size(229, 124)
        Me.Tab_Ctl.TabIndex = 0
        Me.Tab_Ctl.Text = "ScratchP_Ctl"
        '
        'RadLabel_Ctl
        '
        Me.RadLabel_Ctl.AutoSize = false
        Me.RadLabel_Ctl.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.RadLabel_Ctl.Location = New System.Drawing.Point(15, 49)
        Me.RadLabel_Ctl.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Ctl.Name = "RadLabel_Ctl"
        Me.RadLabel_Ctl.Size = New System.Drawing.Size(198, 53)
        Me.RadLabel_Ctl.TabIndex = 146
        Me.RadLabel_Ctl.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadButton_RelForm
        '
        Me.RadButton_RelForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_RelForm.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_RelForm.ForeColor = System.Drawing.Color.Black
        Me.RadButton_RelForm.Location = New System.Drawing.Point(25, 24)
        Me.RadButton_RelForm.Name = "RadButton_RelForm"
        Me.RadButton_RelForm.Size = New System.Drawing.Size(58, 20)
        Me.RadButton_RelForm.TabIndex = 145
        Me.RadButton_RelForm.Text = "ScratchP_RelForm"
        Me.RadButton_RelForm.TextWrap = true
        '
        'RadCheckBox_DisplayCosts
        '
        Me.RadCheckBox_DisplayCosts.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadCheckBox_DisplayCosts.AutoSize = false
        Me.RadCheckBox_DisplayCosts.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_DisplayCosts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadCheckBox_DisplayCosts.Location = New System.Drawing.Point(96, 24)
        Me.RadCheckBox_DisplayCosts.Name = "RadCheckBox_DisplayCosts"
        Me.RadCheckBox_DisplayCosts.Size = New System.Drawing.Size(110, 20)
        Me.RadCheckBox_DisplayCosts.TabIndex = 87
        Me.RadCheckBox_DisplayCosts.Text = "ScratchP_DisplayCosts"
        Me.RadCheckBox_DisplayCosts.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tab_Cost
        '
        Me.Tab_Cost.BackColor = System.Drawing.Color.Silver
        Me.Tab_Cost.Controls.Add(Me.RadLabel_NoLABData)
        Me.Tab_Cost.Controls.Add(Me.RadLabel_StandardCost)
        Me.Tab_Cost.Controls.Add(Me.RadLabel_VariableCost)
        Me.Tab_Cost.Controls.Add(Me.RadLabel_Labour)
        Me.Tab_Cost.Controls.Add(Me.RadTextBox_StandardCost)
        Me.Tab_Cost.Controls.Add(Me.RadTextBox_VariableCost)
        Me.Tab_Cost.Controls.Add(Me.RadTextBox_Labour)
        Me.Tab_Cost.Controls.Add(Me.RadTextBox_Material)
        Me.Tab_Cost.Controls.Add(Me.RadLabel_Material)
        Me.Tab_Cost.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Cost.Name = "Tab_Cost"
        Me.Tab_Cost.Size = New System.Drawing.Size(229, 124)
        Me.Tab_Cost.TabIndex = 1
        Me.Tab_Cost.Text = "ScratchP_Cost"
        '
        'RadLabel_NoLABData
        '
        Me.RadLabel_NoLABData.AutoSize = false
        Me.RadLabel_NoLABData.BackColor = System.Drawing.Color.Red
        Me.RadLabel_NoLABData.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_NoLABData.ForeColor = System.Drawing.Color.White
        Me.RadLabel_NoLABData.Location = New System.Drawing.Point(74, 34)
        Me.RadLabel_NoLABData.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_NoLABData.Name = "RadLabel_NoLABData"
        Me.RadLabel_NoLABData.Size = New System.Drawing.Size(79, 49)
        Me.RadLabel_NoLABData.TabIndex = 147
        Me.RadLabel_NoLABData.Text = "ScratchP_NoLABData"
        Me.RadLabel_NoLABData.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_NoLABData.Visible = false
        '
        'RadLabel_StandardCost
        '
        Me.RadLabel_StandardCost.AutoSize = false
        Me.RadLabel_StandardCost.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_StandardCost.Location = New System.Drawing.Point(7, 89)
        Me.RadLabel_StandardCost.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_StandardCost.Name = "RadLabel_StandardCost"
        Me.RadLabel_StandardCost.Size = New System.Drawing.Size(105, 23)
        Me.RadLabel_StandardCost.TabIndex = 77
        Me.RadLabel_StandardCost.Text = "ScratchP_StandardCost"
        Me.RadLabel_StandardCost.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_VariableCost
        '
        Me.RadLabel_VariableCost.AutoSize = false
        Me.RadLabel_VariableCost.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_VariableCost.Location = New System.Drawing.Point(7, 63)
        Me.RadLabel_VariableCost.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_VariableCost.Name = "RadLabel_VariableCost"
        Me.RadLabel_VariableCost.Size = New System.Drawing.Size(105, 23)
        Me.RadLabel_VariableCost.TabIndex = 76
        Me.RadLabel_VariableCost.Text = "ScratchP_VariableCost"
        Me.RadLabel_VariableCost.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_Labour
        '
        Me.RadLabel_Labour.AutoSize = false
        Me.RadLabel_Labour.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Labour.Location = New System.Drawing.Point(7, 37)
        Me.RadLabel_Labour.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Labour.Name = "RadLabel_Labour"
        Me.RadLabel_Labour.Size = New System.Drawing.Size(105, 23)
        Me.RadLabel_Labour.TabIndex = 75
        Me.RadLabel_Labour.Text = "ScratchP_Labour"
        Me.RadLabel_Labour.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_StandardCost
        '
        Me.RadTextBox_StandardCost.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_StandardCost.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_StandardCost.Location = New System.Drawing.Point(117, 89)
        Me.RadTextBox_StandardCost.MinimumSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_StandardCost.Name = "RadTextBox_StandardCost"
        '
        '
        '
        Me.RadTextBox_StandardCost.RootElement.MinSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_StandardCost.Size = New System.Drawing.Size(105, 23)
        Me.RadTextBox_StandardCost.TabIndex = 74
        '
        'RadTextBox_VariableCost
        '
        Me.RadTextBox_VariableCost.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_VariableCost.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_VariableCost.Location = New System.Drawing.Point(117, 63)
        Me.RadTextBox_VariableCost.MinimumSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_VariableCost.Name = "RadTextBox_VariableCost"
        '
        '
        '
        Me.RadTextBox_VariableCost.RootElement.MinSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_VariableCost.Size = New System.Drawing.Size(105, 23)
        Me.RadTextBox_VariableCost.TabIndex = 73
        '
        'RadTextBox_Labour
        '
        Me.RadTextBox_Labour.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Labour.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Labour.Location = New System.Drawing.Point(117, 37)
        Me.RadTextBox_Labour.MinimumSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_Labour.Name = "RadTextBox_Labour"
        '
        '
        '
        Me.RadTextBox_Labour.RootElement.MinSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_Labour.Size = New System.Drawing.Size(105, 23)
        Me.RadTextBox_Labour.TabIndex = 72
        '
        'RadTextBox_Material
        '
        Me.RadTextBox_Material.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Material.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Material.Location = New System.Drawing.Point(117, 11)
        Me.RadTextBox_Material.MinimumSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_Material.Name = "RadTextBox_Material"
        '
        '
        '
        Me.RadTextBox_Material.RootElement.MinSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_Material.Size = New System.Drawing.Size(105, 23)
        Me.RadTextBox_Material.TabIndex = 71
        '
        'RadLabel_Material
        '
        Me.RadLabel_Material.AutoSize = false
        Me.RadLabel_Material.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Material.Location = New System.Drawing.Point(7, 11)
        Me.RadLabel_Material.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Material.Name = "RadLabel_Material"
        Me.RadLabel_Material.Size = New System.Drawing.Size(105, 23)
        Me.RadLabel_Material.TabIndex = 53
        Me.RadLabel_Material.Text = "ScratchP_Material"
        Me.RadLabel_Material.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tab_Yield
        '
        Me.Tab_Yield.BackColor = System.Drawing.Color.Silver
        Me.Tab_Yield.Controls.Add(Me.RadTextBox_An3)
        Me.Tab_Yield.Controls.Add(Me.RadTextBox_An2)
        Me.Tab_Yield.Controls.Add(Me.RadTextBox_Tiytg)
        Me.Tab_Yield.Controls.Add(Me.RadTextBox_Anytg)
        Me.Tab_Yield.Controls.Add(Me.RadTextBox_CaYC)
        Me.Tab_Yield.Controls.Add(Me.RadTextBox_An1)
        Me.Tab_Yield.Controls.Add(Me.RadTextBox_Ti3)
        Me.Tab_Yield.Controls.Add(Me.RadTextBox_Ti2)
        Me.Tab_Yield.Controls.Add(Me.RadTextBox_Ti1YC)
        Me.Tab_Yield.Controls.Add(Me.RadTextBox_OY)
        Me.Tab_Yield.Controls.Add(Me.RadLabel_OY)
        Me.Tab_Yield.Controls.Add(Me.RadTextBox_Caytg)
        Me.Tab_Yield.Controls.Add(Me.RadLabel_Caytg)
        Me.Tab_Yield.Controls.Add(Me.RadLabel_Tiytg)
        Me.Tab_Yield.Controls.Add(Me.RadLabel_CaYC)
        Me.Tab_Yield.Controls.Add(Me.RadLabel_An3)
        Me.Tab_Yield.Controls.Add(Me.RadLabel_Anytg)
        Me.Tab_Yield.Controls.Add(Me.RadLabel_An2)
        Me.Tab_Yield.Controls.Add(Me.RadLabel_An1)
        Me.Tab_Yield.Controls.Add(Me.RadLabel_Ti3)
        Me.Tab_Yield.Controls.Add(Me.RadLabel_Ti2)
        Me.Tab_Yield.Controls.Add(Me.RadLabel_Ti1YC)
        Me.Tab_Yield.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Yield.Name = "Tab_Yield"
        Me.Tab_Yield.Size = New System.Drawing.Size(229, 124)
        Me.Tab_Yield.TabIndex = 2
        Me.Tab_Yield.Text = "ScratchP_Yield"
        '
        'RadTextBox_An3
        '
        Me.RadTextBox_An3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_An3.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_An3.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_An3.Location = New System.Drawing.Point(176, 31)
        Me.RadTextBox_An3.Name = "RadTextBox_An3"
        '
        '
        '
        Me.RadTextBox_An3.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_An3.Size = New System.Drawing.Size(45, 20)
        Me.RadTextBox_An3.TabIndex = 84
        Me.RadTextBox_An3.Text = "0,02837"
        Me.RadTextBox_An3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_An2
        '
        Me.RadTextBox_An2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_An2.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_An2.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_An2.Location = New System.Drawing.Point(108, 31)
        Me.RadTextBox_An2.Name = "RadTextBox_An2"
        '
        '
        '
        Me.RadTextBox_An2.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_An2.Size = New System.Drawing.Size(45, 20)
        Me.RadTextBox_An2.TabIndex = 82
        Me.RadTextBox_An2.Text = "0,02837"
        Me.RadTextBox_An2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_Tiytg
        '
        Me.RadTextBox_Tiytg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_Tiytg.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Tiytg.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Tiytg.Location = New System.Drawing.Point(40, 94)
        Me.RadTextBox_Tiytg.Name = "RadTextBox_Tiytg"
        '
        '
        '
        Me.RadTextBox_Tiytg.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Tiytg.Size = New System.Drawing.Size(45, 20)
        Me.RadTextBox_Tiytg.TabIndex = 81
        Me.RadTextBox_Tiytg.Text = "0,02837"
        Me.RadTextBox_Tiytg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_Anytg
        '
        Me.RadTextBox_Anytg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_Anytg.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Anytg.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Anytg.Location = New System.Drawing.Point(40, 73)
        Me.RadTextBox_Anytg.Name = "RadTextBox_Anytg"
        '
        '
        '
        Me.RadTextBox_Anytg.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Anytg.Size = New System.Drawing.Size(45, 20)
        Me.RadTextBox_Anytg.TabIndex = 74
        Me.RadTextBox_Anytg.Text = "0,02837"
        Me.RadTextBox_Anytg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_CaYC
        '
        Me.RadTextBox_CaYC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_CaYC.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_CaYC.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_CaYC.Location = New System.Drawing.Point(40, 52)
        Me.RadTextBox_CaYC.Name = "RadTextBox_CaYC"
        '
        '
        '
        Me.RadTextBox_CaYC.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_CaYC.Size = New System.Drawing.Size(45, 20)
        Me.RadTextBox_CaYC.TabIndex = 74
        Me.RadTextBox_CaYC.Text = "0,02837"
        Me.RadTextBox_CaYC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_An1
        '
        Me.RadTextBox_An1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_An1.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_An1.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_An1.Location = New System.Drawing.Point(40, 31)
        Me.RadTextBox_An1.Name = "RadTextBox_An1"
        '
        '
        '
        Me.RadTextBox_An1.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_An1.Size = New System.Drawing.Size(45, 20)
        Me.RadTextBox_An1.TabIndex = 73
        Me.RadTextBox_An1.Text = "0,02837"
        Me.RadTextBox_An1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_Ti3
        '
        Me.RadTextBox_Ti3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_Ti3.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Ti3.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Ti3.Location = New System.Drawing.Point(176, 10)
        Me.RadTextBox_Ti3.Name = "RadTextBox_Ti3"
        '
        '
        '
        Me.RadTextBox_Ti3.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Ti3.Size = New System.Drawing.Size(45, 20)
        Me.RadTextBox_Ti3.TabIndex = 80
        Me.RadTextBox_Ti3.Text = "0,02837"
        Me.RadTextBox_Ti3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_Ti2
        '
        Me.RadTextBox_Ti2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_Ti2.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Ti2.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Ti2.Location = New System.Drawing.Point(108, 10)
        Me.RadTextBox_Ti2.Name = "RadTextBox_Ti2"
        '
        '
        '
        Me.RadTextBox_Ti2.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Ti2.Size = New System.Drawing.Size(45, 20)
        Me.RadTextBox_Ti2.TabIndex = 78
        Me.RadTextBox_Ti2.Text = "0,02837"
        Me.RadTextBox_Ti2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_Ti1YC
        '
        Me.RadTextBox_Ti1YC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_Ti1YC.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Ti1YC.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Ti1YC.Location = New System.Drawing.Point(40, 10)
        Me.RadTextBox_Ti1YC.Name = "RadTextBox_Ti1YC"
        '
        '
        '
        Me.RadTextBox_Ti1YC.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Ti1YC.Size = New System.Drawing.Size(45, 20)
        Me.RadTextBox_Ti1YC.TabIndex = 72
        Me.RadTextBox_Ti1YC.Text = "0,02837"
        Me.RadTextBox_Ti1YC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_OY
        '
        Me.RadTextBox_OY.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_OY.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_OY.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_OY.Location = New System.Drawing.Point(140, 94)
        Me.RadTextBox_OY.Name = "RadTextBox_OY"
        '
        '
        '
        Me.RadTextBox_OY.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_OY.Size = New System.Drawing.Size(45, 20)
        Me.RadTextBox_OY.TabIndex = 88
        Me.RadTextBox_OY.Text = "0,02837"
        Me.RadTextBox_OY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_OY
        '
        Me.RadLabel_OY.AutoSize = false
        Me.RadLabel_OY.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_OY.Location = New System.Drawing.Point(100, 94)
        Me.RadLabel_OY.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_OY.Name = "RadLabel_OY"
        Me.RadLabel_OY.Size = New System.Drawing.Size(40, 20)
        Me.RadLabel_OY.TabIndex = 87
        Me.RadLabel_OY.Text = "ScratchP_OY"
        Me.RadLabel_OY.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_Caytg
        '
        Me.RadTextBox_Caytg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_Caytg.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Caytg.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Caytg.Location = New System.Drawing.Point(140, 73)
        Me.RadTextBox_Caytg.Name = "RadTextBox_Caytg"
        '
        '
        '
        Me.RadTextBox_Caytg.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Caytg.Size = New System.Drawing.Size(45, 20)
        Me.RadTextBox_Caytg.TabIndex = 86
        Me.RadTextBox_Caytg.Text = "0,02837"
        Me.RadTextBox_Caytg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_Caytg
        '
        Me.RadLabel_Caytg.AutoSize = false
        Me.RadLabel_Caytg.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Caytg.Location = New System.Drawing.Point(100, 73)
        Me.RadLabel_Caytg.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Caytg.Name = "RadLabel_Caytg"
        Me.RadLabel_Caytg.Size = New System.Drawing.Size(40, 20)
        Me.RadLabel_Caytg.TabIndex = 85
        Me.RadLabel_Caytg.Text = "ScratchP_Caytg"
        Me.RadLabel_Caytg.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_Tiytg
        '
        Me.RadLabel_Tiytg.AutoSize = false
        Me.RadLabel_Tiytg.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Tiytg.Location = New System.Drawing.Point(2, 94)
        Me.RadLabel_Tiytg.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Tiytg.Name = "RadLabel_Tiytg"
        Me.RadLabel_Tiytg.Size = New System.Drawing.Size(38, 20)
        Me.RadLabel_Tiytg.TabIndex = 82
        Me.RadLabel_Tiytg.Text = "ScratchP_Tiytg"
        Me.RadLabel_Tiytg.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_CaYC
        '
        Me.RadLabel_CaYC.AutoSize = false
        Me.RadLabel_CaYC.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_CaYC.Location = New System.Drawing.Point(2, 52)
        Me.RadLabel_CaYC.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_CaYC.Name = "RadLabel_CaYC"
        Me.RadLabel_CaYC.Size = New System.Drawing.Size(38, 20)
        Me.RadLabel_CaYC.TabIndex = 78
        Me.RadLabel_CaYC.Text = "ScratchP_CaYC"
        Me.RadLabel_CaYC.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_An3
        '
        Me.RadLabel_An3.AutoSize = false
        Me.RadLabel_An3.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_An3.Location = New System.Drawing.Point(150, 31)
        Me.RadLabel_An3.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_An3.Name = "RadLabel_An3"
        Me.RadLabel_An3.Size = New System.Drawing.Size(27, 20)
        Me.RadLabel_An3.TabIndex = 83
        Me.RadLabel_An3.Text = "ScratchP_An3"
        Me.RadLabel_An3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_Anytg
        '
        Me.RadLabel_Anytg.AutoSize = false
        Me.RadLabel_Anytg.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Anytg.Location = New System.Drawing.Point(2, 73)
        Me.RadLabel_Anytg.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Anytg.Name = "RadLabel_Anytg"
        Me.RadLabel_Anytg.Size = New System.Drawing.Size(38, 20)
        Me.RadLabel_Anytg.TabIndex = 77
        Me.RadLabel_Anytg.Text = "ScratchP_Anytg"
        Me.RadLabel_Anytg.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_An2
        '
        Me.RadLabel_An2.AutoSize = false
        Me.RadLabel_An2.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_An2.Location = New System.Drawing.Point(82, 31)
        Me.RadLabel_An2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_An2.Name = "RadLabel_An2"
        Me.RadLabel_An2.Size = New System.Drawing.Size(27, 20)
        Me.RadLabel_An2.TabIndex = 81
        Me.RadLabel_An2.Text = "ScratchP_An2"
        Me.RadLabel_An2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_An1
        '
        Me.RadLabel_An1.AutoSize = false
        Me.RadLabel_An1.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_An1.Location = New System.Drawing.Point(2, 31)
        Me.RadLabel_An1.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_An1.Name = "RadLabel_An1"
        Me.RadLabel_An1.Size = New System.Drawing.Size(38, 20)
        Me.RadLabel_An1.TabIndex = 77
        Me.RadLabel_An1.Text = "ScratchP_An1"
        Me.RadLabel_An1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_Ti3
        '
        Me.RadLabel_Ti3.AutoSize = false
        Me.RadLabel_Ti3.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Ti3.Location = New System.Drawing.Point(150, 10)
        Me.RadLabel_Ti3.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Ti3.Name = "RadLabel_Ti3"
        Me.RadLabel_Ti3.Size = New System.Drawing.Size(27, 20)
        Me.RadLabel_Ti3.TabIndex = 79
        Me.RadLabel_Ti3.Text = "ScratchP_Ti3"
        Me.RadLabel_Ti3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_Ti2
        '
        Me.RadLabel_Ti2.AutoSize = false
        Me.RadLabel_Ti2.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Ti2.Location = New System.Drawing.Point(82, 10)
        Me.RadLabel_Ti2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Ti2.Name = "RadLabel_Ti2"
        Me.RadLabel_Ti2.Size = New System.Drawing.Size(27, 20)
        Me.RadLabel_Ti2.TabIndex = 77
        Me.RadLabel_Ti2.Text = "ScratchP_Ti2"
        Me.RadLabel_Ti2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_Ti1YC
        '
        Me.RadLabel_Ti1YC.AutoSize = false
        Me.RadLabel_Ti1YC.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Ti1YC.Location = New System.Drawing.Point(2, 10)
        Me.RadLabel_Ti1YC.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Ti1YC.Name = "RadLabel_Ti1YC"
        Me.RadLabel_Ti1YC.Size = New System.Drawing.Size(38, 20)
        Me.RadLabel_Ti1YC.TabIndex = 76
        Me.RadLabel_Ti1YC.Text = "ScratchP_Ti1YC"
        Me.RadLabel_Ti1YC.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tab_Lab
        '
        Me.Tab_Lab.BackColor = System.Drawing.Color.Silver
        Me.Tab_Lab.Controls.Add(Me.RadTextBox_Dep)
        Me.Tab_Lab.Controls.Add(Me.RadLabel_Dep)
        Me.Tab_Lab.Controls.Add(Me.RadTextBox_Fix)
        Me.Tab_Lab.Controls.Add(Me.RadLabel_Fix)
        Me.Tab_Lab.Controls.Add(Me.RadTextBox_Var)
        Me.Tab_Lab.Controls.Add(Me.RadLabel_Var)
        Me.Tab_Lab.Controls.Add(Me.RadTextBox_WLC)
        Me.Tab_Lab.Controls.Add(Me.RadLabel_WLC)
        Me.Tab_Lab.Controls.Add(Me.RadTextBox_RCost)
        Me.Tab_Lab.Controls.Add(Me.RadLabel_RCost)
        Me.Tab_Lab.Controls.Add(Me.RadTextBox_CLC)
        Me.Tab_Lab.Controls.Add(Me.RadLabel_CLC)
        Me.Tab_Lab.Controls.Add(Me.RadTextBox_T3LC)
        Me.Tab_Lab.Controls.Add(Me.RadLabel_T3LC)
        Me.Tab_Lab.Controls.Add(Me.RadTextBox_A3LC)
        Me.Tab_Lab.Controls.Add(Me.RadLabel_A3LC)
        Me.Tab_Lab.Controls.Add(Me.RadTextBox_T2LC)
        Me.Tab_Lab.Controls.Add(Me.RadLabel_T2LC)
        Me.Tab_Lab.Controls.Add(Me.RadTextBox_A2LC)
        Me.Tab_Lab.Controls.Add(Me.RadLabel_A2LC)
        Me.Tab_Lab.Controls.Add(Me.RadTextBox_T1LC)
        Me.Tab_Lab.Controls.Add(Me.RadLabel_T1LC)
        Me.Tab_Lab.Controls.Add(Me.RadTextBox_A1LC)
        Me.Tab_Lab.Controls.Add(Me.RadLabel_A1LC)
        Me.Tab_Lab.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Lab.Name = "Tab_Lab"
        Me.Tab_Lab.Size = New System.Drawing.Size(229, 124)
        Me.Tab_Lab.TabIndex = 3
        Me.Tab_Lab.Text = "ScratchP_Lab"
        '
        'RadTextBox_Dep
        '
        Me.RadTextBox_Dep.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_Dep.AutoSize = false
        Me.RadTextBox_Dep.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Dep.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Dep.Location = New System.Drawing.Point(158, 104)
        Me.RadTextBox_Dep.Name = "RadTextBox_Dep"
        '
        '
        '
        Me.RadTextBox_Dep.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Dep.Size = New System.Drawing.Size(55, 18)
        Me.RadTextBox_Dep.TabIndex = 101
        Me.RadTextBox_Dep.Text = "0,260933"
        Me.RadTextBox_Dep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_Dep
        '
        Me.RadLabel_Dep.AutoSize = false
        Me.RadLabel_Dep.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Dep.Location = New System.Drawing.Point(113, 105)
        Me.RadLabel_Dep.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Dep.Name = "RadLabel_Dep"
        Me.RadLabel_Dep.Size = New System.Drawing.Size(45, 18)
        Me.RadLabel_Dep.TabIndex = 102
        Me.RadLabel_Dep.Text = "ScratchP_Dep"
        Me.RadLabel_Dep.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_Fix
        '
        Me.RadTextBox_Fix.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_Fix.AutoSize = false
        Me.RadTextBox_Fix.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Fix.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Fix.Location = New System.Drawing.Point(158, 88)
        Me.RadTextBox_Fix.Name = "RadTextBox_Fix"
        '
        '
        '
        Me.RadTextBox_Fix.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Fix.Size = New System.Drawing.Size(55, 18)
        Me.RadTextBox_Fix.TabIndex = 99
        Me.RadTextBox_Fix.Text = "0,260933"
        Me.RadTextBox_Fix.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_Fix
        '
        Me.RadLabel_Fix.AutoSize = false
        Me.RadLabel_Fix.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Fix.Location = New System.Drawing.Point(113, 88)
        Me.RadLabel_Fix.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Fix.Name = "RadLabel_Fix"
        Me.RadLabel_Fix.Size = New System.Drawing.Size(45, 18)
        Me.RadLabel_Fix.TabIndex = 100
        Me.RadLabel_Fix.Text = "ScratchP_Fix"
        Me.RadLabel_Fix.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_Var
        '
        Me.RadTextBox_Var.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_Var.AutoSize = false
        Me.RadTextBox_Var.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Var.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Var.Location = New System.Drawing.Point(158, 71)
        Me.RadTextBox_Var.Name = "RadTextBox_Var"
        '
        '
        '
        Me.RadTextBox_Var.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Var.Size = New System.Drawing.Size(55, 18)
        Me.RadTextBox_Var.TabIndex = 95
        Me.RadTextBox_Var.Text = "0,260933"
        Me.RadTextBox_Var.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_Var
        '
        Me.RadLabel_Var.AutoSize = false
        Me.RadLabel_Var.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Var.Location = New System.Drawing.Point(113, 71)
        Me.RadLabel_Var.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Var.Name = "RadLabel_Var"
        Me.RadLabel_Var.Size = New System.Drawing.Size(45, 18)
        Me.RadLabel_Var.TabIndex = 96
        Me.RadLabel_Var.Text = "ScratchP_Var"
        Me.RadLabel_Var.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_WLC
        '
        Me.RadTextBox_WLC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_WLC.AutoSize = false
        Me.RadTextBox_WLC.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_WLC.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_WLC.Location = New System.Drawing.Point(54, 71)
        Me.RadTextBox_WLC.Name = "RadTextBox_WLC"
        '
        '
        '
        Me.RadTextBox_WLC.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_WLC.Size = New System.Drawing.Size(55, 18)
        Me.RadTextBox_WLC.TabIndex = 93
        Me.RadTextBox_WLC.Text = "0,260933"
        Me.RadTextBox_WLC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_WLC
        '
        Me.RadLabel_WLC.AutoSize = false
        Me.RadLabel_WLC.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_WLC.Location = New System.Drawing.Point(9, 71)
        Me.RadLabel_WLC.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_WLC.Name = "RadLabel_WLC"
        Me.RadLabel_WLC.Size = New System.Drawing.Size(45, 18)
        Me.RadLabel_WLC.TabIndex = 94
        Me.RadLabel_WLC.Text = "ScratchP_WLC"
        Me.RadLabel_WLC.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_RCost
        '
        Me.RadTextBox_RCost.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_RCost.AutoSize = false
        Me.RadTextBox_RCost.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_RCost.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_RCost.Location = New System.Drawing.Point(158, 54)
        Me.RadTextBox_RCost.Name = "RadTextBox_RCost"
        '
        '
        '
        Me.RadTextBox_RCost.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_RCost.Size = New System.Drawing.Size(55, 18)
        Me.RadTextBox_RCost.TabIndex = 91
        Me.RadTextBox_RCost.Text = "0,260933"
        Me.RadTextBox_RCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_RCost
        '
        Me.RadLabel_RCost.AutoSize = false
        Me.RadLabel_RCost.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_RCost.Location = New System.Drawing.Point(113, 54)
        Me.RadLabel_RCost.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_RCost.Name = "RadLabel_RCost"
        Me.RadLabel_RCost.Size = New System.Drawing.Size(45, 18)
        Me.RadLabel_RCost.TabIndex = 92
        Me.RadLabel_RCost.Text = "ScratchP_RCost"
        Me.RadLabel_RCost.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_CLC
        '
        Me.RadTextBox_CLC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_CLC.AutoSize = false
        Me.RadTextBox_CLC.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_CLC.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_CLC.Location = New System.Drawing.Point(54, 54)
        Me.RadTextBox_CLC.Name = "RadTextBox_CLC"
        '
        '
        '
        Me.RadTextBox_CLC.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_CLC.Size = New System.Drawing.Size(55, 18)
        Me.RadTextBox_CLC.TabIndex = 89
        Me.RadTextBox_CLC.Text = "0,260933"
        Me.RadTextBox_CLC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_CLC
        '
        Me.RadLabel_CLC.AutoSize = false
        Me.RadLabel_CLC.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_CLC.Location = New System.Drawing.Point(9, 54)
        Me.RadLabel_CLC.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_CLC.Name = "RadLabel_CLC"
        Me.RadLabel_CLC.Size = New System.Drawing.Size(45, 18)
        Me.RadLabel_CLC.TabIndex = 90
        Me.RadLabel_CLC.Text = "ScratchP_CLC"
        Me.RadLabel_CLC.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_T3LC
        '
        Me.RadTextBox_T3LC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_T3LC.AutoSize = false
        Me.RadTextBox_T3LC.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_T3LC.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_T3LC.Location = New System.Drawing.Point(158, 37)
        Me.RadTextBox_T3LC.Name = "RadTextBox_T3LC"
        '
        '
        '
        Me.RadTextBox_T3LC.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_T3LC.Size = New System.Drawing.Size(55, 18)
        Me.RadTextBox_T3LC.TabIndex = 87
        Me.RadTextBox_T3LC.Text = "0,260933"
        Me.RadTextBox_T3LC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_T3LC
        '
        Me.RadLabel_T3LC.AutoSize = false
        Me.RadLabel_T3LC.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_T3LC.Location = New System.Drawing.Point(113, 37)
        Me.RadLabel_T3LC.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_T3LC.Name = "RadLabel_T3LC"
        Me.RadLabel_T3LC.Size = New System.Drawing.Size(45, 18)
        Me.RadLabel_T3LC.TabIndex = 88
        Me.RadLabel_T3LC.Text = "ScratchP_T3LC"
        Me.RadLabel_T3LC.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_A3LC
        '
        Me.RadTextBox_A3LC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_A3LC.AutoSize = false
        Me.RadTextBox_A3LC.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_A3LC.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_A3LC.Location = New System.Drawing.Point(54, 37)
        Me.RadTextBox_A3LC.Name = "RadTextBox_A3LC"
        '
        '
        '
        Me.RadTextBox_A3LC.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_A3LC.Size = New System.Drawing.Size(55, 18)
        Me.RadTextBox_A3LC.TabIndex = 85
        Me.RadTextBox_A3LC.Text = "0,260933"
        Me.RadTextBox_A3LC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_A3LC
        '
        Me.RadLabel_A3LC.AutoSize = false
        Me.RadLabel_A3LC.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_A3LC.Location = New System.Drawing.Point(9, 37)
        Me.RadLabel_A3LC.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_A3LC.Name = "RadLabel_A3LC"
        Me.RadLabel_A3LC.Size = New System.Drawing.Size(45, 18)
        Me.RadLabel_A3LC.TabIndex = 86
        Me.RadLabel_A3LC.Text = "ScratchP_A3LC"
        Me.RadLabel_A3LC.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_T2LC
        '
        Me.RadTextBox_T2LC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_T2LC.AutoSize = false
        Me.RadTextBox_T2LC.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_T2LC.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_T2LC.Location = New System.Drawing.Point(158, 20)
        Me.RadTextBox_T2LC.Name = "RadTextBox_T2LC"
        '
        '
        '
        Me.RadTextBox_T2LC.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_T2LC.Size = New System.Drawing.Size(55, 18)
        Me.RadTextBox_T2LC.TabIndex = 83
        Me.RadTextBox_T2LC.Text = "0,260933"
        Me.RadTextBox_T2LC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_T2LC
        '
        Me.RadLabel_T2LC.AutoSize = false
        Me.RadLabel_T2LC.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_T2LC.Location = New System.Drawing.Point(113, 20)
        Me.RadLabel_T2LC.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_T2LC.Name = "RadLabel_T2LC"
        Me.RadLabel_T2LC.Size = New System.Drawing.Size(45, 18)
        Me.RadLabel_T2LC.TabIndex = 84
        Me.RadLabel_T2LC.Text = "ScratchP_T2LC"
        Me.RadLabel_T2LC.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_A2LC
        '
        Me.RadTextBox_A2LC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_A2LC.AutoSize = false
        Me.RadTextBox_A2LC.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_A2LC.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_A2LC.Location = New System.Drawing.Point(54, 20)
        Me.RadTextBox_A2LC.Name = "RadTextBox_A2LC"
        '
        '
        '
        Me.RadTextBox_A2LC.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_A2LC.Size = New System.Drawing.Size(55, 18)
        Me.RadTextBox_A2LC.TabIndex = 81
        Me.RadTextBox_A2LC.Text = "0,260933"
        Me.RadTextBox_A2LC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_A2LC
        '
        Me.RadLabel_A2LC.AutoSize = false
        Me.RadLabel_A2LC.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_A2LC.Location = New System.Drawing.Point(9, 20)
        Me.RadLabel_A2LC.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_A2LC.Name = "RadLabel_A2LC"
        Me.RadLabel_A2LC.Size = New System.Drawing.Size(45, 18)
        Me.RadLabel_A2LC.TabIndex = 82
        Me.RadLabel_A2LC.Text = "ScratchP_A2LC"
        Me.RadLabel_A2LC.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_T1LC
        '
        Me.RadTextBox_T1LC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_T1LC.AutoSize = false
        Me.RadTextBox_T1LC.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_T1LC.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_T1LC.Location = New System.Drawing.Point(158, 3)
        Me.RadTextBox_T1LC.Name = "RadTextBox_T1LC"
        '
        '
        '
        Me.RadTextBox_T1LC.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_T1LC.Size = New System.Drawing.Size(55, 18)
        Me.RadTextBox_T1LC.TabIndex = 79
        Me.RadTextBox_T1LC.Text = "0,260933"
        Me.RadTextBox_T1LC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_T1LC
        '
        Me.RadLabel_T1LC.AutoSize = false
        Me.RadLabel_T1LC.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_T1LC.Location = New System.Drawing.Point(113, 3)
        Me.RadLabel_T1LC.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_T1LC.Name = "RadLabel_T1LC"
        Me.RadLabel_T1LC.Size = New System.Drawing.Size(45, 18)
        Me.RadLabel_T1LC.TabIndex = 80
        Me.RadLabel_T1LC.Text = "ScratchP_T1LC"
        Me.RadLabel_T1LC.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_A1LC
        '
        Me.RadTextBox_A1LC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_A1LC.AutoSize = false
        Me.RadTextBox_A1LC.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_A1LC.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_A1LC.Location = New System.Drawing.Point(54, 3)
        Me.RadTextBox_A1LC.Name = "RadTextBox_A1LC"
        '
        '
        '
        Me.RadTextBox_A1LC.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_A1LC.Size = New System.Drawing.Size(55, 18)
        Me.RadTextBox_A1LC.TabIndex = 77
        Me.RadTextBox_A1LC.Text = "0,260933"
        Me.RadTextBox_A1LC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_A1LC
        '
        Me.RadLabel_A1LC.AutoSize = false
        Me.RadLabel_A1LC.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_A1LC.Location = New System.Drawing.Point(9, 3)
        Me.RadLabel_A1LC.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_A1LC.Name = "RadLabel_A1LC"
        Me.RadLabel_A1LC.Size = New System.Drawing.Size(45, 18)
        Me.RadLabel_A1LC.TabIndex = 78
        Me.RadLabel_A1LC.Text = "ScratchP_A1LC"
        Me.RadLabel_A1LC.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tab_OldTab
        '
        Me.Tab_OldTab.BackColor = System.Drawing.Color.Silver
        Me.Tab_OldTab.Controls.Add(Me.RadLabel_Variable)
        Me.Tab_OldTab.Controls.Add(Me.RadTextBox_TotalCostVariable)
        Me.Tab_OldTab.Controls.Add(Me.RadTextBox_OHCostVariable)
        Me.Tab_OldTab.Controls.Add(Me.RadTextBox_LabourCostVariable)
        Me.Tab_OldTab.Controls.Add(Me.RadTextBox_PartsCostVariable)
        Me.Tab_OldTab.Controls.Add(Me.RadTextBox_WindCostVariable)
        Me.Tab_OldTab.Controls.Add(Me.RadTextBox_TotalCostGross)
        Me.Tab_OldTab.Controls.Add(Me.RadLabel_TotalCost)
        Me.Tab_OldTab.Controls.Add(Me.RadTextBox_OHCostGross)
        Me.Tab_OldTab.Controls.Add(Me.RadLabel_OHCost)
        Me.Tab_OldTab.Controls.Add(Me.RadTextBox_LabourCostGross)
        Me.Tab_OldTab.Controls.Add(Me.RadLabel_LabourCost)
        Me.Tab_OldTab.Controls.Add(Me.RadTextBox_PartsCostGross)
        Me.Tab_OldTab.Controls.Add(Me.RadLabel_PartsCost)
        Me.Tab_OldTab.Controls.Add(Me.RadTextBox_WindCostGross)
        Me.Tab_OldTab.Controls.Add(Me.RadLabel_WindCost)
        Me.Tab_OldTab.Controls.Add(Me.RadLabel_Gross)
        Me.Tab_OldTab.Location = New System.Drawing.Point(4, 22)
        Me.Tab_OldTab.Name = "Tab_OldTab"
        Me.Tab_OldTab.Size = New System.Drawing.Size(229, 124)
        Me.Tab_OldTab.TabIndex = 4
        Me.Tab_OldTab.Text = "ScratchP_OldTab"
        '
        'RadLabel_Variable
        '
        Me.RadLabel_Variable.AutoSize = false
        Me.RadLabel_Variable.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Variable.Location = New System.Drawing.Point(146, 6)
        Me.RadLabel_Variable.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Variable.Name = "RadLabel_Variable"
        Me.RadLabel_Variable.Size = New System.Drawing.Size(55, 18)
        Me.RadLabel_Variable.TabIndex = 118
        Me.RadLabel_Variable.Text = "ScratchP_Variable"
        Me.RadLabel_Variable.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadTextBox_TotalCostVariable
        '
        Me.RadTextBox_TotalCostVariable.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_TotalCostVariable.AutoSize = false
        Me.RadTextBox_TotalCostVariable.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_TotalCostVariable.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_TotalCostVariable.Location = New System.Drawing.Point(146, 99)
        Me.RadTextBox_TotalCostVariable.Name = "RadTextBox_TotalCostVariable"
        '
        '
        '
        Me.RadTextBox_TotalCostVariable.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_TotalCostVariable.Size = New System.Drawing.Size(55, 18)
        Me.RadTextBox_TotalCostVariable.TabIndex = 117
        Me.RadTextBox_TotalCostVariable.Text = "0,260933"
        Me.RadTextBox_TotalCostVariable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_OHCostVariable
        '
        Me.RadTextBox_OHCostVariable.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_OHCostVariable.AutoSize = false
        Me.RadTextBox_OHCostVariable.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_OHCostVariable.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_OHCostVariable.Location = New System.Drawing.Point(146, 80)
        Me.RadTextBox_OHCostVariable.Name = "RadTextBox_OHCostVariable"
        '
        '
        '
        Me.RadTextBox_OHCostVariable.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_OHCostVariable.Size = New System.Drawing.Size(55, 18)
        Me.RadTextBox_OHCostVariable.TabIndex = 116
        Me.RadTextBox_OHCostVariable.Text = "0,260933"
        Me.RadTextBox_OHCostVariable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_LabourCostVariable
        '
        Me.RadTextBox_LabourCostVariable.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_LabourCostVariable.AutoSize = false
        Me.RadTextBox_LabourCostVariable.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_LabourCostVariable.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_LabourCostVariable.Location = New System.Drawing.Point(146, 61)
        Me.RadTextBox_LabourCostVariable.Name = "RadTextBox_LabourCostVariable"
        '
        '
        '
        Me.RadTextBox_LabourCostVariable.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_LabourCostVariable.Size = New System.Drawing.Size(55, 18)
        Me.RadTextBox_LabourCostVariable.TabIndex = 115
        Me.RadTextBox_LabourCostVariable.Text = "0,260933"
        Me.RadTextBox_LabourCostVariable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_PartsCostVariable
        '
        Me.RadTextBox_PartsCostVariable.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_PartsCostVariable.AutoSize = false
        Me.RadTextBox_PartsCostVariable.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_PartsCostVariable.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_PartsCostVariable.Location = New System.Drawing.Point(146, 42)
        Me.RadTextBox_PartsCostVariable.Name = "RadTextBox_PartsCostVariable"
        '
        '
        '
        Me.RadTextBox_PartsCostVariable.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_PartsCostVariable.Size = New System.Drawing.Size(55, 18)
        Me.RadTextBox_PartsCostVariable.TabIndex = 114
        Me.RadTextBox_PartsCostVariable.Text = "0,260933"
        Me.RadTextBox_PartsCostVariable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_WindCostVariable
        '
        Me.RadTextBox_WindCostVariable.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_WindCostVariable.AutoSize = false
        Me.RadTextBox_WindCostVariable.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_WindCostVariable.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_WindCostVariable.Location = New System.Drawing.Point(146, 23)
        Me.RadTextBox_WindCostVariable.Name = "RadTextBox_WindCostVariable"
        '
        '
        '
        Me.RadTextBox_WindCostVariable.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_WindCostVariable.Size = New System.Drawing.Size(55, 18)
        Me.RadTextBox_WindCostVariable.TabIndex = 113
        Me.RadTextBox_WindCostVariable.Text = "0,260933"
        Me.RadTextBox_WindCostVariable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_TotalCostGross
        '
        Me.RadTextBox_TotalCostGross.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_TotalCostGross.AutoSize = false
        Me.RadTextBox_TotalCostGross.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_TotalCostGross.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_TotalCostGross.Location = New System.Drawing.Point(89, 99)
        Me.RadTextBox_TotalCostGross.Name = "RadTextBox_TotalCostGross"
        '
        '
        '
        Me.RadTextBox_TotalCostGross.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_TotalCostGross.Size = New System.Drawing.Size(55, 18)
        Me.RadTextBox_TotalCostGross.TabIndex = 111
        Me.RadTextBox_TotalCostGross.Text = "0,260933"
        Me.RadTextBox_TotalCostGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_TotalCost
        '
        Me.RadLabel_TotalCost.AutoSize = false
        Me.RadLabel_TotalCost.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_TotalCost.Location = New System.Drawing.Point(19, 99)
        Me.RadLabel_TotalCost.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_TotalCost.Name = "RadLabel_TotalCost"
        Me.RadLabel_TotalCost.Size = New System.Drawing.Size(70, 18)
        Me.RadLabel_TotalCost.TabIndex = 112
        Me.RadLabel_TotalCost.Text = "ScratchP_TotalCost"
        Me.RadLabel_TotalCost.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_OHCostGross
        '
        Me.RadTextBox_OHCostGross.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_OHCostGross.AutoSize = false
        Me.RadTextBox_OHCostGross.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_OHCostGross.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_OHCostGross.Location = New System.Drawing.Point(89, 80)
        Me.RadTextBox_OHCostGross.Name = "RadTextBox_OHCostGross"
        '
        '
        '
        Me.RadTextBox_OHCostGross.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_OHCostGross.Size = New System.Drawing.Size(55, 18)
        Me.RadTextBox_OHCostGross.TabIndex = 109
        Me.RadTextBox_OHCostGross.Text = "0,260933"
        Me.RadTextBox_OHCostGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_OHCost
        '
        Me.RadLabel_OHCost.AutoSize = false
        Me.RadLabel_OHCost.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_OHCost.Location = New System.Drawing.Point(19, 80)
        Me.RadLabel_OHCost.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_OHCost.Name = "RadLabel_OHCost"
        Me.RadLabel_OHCost.Size = New System.Drawing.Size(70, 18)
        Me.RadLabel_OHCost.TabIndex = 110
        Me.RadLabel_OHCost.Text = "ScratchP_OHCost"
        Me.RadLabel_OHCost.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_LabourCostGross
        '
        Me.RadTextBox_LabourCostGross.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_LabourCostGross.AutoSize = false
        Me.RadTextBox_LabourCostGross.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_LabourCostGross.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_LabourCostGross.Location = New System.Drawing.Point(89, 61)
        Me.RadTextBox_LabourCostGross.Name = "RadTextBox_LabourCostGross"
        '
        '
        '
        Me.RadTextBox_LabourCostGross.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_LabourCostGross.Size = New System.Drawing.Size(55, 18)
        Me.RadTextBox_LabourCostGross.TabIndex = 107
        Me.RadTextBox_LabourCostGross.Text = "0,260933"
        Me.RadTextBox_LabourCostGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_LabourCost
        '
        Me.RadLabel_LabourCost.AutoSize = false
        Me.RadLabel_LabourCost.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_LabourCost.Location = New System.Drawing.Point(19, 61)
        Me.RadLabel_LabourCost.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_LabourCost.Name = "RadLabel_LabourCost"
        Me.RadLabel_LabourCost.Size = New System.Drawing.Size(70, 18)
        Me.RadLabel_LabourCost.TabIndex = 108
        Me.RadLabel_LabourCost.Text = "ScratchP_LabourCost"
        Me.RadLabel_LabourCost.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_PartsCostGross
        '
        Me.RadTextBox_PartsCostGross.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_PartsCostGross.AutoSize = false
        Me.RadTextBox_PartsCostGross.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_PartsCostGross.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_PartsCostGross.Location = New System.Drawing.Point(89, 42)
        Me.RadTextBox_PartsCostGross.Name = "RadTextBox_PartsCostGross"
        '
        '
        '
        Me.RadTextBox_PartsCostGross.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_PartsCostGross.Size = New System.Drawing.Size(55, 18)
        Me.RadTextBox_PartsCostGross.TabIndex = 105
        Me.RadTextBox_PartsCostGross.Text = "0,260933"
        Me.RadTextBox_PartsCostGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_PartsCost
        '
        Me.RadLabel_PartsCost.AutoSize = false
        Me.RadLabel_PartsCost.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_PartsCost.Location = New System.Drawing.Point(19, 42)
        Me.RadLabel_PartsCost.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_PartsCost.Name = "RadLabel_PartsCost"
        Me.RadLabel_PartsCost.Size = New System.Drawing.Size(70, 18)
        Me.RadLabel_PartsCost.TabIndex = 106
        Me.RadLabel_PartsCost.Text = "ScratchP_PartsCost"
        Me.RadLabel_PartsCost.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_WindCostGross
        '
        Me.RadTextBox_WindCostGross.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_WindCostGross.AutoSize = false
        Me.RadTextBox_WindCostGross.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_WindCostGross.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_WindCostGross.Location = New System.Drawing.Point(89, 23)
        Me.RadTextBox_WindCostGross.Name = "RadTextBox_WindCostGross"
        '
        '
        '
        Me.RadTextBox_WindCostGross.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_WindCostGross.Size = New System.Drawing.Size(55, 18)
        Me.RadTextBox_WindCostGross.TabIndex = 103
        Me.RadTextBox_WindCostGross.Text = "0,260933"
        Me.RadTextBox_WindCostGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_WindCost
        '
        Me.RadLabel_WindCost.AutoSize = false
        Me.RadLabel_WindCost.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_WindCost.Location = New System.Drawing.Point(19, 23)
        Me.RadLabel_WindCost.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_WindCost.Name = "RadLabel_WindCost"
        Me.RadLabel_WindCost.Size = New System.Drawing.Size(70, 18)
        Me.RadLabel_WindCost.TabIndex = 104
        Me.RadLabel_WindCost.Text = "ScratchP_WindCost"
        Me.RadLabel_WindCost.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_Gross
        '
        Me.RadLabel_Gross.AutoSize = false
        Me.RadLabel_Gross.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Gross.Location = New System.Drawing.Point(89, 6)
        Me.RadLabel_Gross.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Gross.Name = "RadLabel_Gross"
        Me.RadLabel_Gross.Size = New System.Drawing.Size(55, 18)
        Me.RadLabel_Gross.TabIndex = 102
        Me.RadLabel_Gross.Text = "ScratchP_Gross"
        Me.RadLabel_Gross.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tab_OldTab2
        '
        Me.Tab_OldTab2.BackColor = System.Drawing.Color.Silver
        Me.Tab_OldTab2.Controls.Add(Me.RadTextBox_SMV)
        Me.Tab_OldTab2.Controls.Add(Me.RadLabel_SMV)
        Me.Tab_OldTab2.Controls.Add(Me.RadTextBox_Group)
        Me.Tab_OldTab2.Controls.Add(Me.RadLabel_Group)
        Me.Tab_OldTab2.Location = New System.Drawing.Point(4, 22)
        Me.Tab_OldTab2.Name = "Tab_OldTab2"
        Me.Tab_OldTab2.Size = New System.Drawing.Size(229, 124)
        Me.Tab_OldTab2.TabIndex = 5
        Me.Tab_OldTab2.Text = "ScratchP_OldTab2"
        '
        'RadTextBox_SMV
        '
        Me.RadTextBox_SMV.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_SMV.AutoSize = false
        Me.RadTextBox_SMV.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_SMV.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_SMV.Location = New System.Drawing.Point(82, 30)
        Me.RadTextBox_SMV.Name = "RadTextBox_SMV"
        '
        '
        '
        Me.RadTextBox_SMV.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_SMV.Size = New System.Drawing.Size(40, 18)
        Me.RadTextBox_SMV.TabIndex = 109
        Me.RadTextBox_SMV.Text = "152,0"
        Me.RadTextBox_SMV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_SMV
        '
        Me.RadLabel_SMV.AutoSize = false
        Me.RadLabel_SMV.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_SMV.Location = New System.Drawing.Point(12, 30)
        Me.RadLabel_SMV.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_SMV.Name = "RadLabel_SMV"
        Me.RadLabel_SMV.Size = New System.Drawing.Size(70, 18)
        Me.RadLabel_SMV.TabIndex = 110
        Me.RadLabel_SMV.Text = "ScratchP_SMV"
        Me.RadLabel_SMV.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_Group
        '
        Me.RadTextBox_Group.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadTextBox_Group.AutoSize = false
        Me.RadTextBox_Group.Enabled = false
        Me.RadTextBox_Group.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Group.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Group.Location = New System.Drawing.Point(82, 11)
        Me.RadTextBox_Group.Name = "RadTextBox_Group"
        '
        '
        '
        Me.RadTextBox_Group.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_Group.Size = New System.Drawing.Size(40, 18)
        Me.RadTextBox_Group.TabIndex = 107
        Me.RadTextBox_Group.Text = "PT"
        Me.RadTextBox_Group.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel_Group
        '
        Me.RadLabel_Group.AutoSize = false
        Me.RadLabel_Group.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Group.Location = New System.Drawing.Point(12, 11)
        Me.RadLabel_Group.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Group.Name = "RadLabel_Group"
        Me.RadLabel_Group.Size = New System.Drawing.Size(70, 18)
        Me.RadLabel_Group.TabIndex = 108
        Me.RadLabel_Group.Text = "ScratchP_Group"
        Me.RadLabel_Group.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel_CapAndNotes
        '
        Me.Panel_CapAndNotes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Panel_CapAndNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_CapAndNotes.Controls.Add(Me.RadTextBox_GasLife120)
        Me.Panel_CapAndNotes.Controls.Add(Me.RadLabel_GasLife)
        Me.Panel_CapAndNotes.Controls.Add(Me.RadTextBox_GasLife70)
        Me.Panel_CapAndNotes.Controls.Add(Me.RadLabel_VoidSpacecm3)
        Me.Panel_CapAndNotes.Controls.Add(Me.RadTextBox_VoidSpacecm3)
        Me.Panel_CapAndNotes.Controls.Add(Me.RadButton_ESR)
        Me.Panel_CapAndNotes.Controls.Add(Me.RadButton_Store)
        Me.Panel_CapAndNotes.Controls.Add(Me.RadLabel_MicroFarad2)
        Me.Panel_CapAndNotes.Controls.Add(Me.RadLabel_PhysicalCaseFill)
        Me.Panel_CapAndNotes.Controls.Add(Me.RadLabel_MaxCapAt90Fit)
        Me.Panel_CapAndNotes.Controls.Add(Me.RadTextBox_MaxCapAt90Fit)
        Me.Panel_CapAndNotes.Controls.Add(Me.RadTextBox_PhysicalCaseFill)
        Me.Panel_CapAndNotes.Controls.Add(Me.RadCheckBox_Show)
        Me.Panel_CapAndNotes.Controls.Add(Me.RadLabel_DesignNotes)
        Me.Panel_CapAndNotes.Controls.Add(Me.RadTextBox_DesignNotes)
        Me.Panel_CapAndNotes.Controls.Add(Me.RadLabel_GasLife120)
        Me.Panel_CapAndNotes.Controls.Add(Me.RadLabel_GasLife70)
        Me.Panel_CapAndNotes.Location = New System.Drawing.Point(736, 291)
        Me.Panel_CapAndNotes.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_CapAndNotes.MaximumSize = New System.Drawing.Size(252, 224)
        Me.Panel_CapAndNotes.MinimumSize = New System.Drawing.Size(237, 224)
        Me.Panel_CapAndNotes.Name = "Panel_CapAndNotes"
        Me.Panel_CapAndNotes.Size = New System.Drawing.Size(237, 224)
        Me.Panel_CapAndNotes.TabIndex = 14
        '
        'RadTextBox_GasLife120
        '
        Me.RadTextBox_GasLife120.Enabled = false
        Me.RadTextBox_GasLife120.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_GasLife120.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_GasLife120.Location = New System.Drawing.Point(119, 94)
        Me.RadTextBox_GasLife120.MinimumSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_GasLife120.Name = "RadTextBox_GasLife120"
        '
        '
        '
        Me.RadTextBox_GasLife120.RootElement.MinSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_GasLife120.Size = New System.Drawing.Size(48, 20)
        Me.RadTextBox_GasLife120.TabIndex = 149
        Me.RadTextBox_GasLife120.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_GasLife120.Visible = false
        '
        'RadLabel_GasLife
        '
        Me.RadLabel_GasLife.AutoSize = false
        Me.RadLabel_GasLife.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_GasLife.Location = New System.Drawing.Point(34, 72)
        Me.RadLabel_GasLife.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_GasLife.Name = "RadLabel_GasLife"
        Me.RadLabel_GasLife.Size = New System.Drawing.Size(82, 20)
        Me.RadLabel_GasLife.TabIndex = 150
        Me.RadLabel_GasLife.Text = "ScratchP_GassingFailAt"
        Me.RadLabel_GasLife.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_GasLife.Visible = false
        '
        'RadTextBox_GasLife70
        '
        Me.RadTextBox_GasLife70.Enabled = false
        Me.RadTextBox_GasLife70.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_GasLife70.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_GasLife70.Location = New System.Drawing.Point(119, 72)
        Me.RadTextBox_GasLife70.MinimumSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_GasLife70.Name = "RadTextBox_GasLife70"
        '
        '
        '
        Me.RadTextBox_GasLife70.RootElement.MinSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_GasLife70.Size = New System.Drawing.Size(48, 20)
        Me.RadTextBox_GasLife70.TabIndex = 148
        Me.RadTextBox_GasLife70.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_GasLife70.Visible = false
        '
        'RadLabel_VoidSpacecm3
        '
        Me.RadLabel_VoidSpacecm3.AutoSize = false
        Me.RadLabel_VoidSpacecm3.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_VoidSpacecm3.Location = New System.Drawing.Point(5, 50)
        Me.RadLabel_VoidSpacecm3.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_VoidSpacecm3.Name = "RadLabel_VoidSpacecm3"
        Me.RadLabel_VoidSpacecm3.Size = New System.Drawing.Size(111, 20)
        Me.RadLabel_VoidSpacecm3.TabIndex = 147
        Me.RadLabel_VoidSpacecm3.Text = "ScratchP_VoidSpacecm3"
        Me.RadLabel_VoidSpacecm3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_VoidSpacecm3.Visible = false
        '
        'RadTextBox_VoidSpacecm3
        '
        Me.RadTextBox_VoidSpacecm3.Enabled = false
        Me.RadTextBox_VoidSpacecm3.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_VoidSpacecm3.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_VoidSpacecm3.Location = New System.Drawing.Point(119, 50)
        Me.RadTextBox_VoidSpacecm3.MinimumSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_VoidSpacecm3.Name = "RadTextBox_VoidSpacecm3"
        '
        '
        '
        Me.RadTextBox_VoidSpacecm3.RootElement.MinSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_VoidSpacecm3.Size = New System.Drawing.Size(48, 20)
        Me.RadTextBox_VoidSpacecm3.TabIndex = 146
        Me.RadTextBox_VoidSpacecm3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox_VoidSpacecm3.Visible = false
        '
        'RadButton_ESR
        '
        Me.RadButton_ESR.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_ESR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_ESR.ForeColor = System.Drawing.Color.Black
        Me.RadButton_ESR.Location = New System.Drawing.Point(2, 76)
        Me.RadButton_ESR.Name = "RadButton_ESR"
        Me.RadButton_ESR.Size = New System.Drawing.Size(30, 20)
        Me.RadButton_ESR.TabIndex = 145
        Me.RadButton_ESR.Text = "ScratchP_ESR"
        Me.RadButton_ESR.TextWrap = true
        '
        'RadButton_Store
        '
        Me.RadButton_Store.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.RadButton_Store.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Store.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Store.Location = New System.Drawing.Point(168, 28)
        Me.RadButton_Store.Name = "RadButton_Store"
        Me.RadButton_Store.Size = New System.Drawing.Size(60, 20)
        Me.RadButton_Store.TabIndex = 144
        Me.RadButton_Store.Text = "Global_Store"
        Me.RadButton_Store.TextWrap = true
        '
        'RadLabel_MicroFarad2
        '
        Me.RadLabel_MicroFarad2.AutoSize = false
        Me.RadLabel_MicroFarad2.Font = New System.Drawing.Font("Segoe UI", 7!)
        Me.RadLabel_MicroFarad2.Location = New System.Drawing.Point(168, 6)
        Me.RadLabel_MicroFarad2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_MicroFarad2.Name = "RadLabel_MicroFarad2"
        Me.RadLabel_MicroFarad2.Size = New System.Drawing.Size(35, 20)
        Me.RadLabel_MicroFarad2.TabIndex = 143
        Me.RadLabel_MicroFarad2.Text = "Units_MicroFarad"
        Me.RadLabel_MicroFarad2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_PhysicalCaseFill
        '
        Me.RadLabel_PhysicalCaseFill.AutoSize = false
        Me.RadLabel_PhysicalCaseFill.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_PhysicalCaseFill.Location = New System.Drawing.Point(5, 28)
        Me.RadLabel_PhysicalCaseFill.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_PhysicalCaseFill.Name = "RadLabel_PhysicalCaseFill"
        Me.RadLabel_PhysicalCaseFill.Size = New System.Drawing.Size(111, 20)
        Me.RadLabel_PhysicalCaseFill.TabIndex = 142
        Me.RadLabel_PhysicalCaseFill.Text = "ScratchP_PhysicalCaseFill"
        Me.RadLabel_PhysicalCaseFill.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_MaxCapAt90Fit
        '
        Me.RadLabel_MaxCapAt90Fit.AutoSize = false
        Me.RadLabel_MaxCapAt90Fit.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_MaxCapAt90Fit.Location = New System.Drawing.Point(5, 6)
        Me.RadLabel_MaxCapAt90Fit.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_MaxCapAt90Fit.Name = "RadLabel_MaxCapAt90Fit"
        Me.RadLabel_MaxCapAt90Fit.Size = New System.Drawing.Size(111, 20)
        Me.RadLabel_MaxCapAt90Fit.TabIndex = 141
        Me.RadLabel_MaxCapAt90Fit.Text = "ScratchP_MaxCapAt90Fit"
        Me.RadLabel_MaxCapAt90Fit.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_MaxCapAt90Fit
        '
        Me.RadTextBox_MaxCapAt90Fit.Enabled = false
        Me.RadTextBox_MaxCapAt90Fit.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_MaxCapAt90Fit.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_MaxCapAt90Fit.Location = New System.Drawing.Point(119, 6)
        Me.RadTextBox_MaxCapAt90Fit.MinimumSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_MaxCapAt90Fit.Name = "RadTextBox_MaxCapAt90Fit"
        '
        '
        '
        Me.RadTextBox_MaxCapAt90Fit.RootElement.MinSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_MaxCapAt90Fit.Size = New System.Drawing.Size(48, 20)
        Me.RadTextBox_MaxCapAt90Fit.TabIndex = 140
        Me.RadTextBox_MaxCapAt90Fit.Text = "13 088"
        Me.RadTextBox_MaxCapAt90Fit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_PhysicalCaseFill
        '
        Me.RadTextBox_PhysicalCaseFill.Enabled = false
        Me.RadTextBox_PhysicalCaseFill.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_PhysicalCaseFill.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_PhysicalCaseFill.Location = New System.Drawing.Point(119, 28)
        Me.RadTextBox_PhysicalCaseFill.MinimumSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_PhysicalCaseFill.Name = "RadTextBox_PhysicalCaseFill"
        '
        '
        '
        Me.RadTextBox_PhysicalCaseFill.RootElement.MinSize = New System.Drawing.Size(48, 20)
        Me.RadTextBox_PhysicalCaseFill.Size = New System.Drawing.Size(48, 20)
        Me.RadTextBox_PhysicalCaseFill.TabIndex = 139
        Me.RadTextBox_PhysicalCaseFill.Text = "90,12%"
        Me.RadTextBox_PhysicalCaseFill.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadCheckBox_Show
        '
        Me.RadCheckBox_Show.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadCheckBox_Show.AutoSize = false
        Me.RadCheckBox_Show.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Show.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadCheckBox_Show.Location = New System.Drawing.Point(168, 52)
        Me.RadCheckBox_Show.Margin = New System.Windows.Forms.Padding(0)
        Me.RadCheckBox_Show.Name = "RadCheckBox_Show"
        Me.RadCheckBox_Show.Size = New System.Drawing.Size(54, 20)
        Me.RadCheckBox_Show.TabIndex = 137
        Me.RadCheckBox_Show.Text = "Global_Show"
        Me.RadCheckBox_Show.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_DesignNotes
        '
        Me.RadLabel_DesignNotes.AutoSize = false
        Me.RadLabel_DesignNotes.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_DesignNotes.Location = New System.Drawing.Point(2, 97)
        Me.RadLabel_DesignNotes.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_DesignNotes.Name = "RadLabel_DesignNotes"
        Me.RadLabel_DesignNotes.Size = New System.Drawing.Size(114, 22)
        Me.RadLabel_DesignNotes.TabIndex = 132
        Me.RadLabel_DesignNotes.Text = "ScratchP_DesignNotes"
        Me.RadLabel_DesignNotes.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadTextBox_DesignNotes
        '
        Me.RadTextBox_DesignNotes.AutoSize = false
        Me.RadTextBox_DesignNotes.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_DesignNotes.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_DesignNotes.Location = New System.Drawing.Point(1, 120)
        Me.RadTextBox_DesignNotes.Margin = New System.Windows.Forms.Padding(0)
        Me.RadTextBox_DesignNotes.Multiline = true
        Me.RadTextBox_DesignNotes.Name = "RadTextBox_DesignNotes"
        '
        '
        '
        Me.RadTextBox_DesignNotes.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadTextBox_DesignNotes.Size = New System.Drawing.Size(234, 98)
        Me.RadTextBox_DesignNotes.TabIndex = 108
        '
        'RadLabel_GasLife120
        '
        Me.RadLabel_GasLife120.AutoSize = false
        Me.RadLabel_GasLife120.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_GasLife120.Location = New System.Drawing.Point(167, 94)
        Me.RadLabel_GasLife120.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_GasLife120.Name = "RadLabel_GasLife120"
        Me.RadLabel_GasLife120.Size = New System.Drawing.Size(68, 20)
        Me.RadLabel_GasLife120.TabIndex = 152
        Me.RadLabel_GasLife120.Text = "ScratchP_hrs120PSI"
        Me.RadLabel_GasLife120.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_GasLife120.Visible = false
        '
        'RadLabel_GasLife70
        '
        Me.RadLabel_GasLife70.AutoSize = false
        Me.RadLabel_GasLife70.Font = New System.Drawing.Font("Segoe UI", 8!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_GasLife70.Location = New System.Drawing.Point(167, 72)
        Me.RadLabel_GasLife70.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_GasLife70.Name = "RadLabel_GasLife70"
        Me.RadLabel_GasLife70.Size = New System.Drawing.Size(63, 20)
        Me.RadLabel_GasLife70.TabIndex = 151
        Me.RadLabel_GasLife70.Text = "ScratchP_hrs70PSI"
        Me.RadLabel_GasLife70.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_GasLife70.Visible = false
        '
        'ScratchPad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(992, 632)
        Me.Controls.Add(Me.RadScrollablePanel_Container)
        Me.Controls.Add(Me.RadPanel_MenuTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1000, 2000)
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "ScratchPad"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = true
        Me.RootElement.MaxSize = New System.Drawing.Size(1000, 2000)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScratchPad_Title"
        Me.ThemeName = "Windows8"
        CType(Me.RadPanel_MenuTop,System.ComponentModel.ISupportInitialize).EndInit
        Me.RadPanel_MenuTop.ResumeLayout(false)
        Me.RadPanel_MenuTop.PerformLayout
        CType(Me.RadCheckBox_UsePRMSCostReport,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadCheckBox_DesChecked,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_KPartNumber,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel_TopBarGroup2.ResumeLayout(false)
        Me.Panel_TopBarGroup2.PerformLayout
        CType(Me.RadTextBox_DesApp,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Issue,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_QAApp,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Issue,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_DesApp,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Date,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_QAApp,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Date,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_ClearApps,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel_TopBarRadioButtons.ResumeLayout(false)
        CType(Me.RadTextBox_SQApp_2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_SQApp,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_SQApp,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_SDApp,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_SDApp,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Summary,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Summary,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_CelsiusDegreesMin,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_CelsiusDegreesMax,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_CelsiusDegreesMin,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_CelsiusDegreesMax,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Percentage_2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Percentage,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_PositivePercentage,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_NegativePercentage,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Positive,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Negative,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_MicroFarad,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_V,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Volts,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Volts,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Cap,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_ASNo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Dia,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Len,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Len,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_ASNo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Dia_2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Len_2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Dia,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_PrintCost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_ShowSpec,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_PrintDesign,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_PrevSpec,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_PrintEsr,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_DeUser,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Range,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_U,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_R,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Cap,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_PartNumber,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_PartStyle,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_DeleteScratch,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_Evaluate,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_Refresh,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_ShowAllRecs,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_Rename,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_UpdateMain,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_GoToSummary,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_NewDesign,System.ComponentModel.ISupportInitialize).EndInit
        Me.RadScrollablePanel_Container.PanelContainer.ResumeLayout(false)
        CType(Me.RadScrollablePanel_Container,System.ComponentModel.ISupportInitialize).EndInit
        Me.RadScrollablePanel_Container.ResumeLayout(false)
        Me.Panel_SpecificationDetails.ResumeLayout(false)
        Me.Panel_SpecificationDetails.PerformLayout
        CType(Me.RadLabel_SEVtestvoltage,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_SurgeOrVDEvoltage,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_SEVtestvoltage,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_SurgeOrVDEvoltage,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_CelsiusDegrees,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_RatedIr3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_RatedIr3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_RatedIr2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_RatedIr2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Notes,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_RatedIr,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Notes,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_RatedIr,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Dimensions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Terminals,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_SpecDwg,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Distributor,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_CustPNo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Dimensions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Terminals,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_SpecDwg,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Distributor,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_CustPNo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_SpecificationDetails,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Customer,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Customer,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabControl_PrintCatExtra.ResumeLayout(false)
        Me.ScratchP_PrintDetail.ResumeLayout(false)
        CType(Me.RadGroupBox_PrintDetail,System.ComponentModel.ISupportInitialize).EndInit
        Me.RadGroupBox_PrintDetail.ResumeLayout(false)
        Me.RadGroupBox_PrintDetail.PerformLayout
        CType(Me.RadTextBox_PartsCost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_MelCostRaw,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_MelTCost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_MelQty,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_MelinexCost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_PrintDrawing,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_PrintDrawing,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_ViewCentred,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_PrintDetailMax13Lines,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_PrintNotes,System.ComponentModel.ISupportInitialize).EndInit
        Me.ScratchP_CatData.ResumeLayout(false)
        Me.Panel_CatalogueData.ResumeLayout(false)
        Me.Panel_CatalogueData.PerformLayout
        CType(Me.RadTextBox_condy_eq,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_IrT,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_IrF,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Rise_T,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Rbo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Rwb,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_IrT,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_IrF,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Rise_T,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Rbo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Rwb,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Rhw,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Ir,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Rha,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_condy_eq,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_oxide_fi,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_tissue_ti,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_tabbing,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_foil,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Ir,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Rha,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_oxide_fi,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_tissue_ti,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_tabbing,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Rhw,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_foil,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel_CatalogueDataTitle.ResumeLayout(false)
        CType(Me.RadLabel_CatalogueData,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_ViewAllCatData,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadGridView2.MasterTemplate,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadGridView2,System.ComponentModel.ISupportInitialize).EndInit
        Me.ScratchP_ExtraFields.ResumeLayout(false)
        CType(Me.RadButton_EditFields,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadGridView_ExtraFields.MasterTemplate,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadGridView_ExtraFields,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel_Anode.ResumeLayout(false)
        Me.Panel_Anode.PerformLayout
        CType(Me.RadLabel_Cost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Anode3Cost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Anode2Cost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Anode1Cost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Melinex,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Mm3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Mm2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_AnodeLenght2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_AnodeLenght,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Melinex,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_FaradPerSquareCm3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_FaradPerSquareCm2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_MinGain,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_MinGain,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Anode3Amount,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_StdLength,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Anode2Amount,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Anode3Width,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Anode1Width,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Anode3Vf,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_AnodeGain2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Anode3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Anode2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Anode3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Anode2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_MaxLen,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_PercentageFit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Factor,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Anode1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_AnodeGain,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Factor,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_WindingDetails,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadCheckBox_UserGain,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Anode_Vertical,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_MaxLen,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_PercentageFit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Anode1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Vf,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Anode1Vf,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Anode2Vf,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Width,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Anode2Width,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Amount,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Anode1Amount,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Mm,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_FaradPerSquareCm,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_PercentageFit2,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel_Parameters.ResumeLayout(false)
        Me.Panel_Parameters.PerformLayout
        CType(Me.RadLabel_TestVolts,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_IMPAt10000HzAt20C,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_IMPAt10000HzAt20C,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_ESRAt100HzAt20C,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_ESRAt100HzAt20C,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_ParameterCondition,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_ParameterValue,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Parameter,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_ParameterCondition4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_ParameterValue4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_ParameterCondition3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_ParameterValue3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_ParameterCondition2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_ParameterValue2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadCheckBox_ac,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_TestVolts,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_ParameterCondition1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_ParameterValue1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Parameter4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Parameter3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Parameter2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_MicroFarad4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Capacitance2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_to,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_MicroFarad3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Capacitance,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Capacitance,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Parameter1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_GetLimits,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_TestParameters,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel_Cathode.ResumeLayout(false)
        Me.Panel_Cathode.PerformLayout
        CType(Me.RadTextBox_CathodeCost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadCheckBox_Swage,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Swage,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Mm4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_CathExtension,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_CathExtension,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_CathodeVf,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_CathodeAmount,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_CathodeWidth,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Cath,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Cathode,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel_Notes.ResumeLayout(false)
        Me.Panel_Notes.PerformLayout
        CType(Me.RadDropDownList_Note3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Note3Type,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Note2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Note3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Note2Type,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Note2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Note1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Note,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_NoteType,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Note1Type,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Note1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Sequence,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_ArrowRight,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel_NotesLanguages.ResumeLayout(false)
        CType(Me.RadButton_NotesMax10escroutnotes,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel_TopRight.ResumeLayout(false)
        Me.Panel_TopRight.PerformLayout
        CType(Me.RadLabel_SpecDrawing,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_WindingPicture,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_DimensionDwg,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_WindingPicture,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Routing,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_PartsFile,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_SpecDrawing,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_PartsFile,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_DimensionDwg,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Routing,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel_Elyte.ResumeLayout(false)
        Me.Panel_Elyte.PerformLayout
        CType(Me.RadLabel_MiniPrewrap,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_MiniPrewrap,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadCheckBox_AutoWidth,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_ElyteCost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadCheckBox_Scrollbar,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Scrollbar,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_ElyteAmount,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Elyte,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Elyte,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel_Tissue.ResumeLayout(false)
        Me.Panel_Tissue.PerformLayout
        CType(Me.RadTextBox_Tissue3Cost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Tissue2Cost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Tissue1Cost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadCheckBox_AfterWrap,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_AfterWrap,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_PreWrapLength,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_PreWrapLength,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_PreWrapTurns,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_PreWrapTurns,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Tissue3Amount,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Tissue2Amount,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Tissue3Width,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Tissue1Width,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Tissue3Vf,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Tissue_Vertical,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Tissue3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Tissue2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Tissue3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Tissue2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Tissue1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Tissue1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Tissue1Vf,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Tissue2Width,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Tissue1Amount,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Tissue2Vf,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel_Freqs.ResumeLayout(false)
        Me.Panel_Freqs.PerformLayout
        CType(Me.RadButton_MoreDetail,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_LifeCalc,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_WriteCatData,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_Refresh2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_GetData,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_DefaultFreqs,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_HSink,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_EDType,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Mm9,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_VFactorMm,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_EDType,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_AirflowMs,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadCheckBox_UseActualEsr,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_ATc,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_FailMode,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_LifeLop,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_FailMode,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_LifeLop,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_ActEsrTemp,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_UseActualEsr,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_ActEsrTemp,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_ESRFactorKe,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_MaxESRx,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_ESRFactorKe,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_MaxESRx,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_TrForCalcIr,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_MaxCoreTm,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_TrForCalcIr,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_MaxCoreTm,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_VFactorKv,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_StdVfs,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_VFactorKv,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_StdVfs,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_CurrentPaths,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_CurrentPaths,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_AirflowMs,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_ActTrxAtEOLTx,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_ArrheniusT2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_ActTrxAtEOLTx,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_ArrheniusT2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_TrCoreRise,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_AverageTh,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_TrCoreRise,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_AverageTh,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_HSink,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_OpVop,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_OpVop,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadCheckBox_old,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_RHaCperWatt,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_RHaCperWatt,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_LifeFactorLe,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_LifeFactorLe,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_ATc,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_AmbientTa,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_AmbientTa,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadGridView1.MasterTemplate,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel_Tab.ResumeLayout(false)
        Me.Panel_Tab.PerformLayout
        CType(Me.RadTextBox_MatCost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_TabCost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Mm8,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Hole,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Hole,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_NoDot,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_NoDot,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_L2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_L2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_L1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_L1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Mm7,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_TabAmount,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Tab,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadDropDownList_Tab,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel_TissueRight.ResumeLayout(false)
        Me.Panel_TissueRight.PerformLayout
        CType(Me.RadLabel_Mm5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Mandrel,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_CanCode,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_CanInt,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_CanInt,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Mandrel,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_CanCode,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Mm6,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabControl_Ctl.ResumeLayout(false)
        Me.Tab_Ctl.ResumeLayout(false)
        CType(Me.RadLabel_Ctl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_RelForm,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadCheckBox_DisplayCosts,System.ComponentModel.ISupportInitialize).EndInit
        Me.Tab_Cost.ResumeLayout(false)
        Me.Tab_Cost.PerformLayout
        CType(Me.RadLabel_NoLABData,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_StandardCost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_VariableCost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Labour,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_StandardCost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_VariableCost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Labour,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Material,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Material,System.ComponentModel.ISupportInitialize).EndInit
        Me.Tab_Yield.ResumeLayout(false)
        Me.Tab_Yield.PerformLayout
        CType(Me.RadTextBox_An3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_An2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Tiytg,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Anytg,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_CaYC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_An1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Ti3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Ti2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Ti1YC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_OY,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_OY,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Caytg,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Caytg,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Tiytg,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_CaYC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_An3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Anytg,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_An2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_An1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Ti3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Ti2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Ti1YC,System.ComponentModel.ISupportInitialize).EndInit
        Me.Tab_Lab.ResumeLayout(false)
        CType(Me.RadTextBox_Dep,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Dep,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Fix,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Fix,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Var,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Var,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_WLC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_WLC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_RCost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_RCost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_CLC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_CLC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_T3LC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_T3LC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_A3LC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_A3LC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_T2LC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_T2LC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_A2LC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_A2LC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_T1LC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_T1LC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_A1LC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_A1LC,System.ComponentModel.ISupportInitialize).EndInit
        Me.Tab_OldTab.ResumeLayout(false)
        CType(Me.RadLabel_Variable,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_TotalCostVariable,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_OHCostVariable,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_LabourCostVariable,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_PartsCostVariable,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_WindCostVariable,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_TotalCostGross,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_TotalCost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_OHCostGross,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_OHCost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_LabourCostGross,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_LabourCost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_PartsCostGross,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_PartsCost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_WindCostGross,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_WindCost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Gross,System.ComponentModel.ISupportInitialize).EndInit
        Me.Tab_OldTab2.ResumeLayout(false)
        CType(Me.RadTextBox_SMV,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_SMV,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_Group,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_Group,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel_CapAndNotes.ResumeLayout(false)
        Me.Panel_CapAndNotes.PerformLayout
        CType(Me.RadTextBox_GasLife120,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_GasLife,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_GasLife70,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_VoidSpacecm3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_VoidSpacecm3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_ESR,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadButton_Store,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_MicroFarad2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_PhysicalCaseFill,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_MaxCapAt90Fit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_MaxCapAt90Fit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_PhysicalCaseFill,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadCheckBox_Show,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_DesignNotes,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadTextBox_DesignNotes,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_GasLife120,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabel_GasLife70,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents RadPanel_MenuTop As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadButton_Evaluate As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Refresh As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_ShowAllRecs As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Rename As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_UpdateMain As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_DeleteScratch As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_GoToSummary As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_NewDesign As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadTextBox_DeUser As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadDropDownList_Range As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_U As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_R As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Cap As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_PartNumber As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadDropDownList_PartStyle As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadButton_PrintCost As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_ShowSpec As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_PrintDesign As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_PrevSpec As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_PrintEsr As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadioButton_Hold As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Obs As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Live As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Outline As System.Windows.Forms.RadioButton
    Friend WithEvents RadTextBox_Date As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Date As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Issue As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Issue As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton_ClearApps As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_QAApp As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_DesApp As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadTextBox_DesApp As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_QAApp As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_ASNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Dia_2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Len_2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Dia As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Len As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Len As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Dia As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_ASNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Volts As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Volts As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Cap As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_V As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_MicroFarad As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Percentage_2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Percentage As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_PositivePercentage As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_NegativePercentage As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Positive As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Negative As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_CelsiusDegreesMin As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_CelsiusDegreesMax As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_CelsiusDegreesMax As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_CelsiusDegreesMin As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Summary As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Summary As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_SQApp_2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_SQApp As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_SQApp As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_SDApp As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_SDApp As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadScrollablePanel_Container As Telerik.WinControls.UI.RadScrollablePanel
    Friend WithEvents TabControl_PrintCatExtra As System.Windows.Forms.TabControl
    Friend WithEvents ScratchP_PrintDetail As System.Windows.Forms.TabPage
    Friend WithEvents ScratchP_CatData As System.Windows.Forms.TabPage
    Friend WithEvents ScratchP_ExtraFields As System.Windows.Forms.TabPage
    Friend WithEvents Panel_Anode As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_Cost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Anode3Cost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Anode2Cost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Anode1Cost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadDropDownList_Melinex As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_Mm3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Mm2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_AnodeLenght2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_AnodeLenght As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Melinex As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_FaradPerSquareCm3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_FaradPerSquareCm2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_MinGain As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_MinGain As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Anode3Amount As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_StdLength As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Anode2Amount As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadDropDownList_Anode3Width As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_Anode1Width As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_Anode3Vf As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadTextBox_AnodeGain2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadDropDownList_Anode3 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_Anode2 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_Anode3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Anode2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_MaxLen As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_PercentageFit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Factor As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Anode1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_AnodeGain As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Factor As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_WindingDetails As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadCheckBox_UserGain As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel_Anode_Vertical As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_MaxLen As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_PercentageFit As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadDropDownList_Anode1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_Vf As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_Anode1Vf As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_Anode2Vf As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_Width As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_Anode2Width As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_Amount As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Anode1Amount As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Mm As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_FaradPerSquareCm As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_PercentageFit2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Panel_Parameters As System.Windows.Forms.Panel
    Friend WithEvents Panel_Cathode As System.Windows.Forms.Panel
    Friend WithEvents RadTextBox_CathodeCost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadCheckBox_Swage As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel_Swage As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Mm4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_CathExtension As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_CathExtension As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_CathodeVf As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadTextBox_CathodeAmount As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadDropDownList_CathodeWidth As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_Cath As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_Cathode As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Panel_Notes As System.Windows.Forms.Panel
    Friend WithEvents Panel_TopRight As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_SpecDrawing As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_WindingPicture As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_DimensionDwg As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_WindingPicture As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Routing As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_PartsFile As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_SpecDrawing As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_PartsFile As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_DimensionDwg As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_Routing As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Panel_Elyte As System.Windows.Forms.Panel
    Friend WithEvents RadTextBox_ElyteCost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadCheckBox_Scrollbar As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel_Scrollbar As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_ElyteAmount As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Elyte As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_Elyte As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Panel_Tissue As System.Windows.Forms.Panel
    Friend WithEvents RadTextBox_Tissue3Cost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Tissue2Cost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Tissue1Cost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadCheckBox_AfterWrap As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel_AfterWrap As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_PreWrapLength As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_PreWrapLength As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_PreWrapTurns As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_PreWrapTurns As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Tissue3Amount As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Tissue2Amount As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadDropDownList_Tissue3Width As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_Tissue1Width As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_Tissue3Vf As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_Tissue_Vertical As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_Tissue3 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_Tissue2 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_Tissue3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Tissue2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Tissue1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_Tissue1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_Tissue1Vf As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_Tissue2Width As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadTextBox_Tissue1Amount As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Panel_Freqs As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_HSink As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_EDType As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Mm9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_VFactorMm As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadDropDownList_EDType As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_AirflowMs As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadCheckBox_UseActualEsr As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel_ATc As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_FailMode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_LifeLop As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_FailMode As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_LifeLop As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_ActEsrTemp As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_UseActualEsr As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_ActEsrTemp As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_ESRFactorKe As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_MaxESRx As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_ESRFactorKe As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_MaxESRx As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_TrForCalcIr As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_MaxCoreTm As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_TrForCalcIr As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_MaxCoreTm As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_VFactorKv As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_StdVfs As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_VFactorKv As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_StdVfs As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_CurrentPaths As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_CurrentPaths As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_AirflowMs As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_ActTrxAtEOLTx As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_ArrheniusT2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_ActTrxAtEOLTx As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_ArrheniusT2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_TrCoreRise As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_AverageTh As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_TrCoreRise As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_AverageTh As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_HSink As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_OpVop As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_OpVop As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadCheckBox_old As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadTextBox_RHaCperWatt As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_RHaCperWatt As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_LifeFactorLe As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_LifeFactorLe As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_ATc As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_AmbientTa As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_AmbientTa As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Panel_Tab As System.Windows.Forms.Panel
    Friend WithEvents RadTextBox_TabCost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Mm8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Hole As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Hole As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_NoDot As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_NoDot As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_L2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_L2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_L1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_L1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Mm7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_TabAmount As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Tab As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_Tab As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Panel_TissueRight As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_Mm5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Mandrel As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_CanCode As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_CanInt As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_CanInt As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Mandrel As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_CanCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Mm6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TabControl_Ctl As System.Windows.Forms.TabControl
    Friend WithEvents Tab_Ctl As System.Windows.Forms.TabPage
    Friend WithEvents RadCheckBox_DisplayCosts As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents Tab_Cost As System.Windows.Forms.TabPage
    Friend WithEvents RadLabel_StandardCost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_VariableCost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Labour As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_StandardCost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_VariableCost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Labour As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Material As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Material As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Tab_Yield As System.Windows.Forms.TabPage
    Friend WithEvents RadTextBox_An3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_An2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Tiytg As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Anytg As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_CaYC As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_An1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Ti3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Ti2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Ti1YC As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_OY As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_OY As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Caytg As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Caytg As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Tiytg As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_CaYC As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_An3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Anytg As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_An2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_An1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Ti3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Ti2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Ti1YC As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Tab_Lab As System.Windows.Forms.TabPage
    Friend WithEvents RadTextBox_A1LC As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_A1LC As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Tab_OldTab As System.Windows.Forms.TabPage
    Friend WithEvents Tab_OldTab2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel_CapAndNotes As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_MicroFarad2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_PhysicalCaseFill As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_MaxCapAt90Fit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_MaxCapAt90Fit As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_PhysicalCaseFill As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadCheckBox_Show As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel_DesignNotes As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_DesignNotes As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_T1LC As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_T1LC As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Dep As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Dep As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Fix As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Fix As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Var As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Var As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_WLC As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_WLC As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_RCost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_RCost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_CLC As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_CLC As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_T3LC As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_T3LC As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_A3LC As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_A3LC As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_T2LC As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_T2LC As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_A2LC As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_A2LC As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_TotalCostGross As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_TotalCost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_OHCostGross As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_OHCost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_LabourCostGross As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_LabourCost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_PartsCostGross As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_PartsCost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_WindCostGross As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_WindCost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Gross As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Variable As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_TotalCostVariable As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_OHCostVariable As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_LabourCostVariable As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_PartsCostVariable As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_WindCostVariable As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_SMV As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_SMV As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Group As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Group As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGroupBox_PrintDetail As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadTextBox_PrintNotes As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadButton_ESR As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Store As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_RelForm As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_MoreDetail As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_LifeCalc As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_WriteCatData As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Refresh2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_GetData As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_DefaultFreqs As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadDropDownList_PrintDrawing As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_PrintDrawing As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton_ViewCentred As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel_PrintDetailMax13Lines As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton_EditFields As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGridView_ExtraFields As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadButton_ViewAllCatData As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGridView2 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Panel_CatalogueData As System.Windows.Forms.Panel
    Friend WithEvents Panel_CatalogueDataTitle As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_CatalogueData As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Ir As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Rha As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_condy_eq As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_oxide_fi As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_tissue_ti As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_tabbing As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Rhw As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_foil As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Ir As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Rha As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_condy_eq As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_oxide_fi As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_tissue_ti As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_tabbing As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_foil As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_IrT As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_IrF As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Rise_T As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Rbo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Rwb As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_IrT As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_IrF As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Rise_T As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Rbo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Rwb As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Rhw As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton_TestParameters As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel_Capacitance As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_Parameter1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadButton_GetLimits As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel_to As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_MicroFarad3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Capacitance As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_MicroFarad4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Capacitance2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadDropDownList_ParameterCondition1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadTextBox_ParameterValue1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadDropDownList_Parameter4 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_Parameter3 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_Parameter2 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadCheckBox_ac As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadTextBox_TestVolts As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadDropDownList_ParameterCondition4 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadTextBox_ParameterValue4 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadDropDownList_ParameterCondition3 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadTextBox_ParameterValue3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadDropDownList_ParameterCondition2 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadTextBox_ParameterValue2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_ParameterCondition As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_ParameterValue As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Parameter As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_ESRAt100HzAt20C As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_ESRAt100HzAt20C As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_IMPAt10000HzAt20C As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_IMPAt10000HzAt20C As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel_SpecificationDetails As System.Windows.Forms.Panel
    Friend WithEvents RadTextBox_Notes As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_RatedIr As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Notes As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_RatedIr As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Dimensions As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Terminals As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_SpecDwg As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Distributor As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_CustPNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Dimensions As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Terminals As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_SpecDwg As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Distributor As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_CustPNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadButton_SpecificationDetails As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel_Customer As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Customer As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_SEVtestvoltage As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_SurgeOrVDEvoltage As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_SEVtestvoltage As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_SurgeOrVDEvoltage As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_CelsiusDegrees As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_RatedIr3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_RatedIr3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_RatedIr2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_RatedIr2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_TestVolts As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton_NotesMax10escroutnotes As Telerik.WinControls.UI.RadButton
    Friend WithEvents Panel_NotesLanguages As System.Windows.Forms.Panel
    Friend WithEvents RadButton_ArrowRight As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadioButton_Spanish As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_English As System.Windows.Forms.RadioButton
    Friend WithEvents RadDropDownList_Note1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_Note As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_NoteType As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_Note1Type As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadTextBox_Note1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Sequence As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_Note3 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_Note3Type As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList_Note2 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadTextBox_Note3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadDropDownList_Note2Type As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadTextBox_Note2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_VoidSpacecm3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_VoidSpacecm3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Panel_TopBarGroup2 As System.Windows.Forms.Panel
    Friend WithEvents Panel_TopBarRadioButtons As System.Windows.Forms.Panel
    Friend WithEvents RadCheckBox_UsePRMSCostReport As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_DesChecked As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel_KPartNumber As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadCheckBox_AutoWidth As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadTextBox_MatCost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_MiniPrewrap As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_MiniPrewrap As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Ctl As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_NoLABData As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_GasLife As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_GasLife120 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_GasLife70 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_GasLife120 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_GasLife70 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_MelQty As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_MelinexCost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_PartsCost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_MelCostRaw As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_MelTCost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadDropDownList_Tissue2Vf As Telerik.WinControls.UI.RadDropDownList
End Class

