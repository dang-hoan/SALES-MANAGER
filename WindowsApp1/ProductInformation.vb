Imports LibraryDataset
Imports LibraryCommon
Public Class ProductInformation
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsProduct(conn.connSales.ConnectionString)
    Dim clsCBB As New clsCBB(conn.connSales.ConnectionString)
    Dim clsWarehouse As New clsWarehouse(conn.connSales.ConnectionString)
    Dim clsRolePermission As New clsRolePermission(conn.connSales.ConnectionString)

    Dim mode As String = "Update"
    Public Sub LoadData(productCode As Long, Optional onlyView As Boolean = False)
        SetVisibleForPermission()
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

        If productCode = -1 Then
            setEnable(True)
            mode = "Add"

            labTitle.Text = "ADD PRODUCT"
            labTitle.Location = New Point(Me.Width / 2 - labTitle.Width / 2, 30)

            Dim x As Integer = (Me.Width - bSave.Width) / 2

            bSave.Location = New Point(x, bSave.Location.Y)
            bEdit.Visible = False
            bDelete.Visible = False

            txtSoldProducts.Text = 0

        Else
            setEnable(False)

            Dim data = clsPMSAnalysis.GetProductById(productCode)
            txtCode.Text = productCode
            txtName.Text = data("ProductName")
            txtPrice.Text = data("ProductPrice")
            txtDiscount.Text = data("DiscountPercent")
            txtTotal.Text = data("Total")
            txtSoldProducts.Text = data("SellNumber")

            For Each item As CBBItem In cbbCategory.Items
                If item.PropItemId = data("CategoryId") Then
                    cbbCategory.SelectedItem = item
                End If
            Next
            For Each item As CBBItem In cbbSupplier.Items
                If item.PropItemId = data("SupplierId") Then
                    cbbSupplier.SelectedItem = item
                End If
            Next
            For Each item As CBBItem In cbbStatus.Items
                If item.PropItemId = data("ProductStatusId") Then
                    cbbStatus.SelectedItem = item
                End If
            Next
            For Each item As CBBItem In cbbWarehouse.Items
                If item.PropItemId = data("WareHouseId") Then
                    cbbWarehouse.SelectedItem = item
                End If
            Next

            If onlyView Then
                bSave.Visible = False
                bEdit.Visible = False
                bDelete.Visible = False
            End If

        End If
        InitPlaceHolderText()

    End Sub

    'Set up placeholder text for comboboxes

    Private categoryPlhTxt = "Select a category"
    Private supplierPlhTxt = "Select a supplier"
    Private warehousePlhTxt = "Select a warehouse"
    Private statusPlhTxt = "Select a status"

    Private Sub InitPlaceHolderText()
        DropDownClosed(cbbCategory, categoryPlhTxt)
        DropDownClosed(cbbSupplier, supplierPlhTxt)
        DropDownClosed(cbbWarehouse, warehousePlhTxt)
        DropDownClosed(cbbStatus, statusPlhTxt)
    End Sub

    Private Sub SetVisibleForPermission()
        'bAdd.Visible = False
        bEdit.Visible = False
        bDelete.Visible = False
        bSave.Visible = False
        Dim dataPermission = clsRolePermission.GetPermissionOfUser(LoginForm.PropUsername)
        For Each permission In dataPermission
            Dim form = permission(1).split(":")(0)
            Dim permiss = Strings.Split(Strings.Split(permission(1), ": ")(1), ", ")
            If form = "Product category" Then
                For Each p In permiss
                    Select Case p
                        Case "Add"
                            'bAdd.Visible = True
                            bSave.Visible = True
                        Case "Edit"
                            bEdit.Visible = True
                            bSave.Visible = True
                        Case "Delete"
                            bDelete.Visible = True
                    End Select
                Next
                Exit For
            End If
        Next
        CenterButtons()
    End Sub

    Private Sub CenterButtons()
        Dim listButtons = New List(Of Button) From {bEdit, bDelete, bSave}
        Dim totalWidth As Integer = 0
        Dim count = 0

        For Each btn As Button In listButtons
            If btn.Visible = True Then
                totalWidth += btn.Width
                count += 1
            End If
        Next

        Dim offset_between = 30
        Dim x As Integer = (Me.Width - totalWidth - offset_between * (count - 1)) / 2
        Dim y As Integer = 350

        For Each btn As Button In listButtons
            If btn.Visible = True Then
                btn.Location = New Point(x, y)
                x += btn.Width + offset_between
            End If
        Next
    End Sub

    Private Sub bEdit_Click(sender As Object, e As EventArgs) Handles bEdit.Click
        bEdit.Enabled = False
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
        txtTotal.Enabled = valBoolean
        cbbWarehouse.Enabled = valBoolean
        bSave.Enabled = valBoolean
    End Sub

    Private Sub editDeleteEnabled(valBoolean As Boolean)
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
        txtTotal.Text = ""
        cbbWarehouse.SelectedIndex = -1
        txtSoldProducts.Text = "0"
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        If checkLogicData() Then
            Dim result As Integer
            Dim categoryId = CType(cbbCategory.SelectedItem, CBBItem).PropItemId
            Dim supplierId = CType(cbbSupplier.SelectedItem, CBBItem).PropItemId
            Dim statusId = CType(cbbStatus.SelectedItem, CBBItem).PropItemId
            Dim wareHouseId = CType(cbbWarehouse.SelectedItem, CBBItem).PropItemId

            If mode = "Update" Then          'Edit
                Dim oldTotal = clsPMSAnalysis.GetProductById(txtCode.Text)("Total")

                result = clsPMSAnalysis.EditProduct(txtCode.Text, txtName.Text,
                                            supplierId, categoryId, txtPrice.Text, txtUnitPrice.Text, statusId,
                                             txtDiscount.Text, Nothing, Nothing, wareHouseId, txtTotal.Text, LoginForm.PropUsername)

                If result = 1 Then
                    Dim oldImports = clsWarehouse.GetWarehouseById(wareHouseId)("NumberOfImport")
                    result = clsWarehouse.UpdateImportsOfWarehouse(oldImports - oldTotal + txtTotal.Text, wareHouseId)
                End If
            Else                                'Add new
                result = clsPMSAnalysis.AddProduct(txtName.Text,
                                            supplierId, categoryId, txtPrice.Text, txtUnitPrice.Text, statusId,
                                             txtDiscount.Text, Nothing, Nothing, wareHouseId, txtTotal.Text, LoginForm.PropUsername)

                If result = 1 Then
                    Dim oldImports = clsWarehouse.GetWarehouseById(wareHouseId)("NumberOfImport")
                    result = clsWarehouse.UpdateImportsOfWarehouse(oldImports + txtTotal.Text, wareHouseId)
                End If

            End If

            If result = 1 Then
                MsgBox(mode & " product information successful!", Nothing, "Notification")
                Dim caller As ProductCategory = CType(Application.OpenForms("ProductCategory"), ProductCategory)
                caller.Reload()
                Me.Close()
            Else
                MsgBox("There is an error when interact with database!", Nothing, "Notification")
            End If
        End If
    End Sub
    Private Function checkLogicData() As Boolean
        If txtName.Text = "" Or txtPrice.Text = "" Or txtUnitPrice.Text = "" Or
            txtDiscount.Text = "" Then

            MsgBox("You need to enter all the fields!", Nothing, "Notification")
            Return False

        ElseIf cbbCategory.Text.Equals(categoryPlhTxt) Or cbbSupplier.Text.Equals(supplierPlhTxt) Or
                cbbWarehouse.Text.Equals(warehousePlhTxt) Or cbbStatus.Text.Equals(statusPlhTxt) Then

            MsgBox("You need to select element for all comboboxes!", Nothing, "Notification")
            Return False

        ElseIf Not CheckValue("Price", txtPrice.Text, "Double") Or
            Not CheckValue("Discount", txtDiscount.Text, "Double") Or
            Not CheckValue("Number of products", txtTotal.Text, "Long") Then
            Return False

        ElseIf txtDiscount.Text < 0 Or txtDiscount.Text > 100 Then
            MsgBox("Discount percent must be in 0 - 100!", Nothing, "Notification")
            Return False

        ElseIf CType(txtTotal.Text, Double) < CType(txtSoldProducts.Text, Double) Then
            MsgBox("Total products must be greater than sold products!", Nothing, "Notification")
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
                    MsgBox(label & " must be a number!", Nothing, "Notification")
                    returnVal = False
                Catch ex As OverflowException
                    MsgBox(label & " is too big to handle!", Nothing, "Notification")
                    returnVal = False
                End Try

            Case "Double"
                Dim Number As Double
                Try
                    Number = Double.Parse(value)
                Catch ex As FormatException
                    MsgBox(label & " must be a number!", Nothing, "Notification")
                    returnVal = False
                Catch ex As OverflowException
                    MsgBox(label & " is too big to handle!", Nothing, "Notification")
                    returnVal = False
                End Try

        End Select

        Return returnVal

    End Function

    Private Sub bDelete_Click(sender As Object, e As EventArgs) Handles bDelete.Click
        Dim productId = txtCode.Text

        Dim product = clsPMSAnalysis.GetProductById(productId)
        Dim warehouseId = product("WareHouseId")
        Dim total = product("Total")
        Dim oldImports = clsWarehouse.GetWarehouseById(warehouseId)("NumberOfImport")
        Dim result = clsWarehouse.UpdateImportsOfWarehouse(oldImports - total, warehouseId)

        If result = 1 Then
            result = clsPMSAnalysis.DeleteProduct(LoginForm.PropUsername, productId)
        End If

        If result = 1 Then
            MsgBox("Delete product information successful!", Nothing, "Notification")
            Dim caller As ProductCategory = CType(Application.OpenForms("ProductCategory"), ProductCategory)
            caller.Reload()
            Me.Close()
        End If

        If result <> 1 Then
            MsgBox("There is an error when interact with database!", Nothing, "Notification")
        End If
    End Sub
    Private Sub DropDown(ByRef cbb As ComboBox, ByVal txt As String)
        If (cbb.Items.Contains(txt)) Then
            cbb.Items.RemoveAt(0)
        End If
    End Sub
    Private Sub DropDownClosed(ByRef cbb As ComboBox, ByVal txt As String)
        If (cbb.SelectedIndex = -1) Then
            cbb.Items.Insert(0, txt)
            cbb.Text = txt
        End If
    End Sub

    Private Sub cbbCategory_DropDown(sender As Object, e As EventArgs) Handles cbbCategory.DropDown
        DropDown(cbbCategory, categoryPlhTxt)
    End Sub

    Private Sub cbbCategory_DropDownClosed(sender As Object, e As EventArgs) Handles cbbCategory.DropDownClosed
        DropDownClosed(cbbCategory, categoryPlhTxt)
    End Sub

    Private Sub cbbSupplier_DropDown(sender As Object, e As EventArgs) Handles cbbSupplier.DropDown
        DropDown(cbbSupplier, supplierPlhTxt)
    End Sub

    Private Sub cbbSupplier_DropDownClosed(sender As Object, e As EventArgs) Handles cbbSupplier.DropDownClosed
        DropDownClosed(cbbSupplier, supplierPlhTxt)
    End Sub

    Private Sub cbbWarehouse_DropDown(sender As Object, e As EventArgs) Handles cbbWarehouse.DropDown
        DropDown(cbbWarehouse, warehousePlhTxt)
    End Sub

    Private Sub cbbWarehouse_DropDownClosed(sender As Object, e As EventArgs) Handles cbbWarehouse.DropDownClosed
        DropDownClosed(cbbWarehouse, warehousePlhTxt)
    End Sub

    Private Sub cbbStatus_DropDown(sender As Object, e As EventArgs) Handles cbbStatus.DropDown
        DropDown(cbbStatus, statusPlhTxt)
    End Sub

    Private Sub cbbStatus_DropDownClosed(sender As Object, e As EventArgs) Handles cbbStatus.DropDownClosed
        DropDownClosed(cbbStatus, statusPlhTxt)
    End Sub

    'Private Sub dgvCategory_KeyUp(sender As Object, e As KeyEventArgs)
    '    If e.KeyCode.Equals(Keys.Up) Or e.KeyCode.Equals(Keys.Down) Then
    '        'If dgvCategory.CurrentRow IsNot Nothing And bSave.Enabled = False Then
    '        addEditDeleteEnabled(True)
    '        setEnable(False)
    '        setValue()
    '        'End If
    '    End If
    'End Sub
End Class