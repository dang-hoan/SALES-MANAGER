Imports LibraryDataset
Imports LibraryCommon

Public Class LoginForm
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsAccount(conn.connSales.ConnectionString)
    Private username As String

    Private Sub bLogin_Click(sender As Object, e As EventArgs) Handles bLogin.Click
        Dim data = clsPMSAnalysis.GetUserByUsername(txtUsername.Text, txtPassword.Text)
        If data._Account.Rows.Count > 0 Then
            Dim main As New MainForm()
            main.Show()
            Me.Hide()
            username = txtUsername.Text
        End If

    End Sub

    Public ReadOnly Property ProbUsername As String
        Get
            Return username
        End Get
    End Property


End Class