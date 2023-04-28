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
        cbCustomerCGView.Enabled = valBoolean
        cbCustomerCGAdd.Enabled = valBoolean
        cbCustomerCGEdit.Enabled = valBoolean
        cbCustomerCGDelete.Enabled = valBoolean
        cbEmployeeCG.Enabled = valBoolean
        cbEmployeeCGView.Enabled = valBoolean
        cbEmployeeCGAdd.Enabled = valBoolean
        cbEmployeeCGEdit.Enabled = valBoolean
        cbEmployeeCGDelete.Enabled = valBoolean
        cbProductCG.Enabled = valBoolean
        cbProductCGView.Enabled = valBoolean
        cbProductCGAdd.Enabled = valBoolean
        cbProductCGEdit.Enabled = valBoolean
        cbProductCGDelete.Enabled = valBoolean
        cbOrderCG.Enabled = valBoolean
        cbOrderCGView.Enabled = valBoolean
        cbOrderCGAdd.Enabled = valBoolean
        cbOrderCGEdit.Enabled = valBoolean
        cbOrderCGDelete.Enabled = valBoolean
        cbSupplierCG.Enabled = valBoolean
        cbSupplierCGView.Enabled = valBoolean
        cbSupplierCGAdd.Enabled = valBoolean
        cbSupplierCGEdit.Enabled = valBoolean
        cbSupplierCGDelete.Enabled = valBoolean
        cbWarehouseCG.Enabled = valBoolean
        cbWarehouseCGView.Enabled = valBoolean
        cbWarehouseCGAdd.Enabled = valBoolean
        cbWarehouseCGEdit.Enabled = valBoolean
        cbWarehouseCGDelete.Enabled = valBoolean
        cbEmployeeSearch.Enabled = valBoolean
        cbEmployeeSSearch.Enabled = valBoolean
        cbEmployeeSearchExport.Enabled = valBoolean
        cbProductSearch.Enabled = valBoolean
        cbProductSSearch.Enabled = valBoolean
        cbProductSearchExport.Enabled = valBoolean
        cbOrderSearch.Enabled = valBoolean
        cbOrderSSearch.Enabled = valBoolean
        cbOrderSearchExport.Enabled = valBoolean
        cbInventoryReport.Enabled = valBoolean
        cbInventoryReportSearch.Enabled = valBoolean
        cbInventoryReportExport.Enabled = valBoolean
        cbSalesReport.Enabled = valBoolean
        cbSalesReportSearch.Enabled = valBoolean
        cbSalesReportReport.Enabled = valBoolean
        cbDecentralization.Enabled = valBoolean
        cbDecentralizationView.Enabled = valBoolean
        cbDecentralizationEdit.Enabled = valBoolean
        cbEmployeeAccountInfor.Enabled = valBoolean
        cbEmployeeAccountInforView.Enabled = valBoolean
        cbEmployeeAccountInforAdd.Enabled = valBoolean
        cbEmployeeAccountInforEdit.Enabled = valBoolean
        cbDetailWarehouseProduct.Enabled = valBoolean
        cbDetailProductView.Enabled = valBoolean
        cbDetailProductAdd.Enabled = valBoolean
        cbDetailProductEdit.Enabled = valBoolean
    End Sub

    Private Sub SetValue()
        Dim dataPermission = clsPMSAnalysis.get
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
        cbSalesReportReport.Checked = False
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

        cbbRole.Items.Clear()
        For Each role In dataRole
            cbbRole.Items.Add(New CBBItem(role(0), role(1)))
        Next

    End Sub

    Private Sub bNewRole_Click(sender As Object, e As EventArgs) Handles bNewRole.Click
        Dim roleName = InputBox("Let's enter new role's name:", "Create new role")
        If roleName <> "" Then
            Dim result = clsPMSAnalysis.AddRole(roleName, LoginForm.PropUsername)
            If result = 1 Then
                MsgBox("Add new role successful!")
                isNew = True
                Reload()
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
            Else
                MsgBox("There is an error when interact with database!")
            End If
        End If
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        Dim permissions = New List(Of String) From {"", "", "", "", "", "", "", "", "", "", "", "", "", ""}

        'CATEGORY
        If cbCustomerCG.Checked Then
            permissions(0) += "Customer category: " + If(cbCustomerCGView.Checked, "View, ", ", ") +
                If(cbCustomerCGAdd.Checked, "Add, ", ", ") + If(cbCustomerCGEdit.Checked, "Edit, ", ", ") +
                If(cbCustomerCGDelete.Checked, "Delete", "")
        End If

        If cbEmployeeCG.Checked Then
            permissions(1) += "Employee category: " + If(cbEmployeeCGView.Checked, "View, ", ", ") +
                If(cbEmployeeCGAdd.Checked, "Add, ", ", ") + If(cbEmployeeCGEdit.Checked, "Edit, ", ", ") +
                If(cbEmployeeCGDelete.Checked, "Delete", "")
        End If

        If cbProductCG.Checked Then
            permissions(2) += "Product category: " + If(cbProductCGView.Checked, "View, ", ", ") +
                If(cbProductCGAdd.Checked, "Add, ", ", ") + If(cbProductCGEdit.Checked, "Edit, ", ", ") +
                If(cbProductCGDelete.Checked, "Delete", "")
        End If

        If cbOrderCG.Checked Then
            permissions(3) += "Customer category: " + If(cbOrderCGView.Checked, "View, ", ", ") +
                If(cbOrderCGAdd.Checked, "Add, ", ", ") + If(cbOrderCGEdit.Checked, "Edit, ", ", ") +
                If(cbOrderCGDelete.Checked, "Delete", "")
        End If

        If cbSupplierCG.Checked Then
            permissions(4) += "Supplier category: " + If(cbSupplierCGView.Checked, "View, ", ", ") +
                If(cbSupplierCGAdd.Checked, "Add, ", ", ") + If(cbSupplierCGEdit.Checked, "Edit, ", ", ") +
                If(cbSupplierCGDelete.Checked, "Delete", "")
        End If

        If cbWarehouseCG.Checked Then
            permissions(5) += "Warehouse category: " + If(cbWarehouseCGView.Checked, "View, ", ", ") +
                If(cbWarehouseCGAdd.Checked, "Add, ", ", ") + If(cbWarehouseCGEdit.Checked, "Edit, ", ", ") +
                If(cbWarehouseCGDelete.Checked, "Delete", "")
        End If

        'TOOLS 
        If cbEmployeeSearch.Checked Then
            permissions(6) += "Employee search: " + If(cbEmployeeSSearch.Checked, "Search, ", ", ") +
                If(cbEmployeeSearchExport.Checked, "Export", "")
        End If
        If cbProductSearch.Checked Then
            permissions(7) += "Product search: " + If(cbProductSSearch.Checked, "Search, ", ", ") +
                If(cbProductSearchExport.Checked, "Export", "")
        End If
        If cbOrderSearch.Checked Then
            permissions(8) += "Order search: " + If(cbOrderSSearch.Checked, "Search, ", ", ") +
                If(cbOrderSearchExport.Checked, "Export", "")
        End If

        'STATISTIC
        If cbInventoryReport.Checked Then
            permissions(9) += "Inventory report: " + If(cbInventoryReportSearch.Checked, "Search, ", ", ") +
                If(cbInventoryReportExport.Checked, "Export", "")
        End If
        If cbSalesReport.Checked Then
            permissions(10) += "Sales report: " + If(cbSalesReportSearch.Checked, "Search, ", ", ") +
                If(cbSalesReportReport.Checked, "Export", "")
        End If

        'OTHERS
        If cbDecentralization.Checked Then
            permissions(11) += "Decentralization: " + If(cbDecentralizationView.Checked, "View, ", ", ") +
                If(cbDecentralizationEdit.Checked, "Edit", "")
        End If
        If cbEmployeeAccountInfor.Checked Then
            permissions(12) += "Employee's account information: " + If(cbEmployeeAccountInforView.Checked, "View, ", ", ") +
                +If(cbEmployeeAccountInforAdd.Checked, "Add, ", ", ") +
                If(cbEmployeeAccountInforEdit.Checked, "Edit", "")
        End If
        If cbDetailWarehouseProduct.Checked Then
            permissions(13) += "Detail product of warehouse: " + If(cbDetailProductView.Checked, "View, ", ", ") +
                If(cbDetailProductAdd.Checked, "Add, ", ", ") + If(cbDetailProductEdit.Checked, "Edit, ", ", ")
        End If

        Dim type = ""
        Dim result = 1
        If isNew Then
            For Each permission In permissions
                MsgBox(permission)
                MsgBox(result)
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
            result = clsPMSAnalysis.DeleteRolePermisisonByRole(CType(cbbRole.SelectedItem, CBBItem).PropItemId)
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

        If result = 1 Then
            SetEnable(False)
            MsgBox(type & " product information successful!")
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
        setValue()
    End Sub
End Class