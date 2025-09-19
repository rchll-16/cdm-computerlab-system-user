Imports MySql.Data.MySqlClient

Public Class Dashboard

    Private Sub btnReservePcSlot_Click(sender As Object, e As EventArgs) Handles btnReservePcSlot.Click
        Me.Hide()
        PC_Availability.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        GlobalDataModule.isLoggedIn = False
        profileClear()
        reservationClear()
        Me.Hide()
        Login.Show()
    End Sub


    Private Sub Dashboard_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        con.Close()

        fname_dash.Text = ""
        studentno_dash.Text = ""
        txtDashCourse.Text = ""
        txtYearSec.Text = ""
        txtBSITCount.Clear()
        txtBSCPECount.Clear()
        txtFirstYear.Clear()
        txtSecondYear.Clear()
        txtThirdYear.Clear()
        txtFourthYear.Clear()


        fname_dash.Text = GlobalDataModule.loggedIn_fName
        studentno_dash.Text = GlobalDataModule.loggedIn_studentNo
        txtDashCourse.Text = GlobalDataModule.loggedIn_course
        txtYearSec.Text = GlobalDataModule.loggedIn_studentYear + GlobalDataModule.loggedIn_section


        ReservationCount()
    End Sub



    Private Sub btnViewSched_Click(sender As Object, e As EventArgs) Handles btnViewSched.Click
        Me.Hide()
        Schedule.Show()
    End Sub

    Public Sub ReservationCount()
        Try
            openCon()
            Dim countFirstYear As String = "SELECT COUNT(*) AS reservation_count FROM reservation r JOIN students s ON r.student_id = s.student_id WHERE s.studentYear = '1';"
            Dim countSecondYear As String = "SELECT COUNT(*) AS reservation_count FROM reservation r JOIN students s ON r.student_id = s.student_id WHERE s.studentYear = '2';"
            Dim countThirdYear As String = "SELECT COUNT(*) AS reservation_count FROM reservation r JOIN students s ON r.student_id = s.student_id WHERE s.studentYear = '3';"
            Dim countFourthYear As String = "SELECT COUNT(*) AS reservation_count FROM reservation r JOIN students s ON r.student_id = s.student_id WHERE s.studentYear = '4';"

            Dim countBSIT As String = "SELECT COUNT(*) AS reservation_count FROM reservation r JOIN students s ON r.student_id = s.student_id WHERE s.course = 'BSIT';"
            Dim countBSCPE As String = "SELECT COUNT(*) AS reservation_count FROM reservation r JOIN students s ON r.student_id = s.student_id WHERE s.course = 'BSCPE';"


            Dim adapterFirstYear As New MySqlDataAdapter(countFirstYear, con)
            Dim adapterSecondYear As New MySqlDataAdapter(countSecondYear, con)
            Dim adapterThirdYear As New MySqlDataAdapter(countThirdYear, con)
            Dim adapterFourthYear As New MySqlDataAdapter(countFourthYear, con)

            Dim adapterBSIT As New MySqlDataAdapter(countBSIT, con)
            Dim adapterBSCPE As New MySqlDataAdapter(countBSCPE, con)

            adapterFirstYear.Fill(data, "ReservationFirstYear")
            adapterSecondYear.Fill(data, "ReservationSecondYear")
            adapterThirdYear.Fill(data, "ReservationThirdYear")
            adapterFourthYear.Fill(data, "ReservationFourthYear")

            adapterBSIT.Fill(data, "ReservationBSIT")
            adapterBSCPE.Fill(data, "ReservationBSCPE")

            If data.Tables("ReservationFirstYear").Rows.Count > 0 Then
                txtFirstYear.Text = data.Tables("ReservationFirstYear").Rows(0)("reservation_count").ToString()
            End If
            If data.Tables("ReservationSecondYear").Rows.Count > 0 Then
                txtSecondYear.Text = data.Tables("ReservationSecondYear").Rows(0)("reservation_count").ToString()
            End If
            If data.Tables("ReservationThirdYear").Rows.Count > 0 Then
                txtThirdYear.Text = data.Tables("ReservationThirdYear").Rows(0)("reservation_count").ToString()
            End If
            If data.Tables("ReservationFourthYear").Rows.Count > 0 Then
                txtFourthYear.Text = data.Tables("ReservationFourthYear").Rows(0)("reservation_count").ToString()

            End If
            If data.Tables("ReservationBSIT").Rows.Count > 0 Then
                txtBSITCount.Text = data.Tables("ReservationBSIT").Rows(0)("reservation_count").ToString()
            End If
            If data.Tables("ReservationBSCPE").Rows.Count > 0 Then
                txtBSCPECount.Text = data.Tables("ReservationBSCPE").Rows(0)("reservation_count").ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub


End Class