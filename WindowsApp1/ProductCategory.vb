Imports LibraryDataset
Imports LibraryCommon
Imports System.IO
Imports System.ComponentModel

Public Class ProductCategory
    Dim conn As New connCommon()
    Dim clsProduct As New clsProduct(conn.connSales.ConnectionString)
    Dim clsCBB As New clsCBB(conn.connSales.ConnectionString)
    Dim clsRolePermission As New clsRolePermission(conn.connSales.ConnectionString)

    Private _recordsPerPage As Integer = 4
    Private bs As BindingSource = New BindingSource()
    Private tables As BindingList(Of DataTable)
    Private listCheckboxValue As New List(Of Long)

    'Private CheckboxHeader As New System.Windows.Forms.CheckBox()
    Private WithEvents CheckTest As New DataGridViewCheckBoxHeaderCell()
    Private Sub OrderSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbbCategory.Enabled = False
        cbbSupplier.Enabled = False
        cbbWarehouse.Enabled = False
        cbbStatus.Enabled = False

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

        'Dim HeaderCellCollection As System.Drawing.Point = Me.dgvProductSearch.GetCellDisplayRectangle(0, -1, True).Location
        'CheckboxHeader.Location = New System.Drawing.Point(HeaderCellCollection.X + 17, HeaderCellCollection.Y + 2)
        'CheckboxHeader.Size = New Size(18, 18)
        'CheckboxHeader.BackColor = Color.White
        'dgvProductSearch.Controls.Add(CheckboxHeader)
        'AddHandler CheckboxHeader.Click, AddressOf CheckboxHeader_Click
        'AddHandler dgvProductSearch.CellContentClick, AddressOf dgvProductSearch_CellClick
        dgvProductSearch.Columns(0).HeaderCell = CheckTest

        InitPlaceHolderText()
        SetVisibleForPermission()
        Reload()
    End Sub


    Private cellContentValueChangedByUser = False  'Remark cell content datagridview value change cause code or cause user click
    Public Sub SetPagedDataSource(ByVal dataTable As DataTable)
        tables = New BindingList(Of DataTable)()
        Dim dt As DataTable = Nothing
        Dim counter As Integer = 1

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

        dgvProductSearch.ReadOnly = False
        For i = 1 To dgvProductSearch.Columns.Count - 1
            dgvProductSearch.Columns(i).ReadOnly = True
        Next
        listCheckboxValue.Clear()
        cellContentValueChangedByUser = False
        CheckTest.CheckUncheckEntireColumn(listCheckboxValue)
        CheckTest.Checked = False
    End Sub
    Private Sub bs_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
        If bs.Position >= 0 Then
            Me.dgvProductSearch.DataSource = tables(bs.Position)
        Else
            If TypeOf Me.dgvProductSearch.DataSource Is DataTable Then
                Dim dt = Me.dgvProductSearch.DataSource
                dt.Rows.Clear()
                Me.dgvProductSearch.DataSource = dt
            End If
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
    Private Sub dgvProductSearch_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductSearch.CellContentClick
        'dgvProductSearch.CommitEdit(DataGridViewDataErrorContexts.Commit)
        cellContentValueChangedByUser = True
    End Sub
    Private Sub dgvProductSearch_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductSearch.CellValueChanged
        If e.ColumnIndex = 0 And e.RowIndex <> -1 And cellContentValueChangedByUser Then
            'Console.WriteLine("check " & dgvProductSearch.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
            If dgvProductSearch.Rows(e.RowIndex).Cells(e.ColumnIndex).Value Then
                listCheckboxValue.Add(dgvProductSearch.Rows(e.RowIndex).Cells(1).Value.ToString())
            Else
                listCheckboxValue.Remove(dgvProductSearch.Rows(e.RowIndex).Cells(1).Value.ToString())
            End If
            'Console.WriteLine(listCheckboxValue.Count)
            If listCheckboxValue.Count = tables.Sum(Function(l) l.Rows.Count) Then
                CheckTest.Checked = True
            Else
                CheckTest.Checked = False
            End If
        End If
    End Sub
    Private Sub dgvProductSearch_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvProductSearch.CellMouseUp
        If e.ColumnIndex = 0 And e.RowIndex <> -1 Then
            dgvProductSearch.EndEdit()       'Notification datagridview to start value change event
        End If
    End Sub
    Private Sub dgvProductSearch_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductSearch.CellDoubleClick
        If (e.ColumnIndex > 0 And e.RowIndex >= 0) Then
            Dim frmProductCategory = New ProductInformation()
            frmProductCategory.LoadData(dgvProductSearch.SelectedRows(0).Cells(1).Value.ToString())
            frmProductCategory.ShowDialog()
        End If
        If (e.ColumnIndex = CheckTest.ColumnIndex And e.RowIndex <> -1) Then
            'A DoubleClick event is treated separate from a MouseUp event.
            'If a DoubleClick event is detected, the application will ignore the first MouseUp event entirely.
            dgvProductSearch.EndEdit()   'So add this code to notification datagridview to start value change event
        End If
    End Sub

    Private Sub dgvProductSearch_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvProductSearch.ColumnHeaderMouseClick
        If (e.ColumnIndex <> CheckTest.ColumnIndex) Then
            cellContentValueChangedByUser = False
            CheckTest.CheckUncheckEntireColumn(listCheckboxValue)
        End If
    End Sub

    'Private Sub CheckboxHeader_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    dgvProductSearch.EndEdit()

    '    'loop for select and unselect the records
    '    For Each row As DataGridViewRow In dgvProductSearch.Rows
    '        Dim chk As DataGridViewCheckBoxCell = TryCast(row.Cells("CheckBoxColumn"), DataGridViewCheckBoxCell)
    '        chk.Value = CheckboxHeader.Checked
    '    Next
    'End Sub

    'Private Sub dgvProductSearch_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
    '    If e.RowIndex >= 0 Then
    '        Dim isChecked As Boolean = True
    '        For Each row As DataGridViewRow In dgvProductSearch.Rows
    '            If Convert.ToBoolean(row.Cells("CheckBoxColumn").EditedFormattedValue) = False Then
    '                isChecked = False
    '                Exit For
    '            End If
    '        Next
    '        CheckboxHeader.Checked = isChecked
    '    End If
    'End Sub

    Private Sub SetVisibleForPermission()
        btnExport.Visible = False
        Dim dataPermission = clsRolePermission.GetPermissionOfUser(LoginForm.PropUsername)
        For Each permission In dataPermission
            Dim form = permission(1).split(":")(0)
            Dim permiss = Strings.Split(Strings.Split(permission(1), ": ")(1), ", ")
            If form = "Product search" Then
                For Each p In permiss
                    Select Case p
                        Case "Export"
                            btnExport.Visible = True
                    End Select
                Next
                Exit For
            End If
        Next
    End Sub

    Public Sub Reload()
        'dgvProductSearch.DataSource = clsProduct.SearchProduct("")
        SetPagedDataSource(clsProduct.SearchProduct(""))
        dgvProductSearch.ReadOnly = False
        For i = 1 To dgvProductSearch.Columns.Count - 1
            dgvProductSearch.Columns(i).ReadOnly = True
        Next
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If checkLogicData() Then
            Dim sqlCommand = ""

            If Not String.IsNullOrWhiteSpace(txtCode.Text) Then
                sqlCommand &= $" AND Product.Id = {txtCode.Text}"
            End If

            sqlCommand &= $" AND Product.ProductName LIKE N'%{txtName.Text}%'"

            If cbSupplier.Checked Then
                sqlCommand &= $" AND Product.SupplierId = {CType(cbbSupplier.SelectedItem, CBBItem).PropItemId}"
            End If

            If cbCategory.Checked Then
                sqlCommand &= $" AND Product.CategoryId = {CType(cbbCategory.SelectedItem, CBBItem).PropItemId}"
            End If

            If cbProductStatus.Checked Then
                sqlCommand &= $" AND Product.ProductStatusId = {CType(cbbStatus.SelectedItem, CBBItem).PropItemId}"
            End If

            If cbWarehouse.Checked Then
                sqlCommand &= $" AND SalesDetail.WareHouseId = {CType(cbbWarehouse.SelectedItem, CBBItem).PropItemId}"
            End If

            If Not String.IsNullOrWhiteSpace(txtPrice.Text) Then
                sqlCommand &= $" AND Product.ProductPrice = {txtPrice.Text}"
            End If

            If Not String.IsNullOrWhiteSpace(txtDiscount.Text) Then
                sqlCommand &= $" AND Product.DiscountPercent = {txtDiscount.Text}"
            End If

            If Not String.IsNullOrWhiteSpace(txtNumber.Text) Then
                sqlCommand &= $" AND SalesDetail.Total = {txtNumber.Text}"
            End If

            'dgvProductSearch.DataSource = clsProduct.SearchProduct(sqlCommand)
            SetPagedDataSource(clsProduct.SearchProduct(sqlCommand))
        End If

    End Sub
    Private Function checkLogicData() As Boolean
        If Not (CheckValue("Product code", txtCode.Text, "Long") And
            CheckValue("Price", txtPrice.Text, "Double") And
            CheckValue("Discount", txtDiscount.Text, "Double") And
            CheckValue("Number of products", txtNumber.Text, "Long")) Then
            Return False

        ElseIf (cbCategory.Checked And cbbCategory.Text.Equals(categoryPlhTxt)) Or
            (cbSupplier.Checked And cbbSupplier.Text.Equals(supplierPlhTxt)) Or
            (cbWarehouse.Checked And cbbWarehouse.Text.Equals(warehousePlhTxt)) Or
            (cbProductStatus.Checked And cbbStatus.Text.Equals(statusPlhTxt)) Then

            MsgBox("You need to select element for the checked comboboxes!", Nothing, "Notification")
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
            For Each column In dgvProductSearch.Columns
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

            Dim listLeftFormat As New ArrayList() From {1, 5, 6, 7}       'list left format of datagridview column
            exportObject.exportToExcel(sfd.FileName, tables, listPrintedColumn, listLeftFormat, "order search")
        End If
    End Sub
    Private Sub cbCategory_CheckedChanged(sender As Object, e As EventArgs) Handles cbCategory.CheckedChanged
        cbbCategory.Enabled = cbCategory.Checked
    End Sub

    Private Sub cbSupplier_CheckedChanged(sender As Object, e As EventArgs) Handles cbSupplier.CheckedChanged
        cbbSupplier.Enabled = cbSupplier.Checked
    End Sub

    Private Sub cbWarehouse_CheckedChanged(sender As Object, e As EventArgs) Handles cbWarehouse.CheckedChanged
        cbbWarehouse.Enabled = cbWarehouse.Checked
    End Sub

    Private Sub cbProductStatus_CheckedChanged(sender As Object, e As EventArgs) Handles cbProductStatus.CheckedChanged
        cbbStatus.Enabled = cbProductStatus.Checked
    End Sub

    Private Sub bAdd_Click(sender As Object, e As EventArgs) Handles bAdd.Click
        Dim frmProductCategory = New ProductInformation()
        frmProductCategory.LoadData(-1)
        frmProductCategory.ShowDialog()
    End Sub

    Private Sub bDelete_Click(sender As Object, e As EventArgs) Handles bDelete.Click
        If listCheckboxValue.Count > 0 Then
            Dim err = False

            For Each id In listCheckboxValue
                Dim result = clsProduct.DeleteProduct(LoginForm.PropUsername, id)

                If result <> 1 Then
                    MsgBox("There is an error when interact with database!", Nothing, "Notification")
                    err = True
                    Exit For
                End If
            Next

            If Not err Then
                MsgBox("Delete selected products information successful!", Nothing, "Notification")
                Reload()
            Else
            End If

        Else
            MsgBox("Please check first cell of products you want to delete!")
        End If
    End Sub

    'Set up placeholder text for comboboxes

    Private categoryPlhTxt = "Select a category"
    Private supplierPlhTxt = "Select a supplier"
    Private warehousePlhTxt = "Select a warehouse"
    Private statusPlhTxt = "Select a status"

    Private Sub InitPlaceHolderText()
        cbbCategory.Items.Insert(0, categoryPlhTxt)
        cbbCategory.Text = categoryPlhTxt
        cbbSupplier.Items.Insert(0, supplierPlhTxt)
        cbbSupplier.Text = supplierPlhTxt
        cbbWarehouse.Items.Insert(0, warehousePlhTxt)
        cbbWarehouse.Text = warehousePlhTxt
        cbbStatus.Items.Insert(0, statusPlhTxt)
        cbbStatus.Text = statusPlhTxt
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

    'Private Sub dgvProductSearch_Scroll(sender As Object, e As ScrollEventArgs) Handles dgvProductSearch.Scroll
    '    If e.ScrollOrientation = ScrollOrientation.HorizontalScroll Then
    '        If (e.NewValue > Me.dgvProductSearch.Width / 2) Then
    '            MsgBox(e.NewValue & " greater")
    '        Else
    '            MsgBox(e.NewValue)
    '        End If
    '    End If
    'End Sub

End Class