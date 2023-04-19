Imports LibraryDataset
Imports LibraryCommon
Imports System.IO

Public Class LoginForm
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsAccount(conn.connSales.ConnectionString)
    Dim clsPerson As New clsPerson(conn.connSales.ConnectionString)
    Private username As String
    Private isShow As Boolean = False

    Private Sub bLogin_Click(sender As Object, e As EventArgs) Handles bLogin.Click
        login()
    End Sub
    Private Sub login()
        Dim data = clsPMSAnalysis.GetUserByUsername(txtUsername.Text, txtPassword.Text)
        If data._Account.Rows.Count > 0 Then
            Dim IsDelete = clsPMSAnalysis.CheckUserWasDeleted(txtUsername.Text)
            If Not IsDelete Then
                username = txtUsername.Text
                Dim main As New MainForm()
                main.Show()
                Me.Hide()
                txtPassword.Text = ""
            Else
                MsgBox("Your account was deleted from the system!")
            End If
        Else
            MsgBox("Username or password isn't correct!")
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