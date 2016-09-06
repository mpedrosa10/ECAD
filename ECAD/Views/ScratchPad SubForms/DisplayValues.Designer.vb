<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplayValues
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DisplayValues))
        Me.TabControl_PrintCatExtra = New System.Windows.Forms.TabControl()
        Me.TabPage_RelativeCost = New System.Windows.Forms.TabPage()
        Me.RadButton_ResetData = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel_RelativeCost = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_RelativeCost = New Telerik.WinControls.UI.RadTextBox()
        Me.TabPage_ActualValues = New System.Windows.Forms.TabPage()
        Me.RadTextBox_StdCostWas = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_StdCostNow = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_VarCostWas = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_VarCostNow = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_VarCost = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_StdCost = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Now = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Was = New Telerik.WinControls.UI.RadLabel()
        Me.TabControl_PrintCatExtra.SuspendLayout()
        Me.TabPage_RelativeCost.SuspendLayout()
        CType(Me.RadButton_ResetData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_RelativeCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_RelativeCost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_ActualValues.SuspendLayout()
        CType(Me.RadTextBox_StdCostWas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_StdCostNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_VarCostWas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_VarCostNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_VarCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_StdCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Now, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Was, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl_PrintCatExtra
        '
        Me.TabControl_PrintCatExtra.Controls.Add(Me.TabPage_RelativeCost)
        Me.TabControl_PrintCatExtra.Controls.Add(Me.TabPage_ActualValues)
        Me.TabControl_PrintCatExtra.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TabControl_PrintCatExtra.ItemSize = New System.Drawing.Size(120, 27)
        Me.TabControl_PrintCatExtra.Location = New System.Drawing.Point(6, 6)
        Me.TabControl_PrintCatExtra.Name = "TabControl_PrintCatExtra"
        Me.TabControl_PrintCatExtra.SelectedIndex = 0
        Me.TabControl_PrintCatExtra.Size = New System.Drawing.Size(280, 130)
        Me.TabControl_PrintCatExtra.TabIndex = 20
        '
        'TabPage_RelativeCost
        '
        Me.TabPage_RelativeCost.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage_RelativeCost.Controls.Add(Me.RadButton_ResetData)
        Me.TabPage_RelativeCost.Controls.Add(Me.RadLabel_RelativeCost)
        Me.TabPage_RelativeCost.Controls.Add(Me.RadTextBox_RelativeCost)
        Me.TabPage_RelativeCost.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TabPage_RelativeCost.Location = New System.Drawing.Point(4, 31)
        Me.TabPage_RelativeCost.Name = "TabPage_RelativeCost"
        Me.TabPage_RelativeCost.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_RelativeCost.Size = New System.Drawing.Size(272, 95)
        Me.TabPage_RelativeCost.TabIndex = 0
        Me.TabPage_RelativeCost.Text = "DisplayValues_RelativeCost"
        '
        'RadButton_ResetData
        '
        Me.RadButton_ResetData.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_ResetData.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_ResetData.ForeColor = System.Drawing.Color.Black
        Me.RadButton_ResetData.Location = New System.Drawing.Point(194, 13)
        Me.RadButton_ResetData.Name = "RadButton_ResetData"
        Me.RadButton_ResetData.Size = New System.Drawing.Size(72, 66)
        Me.RadButton_ResetData.TabIndex = 34
        Me.RadButton_ResetData.Text = "DisplayValues_ResetData"
        Me.RadButton_ResetData.TextWrap = True
        '
        'RadLabel_RelativeCost
        '
        Me.RadLabel_RelativeCost.AutoSize = False
        Me.RadLabel_RelativeCost.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_RelativeCost.Location = New System.Drawing.Point(10, 13)
        Me.RadLabel_RelativeCost.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_RelativeCost.Name = "RadLabel_RelativeCost"
        Me.RadLabel_RelativeCost.Size = New System.Drawing.Size(180, 16)
        Me.RadLabel_RelativeCost.TabIndex = 33
        Me.RadLabel_RelativeCost.Text = "DisplayValues_RelativeCost"
        Me.RadLabel_RelativeCost.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadTextBox_RelativeCost
        '
        Me.RadTextBox_RelativeCost.AutoSize = False
        Me.RadTextBox_RelativeCost.BackColor = System.Drawing.Color.White
        Me.RadTextBox_RelativeCost.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_RelativeCost.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_RelativeCost.Location = New System.Drawing.Point(10, 31)
        Me.RadTextBox_RelativeCost.Name = "RadTextBox_RelativeCost"
        Me.RadTextBox_RelativeCost.Size = New System.Drawing.Size(180, 48)
        Me.RadTextBox_RelativeCost.TabIndex = 32
        Me.RadTextBox_RelativeCost.Text = "Unbound"
        Me.RadTextBox_RelativeCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage_ActualValues
        '
        Me.TabPage_ActualValues.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage_ActualValues.Controls.Add(Me.RadTextBox_StdCostWas)
        Me.TabPage_ActualValues.Controls.Add(Me.RadTextBox_StdCostNow)
        Me.TabPage_ActualValues.Controls.Add(Me.RadTextBox_VarCostWas)
        Me.TabPage_ActualValues.Controls.Add(Me.RadTextBox_VarCostNow)
        Me.TabPage_ActualValues.Controls.Add(Me.RadLabel_VarCost)
        Me.TabPage_ActualValues.Controls.Add(Me.RadLabel_StdCost)
        Me.TabPage_ActualValues.Controls.Add(Me.RadLabel_Now)
        Me.TabPage_ActualValues.Controls.Add(Me.RadLabel_Was)
        Me.TabPage_ActualValues.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TabPage_ActualValues.Location = New System.Drawing.Point(4, 31)
        Me.TabPage_ActualValues.Name = "TabPage_ActualValues"
        Me.TabPage_ActualValues.Size = New System.Drawing.Size(272, 95)
        Me.TabPage_ActualValues.TabIndex = 1
        Me.TabPage_ActualValues.Text = "DisplayValues_ActualValues"
        '
        'RadTextBox_StdCostWas
        '
        Me.RadTextBox_StdCostWas.AutoSize = False
        Me.RadTextBox_StdCostWas.BackColor = System.Drawing.Color.White
        Me.RadTextBox_StdCostWas.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadTextBox_StdCostWas.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_StdCostWas.Location = New System.Drawing.Point(90, 32)
        Me.RadTextBox_StdCostWas.Name = "RadTextBox_StdCostWas"
        Me.RadTextBox_StdCostWas.Size = New System.Drawing.Size(82, 25)
        Me.RadTextBox_StdCostWas.TabIndex = 97
        Me.RadTextBox_StdCostWas.Text = "Unbound"
        Me.RadTextBox_StdCostWas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_StdCostNow
        '
        Me.RadTextBox_StdCostNow.AutoSize = False
        Me.RadTextBox_StdCostNow.BackColor = System.Drawing.Color.White
        Me.RadTextBox_StdCostNow.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadTextBox_StdCostNow.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_StdCostNow.Location = New System.Drawing.Point(180, 32)
        Me.RadTextBox_StdCostNow.Name = "RadTextBox_StdCostNow"
        Me.RadTextBox_StdCostNow.Size = New System.Drawing.Size(82, 25)
        Me.RadTextBox_StdCostNow.TabIndex = 96
        Me.RadTextBox_StdCostNow.Text = "Unbound"
        Me.RadTextBox_StdCostNow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_VarCostWas
        '
        Me.RadTextBox_VarCostWas.AutoSize = False
        Me.RadTextBox_VarCostWas.BackColor = System.Drawing.Color.White
        Me.RadTextBox_VarCostWas.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadTextBox_VarCostWas.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_VarCostWas.Location = New System.Drawing.Point(90, 62)
        Me.RadTextBox_VarCostWas.Name = "RadTextBox_VarCostWas"
        Me.RadTextBox_VarCostWas.Size = New System.Drawing.Size(82, 25)
        Me.RadTextBox_VarCostWas.TabIndex = 95
        Me.RadTextBox_VarCostWas.Text = "Unbound"
        Me.RadTextBox_VarCostWas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadTextBox_VarCostNow
        '
        Me.RadTextBox_VarCostNow.AutoSize = False
        Me.RadTextBox_VarCostNow.BackColor = System.Drawing.Color.White
        Me.RadTextBox_VarCostNow.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadTextBox_VarCostNow.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_VarCostNow.Location = New System.Drawing.Point(180, 62)
        Me.RadTextBox_VarCostNow.Name = "RadTextBox_VarCostNow"
        Me.RadTextBox_VarCostNow.Size = New System.Drawing.Size(82, 25)
        Me.RadTextBox_VarCostNow.TabIndex = 94
        Me.RadTextBox_VarCostNow.Text = "Unbound"
        Me.RadTextBox_VarCostNow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel_VarCost
        '
        Me.RadLabel_VarCost.AutoSize = False
        Me.RadLabel_VarCost.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_VarCost.Location = New System.Drawing.Point(1, 62)
        Me.RadLabel_VarCost.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_VarCost.Name = "RadLabel_VarCost"
        Me.RadLabel_VarCost.Size = New System.Drawing.Size(88, 25)
        Me.RadLabel_VarCost.TabIndex = 37
        Me.RadLabel_VarCost.Text = "DisplayValues_VarCost"
        Me.RadLabel_VarCost.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_StdCost
        '
        Me.RadLabel_StdCost.AutoSize = False
        Me.RadLabel_StdCost.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_StdCost.Location = New System.Drawing.Point(1, 32)
        Me.RadLabel_StdCost.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_StdCost.Name = "RadLabel_StdCost"
        Me.RadLabel_StdCost.Size = New System.Drawing.Size(88, 25)
        Me.RadLabel_StdCost.TabIndex = 36
        Me.RadLabel_StdCost.Text = "DisplayValues_StdCost"
        Me.RadLabel_StdCost.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel_Now
        '
        Me.RadLabel_Now.AutoSize = False
        Me.RadLabel_Now.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Now.Location = New System.Drawing.Point(180, 7)
        Me.RadLabel_Now.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Now.Name = "RadLabel_Now"
        Me.RadLabel_Now.Size = New System.Drawing.Size(82, 20)
        Me.RadLabel_Now.TabIndex = 35
        Me.RadLabel_Now.Text = "DisplayValues_Now"
        Me.RadLabel_Now.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadLabel_Was
        '
        Me.RadLabel_Was.AutoSize = False
        Me.RadLabel_Was.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Was.Location = New System.Drawing.Point(90, 7)
        Me.RadLabel_Was.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Was.Name = "RadLabel_Was"
        Me.RadLabel_Was.Size = New System.Drawing.Size(82, 20)
        Me.RadLabel_Was.TabIndex = 34
        Me.RadLabel_Was.Text = "DisplayValues_Was"
        Me.RadLabel_Was.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DisplayValues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(292, 145)
        Me.Controls.Add(Me.TabControl_PrintCatExtra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(300, 175)
        Me.Name = "DisplayValues"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DisplayValues_Title"
        Me.ThemeName = "Windows8"
        Me.TabControl_PrintCatExtra.ResumeLayout(False)
        Me.TabPage_RelativeCost.ResumeLayout(False)
        CType(Me.RadButton_ResetData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_RelativeCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_RelativeCost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_ActualValues.ResumeLayout(False)
        CType(Me.RadTextBox_StdCostWas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_StdCostNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_VarCostWas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_VarCostNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_VarCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_StdCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Now, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Was, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl_PrintCatExtra As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_RelativeCost As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_ActualValues As System.Windows.Forms.TabPage
    Friend WithEvents RadTextBox_RelativeCost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_RelativeCost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton_ResetData As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel_VarCost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_StdCost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Now As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Was As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_StdCostWas As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_StdCostNow As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_VarCostWas As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_VarCostNow As Telerik.WinControls.UI.RadTextBox
End Class

