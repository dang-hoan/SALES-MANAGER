Imports LibraryDataset
Imports LibraryCommon
Public Class ProductCategory
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsProduct(conn.connSales.ConnectionString)
    Dim clsCBB As New clsCBB(conn.connSales.ConnectionString)
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
        If dgvCategory Is Nothing Then
            Return
        Else
            Dim row As DataGridViewRow = dgvCategory.CurrentRow
            txtCode.Text = row.Cells(0).Value.ToString
            txtName.Text = row.Cells(1).Value.ToString
            txtPrice.Text = row.Cells(4).Value.ToString
            txtUnitPrice.Text = row.Cells(5).Value.ToString
            txtDiscount.Text = row.Cells(7).Value.ToString
            txtNumber.Text = row.Cells(18).Value.ToString

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
                If item.PropItemId = row.Cells(17).Value.ToString Then
                    cbbWarehouse.SelectedItem = item
                End If
            Next
        End If
    End Sub

    Private Sub bEdit_Click(sender As Object, e As EventArgs) Handles bEdit.Click
        setEnable(True)
    End Sub

    Private Sub setEnable(valBoolean As Boolean)
        txtName.Enabled = valBoolean
        cbbCategory.Enabled = valBoolean
        txtPrice.Enabled = valBoolean
        txtUnitPrice.Enabled = valBoolean
        cbbStatus.Enabled = valBoolean
        cbbSupplier.Enabled = valBoolean
        txtDiscount.Enabled = valBoolean
        txtNumber.Enabled = valBoolean
        cbbWarehouse.Enabled = valBoolean
    End Sub

    Private Sub clearValue()
        txtCode.Text = ""
        txtName.Text = ""
        cbbCategory.SelectedIndex = -1
        txtPrice.Text = ""
        txtUnitPrice.Text = ""
        cbbStatus.SelectedIndex = -1
        cbbSupplier.SelectedIndex = -1
        txtDiscount.Text = ""
        txtNumber.Text = ""
        cbbWarehouse.SelectedIndex = -1
    End Sub

    Private Sub bAdd_Click(sender As Object, e As EventArgs) Handles bAdd.Click
        clearValue()
        setEnable(True)
    End Sub

    Private Sub dgvCategory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategory.CellClick
        setEnable(False)
        setValue()
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
            Else                                'Add new
                result = clsPMSAnalysis.AddProduct(txtName.Text,
                                            supplierId, categoryId, txtPrice.Text, txtUnitPrice.Text, statusId,
                                             txtDiscount.Text, Nothing, Nothing, wareHouseId, txtNumber.Text, LoginForm.PropUsername)
                type = "Add"
            End If

            If result = 1 Then
                setEnable(False)
                MsgBox(type & " product information successful!")
                Reload()
            Else
                MsgBox("There is an error when interact with database!")
            End If
        End If
    End Sub
    Private Function checkLogicData() As Boolean
        If txtName.Text = "" Or cbbCategory.Text = "" Or txtPrice.Text = "" Or txtUnitPrice.Text = "" Or
            cbbStatus.Text = "" Or txtDiscount.Text = "" Or cbbWarehouse.Text = "" Then

            MsgBox("You need to enter all the fields!")
            Return False

        ElseIf Not checkNumber(txtPrice.Text) Then
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

    Private Sub bDelete_Click(sender As Object, e As EventArgs) Handles bDelete.Click
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
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Dim productId = CLng(dgvCategory.CurrentRow.Cells(0).Value.ToString)
        Dim isDelete = clsPMSAnalysis.CheckProductWasDeleted(productId)
        If isDelete Then
            Dim result = clsPMSAnalysis.RestoreProduct(productId)
            If result = 1 Then
                setEnable(False)
                MsgBox("Restore product information successful!")
                Reload()
            Else
                MsgBox("There is an error when interact with database!")
            End If
        Else
            MsgBox("The product hasn't been deleted yet, you don't need restore!")
        End If
    End Sub

    Private Sub txtUnitPrice_TextChanged(sender As Object, e As EventArgs) Handles txtUnitPrice.TextChanged
        txtUnitDiscount.Text = txtUnitPrice.Text
    End Sub
End Class