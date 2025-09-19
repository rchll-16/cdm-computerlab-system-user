Module GlobalDataModule
    Public reservationCount As New Dictionary(Of String, Integer)()
    Public isLoggedIn As Boolean = False
    Public loggedIn_lName As String
    Public loggedIn_fName As String
    Public loggedIn_studentNo As String
    Public loggedIn_gender As String
    Public loggedIn_email As String
    Public loggedIn_course As String
    Public loggedIn_studentYear As String
    Public loggedIn_section As String
    Public loggedIn_fullName As String
    Public loggedIn_yearAndSection As String

    Public reservation_Start As DateTime
    Public reservation_End As DateTime
    Public reservation_Date As DateTime
    Public reservation_TimeStart As DateTime
    Public reservation_TimeEnd As DateTime
    Public pcSlot As String
    Public computerlab As String
    Public selectedMajorSub As String

    Sub profileClear()
        loggedIn_lName = ""
        loggedIn_fName = ""
        loggedIn_studentNo = ""
        loggedIn_gender = ""
        loggedIn_email = ""
        loggedIn_course = ""
        loggedIn_studentYear = ""
        loggedIn_section = ""
        loggedIn_fullName = ""
        loggedIn_yearAndSection = ""

    End Sub

    Sub reservationClear()
        pcSlot = ""
        computerlab = ""
        selectedMajorSub = ""
    End Sub
End Module
