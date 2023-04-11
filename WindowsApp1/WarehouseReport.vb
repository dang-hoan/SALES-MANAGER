Imports LibraryDataset
Imports LibraryCommon

Public Class WarehouseReport
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsCBB(conn.connSales.ConnectionString)
    Dim clsOrderDetail As New clsOrderDetail(conn.connSales.ConnectionString)

    Private Sub WarehouseReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataProduct = clsPMSAnalysis.GetCBBProduct().CBBProduct
        Dim dataWareHouse = clsPMSAnalysis.GetCBBWareHouse().CBBWareHouse

        cbbWarehouse.Items.Clear()
        cbbProduct.Items.Clear()

        cbbWarehouse.Items.Add("")
        cbbProduct.Items.Add("")
        For Each row As DataRow In dataWareHouse.Rows
            cbbWarehouse.Items.Add(New CBBItem(row(0), row(1)))
        Next

        For Each row As DataRow In dataProduct.Rows
            cbbProduct.Items.Add(New CBBItem(row(0), row(1)))
        Next

        GetValue()

    End Sub

    Private Sub cbbWarehouse_Click(sender As Object, e As EventArgs) Handles cbbWarehouse.Click
        Dim warehouseId = Nothing
        'Save selected productId 
        If cbbWarehouse.Text <> "" Then
            warehouseId = CType(cbbWarehouse.SelectedItem, CBBItem).PropItemId
        End If

        If cbbProduct.Text <> "" Then
            Dim productId = CType(cbbProduct.SelectedItem, CBBItem).PropItemId
            Dim dataWareHouse = clsPMSAnalysis.GetCBBWareHouseOfProduct(productId).CBBWareHouse

            cbbWarehouse.Items.Clear()

            cbbWarehouse.Items.Add("")

            For Each row As DataRow In dataWareHouse.Rows
                cbbWarehouse.Items.Add(New CBBItem(row(0), row(1)))
            Next
        Else
            Dim dataWareHouse = clsPMSAnalysis.GetCBBWareHouse().CBBWareHouse

            cbbWarehouse.Items.Clear()

            cbbWarehouse.Items.Add("")

            For Each row As DataRow In dataWareHouse.Rows
                cbbWarehouse.Items.Add(New CBBItem(row(0), row(1)))
            Next
        End If

        ' Set old warehouseId
        If warehouseId IsNot Nothing Then
            For i = 1 To cbbWarehouse.Items.Count - 1
                If CType(cbbWarehouse.Items(i), CBBItem).PropItemId = warehouseId Then
                    cbbWarehouse.SelectedIndex = i
                End If
            Next

        End If
    End Sub

    Private Sub cbbProduct_Click(sender As Object, e As EventArgs) Handles cbbProduct.Click
        Dim productId = Nothing
        'Save selected productId 
        If cbbProduct.Text <> "" Then
            productId = CType(cbbProduct.SelectedItem, CBBItem).PropItemId
        End If

        If cbbWarehouse.Text <> "" Then
            Dim warehouseId = CType(cbbWarehouse.SelectedItem, CBBItem).PropItemId
            Dim dataProduct = clsPMSAnalysis.GetCBBProductOfWareHouse(warehouseId).CBBProduct

            cbbProduct.Items.Clear()

            cbbProduct.Items.Add("")

            For Each row As DataRow In dataProduct.Rows
                cbbProduct.Items.Add(New CBBItem(row(0), row(1)))
            Next
        Else
            Dim dataProduct = clsPMSAnalysis.GetCBBProduct().CBBProduct

            cbbProduct.Items.Clear()

            cbbProduct.Items.Add("")

            For Each row As DataRow In dataProduct.Rows
                cbbProduct.Items.Add(New CBBItem(row(0), row(1)))
            Next
        End If

        ' Set old productId
        If productId IsNot Nothing Then
            For i = 1 To cbbProduct.Items.Count - 1
                If CType(cbbProduct.Items(i), CBBItem).PropItemId = productId Then
                    cbbProduct.SelectedIndex = i
                End If
            Next

        End If
    End Sub

    Private Sub GetValue()
        If cbbWarehouse.Text <> "" And cbbProduct.Text <> "" Then
            Dim data = clsOrderDetail.GetSalesDetailByProductId(CType(cbbProduct.SelectedItem, CBBItem).PropItemId)
            Dim dataOrderDetail = clsOrderDetail.GetOrderDetailView()

            labTotalProducts.Text = data.Rows(0)(2)
            labRemainProducts.Text = data.Rows(0)(2) - data.Rows(0)(3)
            labTotalSales.Text = data.Rows(0)(4) & "$"

            labTotalProducts.Location = New Point((panel1.Width - labTotalProducts.Width) / 2, labelTotal.Location.Y - 30)
            labRemainProducts.Location = New Point((panel2.Width - labRemainProducts.Width) / 2, labelTotal.Location.Y - 30)
            labTotalSales.Location = New Point((panel3.Width - labTotalSales.Width) / 2, labelTotal.Location.Y - 30)

            chartReport.Series.Clear()
            'chartReport.Series.Add("Number of products sold")
            chartReport.Series.Add("Sales")

            Dim year = DateTime.Now.Year
            'chartReport.Series("Sales").Points.AddXY("2023", 33)

            Dim range = 5
            Dim listNumber(range) As Double
            Dim listSales(range) As Double
            For i = year - range + 1 To year
                For Each row In dataOrderDetail.Rows
                    If CType(row(1), Date).Year = i And row(0) = CType(cbbProduct.SelectedItem, CBBItem).PropItemId Then
                        listNumber(year - i) += row(2)
                        listSales(year - i) += row(3)
                    End If
                Next
                'chartReport.Series("Number of products sold").Points.AddXY(i, listNumber(year - i))
                chartReport.Series("Sales").Points.AddXY(i, listSales(year - i))
            Next

        ElseIf cbbWarehouse.Text = "" And cbbProduct.Text = "" Then
            Dim data = clsOrderDetail.GetAllSalesDetail()
            Dim dataOrder = clsOrderDetail.GetOrderView()

            Dim sumTotal = 0
            Dim sumRemain = 0
            Dim sumSales = 0
            For Each row In data.Rows
                sumTotal += row(2)
                sumRemain += row(2) - row(3)
                sumSales += row(4)
            Next

            labTotalProducts.Text = sumTotal
            labRemainProducts.Text = sumRemain
            labTotalSales.Text = sumSales & "$"

            labTotalProducts.Location = New Point((panel1.Width - labTotalProducts.Width) / 2, labelTotal.Location.Y - 30)
            labRemainProducts.Location = New Point((panel2.Width - labRemainProducts.Width) / 2, labelTotal.Location.Y - 30)
            labTotalSales.Location = New Point((panel3.Width - labTotalSales.Width) / 2, labelTotal.Location.Y - 30)


            chartReport.Series.Clear()
            chartReport.Series.Add("Sales")
            chartReport.ChartAreas("ChartArea1").AxisY.Title = "Sales ($)"
            chartReport.ChartAreas("ChartArea1").AxisY.TextOrientation = DataVisualization.Charting.TextOrientation.Horizontal
            chartReport.ChartAreas("ChartArea1").AxisY.TitleAlignment = StringAlignment.Far

            Dim year = DateTime.Now.Year
            'chartReport.Series("Sales").Points.AddXY("2023", 33)

            Dim range = 5
            Dim listSales(range) As Double
            For i = year - range + 1 To year
                For Each row In dataOrder.Rows
                    If CType(row(0), Date).Year = i Then
                        listSales(year - i) += row(3)
                    End If
                Next
                chartReport.Series("Sales").Points.AddXY(i, listSales(year - i))
            Next

        End If
    End Sub

    Private Sub cbbWarehouse_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbbWarehouse.SelectionChangeCommitted
        GetValue()
    End Sub

    Private Sub cbbProduct_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbbProduct.SelectionChangeCommitted
        GetValue()
    End Sub


    ' Shouldn't do this (-> non-response program)
    'Dim max = Math.Max(Math.Max(Data.Rows(0)(2), Data.Rows(0)(2) - Data.Rows(0)(3)), Data.Rows(0)(4))

    'For i = 0 To max
    'If i <= data.Rows(0)(2) Then
    '                labTotalProducts.Text = i
    '            End If

    'If i <= data.Rows(0)(2) - data.Rows(0)(3) Then
    '                labRemainProducts.Text = i
    '            End If

    'If i <= data.Rows(0)(4) Then
    '                labTotalSales.Text = i
    '            End If
    '            Application.DoEvents()
    '            Threading.Thread.Sleep(100)
    '        Next
End Class