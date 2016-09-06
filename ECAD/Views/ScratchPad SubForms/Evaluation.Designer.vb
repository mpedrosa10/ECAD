<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Evaluation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Evaluation))
        Me.RadLabel_PartNumber = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_FormingVoltage = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_PartNumber = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_FormingVoltage = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Counter = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Counter = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_MaxCounter = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_of = New Telerik.WinControls.UI.RadLabel()
        Me.RadButton_Evaluate = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel_CurrentEvaluationstored = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox__CurrentEvaluationstored = New Telerik.WinControls.UI.RadTextBox()
        Me.RadRadioButton_NonSlotted = New Telerik.WinControls.UI.RadRadioButton()
        Me.Panel_CathType = New System.Windows.Forms.Panel()
        Me.RadRadioButton_All = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadRadioButton_Slotted = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadCheckBox_Anodes = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_Cathodes = New Telerik.WinControls.UI.RadCheckBox()
        Me.Panel_BestCost = New System.Windows.Forms.Panel()
        Me.RadTextBox_fit = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_fit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_esr = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_esr = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_saltotalcost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_saltotalcost = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_stdtotalcost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_stdtotalcost = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_BestCostCathodeName = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_BestCostCathodeName = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_FirstAnodeName = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_FirstAnodeName = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_BestCostTitle = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_BestCost = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_BestESR = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_AnodeName = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_CathodeName = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_AnodePtNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_CathodePtNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_id = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_id = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_user = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_user = New Telerik.WinControls.UI.RadLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadTextBox_BestESRfit = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_BestESRfit = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_BestESResr = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_BestESResr = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_BestESRsaltotalcost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_BestESRsaltotalcost = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_BestESRstdtotalcost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_BestESRstdtotalcost = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_BestESRCathodeName = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_BestESRCathodeName = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_BestESRFirstAnodeName = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_BestESRFirstAnodeName = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_BestESRTitle = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadLabel_PartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_FormingVoltage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_PartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_FormingVoltage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Counter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Counter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_MaxCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_of, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Evaluate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_CurrentEvaluationstored, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox__CurrentEvaluationstored, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton_NonSlotted, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_CathType.SuspendLayout()
        CType(Me.RadRadioButton_All, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton_Slotted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_Anodes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_Cathodes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_BestCost.SuspendLayout()
        CType(Me.RadTextBox_fit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_fit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_esr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_esr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_saltotalcost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_saltotalcost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_stdtotalcost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_stdtotalcost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_BestCostCathodeName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_BestCostCathodeName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_FirstAnodeName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_FirstAnodeName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_BestCostTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_BestCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_BestESR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_AnodeName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_CathodeName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_AnodePtNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CathodePtNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.RadTextBox_BestESRfit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_BestESRfit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_BestESResr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_BestESResr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_BestESRsaltotalcost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_BestESRsaltotalcost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_BestESRstdtotalcost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_BestESRstdtotalcost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_BestESRCathodeName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_BestESRCathodeName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_BestESRFirstAnodeName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_BestESRFirstAnodeName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_BestESRTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel_PartNumber
        '
        Me.RadLabel_PartNumber.AutoSize = False
        Me.RadLabel_PartNumber.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_PartNumber.Location = New System.Drawing.Point(2, 10)
        Me.RadLabel_PartNumber.Name = "RadLabel_PartNumber"
        Me.RadLabel_PartNumber.Size = New System.Drawing.Size(190, 32)
        Me.RadLabel_PartNumber.TabIndex = 28
        Me.RadLabel_PartNumber.Text = "Global_PartNumber"
        Me.RadLabel_PartNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_FormingVoltage
        '
        Me.RadLabel_FormingVoltage.AutoSize = False
        Me.RadLabel_FormingVoltage.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_FormingVoltage.Location = New System.Drawing.Point(2, 48)
        Me.RadLabel_FormingVoltage.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_FormingVoltage.Name = "RadLabel_FormingVoltage"
        Me.RadLabel_FormingVoltage.Size = New System.Drawing.Size(190, 32)
        Me.RadLabel_FormingVoltage.TabIndex = 29
        Me.RadLabel_FormingVoltage.Text = "Evaluation_FormingVoltage"
        Me.RadLabel_FormingVoltage.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_PartNumber
        '
        Me.RadTextBox_PartNumber.Enabled = False
        Me.RadTextBox_PartNumber.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_PartNumber.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_PartNumber.Location = New System.Drawing.Point(194, 10)
        Me.RadTextBox_PartNumber.Name = "RadTextBox_PartNumber"
        Me.RadTextBox_PartNumber.Size = New System.Drawing.Size(230, 34)
        Me.RadTextBox_PartNumber.TabIndex = 30
        Me.RadTextBox_PartNumber.Text = "Unbound"
        '
        'RadTextBox_FormingVoltage
        '
        Me.RadTextBox_FormingVoltage.Enabled = False
        Me.RadTextBox_FormingVoltage.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_FormingVoltage.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_FormingVoltage.Location = New System.Drawing.Point(194, 48)
        Me.RadTextBox_FormingVoltage.Name = "RadTextBox_FormingVoltage"
        Me.RadTextBox_FormingVoltage.Size = New System.Drawing.Size(70, 34)
        Me.RadTextBox_FormingVoltage.TabIndex = 31
        Me.RadTextBox_FormingVoltage.Text = "Unbound"
        '
        'RadLabel_Counter
        '
        Me.RadLabel_Counter.AutoSize = False
        Me.RadLabel_Counter.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadLabel_Counter.Location = New System.Drawing.Point(269, 56)
        Me.RadLabel_Counter.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Counter.Name = "RadLabel_Counter"
        Me.RadLabel_Counter.Size = New System.Drawing.Size(140, 16)
        Me.RadLabel_Counter.TabIndex = 30
        Me.RadLabel_Counter.Text = "Evaluation_Counter"
        Me.RadLabel_Counter.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadTextBox_Counter
        '
        Me.RadTextBox_Counter.Enabled = False
        Me.RadTextBox_Counter.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Counter.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Counter.Location = New System.Drawing.Point(269, 75)
        Me.RadTextBox_Counter.Name = "RadTextBox_Counter"
        Me.RadTextBox_Counter.Size = New System.Drawing.Size(54, 34)
        Me.RadTextBox_Counter.TabIndex = 32
        Me.RadTextBox_Counter.Text = "Unbound"
        '
        'RadTextBox_MaxCounter
        '
        Me.RadTextBox_MaxCounter.Enabled = False
        Me.RadTextBox_MaxCounter.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_MaxCounter.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_MaxCounter.Location = New System.Drawing.Point(355, 75)
        Me.RadTextBox_MaxCounter.Name = "RadTextBox_MaxCounter"
        Me.RadTextBox_MaxCounter.Size = New System.Drawing.Size(54, 34)
        Me.RadTextBox_MaxCounter.TabIndex = 33
        Me.RadTextBox_MaxCounter.Text = "Unbound"
        '
        'RadLabel_of
        '
        Me.RadLabel_of.AutoSize = False
        Me.RadLabel_of.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_of.Location = New System.Drawing.Point(321, 77)
        Me.RadLabel_of.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_of.Name = "RadLabel_of"
        Me.RadLabel_of.Size = New System.Drawing.Size(35, 32)
        Me.RadLabel_of.TabIndex = 34
        Me.RadLabel_of.Text = "Global_of"
        Me.RadLabel_of.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadButton_Evaluate
        '
        Me.RadButton_Evaluate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_Evaluate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Evaluate.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Evaluate.Location = New System.Drawing.Point(27, 79)
        Me.RadButton_Evaluate.Name = "RadButton_Evaluate"
        Me.RadButton_Evaluate.Size = New System.Drawing.Size(85, 38)
        Me.RadButton_Evaluate.TabIndex = 35
        Me.RadButton_Evaluate.Text = "Evaluation_Evaluate"
        Me.RadButton_Evaluate.TextWrap = True
        '
        'RadLabel_CurrentEvaluationstored
        '
        Me.RadLabel_CurrentEvaluationstored.AutoSize = False
        Me.RadLabel_CurrentEvaluationstored.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadLabel_CurrentEvaluationstored.Location = New System.Drawing.Point(252, 128)
        Me.RadLabel_CurrentEvaluationstored.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_CurrentEvaluationstored.Name = "RadLabel_CurrentEvaluationstored"
        Me.RadLabel_CurrentEvaluationstored.Size = New System.Drawing.Size(130, 16)
        Me.RadLabel_CurrentEvaluationstored.TabIndex = 36
        Me.RadLabel_CurrentEvaluationstored.Text = "Evaluation_CurrentEvaluationstored"
        Me.RadLabel_CurrentEvaluationstored.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadTextBox__CurrentEvaluationstored
        '
        Me.RadTextBox__CurrentEvaluationstored.Enabled = False
        Me.RadTextBox__CurrentEvaluationstored.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox__CurrentEvaluationstored.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox__CurrentEvaluationstored.Location = New System.Drawing.Point(252, 143)
        Me.RadTextBox__CurrentEvaluationstored.Name = "RadTextBox__CurrentEvaluationstored"
        Me.RadTextBox__CurrentEvaluationstored.Size = New System.Drawing.Size(130, 20)
        Me.RadTextBox__CurrentEvaluationstored.TabIndex = 37
        Me.RadTextBox__CurrentEvaluationstored.Text = "Unbound"
        '
        'RadRadioButton_NonSlotted
        '
        Me.RadRadioButton_NonSlotted.AutoSize = False
        Me.RadRadioButton_NonSlotted.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadRadioButton_NonSlotted.Location = New System.Drawing.Point(3, 4)
        Me.RadRadioButton_NonSlotted.Name = "RadRadioButton_NonSlotted"
        Me.RadRadioButton_NonSlotted.Size = New System.Drawing.Size(85, 18)
        Me.RadRadioButton_NonSlotted.TabIndex = 38
        Me.RadRadioButton_NonSlotted.Text = "Evaluation_NonSlotted"
        '
        'Panel_CathType
        '
        Me.Panel_CathType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_CathType.Controls.Add(Me.RadRadioButton_All)
        Me.Panel_CathType.Controls.Add(Me.RadRadioButton_Slotted)
        Me.Panel_CathType.Controls.Add(Me.RadRadioButton_NonSlotted)
        Me.Panel_CathType.Location = New System.Drawing.Point(173, 181)
        Me.Panel_CathType.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_CathType.Name = "Panel_CathType"
        Me.Panel_CathType.Size = New System.Drawing.Size(220, 31)
        Me.Panel_CathType.TabIndex = 39
        '
        'RadRadioButton_All
        '
        Me.RadRadioButton_All.AutoSize = False
        Me.RadRadioButton_All.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadRadioButton_All.Location = New System.Drawing.Point(174, 4)
        Me.RadRadioButton_All.Name = "RadRadioButton_All"
        Me.RadRadioButton_All.Size = New System.Drawing.Size(40, 18)
        Me.RadRadioButton_All.TabIndex = 40
        Me.RadRadioButton_All.Text = "Global_All"
        '
        'RadRadioButton_Slotted
        '
        Me.RadRadioButton_Slotted.AutoSize = False
        Me.RadRadioButton_Slotted.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadRadioButton_Slotted.Location = New System.Drawing.Point(93, 4)
        Me.RadRadioButton_Slotted.Name = "RadRadioButton_Slotted"
        Me.RadRadioButton_Slotted.Size = New System.Drawing.Size(75, 18)
        Me.RadRadioButton_Slotted.TabIndex = 39
        Me.RadRadioButton_Slotted.Text = "Evaluation_Slotted"
        '
        'RadCheckBox_Anodes
        '
        Me.RadCheckBox_Anodes.AutoSize = False
        Me.RadCheckBox_Anodes.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Anodes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadCheckBox_Anodes.Location = New System.Drawing.Point(43, 155)
        Me.RadCheckBox_Anodes.Name = "RadCheckBox_Anodes"
        Me.RadCheckBox_Anodes.Size = New System.Drawing.Size(120, 20)
        Me.RadCheckBox_Anodes.TabIndex = 88
        Me.RadCheckBox_Anodes.Text = "Global_Anodes"
        Me.RadCheckBox_Anodes.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadCheckBox_Cathodes
        '
        Me.RadCheckBox_Cathodes.AutoSize = False
        Me.RadCheckBox_Cathodes.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Cathodes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadCheckBox_Cathodes.Location = New System.Drawing.Point(43, 178)
        Me.RadCheckBox_Cathodes.Name = "RadCheckBox_Cathodes"
        Me.RadCheckBox_Cathodes.Size = New System.Drawing.Size(120, 20)
        Me.RadCheckBox_Cathodes.TabIndex = 89
        Me.RadCheckBox_Cathodes.Text = "Global_Cathodes"
        Me.RadCheckBox_Cathodes.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel_BestCost
        '
        Me.Panel_BestCost.AutoScroll = True
        Me.Panel_BestCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_BestCost.Controls.Add(Me.RadTextBox_fit)
        Me.Panel_BestCost.Controls.Add(Me.RadLabel_fit)
        Me.Panel_BestCost.Controls.Add(Me.RadTextBox_esr)
        Me.Panel_BestCost.Controls.Add(Me.RadLabel_esr)
        Me.Panel_BestCost.Controls.Add(Me.RadTextBox_saltotalcost)
        Me.Panel_BestCost.Controls.Add(Me.RadLabel_saltotalcost)
        Me.Panel_BestCost.Controls.Add(Me.RadTextBox_stdtotalcost)
        Me.Panel_BestCost.Controls.Add(Me.RadLabel_stdtotalcost)
        Me.Panel_BestCost.Controls.Add(Me.RadTextBox_BestCostCathodeName)
        Me.Panel_BestCost.Controls.Add(Me.RadLabel_BestCostCathodeName)
        Me.Panel_BestCost.Controls.Add(Me.RadTextBox_FirstAnodeName)
        Me.Panel_BestCost.Controls.Add(Me.RadLabel_FirstAnodeName)
        Me.Panel_BestCost.Controls.Add(Me.RadLabel_BestCostTitle)
        Me.Panel_BestCost.Location = New System.Drawing.Point(27, 242)
        Me.Panel_BestCost.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_BestCost.MinimumSize = New System.Drawing.Size(340, 76)
        Me.Panel_BestCost.Name = "Panel_BestCost"
        Me.Panel_BestCost.Size = New System.Drawing.Size(340, 76)
        Me.Panel_BestCost.TabIndex = 90
        '
        'RadTextBox_fit
        '
        Me.RadTextBox_fit.Enabled = False
        Me.RadTextBox_fit.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_fit.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_fit.Location = New System.Drawing.Point(161, 155)
        Me.RadTextBox_fit.Name = "RadTextBox_fit"
        Me.RadTextBox_fit.Size = New System.Drawing.Size(130, 20)
        Me.RadTextBox_fit.TabIndex = 103
        Me.RadTextBox_fit.Text = "Unbound"
        '
        'RadLabel_fit
        '
        Me.RadLabel_fit.AutoSize = False
        Me.RadLabel_fit.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_fit.Location = New System.Drawing.Point(17, 156)
        Me.RadLabel_fit.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_fit.Name = "RadLabel_fit"
        Me.RadLabel_fit.Size = New System.Drawing.Size(140, 18)
        Me.RadLabel_fit.TabIndex = 102
        Me.RadLabel_fit.Text = "Evaluation_fit"
        Me.RadLabel_fit.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_esr
        '
        Me.RadTextBox_esr.Enabled = False
        Me.RadTextBox_esr.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_esr.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_esr.Location = New System.Drawing.Point(161, 131)
        Me.RadTextBox_esr.Name = "RadTextBox_esr"
        Me.RadTextBox_esr.Size = New System.Drawing.Size(130, 20)
        Me.RadTextBox_esr.TabIndex = 101
        Me.RadTextBox_esr.Text = "Unbound"
        '
        'RadLabel_esr
        '
        Me.RadLabel_esr.AutoSize = False
        Me.RadLabel_esr.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_esr.Location = New System.Drawing.Point(17, 132)
        Me.RadLabel_esr.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_esr.Name = "RadLabel_esr"
        Me.RadLabel_esr.Size = New System.Drawing.Size(140, 18)
        Me.RadLabel_esr.TabIndex = 100
        Me.RadLabel_esr.Text = "Evaluation_esr"
        Me.RadLabel_esr.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_saltotalcost
        '
        Me.RadTextBox_saltotalcost.Enabled = False
        Me.RadTextBox_saltotalcost.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_saltotalcost.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_saltotalcost.Location = New System.Drawing.Point(161, 107)
        Me.RadTextBox_saltotalcost.Name = "RadTextBox_saltotalcost"
        Me.RadTextBox_saltotalcost.Size = New System.Drawing.Size(130, 20)
        Me.RadTextBox_saltotalcost.TabIndex = 99
        Me.RadTextBox_saltotalcost.Text = "Unbound"
        '
        'RadLabel_saltotalcost
        '
        Me.RadLabel_saltotalcost.AutoSize = False
        Me.RadLabel_saltotalcost.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_saltotalcost.Location = New System.Drawing.Point(17, 108)
        Me.RadLabel_saltotalcost.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_saltotalcost.Name = "RadLabel_saltotalcost"
        Me.RadLabel_saltotalcost.Size = New System.Drawing.Size(140, 18)
        Me.RadLabel_saltotalcost.TabIndex = 98
        Me.RadLabel_saltotalcost.Text = "Evaluation_saltotalcost"
        Me.RadLabel_saltotalcost.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_stdtotalcost
        '
        Me.RadTextBox_stdtotalcost.Enabled = False
        Me.RadTextBox_stdtotalcost.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_stdtotalcost.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_stdtotalcost.Location = New System.Drawing.Point(161, 83)
        Me.RadTextBox_stdtotalcost.Name = "RadTextBox_stdtotalcost"
        Me.RadTextBox_stdtotalcost.Size = New System.Drawing.Size(130, 20)
        Me.RadTextBox_stdtotalcost.TabIndex = 97
        Me.RadTextBox_stdtotalcost.Text = "Unbound"
        '
        'RadLabel_stdtotalcost
        '
        Me.RadLabel_stdtotalcost.AutoSize = False
        Me.RadLabel_stdtotalcost.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_stdtotalcost.Location = New System.Drawing.Point(17, 84)
        Me.RadLabel_stdtotalcost.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_stdtotalcost.Name = "RadLabel_stdtotalcost"
        Me.RadLabel_stdtotalcost.Size = New System.Drawing.Size(140, 18)
        Me.RadLabel_stdtotalcost.TabIndex = 96
        Me.RadLabel_stdtotalcost.Text = "Evaluation_stdtotalcost"
        Me.RadLabel_stdtotalcost.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_BestCostCathodeName
        '
        Me.RadTextBox_BestCostCathodeName.Enabled = False
        Me.RadTextBox_BestCostCathodeName.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_BestCostCathodeName.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_BestCostCathodeName.Location = New System.Drawing.Point(161, 59)
        Me.RadTextBox_BestCostCathodeName.Name = "RadTextBox_BestCostCathodeName"
        Me.RadTextBox_BestCostCathodeName.Size = New System.Drawing.Size(130, 20)
        Me.RadTextBox_BestCostCathodeName.TabIndex = 95
        Me.RadTextBox_BestCostCathodeName.Text = "Unbound"
        '
        'RadLabel_BestCostCathodeName
        '
        Me.RadLabel_BestCostCathodeName.AutoSize = False
        Me.RadLabel_BestCostCathodeName.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_BestCostCathodeName.Location = New System.Drawing.Point(17, 60)
        Me.RadLabel_BestCostCathodeName.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_BestCostCathodeName.Name = "RadLabel_BestCostCathodeName"
        Me.RadLabel_BestCostCathodeName.Size = New System.Drawing.Size(140, 18)
        Me.RadLabel_BestCostCathodeName.TabIndex = 94
        Me.RadLabel_BestCostCathodeName.Text = "Evaluation_BestCostCathodeName"
        Me.RadLabel_BestCostCathodeName.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_FirstAnodeName
        '
        Me.RadTextBox_FirstAnodeName.Enabled = False
        Me.RadTextBox_FirstAnodeName.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_FirstAnodeName.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_FirstAnodeName.Location = New System.Drawing.Point(161, 35)
        Me.RadTextBox_FirstAnodeName.Name = "RadTextBox_FirstAnodeName"
        Me.RadTextBox_FirstAnodeName.Size = New System.Drawing.Size(130, 20)
        Me.RadTextBox_FirstAnodeName.TabIndex = 93
        Me.RadTextBox_FirstAnodeName.Text = "Unbound"
        '
        'RadLabel_FirstAnodeName
        '
        Me.RadLabel_FirstAnodeName.AutoSize = False
        Me.RadLabel_FirstAnodeName.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_FirstAnodeName.Location = New System.Drawing.Point(17, 36)
        Me.RadLabel_FirstAnodeName.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_FirstAnodeName.Name = "RadLabel_FirstAnodeName"
        Me.RadLabel_FirstAnodeName.Size = New System.Drawing.Size(140, 18)
        Me.RadLabel_FirstAnodeName.TabIndex = 92
        Me.RadLabel_FirstAnodeName.Text = "Evaluation_FirstAnodeName"
        Me.RadLabel_FirstAnodeName.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_BestCostTitle
        '
        Me.RadLabel_BestCostTitle.AutoSize = False
        Me.RadLabel_BestCostTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_BestCostTitle.ForeColor = System.Drawing.Color.White
        Me.RadLabel_BestCostTitle.Location = New System.Drawing.Point(0, 6)
        Me.RadLabel_BestCostTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_BestCostTitle.Name = "RadLabel_BestCostTitle"
        Me.RadLabel_BestCostTitle.Size = New System.Drawing.Size(314, 25)
        Me.RadLabel_BestCostTitle.TabIndex = 30
        Me.RadLabel_BestCostTitle.Text = "Evaluation_BestCostTitle"
        Me.RadLabel_BestCostTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadLabel_BestCost
        '
        Me.RadLabel_BestCost.AutoSize = False
        Me.RadLabel_BestCost.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_BestCost.Location = New System.Drawing.Point(27, 224)
        Me.RadLabel_BestCost.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_BestCost.Name = "RadLabel_BestCost"
        Me.RadLabel_BestCost.Size = New System.Drawing.Size(190, 18)
        Me.RadLabel_BestCost.TabIndex = 91
        Me.RadLabel_BestCost.Text = "Evaluation_BestCost"
        Me.RadLabel_BestCost.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_BestESR
        '
        Me.RadLabel_BestESR.AutoSize = False
        Me.RadLabel_BestESR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_BestESR.Location = New System.Drawing.Point(27, 324)
        Me.RadLabel_BestESR.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_BestESR.Name = "RadLabel_BestESR"
        Me.RadLabel_BestESR.Size = New System.Drawing.Size(190, 18)
        Me.RadLabel_BestESR.TabIndex = 93
        Me.RadLabel_BestESR.Text = "Evaluation_BestESR"
        Me.RadLabel_BestESR.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_AnodeName
        '
        Me.RadLabel_AnodeName.AutoSize = False
        Me.RadLabel_AnodeName.BackColor = System.Drawing.Color.White
        Me.RadLabel_AnodeName.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadLabel_AnodeName.Location = New System.Drawing.Point(417, 88)
        Me.RadLabel_AnodeName.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_AnodeName.Name = "RadLabel_AnodeName"
        Me.RadLabel_AnodeName.Size = New System.Drawing.Size(47, 28)
        Me.RadLabel_AnodeName.TabIndex = 94
        Me.RadLabel_AnodeName.Text = "Evaluation_anodename"
        Me.RadLabel_AnodeName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_AnodeName.Visible = False
        '
        'RadLabel_CathodeName
        '
        Me.RadLabel_CathodeName.AutoSize = False
        Me.RadLabel_CathodeName.BackColor = System.Drawing.Color.White
        Me.RadLabel_CathodeName.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadLabel_CathodeName.Location = New System.Drawing.Point(417, 150)
        Me.RadLabel_CathodeName.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_CathodeName.Name = "RadLabel_CathodeName"
        Me.RadLabel_CathodeName.Size = New System.Drawing.Size(47, 28)
        Me.RadLabel_CathodeName.TabIndex = 95
        Me.RadLabel_CathodeName.Text = "Evaluation_cathodename"
        Me.RadLabel_CathodeName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_CathodeName.Visible = False
        '
        'RadTextBox_AnodePtNo
        '
        Me.RadTextBox_AnodePtNo.AutoSize = False
        Me.RadTextBox_AnodePtNo.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_AnodePtNo.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_AnodePtNo.Location = New System.Drawing.Point(417, 119)
        Me.RadTextBox_AnodePtNo.Name = "RadTextBox_AnodePtNo"
        Me.RadTextBox_AnodePtNo.Size = New System.Drawing.Size(47, 23)
        Me.RadTextBox_AnodePtNo.TabIndex = 96
        Me.RadTextBox_AnodePtNo.Text = "Unbound"
        Me.RadTextBox_AnodePtNo.Visible = False
        '
        'RadTextBox_CathodePtNo
        '
        Me.RadTextBox_CathodePtNo.AutoSize = False
        Me.RadTextBox_CathodePtNo.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_CathodePtNo.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_CathodePtNo.Location = New System.Drawing.Point(417, 181)
        Me.RadTextBox_CathodePtNo.Name = "RadTextBox_CathodePtNo"
        Me.RadTextBox_CathodePtNo.Size = New System.Drawing.Size(47, 23)
        Me.RadTextBox_CathodePtNo.TabIndex = 97
        Me.RadTextBox_CathodePtNo.Text = "Unbound"
        Me.RadTextBox_CathodePtNo.Visible = False
        '
        'RadTextBox_id
        '
        Me.RadTextBox_id.AutoSize = False
        Me.RadTextBox_id.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_id.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_id.Location = New System.Drawing.Point(417, 229)
        Me.RadTextBox_id.Name = "RadTextBox_id"
        Me.RadTextBox_id.Size = New System.Drawing.Size(46, 18)
        Me.RadTextBox_id.TabIndex = 99
        Me.RadTextBox_id.Text = "Unbound"
        Me.RadTextBox_id.Visible = False
        '
        'RadLabel_id
        '
        Me.RadLabel_id.AutoSize = False
        Me.RadLabel_id.BackColor = System.Drawing.Color.White
        Me.RadLabel_id.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadLabel_id.Location = New System.Drawing.Point(417, 214)
        Me.RadLabel_id.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_id.Name = "RadLabel_id"
        Me.RadLabel_id.Size = New System.Drawing.Size(43, 16)
        Me.RadLabel_id.TabIndex = 98
        Me.RadLabel_id.Text = "Evaluation_id"
        Me.RadLabel_id.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_id.Visible = False
        '
        'RadTextBox_user
        '
        Me.RadTextBox_user.AutoSize = False
        Me.RadTextBox_user.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_user.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_user.Location = New System.Drawing.Point(417, 274)
        Me.RadTextBox_user.Name = "RadTextBox_user"
        Me.RadTextBox_user.Size = New System.Drawing.Size(46, 18)
        Me.RadTextBox_user.TabIndex = 101
        Me.RadTextBox_user.Text = "Unbound"
        Me.RadTextBox_user.Visible = False
        '
        'RadLabel_user
        '
        Me.RadLabel_user.AutoSize = False
        Me.RadLabel_user.BackColor = System.Drawing.Color.White
        Me.RadLabel_user.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadLabel_user.Location = New System.Drawing.Point(417, 259)
        Me.RadLabel_user.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_user.Name = "RadLabel_user"
        Me.RadLabel_user.Size = New System.Drawing.Size(43, 16)
        Me.RadLabel_user.TabIndex = 100
        Me.RadLabel_user.Text = "Evaluation_id"
        Me.RadLabel_user.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_user.Visible = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.RadTextBox_BestESRfit)
        Me.Panel1.Controls.Add(Me.RadLabel_BestESRfit)
        Me.Panel1.Controls.Add(Me.RadTextBox_BestESResr)
        Me.Panel1.Controls.Add(Me.RadLabel_BestESResr)
        Me.Panel1.Controls.Add(Me.RadTextBox_BestESRsaltotalcost)
        Me.Panel1.Controls.Add(Me.RadLabel_BestESRsaltotalcost)
        Me.Panel1.Controls.Add(Me.RadTextBox_BestESRstdtotalcost)
        Me.Panel1.Controls.Add(Me.RadLabel_BestESRstdtotalcost)
        Me.Panel1.Controls.Add(Me.RadTextBox_BestESRCathodeName)
        Me.Panel1.Controls.Add(Me.RadLabel_BestESRCathodeName)
        Me.Panel1.Controls.Add(Me.RadTextBox_BestESRFirstAnodeName)
        Me.Panel1.Controls.Add(Me.RadLabel_BestESRFirstAnodeName)
        Me.Panel1.Controls.Add(Me.RadLabel_BestESRTitle)
        Me.Panel1.Location = New System.Drawing.Point(27, 342)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.MinimumSize = New System.Drawing.Size(340, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 76)
        Me.Panel1.TabIndex = 102
        '
        'RadTextBox_BestESRfit
        '
        Me.RadTextBox_BestESRfit.Enabled = False
        Me.RadTextBox_BestESRfit.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_BestESRfit.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_BestESRfit.Location = New System.Drawing.Point(161, 155)
        Me.RadTextBox_BestESRfit.Name = "RadTextBox_BestESRfit"
        Me.RadTextBox_BestESRfit.Size = New System.Drawing.Size(130, 20)
        Me.RadTextBox_BestESRfit.TabIndex = 103
        Me.RadTextBox_BestESRfit.Text = "Unbound"
        '
        'RadLabel_BestESRfit
        '
        Me.RadLabel_BestESRfit.AutoSize = False
        Me.RadLabel_BestESRfit.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_BestESRfit.Location = New System.Drawing.Point(17, 156)
        Me.RadLabel_BestESRfit.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_BestESRfit.Name = "RadLabel_BestESRfit"
        Me.RadLabel_BestESRfit.Size = New System.Drawing.Size(140, 18)
        Me.RadLabel_BestESRfit.TabIndex = 102
        Me.RadLabel_BestESRfit.Text = "Evaluation_fit"
        Me.RadLabel_BestESRfit.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_BestESResr
        '
        Me.RadTextBox_BestESResr.Enabled = False
        Me.RadTextBox_BestESResr.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_BestESResr.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_BestESResr.Location = New System.Drawing.Point(161, 131)
        Me.RadTextBox_BestESResr.Name = "RadTextBox_BestESResr"
        Me.RadTextBox_BestESResr.Size = New System.Drawing.Size(130, 20)
        Me.RadTextBox_BestESResr.TabIndex = 101
        Me.RadTextBox_BestESResr.Text = "Unbound"
        '
        'RadLabel_BestESResr
        '
        Me.RadLabel_BestESResr.AutoSize = False
        Me.RadLabel_BestESResr.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_BestESResr.Location = New System.Drawing.Point(17, 132)
        Me.RadLabel_BestESResr.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_BestESResr.Name = "RadLabel_BestESResr"
        Me.RadLabel_BestESResr.Size = New System.Drawing.Size(140, 18)
        Me.RadLabel_BestESResr.TabIndex = 100
        Me.RadLabel_BestESResr.Text = "Evaluation_esr"
        Me.RadLabel_BestESResr.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_BestESRsaltotalcost
        '
        Me.RadTextBox_BestESRsaltotalcost.Enabled = False
        Me.RadTextBox_BestESRsaltotalcost.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_BestESRsaltotalcost.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_BestESRsaltotalcost.Location = New System.Drawing.Point(161, 107)
        Me.RadTextBox_BestESRsaltotalcost.Name = "RadTextBox_BestESRsaltotalcost"
        Me.RadTextBox_BestESRsaltotalcost.Size = New System.Drawing.Size(130, 20)
        Me.RadTextBox_BestESRsaltotalcost.TabIndex = 99
        Me.RadTextBox_BestESRsaltotalcost.Text = "Unbound"
        '
        'RadLabel_BestESRsaltotalcost
        '
        Me.RadLabel_BestESRsaltotalcost.AutoSize = False
        Me.RadLabel_BestESRsaltotalcost.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_BestESRsaltotalcost.Location = New System.Drawing.Point(17, 108)
        Me.RadLabel_BestESRsaltotalcost.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_BestESRsaltotalcost.Name = "RadLabel_BestESRsaltotalcost"
        Me.RadLabel_BestESRsaltotalcost.Size = New System.Drawing.Size(140, 18)
        Me.RadLabel_BestESRsaltotalcost.TabIndex = 98
        Me.RadLabel_BestESRsaltotalcost.Text = "Evaluation_saltotalcost"
        Me.RadLabel_BestESRsaltotalcost.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_BestESRstdtotalcost
        '
        Me.RadTextBox_BestESRstdtotalcost.Enabled = False
        Me.RadTextBox_BestESRstdtotalcost.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_BestESRstdtotalcost.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_BestESRstdtotalcost.Location = New System.Drawing.Point(161, 83)
        Me.RadTextBox_BestESRstdtotalcost.Name = "RadTextBox_BestESRstdtotalcost"
        Me.RadTextBox_BestESRstdtotalcost.Size = New System.Drawing.Size(130, 20)
        Me.RadTextBox_BestESRstdtotalcost.TabIndex = 97
        Me.RadTextBox_BestESRstdtotalcost.Text = "Unbound"
        '
        'RadLabel_BestESRstdtotalcost
        '
        Me.RadLabel_BestESRstdtotalcost.AutoSize = False
        Me.RadLabel_BestESRstdtotalcost.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_BestESRstdtotalcost.Location = New System.Drawing.Point(17, 84)
        Me.RadLabel_BestESRstdtotalcost.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_BestESRstdtotalcost.Name = "RadLabel_BestESRstdtotalcost"
        Me.RadLabel_BestESRstdtotalcost.Size = New System.Drawing.Size(140, 18)
        Me.RadLabel_BestESRstdtotalcost.TabIndex = 96
        Me.RadLabel_BestESRstdtotalcost.Text = "Evaluation_stdtotalcost"
        Me.RadLabel_BestESRstdtotalcost.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_BestESRCathodeName
        '
        Me.RadTextBox_BestESRCathodeName.Enabled = False
        Me.RadTextBox_BestESRCathodeName.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_BestESRCathodeName.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_BestESRCathodeName.Location = New System.Drawing.Point(161, 59)
        Me.RadTextBox_BestESRCathodeName.Name = "RadTextBox_BestESRCathodeName"
        Me.RadTextBox_BestESRCathodeName.Size = New System.Drawing.Size(130, 20)
        Me.RadTextBox_BestESRCathodeName.TabIndex = 95
        Me.RadTextBox_BestESRCathodeName.Text = "Unbound"
        '
        'RadLabel_BestESRCathodeName
        '
        Me.RadLabel_BestESRCathodeName.AutoSize = False
        Me.RadLabel_BestESRCathodeName.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_BestESRCathodeName.Location = New System.Drawing.Point(17, 60)
        Me.RadLabel_BestESRCathodeName.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_BestESRCathodeName.Name = "RadLabel_BestESRCathodeName"
        Me.RadLabel_BestESRCathodeName.Size = New System.Drawing.Size(140, 18)
        Me.RadLabel_BestESRCathodeName.TabIndex = 94
        Me.RadLabel_BestESRCathodeName.Text = "Evaluation_BestCostCathodeName"
        Me.RadLabel_BestESRCathodeName.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_BestESRFirstAnodeName
        '
        Me.RadTextBox_BestESRFirstAnodeName.Enabled = False
        Me.RadTextBox_BestESRFirstAnodeName.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_BestESRFirstAnodeName.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_BestESRFirstAnodeName.Location = New System.Drawing.Point(161, 35)
        Me.RadTextBox_BestESRFirstAnodeName.Name = "RadTextBox_BestESRFirstAnodeName"
        Me.RadTextBox_BestESRFirstAnodeName.Size = New System.Drawing.Size(130, 20)
        Me.RadTextBox_BestESRFirstAnodeName.TabIndex = 93
        Me.RadTextBox_BestESRFirstAnodeName.Text = "Unbound"
        '
        'RadLabel_BestESRFirstAnodeName
        '
        Me.RadLabel_BestESRFirstAnodeName.AutoSize = False
        Me.RadLabel_BestESRFirstAnodeName.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_BestESRFirstAnodeName.Location = New System.Drawing.Point(17, 36)
        Me.RadLabel_BestESRFirstAnodeName.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_BestESRFirstAnodeName.Name = "RadLabel_BestESRFirstAnodeName"
        Me.RadLabel_BestESRFirstAnodeName.Size = New System.Drawing.Size(140, 18)
        Me.RadLabel_BestESRFirstAnodeName.TabIndex = 92
        Me.RadLabel_BestESRFirstAnodeName.Text = "Evaluation_FirstAnodeName"
        Me.RadLabel_BestESRFirstAnodeName.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_BestESRTitle
        '
        Me.RadLabel_BestESRTitle.AutoSize = False
        Me.RadLabel_BestESRTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_BestESRTitle.ForeColor = System.Drawing.Color.White
        Me.RadLabel_BestESRTitle.Location = New System.Drawing.Point(0, 6)
        Me.RadLabel_BestESRTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_BestESRTitle.Name = "RadLabel_BestESRTitle"
        Me.RadLabel_BestESRTitle.Size = New System.Drawing.Size(314, 25)
        Me.RadLabel_BestESRTitle.TabIndex = 30
        Me.RadLabel_BestESRTitle.Text = "Evaluation_BestESRTitle"
        Me.RadLabel_BestESRTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Evaluation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(472, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel_BestCost)
        Me.Controls.Add(Me.RadTextBox_user)
        Me.Controls.Add(Me.RadLabel_user)
        Me.Controls.Add(Me.RadTextBox_id)
        Me.Controls.Add(Me.RadLabel_id)
        Me.Controls.Add(Me.RadTextBox_CathodePtNo)
        Me.Controls.Add(Me.RadTextBox_AnodePtNo)
        Me.Controls.Add(Me.RadLabel_CathodeName)
        Me.Controls.Add(Me.RadLabel_AnodeName)
        Me.Controls.Add(Me.RadLabel_BestESR)
        Me.Controls.Add(Me.RadLabel_BestCost)
        Me.Controls.Add(Me.RadCheckBox_Cathodes)
        Me.Controls.Add(Me.RadCheckBox_Anodes)
        Me.Controls.Add(Me.Panel_CathType)
        Me.Controls.Add(Me.RadTextBox__CurrentEvaluationstored)
        Me.Controls.Add(Me.RadLabel_CurrentEvaluationstored)
        Me.Controls.Add(Me.RadButton_Evaluate)
        Me.Controls.Add(Me.RadTextBox_MaxCounter)
        Me.Controls.Add(Me.RadTextBox_Counter)
        Me.Controls.Add(Me.RadLabel_Counter)
        Me.Controls.Add(Me.RadTextBox_FormingVoltage)
        Me.Controls.Add(Me.RadTextBox_PartNumber)
        Me.Controls.Add(Me.RadLabel_FormingVoltage)
        Me.Controls.Add(Me.RadLabel_PartNumber)
        Me.Controls.Add(Me.RadLabel_of)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(480, 800)
        Me.MinimumSize = New System.Drawing.Size(480, 480)
        Me.Name = "Evaluation"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(480, 800)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Evaluation_Title"
        Me.ThemeName = "Windows8"
        CType(Me.RadLabel_PartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_FormingVoltage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_PartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_FormingVoltage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Counter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Counter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_MaxCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_of, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Evaluate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_CurrentEvaluationstored, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox__CurrentEvaluationstored, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton_NonSlotted, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_CathType.ResumeLayout(False)
        CType(Me.RadRadioButton_All, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton_Slotted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_Anodes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_Cathodes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_BestCost.ResumeLayout(False)
        Me.Panel_BestCost.PerformLayout()
        CType(Me.RadTextBox_fit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_fit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_esr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_esr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_saltotalcost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_saltotalcost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_stdtotalcost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_stdtotalcost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_BestCostCathodeName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_BestCostCathodeName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_FirstAnodeName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_FirstAnodeName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_BestCostTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_BestCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_BestESR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_AnodeName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_CathodeName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_AnodePtNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CathodePtNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.RadTextBox_BestESRfit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_BestESRfit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_BestESResr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_BestESResr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_BestESRsaltotalcost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_BestESRsaltotalcost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_BestESRstdtotalcost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_BestESRstdtotalcost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_BestESRCathodeName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_BestESRCathodeName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_BestESRFirstAnodeName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_BestESRFirstAnodeName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_BestESRTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadLabel_PartNumber As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_FormingVoltage As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_PartNumber As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_FormingVoltage As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Counter As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Counter As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_MaxCounter As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_of As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton_Evaluate As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel_CurrentEvaluationstored As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox__CurrentEvaluationstored As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadRadioButton_NonSlotted As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents Panel_CathType As System.Windows.Forms.Panel
    Friend WithEvents RadCheckBox_Anodes As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_Cathodes As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadRadioButton_All As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadRadioButton_Slotted As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadLabel_BestCost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_BestESR As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel_BestCost As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_AnodeName As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_CathodeName As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_AnodePtNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_CathodePtNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_id As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_id As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_user As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_user As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_BestCostTitle As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_fit As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_fit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_esr As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_esr As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_saltotalcost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_saltotalcost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_stdtotalcost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_stdtotalcost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_BestCostCathodeName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_BestCostCathodeName As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_FirstAnodeName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_FirstAnodeName As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RadTextBox_BestESRfit As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_BestESRfit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_BestESResr As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_BestESResr As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_BestESRsaltotalcost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_BestESRsaltotalcost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_BestESRstdtotalcost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_BestESRstdtotalcost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_BestESRCathodeName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_BestESRCathodeName As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_BestESRFirstAnodeName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_BestESRFirstAnodeName As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_BestESRTitle As Telerik.WinControls.UI.RadLabel
End Class

