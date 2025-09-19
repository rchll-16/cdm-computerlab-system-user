Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class Registration

    Dim connStr = "data source = localhost; user id = root; database = cdmcomlab"

    Dim registeredEmail, registeredPass, fname, lname, studentno, gender, course, studentYear, section As String

    Private Sub rdbMale_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMale.CheckedChanged
        gender = rdbMale.Text
    End Sub
    Private Sub rdbFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rdbFemale.CheckedChanged
        gender = rdbFemale.Text
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbCourse.Text = cmbCourse.Items(0)
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        registeredEmail = txtEmail.Text
        registeredPass = txtPass.Text
        fname = txtFname.Text
        lname = txtLname.Text
        studentno = txtStudentNo.Text
        course = cmbCourse.Text
        studentYear = cmbYrlvl.Text
        section = cmbSec.Text
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@gmail\.com$"
        Dim isValidEmail As Boolean = Regex.IsMatch(registeredEmail, emailPattern)

        If (txtFname.Text = Nothing Or txtLname.Text = Nothing Or txtEmail.Text = Nothing Or txtPass.Text = Nothing Or txtConfirmPass.Text = Nothing Or cmbCourse.Text = Nothing Or cmbYrlvl.Text = Nothing) Then
            MessageBox.Show("Please Fill In All The Details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (txtPass.Text <> txtConfirmPass.Text) Then
            MessageBox.Show("Your Password And Confirm Password Is Not Same!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not isValidEmail Then
            MessageBox.Show("Invalid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Try
                openCon()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO `students`(`lastName`, `firstName`, `studentNo`, `gender`, `email`, `password`, `course`, `studentYear`, `section`) VALUES (@lastName, @firstName, @studentNo, @gender, @email, @password, @course, @studentYear, @section)"

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@lastName", lname)
                cmd.Parameters.AddWithValue("@firstName", fname)
                cmd.Parameters.AddWithValue("@gender", gender)
                cmd.Parameters.AddWithValue("@email", registeredEmail)
                cmd.Parameters.AddWithValue("@password", registeredPass)
                cmd.Parameters.AddWithValue("@studentNo", studentno)
                cmd.Parameters.AddWithValue("@course", course)
                cmd.Parameters.AddWithValue("@studentYear", studentYear)
                cmd.Parameters.AddWithValue("@section", section)


                cmd.ExecuteNonQuery()

                txtEmail.Clear()
                txtPass.Clear()
                txtFname.Clear()
                txtLname.Clear()
                txtStudentNo.Clear()
                txtConfirmPass.Clear()

                MessageBox.Show("Registration Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Login.Show()
                Me.Hide()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try
        End If

    End Sub

End Class