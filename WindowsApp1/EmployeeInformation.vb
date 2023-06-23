Imports LibraryDataset
Imports LibraryCommon
Imports System.IO

Public Class EmployeeInformation
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsPerson(conn.connSales.ConnectionString)
    Dim clsCBB As New clsCBB(conn.connSales.ConnectionString)
    Dim clsAccount As New clsAccount(conn.connSales.ConnectionString)
    Dim clsRolePermission As New clsRolePermission(conn.connSales.ConnectionString)

    Dim mode As String = "Update"
    Private isShow As Boolean = False
    Private hasAccount As Boolean = False

    Public Sub LoadData(employeeCode As Long)
        Dim dataRole = clsCBB.GetCBBRole().CBBRole
        Dim dataStatus = clsCBB.GetCBBStatusOfAccount().CBBStatus

        cbbRole.Items.Clear()
        cbbStatus.Items.Clear()

        For Each row As DataRow In dataRole.Rows
            cbbRole.Items.Add(New CBBItem(row(0), row(1)))
        Next

        For Each row As DataRow In dataStatus.Rows
            cbbStatus.Items.Add(New CBBItem(row(0), row(1)))
        Next

        If employeeCode = -1 Then
            setEnable(True)
            mode = "Add"

            labTitle.Text = "ADD EMPLOYEE"
            labTitle.Location = New Point(Me.Width / 2 - labTitle.Width / 2, labTitle.Location.Y)

            Dim x As Integer = (Me.Width - bSave.Width) / 2

            bSave.Location = New Point(x, bSave.Location.Y)
            bEdit.Visible = False
            bDelete.Visible = False

            txtFirstName_Leave(txtFirstName, EventArgs.Empty)
            txtLastName_Leave(txtLastName, EventArgs.Empty)

        Else
            setEnable(False)

            Dim data = clsPMSAnalysis.GetPersonById(employeeCode)
            txtCode.Text = employeeCode
            txtLastName.Text = data("LastName")
            txtFirstName.Text = data("FirstName")
            dtBirthDay.Text = data("BirthDate")
            txtPhone.Text = data("Phone")
            txtEmail.Text = data("Email")
            txtAddress.Text = data("Address")

            If TypeOf data("Username") IsNot DBNull Then
                hasAccount = True
                txtAccountName.Text = data("Username")
                txtPassword.Text = data("Password")

                For Each item As CBBItem In cbbStatus.Items
                    If item.PropItemId = data("StatusId") Then
                        cbbStatus.SelectedItem = item
                    End If
                Next
            End If

            If data("Gender") Then
                rdMale.Checked = True
            Else
                rdFemale.Checked = True
            End If

            For Each item As CBBItem In cbbRole.Items
                If item.PropItemId = data("RoleId") Then
                    cbbRole.SelectedItem = item
                End If
            Next

        End If
        InitPlaceHolderText()

    End Sub
    Private Sub EmployeeInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetVisibleForPermission()
    End Sub

    'Set up placeholder text for comboboxes

    Private rolePlhTxt = "Select a role"
    Private statusPlhTxt = "Select a status"

    Private Sub InitPlaceHolderText()
        DropDownClosed(cbbRole, rolePlhTxt)
        DropDownClosed(cbbStatus, statusPlhTxt)
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
    Private Sub cbbStatus_DropDown(sender As Object, e As EventArgs) Handles cbbStatus.DropDown
        DropDown(cbbStatus, statusPlhTxt)
    End Sub

    Private Sub cbbStatus_DropDownClosed(sender As Object, e As EventArgs) Handles cbbStatus.DropDownClosed
        DropDownClosed(cbbStatus, statusPlhTxt)
    End Sub

    Private Sub SetVisibleForPermission()
        bEdit.Visible = False
        bDelete.Visible = False
        bSave.Visible = False
        cbEditAccount.Visible = False
        gbAccount.Visible = False
        lineSeparate.Visible = False

        Me.AutoSize = False
        Dim oldHeight = Me.Height
        Me.Size = New Size(Me.Width, Me.Height - gbAccount.Height - lineSeparate.Height - cbEditAccount.Height)

        Dim dataPermission = clsRolePermission.GetPermissionOfUser(LoginForm.PropUsername)
        For Each permission In dataPermission
            Dim form = permission(1).split(":")(0)
            Dim permiss = Strings.Split(Strings.Split(permission(1), ": ")(1), ", ")
            Select Case form
                Case "Employee category"
                    For Each p In permiss
                        Select Case p
                            Case "Edit"
                                bEdit.Visible = True
                                bSave.Visible = True
                                Console.WriteLine(bEdit.Visible.ToString())
                            Case "Delete"
                                bDelete.Visible = True
                            Case "CRUD account"
                                cbEditAccount.Visible = True
                                gbAccount.Visible = True
                                lineSeparate.Visible = True
                                Me.AutoSize = True
                                Me.Size = New Size(Me.Width, oldHeight)
                        End Select
                    Next
            End Select
        Next
        CenterButtons({bEdit, bDelete, bSave}.ToList(), 30)
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
        Dim y = If(gbAccount.Visible, bEdit.Location.Y, lineSeparate.Location.Y)

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
        cbEditAccount.Enabled = valBoolean
    End Sub
    Private Sub editDeleteEnabled(valBoolean As Boolean)
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
        'setPlaceHolderEnable(True)
    End Sub
    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        If checkLogicData() Then
            Dim result As Integer = 1
            Dim roleId = CType(cbbRole.SelectedItem, CBBItem).PropItemId

            Dim employeeCode = -1

            If mode = "Update" Then                  'Edit
                result = clsPMSAnalysis.UpdateEmployee(txtLastName.Text,
                                            txtFirstName.Text, rdMale.Checked, dtBirthDay.Value,
                                            txtPhone.Text, txtEmail.Text, txtAddress.Text, roleId, LoginForm.PropUsername, txtCode.Text)
                employeeCode = txtCode.Text
            Else                                     'Add new
                employeeCode = clsPMSAnalysis.AddEmployee(txtLastName.Text,
                                            txtFirstName.Text, rdMale.Checked, dtBirthDay.Value,
                                            txtPhone.Text, txtEmail.Text, txtAddress.Text, roleId, LoginForm.PropUsername)
            End If

            If result = 1 And cbEditAccount.Checked Then
                If checkAccountInfor() Then
                    'If employyee had account then update account else add account
                    If hasAccount Then
                        Dim temp = LoginForm.PropUsername

                        If String.Compare(LoginForm.PropUsername, clsPMSAnalysis.GetAccountNameById(employeeCode), StringComparison.OrdinalIgnoreCase) = 0 Then
                            LoginForm.PropUsername = txtAccountName.Text
                        End If
                        If txtPassword.Text.Equals(clsAccount.GetPasswordByUsername(clsPMSAnalysis.GetAccountNameById(employeeCode))) Then
                            result = clsAccount.UpdateAccountExceptPassword(employeeCode, clsPMSAnalysis.GetAccountNameById(employeeCode), txtAccountName.Text, CType(cbbStatus.SelectedItem, CBBItem).PropItemId, LoginForm.PropUsername)
                        Else
                            result = clsAccount.UpdateAccount(employeeCode, clsPMSAnalysis.GetAccountNameById(employeeCode), txtAccountName.Text, txtPassword.Text, CType(cbbStatus.SelectedItem, CBBItem).PropItemId, LoginForm.PropUsername)
                        End If

                        If result <> 1 Then
                            LoginForm.PropUsername = temp
                        End If

                    Else
                        result = clsAccount.AddAccount(txtAccountName.Text, txtPassword.Text, CType(cbbStatus.SelectedItem, CBBItem).PropItemId, LoginForm.PropUsername, employeeCode)
                    End If
                Else
                    Exit Sub
                End If
            End If

            If result = 1 Then
                setEnable(False)
                MsgBox(mode & " employee information successful!", Nothing, "Notification")
                Dim caller As EmployeeCategory = CType(Application.OpenForms("EmployeeCategory"), EmployeeCategory)
                caller.Reload()
                Me.Close()
            Else
                MsgBox("There is an error when interact with database!", Nothing, "Notification")
            End If
        End If
    End Sub

    Private Function checkLogicData() As Boolean
        If txtFirstName.Text = "First name" Or txtLastName.Text = "Last name" Or txtPhone.Text = "" Or txtAddress.Text = "" Or
            txtEmail.Text = "" Or cbbRole.SelectedIndex = -1 Or Not (rdMale.Checked Or rdFemale.Checked) Then

            MsgBox("You need to enter all the fields in employee's profile!", Nothing, "Notification")
            Return False

        ElseIf cbbRole.Text.Equals(rolePlhTxt) Then

            MsgBox("You need to select role for employee!", Nothing, "Notification")
            Return False

        ElseIf Not CheckValue("Phone", txtPhone.Text, "Long") Then
            Return False

        ElseIf Not txtPhone.Text.StartsWith("0") Then
            MsgBox("Phone number must be started with '0'!", Nothing, "Notification")
            Return False

        ElseIf txtPhone.Text.Length > 17 Then
            MsgBox("Phone number length can't be greater than 17!")
            Return False

        ElseIf countString(txtEmail.Text, "gmail.com") <> 1 Or Not txtEmail.Text.EndsWith("@gmail.com") Then
            MsgBox("Email invalidate!", Nothing, "Notification")
            Return False

        End If

        Return True
    End Function

    Private Function checkAccountInfor() As Boolean

        If cbEditAccount.Checked Then
            If txtAccountName.Text = "" Or txtPassword.Text = "" Then
                MsgBox("You need to enter all the fields in employee's account!", Nothing, "Notification")
                Return False

            Else
                If hasAccount Then
                    If clsAccount.CheckUsernameExists(txtAccountName.Text) And String.Compare(txtAccountName.Text, clsPMSAnalysis.GetAccountNameById(txtCode.Text), StringComparison.OrdinalIgnoreCase) <> 0 Then
                        MsgBox("Your account name enter existed!", Nothing, "Notification")
                        Return False
                    End If
                Else
                    If clsAccount.CheckUsernameExists(txtAccountName.Text) Then
                        MsgBox("Your account name enter existed!", Nothing, "Notification")
                        Return False
                    End If
                End If

                If cbbStatus.Text.Equals(statusPlhTxt) Then
                    MsgBox("You need to select status for account!", Nothing, "Notification")
                    Return False
                End If

            End If

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

    Private Sub bDelete_Click(sender As Object, e As EventArgs) Handles bDelete.Click
        Dim employeeId = txtCode.Text
        Dim result = clsPMSAnalysis.DeleteUser(LoginForm.PropUsername, employeeId)

        If result = 1 Then
            MsgBox("Delete employee information successful!", Nothing, "Notification")
            Dim caller As EmployeeCategory = CType(Application.OpenForms("EmployeeCategory"), EmployeeCategory)
            caller.Reload()
            Me.Close()
        End If

        If result <> 1 Then
            MsgBox("There is an error when interact with database!", Nothing, "Notification")
        End If
    End Sub

    Private Sub txtFirstName_MouseDown(sender As Object, e As MouseEventArgs) Handles txtFirstName.MouseDown
        If txtFirstName.ForeColor = Color.Gray Then
            txtFirstName.Select(0, 0)
        End If
    End Sub

    Private Sub txtLastName_MouseDown(sender As Object, e As MouseEventArgs) Handles txtLastName.MouseDown
        If txtLastName.ForeColor = Color.Gray Then
            txtLastName.Select(0, 0)
        End If
    End Sub

    Private Sub txtFirstName_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtFirstName.PreviewKeyDown
        If txtFirstName.ForeColor = Color.Gray Then
            txtFirstName.Text = ""
            txtFirstName.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtLastName_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtLastName.PreviewKeyDown
        If txtLastName.ForeColor = Color.Gray Then
            txtLastName.Text = ""
            txtLastName.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtFirstName_Leave(sender As Object, e As EventArgs) Handles txtFirstName.Leave
        If String.IsNullOrWhiteSpace(txtFirstName.Text) Then
            txtFirstName.Text = "First name"
            txtFirstName.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtLastName_Leave(sender As Object, e As EventArgs) Handles txtLastName.Leave
        If String.IsNullOrWhiteSpace(txtLastName.Text) Then
            txtLastName.Text = "Last name"
            txtLastName.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub cbEditAccount_CheckedChanged(sender As Object, e As EventArgs) Handles cbEditAccount.CheckedChanged
        txtAccountName.Enabled = cbEditAccount.Checked
        txtPassword.Enabled = cbEditAccount.Checked
        cbbStatus.Enabled = cbEditAccount.Checked
    End Sub

    Private Sub labShowPassword_Click(sender As Object, e As EventArgs) Handles labShowPassword.Click
        isShow = Not isShow
        Dim pathFileExe = Application.StartupPath
        If isShow Then
            labShowPassword.Image = Image.FromFile(Path.Combine(pathFileExe, "../../Images/view2.png"))
            txtPassword.UseSystemPasswordChar = False
        Else
            labShowPassword.Image = Image.FromFile(Path.Combine(pathFileExe, "../../Images/hide2.png"))
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

End Class