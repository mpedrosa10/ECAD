<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents EcadSplash As System.Windows.Forms.TableLayoutPanel

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.EcadSplash = New System.Windows.Forms.TableLayoutPanel()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout
        '
        'EcadSplash
        '
        Me.EcadSplash.BackgroundImage = Global.ECAD.My.Resources.Resources.Splash
        Me.EcadSplash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EcadSplash.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.EcadSplash.ColumnCount = 1
        Me.EcadSplash.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.EcadSplash.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.EcadSplash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EcadSplash.Location = New System.Drawing.Point(0, 0)
        Me.EcadSplash.Name = "EcadSplash"
        Me.EcadSplash.RowCount = 1
        Me.EcadSplash.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.EcadSplash.Size = New System.Drawing.Size(496, 303)
        Me.EcadSplash.TabIndex = 0
        '
        'Timer
        '
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 303)
        Me.ControlBox = false
        Me.Controls.Add(Me.EcadSplash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Splash"
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Timer As System.Windows.Forms.Timer

End Class
