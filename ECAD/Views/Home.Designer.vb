Imports ActiveDirectoryLibrary

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
    Inherits Telerik.WinControls.UI.RadForm

    ' DEBUG
    Dim debugforms As List(Of Telerik.WinControls.UI.RadForm) = New List(Of Telerik.WinControls.UI.RadForm)
    ' /DEBUG

    Public Sub New()
        LoggingOut = False
        InitializeComponent()
        LocalizeComponent()

        ' Ensure transparent background on version labels
        Me.RadLabel_Version.Parent = PictureBox_EcadLogo
        Me.RadLabel_VersionNumber.Parent = PictureBox_EcadLogo
        Me.RadLabel_Build.Parent = PictureBox_EcadLogo
        Me.RadLabel_BuildNumber.Parent = PictureBox_EcadLogo

        ' Default tab
        Me.TabControl_Menu.SelectedIndex = 4


        ' DEBUG
        debugforms.Add(ScratchCleanup)
        debugforms.Add(Override)
        debugforms.Add(AddExtraFields)
        debugforms.Add(Evaluation)
        debugforms.Add(NewScratchDesign)
        debugforms.Add(SummaryDesignComment)
        debugforms.Add(ESR_Graphing)
        debugforms.Add(FileChooser)
        debugforms.Add(PartHistory)
        debugforms.Add(PartsFiles)
        debugforms.Add(PictureThumbnail)
        debugforms.Add(PictureDrawings)
        debugforms.Add(RoutingData)
        debugforms.Add(RoutingOpcodesData)
        debugforms.Add(PiecePartData)
        debugforms.Add(TabbingData)
        debugforms.Add(TissueData)
        debugforms.Add(DisplayValues)
        debugforms.Add(RenameScratch)
        debugforms.Add(ScratchTransfer)
        debugforms.Add(SpecificationSetup)
        debugforms.Add(CathodeData)
        debugforms.Add(RangeData)
        debugforms.Add(ElectrolyteData)
        debugforms.Add(HistoryMainForm)
        debugforms.Add(AnodeData)
        debugforms.Add(SubsfSummarySpecData)
        debugforms.Add(MwDesign)
        debugforms.Add(TissueSel)
        debugforms.Add(ScratchList)
        debugforms.Add(TransferToScratch)
        debugforms.Add(DesignWizard)
        debugforms.Add(FlashStatus)
        debugforms.Add(DCDesignWizard)
        debugforms.Add(ScratchCatalogueIndex)
        debugforms.Add(RenameOrCopyScratch)
        debugforms.Add(ReservePartNumber)
        debugforms.Add(OracleRoutingCosts)

        Me.RadDropDownList_DEBUGFORM.DataSource = debugforms
        Me.RadDropDownList_DEBUGFORM.DisplayMember = "Text"
        Me.RadDropDownList_DEBUGFORM.ValueMember = "Text"
        ' /DEBUG
    End Sub

    ' Localizes all the ui elements from a common Resource
    Private Sub LocalizeComponent()
        Me.SuspendLayout()

        Helpers.LocalizationHelper.LocalizeForm(Me)

        ' Add variables to text
        Me.RadLabel_VersionNumber.Text = Application.ProductVersion
        Me.RadLabel_Welcome.Text = Me.RadLabel_Welcome.Text.Replace("$ADUserFullName", AD.currentUserFullName)

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.PictureBox_EcadLogo = New System.Windows.Forms.PictureBox()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.RadLabel_Welcome = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Copyright = New Telerik.WinControls.UI.RadLabel()
        Me.RadButton_LogOut = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel_Version = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_VersionNumber = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_BuildNumber = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Build = New Telerik.WinControls.UI.RadLabel()
        Me.PictureBox_KemetLogo = New System.Windows.Forms.PictureBox()
        Me.RadButton_ASLog = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_AutoExport = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_InitDb = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Customers = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_UsersApprovals = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_AgeingData = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_SystemData = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_ScratchPad = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_DesignSummary = New Telerik.WinControls.UI.RadButton()
        Me.TabControl_Menu = New System.Windows.Forms.TabControl()
        Me.TabPage_DesignMaterials = New System.Windows.Forms.TabPage()
        Me.RadButton_PartsFiles = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_PieceParts = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Anodes = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Tabbing = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Electrolytes = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_StandardWidths = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Cathodes = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Tissues = New Telerik.WinControls.UI.RadButton()
        Me.TabPage_DesignData = New System.Windows.Forms.TabPage()
        Me.RadButton_AdditionalFields = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_AssemblyNotes = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Ranges = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_InputPartMasters = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_RifaCadData = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Pictures = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Parameters = New Telerik.WinControls.UI.RadButton()
        Me.TabPage_CapacitorDesign = New System.Windows.Forms.TabPage()
        Me.RadButton_Customers2 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_DesignSummary2 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_HistoryViewer = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_ProductSelector = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_BlockCosts = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_ScratchPad2 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_DesignIndex = New Telerik.WinControls.UI.RadButton()
        Me.TabPage_DataProcessing = New System.Windows.Forms.TabPage()
        Me.RadButton_UpdateCosts = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_OracleExport = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_ImportDesigns = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_ChangeNotes = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_RecreateSummary = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Print = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_BatchCards = New Telerik.WinControls.UI.RadButton()
        Me.TabPage_GlobalSystem = New System.Windows.Forms.TabPage()
        Me.RadDropDownList_DEBUGFORM = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadButton_DEBUGFORM = New Telerik.WinControls.UI.RadButton()
        CType(Me.PictureBox_EcadLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Welcome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Copyright, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_LogOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Version, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_VersionNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_BuildNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Build, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_ASLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_AutoExport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_InitDb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Customers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_UsersApprovals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_AgeingData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_SystemData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_ScratchPad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_DesignSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl_Menu.SuspendLayout()
        Me.TabPage_DesignMaterials.SuspendLayout()
        CType(Me.RadButton_PartsFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_PieceParts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Anodes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Tabbing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Electrolytes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_StandardWidths, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Cathodes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Tissues, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_DesignData.SuspendLayout()
        CType(Me.RadButton_AdditionalFields, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_AssemblyNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Ranges, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_InputPartMasters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_RifaCadData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Pictures, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Parameters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_CapacitorDesign.SuspendLayout()
        CType(Me.RadButton_Customers2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_DesignSummary2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_HistoryViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_ProductSelector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_BlockCosts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_ScratchPad2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_DesignIndex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_DataProcessing.SuspendLayout()
        CType(Me.RadButton_UpdateCosts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_OracleExport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_ImportDesigns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_ChangeNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_RecreateSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Print, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_BatchCards, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_GlobalSystem.SuspendLayout()
        CType(Me.RadDropDownList_DEBUGFORM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_DEBUGFORM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox_EcadLogo
        '
        Me.PictureBox_EcadLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox_EcadLogo.Image = Global.ECAD.My.Resources.Resources.ECAD
        Me.PictureBox_EcadLogo.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox_EcadLogo.Name = "PictureBox_EcadLogo"
        Me.PictureBox_EcadLogo.Size = New System.Drawing.Size(327, 107)
        Me.PictureBox_EcadLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_EcadLogo.TabIndex = 0
        Me.PictureBox_EcadLogo.TabStop = False
        '
        'RadLabel_Welcome
        '
        Me.RadLabel_Welcome.AutoSize = False
        Me.RadLabel_Welcome.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Welcome.ForeColor = System.Drawing.Color.OliveDrab
        Me.RadLabel_Welcome.Location = New System.Drawing.Point(12, 447)
        Me.RadLabel_Welcome.Name = "RadLabel_Welcome"
        Me.RadLabel_Welcome.Size = New System.Drawing.Size(546, 29)
        Me.RadLabel_Welcome.TabIndex = 1
        Me.RadLabel_Welcome.Text = "Home_EcadWelcomes"
        Me.RadLabel_Welcome.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadLabel_Copyright
        '
        Me.RadLabel_Copyright.Location = New System.Drawing.Point(12, 482)
        Me.RadLabel_Copyright.Name = "RadLabel_Copyright"
        Me.RadLabel_Copyright.Size = New System.Drawing.Size(91, 18)
        Me.RadLabel_Copyright.TabIndex = 2
        Me.RadLabel_Copyright.Text = "Home_Copyright"
        '
        'RadButton_LogOut
        '
        Me.RadButton_LogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_LogOut.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_LogOut.ForeColor = System.Drawing.Color.Black
        Me.RadButton_LogOut.Location = New System.Drawing.Point(464, 12)
        Me.RadButton_LogOut.Name = "RadButton_LogOut"
        Me.RadButton_LogOut.Size = New System.Drawing.Size(94, 44)
        Me.RadButton_LogOut.TabIndex = 3
        Me.RadButton_LogOut.Text = "Home_LogOut"
        '
        'RadLabel_Version
        '
        Me.RadLabel_Version.AutoSize = False
        Me.RadLabel_Version.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel_Version.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Version.ForeColor = System.Drawing.Color.White
        Me.RadLabel_Version.Location = New System.Drawing.Point(239, 12)
        Me.RadLabel_Version.Name = "RadLabel_Version"
        Me.RadLabel_Version.Size = New System.Drawing.Size(84, 18)
        Me.RadLabel_Version.TabIndex = 4
        Me.RadLabel_Version.Text = "Global_Version"
        Me.RadLabel_Version.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadLabel_VersionNumber
        '
        Me.RadLabel_VersionNumber.AutoSize = False
        Me.RadLabel_VersionNumber.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel_VersionNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RadLabel_VersionNumber.ForeColor = System.Drawing.Color.White
        Me.RadLabel_VersionNumber.Location = New System.Drawing.Point(239, 31)
        Me.RadLabel_VersionNumber.Name = "RadLabel_VersionNumber"
        Me.RadLabel_VersionNumber.Size = New System.Drawing.Size(84, 18)
        Me.RadLabel_VersionNumber.TabIndex = 5
        Me.RadLabel_VersionNumber.Text = "versionNum"
        Me.RadLabel_VersionNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadLabel_BuildNumber
        '
        Me.RadLabel_BuildNumber.AutoSize = False
        Me.RadLabel_BuildNumber.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel_BuildNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RadLabel_BuildNumber.ForeColor = System.Drawing.Color.White
        Me.RadLabel_BuildNumber.Location = New System.Drawing.Point(239, 69)
        Me.RadLabel_BuildNumber.Name = "RadLabel_BuildNumber"
        Me.RadLabel_BuildNumber.Size = New System.Drawing.Size(84, 18)
        Me.RadLabel_BuildNumber.TabIndex = 7
        Me.RadLabel_BuildNumber.Text = "buildNum"
        Me.RadLabel_BuildNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadLabel_Build
        '
        Me.RadLabel_Build.AutoSize = False
        Me.RadLabel_Build.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel_Build.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Build.ForeColor = System.Drawing.Color.White
        Me.RadLabel_Build.Location = New System.Drawing.Point(239, 50)
        Me.RadLabel_Build.Name = "RadLabel_Build"
        Me.RadLabel_Build.Size = New System.Drawing.Size(84, 18)
        Me.RadLabel_Build.TabIndex = 6
        Me.RadLabel_Build.Text = "Global_Build"
        Me.RadLabel_Build.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox_KemetLogo
        '
        Me.PictureBox_KemetLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox_KemetLogo.Image = Global.ECAD.My.Resources.Resources.kemet_logo_small
        Me.PictureBox_KemetLogo.Location = New System.Drawing.Point(564, 12)
        Me.PictureBox_KemetLogo.Name = "PictureBox_KemetLogo"
        Me.PictureBox_KemetLogo.Size = New System.Drawing.Size(216, 107)
        Me.PictureBox_KemetLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_KemetLogo.TabIndex = 8
        Me.PictureBox_KemetLogo.TabStop = False
        '
        'RadButton_ASLog
        '
        Me.RadButton_ASLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_ASLog.Enabled = False
        Me.RadButton_ASLog.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_ASLog.ForeColor = System.Drawing.Color.Black
        Me.RadButton_ASLog.Location = New System.Drawing.Point(269, 151)
        Me.RadButton_ASLog.Name = "RadButton_ASLog"
        Me.RadButton_ASLog.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_ASLog.TabIndex = 3
        Me.RadButton_ASLog.Text = "ASLog_Title"
        '
        'RadButton_AutoExport
        '
        Me.RadButton_AutoExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_AutoExport.Enabled = False
        Me.RadButton_AutoExport.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_AutoExport.ForeColor = System.Drawing.Color.Black
        Me.RadButton_AutoExport.Location = New System.Drawing.Point(37, 212)
        Me.RadButton_AutoExport.Name = "RadButton_AutoExport"
        Me.RadButton_AutoExport.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_AutoExport.TabIndex = 6
        Me.RadButton_AutoExport.Text = "AutoExport_Title"
        '
        'RadButton_InitDb
        '
        Me.RadButton_InitDb.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_InitDb.Enabled = False
        Me.RadButton_InitDb.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_InitDb.ForeColor = System.Drawing.Color.Black
        Me.RadButton_InitDb.Location = New System.Drawing.Point(269, 90)
        Me.RadButton_InitDb.Name = "RadButton_InitDb"
        Me.RadButton_InitDb.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_InitDb.TabIndex = 2
        Me.RadButton_InitDb.Text = "InitDb_Title"
        '
        'RadButton_Customers
        '
        Me.RadButton_Customers.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_Customers.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Customers.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Customers.Location = New System.Drawing.Point(37, 151)
        Me.RadButton_Customers.Name = "RadButton_Customers"
        Me.RadButton_Customers.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_Customers.TabIndex = 4
        Me.RadButton_Customers.Text = "Customers_Title"
        '
        'RadButton_UsersApprovals
        '
        Me.RadButton_UsersApprovals.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_UsersApprovals.Enabled = False
        Me.RadButton_UsersApprovals.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_UsersApprovals.ForeColor = System.Drawing.Color.Black
        Me.RadButton_UsersApprovals.Location = New System.Drawing.Point(37, 90)
        Me.RadButton_UsersApprovals.Name = "RadButton_UsersApprovals"
        Me.RadButton_UsersApprovals.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_UsersApprovals.TabIndex = 2
        Me.RadButton_UsersApprovals.Text = "UsersApprovals_Title"
        '
        'RadButton_AgeingData
        '
        Me.RadButton_AgeingData.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_AgeingData.Enabled = False
        Me.RadButton_AgeingData.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_AgeingData.ForeColor = System.Drawing.Color.Black
        Me.RadButton_AgeingData.Location = New System.Drawing.Point(269, 29)
        Me.RadButton_AgeingData.Name = "RadButton_AgeingData"
        Me.RadButton_AgeingData.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_AgeingData.TabIndex = 1
        Me.RadButton_AgeingData.Text = "AgeingData_Title"
        '
        'RadButton_SystemData
        '
        Me.RadButton_SystemData.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_SystemData.Enabled = False
        Me.RadButton_SystemData.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_SystemData.ForeColor = System.Drawing.Color.Black
        Me.RadButton_SystemData.Location = New System.Drawing.Point(37, 29)
        Me.RadButton_SystemData.Name = "RadButton_SystemData"
        Me.RadButton_SystemData.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_SystemData.TabIndex = 0
        Me.RadButton_SystemData.Text = "SystemData_Title"
        '
        'RadButton_ScratchPad
        '
        Me.RadButton_ScratchPad.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_ScratchPad.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_ScratchPad.ForeColor = System.Drawing.Color.Black
        Me.RadButton_ScratchPad.Location = New System.Drawing.Point(622, 487)
        Me.RadButton_ScratchPad.Name = "RadButton_ScratchPad"
        Me.RadButton_ScratchPad.Size = New System.Drawing.Size(158, 37)
        Me.RadButton_ScratchPad.TabIndex = 5
        Me.RadButton_ScratchPad.Text = "ScratchPad_Title"
        '
        'RadButton_DesignSummary
        '
        Me.RadButton_DesignSummary.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_DesignSummary.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_DesignSummary.ForeColor = System.Drawing.Color.Black
        Me.RadButton_DesignSummary.Location = New System.Drawing.Point(622, 447)
        Me.RadButton_DesignSummary.Name = "RadButton_DesignSummary"
        Me.RadButton_DesignSummary.Size = New System.Drawing.Size(158, 37)
        Me.RadButton_DesignSummary.TabIndex = 6
        Me.RadButton_DesignSummary.Text = "DesignSummary_Title"
        '
        'TabControl_Menu
        '
        Me.TabControl_Menu.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl_Menu.Controls.Add(Me.TabPage_DesignMaterials)
        Me.TabControl_Menu.Controls.Add(Me.TabPage_DesignData)
        Me.TabControl_Menu.Controls.Add(Me.TabPage_CapacitorDesign)
        Me.TabControl_Menu.Controls.Add(Me.TabPage_DataProcessing)
        Me.TabControl_Menu.Controls.Add(Me.TabPage_GlobalSystem)
        Me.TabControl_Menu.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControl_Menu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TabControl_Menu.ItemSize = New System.Drawing.Size(45, 205)
        Me.TabControl_Menu.Location = New System.Drawing.Point(36, 134)
        Me.TabControl_Menu.Multiline = True
        Me.TabControl_Menu.Name = "TabControl_Menu"
        Me.TabControl_Menu.SelectedIndex = 0
        Me.TabControl_Menu.Size = New System.Drawing.Size(719, 300)
        Me.TabControl_Menu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl_Menu.TabIndex = 12
        '
        'TabPage_DesignMaterials
        '
        Me.TabPage_DesignMaterials.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.TabPage_DesignMaterials.Controls.Add(Me.RadButton_PartsFiles)
        Me.TabPage_DesignMaterials.Controls.Add(Me.RadButton_PieceParts)
        Me.TabPage_DesignMaterials.Controls.Add(Me.RadButton_Anodes)
        Me.TabPage_DesignMaterials.Controls.Add(Me.RadButton_Tabbing)
        Me.TabPage_DesignMaterials.Controls.Add(Me.RadButton_Electrolytes)
        Me.TabPage_DesignMaterials.Controls.Add(Me.RadButton_StandardWidths)
        Me.TabPage_DesignMaterials.Controls.Add(Me.RadButton_Cathodes)
        Me.TabPage_DesignMaterials.Controls.Add(Me.RadButton_Tissues)
        Me.TabPage_DesignMaterials.Location = New System.Drawing.Point(209, 4)
        Me.TabPage_DesignMaterials.Name = "TabPage_DesignMaterials"
        Me.TabPage_DesignMaterials.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_DesignMaterials.Size = New System.Drawing.Size(506, 292)
        Me.TabPage_DesignMaterials.TabIndex = 0
        Me.TabPage_DesignMaterials.Text = "Home_DesignMaterials"
        '
        'RadButton_PartsFiles
        '
        Me.RadButton_PartsFiles.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_PartsFiles.Enabled = False
        Me.RadButton_PartsFiles.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_PartsFiles.ForeColor = System.Drawing.Color.Black
        Me.RadButton_PartsFiles.Location = New System.Drawing.Point(269, 212)
        Me.RadButton_PartsFiles.Name = "RadButton_PartsFiles"
        Me.RadButton_PartsFiles.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_PartsFiles.TabIndex = 12
        Me.RadButton_PartsFiles.Text = "PartsFiles_Title"
        '
        'RadButton_PieceParts
        '
        Me.RadButton_PieceParts.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_PieceParts.Enabled = False
        Me.RadButton_PieceParts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_PieceParts.ForeColor = System.Drawing.Color.Black
        Me.RadButton_PieceParts.Location = New System.Drawing.Point(269, 151)
        Me.RadButton_PieceParts.Name = "RadButton_PieceParts"
        Me.RadButton_PieceParts.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_PieceParts.TabIndex = 11
        Me.RadButton_PieceParts.Text = "PieceParts_Title"
        '
        'RadButton_Anodes
        '
        Me.RadButton_Anodes.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_Anodes.Enabled = False
        Me.RadButton_Anodes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Anodes.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Anodes.Location = New System.Drawing.Point(37, 29)
        Me.RadButton_Anodes.Name = "RadButton_Anodes"
        Me.RadButton_Anodes.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_Anodes.TabIndex = 7
        Me.RadButton_Anodes.Text = "Anodes_Title"
        '
        'RadButton_Tabbing
        '
        Me.RadButton_Tabbing.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_Tabbing.Enabled = False
        Me.RadButton_Tabbing.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Tabbing.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Tabbing.Location = New System.Drawing.Point(37, 212)
        Me.RadButton_Tabbing.Name = "RadButton_Tabbing"
        Me.RadButton_Tabbing.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_Tabbing.TabIndex = 13
        Me.RadButton_Tabbing.Text = "Tabbing_Title"
        '
        'RadButton_Electrolytes
        '
        Me.RadButton_Electrolytes.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_Electrolytes.Enabled = False
        Me.RadButton_Electrolytes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Electrolytes.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Electrolytes.Location = New System.Drawing.Point(269, 29)
        Me.RadButton_Electrolytes.Name = "RadButton_Electrolytes"
        Me.RadButton_Electrolytes.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_Electrolytes.TabIndex = 8
        Me.RadButton_Electrolytes.Text = "Electrolytes_Title"
        '
        'RadButton_StandardWidths
        '
        Me.RadButton_StandardWidths.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_StandardWidths.Enabled = False
        Me.RadButton_StandardWidths.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_StandardWidths.ForeColor = System.Drawing.Color.Black
        Me.RadButton_StandardWidths.Location = New System.Drawing.Point(269, 90)
        Me.RadButton_StandardWidths.Name = "RadButton_StandardWidths"
        Me.RadButton_StandardWidths.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_StandardWidths.TabIndex = 9
        Me.RadButton_StandardWidths.Text = "StandardWidths_Title"
        '
        'RadButton_Cathodes
        '
        Me.RadButton_Cathodes.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_Cathodes.Enabled = False
        Me.RadButton_Cathodes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Cathodes.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Cathodes.Location = New System.Drawing.Point(37, 90)
        Me.RadButton_Cathodes.Name = "RadButton_Cathodes"
        Me.RadButton_Cathodes.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_Cathodes.TabIndex = 10
        Me.RadButton_Cathodes.Text = "Cathodes_Title"
        '
        'RadButton_Tissues
        '
        Me.RadButton_Tissues.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_Tissues.Enabled = False
        Me.RadButton_Tissues.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Tissues.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Tissues.Location = New System.Drawing.Point(37, 151)
        Me.RadButton_Tissues.Name = "RadButton_Tissues"
        Me.RadButton_Tissues.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_Tissues.TabIndex = 12
        Me.RadButton_Tissues.Text = "Tissues_Title"
        '
        'TabPage_DesignData
        '
        Me.TabPage_DesignData.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.TabPage_DesignData.Controls.Add(Me.RadButton_AdditionalFields)
        Me.TabPage_DesignData.Controls.Add(Me.RadButton_AssemblyNotes)
        Me.TabPage_DesignData.Controls.Add(Me.RadButton_Ranges)
        Me.TabPage_DesignData.Controls.Add(Me.RadButton_InputPartMasters)
        Me.TabPage_DesignData.Controls.Add(Me.RadButton_RifaCadData)
        Me.TabPage_DesignData.Controls.Add(Me.RadButton_Pictures)
        Me.TabPage_DesignData.Controls.Add(Me.RadButton_Parameters)
        Me.TabPage_DesignData.Location = New System.Drawing.Point(209, 4)
        Me.TabPage_DesignData.Name = "TabPage_DesignData"
        Me.TabPage_DesignData.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_DesignData.Size = New System.Drawing.Size(506, 292)
        Me.TabPage_DesignData.TabIndex = 1
        Me.TabPage_DesignData.Text = "Home_DesignData"
        '
        'RadButton_AdditionalFields
        '
        Me.RadButton_AdditionalFields.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_AdditionalFields.Enabled = False
        Me.RadButton_AdditionalFields.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_AdditionalFields.ForeColor = System.Drawing.Color.Black
        Me.RadButton_AdditionalFields.Location = New System.Drawing.Point(269, 151)
        Me.RadButton_AdditionalFields.Name = "RadButton_AdditionalFields"
        Me.RadButton_AdditionalFields.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_AdditionalFields.TabIndex = 11
        Me.RadButton_AdditionalFields.Text = "AdditionalFields_Title"
        '
        'RadButton_AssemblyNotes
        '
        Me.RadButton_AssemblyNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_AssemblyNotes.Enabled = False
        Me.RadButton_AssemblyNotes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_AssemblyNotes.ForeColor = System.Drawing.Color.Black
        Me.RadButton_AssemblyNotes.Location = New System.Drawing.Point(37, 29)
        Me.RadButton_AssemblyNotes.Name = "RadButton_AssemblyNotes"
        Me.RadButton_AssemblyNotes.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_AssemblyNotes.TabIndex = 7
        Me.RadButton_AssemblyNotes.Text = "AssemblyNotes_Title"
        '
        'RadButton_Ranges
        '
        Me.RadButton_Ranges.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_Ranges.Enabled = False
        Me.RadButton_Ranges.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Ranges.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Ranges.Location = New System.Drawing.Point(37, 212)
        Me.RadButton_Ranges.Name = "RadButton_Ranges"
        Me.RadButton_Ranges.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_Ranges.TabIndex = 13
        Me.RadButton_Ranges.Text = "Ranges_Title"
        '
        'RadButton_InputPartMasters
        '
        Me.RadButton_InputPartMasters.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_InputPartMasters.Enabled = False
        Me.RadButton_InputPartMasters.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_InputPartMasters.ForeColor = System.Drawing.Color.Black
        Me.RadButton_InputPartMasters.Location = New System.Drawing.Point(269, 29)
        Me.RadButton_InputPartMasters.Name = "RadButton_InputPartMasters"
        Me.RadButton_InputPartMasters.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_InputPartMasters.TabIndex = 8
        Me.RadButton_InputPartMasters.Text = "InputPartMasters_Title"
        '
        'RadButton_RifaCadData
        '
        Me.RadButton_RifaCadData.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_RifaCadData.Enabled = False
        Me.RadButton_RifaCadData.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_RifaCadData.ForeColor = System.Drawing.Color.Black
        Me.RadButton_RifaCadData.Location = New System.Drawing.Point(269, 90)
        Me.RadButton_RifaCadData.Name = "RadButton_RifaCadData"
        Me.RadButton_RifaCadData.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_RifaCadData.TabIndex = 9
        Me.RadButton_RifaCadData.Text = "RifaCadData_Title"
        '
        'RadButton_Pictures
        '
        Me.RadButton_Pictures.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_Pictures.Enabled = False
        Me.RadButton_Pictures.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Pictures.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Pictures.Location = New System.Drawing.Point(37, 90)
        Me.RadButton_Pictures.Name = "RadButton_Pictures"
        Me.RadButton_Pictures.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_Pictures.TabIndex = 10
        Me.RadButton_Pictures.Text = "Pictures_Title"
        '
        'RadButton_Parameters
        '
        Me.RadButton_Parameters.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_Parameters.Enabled = False
        Me.RadButton_Parameters.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Parameters.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Parameters.Location = New System.Drawing.Point(37, 151)
        Me.RadButton_Parameters.Name = "RadButton_Parameters"
        Me.RadButton_Parameters.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_Parameters.TabIndex = 12
        Me.RadButton_Parameters.Text = "Parameters_Title"
        '
        'TabPage_CapacitorDesign
        '
        Me.TabPage_CapacitorDesign.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.TabPage_CapacitorDesign.Controls.Add(Me.RadButton_Customers2)
        Me.TabPage_CapacitorDesign.Controls.Add(Me.RadButton_DesignSummary2)
        Me.TabPage_CapacitorDesign.Controls.Add(Me.RadButton_HistoryViewer)
        Me.TabPage_CapacitorDesign.Controls.Add(Me.RadButton_ProductSelector)
        Me.TabPage_CapacitorDesign.Controls.Add(Me.RadButton_BlockCosts)
        Me.TabPage_CapacitorDesign.Controls.Add(Me.RadButton_ScratchPad2)
        Me.TabPage_CapacitorDesign.Controls.Add(Me.RadButton_DesignIndex)
        Me.TabPage_CapacitorDesign.Location = New System.Drawing.Point(209, 4)
        Me.TabPage_CapacitorDesign.Name = "TabPage_CapacitorDesign"
        Me.TabPage_CapacitorDesign.Size = New System.Drawing.Size(506, 292)
        Me.TabPage_CapacitorDesign.TabIndex = 2
        Me.TabPage_CapacitorDesign.Text = "Home_CapacitorDesign"
        '
        'RadButton_Customers2
        '
        Me.RadButton_Customers2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_Customers2.Enabled = False
        Me.RadButton_Customers2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Customers2.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Customers2.Location = New System.Drawing.Point(269, 151)
        Me.RadButton_Customers2.Name = "RadButton_Customers2"
        Me.RadButton_Customers2.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_Customers2.TabIndex = 11
        Me.RadButton_Customers2.Text = "Customers_Title"
        '
        'RadButton_DesignSummary2
        '
        Me.RadButton_DesignSummary2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_DesignSummary2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_DesignSummary2.ForeColor = System.Drawing.Color.Black
        Me.RadButton_DesignSummary2.Location = New System.Drawing.Point(37, 29)
        Me.RadButton_DesignSummary2.Name = "RadButton_DesignSummary2"
        Me.RadButton_DesignSummary2.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_DesignSummary2.TabIndex = 7
        Me.RadButton_DesignSummary2.Text = "DesignSummary_Title"
        '
        'RadButton_HistoryViewer
        '
        Me.RadButton_HistoryViewer.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_HistoryViewer.Enabled = False
        Me.RadButton_HistoryViewer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_HistoryViewer.ForeColor = System.Drawing.Color.Black
        Me.RadButton_HistoryViewer.Location = New System.Drawing.Point(37, 212)
        Me.RadButton_HistoryViewer.Name = "RadButton_HistoryViewer"
        Me.RadButton_HistoryViewer.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_HistoryViewer.TabIndex = 13
        Me.RadButton_HistoryViewer.Text = "HistoryViewer_Title"
        '
        'RadButton_ProductSelector
        '
        Me.RadButton_ProductSelector.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_ProductSelector.Enabled = False
        Me.RadButton_ProductSelector.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_ProductSelector.ForeColor = System.Drawing.Color.Black
        Me.RadButton_ProductSelector.Location = New System.Drawing.Point(269, 29)
        Me.RadButton_ProductSelector.Name = "RadButton_ProductSelector"
        Me.RadButton_ProductSelector.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_ProductSelector.TabIndex = 8
        Me.RadButton_ProductSelector.Text = "ProductSelector_Title"
        '
        'RadButton_BlockCosts
        '
        Me.RadButton_BlockCosts.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_BlockCosts.Enabled = False
        Me.RadButton_BlockCosts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_BlockCosts.ForeColor = System.Drawing.Color.Black
        Me.RadButton_BlockCosts.Location = New System.Drawing.Point(269, 90)
        Me.RadButton_BlockCosts.Name = "RadButton_BlockCosts"
        Me.RadButton_BlockCosts.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_BlockCosts.TabIndex = 9
        Me.RadButton_BlockCosts.Text = "BlockCosts_Title"
        '
        'RadButton_ScratchPad2
        '
        Me.RadButton_ScratchPad2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_ScratchPad2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_ScratchPad2.ForeColor = System.Drawing.Color.Black
        Me.RadButton_ScratchPad2.Location = New System.Drawing.Point(37, 90)
        Me.RadButton_ScratchPad2.Name = "RadButton_ScratchPad2"
        Me.RadButton_ScratchPad2.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_ScratchPad2.TabIndex = 10
        Me.RadButton_ScratchPad2.Text = "ScratchPad_Title"
        '
        'RadButton_DesignIndex
        '
        Me.RadButton_DesignIndex.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_DesignIndex.Enabled = False
        Me.RadButton_DesignIndex.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_DesignIndex.ForeColor = System.Drawing.Color.Black
        Me.RadButton_DesignIndex.Location = New System.Drawing.Point(37, 151)
        Me.RadButton_DesignIndex.Name = "RadButton_DesignIndex"
        Me.RadButton_DesignIndex.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_DesignIndex.TabIndex = 12
        Me.RadButton_DesignIndex.Text = "DesignIndex_Title"
        '
        'TabPage_DataProcessing
        '
        Me.TabPage_DataProcessing.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TabPage_DataProcessing.Controls.Add(Me.RadButton_UpdateCosts)
        Me.TabPage_DataProcessing.Controls.Add(Me.RadButton_OracleExport)
        Me.TabPage_DataProcessing.Controls.Add(Me.RadButton_ImportDesigns)
        Me.TabPage_DataProcessing.Controls.Add(Me.RadButton_ChangeNotes)
        Me.TabPage_DataProcessing.Controls.Add(Me.RadButton_RecreateSummary)
        Me.TabPage_DataProcessing.Controls.Add(Me.RadButton_Print)
        Me.TabPage_DataProcessing.Controls.Add(Me.RadButton_BatchCards)
        Me.TabPage_DataProcessing.Location = New System.Drawing.Point(209, 4)
        Me.TabPage_DataProcessing.Name = "TabPage_DataProcessing"
        Me.TabPage_DataProcessing.Size = New System.Drawing.Size(506, 292)
        Me.TabPage_DataProcessing.TabIndex = 3
        Me.TabPage_DataProcessing.Text = "Home_DataProcessing"
        '
        'RadButton_UpdateCosts
        '
        Me.RadButton_UpdateCosts.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_UpdateCosts.Enabled = False
        Me.RadButton_UpdateCosts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_UpdateCosts.ForeColor = System.Drawing.Color.Black
        Me.RadButton_UpdateCosts.Location = New System.Drawing.Point(269, 151)
        Me.RadButton_UpdateCosts.Name = "RadButton_UpdateCosts"
        Me.RadButton_UpdateCosts.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_UpdateCosts.TabIndex = 11
        Me.RadButton_UpdateCosts.Text = "UpdateCosts_Title"
        '
        'RadButton_OracleExport
        '
        Me.RadButton_OracleExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_OracleExport.Enabled = False
        Me.RadButton_OracleExport.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_OracleExport.ForeColor = System.Drawing.Color.Black
        Me.RadButton_OracleExport.Location = New System.Drawing.Point(37, 29)
        Me.RadButton_OracleExport.Name = "RadButton_OracleExport"
        Me.RadButton_OracleExport.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_OracleExport.TabIndex = 7
        Me.RadButton_OracleExport.Text = "OracleExport_Title"
        '
        'RadButton_ImportDesigns
        '
        Me.RadButton_ImportDesigns.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_ImportDesigns.Enabled = False
        Me.RadButton_ImportDesigns.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_ImportDesigns.ForeColor = System.Drawing.Color.Black
        Me.RadButton_ImportDesigns.Location = New System.Drawing.Point(37, 212)
        Me.RadButton_ImportDesigns.Name = "RadButton_ImportDesigns"
        Me.RadButton_ImportDesigns.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_ImportDesigns.TabIndex = 13
        Me.RadButton_ImportDesigns.Text = "ImportDesigns_Title"
        '
        'RadButton_ChangeNotes
        '
        Me.RadButton_ChangeNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_ChangeNotes.Enabled = False
        Me.RadButton_ChangeNotes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_ChangeNotes.ForeColor = System.Drawing.Color.Black
        Me.RadButton_ChangeNotes.Location = New System.Drawing.Point(269, 29)
        Me.RadButton_ChangeNotes.Name = "RadButton_ChangeNotes"
        Me.RadButton_ChangeNotes.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_ChangeNotes.TabIndex = 8
        Me.RadButton_ChangeNotes.Text = "ChangeNotes_Title"
        '
        'RadButton_RecreateSummary
        '
        Me.RadButton_RecreateSummary.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_RecreateSummary.Enabled = False
        Me.RadButton_RecreateSummary.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_RecreateSummary.ForeColor = System.Drawing.Color.Black
        Me.RadButton_RecreateSummary.Location = New System.Drawing.Point(269, 90)
        Me.RadButton_RecreateSummary.Name = "RadButton_RecreateSummary"
        Me.RadButton_RecreateSummary.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_RecreateSummary.TabIndex = 9
        Me.RadButton_RecreateSummary.Text = "RecreateSummary_Title"
        '
        'RadButton_Print
        '
        Me.RadButton_Print.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_Print.Enabled = False
        Me.RadButton_Print.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Print.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Print.Location = New System.Drawing.Point(37, 90)
        Me.RadButton_Print.Name = "RadButton_Print"
        Me.RadButton_Print.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_Print.TabIndex = 10
        Me.RadButton_Print.Text = "Print_Title"
        '
        'RadButton_BatchCards
        '
        Me.RadButton_BatchCards.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_BatchCards.Enabled = False
        Me.RadButton_BatchCards.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_BatchCards.ForeColor = System.Drawing.Color.Black
        Me.RadButton_BatchCards.Location = New System.Drawing.Point(37, 151)
        Me.RadButton_BatchCards.Name = "RadButton_BatchCards"
        Me.RadButton_BatchCards.Size = New System.Drawing.Size(200, 50)
        Me.RadButton_BatchCards.TabIndex = 12
        Me.RadButton_BatchCards.Text = "BatchCards_Title"
        '
        'TabPage_GlobalSystem
        '
        Me.TabPage_GlobalSystem.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.TabPage_GlobalSystem.Controls.Add(Me.RadButton_ASLog)
        Me.TabPage_GlobalSystem.Controls.Add(Me.RadButton_SystemData)
        Me.TabPage_GlobalSystem.Controls.Add(Me.RadButton_AutoExport)
        Me.TabPage_GlobalSystem.Controls.Add(Me.RadButton_AgeingData)
        Me.TabPage_GlobalSystem.Controls.Add(Me.RadButton_InitDb)
        Me.TabPage_GlobalSystem.Controls.Add(Me.RadButton_UsersApprovals)
        Me.TabPage_GlobalSystem.Controls.Add(Me.RadButton_Customers)
        Me.TabPage_GlobalSystem.Location = New System.Drawing.Point(209, 4)
        Me.TabPage_GlobalSystem.Name = "TabPage_GlobalSystem"
        Me.TabPage_GlobalSystem.Size = New System.Drawing.Size(506, 292)
        Me.TabPage_GlobalSystem.TabIndex = 4
        Me.TabPage_GlobalSystem.Text = "Home_GlobalSystem"
        '
        'RadDropDownList_DEBUGFORM
        '
        Me.RadDropDownList_DEBUGFORM.AutoSize = False
        Me.RadDropDownList_DEBUGFORM.BackColor = System.Drawing.Color.Yellow
        Me.RadDropDownList_DEBUGFORM.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_DEBUGFORM.Location = New System.Drawing.Point(345, 64)
        Me.RadDropDownList_DEBUGFORM.Name = "RadDropDownList_DEBUGFORM"
        Me.RadDropDownList_DEBUGFORM.Size = New System.Drawing.Size(213, 23)
        Me.RadDropDownList_DEBUGFORM.TabIndex = 13
        '
        'RadButton_DEBUGFORM
        '
        Me.RadButton_DEBUGFORM.BackColor = System.Drawing.Color.Yellow
        Me.RadButton_DEBUGFORM.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton_DEBUGFORM.ForeColor = System.Drawing.Color.Black
        Me.RadButton_DEBUGFORM.Location = New System.Drawing.Point(345, 88)
        Me.RadButton_DEBUGFORM.Name = "RadButton_DEBUGFORM"
        Me.RadButton_DEBUGFORM.Size = New System.Drawing.Size(213, 28)
        Me.RadButton_DEBUGFORM.TabIndex = 14
        Me.RadButton_DEBUGFORM.Text = "TEST UI"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(792, 536)
        Me.Controls.Add(Me.RadButton_DEBUGFORM)
        Me.Controls.Add(Me.RadDropDownList_DEBUGFORM)
        Me.Controls.Add(Me.TabControl_Menu)
        Me.Controls.Add(Me.RadButton_DesignSummary)
        Me.Controls.Add(Me.RadButton_ScratchPad)
        Me.Controls.Add(Me.PictureBox_KemetLogo)
        Me.Controls.Add(Me.RadLabel_BuildNumber)
        Me.Controls.Add(Me.RadLabel_VersionNumber)
        Me.Controls.Add(Me.RadLabel_Build)
        Me.Controls.Add(Me.RadLabel_Version)
        Me.Controls.Add(Me.RadButton_LogOut)
        Me.Controls.Add(Me.RadLabel_Copyright)
        Me.Controls.Add(Me.RadLabel_Welcome)
        Me.Controls.Add(Me.PictureBox_EcadLogo)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 566)
        Me.Name = "Home"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home_Title"
        Me.ThemeName = "Windows8"
        CType(Me.PictureBox_EcadLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Welcome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Copyright, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_LogOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Version, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_VersionNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_BuildNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Build, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_ASLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_AutoExport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_InitDb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Customers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_UsersApprovals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_AgeingData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_SystemData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_ScratchPad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_DesignSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl_Menu.ResumeLayout(False)
        Me.TabPage_DesignMaterials.ResumeLayout(False)
        CType(Me.RadButton_PartsFiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_PieceParts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Anodes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Tabbing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Electrolytes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_StandardWidths, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Cathodes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Tissues, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_DesignData.ResumeLayout(False)
        CType(Me.RadButton_AdditionalFields, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_AssemblyNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Ranges, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_InputPartMasters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_RifaCadData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Pictures, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Parameters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_CapacitorDesign.ResumeLayout(False)
        CType(Me.RadButton_Customers2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_DesignSummary2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_HistoryViewer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_ProductSelector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_BlockCosts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_ScratchPad2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_DesignIndex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_DataProcessing.ResumeLayout(False)
        CType(Me.RadButton_UpdateCosts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_OracleExport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_ImportDesigns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_ChangeNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_RecreateSummary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Print, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_BatchCards, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_GlobalSystem.ResumeLayout(False)
        CType(Me.RadDropDownList_DEBUGFORM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_DEBUGFORM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox_EcadLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents RadLabel_Welcome As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Copyright As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton_LogOut As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel_Version As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_VersionNumber As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_BuildNumber As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Build As Telerik.WinControls.UI.RadLabel
    Friend WithEvents PictureBox_KemetLogo As System.Windows.Forms.PictureBox
    Friend WithEvents RadButton_SystemData As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_ASLog As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_AutoExport As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_InitDb As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Customers As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_UsersApprovals As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_AgeingData As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_ScratchPad As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_DesignSummary As Telerik.WinControls.UI.RadButton
    Friend WithEvents TabControl_Menu As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_DesignMaterials As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_DesignData As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_CapacitorDesign As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_DataProcessing As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_GlobalSystem As System.Windows.Forms.TabPage
    Friend WithEvents RadButton_PieceParts As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Anodes As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Tabbing As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Electrolytes As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_StandardWidths As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Cathodes As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Tissues As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_AdditionalFields As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_AssemblyNotes As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Ranges As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_InputPartMasters As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_RifaCadData As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Pictures As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Parameters As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Customers2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_DesignSummary2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_HistoryViewer As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_ProductSelector As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_BlockCosts As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_ScratchPad2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_DesignIndex As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_UpdateCosts As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_OracleExport As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_ImportDesigns As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_ChangeNotes As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_RecreateSummary As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Print As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_BatchCards As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_PartsFiles As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadDropDownList_DEBUGFORM As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadButton_DEBUGFORM As Telerik.WinControls.UI.RadButton
End Class

