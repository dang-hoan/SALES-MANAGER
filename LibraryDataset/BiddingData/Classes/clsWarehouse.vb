Imports System.Data.SqlClient
Public Class clsWarehouse
    Dim ta As New WarehouseTableAdapters.WareHouseTableAdapter
    Dim taSalesDetail As New WarehouseTableAdapters.SalesDetailTableAdapter
    Private conn As New SqlConnection
    Public Sub New(ByVal strConn As String)
        conn = New SqlConnection(strConn)
    End Sub
    Public Function GetWarehouse() As Warehouse.WareHouseDataTable
        ta.Connection = conn
        Return ta.GetData()
    End Function
    Public Function GetProductsOfWarehouse(ByVal warehouseId As Long) As Warehouse.SalesDetailDataTable
        taSalesDetail.Connection = conn
        Return taSalesDetail.GetData(warehouseId)
    End Function
    Public Function AddWarehouse(ByVal warehouseName As String, ByVal address As String, ByVal numberOfImport As Long, ByVal numberOfExport As Long, ByVal createUser As String) As Integer
        ta.Connection = conn
        Return ta.InsertWarehouse(warehouseName, address, numberOfImport, numberOfExport, DateTime.Now, createUser)
    End Function
    Public Function UpdateWarehouse(ByVal warehouseId As Long, ByVal warehouseName As String, ByVal address As String, ByVal numberOfImport As Long, ByVal numberOfExport As Long, ByVal updateUser As String) As Integer
        ta.Connection = conn
        Return ta.UpdateWarehouse(warehouseName, address, numberOfImport, numberOfExport, DateTime.Now, updateUser, warehouseId)
    End Function
    Public Function DeleteWarehouse(ByVal warehouseId As Long, ByVal deleteUser As String) As Integer
        ta.Connection = conn
        Return ta.DeleteWarehouse(DateTime.Now, deleteUser, warehouseId)
    End Function
End Class
