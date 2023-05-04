Imports LibraryDataset
Imports LibraryCommon
Public Class DecentralizationForm
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsRolePermission(conn.connSales.ConnectionString)

    Public isNew As Boolean = False

    Private Sub DecentralizationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
        SetEnable(False)
    End Sub

    Private Sub SetEnable(ByVal valBoolean As Boolean)
        cbCustomerCG.Enabled = valBoolean
        cbCustomerCGAdd.Enabled = cbCustomerCG.Checked
        cbCustomerCGEdit.Enabled = cbCustomerCG.Checked
        cbCustomerCGDelete.Enabled = cbCustomerCG.Checked

        cbEmployeeCG.Enabled = valBoolean
        cbEmployeeCGAdd.Enabled = cbEmployeeCG.Checked
        cbEmployeeCGEdit.Enabled = cbEmployeeCG.Checked
        cbEmployeeCGDelete.Enabled = cbEmployeeCG.Checked

        cbProductCG.Enabled = valBoolean
        cbProductCGAdd.Enabled = cbProductCG.Checked
        cbProductCGEdit.Enabled = cbProductCG.Checked
        cbProductCGDelete.Enabled = cbProductCG.Checked


        cbOrderCG.Enabled = valBoolean
        cbOrderCGAdd.Enabled = cbOrderCG.Checked
        cbOrderCGEdit.Enabled = cbOrderCG.Checked
        cbOrderCGDelete.Enabled = cbOrderCG.Checked

        cbSupplierCG.Enabled = valBoolean
        cbSupplierCGAdd.Enabled = cbSupplierCG.Checked
        cbSupplierCGEdit.Enabled = cbSupplierCG.Checked
        cbSupplierCGDelete.Enabled = cbSupplierCG.Checked

        cbWarehouseCG.Enabled = valBoolean
        cbWarehouseCGAdd.Enabled = cbWarehouseCG.Checked
        cbWarehouseCGEdit.Enabled = cbWarehouseCG.Checked
        cbWarehouseCGDelete.Enabled = cbWarehouseCG.Checked

        cbEmployeeSearch.Enabled = valBoolean
        cbEmployeeSearchExport.Enabled = cbEmployeeSearch.Checked

        cbProductSearch.Enabled = valBoolean
        cbProductSearchExport.Enabled = cbProductSearch.Checked

        cbOrderSearch.Enabled = valBoolean
        cbOrderSearchExport.Enabled = cbOrderSearch.Checked

        cbInventoryReport.Enabled = valBoolean
        cbInventoryReportExport.Enabled = cbInventoryReport.Checked

        cbSalesReport.Enabled = valBoolean
        cbSalesReportExport.Enabled = cbSalesReport.Checked

        cbDecentralization.Enabled = valBoolean
        cbDecentralizationEdit.Enabled = cbDecentralization.Checked

        cbEmployeeAccountInfor.Enabled = valBoolean
        cbEmployeeAccountInforAdd.Enabled = cbEmployeeAccountInfor.Checked
        cbEmployeeAccountInforEdit.Enabled = cbEmployeeAccountInfor.Checked

        cbDetailWarehouseProduct.Enabled = valBoolean
        cbDetailProductAdd.Enabled = cbDetailWarehouseProduct.Checked
        cbDetailProductEdit.Enabled = cbDetailWarehouseProduct.Checked

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
        cbCustomerCGView.Enabled = False
        cbCustomerCGAdd.Enabled = False
        cbCustomerCGEdit.Enabled = False
        cbCustomerCGDelete.Enabled = False
        cbEmployeeCG.Enabled = False
        cbEmployeeCGView.Enabled = False
        cbEmployeeCGAdd.Enabled = False
        cbEmployeeCGEdit.Enabled = False
        cbEmployeeCGDelete.Enabled = False
        cbProductCG.Enabled = False
        cbProductCGView.Enabled = False
        cbProductCGAdd.Enabled = False
        cbProductCGEdit.Enabled = False
        cbProductCGDelete.Enabled = False
        cbOrderCG.Enabled = False
        cbOrderCGView.Enabled = False
        cbOrderCGAdd.Enabled = False
        cbOrderCGEdit.Enabled = False
        cbOrderCGDelete.Enabled = False
        cbSupplierCG.Enabled = False
        cbSupplierCGView.Enabled = False
        cbSupplierCGAdd.Enabled = False
        cbSupplierCGEdit.Enabled = False
        cbSupplierCGDelete.Enabled = False
        cbWarehouseCG.Enabled = False
        cbWarehouseCGView.Enabled = False
        cbWarehouseCGAdd.Enabled = False
        cbWarehouseCGEdit.Enabled = False
        cbWarehouseCGDelete.Enabled = False
        cbEmployeeSearch.Enabled = False
        cbEmployeeSSearch.Enabled = False
        cbEmployeeSearchExport.Enabled = False
        cbProductSearch.Enabled = False
        cbProductSSearch.Enabled = False
        cbProductSearchExport.Enabled = False
        cbOrderSearch.Enabled = False
        cbOrderSSearch.Enabled = False
        cbOrderSearchExport.Enabled = False
        cbInventoryReport.Enabled = False
        cbInventoryReportSearch.Enabled = False
        cbInventoryReportExport.Enabled = False
        cbSalesReport.Enabled = False
        cbSalesReportSearch.Enabled = False
        cbSalesReportExport.Enabled = False
        cbDecentralization.Enabled = False
        cbDecentralizationView.Enabled = False
        cbDecentralizationEdit.Enabled = False
        cbEmployeeAccountInfor.Enabled = False
        cbEmployeeAccountInforView.Enabled = False
        cbEmployeeAccountInforAdd.Enabled = False
        cbEmployeeAccountInforEdit.Enabled = False
        cbDetailWarehouseProduct.Enabled = False
        cbDetailProductView.Enabled = False
        cbDetailProductAdd.Enabled = False
        cbDetailProductEdit.Enabled = False

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
                                Case "View"
                                    cbCustomerCGView.Checked = True
                                Case "Add"
                                    cbCustomerCGAdd.Checked = True
                                Case "Edit"
                                    cbCustomerCGEdit.Checked = True
                                Case "Delete"
                                    cbCustomerCGDelete.Checked = True
                            End Select
                        Next

                    Case "Employee category"
                        cbEmployeeCG.Checked = True
                        For Each p In permiss
                            Select Case p
                                Case "View"
                                    cbEmployeeCGView.Checked = True
                                Case "Add"
                                    cbEmployeeCGAdd.Checked = True
                                Case "Edit"
                                    cbEmployeeCGEdit.Checked = True
                                Case "Delete"
                                    cbEmployeeCGDelete.Checked = True
                            End Select
                        Next
                    Case "Product category"
                        cbProductCG.Checked = True
                        For Each p In permiss
                            Select Case p
                                Case "View"
                                    cbProductCGView.Checked = True
                                Case "Add"
                                    cbProductCGAdd.Checked = True
                                Case "Edit"
                                    cbProductCGEdit.Checked = True
                                Case "Delete"
                                    cbProductCGDelete.Checked = True
                            End Select
                        Next
                    Case "Order category"
                        cbOrderCG.Checked = True
                        For Each p In permiss
                            Select Case p
                                Case "View"
                                    cbOrderCGView.Checked = True
                                Case "Add"
                                    cbOrderCGAdd.Checked = True
                                Case "Edit"
                                    cbOrderCGEdit.Checked = True
                                Case "Delete"
                                    cbOrderCGDelete.Checked = True
                            End Select
                        Next
                    Case "Supplier category"
                        cbSupplierCG.Checked = True
                        For Each p In permiss
                            Select Case p
                                Case "View"
                                    cbSupplierCGView.Checked = True
                                Case "Add"
                                    cbSupplierCGAdd.Checked = True
                                Case "Edit"
                                    cbSupplierCGEdit.Checked = True
                                Case "Delete"
                                    cbSupplierCGDelete.Checked = True
                            End Select
                        Next
                    Case "Warehouse category"
                        cbWarehouseCG.Checked = True
                        For Each p In permiss
                            Select Case p
                                Case "View"
                                    cbWarehouseCGView.Checked = True
                                Case "Add"
                                    cbWarehouseCGAdd.Checked = True
                                Case "Edit"
                                    cbWarehouseCGEdit.Checked = True
                                Case "Delete"
                                    cbWarehouseCGDelete.Checked = True
                            End Select
                        Next
                    Case "Employee search"
                        cbEmployeeSearch.Checked = True
                        For Each p In permiss
                            Select Case p
                                Case "Search"
                                    cbEmployeeSSearch.Checked = True
                                Case "Export"
                                    cbEmployeeSearchExport.Checked = True
                            End Select
                        Next
                    Case "Product search"
                        cbProductSearch.Checked = True
                        For Each p In permiss
                            Select Case p
                                Case "Search"
                                    cbProductSSearch.Checked = True
                                Case "Export"
                                    cbProductSearchExport.Checked = True
                            End Select
                        Next
                    Case "Order search"
                        cbOrderSearch.Checked = True
                        For Each p In permiss
                            Select Case p
                                Case "Search"
                                    cbOrderSSearch.Checked = True
                                Case "Export"
                                    cbOrderSearchExport.Checked = True
                            End Select
                        Next
                    Case "Inventory report"
                        cbInventoryReport.Checked = True
                        For Each p In permiss
                            Select Case p
                                Case "Search"
                                    cbInventoryReportSearch.Checked = True
                                Case "Export"
                                    cbInventoryReportExport.Checked = True
                            End Select
                        Next
                    Case "Sales report"
                        cbSalesReport.Checked = True
                        For Each p In permiss
                            Select Case p
                                Case "Search"
                                    cbSalesReportSearch.Checked = True
                                Case "Export"
                                    cbSalesReportExport.Checked = True
                            End Select
                        Next
                    Case "Decentralization"
                        cbDecentralization.Checked = True
                        For Each p In permiss
                            Select Case p
                                Case "View"
                                    cbDecentralizationView.Checked = True
                                Case "Edit"
                                    cbDecentralizationEdit.Checked = True
                            End Select
                        Next
                    Case "Employee's account information"
                        cbEmployeeAccountInfor.Checked = True
                        For Each p In permiss
                            Select Case p
                                Case "View"
                                    cbEmployeeAccountInforView.Checked = True
                                Case "Add"
                                    cbEmployeeAccountInforAdd.Checked = True
                                Case "Edit"
                                    cbEmployeeAccountInforEdit.Checked = True
                            End Select
                        Next
                    Case "Detail product of warehouse"
                        cbDetailWarehouseProduct.Checked = True
                        For Each p In permiss
                            Select Case p
                                Case "View"
                                    cbDetailProductView.Checked = True
                                Case "Add"
                                    cbDetailProductAdd.Checked = True
                                Case "Edit"
                                    cbDetailProductEdit.Checked = True
                            End Select
                        Next
                End Select
            Next
            SetEnableFalse()
        End If
    End Sub
    Private Sub ClearValue()
        cbCustomerCG.Checked = False
        cbCustomerCGView.Checked = False
        cbCustomerCGAdd.Checked = False
        cbCustomerCGEdit.Checked = False
        cbCustomerCGDelete.Checked = False
        cbEmployeeCG.Checked = False
        cbEmployeeCGView.Checked = False
        cbEmployeeCGAdd.Checked = False
        cbEmployeeCGEdit.Checked = False
        cbEmployeeCGDelete.Checked = False
        cbProductCG.Checked = False
        cbProductCGView.Checked = False
        cbProductCGAdd.Checked = False
        cbProductCGEdit.Checked = False
        cbProductCGDelete.Checked = False
        cbOrderCG.Checked = False
        cbOrderCGView.Checked = False
        cbOrderCGAdd.Checked = False
        cbOrderCGEdit.Checked = False
        cbOrderCGDelete.Checked = False
        cbSupplierCG.Checked = False
        cbSupplierCGView.Checked = False
        cbSupplierCGAdd.Checked = False
        cbSupplierCGEdit.Checked = False
        cbSupplierCGDelete.Checked = False
        cbWarehouseCG.Checked = False
        cbWarehouseCGView.Checked = False
        cbWarehouseCGAdd.Checked = False
        cbWarehouseCGEdit.Checked = False
        cbWarehouseCGDelete.Checked = False
        cbEmployeeSearch.Checked = False
        cbEmployeeSSearch.Checked = False
        cbEmployeeSearchExport.Checked = False
        cbProductSearch.Checked = False
        cbProductSSearch.Checked = False
        cbProductSearchExport.Checked = False
        cbOrderSearch.Checked = False
        cbOrderSSearch.Checked = False
        cbOrderSearchExport.Checked = False
        cbInventoryReport.Checked = False
        cbInventoryReportSearch.Checked = False
        cbInventoryReportExport.Checked = False
        cbSalesReport.Checked = False
        cbSalesReportSearch.Checked = False
        cbSalesReportExport.Checked = False
        cbDecentralization.Checked = False
        cbDecentralizationView.Checked = False
        cbDecentralizationEdit.Checked = False
        cbEmployeeAccountInfor.Checked = False
        cbEmployeeAccountInforView.Checked = False
        cbEmployeeAccountInforAdd.Checked = False
        cbEmployeeAccountInforEdit.Checked = False
        cbDetailWarehouseProduct.Checked = False
        cbDetailProductView.Checked = False
        cbDetailProductAdd.Checked = False
        cbDetailProductEdit.Checked = False
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
                MsgBox("Add new role successful!")
                isNew = True
                Reload()
                ClearValue()
                SetEnable(True)
            Else
                MsgBox("There is an error when interact with database!")
            End If
        End If
    End Sub

    Private Sub bDeleteRole_Click(sender As Object, e As EventArgs) Handles bDeleteRole.Click
        If cbbRole.Text <> "" Then
            Dim result = clsPMSAnalysis.DeleteRole(CType(cbbRole.SelectedItem, CBBItem).PropItemId, LoginForm.PropUsername)
            If result = 1 Then
                MsgBox("Delete new role successful!")
                Reload()
                SetEnable(False)
                ClearValue()
            Else
                MsgBox("There is an error when interact with database!")
            End If
        End If
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        Dim permissions = New List(Of String) From {"", "", "", "", "", "", "", "", "", "", "", "", "", ""}

        'CATEGORY
        If cbCustomerCG.Checked Then
            permissions(0) += "Customer category: " + If(cbCustomerCGView.Checked, "View, ", "") +
                If(cbCustomerCGAdd.Checked, "Add, ", "") + If(cbCustomerCGEdit.Checked, "Edit, ", "") +
                If(cbCustomerCGDelete.Checked, "Delete, ", "")
            If permissions(0) <> "" Then
                permissions(0) = permissions(0).Substring(0, permissions(0).Length - 2)
            End If
        End If

        If cbEmployeeCG.Checked Then
            permissions(1) += "Employee category: " + If(cbEmployeeCGView.Checked, "View, ", "") +
                If(cbEmployeeCGAdd.Checked, "Add, ", "") + If(cbEmployeeCGEdit.Checked, "Edit, ", "") +
                If(cbEmployeeCGDelete.Checked, "Delete, ", "")
            If permissions(1) <> "" Then
                permissions(1) = permissions(1).Substring(0, permissions(1).Length - 2)
            End If
        End If

        If cbProductCG.Checked Then
            permissions(2) += "Product category: " + If(cbProductCGView.Checked, "View, ", "") +
                If(cbProductCGAdd.Checked, "Add, ", "") + If(cbProductCGEdit.Checked, "Edit, ", "") +
                If(cbProductCGDelete.Checked, "Delete, ", "")
            If permissions(2) <> "" Then
                permissions(2) = permissions(2).Substring(0, permissions(2).Length - 2)
            End If
        End If

        If cbOrderCG.Checked Then
            permissions(3) += "Order category: " + If(cbOrderCGView.Checked, "View, ", "") +
                If(cbOrderCGAdd.Checked, "Add, ", "") + If(cbOrderCGEdit.Checked, "Edit, ", "") +
                If(cbOrderCGDelete.Checked, "Delete, ", "")
            If permissions(3) <> "" Then
                permissions(3) = permissions(3).Substring(0, permissions(3).Length - 2)
            End If
        End If

        If cbSupplierCG.Checked Then
            permissions(4) += "Supplier category: " + If(cbSupplierCGView.Checked, "View, ", "") +
                If(cbSupplierCGAdd.Checked, "Add, ", "") + If(cbSupplierCGEdit.Checked, "Edit, ", "") +
                If(cbSupplierCGDelete.Checked, "Delete, ", "")
            If permissions(4) <> "" Then
                permissions(4) = permissions(4).Substring(0, permissions(4).Length - 2)
            End If
        End If

        If cbWarehouseCG.Checked Then
            permissions(5) += "Warehouse category: " + If(cbWarehouseCGView.Checked, "View, ", "") +
                If(cbWarehouseCGAdd.Checked, "Add, ", "") + If(cbWarehouseCGEdit.Checked, "Edit, ", "") +
                If(cbWarehouseCGDelete.Checked, "Delete, ", "")
            If permissions(5) <> "" Then
                permissions(5) = permissions(5).Substring(0, permissions(5).Length - 2)
            End If
        End If

        'TOOLS 
        If cbEmployeeSearch.Checked Then
            permissions(6) += "Employee search: " + If(cbEmployeeSSearch.Checked, "Search, ", "") +
                If(cbEmployeeSearchExport.Checked, "Export, ", "")
            If permissions(6) <> "" Then
                permissions(6) = permissions(6).Substring(0, permissions(6).Length - 2)
            End If
        End If
        If cbProductSearch.Checked Then
            permissions(7) += "Product search: " + If(cbProductSSearch.Checked, "Search, ", "") +
                If(cbProductSearchExport.Checked, "Export, ", "")
            If permissions(7) <> "" Then
                permissions(7) = permissions(7).Substring(0, permissions(7).Length - 2)
            End If
        End If
        If cbOrderSearch.Checked Then
            permissions(8) += "Order search: " + If(cbOrderSSearch.Checked, "Search, ", "") +
                If(cbOrderSearchExport.Checked, "Export, ", "")
            If permissions(8) <> "" Then
                permissions(8) = permissions(8).Substring(0, permissions(8).Length - 2)
            End If
        End If

        'STATISTIC
        If cbInventoryReport.Checked Then
            permissions(9) += "Inventory report: " + If(cbInventoryReportSearch.Checked, "Search, ", "") +
                If(cbInventoryReportExport.Checked, "Export, ", "")
            If permissions(9) <> "" Then
                permissions(9) = permissions(9).Substring(0, permissions(9).Length - 2)
            End If
        End If
        If cbSalesReport.Checked Then
            permissions(10) += "Sales report: " + If(cbSalesReportSearch.Checked, "Search, ", "") +
                If(cbSalesReportExport.Checked, "Export, ", "")
            If permissions(10) <> "" Then
                permissions(10) = permissions(10).Substring(0, permissions(10).Length - 2)
            End If
        End If

        'OTHERS
        If cbDecentralization.Checked Then
            permissions(11) += "Decentralization: " + If(cbDecentralizationView.Checked, "View, ", "") +
                If(cbDecentralizationEdit.Checked, "Edit, ", "")
            If permissions(11) <> "" Then
                permissions(11) = permissions(11).Substring(0, permissions(11).Length - 2)
            End If
        End If
        If cbEmployeeAccountInfor.Checked Then
            permissions(12) += "Employee's account information: " + If(cbEmployeeAccountInforView.Checked, "View, ", "") +
                If(cbEmployeeAccountInforAdd.Checked, "Add, ", "") +
                If(cbEmployeeAccountInforEdit.Checked, "Edit, ", "")
            If permissions(12) <> "" Then
                permissions(12) = permissions(12).Substring(0, permissions(12).Length - 2)
            End If
        End If
        If cbDetailWarehouseProduct.Checked Then
            permissions(13) += "Detail product of warehouse: " + If(cbDetailProductView.Checked, "View, ", "") +
                If(cbDetailProductAdd.Checked, "Add, ", "") + If(cbDetailProductEdit.Checked, "Edit, ", "")
            If permissions(13) <> "" Then
                permissions(13) = permissions(13).Substring(0, permissions(13).Length - 2)
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
            MsgBox(type & " permission information successful!")
            Reload()
            isNew = False
        Else
            MsgBox("There is an error when interact with database!")
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
        cbCustomerCGView.Checked = True
        cbCustomerCGAdd.Enabled = val
        cbCustomerCGEdit.Enabled = val
        cbCustomerCGDelete.Enabled = val
    End Sub

    Private Sub cbEmployeeCG_CheckedChanged(sender As Object, e As EventArgs) Handles cbEmployeeCG.CheckedChanged
        Dim val = cbEmployeeCG.Checked
        cbEmployeeCGView.Checked = True
        cbEmployeeCGAdd.Enabled = val
        cbEmployeeCGEdit.Enabled = val
        cbEmployeeCGDelete.Enabled = val
    End Sub

    Private Sub cbProductCG_CheckedChanged(sender As Object, e As EventArgs) Handles cbProductCG.CheckedChanged
        Dim val = cbProductCG.Checked
        cbProductCGView.Checked = True
        cbProductCGAdd.Enabled = val
        cbProductCGEdit.Enabled = val
        cbProductCGDelete.Enabled = val
    End Sub

    Private Sub cbOrderCG_CheckedChanged(sender As Object, e As EventArgs) Handles cbOrderCG.CheckedChanged
        Dim val = cbOrderCG.Checked
        cbOrderCGView.Checked = True
        cbOrderCGAdd.Enabled = val
        cbOrderCGEdit.Enabled = val
        cbOrderCGDelete.Enabled = val
    End Sub

    Private Sub cbSupplierCG_CheckedChanged(sender As Object, e As EventArgs) Handles cbSupplierCG.CheckedChanged
        Dim val = cbSupplierCG.Checked
        cbSupplierCGView.Checked = True
        cbSupplierCGAdd.Enabled = val
        cbSupplierCGEdit.Enabled = val
        cbSupplierCGDelete.Enabled = val
    End Sub

    Private Sub cbWarehouseCG_CheckedChanged(sender As Object, e As EventArgs) Handles cbWarehouseCG.CheckedChanged
        Dim val = cbWarehouseCG.Checked
        cbWarehouseCGView.Checked = True
        cbWarehouseCGAdd.Enabled = val
        cbWarehouseCGEdit.Enabled = val
        cbWarehouseCGDelete.Enabled = val
    End Sub

    Private Sub cbEmployeeSearch_CheckedChanged(sender As Object, e As EventArgs) Handles cbEmployeeSearch.CheckedChanged
        Dim val = cbEmployeeSearch.Checked
        cbEmployeeSSearch.Checked = True
        cbEmployeeSearchExport.Enabled = val
    End Sub

    Private Sub cbProductSearch_CheckedChanged(sender As Object, e As EventArgs) Handles cbProductSearch.CheckedChanged
        Dim val = cbProductSearch.Checked
        cbProductSSearch.Checked = True
        cbProductSearchExport.Enabled = val
    End Sub

    Private Sub cbOrderSearch_CheckedChanged(sender As Object, e As EventArgs) Handles cbOrderSearch.CheckedChanged
        Dim val = cbOrderSearch.Checked
        cbOrderSSearch.Checked = True
        cbOrderSearchExport.Enabled = val
    End Sub

    Private Sub cbInventoryReport_CheckedChanged(sender As Object, e As EventArgs) Handles cbInventoryReport.CheckedChanged
        Dim val = cbInventoryReport.Checked
        cbInventoryReportSearch.Checked = True
        cbInventoryReportExport.Enabled = val
    End Sub

    Private Sub cbSalesReport_CheckedChanged(sender As Object, e As EventArgs) Handles cbSalesReport.CheckedChanged
        Dim val = cbSalesReport.Checked
        cbSalesReportSearch.Checked = True
        cbSalesReportExport.Enabled = val
    End Sub

    Private Sub cbDecentralization_CheckedChanged(sender As Object, e As EventArgs) Handles cbDecentralization.CheckedChanged
        Dim val = cbDecentralization.Checked
        cbDecentralizationView.Checked = True
        cbDecentralizationEdit.Enabled = val
    End Sub

    Private Sub cbEmployeeAccountInfor_CheckedChanged(sender As Object, e As EventArgs) Handles cbEmployeeAccountInfor.CheckedChanged
        Dim val = cbEmployeeAccountInfor.Checked
        cbEmployeeAccountInforView.Checked = True
        cbEmployeeAccountInforAdd.Enabled = val
        cbEmployeeAccountInforEdit.Enabled = val
    End Sub

    Private Sub cbDetailWarehouseProduct_CheckedChanged(sender As Object, e As EventArgs) Handles cbDetailWarehouseProduct.CheckedChanged
        Dim val = cbDetailWarehouseProduct.Checked
        cbDetailProductView.Checked = True
        cbDetailProductAdd.Enabled = val
        cbDetailProductEdit.Enabled = val
    End Sub
End Class