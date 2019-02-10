Module StudentAccounts
    Private e As Object = True
    Dim timeof As DateTime = TimeOfDay
    Dim todayday As DateTime = Format("yyyy-mmm-dd", Today)
    'Surname TextBox
    Sub SurnameMouseEnter()
        If Stundentform.txtSurname.Text = "Enter Surname" Then
            Stundentform.txtSurname.Text = ""
            Stundentform.txtSurname.ForeColor = Color.Black
        End If
    End Sub
    Sub SurnameMouseLeave()
        If Stundentform.txtSurname.Text = "" Then
            Stundentform.txtSurname.Text = "Enter Surname"
            Stundentform.txtSurname.ForeColor = Color.Gray
        End If
    End Sub
    'Name TextBox
    Sub NameMouseEnter()
        If Stundentform.txtFname.Text = "Enter Name" Then
            Stundentform.txtFname.Text = ""
            Stundentform.txtFname.ForeColor = Color.Black
        End If
    End Sub
    Sub NameMouseLeave()
        If Stundentform.txtFname.Text = "" Then
            Stundentform.txtFname.Text = "Enter Name"
            Stundentform.txtFname.ForeColor = Color.Gray
        End If
    End Sub
    'Nationality TextBox
    Sub NationalityMouseEnter()
        If Stundentform.txtNational.Text = "Enter Nationality" Then
            Stundentform.txtNational.Text = ""
            Stundentform.txtNational.ForeColor = Color.Black
        End If
    End Sub
    Sub NationalityMouseLeave()
        If Stundentform.txtNational.Text = "" Then
            Stundentform.txtNational.Text = "Enter Nationality"
            Stundentform.txtNational.ForeColor = Color.Gray
        End If
    End Sub
    'Guidence TextBox
    Sub GuidenceMouseEnter()
        If Stundentform.txtGuid.Text = "Enter Guidence" Then
            Stundentform.txtGuid.Text = ""
            Stundentform.txtGuid.ForeColor = Color.Black
        End If
    End Sub
    Sub GuidenceMouseLeave()
        If Stundentform.txtGuid.Text = "" Then
            Stundentform.txtGuid.Text = "Enter Guidence"
            Stundentform.txtGuid.ForeColor = Color.Gray
        End If
    End Sub
    'PhoneNumber TextBox
    Sub PhoneNumberMouseEnter()
        If Stundentform.txtPhone.Text = "Enter Phone Number" Then
            Stundentform.txtPhone.Text = ""
            Stundentform.txtPhone.ForeColor = Color.Black
        End If
    End Sub
    Sub PhoneNumberMouseLeave()
        If Stundentform.txtPhone.Text = "" Then
            Stundentform.txtPhone.Text = "Enter Phone Number"
            Stundentform.txtPhone.ForeColor = Color.Gray
        End If
    End Sub
    'Create Account
    Sub CreateAccount()
        If Stundentform.txtFname.Text = "" Then
            MsgBox("Name is Required!")
        ElseIf Stundentform.txtSurname.Text = "" Then
            MsgBox("Surname is Required!")
        ElseIf Stundentform.txtAddress.Text = "" Then
            MsgBox("Address is Required!")
        ElseIf Stundentform.txtNational.Text = "" Then
            MsgBox("Nationality is Required!")
        ElseIf Stundentform.txtFname.Text = "" Then
            MsgBox("Guidance's name is Required!")
        ElseIf Stundentform.txtPhone.Text = "" Then
            MsgBox("Phone Number is Required!")
        ElseIf Stundentform.cmbClass.Text = "" Then
            MsgBox("Please select class!")
        ElseIf Stundentform.cmbGender.Text = "" Then
            MsgBox("Please select gender!")
        Else
            issucess = insert("INSERT INTO `student_details` (`stid`, `name`, `surname`,`dateOfBirth`, " &
                   " `gender`, `nationality`, `class`,  `address`, `guidanceName`, `phone`,`date_registered`) " &
                   " VALUES ('" & Stundentform.txtReg.Text & "','" & Stundentform.txtFname.Text & "', '" & Stundentform.txtSurname.Text & "', '" & Stundentform.DOBPick.Value & "', '" & Stundentform.cmbGender.Text & "', '" & Stundentform.txtNational.Text & "', " &
                   " '" & Stundentform.cmbClass.Text & "',  '" & Stundentform.txtAddress.Text & "','" & Stundentform.txtGuid.Text & "', '" & Stundentform.txtPhone.Text & "',  '" & todayday & "');")

            If issucess = True Then
                MsgBox("Student has been registered successfully!", MsgBoxStyle.Information)
                StudentList.Show()
                StudentList.Location = New System.Drawing.Point(433, 122)
                Stundentform.Hide()

            Else
                MsgBox("No student has been registered!", MsgBoxStyle.Critical)
            End If

        End If
    End Sub
    'clear inputs
    Sub GenerateNumber()
        Try
            findthis("SELECT Max(stid) From `student_details`  ")
            con.Open()
            Dim num As Integer = cmd.ExecuteScalar
            Stundentform.txtReg.Text = num + 1
            If Stundentform.txtReg.Text = "" Then
                Stundentform.txtReg.Text = ""
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
    'Load all students
    Sub LoadAllStudents()
        Try
            findthis("SELECT stid,name,surname,dateOfBirth,gender,nationality,class,address,guidanceName,phone FROM student_details")
            LoadData(StudentList.StudentGridView, "studentList")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub
    'Click grid
    Sub FillStudentTextBox()
        StudentList.txtReg.Text = StudentList.StudentGridView.CurrentRow.Cells(0).Value.ToString
        StudentList.txtFname.Text = StudentList.StudentGridView.CurrentRow.Cells(1).Value.ToString
        StudentList.txtSurname.Text = StudentList.StudentGridView.CurrentRow.Cells(2).Value.ToString
        StudentList.DOBPick.Text = StudentList.StudentGridView.CurrentRow.Cells(3).Value.ToString
        StudentList.cmbGender.Text = StudentList.StudentGridView.CurrentRow.Cells(4).Value.ToString
        StudentList.txtNational.Text = StudentList.StudentGridView.CurrentRow.Cells(5).Value.ToString
        StudentList.cmbClass.Text = StudentList.StudentGridView.CurrentRow.Cells(6).Value.ToString
        StudentList.txtAddress.Text = StudentList.StudentGridView.CurrentRow.Cells(7).Value.ToString
        StudentList.txtGuid.Text = StudentList.StudentGridView.CurrentRow.Cells(8).Value.ToString
        StudentList.txtPhone.Text = StudentList.StudentGridView.CurrentRow.Cells(9).Value.ToString
    End Sub
    'Update student
    Sub UpdateStudent()
        issucess = insert("UPDATE `student_details` SET `name`='" & StudentList.txtFname.Text & "',`surname`= '" & StudentList.txtSurname.Text & "',`dateOfBirth`='" & StudentList.DOBPick.Value & "' ,`gender`= '" & StudentList.cmbGender.Text & "' ,`nationality`= '" & StudentList.txtNational.Text & "',`class`= '" & StudentList.cmbClass.Text & "',`address`= '" & StudentList.txtAddress.Text & "',`guidanceName`='" & StudentList.txtGuid.Text & "',`phone`='" & StudentList.txtPhone.Text & "' WHERE `stid`='" & StudentList.txtReg.Text & "'")
        If issucess = True Then
            MsgBox("Student has been Successfully!Updated a student", MsgBoxStyle.Information)
            LoadAllStudents()
            ClearBox()
        Else
            MsgBox("Error occured..................!!!", MsgBoxStyle.Critical)
        End If
    End Sub
    'clear textbox
    Sub ClearBox()
        StudentList.txtReg.Clear()
        StudentList.txtFname.Clear()
        StudentList.txtSurname.Clear()
        StudentList.DOBPick.ResetText()
        StudentList.cmbGender.ResetText()
        StudentList.txtNational.Clear()
        StudentList.cmbClass.ResetText()
        StudentList.txtAddress.Clear()
        StudentList.txtGuid.Clear()
        StudentList.txtPhone.Clear()
    End Sub
    'Filter classes
    Sub FilterClassess()
        Try
            findthis("SELECT stid,name,surname,dateOfBirth,gender,nationality,class,address,guidanceName,phone FROM student_details WHERE class = '" & StudentList.cmbFilterClass.Text & "'")

            LoadData(StudentList.StudentGridView, "studentList")

            findthis("SELECT count(*) FROM `student_details`where class ='" & StudentList.cmbFilterClass.Text & "'")
            Dim numberOfpupilsInClass As Integer = GetCount()
            StudentList.lbTotal.Text = numberOfpupilsInClass
            StudentList.Panel11.Visible = True
            StudentList.lblClassName.Text = StudentList.cmbFilterClass.Text

            If StudentList.lbTotal.Text > 1 Then
                StudentList.lblDesicion.Text = "ther are"
                StudentList.LabelBelow.Text = "Pupils in this Class"
                StudentList.lbTotal.Visible = True
                StudentList.LabelBelow.Visible = True
            ElseIf StudentList.lbTotal.Text = 1 Then
                StudentList.lblDesicion.Text = "there is"
                StudentList.LabelBelow.Text = "Pupil in this Class"
                StudentList.lbTotal.Visible = True
                StudentList.LabelBelow.Visible = True
            ElseIf StudentList.lbTotal.Text = 0 Then
                StudentList.lblDesicion.Text = "THE CLASS IS EMPTY"
                StudentList.lbTotal.Visible = False
                StudentList.LabelBelow.Visible = False


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub
    'delete student
    Sub DeleteStudent()
        issucess = delete("DELETE FROM student_details  WHERE `stid`='" & StudentList.txtReg.Text & "'")
        If issucess = True Then
            MsgBox("Student has been Deleted successfully!", MsgBoxStyle.Information)
            LoadAllStudents()
            ClearBox()
        Else
            MsgBox("Error occured..................!!!", MsgBoxStyle.Critical)

        End If
    End Sub
    'search student
    Sub SearchStudent()
        Try
            findthis("SELECT * FROM `student_details` WHERE `stid`='" & StudentList.txtSearch.Text & "'")


            con.Open()
            dReader = cmd.ExecuteReader()

            While dReader.Read

                StudentList.txtReg.Text = dReader("stid")
                StudentList.txtFname.Text = dReader("name")
                StudentList.txtSurname.Text = dReader("surname")
                StudentList.DOBPick.Text = dReader("dateOfBirth")
                StudentList.cmbGender.Text = dReader("gender")
                StudentList.txtNational.Text = dReader("nationality")
                StudentList.cmbClass.Text = dReader("class")
                StudentList.txtAddress.Text = dReader("address")
                StudentList.txtGuid.Text = dReader("guidanceName")
                StudentList.txtPhone.Text = dReader("phone")
                StudentList.txtSearch.Text = ""
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()

        End Try
    End Sub
    'count all student
    Sub showTotalStudent()
        findthis("SELECT count(*) FROM `student_details`")
        Dim num = GetCount()
        StudentList.lblTotal.Text = num
    End Sub
    'count all female student
    Sub showTotalFemaleStudent()
        findthis("SELECT count(*) FROM `student_details` where gender ='Female'")
        Dim num = GetCount()
        StudentList.lblTotalFemale.Text = num
    End Sub
    'count all male student
    Sub showTotalMaleStudent()
        findthis("SELECT count(*) FROM `student_details` where gender ='Male'")
        Dim num = GetCount()
        StudentList.lblTotalMale.Text = num
    End Sub

    'double Click grid
    Sub DoubleFillStudentTextBox()
        Student_Profile.Show()
        Student_Profile.Location = New System.Drawing.Point(290, 114)
        StudentList.Hide()
        Student_Profile.lblReg.Text = StudentList.StudentGridView.CurrentRow.Cells(0).Value.ToString
        Student_Profile.lblFname.Text = StudentList.StudentGridView.CurrentRow.Cells(1).Value.ToString
        Student_Profile.lblSurn.Text = StudentList.StudentGridView.CurrentRow.Cells(2).Value.ToString
        Student_Profile.lblGnder.Text = StudentList.StudentGridView.CurrentRow.Cells(4).Value.ToString
        Student_Profile.lblClass.Text = StudentList.StudentGridView.CurrentRow.Cells(6).Value.ToString
        Student_Profile.lblphone.Text = StudentList.StudentGridView.CurrentRow.Cells(9).Value.ToString
    End Sub
End Module
