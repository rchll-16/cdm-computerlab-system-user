Public Class ChooseSubjPopup
    Dim firstSem As Boolean = False
    Dim secondSem As Boolean = True
    Dim selectedSubj As String

    Private Sub cmbMajorSubj_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMajorSubj.SelectedIndexChanged
        If GlobalDataModule.loggedIn_course = "BSIT" And GlobalDataModule.loggedIn_studentYear = "1" And firstSem And Not secondSem Then
            cmbMajorSubj.Items.Add("ITCOMP")
            cmbMajorSubj.Items.Add("PROG 1")
        ElseIf GlobalDataModule.loggedIn_course = "BSIT" And GlobalDataModule.loggedIn_studentYear = "1" And secondSem And Not firstSem Then
            cmbMajorSubj.Items.Add("PROG 2")
        ElseIf GlobalDataModule.loggedIn_course = "BSIT" And GlobalDataModule.loggedIn_studentYear = "2" And firstSem And Not secondSem Then
            cmbMajorSubj.Items.Add("PROG 3")
            cmbMajorSubj.Items.Add("ELECT 1")
            cmbMajorSubj.Items.Add("SIA 1")
        ElseIf GlobalDataModule.loggedIn_course = "BSIT" And GlobalDataModule.loggedIn_studentYear = "2" And secondSem And Not firstSem Then
            cmbMajorSubj.Items.Add("ACSS")
            cmbMajorSubj.Items.Add("ELECT 2")
            cmbMajorSubj.Items.Add("NET 1")
            cmbMajorSubj.Items.Add("FDBS")
            cmbMajorSubj.Items.Add("SSD")
            cmbMajorSubj.Items.Add("IPT")
        ElseIf GlobalDataModule.loggedIn_course = "BSIT" And GlobalDataModule.loggedIn_studentYear = "3" And firstSem And Not secondSem Then
            cmbMajorSubj.Items.Add("NET 2")
            cmbMajorSubj.Items.Add("IM 1")
            cmbMajorSubj.Items.Add("APPSDEV 1")
            cmbMajorSubj.Items.Add("OS")
            cmbMajorSubj.Items.Add("IAS 1")
            cmbMajorSubj.Items.Add("HC1")
            cmbMajorSubj.Items.Add("ADBS")
        ElseIf GlobalDataModule.loggedIn_course = "BSIT" And GlobalDataModule.loggedIn_studentYear = "3" And secondSem And Not firstSem Then
            cmbMajorSubj.Items.Add("IM 2")
            cmbMajorSubj.Items.Add("ELECT 3")
            cmbMajorSubj.Items.Add("SA")
            cmbMajorSubj.Items.Add("IAS 2")
            cmbMajorSubj.Items.Add("IPT")
        ElseIf GlobalDataModule.loggedIn_course = "BSCPE" And GlobalDataModule.loggedIn_studentYear = "1" And firstSem And Not secondSem Then
            cmbMajorSubj.Items.Add("CPECHEM 1")
            cmbMajorSubj.Items.Add("CPEPROG 1")
        ElseIf GlobalDataModule.loggedIn_course = "BSCPE" And GlobalDataModule.loggedIn_studentYear = "1" And secondSem And Not firstSem Then
            cmbMajorSubj.Items.Add("CPEPHY 1")
            cmbMajorSubj.Items.Add("CPEPROG 2")
        ElseIf GlobalDataModule.loggedIn_course = "BSCPE" And GlobalDataModule.loggedIn_studentYear = "2" And firstSem And Not secondSem Then
            cmbMajorSubj.Items.Add("CPEPROG 3")
            cmbMajorSubj.Items.Add("FEC 1")
            cmbMajorSubj.Items.Add("ACD 1A")
        ElseIf GlobalDataModule.loggedIn_course = "BSCPE" And GlobalDataModule.loggedIn_studentYear = "2" And secondSem And Not firstSem Then
            cmbMajorSubj.Items.Add("CPE 7A")
            cmbMajorSubj.Items.Add("ECE 1A")
        ElseIf GlobalDataModule.loggedIn_course = "BSCPE" And GlobalDataModule.loggedIn_studentYear = "3" And firstSem And Not secondSem Then
            cmbMajorSubj.Items.Add("LOGDE")
            cmbMajorSubj.Items.Add("CPE 8")
            cmbMajorSubj.Items.Add("RTES")
        ElseIf GlobalDataModule.loggedIn_course = "BSCPE" And GlobalDataModule.loggedIn_studentYear = "3" And secondSem And Not firstSem Then
            cmbMajorSubj.Items.Add("CANAS")
            cmbMajorSubj.Items.Add("MICRO")
            cmbMajorSubj.Items.Add("HDL")
            cmbMajorSubj.Items.Add("SAES")
        ElseIf GlobalDataModule.loggedIn_course = "BSCPE" And GlobalDataModule.loggedIn_studentYear = "4" And firstSem And Not secondSem Then
            cmbMajorSubj.Items.Add("ES")
            cmbMajorSubj.Items.Add("CAAO")
            cmbMajorSubj.Items.Add("CPEDESIGN 1")
            cmbMajorSubj.Items.Add("CPE 11")
            cmbMajorSubj.Items.Add("MAES")
        ElseIf GlobalDataModule.loggedIn_course = "BSCPE" And GlobalDataModule.loggedIn_studentYear = "4" And secondSem And Not firstSem Then
            cmbMajorSubj.Items.Add("CPEDESIGN 2")
            cmbMajorSubj.Items.Add("CPE 22")
        End If

    End Sub

    Private Sub btnChooseMajorSubj_Click(sender As Object, e As EventArgs) Handles btnChooseMajorSubj.Click
        If cmbMajorSubj.Text = cmbMajorSubj.Items(0) Then
            MessageBox.Show("Please choose a subject", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            selectedSubj = cmbMajorSubj.SelectedItem
            GlobalDataModule.selectedMajorSub = selectedSubj
            Comlab1or2.originForm = ""
            Comlab1or2.originForm = "ChooseSubjPopup"
            Me.Hide()
            Comlab1or2.Show()

            PC_Availability.Hide()
        End If
    End Sub

    Private Sub ChooseSubjPopup_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        cmbMajorSubj.Text = cmbMajorSubj.Items(0)
    End Sub

End Class