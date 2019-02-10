Public Class SplashScreen
    Dim timeof As DateTime = TimeOfDay
    Dim crrYera = DateTime.Now.ToString(“yyyy”)
    Dim tims = DateTime.Now.ToString(“s”)
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCurrentYear.Text = "(c)" + crrYera

        splashTimer.Enabled = True
        lblWait.Visible = True
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles splashTimer.Tick
        ProgressLoader.Increment(+1)
        If ProgressLoader.Value = 100 Then
            splashTimer.Stop()
            LoginForm.Show()
            Me.Hide()
        End If
    End Sub
End Class