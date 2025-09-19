Public Class Comlab1or2
    Dim Comlab As String
    Public originForm As String


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If originForm = "Schedule" Then
            Me.Hide()
            Schedule.Show()
        ElseIf originForm = "ChooseSubjPopup" Then
            Me.Hide()
            PC_Availability.Show()
        End If
    End Sub

    Private Sub pnlComlab1_Click(sender As Object, e As EventArgs) Handles pnlComlab1.Click
        Comlab = "1"
        GlobalDataModule.computerlab = Comlab
        Select Case originForm
            Case "ChooseSubjPopup"
                Me.Hide()
                DateTimePick.Show()
            Case "Schedule"
                Me.Hide()
                ComlabSchedule.Show()
        End Select

    End Sub

    Private Sub pnlComlab2_Click(sender As Object, e As EventArgs) Handles pnlComlab2.Click
        Comlab = "2"
        GlobalDataModule.computerlab = Comlab
        Select Case originForm
            Case "ChooseSubjPopup"
                Me.Hide()
                DateTimePick.Show()
            Case "Schedule"
                Me.Hide()
                ComlabSchedule.Show()
        End Select


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Comlab = "1"
        GlobalDataModule.computerlab = Comlab
        Select Case originForm
            Case "ChooseSubjPopup"
                Me.Hide()
                DateTimePick.Show()
            Case "Schedule"
                Me.Hide()
                ComlabSchedule.Show()
        End Select

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Comlab = "2"
        GlobalDataModule.computerlab = Comlab
        Select Case originForm
            Case "ChooseSubjPopup"
                Me.Hide()
                DateTimePick.Show()
            Case "Schedule"
                Me.Hide()
                ComlabSchedule.Show()
        End Select

    End Sub
End Class