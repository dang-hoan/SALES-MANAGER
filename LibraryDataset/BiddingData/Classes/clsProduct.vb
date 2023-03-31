
Imports System.Data.SqlClient

Public Class clsProduct
    Dim ta As New ProductTableAdapters.ProductTableAdapter


    Private strConnTrans As String
    Private strAuditTrans As String
    Private conn As New SqlConnection
    Private connTransaction As New SqlConnection

    Public Sub New(ByVal strConn As String, Optional ByVal strConnTransaction As String = Nothing)
        strConnTrans = strConn
        conn = New SqlConnection(strConn)
        connTransaction = New SqlConnection(strConnTransaction)
    End Sub

    Public Function GetAllProduct() As Product
        Dim ds1 As New Product
        ta.Connection = conn
        ta.Fill(ds1._Product)
        Return ds1
    End Function

    Public Function GetCBBProduct() As Product
        Dim ds1 As New Product
        ta.Connection = conn
        ta.FillBy(ds1._Product)
        Return ds1
    End Function

End Class
