<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryDesignComment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SummaryDesignComment))
        Me.RadLabel_Instructions = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Text = New Telerik.WinControls.UI.RadTextBox()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        CType(Me.RadLabel_Instructions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Text, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel_Instructions
        '
        Me.RadLabel_Instructions.AutoSize = False
        Me.RadLabel_Instructions.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Instructions.Location = New System.Drawing.Point(10, 5)
        Me.RadLabel_Instructions.Name = "RadLabel_Instructions"
        Me.RadLabel_Instructions.Size = New System.Drawing.Size(346, 25)
        Me.RadLabel_Instructions.TabIndex = 0
        Me.RadLabel_Instructions.Text = "SummaryDesignComment_Instructions"
        Me.RadLabel_Instructions.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Instructions.ThemeName = "Windows8"
        '
        'RadTextBox_Text
        '
        Me.RadTextBox_Text.AcceptsReturn = True
        Me.RadTextBox_Text.AcceptsTab = True
        Me.RadTextBox_Text.AutoScroll = True
        Me.RadTextBox_Text.AutoSize = False
        Me.RadTextBox_Text.Location = New System.Drawing.Point(10, 35)
        Me.RadTextBox_Text.Multiline = True
        Me.RadTextBox_Text.Name = "RadTextBox_Text"
        Me.RadTextBox_Text.Size = New System.Drawing.Size(346, 141)
        Me.RadTextBox_Text.TabIndex = 1
        Me.RadTextBox_Text.ThemeName = "Windows8"
        '
        'SummaryDesignComment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 184)
        Me.Controls.Add(Me.RadTextBox_Text)
        Me.Controls.Add(Me.RadLabel_Instructions)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(376, 217)
        Me.MinimumSize = New System.Drawing.Size(376, 217)
        Me.Name = "SummaryDesignComment"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(376, 217)
        Me.Text = "SummaryDesignComment_TitleWindow"
        Me.ThemeName = "Windows8"
        CType(Me.RadLabel_Instructions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Text, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadLabel_Instructions As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Text As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
End Class

