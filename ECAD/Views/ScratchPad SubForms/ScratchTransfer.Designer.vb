<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScratchTransfer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScratchTransfer))
        Me.RadButton_ReserveName = New Telerik.WinControls.UI.RadButton()
        Me.RadTextBox_NoOfDesigns = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_NoOfDesigns = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_ID = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_ID = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_PartNumber = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_PartNumber = New Telerik.WinControls.UI.RadLabel()
        Me.Panel_Container = New System.Windows.Forms.Panel()
        Me.ListBox_Users = New System.Windows.Forms.ListBox()
        Me.RadLabel_UsersMessage = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadButton_ReserveName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_NoOfDesigns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_NoOfDesigns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_PartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Container.SuspendLayout()
        CType(Me.RadLabel_UsersMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadButton_ReserveName
        '
        Me.RadButton_ReserveName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_ReserveName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_ReserveName.ForeColor = System.Drawing.Color.Black
        Me.RadButton_ReserveName.Location = New System.Drawing.Point(286, 173)
        Me.RadButton_ReserveName.Name = "RadButton_ReserveName"
        Me.RadButton_ReserveName.Size = New System.Drawing.Size(46, 46)
        Me.RadButton_ReserveName.TabIndex = 39
        Me.RadButton_ReserveName.Text = "Global_GoExclamation"
        Me.RadButton_ReserveName.TextWrap = True
        '
        'RadTextBox_NoOfDesigns
        '
        Me.RadTextBox_NoOfDesigns.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_NoOfDesigns.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_NoOfDesigns.Location = New System.Drawing.Point(132, 75)
        Me.RadTextBox_NoOfDesigns.Name = "RadTextBox_NoOfDesigns"
        Me.RadTextBox_NoOfDesigns.Size = New System.Drawing.Size(200, 27)
        Me.RadTextBox_NoOfDesigns.TabIndex = 105
        Me.RadTextBox_NoOfDesigns.Text = "Unbound"
        '
        'RadLabel_NoOfDesigns
        '
        Me.RadLabel_NoOfDesigns.AutoSize = False
        Me.RadLabel_NoOfDesigns.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_NoOfDesigns.Location = New System.Drawing.Point(2, 75)
        Me.RadLabel_NoOfDesigns.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_NoOfDesigns.Name = "RadLabel_NoOfDesigns"
        Me.RadLabel_NoOfDesigns.Size = New System.Drawing.Size(128, 27)
        Me.RadLabel_NoOfDesigns.TabIndex = 104
        Me.RadLabel_NoOfDesigns.Text = "ScratchTransfer_NoOfDesigns"
        Me.RadLabel_NoOfDesigns.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_ID
        '
        Me.RadTextBox_ID.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_ID.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_ID.Location = New System.Drawing.Point(132, 43)
        Me.RadTextBox_ID.Name = "RadTextBox_ID"
        Me.RadTextBox_ID.Size = New System.Drawing.Size(200, 27)
        Me.RadTextBox_ID.TabIndex = 103
        Me.RadTextBox_ID.Text = "Unbound"
        '
        'RadLabel_ID
        '
        Me.RadLabel_ID.AutoSize = False
        Me.RadLabel_ID.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_ID.Location = New System.Drawing.Point(2, 43)
        Me.RadLabel_ID.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_ID.Name = "RadLabel_ID"
        Me.RadLabel_ID.Size = New System.Drawing.Size(128, 27)
        Me.RadLabel_ID.TabIndex = 102
        Me.RadLabel_ID.Text = "Global_ID"
        Me.RadLabel_ID.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadTextBox_PartNumber
        '
        Me.RadTextBox_PartNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_PartNumber.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_PartNumber.Location = New System.Drawing.Point(132, 11)
        Me.RadTextBox_PartNumber.Name = "RadTextBox_PartNumber"
        Me.RadTextBox_PartNumber.Size = New System.Drawing.Size(200, 27)
        Me.RadTextBox_PartNumber.TabIndex = 101
        Me.RadTextBox_PartNumber.Text = "Unbound"
        '
        'RadLabel_PartNumber
        '
        Me.RadLabel_PartNumber.AutoSize = False
        Me.RadLabel_PartNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_PartNumber.Location = New System.Drawing.Point(2, 11)
        Me.RadLabel_PartNumber.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_PartNumber.Name = "RadLabel_PartNumber"
        Me.RadLabel_PartNumber.Size = New System.Drawing.Size(128, 27)
        Me.RadLabel_PartNumber.TabIndex = 100
        Me.RadLabel_PartNumber.Text = "Global_PartNumber"
        Me.RadLabel_PartNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel_Container
        '
        Me.Panel_Container.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Container.Controls.Add(Me.ListBox_Users)
        Me.Panel_Container.Controls.Add(Me.RadLabel_PartNumber)
        Me.Panel_Container.Controls.Add(Me.RadTextBox_NoOfDesigns)
        Me.Panel_Container.Controls.Add(Me.RadButton_ReserveName)
        Me.Panel_Container.Controls.Add(Me.RadLabel_NoOfDesigns)
        Me.Panel_Container.Controls.Add(Me.RadTextBox_PartNumber)
        Me.Panel_Container.Controls.Add(Me.RadTextBox_ID)
        Me.Panel_Container.Controls.Add(Me.RadLabel_ID)
        Me.Panel_Container.Controls.Add(Me.RadLabel_UsersMessage)
        Me.Panel_Container.Location = New System.Drawing.Point(5, 5)
        Me.Panel_Container.Name = "Panel_Container"
        Me.Panel_Container.Size = New System.Drawing.Size(345, 232)
        Me.Panel_Container.TabIndex = 106
        '
        'ListBox_Users
        '
        Me.ListBox_Users.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ListBox_Users.ForeColor = System.Drawing.Color.Red
        Me.ListBox_Users.FormattingEnabled = True
        Me.ListBox_Users.ItemHeight = 21
        Me.ListBox_Users.Items.AddRange(New Object() {"Unbound"})
        Me.ListBox_Users.Location = New System.Drawing.Point(10, 132)
        Me.ListBox_Users.MinimumSize = New System.Drawing.Size(266, 85)
        Me.ListBox_Users.Name = "ListBox_Users"
        Me.ListBox_Users.Size = New System.Drawing.Size(266, 88)
        Me.ListBox_Users.TabIndex = 106
        Me.ListBox_Users.Visible = False
        '
        'RadLabel_UsersMessage
        '
        Me.RadLabel_UsersMessage.AutoSize = False
        Me.RadLabel_UsersMessage.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadLabel_UsersMessage.ForeColor = System.Drawing.Color.Red
        Me.RadLabel_UsersMessage.Location = New System.Drawing.Point(10, 112)
        Me.RadLabel_UsersMessage.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_UsersMessage.Name = "RadLabel_UsersMessage"
        Me.RadLabel_UsersMessage.Size = New System.Drawing.Size(266, 20)
        Me.RadLabel_UsersMessage.TabIndex = 107
        Me.RadLabel_UsersMessage.Text = "The following users also have a copy of this design"
        Me.RadLabel_UsersMessage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_UsersMessage.Visible = False
        '
        'ScratchTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(355, 242)
        Me.Controls.Add(Me.Panel_Container)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ScratchTransfer"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScratchTransfer_Title"
        Me.ThemeName = "Windows8"
        CType(Me.RadButton_ReserveName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_NoOfDesigns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_NoOfDesigns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_PartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Container.ResumeLayout(False)
        Me.Panel_Container.PerformLayout()
        CType(Me.RadLabel_UsersMessage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadButton_ReserveName As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadTextBox_NoOfDesigns As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_NoOfDesigns As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_ID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_ID As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_PartNumber As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_PartNumber As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel_Container As System.Windows.Forms.Panel
    Friend WithEvents ListBox_Users As System.Windows.Forms.ListBox
    Friend WithEvents RadLabel_UsersMessage As Telerik.WinControls.UI.RadLabel
End Class

