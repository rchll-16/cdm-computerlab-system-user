Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand("", con)
    Public adapter As New MySqlDataAdapter
    Public data As New DataSet
    Public table As New DataTable

    Sub openCon()
        con.ConnectionString = "server=localhost; username=root; password=; database=cdmcomlab"
        con.Open()
    End Sub

    Sub clearCmd()
        cmd.CommandText = ""
    End Sub

    Sub LoadReservations(pageNumber As Integer, pageSize As Integer, Query As String, lblPageNum As Label, btnNext As Button, btnPrev As Button)
        Try
            openCon()
            cmd.Connection = con
            Dim offset As Integer = (pageNumber - 1) * pageSize
            Dim paginatedQuery = Query & " Limit @PageSize OFFSET @Offset"
            cmd.CommandText = paginatedQuery
            cmd.Parameters.AddWithValue("@PageSize", pageSize)
            cmd.Parameters.AddWithValue("@Offset", pageNumber)

            adapter.Fill(data, "Reservations")

            lblPageNum.Text = "Page " & pageNumber.ToString()

            btnPrev.Enabled = pageNumber > 1
            btnNext.Enabled = data.Tables("Reservation").Rows.Count = pageSize

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

    End Sub

End Module
