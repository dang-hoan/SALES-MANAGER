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
        If Not CheckValue("Code", txtOrderCode.Text, "Long") Then
            Return False
        End If
        Return True
    End Function

    Private Function CheckValue(ByVal label As String, ByVal value As String, ByVal style As String) As Boolean
        Dim returnVal = True

        If value.Length = 0 Then
            Return True
        End If

        Select Case style
            Case "Long"
                Dim Number As Long
                Try
                    Number = Long.Parse(value)
                Catch ex As FormatException
                    MsgBox(label & " must be a integer number!")
                    returnVal = False
                Catch ex As OverflowException
                    MsgBox(label & " is too big to handle!")
                    returnVal = False
                End Try

            Case "Double"
                Dim Number As Double
                Try
                    Number = Double.Parse(value)
                Catch ex As FormatException
                    MsgBox(label & " must be a number!")
                    returnVal = False
                Catch ex As OverflowException
                    MsgBox(label & " is too big to handle!")
                    returnVal = False
                End Try

        End Select

        Return returnVal

    End Function
    Private Sub cbSearchByOrderDate_CheckedChanged(sender As Object, e As EventArgs) Handles cbSearchByOrderDate.CheckedChanged
        dtOrderDate.Enabled = cbSearchByOrderDate.Checked
    End Sub

    Private Sub cbSearchByShipDate_CheckedChanged(sender As Object, e As EventArgs) Handles cbSearchByShipDate.CheckedChanged
        dtShipDate.Enabled = cbSearchByShipDate.Checked
    End Sub
End Class