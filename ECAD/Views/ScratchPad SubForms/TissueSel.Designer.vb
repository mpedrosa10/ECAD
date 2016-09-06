<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TissueSel
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TissueSel))
        Me.RadButton_UpdateScratch = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Search = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_RebuildTable = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox_TissuesNumber = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadRadioButton_All = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadRadioButton_3 = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadRadioButton_2 = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadRadioButton_1 = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadGroupBox_Sort = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadRadioButton_Surge = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadRadioButton_ESR = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadRadioButton_Cost = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadRadioButton_Cap = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadTextBox_WorkingVoltage = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_WorkingVoltage = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Temp = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Temp = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Diam = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Diam = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Length = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Length = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Elec = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Elec = New Telerik.WinControls.UI.RadLabel()
        Me.RadGridView_Results = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabel_Results = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadButton_UpdateScratch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_RebuildTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox_TissuesNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox_TissuesNumber.SuspendLayout()
        CType(Me.RadRadioButton_All, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox_Sort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox_Sort.SuspendLayout()
        CType(Me.RadRadioButton_Surge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton_ESR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton_Cost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton_Cap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_WorkingVoltage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_WorkingVoltage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Temp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Temp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Diam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Diam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Length, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Length, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Elec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Elec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_Results, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_Results.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Results, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadButton_UpdateScratch
        '
        Me.RadButton_UpdateScratch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_UpdateScratch.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadButton_UpdateScratch.ForeColor = System.Drawing.Color.Black
        Me.RadButton_UpdateScratch.Location = New System.Drawing.Point(502, 20)
        Me.RadButton_UpdateScratch.Name = "RadButton_UpdateScratch"
        Me.RadButton_UpdateScratch.Size = New System.Drawing.Size(77, 39)
        Me.RadButton_UpdateScratch.TabIndex = 36
        Me.RadButton_UpdateScratch.Text = "TissueSel_UpdateScratch"
        Me.RadButton_UpdateScratch.TextWrap = True
        '
        'RadButton_Search
        '
        Me.RadButton_Search.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_Search.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadButton_Search.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Search.Location = New System.Drawing.Point(502, 65)
        Me.RadButton_Search.Name = "RadButton_Search"
        Me.RadButton_Search.Size = New System.Drawing.Size(77, 31)
        Me.RadButton_Search.TabIndex = 37
        Me.RadButton_Search.Text = "Global_Search"
        Me.RadButton_Search.TextWrap = True
        '
        'RadButton_RebuildTable
        '
        Me.RadButton_RebuildTable.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_RebuildTable.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadButton_RebuildTable.ForeColor = System.Drawing.Color.Black
        Me.RadButton_RebuildTable.Location = New System.Drawing.Point(502, 102)
        Me.RadButton_RebuildTable.Name = "RadButton_RebuildTable"
        Me.RadButton_RebuildTable.Size = New System.Drawing.Size(77, 35)
        Me.RadButton_RebuildTable.TabIndex = 38
        Me.RadButton_RebuildTable.Text = "TissueSel_RebuildTable"
        Me.RadButton_RebuildTable.TextWrap = True
        '
        'RadGroupBox_TissuesNumber
        '
        Me.RadGroupBox_TissuesNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox_TissuesNumber.Controls.Add(Me.RadRadioButton_All)
        Me.RadGroupBox_TissuesNumber.Controls.Add(Me.RadRadioButton_3)
        Me.RadGroupBox_TissuesNumber.Controls.Add(Me.RadRadioButton_2)
        Me.RadGroupBox_TissuesNumber.Controls.Add(Me.RadRadioButton_1)
        Me.RadGroupBox_TissuesNumber.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadGroupBox_TissuesNumber.HeaderText = "TissueSel_NumberofTissues"
        Me.RadGroupBox_TissuesNumber.Location = New System.Drawing.Point(385, 22)
        Me.RadGroupBox_TissuesNumber.Name = "RadGroupBox_TissuesNumber"
        Me.RadGroupBox_TissuesNumber.Size = New System.Drawing.Size(110, 115)
        Me.RadGroupBox_TissuesNumber.TabIndex = 40
        Me.RadGroupBox_TissuesNumber.Text = "TissueSel_NumberofTissues"
        '
        'RadRadioButton_All
        '
        Me.RadRadioButton_All.AutoSize = False
        Me.RadRadioButton_All.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadRadioButton_All.Location = New System.Drawing.Point(13, 86)
        Me.RadRadioButton_All.Name = "RadRadioButton_All"
        Me.RadRadioButton_All.Size = New System.Drawing.Size(70, 18)
        Me.RadRadioButton_All.TabIndex = 44
        Me.RadRadioButton_All.Text = "Global_All"
        '
        'RadRadioButton_3
        '
        Me.RadRadioButton_3.AutoSize = False
        Me.RadRadioButton_3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadRadioButton_3.Location = New System.Drawing.Point(13, 65)
        Me.RadRadioButton_3.Name = "RadRadioButton_3"
        Me.RadRadioButton_3.Size = New System.Drawing.Size(70, 18)
        Me.RadRadioButton_3.TabIndex = 43
        Me.RadRadioButton_3.Text = "Global_3"
        '
        'RadRadioButton_2
        '
        Me.RadRadioButton_2.AutoSize = False
        Me.RadRadioButton_2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadRadioButton_2.Location = New System.Drawing.Point(13, 44)
        Me.RadRadioButton_2.Name = "RadRadioButton_2"
        Me.RadRadioButton_2.Size = New System.Drawing.Size(70, 18)
        Me.RadRadioButton_2.TabIndex = 42
        Me.RadRadioButton_2.Text = "Global_2"
        '
        'RadRadioButton_1
        '
        Me.RadRadioButton_1.AutoSize = False
        Me.RadRadioButton_1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadRadioButton_1.Location = New System.Drawing.Point(13, 23)
        Me.RadRadioButton_1.Name = "RadRadioButton_1"
        Me.RadRadioButton_1.Size = New System.Drawing.Size(70, 18)
        Me.RadRadioButton_1.TabIndex = 41
        Me.RadRadioButton_1.Text = "Global_1"
        '
        'RadGroupBox_Sort
        '
        Me.RadGroupBox_Sort.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox_Sort.Controls.Add(Me.RadRadioButton_Surge)
        Me.RadGroupBox_Sort.Controls.Add(Me.RadRadioButton_ESR)
        Me.RadGroupBox_Sort.Controls.Add(Me.RadRadioButton_Cost)
        Me.RadGroupBox_Sort.Controls.Add(Me.RadRadioButton_Cap)
        Me.RadGroupBox_Sort.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadGroupBox_Sort.HeaderText = "TissueSel_Sortforbest"
        Me.RadGroupBox_Sort.Location = New System.Drawing.Point(5, 77)
        Me.RadGroupBox_Sort.Name = "RadGroupBox_Sort"
        Me.RadGroupBox_Sort.Size = New System.Drawing.Size(374, 60)
        Me.RadGroupBox_Sort.TabIndex = 41
        Me.RadGroupBox_Sort.Text = "TissueSel_Sortforbest"
        '
        'RadRadioButton_Surge
        '
        Me.RadRadioButton_Surge.AutoSize = False
        Me.RadRadioButton_Surge.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadRadioButton_Surge.Location = New System.Drawing.Point(246, 27)
        Me.RadRadioButton_Surge.Name = "RadRadioButton_Surge"
        Me.RadRadioButton_Surge.Size = New System.Drawing.Size(70, 18)
        Me.RadRadioButton_Surge.TabIndex = 40
        Me.RadRadioButton_Surge.Text = "Global_Surge"
        '
        'RadRadioButton_ESR
        '
        Me.RadRadioButton_ESR.AutoSize = False
        Me.RadRadioButton_ESR.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadRadioButton_ESR.Location = New System.Drawing.Point(168, 27)
        Me.RadRadioButton_ESR.Name = "RadRadioButton_ESR"
        Me.RadRadioButton_ESR.Size = New System.Drawing.Size(70, 18)
        Me.RadRadioButton_ESR.TabIndex = 40
        Me.RadRadioButton_ESR.Text = "Global_ESR"
        '
        'RadRadioButton_Cost
        '
        Me.RadRadioButton_Cost.AutoSize = False
        Me.RadRadioButton_Cost.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadRadioButton_Cost.Location = New System.Drawing.Point(90, 27)
        Me.RadRadioButton_Cost.Name = "RadRadioButton_Cost"
        Me.RadRadioButton_Cost.Size = New System.Drawing.Size(70, 18)
        Me.RadRadioButton_Cost.TabIndex = 40
        Me.RadRadioButton_Cost.Text = "Global_Cost"
        '
        'RadRadioButton_Cap
        '
        Me.RadRadioButton_Cap.AutoSize = False
        Me.RadRadioButton_Cap.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadRadioButton_Cap.Location = New System.Drawing.Point(12, 27)
        Me.RadRadioButton_Cap.Name = "RadRadioButton_Cap"
        Me.RadRadioButton_Cap.Size = New System.Drawing.Size(70, 18)
        Me.RadRadioButton_Cap.TabIndex = 39
        Me.RadRadioButton_Cap.Text = "Global_Cap"
        '
        'RadTextBox_WorkingVoltage
        '
        Me.RadTextBox_WorkingVoltage.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_WorkingVoltage.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_WorkingVoltage.Location = New System.Drawing.Point(5, 44)
        Me.RadTextBox_WorkingVoltage.Name = "RadTextBox_WorkingVoltage"
        Me.RadTextBox_WorkingVoltage.Size = New System.Drawing.Size(70, 27)
        Me.RadTextBox_WorkingVoltage.TabIndex = 95
        Me.RadTextBox_WorkingVoltage.Text = "Unbound"
        '
        'RadLabel_WorkingVoltage
        '
        Me.RadLabel_WorkingVoltage.AutoSize = False
        Me.RadLabel_WorkingVoltage.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_WorkingVoltage.Location = New System.Drawing.Point(5, 2)
        Me.RadLabel_WorkingVoltage.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_WorkingVoltage.Name = "RadLabel_WorkingVoltage"
        Me.RadLabel_WorkingVoltage.Size = New System.Drawing.Size(70, 40)
        Me.RadLabel_WorkingVoltage.TabIndex = 94
        Me.RadLabel_WorkingVoltage.Text = "Global_WorkingVoltage"
        Me.RadLabel_WorkingVoltage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadTextBox_Temp
        '
        Me.RadTextBox_Temp.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_Temp.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Temp.Location = New System.Drawing.Point(81, 44)
        Me.RadTextBox_Temp.Name = "RadTextBox_Temp"
        Me.RadTextBox_Temp.Size = New System.Drawing.Size(70, 27)
        Me.RadTextBox_Temp.TabIndex = 97
        Me.RadTextBox_Temp.Text = "Unbound"
        '
        'RadLabel_Temp
        '
        Me.RadLabel_Temp.AutoSize = False
        Me.RadLabel_Temp.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Temp.Location = New System.Drawing.Point(81, 2)
        Me.RadLabel_Temp.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Temp.Name = "RadLabel_Temp"
        Me.RadLabel_Temp.Size = New System.Drawing.Size(70, 40)
        Me.RadLabel_Temp.TabIndex = 96
        Me.RadLabel_Temp.Text = "TissueSel_Temp"
        Me.RadLabel_Temp.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadTextBox_Diam
        '
        Me.RadTextBox_Diam.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_Diam.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Diam.Location = New System.Drawing.Point(157, 44)
        Me.RadTextBox_Diam.Name = "RadTextBox_Diam"
        Me.RadTextBox_Diam.Size = New System.Drawing.Size(70, 27)
        Me.RadTextBox_Diam.TabIndex = 99
        Me.RadTextBox_Diam.Text = "Unbound"
        '
        'RadLabel_Diam
        '
        Me.RadLabel_Diam.AutoSize = False
        Me.RadLabel_Diam.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Diam.Location = New System.Drawing.Point(157, 2)
        Me.RadLabel_Diam.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Diam.Name = "RadLabel_Diam"
        Me.RadLabel_Diam.Size = New System.Drawing.Size(70, 40)
        Me.RadLabel_Diam.TabIndex = 98
        Me.RadLabel_Diam.Text = "TissueSel_Diam"
        Me.RadLabel_Diam.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadTextBox_Length
        '
        Me.RadTextBox_Length.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_Length.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Length.Location = New System.Drawing.Point(233, 44)
        Me.RadTextBox_Length.Name = "RadTextBox_Length"
        Me.RadTextBox_Length.Size = New System.Drawing.Size(70, 27)
        Me.RadTextBox_Length.TabIndex = 97
        Me.RadTextBox_Length.Text = "Unbound"
        '
        'RadLabel_Length
        '
        Me.RadLabel_Length.AutoSize = False
        Me.RadLabel_Length.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Length.Location = New System.Drawing.Point(233, 2)
        Me.RadLabel_Length.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Length.Name = "RadLabel_Length"
        Me.RadLabel_Length.Size = New System.Drawing.Size(70, 40)
        Me.RadLabel_Length.TabIndex = 96
        Me.RadLabel_Length.Text = "Global_Length"
        Me.RadLabel_Length.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadTextBox_Elec
        '
        Me.RadTextBox_Elec.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_Elec.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Elec.Location = New System.Drawing.Point(309, 44)
        Me.RadTextBox_Elec.Name = "RadTextBox_Elec"
        Me.RadTextBox_Elec.Size = New System.Drawing.Size(70, 27)
        Me.RadTextBox_Elec.TabIndex = 97
        Me.RadTextBox_Elec.Text = "Unbound"
        '
        'RadLabel_Elec
        '
        Me.RadLabel_Elec.AutoSize = False
        Me.RadLabel_Elec.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Elec.Location = New System.Drawing.Point(309, 2)
        Me.RadLabel_Elec.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Elec.Name = "RadLabel_Elec"
        Me.RadLabel_Elec.Size = New System.Drawing.Size(70, 40)
        Me.RadLabel_Elec.TabIndex = 96
        Me.RadLabel_Elec.Text = "TissueSel_Elec"
        Me.RadLabel_Elec.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadGridView_Results
        '
        Me.RadGridView_Results.Location = New System.Drawing.Point(5, 152)
        '
        '
        '
        Me.RadGridView_Results.MasterTemplate.AllowDragToGroup = False
        Me.RadGridView_Results.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.RadGridView_Results.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView_Results.Name = "RadGridView_Results"
        Me.RadGridView_Results.ShowGroupPanel = False
        Me.RadGridView_Results.Size = New System.Drawing.Size(574, 177)
        Me.RadGridView_Results.TabIndex = 103
        Me.RadGridView_Results.Visible = False
        '
        'RadLabel_Results
        '
        Me.RadLabel_Results.AutoSize = False
        Me.RadLabel_Results.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadLabel_Results.Location = New System.Drawing.Point(5, 140)
        Me.RadLabel_Results.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Results.Name = "RadLabel_Results"
        Me.RadLabel_Results.Size = New System.Drawing.Size(200, 15)
        Me.RadLabel_Results.TabIndex = 104
        Me.RadLabel_Results.Text = "Global_Results"
        Me.RadLabel_Results.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Results.Visible = False
        '
        'TissueSel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 333)
        Me.Controls.Add(Me.RadGridView_Results)
        Me.Controls.Add(Me.RadLabel_Results)
        Me.Controls.Add(Me.RadTextBox_Elec)
        Me.Controls.Add(Me.RadLabel_Elec)
        Me.Controls.Add(Me.RadTextBox_Length)
        Me.Controls.Add(Me.RadLabel_Length)
        Me.Controls.Add(Me.RadTextBox_Diam)
        Me.Controls.Add(Me.RadLabel_Diam)
        Me.Controls.Add(Me.RadTextBox_Temp)
        Me.Controls.Add(Me.RadLabel_Temp)
        Me.Controls.Add(Me.RadTextBox_WorkingVoltage)
        Me.Controls.Add(Me.RadLabel_WorkingVoltage)
        Me.Controls.Add(Me.RadGroupBox_Sort)
        Me.Controls.Add(Me.RadGroupBox_TissuesNumber)
        Me.Controls.Add(Me.RadButton_RebuildTable)
        Me.Controls.Add(Me.RadButton_Search)
        Me.Controls.Add(Me.RadButton_UpdateScratch)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TissueSel"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TissueSel_Title"
        Me.ThemeName = "Windows8"
        CType(Me.RadButton_UpdateScratch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_RebuildTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox_TissuesNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox_TissuesNumber.ResumeLayout(False)
        CType(Me.RadRadioButton_All, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox_Sort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox_Sort.ResumeLayout(False)
        CType(Me.RadRadioButton_Surge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton_ESR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton_Cost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton_Cap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_WorkingVoltage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_WorkingVoltage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Temp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Temp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Diam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Diam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Length, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Length, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Elec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Elec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_Results.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_Results, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Results, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadButton_UpdateScratch As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Search As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_RebuildTable As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox_TissuesNumber As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox_Sort As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadRadioButton_All As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadRadioButton_3 As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadRadioButton_2 As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadRadioButton_1 As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadRadioButton_Surge As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadRadioButton_ESR As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadRadioButton_Cost As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadRadioButton_Cap As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadTextBox_WorkingVoltage As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_WorkingVoltage As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Temp As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Temp As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Diam As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Diam As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Length As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Length As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Elec As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Elec As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGridView_Results As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel_Results As Telerik.WinControls.UI.RadLabel
End Class

