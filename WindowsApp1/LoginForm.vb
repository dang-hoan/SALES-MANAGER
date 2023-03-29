Imports LibraryDataset

Public Class LoginForm
    Dim conn As String = "Data Source=DESKTOP-DKTP37G\CSDL;Initial Catalog=SalesManagerDB;User ID=sa;Password=123456"
    Dim clsPMSAnalysis As New LibraryDataset.clsAccount(conn)

    Private Sub bLogin_Click(sender As Object, e As EventArgs) Handles bLogin.Click
        Dim data = clsPMSAnalysis.GetUserByUsername(txtUsername.Text, txtPassword.Text)
        If data._Account.Rows.Count > 0 Then
            Dim main As New MainForm()
            main.Show()
            Me.Hide()

        End If

    End Sub
End Class