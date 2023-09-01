Imports LibraryDataset
Imports LibraryCommon
Public Class DecentralizationForm
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsRolePermission(conn.connSales.ConnectionString)

    Public isNew As Boolean = False

    Private Sub DecentralizationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
        SetEnable(False)
        SetVisibleForPermission()
    End Sub

    Private Sub SetVisibleForPermission()
        bNewRole.Visible = False
        bDeleteRole.Visible = False
        bEdit.Visible = False
        bClearAll.Visible = False
        bSave.Visible = False
        Dim dataPermission = clsPMSAnalysis.GetPermissionOfUser(LoginForm.PropUsername)
        For Each permission In dataPermission
            Dim form = permission(1).split(":")(0)
            Dim permiss = Strings.Split(Strings.Split(permission(1), ": ")(1), ", ")
            If form = "Decentralization" Then
                For Each p In permiss
                    Select Case p
                        Case "Add role"
                            bNewRole.Visible = True
                        Case "Edit"
                            bEdit.Visible = True
                            bClearAll.Visible = True
                            bSave.Visible = True
                        Case "Delete role"
                            bDeleteRole.Visible = True
                    End Select
                Next
                Exit For
            End If
        Next
        CenterButton()
    End Sub

    Private Sub CenterButton()
        Dim val1 = bNewRole.Visible
        Dim val2 = bDeleteRole.Visible
        If val1 = True And val2 = False Then
            bNewRole.Location = New Point(cbbRole.Location.X + cbbRole.Width + 10, cbbRole.Location.Y)
        End If
        If val1 = False And val2 = True Then
            bDeleteRole.Location = New Point(cbbRole.Location.X + cbbRole.Width + 10, cbbRole.Location.Y)
        End If
        If val1 = True And val2 = True Then
            bNewRole.Location = New Point(cbbRole.Location.X + cbbRole.Width + 10, cbbRole.Location.Y - 12)
            bDeleteRole.Location = New Point(cbbRole.Location.X + cbbRole.Width + 10, cbbRole.Location.Y + 12)
        End If
    End Sub

    Private Sub SetEnable(ByVal valBoolean As Boolean)
        cbCustomerCG.Enabled = valBoolean
        cbCustomerCGExport.Enabled = cbCustomerCG.Checked
        cbCustomerCGAdd.Enabled = cbCustomerCG.Checked
        cbCustomerCGDelete.Enabled = cbCustomerCG.Checked
        cbCustomerCGEdit.Enabled = cbCustomerCG.Checked

        cbEmployeeCG.Enabled = valBoolean
        cbEmployeeCGExport.Enabled = cbEmployeeCG.Checked
        cbEmployeeCGAdd.Enabled = cbEmployeeCG.Checked
        cbEmployeeCGDelete.Enabled = cbEmployeeCG.Checked
        cbEmployeeCGEdit.Enabled = cbEmployeeCG.Checked
        cbEmployeeCGCRUDAccount.Enabled = cbEmployeeCG.Checked

        cbProductCG.Enabled = valBoolean
        cbProductCGExport.Enabled = cbProductCG.Checked
        cbProductCGAdd.Enabled = cbProductCG.Checked
        cbProductCGDelete.Enabled = cbProductCG.Checked
        cbProductCGEdit.Enabled = cbProductCG.Checked


        cbOrderCG.Enabled = valBoolean
        cbOrderCGExport.Enabled = cbOrderCG.Checked
        cbOrderCGAdd.Enabled = cbOrderCG.Checked
        cbOrderCGDelete.Enabled = cbOrderCG.Checked
        cbOrderCGEdit.Enabled = cbOrderCG.Checked

        cbSupplierCG.Enabled = valBoolean
        cbSupplierCGExport.Enabled = cbSupplierCG.Checked
        cbSupplierCGAdd.Enabled = cbSupplierCG.Checked
        cbSupplierCGDelete.Enabled = cbSupplierCG.Checked
        cbSupplierCGEdit.Enabled = cbSupplierCG.Checked

        cbWarehouseCG.Enabled = valBoolean
        cbWarehouseCGExport.Enabled = cbWarehouseCG.Checked
        cbWarehouseCGAdd.Enabled = cbWarehouseCG.Checked
        cbWarehouseCGDelete.Enabled = cbWarehouseCG.Checked
        cbWarehouseCGEdit.Enabled = cbWarehouseCG.Checked

        cbWarehouseReport.Enabled = valBoolean
        cbWarehouseReportExport.Enabled = cbWarehouseReport.Checked

        cbDecentralization.Enabled = valBoolean
        cbDecentralizationAddRole.Enabled = cbDecentralization.Checked
        cbDecentralizationEdit.Enabled = cbDecentralization.Checked
        cbDecentralizationDeleteRole.Enabled = cbDecentralization.Checked

        If cbbRole.SelectedItem IsNot Nothing Then
            bEdit.Enabled = Not valBoolean
            bClearAll.Enabled = valBoolean
            bSave.Enabled = valBoolean
            bDeleteRole.Enabled = True
        Else
            bEdit.Enabled = False
            bClearAll.Enabled = False
            bSave.Enabled = False
            bDeleteRole.Enabled = False
        End If
    End Sub

    Private Sub SetEnableFalse()
        cbCustomerCG.Enabled = False
        cbCustomerCGSearch.Enabled = False
        cbCustomerCGExport.Enabled = False
        cbCustomerCGAdd.Enabled = False
        cbCustomerCGDelete.Enabled = False
        cbCustomerCGEdit.Enabled = False

        cbEmployeeCG.Enabled = False
        cbEmployeeCGSearch.Enabled = False
        cbEmployeeCGExport.Enabled = False
        cbEmployeeCGAdd.Enabled = False
        cbEmployeeCGDelete.Enabled = False
        cbEmployeeCGEdit.Enabled = False
        cbEmployeeCGCRUDAccount.Enabled = False

        cbProductCG.Enabled = False
        cbProductCGSearch.Enabled = False
        cbProductCGExport.Enabled = False
        cbProductCGAdd.Enabled = False
        cbProductCGDelete.Enabled = False
        cbProductCGEdit.Enabled = False

        cbOrderCG.Enabled = False
        cbOrderCGSearch.Enabled = False
        cbOrderCGExport.Enabled = False
        cbOrderCGAdd.Enabled = False
        cbOrderCGDelete.Enabled = False
        cbOrderCGEdit.Enabled = False

        cbSupplierCG.Enabled = False
        cbSupplierCGSearch.Enabled = False
        cbSupplierCGExport.Enabled = False
        cbSupplierCGAdd.Enabled = False
        cbSupplierCGDelete.Enabled = False
        cbSupplierCGEdit.Enabled = False

        cbWarehouseCG.Enabled = False
        cbWarehouseCGSearch.Enabled = False
        cbWarehouseCGExport.Enabled = False
        cbWarehouseCGAdd.Enabled = False
        cbWarehouseCGDelete.Enabled = False
        cbWarehouseCGEdit.Enabled = False

        cbWarehouseReport.Enabled = False
        cbWarehouseReportStatistic.Enabled = False
        cbWarehouseReportExport.Enabled = False

        cbDecentralization.Enabled = False
        cbDecentralizationView.Enabled = False
        cbDecentralizationAddRole.Enabled = False
        cbDecentralizationEdit.Enabled = False
        cbDecentralizationDeleteRole.Enabled = False

        If cbbRole.SelectedItem IsNot Nothing Then
            bEdit.Enabled = True
            bClearAll.Enabled = False
            bSave.Enabled = False
            bDeleteRole.Enabled = True
        Else
            bEdit.Enabled = False
            bClearAll.Enabled = False
            bSave.Enabled = False
            bDeleteRole.Enabled = False
        End If
    End Sub

    Private Sub SetValue()
        If cbbRole.Text <> "" Then
            ClearValue()
            Dim dataPermission = clsPMSAnalysis.GetPermissionByRoleId(CType(cbbRole.SelectedItem, CBBItem).PropItemId)
            For Each permission In dataPermission.Rows
                Dim form = permission(1).split(":")(0)
                Dim permiss = Strings.Split(Strings.Split(permission(1), ": ")(1), ", ")
                Select Case form
                    Case "Customer category"
                        cbCustomerCG.Checked = True
                        For Each p In permiss
                            Select Case p
                                Case "Search"
                                    cbCustomerCGSearch.Checked = True
                                Case "Export"
                                    cbCustomerCGExport.Checked = True
                                Case "Add"
                                    cbCustomerCGAdd.Checked = True
                                Case "Delete"
                                    cbCustomerCGDelete.Checked = True
                                Case "Edit"
                                    cbCustomerCGEdit.Checked = True
                            End Select
                        Next

                    Case "Employee category"
                        cbEmployeeCG.Checked = True
                        For Each p In permiss
                            Select Case p
                                Case "Search"
                                    cbEmployeeCGSearch.Checked = True
                                Case "Export"
                                    cbEmployeeCGExport.Checked = True
                                Case "Add"
                                    cbEmployeeCGAdd.Checked = True
                                Case "Delete"
                                    cbEmployeeCGDelete.Checked = True
                                Case "Edit"
                                    cbEmployeeCGEdit.Checked = True
                                Case "CRUD account"
                                    cbEmployeeCGCRUDAccount.Checked = True
                            End Select
                        Next
                    Case "Product category"
                        cbProductCG.Checked = True
                        For Each p In permiss
                            Select Case p
                                Case "Search"
                                    cbProductCGSearch.Checked = True
                                Case "Export"
                                    cbProductCGExport.Checked = True
                                Case "Add"
                                    cbProductCGAdd.Checked = True
                                Case "Delete"
                                    cbProductCGDelete.Checked = True
                                Case "Edit"
                                    cbProductCGEdit.Checked = True
                            End Select
                        Next
                    Case "Order category"
                        cbOrderCG.Checked = True
                        For Each p In permiss
                            Select Case p
                                Case "Search"
                                    cbOrderCGSearch.Checked = True
                                Case "Export"
                                    cbOrderCGExport.Checked = True
                                Case "Add"
                                    cbOrderCGAdd.Checked = True
                                Case "Delete"
                                    cbOrderCGDelete.Checked = True
                                Case "Edit"
                                    cbOrderCGEdit.Checked = True
                            End Select
                        Next
                    Case "Supplier category"
                        cbSupplierCG.Checked = True
                        For Each p In permiss
                            Select Case p
                                Case "Search"
                                    cbSupplierCGSearch.Checked = True
                                Case "Export"
                                    cbSupplierCGExport.Checked = True
                                Case "Add"
                                    cbSupplierCGAdd.Checked = True
                                Case "Delete"
                                    cbSupplierCGDelete.Checked = True
                                Case "Edit"
                                    cbSupplierCGEdit.Checked = True
                            End Select
                        Next
                    Case "Warehouse category"
                        cbWarehouseCG.Checked = True
                        For Each p In permiss
                            Select Case p
                                Case "Search"
                                    cbWarehouseCGSearch.Checked = True
                                Case "Export"
                                    cbWarehouseCGExport.Checked = True
                                Case "Add"
                                    cbWarehouseCGAdd.Checked = True
                                Case "Delete"
                                    cbWarehouseCGDelete.Checked = True
                                Case "Edit"
                                    cbWarehouseCGEdit.Checked = True
                            End Select
                        Next
                    Case "Warehouse report"
                        cbWarehouseReport.Checked = True
                        For Each p In permiss
                            Select Case p
                                Case "Statistic"
                                    cbWarehouseReportStatistic.Checked = True
                                Case "Export"
                                    cbWarehouseReportExport.Checked = True
                            End Select
                        Next
                    Case "Decentralization"
                        cbDecentralization.Checked = True
                        For Each p In permiss
                            Select Case p
                                Case "View"
                                    cbDecentralizationView.Checked = True
                                Case "Add role"
                                    cbDecentralizationAddRole.Checked = True
                                Case "Edit"
                                    cbDecentralizationEdit.Checked = True
                                Case "Delete role"
                                    cbDecentralizationDeleteRole.Checked = True
                            End Select
                        Next
                End Select
            Next
            SetEnableFalse()
        End If
    End Sub
    Private Sub ClearValue()
        cbCustomerCG.Checked = False
        cbCustomerCGSearch.Checked = False
        cbCustomerCGExport.Checked = False
        cbCustomerCGAdd.Checked = False
        cbCustomerCGDelete.Checked = False
        cbCustomerCGEdit.Checked = False

        cbEmployeeCG.Checked = False
        cbEmployeeCGSearch.Checked = False
        cbEmployeeCGExport.Checked = False
        cbEmployeeCGAdd.Checked = False
        cbEmployeeCGDelete.Checked = False
        cbEmployeeCGEdit.Checked = False
        cbEmployeeCGCRUDAccount.Checked = False

        cbProductCG.Checked = False
        cbProductCGSearch.Checked = False
        cbProductCGExport.Checked = False
        cbProductCGAdd.Checked = False
        cbProductCGDelete.Checked = False
        cbProductCGEdit.Checked = False

        cbOrderCG.Checked = False
        cbOrderCGSearch.Checked = False
        cbOrderCGExport.Checked = False
        cbOrderCGAdd.Checked = False
        cbOrderCGDelete.Checked = False
        cbOrderCGEdit.Checked = False

        cbSupplierCG.Checked = False
        cbSupplierCGSearch.Checked = False
        cbSupplierCGExport.Checked = False
        cbSupplierCGAdd.Checked = False
        cbSupplierCGDelete.Checked = False
        cbSupplierCGEdit.Checked = False

        cbWarehouseCG.Checked = False
        cbWarehouseCGSearch.Checked = False
        cbWarehouseCGExport.Checked = False
        cbWarehouseCGAdd.Checked = False
        cbWarehouseCGDelete.Checked = False
        cbWarehouseCGEdit.Checked = False

        cbWarehouseReport.Checked = False
        cbWarehouseReportStatistic.Checked = False
        cbWarehouseReportExport.Checked = False

        cbDecentralization.Checked = False
        cbDecentralizationView.Checked = False
        cbDecentralizationAddRole.Checked = False
        cbDecentralizationEdit.Checked = False
        cbDecentralizationDeleteRole.Checked = False

    End Sub

    Private Sub Reload()
        Dim dataRole = clsPMSAnalysis.GetAllRoles()

        Dim selected As CBBItem = Nothing
        If cbbRole.SelectedItem IsNot Nothing Then
            selected = cbbRole.SelectedItem
        End If

        cbbRole.Items.Clear()
        For Each role In dataRole
            cbbRole.Items.Add(New CBBItem(role(0), role(1)))
        Next

        If isNew Then
            cbbRole.SelectedItem = cbbRole.Items(cbbRole.Items.Count - 1)
        Else
            If selected IsNot Nothing Then
                For Each role As CBBItem In cbbRole.Items
                    If role.PropItemId = selected.PropItemId Then
                        cbbRole.SelectedItem = role
                    End If
                Next
            End If
        End If

    End Sub

    Private Sub bNewRole_Click(sender As Object, e As EventArgs) Handles bNewRole.Click
        Dim roleName = InputBox("Let's enter new role's name:", "Create new role")
        If roleName <> "" Then
            Dim result = clsPMSAnalysis.AddRole(roleName, LoginForm.PropUsername)
            If result = 1 Then
                MsgBox("Add new role successful!", Nothing, "Notification")
                isNew = True
                Reload()
                ClearValue()
                If bSave.Visible = True Then
                    SetEnable(True)
                Else
                    SetEnableFalse()
                    isNew = False
                End If
            Else
                MsgBox("There is an error when interact with database!", Nothing, "Notification")
            End If
        End If
    End Sub

    Private Sub bDeleteRole_Click(sender As Object, e As EventArgs) Handles bDeleteRole.Click
        If cbbRole.Text <> "" Then
            Dim result = clsPMSAnalysis.DeleteRole(CType(cbbRole.SelectedItem, CBBItem).PropItemId, LoginForm.PropUsername)
            If result = 1 Then
                MsgBox("Delete new role successful!", Nothing, "Notification")
                Reload()
                SetEnable(False)
                ClearValue()
                isNew = False
            Else
                MsgBox("There is an error when interact with database!", Nothing, "Notification")
            End If
        End If
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        Dim permissions = New List(Of String) From {"", "", "", "", "", "", "", ""}

        'CATEGORY
        If cbCustomerCG.Checked Then
            permissions(0) += "Customer category: " + If(cbCustomerCGSearch.Checked, "Search, ", "") +
                If(cbCustomerCGExport.Checked, "Export, ", "") + If(cbCustomerCGAdd.Checked, "Add, ", "") +
                If(cbCustomerCGDelete.Checked, "Delete, ", "") + If(cbCustomerCGEdit.Checked, "Edit, ", "")
            If permissions(0) <> "" Then
                permissions(0) = permissions(0).Substring(0, permissions(0).Length - 2)
            End If
        End If

        If cbEmployeeCG.Checked Then
            permissions(1) += "Employee category: " + If(cbEmployeeCGSearch.Checked, "Search, ", "") +
                If(cbEmployeeCGExport.Checked, "Export, ", "") + If(cbEmployeeCGAdd.Checked, "Add, ", "") +
                If(cbEmployeeCGDelete.Checked, "Delete, ", "") + If(cbEmployeeCGEdit.Checked, "Edit, ", "") + If(cbEmployeeCGCRUDAccount.Checked, "CRUD account, ", "")
            If permissions(1) <> "" Then
                permissions(1) = permissions(1).Substring(0, permissions(1).Length - 2)
            End If
        End If

        If cbProductCG.Checked Then
            permissions(2) += "Product category: " + If(cbProductCGSearch.Checked, "Search, ", "") +
                If(cbProductCGExport.Checked, "Export, ", "") + If(cbProductCGAdd.Checked, "Add, ", "") +
                If(cbProductCGDelete.Checked, "Delete, ", "") + If(cbProductCGEdit.Checked, "Edit, ", "")
            If permissions(2) <> "" Then
                permissions(2) = permissions(2).Substring(0, permissions(2).Length - 2)
            End If
        End If

        If cbOrderCG.Checked Then
            permissions(3) += "Order category: " + If(cbOrderCGSearch.Checked, "Search, ", "") +
                If(cbOrderCGExport.Checked, "Export, ", "") + If(cbOrderCGAdd.Checked, "Add, ", "") +
                If(cbOrderCGDelete.Checked, "Delete, ", "") + If(cbOrderCGEdit.Checked, "Edit, ", "")
            If permissions(3) <> "" Then
                permissions(3) = permissions(3).Substring(0, permissions(3).Length - 2)
            End If
        End If

        If cbSupplierCG.Checked Then
            permissions(4) += "Supplier category: " + If(cbSupplierCGSearch.Checked, "Search, ", "") +
                If(cbSupplierCGExport.Checked, "Export, ", "") + If(cbSupplierCGAdd.Checked, "Add, ", "") +
                If(cbSupplierCGDelete.Checked, "Delete, ", "") + If(cbSupplierCGEdit.Checked, "Edit, ", "")
            If permissions(4) <> "" Then
                permissions(4) = permissions(4).Substring(0, permissions(4).Length - 2)
            End If
        End If

        If cbWarehouseCG.Checked Then
            permissions(5) += "Warehouse category: " + If(cbWarehouseCGSearch.Checked, "Search, ", "") +
                If(cbWarehouseCGExport.Checked, "Export, ", "") + If(cbWarehouseCGAdd.Checked, "Add, ", "") +
                If(cbWarehouseCGDelete.Checked, "Delete, ", "") + If(cbWarehouseCGEdit.Checked, "Edit, ", "")
            If permissions(5) <> "" Then
                permissions(5) = permissions(5).Substring(0, permissions(5).Length - 2)
            End If
        End If

        'DECENTRALIZE
        If cbDecentralization.Checked Then
            permissions(6) += "Decentralization: " + If(cbDecentralizationView.Checked, "View, ", "") +
                If(cbDecentralizationEdit.Checked, "Edit, ", "") +
                If(cbDecentralizationAddRole.Checked, "Add role, ", "") +
                If(cbDecentralizationDeleteRole.Checked, "Delete role, ", "")
            If permissions(6) <> "" Then
                permissions(6) = permissions(6).Substring(0, permissions(6).Length - 2)
            End If
        End If

        'STATISTIC
        If cbWarehouseReport.Checked Then
            permissions(7) += "Warehouse report: " + If(cbWarehouseReportStatistic.Checked, "Statistic, ", "") +
                If(cbWarehouseReportExport.Checked, "Export, ", "")
            If permissions(7) <> "" Then
                permissions(7) = permissions(7).Substring(0, permissions(7).Length - 2)
            End If
        End If

        Dim type = ""
        Dim result = 1
        If isNew Then
            For Each permission In permissions
                If permission <> "" Then
                    If result = 1 Then
                        Dim permissionId? = clsPMSAnalysis.CheckPermissionExists(permission)
                        If permissionId Is Nothing Then
                            permissionId = clsPMSAnalysis.AddPermission(permission, LoginForm.PropUsername)
                        End If
                        result = clsPMSAnalysis.AddRolePermission(CType(cbbRole.SelectedItem, CBBItem).PropItemId, permissionId)
                    Else
                        Exit For
                    End If
                End If
            Next
            type = "Add"
        Else
            If cbbRole.SelectedItem IsNot Nothing Then
                result = clsPMSAnalysis.DeleteRolePermisisonByRole(CType(cbbRole.SelectedItem, CBBItem).PropItemId)
                If result >= 0 Then
                    result = 1
                End If
                For Each permission In permissions
                    If permission <> "" Then
                        If result = 1 Then
                            Dim permissionId? = clsPMSAnalysis.CheckPermissionExists(permission)
                            If permissionId Is Nothing Then
                                permissionId = clsPMSAnalysis.AddPermission(permission, LoginForm.PropUsername)
                            End If
                            result = clsPMSAnalysis.AddRolePermission(CType(cbbRole.SelectedItem, CBBItem).PropItemId, permissionId)
                        Else
                            Exit For
                        End If
                    End If
                Next
                type = "Update"
            End If
        End If

        If result = 1 Then
            SetEnableFalse()
            MsgBox(type & " permission information successful!", Nothing, "Notification")
            Reload()
            isNew = False
            Dim caller As MainForm = CType(Application.OpenForms("MainForm"), MainForm)
            caller.SetVisibleForPermission()
            SetVisibleForPermission()
        Else
            MsgBox("There is an error when interact with database!", Nothing, "Notification")
        End If
    End Sub

    Private Sub bEdit_Click(sender As Object, e As EventArgs) Handles bEdit.Click
        SetEnable(True)
    End Sub

    Private Sub bClearAll_Click(sender As Object, e As EventArgs) Handles bClearAll.Click
        ClearValue()
    End Sub

    Private Sub cbbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbRole.SelectedIndexChanged
        SetValue()
    End Sub

    Private Sub cbCustomerCG_CheckedChanged(sender As Object, e As EventArgs) Handles cbCustomerCG.CheckedChanged
        Dim val = cbCustomerCG.Checked
        cbCustomerCGSearch.Checked = True
        cbCustomerCGExport.Enabled = val
        cbCustomerCGAdd.Enabled = val
        cbCustomerCGDelete.Enabled = val
        cbCustomerCGEdit.Enabled = val
    End Sub

    Private Sub cbEmployeeCG_CheckedChanged(sender As Object, e As EventArgs) Handles cbEmployeeCG.CheckedChanged
        Dim val = cbEmployeeCG.Checked
        cbEmployeeCGSearch.Checked = True
        cbEmployeeCGExport.Enabled = val
        cbEmployeeCGAdd.Enabled = val
        cbEmployeeCGDelete.Enabled = val
        cbEmployeeCGEdit.Enabled = val
        cbEmployeeCGCRUDAccount.Enabled = val
    End Sub

    Private Sub cbProductCG_CheckedChanged(sender As Object, e As EventArgs) Handles cbProductCG.CheckedChanged
        Dim val = cbProductCG.Checked
        cbProductCGSearch.Checked = True
        cbProductCGExport.Enabled = val
        cbProductCGAdd.Enabled = val
        cbProductCGDelete.Enabled = val
        cbProductCGEdit.Enabled = val
    End Sub

    Private Sub cbOrderCG_CheckedChanged(sender As Object, e As EventArgs) Handles cbOrderCG.CheckedChanged
        Dim val = cbOrderCG.Checked
        cbOrderCGSearch.Checked = True
        cbOrderCGExport.Enabled = val
        cbOrderCGAdd.Enabled = val
        cbOrderCGDelete.Enabled = val
        cbOrderCGEdit.Enabled = val
    End Sub

    Private Sub cbSupplierCG_CheckedChanged(sender As Object, e As EventArgs) Handles cbSupplierCG.CheckedChanged
        Dim val = cbSupplierCG.Checked
        cbSupplierCGSearch.Checked = True
        cbSupplierCGExport.Enabled = val
        cbSupplierCGAdd.Enabled = val
        cbSupplierCGDelete.Enabled = val
        cbSupplierCGEdit.Enabled = val
    End Sub

    Private Sub cbWarehouseCG_CheckedChanged(sender As Object, e As EventArgs) Handles cbWarehouseCG.CheckedChanged
        Dim val = cbWarehouseCG.Checked
        cbWarehouseCGSearch.Checked = True
        cbWarehouseCGExport.Enabled = val
        cbWarehouseCGAdd.Enabled = val
        cbWarehouseCGDelete.Enabled = val
        cbWarehouseCGEdit.Enabled = val
    End Sub

    Private Sub cbDecentralization_CheckedChanged(sender As Object, e As EventArgs) Handles cbDecentralization.CheckedChanged
        Dim val = cbDecentralization.Checked
        cbDecentralizationView.Checked = True
        cbDecentralizationAddRole.Enabled = val
        cbDecentralizationEdit.Enabled = val
        cbDecentralizationDeleteRole.Enabled = val
    End Sub
    Private Sub cbWarehouseReport_CheckedChanged(sender As Object, e As EventArgs) Handles cbWarehouseReport.CheckedChanged
        Dim val = cbWarehouseReport.Checked
        cbWarehouseReportStatistic.Checked = True
        cbWarehouseReportExport.Enabled = val
    End Sub

End Class