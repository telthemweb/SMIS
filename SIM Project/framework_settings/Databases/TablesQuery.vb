Imports MySql.Data.MySqlClient
Module TablesQuery
    Public Sub findthis(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            con.Close()
            da.Dispose()
        End Try
        con.Close()
    End Sub
    Public Sub LoadSingleResult(ByVal param As String)
        Try
            con.Open()
            dReader = cmd.ExecuteReader()
            Select Case param

                Case "login"
                    Do While dReader.Read = True

                        ACCOUNT_NAME = dReader("name") & " " & dReader("surname")
                        ACCOUNT_USERNAME = dReader("username")
                        ACCOUNT_TYPE = dReader("user_role")

                        If ACCOUNT_TYPE = "Administrator" Then
                            Home.btnLogout.Text = ACCOUNT_NAME
                            Home.Show()
                            LoginForm.Hide()

                        ElseIf ACCOUNT_TYPE = "Teacher" Then

                        ElseIf ACCOUNT_TYPE = "Accounts" Then

                        ElseIf ACCOUNT_TYPE = "Student" Then

                        Else
                            MsgBox("Please contact the IT Department for Account Activation", MsgBoxStyle.Exclamation)
                        End If
                    Loop
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            con.Close()
            da.Dispose()
        End Try
        con.Close()
    End Sub
End Module
