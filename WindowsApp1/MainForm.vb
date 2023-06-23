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

    Public Sub SetVisibleForPermission()
        bCustomer.Visible = False
        bEmployee.Visible = False
        bProduct.Visible = False
        bOrder.Visible = False
        bSupplier.Visible = False
        bWarehouse.Visible = False

        bCategory.Visible = False
        bDecentralize.Visible = False
        bStatistic.Visible = False

        Dim count As Integer = 0        'SubMenu number of Category menu
        Dim dataPermission = clsRolePermission.GetPermissionOfUser(LoginForm.PropUsername)
        For Each permission In dataPermission
            Dim form = permission(1).split(": ")(0)
            Select Case form
                Case "Customer category"
                    bCustomer.Visible = True
                    count += 1
                Case "Employee category"
                    bEmployee.Visible = True
                    count += 1
                Case "Product category"
                    bProduct.Visible = True
                    count += 1
                Case "Order category"
                    bOrder.Visible = True
                    count += 1
                Case "Supplier category"
                    bSupplier.Visible = True
                    count += 1
                Case "Warehouse category"
                    bWarehouse.Visible = True
                    count += 1
                Case "Decentralization"
                    bDecentralize.Visible = True
                Case "Warehouse report"
                    bStatistic.Visible = True
            End Select
        Next
        If count > 0 Then
            bCategory.Visible = True
        End If
    End Sub
    Private Sub bCustomer_Click(sender As Object, e As EventArgs) Handles bCustomer.Click
        Dim frmCustomer As New CustomerCategory
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

    Private Sub bProduct_Click(sender As Object, e As EventArgs) Handles bProduct.Click
        Dim frmProduct As New ProductCategory
        ShowForm(frmProduct)
    End Sub

    Private Sub bOrder_Click(sender As Object, e As EventArgs) Handles bOrder.Click
        Dim frmSalesOrder As New SalesOrderCategory
        ShowForm(frmSalesOrder)
    End Sub

    Private Sub bStatistic_Click(sender As Object, e As EventArgs) Handles bStatistic.Click
        Dim frmWarehouseReport As New WarehouseReport
        ShowForm(frmWarehouseReport)
    End Sub

    Private Sub bHome_Click(sender As Object, e As EventArgs) Handles bHome.Click
        ShowForm(Nothing)
    End Sub

    Private Sub bExit_Click(sender As Object, e As EventArgs) Handles bExit.Click
        userWantLogout = True
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub bWarehouse_Click(sender As Object, e As EventArgs) Handles bWarehouse.Click
        ShowForm(New WarehouseCategory)
    End Sub

    Private Sub bSupplier_Click(sender As Object, e As EventArgs) Handles bSupplier.Click
        ShowForm(New SupplierCategory)
    End Sub

    Private Sub bEmployee_Click(sender As Object, e As EventArgs) Handles bEmployee.Click
        ShowForm(New EmployeeCategory)
    End Sub

    Private Sub bDecentralize_Click(sender As Object, e As EventArgs) Handles bDecentralize.Click
        ShowForm(New DecentralizationForm)
    End Sub
End Class