Imports System.Net.Mail
Imports LibraryCommon
Imports LibraryDataset

Public Class EnterEmail
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsPerson(conn.connSales.ConnectionString)
    Dim randomCode As String
    Private Sub bConfirm_Click(sender As Object, e As EventArgs) Handles bConfirm.Click
        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MsgBox("Email mustn't be empty!")

        ElseIf Not clsPMSAnalysis.CheckEmailExists(txtEmail.Text.Trim()) Then
            MsgBox("Email you enter not belong to any account in system!")

        Else
            randomCode = GetRandomString(10)
            BackgroundWorker1.RunWorkerAsync()

            Dim frmEnterCode = New EnterCode()
            frmEnterCode.email = txtEmail.Text
            frmEnterCode.randomCode = randomCode
            Me.Hide()
            frmEnterCode.ShowDialog(LoginForm)

        End If
    End Sub

    Public Function GetRandomString(ByVal length As Integer) As String
        Dim res As String = ""
        Dim rand As New Random()
        For i As Integer = 1 To length
            res &= ChrW(rand.Next(32, 126))
        Next
        Return res
    End Function

    Private Sub bCancel_Click(sender As Object, e As EventArgs) Handles bCancel.Click
        Me.Close()
    End Sub

    Private Sub EnterEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            bConfirm_Click(sender, EventArgs.Empty)
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        '' Define your SMTP server settings
        Dim smtpServer As New SmtpClient()
        smtpServer.Host = "smtp.gmail.com"
        smtpServer.Port = 587
        smtpServer.Credentials = New System.Net.NetworkCredential("danghoan77777@gmail.com", "vqbjrjfnupsocwlt")
        smtpServer.EnableSsl = True

        ' Create a new email message
        Dim mail As New MailMessage()
        mail.From = New MailAddress("danghoan77777@gmail.com")
        mail.To.Add(txtEmail.Text)
        mail.Subject = "Password Reset Request"

        mail.Body = $"This is code to reset password for your account on sales manager app: {randomCode}. Please don't share it to other people!"

        Try
            ' Send the email
            smtpServer.Send(mail)

        Catch ex As Exception
            MsgBox("There is error when sent code to your email!")
        End Try

    End Sub
End Class