<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransferToScratch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransferToScratch))
        Me.Panel_Container = New System.Windows.Forms.Panel()
        Me.RadTextBox_UserCopies = New Telerik.WinControls.UI.RadTextBox()
        Me.RadCheckBox_RegisterTransfer = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadTextBox_Archive = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Archive = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_scratchid = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_scratchid = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_userval = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_user = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_de_id = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_id = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_PartNumber = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Who = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_HowMany = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_PartNumber = New Telerik.WinControls.UI.RadTextBox()
        Me.RadButton_OK = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Cancel = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel_MessageAboutToBeTransferred = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_InnerTitle = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Copies = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_ArchiveIssue = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_ArchiveIssue = New Telerik.WinControls.UI.RadLabel()
        Me.Panel_Container.SuspendLayout()
        CType(Me.RadTextBox_UserCopies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_RegisterTransfer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Archive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Archive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_scratchid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_scratchid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_userval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_de_id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Who, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_HowMany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_PartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_OK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_MessageAboutToBeTransferred, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_InnerTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Copies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ArchiveIssue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ArchiveIssue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Container
        '
        Me.Panel_Container.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Container.Controls.Add(Me.RadTextBox_UserCopies)
        Me.Panel_Container.Controls.Add(Me.RadCheckBox_RegisterTransfer)
        Me.Panel_Container.Controls.Add(Me.RadTextBox_Archive)
        Me.Panel_Container.Controls.Add(Me.RadLabel_Archive)
        Me.Panel_Container.Controls.Add(Me.RadTextBox_scratchid)
        Me.Panel_Container.Controls.Add(Me.RadLabel_scratchid)
        Me.Panel_Container.Controls.Add(Me.RadLabel_userval)
        Me.Panel_Container.Controls.Add(Me.RadLabel_user)
        Me.Panel_Container.Controls.Add(Me.RadLabel_de_id)
        Me.Panel_Container.Controls.Add(Me.RadLabel_id)
        Me.Panel_Container.Controls.Add(Me.RadLabel_PartNumber)
        Me.Panel_Container.Controls.Add(Me.RadLabel_Who)
        Me.Panel_Container.Controls.Add(Me.RadLabel_HowMany)
        Me.Panel_Container.Controls.Add(Me.RadTextBox_PartNumber)
        Me.Panel_Container.Controls.Add(Me.RadButton_OK)
        Me.Panel_Container.Controls.Add(Me.RadButton_Cancel)
        Me.Panel_Container.Controls.Add(Me.RadLabel_MessageAboutToBeTransferred)
        Me.Panel_Container.Controls.Add(Me.RadLabel_InnerTitle)
        Me.Panel_Container.Controls.Add(Me.RadTextBox_Copies)
        Me.Panel_Container.Controls.Add(Me.RadTextBox_ArchiveIssue)
        Me.Panel_Container.Controls.Add(Me.RadLabel_ArchiveIssue)
        Me.Panel_Container.Location = New System.Drawing.Point(6, 5)
        Me.Panel_Container.Name = "Panel_Container"
        Me.Panel_Container.Size = New System.Drawing.Size(311, 191)
        Me.Panel_Container.TabIndex = 0
        '
        'RadTextBox_UserCopies
        '
        Me.RadTextBox_UserCopies.Enabled = False
        Me.RadTextBox_UserCopies.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_UserCopies.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_UserCopies.Location = New System.Drawing.Point(1, 171)
        Me.RadTextBox_UserCopies.Name = "RadTextBox_UserCopies"
        Me.RadTextBox_UserCopies.Size = New System.Drawing.Size(50, 20)
        Me.RadTextBox_UserCopies.TabIndex = 111
        Me.RadTextBox_UserCopies.Text = "Unbound"
        Me.RadTextBox_UserCopies.Visible = False
        '
        'RadCheckBox_RegisterTransfer
        '
        Me.RadCheckBox_RegisterTransfer.AutoSize = False
        Me.RadCheckBox_RegisterTransfer.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadCheckBox_RegisterTransfer.Location = New System.Drawing.Point(4, 142)
        Me.RadCheckBox_RegisterTransfer.Name = "RadCheckBox_RegisterTransfer"
        Me.RadCheckBox_RegisterTransfer.Size = New System.Drawing.Size(110, 16)
        Me.RadCheckBox_RegisterTransfer.TabIndex = 109
        Me.RadCheckBox_RegisterTransfer.Text = "Register Transfer"
        Me.RadCheckBox_RegisterTransfer.Visible = False
        '
        'RadTextBox_Archive
        '
        Me.RadTextBox_Archive.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_Archive.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Archive.Location = New System.Drawing.Point(261, -7)
        Me.RadTextBox_Archive.Name = "RadTextBox_Archive"
        Me.RadTextBox_Archive.Size = New System.Drawing.Size(60, 20)
        Me.RadTextBox_Archive.TabIndex = 108
        Me.RadTextBox_Archive.Text = "Unbound"
        Me.RadTextBox_Archive.Visible = False
        '
        'RadLabel_Archive
        '
        Me.RadLabel_Archive.AutoSize = False
        Me.RadLabel_Archive.BackColor = System.Drawing.Color.White
        Me.RadLabel_Archive.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadLabel_Archive.Location = New System.Drawing.Point(216, -3)
        Me.RadLabel_Archive.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Archive.Name = "RadLabel_Archive"
        Me.RadLabel_Archive.Size = New System.Drawing.Size(45, 15)
        Me.RadLabel_Archive.TabIndex = 107
        Me.RadLabel_Archive.Text = "Archive"
        Me.RadLabel_Archive.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Archive.Visible = False
        '
        'RadTextBox_scratchid
        '
        Me.RadTextBox_scratchid.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_scratchid.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_scratchid.Location = New System.Drawing.Point(149, -7)
        Me.RadTextBox_scratchid.Name = "RadTextBox_scratchid"
        Me.RadTextBox_scratchid.Size = New System.Drawing.Size(65, 20)
        Me.RadTextBox_scratchid.TabIndex = 106
        Me.RadTextBox_scratchid.Text = "Unbound"
        Me.RadTextBox_scratchid.Visible = False
        '
        'RadLabel_scratchid
        '
        Me.RadLabel_scratchid.AutoSize = False
        Me.RadLabel_scratchid.BackColor = System.Drawing.Color.White
        Me.RadLabel_scratchid.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadLabel_scratchid.Location = New System.Drawing.Point(114, -3)
        Me.RadLabel_scratchid.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_scratchid.Name = "RadLabel_scratchid"
        Me.RadLabel_scratchid.Size = New System.Drawing.Size(35, 15)
        Me.RadLabel_scratchid.TabIndex = 105
        Me.RadLabel_scratchid.Text = "s id:"
        Me.RadLabel_scratchid.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_scratchid.Visible = False
        '
        'RadLabel_userval
        '
        Me.RadLabel_userval.AutoSize = False
        Me.RadLabel_userval.BackColor = System.Drawing.Color.Silver
        Me.RadLabel_userval.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadLabel_userval.Location = New System.Drawing.Point(49, -3)
        Me.RadLabel_userval.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_userval.Name = "RadLabel_userval"
        Me.RadLabel_userval.Size = New System.Drawing.Size(60, 15)
        Me.RadLabel_userval.TabIndex = 104
        Me.RadLabel_userval.Text = "Unbound"
        Me.RadLabel_userval.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_userval.Visible = False
        '
        'RadLabel_user
        '
        Me.RadLabel_user.AutoSize = False
        Me.RadLabel_user.BackColor = System.Drawing.Color.Silver
        Me.RadLabel_user.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadLabel_user.Location = New System.Drawing.Point(-1, -2)
        Me.RadLabel_user.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_user.Name = "RadLabel_user"
        Me.RadLabel_user.Size = New System.Drawing.Size(50, 15)
        Me.RadLabel_user.TabIndex = 103
        Me.RadLabel_user.Text = "user"
        Me.RadLabel_user.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_user.Visible = False
        '
        'RadLabel_de_id
        '
        Me.RadLabel_de_id.AutoSize = False
        Me.RadLabel_de_id.BackColor = System.Drawing.Color.Silver
        Me.RadLabel_de_id.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadLabel_de_id.Location = New System.Drawing.Point(110, 57)
        Me.RadLabel_de_id.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_de_id.Name = "RadLabel_de_id"
        Me.RadLabel_de_id.Size = New System.Drawing.Size(100, 15)
        Me.RadLabel_de_id.TabIndex = 103
        Me.RadLabel_de_id.Text = "Unbound"
        Me.RadLabel_de_id.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_de_id.Visible = False
        '
        'RadLabel_id
        '
        Me.RadLabel_id.AutoSize = False
        Me.RadLabel_id.BackColor = System.Drawing.Color.Silver
        Me.RadLabel_id.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadLabel_id.Location = New System.Drawing.Point(25, 57)
        Me.RadLabel_id.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_id.Name = "RadLabel_id"
        Me.RadLabel_id.Size = New System.Drawing.Size(50, 15)
        Me.RadLabel_id.TabIndex = 102
        Me.RadLabel_id.Text = "id"
        Me.RadLabel_id.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_id.Visible = False
        '
        'RadLabel_PartNumber
        '
        Me.RadLabel_PartNumber.AutoSize = False
        Me.RadLabel_PartNumber.BackColor = System.Drawing.Color.Silver
        Me.RadLabel_PartNumber.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadLabel_PartNumber.Location = New System.Drawing.Point(10, 98)
        Me.RadLabel_PartNumber.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_PartNumber.Name = "RadLabel_PartNumber"
        Me.RadLabel_PartNumber.Size = New System.Drawing.Size(70, 15)
        Me.RadLabel_PartNumber.TabIndex = 101
        Me.RadLabel_PartNumber.Text = "Global_PartNumber"
        Me.RadLabel_PartNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_PartNumber.Visible = False
        '
        'RadLabel_Who
        '
        Me.RadLabel_Who.AutoSize = False
        Me.RadLabel_Who.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Who.ForeColor = System.Drawing.Color.Red
        Me.RadLabel_Who.Location = New System.Drawing.Point(3, 123)
        Me.RadLabel_Who.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Who.Name = "RadLabel_Who"
        Me.RadLabel_Who.Size = New System.Drawing.Size(304, 20)
        Me.RadLabel_Who.TabIndex = 100
        Me.RadLabel_Who.Text = "=Switch([txtcopies]=1 And [txtusercopies]>0;""and that is yourself"";[txtcopies]>1 " & _
    "And [txtusercopies]>0;""including you"";[txtusercopies]=0;"""")"
        Me.RadLabel_Who.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_Who.Visible = False
        '
        'RadLabel_HowMany
        '
        Me.RadLabel_HowMany.AutoSize = False
        Me.RadLabel_HowMany.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadLabel_HowMany.Location = New System.Drawing.Point(2, 104)
        Me.RadLabel_HowMany.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_HowMany.Name = "RadLabel_HowMany"
        Me.RadLabel_HowMany.Size = New System.Drawing.Size(304, 20)
        Me.RadLabel_HowMany.TabIndex = 99
        Me.RadLabel_HowMany.Text = "=Switch([txtcopies]=0;""Noone has"";[txtcopies]=1;""Someone has"";[txtcopies]>1;CStr(" & _
    "[txtcopies]) & "" People have"") & ""  a copy at the moment."""
        Me.RadLabel_HowMany.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_HowMany.Visible = False
        '
        'RadTextBox_PartNumber
        '
        Me.RadTextBox_PartNumber.Enabled = False
        Me.RadTextBox_PartNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_PartNumber.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_PartNumber.Location = New System.Drawing.Point(10, 71)
        Me.RadTextBox_PartNumber.Name = "RadTextBox_PartNumber"
        Me.RadTextBox_PartNumber.Size = New System.Drawing.Size(289, 27)
        Me.RadTextBox_PartNumber.TabIndex = 98
        Me.RadTextBox_PartNumber.Text = "Unbound"
        Me.RadTextBox_PartNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadButton_OK
        '
        Me.RadButton_OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_OK.Enabled = False
        Me.RadButton_OK.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_OK.ForeColor = System.Drawing.Color.Black
        Me.RadButton_OK.Location = New System.Drawing.Point(134, 153)
        Me.RadButton_OK.Name = "RadButton_OK"
        Me.RadButton_OK.Size = New System.Drawing.Size(82, 31)
        Me.RadButton_OK.TabIndex = 12
        Me.RadButton_OK.Text = "Global_OK"
        Me.RadButton_OK.TextWrap = True
        '
        'RadButton_Cancel
        '
        Me.RadButton_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_Cancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Cancel.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Cancel.Location = New System.Drawing.Point(222, 153)
        Me.RadButton_Cancel.Name = "RadButton_Cancel"
        Me.RadButton_Cancel.Size = New System.Drawing.Size(82, 31)
        Me.RadButton_Cancel.TabIndex = 11
        Me.RadButton_Cancel.Text = "Global_Cancel"
        Me.RadButton_Cancel.TextWrap = True
        '
        'RadLabel_MessageAboutToBeTransferred
        '
        Me.RadLabel_MessageAboutToBeTransferred.AutoSize = False
        Me.RadLabel_MessageAboutToBeTransferred.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MessageAboutToBeTransferred.Location = New System.Drawing.Point(1, 15)
        Me.RadLabel_MessageAboutToBeTransferred.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_MessageAboutToBeTransferred.Name = "RadLabel_MessageAboutToBeTransferred"
        Me.RadLabel_MessageAboutToBeTransferred.Size = New System.Drawing.Size(304, 37)
        Me.RadLabel_MessageAboutToBeTransferred.TabIndex = 14
        Me.RadLabel_MessageAboutToBeTransferred.Text = "TrsfrToScratch_MessageAboutToBeTransferred"
        Me.RadLabel_MessageAboutToBeTransferred.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadLabel_InnerTitle
        '
        Me.RadLabel_InnerTitle.AutoSize = False
        Me.RadLabel_InnerTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_InnerTitle.Location = New System.Drawing.Point(1, 15)
        Me.RadLabel_InnerTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_InnerTitle.Name = "RadLabel_InnerTitle"
        Me.RadLabel_InnerTitle.Size = New System.Drawing.Size(304, 37)
        Me.RadLabel_InnerTitle.TabIndex = 13
        Me.RadLabel_InnerTitle.Text = "TrsfrToScratch_Transferring"
        Me.RadLabel_InnerTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_InnerTitle.Visible = False
        '
        'RadTextBox_Copies
        '
        Me.RadTextBox_Copies.Enabled = False
        Me.RadTextBox_Copies.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_Copies.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_Copies.Location = New System.Drawing.Point(1, 152)
        Me.RadTextBox_Copies.Name = "RadTextBox_Copies"
        Me.RadTextBox_Copies.Size = New System.Drawing.Size(50, 20)
        Me.RadTextBox_Copies.TabIndex = 110
        Me.RadTextBox_Copies.Text = "Unbound"
        Me.RadTextBox_Copies.Visible = False
        '
        'RadTextBox_ArchiveIssue
        '
        Me.RadTextBox_ArchiveIssue.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_ArchiveIssue.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_ArchiveIssue.Location = New System.Drawing.Point(85, 168)
        Me.RadTextBox_ArchiveIssue.Name = "RadTextBox_ArchiveIssue"
        Me.RadTextBox_ArchiveIssue.Size = New System.Drawing.Size(60, 20)
        Me.RadTextBox_ArchiveIssue.TabIndex = 113
        Me.RadTextBox_ArchiveIssue.Text = "Unbound"
        Me.RadTextBox_ArchiveIssue.Visible = False
        '
        'RadLabel_ArchiveIssue
        '
        Me.RadLabel_ArchiveIssue.AutoSize = False
        Me.RadLabel_ArchiveIssue.BackColor = System.Drawing.Color.White
        Me.RadLabel_ArchiveIssue.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadLabel_ArchiveIssue.Location = New System.Drawing.Point(50, 171)
        Me.RadLabel_ArchiveIssue.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_ArchiveIssue.Name = "RadLabel_ArchiveIssue"
        Me.RadLabel_ArchiveIssue.Size = New System.Drawing.Size(35, 15)
        Me.RadLabel_ArchiveIssue.TabIndex = 112
        Me.RadLabel_ArchiveIssue.Text = "Issue"
        Me.RadLabel_ArchiveIssue.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_ArchiveIssue.Visible = False
        '
        'TransferToScratch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(322, 200)
        Me.Controls.Add(Me.Panel_Container)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TransferToScratch"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TrsfrToScratch_Title"
        Me.ThemeName = "Windows8"
        Me.Panel_Container.ResumeLayout(False)
        Me.Panel_Container.PerformLayout()
        CType(Me.RadTextBox_UserCopies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_RegisterTransfer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Archive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Archive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_scratchid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_scratchid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_userval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_de_id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Who, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_HowMany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_PartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_OK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_MessageAboutToBeTransferred, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_InnerTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Copies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ArchiveIssue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ArchiveIssue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Container As System.Windows.Forms.Panel
    Friend WithEvents RadButton_OK As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Cancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel_InnerTitle As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_MessageAboutToBeTransferred As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_PartNumber As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Who As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_HowMany As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_PartNumber As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_de_id As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_id As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_scratchid As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_scratchid As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_userval As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_user As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Archive As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Archive As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_UserCopies As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadCheckBox_RegisterTransfer As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadTextBox_Copies As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_ArchiveIssue As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_ArchiveIssue As Telerik.WinControls.UI.RadLabel
End Class

