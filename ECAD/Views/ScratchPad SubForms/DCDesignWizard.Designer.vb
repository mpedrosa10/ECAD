<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DCDesignWizard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DCDesignWizard))
        Me.RadButton_Submit = New Telerik.WinControls.UI.RadButton()
        Me.RadDropDownList_Range = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_Range = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Capacitance = New Telerik.WinControls.UI.RadTextBox()
        Me.RadDropDownList_Can = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_Can = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_Voltage = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_Voltage = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Capacitance = New Telerik.WinControls.UI.RadLabel()
        Me.RadGridView_OutlineMaxCap = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabel_Outline = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_MaxCap = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_OutlineComboSql = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadButton_Submit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_Range, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Range, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Capacitance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_Can, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Can, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_Voltage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Voltage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Capacitance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_OutlineMaxCap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_OutlineMaxCap.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Outline, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_MaxCap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_OutlineComboSql, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadButton_Submit
        '
        Me.RadButton_Submit.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_Submit.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadButton_Submit.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Submit.Location = New System.Drawing.Point(9, 247)
        Me.RadButton_Submit.Name = "RadButton_Submit"
        Me.RadButton_Submit.Size = New System.Drawing.Size(120, 25)
        Me.RadButton_Submit.TabIndex = 38
        Me.RadButton_Submit.Text = "Global_Submit"
        Me.RadButton_Submit.TextWrap = True
        '
        'RadDropDownList_Range
        '
        Me.RadDropDownList_Range.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Range.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Range.Location = New System.Drawing.Point(9, 36)
        Me.RadDropDownList_Range.Name = "RadDropDownList_Range"
        Me.RadDropDownList_Range.Size = New System.Drawing.Size(120, 27)
        Me.RadDropDownList_Range.TabIndex = 45
        Me.RadDropDownList_Range.Text = "Unbound"
        '
        'RadLabel_Range
        '
        Me.RadLabel_Range.AutoSize = False
        Me.RadLabel_Range.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Range.Location = New System.Drawing.Point(9, 9)
        Me.RadLabel_Range.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Range.Name = "RadLabel_Range"
        Me.RadLabel_Range.Size = New System.Drawing.Size(120, 27)
        Me.RadLabel_Range.TabIndex = 46
        Me.RadLabel_Range.Text = "Global_Range"
        Me.RadLabel_Range.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadTextBox_Capacitance
        '
        Me.RadTextBox_Capacitance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_Capacitance.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Capacitance.Location = New System.Drawing.Point(9, 208)
        Me.RadTextBox_Capacitance.Name = "RadTextBox_Capacitance"
        Me.RadTextBox_Capacitance.Size = New System.Drawing.Size(120, 27)
        Me.RadTextBox_Capacitance.TabIndex = 98
        Me.RadTextBox_Capacitance.Text = "Unbound"
        '
        'RadDropDownList_Can
        '
        Me.RadDropDownList_Can.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Can.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Can.Location = New System.Drawing.Point(9, 93)
        Me.RadDropDownList_Can.Name = "RadDropDownList_Can"
        Me.RadDropDownList_Can.Size = New System.Drawing.Size(120, 27)
        Me.RadDropDownList_Can.TabIndex = 99
        Me.RadDropDownList_Can.Text = "Unbound"
        '
        'RadLabel_Can
        '
        Me.RadLabel_Can.AutoSize = False
        Me.RadLabel_Can.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Can.Location = New System.Drawing.Point(9, 66)
        Me.RadLabel_Can.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Can.Name = "RadLabel_Can"
        Me.RadLabel_Can.Size = New System.Drawing.Size(120, 27)
        Me.RadLabel_Can.TabIndex = 100
        Me.RadLabel_Can.Text = "Global_Can"
        Me.RadLabel_Can.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadDropDownList_Voltage
        '
        Me.RadDropDownList_Voltage.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Voltage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Voltage.Location = New System.Drawing.Point(9, 150)
        Me.RadDropDownList_Voltage.Name = "RadDropDownList_Voltage"
        Me.RadDropDownList_Voltage.Size = New System.Drawing.Size(120, 27)
        Me.RadDropDownList_Voltage.TabIndex = 101
        Me.RadDropDownList_Voltage.Text = "Unbound"
        '
        'RadLabel_Voltage
        '
        Me.RadLabel_Voltage.AutoSize = False
        Me.RadLabel_Voltage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Voltage.Location = New System.Drawing.Point(9, 123)
        Me.RadLabel_Voltage.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Voltage.Name = "RadLabel_Voltage"
        Me.RadLabel_Voltage.Size = New System.Drawing.Size(120, 27)
        Me.RadLabel_Voltage.TabIndex = 102
        Me.RadLabel_Voltage.Text = "Global_Voltage"
        Me.RadLabel_Voltage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadLabel_Capacitance
        '
        Me.RadLabel_Capacitance.AutoSize = False
        Me.RadLabel_Capacitance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Capacitance.Location = New System.Drawing.Point(9, 180)
        Me.RadLabel_Capacitance.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Capacitance.Name = "RadLabel_Capacitance"
        Me.RadLabel_Capacitance.Size = New System.Drawing.Size(120, 27)
        Me.RadLabel_Capacitance.TabIndex = 103
        Me.RadLabel_Capacitance.Text = "Global_Capacitance"
        Me.RadLabel_Capacitance.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadGridView_OutlineMaxCap
        '
        Me.RadGridView_OutlineMaxCap.Location = New System.Drawing.Point(150, 36)
        '
        '
        '
        Me.RadGridView_OutlineMaxCap.MasterTemplate.AllowDragToGroup = False
        Me.RadGridView_OutlineMaxCap.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.RadGridView_OutlineMaxCap.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView_OutlineMaxCap.Name = "RadGridView_OutlineMaxCap"
        Me.RadGridView_OutlineMaxCap.ShowGroupPanel = False
        Me.RadGridView_OutlineMaxCap.Size = New System.Drawing.Size(340, 151)
        Me.RadGridView_OutlineMaxCap.TabIndex = 104
        '
        'RadLabel_Outline
        '
        Me.RadLabel_Outline.AutoSize = False
        Me.RadLabel_Outline.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Outline.Location = New System.Drawing.Point(150, 8)
        Me.RadLabel_Outline.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Outline.Name = "RadLabel_Outline"
        Me.RadLabel_Outline.Size = New System.Drawing.Size(165, 27)
        Me.RadLabel_Outline.TabIndex = 105
        Me.RadLabel_Outline.Text = "Global_Outline"
        Me.RadLabel_Outline.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_MaxCap
        '
        Me.RadLabel_MaxCap.AutoSize = False
        Me.RadLabel_MaxCap.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_MaxCap.Location = New System.Drawing.Point(315, 9)
        Me.RadLabel_MaxCap.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_MaxCap.Name = "RadLabel_MaxCap"
        Me.RadLabel_MaxCap.Size = New System.Drawing.Size(175, 27)
        Me.RadLabel_MaxCap.TabIndex = 106
        Me.RadLabel_MaxCap.Text = "Global_MaxCap"
        Me.RadLabel_MaxCap.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_OutlineComboSql
        '
        Me.RadLabel_OutlineComboSql.AutoSize = False
        Me.RadLabel_OutlineComboSql.BackColor = System.Drawing.Color.White
        Me.RadLabel_OutlineComboSql.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadLabel_OutlineComboSql.Location = New System.Drawing.Point(150, 197)
        Me.RadLabel_OutlineComboSql.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_OutlineComboSql.Name = "RadLabel_OutlineComboSql"
        Me.RadLabel_OutlineComboSql.Size = New System.Drawing.Size(340, 55)
        Me.RadLabel_OutlineComboSql.TabIndex = 107
        Me.RadLabel_OutlineComboSql.Text = resources.GetString("RadLabel_OutlineComboSql.Text")
        Me.RadLabel_OutlineComboSql.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_OutlineComboSql.Visible = False
        '
        'DCDesignWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(510, 282)
        Me.Controls.Add(Me.RadLabel_OutlineComboSql)
        Me.Controls.Add(Me.RadLabel_MaxCap)
        Me.Controls.Add(Me.RadLabel_Outline)
        Me.Controls.Add(Me.RadGridView_OutlineMaxCap)
        Me.Controls.Add(Me.RadLabel_Capacitance)
        Me.Controls.Add(Me.RadDropDownList_Voltage)
        Me.Controls.Add(Me.RadLabel_Voltage)
        Me.Controls.Add(Me.RadDropDownList_Can)
        Me.Controls.Add(Me.RadLabel_Can)
        Me.Controls.Add(Me.RadDropDownList_Range)
        Me.Controls.Add(Me.RadTextBox_Capacitance)
        Me.Controls.Add(Me.RadLabel_Range)
        Me.Controls.Add(Me.RadButton_Submit)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DCDesignWizard"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DCWizard_Title"
        Me.ThemeName = "Windows8"
        CType(Me.RadButton_Submit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_Range, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Range, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Capacitance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_Can, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Can, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_Voltage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Voltage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Capacitance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_OutlineMaxCap.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_OutlineMaxCap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Outline, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_MaxCap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_OutlineComboSql, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadButton_Submit As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadDropDownList_Range As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_Range As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Capacitance As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadDropDownList_Can As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_Can As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Capacitance As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_Voltage As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_Voltage As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGridView_OutlineMaxCap As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel_Outline As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_MaxCap As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_OutlineComboSql As Telerik.WinControls.UI.RadLabel
End Class

