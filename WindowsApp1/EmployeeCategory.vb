Imports LibraryDataset
Imports LibraryCommon
Imports System.ComponentModel
Imports System.IO

Public Class EmployeeCategory
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsPerson(conn.connSales.ConnectionString)
    Dim clsCBB As New clsCBB(conn.connSales.ConnectionString)
    Dim clsAccount As New clsAccount(conn.connSales.ConnectionString)
    Dim clsRolePermission As New clsRolePermission(conn.connSales.ConnectionString)

    Private _recordsPerPage As Integer = 4
    Private bs As BindingSource = New BindingSource()
    Private tables As BindingList(Of DataTable)
    Private listCheckboxValue As New List(Of Long)

    Private WithEvents CheckTest As New DataGridViewCheckBoxHeaderCell()
    Private Sub EmployeeCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbbRole.Enabled = False

        Dim dataRole = clsCBB.GetCBBRole().CBBRole

        cbbRole.Items.Clear()

        For Each row As DataRow In dataRole.Rows
            cbbRole.Items.Add(New CBBItem(row(0), row(1)))
        Next

        'Dim HeaderCellCollection As System.Drawing.Point = Me.dgvProductSearch.GetCellDisplayRectangle(0, -1, True).Location
        'CheckboxHeader.Location = New System.Drawing.Point(HeaderCellCollection.X + 17, HeaderCellCollection.Y + 2)
        'CheckboxHeader.Size = New Size(18, 18)
        'CheckboxHeader.BackColor = Color.White
        'dgvProductSearch.Controls.Add(CheckboxHeader)
        'AddHandler CheckboxHeader.Click, AddressOf CheckboxHeader_Click
        'AddHandler dgvProductSearch.CellContentClick, AddressOf dgvProductSearch_CellClick
        dgvEmployeeSearch.Columns(0).HeaderCell = CheckTest

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

        dgvEmployeeSearch.ReadOnly = False
        For i = 1 To dgvEmployeeSearch.Columns.Count - 1
            dgvEmployeeSearch.Columns(i).ReadOnly = True
        Next
        listCheckboxValue.Clear()
        cellContentValueChangedByUser = False
        CheckTest.CheckUncheckEntireColumn(listCheckboxValue)
        CheckTest.Checked = False
    End Sub
    Private Sub bs_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
        If bs.Position >= 0 Then
            Me.dgvEmployeeSearch.DataSource = tables(bs.Position)
        Else
            Me.dgvEmployeeSearch.DataSource = Nothing
            'If TypeOf Me.dgvEmployeeSearch.DataSource Is DataTable Then
            '    Dim dt = Me.dgvEmployeeSearch.DataSource
            '    dt.Rows.Clear()
            '    Me.dgvEmployeeSearch.DataSource = dt
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
                    listCheckboxValue.Add(row("Id"))
                Next
            Next
        End If
        cellContentValueChangedByUser = False
        CheckTest.CheckUncheckEntireColumn(listCheckboxValue)
    End Sub
    Private Sub dgvEmployeeSearch_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEmployeeSearch.CellContentClick
        'dgvEmployeeSearch.CommitEdit(DataGridViewDataErrorContexts.Commit)
        cellContentValueChangedByUser = True
    End Sub
    Private Sub dgvEmployeeSearch_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeSearch.CellValueChanged
        If e.ColumnIndex = 0 And e.RowIndex <> -1 And cellContentValueChangedByUser Then
            'Console.WriteLine("check " & dgvEmployeeSearch.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
            If dgvEmployeeSearch.Rows(e.RowIndex).Cells(e.ColumnIndex).Value Then
                listCheckboxValue.Add(dgvEmployeeSearch.Rows(e.RowIndex).Cells(1).Value.ToString())
            Else
                listCheckboxValue.Remove(dgvEmployeeSearch.Rows(e.RowIndex).Cells(1).Value.ToString())
            End If
            'Console.WriteLine(listCheckboxValue.Count)
            If listCheckboxValue.Count = tables.Sum(Function(l) l.Rows.Count) Then
                CheckTest.Checked = True
            Else
                CheckTest.Checked = False
            End If
        End If
    End Sub
    Private Sub dgvEmployeeSearch_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvEmployeeSearch.CellMouseUp
        If e.ColumnIndex = 0 And e.RowIndex <> -1 Then
            dgvEmployeeSearch.EndEdit()       'Notification datagridview to start value change event
        End If
    End Sub
    Private Sub dgvEmployeeSearch_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeSearch.CellDoubleClick
        If (e.ColumnIndex > 0 And e.RowIndex >= 0) Then
            Dim frmEmployeeInformation = New EmployeeInformation()
            frmEmployeeInformation.LoadData(dgvEmployeeSearch.SelectedRows(0).Cells(1).Value.ToString())
            frmEmployeeInformation.ShowDialog()
        End If
        If (e.ColumnIndex = CheckTest.ColumnIndex And e.RowIndex <> -1) Then
            'A DoubleClick event is treated separate from a MouseUp event.
            'If a DoubleClick event is detected, the application will ignore the first MouseUp event entirely.
            dgvEmployeeSearch.EndEdit()   'So add this code to notification datagridview to start value change event
        End If
    End Sub

    Private Sub dgvEmployeeSearch_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvEmployeeSearch.ColumnHeaderMouseClick
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
            Select Case form
                Case "Employee category"
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
            End Select
        Next
        CenterButtons({bSearch, bExport}.ToList(), 20)
        CenterButtons({bAdd, bDelete}.ToList(), 30)
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
        SetPagedDataSource(clsPMSAnalysis.SearchPerson(""))
    End Sub
    Private Sub bSearch_Click(sender As Object, e As EventArgs) Handles bSearch.Click
        'AND (Username = @Username) AND (LastName = @LastName) AND (FirstName = @FirstName)
        'AND (Gender = @Gender) AND (BirthDate = @BirthDate) AND (Phone = @Phone)
        'AND (Email = @Email) AND (Address = @Address) AND (RoleId = @RoleId) AND (Id = @Id)
        If checkLogicData() Then
            Dim sqlCommand = ""

            If Not String.IsNullOrWhiteSpace(txtCode.Text) Then
                sqlCommand &= $" AND Id = {txtCode.Text}"
            End If

            If Not String.IsNullOrWhiteSpace(txtUsername.Text) Then
                sqlCommand &= $" AND Username LIKE N'%{txtUsername.Text}%'"
            End If

            sqlCommand &= $" AND (LastName + ' ' + FirstName) LIKE N'%{txtName.Text}%'"

            If cbGender.Checked Then
                sqlCommand &= $" AND Gender = '{rdMale.Checked}'"
            End If

            If cbBirthDay.Checked Then
                sqlCommand &= $" AND FORMAT(BirthDate, '{dtBirthDay.CustomFormat}') = '{dtBirthDay.Value.ToString(dtBirthDay.CustomFormat)}'"
            End If

            sqlCommand &= $" AND Phone LIKE N'%{txtPhone.Text}%'"
            sqlCommand &= $" AND Email LIKE N'%{txtEmail.Text}%'"
            sqlCommand &= $" AND Address LIKE N'%{txtAddress.Text}%'"

            If cbRole.Checked Then
                sqlCommand &= $" AND RoleId = {CType(cbbRole.SelectedItem, CBBItem).PropItemId}"
            End If

            SetPagedDataSource(clsPMSAnalysis.SearchPerson(sqlCommand))
        End If

    End Sub

    Private Function checkLogicData() As Boolean
        If Not (CheckValue("Employee code", txtCode.Text, "Long") And CheckValue("Phone", txtPhone.Text, "Long")) Then
            Return False
        ElseIf (cbRole.Checked And cbbRole.Text.Equals(rolePlhTxt)) Then
            MsgBox("You need to select role to search!", Nothing, "Notification")
            Return False

        ElseIf cbGender.Checked And Not (rdMale.Checked Or rdFemale.Checked) Then
            MsgBox("You need to select gender to search!", Nothing, "Notification")
            Return False

        ElseIf txtPhone.Text.Length > 17 Then
            MsgBox("Phone number length can't be greater than 17!")
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

    Public Function countString(ByVal inputString As String, ByVal subString As String) As Integer
        Return System.Text.RegularExpressions.Regex.Split(inputString, subString).Length - 1
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
            For Each column In dgvEmployeeSearch.Columns
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

            Dim listLeftFormat As New ArrayList() From {1, 2, 3, 6, 7, 9}       'list left format of datagridview column (excluding column Checkbox)
            Dim listDateTimeFormat As New ArrayList() From {4}                  'list datetime format of datagridview column (excluding column Checkbox)
            exportObject.exportToExcel(sfd.FileName, tables, listPrintedColumn, listLeftFormat, "Employee search", listDateTimeFormat, "DD/MM/YYYY")
        End If
    End Sub
    Private Sub dgvEmployeeSearch_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvEmployeeSearch.CellFormatting
        If e.ColumnIndex = dgvEmployeeSearch.Columns("BirthDate").Index AndAlso e.Value IsNot Nothing Then
            Dim dateValue As DateTime
            If DateTime.TryParse(e.Value.ToString(), dateValue) Then
                e.Value = dateValue.ToString("dd/MM/yyyy")
                e.FormattingApplied = True
            End If
        End If
    End Sub

    Private Sub cbGender_CheckedChanged(sender As Object, e As EventArgs) Handles cbGender.CheckedChanged
        rdMale.Enabled = cbGender.Checked
        rdFemale.Enabled = cbGender.Checked
    End Sub
    Private Sub cbBirthDay_CheckedChanged(sender As Object, e As EventArgs) Handles cbBirthDay.CheckedChanged
        dtBirthDay.Enabled = cbBirthDay.Checked
    End Sub
    Private Sub cbRole_CheckedChanged(sender As Object, e As EventArgs) Handles cbRole.CheckedChanged
        cbbRole.Enabled = cbRole.Checked
    End Sub

    Private Sub bAdd_Click(sender As Object, e As EventArgs) Handles bAdd.Click
        Dim frmEmployeeInformation = New EmployeeInformation()
        frmEmployeeInformation.LoadData(-1)
        frmEmployeeInformation.ShowDialog()
    End Sub
    Private Sub bDelete_Click(sender As Object, e As EventArgs) Handles bDelete.Click
        If listCheckboxValue.Count > 0 Then
            Dim result = 1
            Dim err = False

            For Each id In listCheckboxValue

                If result = 1 Then
                    result = clsPMSAnalysis.DeleteUser(LoginForm.PropUsername, id)
                End If

                If result <> 1 Then
                    MsgBox("There is an error when interact with database!", Nothing, "Notification")
                    err = True
                    Exit For
                End If
            Next

            If Not err Then
                MsgBox("Delete selected employees information successful!", Nothing, "Notification")
                Reload()
            Else
            End If

        Else
            MsgBox("Please check first cell of employees you want to delete!")
        End If
    End Sub
    'Set up placeholder text for comboboxes

    Private rolePlhTxt = "Select a role"

    Private Sub InitPlaceHolderText()
        DropDownClosed(cbbRole, rolePlhTxt)
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
    Private Sub cbbRole_DropDown(sender As Object, e As EventArgs) Handles cbbRole.DropDown
        DropDown(cbbRole, rolePlhTxt)
    End Sub

    Private Sub cbbRole_DropDownClosed(sender As Object, e As EventArgs) Handles cbbRole.DropDownClosed
        DropDownClosed(cbbRole, rolePlhTxt)
    End Sub
End Class