Public Class DashBoard
    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        If txtSearch.Text = "Search here...." Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If txtSearch.Text = "" Then
            txtSearch.Text = "Search here...."
            txtSearch.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtReg_Click(sender As Object, e As EventArgs) Handles txtReg.Click
        If txtReg.Text = "Student ID" Then
            txtReg.Text = ""
            txtReg.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtReg_Leave(sender As Object, e As EventArgs) Handles txtReg.Leave
        If txtReg.Text = "" Then
            txtReg.Text = "Student ID"
            txtReg.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtName_Click(sender As Object, e As EventArgs) Handles txtName.Click
        If txtName.Text = "Name" Then
            txtName.Text = ""
            txtName.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtName_Leave(sender As Object, e As EventArgs) Handles txtName.Leave
        If txtName.Text = "" Then
            txtName.Text = "Name"
            txtName.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtSurname_Click(sender As Object, e As EventArgs) Handles txtSurname.Click
        If txtSurname.Text = "Surname" Then
            txtSurname.Text = ""
            txtSurname.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtSurname_Leave(sender As Object, e As EventArgs) Handles txtSurname.Leave
        If txtSurname.Text = "" Then
            txtSurname.Text = "Surname"
            txtSurname.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtRecept_Click(sender As Object, e As EventArgs) Handles txtRecept.Click
        If txtRecept.Text = "Receipt Number" Then
            txtRecept.Text = ""
            txtRecept.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtRecept_Leave(sender As Object, e As EventArgs) Handles txtRecept.Leave
        If txtRecept.Text = "" Then
            txtRecept.Text = "Receipt Number"
            txtRecept.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtAmt_Click(sender As Object, e As EventArgs) Handles txtAmt.Click
        If txtAmt.Text = "Fees Paid" Then
            txtAmt.Text = ""
            txtAmt.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtAmt_Leave(sender As Object, e As EventArgs) Handles txtAmt.Leave
        If txtAmt.Text = "" Then
            txtAmt.Text = "Fees Paid"
            txtAmt.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub DashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = GroupBoxInfo
        Me.ActiveControl = GroupBoxAmt
        GenerateReceipt()
    End Sub

    Private Sub txtAmt_TextChanged(sender As Object, e As EventArgs) Handles txtAmt.TextChanged
        txtBalance.Text = Val(txtfeeperTerm.Text) - Val(txtAmt.Text)
        lblChange.Text = Val(txtAmt.Text) - Val(txtfeeperTerm.Text)

        If Val(txtAmt.Text) > 120 Then
            lblAmntPaid.Text = 120
        Else
            lblAmntPaid.Text = txtAmt.Text
        End If

        If txtBalance.Text < 0 Then
            txtBalance.Text = 0.0

        End If

        If lblChange.Text < 0 Then
            lblChange.Text = 0.0
        End If


        If Val(lblAmntPaid.Text) = 120 Then
            cboStatus.Text = "YES"
        ElseIf Val(lblAmntPaid.Text) >= 40 And Val(lblAmntPaid.Text) <= 119 Then
            cboStatus.Text = "NO"
        Else

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MakePayment()
    End Sub

    Private Sub avatar_Click(sender As Object, e As EventArgs) Handles avatar.Click
        SearchStudetInfo()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Gross_Fees_Paid.Show()
        Gross_Fees_Paid.Location = New System.Drawing.Point(146, 114)
        Home.PanelHide.Visible = True
    End Sub
End Class