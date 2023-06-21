
Imports System.Data.SqlClient

Public Class clsOrderDetail
    Dim ta As New OrderDetailTableAdapters.SalesOrderViewTableAdapter
    Dim taOrder As New OrderDetailTableAdapters.OrderTableAdapter
    Dim taOrderView As New OrderDetailTableAdapters.OrderViewTableAdapter
    Dim taOrderDetail As New OrderDetailTableAdapters.OrderDetailTableAdapter
    Dim taOrderDetailView As New OrderDetailTableAdapters.OrderDetailViewTableAdapter
    Dim taSalesDetail As New OrderDetailTableAdapters.SalesDetailTableAdapter
    Private conn As New SqlConnection

    Public Sub New(ByVal strConn As String, Optional ByVal strConnTransaction As String = Nothing)
        conn = New SqlConnection(strConn)
    End Sub
    Public Function AddOrder(customerName As String, orderDate As Date,
                             shipperId As Long, shipDate As Date, shipAddress As String,
                             shipPrice As Double, statusId As Integer, privateDiscount As Double,
                             totalPrice As Double, paymentMethodId As Integer, note As String, createUser As String) As Integer
        taOrder.Connection = conn
        Return taOrder.InsertOrder(customerName, orderDate, shipperId, shipDate, shipAddress, Nothing, shipPrice, statusId, privateDiscount, totalPrice, paymentMethodId, note, DateTime.Now, createUser)
    End Function
    Public Function UpdateOrder(id As Long, customerName As String, orderDate As Date,
                             shipperId As Long, shipDate As Date, shipAddress As String,
                             shipPrice As Double, statusId As Integer, privateDiscount As Double,
                             totalPrice As Double, paymentMethodId As Integer, note As String, updateUser As String) As Integer
        taOrder.Connection = conn
        Return taOrder.UpdateOrder(customerName, orderDate, shipperId, shipDate, shipAddress, Nothing, shipPrice, statusId, privateDiscount, totalPrice, paymentMethodId, note, DateTime.Now, updateUser, id)
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
    Public Function GetSalesDetailByWarehouseId(ByVal warehouseId As Long) As OrderDetail.SalesDetailDataTable
        taSalesDetail.Connection = conn
        Return taSalesDetail.GetSalesDetailByWarehouseId(warehouseId)
    End Function
    Public Function GetSalesDetailByProductName(ByVal productName As String) As OrderDetail.SalesDetailDataTable
        taSalesDetail.Connection = conn
        Return taSalesDetail.GetSalesDetailByProductName(productName)
    End Function
    Public Function UpdateSalesDetail(ByVal WareHouseId As Long, ByVal ProductId As Long, ByVal Total As Long, ByVal SellNumber As Long, ByVal SalesTotal As Double) As Integer
        taSalesDetail.Connection = conn
        Return taSalesDetail.UpdateSalesDetail(WareHouseId, ProductId, Total, SellNumber, SalesTotal)
    End Function
    Public Function GetOrderDetailView() As OrderDetail.OrderDetailViewDataTable
        taOrderDetailView.Connection = conn
        Return taOrderDetailView.GetData()
    End Function

    Public Function GetSalesOrderById(ByVal orderId As Long) As DataRow
        ta.Connection = conn
        Return ta.GetSalesOrderById(orderId).Rows(0)
    End Function
    Public Function GetProductsInforByOrderId(ByVal orderId As Long) As OrderDetail.OrderDetailDataTable
        taOrderDetail.Connection = conn
        Return taOrderDetail.GetProductsInforByOrderId(orderId)
    End Function
    Public Function SearchSalesOrder(ByVal sqlCommand As String) As OrderDetail.SalesOrderViewDataTable
        Dim ds As New OrderDetail

        Dim cmd = conn.CreateCommand()

        cmd.CommandText = "SELECT *
                           FROM SalesOrderView
                           WHERE IsDelete = 'False'" & sqlCommand

        ta.Connection = conn

        Dim tmp = cmd.CommandText.ToString()
        Console.WriteLine(tmp)

        ta.Adapter.SelectCommand = cmd
        ta.Adapter.Fill(ds.SalesOrderView)

        Return ds.SalesOrderView

    End Function

    Public Function GetMaxYear() As Integer
        taOrderView.Connection = conn
        Return taOrderView.GetMaxYear()
    End Function
    Public Function GetMinYear() As Integer
        taOrderView.Connection = conn
        Return taOrderView.GetMinYear()
    End Function
    Public Function GetSalesByDate(ByVal shipDate As String) As OrderDetail.OrderViewDataTable
        taOrderView.Connection = conn
        Return taOrderView.GetSalesByDate(shipDate)
    End Function
    Public Function GetSalesByDateAndProductId(ByVal shipDate As String, ByVal productId As Long) As OrderDetail.OrderDetailViewDataTable
        taOrderDetailView.Connection = conn
        Return taOrderDetailView.GetSalesByDateAndProductId(shipDate, productId)
    End Function
    Public Function GetSalesByDateAndWarehouseId(ByVal shipDate As String, ByVal warehouseId As Long) As OrderDetail.OrderDetailViewDataTable
        taOrderDetailView.Connection = conn
        Return taOrderDetailView.GetSalesByDateAndWarehouseId(shipDate, warehouseId)
    End Function
    Public Function GetSalesByDateAndProductName(ByVal shipDate As String, ByVal productName As String) As OrderDetail.OrderDetailViewDataTable
        taOrderDetailView.Connection = conn
        Return taOrderDetailView.GetSalesByDateAndProductName(shipDate, productName)
    End Function
    Public Function GetSalesByMonth(ByVal shipMonth As String) As OrderDetail.OrderViewDataTable
        taOrderView.Connection = conn
        Return taOrderView.GetSalesByMonth(shipMonth)
    End Function
    Public Function GetSalesByMonthAndProductId(ByVal shipMonth As String, ByVal productId As Long) As OrderDetail.OrderDetailViewDataTable
        taOrderDetailView.Connection = conn
        Return taOrderDetailView.GetSalesByMonthAndProductId(shipMonth, productId)
    End Function
    Public Function GetSalesByMonthAndWareHouseId(ByVal shipMonth As String, ByVal warehouseId As Long) As OrderDetail.OrderDetailViewDataTable
        taOrderDetailView.Connection = conn
        Return taOrderDetailView.GetSalesByMonthAndWareHouseId(shipMonth, warehouseId)
    End Function
    Public Function GetSalesByMonthAndProductName(ByVal shipMonth As String, ByVal productName As String) As OrderDetail.OrderDetailViewDataTable
        taOrderDetailView.Connection = conn
        Return taOrderDetailView.GetSalesByMonthAndProductName(shipMonth, productName)
    End Function

    Public Function GetSalesByYear(ByVal shipYear As String) As OrderDetail.OrderViewDataTable
        taOrderView.Connection = conn
        Return taOrderView.GetSalesByYear(shipYear)
    End Function
    Public Function GetSalesByYearAndProductId(ByVal shipYear As String, ByVal productId As Long) As OrderDetail.OrderDetailViewDataTable
        taOrderDetailView.Connection = conn
        Return taOrderDetailView.GetSalesByYearAndProductId(shipYear, productId)
    End Function
    Public Function GetSalesByYearAndWareHouseId(ByVal shipYear As String, ByVal warehouseId As Long) As OrderDetail.OrderDetailViewDataTable
        taOrderDetailView.Connection = conn
        Return taOrderDetailView.GetSalesByYearAndWarehouseId(shipYear, warehouseId)
    End Function
    Public Function GetSalesByYearAndProductName(ByVal shipYear As String, ByVal productName As String) As OrderDetail.OrderDetailViewDataTable
        taOrderDetailView.Connection = conn
        Return taOrderDetailView.GetSalesByYearAndProductName(shipYear, productName)
    End Function


End Class
