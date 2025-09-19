Imports MySql.Data.MySqlClient
Imports Telerik.Windows.Documents.Spreadsheet.Expressions.Functions

Public Class PC_SLOT
    Dim selectedPcslot As String

    Private Sub PictureBox_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, PictureBox2.Click, PictureBox3.Click,
            PictureBox4.Click, PictureBox5.Click, PictureBox6.Click, PictureBox7.Click, PictureBox8.Click, PictureBox9.Click,
            PictureBox10.Click, PictureBox11.Click, PictureBox12.Click, PictureBox13.Click, PictureBox14.Click, PictureBox15.Click,
            PictureBox16.Click, PictureBox17.Click, PictureBox18.Click,
            PictureBox19.Click, PictureBox20.Click, PictureBox21.Click, PictureBox22.Click, PictureBox23.Click, PictureBox24.Click,
            PictureBox25.Click, PictureBox26.Click, PictureBox27.Click, PictureBox28.Click, PictureBox29.Click, PictureBox30.Click

        selectedPcslot = ""
        Dim clickedPictureBox As PictureBox = CType(sender, PictureBox)

        If clickedPictureBox Is PictureBox1 Then
            selectedPcslot = "1"
        ElseIf clickedPictureBox Is PictureBox2 Then
            selectedPcslot = "2"
        ElseIf clickedPictureBox Is PictureBox3 Then
            selectedPcslot = "3"
        ElseIf clickedPictureBox Is PictureBox4 Then
            selectedPcslot = "4"
        ElseIf clickedPictureBox Is PictureBox5 Then
            selectedPcslot = "5"
        ElseIf clickedPictureBox Is PictureBox6 Then
            selectedPcslot = "6"
        ElseIf clickedPictureBox Is PictureBox7 Then
            selectedPcslot = "7"
        ElseIf clickedPictureBox Is PictureBox8 Then
            selectedPcslot = "8"
        ElseIf clickedPictureBox Is PictureBox9 Then
            selectedPcslot = "9"
        ElseIf clickedPictureBox Is PictureBox10 Then
            selectedPcslot = "10"
        ElseIf clickedPictureBox Is PictureBox11 Then
            selectedPcslot = "11"
        ElseIf clickedPictureBox Is PictureBox12 Then
            selectedPcslot = "12"
        ElseIf clickedPictureBox Is PictureBox13 Then
            selectedPcslot = "13"
        ElseIf clickedPictureBox Is PictureBox14 Then
            selectedPcslot = "14"
        ElseIf clickedPictureBox Is PictureBox15 Then
            selectedPcslot = "15"
        ElseIf clickedPictureBox Is PictureBox16 Then
            selectedPcslot = "16"
        ElseIf clickedPictureBox Is PictureBox17 Then
            selectedPcslot = "17"
        ElseIf clickedPictureBox Is PictureBox18 Then
            selectedPcslot = "18"
        ElseIf clickedPictureBox Is PictureBox19 Then
            selectedPcslot = "19"
        ElseIf clickedPictureBox Is PictureBox20 Then
            selectedPcslot = "20"
        ElseIf clickedPictureBox Is PictureBox21 Then
            selectedPcslot = "21"
        ElseIf clickedPictureBox Is PictureBox22 Then
            selectedPcslot = "22"
        ElseIf clickedPictureBox Is PictureBox23 Then
            selectedPcslot = "23"
        ElseIf clickedPictureBox Is PictureBox24 Then
            selectedPcslot = "24"
        ElseIf clickedPictureBox Is PictureBox25 Then
            selectedPcslot = "25"
        ElseIf clickedPictureBox Is PictureBox26 Then
            selectedPcslot = "26"
        ElseIf clickedPictureBox Is PictureBox27 Then
            selectedPcslot = "27"
        ElseIf clickedPictureBox Is PictureBox28 Then
            selectedPcslot = "28"
        ElseIf clickedPictureBox Is PictureBox29 Then
            selectedPcslot = "29"
        ElseIf clickedPictureBox Is PictureBox30 Then
            selectedPcslot = "30"
        End If
        GlobalDataModule.pcSlot = selectedPcslot
        Dim result As DialogResult = MessageBox.Show("Student No: " + GlobalDataModule.loggedIn_studentNo + Environment.NewLine + "Student Name: " + GlobalDataModule.loggedIn_fullName + Environment.NewLine + "Major Subject: " + GlobalDataModule.selectedMajorSub + Environment.NewLine + "Computer Laboratory: " + GlobalDataModule.computerLab + Environment.NewLine + Environment.NewLine + "PC Slot: " + GlobalDataModule.pcSlot + Environment.NewLine + "Date: " + GlobalDataModule.reservation_Date + Environment.NewLine + "Start Time: " + GlobalDataModule.reservation_TimeStart + Environment.NewLine + "End Time: " + GlobalDataModule.reservation_TimeEnd, "Reserve Schedule?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            insertReservation()

        ElseIf result = DialogResult.No Then
            MessageBox.Show("Please Reserve", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub

    Private Sub insertReservation()
        Try
            openCon()
            Dim checkQuery As String = "SELECT COUNT(*) 
                                    FROM reservation r
                                    JOIN computerlab cl ON r.comlab_id = cl.comlab_id
                                    WHERE r.StartTime = @StartTime 
                                      AND cl.comlab = @Comlab 
                                      AND cl.pcSlot = @PcSlot"
            cmd.Connection = con
            cmd.CommandText = checkQuery
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@StartTime", GlobalDataModule.reservation_Start)
            cmd.Parameters.AddWithValue("@Comlab", GlobalDataModule.computerlab)
            cmd.Parameters.AddWithValue("@PcSlot", GlobalDataModule.pcSlot)

            Dim reservationCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If reservationCount > 0 Then
                MessageBox.Show("This schedule is already occupied.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else
                cmd.CommandText = "INSERT INTO `reservation` (`startTime`, `endTime`, `student_id`, `comlab_id`, subject) VALUES
                                                         (@startTime, @endTime, (SELECT student_id FROM students WHERE studentNo = @studentNo),
                                                         (SELECT comlab_id FROM computerlab WHERE comlab = @comlab AND pcSlot = @pcSlot), @subject)"



                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@startTime", GlobalDataModule.reservation_Start)
                cmd.Parameters.AddWithValue("@endTime", GlobalDataModule.reservation_End)
                cmd.Parameters.AddWithValue("@studentNo", GlobalDataModule.loggedIn_studentNo)
                cmd.Parameters.AddWithValue("@comlab", GlobalDataModule.computerlab)
                cmd.Parameters.AddWithValue("@pcSlot", GlobalDataModule.pcSlot)
                cmd.Parameters.AddWithValue("@subject", GlobalDataModule.selectedMajorSub)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Reservation Successful!, Please wait for the Email", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Reservation Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                SendEmail()
                RERESERVATION()
                reservationClear()
            End If
        Catch ex As Exception
            MessageBox.Show("Error inserting reservation: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
    Sub RERESERVATION()
        con.Close()
        Dim result As DialogResult = MessageBox.Show("Do you want to make a reservation again? ", "Another Reservation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            PC_Availability.Show()
            Me.Hide()
        ElseIf result = DialogResult.No Then
            Dashboard.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        DateTimePick.Show()
    End Sub
    Private Sub PC_SLOT_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Label32.Text = "Computer Laboratory " + GlobalDataModule.computerlab
    End Sub
End Class
