Imports LibraryDataset
Imports LibraryCommon
Public Class WarehouseCategory
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsWarehouse(conn.connSales.ConnectionString)
    Private Sub WarehouseCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub Reload()
        dgvCategory.DataSource = clsPMSAnalysis.GetWarehouse()
        setEnable(False)
        setValue()
    End Sub

    Private Sub setValue()
        If dgvCategory Is Nothing Then
            Return
        Else
            Dim row As DataGridViewRow = dgvCategory.CurrentRow
            txtCode.Text = row.Cells(0).Value.ToString
            txtName.Text = row.Cells(1).Value.ToString
            txtAddress.Text = row.Cells(2).Value.ToString
            txtTotal.Text = row.Cells(3).Value.ToString
            txtNumberOfImport.Text = row.Cells(4).Value.ToString
            txtNumberOfExport.Text = row.Cells(5).Value.ToString

        End If
    End Sub

    Private Sub bEdit_Click(sender As Object, e As EventArgs) Handles bEdit.Click
        setEnable(True)
    End Sub

    Private Sub setEnable(valBoolean As Boolean)
        txtCode.Enabled = valBoolean
        txtName.Enabled = valBoolean
        txtAddress.Enabled = valBoolean
        txtTotal.Enabled = valBoolean
        txtNumberOfImport.Enabled = valBoolean
        txtNumberOfExport.Enabled = valBoolean
    End Sub

    Private Sub clearValue()
        txtCode.Text = ""
        txtName.Text = ""
        txtAddress.Text = ""
        txtTotal.Text = ""
        txtNumberOfImport.Text = ""
        txtNumberOfExport.Text = ""
    End Sub

    Private Sub bAdd_Click(sender As Object, e As EventArgs) Handles bAdd.Click
        clearValue()
        setEnable(True)
    End Sub

    Private Sub dgvCategory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategory.CellClick
        setEnable(False)
        setValue()
    End Sub
End Class