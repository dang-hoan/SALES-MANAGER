Imports LibraryDataset
Imports LibraryCommon

Public Class EmployeeCategory
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsPerson(conn.connSales.ConnectionString)
    Dim clsCBB As New clsCBB(conn.connSales.ConnectionString)
    Dim clsAccount As New clsAccount(conn.connSales.ConnectionString)

    Private isAddFirstName As Boolean = False
    Private isAddLastName As Boolean = False
    Private isSaved As Boolean = True

    Private employeeUsername = Nothing
    Private Sub EmployeeCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub Reload()
        Dim dataRole = clsCBB.GetCBBRole().CBBRole
        cbbRole.Items.Clear()

        For Each row As DataRow In dataRole.Rows
            cbbRole.Items.Add(New CBBItem(row(0), row(1)))
        Next

        Dim data = clsPMSAnalysis.GetEmployees()
        dgvCategory.DataSource = data.Person
        setEnable(False)
        setValue()
    End Sub

    Private Sub bEdit_Click(sender As Object, e As EventArgs) Handles bEdit.Click
        addEditDeleteEnabled(False)
        bDelete.Enabled = True
        setEnable(True)
    End Sub

    Private Sub setEnable(valBoolean As Boolean)
        txtFirstName.Enabled = valBoolean
        txtLastName.Enabled = valBoolean
        txtPhone.Enabled = valBoolean
        txtAddress.Enabled = valBoolean
        dtBirthDay.Enabled = valBoolean
        rdMale.Enabled = valBoolean
        rdFemale.Enabled = valBoolean
        txtEmail.Enabled = valBoolean
        cbbRole.Enabled = valBoolean
        bSave.Enabled = valBoolean
    End Sub

    Private Sub addEditDeleteEnabled(valBoolean As Boolean)
        bAdd.Enabled = valBoolean
        bEdit.Enabled = valBoolean
        bDelete.Enabled = valBoolean
    End Sub

    Private Sub clearValue()
        txtFirstName.Text = "First name"
        txtLastName.Text = "Last name"
        txtCode.Text = ""
        rdMale.Checked = True
        txtPhone.Text = ""
        txtAddress.Text = ""
        dtBirthDay.Value = DateTime.Now
        txtEmail.Text = ""
        cbbRole.SelectedIndex = -1
        employeeUsername = Nothing
        setPlaceHolderEnable(True)
    End Sub

    Private Sub bAdd_Click(sender As Object, e As EventArgs) Handles bAdd.Click
        addEditDeleteEnabled(False)
        clearValue()
        setEnable(True)
        isSaved = False
    End Sub

    Private Sub dgvCategory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategory.CellClick
        deleteAccountIfNotSave()
        addEditDeleteEnabled(True)
        setEnable(False)
        setValue()
        setPlaceHolderEnable(False)
    End Sub

    Private Sub setValue()
        If dgvCategory.Rows.Count = 0 Then
            addEditDeleteEnabled(False)
            bAdd.Enabled = True
            Return
        Else
            Dim row As DataGridViewRow = dgvCategory.CurrentRow
            txtCode.Text = row.Cells(0).Value.ToString
            employeeUsername = If(row.Cells(1).Value.ToString = "", Nothing, row.Cells(1).Value.ToString)
            txtLastName.Text = row.Cells(2).Value.ToString
            txtFirstName.Text = row.Cells(3).Value.ToString
            dtBirthDay.Text = row.Cells(5).Value.ToString
            txtPhone.Text = row.Cells(6).Value.ToString
            txtEmail.Text = row.Cells(7).Value.ToString
            txtAddress.Text = row.Cells(8).Value.ToString
            If row.Cells(4).Value.ToString() = "True" Then
                rdMale.Checked = True
            Else
                rdFemale.Checked = True
            End If

            For Each item As CBBItem In cbbRole.Items
                If item.PropItemId = row.Cells(9).Value.ToString Then
                    cbbRole.SelectedItem = item
                End If
            Next
        End If
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        If checkLogicData() Then
            Dim result As Integer
            Dim type As String = "Update"
            If txtCode.Text <> "" Then               'Edit
                result = clsPMSAnalysis.UpdateEmployee(employeeUsername, txtLastName.Text,
                                            txtFirstName.Text, rdMale.Checked, dtBirthDay.Value,
                                            txtPhone.Text, txtEmail.Text, txtAddress.Text, CType(cbbRole.SelectedItem, CBBItem).PropItemId, LoginForm.PropUsername, txtCode.Text)
            Else                                     'Add new
                result = clsPMSAnalysis.AddEmployee(employeeUsername, txtLastName.Text,
                                            txtFirstName.Text, rdMale.Checked, dtBirthDay.Value,
                                            txtPhone.Text, txtEmail.Text, txtAddress.Text, CType(cbbRole.SelectedItem, CBBItem).PropItemId, LoginForm.PropUsername)
                type = "Add"
            End If

            If result = 1 Then
                setEnable(False)
                MsgBox(type & " employee information successful!")
                Reload()
                addEditDeleteEnabled(True)
                setPlaceHolderEnable(False)
                isSaved = True
            Else
                MsgBox("There is an error when interact with database!")
            End If
        End If
    End Sub

    Private Function checkLogicData() As Boolean
        If txtFirstName.Text = "" Or isAddFirstName = True Or isAddLastName = True Or txtLastName.Text = "" Or txtPhone.Text = "" Or txtAddress.Text = "" Or
            txtEmail.Text = "" Or cbbRole.SelectedIndex = -1 Then

            MsgBox("You need to enter all the fields!")
            Return False

        ElseIf Not CheckValue("Phone", txtPhone.Text, "Long") Then
            Return False

        ElseIf Not txtPhone.Text.StartsWith("0") Then
            MsgBox("Phone number must be started with '0'!")
            Return False

        ElseIf countString(txtEmail.Text, "gmail.com") <> 1 Or Not txtEmail.Text.EndsWith("@gmail.com") Then
            MsgBox("Email invalidate!")
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


    Public Function countString(ByVal inputString As String, ByVal subString As String) As Integer
        Return System.Text.RegularExpressions.Regex.Split(inputString, subString).Length - 1
    End Function

    Private Sub bDelete_Click(sender As Object, e As EventArgs) Handles bDelete.Click
        If txtCode.Text <> "" Then
            Dim username As String = txtCode.Text
            Dim isDelete = clsAccount.CheckUserWasDeleted(username)
            If Not isDelete Then
                Dim result = clsPMSAnalysis.DeleteUser(LoginForm.PropUsername, username)
                If result = 1 Then
                    setEnable(False)
                    MsgBox("Delete employee information successful!")
                    Reload()
                Else
                    MsgBox("There is an error when interact with database!")
                End If
            Else
                MsgBox("User was deleted before!")
            End If

        End If
    End Sub
    Private Sub dgvCategory_KeyUp(sender As Object, e As KeyEventArgs) Handles dgvCategory.KeyUp
        If e.KeyCode.Equals(Keys.Up) Or e.KeyCode.Equals(Keys.Down) Then
            If dgvCategory.CurrentRow IsNot Nothing And bSave.Enabled = False Then
                addEditDeleteEnabled(True)
                setEnable(False)
                setValue()
            End If
        End If
    End Sub

    Private Sub bAccountInfor_Click(sender As Object, e As EventArgs) Handles bAccountInfor.Click
        Dim frmAccountInfor As New AccountInformation
        frmAccountInfor.isView = Not bSave.Enabled
        frmAccountInfor.employeeCode = If(txtCode.Text <> "", txtCode.Text, -1)
        frmAccountInfor.employeeUsername = employeeUsername
        frmAccountInfor.ShowDialog()
    End Sub

    Private Sub txtFirstName_Click(sender As Object, e As EventArgs) Handles txtFirstName.Click
        If isAddFirstName Then
            txtFirstName.Text = ""
            txtFirstName.ForeColor = Color.Black
            isAddFirstName = False
        End If
    End Sub

    Private Sub txtLastName_Click(sender As Object, e As EventArgs) Handles txtLastName.Click
        If isAddLastName Then
            txtLastName.Text = ""
            txtLastName.ForeColor = Color.Black
            isAddLastName = False
        End If
    End Sub
    Public Sub setPlaceHolderEnable(ByVal valBoolean As Boolean)
        If valBoolean = False Then
            txtLastName.ForeColor = Color.Black
            isAddLastName = False
            txtFirstName.ForeColor = Color.Black
            isAddFirstName = False
        Else
            txtLastName.ForeColor = Color.Gray
            isAddLastName = True
            txtFirstName.ForeColor = Color.Gray
            isAddFirstName = True
        End If
    End Sub
    Public Sub setAccountName(ByVal accountName As String)
        employeeUsername = accountName
        If isSaved Then
            If dgvCategory.CurrentRow IsNot Nothing Then
                dgvCategory.CurrentRow.Cells(1).Value = accountName
            End If
        End If
    End Sub

    Private Sub EmployeeCategory_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        deleteAccountIfNotSave()
    End Sub
    Private Sub deleteAccountIfNotSave()
        If Not isSaved Then
            clsAccount.DeleteCompletelyAccount(employeeUsername)
            isSaved = True
        End If
    End Sub
End Class