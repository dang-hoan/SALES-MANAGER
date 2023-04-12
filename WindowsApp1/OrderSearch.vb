Imports LibraryDataset
Imports LibraryCommon
Public Class OrderSearch
    Dim conn As New connCommon()
    Dim clsOrderDetail As New clsOrderDetail(conn.connSales.ConnectionString)
    Dim clsCBB As New clsCBB(conn.connSales.ConnectionString)
    Private Sub OrderSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbSearchByOrderDate.Checked = False

        Dim dataShipper = clsCBB.GetCBBShipper().CBBPerson
        Dim dataStatus = clsCBB.GetCBBStatusOfOrder().CBBStatus

        cbbShipper.Items.Clear()
        cbbShipStatus.Items.Clear()

        cbbShipper.Items.Add("")
        cbbShipStatus.Items.Add("")

        For Each row As DataRow In dataShipper.Rows
            cbbShipper.Items.Add(New CBBPerson(row(0), row(1)))
        Next
        For Each row As DataRow In dataStatus.Rows
            cbbShipStatus.Items.Add(New CBBItem(row(0), row(1)))
        Next
    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If checkLogicData() Then
            Dim code = -1
            If txtOrderCode.Text <> "" Then
                code = txtOrderCode.Text
            End If
            Dim shipperId = Nothing
            If cbbShipper.SelectedItem IsNot Nothing And cbbShipper.Text <> "" Then
                shipperId = CType(cbbShipper.SelectedItem, CBBPerson).PropItemId
            End If
            Dim statusId = -1
            If cbbShipStatus.SelectedItem IsNot Nothing And cbbShipStatus.Text <> "" Then
                statusId = CType(cbbShipStatus.SelectedItem, CBBItem).PropItemId
            End If

            dgvOrderSearch.DataSource = clsOrderDetail.SearchOrder(code, txtCustomerName.Text, dtOrderDate.Value,
                                            shipperId, dtShipDate.Value, txtShipAddress.Text,
                                            statusId, txtPaymentMethod.Text, cbSearchByOrderDate.Checked, cbSearchByShipDate.Checked)

        End If

    End Sub
    Private Function checkLogicData() As Boolean
        If Not checkNumber(txtOrderCode.Text) Then
            MsgBox("Ordercode must be a number (>=0)!")
            Return False
        End If
        Return True
    End Function

    Private Function checkNumber(ByVal phone As String)
        For Each c As Char In phone
            If Asc(c) > 57 Or Asc(c) < 48 Then
                Return False
            End If
        Next

        Return True
    End Function
    Private Sub cbSearchByOrderDate_CheckedChanged(sender As Object, e As EventArgs) Handles cbSearchByOrderDate.CheckedChanged
        dtOrderDate.Enabled = cbSearchByOrderDate.Checked
    End Sub

    Private Sub cbSearchByShipDate_CheckedChanged(sender As Object, e As EventArgs) Handles cbSearchByShipDate.CheckedChanged
        dtShipDate.Enabled = cbSearchByShipDate.Checked
    End Sub
End Class