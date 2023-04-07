
Imports System.Data.SqlClient

Public Class clsOrderDetail
    Dim ta As New OrderDetailTableAdapters.SalesOrderTableAdapter
    Dim taOrder As New OrderDetailTableAdapters.OrderTableAdapter
    Dim taOrderDetail As New OrderDetailTableAdapters.OrderDetailTableAdapter
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
    Public Function AddOrder(customerName As String, orderDate As Date,
                             shipperId As String, shipDate As Date, shipAddress As String,
                             shipPrice As Double, statusId As Integer, privateDiscount As Double,
                             totalPrice As Double, paymentMethod As String, note As String, createUser As String) As Integer
        taOrder.Connection = conn
        Return taOrder.InsertOrder(customerName, orderDate, shipperId, shipDate, shipAddress, Nothing, shipPrice, statusId, privateDiscount, totalPrice, paymentMethod, note, DateTime.Now, createUser)
    End Function
    Public Function UpdateOrder(id As Long, customerName As String, orderDate As Date,
                             shipperId As String, shipDate As Date, shipAddress As String,
                             shipPrice As Double, statusId As Integer, privateDiscount As Double,
                             totalPrice As Double, paymentMethod As String, note As String, updateUser As String) As Integer
        taOrder.Connection = conn
        Return taOrder.UpdateOrder(customerName, orderDate, shipperId, shipDate, shipAddress, Nothing, shipPrice, statusId, privateDiscount, totalPrice, paymentMethod, note, DateTime.Now, updateUser, id)
    End Function
    Public Function DeleteOrder(id As Long, deleteUser As String) As Integer
        taOrder.Connection = conn
        Return taOrder.DeleteOrder(DateTime.Now, deleteUser, id)
    End Function
    Public Function UpdateOrderStatus(orderId As Long, statusId As Integer, updateUser As String) As Integer
        taOrder.Connection = conn
        Return taOrder.UpdateOrderStatus(statusId, DateTime.Now, updateUser, orderId)
    End Function

    Public Function AddOrderDetail(orderId As Long, productId As Long, numberOfProduct As Integer) As Integer
        taOrderDetail.Connection = conn
        Return taOrderDetail.InsertOrderDetail(orderId, productId, numberOfProduct)
    End Function
    Public Function UpdateOrderDetail(orderId As Long, productId As Long, numberOfProduct As Integer) As Integer
        taOrderDetail.Connection = conn
        Return taOrderDetail.UpdateOrderDetail(numberOfProduct, orderId, productId)
    End Function
    Public Function CheckIfOrderDetailExists(orderId As Long, productId As Long) As Boolean
        taOrderDetail.Connection = conn
        If taOrderDetail.GetOrderDetailByOrderIdAndProductId(orderId, productId).Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
