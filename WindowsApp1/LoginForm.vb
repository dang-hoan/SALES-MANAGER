Imports LibraryDataset
Imports LibraryCommon

Public Class LoginForm
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsAccount(conn.connSales.ConnectionString)

    Private Sub bLogin_Click(sender As Object, e As EventArgs) Handles bLogin.Click
        Dim data = clsPMSAnalysis.GetUserByUsername(txtUsername.Text, txtPassword.Text)
        If data._Account.Rows.Count > 0 Then
            Dim main As New MainForm()
            main.Show()
            Me.Hide()

        End If

    End Sub
End Class