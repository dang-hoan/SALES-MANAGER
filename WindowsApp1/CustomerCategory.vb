Imports LibraryDataset
Imports LibraryCommon

Public Class CustomerCategory
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsPerson(conn.connSales.ConnectionString)
    Private Sub CustomerCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub Reload()
        Dim data = clsPMSAnalysis.GetCustomers()
        dgvCategory.DataSource = data.Person
        setEnable(False)
        setValue()
    End Sub

    Private Sub bEdit_Click(sender As Object, e As EventArgs) Handles bEdit.Click
        setEnable(True)
    End Sub

    Private Sub setEnable(valBoolean As Boolean)
        If txtCustomerCode.Text <> "" Then
            txtCustomerCode.Enabled = False
        Else
            txtCustomerCode.Enabled = valBoolean
        End If
        txtCustomerFirstName.Enabled = valBoolean
        txtCustomerLastName.Enabled = valBoolean
        txtPhone.Enabled = valBoolean
        txtAddress.Enabled = valBoolean
        dtBirthDay.Enabled = valBoolean
        rdMale.Enabled = valBoolean
        rdFemale.Enabled = valBoolean
        txtEmail.Enabled = valBoolean
    End Sub

    Private Sub clearValue()
        txtCustomerCode.Text = ""
        txtCustomerFirstName.Text = ""
        txtCustomerLastName.Text = ""
        rdMale.Checked = True
        txtPhone.Text = ""
        txtAddress.Text = ""
        dtBirthDay.Value = DateTime.Now
        txtEmail.Text = ""
    End Sub

    Private Sub bAdd_Click(sender As Object, e As EventArgs) Handles bAdd.Click
        clearValue()
        setEnable(True)
    End Sub

    Private Sub dgvCategory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategory.CellClick
        setEnable(False)
        setValue()
    End Sub

    Private Sub setValue()
        If dgvCategory Is Nothing Then
            Return
        Else
            Dim row As DataGridViewRow = dgvCategory.CurrentRow
            txtCustomerCode.Text = row.Cells(0).Value.ToString
            txtCustomerLastName.Text = row.Cells(1).Value.ToString
            txtCustomerFirstName.Text = row.Cells(2).Value.ToString
            dtBirthDay.Text = row.Cells(4).Value.ToString
            txtPhone.Text = row.Cells(5).Value.ToString
            txtEmail.Text = row.Cells(6).Value.ToString
            txtAddress.Text = row.Cells(7).Value.ToString
            If row.Cells(3).Value.ToString() = "True" Then
                rdMale.Checked = True
            Else
                rdFemale.Checked = True
            End If
        End If
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        If checkLogicData() Then
            Dim result As Integer
            Dim type As String = "Update"
            If txtCustomerCode.Enabled = False Then          'Edit
                result = clsPMSAnalysis.EditUser(txtCustomerCode.Text, txtCustomerLastName.Text,
                                            txtCustomerFirstName.Text, rdMale.Checked, dtBirthDay.Value,
                                            txtPhone.Text, txtEmail.Text, txtAddress.Text, LoginForm.PropUsername)
            Else                                             'Add new
                result = clsPMSAnalysis.AddCustomer(txtCustomerCode.Text, txtCustomerLastName.Text,
                                            txtCustomerFirstName.Text, rdMale.Checked, dtBirthDay.Value,
                                            txtPhone.Text, txtEmail.Text, txtAddress.Text, LoginForm.PropUsername)
                type = "Add"
            End If

            If result = 1 Then
                setEnable(False)
                MsgBox(type & " customer information successful!")
                Reload()
            Else
                MsgBox("There is an error when interact with database!")
            End If
        End If
    End Sub

    Private Function checkLogicData() As Boolean
        If clsPMSAnalysis.CheckUsernameExits(txtCustomerCode.Text) And txtCustomerCode.Enabled = True Then
            MsgBox("CustomerCode already exists in the system! Let enter other CustomerCode")
            Return False

        ElseIf txtCustomerCode.Text = "" Or txtCustomerFirstName.Text = "" Or txtCustomerLastName.Text = "" Or txtPhone.Text = "" Or txtAddress.Text = "" Or
            txtEmail.Text = "" Then

            MsgBox("You need to enter all the fields!")
            Return False

        ElseIf Not checkPhone(txtPhone.Text) Then
            MsgBox("Phone number must be a number!")
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

    Private Function checkPhone(ByVal phone As String)
        For Each c As Char In phone
            If Asc(c) > 57 Or Asc(c) < 48 Then
                Return False
            End If
        Next

        Return True
    End Function

    Public Function countString(ByVal inputString As String, ByVal subString As String) As Integer
        Return System.Text.RegularExpressions.Regex.Split(inputString, subString).Length - 1

    End Function

    Private Sub bDelete_Click(sender As Object, e As EventArgs) Handles bDelete.Click
        Dim username As String = dgvCategory.CurrentRow.Cells(0).Value.ToString
        Dim isDelete = clsPMSAnalysis.CheckUserWasDeleted(username)
        If Not isDelete Then
            Dim result = clsPMSAnalysis.DeleteUser(LoginForm.PropUsername, username)
            If result = 1 Then
                setEnable(False)
                MsgBox("Delete customer information successful!")
                Reload()
            Else
                MsgBox("There is an error when interact with database!")
            End If
        Else
            MsgBox("User was deleted before!")
        End If
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Dim username As String = dgvCategory.CurrentRow.Cells(0).Value.ToString
        Dim isDelete = clsPMSAnalysis.CheckUserWasDeleted(username)
        If isDelete Then
            Dim result = clsPMSAnalysis.RestoreUser(username)
            If result = 1 Then
                setEnable(False)
                MsgBox("Restore customer information successful!")
                Reload()
            Else
                MsgBox("There is an error when interact with database!")
            End If
        Else
            MsgBox("The user hasn't been deleted yet, you don't need restore!")
        End If
    End Sub
End Class