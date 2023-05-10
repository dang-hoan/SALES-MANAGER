Imports LibraryCommon
Imports LibraryDataset
Public Class MainForm
    Private conn As New connCommon()
    Private clsPerson As New clsPerson(conn.connSales.ConnectionString)
    Private clsRolePermission As New clsRolePermission(conn.connSales.ConnectionString)

    Private f As Form = Nothing
    Private userWantLogout = False

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowForm(Nothing)
        SetVisibleForPermission()
    End Sub

    Private Sub SetVisibleForPermission()
        btnCustomer.Visible = False
        btnEmployee.Visible = False
        btnProduct.Visible = False
        btnOrder.Visible = False
        btnSupplier.Visible = False
        btnWarehouse.Visible = False
        btnEmployeeSearch.Visible = False
        btnProductSearch.Visible = False
        btnOrderSearch.Visible = False
        btnWarehouseReport.Visible = False
        btnSalesReport.Visible = False
        btnDecentralization.Visible = False
        Dim listNumber As New List(Of Integer) From {0, 0, 0, 0}        'Category, Search, Statistic, Tool
        Dim dataPermission = clsRolePermission.GetPermissionOfUser(LoginForm.PropUsername)
        For Each permission In dataPermission
            Dim form = permission(1).split(":")(0)
            Select Case form
                Case "Customer category"
                    btnCustomer.Visible = True
                    listNumber(0) += 1
                Case "Employee category"
                    btnEmployee.Visible = True
                    listNumber(0) += 1
                Case "Product category"
                    btnProduct.Visible = True
                    listNumber(0) += 1
                Case "Order category"
                    btnOrder.Visible = True
                    listNumber(0) += 1
                Case "Supplier category"
                    btnSupplier.Visible = True
                    listNumber(0) += 1
                Case "Warehouse category"
                    btnWarehouse.Visible = True
                    listNumber(0) += 1
                Case "Employee search"
                    btnEmployeeSearch.Visible = True
                    listNumber(1) += 1
                Case "Product search"
                    btnProductSearch.Visible = True
                    listNumber(1) += 1
                Case "Order search"
                    btnOrderSearch.Visible = True
                    listNumber(1) += 1
                Case "Inventory report"
                    btnWarehouseReport.Visible = True
                    listNumber(2) += 1
                Case "Sales report"
                    btnSalesReport.Visible = True
                    listNumber(2) += 1
                Case "Decentralization"
                    btnDecentralization.Visible = True
                    listNumber(3) += 1
            End Select
        Next
        If listNumber(0) = 0 Then
            btnCategory.Visible = False
        End If
        If listNumber(1) = 0 Then
            btnSearch.Visible = False
        End If
        If listNumber(2) = 0 Then
            btnStatistic.Visible = False
        End If
        If listNumber(3) = 0 And listNumber(1) = 0 Then
            btnTool.Visible = False
        End If
    End Sub
    Private Sub btnCategoryCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Dim frmCustomer As New frmCustomerCategory
        ShowForm(frmCustomer)
    End Sub

    Private Sub ShowForm(subForm As Form)
        If subForm Is Nothing Then
            labHello.Text = "Hello " + clsPerson.GetName(LoginForm.PropUsername)
            panelWelcome.Visible = True
            Exit Sub
        Else
            panelWelcome.Visible = False
        End If

        If f IsNot Nothing Then f.Close()
        f = subForm

        subForm.TopLevel = False
        subForm.FormBorderStyle = FormBorderStyle.None
        subForm.Dock = DockStyle.Fill
        srcMain.Controls.Add(subForm)
        srcMain.Tag = subForm
        subForm.Show()
    End Sub

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If Not userWantLogout Then
            Application.Exit()
        End If
    End Sub

    Private Sub productToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        Dim frmProduct As New ProductCategory
        ShowForm(frmProduct)
    End Sub

    Private Sub orderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Dim frmSalesOrder As New SalesOrder
        ShowForm(frmSalesOrder)
    End Sub

    Private Sub inventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnWarehouseReport.Click
        Dim frmWarehouseReport As New WarehouseReport
        ShowForm(frmWarehouseReport)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ShowForm(Nothing)
    End Sub

    Private Sub btnSearchOrder_Click(sender As Object, e As EventArgs) Handles btnOrderSearch.Click
        ShowForm(New OrderSearch)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        userWantLogout = True
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub btnProductSearch_Click(sender As Object, e As EventArgs) Handles btnProductSearch.Click
        ShowForm(New ProductSearch)
    End Sub

    Private Sub btnWarehouseCategory_Click(sender As Object, e As EventArgs) Handles btnWarehouse.Click
        ShowForm(New WarehouseCategory)
    End Sub

    Private Sub bSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        ShowForm(New SupplierCategory)
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        ShowForm(New EmployeeCategory)
    End Sub

    Private Sub btnDecentralization_Click(sender As Object, e As EventArgs) Handles btnDecentralization.Click
        ShowForm(New DecentralizationForm)
    End Sub
End Class