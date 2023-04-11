Imports LibraryDataset
Imports LibraryCommon
Public Class OrderSearch
    Dim conn As New connCommon()
    Dim clsOrderDetail As New clsOrderDetail(conn.connSales.ConnectionString)
    Dim clsCBB As New clsCBB(conn.connSales.ConnectionString)
    Private Sub OrderSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbSearchByDate.Checked = False

        Dim dataShipper = clsCBB.GetCBBShipper().CBBPerson
        Dim dataStatus = clsCBB.GetCBBStatusOfOrder().CBBStatus

        cbbShipper.Items.Clear()
        cbbShipStatus.Items.Clear()

        For Each row As DataRow In dataShipper.Rows
            cbbShipper.Items.Add(New CBBPerson(row(0), row(1)))
        Next
        For Each row As DataRow In dataStatus.Rows
            cbbShipStatus.Items.Add(New CBBItem(row(0), row(1)))
        Next
    End Sub

    Private Sub cbSearchByDate_CheckedChanged(sender As Object, e As EventArgs) Handles cbSearchByDate.CheckedChanged
        dtOrderDate.Enabled = cbSearchByDate.Checked
        dtShipDate.Enabled = cbSearchByDate.Checked
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim shipperId = Nothing
        If cbbShipper.SelectedItem IsNot Nothing Then
            shipperId = CType(cbbShipper.SelectedItem, CBBPerson).PropItemId
        End If
        Dim statusId = -1
        If cbbShipStatus.SelectedItem IsNot Nothing Then
            statusId = CType(cbbShipStatus.SelectedItem, CBBItem).PropItemId
        End If
        dgvOrderSearch.DataSource = clsOrderDetail.SearchOrder(txtOrderCode.Text, txtCustomerName.Text, dtOrderDate.Value,
                                        shipperId, dtShipDate.Value, txtShipAddress.Text,
                                        statusId, txtPaymentMethod.Text, cbSearchByDate.Checked)
    End Sub
End Class