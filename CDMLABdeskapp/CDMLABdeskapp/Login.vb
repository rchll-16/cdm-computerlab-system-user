Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub chbShow_CheckedChanged(sender As Object, e As EventArgs) Handles chbShow.CheckedChanged
        If chbShow.Checked = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim email As String = txtEmail.Text.Trim()
        Dim password As String = txtPass.Text

        If String.IsNullOrWhiteSpace(email) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter both email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            'Select Email first then retrieve password then check if password input is matched in password in Database
            openCon()
            cmd.CommandText = "SELECT `email`, `password` FROM `students` WHERE email = @email"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@email", email)

            Dim emailDB As String = ""
            Dim passwordDB As String = ""

            Dim reader1 As MySqlDataReader = cmd.ExecuteReader()
            If reader1.Read() Then
                emailDB = reader1.GetString(0)
                passwordDB = reader1.GetString(1)
            End If
            reader1.Close()

            'If email is nothing, it means that it doesnt exist
            If Not String.IsNullOrEmpty(emailDB) Then
                If passwordDB IsNot Nothing Then
                    If password = passwordDB And isLoggedIn = False Then
                        MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        password = ""
                        GlobalDataModule.isLoggedIn = True
                        txtEmail.Clear()
                        txtPass.Clear()
                        cmd.CommandText = "SELECT `lastName`,`firstName`, `studentNo`, `gender`, `email`, `course`, `studentYear`, `section` FROM `students` WHERE email = @email"


                        Dim reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.Read() Then
                            GlobalDataModule.loggedIn_lName = reader.GetString(0)
                            GlobalDataModule.loggedIn_fName = reader.GetString(1)
                            GlobalDataModule.loggedIn_studentNo = reader.GetString(2)
                            GlobalDataModule.loggedIn_gender = reader.GetString(3)
                            GlobalDataModule.loggedIn_email = reader.GetString(4)
                            GlobalDataModule.loggedIn_course = reader.GetString(5)
                            GlobalDataModule.loggedIn_studentYear = reader.GetString(6)
                            GlobalDataModule.loggedIn_section = reader.GetString(7)
                        End If
                        reader.Close()
                        GlobalDataModule.loggedIn_fullName = loggedIn_fName + " " + loggedIn_lName
                        GlobalDataModule.loggedIn_yearAndSection = loggedIn_studentYear + loggedIn_section

                        Dashboard.Show()
                        Me.Hide()


                    Else
                        MessageBox.Show("Incorrect Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtPass.Clear()
                    End If
                Else
                    MessageBox.Show("Fill up the password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("User not found!", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If


        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub linkReg_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkReg.LinkClicked
        Registration.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
