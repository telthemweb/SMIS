Module LogIn
    'Username TextBox
    Sub UsernamrMouseEnter()
        If LoginForm.txtUser.Text = "Enter Username" Then
            LoginForm.txtUser.Text = ""
            LoginForm.txtUser.ForeColor = Color.Black
        End If
    End Sub
    Sub UsernameMouseLeave()
        If LoginForm.txtUser.Text = "" Then
            LoginForm.txtUser.Text = "Enter Username"
            LoginForm.txtUser.ForeColor = Color.Gray
        End If
    End Sub
    'Password TextBox
    Sub UserpassMouseEnter()
        If LoginForm.txtPass.Text = "Enter Password" Then
            LoginForm.txtPass.Text = ""
            LoginForm.txtPass.PasswordChar = "*"
            LoginForm.txtPass.ForeColor = Color.Black
        End If
    End Sub

    Sub UserpassMouseLeave()
        If LoginForm.txtPass.Text = "" Then
            LoginForm.txtPass.Text = "Enter Password"
            LoginForm.txtPass.ForeColor = Color.Gray
        End If
    End Sub

    'Sign in now
    Sub SignIn()
        If LoginForm.txtUser.Text = "" Then
            MsgBox("Username is required", MsgBoxStyle.Critical)

        ElseIf LoginForm.txtPass.Text = "" Then
            MsgBox("Password is required", MsgBoxStyle.Critical)

        Else
            sql = "SELECT * FROM `user` WHERE `username`='" & LoginForm.txtUser.Text & "' AND `password`='" & LoginForm.txtPass.Text & "' "
            findthis(sql)

            If GetNumRows() = 1 Then
                LoadSingleResult("login")
                MsgBox("Welcome to Student Infomation")
                LoginForm.txtPass.Text = ""
                LoginForm.txtUser.Text = ""
            Else
                MsgBox("Username or Passwrord is not correct, Please try again!!", MsgBoxStyle.Critical)
                LoginForm.txtPass.Text = ""
                LoginForm.txtUser.Text = ""
            End If

        End If
    End Sub
End Module
