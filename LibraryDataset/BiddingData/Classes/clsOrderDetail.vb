
Imports System.Data.SqlClient

Public Class clsOrderDetail
    Dim ta As New OrderDetailTableAdapters.SalesOrderTableAdapter
    Dim taOrder As New OrderDetailTableAdapters.OrderTableAdapter
    Dim taOrderView As New OrderDetailTableAdapters.OrderViewTableAdapter
    Dim taOrderDetail As New OrderDetailTableAdapters.OrderDetailTableAdapter
    Dim taOrderDetailView As New OrderDetailTableAdapters.OrderDetailViewTableAdapter
    Dim taSalesDetail As New OrderDetailTableAdapters.SalesDetailTableAdapter
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

    Public Function AddOrderDetail(orderId As Long, productId As Long, numberOfProduct As Integer, totalPriceOfProducts As Double) As Integer
        taOrderDetail.Connection = conn
        Return taOrderDetail.InsertOrderDetail(orderId, productId, numberOfProduct, totalPriceOfProducts)
    End Function
    Public Function UpdateOrderDetail(orderId As Long, productId As Long, numberOfProduct As Integer, totalPriceOfProducts As Double) As Integer
        taOrderDetail.Connection = conn
        Return taOrderDetail.UpdateOrderDetail(numberOfProduct, totalPriceOfProducts, orderId, productId)
    End Function
    Public Function DeleteOrderDetail(orderId As Long, productId As Long) As Integer
        taOrderDetail.Connection = conn
        Return taOrderDetail.DeleteOrderDetail(orderId, productId)
    End Function
    Public Function CheckIfOrderDetailExists(orderId As Long, productId As Long) As Boolean
        taOrderDetail.Connection = conn
        If taOrderDetail.GetOrderDetailByOrderIdAndProductId(orderId, productId).Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function GetAllSalesDetail() As OrderDetail.SalesDetailDataTable
        Dim ds As New OrderDetail.SalesDetailDataTable
        taSalesDetail.Connection = conn
        taSalesDetail.Fill(ds)
        Return ds
    End Function
    Public Function GetSalesDetailByProductId(ByVal productId As Long) As OrderDetail.SalesDetailDataTable
        taSalesDetail.Connection = conn
        Return taSalesDetail.GetSalesDetailByProductId(productId)
    End Function
    Public Function UpdateSalesDetail(ByVal WareHouseId As Long, ByVal ProductId As Long, ByVal Total As Long, ByVal SellNumber As Long, ByVal SalesTotal As Double) As Integer
        taSalesDetail.Connection = conn
        Return taSalesDetail.UpdateSalesDetail(WareHouseId, ProductId, Total, SellNumber, SalesTotal)
    End Function
    Public Function GetOrderView() As OrderDetail.OrderViewDataTable
        taOrderView.Connection = conn
        Return taOrderView.GetData()
    End Function
    Public Function GetOrderDetailView() As OrderDetail.OrderDetailViewDataTable
        taOrderDetailView.Connection = conn
        Return taOrderDetailView.GetData()
    End Function
    Public Function SearchOrder(ByVal Id As Long, ByVal CustomerName As String, ByVal OrderDate As Date, ByVal ShipperId As String,
                                ByVal ShipDate As Date, ByVal ShipAddress As String, ByVal StatusId As Integer, ByVal PaymentMethod As String, ByVal searchByDate As Boolean) As OrderDetail.OrderDataTable
        Dim ds As New OrderDetail

        Dim shipIdStr = "AND ShipperId = " & ShipperId
        Dim statusIdStr = "AND StatusId = " & StatusId

        Dim dateStr = "AND OrderDate = " & OrderDate & " AND 
                    ShipDate = " & ShipDate

        If ShipperId Is Nothing Then
            shipIdStr = ""
        End If

        If StatusId = -1 Then
            statusIdStr = ""
        End If

        If searchByDate = False Then
            dateStr = ""
        End If

        Dim query = "SELECT Id, CustomerName, OrderDate, ShipperId, ShipDate, ShipAddress, ShipPostalCode, ShipPrice, StatusId, PrivateDiscount, TotalPrice, PaymentMethod
                    FROM   [Order]
                    WHERE Id = " & Id & shipIdStr & " AND (ShipAddress LIKE '%' " & ShipAddress & " + '%') " & StatusId & " AND (PaymentMethod LIKE '%' + " & PaymentMethod & " + '%') AND (CustomerName LIKE '%' + " & CustomerName & " + '%') " & dateStr
        taOrder.Connection = conn

        Dim command As New SqlCommand(query, conn)
        taOrder.Adapter.SelectCommand = command
        taOrder.Fill(ds.Order)

        Return ds.Order

    End Function

End Class
