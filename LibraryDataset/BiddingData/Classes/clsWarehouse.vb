Imports System.Data.SqlClient
Public Class clsWarehouse
    Dim ta As New WarehouseTableAdapters.WareHouseTableAdapter
    Private conn As New SqlConnection
    Public Sub New(ByVal strConn As String)
        conn = New SqlConnection(strConn)
    End Sub
    Public Function GetWarehouse() As Warehouse.WareHouseDataTable
        ta.Connection = conn
        Return ta.GetData()
    End Function
End Class
