Imports LibraryDataset
Imports LibraryCommon
Public Class SalesOrder
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsOrderDetail(conn.connSales.ConnectionString)
    Private Sub dgvOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data = clsPMSAnalysis.GetAllSaleOrders()
        dgvOrder.DataSource = data.SalesOrder
        setEnable(False)
    End Sub
    Private Sub bEdit_Click(sender As Object, e As EventArgs) Handles bEdit.Click
        setEnable(True)
    End Sub
    Private Sub setEnable(valBoolean As Boolean)
        txtCustomerName.Enabled = valBoolean
        dtOrderDate.Enabled = valBoolean
        dtShipDate.Enabled = valBoolean
        txtShipAddress.Enabled = valBoolean
        cbbShipStatus.Enabled = valBoolean
        txtProductName.Enabled = valBoolean
        txtProductPrice.Enabled = valBoolean
        cbbNumber.Enabled = valBoolean
        txtDiscount.Enabled = valBoolean
        txtTotalPrice.Enabled = valBoolean
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        setEnable(False)
    End Sub

    Private Sub dgvOrder_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrder.CellClick
        If dgvOrder Is Nothing Then
            Return
        Else
            Dim row As DataGridViewRow = dgvOrder.CurrentRow
            txtOrderCode.Text = row.Cells(0).Value.ToString
            txtCustomerCode.Text = row.Cells(1).Value.ToString
            dtOrderDate.Text = row.Cells(2).Value.ToString
            dtShipDate.Text = row.Cells(3).Value.ToString
            txtShipAddress.Text = row.Cells(4).Value.ToString
            cbbShipStatus.Text = row.Cells(5).Value.ToString
            cbbNumber.Text = row.Cells(6).Value.ToString
            txtTotalPrice.Text = row.Cells(8).Value.ToString
            'txtCustomerName.Text = row.Cells(9).Value.ToString
            cbbProductCode.Text = row.Cells(11).Value.ToString
            txtProductName.Text = row.Cells(12).Value.ToString
            txtProductPrice.Text = row.Cells(13).Value.ToString
            txtDiscount.Text = row.Cells(15).Value.ToString
            cbbEmployeeCode.Text = row.Cells(18).Value.ToString
        End If
    End Sub


End Class