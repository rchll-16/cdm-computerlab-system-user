Imports System.IO
Imports Aspose.Pdf
Imports Aspose.Pdf.Forms
Imports MimeKit
Imports MailKit.Net.Smtp

Module SendEmailWithAsposePDF

    Public Sub SendEmail()
        Try
            ' Palitan nyo to ng location kung saan nakalagay yung inyong project, dito dapat yung exact location ng Template na ginamit
            Dim templatePath As String = "C:\Users\user\Documents\CDMLABdeskapp_LatestnaFinal\CDMLABdeskapp 5-26-24 ORDOVIZ\CDMLABdeskapp\SLIP.pdf"
            Dim outputPath As String = GenerateOutputPath()

            ' Data to fill in the PDF
            Dim data As New Dictionary(Of String, String) From {
                {"studentName", GlobalDataModule.loggedIn_fullName},
                {"studentNo", GlobalDataModule.loggedIn_studentNo},
                {"yearSec", GlobalDataModule.loggedIn_yearAndSection},
                {"majorSubj", GlobalDataModule.selectedMajorSub},
                {"reserveDate", GlobalDataModule.reservation_Date},
                {"startTime", GlobalDataModule.reservation_TimeStart},
                {"comlab", GlobalDataModule.computerlab},
                {"pcSlot", GlobalDataModule.pcSlot},
                {"endTime", GlobalDataModule.reservation_TimeEnd}
            }

            ' Fill the PDF form
            FillPdfForm(templatePath, outputPath, data)

            ' Create a new MimeMessage
            Dim message As New MimeMessage()
            message.From.Add(New MailboxAddress(GlobalDataModule.loggedIn_fullName, "jhanra.ordoviz22@gmail.com"))
            message.To.Add(New MailboxAddress("", GlobalDataModule.loggedIn_email))
            message.Subject = "Reservation in Computer Laboratory at Colegio de Montalban"

            ' Create the body of the email
            Dim bodyBuilder As New BodyBuilder()
            bodyBuilder.TextBody = $"Good day, {GlobalDataModule.loggedIn_fullName}! You have reserved a schedule successfully!"
            bodyBuilder.Attachments.Add(outputPath) ' Attach the filled PDF

            ' Set the message body
            message.Body = bodyBuilder.ToMessageBody()

            ' Configure the SMTP client and send the email
            Using client As New SmtpClient()
                client.Connect("smtp.gmail.com", 465, MailKit.Security.SecureSocketOptions.SslOnConnect)
                client.Authenticate("jhanra.ordoviz22@gmail.com", "joiv lwak hmyp opry")
                client.Send(message)
                client.Disconnect(True)
            End Using

            MessageBox.Show("Email sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error sending email: " & ex.Message)
        End Try
    End Sub

    Private Sub FillPdfForm(templatePath As String, outputPath As String, formData As Dictionary(Of String, String))
        ' Load the template PDF
        Dim document As New Document(templatePath)
        Dim form As Form = document.Form

        ' Iterate over the form data and fill form fields
        For Each keyValue In formData
            FillField(form, keyValue.Key, keyValue.Value)
        Next

        ' Save the modified PDF
        document.Save(outputPath)
    End Sub

    Private Sub FillField(form As Form, fieldName As String, fieldValue As String)
        Dim field As Field = form(fieldName)
        If field IsNot Nothing Then
            field.Value = fieldValue
        Else
            MessageBox.Show($"Field '{fieldName}' not found in the PDF.")
        End If
    End Sub

    Private Function GenerateOutputPath() As String
        ' Generate a unique file name based on timestamp
        Dim timestamp As String = DateTime.Now.ToString("yyyyMMddHHmmss")
        Dim fileName As String = $"{GlobalDataModule.loggedIn_lName}_{GlobalDataModule.loggedIn_fName}_{timestamp}.pdf"

        ' Palitan nyo to ng location kung saan nakalagay yung inyong project, kung wala kayong output folder, automatic na gagawa yan kaya wag nyo na gawan
        Dim outputDirectory As String = "C:\Users\user\Documents\CDMLABdeskapp_LatestnaFinal\CDMLABdeskapp 5-26-24 ORDOVIZ\CDMLABdeskapp\output"

        ' Ensure the directory exists
        If Not Directory.Exists(outputDirectory) Then
            Directory.CreateDirectory(outputDirectory)
        End If

        ' Return the full output file path
        Return Path.Combine(outputDirectory, fileName)
    End Function

End Module
