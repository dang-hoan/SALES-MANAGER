
Imports System.Data.SqlClient

Public Class clsAccount
    Dim ta As New AccountTableAdapters.AccountTableAdapter

    Private strConnTrans As String
    Private strAuditTrans As String
    Private conn As New SqlConnection
    Private connTransaction As New SqlConnection

    Public Sub New(ByVal strConn As String, Optional ByVal strConnTransaction As String = Nothing)
        strConnTrans = strConn
        conn = New SqlConnection(strConn)
        connTransaction = New SqlConnection(strConnTransaction)
    End Sub

    Public Function GetUserByUsername(ByVal username As String, ByVal password As String) As Account
        Dim ds1 As New Account
        ta.Connection = conn
        ta.FillBy(ds1._Account, username, password)
        Return ds1
    End Function

End Class
