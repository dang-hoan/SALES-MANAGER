Imports LibraryDataset
Imports LibraryCommon
Imports System.IO

Public Class LoginForm
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsAccount(conn.connSales.ConnectionString)
    Private username As String
    Private isShow As Boolean = False

    Private Sub bLogin_Click(sender As Object, e As EventArgs) Handles bLogin.Click
        login()
    End Sub
    Private Sub login()
        If txtUsername.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Then
            MsgBox("Username and password can't be empty!", Nothing, "Notification")
            Return
        End If

        If clsPMSAnalysis.CheckUserExists(txtUsername.Text, txtPassword.Text) Then
            Dim statusName = clsPMSAnalysis.GetStatusOfAccount(txtUsername.Text).Rows(0)(1)

            Select Case statusName
                Case "ACTIVITIED"
                    username = txtUsername.Text
                    Dim main As New MainForm()
                    main.Show()
                    Me.Hide()
                    txtPassword.Text = ""
                Case "BLOCK"
                    MsgBox("Your account is blocked from logging into the system!", Nothing, "Notification")
                Case "DELETED"
                    MsgBox("Your account is deleted from the system!", Nothing, "Notification")
                Case "PENDING"
                    MsgBox("Your account is pending!", Nothing, "Notification")
                Case "NOT ACTIVITIED"          'Ví dụ xin nghỉ làm thời gian hoặc mới vào làm ở cty
                    MsgBox("Your account is not activitied yet!", Nothing, "Notification")
            End Select
        Else
            MsgBox("Username or password isn't correct!", Nothing, "Notification")
        End If
    End Sub

    Public ReadOnly Property PropUsername As String
        Get
            Return username
        End Get
    End Property

    Private Sub labShowPassword_Click(sender As Object, e As EventArgs) Handles labShowPassword.Click
        isShow = Not isShow
        Dim pathFileExe = Application.StartupPath
        If isShow Then
            labShowPassword.Image = Image.FromFile(Path.Combine(pathFileExe, "../../Images/view2.png"))
            txtPassword.UseSystemPasswordChar = False
        Else
            labShowPassword.Image = Image.FromFile(Path.Combine(pathFileExe, "../../Images/hide2.png"))
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub LoginForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub
End Class