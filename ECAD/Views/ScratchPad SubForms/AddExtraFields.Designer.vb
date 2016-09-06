<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddExtraFields
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
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddExtraFields))
        Me.RadPanel_Header = New Telerik.WinControls.UI.RadPanel()
        Me.PictureBox_KemetLogo = New System.Windows.Forms.PictureBox()
        Me.RadLabel_InnerTitle = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Fields = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_ForTable = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_Table = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadGridView_ExtraFields = New Telerik.WinControls.UI.RadGridView()
        CType(Me.RadPanel_Header, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel_Header.SuspendLayout()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_InnerTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Fields, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ForTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_Table, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_ExtraFields, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_ExtraFields.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel_Header
        '
        Me.RadPanel_Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadPanel_Header.Controls.Add(Me.PictureBox_KemetLogo)
        Me.RadPanel_Header.Controls.Add(Me.RadLabel_InnerTitle)
        Me.RadPanel_Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel_Header.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel_Header.Margin = New System.Windows.Forms.Padding(0)
        Me.RadPanel_Header.Name = "RadPanel_Header"
        Me.RadPanel_Header.Size = New System.Drawing.Size(812, 56)
        Me.RadPanel_Header.TabIndex = 0
        '
        'PictureBox_KemetLogo
        '
        Me.PictureBox_KemetLogo.Image = Global.ECAD.My.Resources.Resources.kemet_logo_small
        Me.PictureBox_KemetLogo.Location = New System.Drawing.Point(669, 0)
        Me.PictureBox_KemetLogo.Name = "PictureBox_KemetLogo"
        Me.PictureBox_KemetLogo.Size = New System.Drawing.Size(128, 56)
        Me.PictureBox_KemetLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_KemetLogo.TabIndex = 2
        Me.PictureBox_KemetLogo.TabStop = False
        '
        'RadLabel_InnerTitle
        '
        Me.RadLabel_InnerTitle.AutoSize = False
        Me.RadLabel_InnerTitle.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_InnerTitle.Location = New System.Drawing.Point(9, 10)
        Me.RadLabel_InnerTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_InnerTitle.Name = "RadLabel_InnerTitle"
        Me.RadLabel_InnerTitle.Size = New System.Drawing.Size(311, 37)
        Me.RadLabel_InnerTitle.TabIndex = 1
        Me.RadLabel_InnerTitle.Text = "AddExtraFields_ExtraFields"
        Me.RadLabel_InnerTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_Fields
        '
        Me.RadLabel_Fields.AutoSize = False
        Me.RadLabel_Fields.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.RadLabel_Fields.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadLabel_Fields.Location = New System.Drawing.Point(9, 63)
        Me.RadLabel_Fields.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Fields.Name = "RadLabel_Fields"
        Me.RadLabel_Fields.Size = New System.Drawing.Size(105, 28)
        Me.RadLabel_Fields.TabIndex = 2
        Me.RadLabel_Fields.Text = "AddExtraFields_Fields"
        Me.RadLabel_Fields.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel_ForTable
        '
        Me.RadLabel_ForTable.AutoSize = False
        Me.RadLabel_ForTable.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.RadLabel_ForTable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadLabel_ForTable.Location = New System.Drawing.Point(215, 63)
        Me.RadLabel_ForTable.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_ForTable.Name = "RadLabel_ForTable"
        Me.RadLabel_ForTable.Size = New System.Drawing.Size(105, 28)
        Me.RadLabel_ForTable.TabIndex = 3
        Me.RadLabel_ForTable.Text = "AddExtraFields_ForTable"
        Me.RadLabel_ForTable.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadDropDownList_Table
        '
        Me.RadDropDownList_Table.BackColor = System.Drawing.Color.White
        Me.RadDropDownList_Table.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_Table.Location = New System.Drawing.Point(323, 65)
        Me.RadDropDownList_Table.Name = "RadDropDownList_Table"
        Me.RadDropDownList_Table.Size = New System.Drawing.Size(210, 25)
        Me.RadDropDownList_Table.TabIndex = 10
        Me.RadDropDownList_Table.Text = "Unbound"
        '
        'RadGridView_ExtraFields
        '
        Me.RadGridView_ExtraFields.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadGridView_ExtraFields.Location = New System.Drawing.Point(12, 96)
        '
        '
        '
        GridViewTextBoxColumn1.HeaderText = "AddExtraFields_FieldName"
        GridViewTextBoxColumn1.Name = "column1"
        GridViewTextBoxColumn1.Width = 100
        GridViewTextBoxColumn2.HeaderText = "AddExtraFields_PpiType"
        GridViewTextBoxColumn2.Name = "column2"
        GridViewTextBoxColumn2.Width = 100
        GridViewTextBoxColumn3.HeaderText = "AddExtraFields_FieldType"
        GridViewTextBoxColumn3.Name = "column3"
        GridViewTextBoxColumn3.Width = 100
        GridViewTextBoxColumn4.HeaderText = "AddExtraFields_FieldValRule"
        GridViewTextBoxColumn4.Name = "column4"
        GridViewTextBoxColumn4.Width = 100
        GridViewTextBoxColumn5.HeaderText = "AddExtraFields_FieldValMsg"
        GridViewTextBoxColumn5.Name = "column5"
        GridViewTextBoxColumn5.Width = 100
        GridViewTextBoxColumn6.HeaderText = "AddExtraFields_RuleCode"
        GridViewTextBoxColumn6.Name = "column6"
        GridViewTextBoxColumn6.Width = 100
        GridViewTextBoxColumn7.HeaderText = "AddExtraFields_TableName"
        GridViewTextBoxColumn7.Name = "column7"
        GridViewTextBoxColumn7.Width = 100
        Me.RadGridView_ExtraFields.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7})
        Me.RadGridView_ExtraFields.MasterTemplate.EnableSorting = False
        Me.RadGridView_ExtraFields.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView_ExtraFields.Name = "RadGridView_ExtraFields"
        Me.RadGridView_ExtraFields.ShowGroupPanel = False
        Me.RadGridView_ExtraFields.ShowGroupPanelScrollbars = False
        Me.RadGridView_ExtraFields.Size = New System.Drawing.Size(785, 316)
        Me.RadGridView_ExtraFields.TabIndex = 11
        '
        'AddExtraFields
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(812, 427)
        Me.Controls.Add(Me.RadGridView_ExtraFields)
        Me.Controls.Add(Me.RadDropDownList_Table)
        Me.Controls.Add(Me.RadLabel_ForTable)
        Me.Controls.Add(Me.RadLabel_Fields)
        Me.Controls.Add(Me.RadPanel_Header)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(820, 460)
        Me.MinimumSize = New System.Drawing.Size(820, 460)
        Me.Name = "AddExtraFields"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(820, 460)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddExtraFields_Title"
        Me.ThemeName = "Windows8"
        CType(Me.RadPanel_Header, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel_Header.ResumeLayout(False)
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_InnerTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Fields, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ForTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_Table, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_ExtraFields.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_ExtraFields, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadPanel_Header As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadLabel_InnerTitle As Telerik.WinControls.UI.RadLabel
    Friend WithEvents PictureBox_KemetLogo As System.Windows.Forms.PictureBox
    Friend WithEvents RadLabel_Fields As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_ForTable As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_Table As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadGridView_ExtraFields As Telerik.WinControls.UI.RadGridView
End Class

