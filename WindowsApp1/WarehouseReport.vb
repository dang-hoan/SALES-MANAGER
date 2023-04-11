Imports LibraryDataset
Imports LibraryCommon

Public Class WarehouseReport
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsCBB(conn.connSales.ConnectionString)

    Dim dataProduct As CBB.CBBProductDataTable
    Dim dataWareHouse As CBB.CBBWareHouseDataTable
    'Dim dataSaleDetail As CBB.CBBDea
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

    'Private Sub cbbWarehouse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbWarehouse.SelectedIndexChanged
    '    Dim productId = Nothing
    '    'Save selected productId 
    '    If cbbProduct.Text <> "" Then
    '        productId = CType(cbbProduct.SelectedItem, CBBItem).PropItemId
    '    End If

    '    If cbbWarehouse.Text <> "" Then
    '        Dim warehouseId = CType(cbbWarehouse.SelectedItem, CBBItem).PropItemId
    '        Dim dataProduct = clsPMSAnalysis.GetCBBProductOfWareHouse(warehouseId).CBBProduct

    '        cbbProduct.Items.Clear()

    '        cbbProduct.Items.Add("")

    '        For Each row As DataRow In dataProduct.Rows
    '            cbbProduct.Items.Add(New CBBItem(row(0), row(1)))
    '        Next
    '    Else
    '        Dim dataProduct = clsPMSAnalysis.GetCBBProduct().CBBProduct

    '        cbbProduct.Items.Clear()

    '        cbbProduct.Items.Add("")

    '        For Each row As DataRow In dataProduct.Rows
    '            cbbProduct.Items.Add(New CBBItem(row(0), row(1)))
    '        Next
    '    End If

    '    If productId IsNot Nothing Then
    '        For i = 1 To cbbProduct.Items.Count - 1
    '            If CType(cbbProduct.Items(i), CBBItem).PropItemId = productId Then
    '                cbbProduct.SelectedIndex = i
    '            End If
    '        Next

    '    End If
    'End Sub

    'Private Sub cbbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbProduct.SelectedIndexChanged
    '    Dim warehouseId = Nothing

    '    'Save selected warehouseId
    '    If cbbWarehouse.Text <> "" Then
    '        warehouseId = CType(cbbWarehouse.SelectedItem, CBBItem).PropItemId
    '    End If

    '    If cbbProduct.Text <> "" Then
    '        Dim productId = CType(cbbProduct.SelectedItem, CBBItem).PropItemId
    '        Dim dataWareHouse = clsPMSAnalysis.GetCBBWareHouseOfProduct(productId).CBBWareHouse

    '        cbbWarehouse.Items.Clear()

    '        cbbWarehouse.Items.Add("")

    '        For Each row As DataRow In dataWareHouse.Rows
    '            cbbWarehouse.Items.Add(New CBBItem(row(0), row(1)))
    '        Next
    '    Else
    '        Dim dataWareHouse = clsPMSAnalysis.GetCBBWareHouse().CBBWareHouse

    '        cbbWarehouse.Items.Clear()

    '        cbbWarehouse.Items.Add("")

    '        For Each row As DataRow In dataWareHouse.Rows
    '            cbbWarehouse.Items.Add(New CBBItem(row(0), row(1)))
    '        Next
    '    End If
    '    Console.WriteLine("hello")
    '    If warehouseId IsNot Nothing Then
    '        For i = 1 To cbbWarehouse.Items.Count - 1
    '            If CType(cbbWarehouse.Items(i), CBBItem).PropItemId = warehouseId Then
    '                cbbWarehouse.SelectedIndex = i
    '            End If
    '        Next

    '    End If
    'End Sub

    Private Sub cbbWarehouse_Click(sender As Object, e As EventArgs) Handles cbbWarehouse.Click
        Dim warehouseId = Nothing
        'Save selected productId 
        If cbbWarehouse.Text <> "" Then
            warehouseId = CType(cbbWarehouse.SelectedItem, CBBItem).PropItemId
        End If

        If cbbProduct.Text <> "" Then
            Dim productId = CType(cbbProduct.SelectedItem, CBBItem).PropItemId
            Dim dataWareHouse = clsPMSAnalysis.GetCBBWareHouseOfProduct(productId).CBBWareHouse

            cbbWarehouse.Items.Clear()

            cbbWarehouse.Items.Add("")

            For Each row As DataRow In dataWareHouse.Rows
                cbbWarehouse.Items.Add(New CBBItem(row(0), row(1)))
            Next
        Else
            Dim dataWareHouse = clsPMSAnalysis.GetCBBWareHouse().CBBWareHouse

            cbbWarehouse.Items.Clear()

            cbbWarehouse.Items.Add("")

            For Each row As DataRow In dataWareHouse.Rows
                cbbWarehouse.Items.Add(New CBBItem(row(0), row(1)))
            Next
        End If

        ' Set old warehouseId
        If warehouseId IsNot Nothing Then
            For i = 1 To cbbWarehouse.Items.Count - 1
                If CType(cbbWarehouse.Items(i), CBBItem).PropItemId = warehouseId Then
                    cbbWarehouse.SelectedIndex = i
                End If
            Next

        End If
    End Sub

    Private Sub cbbProduct_Click(sender As Object, e As EventArgs) Handles cbbProduct.Click
        Dim productId = Nothing
        'Save selected productId 
        If cbbProduct.Text <> "" Then
            productId = CType(cbbProduct.SelectedItem, CBBItem).PropItemId
        End If

        If cbbWarehouse.Text <> "" Then
            Dim warehouseId = CType(cbbWarehouse.SelectedItem, CBBItem).PropItemId
            Dim dataProduct = clsPMSAnalysis.GetCBBProductOfWareHouse(warehouseId).CBBProduct

            cbbProduct.Items.Clear()

            cbbProduct.Items.Add("")

            For Each row As DataRow In dataProduct.Rows
                cbbProduct.Items.Add(New CBBItem(row(0), row(1)))
            Next
        Else
            Dim dataProduct = clsPMSAnalysis.GetCBBProduct().CBBProduct

            cbbProduct.Items.Clear()

            cbbProduct.Items.Add("")

            For Each row As DataRow In dataProduct.Rows
                cbbProduct.Items.Add(New CBBItem(row(0), row(1)))
            Next
        End If

        ' Set old productId
        If productId IsNot Nothing Then
            For i = 1 To cbbProduct.Items.Count - 1
                If CType(cbbProduct.Items(i), CBBItem).PropItemId = productId Then
                    cbbProduct.SelectedIndex = i
                End If
            Next

        End If
    End Sub
End Class