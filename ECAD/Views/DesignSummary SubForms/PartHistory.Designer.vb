<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PartHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PartHistory))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox_KemetLogo = New System.Windows.Forms.PictureBox()
        Me.RadLabel_Title = New Telerik.WinControls.UI.RadLabel()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabel_PartNumber = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_PartNumber = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_LatestIssue = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_LatestIssue = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_LatestIssueDate = New Telerik.WinControls.UI.RadTextBox()
        Me.RadButton_MicroWaveHistory = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Print = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Preview = New Telerik.WinControls.UI.RadButton()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_PartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_LatestIssue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_LatestIssue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_LatestIssueDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_MicroWaveHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Print, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox_KemetLogo)
        Me.Panel1.Controls.Add(Me.RadLabel_Title)
        Me.Panel1.Location = New System.Drawing.Point(-12, -6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1185, 73)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox_KemetLogo
        '
        Me.PictureBox_KemetLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox_KemetLogo.Image = Global.ECAD.My.Resources.Resources.kemet_logo_small
        Me.PictureBox_KemetLogo.Location = New System.Drawing.Point(1033, 10)
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
        Me.RadLabel_Title.Text = "PartHistory_Title"
        Me.RadLabel_Title.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Title.ThemeName = "Windows8"
        '
        'RadGridView1
        '
        Me.RadGridView1.AutoScroll = True
        Me.RadGridView1.Location = New System.Drawing.Point(25, 183)
        '
        '
        '
        Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.Size = New System.Drawing.Size(1114, 507)
        Me.RadGridView1.TabIndex = 1
        Me.RadGridView1.Text = "RadGridView1"
        Me.RadGridView1.ThemeName = "Windows8"
        '
        'RadLabel_PartNumber
        '
        Me.RadLabel_PartNumber.AutoSize = False
        Me.RadLabel_PartNumber.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.RadLabel_PartNumber.Location = New System.Drawing.Point(25, 86)
        Me.RadLabel_PartNumber.Name = "RadLabel_PartNumber"
        Me.RadLabel_PartNumber.Size = New System.Drawing.Size(156, 30)
        Me.RadLabel_PartNumber.TabIndex = 2
        Me.RadLabel_PartNumber.Text = "PartHistory_PartNumber"
        Me.RadLabel_PartNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_PartNumber.TextWrap = False
        Me.RadLabel_PartNumber.ThemeName = "Windows8"
        '
        'RadDropDownList_PartNumber
        '
        Me.RadDropDownList_PartNumber.AutoSize = False
        Me.RadDropDownList_PartNumber.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_PartNumber.Location = New System.Drawing.Point(187, 86)
        Me.RadDropDownList_PartNumber.Name = "RadDropDownList_PartNumber"
        Me.RadDropDownList_PartNumber.Size = New System.Drawing.Size(236, 30)
        Me.RadDropDownList_PartNumber.TabIndex = 3
        Me.RadDropDownList_PartNumber.ThemeName = "Windows8"
        '
        'RadLabel_LatestIssue
        '
        Me.RadLabel_LatestIssue.AutoSize = False
        Me.RadLabel_LatestIssue.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.RadLabel_LatestIssue.Location = New System.Drawing.Point(25, 127)
        Me.RadLabel_LatestIssue.Name = "RadLabel_LatestIssue"
        Me.RadLabel_LatestIssue.Size = New System.Drawing.Size(156, 30)
        Me.RadLabel_LatestIssue.TabIndex = 4
        Me.RadLabel_LatestIssue.Text = "PartHistory_LatestIssue"
        Me.RadLabel_LatestIssue.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_LatestIssue.TextWrap = False
        Me.RadLabel_LatestIssue.ThemeName = "Windows8"
        '
        'RadTextBox_LatestIssue
        '
        Me.RadTextBox_LatestIssue.AutoSize = False
        Me.RadTextBox_LatestIssue.BackColor = System.Drawing.Color.Silver
        Me.RadTextBox_LatestIssue.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.RadTextBox_LatestIssue.Location = New System.Drawing.Point(187, 127)
        Me.RadTextBox_LatestIssue.Name = "RadTextBox_LatestIssue"
        Me.RadTextBox_LatestIssue.Size = New System.Drawing.Size(46, 30)
        Me.RadTextBox_LatestIssue.TabIndex = 5
        Me.RadTextBox_LatestIssue.ThemeName = "Windows8"
        '
        'RadTextBox_LatestIssueDate
        '
        Me.RadTextBox_LatestIssueDate.AutoSize = False
        Me.RadTextBox_LatestIssueDate.BackColor = System.Drawing.Color.Silver
        Me.RadTextBox_LatestIssueDate.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.RadTextBox_LatestIssueDate.Location = New System.Drawing.Point(250, 127)
        Me.RadTextBox_LatestIssueDate.Name = "RadTextBox_LatestIssueDate"
        Me.RadTextBox_LatestIssueDate.Size = New System.Drawing.Size(144, 30)
        Me.RadTextBox_LatestIssueDate.TabIndex = 6
        Me.RadTextBox_LatestIssueDate.ThemeName = "Windows8"
        '
        'RadButton_MicroWaveHistory
        '
        Me.RadButton_MicroWaveHistory.BackColor = System.Drawing.Color.Silver
        Me.RadButton_MicroWaveHistory.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadButton_MicroWaveHistory.ForeColor = System.Drawing.Color.Black
        Me.RadButton_MicroWaveHistory.Location = New System.Drawing.Point(475, 107)
        Me.RadButton_MicroWaveHistory.Name = "RadButton_MicroWaveHistory"
        Me.RadButton_MicroWaveHistory.Size = New System.Drawing.Size(141, 50)
        Me.RadButton_MicroWaveHistory.TabIndex = 7
        Me.RadButton_MicroWaveHistory.Text = "PartHistory_MicroWaveHistory"
        Me.RadButton_MicroWaveHistory.ThemeName = "Windows8"
        '
        'RadButton_Print
        '
        Me.RadButton_Print.BackColor = System.Drawing.Color.White
        Me.RadButton_Print.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.RadButton_Print.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadButton_Print.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Print.Image = Global.ECAD.My.Resources.Resources.print_32
        Me.RadButton_Print.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButton_Print.Location = New System.Drawing.Point(1053, 86)
        Me.RadButton_Print.Name = "RadButton_Print"
        Me.RadButton_Print.Size = New System.Drawing.Size(35, 35)
        Me.RadButton_Print.TabIndex = 9
        Me.RadButton_Print.ThemeName = "Windows8"
        '
        'RadButton_Preview
        '
        Me.RadButton_Preview.BackColor = System.Drawing.Color.White
        Me.RadButton_Preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadButton_Preview.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadButton_Preview.Image = Global.ECAD.My.Resources.Resources.preview_32
        Me.RadButton_Preview.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButton_Preview.Location = New System.Drawing.Point(1104, 86)
        Me.RadButton_Preview.Name = "RadButton_Preview"
        Me.RadButton_Preview.Size = New System.Drawing.Size(35, 35)
        Me.RadButton_Preview.TabIndex = 8
        Me.RadButton_Preview.ThemeName = "Windows8"
        '
        'PartHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1166, 717)
        Me.Controls.Add(Me.RadButton_Print)
        Me.Controls.Add(Me.RadButton_Preview)
        Me.Controls.Add(Me.RadButton_MicroWaveHistory)
        Me.Controls.Add(Me.RadTextBox_LatestIssueDate)
        Me.Controls.Add(Me.RadTextBox_LatestIssue)
        Me.Controls.Add(Me.RadLabel_LatestIssue)
        Me.Controls.Add(Me.RadDropDownList_PartNumber)
        Me.Controls.Add(Me.RadLabel_PartNumber)
        Me.Controls.Add(Me.RadGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1174, 750)
        Me.MinimumSize = New System.Drawing.Size(1174, 750)
        Me.Name = "PartHistory"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(1174, 750)
        Me.Text = "PartHistory_TitleWindow"
        Me.ThemeName = "Windows8"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_PartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_LatestIssue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_LatestIssue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_LatestIssueDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_MicroWaveHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Print, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Preview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_Title As Telerik.WinControls.UI.RadLabel
    Friend WithEvents PictureBox_KemetLogo As System.Windows.Forms.PictureBox
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel_PartNumber As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_PartNumber As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_LatestIssue As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_LatestIssue As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_LatestIssueDate As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadButton_MicroWaveHistory As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Preview As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Print As Telerik.WinControls.UI.RadButton
End Class

