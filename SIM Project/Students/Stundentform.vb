Public Class Stundentform
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Home.MenuBarMid.Show()
    End Sub
    'form load is here
    Private Sub Stundentform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'form load is here
        GenerateNumber()
    End Sub
    'TextBox Placeholders


    Private Sub txtSurname_MouseLeave(sender As Object, e As EventArgs) Handles txtSurname.MouseLeave
        SurnameMouseLeave()
    End Sub

    Private Sub txtFname_MouseLeave(sender As Object, e As EventArgs) Handles txtFname.MouseLeave
        NameMouseLeave()
    End Sub

    Private Sub txtNational_MouseLeave(sender As Object, e As EventArgs) Handles txtNational.MouseLeave
        NationalityMouseLeave()
    End Sub

    Private Sub txtGuid_MouseLeave(sender As Object, e As EventArgs) Handles txtGuid.MouseLeave
        GuidenceMouseLeave()
    End Sub

    Private Sub txtPhone_MouseLeave(sender As Object, e As EventArgs) Handles txtPhone.MouseLeave
        PhoneNumberMouseLeave()
    End Sub
    'end TextBox Placeholders

    'Validate TextBox
    Private Sub txtSurname_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSurname.KeyUp
        If Char.IsNumber(ChrW(e.KeyCode)) Then
            MsgBox("Please only letters for Surname", MsgBoxStyle.Critical)
            txtSurname.Text = ""
        End If
    End Sub

    Private Sub txtFname_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFname.KeyUp
        If Char.IsNumber(ChrW(e.KeyCode)) Then
            MsgBox("Please only letters for Name", MsgBoxStyle.Critical)
            txtFname.Text = ""
        End If
    End Sub

    Private Sub txtNational_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNational.KeyUp
        If Char.IsNumber(ChrW(e.KeyCode)) Then
            MsgBox("Please only letters are needed for Nationality", MsgBoxStyle.Critical)
            txtNational.Text = ""
        End If
    End Sub

    Private Sub txtGuid_KeyUp(sender As Object, e As KeyEventArgs) Handles txtGuid.KeyUp
        If Char.IsNumber(ChrW(e.KeyCode)) Then
            MsgBox("Please only letters are needed for Guidance", MsgBoxStyle.Critical)
            txtGuid.Text = ""
        End If
    End Sub

    Private Sub txtPhone_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPhone.KeyUp
        If Not Char.IsNumber(ChrW(e.KeyCode)) Then
            MsgBox("Please only numbers are allowed her 0123456789", MsgBoxStyle.Critical)
            txtPhone.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CreateAccount()
    End Sub

    Private Sub txtSurname_Click(sender As Object, e As EventArgs) Handles txtSurname.Click
        SurnameMouseEnter()
    End Sub

    Private Sub txtFname_Click(sender As Object, e As EventArgs) Handles txtFname.Click
        NameMouseEnter()
    End Sub

    Private Sub txtNational_Click(sender As Object, e As EventArgs) Handles txtNational.Click
        NationalityMouseEnter()
    End Sub

    Private Sub txtGuid_Click(sender As Object, e As EventArgs) Handles txtGuid.Click
        GuidenceMouseEnter()
    End Sub

    Private Sub txtPhone_Click(sender As Object, e As EventArgs) Handles txtPhone.Click
        PhoneNumberMouseEnter()
    End Sub
End Class