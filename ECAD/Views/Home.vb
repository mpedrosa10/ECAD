Imports ActiveDirectoryLibrary
Imports ECAD.Helpers.LocalizationHelper
Imports Telerik.WinControls

Public Class Home

#Region "Close / Logout"
    Private LoggingOut As Boolean

    Private Sub Home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' If not just logging out, ask for confirmation
        If LoggingOut = False Then
            RadMessageBox.ThemeName = Windows8Theme1.ThemeName
            Dim confirm As DialogResult = RadMessageBox.Show(Me, GetLocalizedString("Home_Quit"), GetLocalizedString("Home_Quit_Title"), MessageBoxButtons.YesNo, RadMessageIcon.Question)

            If (confirm <> DialogResult.Yes) Then
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub Home_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Don't exit if just logging out
        If LoggingOut = False Then
            Application.Exit()
        End If
    End Sub

    Private Sub RadButton_LogOut_Click(sender As Object, e As EventArgs) Handles RadButton_LogOut.Click
        AD.Logout()
        LoggingOut = True
        Login.Show()
        Me.Close()
    End Sub
#End Region

#Region "TabControl_Menu"
    Private Sub TabControl_Menu_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TabControl_Menu.DrawItem
        Dim g As Graphics = e.Graphics
        Dim _TextBrush As Brush

        ' Get the item from the collection.
        Dim _TabPage As TabPage = TabControl_Menu.TabPages(e.Index)

        ' Get the real bounds for the tab rectangle.
        Dim _TabBounds As Rectangle = TabControl_Menu.GetTabRect(e.Index)


        _TextBrush = New SolidBrush(Color.Black)

        If (e.State = DrawItemState.Selected) Then
            ' Draw a different background color, and don't paint a focus rectangle.
            g.FillRectangle(Brushes.WhiteSmoke, e.Bounds)
        Else
            g.FillRectangle(New SolidBrush(Color.FromArgb(224, 224, 224)), e.Bounds)
        End If

        ' Use our own font.
        Dim _TabFont As Font = e.Font

        ' Draw string. Center the text.
        Dim _StringFlags As New StringFormat()
        _StringFlags.Alignment = StringAlignment.Center
        _StringFlags.LineAlignment = StringAlignment.Center
        g.DrawString(_TabPage.Text, _TabFont, _TextBrush, _TabBounds, New StringFormat(_StringFlags))
    End Sub
#End Region

#Region "RadButton_ScratchPad"
    Private Sub RadButton_ScratchPad_Click(sender As Object, e As EventArgs) Handles RadButton_ScratchPad.Click
        Helpers.GeneralFunctions.OpenForm(ScratchPad)
    End Sub

    Private Sub RadButton_ScratchPad2_Click(sender As Object, e As EventArgs) Handles RadButton_ScratchPad2.Click
        RadButton_ScratchPad_Click(sender, e)
    End Sub
#End Region

#Region "RadButton_Customers"
    Private Sub RadButton_Customers_Click(sender As Object, e As EventArgs) Handles RadButton_Customers.Click
        Helpers.GeneralFunctions.OpenForm(CustomersData)
    End Sub
    Private Sub RadButton_Customers2_Click(sender As Object, e As EventArgs) Handles RadButton_Customers2.Click
        Helpers.GeneralFunctions.OpenForm(CustomersData)
    End Sub
#End Region

#Region "RadButton_DesignSummary"
    Private Sub RadButton_DesignSummary_Click(sender As Object, e As EventArgs) Handles RadButton_DesignSummary.Click
        Helpers.GeneralFunctions.OpenForm(DesignSummary)
    End Sub
#End Region

    'DEBUG
    Private Sub RadButton_DEBUGFORM_Click(sender As Object, e As EventArgs) Handles RadButton_DEBUGFORM.Click
        For Each frm In debugforms
            If frm.Text = Me.RadDropDownList_DEBUGFORM.SelectedValue Then
                Helpers.GeneralFunctions.OpenForm(frm)
            End If
        Next
    End Sub
    '/DEBUG
End Class