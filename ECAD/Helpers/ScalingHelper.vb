Imports Telerik.WinControls

Namespace Helpers

    Public Class ScalingHelper


#Region "PrepareTableLayout"
        ' Set columns and rows size from absolute to percentage for scaling purposes
        Public Shared Sub PrepareTableLayout(ByRef controls As System.Windows.Forms.Control.ControlCollection)
            For Each c As Control In controls
                PrepareComponentsForScale(c)
            Next
        End Sub

        Private Shared Sub PrepareComponentsForScale(ByRef c As Control)
            If TypeOf c Is TableLayoutPanel Then
                Dim ct As TableLayoutPanel = c
                Dim tableWidth As Integer = ct.Width
                Dim tableHeight As Integer = ct.Height

                ' Columns
                For Each style As ColumnStyle In ct.ColumnStyles
                    If style.SizeType = SizeType.Absolute Then
                        Dim abs As Integer = style.Width
                        style.SizeType = SizeType.Percent
                        style.Width = abs * 100 / tableWidth
                    End If
                Next

                ' Rows
                For Each style As RowStyle In ct.RowStyles
                    If style.SizeType = SizeType.Absolute Then
                        Dim abs As Integer = style.Height
                        style.SizeType = SizeType.Percent
                        style.Height = abs * 100 / tableHeight
                    End If
                Next
            End If

            For Each child As Control In c.Controls
                PrepareComponentsForScale(child)
            Next
        End Sub
#End Region

    End Class

End Namespace