Imports LibraryDataset
Imports LibraryCommon
Imports System.ComponentModel
Imports System.IO

Public Class SupplierCategory
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsSupplier(conn.connSales.ConnectionString)
    Dim clsRolePermission As New clsRolePermission(conn.connSales.ConnectionString)

    Private _recordsPerPage As Integer = 5
    Private bs As BindingSource = New BindingSource()
    Private tables As BindingList(Of DataTable)
    Private listCheckboxValue As New List(Of Long)

    Private WithEvents CheckTest As New DataGridViewCheckBoxHeaderCell()
    Private Sub SupplierCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvSupplierSearch.Columns(0).HeaderCell = CheckTest

        'InitPlaceHolderText()
        SetVisibleForPermission()
        Reload()
    End Sub

    Private cellContentValueChangedByUser = False  'Remark cell content datagridview value change cause code or cause user click
    Public Sub SetPagedDataSource(ByVal dataTable As DataTable)
        tables = New BindingList(Of DataTable)()
        Dim dt As DataTable = Nothing
        Dim counter As Integer = 1          'Count number of records of a page

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

        dgvSupplierSearch.ReadOnly = False
        For i = 1 To dgvSupplierSearch.Columns.Count - 1
            dgvSupplierSearch.Columns(i).ReadOnly = True
        Next
        listCheckboxValue.Clear()
        cellContentValueChangedByUser = False
        CheckTest.CheckUncheckEntireColumn(listCheckboxValue)
        CheckTest.Checked = False
    End Sub
    Private Sub bs_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
        If bs.Position >= 0 Then
            Me.dgvSupplierSearch.DataSource = tables(bs.Position)
        Else
            Me.dgvSupplierSearch.DataSource = Nothing
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
    Private Sub dgvSupplierSearch_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSupplierSearch.CellContentClick
        cellContentValueChangedByUser = True
    End Sub
    Private Sub dgvSupplierSearch_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSupplierSearch.CellValueChanged
        If e.ColumnIndex = 0 And e.RowIndex <> -1 And cellContentValueChangedByUser Then

            If dgvSupplierSearch.Rows(e.RowIndex).Cells(e.ColumnIndex).Value Then
                listCheckboxValue.Add(dgvSupplierSearch.Rows(e.RowIndex).Cells(1).Value.ToString())
            Else
                listCheckboxValue.Remove(dgvSupplierSearch.Rows(e.RowIndex).Cells(1).Value.ToString())
            End If

            If listCheckboxValue.Count = tables.Sum(Function(l) l.Rows.Count) Then
                CheckTest.Checked = True
            Else
                CheckTest.Checked = False
            End If
        End If
    End Sub
    Private Sub dgvSupplierSearch_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSupplierSearch.CellMouseUp
        If e.ColumnIndex = 0 And e.RowIndex <> -1 Then
            dgvSupplierSearch.EndEdit()       'Notification datagridview to start value change event
        End If
    End Sub
    Private Sub dgvSupplierSearch_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSupplierSearch.CellDoubleClick
        If (e.ColumnIndex > 0 And e.RowIndex >= 0) Then
            Dim frmSupplierInformation = New SupplierInformation()
            frmSupplierInformation.LoadData(dgvSupplierSearch.SelectedRows(0).Cells(1).Value.ToString())
            frmSupplierInformation.ShowDialog()
        End If
        If (e.ColumnIndex = CheckTest.ColumnIndex And e.RowIndex <> -1) Then
            'A DoubleClick event is treated separate from a MouseUp event.
            'If a DoubleClick event is detected, the application will ignore the first MouseUp event entirely.
            dgvSupplierSearch.EndEdit()   'So add this code to notification datagridview to start value change event
        End If
    End Sub

    Private Sub dgvSupplierSearch_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSupplierSearch.ColumnHeaderMouseClick
        If (e.ColumnIndex <> CheckTest.ColumnIndex) Then
            cellContentValueChangedByUser = False
            CheckTest.CheckUncheckEntireColumn(listCheckboxValue)
        End If
    End Sub

    Private Sub SetVisibleForPermission()
        bSearch.Visible = False
        bExport.Visible = False
        bAdd.Visible = False
        bDelete.Visible = False
        Dim dataPermission = clsRolePermission.GetPermissionOfUser(LoginForm.PropUsername)
        For Each permission In dataPermission
            Dim form = permission(1).split(":")(0)
            Dim permiss = Strings.Split(Strings.Split(permission(1), ": ")(1), ", ")
            If form = "Supplier category" Then
                For Each p In permiss
                    Select Case p
                        Case "Search"
                            bSearch.Visible = True
                        Case "Export"
                            bExport.Visible = True
                        Case "Add"
                            bAdd.Visible = True
                        Case "Delete"
                            bDelete.Visible = True
                    End Select
                Next
                Exit For
            End If
        Next
        CenterButtons({bSearch, bExport}.ToList, 20)
        CenterButtons({bAdd, bDelete}.ToList, 30)
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
    Public Sub Reload()
        SetPagedDataSource(clsPMSAnalysis.GetAllSuppliers())
    End Sub
    Private Sub bSearch_Click(sender As Object, e As EventArgs) Handles bSearch.Click
        ' AND (Id = @Id) AND (CompanyName = @CompanyName) AND (Address = @Address) AND (Phone = @Phone)
        ' AND (Email = @Email) AND (Webpage = @Webpage) AND (Description = @Description)
        If checkLogicData() Then
            Dim sqlCommand = ""

            If Not String.IsNullOrWhiteSpace(txtCode.Text) Then
                sqlCommand &= $" AND Id = {txtCode.Text}"
            End If

            sqlCommand &= $" AND CompanyName LIKE N'%{txtName.Text}%'"
            sqlCommand &= $" AND Address LIKE N'%{txtAddress.Text}%'"
            sqlCommand &= $" AND Phone LIKE N'%{txtPhone.Text}%'"
            sqlCommand &= $" AND Email LIKE N'%{txtEmail.Text}%'"
            sqlCommand &= $" AND Webpage LIKE N'%{txtWebpage.Text}%'"
            sqlCommand &= $" AND Description LIKE N'%{txtDescription.Text}%'"

            SetPagedDataSource(clsPMSAnalysis.SearchSupplier(sqlCommand))
        End If
    End Sub
    Private Function checkLogicData() As Boolean
        If Not (CheckValue("Supplier code", txtCode.Text, "Long") And CheckValue("Phone", txtPhone.Text, "Long")) Then
            Return False

        ElseIf txtPhone.Text.Length > 17 Then
            MsgBox("Phone number length can't be greater than 17!")
            Return False

        End If
        Return True
    End Function
    'Public Function countString(ByVal inputString As String, ByVal subString As String) As Integer
    '    Return System.Text.RegularExpressions.Regex.Split(inputString, subString).Length - 1
    'End Function
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

    Private Sub bExport_Click(sender As Object, e As EventArgs) Handles bExport.Click
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
            For Each column In dgvSupplierSearch.Columns
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

            Dim listLeftFormat As New ArrayList() From {1, 2, 4, 5, 6}       'list left format of datagridview column (excluding column Checkbox)
            exportObject.exportToExcel(sfd.FileName, tables, listPrintedColumn, listLeftFormat, "Supplier search")
        End If
    End Sub
    Private Sub bAdd_Click(sender As Object, e As EventArgs) Handles bAdd.Click
        Dim frmSupplierInformation = New SupplierInformation()
        frmSupplierInformation.LoadData(-1)
        frmSupplierInformation.ShowDialog()
    End Sub

    Private Sub bDelete_Click(sender As Object, e As EventArgs) Handles bDelete.Click
        If listCheckboxValue.Count > 0 Then
            Dim err = False

            For Each id In listCheckboxValue
                Dim result = clsPMSAnalysis.DeleteSupplier(id, LoginForm.PropUsername)

                If result <> 1 Then
                    MsgBox("There is an error when interact with database!", Nothing, "Notification")
                    err = True
                    Exit For
                End If
            Next

            If Not err Then
                MsgBox("Delete selected suppliers information successful!", Nothing, "Notification")
                Reload()
            Else
            End If

        Else
            MsgBox("Please check first cell of suppliers you want to delete!")
        End If
    End Sub
End Class