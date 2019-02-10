Public Class Student_Profile
    Dim crrYera = DateTime.Now.ToString(“yyyy”)
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        StudentList.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        StudentList.Show()
        Me.Hide()
    End Sub

    Private Sub Student_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAcady.Text = crrYera
    End Sub
End Class