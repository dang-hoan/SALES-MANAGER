Imports LibraryDataset
Imports LibraryCommon
Public Class ProductCategory
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsProduct(conn.connSales.ConnectionString)
    Dim clsCBB As New clsCBB(conn.connSales.ConnectionString)
    Dim clsWarehouse As New clsWarehouse(conn.connSales.ConnectionString)
    Private Sub CustomerCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub Reload()
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

        For Each row As DataRow In dataWarehouse.Rows
            cbbWarehouse.Items.Add(New CBBItem(row(0), row(1)))
        Next

        Dim data = clsPMSAnalysis.GetAllProduct()
        dgvCategory.DataSource = data.ProductSalesDetail
        setEnable(False)
        setValue()
    End Sub

    Private Sub setValue()
        If dgvCategory.Rows.Count = 0 Then
            addEditDeleteEnabled(False)
            bAdd.Enabled = True
            Return
        Else
            Dim row As DataGridViewRow = dgvCategory.CurrentRow
            txtCode.Text = row.Cells(0).Value.ToString
            txtName.Text = row.Cells(1).Value.ToString
            txtPrice.Text = row.Cells(4).Value.ToString
            txtDiscount.Text = row.Cells(7).Value.ToString
            txtNumber.Text = row.Cells(11).Value.ToString
            txtSoldProducts.Text = row.Cells(12).Value.ToString

            For Each item As CBBItem In cbbCategory.Items
                If item.PropItemId = row.Cells(3).Value.ToString Then
                    cbbCategory.SelectedItem = item
                End If
            Next
            For Each item As CBBItem In cbbSupplier.Items
                If item.PropItemId = row.Cells(2).Value.ToString Then
                    cbbSupplier.SelectedItem = item
                End If
            Next
            For Each item As CBBItem In cbbStatus.Items
                If item.PropItemId = row.Cells(6).Value.ToString Then
                    cbbStatus.SelectedItem = item
                End If
            Next
            For Each item As CBBItem In cbbWarehouse.Items
                If item.PropItemId = row.Cells(10).Value.ToString Then
                    cbbWarehouse.SelectedItem = item
                End If
            Next
        End If
    End Sub

    Private Sub bEdit_Click(sender As Object, e As EventArgs) Handles bEdit.Click
        bAdd.Enabled = False
        setEnable(True)
    End Sub

    Private Sub setEnable(valBoolean As Boolean)
        txtName.Enabled = valBoolean
        cbbCategory.Enabled = valBoolean
        txtPrice.Enabled = valBoolean
        'txtUnitPrice.Enabled = valBoolean
        cbbStatus.Enabled = valBoolean
        cbbSupplier.Enabled = valBoolean
        txtDiscount.Enabled = valBoolean
        txtNumber.Enabled = valBoolean
        cbbWarehouse.Enabled = valBoolean
        bSave.Enabled = valBoolean
    End Sub

    Private Sub addEditDeleteEnabled(valBoolean As Boolean)
        bAdd.Enabled = valBoolean
        bEdit.Enabled = valBoolean
        bDelete.Enabled = valBoolean
    End Sub
    Private Sub clearValue()
        txtCode.Text = ""
        txtName.Text = ""
        cbbCategory.SelectedIndex = -1
        txtPrice.Text = ""
        'txtUnitPrice.Text = ""
        cbbStatus.SelectedIndex = -1
        cbbSupplier.SelectedIndex = -1
        txtDiscount.Text = ""
        txtNumber.Text = ""
        cbbWarehouse.SelectedIndex = -1
        txtSoldProducts.Text = "0"
    End Sub

    Private Sub bAdd_Click(sender As Object, e As EventArgs) Handles bAdd.Click
        clearValue()
        setEnable(True)
        addEditDeleteEnabled(False)
    End Sub

    Private Sub dgvCategory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategory.CellClick
        setEnable(False)
        setValue()
        addEditDeleteEnabled(True)
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        If checkLogicData() Then
            Dim result As Integer
            Dim type As String = "Update"
            Dim categoryId = CType(cbbCategory.SelectedItem, CBBItem).PropItemId
            Dim supplierId = CType(cbbSupplier.SelectedItem, CBBItem).PropItemId
            Dim statusId = CType(cbbStatus.SelectedItem, CBBItem).PropItemId
            Dim wareHouseId = CType(cbbWarehouse.SelectedItem, CBBItem).PropItemId

            If txtCode.Text <> "" Then          'Edit
                result = clsPMSAnalysis.EditProduct(txtCode.Text, txtName.Text,
                                            supplierId, categoryId, txtPrice.Text, txtUnitPrice.Text, statusId,
                                             txtDiscount.Text, Nothing, Nothing, wareHouseId, txtNumber.Text, LoginForm.PropUsername)

                If result = 1 Then
                    Dim oldTotal = dgvCategory.CurrentRow.Cells(11).Value.ToString
                    Dim oldImports = clsWarehouse.GetWarehouseById(wareHouseId).Rows(0)(3)
                    result = clsWarehouse.UpdateImportsOfWarehouse(oldImports - oldTotal + txtNumber.Text, wareHouseId)
                End If
            Else                                'Add new
                result = clsPMSAnalysis.AddProduct(txtName.Text,
                                            supplierId, categoryId, txtPrice.Text, txtUnitPrice.Text, statusId,
                                             txtDiscount.Text, Nothing, Nothing, wareHouseId, txtNumber.Text, LoginForm.PropUsername)

                If result = 1 Then
                    Dim oldImports = clsWarehouse.GetWarehouseById(wareHouseId).Rows(0)(3)
                    result = clsWarehouse.UpdateImportsOfWarehouse(oldImports + txtNumber.Text, wareHouseId)
                End If
                type = "Add"
            End If

            If result = 1 Then
                setEnable(False)
                MsgBox(type & " product information successful!")
                Reload()
                bAdd.Enabled = True
            Else
                MsgBox("There is an error when interact with database!")
            End If
        End If
    End Sub
    Private Function checkLogicData() As Boolean
        If txtName.Text = "" Or cbbCategory.Text = "" Or txtPrice.Text = "" Or txtUnitPrice.Text = "" Or
            cbbStatus.Text = "" Or txtDiscount.Text = "" Or cbbWarehouse.Text = "" Or cbbSupplier.Text = "" Then

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

    Private Sub bDelete_Click(sender As Object, e As EventArgs) Handles bDelete.Click
        If dgvCategory.CurrentRow IsNot Nothing Then
            Dim productId = CLng(dgvCategory.CurrentRow.Cells(0).Value.ToString)
            Dim isDelete = clsPMSAnalysis.CheckProductWasDeleted(productId)
            If Not isDelete Then
                Dim result = clsPMSAnalysis.DeleteProduct(LoginForm.PropUsername, productId)
                If result = 1 Then
                    setEnable(False)
                    MsgBox("Delete product information successful!")
                    Reload()
                Else
                    MsgBox("There is an error when interact with database!")
                End If
            Else
                MsgBox("Product was deleted before!")
            End If

        End If
    End Sub

    Private Sub txtUnitPrice_TextChanged(sender As Object, e As EventArgs) Handles txtUnitPrice.TextChanged
        txtUnitDiscount.Text = txtUnitPrice.Text
    End Sub
End Class