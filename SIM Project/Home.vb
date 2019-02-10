Public Class Home
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Application.Exit()
    End Sub

    Private Sub button3_MouseHover(sender As Object, e As EventArgs) Handles button3.MouseHover
        Panel4Menua11.Visible = True
        PanelLogout.Visible = False
    End Sub

    Private Sub avatar_MouseHover(sender As Object, e As EventArgs) Handles avatar.MouseHover
        PanelLogout.Visible = True
        Panel4Menua11.Visible = False

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' load Panel4Menua11
        PanelLogout.Visible = False
        Panel4Menua11.Visible = False
        MenuBarMid.Show()
        'close other tabs
        Stundentform.Hide()
        StudentList.Hide()
        DashBoard.Hide()
        Student_Profile.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'ad
        DashBoard.Show()
        DashBoard.Location = New System.Drawing.Point(275, 114)
        ' Close other tabs
        MenuBarMid.Hide()
        StudentList.Hide()
        Stundentform.Hide()
        PanelLogout.Visible = False
        Panel4Menua11.Visible = False
        Student_Profile.Hide()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' load student register
        PanelLogout.Visible = False
        Panel4Menua11.Visible = False
        Stundentform.Show()
        Stundentform.Location = New System.Drawing.Point(433, 122)
        ' Close other tabs
        MenuBarMid.Hide()
        StudentList.Hide()
        DashBoard.Hide()
        Student_Profile.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PanelLogout.Visible = False
        Panel4Menua11.Visible = False
        DashBoard.Hide()
        Student_Profile.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        PanelLogout.Visible = False
        Panel4Menua11.Visible = False
        Student_Profile.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Gallery.Show()
        Me.Hide()
        PanelLogout.Visible = False
        Panel4Menua11.Visible = False
    End Sub
    Private Sub Button9_MouseHover(sender As Object, e As EventArgs) Handles Button9.MouseHover
        Panel4Menua11.Visible = False
        PanelLogout.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StudentList.Show()
        StudentList.Location = New System.Drawing.Point(275, 114)
        ' Close other tabs
        MenuBarMid.Hide()
        Stundentform.Hide()
        DashBoard.Hide()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Application.Exit()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btnADm.Click
        DashBoard.Show()
        DashBoard.Location = New System.Drawing.Point(275, 114)
        ' Close other tabs
        MenuBarMid.Hide()
        StudentList.Hide()
        Stundentform.Hide()
        PanelLogout.Visible = False
        Panel4Menua11.Visible = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub
End Class
