<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DesignWizard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DesignWizard))
        Me.RadButton_Cancel = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_AC = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_DC = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel_DesignWizardMessage = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadButton_Cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_AC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_DC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_DesignWizardMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadButton_Cancel
        '
        Me.RadButton_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_Cancel.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Cancel.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Cancel.Location = New System.Drawing.Point(211, 45)
        Me.RadButton_Cancel.Name = "RadButton_Cancel"
        Me.RadButton_Cancel.Size = New System.Drawing.Size(92, 40)
        Me.RadButton_Cancel.TabIndex = 12
        Me.RadButton_Cancel.Text = "Global_Cancel"
        Me.RadButton_Cancel.TextWrap = True
        '
        'RadButton_AC
        '
        Me.RadButton_AC.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_AC.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_AC.ForeColor = System.Drawing.Color.Black
        Me.RadButton_AC.Location = New System.Drawing.Point(110, 45)
        Me.RadButton_AC.Name = "RadButton_AC"
        Me.RadButton_AC.Size = New System.Drawing.Size(92, 40)
        Me.RadButton_AC.TabIndex = 13
        Me.RadButton_AC.Text = "Global_AC"
        Me.RadButton_AC.TextWrap = True
        '
        'RadButton_DC
        '
        Me.RadButton_DC.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_DC.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_DC.ForeColor = System.Drawing.Color.Black
        Me.RadButton_DC.Location = New System.Drawing.Point(9, 45)
        Me.RadButton_DC.Name = "RadButton_DC"
        Me.RadButton_DC.Size = New System.Drawing.Size(92, 40)
        Me.RadButton_DC.TabIndex = 13
        Me.RadButton_DC.Text = "Global_DC"
        Me.RadButton_DC.TextWrap = True
        '
        'RadLabel_DesignWizardMessage
        '
        Me.RadLabel_DesignWizardMessage.AutoSize = False
        Me.RadLabel_DesignWizardMessage.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_DesignWizardMessage.Location = New System.Drawing.Point(3, 3)
        Me.RadLabel_DesignWizardMessage.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_DesignWizardMessage.Name = "RadLabel_DesignWizardMessage"
        Me.RadLabel_DesignWizardMessage.Size = New System.Drawing.Size(304, 37)
        Me.RadLabel_DesignWizardMessage.TabIndex = 15
        Me.RadLabel_DesignWizardMessage.Text = "DesignWizard_Message"
        Me.RadLabel_DesignWizardMessage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DesignWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(312, 91)
        Me.Controls.Add(Me.RadLabel_DesignWizardMessage)
        Me.Controls.Add(Me.RadButton_DC)
        Me.Controls.Add(Me.RadButton_AC)
        Me.Controls.Add(Me.RadButton_Cancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DesignWizard"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DesignWizard_Title"
        Me.ThemeName = "Windows8"
        CType(Me.RadButton_Cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_AC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_DC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_DesignWizardMessage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadButton_Cancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_AC As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_DC As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel_DesignWizardMessage As Telerik.WinControls.UI.RadLabel
End Class

