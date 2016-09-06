<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PartsFiles
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PartsFiles))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadButton_PiecePartsForm = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_CopyAsNewRecord = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_WhereUsed = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox_KemetLogo = New System.Windows.Forms.PictureBox()
        Me.RadLabel_Title = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_PartsFile = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_PartsFile = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadButton_PrintPartsFile = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_ReOrder = New Telerik.WinControls.UI.RadButton()
        Me.RadTextBox_Description = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Description = New Telerik.WinControls.UI.RadLabel()
        Me.object_1d6422b4_5d9f_4bbb_a4a4_bbf357a3d190 = New Telerik.WinControls.RootRadElement()
        Me.RadLabel_Usage = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_PartsCost = New Telerik.WinControls.UI.RadLabel()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.RadButton_PiecePartsForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_CopyAsNewRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_WhereUsed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PartsFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_PartsFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_PrintPartsFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_ReOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Usage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PartsCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.RadButton_PiecePartsForm)
        Me.Panel1.Controls.Add(Me.RadButton_CopyAsNewRecord)
        Me.Panel1.Controls.Add(Me.RadButton_WhereUsed)
        Me.Panel1.Controls.Add(Me.PictureBox_KemetLogo)
        Me.Panel1.Controls.Add(Me.RadLabel_Title)
        Me.Panel1.Location = New System.Drawing.Point(-4, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1326, 68)
        Me.Panel1.TabIndex = 1
        '
        'RadButton_PiecePartsForm
        '
        Me.RadButton_PiecePartsForm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_PiecePartsForm.Location = New System.Drawing.Point(540, 8)
        Me.RadButton_PiecePartsForm.Name = "RadButton_PiecePartsForm"
        Me.RadButton_PiecePartsForm.Size = New System.Drawing.Size(100, 50)
        Me.RadButton_PiecePartsForm.TabIndex = 14
        Me.RadButton_PiecePartsForm.Text = "PartsFiles_PiecePartsForm"
        Me.RadButton_PiecePartsForm.TextWrap = True
        Me.RadButton_PiecePartsForm.ThemeName = "Windows8"
        '
        'RadButton_CopyAsNewRecord
        '
        Me.RadButton_CopyAsNewRecord.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_CopyAsNewRecord.Location = New System.Drawing.Point(410, 8)
        Me.RadButton_CopyAsNewRecord.Name = "RadButton_CopyAsNewRecord"
        Me.RadButton_CopyAsNewRecord.Size = New System.Drawing.Size(100, 50)
        Me.RadButton_CopyAsNewRecord.TabIndex = 13
        Me.RadButton_CopyAsNewRecord.Text = "PartsFiles_CopyAsNewRecord"
        Me.RadButton_CopyAsNewRecord.TextWrap = True
        Me.RadButton_CopyAsNewRecord.ThemeName = "Windows8"
        '
        'RadButton_WhereUsed
        '
        Me.RadButton_WhereUsed.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_WhereUsed.Location = New System.Drawing.Point(280, 8)
        Me.RadButton_WhereUsed.Name = "RadButton_WhereUsed"
        Me.RadButton_WhereUsed.Size = New System.Drawing.Size(100, 50)
        Me.RadButton_WhereUsed.TabIndex = 12
        Me.RadButton_WhereUsed.Text = "PartsFiles_WhereUsed"
        Me.RadButton_WhereUsed.TextWrap = True
        Me.RadButton_WhereUsed.ThemeName = "Windows8"
        '
        'PictureBox_KemetLogo
        '
        Me.PictureBox_KemetLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox_KemetLogo.Image = Global.ECAD.My.Resources.Resources.kemet_logo_small
        Me.PictureBox_KemetLogo.Location = New System.Drawing.Point(1160, 5)
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
        Me.RadLabel_Title.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Title.Location = New System.Drawing.Point(25, -2)
        Me.RadLabel_Title.Name = "RadLabel_Title"
        Me.RadLabel_Title.Size = New System.Drawing.Size(282, 68)
        Me.RadLabel_Title.TabIndex = 0
        Me.RadLabel_Title.Text = "PartsFiles_Title"
        Me.RadLabel_Title.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Title.ThemeName = "Windows8"
        '
        'RadLabel_PartsFile
        '
        Me.RadLabel_PartsFile.AutoSize = False
        Me.RadLabel_PartsFile.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.RadLabel_PartsFile.Location = New System.Drawing.Point(23, 88)
        Me.RadLabel_PartsFile.Name = "RadLabel_PartsFile"
        Me.RadLabel_PartsFile.Size = New System.Drawing.Size(100, 30)
        Me.RadLabel_PartsFile.TabIndex = 2
        Me.RadLabel_PartsFile.Text = "PartsFiles_PartsFile"
        Me.RadLabel_PartsFile.ThemeName = "Windows8"
        '
        'RadDropDownList_PartsFile
        '
        Me.RadDropDownList_PartsFile.AutoSize = False
        Me.RadDropDownList_PartsFile.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.RadDropDownList_PartsFile.Location = New System.Drawing.Point(151, 88)
        Me.RadDropDownList_PartsFile.Name = "RadDropDownList_PartsFile"
        Me.RadDropDownList_PartsFile.Size = New System.Drawing.Size(345, 30)
        Me.RadDropDownList_PartsFile.TabIndex = 3
        Me.RadDropDownList_PartsFile.ThemeName = "Windows8"
        '
        'RadButton_PrintPartsFile
        '
        Me.RadButton_PrintPartsFile.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_PrintPartsFile.Location = New System.Drawing.Point(526, 88)
        Me.RadButton_PrintPartsFile.Name = "RadButton_PrintPartsFile"
        Me.RadButton_PrintPartsFile.Size = New System.Drawing.Size(100, 30)
        Me.RadButton_PrintPartsFile.TabIndex = 15
        Me.RadButton_PrintPartsFile.Text = "PartsFiles_PrintPartsFile"
        Me.RadButton_PrintPartsFile.ThemeName = "Windows8"
        '
        'RadButton_ReOrder
        '
        Me.RadButton_ReOrder.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadButton_ReOrder.Location = New System.Drawing.Point(23, 175)
        Me.RadButton_ReOrder.Name = "RadButton_ReOrder"
        Me.RadButton_ReOrder.Size = New System.Drawing.Size(100, 30)
        Me.RadButton_ReOrder.TabIndex = 16
        Me.RadButton_ReOrder.Text = "PartsFiles_ReOrder"
        Me.RadButton_ReOrder.ThemeName = "Windows8"
        '
        'RadTextBox_Description
        '
        Me.RadTextBox_Description.AutoSize = False
        Me.RadTextBox_Description.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_Description.Location = New System.Drawing.Point(151, 175)
        Me.RadTextBox_Description.Name = "RadTextBox_Description"
        Me.RadTextBox_Description.Size = New System.Drawing.Size(345, 30)
        Me.RadTextBox_Description.TabIndex = 17
        Me.RadTextBox_Description.ThemeName = "Windows8"
        '
        'RadLabel_Description
        '
        Me.RadLabel_Description.AutoSize = False
        Me.RadLabel_Description.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Description.Location = New System.Drawing.Point(151, 144)
        Me.RadLabel_Description.Name = "RadLabel_Description"
        Me.RadLabel_Description.Size = New System.Drawing.Size(142, 25)
        Me.RadLabel_Description.TabIndex = 18
        Me.RadLabel_Description.Text = "PartsFiles_Description"
        Me.RadLabel_Description.ThemeName = "Windows8"
        '
        'object_1d6422b4_5d9f_4bbb_a4a4_bbf357a3d190
        '
        Me.object_1d6422b4_5d9f_4bbb_a4a4_bbf357a3d190.Name = "object_1d6422b4_5d9f_4bbb_a4a4_bbf357a3d190"
        Me.object_1d6422b4_5d9f_4bbb_a4a4_bbf357a3d190.StretchHorizontally = True
        Me.object_1d6422b4_5d9f_4bbb_a4a4_bbf357a3d190.StretchVertically = True
        '
        'RadLabel_Usage
        '
        Me.RadLabel_Usage.AutoSize = False
        Me.RadLabel_Usage.BorderVisible = True
        Me.RadLabel_Usage.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Usage.ForeColor = System.Drawing.Color.Red
        Me.RadLabel_Usage.Location = New System.Drawing.Point(1155, 144)
        Me.RadLabel_Usage.Name = "RadLabel_Usage"
        Me.RadLabel_Usage.Size = New System.Drawing.Size(136, 61)
        Me.RadLabel_Usage.TabIndex = 19
        Me.RadLabel_Usage.Text = "Unused"
        Me.RadLabel_Usage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_Usage.TextWrap = False
        Me.RadLabel_Usage.ThemeName = "Windows8"
        '
        'RadTextBox1
        '
        Me.RadTextBox1.AutoSize = False
        Me.RadTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RadTextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox1.Location = New System.Drawing.Point(876, 175)
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.Size = New System.Drawing.Size(139, 30)
        Me.RadTextBox1.TabIndex = 20
        Me.RadTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadTextBox1.ThemeName = "Windows8"
        '
        'RadLabel_PartsCost
        '
        Me.RadLabel_PartsCost.AutoSize = False
        Me.RadLabel_PartsCost.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_PartsCost.Location = New System.Drawing.Point(876, 144)
        Me.RadLabel_PartsCost.Name = "RadLabel_PartsCost"
        Me.RadLabel_PartsCost.Size = New System.Drawing.Size(139, 25)
        Me.RadLabel_PartsCost.TabIndex = 21
        Me.RadLabel_PartsCost.Text = "PartsFiles_PartsCost"
        Me.RadLabel_PartsCost.ThemeName = "Windows8"
        '
        'RadGridView1
        '
        Me.RadGridView1.Location = New System.Drawing.Point(23, 225)
        '
        '
        '
        Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.Size = New System.Drawing.Size(1268, 365)
        Me.RadGridView1.TabIndex = 22
        Me.RadGridView1.Text = "RadGridView1"
        Me.RadGridView1.ThemeName = "Windows8"
        '
        'PartsFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1316, 613)
        Me.Controls.Add(Me.RadGridView1)
        Me.Controls.Add(Me.RadLabel_PartsCost)
        Me.Controls.Add(Me.RadTextBox1)
        Me.Controls.Add(Me.RadLabel_Usage)
        Me.Controls.Add(Me.RadLabel_Description)
        Me.Controls.Add(Me.RadTextBox_Description)
        Me.Controls.Add(Me.RadButton_ReOrder)
        Me.Controls.Add(Me.RadButton_PrintPartsFile)
        Me.Controls.Add(Me.RadDropDownList_PartsFile)
        Me.Controls.Add(Me.RadLabel_PartsFile)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1324, 646)
        Me.MinimumSize = New System.Drawing.Size(1324, 646)
        Me.Name = "PartsFiles"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(1324, 646)
        Me.Text = "PartsFiles_TitleWindow"
        Me.ThemeName = "Windows8"
        Me.Panel1.ResumeLayout(False)
        CType(Me.RadButton_PiecePartsForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_CopyAsNewRecord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_WhereUsed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PartsFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_PartsFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_PrintPartsFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_ReOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Description, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Description, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Usage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PartsCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox_KemetLogo As System.Windows.Forms.PictureBox
    Friend WithEvents RadLabel_Title As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton_PiecePartsForm As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_CopyAsNewRecord As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_WhereUsed As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel_PartsFile As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_PartsFile As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadButton_PrintPartsFile As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_ReOrder As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadTextBox_Description As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Description As Telerik.WinControls.UI.RadLabel
    Friend WithEvents object_1d6422b4_5d9f_4bbb_a4a4_bbf357a3d190 As Telerik.WinControls.RootRadElement
    Friend WithEvents RadLabel_Usage As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_PartsCost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
End Class

