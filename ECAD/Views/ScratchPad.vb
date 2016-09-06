Public Class ScratchPad

    Private Sub RadCheckBox_DisplayCosts_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles RadCheckBox_DisplayCosts.ToggleStateChanged
        HandleCostsVisibility()
    End Sub
End Class
