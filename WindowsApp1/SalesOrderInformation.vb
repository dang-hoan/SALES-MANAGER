Imports LibraryDataset
Imports LibraryCommon
Imports System.ComponentModel
Imports System.Globalization

Public Class SalesOrderInformation
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsOrderDetail(conn.connSales.ConnectionString)
    Dim clsProduct As New clsProduct(conn.connSales.ConnectionString)
    Dim clsWarehouse As New clsWarehouse(conn.connSales.ConnectionString)
    Dim clsCBB As New clsCBB(conn.connSales.ConnectionString)
    Dim clsRolePermission As New clsRolePermission(conn.connSales.ConnectionString)

    Private _recordsPerPage As Integer = 4
    Private bs As BindingSource = New BindingSource()
    Private tables As BindingList(Of DataTable) = New BindingList(Of DataTable)()
    Private listCheckboxValue As New List(Of Long)

    Private WithEvents CheckTest As New DataGridViewCheckBoxHeaderCell()

    Dim mode As String = "Update"

    Public Sub LoadData(orderCode As Long)
        txtOrderCode.Enabled = False
        txtTotalCosts.Enabled = False
        txtCosts.Enabled = False

        Dim dataShipper = clsCBB.GetCBBShipper().CBBPerson
        Dim dataPaymentMethod = clsCBB.GetCBBPaymentMethod().CBBPaymentMethod
        Dim dataStatus = clsCBB.GetCBBStatusOfOrder().CBBStatus
        Dim dataProduct = clsCBB.GetCBBProduct().CBBProduct

        cbbShipper.Items.Clear()
        cbbPaymentMethod.Items.Clear()
        cbbShipStatus.Items.Clear()
        cbbProduct.Items.Clear()

        For Each row As DataRow In dataShipper.Rows
            cbbShipper.Items.Add(New CBBItem(row(0), row(1)))
        Next

        For Each row As DataRow In dataPaymentMethod.Rows
            cbbPaymentMethod.Items.Add(New CBBItem(row(0), row(1)))
        Next

        For Each row As DataRow In dataStatus.Rows
            cbbShipStatus.Items.Add(New CBBItem(row(0), row(1)))
        Next

        For Each row As DataRow In dataProduct.Rows
            cbbProduct.Items.Add(New CBBItem(row(0), row(1)))
        Next

        listBuyProduct.Columns(0).HeaderCell = CheckTest

        If orderCode = -1 Then
            setEnable(True)
            mode = "Add"

            labTitle.Text = "ADD SALES ORDER"
            labTitle.Location = New Point(Me.Width / 2 - labTitle.Width / 2, labTitle.Location.Y)

            Dim x As Integer = (Me.Width - bSave.Width) / 2

            bSave.Location = New Point(x, bSave.Location.Y)
            bEdit.Visible = False
            bDelete.Visible = False

        Else
            setEnable(False)

            Dim data = clsPMSAnalysis.GetSalesOrderById(orderCode)
            txtOrderCode.Text = orderCode
            txtCustomerName.Text = data("CustomerName")
            txtShipFee.Text = data("ShipPrice")
            dtOrderDate.Value = data("OrderDate")
            dtShipDate.Value = data("ShipDate")
            txtShipAddress.Text = data("ShipAddress")
            txtDiscount.Text = data("PrivateDiscount")
            txtTotalCosts.Text = data("TotalPrice")

            For Each item As CBBItem In cbbShipper.Items
                If item.PropItemId = data("ShipperId") Then
                    cbbShipper.SelectedItem = item
                End If
            Next
            For Each item As CBBItem In cbbPaymentMethod.Items
                If item.PropItemId = data("PaymentMethodId") Then
                    cbbPaymentMethod.SelectedItem = item
                End If
            Next
            For Each item As CBBItem In cbbShipStatus.Items
                If item.PropItemId = data("StatusId") Then
                    cbbShipStatus.SelectedItem = item
                End If
            Next

            If CType(cbbShipStatus.SelectedItem, CBBItem).PropItemId = clsCBB.GetDeliveredId() Then
                bEdit.Enabled = False
            End If

        End If
        InitPlaceHolderText()

    End Sub
    Private Sub SalesOrderInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetVisibleForPermission()
        If mode <> "Add" Then
            SetPagedDataSource(clsPMSAnalysis.GetProductsInforByOrderId(txtOrderCode.Text))
        Else
            SetPagedDataSource(clsPMSAnalysis.GetProductsInforByOrderId(-1))
        End If
    End Sub

    Private cellContentValueChangedByUser = False  'Remark cell content datagridview value change cause code or cause user click
    Public Sub SetPagedDataSource(ByVal dataTable As DataTable)
        tables.Clear()
        Dim dt As DataTable = Nothing
        Dim counter As Integer = 1           'Count number of records of a page

        For Each dr As DataRow In dataTable.Rows
            If counter = 1 Then
                dt = dataTable.Clone()
                tables.Add(dt)
            End If

            dt.Rows.Add(dr.ItemArray)

            counter += 1
            If _recordsPerPage < counter Then
                counter = 1
            End If
        Next

        If dataTable.Rows.Count = 0 Then
            tables.Add(clsPMSAnalysis.GetProductsInforByOrderId(-1))
        End If

        bindingNav.BindingSource = bs
        bs.DataSource = tables
        AddHandler bs.PositionChanged, AddressOf bs_PositionChanged
        bs_PositionChanged(bs, EventArgs.Empty)

        listBuyProduct.ReadOnly = False
        For i = 1 To listBuyProduct.Columns.Count - 1
            listBuyProduct.Columns(i).ReadOnly = True
        Next
        listCheckboxValue.Clear()
        cellContentValueChangedByUser = False
        CheckTest.CheckUncheckEntireColumn(listCheckboxValue)
        CheckTest.Checked = False
    End Sub
    Private Sub bs_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
        If bs.Position >= 0 Then
            Me.listBuyProduct.DataSource = tables(bs.Position)
            'Else
            '    'Me.listBuyProduct.DataSource = Nothing
            '    'If TypeOf Me.listBuyProduct.DataSource Is DataTable Then
            '    '    Dim dt = Me.listBuyProduct.DataSource
            '    '    dt.Rows.Clear()
            '    '    Me.listBuyProduct.DataSource = dt
            '    'End If

            '    Me.listBuyProduct.DataSource = clsPMSAnalysis.GetProductsInforByOrderId(-1)
        End If
        cellContentValueChangedByUser = False
        CheckTest.CheckUncheckEntireColumn(listCheckboxValue)
    End Sub
    Private Sub CheckBoxHeaderCell_CheckBoxClicked(sender As Object, e As DataGridViewCheckBoxHeaderCellEventArgs) Handles CheckTest.CheckBoxClicked
        listCheckboxValue.Clear()
        If e.Checked Then
            For Each dt In tables.ToList
                For Each row In dt.Rows
                    listCheckboxValue.Add(row(0))
                Next
            Next
        End If
        cellContentValueChangedByUser = False
        CheckTest.CheckUncheckEntireColumn(listCheckboxValue)
    End Sub
    Private Sub listBuyProduct_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles listBuyProduct.CellContentClick
        'listBuyProduct.CommitEdit(DataGridViewDataErrorContexts.Commit)
        cellContentValueChangedByUser = True
    End Sub
    Private Sub listBuyProduct_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles listBuyProduct.CellValueChanged
        If e.ColumnIndex = 0 And e.RowIndex <> -1 And cellContentValueChangedByUser Then
            'Console.WriteLine("check " & listBuyProduct.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
            If listBuyProduct.Rows(e.RowIndex).Cells(e.ColumnIndex).Value Then
                listCheckboxValue.Add(listBuyProduct.Rows(e.RowIndex).Cells(1).Value.ToString())
            Else
                listCheckboxValue.Remove(listBuyProduct.Rows(e.RowIndex).Cells(1).Value.ToString())
            End If
            'Console.WriteLine(listCheckboxValue.Count)
            If listCheckboxValue.Count = tables.Sum(Function(l) l.Rows.Count) Then
                CheckTest.Checked = True
            Else
                CheckTest.Checked = False
            End If
        End If
    End Sub
    Private Sub listBuyProduct_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles listBuyProduct.CellMouseUp
        If e.ColumnIndex = 0 And e.RowIndex <> -1 Then
            listBuyProduct.EndEdit()       'Notification datagridview to start value change event
        End If
    End Sub

    Private Sub listBuyProduct_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles listBuyProduct.ColumnHeaderMouseClick
        If (e.ColumnIndex <> CheckTest.ColumnIndex) Then
            cellContentValueChangedByUser = False
            CheckTest.CheckUncheckEntireColumn(listCheckboxValue)
        End If
    End Sub

    Private Sub listBuyProduct_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles listBuyProduct.CellDoubleClick
        If (e.ColumnIndex > 0 And e.RowIndex >= 0) Then
            If clsProduct.CheckProductWasDeleted(listBuyProduct.CurrentRow.Cells("ProductId").Value.ToString()) Then
                MsgBox("This product was deleted! You can't to see product's detail information!")
            Else
                Dim frmProductInformation = New ProductInformation()
                frmProductInformation.LoadData(listBuyProduct.CurrentRow.Cells("ProductId").Value.ToString(), True)
                frmProductInformation.ShowDialog()
            End If
        End If
        If (e.ColumnIndex = CheckTest.ColumnIndex And e.RowIndex <> -1) Then
            'A DoubleClick event is treated separate from a MouseUp event.
            'If a DoubleClick event is detected, the application will ignore the first MouseUp event entirely.
            listBuyProduct.EndEdit()   'So add this code to notification datagridview to start value change event
        End If
    End Sub


    'Set up placeholder text for comboboxes

    Private shipperPlhTxt = "Select a shipper"
    Private paymentMethodPlhTxt = "Select a payment method"
    Private shipStatusPlhTxt = "Select a ship status"

    Private Sub InitPlaceHolderText()
        DropDownClosed(cbbShipper, shipperPlhTxt)
        DropDownClosed(cbbPaymentMethod, paymentMethodPlhTxt)
        DropDownClosed(cbbShipStatus, shipStatusPlhTxt)
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

    Private Sub cbbShipper_DropDown(sender As Object, e As EventArgs) Handles cbbShipper.DropDown
        DropDown(cbbShipper, shipperPlhTxt)
    End Sub

    Private Sub cbbShipper_DropDownClosed(sender As Object, e As EventArgs) Handles cbbShipper.DropDownClosed
        DropDownClosed(cbbShipper, shipperPlhTxt)
    End Sub

    Private Sub cbbPaymentMethod_DropDown(sender As Object, e As EventArgs) Handles cbbPaymentMethod.DropDown
        DropDown(cbbPaymentMethod, paymentMethodPlhTxt)
    End Sub

    Private Sub cbbPaymentMethod_DropDownClosed(sender As Object, e As EventArgs) Handles cbbPaymentMethod.DropDownClosed
        DropDownClosed(cbbPaymentMethod, paymentMethodPlhTxt)
    End Sub

    Private Sub cbbShipStatus_DropDown(sender As Object, e As EventArgs) Handles cbbShipStatus.DropDown
        DropDown(cbbShipStatus, shipStatusPlhTxt)
    End Sub

    Private Sub cbbShipStatus_DropDownClosed(sender As Object, e As EventArgs) Handles cbbShipStatus.DropDownClosed
        DropDownClosed(cbbShipStatus, shipStatusPlhTxt)
    End Sub

    Private Sub SetVisibleForPermission()
        bEdit.Visible = False
        bDelete.Visible = False
        bSave.Visible = False
        Dim dataPermission = clsRolePermission.GetPermissionOfUser(LoginForm.PropUsername)
        For Each permission In dataPermission
            Dim form = permission(1).split(":")(0)
            Dim permiss = Strings.Split(Strings.Split(permission(1), ": ")(1), ", ")
            If form = "Order category" Then
                For Each p In permiss
                    Select Case p
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
        CenterButtons({bEdit, bDelete, bSave}.ToList, 30)
    End Sub

    Private Sub CenterButtons(ByRef listButtons As List(Of Button), ByVal offset_between As Integer)
        Dim totalWidth As Integer = 0
        Dim count = 0

        For Each btn As Button In listButtons
            If btn.Visible = True Then
                totalWidth += btn.Width
                count += 1
            End If
        Next

        Dim x As Integer = (listButtons(0).Parent.Width - totalWidth - offset_between * (count - 1)) / 2

        For Each btn As Button In listButtons
            If btn.Visible = True Then
                btn.Location = New Point(x, btn.Location.Y)
                x += btn.Width + offset_between
            End If
        Next
    End Sub

    Private Sub bEdit_Click(sender As Object, e As EventArgs) Handles bEdit.Click
        bEdit.Enabled = False
        setEnable(True)
    End Sub

    Private Sub setEnable(valBoolean As Boolean)
        txtCustomerName.Enabled = valBoolean
        cbbShipper.Enabled = valBoolean
        dtOrderDate.Enabled = valBoolean
        txtShipFee.Enabled = valBoolean
        dtShipDate.Enabled = valBoolean
        txtShipAddress.Enabled = valBoolean
        cbbShipStatus.Enabled = valBoolean
        cbbProduct.Enabled = valBoolean
        txtNumber.Enabled = valBoolean
        txtDiscount.Enabled = valBoolean
        cbbPaymentMethod.Enabled = valBoolean
        labUpdate.Visible = valBoolean
        labRemove.Visible = valBoolean

        If valBoolean Then
            listBuyProduct.Location = New Point(190, 12)
            listBuyProduct.Size = New Size(360, 180)
        Else
            listBuyProduct.Location = New Point(labUpdate.Location.X, 12)
            listBuyProduct.Size = New Size(360 + labRemove.Width - 5, 180)
        End If
        bSave.Enabled = valBoolean

        listBuyProduct.Columns("CheckBoxColumn").Visible = valBoolean
    End Sub
    Private Sub editDeleteEnabled(valBoolean As Boolean)
        bEdit.Enabled = valBoolean
        bDelete.Enabled = valBoolean
    End Sub
    Private Sub clearValue()
        txtOrderCode.Text = ""
        txtCustomerName.Text = ""
        cbbShipper.SelectedIndex = -1
        dtOrderDate.Value = DateTime.Now
        txtShipFee.Text = ""
        dtShipDate.Value = DateTime.Now
        txtShipAddress.Text = ""
        cbbShipStatus.SelectedIndex = -1
        cbbProduct.SelectedIndex = -1
        txtNumber.Text = ""
        txtDiscount.Text = ""
        cbbPaymentMethod.SelectedIndex = -1
        txtTotalCosts.Text = ""
        txtCosts.Text = ""
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        If checkLogicData() Then
            Dim result As Integer = 1

            Dim hasDelevered = False
            If cbbShipStatus.SelectedItem IsNot Nothing Then
                If CType(cbbShipStatus.SelectedItem, CBBItem).PropItemId = clsCBB.GetDeliveredId() Then
                    Dim ask As MsgBoxResult = MsgBox("Once the order is updated to delivered, you won't be able to edit it in the future! Are you sure to save the order?", MsgBoxStyle.YesNo, "Notification")
                    If ask = MsgBoxResult.No Then
                        Exit Sub
                    Else
                        hasDelevered = True
                    End If
                End If
            End If

            'Add data sale to SalesDetail table
            Dim stockId = -1
            Dim number = -1

            Dim dataSalesDetail = clsPMSAnalysis.GetAllSalesDetail()
            If hasDelevered Then
                For Each dt In tables
                    For Each product In dt.Rows
                        result = 123
                        Dim productId = product("ProductId")
                        Dim numberOfProducts = product("NumberOfProducts")
                        Dim totalPriceOfProducts = product("TotalPriceOfProducts")

                        For Each row In dataSalesDetail.Rows

                            If row("ProductId") = productId Then

                                'If Total quantity of this product >= number user buy + total sold quantity of this product then OK, else this product not enough!!!
                                If row("Total") >= (numberOfProducts + row("SellNumber")) Then
                                    result = 1

                                    'Update sell numbers and sales of this product
                                    clsPMSAnalysis.UpdateSalesDetail(row("WareHouseId"), row("ProductId"), row("Total"), numberOfProducts + row("SellNumber"), totalPriceOfProducts + row("SalesTotal"))

                                    'Update export numbers of warehouse which contains this product
                                    Dim oldExports = clsWarehouse.GetWarehouseById(row("WareHouseId"))("NumberOfExport")
                                    clsWarehouse.UpdateExportsOfWarehouse(oldExports + numberOfProducts, row("WareHouseId"))

                                    'If Total quantity of this product = number user buy + total sold quantity of this product then update this product is unavailable
                                    If row("Total") = (numberOfProducts + row("SellNumber")) Then
                                        result = clsProduct.UpdateStatus(row("ProductId"), clsCBB.GetUnavailableId())
                                    End If
                                    Exit For
                                End If
                                number = row("Total") - row("SellNumber")         'Number of products left
                            End If
                        Next

                        If result = 123 Then
                            stockId = productId
                            Exit For
                        End If

                    Next
                Next

            Else
                For Each dt In tables
                    For Each product In dt.Rows
                        result = 123
                        Dim productId = product("ProductId")
                        Dim numberOfProducts = product("NumberOfProducts")
                        Dim totalPriceOfProducts = product("TotalPriceOfProducts")

                        For Each row In dataSalesDetail.Rows

                            If row("ProductId") = productId Then

                                'If Total quantity of this product >= number user buy + total sold quantity of this product then OK, else this product not enough!!!
                                If row("Total") >= (numberOfProducts + row("SellNumber")) Then
                                    result = 1
                                    Exit For
                                End If
                                number = row("Total") - row("SellNumber")         'Number of products left
                            End If
                        Next

                        If result = 123 Then
                            stockId = productId
                            Exit For
                        End If
                    Next
                Next

            End If

            If result = 1 Then
                Dim shipperId = CType(cbbShipper.SelectedItem, CBBItem).PropItemId
                Dim paymentMethodId = CType(cbbPaymentMethod.SelectedItem, CBBItem).PropItemId
                Dim statusId = CType(cbbShipStatus.SelectedItem, CBBItem).PropItemId

                If mode = "Update" Then             'Edit
                    result = clsPMSAnalysis.UpdateOrder(txtOrderCode.Text, txtCustomerName.Text,
                                            dtOrderDate.Value, shipperId, dtShipDate.Value, txtShipAddress.Text, txtShipFee.Text, statusId,
                                             txtDiscount.Text, txtTotalCosts.Text, paymentMethodId, "", LoginForm.PropUsername)



                    'Check if orderdetail of this order in db not exist in list buy new product then remove it
                    Dim listOldProducts = clsPMSAnalysis.GetProductsInforByOrderId(txtOrderCode.Text)
                    For Each oldProduct In listOldProducts.Rows
                        If result = 1 Then
                            Dim isExist = False
                            For Each dt In tables
                                For Each product In dt.Rows
                                    If product("ProductId") = oldProduct("ProductId") Then
                                        isExist = True
                                        Exit For
                                    End If
                                Next
                            Next

                            If Not isExist Then
                                result = clsPMSAnalysis.DeleteOrderDetail(txtOrderCode.Text, oldProduct("ProductId"))
                            End If

                        End If
                    Next

                    'Check if order detail not exits then add it into db, else update it
                    For Each dt In tables
                        For Each product In dt.Rows
                            If result = 1 Then
                                If Not clsPMSAnalysis.CheckIfOrderDetailExists(txtOrderCode.Text, product("ProductId")) Then
                                    result = clsPMSAnalysis.AddOrderDetail(txtOrderCode.Text, product("ProductId"), product("NumberOfProducts"), product("TotalPriceOfProducts"))
                                Else
                                    result = clsPMSAnalysis.UpdateOrderDetail(txtOrderCode.Text, product("ProductId"), product("NumberOfProducts"), product("TotalPriceOfProducts"))
                                End If
                            Else
                                Exit For
                            End If
                        Next
                    Next

                Else                                        'Add new
                    Dim orderId = clsPMSAnalysis.AddOrder(txtCustomerName.Text,
                                            dtOrderDate.Value, shipperId, dtShipDate.Value, txtShipAddress.Text, txtShipFee.Text, statusId,
                                             txtDiscount.Text, txtTotalCosts.Text, paymentMethodId, "", LoginForm.PropUsername)

                    result = 1

                    For Each dt In tables
                        For Each product In dt.Rows
                            If result = 1 Then
                                result = clsPMSAnalysis.AddOrderDetail(orderId, product("ProductId"), product("NumberOfProducts"), product("TotalPriceOfProducts"))

                            Else
                                Exit For
                            End If
                        Next
                    Next

                    mode = "Add"
                End If

            End If

            If result = 1 Then
                MsgBox(mode & " order information successful!", Nothing, "Notification")
                Dim caller As SalesOrderCategory = CType(Application.OpenForms("SalesOrderCategory"), SalesOrderCategory)
                caller.Reload()
                Me.Close()

            ElseIf result = 123 Then
                If number <= 0 Then
                    MsgBox("The item has id " & stockId & " is out of stock!", Nothing, "Notification")
                Else
                    MsgBox("The item has id " & stockId & " only " & number & " left!", Nothing, "Notification")
                End If
            Else
                MsgBox("There is an error when interact with database!", Nothing, "Notification")
            End If

        End If
    End Sub
    Private Function checkLogicData() As Boolean
        If txtShipFee.Text = "" Then
            txtShipFee.Text = "0"
        End If
        If txtDiscount.Text = "" Then
            txtDiscount.Text = "0"
        End If
        If txtCustomerName.Text = "" Or txtShipAddress.Text = "" Then

            MsgBox("You need to enter all the fields!", Nothing, "Notification")
            Return False

        ElseIf cbbShipper.Text.Equals(shipperPlhTxt) Or cbbPaymentMethod.Text.Equals(paymentMethodPlhTxt) Or
                cbbShipStatus.Text.Equals(shipStatusPlhTxt) Then

            MsgBox("You need to select element for all comboboxes!", Nothing, "Notification")
            Return False

        ElseIf Not CheckValue("Ship fee", txtShipFee.Text, "Double") Or
             Not CheckValue("Discount", txtDiscount.Text, "Double") Then
            Return False

        ElseIf txtDiscount.Text < 0 Or txtDiscount.Text > 100 Then
            MsgBox("Discount percent must be in 0 - 100!", Nothing, "Notification")
            Return False

        Else
            Dim orderDT As DateTime = DateTime.ParseExact(dtOrderDate.Value.ToString("dd/MM/yyyy HH:mm"), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)
            Dim shipDT As DateTime = DateTime.ParseExact(dtShipDate.Value.ToString("dd/MM/yyyy HH:mm"), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)

            If orderDT > shipDT Then
                MsgBox("Order date can't be after ship date!")
                Return False
            End If
        End If

        Return True
    End Function

    Private Function CheckValue(ByVal label As String, ByVal value As String, ByVal style As String, Optional ByVal warning As Boolean = True) As Boolean
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
                    If warning Then
                        MsgBox(label & " must be a number!", Nothing, "Notification")
                    End If
                    returnVal = False
                Catch ex As OverflowException
                    If warning Then
                        MsgBox(label & " is too big to handle!", Nothing, "Notification")
                    End If
                    returnVal = False
                End Try

            Case "Double"
                Dim Number As Double
                Try
                    Number = Double.Parse(value)
                Catch ex As FormatException
                    If warning Then
                        MsgBox(label & " must be a number!", Nothing, "Notification")
                    End If
                    returnVal = False
                Catch ex As OverflowException
                    If warning Then
                        MsgBox(label & " is too big to handle!", Nothing, "Notification")
                    End If
                    returnVal = False
                End Try

        End Select

        Return returnVal

    End Function
    Private Sub listBuyProduct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles listBuyProduct.CellClick
        'Only process when row count = 1, the rest selectionchanged event process
        If (e.RowIndex <> -1 And listBuyProduct.RowCount = 1) Then
            Dim currentRow = listBuyProduct.CurrentRow

            If currentRow IsNot Nothing Then
                If currentRow.Cells("ProductId").Value IsNot Nothing Then
                    Dim productId = currentRow.Cells("ProductId").Value.ToString()
                    Dim productName = currentRow.Cells("ProductNameColumn").Value.ToString()
                    Dim numberOfProducts = currentRow.Cells("NumberOfProducts").Value.ToString()
                    Dim totalPriceOfProducts = currentRow.Cells("TotalPriceOfProducts").Value.ToString()
                    Dim statusName = currentRow.Cells("StatusName").Value.ToString()

                    If cbbProduct.Enabled = False Then
                        For Each item As CBBItem In cbbProduct.Items
                            If item.PropItemId = CLng(productId) Then
                                cbbProduct.SelectedItem = item
                                txtNumber.Text = numberOfProducts
                                txtCosts.Text = totalPriceOfProducts

                                If statusName = "UNAVAILABLE" Then
                                    labWarning.Text = "*Warning: this product is out of stock now!"
                                Else
                                    labWarning.Text = ""
                                End If
                            End If
                        Next
                    Else
                        Dim abc = New CBBItem(productId, productName)
                        cbbProduct.Items.Add(abc)
                        cbbProduct.SelectedItem = abc
                        txtNumber.Text = numberOfProducts
                        txtCosts.Text = totalPriceOfProducts

                        If statusName = "UNAVAILABLE" Then
                            labWarning.Text = "*Warning: this product is out of stock now!"
                        Else
                            labWarning.Text = ""
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub listBuyProduct_SelectionChanged(sender As Object, e As EventArgs) Handles listBuyProduct.SelectionChanged
        Dim currentRow = listBuyProduct.CurrentRow

        If currentRow IsNot Nothing Then
            If currentRow.Cells("ProductId").Value IsNot Nothing Then
                Dim productId = currentRow.Cells("ProductId").Value.ToString()
                Dim productName = currentRow.Cells("ProductNameColumn").Value.ToString()
                Dim numberOfProducts = currentRow.Cells("NumberOfProducts").Value.ToString()
                Dim totalPriceOfProducts = currentRow.Cells("TotalPriceOfProducts").Value.ToString()
                Dim statusName = currentRow.Cells("StatusName").Value.ToString()

                If cbbProduct.Enabled = False Then
                    For Each item As CBBItem In cbbProduct.Items
                        If item.PropItemId = CLng(productId) Then
                            cbbProduct.SelectedItem = item
                            txtNumber.Text = numberOfProducts
                            txtCosts.Text = totalPriceOfProducts

                            If statusName = "UNAVAILABLE" Then
                                labWarning.Text = "*Warning: this product is out of stock now!"
                            Else
                                labWarning.Text = ""
                            End If
                        End If
                    Next
                Else
                    Dim abc = New CBBItem(productId, productName)
                    cbbProduct.Items.Add(abc)
                    cbbProduct.SelectedItem = abc
                    txtNumber.Text = numberOfProducts
                    txtCosts.Text = totalPriceOfProducts

                    If statusName = "UNAVAILABLE" Then
                        labWarning.Text = "*Warning: this product is out of stock now!"
                    Else
                        labWarning.Text = ""
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub pictureAdd_Click(sender As Object, e As EventArgs) Handles pictureAdd.Click
        Dim isExist = False
        Dim selectedProduct = CType(cbbProduct.SelectedItem, CBBItem)

        Dim number

        'Check logic
        If cbbProduct.SelectedIndex = -1 Then
            MsgBox("You haven't selected product to add yet!", Nothing, "Notification")
            Exit Sub
        ElseIf txtNumber.Text = "" Then
            number = "0"
        ElseIf Not CheckValue("Number of products", txtNumber.Text, "Long") Then
            Exit Sub
        Else
            number = txtNumber.Text
        End If

        'Check if selected product exists in list buy product then update it, else add it into list buy product
        If selectedProduct IsNot Nothing Then
            For Each dt In tables
                For Each item In dt.Rows
                    If selectedProduct.PropItemId = item("ProductId") Then
                        cbbProduct.SelectedIndex = -1
                        item("NumberOfProducts") = number
                        item("TotalPriceOfProducts") = If(number = "0", "0", txtCosts.Text)
                        txtNumber.Text = ""
                        txtCosts.Text = ""
                        isExist = True
                    End If
                Next
            Next
        End If

        If Not isExist Then
            If tables.Count > 0 Then
                Dim lastDataTable = tables(tables.Count - 1)

                'If last datatable have number of rows max then create new datatable, add new row to it
                'and add it to BindingList,
                'else add new row to last datatable
                If lastDataTable.Rows.Count = _recordsPerPage Then
                    Dim newDatable = lastDataTable.Clone()
                    Dim newRow = newDatable.NewRow()
                    newRow("ProductId") = selectedProduct.PropItemId
                    newRow("ProductNameColumn") = selectedProduct.PropItemName
                    newRow("NumberOfProducts") = number
                    newRow("TotalPriceOfProducts") = If(number = "0", "0", txtCosts.Text)
                    newRow("StatusName") = "AVAILABLE"
                    newDatable.Rows.Add(newRow)
                    tables.Add(newDatable)
                Else
                    Dim newRow = lastDataTable.NewRow()
                    newRow("ProductId") = selectedProduct.PropItemId
                    newRow("ProductNameColumn") = selectedProduct.PropItemName
                    newRow("NumberOfProducts") = number
                    newRow("TotalPriceOfProducts") = If(number = "0", "0", txtCosts.Text)
                    newRow("StatusName") = "AVAILABLE"
                    lastDataTable.Rows.Add(newRow)
                End If

            Else
                Dim dt = CType(listBuyProduct.DataSource, DataTable)
                Dim newRow = dt.NewRow()
                newRow("ProductId") = selectedProduct.PropItemId
                newRow("ProductNameColumn") = selectedProduct.PropItemName
                newRow("NumberOfProducts") = number
                newRow("TotalPriceOfProducts") = If(number = "0", "0", txtCosts.Text)
                newRow("StatusName") = "AVAILABLE"
                dt.Rows.Add(newRow)
            End If

            listBuyProduct.Refresh()

            cbbProduct.Items.RemoveAt(cbbProduct.SelectedIndex)
            txtNumber.Text = ""
            txtCosts.Text = ""
        End If

        CalculateTotalPrice()
    End Sub

    Private Sub pictureRemove_Click(sender As Object, e As EventArgs) Handles pictureRemove.Click
        If listCheckboxValue.Count > 0 Then

            Dim newAll As New DataTable()

            For Each id In listCheckboxValue
                For Each dt In tables
                    Dim needRemoveRows As New List(Of DataRow)

                    For Each product In dt.Rows
                        If id = product("ProductId") Then
                            cbbProduct.Items.Add(New CBBItem(id, product("ProductNameColumn")))
                            needRemoveRows.Add(product)
                        End If
                    Next

                    For Each row In needRemoveRows
                        dt.Rows.Remove(row)
                    Next

                Next
            Next

            'set new datable for datagridview to paging again
            For Each dt In tables
                newAll.Merge(dt)
            Next
            SetPagedDataSource(newAll)

            txtNumber.Text = ""
            txtCosts.Text = ""
            listCheckboxValue.Clear()
            CalculateTotalPrice()
        Else
            MsgBox("Please check first cell of products you want to delete!")
        End If
    End Sub

    Private Sub bDelete_Click(sender As Object, e As EventArgs) Handles bDelete.Click
        Dim result = clsPMSAnalysis.DeleteOrder(txtOrderCode.Text, LoginForm.PropUsername)
        If result = 1 Then
            MsgBox("Delete order successful!", Nothing, "Notification")
            Dim caller As SalesOrderCategory = CType(Application.OpenForms("SalesOrderCategory"), SalesOrderCategory)
            caller.Reload()
            Me.Close()
        Else
            MsgBox("There is an error when interact with database!", Nothing, "Notification")
        End If
    End Sub

    Private Sub CalculateTotalPrice()
        Dim shipFee = txtShipFee.Text
        Dim discount = txtDiscount.Text

        If shipFee = "" Then
            shipFee = "0"
        End If
        If discount = "" Then
            discount = "0"
        End If

        If Not CheckValue("Ship fee", shipFee, "Double", False) Or Not CheckValue("Discount", discount, "Double", False) Then
            txtTotalCosts.Text = "#N/A"
        Else
            Dim cost As Double = 0
            For Each dt In tables
                For Each item In dt.Rows
                    cost += item("TotalPriceOfProducts")
                Next
            Next
            cost += shipFee
            cost *= 1 - discount / 100
            txtTotalCosts.Text = cost
        End If

    End Sub

    Private Sub txtShipFee_TextChanged(sender As Object, e As EventArgs) Handles txtShipFee.TextChanged
        If txtShipFee.Enabled = True Then
            CalculateTotalPrice()
        End If

    End Sub

    Private Sub txtDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscount.TextChanged
        If txtDiscount.Enabled = True Then
            CalculateTotalPrice()
        End If
    End Sub

    Private Sub txtNumber_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNumber.KeyUp
        Calculate_ProductCost()
    End Sub

    Private Sub Calculate_ProductCost()
        If cbbProduct.SelectedIndex <> -1 And txtNumber.Text <> "" Then
            If CheckValue("", txtNumber.Text, "Long", False) Then
                Dim costItem = clsProduct.GetCostOfProductById(CType(cbbProduct.SelectedItem, CBBItem).PropItemId)
                txtCosts.Text = (costItem("ProductPrice") * (1 - costItem("DiscountPercent") / 100)) * txtNumber.Text

            Else
                txtCosts.Text = "#N/A"

            End If
        End If
    End Sub

    Private Sub cbbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbProduct.SelectedIndexChanged
        Calculate_ProductCost()
    End Sub

    Private Sub cbbProduct_DropDown(sender As Object, e As EventArgs) Handles cbbProduct.DropDown
        Dim dataProduct = clsCBB.GetCBBProduct().CBBProduct
        Dim isExist = False

        cbbProduct.Items.Clear()

        'Only add products which not exists in list buy product into combobox
        For Each row In dataProduct.Rows
            For Each dt In tables
                For Each item In dt.Rows
                    If row(0) = item("ProductId") Then
                        isExist = True
                        Exit For
                    End If
                Next
            Next

            If Not isExist Then
                cbbProduct.Items.Add(New CBBItem(row(0), row(1)))
            End If
            isExist = False
        Next
    End Sub
End Class