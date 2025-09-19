Imports Aspose.Pdf

Public Class Schedule
    Private currentPage As Integer = 1
    Private pageSize As Integer = 10
    Private totalRecords As Integer
    Private totalPages As Integer
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Comlab1or2.originForm = ""
        Comlab1or2.originForm = "Schedule"
        Me.Hide()
        Comlab1or2.Show()

    End Sub

    Private Sub loadSchedule(pageNumber As Integer, pageSize As Integer)
        openCon()
        Try
            Dim offset As Integer = (pageNumber - 1) * pageSize
            cmd.Connection = con
            Dim query = "SELECT computerlab.comlab,
                                      computerlab.pcSlot,
                                      reservation.StartTime,
                                      reservation.EndTime   
                               FROM reservation INNER JOIN
                               computerlab ON reservation.comlab_id = computerlab.comlab_id 
                               WHERE reservation.StartTime >= CURDATE()
                               ORDER BY reservation.StartTime 
                               LIMIT @PageSize OFFSET @Offset"
            cmd.CommandText = query
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@PageSize", pageSize)
            cmd.Parameters.AddWithValue("@Offset", offset)
            adapter.SelectCommand = cmd
            table.Clear()
            adapter.Fill(table)
            populateDataGridView(table)

            cmd.CommandText = "SELECT COUNT(*) FROM reservation WHERE reservation.StartTime >= CURDATE()"
            totalRecords = Convert.ToInt32(cmd.ExecuteScalar())
            totalPages = Math.Ceiling(totalRecords / pageSize)

            btnPrevious.Enabled = pageNumber > 1
            btnNext.Enabled = pageNumber < totalPages
            lblPageNumber.Text = "Page " & pageNumber.ToString & " of " & totalPages.ToString()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub populateDataGridView(table As DataTable)
        ScheduleDataGridView.Rows.Clear()
        For Each row As DataRow In table.Rows
            ScheduleDataGridView.Rows.Add(row("comlab"), row("pcSlot"), row("startTime"), row("endTime"))
        Next
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentPage < totalPages Then
            currentPage += 1
            loadSchedule(currentPage, pageSize)
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentPage > 1 Then
            currentPage -= 1
            loadSchedule(currentPage, pageSize)
        End If
    End Sub

    Private Sub Schedule_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        loadSchedule(currentPage, pageSize)
    End Sub
End Class