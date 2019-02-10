Public Class Gross_Fees_Paid
    Private Sub Gross_Fees_Paid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFees()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DashBoard.Show()
        Home.PanelHide.Visible = False
        Me.Hide()
    End Sub
End Class