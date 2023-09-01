Imports System.Net.Mail

Public Class EnterCode
    Public email As String
    Public randomCode As String

    Private timer As Timer
    Private secondsNumber As Integer = 5
    Private count As Integer = secondsNumber

    Private isBack As Boolean = False

    Private Sub EnterCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labNotice.Visible = False
        labCount.Visible = False
        labCount.Text = $"Resent next after {secondsNumber} seconds"
    End Sub
    Private Sub bConfirm_Click(sender As Object, e As EventArgs) Handles bConfirm.Click
        If String.IsNullOrWhiteSpace(txtCode.Text) Then
            MsgBox("Code mustn't be empty!")

        ElseIf Not txtCode.Text.Equals(randomCode) Then
            MsgBox("Code you enter not correct! Please check code again in your email!")

        Else
            Dim frmResetPassword = New ResetPassword()
            frmResetPassword.email = email
            Me.Close()
            frmResetPassword.ShowDialog(LoginForm)
        End If
    End Sub

    Private Sub bResent_Click(sender As Object, e As EventArgs) Handles bResent.Click
        randomCode = GetRandomString(10)
        BackgroundWorker1.RunWorkerAsync()

        ' Set the Interval property to 1000 milliseconds (1 second): after per 1 second it will call timer_tick again
        If timer IsNot Nothing Then
            timer.Stop()
        Else
            timer = New Timer()

            timer.Interval = 1000
            AddHandler timer.Tick, AddressOf Timer_Tick
        End If

        count = secondsNumber
        labNotice.Visible = True
        bResent.Visible = False
        labCount.Visible = True

        ' Start the timer.
        timer.Start()
    End Sub
    Public Function GetRandomString(ByVal length As Integer) As String
        Dim res As String = ""
        Dim rand As New Random()
        For i As Integer = 1 To length
            res &= ChrW(rand.Next(32, 126))
        Next
        Return res
    End Function

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        count -= 1
        labCount.Text = $"Resent next after {count} seconds"
        If count = 0 Then
            labNotice.Visible = False
            CType(sender, Timer).Stop()
            labNotice.Visible = False
            bResent.Visible = True
            labCount.Visible = False
            labCount.Text = $"Resent next after {secondsNumber} seconds"
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
        mail.To.Add(email)
        mail.Subject = "Password Reset Request"
        mail.Body = $"This is code to reset password for your account on sales manager app: {randomCode}. Please don't share it to other people!"

        Try
            ' Send the email
            smtpServer.Send(mail)

        Catch ex As Exception
            MsgBox("There is error when sent code to your email!")
        End Try
    End Sub
    Private Sub bBack_Click(sender As Object, e As EventArgs) Handles bBack.Click
        isBack = True
        Me.Close()
        Dim caller As EnterEmail = CType(Application.OpenForms("EnterEmail"), EnterEmail)
        caller.Show()
    End Sub

    Private Sub bCancel_Click(sender As Object, e As EventArgs) Handles bCancel.Click
        Me.Close()
    End Sub

    Private Sub EnterCode_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not isBack Then
            EnterEmail.Close()
        End If
    End Sub
    Private Sub EnterCode_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            bConfirm_Click(sender, EventArgs.Empty)
        End If
    End Sub

End Class