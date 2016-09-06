Imports Telerik.WinControls

Namespace Helpers

    Public Class GeneralFunctions

#Region "OpenForm"
        Public Shared Sub OpenForm(ByRef form As Telerik.WinControls.UI.RadForm)
            If form.Visible = True Then
                form.Focus()
            Else
                form.Show()
            End If
        End Sub
#End Region

    End Class

End Namespace