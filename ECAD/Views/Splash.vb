Public NotInheritable Class Splash

    Private Sub Splash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Setup splash screen size
        Me.Width = 590
        Me.Height = 528

        ' Center
        Dim r As Rectangle = Screen.FromPoint(Me.Location).WorkingArea

        Dim x = r.Left + (r.Width - Me.Width) \ 2
        Dim y = r.Top + (r.Height - Me.Height) \ 2
        Me.Location = New Point(x, y)

        ' Set timer
        Timer.Interval = 1000
        Timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Timer.Stop()
        Home.Show()
        Me.Close()
    End Sub
End Class
