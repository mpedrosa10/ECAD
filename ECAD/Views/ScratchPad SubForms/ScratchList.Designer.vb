<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScratchList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScratchList))
        Me.RadLabel_Message = New Telerik.WinControls.UI.RadLabel()
        Me.RadCheckBox_OnlyShowMine = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadGridView_Designs = New Telerik.WinControls.UI.RadGridView()
        CType(Me.RadLabel_Message, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_OnlyShowMine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_Designs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_Designs.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel_Message
        '
        Me.RadLabel_Message.AutoSize = False
        Me.RadLabel_Message.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Message.Location = New System.Drawing.Point(18, 9)
        Me.RadLabel_Message.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Message.Name = "RadLabel_Message"
        Me.RadLabel_Message.Size = New System.Drawing.Size(500, 78)
        Me.RadLabel_Message.TabIndex = 30
        Me.RadLabel_Message.Text = "ScratchList_Message"
        Me.RadLabel_Message.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadCheckBox_OnlyShowMine
        '
        Me.RadCheckBox_OnlyShowMine.AutoSize = False
        Me.RadCheckBox_OnlyShowMine.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RadCheckBox_OnlyShowMine.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_OnlyShowMine.Location = New System.Drawing.Point(43, 91)
        Me.RadCheckBox_OnlyShowMine.Name = "RadCheckBox_OnlyShowMine"
        Me.RadCheckBox_OnlyShowMine.Size = New System.Drawing.Size(250, 25)
        Me.RadCheckBox_OnlyShowMine.TabIndex = 89
        Me.RadCheckBox_OnlyShowMine.Text = "ScratchList_OnlyShowMydesigns"
        Me.RadCheckBox_OnlyShowMine.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'RadGridView_Designs
        '
        Me.RadGridView_Designs.Location = New System.Drawing.Point(10, 119)
        '
        '
        '
        Me.RadGridView_Designs.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView_Designs.MasterTemplate.AllowCellContextMenu = False
        Me.RadGridView_Designs.MasterTemplate.AllowDeleteRow = False
        Me.RadGridView_Designs.MasterTemplate.AllowDragToGroup = False
        Me.RadGridView_Designs.MasterTemplate.AllowEditRow = False
        Me.RadGridView_Designs.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.RadGridView_Designs.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView_Designs.Name = "RadGridView_Designs"
        Me.RadGridView_Designs.ShowGroupPanel = False
        Me.RadGridView_Designs.Size = New System.Drawing.Size(519, 494)
        Me.RadGridView_Designs.TabIndex = 104
        '
        'ScratchList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(538, 621)
        Me.Controls.Add(Me.RadGridView_Designs)
        Me.Controls.Add(Me.RadCheckBox_OnlyShowMine)
        Me.Controls.Add(Me.RadLabel_Message)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ScratchList"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScratchList_Title"
        Me.ThemeName = "Windows8"
        CType(Me.RadLabel_Message, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_OnlyShowMine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_Designs.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_Designs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadLabel_Message As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadCheckBox_OnlyShowMine As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadGridView_Designs As Telerik.WinControls.UI.RadGridView
End Class

