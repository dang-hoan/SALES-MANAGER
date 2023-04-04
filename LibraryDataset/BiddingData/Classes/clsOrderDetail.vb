
Imports System.Data.SqlClient

Public Class clsOrderDetail
    Dim ta As New OrderDetailTableAdapters.SalesOrderTableAdapter
    Private conn As New SqlConnection

    Public Sub New(ByVal strConn As String, Optional ByVal strConnTransaction As String = Nothing)
        conn = New SqlConnection(strConn)
    End Sub

    Public Function GetAllSaleOrders() As OrderDetail
        Dim ds As New OrderDetail
        ta.Connection = conn
        ta.Fill(ds.SalesOrder)
        Return ds
    End Function

End Class
