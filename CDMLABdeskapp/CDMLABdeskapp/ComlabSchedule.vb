Imports Telerik.WinControls.UI

Public Class ComlabSchedule

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComlabSchedule_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        loadReservation()
        RadDateTimePicker1.MinDate = Date.Today()
        Label1.Text = "Computer Laboratory " + GlobalDataModule.computerlab
        RadDateTimePicker1.Value = Date.Today()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Comlab1or2.originForm = ""
        Comlab1or2.originForm = "Schedule"
        Me.Hide()
        Comlab1or2.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        Schedule.Show()
    End Sub

    Private Sub populateDataGridView(table As DataTable)
        DataGridView1.Rows.Clear()
        For Each row As DataRow In table.Rows
            DataGridView1.Rows.Add(row("pcSlot"), row("startTime"), row("endTime"))
        Next
    End Sub

    Private Sub loadReservation()
        Dim selectedDate As Date = RadDateTimePicker1.Value

        openCon()

        Try
            Dim query As String = "SELECT cl.pcSlot, r.startTime, r.endTime
                                   FROM reservation r
                                   JOIN computerlab cl ON r.comlab_id = cl.comlab_id
                                   WHERE cl.comlab = @comlab
                                   AND DATE(r.startTime) = @selectedDate
                                   ORDER BY r.startTime;"
            cmd.Connection = con
            cmd.CommandText = query
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@comlab", GlobalDataModule.computerlab)
            cmd.Parameters.AddWithValue("@selectedDate", selectedDate.Date)
            adapter.SelectCommand = cmd
            table.Clear()
            adapter.Fill(table)
            populateDataGridView(table)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub RadDateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles RadDateTimePicker1.ValueChanged
        loadReservation()
    End Sub
End Class