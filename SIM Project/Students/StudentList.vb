Public Class StudentList
    Private Sub StudentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'location(X=250, Y=114)
        LoadAllStudents()
        Me.ActiveControl = Panel1
        'total===================
        showTotalStudent()
        'total female students===================
        showTotalFemaleStudent()

        'total female students===================
        showTotalMaleStudent()
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        If txtSearch.Text = "Use StudentId to search" Then
            txtSearch.Text = ""
        End If
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If txtSearch.Text = "" Then
            txtSearch.Text = "Use StudentId to search"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Home.MenuBarMid.Show()
        Me.Hide()
    End Sub

    Private Sub StudentGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentGridView.CellClick
        FillStudentTextBox()
    End Sub

    Private Sub btnUpdat_Click(sender As Object, e As EventArgs) Handles btnUpdat.Click
        UpdateStudent()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClearBox()
    End Sub

    Private Sub cmbFilterClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterClass.SelectedIndexChanged
        FilterClassess()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DeleteStudent()
    End Sub

    Private Sub avatar_Click(sender As Object, e As EventArgs) Handles avatar.Click
        SearchStudent()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Panel11.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'refresh
        LoadAllStudents()
    End Sub

    Private Sub StudentGridView_DoubleClick(sender As Object, e As EventArgs) Handles StudentGridView.DoubleClick
        DoubleFillStudentTextBox()
    End Sub
End Class