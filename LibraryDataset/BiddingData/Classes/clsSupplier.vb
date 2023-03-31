
Imports System.Data.SqlClient

Public Class clsSupplier
    Dim ta As New SupplierTableAdapters.SupplierTableAdapter

    Private strConnTrans As String
    Private strAuditTrans As String
    Private conn As New SqlConnection
    Private connTransaction As New SqlConnection

    Public Sub New(ByVal strConn As String, Optional ByVal strConnTransaction As String = Nothing)
        strConnTrans = strConn
        conn = New SqlConnection(strConn)
        connTransaction = New SqlConnection(strConnTransaction)
    End Sub

    Public Function GetUserByUsername(ByVal username As String, ByVal password As String) As Supplier
        Dim ds1 As New Supplier
        ta.Connection = conn
        'ta.FillBy(ds1._Supplier, username, password)
        Return ds1
    End Function

End Class
