<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlashStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FlashStatus))
        Me.RadTextBox_Status = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.RadTextBox_Status, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadTextBox_Status
        '
        Me.RadTextBox_Status.Enabled = False
        Me.RadTextBox_Status.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.RadTextBox_Status.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Status.Location = New System.Drawing.Point(12, 8)
        Me.RadTextBox_Status.Name = "RadTextBox_Status"
        Me.RadTextBox_Status.Size = New System.Drawing.Size(588, 30)
        Me.RadTextBox_Status.TabIndex = 100
        Me.RadTextBox_Status.Text = "Unbound"
        Me.RadTextBox_Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlashStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(612, 47)
        Me.ControlBox = False
        Me.Controls.Add(Me.RadTextBox_Status)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FlashStatus"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Global_Message"
        Me.ThemeName = "Windows8"
        CType(Me.RadTextBox_Status, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadTextBox_Status As Telerik.WinControls.UI.RadTextBox
End Class

