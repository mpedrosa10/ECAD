<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Override
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Override))
        Me.RadLabel_OverrideMessage = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_OverridePassword = New Telerik.WinControls.UI.RadTextBox()
        Me.RadButton_OverrideDo = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Cancel = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadLabel_OverrideMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_OverridePassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_OverrideDo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel_OverrideMessage
        '
        Me.RadLabel_OverrideMessage.AutoSize = False
        Me.RadLabel_OverrideMessage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_OverrideMessage.Location = New System.Drawing.Point(5, 5)
        Me.RadLabel_OverrideMessage.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_OverrideMessage.Name = "RadLabel_OverrideMessage"
        Me.RadLabel_OverrideMessage.Size = New System.Drawing.Size(382, 70)
        Me.RadLabel_OverrideMessage.TabIndex = 1
        Me.RadLabel_OverrideMessage.Text = "You do not have clearance to authorise the design. You may override by entering t" & _
    "he correct password below..."
        Me.RadLabel_OverrideMessage.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'RadTextBox_OverridePassword
        '
        Me.RadTextBox_OverridePassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_OverridePassword.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_OverridePassword.Location = New System.Drawing.Point(5, 83)
        Me.RadTextBox_OverridePassword.Name = "RadTextBox_OverridePassword"
        Me.RadTextBox_OverridePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RadTextBox_OverridePassword.Size = New System.Drawing.Size(160, 27)
        Me.RadTextBox_OverridePassword.TabIndex = 24
        Me.RadTextBox_OverridePassword.Text = "Unbound"
        '
        'RadButton_OverrideDo
        '
        Me.RadButton_OverrideDo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadButton_OverrideDo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_OverrideDo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_OverrideDo.ForeColor = System.Drawing.Color.Black
        Me.RadButton_OverrideDo.Location = New System.Drawing.Point(171, 77)
        Me.RadButton_OverrideDo.Name = "RadButton_OverrideDo"
        Me.RadButton_OverrideDo.Size = New System.Drawing.Size(107, 31)
        Me.RadButton_OverrideDo.TabIndex = 25
        Me.RadButton_OverrideDo.Text = "Override_Title"
        Me.RadButton_OverrideDo.TextWrap = True
        '
        'RadButton_Cancel
        '
        Me.RadButton_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadButton_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_Cancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Cancel.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Cancel.Location = New System.Drawing.Point(280, 77)
        Me.RadButton_Cancel.Name = "RadButton_Cancel"
        Me.RadButton_Cancel.Size = New System.Drawing.Size(107, 31)
        Me.RadButton_Cancel.TabIndex = 26
        Me.RadButton_Cancel.Text = "Global_Cancel"
        Me.RadButton_Cancel.TextWrap = True
        '
        'Override
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(392, 117)
        Me.Controls.Add(Me.RadButton_Cancel)
        Me.Controls.Add(Me.RadButton_OverrideDo)
        Me.Controls.Add(Me.RadTextBox_OverridePassword)
        Me.Controls.Add(Me.RadLabel_OverrideMessage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(400, 150)
        Me.MinimumSize = New System.Drawing.Size(400, 150)
        Me.Name = "Override"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(400, 150)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Override_Title"
        Me.ThemeName = "Windows8"
        CType(Me.RadLabel_OverrideMessage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_OverridePassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_OverrideDo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadLabel_OverrideMessage As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_OverridePassword As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadButton_OverrideDo As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Cancel As Telerik.WinControls.UI.RadButton
End Class

