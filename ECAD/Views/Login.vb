Imports ActiveDirectoryLibrary
Imports Telerik.WinControls


Public Class Login

    ' Attempt to authenticate with current windows user
    Private Sub Login_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim usr As String = Environment.UserDomainName + "\" + Environment.UserName
        If AD.TryLogin(usr) Then
            LogIn()
        Else
            Me.Visible = True
        End If
    End Sub

    ' Login OK button, attempt to login with user and password in textboxes
    Private Sub RadButton_OK_Click(sender As Object, e As EventArgs) Handles RadButton_OK.Click
        Cursor = Cursors.WaitCursor
        Dim loginResult As Boolean = AD.TryLogin(Me.RadTextBox_User.Text, Me.RadTextBox_Pass.Text)
        Cursor = Cursors.Default

        If (loginResult = False) Then
            RadMessageBox.ThemeName = Windows8Theme1.ThemeName
            RadMessageBox.Show(Me, Helpers.LocalizationHelper.GetLocalizedString("Login_Error"), Helpers.LocalizationHelper.GetLocalizedString("Global_Error"), MessageBoxButtons.OK, RadMessageIcon.Error)
        Else
            LogIn()
        End If
    End Sub

    ' Login successful, open home form
    Private Sub LogIn()
        Me.RadTextBox_User.Text = ""
        Me.RadTextBox_Pass.Text = ""
        Me.Hide()
        Splash.Show()
    End Sub

    ' Cancel login, exit app
    Private Sub RadButton_Cancel_Click(sender As Object, e As EventArgs) Handles RadButton_Cancel.Click
        Me.Close()
    End Sub

    ' Pressing Enter on User textbox moves cursor to password
    Private Sub RadTextBox_User_KeyDown(sender As Object, e As KeyEventArgs) Handles RadTextBox_User.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Me.RadTextBox_Pass.Focus()
        End If
    End Sub

    ' Pressing Enter on Password textbox attempts login
    Private Sub RadTextBox_Pass_KeyDown(sender As Object, e As KeyEventArgs) Handles RadTextBox_Pass.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Me.RadButton_OK.Focus()
            Me.RadButton_OK.PerformClick()
        End If
    End Sub
End Class
