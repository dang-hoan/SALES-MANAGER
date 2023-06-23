Imports LibraryDataset
Imports LibraryCommon

Public Class SupplierInformation
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsSupplier(conn.connSales.ConnectionString)
    Dim clsRolePermission As New clsRolePermission(conn.connSales.ConnectionString)

    Dim mode As String = "Update"
    Public Sub LoadData(supplierCode As Long)
        If supplierCode = -1 Then
            setEnable(True)
            mode = "Add"

            labTitle.Text = "ADD SUPPLIER"
            labTitle.Location = New Point(Me.Width / 2 - labTitle.Width / 2, labTitle.Location.Y)

            Dim x As Integer = (Me.Width - bSave.Width) / 2

            bSave.Location = New Point(x, bSave.Location.Y)
            bEdit.Visible = False
            bDelete.Visible = False

        Else
            setEnable(False)

            Dim data = clsPMSAnalysis.GetSuppliertById(supplierCode)
            txtCode.Text = supplierCode
            txtName.Text = data("CompanyName")
            txtAddress.Text = data("Address")
            txtPhone.Text = data("Phone")
            txtEmail.Text = data("Email")
            txtWebpage.Text = data("Webpage")
            txtDescription.Text = data("Description")

        End If
        'InitPlaceHolderText()

    End Sub
    Private Sub SupplierInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            If form = "Supplier category" Then
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
        txtName.Enabled = valBoolean
        txtPhone.Enabled = valBoolean
        txtAddress.Enabled = valBoolean
        txtEmail.Enabled = valBoolean
        txtWebpage.Enabled = valBoolean
        txtDescription.Enabled = valBoolean
        bSave.Enabled = valBoolean
    End Sub

    Private Sub editDeleteEnabled(valBoolean As Boolean)
        bEdit.Enabled = valBoolean
        bDelete.Enabled = valBoolean
    End Sub

    Private Sub clearValue()
        txtCode.Text = ""
        txtName.Text = ""
        txtAddress.Text = ""
        txtPhone.Text = ""
        txtEmail.Text = ""
        txtWebpage.Text = ""
        txtDescription.Text = ""
    End Sub

    Private Sub bAdd_Click(sender As Object, e As EventArgs)
        clearValue()
        setEnable(True)
        editDeleteEnabled(False)
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        If checkLogicData() Then
            Dim result As Integer
            If mode = "Update" Then                          'Edit
                result = clsPMSAnalysis.UpdateSupplier(txtCode.Text, txtName.Text,
                                            txtAddress.Text, txtPhone.Text, txtEmail.Text,
                                            txtWebpage.Text, txtDescription.Text,
                                            LoginForm.PropUsername)
            Else                                             'Add new
                result = clsPMSAnalysis.AddSupplier(txtName.Text, txtAddress.Text,
                                            txtPhone.Text, txtEmail.Text,
                                            txtWebpage.Text, txtDescription.Text,
                                            LoginForm.PropUsername)
            End If

            If result = 1 Then
                MsgBox(mode & " supplier information successful!", Nothing, "Notification")
                Dim caller As SupplierCategory = CType(Application.OpenForms("SupplierCategory"), SupplierCategory)
                caller.Reload()
                Me.Close()
            Else
                MsgBox("There is an error when interact with database!", Nothing, "Notification")
            End If
        End If
    End Sub

    Private Function checkLogicData() As Boolean
        If txtName.Text = "" Or
            txtEmail.Text = "" Or txtPhone.Text = "" Or txtAddress.Text = "" Then

            MsgBox("You need to enter all the required fields!", Nothing, "Notification")
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
        Dim code As String = txtCode.Text
        Dim result = clsPMSAnalysis.DeleteSupplier(code, LoginForm.PropUsername)
        If result = 1 Then
            MsgBox("Delete supplier information successful!", Nothing, "Notification")
            Dim caller As SupplierCategory = CType(Application.OpenForms("SupplierCategory"), SupplierCategory)
            caller.Reload()
            Me.Close()
        Else
            MsgBox("There is an error when interact with database!", Nothing, "Notification")
        End If
    End Sub
End Class