
Imports System.Data.SqlClient

Public Class clsCBB
    Dim taWareHouse As New CBBTableAdapters.CBBWareHouseTableAdapter
    Dim taProduct As New CBBTableAdapters.CBBProductTableAdapter
    Dim taCategory As New CBBTableAdapters.CBBCategoryTableAdapter
    Dim taSupplier As New CBBTableAdapters.CBBSupplierTableAdapter
    Dim taStatus As New CBBTableAdapters.CBBStatusTableAdapter
    Dim taPerson As New CBBTableAdapters.CBBPersonTableAdapter
    Private conn As New SqlConnection

    Public Sub New(ByVal strConn As String, Optional ByVal strConnTransaction As String = Nothing)
        conn = New SqlConnection(strConn)
    End Sub

    Public Function GetAllProduct() As Product
        Dim ds1 As New Product
        taWareHouse.Connection = conn
        'ta.Fill(ds1._Product)
        Return ds1
    End Function

    Public Function GetCBBWareHouse() As CBB
        Dim ds1 As New CBB
        taWareHouse.Connection = conn
        taWareHouse.Fill(ds1.CBBWareHouse)
        Return ds1
    End Function
    Public Function GetCBBWareHouseOfProduct(ByVal productId As String) As CBB
        Dim ds1 As New CBB
        taWareHouse.Connection = conn
        taWareHouse.FillByWareHousesOfAProduct(ds1.CBBWareHouse, productId)
        Return ds1
    End Function
    Public Function GetCBBProduct() As CBB
        Dim ds1 As New CBB
        taProduct.Connection = conn
        taProduct.Fill(ds1.CBBProduct)
        Return ds1
    End Function
    Public Function GetCBBProductOfWareHouse(ByVal warehouseId As String) As CBB
        Dim ds1 As New CBB
        taProduct.Connection = conn
        taProduct.FillByProductsOfAWareHouse(ds1.CBBProduct, warehouseId)
        Return ds1
    End Function
    Public Function GetCBBSaleDetail(ByVal warehouseId As String) As CBB
        Dim ds1 As New CBB
        'taProduct.Connection = conn
        'taProduct.Fi(ds1.CBBProduct, warehouseId)
        Return ds1
    End Function
    Public Function GetCBBCategory() As CBB
        Dim ds1 As New CBB
        taCategory.Connection = conn
        taCategory.Fill(ds1.CBBCategory)
        Return ds1
    End Function
    Public Function GetCBBSupplier() As CBB
        Dim ds1 As New CBB
        taSupplier.Connection = conn
        taSupplier.Fill(ds1.CBBSupplier)
        Return ds1
    End Function
    Public Function GetCBBStatusOfProduct() As CBB
        Dim ds1 As New CBB
        taStatus.Connection = conn
        taStatus.Fill(ds1.CBBStatus, "Product")
        Return ds1
    End Function
    Public Function GetCBBShipper() As CBB
        Dim ds1 As New CBB
        taPerson.Connection = conn
        taPerson.FillByShipper(ds1.CBBPerson)
        Return ds1
    End Function
    Public Function GetCBBStatusOfOrder() As CBB
        Dim ds1 As New CBB
        taStatus.Connection = conn
        taStatus.Fill(ds1.CBBStatus, "Order")
        Return ds1
    End Function

End Class
