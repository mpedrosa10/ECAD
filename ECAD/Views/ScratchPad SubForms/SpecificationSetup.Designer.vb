<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpecificationSetup
    Inherits Telerik.WinControls.UI.RadForm

    Public Sub New()
        InitializeComponent()
        LocalizeComponent()
    End Sub

    ' Localizes all the ui elements from a common Resource
    Private Sub LocalizeComponent()
        Me.SuspendLayout()

        Helpers.LocalizationHelper.LocalizeForm(Me)

        ' Add variables to text
        Me.RadCheckBox_PageBreak1.Text = Me.RadCheckBox_PageBreak1.Text.Replace("$i", "1")
        Me.RadCheckBox_PageBreak2.Text = Me.RadCheckBox_PageBreak2.Text.Replace("$i", "2")
        Me.RadCheckBox_PageBreak3.Text = Me.RadCheckBox_PageBreak3.Text.Replace("$i", "3")
        Me.RadCheckBox_PageBreak4.Text = Me.RadCheckBox_PageBreak4.Text.Replace("$i", "4")
        Me.RadCheckBox_PageBreak5.Text = Me.RadCheckBox_PageBreak5.Text.Replace("$i", "5")
        Me.RadCheckBox_PageBreak6.Text = Me.RadCheckBox_PageBreak6.Text.Replace("$i", "6")
        Me.RadCheckBox_PageBreak7.Text = Me.RadCheckBox_PageBreak7.Text.Replace("$i", "7")
        Me.RadCheckBox_PageBreak8.Text = Me.RadCheckBox_PageBreak8.Text.Replace("$i", "8")
        Me.RadCheckBox_PageBreak9.Text = Me.RadCheckBox_PageBreak9.Text.Replace("$i", "9")

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
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition4 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition5 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition6 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewTextBoxColumn9 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn10 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition7 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewTextBoxColumn11 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn12 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition8 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewTextBoxColumn13 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn14 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition9 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewTextBoxColumn15 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn16 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition10 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SpecificationSetup))
        Me.Panel_Header = New System.Windows.Forms.Panel()
        Me.RadCheckBox_CatData = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel_Rectangle3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Rectangle2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Rectangle1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_ID = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_IDTxt = New Telerik.WinControls.UI.RadLabel()
        Me.PictureBox_KemetLogo = New System.Windows.Forms.PictureBox()
        Me.RadLabel_InnerTitle = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_AmbientTemp = New Telerik.WinControls.UI.RadLabel()
        Me.RadGridView_AmbientTemp = New Telerik.WinControls.UI.RadGridView()
        Me.RadGridView_CoreRise = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabel_CoreRise = New Telerik.WinControls.UI.RadLabel()
        Me.RadGridView_ESRFF = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabel_ESRFF = New Telerik.WinControls.UI.RadLabel()
        Me.RadGridView_LifeExp = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabel_KVTemp = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_ESRFTemp = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_LifeExp = New Telerik.WinControls.UI.RadLabel()
        Me.RadGridView_KFFreq = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabel_KFFreq = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_KVPercentage = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_KFTemp = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_IrMultiplier = New Telerik.WinControls.UI.RadLabel()
        Me.RadGridView_KVPercentage = New Telerik.WinControls.UI.RadGridView()
        Me.RadGridView_IrMultiplier = New Telerik.WinControls.UI.RadGridView()
        Me.RadGridView_KFTemp = New Telerik.WinControls.UI.RadGridView()
        Me.RadGridView_ESRFTemp = New Telerik.WinControls.UI.RadGridView()
        Me.RadGridView_KVTemp = New Telerik.WinControls.UI.RadGridView()
        Me.Panel_Selects = New System.Windows.Forms.Panel()
        Me.RadCheckBox_LopVsTaForTrData = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_OnePage = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_RippleQuote = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_PageBreak1 = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_LifeDefinitions = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_PageBreak2 = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_ESRData = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_PageBreak3 = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_LopVsTaForTrGraph = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_PageBreak4 = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_KVDeratingGraph = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_KVDeratingData = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_PageBreak5 = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_LopVsTaForM = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_LopVsTaForMData = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_PageBreak6 = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_MVsTaForLopData = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_MVsTaForLop = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_PageBreak7 = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_RHaDiag = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_ShowallRhaDiagData = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_PageBreak8 = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_ESRFreqData = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_ESRFreqGraph = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_PageBreak9 = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadButton_SelectAll = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_SelectNone = New Telerik.WinControls.UI.RadButton()
        Me.RadCheckBox_KFData = New Telerik.WinControls.UI.RadCheckBox()
        Me.Panel_Selects2 = New System.Windows.Forms.Panel()
        Me.RadCheckBox_InhibitSpec = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_ShowLopEquation = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_ShowSampleDisclaimer = New Telerik.WinControls.UI.RadCheckBox()
        Me.Panel_ViewExport = New System.Windows.Forms.Panel()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadTextBox_PDFPath = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Header = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_PDFPath = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Header = New Telerik.WinControls.UI.RadLabel()
        Me.RadCheckBox_ExportstraighttoPDF = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadButton_ViewReport = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_AddAllDefaults = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel_Header.SuspendLayout()
        CType(Me.RadCheckBox_CatData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Rectangle3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Rectangle2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Rectangle1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_IDTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_InnerTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_AmbientTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_AmbientTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_AmbientTemp.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_CoreRise, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_CoreRise.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_CoreRise, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_ESRFF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_ESRFF.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ESRFF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_LifeExp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_LifeExp.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_KVTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ESRFTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_LifeExp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_KFFreq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_KFFreq.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_KFFreq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_KVPercentage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_KFTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_IrMultiplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_KVPercentage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_KVPercentage.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_IrMultiplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_IrMultiplier.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_KFTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_KFTemp.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_ESRFTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_ESRFTemp.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_KVTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_KVTemp.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Selects.SuspendLayout()
        CType(Me.RadCheckBox_LopVsTaForTrData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_OnePage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_RippleQuote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_PageBreak1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_LifeDefinitions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_PageBreak2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_ESRData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_PageBreak3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_LopVsTaForTrGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_PageBreak4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_KVDeratingGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_KVDeratingData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_PageBreak5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_LopVsTaForM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_LopVsTaForMData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_PageBreak6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_MVsTaForLopData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_MVsTaForLop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_PageBreak7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_RHaDiag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_ShowallRhaDiagData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_PageBreak8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_ESRFreqData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_ESRFreqGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_PageBreak9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_SelectAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_SelectNone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_KFData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Selects2.SuspendLayout()
        CType(Me.RadCheckBox_InhibitSpec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_ShowLopEquation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_ShowSampleDisclaimer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_ViewExport.SuspendLayout()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_PDFPath, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Header, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PDFPath, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Header, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_ExportstraighttoPDF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_ViewReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_AddAllDefaults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Header
        '
        Me.Panel_Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel_Header.Controls.Add(Me.RadCheckBox_CatData)
        Me.Panel_Header.Controls.Add(Me.RadLabel_Rectangle3)
        Me.Panel_Header.Controls.Add(Me.RadLabel_Rectangle2)
        Me.Panel_Header.Controls.Add(Me.RadLabel_Rectangle1)
        Me.Panel_Header.Controls.Add(Me.RadLabel_ID)
        Me.Panel_Header.Controls.Add(Me.RadLabel_IDTxt)
        Me.Panel_Header.Controls.Add(Me.PictureBox_KemetLogo)
        Me.Panel_Header.Controls.Add(Me.RadLabel_InnerTitle)
        Me.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Header.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Header.Name = "Panel_Header"
        Me.Panel_Header.Size = New System.Drawing.Size(1199, 70)
        Me.Panel_Header.TabIndex = 0
        '
        'RadCheckBox_CatData
        '
        Me.RadCheckBox_CatData.AutoSize = False
        Me.RadCheckBox_CatData.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadCheckBox_CatData.Location = New System.Drawing.Point(899, 20)
        Me.RadCheckBox_CatData.Name = "RadCheckBox_CatData"
        Me.RadCheckBox_CatData.Size = New System.Drawing.Size(110, 28)
        Me.RadCheckBox_CatData.TabIndex = 90
        Me.RadCheckBox_CatData.Text = "SpecSetup_CatData"
        '
        'RadLabel_Rectangle3
        '
        Me.RadLabel_Rectangle3.AutoSize = False
        Me.RadLabel_Rectangle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadLabel_Rectangle3.Location = New System.Drawing.Point(725, 15)
        Me.RadLabel_Rectangle3.Name = "RadLabel_Rectangle3"
        Me.RadLabel_Rectangle3.Size = New System.Drawing.Size(80, 39)
        Me.RadLabel_Rectangle3.TabIndex = 39
        Me.RadLabel_Rectangle3.Visible = False
        '
        'RadLabel_Rectangle2
        '
        Me.RadLabel_Rectangle2.AutoSize = False
        Me.RadLabel_Rectangle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.RadLabel_Rectangle2.Location = New System.Drawing.Point(645, 15)
        Me.RadLabel_Rectangle2.Name = "RadLabel_Rectangle2"
        Me.RadLabel_Rectangle2.Size = New System.Drawing.Size(80, 39)
        Me.RadLabel_Rectangle2.TabIndex = 38
        Me.RadLabel_Rectangle2.Visible = False
        '
        'RadLabel_Rectangle1
        '
        Me.RadLabel_Rectangle1.AutoSize = False
        Me.RadLabel_Rectangle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RadLabel_Rectangle1.Location = New System.Drawing.Point(564, 15)
        Me.RadLabel_Rectangle1.Name = "RadLabel_Rectangle1"
        Me.RadLabel_Rectangle1.Size = New System.Drawing.Size(80, 35)
        Me.RadLabel_Rectangle1.TabIndex = 37
        Me.RadLabel_Rectangle1.Visible = False
        '
        'RadLabel_ID
        '
        Me.RadLabel_ID.AutoSize = False
        Me.RadLabel_ID.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_ID.Location = New System.Drawing.Point(395, 22)
        Me.RadLabel_ID.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_ID.Name = "RadLabel_ID"
        Me.RadLabel_ID.Size = New System.Drawing.Size(120, 25)
        Me.RadLabel_ID.TabIndex = 35
        Me.RadLabel_ID.Text = "someIDhere"
        Me.RadLabel_ID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_IDTxt
        '
        Me.RadLabel_IDTxt.AutoSize = False
        Me.RadLabel_IDTxt.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_IDTxt.Location = New System.Drawing.Point(351, 22)
        Me.RadLabel_IDTxt.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_IDTxt.Name = "RadLabel_IDTxt"
        Me.RadLabel_IDTxt.Size = New System.Drawing.Size(40, 25)
        Me.RadLabel_IDTxt.TabIndex = 34
        Me.RadLabel_IDTxt.Text = "ID"
        Me.RadLabel_IDTxt.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox_KemetLogo
        '
        Me.PictureBox_KemetLogo.Image = Global.ECAD.My.Resources.Resources.kemet_logo_small
        Me.PictureBox_KemetLogo.Location = New System.Drawing.Point(1067, 7)
        Me.PictureBox_KemetLogo.Name = "PictureBox_KemetLogo"
        Me.PictureBox_KemetLogo.Size = New System.Drawing.Size(126, 56)
        Me.PictureBox_KemetLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_KemetLogo.TabIndex = 3
        Me.PictureBox_KemetLogo.TabStop = False
        '
        'RadLabel_InnerTitle
        '
        Me.RadLabel_InnerTitle.AutoSize = False
        Me.RadLabel_InnerTitle.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_InnerTitle.Location = New System.Drawing.Point(11, 15)
        Me.RadLabel_InnerTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_InnerTitle.Name = "RadLabel_InnerTitle"
        Me.RadLabel_InnerTitle.Size = New System.Drawing.Size(340, 37)
        Me.RadLabel_InnerTitle.TabIndex = 2
        Me.RadLabel_InnerTitle.Text = "SpecSetup_Title"
        Me.RadLabel_InnerTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_AmbientTemp
        '
        Me.RadLabel_AmbientTemp.AutoSize = False
        Me.RadLabel_AmbientTemp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_AmbientTemp.Location = New System.Drawing.Point(9, 75)
        Me.RadLabel_AmbientTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_AmbientTemp.Name = "RadLabel_AmbientTemp"
        Me.RadLabel_AmbientTemp.Size = New System.Drawing.Size(168, 25)
        Me.RadLabel_AmbientTemp.TabIndex = 101
        Me.RadLabel_AmbientTemp.Text = "SpecSetup_AmbientTemp"
        Me.RadLabel_AmbientTemp.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadGridView_AmbientTemp
        '
        Me.RadGridView_AmbientTemp.Location = New System.Drawing.Point(9, 100)
        '
        '
        '
        Me.RadGridView_AmbientTemp.MasterTemplate.AllowDragToGroup = False
        Me.RadGridView_AmbientTemp.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn1.HeaderText = "Global_Value"
        GridViewTextBoxColumn1.Name = "column1"
        GridViewTextBoxColumn1.Width = 147
        Me.RadGridView_AmbientTemp.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1})
        Me.RadGridView_AmbientTemp.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView_AmbientTemp.Name = "RadGridView_AmbientTemp"
        Me.RadGridView_AmbientTemp.ShowGroupPanel = False
        Me.RadGridView_AmbientTemp.Size = New System.Drawing.Size(168, 399)
        Me.RadGridView_AmbientTemp.TabIndex = 102
        '
        'RadGridView_CoreRise
        '
        Me.RadGridView_CoreRise.Location = New System.Drawing.Point(183, 100)
        '
        '
        '
        Me.RadGridView_CoreRise.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn2.HeaderText = "Global_Value"
        GridViewTextBoxColumn2.Name = "column1"
        GridViewTextBoxColumn2.Width = 84
        GridViewTextBoxColumn3.HeaderText = "Global_Text"
        GridViewTextBoxColumn3.Name = "column2"
        GridViewTextBoxColumn3.Width = 64
        Me.RadGridView_CoreRise.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn2, GridViewTextBoxColumn3})
        Me.RadGridView_CoreRise.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.RadGridView_CoreRise.Name = "RadGridView_CoreRise"
        Me.RadGridView_CoreRise.ShowGroupPanel = False
        Me.RadGridView_CoreRise.Size = New System.Drawing.Size(168, 183)
        Me.RadGridView_CoreRise.TabIndex = 103
        '
        'RadLabel_CoreRise
        '
        Me.RadLabel_CoreRise.AutoSize = False
        Me.RadLabel_CoreRise.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_CoreRise.Location = New System.Drawing.Point(183, 75)
        Me.RadLabel_CoreRise.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_CoreRise.Name = "RadLabel_CoreRise"
        Me.RadLabel_CoreRise.Size = New System.Drawing.Size(168, 25)
        Me.RadLabel_CoreRise.TabIndex = 104
        Me.RadLabel_CoreRise.Text = "SpecSetup_CoreRise"
        Me.RadLabel_CoreRise.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadGridView_ESRFF
        '
        Me.RadGridView_ESRFF.Location = New System.Drawing.Point(183, 316)
        '
        '
        '
        Me.RadGridView_ESRFF.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn4.HeaderText = "Global_Value"
        GridViewTextBoxColumn4.Name = "column1"
        GridViewTextBoxColumn4.Width = 147
        Me.RadGridView_ESRFF.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn4})
        Me.RadGridView_ESRFF.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.RadGridView_ESRFF.Name = "RadGridView_ESRFF"
        Me.RadGridView_ESRFF.ShowGroupPanel = False
        Me.RadGridView_ESRFF.Size = New System.Drawing.Size(168, 183)
        Me.RadGridView_ESRFF.TabIndex = 105
        '
        'RadLabel_ESRFF
        '
        Me.RadLabel_ESRFF.AutoSize = False
        Me.RadLabel_ESRFF.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_ESRFF.Location = New System.Drawing.Point(183, 291)
        Me.RadLabel_ESRFF.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_ESRFF.Name = "RadLabel_ESRFF"
        Me.RadLabel_ESRFF.Size = New System.Drawing.Size(168, 25)
        Me.RadLabel_ESRFF.TabIndex = 106
        Me.RadLabel_ESRFF.Text = "SpecSetup_ESRFF"
        Me.RadLabel_ESRFF.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadGridView_LifeExp
        '
        Me.RadGridView_LifeExp.Location = New System.Drawing.Point(357, 100)
        '
        '
        '
        Me.RadGridView_LifeExp.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn5.HeaderText = "Global_Value"
        GridViewTextBoxColumn5.Name = "column1"
        GridViewTextBoxColumn5.Width = 84
        GridViewTextBoxColumn6.HeaderText = "Global_Text"
        GridViewTextBoxColumn6.Name = "column2"
        GridViewTextBoxColumn6.Width = 64
        Me.RadGridView_LifeExp.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn5, GridViewTextBoxColumn6})
        Me.RadGridView_LifeExp.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.RadGridView_LifeExp.Name = "RadGridView_LifeExp"
        Me.RadGridView_LifeExp.ShowGroupPanel = False
        Me.RadGridView_LifeExp.Size = New System.Drawing.Size(168, 399)
        Me.RadGridView_LifeExp.TabIndex = 108
        '
        'RadLabel_KVTemp
        '
        Me.RadLabel_KVTemp.AutoSize = False
        Me.RadLabel_KVTemp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_KVTemp.Location = New System.Drawing.Point(531, 291)
        Me.RadLabel_KVTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_KVTemp.Name = "RadLabel_KVTemp"
        Me.RadLabel_KVTemp.Size = New System.Drawing.Size(168, 25)
        Me.RadLabel_KVTemp.TabIndex = 112
        Me.RadLabel_KVTemp.Text = "SpecSetup_KVTemp"
        Me.RadLabel_KVTemp.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_ESRFTemp
        '
        Me.RadLabel_ESRFTemp.AutoSize = False
        Me.RadLabel_ESRFTemp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_ESRFTemp.Location = New System.Drawing.Point(531, 75)
        Me.RadLabel_ESRFTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_ESRFTemp.Name = "RadLabel_ESRFTemp"
        Me.RadLabel_ESRFTemp.Size = New System.Drawing.Size(168, 25)
        Me.RadLabel_ESRFTemp.TabIndex = 110
        Me.RadLabel_ESRFTemp.Text = "SpecSetup_ESRFTemp"
        Me.RadLabel_ESRFTemp.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_LifeExp
        '
        Me.RadLabel_LifeExp.AutoSize = False
        Me.RadLabel_LifeExp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_LifeExp.Location = New System.Drawing.Point(357, 75)
        Me.RadLabel_LifeExp.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_LifeExp.Name = "RadLabel_LifeExp"
        Me.RadLabel_LifeExp.Size = New System.Drawing.Size(168, 25)
        Me.RadLabel_LifeExp.TabIndex = 107
        Me.RadLabel_LifeExp.Text = "SpecSetup_LifeExp"
        Me.RadLabel_LifeExp.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadGridView_KFFreq
        '
        Me.RadGridView_KFFreq.Location = New System.Drawing.Point(9, 525)
        '
        '
        '
        Me.RadGridView_KFFreq.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn7.HeaderText = "Global_Value"
        GridViewTextBoxColumn7.Name = "column1"
        GridViewTextBoxColumn7.Width = 147
        Me.RadGridView_KFFreq.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn7})
        Me.RadGridView_KFFreq.MasterTemplate.ViewDefinition = TableViewDefinition5
        Me.RadGridView_KFFreq.Name = "RadGridView_KFFreq"
        Me.RadGridView_KFFreq.ShowGroupPanel = False
        Me.RadGridView_KFFreq.Size = New System.Drawing.Size(168, 195)
        Me.RadGridView_KFFreq.TabIndex = 113
        '
        'RadLabel_KFFreq
        '
        Me.RadLabel_KFFreq.AutoSize = False
        Me.RadLabel_KFFreq.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_KFFreq.Location = New System.Drawing.Point(9, 501)
        Me.RadLabel_KFFreq.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_KFFreq.Name = "RadLabel_KFFreq"
        Me.RadLabel_KFFreq.Size = New System.Drawing.Size(168, 25)
        Me.RadLabel_KFFreq.TabIndex = 114
        Me.RadLabel_KFFreq.Text = "SpecSetup_KFFreq"
        Me.RadLabel_KFFreq.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_KVPercentage
        '
        Me.RadLabel_KVPercentage.AutoSize = False
        Me.RadLabel_KVPercentage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_KVPercentage.Location = New System.Drawing.Point(183, 501)
        Me.RadLabel_KVPercentage.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_KVPercentage.Name = "RadLabel_KVPercentage"
        Me.RadLabel_KVPercentage.Size = New System.Drawing.Size(168, 25)
        Me.RadLabel_KVPercentage.TabIndex = 116
        Me.RadLabel_KVPercentage.Text = "SpecSetup_KVPercentage"
        Me.RadLabel_KVPercentage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_KFTemp
        '
        Me.RadLabel_KFTemp.AutoSize = False
        Me.RadLabel_KFTemp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_KFTemp.Location = New System.Drawing.Point(531, 501)
        Me.RadLabel_KFTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_KFTemp.Name = "RadLabel_KFTemp"
        Me.RadLabel_KFTemp.Size = New System.Drawing.Size(168, 25)
        Me.RadLabel_KFTemp.TabIndex = 120
        Me.RadLabel_KFTemp.Text = "SpecSetup_KFTemp"
        Me.RadLabel_KFTemp.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_IrMultiplier
        '
        Me.RadLabel_IrMultiplier.AutoSize = False
        Me.RadLabel_IrMultiplier.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_IrMultiplier.Location = New System.Drawing.Point(357, 501)
        Me.RadLabel_IrMultiplier.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_IrMultiplier.Name = "RadLabel_IrMultiplier"
        Me.RadLabel_IrMultiplier.Size = New System.Drawing.Size(168, 25)
        Me.RadLabel_IrMultiplier.TabIndex = 118
        Me.RadLabel_IrMultiplier.Text = "SpecSetup_IrMultiplier"
        Me.RadLabel_IrMultiplier.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadGridView_KVPercentage
        '
        Me.RadGridView_KVPercentage.Location = New System.Drawing.Point(183, 525)
        '
        '
        '
        Me.RadGridView_KVPercentage.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn8.HeaderText = "Global_Value"
        GridViewTextBoxColumn8.Name = "column1"
        GridViewTextBoxColumn8.Width = 147
        Me.RadGridView_KVPercentage.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn8})
        Me.RadGridView_KVPercentage.MasterTemplate.ViewDefinition = TableViewDefinition6
        Me.RadGridView_KVPercentage.Name = "RadGridView_KVPercentage"
        Me.RadGridView_KVPercentage.ShowGroupPanel = False
        Me.RadGridView_KVPercentage.Size = New System.Drawing.Size(168, 195)
        Me.RadGridView_KVPercentage.TabIndex = 123
        '
        'RadGridView_IrMultiplier
        '
        Me.RadGridView_IrMultiplier.Location = New System.Drawing.Point(357, 525)
        '
        '
        '
        Me.RadGridView_IrMultiplier.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn9.HeaderText = "Global_Value"
        GridViewTextBoxColumn9.Name = "column1"
        GridViewTextBoxColumn9.Width = 84
        GridViewTextBoxColumn10.HeaderText = "Global_Text"
        GridViewTextBoxColumn10.Name = "column2"
        GridViewTextBoxColumn10.Width = 64
        Me.RadGridView_IrMultiplier.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn9, GridViewTextBoxColumn10})
        Me.RadGridView_IrMultiplier.MasterTemplate.ViewDefinition = TableViewDefinition7
        Me.RadGridView_IrMultiplier.Name = "RadGridView_IrMultiplier"
        Me.RadGridView_IrMultiplier.ShowGroupPanel = False
        Me.RadGridView_IrMultiplier.Size = New System.Drawing.Size(168, 195)
        Me.RadGridView_IrMultiplier.TabIndex = 124
        '
        'RadGridView_KFTemp
        '
        Me.RadGridView_KFTemp.Location = New System.Drawing.Point(531, 525)
        '
        '
        '
        Me.RadGridView_KFTemp.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn11.HeaderText = "Global_Value"
        GridViewTextBoxColumn11.Name = "column1"
        GridViewTextBoxColumn11.Width = 84
        GridViewTextBoxColumn12.HeaderText = "Global_Text"
        GridViewTextBoxColumn12.Name = "column2"
        GridViewTextBoxColumn12.Width = 64
        Me.RadGridView_KFTemp.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn11, GridViewTextBoxColumn12})
        Me.RadGridView_KFTemp.MasterTemplate.ViewDefinition = TableViewDefinition8
        Me.RadGridView_KFTemp.Name = "RadGridView_KFTemp"
        Me.RadGridView_KFTemp.ShowGroupPanel = False
        Me.RadGridView_KFTemp.Size = New System.Drawing.Size(168, 195)
        Me.RadGridView_KFTemp.TabIndex = 125
        '
        'RadGridView_ESRFTemp
        '
        Me.RadGridView_ESRFTemp.Location = New System.Drawing.Point(531, 100)
        '
        '
        '
        Me.RadGridView_ESRFTemp.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn13.HeaderText = "Global_Value"
        GridViewTextBoxColumn13.Name = "column1"
        GridViewTextBoxColumn13.Width = 84
        GridViewTextBoxColumn14.HeaderText = "Global_Text"
        GridViewTextBoxColumn14.Name = "column2"
        GridViewTextBoxColumn14.Width = 64
        Me.RadGridView_ESRFTemp.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn13, GridViewTextBoxColumn14})
        Me.RadGridView_ESRFTemp.MasterTemplate.ViewDefinition = TableViewDefinition9
        Me.RadGridView_ESRFTemp.Name = "RadGridView_ESRFTemp"
        Me.RadGridView_ESRFTemp.ShowGroupPanel = False
        Me.RadGridView_ESRFTemp.Size = New System.Drawing.Size(168, 183)
        Me.RadGridView_ESRFTemp.TabIndex = 126
        '
        'RadGridView_KVTemp
        '
        Me.RadGridView_KVTemp.Location = New System.Drawing.Point(531, 316)
        '
        '
        '
        Me.RadGridView_KVTemp.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn15.HeaderText = "Global_Value"
        GridViewTextBoxColumn15.Name = "column1"
        GridViewTextBoxColumn15.Width = 84
        GridViewTextBoxColumn16.HeaderText = "Global_Text"
        GridViewTextBoxColumn16.Name = "column2"
        GridViewTextBoxColumn16.Width = 64
        Me.RadGridView_KVTemp.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn15, GridViewTextBoxColumn16})
        Me.RadGridView_KVTemp.MasterTemplate.ViewDefinition = TableViewDefinition10
        Me.RadGridView_KVTemp.Name = "RadGridView_KVTemp"
        Me.RadGridView_KVTemp.ShowGroupPanel = False
        Me.RadGridView_KVTemp.Size = New System.Drawing.Size(168, 183)
        Me.RadGridView_KVTemp.TabIndex = 127
        '
        'Panel_Selects
        '
        Me.Panel_Selects.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_LopVsTaForTrData)
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_OnePage)
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_RippleQuote)
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_PageBreak1)
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_LifeDefinitions)
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_PageBreak2)
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_ESRData)
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_PageBreak3)
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_LopVsTaForTrGraph)
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_PageBreak4)
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_KVDeratingGraph)
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_KVDeratingData)
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_PageBreak5)
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_LopVsTaForM)
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_LopVsTaForMData)
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_PageBreak6)
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_MVsTaForLopData)
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_MVsTaForLop)
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_PageBreak7)
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_RHaDiag)
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_ShowallRhaDiagData)
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_PageBreak8)
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_ESRFreqData)
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_ESRFreqGraph)
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_PageBreak9)
        Me.Panel_Selects.Controls.Add(Me.RadButton_SelectAll)
        Me.Panel_Selects.Controls.Add(Me.RadButton_SelectNone)
        Me.Panel_Selects.Controls.Add(Me.RadCheckBox_KFData)
        Me.Panel_Selects.Location = New System.Drawing.Point(707, 75)
        Me.Panel_Selects.Name = "Panel_Selects"
        Me.Panel_Selects.Size = New System.Drawing.Size(240, 645)
        Me.Panel_Selects.TabIndex = 128
        '
        'RadCheckBox_LopVsTaForTrData
        '
        Me.RadCheckBox_LopVsTaForTrData.AutoSize = False
        Me.RadCheckBox_LopVsTaForTrData.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_LopVsTaForTrData.Location = New System.Drawing.Point(6, 162)
        Me.RadCheckBox_LopVsTaForTrData.Name = "RadCheckBox_LopVsTaForTrData"
        Me.RadCheckBox_LopVsTaForTrData.Size = New System.Drawing.Size(225, 23)
        Me.RadCheckBox_LopVsTaForTrData.TabIndex = 111
        Me.RadCheckBox_LopVsTaForTrData.Text = "SpecSetup_LopVsTaForTrData"
        '
        'RadCheckBox_OnePage
        '
        Me.RadCheckBox_OnePage.AutoSize = False
        Me.RadCheckBox_OnePage.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_OnePage.Location = New System.Drawing.Point(6, 1)
        Me.RadCheckBox_OnePage.Name = "RadCheckBox_OnePage"
        Me.RadCheckBox_OnePage.Size = New System.Drawing.Size(225, 23)
        Me.RadCheckBox_OnePage.TabIndex = 117
        Me.RadCheckBox_OnePage.Text = "SpecSetup_OnePage"
        '
        'RadCheckBox_RippleQuote
        '
        Me.RadCheckBox_RippleQuote.AutoSize = False
        Me.RadCheckBox_RippleQuote.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.RadCheckBox_RippleQuote.Location = New System.Drawing.Point(20, 24)
        Me.RadCheckBox_RippleQuote.Name = "RadCheckBox_RippleQuote"
        Me.RadCheckBox_RippleQuote.Size = New System.Drawing.Size(211, 23)
        Me.RadCheckBox_RippleQuote.TabIndex = 116
        Me.RadCheckBox_RippleQuote.Text = "SpecSetup_RippleQuote"
        '
        'RadCheckBox_PageBreak1
        '
        Me.RadCheckBox_PageBreak1.AutoSize = False
        Me.RadCheckBox_PageBreak1.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_PageBreak1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_PageBreak1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.RadCheckBox_PageBreak1.Location = New System.Drawing.Point(6, 47)
        Me.RadCheckBox_PageBreak1.Name = "RadCheckBox_PageBreak1"
        Me.RadCheckBox_PageBreak1.Size = New System.Drawing.Size(225, 23)
        Me.RadCheckBox_PageBreak1.TabIndex = 115
        Me.RadCheckBox_PageBreak1.Text = "SpecSetup_PageBreak"
        Me.RadCheckBox_PageBreak1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadCheckBox_LifeDefinitions
        '
        Me.RadCheckBox_LifeDefinitions.AutoSize = False
        Me.RadCheckBox_LifeDefinitions.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_LifeDefinitions.Location = New System.Drawing.Point(6, 70)
        Me.RadCheckBox_LifeDefinitions.Name = "RadCheckBox_LifeDefinitions"
        Me.RadCheckBox_LifeDefinitions.Size = New System.Drawing.Size(225, 23)
        Me.RadCheckBox_LifeDefinitions.TabIndex = 114
        Me.RadCheckBox_LifeDefinitions.Text = "SpecSetup_LifeDefinitions"
        '
        'RadCheckBox_PageBreak2
        '
        Me.RadCheckBox_PageBreak2.AutoSize = False
        Me.RadCheckBox_PageBreak2.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_PageBreak2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_PageBreak2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.RadCheckBox_PageBreak2.Location = New System.Drawing.Point(6, 93)
        Me.RadCheckBox_PageBreak2.Name = "RadCheckBox_PageBreak2"
        Me.RadCheckBox_PageBreak2.Size = New System.Drawing.Size(225, 23)
        Me.RadCheckBox_PageBreak2.TabIndex = 113
        Me.RadCheckBox_PageBreak2.Text = "SpecSetup_PageBreak"
        Me.RadCheckBox_PageBreak2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadCheckBox_ESRData
        '
        Me.RadCheckBox_ESRData.AutoSize = False
        Me.RadCheckBox_ESRData.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_ESRData.Location = New System.Drawing.Point(6, 116)
        Me.RadCheckBox_ESRData.Name = "RadCheckBox_ESRData"
        Me.RadCheckBox_ESRData.Size = New System.Drawing.Size(225, 23)
        Me.RadCheckBox_ESRData.TabIndex = 112
        Me.RadCheckBox_ESRData.Text = "SpecSetup_ESRData"
        '
        'RadCheckBox_PageBreak3
        '
        Me.RadCheckBox_PageBreak3.AutoSize = False
        Me.RadCheckBox_PageBreak3.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_PageBreak3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_PageBreak3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.RadCheckBox_PageBreak3.Location = New System.Drawing.Point(6, 139)
        Me.RadCheckBox_PageBreak3.Name = "RadCheckBox_PageBreak3"
        Me.RadCheckBox_PageBreak3.Size = New System.Drawing.Size(225, 23)
        Me.RadCheckBox_PageBreak3.TabIndex = 111
        Me.RadCheckBox_PageBreak3.Text = "SpecSetup_PageBreak"
        Me.RadCheckBox_PageBreak3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadCheckBox_LopVsTaForTrGraph
        '
        Me.RadCheckBox_LopVsTaForTrGraph.AutoSize = False
        Me.RadCheckBox_LopVsTaForTrGraph.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_LopVsTaForTrGraph.Location = New System.Drawing.Point(6, 185)
        Me.RadCheckBox_LopVsTaForTrGraph.Name = "RadCheckBox_LopVsTaForTrGraph"
        Me.RadCheckBox_LopVsTaForTrGraph.Size = New System.Drawing.Size(225, 23)
        Me.RadCheckBox_LopVsTaForTrGraph.TabIndex = 110
        Me.RadCheckBox_LopVsTaForTrGraph.Text = "SpecSetup_LopVsTaForTrGraph"
        '
        'RadCheckBox_PageBreak4
        '
        Me.RadCheckBox_PageBreak4.AutoSize = False
        Me.RadCheckBox_PageBreak4.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_PageBreak4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_PageBreak4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.RadCheckBox_PageBreak4.Location = New System.Drawing.Point(6, 208)
        Me.RadCheckBox_PageBreak4.Name = "RadCheckBox_PageBreak4"
        Me.RadCheckBox_PageBreak4.Size = New System.Drawing.Size(225, 23)
        Me.RadCheckBox_PageBreak4.TabIndex = 109
        Me.RadCheckBox_PageBreak4.Text = "SpecSetup_PageBreak"
        Me.RadCheckBox_PageBreak4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadCheckBox_KVDeratingGraph
        '
        Me.RadCheckBox_KVDeratingGraph.AutoSize = False
        Me.RadCheckBox_KVDeratingGraph.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_KVDeratingGraph.Location = New System.Drawing.Point(6, 231)
        Me.RadCheckBox_KVDeratingGraph.Name = "RadCheckBox_KVDeratingGraph"
        Me.RadCheckBox_KVDeratingGraph.Size = New System.Drawing.Size(225, 23)
        Me.RadCheckBox_KVDeratingGraph.TabIndex = 108
        Me.RadCheckBox_KVDeratingGraph.Text = "SpecSetup_KVDeratingGraph"
        '
        'RadCheckBox_KVDeratingData
        '
        Me.RadCheckBox_KVDeratingData.AutoSize = False
        Me.RadCheckBox_KVDeratingData.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_KVDeratingData.Location = New System.Drawing.Point(6, 254)
        Me.RadCheckBox_KVDeratingData.Name = "RadCheckBox_KVDeratingData"
        Me.RadCheckBox_KVDeratingData.Size = New System.Drawing.Size(225, 23)
        Me.RadCheckBox_KVDeratingData.TabIndex = 107
        Me.RadCheckBox_KVDeratingData.Text = "SpecSetup_KVDeratingData"
        '
        'RadCheckBox_PageBreak5
        '
        Me.RadCheckBox_PageBreak5.AutoSize = False
        Me.RadCheckBox_PageBreak5.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_PageBreak5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_PageBreak5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.RadCheckBox_PageBreak5.Location = New System.Drawing.Point(6, 277)
        Me.RadCheckBox_PageBreak5.Name = "RadCheckBox_PageBreak5"
        Me.RadCheckBox_PageBreak5.Size = New System.Drawing.Size(225, 23)
        Me.RadCheckBox_PageBreak5.TabIndex = 106
        Me.RadCheckBox_PageBreak5.Text = "SpecSetup_PageBreak"
        Me.RadCheckBox_PageBreak5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadCheckBox_LopVsTaForM
        '
        Me.RadCheckBox_LopVsTaForM.AutoSize = False
        Me.RadCheckBox_LopVsTaForM.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_LopVsTaForM.Location = New System.Drawing.Point(6, 300)
        Me.RadCheckBox_LopVsTaForM.Name = "RadCheckBox_LopVsTaForM"
        Me.RadCheckBox_LopVsTaForM.Size = New System.Drawing.Size(225, 23)
        Me.RadCheckBox_LopVsTaForM.TabIndex = 105
        Me.RadCheckBox_LopVsTaForM.Text = "SpecSetup_LopVsTaForM"
        '
        'RadCheckBox_LopVsTaForMData
        '
        Me.RadCheckBox_LopVsTaForMData.AutoSize = False
        Me.RadCheckBox_LopVsTaForMData.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_LopVsTaForMData.Location = New System.Drawing.Point(6, 323)
        Me.RadCheckBox_LopVsTaForMData.Name = "RadCheckBox_LopVsTaForMData"
        Me.RadCheckBox_LopVsTaForMData.Size = New System.Drawing.Size(225, 23)
        Me.RadCheckBox_LopVsTaForMData.TabIndex = 104
        Me.RadCheckBox_LopVsTaForMData.Text = "SpecSetup_LopVsTaForMData"
        '
        'RadCheckBox_PageBreak6
        '
        Me.RadCheckBox_PageBreak6.AutoSize = False
        Me.RadCheckBox_PageBreak6.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_PageBreak6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_PageBreak6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.RadCheckBox_PageBreak6.Location = New System.Drawing.Point(6, 346)
        Me.RadCheckBox_PageBreak6.Name = "RadCheckBox_PageBreak6"
        Me.RadCheckBox_PageBreak6.Size = New System.Drawing.Size(225, 23)
        Me.RadCheckBox_PageBreak6.TabIndex = 103
        Me.RadCheckBox_PageBreak6.Text = "SpecSetup_PageBreak"
        Me.RadCheckBox_PageBreak6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadCheckBox_MVsTaForLopData
        '
        Me.RadCheckBox_MVsTaForLopData.AutoSize = False
        Me.RadCheckBox_MVsTaForLopData.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_MVsTaForLopData.Location = New System.Drawing.Point(6, 369)
        Me.RadCheckBox_MVsTaForLopData.Name = "RadCheckBox_MVsTaForLopData"
        Me.RadCheckBox_MVsTaForLopData.Size = New System.Drawing.Size(225, 23)
        Me.RadCheckBox_MVsTaForLopData.TabIndex = 102
        Me.RadCheckBox_MVsTaForLopData.Text = "SpecSetup_MVsTaForLopData"
        '
        'RadCheckBox_MVsTaForLop
        '
        Me.RadCheckBox_MVsTaForLop.AutoSize = False
        Me.RadCheckBox_MVsTaForLop.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_MVsTaForLop.Location = New System.Drawing.Point(6, 392)
        Me.RadCheckBox_MVsTaForLop.Name = "RadCheckBox_MVsTaForLop"
        Me.RadCheckBox_MVsTaForLop.Size = New System.Drawing.Size(225, 23)
        Me.RadCheckBox_MVsTaForLop.TabIndex = 101
        Me.RadCheckBox_MVsTaForLop.Text = "SpecSetup_MVsTaForLop"
        '
        'RadCheckBox_PageBreak7
        '
        Me.RadCheckBox_PageBreak7.AutoSize = False
        Me.RadCheckBox_PageBreak7.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_PageBreak7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_PageBreak7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.RadCheckBox_PageBreak7.Location = New System.Drawing.Point(6, 415)
        Me.RadCheckBox_PageBreak7.Name = "RadCheckBox_PageBreak7"
        Me.RadCheckBox_PageBreak7.Size = New System.Drawing.Size(225, 23)
        Me.RadCheckBox_PageBreak7.TabIndex = 100
        Me.RadCheckBox_PageBreak7.Text = "SpecSetup_PageBreak"
        Me.RadCheckBox_PageBreak7.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadCheckBox_RHaDiag
        '
        Me.RadCheckBox_RHaDiag.AutoSize = False
        Me.RadCheckBox_RHaDiag.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_RHaDiag.Location = New System.Drawing.Point(6, 438)
        Me.RadCheckBox_RHaDiag.Name = "RadCheckBox_RHaDiag"
        Me.RadCheckBox_RHaDiag.Size = New System.Drawing.Size(225, 23)
        Me.RadCheckBox_RHaDiag.TabIndex = 99
        Me.RadCheckBox_RHaDiag.Text = "SpecSetup_RHaDiag"
        '
        'RadCheckBox_ShowallRhaDiagData
        '
        Me.RadCheckBox_ShowallRhaDiagData.AutoSize = False
        Me.RadCheckBox_ShowallRhaDiagData.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.RadCheckBox_ShowallRhaDiagData.Location = New System.Drawing.Point(20, 461)
        Me.RadCheckBox_ShowallRhaDiagData.Name = "RadCheckBox_ShowallRhaDiagData"
        Me.RadCheckBox_ShowallRhaDiagData.Size = New System.Drawing.Size(211, 23)
        Me.RadCheckBox_ShowallRhaDiagData.TabIndex = 98
        Me.RadCheckBox_ShowallRhaDiagData.Text = "SpecSetup_ShowallRhaDiagData"
        '
        'RadCheckBox_PageBreak8
        '
        Me.RadCheckBox_PageBreak8.AutoSize = False
        Me.RadCheckBox_PageBreak8.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_PageBreak8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_PageBreak8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.RadCheckBox_PageBreak8.Location = New System.Drawing.Point(6, 484)
        Me.RadCheckBox_PageBreak8.Name = "RadCheckBox_PageBreak8"
        Me.RadCheckBox_PageBreak8.Size = New System.Drawing.Size(225, 23)
        Me.RadCheckBox_PageBreak8.TabIndex = 97
        Me.RadCheckBox_PageBreak8.Text = "SpecSetup_PageBreak"
        Me.RadCheckBox_PageBreak8.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadCheckBox_ESRFreqData
        '
        Me.RadCheckBox_ESRFreqData.AutoSize = False
        Me.RadCheckBox_ESRFreqData.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_ESRFreqData.Location = New System.Drawing.Point(6, 507)
        Me.RadCheckBox_ESRFreqData.Name = "RadCheckBox_ESRFreqData"
        Me.RadCheckBox_ESRFreqData.Size = New System.Drawing.Size(225, 23)
        Me.RadCheckBox_ESRFreqData.TabIndex = 96
        Me.RadCheckBox_ESRFreqData.Text = "SpecSetup_ESRFreqData"
        '
        'RadCheckBox_ESRFreqGraph
        '
        Me.RadCheckBox_ESRFreqGraph.AutoSize = False
        Me.RadCheckBox_ESRFreqGraph.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_ESRFreqGraph.Location = New System.Drawing.Point(6, 530)
        Me.RadCheckBox_ESRFreqGraph.Name = "RadCheckBox_ESRFreqGraph"
        Me.RadCheckBox_ESRFreqGraph.Size = New System.Drawing.Size(225, 23)
        Me.RadCheckBox_ESRFreqGraph.TabIndex = 95
        Me.RadCheckBox_ESRFreqGraph.Text = "SpecSetup_ESRFreqGraph"
        '
        'RadCheckBox_PageBreak9
        '
        Me.RadCheckBox_PageBreak9.AutoSize = False
        Me.RadCheckBox_PageBreak9.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_PageBreak9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_PageBreak9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.RadCheckBox_PageBreak9.Location = New System.Drawing.Point(6, 553)
        Me.RadCheckBox_PageBreak9.Name = "RadCheckBox_PageBreak9"
        Me.RadCheckBox_PageBreak9.Size = New System.Drawing.Size(225, 23)
        Me.RadCheckBox_PageBreak9.TabIndex = 94
        Me.RadCheckBox_PageBreak9.Text = "SpecSetup_PageBreak"
        Me.RadCheckBox_PageBreak9.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadButton_SelectAll
        '
        Me.RadButton_SelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadButton_SelectAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_SelectAll.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_SelectAll.ForeColor = System.Drawing.Color.Black
        Me.RadButton_SelectAll.Location = New System.Drawing.Point(121, 602)
        Me.RadButton_SelectAll.Name = "RadButton_SelectAll"
        Me.RadButton_SelectAll.Size = New System.Drawing.Size(110, 32)
        Me.RadButton_SelectAll.TabIndex = 93
        Me.RadButton_SelectAll.Text = "Global_SelectAll"
        Me.RadButton_SelectAll.TextWrap = True
        '
        'RadButton_SelectNone
        '
        Me.RadButton_SelectNone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadButton_SelectNone.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_SelectNone.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_SelectNone.ForeColor = System.Drawing.Color.Black
        Me.RadButton_SelectNone.Location = New System.Drawing.Point(6, 602)
        Me.RadButton_SelectNone.Name = "RadButton_SelectNone"
        Me.RadButton_SelectNone.Size = New System.Drawing.Size(110, 32)
        Me.RadButton_SelectNone.TabIndex = 92
        Me.RadButton_SelectNone.Text = "Global_SelectNone"
        Me.RadButton_SelectNone.TextWrap = True
        '
        'RadCheckBox_KFData
        '
        Me.RadCheckBox_KFData.AutoSize = False
        Me.RadCheckBox_KFData.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_KFData.Location = New System.Drawing.Point(6, 576)
        Me.RadCheckBox_KFData.Name = "RadCheckBox_KFData"
        Me.RadCheckBox_KFData.Size = New System.Drawing.Size(225, 23)
        Me.RadCheckBox_KFData.TabIndex = 91
        Me.RadCheckBox_KFData.Text = "SpecSetup_KFData"
        '
        'Panel_Selects2
        '
        Me.Panel_Selects2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Selects2.Controls.Add(Me.RadCheckBox_InhibitSpec)
        Me.Panel_Selects2.Controls.Add(Me.RadCheckBox_ShowLopEquation)
        Me.Panel_Selects2.Controls.Add(Me.RadCheckBox_ShowSampleDisclaimer)
        Me.Panel_Selects2.Location = New System.Drawing.Point(953, 75)
        Me.Panel_Selects2.Name = "Panel_Selects2"
        Me.Panel_Selects2.Size = New System.Drawing.Size(240, 82)
        Me.Panel_Selects2.TabIndex = 129
        '
        'RadCheckBox_InhibitSpec
        '
        Me.RadCheckBox_InhibitSpec.AutoSize = False
        Me.RadCheckBox_InhibitSpec.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_InhibitSpec.Location = New System.Drawing.Point(12, 5)
        Me.RadCheckBox_InhibitSpec.Margin = New System.Windows.Forms.Padding(0)
        Me.RadCheckBox_InhibitSpec.Name = "RadCheckBox_InhibitSpec"
        Me.RadCheckBox_InhibitSpec.Size = New System.Drawing.Size(220, 21)
        Me.RadCheckBox_InhibitSpec.TabIndex = 111
        Me.RadCheckBox_InhibitSpec.Text = "SpecSetup_InhibitSpec"
        '
        'RadCheckBox_ShowLopEquation
        '
        Me.RadCheckBox_ShowLopEquation.AutoSize = False
        Me.RadCheckBox_ShowLopEquation.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_ShowLopEquation.Location = New System.Drawing.Point(12, 28)
        Me.RadCheckBox_ShowLopEquation.Margin = New System.Windows.Forms.Padding(0)
        Me.RadCheckBox_ShowLopEquation.Name = "RadCheckBox_ShowLopEquation"
        Me.RadCheckBox_ShowLopEquation.Size = New System.Drawing.Size(220, 21)
        Me.RadCheckBox_ShowLopEquation.TabIndex = 110
        Me.RadCheckBox_ShowLopEquation.Text = "SpecSetup_ShowLopEquation"
        '
        'RadCheckBox_ShowSampleDisclaimer
        '
        Me.RadCheckBox_ShowSampleDisclaimer.AutoSize = False
        Me.RadCheckBox_ShowSampleDisclaimer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_ShowSampleDisclaimer.Location = New System.Drawing.Point(12, 51)
        Me.RadCheckBox_ShowSampleDisclaimer.Margin = New System.Windows.Forms.Padding(0)
        Me.RadCheckBox_ShowSampleDisclaimer.Name = "RadCheckBox_ShowSampleDisclaimer"
        Me.RadCheckBox_ShowSampleDisclaimer.Size = New System.Drawing.Size(220, 21)
        Me.RadCheckBox_ShowSampleDisclaimer.TabIndex = 109
        Me.RadCheckBox_ShowSampleDisclaimer.Text = "SpecSetup_ShowSampleDisclaimer"
        '
        'Panel_ViewExport
        '
        Me.Panel_ViewExport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_ViewExport.Controls.Add(Me.RadButton1)
        Me.Panel_ViewExport.Controls.Add(Me.RadTextBox_PDFPath)
        Me.Panel_ViewExport.Controls.Add(Me.RadTextBox_Header)
        Me.Panel_ViewExport.Controls.Add(Me.RadLabel_PDFPath)
        Me.Panel_ViewExport.Controls.Add(Me.RadLabel_Header)
        Me.Panel_ViewExport.Controls.Add(Me.RadCheckBox_ExportstraighttoPDF)
        Me.Panel_ViewExport.Controls.Add(Me.RadButton_ViewReport)
        Me.Panel_ViewExport.Controls.Add(Me.RadButton_AddAllDefaults)
        Me.Panel_ViewExport.Location = New System.Drawing.Point(953, 163)
        Me.Panel_ViewExport.Name = "Panel_ViewExport"
        Me.Panel_ViewExport.Size = New System.Drawing.Size(240, 188)
        Me.Panel_ViewExport.TabIndex = 130
        '
        'RadButton1
        '
        Me.RadButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton1.ForeColor = System.Drawing.Color.Black
        Me.RadButton1.Location = New System.Drawing.Point(172, 104)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(61, 20)
        Me.RadButton1.TabIndex = 95
        Me.RadButton1.Text = "SpecSetup_UsePN"
        Me.RadButton1.TextWrap = True
        '
        'RadTextBox_PDFPath
        '
        Me.RadTextBox_PDFPath.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_PDFPath.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_PDFPath.Location = New System.Drawing.Point(3, 123)
        Me.RadTextBox_PDFPath.Name = "RadTextBox_PDFPath"
        Me.RadTextBox_PDFPath.Size = New System.Drawing.Size(230, 20)
        Me.RadTextBox_PDFPath.TabIndex = 112
        Me.RadTextBox_PDFPath.Text = "Unbound"
        Me.RadTextBox_PDFPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_Header
        '
        Me.RadTextBox_Header.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_Header.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Header.Location = New System.Drawing.Point(3, 161)
        Me.RadTextBox_Header.Name = "RadTextBox_Header"
        Me.RadTextBox_Header.Size = New System.Drawing.Size(230, 20)
        Me.RadTextBox_Header.TabIndex = 111
        Me.RadTextBox_Header.Text = "Unbound"
        Me.RadTextBox_Header.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_PDFPath
        '
        Me.RadLabel_PDFPath.AutoSize = False
        Me.RadLabel_PDFPath.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_PDFPath.Location = New System.Drawing.Point(3, 109)
        Me.RadLabel_PDFPath.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_PDFPath.Name = "RadLabel_PDFPath"
        Me.RadLabel_PDFPath.Size = New System.Drawing.Size(168, 15)
        Me.RadLabel_PDFPath.TabIndex = 114
        Me.RadLabel_PDFPath.Text = "SpecSetup_PDFPath"
        Me.RadLabel_PDFPath.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_Header
        '
        Me.RadLabel_Header.AutoSize = False
        Me.RadLabel_Header.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Header.Location = New System.Drawing.Point(3, 147)
        Me.RadLabel_Header.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Header.Name = "RadLabel_Header"
        Me.RadLabel_Header.Size = New System.Drawing.Size(168, 15)
        Me.RadLabel_Header.TabIndex = 113
        Me.RadLabel_Header.Text = "SpecSetup_Header"
        Me.RadLabel_Header.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadCheckBox_ExportstraighttoPDF
        '
        Me.RadCheckBox_ExportstraighttoPDF.AutoSize = False
        Me.RadCheckBox_ExportstraighttoPDF.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadCheckBox_ExportstraighttoPDF.Location = New System.Drawing.Point(8, 82)
        Me.RadCheckBox_ExportstraighttoPDF.Margin = New System.Windows.Forms.Padding(0)
        Me.RadCheckBox_ExportstraighttoPDF.Name = "RadCheckBox_ExportstraighttoPDF"
        Me.RadCheckBox_ExportstraighttoPDF.Size = New System.Drawing.Size(220, 21)
        Me.RadCheckBox_ExportstraighttoPDF.TabIndex = 110
        Me.RadCheckBox_ExportstraighttoPDF.Text = "SpecSetup_ExportstraighttoPDF"
        '
        'RadButton_ViewReport
        '
        Me.RadButton_ViewReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadButton_ViewReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_ViewReport.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_ViewReport.ForeColor = System.Drawing.Color.Black
        Me.RadButton_ViewReport.Location = New System.Drawing.Point(7, 46)
        Me.RadButton_ViewReport.Name = "RadButton_ViewReport"
        Me.RadButton_ViewReport.Size = New System.Drawing.Size(224, 35)
        Me.RadButton_ViewReport.TabIndex = 94
        Me.RadButton_ViewReport.Text = "Global_ViewReport"
        Me.RadButton_ViewReport.TextWrap = True
        '
        'RadButton_AddAllDefaults
        '
        Me.RadButton_AddAllDefaults.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadButton_AddAllDefaults.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_AddAllDefaults.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_AddAllDefaults.ForeColor = System.Drawing.Color.Black
        Me.RadButton_AddAllDefaults.Location = New System.Drawing.Point(7, 5)
        Me.RadButton_AddAllDefaults.Name = "RadButton_AddAllDefaults"
        Me.RadButton_AddAllDefaults.Size = New System.Drawing.Size(224, 35)
        Me.RadButton_AddAllDefaults.TabIndex = 93
        Me.RadButton_AddAllDefaults.Text = "SpecSetup_AddAllDefaults"
        Me.RadButton_AddAllDefaults.TextWrap = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ECAD.My.Resources.Resources.kemet_logo_small
        Me.PictureBox1.Location = New System.Drawing.Point(957, 358)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 327)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 131
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'SpecificationSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1199, 727)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel_ViewExport)
        Me.Controls.Add(Me.Panel_Selects2)
        Me.Controls.Add(Me.Panel_Selects)
        Me.Controls.Add(Me.RadGridView_KVTemp)
        Me.Controls.Add(Me.RadGridView_ESRFTemp)
        Me.Controls.Add(Me.RadGridView_KFTemp)
        Me.Controls.Add(Me.RadGridView_IrMultiplier)
        Me.Controls.Add(Me.RadGridView_KVPercentage)
        Me.Controls.Add(Me.RadLabel_KFTemp)
        Me.Controls.Add(Me.RadLabel_IrMultiplier)
        Me.Controls.Add(Me.RadLabel_KVPercentage)
        Me.Controls.Add(Me.RadGridView_KFFreq)
        Me.Controls.Add(Me.RadLabel_KFFreq)
        Me.Controls.Add(Me.RadGridView_LifeExp)
        Me.Controls.Add(Me.RadLabel_KVTemp)
        Me.Controls.Add(Me.RadLabel_ESRFTemp)
        Me.Controls.Add(Me.RadLabel_LifeExp)
        Me.Controls.Add(Me.RadGridView_ESRFF)
        Me.Controls.Add(Me.RadGridView_CoreRise)
        Me.Controls.Add(Me.RadGridView_AmbientTemp)
        Me.Controls.Add(Me.RadLabel_ESRFF)
        Me.Controls.Add(Me.RadLabel_CoreRise)
        Me.Controls.Add(Me.RadLabel_AmbientTemp)
        Me.Controls.Add(Me.Panel_Header)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SpecificationSetup"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SpecSetup_Title"
        Me.ThemeName = "Windows8"
        Me.Panel_Header.ResumeLayout(False)
        CType(Me.RadCheckBox_CatData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Rectangle3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Rectangle2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Rectangle1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_IDTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_InnerTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_AmbientTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_AmbientTemp.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_AmbientTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_CoreRise.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_CoreRise, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_CoreRise, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_ESRFF.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_ESRFF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ESRFF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_LifeExp.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_LifeExp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_KVTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ESRFTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_LifeExp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_KFFreq.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_KFFreq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_KFFreq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_KVPercentage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_KFTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_IrMultiplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_KVPercentage.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_KVPercentage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_IrMultiplier.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_IrMultiplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_KFTemp.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_KFTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_ESRFTemp.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_ESRFTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_KVTemp.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_KVTemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Selects.ResumeLayout(False)
        CType(Me.RadCheckBox_LopVsTaForTrData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_OnePage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_RippleQuote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_PageBreak1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_LifeDefinitions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_PageBreak2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_ESRData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_PageBreak3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_LopVsTaForTrGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_PageBreak4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_KVDeratingGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_KVDeratingData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_PageBreak5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_LopVsTaForM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_LopVsTaForMData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_PageBreak6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_MVsTaForLopData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_MVsTaForLop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_PageBreak7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_RHaDiag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_ShowallRhaDiagData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_PageBreak8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_ESRFreqData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_ESRFreqGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_PageBreak9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_SelectAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_SelectNone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_KFData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Selects2.ResumeLayout(False)
        CType(Me.RadCheckBox_InhibitSpec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_ShowLopEquation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_ShowSampleDisclaimer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_ViewExport.ResumeLayout(False)
        Me.Panel_ViewExport.PerformLayout()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_PDFPath, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Header, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PDFPath, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Header, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_ExportstraighttoPDF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_ViewReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_AddAllDefaults, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Header As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_InnerTitle As Telerik.WinControls.UI.RadLabel
    Friend WithEvents PictureBox_KemetLogo As System.Windows.Forms.PictureBox
    Friend WithEvents RadLabel_ID As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_IDTxt As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Rectangle1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Rectangle3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Rectangle2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadCheckBox_CatData As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel_AmbientTemp As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGridView_AmbientTemp As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadGridView_CoreRise As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel_CoreRise As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_ESRFF As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGridView_ESRFF As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel_KVTemp As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGridView_LifeExp As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel_ESRFTemp As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_LifeExp As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_KFFreq As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGridView_KFFreq As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel_KVPercentage As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_KFTemp As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_IrMultiplier As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGridView_KVPercentage As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadGridView_IrMultiplier As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadGridView_KFTemp As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadGridView_ESRFTemp As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadGridView_KVTemp As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Panel_Selects As System.Windows.Forms.Panel
    Friend WithEvents Panel_Selects2 As System.Windows.Forms.Panel
    Friend WithEvents Panel_ViewExport As System.Windows.Forms.Panel
    Friend WithEvents RadCheckBox_KFData As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadButton_SelectNone As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_SelectAll As Telerik.WinControls.UI.RadButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RadCheckBox_PageBreak9 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_ESRFreqData As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_ESRFreqGraph As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_PageBreak8 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_MVsTaForLopData As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_MVsTaForLop As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_PageBreak7 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_RHaDiag As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_ShowallRhaDiagData As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_LopVsTaForTrGraph As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_PageBreak4 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_KVDeratingGraph As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_KVDeratingData As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_PageBreak5 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_LopVsTaForM As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_LopVsTaForMData As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_PageBreak6 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_PageBreak1 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_LifeDefinitions As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_PageBreak2 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_ESRData As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_PageBreak3 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_OnePage As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_RippleQuote As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_LopVsTaForTrData As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_InhibitSpec As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_ShowLopEquation As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_ShowSampleDisclaimer As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadButton_ViewReport As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_AddAllDefaults As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadCheckBox_ExportstraighttoPDF As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadTextBox_PDFPath As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Header As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_PDFPath As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Header As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
End Class

