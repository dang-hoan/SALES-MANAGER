Imports LibraryDataset
Imports LibraryCommon

Public Class WarehouseReport
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsCBB(conn.connSales.ConnectionString)
    Private Sub WarehouseReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataProduct = clsPMSAnalysis.GetCBBProduct().CBBProduct
        Dim dataWareHouse = clsPMSAnalysis.GetCBBWareHouse().CBBWareHouse

        cbbWarehouse.Items.Clear()
        cbbProduct.Items.Clear()

        cbbWarehouse.Items.Add("")
        cbbProduct.Items.Add("")
        For Each row As DataRow In dataWareHouse.Rows
            cbbWarehouse.Items.Add(New CBBItem(row(0), row(1)))
        Next

        For Each row As DataRow In dataProduct.Rows
            cbbProduct.Items.Add(New CBBItem(row(0), row(1)))
        Next

    End Sub
End Class