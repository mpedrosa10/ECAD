<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RenameOrCopyScratch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RenameOrCopyScratch))
        Me.RadButton_Cancel = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Rename = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Copy = New Telerik.WinControls.UI.RadButton()
        Me.Panel_Message = New System.Windows.Forms.Panel()
        Me.RadLabel_Message = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_id = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_id = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_newname = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_newname = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadButton_Cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Rename, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Copy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Message.SuspendLayout()
        CType(Me.RadLabel_Message, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_newname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_newname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadButton_Cancel
        '
        Me.RadButton_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_Cancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Cancel.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Cancel.Location = New System.Drawing.Point(268, 85)
        Me.RadButton_Cancel.Name = "RadButton_Cancel"
        Me.RadButton_Cancel.Size = New System.Drawing.Size(122, 32)
        Me.RadButton_Cancel.TabIndex = 13
        Me.RadButton_Cancel.Text = "Global_Cancel"
        Me.RadButton_Cancel.TextWrap = True
        '
        'RadButton_Rename
        '
        Me.RadButton_Rename.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_Rename.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Rename.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Rename.Location = New System.Drawing.Point(140, 85)
        Me.RadButton_Rename.Name = "RadButton_Rename"
        Me.RadButton_Rename.Size = New System.Drawing.Size(122, 32)
        Me.RadButton_Rename.TabIndex = 14
        Me.RadButton_Rename.Text = "Global_Rename"
        Me.RadButton_Rename.TextWrap = True
        '
        'RadButton_Copy
        '
        Me.RadButton_Copy.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadButton_Copy.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_Copy.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Copy.Location = New System.Drawing.Point(12, 85)
        Me.RadButton_Copy.Name = "RadButton_Copy"
        Me.RadButton_Copy.Size = New System.Drawing.Size(122, 32)
        Me.RadButton_Copy.TabIndex = 14
        Me.RadButton_Copy.Text = "Global_Copy"
        Me.RadButton_Copy.TextWrap = True
        '
        'Panel_Message
        '
        Me.Panel_Message.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Message.Controls.Add(Me.RadLabel_Message)
        Me.Panel_Message.Location = New System.Drawing.Point(12, 12)
        Me.Panel_Message.Name = "Panel_Message"
        Me.Panel_Message.Size = New System.Drawing.Size(378, 62)
        Me.Panel_Message.TabIndex = 15
        '
        'RadLabel_Message
        '
        Me.RadLabel_Message.AutoSize = False
        Me.RadLabel_Message.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Message.Location = New System.Drawing.Point(2, 3)
        Me.RadLabel_Message.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_Message.Name = "RadLabel_Message"
        Me.RadLabel_Message.Size = New System.Drawing.Size(370, 52)
        Me.RadLabel_Message.TabIndex = 103
        Me.RadLabel_Message.Text = "Unbound"
        Me.RadLabel_Message.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadTextBox_id
        '
        Me.RadTextBox_id.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_id.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_id.Location = New System.Drawing.Point(245, 107)
        Me.RadTextBox_id.Name = "RadTextBox_id"
        Me.RadTextBox_id.Size = New System.Drawing.Size(60, 20)
        Me.RadTextBox_id.TabIndex = 112
        Me.RadTextBox_id.Text = "=[Forms]![rename scratch form]![txtid]"
        Me.RadTextBox_id.Visible = False
        '
        'RadLabel_id
        '
        Me.RadLabel_id.AutoSize = False
        Me.RadLabel_id.BackColor = System.Drawing.Color.White
        Me.RadLabel_id.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadLabel_id.Location = New System.Drawing.Point(200, 111)
        Me.RadLabel_id.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_id.Name = "RadLabel_id"
        Me.RadLabel_id.Size = New System.Drawing.Size(45, 15)
        Me.RadLabel_id.TabIndex = 111
        Me.RadLabel_id.Text = "id:"
        Me.RadLabel_id.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_id.Visible = False
        '
        'RadTextBox_newname
        '
        Me.RadTextBox_newname.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_newname.ForeColor = System.Drawing.Color.Black
        Me.RadTextBox_newname.Location = New System.Drawing.Point(133, 107)
        Me.RadTextBox_newname.Name = "RadTextBox_newname"
        Me.RadTextBox_newname.Size = New System.Drawing.Size(65, 20)
        Me.RadTextBox_newname.TabIndex = 110
        Me.RadTextBox_newname.Text = "=[Forms]![rename scratch form]![txtnewname]"
        Me.RadTextBox_newname.Visible = False
        '
        'RadLabel_newname
        '
        Me.RadLabel_newname.AutoSize = False
        Me.RadLabel_newname.BackColor = System.Drawing.Color.White
        Me.RadLabel_newname.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadLabel_newname.Location = New System.Drawing.Point(73, 110)
        Me.RadLabel_newname.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel_newname.Name = "RadLabel_newname"
        Me.RadLabel_newname.Size = New System.Drawing.Size(60, 15)
        Me.RadLabel_newname.TabIndex = 109
        Me.RadLabel_newname.Text = "new name:"
        Me.RadLabel_newname.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_newname.Visible = False
        '
        'RenameOrCopyScratch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(402, 129)
        Me.Controls.Add(Me.Panel_Message)
        Me.Controls.Add(Me.RadButton_Copy)
        Me.Controls.Add(Me.RadButton_Rename)
        Me.Controls.Add(Me.RadButton_Cancel)
        Me.Controls.Add(Me.RadTextBox_id)
        Me.Controls.Add(Me.RadLabel_id)
        Me.Controls.Add(Me.RadTextBox_newname)
        Me.Controls.Add(Me.RadLabel_newname)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RenameOrCopyScratch"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RenCopyScratch_Title"
        Me.ThemeName = "Windows8"
        CType(Me.RadButton_Cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Rename, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Copy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Message.ResumeLayout(False)
        CType(Me.RadLabel_Message, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_newname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_newname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadButton_Cancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Rename As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Copy As Telerik.WinControls.UI.RadButton
    Friend WithEvents Panel_Message As System.Windows.Forms.Panel
    Friend WithEvents RadLabel_Message As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_id As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_id As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_newname As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_newname As Telerik.WinControls.UI.RadLabel
End Class

