Imports LibraryDataset
Imports LibraryCommon
Imports System.IO
Imports System.ComponentModel
Imports System.Globalization

Public Class SalesOrderCategory
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsOrderDetail(conn.connSales.ConnectionString)
    Dim clsProduct As New clsProduct(conn.connSales.ConnectionString)
    Dim clsWarehouse As New clsWarehouse(conn.connSales.ConnectionString)
    Dim clsCBB As New clsCBB(conn.connSales.ConnectionString)
    Dim clsRolePermission As New clsRolePermission(conn.connSales.ConnectionString)

    Private _recordsPerPage As Integer = 4
    Private bs As BindingSource = New BindingSource()
    Private tables As BindingList(Of DataTable)
    Private listCheckboxValue As New List(Of Long)

    Private WithEvents CheckTest As New DataGridViewCheckBoxHeaderCell()

    Private Sub dgvOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbbShipper.Enabled = False
        cbbShipStatus.Enabled = False
        dtShipDate.Enabled = False
        dtOrderDate.Enabled = False

        Dim dataShipper = clsCBB.GetCBBShipper().CBBPerson
        Dim dataPaymentMethod = clsCBB.GetCBBPaymentMethod().CBBPaymentMethod
        Dim dataStatus = clsCBB.GetCBBStatusOfOrder().CBBStatus

        cbbShipper.Items.Clear()
        cbbPaymentMethod.Items.Clear()
        cbbShipStatus.Items.Clear()

        For Each row As DataRow In dataShipper.Rows
            cbbShipper.Items.Add(New CBBItem(row(0), row(1)))
        Next

        For Each row As DataRow In dataPaymentMethod.Rows
            cbbPaymentMethod.Items.Add(New CBBItem(row(0), row(1)))
        Next

        For Each row As DataRow In dataStatus.Rows
            cbbShipStatus.Items.Add(New CBBItem(row(0), row(1)))
        Next

        dgvSalesOrderSearch.Columns(0).HeaderCell = CheckTest

        InitPlaceHolderText()
        SetVisibleForPermission()
        Reload()
    End Sub

    Private cellContentValueChangedByUser = False  'Remark cell content datagridview value change cause code or cause user click
    Public Sub SetPagedDataSource(ByVal dataTable As DataTable)
        tables = New BindingList(Of DataTable)()
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

        bindingNav.BindingSource = bs
        bs.DataSource = tables
        AddHandler bs.PositionChanged, AddressOf bs_PositionChanged
        bs_PositionChanged(bs, EventArgs.Empty)

        dgvSalesOrderSearch.ReadOnly = False
        For i = 1 To dgvSalesOrderSearch.Columns.Count - 1
            dgvSalesOrderSearch.Columns(i).ReadOnly = True
        Next
        listCheckboxValue.Clear()
        cellContentValueChangedByUser = False
        CheckTest.CheckUncheckEntireColumn(listCheckboxValue)
        CheckTest.Checked = False
    End Sub
    Private Sub bs_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
        If bs.Position >= 0 Then
            Me.dgvSalesOrderSearch.DataSource = tables(bs.Position)
        Else
            Me.dgvSalesOrderSearch.DataSource = Nothing
            'If TypeOf Me.dgvSalesOrderSearch.DataSource Is DataTable Then
            '    Dim dt = Me.dgvSalesOrderSearch.DataSource
            '    dt.Rows.Clear()
            '    Me.dgvSalesOrderSearch.DataSource = dt
            'End If
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
    Private Sub dgvSalesOrderSearch_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSalesOrderSearch.CellContentClick
        'dgvSalesOrderSearch.CommitEdit(DataGridViewDataErrorContexts.Commit)
        cellContentValueChangedByUser = True
    End Sub
    Private Sub dgvSalesOrderSearch_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalesOrderSearch.CellValueChanged
        If e.ColumnIndex = 0 And e.RowIndex <> -1 And cellContentValueChangedByUser Then
            'Console.WriteLine("check " & dgvSalesOrderSearch.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
            If dgvSalesOrderSearch.Rows(e.RowIndex).Cells(e.ColumnIndex).Value Then
                listCheckboxValue.Add(dgvSalesOrderSearch.Rows(e.RowIndex).Cells(1).Value.ToString())
            Else
                listCheckboxValue.Remove(dgvSalesOrderSearch.Rows(e.RowIndex).Cells(1).Value.ToString())
            End If
            'Console.WriteLine(listCheckboxValue.Count)
            If listCheckboxValue.Count = tables.Sum(Function(l) l.Rows.Count) Then
                CheckTest.Checked = True
            Else
                CheckTest.Checked = False
            End If
        End If
    End Sub
    Private Sub dgvSalesOrderSearch_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSalesOrderSearch.CellMouseUp
        If e.ColumnIndex = 0 And e.RowIndex <> -1 Then
            dgvSalesOrderSearch.EndEdit()       'Notification datagridview to start value change event
        End If
    End Sub
    Private Sub dgvSalesOrderSearch_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalesOrderSearch.CellDoubleClick
        If (e.ColumnIndex > 0 And e.RowIndex >= 0) Then
            Dim frmSalesOrderInformation = New SalesOrderInformation()
            frmSalesOrderInformation.LoadData(dgvSalesOrderSearch.SelectedRows(0).Cells(1).Value.ToString())
            frmSalesOrderInformation.ShowDialog()
        End If
        If (e.ColumnIndex = CheckTest.ColumnIndex And e.RowIndex <> -1) Then
            'A DoubleClick event is treated separate from a MouseUp event.
            'If a DoubleClick event is detected, the application will ignore the first MouseUp event entirely.
            dgvSalesOrderSearch.EndEdit()   'So add this code to notification datagridview to start value change event
        End If
    End Sub

    Private Sub dgvSalesOrderSearch_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSalesOrderSearch.ColumnHeaderMouseClick
        If (e.ColumnIndex <> CheckTest.ColumnIndex) Then
            cellContentValueChangedByUser = False
            CheckTest.CheckUncheckEntireColumn(listCheckboxValue)
        End If
    End Sub

    Private Sub SetVisibleForPermission()
        bAdd.Visible = False
        bDelete.Visible = False
        Dim dataPermission = clsRolePermission.GetPermissionOfUser(LoginForm.PropUsername)
        For Each permission In dataPermission
            Dim form = permission(1).split(":")(0)
            Dim permiss = Strings.Split(Strings.Split(permission(1), ": ")(1), ", ")
            If form = "Order category" Then
                For Each p In permiss
                    Select Case p
                        Case "Add"
                            bAdd.Visible = True
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
        Dim listButtons = New List(Of Button) From {bAdd, bDelete}
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
        Dim y As Integer = 495

        For Each btn As Button In listButtons
            If btn.Visible = True Then
                btn.Location = New Point(x, y)
                x += btn.Width + offset_between
            End If
        Next
    End Sub
    Public Sub Reload()
        SetPagedDataSource(clsPMSAnalysis.SearchSalesOrder(""))
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' AND ([Order].Id = @Id) AND ([Order].ShipperId = @ShipperId)
        ' AND ([Order].PaymentMethodId = @PaymentMethodId) AND ([Order].CustomerName = @CustomerName)
        ' AND ([Order].OrderDate = @OrderDate) AND ([Order].ShipDate = @ShipDate)
        ' AND ([Order].ShipAddress = [Order].ShipAddress) And ([Order].StatusId = @StatusId)
        If checkLogicData() Then
            Dim sqlCommand = ""

            If Not String.IsNullOrWhiteSpace(txtOrderCode.Text) Then
                sqlCommand &= $" AND [Order].Id = {txtOrderCode.Text}"
            End If

            sqlCommand &= $" AND [Order].CustomerName LIKE N'%{txtCustomerName.Text}%'"
            sqlCommand &= $" AND [Order].ShipAddress LIKE N'%{txtShipAddress.Text}%'"

            If cbShipper.Checked Then
                sqlCommand &= $" AND [Order].ShipperId = {CType(cbbShipper.SelectedItem, CBBItem).PropItemId}"
            End If

            If cbPaymentMethod.Checked Then
                sqlCommand &= $" AND [Order].PaymentMethodId = {CType(cbbPaymentMethod.SelectedItem, CBBItem).PropItemId}"
            End If

            'Get custom format and code format from https://learn.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql?view=sql-server-ver15#date-and-time-styles
            Dim customFormat = dtOrderDate.CustomFormat

            If cbOrderDate.Checked Then
                sqlCommand &= $" AND CONVERT(VARCHAR(10), [Order].OrderDate, 103) = '{dtOrderDate.Value.ToString(customFormat)}'"
            End If

            If cbShipDate.Checked Then
                sqlCommand &= $" AND CONVERT(VARCHAR(10), [Order].ShipDate, 103) = '{dtShipDate.Value.ToString(customFormat)}'"
            End If

            If cbShipStatus.Checked Then
                sqlCommand &= $" AND [Order].StatusId = {CType(cbbShipStatus.SelectedItem, CBBItem).PropItemId}"
            End If

            SetPagedDataSource(clsPMSAnalysis.SearchSalesOrder(sqlCommand))
        End If

    End Sub

    Private Function checkLogicData() As Boolean
        If Not CheckValue("Order code", txtOrderCode.Text, "Long") Then
            Return False

        ElseIf (cbShipper.Checked And cbbShipper.Text.Equals(shipperPlhTxt)) Or
            (cbPaymentMethod.Checked And cbbPaymentMethod.Text.Equals(paymentMethodPlhTxt)) Or
            (cbShipStatus.Checked And cbbShipStatus.Text.Equals(shipStatusPlhTxt)) Then

            MsgBox("You need to select element for the checked comboboxes!", Nothing, "Notification")
            Return False
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

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If tables Is Nothing Then
            MsgBox("No data to export!", Nothing, "Notification")
            Return
        End If

        If tables.Sum(Function(l) l.Rows.Count) = 0 Then
            MsgBox("No data to export!", Nothing, "Notification")
            Return
        End If


        For Each col In tables(0).Columns
            Console.WriteLine(col.ToString() & "  ")
        Next

        Dim sfd As SaveFileDialog = New SaveFileDialog()
        sfd.Title = "Select export data path"
        Dim defaultPath = Environ$("USERPROFILE") & "\Downloads"
        If Directory.Exists(defaultPath) Then
            sfd.InitialDirectory = defaultPath
        Else
            sfd.InitialDirectory = "C:\"
        End If
        sfd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        sfd.FilterIndex = 2
        sfd.RestoreDirectory = True
        Dim result = sfd.ShowDialog()
        If result = DialogResult.OK Then
            Dim fileName = Path.GetDirectoryName(sfd.FileName) & Path.AltDirectorySeparatorChar & Path.GetFileNameWithoutExtension(sfd.FileName)
            Dim ext = Path.GetExtension(sfd.FileName)
            If ext = "" Then
                ext += ".xlsx"
                sfd.FileName += ".xlsx"
            End If
            'If File.Exists(sfd.FileName) Then
            '    Dim i = 0
            '    Do
            '        sfd.FileName = fileName & "(" & i & ")" & ext
            '        i += 1
            '    Loop While File.Exists(sfd.FileName)
            'End If
            Dim exportObject As New Export()

            Dim listPrintedColumn As New List(Of KeyValuePair(Of Integer, String))
            For Each column In dgvSalesOrderSearch.Columns
                If column.Visible And Not column.Name.Equals("CheckBoxColumn") Then
                    Dim count = 0
                    For Each col In tables(0).Columns
                        If col.ToString().Equals(column.DataPropertyName) Then
                            listPrintedColumn.Add(New KeyValuePair(Of Integer, String)(count, column.HeaderText))
                        End If
                        count += 1
                    Next
                End If
            Next

            Dim listLeftFormat As New ArrayList() From {1, 4, 8, 9, 10, 11}       'list left format of datagridview column (excluding column Checkbox)
            Dim listDateTimeFormat As New ArrayList() From {2, 3}                 'list datetime format of datagridview column (excluding column Checkbox)
            exportObject.exportToExcel(sfd.FileName, tables, listPrintedColumn, listLeftFormat, "Sales order search", listDateTimeFormat)
        End If
    End Sub
    Private Sub cbShipper_CheckedChanged(sender As Object, e As EventArgs) Handles cbShipper.CheckedChanged
        cbbShipper.Enabled = cbShipper.Checked
    End Sub

    Private Sub cbPaymentMethod_CheckedChanged(sender As Object, e As EventArgs) Handles cbPaymentMethod.CheckedChanged
        cbbPaymentMethod.Enabled = cbPaymentMethod.Checked
    End Sub

    Private Sub cbOrderDate_CheckedChanged(sender As Object, e As EventArgs) Handles cbOrderDate.CheckedChanged
        dtOrderDate.Enabled = cbOrderDate.Checked
    End Sub

    Private Sub cbShipDate_CheckedChanged(sender As Object, e As EventArgs) Handles cbShipDate.CheckedChanged
        dtShipDate.Enabled = cbShipDate.Checked
    End Sub

    Private Sub cbShipStatus_CheckedChanged(sender As Object, e As EventArgs) Handles cbShipStatus.CheckedChanged
        cbbShipStatus.Enabled = cbShipStatus.Checked
    End Sub

    Private Sub bAdd_Click(sender As Object, e As EventArgs) Handles bAdd.Click
        Dim frmSalesOrderInformation = New SalesOrderInformation()
        frmSalesOrderInformation.LoadData(-1)
        frmSalesOrderInformation.ShowDialog()
    End Sub

    Private Sub bDelete_Click(sender As Object, e As EventArgs) Handles bDelete.Click
        If listCheckboxValue.Count > 0 Then
            Dim err = False

            For Each id In listCheckboxValue
                Dim result = clsPMSAnalysis.DeleteOrder(id, LoginForm.PropUsername)

                If result <> 1 Then
                    MsgBox("There is an error when interact with database!", Nothing, "Notification")
                    err = True
                    Exit For
                End If
            Next

            If Not err Then
                MsgBox("Delete selected orders information successful!", Nothing, "Notification")
                Reload()
            Else
            End If

        Else
            MsgBox("Please check first cell of orders you want to delete!")
        End If
    End Sub

    'Set up placeholder text for comboboxes

    Private shipperPlhTxt = "Select a shipper"
    Private paymentMethodPlhTxt = "Select a payment method"
    Private shipStatusPlhTxt = "Select a ship status"

    Private Sub InitPlaceHolderText()
        cbbShipper.Items.Insert(0, shipperPlhTxt)
        cbbShipper.Text = shipperPlhTxt

        cbbPaymentMethod.Items.Insert(0, paymentMethodPlhTxt)
        cbbPaymentMethod.Text = paymentMethodPlhTxt

        cbbShipStatus.Items.Insert(0, shipStatusPlhTxt)
        cbbShipStatus.Text = shipStatusPlhTxt
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
End Class