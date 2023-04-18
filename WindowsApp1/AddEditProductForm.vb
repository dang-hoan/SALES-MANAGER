Imports LibraryDataset
Imports LibraryCommon
Public Class AddEditProductForm
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsProduct(conn.connSales.ConnectionString)
    Dim clsCBB As New clsCBB(conn.connSales.ConnectionString)
    Dim clsWarehouse As New clsWarehouse(conn.connSales.ConnectionString)

    Public warehouseId As Long = -1
    Public productId As Long = -1
    Public oldNumbers As Long = -1

    Private Sub CustomerCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If productId <> -1 Then
            txtCode.Text = productId
            labTitle.Text = "UPDATE PRODUCT"
            bSave.Text = "Save"
        Else
            labTitle.Text = "ADD PRODUCT"
            bSave.Text = "Add"
            txtSoldProducts.Text = "0"
        End If
        labTitle.Location = New Point((Width - labTitle.Width) \ 2, groupBox1.Location.Y - 45)
        LoadProduct()
    End Sub

    Private Sub LoadProduct()
        txtCode.Enabled = False
        Dim dataCategory = clsCBB.GetCBBCategory().CBBCategory
        Dim dataSupplier = clsCBB.GetCBBSupplier().CBBSupplier
        Dim dataStatus = clsCBB.GetCBBStatusOfProduct().CBBStatus
        Dim dataWarehouse = clsCBB.GetCBBWareHouse().CBBWareHouse

        cbbCategory.Items.Clear()
        cbbSupplier.Items.Clear()
        cbbStatus.Items.Clear()
        cbbWarehouse.Items.Clear()

        For Each row As DataRow In dataCategory.Rows
            cbbCategory.Items.Add(New CBBItem(row(0), row(1)))
        Next

        For Each row As DataRow In dataSupplier.Rows
            cbbSupplier.Items.Add(New CBBItem(row(0), row(1)))
        Next

        For Each row As DataRow In dataStatus.Rows
            cbbStatus.Items.Add(New CBBItem(row(0), row(1)))
        Next

        If productId <> -1 Then                        'Edit product of warehouse
            For Each row As DataRow In dataWarehouse.Rows
                cbbWarehouse.Items.Add(New CBBItem(row(0), row(1)))
            Next
            setValue(clsPMSAnalysis.GetProductById(productId).Rows(0))
        Else                                           'Add new product for warehouse
            For Each row As DataRow In dataWarehouse.Rows
                If row(0) = warehouseId Then
                    cbbWarehouse.Items.Add(New CBBItem(row(0), row(1)))
                    Exit For
                End If
            Next
            cbbWarehouse.Enabled = False

        End If

    End Sub

    Private Sub setValue(ByVal product As DataRow)
        txtCode.Text = product(0)
        txtName.Text = product(1)
        txtPrice.Text = product(4)
        txtDiscount.Text = product(7)
        txtNumber.Text = product(11)
        txtSoldProducts.Text = product(12)
        oldNumbers = product(11)

        For Each item As CBBItem In cbbCategory.Items
            If item.PropItemId = product(3) Then
                cbbCategory.SelectedItem = item
            End If
        Next
        For Each item As CBBItem In cbbSupplier.Items
            If item.PropItemId = product(2) Then
                cbbSupplier.SelectedItem = item
            End If
        Next
        For Each item As CBBItem In cbbStatus.Items
            If item.PropItemId = product(6) Then
                cbbStatus.SelectedItem = item
            End If
        Next
        For Each item As CBBItem In cbbWarehouse.Items
            If item.PropItemId = product(10) Then
                cbbWarehouse.SelectedItem = item
            End If
        Next
    End Sub
    Private Sub clearValue()
        txtName.Text = ""
        cbbCategory.SelectedIndex = -1
        txtPrice.Text = ""
        'txtUnitPrice.Text = ""
        cbbStatus.SelectedIndex = -1
        cbbSupplier.SelectedIndex = -1
        txtDiscount.Text = ""
        txtNumber.Text = ""
        cbbWarehouse.SelectedIndex = -1
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        If checkLogicData() Then
            Dim result As Integer
            Dim categoryId = CType(cbbCategory.SelectedItem, CBBItem).PropItemId
            Dim supplierId = CType(cbbSupplier.SelectedItem, CBBItem).PropItemId
            Dim statusId = CType(cbbStatus.SelectedItem, CBBItem).PropItemId
            Dim selectedWarehouse = If(cbbWarehouse.Enabled = True, CType(cbbWarehouse.SelectedItem, CBBItem).PropItemId, warehouseId)

            If txtCode.Text <> "" Then          'Edit
                result = clsPMSAnalysis.EditProduct(txtCode.Text, txtName.Text,
                                            supplierId, categoryId, txtPrice.Text, txtUnitPrice.Text, statusId,
                                             txtDiscount.Text, Nothing, Nothing, selectedWarehouse, txtNumber.Text, LoginForm.PropUsername)

                If result = 1 Then
                    Dim oldTotal = oldNumbers
                    Dim oldImports = clsWarehouse.GetWarehouseById(warehouseId).Rows(0)(3)
                    result = clsWarehouse.UpdateImportsOfWarehouse(oldImports - oldTotal + txtNumber.Text, warehouseId)
                End If
            Else                                'Add new
                result = clsPMSAnalysis.AddProduct(txtName.Text,
                                            supplierId, categoryId, txtPrice.Text, txtUnitPrice.Text, statusId,
                                             txtDiscount.Text, Nothing, Nothing, selectedWarehouse, txtNumber.Text, LoginForm.PropUsername)
                If result = 1 Then
                    Dim oldImports = clsWarehouse.GetWarehouseById(warehouseId).Rows(0)(3)
                    result = clsWarehouse.UpdateImportsOfWarehouse(oldImports + txtNumber.Text, warehouseId)
                End If
            End If

            If result = 1 Then
                Dim caller As WarehouseCategory = CType(Application.OpenForms("WarehouseCategory"), WarehouseCategory)
                caller.Warehouse.Clear()
                caller.Warehouse.Merge(clsWarehouse.GetProductsOfWarehouse(warehouseId))

                MsgBox(bSave.Text & " product information successful!")
                Me.Close()
            Else
                MsgBox("There is an error when interact with database!")
            End If
        End If
    End Sub
    Private Function checkLogicData() As Boolean
        If txtName.Text = "" Or cbbCategory.Text = "" Or txtPrice.Text = "" Or txtUnitPrice.Text = "" Or
            cbbStatus.Text = "" Or txtDiscount.Text = "" Or cbbSupplier.Text = "" Then

            MsgBox("You need to enter all the fields!")
            Return False

        ElseIf Not CheckValue("Price", txtPrice.Text, "Double") Or
            Not CheckValue("Discount", txtDiscount.Text, "Double") Or
            Not CheckValue("Number of products", txtNumber.Text, "Long") Then
            Return False
        ElseIf txtNumber.Text < txtSoldProducts.Text Then
            MsgBox("Total products must be greater than sold products!")
            Return False
        End If
        Return True
    End Function

    Private Function CheckValue(ByVal label As String, ByVal value As String, ByVal style As String) As Boolean
        Dim returnVal = True

        If value.Length = 0 Then
            Return True
        End If

        Select Case style
            Case "Long"
                Dim Number As Long
                Try
                    Number = Long.Parse(value)
                Catch ex As FormatException
                    MsgBox(label & " must be a integer number!")
                    returnVal = False
                Catch ex As OverflowException
                    MsgBox(label & " is too big to handle!")
                    returnVal = False
                End Try

            Case "Double"
                Dim Number As Double
                Try
                    Number = Double.Parse(value)
                Catch ex As FormatException
                    MsgBox(label & " must be a number!")
                    returnVal = False
                Catch ex As OverflowException
                    MsgBox(label & " is too big to handle!")
                    returnVal = False
                End Try

        End Select

        Return returnVal

    End Function

    Private Sub txtUnitPrice_TextChanged(sender As Object, e As EventArgs) Handles txtUnitPrice.TextChanged
        txtUnitDiscount.Text = txtUnitPrice.Text
    End Sub

    Private Sub bClearAll_Click(sender As Object, e As EventArgs) Handles bClearAll.Click
        clearValue()
    End Sub
End Class