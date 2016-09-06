<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScratchCleanup
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
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScratchCleanup))
        Me.RadLabel_InnerTitle = New Telerik.WinControls.UI.RadLabel()
        Me.RadGridView_PartsChanged = New Telerik.WinControls.UI.RadGridView()
        Me.RadButton_Delete = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_MarkAll = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Cancel = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadLabel_InnerTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_PartsChanged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_PartsChanged.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_MarkAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel_InnerTitle
        '
        Me.RadLabel_InnerTitle.AutoSize = False
        Me.RadLabel_InnerTitle.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_InnerTitle.Location = New System.Drawing.Point(12, 9)
        Me.RadLabel_InnerTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_InnerTitle.Name = "RadLabel_InnerTitle"
        Me.RadLabel_InnerTitle.Size = New System.Drawing.Size(311, 37)
        Me.RadLabel_InnerTitle.TabIndex = 0
        Me.RadLabel_InnerTitle.Text = "ScratchCleanup_Title"
        Me.RadLabel_InnerTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadGridView_PartsChanged
        '
        Me.RadGridView_PartsChanged.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadGridView_PartsChanged.AutoSize = True
        Me.RadGridView_PartsChanged.Location = New System.Drawing.Point(-1, 60)
        '
        '
        '
        Me.RadGridView_PartsChanged.MasterTemplate.AllowAddNewRow = False
        GridViewTextBoxColumn1.HeaderText = "Global_PartNumber"
        GridViewTextBoxColumn1.Name = "column1"
        GridViewTextBoxColumn1.Width = 200
        GridViewTextBoxColumn2.HeaderText = "Global_User"
        GridViewTextBoxColumn2.Name = "column2"
        GridViewTextBoxColumn2.Width = 100
        GridViewTextBoxColumn3.HeaderText = "Global_ID"
        GridViewTextBoxColumn3.Name = "column3"
        GridViewTextBoxColumn3.Width = 100
        GridViewTextBoxColumn4.HeaderText = "Global_DeleteQuestion"
        GridViewTextBoxColumn4.Name = "column4"
        GridViewTextBoxColumn4.Width = 100
        Me.RadGridView_PartsChanged.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4})
        Me.RadGridView_PartsChanged.MasterTemplate.EnableSorting = False
        Me.RadGridView_PartsChanged.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView_PartsChanged.Name = "RadGridView_PartsChanged"
        Me.RadGridView_PartsChanged.ShowGroupPanel = False
        Me.RadGridView_PartsChanged.ShowGroupPanelScrollbars = False
        Me.RadGridView_PartsChanged.Size = New System.Drawing.Size(518, 30)
        Me.RadGridView_PartsChanged.TabIndex = 6
        '
        'RadButton_Delete
        '
        Me.RadButton_Delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadButton_Delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_Delete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Delete.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Delete.Location = New System.Drawing.Point(102, 121)
        Me.RadButton_Delete.Name = "RadButton_Delete"
        Me.RadButton_Delete.Size = New System.Drawing.Size(100, 35)
        Me.RadButton_Delete.TabIndex = 7
        Me.RadButton_Delete.Text = "Global_Delete"
        Me.RadButton_Delete.TextWrap = True
        '
        'RadButton_MarkAll
        '
        Me.RadButton_MarkAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadButton_MarkAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_MarkAll.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_MarkAll.ForeColor = System.Drawing.Color.Black
        Me.RadButton_MarkAll.Location = New System.Drawing.Point(209, 121)
        Me.RadButton_MarkAll.Name = "RadButton_MarkAll"
        Me.RadButton_MarkAll.Size = New System.Drawing.Size(100, 35)
        Me.RadButton_MarkAll.TabIndex = 8
        Me.RadButton_MarkAll.Text = "Global_MarkAll"
        Me.RadButton_MarkAll.TextWrap = True
        '
        'RadButton_Cancel
        '
        Me.RadButton_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadButton_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_Cancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Cancel.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Cancel.Location = New System.Drawing.Point(316, 121)
        Me.RadButton_Cancel.Name = "RadButton_Cancel"
        Me.RadButton_Cancel.Size = New System.Drawing.Size(100, 35)
        Me.RadButton_Cancel.TabIndex = 9
        Me.RadButton_Cancel.Text = "Global_Cancel"
        Me.RadButton_Cancel.TextWrap = True
        '
        'ScratchCleanup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(517, 170)
        Me.Controls.Add(Me.RadButton_Cancel)
        Me.Controls.Add(Me.RadButton_MarkAll)
        Me.Controls.Add(Me.RadButton_Delete)
        Me.Controls.Add(Me.RadGridView_PartsChanged)
        Me.Controls.Add(Me.RadLabel_InnerTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(525, 600)
        Me.MinimumSize = New System.Drawing.Size(525, 200)
        Me.Name = "ScratchCleanup"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(525, 600)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScratchCleanup_Title"
        Me.ThemeName = "Windows8"
        CType(Me.RadLabel_InnerTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_PartsChanged.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_PartsChanged, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_MarkAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadLabel_InnerTitle As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGridView_PartsChanged As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadButton_Delete As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_MarkAll As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Cancel As Telerik.WinControls.UI.RadButton
End Class

