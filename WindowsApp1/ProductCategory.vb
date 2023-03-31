Imports LibraryDataset
Imports LibraryCommon
Public Class ProductCategory
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsProduct(conn.connSales.ConnectionString)
    Private Sub CustomerCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data = clsPMSAnalysis.GetAllProduct()
        dgvCategory.DataSource = data._Product

    End Sub

    Private Sub bEdit_Click(sender As Object, e As EventArgs) Handles bEdit.Click
        setEnable(True)
    End Sub

    Private Sub setEnable(valBoolean As Boolean)
        txtCode.Enabled = valBoolean
        txtName.Enabled = valBoolean
        cbbCategory.Enabled = valBoolean
        txtPrice.Enabled = valBoolean
        txtUnitPrice.Enabled = valBoolean
        txtStatus.Enabled = valBoolean
        txtDiscount.Enabled = valBoolean
    End Sub

    Private Sub bAdd_Click(sender As Object, e As EventArgs) Handles bAdd.Click

    End Sub

    Private Sub dgvCategory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategory.CellClick
        'Dim dgv As sender As DataGridView
        Dim row As DataGridViewRow = dgvCategory.CurrentRow
        If dgvCategory Is Nothing Then
            Return
        Else
            txtCode.Text = row.Cells(0).Value.ToString
            txtName.Text = row.Cells(1).Value.ToString
            cbbCategory.Text = row.Cells(3).Value.ToString
            txtPrice.Text = row.Cells(4).Value.ToString
            txtUnitPrice.Text = row.Cells(5).Value.ToString
            txtStatus.Text = row.Cells(6).Value.ToString
            txtDiscount.Text = row.Cells(7).Value.ToString
        End If
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        setEnable(False)
    End Sub
End Class