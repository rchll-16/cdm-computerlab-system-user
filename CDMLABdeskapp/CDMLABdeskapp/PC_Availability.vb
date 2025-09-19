Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI

Public Class PC_Availability
    Dim chosenDate1 As DateTime
    Dim chosenDate2 As DateTime
    Private Sub btnChooseSubj_Click(sender As Object, e As EventArgs) Handles btnChooseSubj.Click
        Dim popup As New ChooseSubjPopup

        popup.ShowDialog()
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        Dashboard.Show()
        Me.Hide()
    End Sub



    Private Sub PC_Availability_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DateTimePicker1.MinDate = Date.Today
        DateTimePicker2.MinDate = Date.Today
        DateTimePicker1.MinDate = Date.Today
        DateTimePicker2.MinDate = Date.Today
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        loadReservation1()
    End Sub
    Sub loadReservation1()
        Dim chosenDate1 As Date = DateTimePicker1.Value.Date

        openCon()

        Try
            Dim query As String = "SELECT cl.comlab, 
                                   COUNT(r.reservation_id) AS availableSlots
                                   FROM computerlab cl
                                   LEFT JOIN reservation r ON cl.comlab_id = r.comlab_id
                                   AND DATE(r.startTime) = @chosenDate
                                   WHERE cl.comlab = '1'
                                   GROUP BY cl.comlab;"

            cmd.CommandText = query
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@chosenDate", chosenDate1)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    txtComlab1.Text = reader("availableSlots").ToString()
                End While
            Else
                txtComlab1.Text = "30" ' If no reservations, all slots are available
            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            con.Close()
        End Try
    End Sub
    Sub loadReservation2()
        Dim chosenDate2 As Date = DateTimePicker2.Value.Date

        openCon()

        Try
            Dim query As String = "SELECT cl.comlab, 
                                   COUNT(r.reservation_id) AS availableSlots
                                   FROM computerlab cl
                                   LEFT JOIN reservation r ON cl.comlab_id = r.comlab_id
                                   AND DATE(r.startTime) = @chosenDate
                                   WHERE cl.comlab = '2'
                                   GROUP BY cl.comlab;"

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@chosenDate", chosenDate2)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    txtComlab2.Text = reader("availableSlots").ToString()
                End While
            Else
                txtComlab2.Text = "30" ' If no reservations, all slots are available
            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        loadReservation2()
    End Sub
End Class