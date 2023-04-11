
Imports System.Data.SqlClient

Public Class clsProduct
    Dim ta As New ProductTableAdapters.ProductTableAdapter
    Dim taCostProduct As New ProductTableAdapters.CostProductTableAdapter
    Dim taSalesDetail As New ProductTableAdapters.SalesDetailTableAdapter
    Dim taProductSalesDetail As New ProductTableAdapters.ProductSalesDetailTableAdapter


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
        taProductSalesDetail.Connection = conn
        taProductSalesDetail.Fill(ds1.ProductSalesDetail)
        Return ds1
    End Function

    Public Function CheckProductExits(productId As Long) As Boolean
        ta.Connection = conn
        Dim result = ta.CheckProductExists(productId).Count
        If result = 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function EditProduct(productCode As Long, productName As String, supplierId As Long, categoryId As Long,
                                productPrice As Double, unitPrice As String, productStatus As Integer,
                                discountPercent As Double, rating As Integer, imageId As Long, wareHouseId As Long, total As Long, updateUser As String) As Integer
        ta.Connection = conn
        taSalesDetail.Connection = conn
        Dim result1 = ta.UpdateProduct(productName, supplierId, categoryId, productPrice, unitPrice, productStatus, discountPercent, rating, imageId, DateTime.Now, updateUser, productCode)
        Dim result2 = taSalesDetail.UpdateSalesDetail(wareHouseId, total, productCode)
        If result1 = 1 And result2 = 1 Then
            Return 1
        Else
            Return -1
        End If
    End Function
    Public Function AddProduct(productName As String, supplierId As Long, categoryId As Long,
                                productPrice As Double, unitPrice As String, productStatus As Integer,
                                discountPercent As Double, rating As Integer, imageId As Long, wareHouseId As Long, total As Long, createUser As String) As Integer
        ta.Connection = conn
        taSalesDetail.Connection = conn

        Dim productId = ta.InsertProduct(productName, supplierId, categoryId, productPrice, unitPrice, productStatus, discountPercent, rating, imageId, DateTime.Now, createUser, False)
        Dim result = taSalesDetail.InsertSalesDetail(wareHouseId, productId, total)

        If result = 1 Then
            Return 1
        Else
            Return -1
        End If
    End Function

    Public Function DeleteProduct(ByVal deleteUsername As String, ByVal productId As Long) As Integer
        ta.Connection = conn
        Return ta.DeleteProduct(DateTime.Now, deleteUsername, productId)
    End Function
    Public Function RestoreProduct(ByVal productId As Long) As Integer
        ta.Connection = conn
        Return ta.RestoreProduct(productId)
    End Function
    Public Function CheckProductWasDeleted(ByVal productId As Long) As Integer
        ta.Connection = conn
        Dim result = ta.CheckProductWasDeleted(productId).Count
        If result > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function GetCostOfProduct(ByVal productId As Long) As Product.CostProductDataTable
        taCostProduct.Connection = conn
        Return taCostProduct.GetCostOfProduct(productId)
    End Function


End Class
