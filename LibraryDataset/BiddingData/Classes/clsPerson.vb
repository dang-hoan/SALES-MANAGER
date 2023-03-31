
Imports System.Data.SqlClient

Public Class clsPerson
    Dim ta As New PersonTableAdapters.PersonTableAdapter

    Private strConnTrans As String
    Private strAuditTrans As String
    Private conn As New SqlConnection
    Private connTransaction As New SqlConnection

    Public Sub New(ByVal strConn As String, Optional ByVal strConnTransaction As String = Nothing)
        strConnTrans = strConn
        conn = New SqlConnection(strConn)
        connTransaction = New SqlConnection(strConnTransaction)
    End Sub

    Public Function GetCustomers() As Person
        Dim ds1 As New Person
        ta.Connection = conn
        ta.FillByCustomers(ds1._Person)
        Return ds1
    End Function

End Class
