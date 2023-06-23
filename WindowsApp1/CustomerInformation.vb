Imports LibraryDataset
Imports LibraryCommon

Public Class CustomerInformation
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsPerson(conn.connSales.ConnectionString)
    Dim clsRolePermission As New clsRolePermission(conn.connSales.ConnectionString)

    Dim mode As String = "Update"
    Public Sub LoadData(customerCode As Long)
        If customerCode = -1 Then
            setEnable(True)
            mode = "Add"

            labTitle.Text = "ADD CUSTOMER"
            labTitle.Location = New Point(Me.Width / 2 - labTitle.Width / 2, labTitle.Location.Y)

            Dim x As Integer = (Me.Width - bSave.Width) / 2

            bSave.Location = New Point(x, bSave.Location.Y)
            bEdit.Visible = False
            bDelete.Visible = False

            txtFirstName_Leave(txtFirstName, EventArgs.Empty)
            txtLastName_Leave(txtLastName, EventArgs.Empty)

        Else
            setEnable(False)

            Dim data = clsPMSAnalysis.GetPersonById(customerCode)
            txtCode.Text = customerCode
            txtLastName.Text = data("LastName")
            txtFirstName.Text = data("FirstName")
            dtBirthDay.Text = data("BirthDate")
            txtPhone.Text = data("Phone")
            txtEmail.Text = data("Email")
            txtAddress.Text = data("Address")

            If data("Gender") Then
                rdMale.Checked = True
            Else
                rdFemale.Checked = True
            End If

        End If
        'InitPlaceHolderText()

    End Sub
    Private Sub CustomerInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetVisibleForPermission()
    End Sub
    Private Sub SetVisibleForPermission()
        bEdit.Visible = False
        bDelete.Visible = False
        bSave.Visible = False
        Dim dataPermission = clsRolePermission.GetPermissionOfUser(LoginForm.PropUsername)
        For Each permission In dataPermission
            Dim form = permission(1).split(":")(0)
            Dim permiss = Strings.Split(Strings.Split(permission(1), ": ")(1), ", ")
            If form = "Customer category" Then
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
        txtFirstName.Enabled = valBoolean
        txtLastName.Enabled = valBoolean
        txtPhone.Enabled = valBoolean
        txtAddress.Enabled = valBoolean
        dtBirthDay.Enabled = valBoolean
        rdMale.Enabled = valBoolean
        rdFemale.Enabled = valBoolean
        txtEmail.Enabled = valBoolean
        bSave.Enabled = valBoolean
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
    End Sub
    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        If checkLogicData() Then
            Dim result As Integer = 1

            If mode = "Update" Then                  'Edit
                result = clsPMSAnalysis.UpdateCustomer(txtLastName.Text,
                                            txtFirstName.Text, rdMale.Checked, dtBirthDay.Value,
                                            txtPhone.Text, txtEmail.Text, txtAddress.Text, LoginForm.PropUsername, txtCode.Text)

            Else                                     'Add new
                clsPMSAnalysis.AddCustomer(txtLastName.Text,
                                            txtFirstName.Text, rdMale.Checked, dtBirthDay.Value,
                                            txtPhone.Text, txtEmail.Text, txtAddress.Text, LoginForm.PropUsername)
            End If

            If result = 1 Then
                setEnable(False)
                MsgBox(mode & " customer information successful!", Nothing, "Notification")
                Dim caller As CustomerCategory = CType(Application.OpenForms("CustomerCategory"), CustomerCategory)
                caller.Reload()
                Me.Close()
            Else
                MsgBox("There is an error when interact with database!", Nothing, "Notification")
            End If
        End If
    End Sub

    Private Function checkLogicData() As Boolean
        If txtFirstName.Text = "First name" Or txtLastName.Text = "Last name" Or txtPhone.Text = "" Or txtAddress.Text = "" Or
            txtEmail.Text = "" Or Not (rdMale.Checked Or rdFemale.Checked) Then

            MsgBox("You need to enter all the fields in customer's profile!", Nothing, "Notification")
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
        Dim customerId = txtCode.Text
        Dim result = clsPMSAnalysis.DeleteUser(LoginForm.PropUsername, customerId)

        If result = 1 Then
            MsgBox("Delete customer information successful!", Nothing, "Notification")
            Dim caller As CustomerCategory = CType(Application.OpenForms("CustomerCategory"), CustomerCategory)
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

End Class