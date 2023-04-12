Imports LibraryCommon
Imports LibraryDataset
Public Class MainForm
    Private conn As New connCommon()
    Private clsPerson As New clsPerson(conn.connSales.ConnectionString)
    Private f As Form = Nothing
    Private userWantLogout = False
    Private Sub btnCategoryCustomer_Click(sender As Object, e As EventArgs) Handles btnCategoryCustomer.Click
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

    Private Sub productToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles productToolStripMenuItem.Click
        Dim frmProduct As New ProductCategory
        ShowForm(frmProduct)
    End Sub

    Private Sub orderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles orderToolStripMenuItem.Click
        Dim frmSalesOrder As New SalesOrder
        ShowForm(frmSalesOrder)
    End Sub

    Private Sub inventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Dim frmWarehouseReport As New WarehouseReport
        ShowForm(frmWarehouseReport)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowForm(Nothing)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ShowForm(Nothing)
    End Sub

    Private Sub btnSearchOrder_Click(sender As Object, e As EventArgs) Handles btnSearchOrder.Click
        ShowForm(New OrderSearch)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        userWantLogout = True
        Me.Close()
        LoginForm.Show()
    End Sub
End Class