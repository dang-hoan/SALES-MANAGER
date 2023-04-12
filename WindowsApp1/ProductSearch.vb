Imports LibraryDataset
Imports LibraryCommon
Public Class ProductSearch
    Dim conn As New connCommon()
    Dim clsProduct As New clsProduct(conn.connSales.ConnectionString)
    Dim clsCBB As New clsCBB(conn.connSales.ConnectionString)
    Private Sub OrderSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataCategory = clsCBB.GetCBBCategory().CBBCategory
        Dim dataSupplier = clsCBB.GetCBBSupplier().CBBSupplier
        Dim dataStatus = clsCBB.GetCBBStatusOfProduct().CBBStatus
        Dim dataWarehouse = clsCBB.GetCBBWareHouse().CBBWareHouse

        cbbCategory.Items.Clear()
        cbbSupplier.Items.Clear()
        cbbStatus.Items.Clear()
        cbbWarehouse.Items.Clear()

        cbbCategory.Items.Add("")
        cbbSupplier.Items.Add("")
        cbbStatus.Items.Add("")
        cbbWarehouse.Items.Add("")

        For Each row As DataRow In dataCategory.Rows
            cbbCategory.Items.Add(New CBBItem(row(0), row(1)))
        Next

        For Each row As DataRow In dataSupplier.Rows
            cbbSupplier.Items.Add(New CBBItem(row(0), row(1)))
        Next

        For Each row As DataRow In dataStatus.Rows
            cbbStatus.Items.Add(New CBBItem(row(0), row(1)))
        Next

        For Each row As DataRow In dataWarehouse.Rows
            cbbWarehouse.Items.Add(New CBBItem(row(0), row(1)))
        Next
    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If checkLogicData() Then
            Dim code = -1
            If txtCode.Text <> "" Then
                code = txtCode.Text
            End If

            Dim category = -1
            If cbbCategory.Text <> "" And cbbCategory.SelectedItem IsNot Nothing Then
                category = CType(cbbCategory.SelectedItem, CBBItem).PropItemId
            End If

            Dim supplier = -1
            If cbbSupplier.Text <> "" And cbbSupplier.SelectedItem IsNot Nothing Then
                supplier = CType(cbbSupplier.SelectedItem, CBBItem).PropItemId
            End If

            Dim warehouse = -1
            If cbbWarehouse.Text <> "" And cbbWarehouse.SelectedItem IsNot Nothing Then
                warehouse = CType(cbbWarehouse.SelectedItem, CBBItem).PropItemId
            End If

            Dim price = -1
            If txtPrice.Text <> "" Then
                price = txtPrice.Text
            End If

            Dim status = -1
            If cbbStatus.Text <> "" And cbbStatus.SelectedItem IsNot Nothing Then
                status = CType(cbbStatus.SelectedItem, CBBItem).PropItemId
            End If

            Dim discount = -1
            If txtDiscount.Text <> "" Then
                discount = txtDiscount.Text
            End If

            Dim number = -1
            If txtNumber.Text <> "" Then
                number = txtNumber.Text
            End If

            dgvProductSearch.DataSource = clsProduct.SearchProduct(code, txtName.Text, supplier, category, price, status, discount, warehouse, number)

        End If

    End Sub
    Private Function checkLogicData() As Boolean
        If Not checkNumber(txtPrice.Text) Then
            MsgBox("Price must be a number!")
            Return False

        ElseIf Not checkNumber(txtDiscount.Text) Then
            MsgBox("Discount must be a number!")
            Return False
        ElseIf Not checkNumber(txtNumber.Text) Then
            MsgBox("Number of product must be a number!")
            Return False
        End If
        Return True
    End Function

    Private Function checkNumber(ByVal phone As String)
        For Each c As Char In phone
            If Asc(c) <> 44 And Asc(c) <> 46 Then
                If Asc(c) > 57 Or Asc(c) < 48 Then
                    Return False
                End If
            End If
        Next

        Return True
    End Function
End Class