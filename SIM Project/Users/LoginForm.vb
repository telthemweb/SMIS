Public Class LoginForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SignIn()
    End Sub



    Private Sub txtUser_MouseLeave(sender As Object, e As EventArgs)
        UsernameMouseLeave()
    End Sub

    Private Sub txtPass_MouseLeave(sender As Object, e As EventArgs)
        UserpassMouseLeave()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = GroupBox1
    End Sub

    Private Sub txtUser_Click(sender As Object, e As EventArgs) Handles txtUser.Click
        UsernamrMouseEnter()
    End Sub

    Private Sub txtPass_Click(sender As Object, e As EventArgs) Handles txtPass.Click
        UserpassMouseEnter()
    End Sub
End Class