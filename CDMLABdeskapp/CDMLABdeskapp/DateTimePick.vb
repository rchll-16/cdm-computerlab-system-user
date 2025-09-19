Public Class DateTimePick
    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        If cmbTime.SelectedIndex = 0 Then
            MessageBox.Show("Please Select a Valid Time Range", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Dim selectedDate As Date = RadDateTimePicker1.Value
        Dim selectedTimeRange As String = cmbTime.SelectedItem.ToString()
        Dim timeParts() As String = selectedTimeRange.Split("-"c)
        Dim startTimeStr As String = timeParts(0).Trim()
        Dim endTimeStr As String = timeParts(1).Trim()

        Dim startTime As DateTime = Convert.ToDateTime(startTimeStr)
        Dim endTime As DateTime = Convert.ToDateTime(endTimeStr)

        Dim combinedStartTime As DateTime = selectedDate.Add(startTime.TimeOfDay)
        Dim combinedEndTime As DateTime = selectedDate.Add(endTime.TimeOfDay)

        Dim Result As DialogResult = MessageBox.Show("Date: " + combinedStartTime.Date + Environment.NewLine + "Start Time: " + startTimeStr + Environment.NewLine + "End Time: " + endTimeStr, "Date and Time", MessageBoxButtons.YesNo)
        If Result = DialogResult.Yes Then
            GlobalDataModule.reservation_Start = combinedStartTime
            GlobalDataModule.reservation_End = combinedEndTime
            GlobalDataModule.reservation_Date = combinedStartTime.Date
            GlobalDataModule.reservation_TimeStart = startTimeStr
            GlobalDataModule.reservation_TimeEnd = endTimeStr
            cmbTime.SelectedIndex = 0
            startTime = Nothing
            endTime = Nothing
            combinedStartTime = Nothing
            combinedEndTime = Nothing
            PC_SLOT.Show()
            Me.Hide()
        ElseIf Result = DialogResult.No Then
            cmbTime.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Comlab1or2.Show()
        Me.Hide()
    End Sub

    Private Sub RadDateTimePicker1_KeyDown(sender As Object, e As KeyEventArgs) Handles RadDateTimePicker1.KeyDown
        ' Suppress all keyboard input
        e.SuppressKeyPress = True
    End Sub

    Private Sub DateTimePick_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        cmbTime.SelectedIndex = 0
    End Sub

    Private Sub DateTimePick_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadDateTimePicker1.MinDate = Date.Today
    End Sub

End Class