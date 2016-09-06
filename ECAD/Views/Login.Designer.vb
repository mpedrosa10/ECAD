Imports Telerik.WinControls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits Telerik.WinControls.UI.RadForm

    Public Sub New()
        Me.Visible = False
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.RadTextBox_User = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_User = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Pass = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Pass = New Telerik.WinControls.UI.RadTextBox()
        Me.RadButton_OK = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Cancel = New Telerik.WinControls.UI.RadButton()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        CType(Me.RadTextBox_User, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_User, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Pass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Pass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_OK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadTextBox_User
        '
        Me.RadTextBox_User.Location = New System.Drawing.Point(12, 36)
        Me.RadTextBox_User.Name = "RadTextBox_User"
        Me.RadTextBox_User.Size = New System.Drawing.Size(200, 20)
        Me.RadTextBox_User.TabIndex = 0
        '
        'RadLabel_User
        '
        Me.RadLabel_User.Location = New System.Drawing.Point(12, 12)
        Me.RadLabel_User.Name = "RadLabel_User"
        Me.RadLabel_User.Size = New System.Drawing.Size(69, 18)
        Me.RadLabel_User.TabIndex = 1
        Me.RadLabel_User.Text = "Login_Name"
        '
        'RadLabel_Pass
        '
        Me.RadLabel_Pass.Location = New System.Drawing.Point(12, 62)
        Me.RadLabel_Pass.Name = "RadLabel_Pass"
        Me.RadLabel_Pass.Size = New System.Drawing.Size(86, 18)
        Me.RadLabel_Pass.TabIndex = 3
        Me.RadLabel_Pass.Text = "Login_Password"
        '
        'RadTextBox_Pass
        '
        Me.RadTextBox_Pass.Location = New System.Drawing.Point(12, 86)
        Me.RadTextBox_Pass.Name = "RadTextBox_Pass"
        Me.RadTextBox_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.RadTextBox_Pass.Size = New System.Drawing.Size(200, 20)
        Me.RadTextBox_Pass.TabIndex = 2
        Me.RadTextBox_Pass.UseSystemPasswordChar = True
        '
        'RadButton_OK
        '
        Me.RadButton_OK.Location = New System.Drawing.Point(219, 56)
        Me.RadButton_OK.Name = "RadButton_OK"
        Me.RadButton_OK.Size = New System.Drawing.Size(110, 24)
        Me.RadButton_OK.TabIndex = 4
        Me.RadButton_OK.Text = "Global_OK"
        '
        'RadButton_Cancel
        '
        Me.RadButton_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.RadButton_Cancel.Location = New System.Drawing.Point(219, 82)
        Me.RadButton_Cancel.Name = "RadButton_Cancel"
        Me.RadButton_Cancel.Size = New System.Drawing.Size(110, 24)
        Me.RadButton_Cancel.TabIndex = 5
        Me.RadButton_Cancel.Text = "Global_Cancel"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 114)
        Me.Controls.Add(Me.RadButton_Cancel)
        Me.Controls.Add(Me.RadButton_OK)
        Me.Controls.Add(Me.RadLabel_User)
        Me.Controls.Add(Me.RadLabel_Pass)
        Me.Controls.Add(Me.RadTextBox_User)
        Me.Controls.Add(Me.RadTextBox_Pass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Login"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login_Title"
        Me.ThemeName = "Windows8"
        CType(Me.RadTextBox_User, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_User, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Pass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Pass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_OK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadTextBox_User As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_User As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Pass As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Pass As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadButton_Cancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_OK As Telerik.WinControls.UI.RadButton
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
End Class

