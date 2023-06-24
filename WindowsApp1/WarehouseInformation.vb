Imports LibraryDataset
Imports LibraryCommon
Public Class WarehouseInformation
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsWarehouse(conn.connSales.ConnectionString)
    Dim clsProduct As New clsProduct(conn.connSales.ConnectionString)
    Dim clsRolePermission As New clsRolePermission(conn.connSales.ConnectionString)

    Dim mode As String = "Add"
    Dim warehouseCode = -1

    Public Sub Init(ByVal warehouseCode As Long)
        If warehouseCode <> -1 Then
            mode = "Update"
            Me.warehouseCode = warehouseCode
        End If
    End Sub
    Private Sub WarehouseInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetVisibleForPermission()
        LoadData()
    End Sub
    Private Sub SetVisibleForPermission()
        bEdit.Visible = False
        bDelete.Visible = False
        bSave.Visible = False

        Dim dataPermission = clsRolePermission.GetPermissionOfUser(LoginForm.PropUsername)

        For Each permission In dataPermission
            Dim form = permission(1).split(":")(0)
            Dim permiss = Strings.Split(Strings.Split(permission(1), ": ")(1), ", ")
            Select Case form
                Case "Warehouse category"
                    For Each p In permiss
                        Select Case p
                            Case "Edit"
                                bEdit.Visible = True
                                bSave.Visible = True
                            Case "Delete"
                                bDelete.Visible = True
                        End Select
                    Next
            End Select
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
    Public Sub LoadData()
        If mode = "Add" Then
            setEnable(True)

            labTitle.Text = "ADD WAREHOUSE"
            labTitle.Location = New Point(Me.Width / 2 - labTitle.Width / 2, labTitle.Location.Y)

            Dim x As Integer = (Me.Width - bSave.Width) / 2

            bSave.Location = New Point(x, bSave.Location.Y)
            bSave.Visible = True
            bEdit.Visible = False
            bDelete.Visible = False

            txtNumberOfImport.Text = "0"
            txtNumberOfExport.Text = "0"
        Else
            setEnable(False)

            Dim data = clsPMSAnalysis.GetWarehouseById(warehouseCode)
            txtCode.Text = warehouseCode
            txtName.Text = data("WareHouseName")
            txtAddress.Text = data("Address")
            txtNumberOfImport.Text = data("NumberOfImport")
            txtNumberOfExport.Text = data("NumberOfExport")

        End If
        'InitPlaceHolderText()

    End Sub

    Private Sub bEdit_Click(sender As Object, e As EventArgs) Handles bEdit.Click
        bEdit.Enabled = False
        setEnable(True)
    End Sub

    Private Sub setEnable(valBoolean As Boolean)
        txtName.Enabled = valBoolean
        txtAddress.Enabled = valBoolean
        'txtNumberOfImport.Enabled = valBoolean
        'txtNumberOfExport.Enabled = valBoolean
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
        txtNumberOfImport.Text = "0"
        txtNumberOfExport.Text = "0"
        Warehouse.Clear()
    End Sub

    Private Sub bAdd_Click(sender As Object, e As EventArgs)
        clearValue()
        setEnable(True)
        editDeleteEnabled(False)
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        If checkLogicData() Then
            Dim result As Integer
            If mode = "Update" Then          'Edit
                result = clsPMSAnalysis.UpdateWarehouse(txtCode.Text, txtName.Text, txtAddress.Text, txtNumberOfImport.Text, txtNumberOfExport.Text, LoginForm.PropUsername)
            Else
                result = clsPMSAnalysis.AddWarehouse(txtName.Text, txtAddress.Text, txtNumberOfImport.Text, txtNumberOfExport.Text, LoginForm.PropUsername)
            End If
            If result = 1 Then
                MsgBox(mode & " warehouse information successful!", Nothing, "Notification")
                Dim caller As WarehouseCategory = CType(Application.OpenForms("WarehouseCategory"), WarehouseCategory)
                caller.Reload()
                Me.Close()
            Else
                MsgBox("There is an error when interact with database!", Nothing, "Notification")
            End If
        End If
    End Sub

    Private Function checkLogicData() As Boolean
        If txtName.Text = "" Or txtAddress.Text = "" Or txtNumberOfImport.Text = "" Or
            txtNumberOfExport.Text = "" Then

            MsgBox("You need to enter all the fields!", Nothing, "Notification")
            Return False

        ElseIf Not CheckValue("Warehouse code", txtCode.Text, "Long") Or
            Not CheckValue("Number of import", txtNumberOfImport.Text, "Long") Or
            Not CheckValue("Number of export", txtNumberOfExport.Text, "Long") Then
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

    Private Sub bDelete_Click(sender As Object, e As EventArgs) Handles bDelete.Click
        Dim code As String = txtCode.Text
        Dim result = clsPMSAnalysis.DeleteWarehouse(code, LoginForm.PropUsername)
        If result = 1 Then
            MsgBox("Delete warehouse information successful!", Nothing, "Notification")
            Dim caller As WarehouseCategory = CType(Application.OpenForms("WarehouseCategory"), WarehouseCategory)
            caller.Reload()
            Me.Close()
        Else
            MsgBox("There is an error when interact with database!", Nothing, "Notification")
        End If
    End Sub

End Class