<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileChooser
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
        Dim ListViewDetailColumn1 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "0")
        Dim ListViewDataItem1 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("C:\UserData\EcadTest\P_Server\dwg\END DISCS\text.pdf")
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileChooser))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox_KemetLogo = New System.Windows.Forms.PictureBox()
        Me.RadLabel_Title = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_TypeChooser = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_FileToFind = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_FileToFind = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_FileExt = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_FileExt = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_SearchPath = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_SearchPath = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_FileType = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_FileType = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Files = New Telerik.WinControls.UI.RadLabel()
        Me.RadListView_Files = New Telerik.WinControls.UI.RadListView()
        Me.RadMultiColumnComboBox_TypeChooser = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_TypeChooser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_FileToFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_FileToFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_FileExt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_FileExt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_SearchPath, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_SearchPath, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_FileType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_FileType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Files, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadListView_Files, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadMultiColumnComboBox_TypeChooser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadMultiColumnComboBox_TypeChooser.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadMultiColumnComboBox_TypeChooser.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox_KemetLogo)
        Me.Panel1.Controls.Add(Me.RadLabel_Title)
        Me.Panel1.Location = New System.Drawing.Point(-9, -7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(833, 71)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox_KemetLogo
        '
        Me.PictureBox_KemetLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox_KemetLogo.Image = Global.ECAD.My.Resources.Resources.kemet_logo_small
        Me.PictureBox_KemetLogo.Location = New System.Drawing.Point(698, 9)
        Me.PictureBox_KemetLogo.MaximumSize = New System.Drawing.Size(142, 61)
        Me.PictureBox_KemetLogo.Name = "PictureBox_KemetLogo"
        Me.PictureBox_KemetLogo.Size = New System.Drawing.Size(116, 54)
        Me.PictureBox_KemetLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_KemetLogo.TabIndex = 11
        Me.PictureBox_KemetLogo.TabStop = False
        '
        'RadLabel_Title
        '
        Me.RadLabel_Title.AutoSize = False
        Me.RadLabel_Title.Font = New System.Drawing.Font("Segoe UI", 22.0!)
        Me.RadLabel_Title.Location = New System.Drawing.Point(35, 4)
        Me.RadLabel_Title.Name = "RadLabel_Title"
        Me.RadLabel_Title.Size = New System.Drawing.Size(483, 62)
        Me.RadLabel_Title.TabIndex = 0
        Me.RadLabel_Title.Text = "FileChooser_Title"
        Me.RadLabel_Title.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Title.ThemeName = "Windows8"
        '
        'RadLabel_TypeChooser
        '
        Me.RadLabel_TypeChooser.AutoSize = False
        Me.RadLabel_TypeChooser.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.RadLabel_TypeChooser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.RadLabel_TypeChooser.Location = New System.Drawing.Point(8, 71)
        Me.RadLabel_TypeChooser.Name = "RadLabel_TypeChooser"
        Me.RadLabel_TypeChooser.Size = New System.Drawing.Size(100, 25)
        Me.RadLabel_TypeChooser.TabIndex = 2
        Me.RadLabel_TypeChooser.Text = "FileChooser_TypeChooser"
        Me.RadLabel_TypeChooser.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_TypeChooser.TextWrap = False
        Me.RadLabel_TypeChooser.ThemeName = "Windows8"
        '
        'RadLabel_FileToFind
        '
        Me.RadLabel_FileToFind.AutoSize = False
        Me.RadLabel_FileToFind.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.RadLabel_FileToFind.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.RadLabel_FileToFind.Location = New System.Drawing.Point(338, 71)
        Me.RadLabel_FileToFind.Name = "RadLabel_FileToFind"
        Me.RadLabel_FileToFind.Size = New System.Drawing.Size(100, 25)
        Me.RadLabel_FileToFind.TabIndex = 4
        Me.RadLabel_FileToFind.Text = "FileChooser_FileToFind"
        Me.RadLabel_FileToFind.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_FileToFind.TextWrap = False
        Me.RadLabel_FileToFind.ThemeName = "Windows8"
        '
        'RadTextBox_FileToFind
        '
        Me.RadTextBox_FileToFind.AutoSize = False
        Me.RadTextBox_FileToFind.Location = New System.Drawing.Point(446, 71)
        Me.RadTextBox_FileToFind.Name = "RadTextBox_FileToFind"
        Me.RadTextBox_FileToFind.Size = New System.Drawing.Size(150, 25)
        Me.RadTextBox_FileToFind.TabIndex = 5
        Me.RadTextBox_FileToFind.ThemeName = "Windows8"
        '
        'RadTextBox_FileExt
        '
        Me.RadTextBox_FileExt.AutoSize = False
        Me.RadTextBox_FileExt.Location = New System.Drawing.Point(721, 71)
        Me.RadTextBox_FileExt.Name = "RadTextBox_FileExt"
        Me.RadTextBox_FileExt.Size = New System.Drawing.Size(86, 25)
        Me.RadTextBox_FileExt.TabIndex = 7
        Me.RadTextBox_FileExt.ThemeName = "Windows8"
        '
        'RadLabel_FileExt
        '
        Me.RadLabel_FileExt.AutoSize = False
        Me.RadLabel_FileExt.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.RadLabel_FileExt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.RadLabel_FileExt.Location = New System.Drawing.Point(613, 71)
        Me.RadLabel_FileExt.Name = "RadLabel_FileExt"
        Me.RadLabel_FileExt.Size = New System.Drawing.Size(100, 25)
        Me.RadLabel_FileExt.TabIndex = 6
        Me.RadLabel_FileExt.Text = "FileChooser_FileExt"
        Me.RadLabel_FileExt.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_FileExt.TextWrap = False
        Me.RadLabel_FileExt.ThemeName = "Windows8"
        '
        'RadLabel_SearchPath
        '
        Me.RadLabel_SearchPath.AutoSize = False
        Me.RadLabel_SearchPath.Enabled = False
        Me.RadLabel_SearchPath.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.RadLabel_SearchPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.RadLabel_SearchPath.Location = New System.Drawing.Point(8, 115)
        Me.RadLabel_SearchPath.Name = "RadLabel_SearchPath"
        Me.RadLabel_SearchPath.Size = New System.Drawing.Size(100, 25)
        Me.RadLabel_SearchPath.TabIndex = 8
        Me.RadLabel_SearchPath.Text = "FileChooser_SearchPath"
        Me.RadLabel_SearchPath.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_SearchPath.TextWrap = False
        Me.RadLabel_SearchPath.ThemeName = "Windows8"
        '
        'RadTextBox_SearchPath
        '
        Me.RadTextBox_SearchPath.AutoSize = False
        Me.RadTextBox_SearchPath.Enabled = False
        Me.RadTextBox_SearchPath.Location = New System.Drawing.Point(115, 115)
        Me.RadTextBox_SearchPath.Name = "RadTextBox_SearchPath"
        Me.RadTextBox_SearchPath.Size = New System.Drawing.Size(481, 25)
        Me.RadTextBox_SearchPath.TabIndex = 9
        Me.RadTextBox_SearchPath.ThemeName = "Windows8"
        '
        'RadTextBox_FileType
        '
        Me.RadTextBox_FileType.AutoSize = False
        Me.RadTextBox_FileType.Location = New System.Drawing.Point(721, 115)
        Me.RadTextBox_FileType.Name = "RadTextBox_FileType"
        Me.RadTextBox_FileType.Size = New System.Drawing.Size(86, 25)
        Me.RadTextBox_FileType.TabIndex = 11
        Me.RadTextBox_FileType.ThemeName = "Windows8"
        '
        'RadLabel_FileType
        '
        Me.RadLabel_FileType.AutoSize = False
        Me.RadLabel_FileType.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.RadLabel_FileType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.RadLabel_FileType.Location = New System.Drawing.Point(613, 115)
        Me.RadLabel_FileType.Name = "RadLabel_FileType"
        Me.RadLabel_FileType.Size = New System.Drawing.Size(100, 25)
        Me.RadLabel_FileType.TabIndex = 10
        Me.RadLabel_FileType.Text = "FileChooser_FileType"
        Me.RadLabel_FileType.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_FileType.TextWrap = False
        Me.RadLabel_FileType.ThemeName = "Windows8"
        '
        'RadLabel_Files
        '
        Me.RadLabel_Files.AutoSize = False
        Me.RadLabel_Files.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.RadLabel_Files.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.RadLabel_Files.Location = New System.Drawing.Point(8, 155)
        Me.RadLabel_Files.Name = "RadLabel_Files"
        Me.RadLabel_Files.Size = New System.Drawing.Size(100, 25)
        Me.RadLabel_Files.TabIndex = 12
        Me.RadLabel_Files.Text = "FileChooser_Files"
        Me.RadLabel_Files.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Files.TextWrap = False
        Me.RadLabel_Files.ThemeName = "Windows8"
        '
        'RadListView_Files
        '
        Me.RadListView_Files.AllowEdit = False
        ListViewDetailColumn1.HeaderText = "0"
        ListViewDetailColumn1.Width = 335.0!
        Me.RadListView_Files.Columns.AddRange(New Telerik.WinControls.UI.ListViewDetailColumn() {ListViewDetailColumn1})
        Me.RadListView_Files.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.RadListView_Files.HeaderHeight = 0.0!
        ListViewDataItem1.Text = "C:\UserData\EcadTest\P_Server\dwg\END DISCS\text.pdf"
        Me.RadListView_Files.Items.AddRange(New Telerik.WinControls.UI.ListViewDataItem() {ListViewDataItem1})
        Me.RadListView_Files.Location = New System.Drawing.Point(8, 197)
        Me.RadListView_Files.Name = "RadListView_Files"
        Me.RadListView_Files.ShowColumnHeaders = False
        Me.RadListView_Files.Size = New System.Drawing.Size(799, 335)
        Me.RadListView_Files.TabIndex = 13
        Me.RadListView_Files.ThemeName = "Windows8"
        '
        'RadMultiColumnComboBox_TypeChooser
        '
        '
        'RadMultiColumnComboBox_TypeChooser.NestedRadGridView
        '
        Me.RadMultiColumnComboBox_TypeChooser.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.RadMultiColumnComboBox_TypeChooser.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadMultiColumnComboBox_TypeChooser.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadMultiColumnComboBox_TypeChooser.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.RadMultiColumnComboBox_TypeChooser.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.RadMultiColumnComboBox_TypeChooser.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.RadMultiColumnComboBox_TypeChooser.EditorControl.MasterTemplate.AllowColumnChooser = False
        GridViewTextBoxColumn1.HeaderText = "Type"
        GridViewTextBoxColumn1.Name = "Type"
        GridViewTextBoxColumn2.HeaderText = "Path"
        GridViewTextBoxColumn2.Name = "Path"
        GridViewTextBoxColumn2.Width = 100
        GridViewTextBoxColumn3.HeaderText = "Ext"
        GridViewTextBoxColumn3.Name = "column1"
        Me.RadMultiColumnComboBox_TypeChooser.EditorControl.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3})
        Me.RadMultiColumnComboBox_TypeChooser.EditorControl.MasterTemplate.EnableGrouping = False
        Me.RadMultiColumnComboBox_TypeChooser.EditorControl.MasterTemplate.ShowColumnHeaders = False
        Me.RadMultiColumnComboBox_TypeChooser.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.RadMultiColumnComboBox_TypeChooser.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadMultiColumnComboBox_TypeChooser.EditorControl.Name = "NestedRadGridView"
        Me.RadMultiColumnComboBox_TypeChooser.EditorControl.ReadOnly = True
        Me.RadMultiColumnComboBox_TypeChooser.EditorControl.ShowGroupPanel = False
        Me.RadMultiColumnComboBox_TypeChooser.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.RadMultiColumnComboBox_TypeChooser.EditorControl.TabIndex = 0
        Me.RadMultiColumnComboBox_TypeChooser.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.RadMultiColumnComboBox_TypeChooser.Location = New System.Drawing.Point(115, 71)
        Me.RadMultiColumnComboBox_TypeChooser.Name = "RadMultiColumnComboBox_TypeChooser"
        Me.RadMultiColumnComboBox_TypeChooser.Size = New System.Drawing.Size(200, 25)
        Me.RadMultiColumnComboBox_TypeChooser.TabIndex = 14
        Me.RadMultiColumnComboBox_TypeChooser.TabStop = False
        Me.RadMultiColumnComboBox_TypeChooser.ThemeName = "Windows8"
        '
        'FileChooser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(819, 544)
        Me.Controls.Add(Me.RadMultiColumnComboBox_TypeChooser)
        Me.Controls.Add(Me.RadListView_Files)
        Me.Controls.Add(Me.RadLabel_Files)
        Me.Controls.Add(Me.RadTextBox_FileType)
        Me.Controls.Add(Me.RadLabel_FileType)
        Me.Controls.Add(Me.RadTextBox_SearchPath)
        Me.Controls.Add(Me.RadLabel_SearchPath)
        Me.Controls.Add(Me.RadTextBox_FileExt)
        Me.Controls.Add(Me.RadLabel_FileExt)
        Me.Controls.Add(Me.RadTextBox_FileToFind)
        Me.Controls.Add(Me.RadLabel_FileToFind)
        Me.Controls.Add(Me.RadLabel_TypeChooser)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(827, 577)
        Me.MinimumSize = New System.Drawing.Size(827, 577)
        Me.Name = "FileChooser"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(827, 577)
        Me.Text = "FileChooser_TitleWindow"
        Me.ThemeName = "Windows8"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_TypeChooser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_FileToFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_FileToFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_FileExt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_FileExt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_SearchPath, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_SearchPath, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_FileType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_FileType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Files, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadListView_Files, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadMultiColumnComboBox_TypeChooser.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadMultiColumnComboBox_TypeChooser.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadMultiColumnComboBox_TypeChooser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox_KemetLogo As System.Windows.Forms.PictureBox
    Friend WithEvents RadLabel_Title As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_TypeChooser As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_FileToFind As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_FileToFind As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_FileExt As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_FileExt As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_SearchPath As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_SearchPath As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_FileType As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_FileType As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Files As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadListView_Files As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadMultiColumnComboBox_TypeChooser As Telerik.WinControls.UI.RadMultiColumnComboBox
End Class

