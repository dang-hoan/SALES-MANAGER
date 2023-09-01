
Imports System.IO
Imports LibraryCommon
Imports LibraryDataset
Public Class ResetPassword
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsAccount(conn.connSales.ConnectionString)
    Dim clsPerson As New clsPerson(conn.connSales.ConnectionString)

    Public email As String
    Private isShow = False
    Private Sub bConfirm_Click(sender As Object, e As EventArgs) Handles bConfirm.Click
        If String.IsNullOrWhiteSpace(txtNewPassword.Text) Or String.IsNullOrWhiteSpace(txtReEnterPassword.Text) Then
            MsgBox("Password mustn't be empty!")

        ElseIf Not txtNewPassword.Text.Equals(txtReEnterPassword.Text) Then
            MsgBox("The re-enter password not match with the new password!")

        Else
            Dim result = clsPMSAnalysis.UpdatePasswordByEmail(txtNewPassword.Text, email, clsPerson.GetAccountNameByEmail(email))

            If result Then
                MsgBox("Change password successfully! Please login again!")
                Me.Close()
            Else
                MsgBox("There is an error when update your password! Please try again!")

            End If
        End If
    End Sub
    Private Sub bCancel_Click(sender As Object, e As EventArgs) Handles bCancel.Click
        Me.Close()
    End Sub

    Private Sub ResetPassword_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        EnterEmail.Close()
        LoginForm.Show()
    End Sub
    Private Sub ResetPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            bConfirm_Click(sender, EventArgs.Empty)
        End If
    End Sub

    Private Sub labShowPassword_Click(sender As Object, e As EventArgs) Handles labShowNewPassword.Click, labShowReEnterPassword.Click
        isShow = Not isShow
        Dim pathFileExe = Application.StartupPath
        If isShow Then
            labShowNewPassword.Image = Image.FromFile(Path.Combine(pathFileExe, "../../Images/view2.png"))
            labShowReEnterPassword.Image = Image.FromFile(Path.Combine(pathFileExe, "../../Images/view2.png"))
            txtNewPassword.UseSystemPasswordChar = False
            txtReEnterPassword.UseSystemPasswordChar = False
        Else
            labShowNewPassword.Image = Image.FromFile(Path.Combine(pathFileExe, "../../Images/hide2.png"))
            labShowReEnterPassword.Image = Image.FromFile(Path.Combine(pathFileExe, "../../Images/hide2.png"))
            txtNewPassword.UseSystemPasswordChar = True
            txtReEnterPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class