Imports LibraryDataset
Imports LibraryCommon
Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.Office.Interop
Imports OfficeOpenXml
Imports System.IO

Public Class WarehouseReport
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsCBB(conn.connSales.ConnectionString)
    Dim clsOrderDetail As New clsOrderDetail(conn.connSales.ConnectionString)
    Dim clsWarehouse As New clsWarehouse(conn.connSales.ConnectionString)

    Dim lastSelectedIndex = 0

    Private Sub WarehouseReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataProduct = clsPMSAnalysis.GetCBBProduct().CBBProduct
        Dim dataWareHouse = clsPMSAnalysis.GetCBBWareHouse().CBBWareHouse
        Dim dataOrder = clsOrderDetail.GetOrderView()

        cbbWarehouse.Items.Add("All")
        cbbProduct.Items.Add("All")
        For Each row As DataRow In dataWareHouse.Rows
            cbbWarehouse.Items.Add(New CBBItem(row(0), row(1)))
        Next

        For Each row As DataRow In dataProduct.Rows
            cbbProduct.Items.Add(New CBBItem(row(0), row(1)))
        Next

        cbbWarehouse.SelectedIndex = 0
        cbbProduct.SelectedIndex = 0

        'For i = 0 To 12
        '    cbbFromMonth.Items.Add(i)
        '    cbbToMonth.Items.Add(i)
        'Next

        'Get min and max year in all shipped order
        Dim min = DateTime.Now.Year, max = -1

        For Each order In dataOrder
            Dim shipYear = CType(order(0), Date).Year         'Ship date ( order(0) )
            If min > shipYear Then
                min = shipYear
            End If
            If max < shipYear Then
                max = shipYear
            End If
        Next

        For i = min To max
            cbbFromYear.Items.Add(i)
            cbbToYear.Items.Add(i)
        Next

        'Set hint for month year comboboxes
        'cbbFromMonth.Items.Insert(0, "Month")
        cbbFromYear.Items.Insert(0, "Year")
        'cbbToMonth.Items.Insert(0, "Month")
        cbbToYear.Items.Insert(0, "Year")

        'cbbFromMonth.Text = "Month"
        cbbFromYear.Text = "Year"
        'cbbToMonth.Text = "Month"
        cbbToYear.Text = "Year"

        GetValue()
    End Sub

    Private Sub cbbProduct_Click(sender As Object, e As EventArgs) Handles cbbProduct.Click
        Dim productId = Nothing
        'Save selected productId 
        If Not isAll(cbbProduct.Text) Then
            productId = CType(cbbProduct.SelectedItem, CBBItem).PropItemId
        End If

        If Not isAll(cbbWarehouse.Text) Then
            Dim warehouseId = CType(cbbWarehouse.SelectedItem, CBBItem).PropItemId
            Dim dataProduct = clsPMSAnalysis.GetCBBProductOfWareHouse(warehouseId).CBBProduct

            cbbProduct.Items.Clear()

            cbbProduct.Items.Add("All")

            For Each row As DataRow In dataProduct.Rows
                cbbProduct.Items.Add(New CBBItem(row(0), row(1)))
            Next
        Else
            Dim dataProduct = clsPMSAnalysis.GetCBBProduct().CBBProduct

            cbbProduct.Items.Clear()

            cbbProduct.Items.Add("All")

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
        Else
            cbbProduct.SelectedIndex = 0
        End If
    End Sub

    Private Sub GetValue()
        If Not isAll(cbbWarehouse.Text) And Not isAll(cbbProduct.Text) Then
            Dim data = clsOrderDetail.GetSalesDetailByProductId(CType(cbbProduct.SelectedItem, CBBItem).PropItemId)
            Dim dataOrderDetail = clsOrderDetail.GetOrderDetailView()

            labTotalProducts.Text = data.Rows(0)(2)
            labRemainProducts.Text = data.Rows(0)(2) - data.Rows(0)(3)
            labTotalSales.Text = data.Rows(0)(4) & "$"

            labTotalProducts.Location = New Point((panel1.Width - labTotalProducts.Width) / 2, labelTotal.Location.Y - 30)
            labRemainProducts.Location = New Point((panel2.Width - labRemainProducts.Width) / 2, labelTotal.Location.Y - 30)
            labTotalSales.Location = New Point((panel3.Width - labTotalSales.Width) / 2, labelTotal.Location.Y - 30)

            chartReport.Series.Clear()
            chartReport.ChartAreas.Clear()
            chartReport.ChartAreas.Add("ChartArea1")
            chartReport.Series.Add("Sales")
            'chartReport.Series.Add("Number of products sold")
            chartReport.ChartAreas("ChartArea1").AxisY.Title = "Sales ($)"
            chartReport.ChartAreas("ChartArea1").AxisY.TextOrientation = DataVisualization.Charting.TextOrientation.Horizontal
            chartReport.ChartAreas("ChartArea1").AxisY.TitleAlignment = StringAlignment.Far
            chartReport.Series("Sales").IsValueShownAsLabel = True

            'chartReport.ChartAreas("ChartArea1").AxisX.MinorTickMark.Enabled = True
            'chartReport.ChartAreas("ChartArea1").AxisX.Interval = 1
            chartReport.ChartAreas("ChartArea1").AxisX.IsLabelAutoFit = True
            'chartReport.ChartAreas("ChartArea1").AxisX.LabelStyle.IsStaggered = True
            chartReport.ChartAreas("ChartArea1").AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont

            'chartReport.Series("Sales").Points.AddXY("2023", 33)


            If cbbFromYear.Text = "Year" Then
                If cbbFromYear.Items.Count > 1 Then
                    cbbFromYear.SelectedIndex = 1
                Else
                    Return
                End If
            End If
            If cbbToYear.Text = "Year" Then
                If cbbToYear.Items.Count > 1 Then
                    cbbToYear.SelectedIndex = cbbToYear.Items.Count - 1
                Else
                    Return
                End If
            End If

            If cbbToYear.Text < cbbFromYear.Text Then
                MsgBox("To-year can't be less than from-year!", Nothing, "Notification")
                chartReport.Series.Clear()
                Return
            End If

            Dim range = cbbToYear.Text - cbbFromYear.Text + 1
            Dim listNumber(range) As Double
            Dim listSales(range) As Double
            For i = CType(cbbFromYear.Text, Integer) To CType(cbbToYear.Text, Integer)
                For Each row In dataOrderDetail.Rows
                    If CType(row(1), Date).Year = i And row(0) = CType(cbbProduct.SelectedItem, CBBItem).PropItemId Then
                        listNumber(cbbToYear.Text - i) += row(2)
                        listSales(cbbToYear.Text - i) += row(3)
                    End If
                Next
                'chartReport.Series("Number of products sold").Points.AddXY(i, listNumber(cbbToYear.Text - i))
                chartReport.Series("Sales").Points.AddXY(i, listSales(cbbToYear.Text - i))
            Next

        ElseIf isAll(cbbWarehouse.Text) And isAll(cbbProduct.Text) Then
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
            chartReport.ChartAreas.Clear()
            chartReport.ChartAreas.Add("ChartArea1")
            chartReport.Series.Add("Sales")
            chartReport.ChartAreas("ChartArea1").AxisY.Title = "Sales ($)"
            chartReport.ChartAreas("ChartArea1").AxisY.TextOrientation = DataVisualization.Charting.TextOrientation.Horizontal
            chartReport.ChartAreas("ChartArea1").AxisY.TitleAlignment = StringAlignment.Far
            chartReport.Series("Sales").IsValueShownAsLabel = True

            'chartReport.ChartAreas("ChartArea1").AxisX.MinorTickMark.Enabled = True
            'chartReport.ChartAreas("ChartArea1").AxisX.Interval = 1
            chartReport.ChartAreas("ChartArea1").AxisX.IsLabelAutoFit = True
            'chartReport.ChartAreas("ChartArea1").AxisX.LabelStyle.IsStaggered = True
            chartReport.ChartAreas("ChartArea1").AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont

            'chartReport.Series("Sales").Points.AddXY("2023", 33)

            If cbbFromYear.Text = "Year" Then
                If cbbFromYear.Items.Count > 1 Then
                    cbbFromYear.SelectedIndex = 1
                Else
                    Return
                End If
            End If
            If cbbToYear.Text = "Year" Then
                If cbbToYear.Items.Count > 1 Then
                    cbbToYear.SelectedIndex = cbbToYear.Items.Count - 1
                Else
                    Return
                End If
            End If

            If cbbToYear.Text < cbbFromYear.Text Then
                MsgBox("To-year can't be less than from-year!", Nothing, "Notification")
                chartReport.Series.Clear()
                Return
            End If

            Dim range = cbbToYear.Text - cbbFromYear.Text + 1
            Dim listSales(range) As Double
            For i = CType(cbbFromYear.Text, Integer) To CType(cbbToYear.Text, Integer)
                For Each row In dataOrder.Rows
                    If CType(row(0), Date).Year = i Then
                        listSales(cbbToYear.Text - i) += Math.Round(row(3) / (1 - row(2) / 100), 2)
                    End If
                Next
                chartReport.Series("Sales").Points.AddXY(i, listSales(cbbToYear.Text - i))
            Next

        ElseIf Not isAll(cbbWarehouse.Text) And isAll(cbbProduct.Text) Then
            Dim data = clsOrderDetail.GetSalesDetailByWarehouseId(CType(cbbWarehouse.SelectedItem, CBBItem).PropItemId)
            Dim dataOrderDetail = clsOrderDetail.GetOrderDetailView()

            Dim total = 0, remain = 0, totalSales = 0
            For Each row In data.Rows
                total += row(2)
                remain += row(2) - row(3)
                totalSales += row(4)
            Next
            labTotalProducts.Text = total
            labRemainProducts.Text = remain
            labTotalSales.Text = totalSales & "$"

            labTotalProducts.Location = New Point((panel1.Width - labTotalProducts.Width) / 2, labelTotal.Location.Y - 30)
            labRemainProducts.Location = New Point((panel2.Width - labRemainProducts.Width) / 2, labelTotal.Location.Y - 30)
            labTotalSales.Location = New Point((panel3.Width - labTotalSales.Width) / 2, labelTotal.Location.Y - 30)

            chartReport.Series.Clear()
            chartReport.ChartAreas.Clear()
            chartReport.ChartAreas.Add("ChartArea1")
            chartReport.Series.Add("Sales")
            'chartReport.Series.Add("Number of products sold")
            chartReport.ChartAreas("ChartArea1").AxisY.Title = "Sales ($)"
            chartReport.ChartAreas("ChartArea1").AxisY.TextOrientation = DataVisualization.Charting.TextOrientation.Horizontal
            chartReport.ChartAreas("ChartArea1").AxisY.TitleAlignment = StringAlignment.Far
            chartReport.Series("Sales").IsValueShownAsLabel = True

            'chartReport.ChartAreas("ChartArea1").AxisX.MinorTickMark.Enabled = True
            'chartReport.ChartAreas("ChartArea1").AxisX.Interval = 1
            chartReport.ChartAreas("ChartArea1").AxisX.IsLabelAutoFit = True
            'chartReport.ChartAreas("ChartArea1").AxisX.LabelStyle.IsStaggered = True
            chartReport.ChartAreas("ChartArea1").AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont

            'chartReport.Series("Sales").Points.AddXY("2023", 33)

            If cbbFromYear.Text = "Year" Then
                If cbbFromYear.Items.Count > 1 Then
                    cbbFromYear.SelectedIndex = 1
                Else
                    Return
                End If
            End If
            If cbbToYear.Text = "Year" Then
                If cbbToYear.Items.Count > 1 Then
                    cbbToYear.SelectedIndex = cbbToYear.Items.Count - 1
                Else
                    Return
                End If
            End If

            If cbbToYear.Text < cbbFromYear.Text Then
                MsgBox("To-year can't be less than from-year!", Nothing, "Notification")
                chartReport.Series.Clear()
                Return
            End If

            Dim range = cbbToYear.Text - cbbFromYear.Text + 1
            Dim listNumber(range) As Double
            Dim listSales(range) As Double
            For i = CType(cbbFromYear.Text, Integer) To CType(cbbToYear.Text, Integer)
                For Each row In dataOrderDetail.Rows
                    If CType(row(1), Date).Year = i And row(4) = CType(cbbWarehouse.SelectedItem, CBBItem).PropItemId Then
                        listNumber(cbbToYear.Text - i) += row(2)
                        listSales(cbbToYear.Text - i) += row(3)
                    End If
                Next
                'chartReport.Series("Number of products sold").Points.AddXY(i, listNumber(cbbToYear.Text - i))
                chartReport.Series("Sales").Points.AddXY(i, listSales(cbbToYear.Text - i))
            Next

        ElseIf isAll(cbbWarehouse.Text) And Not isAll(cbbProduct.Text) Then
            Dim data = clsOrderDetail.GetSalesDetailByProductName(cbbProduct.Text)
            Dim dataOrderDetail = clsOrderDetail.GetOrderDetailView()

            Dim total = 0, remain = 0, totalSales = 0
            For Each row In data.Rows
                total += row(2)
                remain += row(2) - row(3)
                totalSales += row(4)
            Next
            labTotalProducts.Text = total
            labRemainProducts.Text = remain
            labTotalSales.Text = totalSales & "$"

            labTotalProducts.Location = New Point((panel1.Width - labTotalProducts.Width) / 2, labelTotal.Location.Y - 30)
            labRemainProducts.Location = New Point((panel2.Width - labRemainProducts.Width) / 2, labelTotal.Location.Y - 30)
            labTotalSales.Location = New Point((panel3.Width - labTotalSales.Width) / 2, labelTotal.Location.Y - 30)

            chartReport.Series.Clear()
            chartReport.ChartAreas.Clear()
            chartReport.ChartAreas.Add("ChartArea1")
            chartReport.Series.Add("Sales")
            'chartReport.Series.Add("Number of products sold")
            chartReport.ChartAreas("ChartArea1").AxisY.Title = "Sales ($)"
            chartReport.ChartAreas("ChartArea1").AxisY.TextOrientation = DataVisualization.Charting.TextOrientation.Horizontal
            chartReport.ChartAreas("ChartArea1").AxisY.TitleAlignment = StringAlignment.Far
            chartReport.Series("Sales").IsValueShownAsLabel = True

            'chartReport.ChartAreas("ChartArea1").AxisX.MinorTickMark.Enabled = True
            'chartReport.ChartAreas("ChartArea1").AxisX.Interval = 1
            chartReport.ChartAreas("ChartArea1").AxisX.IsLabelAutoFit = True
            'chartReport.ChartAreas("ChartArea1").AxisX.LabelStyle.IsStaggered = True
            chartReport.ChartAreas("ChartArea1").AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont

            'chartReport.Series("Sales").Points.AddXY("2023", 33)


            If cbbFromYear.Text = "Year" Then
                If cbbFromYear.Items.Count > 1 Then
                    cbbFromYear.SelectedIndex = 1
                Else
                    Return
                End If
            End If
            If cbbToYear.Text = "Year" Then
                If cbbToYear.Items.Count > 1 Then
                    cbbToYear.SelectedIndex = cbbToYear.Items.Count - 1
                Else
                    Return
                End If
            End If

            If cbbToYear.Text < cbbFromYear.Text Then
                MsgBox("To-year can't be less than from-year!", Nothing, "Notification")
                chartReport.Series.Clear()
                Return
            End If

            Dim range = cbbToYear.Text - cbbFromYear.Text + 1
            Dim listNumber(range) As Double
            Dim listSales(range) As Double
            For i = CType(cbbFromYear.Text, Integer) To CType(cbbToYear.Text, Integer)
                For Each row In dataOrderDetail.Rows
                    If CType(row(1), Date).Year = i And row(5) = cbbProduct.Text Then
                        listNumber(cbbToYear.Text - i) += row(2)
                        listSales(cbbToYear.Text - i) += row(3)
                    End If
                Next
                'chartReport.Series("Number of products sold").Points.AddXY(i, listNumber(cbbToYear.Text - i))
                chartReport.Series("Sales").Points.AddXY(i, listSales(cbbToYear.Text - i))
            Next

        End If


    End Sub

    Private Sub cbbWarehouse_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbbWarehouse.SelectionChangeCommitted
        If Not isAll(cbbProduct.Text) And Not isAll(cbbWarehouse.Text) Then
            If cbbWarehouse.SelectedIndex <> lastSelectedIndex Then
                Dim warehouseId = CType(cbbWarehouse.SelectedItem, CBBItem).PropItemId
                Dim productId = CType(cbbProduct.SelectedItem, CBBItem).PropItemId
                If Not clsWarehouse.CheckWareHouseContainProduct(warehouseId, productId) Then
                    cbbProduct.SelectedIndex = 0
                End If
            End If
        End If
        lastSelectedIndex = cbbWarehouse.SelectedIndex
        GetValue()
    End Sub

    Private Sub cbbProduct_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbbProduct.SelectionChangeCommitted
        GetValue()
    End Sub

    Private Function isAll(ByVal cbbText As String) As Boolean
        If cbbText = "All" Or cbbText = "" Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub DropDown(ByRef cbb As ComboBox, ByVal txt As String)
        If (cbb.Items.Contains(txt)) Then
            cbb.Items.RemoveAt(0)
        End If
    End Sub
    Private Sub DropDownClosed(ByRef cbb As ComboBox, ByVal txt As String)
        If (cbb.SelectedIndex = -1) Then
            cbb.Items.Insert(0, txt)
            cbb.Text = txt
        End If
    End Sub

    Private Sub cbbFromMonth_DropDown(sender As Object, e As EventArgs)
        'DropDown(cbbFromMonth, "Month")
    End Sub

    Private Sub cbbFromYear_DropDown(sender As Object, e As EventArgs) Handles cbbFromYear.DropDown
        DropDown(cbbFromYear, "Year")
    End Sub

    Private Sub cbbToMonth_DropDown(sender As Object, e As EventArgs)
        'DropDown(cbbToMonth, "Month")
    End Sub

    Private Sub cbbToYear_DropDown(sender As Object, e As EventArgs) Handles cbbToYear.DropDown
        DropDown(cbbToYear, "Year")
    End Sub

    Private Sub cbbFromMonth_DropDownClosed(sender As Object, e As EventArgs)
        'DropDownClosed(cbbFromMonth, "Month")
    End Sub

    Private Sub cbbFromYear_DropDownClosed(sender As Object, e As EventArgs) Handles cbbFromYear.DropDownClosed
        DropDownClosed(cbbFromYear, "Year")
    End Sub

    Private Sub cbbToMonth_DropDownClosed(sender As Object, e As EventArgs)
        'DropDownClosed(cbbToMonth, "Month")
    End Sub

    Private Sub cbbToYear_DropDownClosed(sender As Object, e As EventArgs) Handles cbbToYear.DropDownClosed
        DropDownClosed(cbbToYear, "Year")
    End Sub

    Private Sub cbbFromYear_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbbFromYear.SelectionChangeCommitted
        GetValue()
    End Sub

    Private Sub cbbToYear_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbbToYear.SelectionChangeCommitted
        GetValue()
    End Sub

    Private Sub btnExport_Click() Handles btnExport.Click
        Dim sfd As SaveFileDialog = New SaveFileDialog()
        sfd.Title = "Select export data path"
        Dim defaultPath = Environ$("USERPROFILE") & "\Downloads"
        If Directory.Exists(defaultPath) Then
            sfd.InitialDirectory = defaultPath
        Else
            sfd.InitialDirectory = "C:\"
        End If
        sfd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        sfd.FilterIndex = 2
        sfd.RestoreDirectory = True
        Dim result = sfd.ShowDialog()
        If result = DialogResult.OK Then
            Dim fileName = Path.GetDirectoryName(sfd.FileName) & Path.AltDirectorySeparatorChar & Path.GetFileNameWithoutExtension(sfd.FileName)
            Dim ext = Path.GetExtension(sfd.FileName)
            If ext = "" Then
                ext += ".xlsx"
                sfd.FileName += ".xlsx"
            End If
            'If File.Exists(sfd.FileName) Then
            '    Dim i = 0
            '    Do
            '        sfd.FileName = fileName & "(" & i & ")" & ext
            '        i += 1
            '    Loop While File.Exists(sfd.FileName)
            'End If
            exportToExcel(sfd.FileName, chartReport, "Warehouse report")
        End If
    End Sub
    Private Sub exportToExcel(ByVal path As String, ByVal chartReport As Chart, ByVal title As String)
        If chartReport.Series.Count > 0 Then

            Dim xlApp As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value

            xlApp = New Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")
            xlWorkSheet.Name = title

            'add data
            Dim i = 1, j = 1, k = i
            'xlWorkSheet.Cells(i, j) = "Year"
            xlWorkSheet.Cells(i, j + 1) = "Sales"
            For Each point As DataPoint In chartReport.Series("Sales").Points
                i += 1
                Dim xValue As Double = point.XValue
                Dim yValue As Double = point.YValues(0)
                xlWorkSheet.Cells(i, j) = xValue
                xlWorkSheet.Cells(i, j + 1) = yValue
                Console.WriteLine(xValue & ", " & yValue)
                ' Do something with yValue.
            Next

            'create chart
            Dim chartPage As Excel.Chart
            Dim xlCharts As Excel.ChartObjects
            Dim myChart As Excel.ChartObject
            Dim chartRange As Excel.Range

            xlCharts = xlWorkSheet.ChartObjects
            myChart = xlCharts.Add(10, 80, 300, 250)
            chartPage = myChart.Chart
            chartRange = xlWorkSheet.Range(Chr(j + 64) & k, Chr(j + 64 + 1) & i)
            Console.WriteLine(Chr(j + 64) & k & ", " & Chr(j + 64 + 1) & i)
            chartPage.SetSourceData(Source:=chartRange)
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered

            'exporting chart as picture file
            'xlWorkSheet.ChartObjects(1).chart.Export(FileName:=
            '"C:\Users\DELL\Downloads\excel_chart_export.bmp", FilterName:="BMP")

            Dim saved = True
            Try
                xlWorkSheet.SaveAs(path)
            Catch ex As Exception
                saved = False
            End Try

            If saved Then
                MsgBox("Export successfully in " & path & "!", Nothing, "Notification")
            Else
                MsgBox("We can't export your data because selected file is opening!", Nothing, "Notification")
            End If

            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
        Else
            MsgBox("There's not chart to export!", Nothing, "Notification")
            Return
        End If


    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
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