Imports LibraryDataset
Imports LibraryCommon
Public Class SalesOrder
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsOrderDetail(conn.connSales.ConnectionString)
    Dim clsProduct As New clsProduct(conn.connSales.ConnectionString)
    Dim clsCBB As New clsCBB(conn.connSales.ConnectionString)

    Private listName As New List(Of String)
    Private listNumber As New List(Of String)

    Private Sub dgvOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listBuyProduct.Columns.Add("Id", 30)
        listBuyProduct.Columns.Add("Product")
        listBuyProduct.Columns.Add("Number")
        Reload()
    End Sub
    Private Sub Reload()
        Dim dataShipper = clsCBB.GetCBBShipper().CBBPerson
        Dim dataStatus = clsCBB.GetCBBStatusOfOrder().CBBStatus
        Dim dataProduct = clsCBB.GetCBBProduct().CBBProduct

        cbbShipper.Items.Clear()
        cbbShipStatus.Items.Clear()
        cbbProduct.Items.Clear()

        For Each row As DataRow In dataShipper.Rows
            cbbShipper.Items.Add(New CBBPerson(row(0), row(1)))
        Next

        For Each row As DataRow In dataStatus.Rows
            cbbShipStatus.Items.Add(New CBBItem(row(0), row(1)))
        Next

        For Each row As DataRow In dataProduct.Rows
            cbbProduct.Items.Add(New CBBItem(row(0), row(1)))
        Next

        Dim table As New DataTable
        table.Columns.Add("OrderId", GetType(Long))
        table.Columns.Add("CustomerName", GetType(String))
        table.Columns.Add("OrderDate", GetType(Date))
        table.Columns.Add("ShipDate", GetType(Date))
        table.Columns.Add("ShipAddress", GetType(String))
        table.Columns.Add("StatusId", GetType(Integer))
        table.Columns.Add("TotalOfProduct", GetType(Long))
        table.Columns.Add("ShipPrice", GetType(Double))
        table.Columns.Add("TotalPrice", GetType(Double))
        table.Columns.Add("PrivateDiscount", GetType(Double))
        table.Columns.Add("PaymentMethod", GetType(String))
        table.Columns.Add("ListProductId", GetType(String))
        table.Columns.Add("SupplierId", GetType(Long))
        table.Columns.Add("ShipperId", GetType(String))

        Dim data = clsPMSAnalysis.GetAllSaleOrders()

        If data.SalesOrder.Count > 0 Then
            listName.Clear()
            listNumber.Clear()

            Dim i = 0
            While i < data.SalesOrder.Rows.Count
                Dim id As Long = data.SalesOrder.Rows(i)(0)
                Dim j = i
                Dim s = "", lineName = "", lineNumber = ""
                Dim totalProduct = 0
                While j < data.SalesOrder.Rows.Count
                    If data.SalesOrder.Rows(j)(0) <> id Then
                        Exit While
                    End If
                    totalProduct += If(Not IsDBNull(data.SalesOrder.Rows(j)("NumberOfProducts")), data.SalesOrder.Rows(j)("NumberOfProducts"), 0)
                    s += If(Not IsDBNull(data.SalesOrder.Rows(j)("ProductId")), data.SalesOrder.Rows(j)("ProductId").ToString + ",", "NULL" + ",")
                    lineName += If(Not IsDBNull(data.SalesOrder.Rows(j)("ProductName")), data.SalesOrder.Rows(j)("ProductName") + ",", "NULL" + ",")
                    lineNumber += If(Not IsDBNull(data.SalesOrder.Rows(j)("NumberOfProducts")), data.SalesOrder.Rows(j)("NumberOfProducts").ToString + ",", "NULL" + ",")
                    j += 1
                End While

                listName.Add(lineName.Substring(0, Len(lineName) - 1))
                listNumber.Add(lineNumber.Substring(0, Len(lineNumber) - 1))

                Dim rowTable As DataRow = table.NewRow
                Dim row = data.SalesOrder.Rows(j - 1)

                rowTable("OrderId") = row("OrderId")
                rowTable("CustomerName") = row("CustomerName")
                rowTable("OrderDate") = row("OrderDate")
                rowTable("ShipDate") = row("ShipDate")
                rowTable("ShipAddress") = row("ShipAddress")
                rowTable("StatusId") = row("StatusId")
                rowTable("TotalOfProduct") = totalProduct
                rowTable("ShipPrice") = row("ShipPrice")
                rowTable("TotalPrice") = row("TotalPrice")
                rowTable("PrivateDiscount") = row("PrivateDiscount")
                rowTable("PaymentMethod") = row("PaymentMethod")
                rowTable("ListProductId") = s.Substring(0, Len(s) - 1)
                rowTable("SupplierId") = row("SupplierId")
                rowTable("ShipperId") = row("ShipperId")
                table.Rows.Add(rowTable)

                i = j
            End While

            dgvOrder.DataSource = table
            setValue()
        Else
            MsgBox("There isn't any sales order to show!")
        End If
        setEnable(False)
    End Sub

    Private Sub setValue()
        If dgvOrder Is Nothing Then
            Return
        Else
            Dim row As DataGridViewRow = dgvOrder.CurrentRow
            txtOrderCode.Text = row.Cells(0).Value.ToString
            txtCustomerName.Text = row.Cells(1).Value.ToString
            dtOrderDate.Text = row.Cells(2).Value.ToString
            dtShipDate.Text = row.Cells(3).Value.ToString
            txtShipAddress.Text = row.Cells(4).Value.ToString

            For Each item As CBBItem In cbbShipStatus.Items
                If item.PropItemId = row.Cells(5).Value.ToString Then
                    cbbShipStatus.SelectedItem = item
                End If
            Next

            txtShipFee.Text = row.Cells(7).Value.ToString
            txtTotalPrice.Text = row.Cells(8).Value.ToString
            txtDiscount.Text = row.Cells(9).Value.ToString
            txtPaymentMethod.Text = row.Cells(10).Value.ToString

            'Listview product
            listBuyProduct.Items.Clear()
            Dim id = row.Cells(11).Value.ToString.Split(",")
            Dim name = listName(dgvOrder.CurrentRow.Index).Split(",")
            Dim number = listNumber(dgvOrder.CurrentRow.Index).Split(",")
            If id(0).ToString <> "NULL" Then
                For i = 0 To id.Length - 1
                    Dim rowView = listBuyProduct.Items.Add(id(i))
                    rowView.SubItems.Add(name(i))
                    rowView.SubItems.Add(number(i))
                Next

            End If

            If listBuyProduct.Items.Count > 0 Then
                listBuyProduct.Items(0).Selected = True
                For Each item As CBBItem In cbbProduct.Items
                    If item.PropItemId = CLng(listBuyProduct.Items(0).SubItems(0).Text) Then
                        cbbProduct.SelectedItem = item
                        txtNumber.Text = listBuyProduct.Items(0).SubItems(2).Text
                    End If
                Next
            Else
                cbbProduct.SelectedIndex = -1
                txtNumber.Text = ""
            End If

            For Each item As CBBPerson In cbbShipper.Items
                If item.PropItemId = row.Cells(13).Value.ToString Then
                    cbbShipper.SelectedItem = item
                End If
            Next
        End If
    End Sub
    Private Sub bEdit_Click(sender As Object, e As EventArgs) Handles bEdit.Click
        If cbbShipStatus.SelectedItem IsNot Nothing Then
            If CType(cbbShipStatus.SelectedItem, CBBItem).PropItemId <> clsCBB.GetDeleveredId().Rows(0)(0) Then
                setEnable(True)
            Else
                MsgBox("Order was delevered to customer, you can't edit it!")
            End If
        End If
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
        txtPaymentMethod.Enabled = valBoolean
        labUpdate.Visible = valBoolean
        labRemove.Visible = valBoolean

        If valBoolean Then
            listBuyProduct.Location = New Point(188, 12)
            listBuyProduct.Size = New Point(188, 95)
        Else
            listBuyProduct.Location = New Point(140, 12)
            listBuyProduct.Size = New Point(188, 95)
        End If
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
        txtPaymentMethod.Text = ""
        txtTotalPrice.Text = ""
        listBuyProduct.Items.Clear()
    End Sub

    Private Sub bAdd_Click(sender As Object, e As EventArgs) Handles bAdd.Click
        clearValue()
        setEnable(True)
    End Sub
    Private Sub dgvOrder_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrder.CellClick
        setEnable(False)
        setValue()
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        If checkLogicData() Then
            Dim hasDelevered = False
            If cbbShipStatus.SelectedItem IsNot Nothing Then
                If CType(cbbShipStatus.SelectedItem, CBBItem).PropItemId = clsCBB.GetDeleveredId().Rows(0)(0) Then
                    Dim ask As MsgBoxResult = MsgBox("Once the order is updated to delivered, you won't be able to edit it in the future! Are you sure to save the order?", MsgBoxStyle.YesNo)
                    If ask = MsgBoxResult.No Then
                        Exit Sub
                    Else
                        hasDelevered = True
                    End If
                End If
            End If

            Dim result As Integer = 1

            'Add data sale to SalesDetail table
            Dim stockId = -1
            Dim number = -1
            If hasDelevered Then
                Dim dataSalesDetail = clsPMSAnalysis.GetAllSalesDetail()
                For Each item In listBuyProduct.Items
                    result = 123
                    Dim cost As Double = 0
                    Dim costItem = clsProduct.GetCostOfProduct(item.SubItems(0).Text)
                    cost += (costItem(0)(0) * (1 - costItem(0)(1) / 100)) * item.SubItems(2).Text

                    For Each row In dataSalesDetail.Rows
                        If row(1) = item.SubItems(0).Text Then
                            If row(2) >= (item.SubItems(2).Text + row(3)) Then
                                result = 1
                                clsPMSAnalysis.UpdateSalesDetail(row(0), row(1), row(2), item.SubItems(2).Text + row(3), cost)
                                Exit For
                            End If
                            number = row(2) - row(3)
                        End If
                    Next

                    If result = 123 Then
                        stockId = item.SubItems(0).Text
                        Exit For
                    End If

                Next

            Else
                Dim dataSalesDetail = clsPMSAnalysis.GetAllSalesDetail()
                For Each item In listBuyProduct.Items
                    result = 123

                    For Each row In dataSalesDetail.Rows
                        If row(1) = item.SubItems(0).Text Then
                            If row(2) >= (item.SubItems(2).Text + row(3)) Then
                                result = 1
                                Exit For
                            End If
                            number = row(2) - row(3)
                        End If
                    Next

                    If result = 123 Then
                        stockId = item.SubItems(0).Text
                        Exit For
                    End If

                Next

            End If

            Dim type As String = "Update"
            If result = 1 Then
                Dim shipperId = CType(cbbShipper.SelectedItem, CBBPerson).PropItemId
                Dim statusId = CType(cbbShipStatus.SelectedItem, CBBItem).PropItemId

                If txtOrderCode.Text <> "" Then             'Edit
                    result = clsPMSAnalysis.UpdateOrder(txtOrderCode.Text, txtCustomerName.Text,
                                            dtOrderDate.Value, shipperId, dtShipDate.Value, txtShipAddress.Text, txtShipFee.Text, statusId,
                                             txtDiscount.Text, txtTotalPrice.Text, txtPaymentMethod.Text, "", LoginForm.PropUsername)


                    For Each product In listBuyProduct.Items
                        If result = 1 Then
                            Dim totalPrice As Double = 0
                            Dim costItem = clsProduct.GetCostOfProduct(product.SubItems(0).Text)
                            totalPrice += (costItem(0)(0) * (1 - costItem(0)(1) / 100)) * product.SubItems(2).Text

                            If Not clsPMSAnalysis.CheckIfOrderDetailExists(txtOrderCode.Text, product.SubItems(0).Text) Then
                                result = clsPMSAnalysis.AddOrderDetail(txtOrderCode.Text, product.SubItems(0).Text, product.SubItems(2).Text, totalPrice)
                            Else
                                result = clsPMSAnalysis.UpdateOrderDetail(txtOrderCode.Text, product.SubItems(0).Text, product.SubItems(2).Text, totalPrice)
                            End If
                        Else
                            Exit For
                        End If
                    Next

                    Dim id = dgvOrder.CurrentRow.Cells(11).Value.ToString.Split(",")
                    If id(0).ToString <> "NULL" Then
                        For Each oldProduct In id
                            If result = 1 Then
                                Dim isExist = False
                                For Each product In listBuyProduct.Items
                                    If product.SubItems(0).Text = oldProduct Then
                                        isExist = True
                                        Exit For
                                    End If
                                Next

                                If Not isExist Then
                                    result = clsPMSAnalysis.DeleteOrderDetail(txtOrderCode.Text, oldProduct)
                                End If

                            End If
                        Next
                    End If
                Else                                        'Add new
                    Dim orderId = clsPMSAnalysis.AddOrder(txtCustomerName.Text,
                                            dtOrderDate.Value, shipperId, dtShipDate.Value, txtShipAddress.Text, txtShipFee.Text, statusId,
                                             txtDiscount.Text, txtTotalPrice.Text, txtPaymentMethod.Text, "", LoginForm.PropUsername)

                    result = 1

                    For Each product In listBuyProduct.Items
                        If result = 1 Then

                            Dim totalPrice As Double = 0
                            Dim costItem = clsProduct.GetCostOfProduct(product.SubItems(0).Text)
                            totalPrice += (costItem(0)(0) * (1 - costItem(0)(1) / 100)) * product.SubItems(2).Text

                            If Not clsPMSAnalysis.CheckIfOrderDetailExists(orderId, product.SubItems(0).Text) Then
                                result = clsPMSAnalysis.AddOrderDetail(orderId, product.SubItems(0).Text, product.SubItems(2).Text, totalPrice)
                            End If

                        Else
                            Exit For
                        End If
                    Next

                    type = "Add"
                End If

            End If

            If result = 1 Then
                setEnable(False)
                MsgBox(type & " order information successful!")
                Reload()
            ElseIf result = 123 Then
                If number <= 0 Then
                    MsgBox("The item has id " & stockId & " is out of stock!")
                Else
                    MsgBox("The item has id " & stockId & " only " & number & " left!")
                End If
            Else
                MsgBox("There is an error when interact with database!")
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
        If txtCustomerName.Text = "" Or cbbShipper.Text = "" Or
            txtShipAddress.Text = "" Or cbbShipStatus.Text = "" Or txtPaymentMethod.Text = "" Then

            MsgBox("You need to enter all the fields!")
            Return False

        ElseIf Not CheckValue("Ship fee", txtShipFee.Text, "Double") Or
             Not CheckValue("Discount", txtDiscount.Text, "Double") Then
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

    Private Sub listBuyProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBuyProduct.SelectedIndexChanged
        If listBuyProduct.SelectedItems.Count > 0 Then
            Dim selectedRow = listBuyProduct.SelectedItems(0)

            If cbbProduct.Enabled = False Then
                For Each item As CBBItem In cbbProduct.Items
                    If item.PropItemId = CLng(selectedRow.SubItems(0).Text) Then
                        cbbProduct.SelectedItem = item
                        txtNumber.Text = selectedRow.SubItems(2).Text
                    End If
                Next
            Else
                Dim abc = New CBBItem(selectedRow.SubItems(0).Text, selectedRow.SubItems(1).Text)
                cbbProduct.Items.Add(abc)
                cbbProduct.SelectedItem = abc
                txtNumber.Text = selectedRow.SubItems(2).Text
            End If
        End If
    End Sub

    Private Sub pictureAdd_Click(sender As Object, e As EventArgs) Handles pictureAdd.Click
        Dim isExist = False
        Dim selectedRow = CType(cbbProduct.SelectedItem, CBBItem)

        Dim number

        If cbbProduct.Text = "" Then
            MsgBox("You haven't selected product to add yet!")
            Exit Sub
        ElseIf txtNumber.Text = "" Then
            number = "0"
        ElseIf Not CheckValue("Number of products", txtNumber.Text, "Long") Then
            Exit Sub
        Else
            number = txtNumber.Text
        End If

        For Each item In listBuyProduct.Items
            If selectedRow.PropItemId = item.SubItems(0).Text Then
                cbbProduct.SelectedIndex = -1
                If CheckValue("Number of products", txtNumber.Text, "Long") Then
                    item.SubItems(2).Text = number
                    txtNumber.Text = ""
                    isExist = True
                End If
            End If
        Next

        If Not isExist Then
            Dim rowView = listBuyProduct.Items.Add(selectedRow.PropItemId)
            rowView.SubItems.Add(selectedRow.PropItemName)
            rowView.SubItems.Add(number)
            cbbProduct.Items.RemoveAt(cbbProduct.SelectedIndex)
            txtNumber.Text = ""
        End If

        CalculateTotalPrice()
    End Sub


    Private Sub pictureRemove_Click(sender As Object, e As EventArgs) Handles pictureRemove.Click
        If listBuyProduct.SelectedItems.Count > 0 Then
            Dim selectedRow = listBuyProduct.SelectedItems(0)

            cbbProduct.Items.Add(New CBBItem(selectedRow.SubItems(0).Text, selectedRow.SubItems(1).Text))
            txtNumber.Text = selectedRow.SubItems(2).Text
            listBuyProduct.Items.RemoveAt(listBuyProduct.SelectedIndices(0))

        Else
            MsgBox("You haven't selected the product in table you want to delete yet!")
        End If
        CalculateTotalPrice()
    End Sub

    Private Sub bDelete_Click(sender As Object, e As EventArgs) Handles bDelete.Click
        If txtOrderCode.Text <> "" Then
            Dim result = clsPMSAnalysis.DeleteOrder(txtOrderCode.Text, LoginForm.PropUsername)
            If result = 1 Then
                MsgBox("Delete order successful!")
            Else
                MsgBox("There is an error when interact with database!")
            End If
        End If
        Reload()
    End Sub

    Private Sub cbbProduct_Click(sender As Object, e As EventArgs) Handles cbbProduct.Click
        Dim dataProduct = clsCBB.GetCBBProduct().CBBProduct
        Dim isExist = False

        cbbProduct.Items.Clear()
        For index = 0 To dataProduct.Count - 1
            Dim row = dataProduct(index)
            For Each item In listBuyProduct.Items
                If row(0) = item.SubItems(0).Text Then
                    isExist = True
                    Exit For
                End If
            Next

            If Not isExist Then
                cbbProduct.Items.Add(New CBBItem(row(0), row(1)))
            End If
            isExist = False
        Next
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

        If Not CheckValue("Ship fee", shipFee, "Double") Or Not CheckValue("Discount", discount, "Double") Then
            txtTotalPrice.Text = "#N/A"
        Else
            Dim cost As Double = 0
            For Each item In listBuyProduct.Items
                Dim costItem = clsProduct.GetCostOfProduct(item.SubItems(0).Text)
                cost += (costItem(0)(0) * (1 - costItem(0)(1) / 100)) * item.SubItems(2).Text
            Next
            cost += shipFee
            cost *= 1 - discount / 100
            txtTotalPrice.Text = cost
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

End Class