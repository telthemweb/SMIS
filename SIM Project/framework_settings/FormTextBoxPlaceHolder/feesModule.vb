Module feesModule
    Dim todayday As DateTime = Format("yyyy-mmm-dd", Today)
    'Generate Receipt
    Sub GenerateReceipt()
        Try
            findthis("SELECT Max(receiptNumber) From `payment_fees`  ")
            con.Open()
            Dim num As Integer = cmd.ExecuteScalar
            DashBoard.txtRecept.Text = num + 1
            If DashBoard.txtRecept.Text = "" Then
                DashBoard.txtRecept.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
    'Make payment
    Sub MakePayment()
        If DashBoard.txtAmt.Text = "" Then
            MsgBox("Please amount of fees paid is Required!", MsgBoxStyle.Critical)
        ElseIf Val(DashBoard.txtAmt.Text) <= 0 Then
            MsgBox("Your amount is below our standards, please we don't accept negative numbers", MsgBoxStyle.Critical)
        ElseIf Val(DashBoard.txtAmt.Text) < 45 Then
            MsgBox("Amount is below the minimum amount of $45.00", MsgBoxStyle.Critical)
        Else
            issucess = insert("INSERT INTO `payment_fees` (`receiptNumber`,`studentID`, `term_paid`,`date_paid`, " &
                           " `fees_paid`, `amount_left`,`Cashier`, `isFullyPaid`,`overfees`) " &
                           " VALUES ('" & DashBoard.txtRecept.Text & "','" & DashBoard.txtReg.Text & "','" & DashBoard.cboTerm.Text & "', '" & todayday & "', '" & DashBoard.txtAmt.Text & "', '" & DashBoard.txtBalance.Text & "','" & DashBoard.txtCashName.Text & "', " &
                           " '" & DashBoard.cboStatus.Text & "','" & DashBoard.lblChange.Text & "');")
            If issucess = True Then
                MsgBox("New student fees has been paid successfully", MsgBoxStyle.Information)
                'PrintReceipt()
                insert("INSERT INTO `tblbackup` (`receiptNumber`,`regNumber`, `fullName`, `term_paid`,`date_paid`, " &
                               " `fees_paid`, `amount_left`,`Cashier`, `isFullyPaid`,`overfees`) " &
                               " VALUES ('" & DashBoard.txtRecept.Text & "','" & DashBoard.txtReg.Text & "', '" & DashBoard.cboTerm.Text & "', '" & todayday & "', '" & DashBoard.txtAmt.Text & "', '" & DashBoard.txtBalance.Text & "','" & DashBoard.txtCashName.Text & "', " &
                               " '" & DashBoard.cboStatus.Text & "','" & DashBoard.lblChange.Text & "');")
            Else
                MsgBox("New student fees has not been paid successfully, Please make sure all details are correct!! ")


            End If
        End If

    End Sub
    Sub SearchStudetInfo()
        Try
            findthis("SELECT * FROM `student_details` WHERE `stid`='" & DashBoard.txtSearch.Text & "'")
            con.Open()
            dReader = cmd.ExecuteReader()
            While dReader.Read
                DashBoard.txtReg.Text = dReader("stid")
                DashBoard.txtName.Text = dReader("name")
                DashBoard.txtSurname.Text = dReader("surname")
                DashBoard.cboClass.Text = dReader("class")
            End While
            DashBoard.txtSearch.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub
    'load fees
    Sub LoadFees()
        findthis("SELECT payment_fees.id,payment_fees.receiptNumber,student_details.stid,student_details.name,student_details.surname,student_details.class,payment_fees.term_paid,payment_fees.date_paid,payment_fees.fees_paid,payment_fees.amount_left,payment_fees.Cashier from payment_fees INNER Join student_details on payment_fees.studentID= student_details.stid order by payment_fees.id ")
        LoadData(Gross_Fees_Paid.FeesGrid, "payment")
    End Sub


End Module
