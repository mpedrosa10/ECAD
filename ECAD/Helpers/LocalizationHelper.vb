Imports Telerik.WinControls

Namespace Helpers

    Public Class LocalizationHelper

#Region "LocalizeForm"
        ' Localize Form title and text components
        Public Shared Sub LocalizeForm(ByRef form As Telerik.WinControls.UI.RadForm)

            Form.Text = GetLocalizedString(Form.Text)

            For Each item As Control In Form.Controls()
                LocalizeControl(item)
            Next

        End Sub

        Private Shared Sub LocalizeControl(ByRef item As Control)
            If item.GetType() Is GetType(Telerik.WinControls.UI.RadGridView) Then
                LocalizeRadGridView(item)
            Else
                If item.Text <> "" Then
                    'item.Text = GetLocalizedString(item.Text)

                    Dim localized As String = GetLocalizedString(item.Text)
                    If localized <> "" Then
                        item.Text = localized
                    End If
                End If
                For Each child As Control In item.Controls
                    LocalizeControl(child)
                Next
            End If
        End Sub

        ' Localize RadGridView column headers
        Private Shared Sub LocalizeRadGridView(ByRef grid As Telerik.WinControls.UI.RadGridView)
            For Each col In grid.Columns
                If col.HeaderText <> "" Then
                    'item.Text = GetLocalizedString(item.Text)

                    Dim localized As String = GetLocalizedString(col.HeaderText)
                    If localized <> "" Then
                        col.HeaderText = localized
                    End If
                End If
            Next
        End Sub
#End Region

#Region "GetLocalizedString"
        ' Return localized string based on resource name
        Public Shared Function GetLocalizedString(ByVal text As String) As String
            Return My.Resources.ECADFormStrings.ResourceManager.GetString(text)
        End Function
#End Region

#Region "SetLocalizationCulture"
        ' Set culture to code defined on settings or to defined by OS
        Public Shared Sub SetLocalizationCulture()
            Dim TwoLetterLangName As String = My.Settings.ForcedLocale
            If (TwoLetterLangName = "" Or TwoLetterLangName.Length <> 2) Then
                TwoLetterLangName = Threading.Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName
            End If

            Threading.Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo(TwoLetterLangName)
            Threading.Thread.CurrentThread.CurrentUICulture = Threading.Thread.CurrentThread.CurrentCulture
        End Sub
#End Region


#Region "RadMessage Localization Provider"
        ' Custom localization provider to translate messagebox buttons text
        Public Class ECADRadMessageLocalizationProvider
            Inherits RadMessageLocalizationProvider
            Public Overloads Overrides Function GetLocalizedString(ByVal id As String) As String
                Select Case id
                    Case RadMessageStringID.AbortButton
                        Return LocalizationHelper.GetLocalizedString("Global_Abort")

                    Case RadMessageStringID.CancelButton
                        Return LocalizationHelper.GetLocalizedString("Global_Cancel")

                    Case RadMessageStringID.IgnoreButton
                        Return LocalizationHelper.GetLocalizedString("Global_Ignore")

                    Case RadMessageStringID.NoButton
                        Return LocalizationHelper.GetLocalizedString("Global_No")

                    Case RadMessageStringID.OKButton
                        Return LocalizationHelper.GetLocalizedString("Global_OK")

                    Case RadMessageStringID.RetryButton
                        Return LocalizationHelper.GetLocalizedString("Global_Retry")

                    Case RadMessageStringID.YesButton
                        Return LocalizationHelper.GetLocalizedString("Global_Yes")

                    Case Else
                        Return MyBase.GetLocalizedString(id)
                End Select
            End Function
        End Class
#End Region

    End Class

End Namespace
