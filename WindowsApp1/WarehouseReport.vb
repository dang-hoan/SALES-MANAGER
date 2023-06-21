Imports LibraryDataset
Imports LibraryCommon
Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.Office.Interop
Imports OfficeOpenXml
Imports System.IO
Imports System.Globalization

Public Class WarehouseReport
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsCBB(conn.connSales.ConnectionString)
    Dim clsOrderDetail As New clsOrderDetail(conn.connSales.ConnectionString)
    Dim clsWarehouse As New clsWarehouse(conn.connSales.ConnectionString)

    Dim lastSelectedIndex = 0

    Private Sub WarehouseReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataProduct = clsPMSAnalysis.GetCBBProduct().CBBProduct
        Dim dataWareHouse = clsPMSAnalysis.GetCBBWareHouse().CBBWareHouse

        cbbWarehouse.Items.Add(New CBBItem(-1, "All"))
        cbbProduct.Items.Add(New CBBItem(-1, "All"))
        For Each row As DataRow In dataWareHouse.Rows
            cbbWarehouse.Items.Add(New CBBItem(row(0), row(1)))
        Next

        For Each row As DataRow In dataProduct.Rows
            cbbProduct.Items.Add(New CBBItem(row(0), row(1)))
        Next

        cbbWarehouse.SelectedIndex = 0
        cbbProduct.SelectedIndex = 0

        rdByYear.Checked = True
    End Sub

    Private Sub cbbProduct_Click(sender As Object, e As EventArgs) Handles cbbProduct.Click
        Dim productId = Nothing
        'Save selected productId 
        If Not isAll(cbbProduct) Then
            productId = CType(cbbProduct.SelectedItem, CBBItem).PropItemId
        End If

        If Not isAll(cbbWarehouse) Then
            Dim warehouseId = CType(cbbWarehouse.SelectedItem, CBBItem).PropItemId
            Dim dataProduct = clsPMSAnalysis.GetCBBProductOfWareHouse(warehouseId).CBBProduct

            cbbProduct.Items.Clear()

            cbbProduct.Items.Add(New CBBItem(-1, "All"))

            For Each row As DataRow In dataProduct.Rows
                cbbProduct.Items.Add(New CBBItem(row(0), row(1)))
            Next
        Else
            Dim dataProduct = clsPMSAnalysis.GetCBBProduct().CBBProduct

            cbbProduct.Items.Clear()

            cbbProduct.Items.Add(New CBBItem(-1, "All"))

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
        If rdByYear.Checked Then
            GetValueByYear()
        ElseIf rdByMonth.Checked Then
            GetValueByMonth()
        ElseIf rdByDate.Checked Then
            GetValueByDate()
        End If
    End Sub

    Private Sub GetValueByDate()
        If Not isAll(cbbWarehouse) And Not isAll(cbbProduct) Then
            Dim data = clsOrderDetail.GetSalesDetailByProductId(CType(cbbProduct.SelectedItem, CBBItem).PropItemId)

            InitComponents(data)

            'One product only belong to one warehouse => only need search by product id
            Dim salesPerHourInDay = clsOrderDetail.GetSalesByDateAndProductId(dtDate.Value.ToString("dd/MM/yyyy"), CType(cbbProduct.SelectedItem, CBBItem).PropItemId)
            If salesPerHourInDay.Rows.Count > 0 Then
                For Each sales In salesPerHourInDay
                    chartReport.Series("Sales").Points.AddXY(sales("ShipDate"), sales("TotalCosts"))
                Next
                chartReport.Visible = True
                labNotice.Visible = False
            Else
                chartReport.Visible = False
                labNotice.Visible = True
            End If

        ElseIf isAll(cbbWarehouse) And isAll(cbbProduct) Then
            Dim data = clsOrderDetail.GetAllSalesDetail()

            InitComponents(data)

            Dim salesPerHourInDay = clsOrderDetail.GetSalesByDate(dtDate.Value.ToString("dd/MM/yyyy"))
            If salesPerHourInDay.Rows.Count > 0 Then
                For Each sales In salesPerHourInDay
                    chartReport.Series("Sales").Points.AddXY(sales("ShipDate"), sales("TotalCosts"))
                Next
                chartReport.Visible = True
                labNotice.Visible = False
            Else
                chartReport.Visible = False
                labNotice.Visible = True
            End If

        ElseIf Not isAll(cbbWarehouse) And isAll(cbbProduct) Then
            Dim data = clsOrderDetail.GetSalesDetailByWarehouseId(CType(cbbWarehouse.SelectedItem, CBBItem).PropItemId)

            InitComponents(data)

            Dim salesPerHourInDay = clsOrderDetail.GetSalesByDateAndWarehouseId(dtDate.Value.ToString("dd/MM/yyyy"), CType(cbbWarehouse.SelectedItem, CBBItem).PropItemId)
            If salesPerHourInDay.Rows.Count > 0 Then
                For Each sales In salesPerHourInDay
                    chartReport.Series("Sales").Points.AddXY(sales("ShipDate"), sales("TotalCosts"))
                Next
                chartReport.Visible = True
                labNotice.Visible = False
            Else
                chartReport.Visible = False
                labNotice.Visible = True
            End If

        ElseIf isAll(cbbWarehouse) And Not isAll(cbbProduct) Then
            Dim data = clsOrderDetail.GetSalesDetailByProductName(cbbProduct.Text)

            InitComponents(data)

            Dim salesPerHourInDay = clsOrderDetail.GetSalesByDateAndProductName(dtDate.Value.ToString("dd/MM/yyyy"), cbbProduct.Text)
            If salesPerHourInDay.Rows.Count > 0 Then
                For Each sales In salesPerHourInDay
                    chartReport.Series("Sales").Points.AddXY(sales("ShipDate"), sales("TotalCosts"))
                Next
                chartReport.Visible = True
                labNotice.Visible = False
            Else
                chartReport.Visible = False
                labNotice.Visible = True
            End If

        End If
    End Sub
    Private Sub GetValueByMonth()
        If Not isAll(cbbWarehouse) And Not isAll(cbbProduct) Then
            Dim data = clsOrderDetail.GetSalesDetailByProductId(CType(cbbProduct.SelectedItem, CBBItem).PropItemId)

            InitComponents(data)

            'One product only belong to one warehouse => only need search by product id
            Dim salesPerDayInMonth = clsOrderDetail.GetSalesByMonthAndProductId(dtMonth.Value.ToString("MM/yyyy"), CType(cbbProduct.SelectedItem, CBBItem).PropItemId)
            If salesPerDayInMonth.Rows.Count > 0 Then
                For Each sales In salesPerDayInMonth
                    chartReport.Series("Sales").Points.AddXY(sales("ShipDate"), sales("TotalCosts"))
                Next
                chartReport.Visible = True
                labNotice.Visible = False
            Else
                chartReport.Visible = False
                labNotice.Visible = True
            End If

        ElseIf isAll(cbbWarehouse) And isAll(cbbProduct) Then
            Dim data = clsOrderDetail.GetAllSalesDetail()

            InitComponents(data)

            Dim salesPerDayInMonth = clsOrderDetail.GetSalesByMonth(dtMonth.Value.ToString("MM/yyyy"))
            If salesPerDayInMonth.Rows.Count > 0 Then
                For Each sales In salesPerDayInMonth
                    chartReport.Series("Sales").Points.AddXY(sales("ShipDate"), sales("TotalCosts"))
                Next
                chartReport.Visible = True
                labNotice.Visible = False
            Else
                chartReport.Visible = False
                labNotice.Visible = True
            End If

        ElseIf Not isAll(cbbWarehouse) And isAll(cbbProduct) Then
            Dim data = clsOrderDetail.GetSalesDetailByWarehouseId(CType(cbbWarehouse.SelectedItem, CBBItem).PropItemId)

            InitComponents(data)

            Dim salesPerDayInMonth = clsOrderDetail.GetSalesByMonthAndWareHouseId(dtMonth.Value.ToString("MM/yyyy"), CType(cbbWarehouse.SelectedItem, CBBItem).PropItemId)
            If salesPerDayInMonth.Rows.Count > 0 Then
                For Each sales In salesPerDayInMonth
                    chartReport.Series("Sales").Points.AddXY(sales("ShipDate"), sales("TotalCosts"))
                Next
                chartReport.Visible = True
                labNotice.Visible = False
            Else
                chartReport.Visible = False
                labNotice.Visible = True
            End If

        ElseIf isAll(cbbWarehouse) And Not isAll(cbbProduct) Then
            Dim data = clsOrderDetail.GetSalesDetailByProductName(cbbProduct.Text)

            InitComponents(data)

            Dim salesPerDayInMonth = clsOrderDetail.GetSalesByMonthAndProductName(dtMonth.Value.ToString("MM/yyyy"), cbbProduct.Text)
            If salesPerDayInMonth.Rows.Count > 0 Then
                For Each sales In salesPerDayInMonth
                    chartReport.Series("Sales").Points.AddXY(sales("ShipDate"), sales("TotalCosts"))
                Next
                chartReport.Visible = True
                labNotice.Visible = False
            Else
                chartReport.Visible = False
                labNotice.Visible = True
            End If

        End If
    End Sub

    Private Sub GetValueByYear()
        If Not isAll(cbbWarehouse) And Not isAll(cbbProduct) Then
            Dim data = clsOrderDetail.GetSalesDetailByProductId(CType(cbbProduct.SelectedItem, CBBItem).PropItemId)

            InitComponents(data)

            'One product only belong to one warehouse => only need search by product id
            Dim salesPerMonthInYear = clsOrderDetail.GetSalesByYearAndProductId(dtYear.Value.ToString("yyyy"), CType(cbbProduct.SelectedItem, CBBItem).PropItemId)
            If salesPerMonthInYear.Rows.Count > 0 Then
                For Each sales In salesPerMonthInYear
                    chartReport.Series("Sales").Points.AddXY(sales("ShipDate"), sales("TotalCosts"))
                Next
                chartReport.Visible = True
                labNotice.Visible = False
            Else
                chartReport.Visible = False
                labNotice.Visible = True
            End If

        ElseIf isAll(cbbWarehouse) And isAll(cbbProduct) Then
            Dim data = clsOrderDetail.GetAllSalesDetail()

            InitComponents(data)

            Dim salesPerMonthInYear = clsOrderDetail.GetSalesByYear(dtYear.Value.ToString("yyyy"))
            If salesPerMonthInYear.Rows.Count > 0 Then
                For Each sales In salesPerMonthInYear
                    chartReport.Series("Sales").Points.AddXY(sales("ShipDate"), sales("TotalCosts"))
                Next
                chartReport.Visible = True
                labNotice.Visible = False
            Else
                chartReport.Visible = False
                labNotice.Visible = True
            End If

        ElseIf Not isAll(cbbWarehouse) And isAll(cbbProduct) Then
            Dim data = clsOrderDetail.GetSalesDetailByWarehouseId(CType(cbbWarehouse.SelectedItem, CBBItem).PropItemId)

            InitComponents(data)

            Dim salesPerMonthInYear = clsOrderDetail.GetSalesByYearAndWareHouseId(dtYear.Value.ToString("yyyy"), CType(cbbWarehouse.SelectedItem, CBBItem).PropItemId)
            If salesPerMonthInYear.Rows.Count > 0 Then
                For Each sales In salesPerMonthInYear
                    chartReport.Series("Sales").Points.AddXY(sales("ShipDate"), sales("TotalCosts"))
                Next
                chartReport.Visible = True
                labNotice.Visible = False
            Else
                chartReport.Visible = False
                labNotice.Visible = True
            End If

        ElseIf isAll(cbbWarehouse) And Not isAll(cbbProduct) Then
            Dim data = clsOrderDetail.GetSalesDetailByProductName(cbbProduct.Text)

            InitComponents(data)

            Dim salesPerMonthInYear = clsOrderDetail.GetSalesByYearAndProductName(dtYear.Value.ToString("yyyy"), cbbProduct.Text)
            If salesPerMonthInYear.Rows.Count > 0 Then
                For Each sales In salesPerMonthInYear
                    chartReport.Series("Sales").Points.AddXY(sales("ShipDate"), sales("TotalCosts"))
                Next
                chartReport.Visible = True
                labNotice.Visible = False
            Else
                chartReport.Visible = False
                labNotice.Visible = True
            End If

        End If
    End Sub

    Private Sub InitComponents(ByVal data As DataTable)
        'Calculate 
        Dim total = 0, remain = 0, totalSales = 0
        For Each row In data.Rows
            total += row(2)
            remain += row(2) - row(3)
            totalSales += row(4)
        Next

        'Set location for data labels
        labTotalProducts.Text = total
        labRemainProducts.Text = remain
        labTotalSales.Text = totalSales & "$"

        labTotalProducts.Location = New Point((panel1.Width - labTotalProducts.Width) / 2, labelTotal.Location.Y - 35)
        labRemainProducts.Location = New Point((panel2.Width - labRemainProducts.Width) / 2, labelTotal.Location.Y - 35)
        labTotalSales.Location = New Point((panel3.Width - labTotalSales.Width) / 2, labelTotal.Location.Y - 35)

        'Init chart report
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

    End Sub

    Private Sub cbbWarehouse_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbbWarehouse.SelectionChangeCommitted
        If Not isAll(cbbProduct) And Not isAll(cbbWarehouse) Then
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

    Private Function isAll(ByVal cbb As ComboBox) As Boolean
        If CType(cbb.SelectedItem, CBBItem).PropItemId = -1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub cbbProduct_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbbProduct.SelectionChangeCommitted
        GetValue()
    End Sub
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

    Private Sub cbbToMonth_DropDown(sender As Object, e As EventArgs)
        'DropDown(cbbToMonth, "Month")
    End Sub

    Private Sub cbbFromMonth_DropDownClosed(sender As Object, e As EventArgs)
        'DropDownClosed(cbbFromMonth, "Month")
    End Sub

    Private Sub cbbToMonth_DropDownClosed(sender As Object, e As EventArgs)
        'DropDownClosed(cbbToMonth, "Month")
    End Sub

    Private Sub cbbFromYear_SelectionChangeCommitted(sender As Object, e As EventArgs)
        GetValue()
    End Sub

    Private Sub cbbToYear_SelectionChangeCommitted(sender As Object, e As EventArgs)
        GetValue()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If labNotice.Visible Then
            MsgBox("No data to export!", Nothing, "Notification")
            Return
        End If

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
            Dim startRow = 2, startColumn = 2
            Dim offset = 4, boxWidth = 3, boxHeight = 4
            'Dim range = xlWorkSheet.Range("A2:C5")
            Dim range = xlWorkSheet.Range(Chr(startColumn + 64) & startRow & ":" & Chr(startColumn + boxWidth - 1 + 64) & (startRow + boxHeight - 1))
            range.Merge()
            range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            range.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter
            range.Font.Color = ColorTranslator.ToOle(Color.Brown)
            range.Interior.Color = ColorTranslator.ToOle(Color.FromArgb(&HFA, &HEB, &HD7))
            range.Font.Bold = True
            range.Font.Size = 15
            range.Value = labTotalProducts.Text & vbCrLf & "Total products"

            'range = xlWorkSheet.Range("E2:G5")
            range = xlWorkSheet.Range(Chr(startColumn + offset + 64) & startRow & ":" & Chr(startColumn + offset + boxWidth - 1 + 64) & (startRow + boxHeight - 1))
            range.Merge()
            range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            range.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter
            range.Font.Color = ColorTranslator.ToOle(Color.Red)
            range.Interior.Color = ColorTranslator.ToOle(Color.FromArgb(&HFA, &HEB, &HD7))
            range.Font.Bold = True
            range.Font.Size = 15
            range.Value = labRemainProducts.Text & vbCrLf & "Remain products"

            'range = xlWorkSheet.Range("I2:K5")
            range = xlWorkSheet.Range(Chr(startColumn + offset * 2 + 64) & startRow & ":" & Chr(startColumn + offset * 2 + boxWidth - 1 + 64) & (startRow + boxHeight - 1))
            range.Merge()
            range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            range.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter
            range.Font.Color = ColorTranslator.ToOle(Color.FromArgb(&H1C, &HC0, &H0))
            range.Interior.Color = ColorTranslator.ToOle(Color.FromArgb(&HFA, &HEB, &HD7))
            range.Font.Bold = True
            range.Font.Size = 15
            range.Value = labTotalSales.Text & vbCrLf & "Total sales"

            'create chart
            'Start cell
            Dim i = startRow + boxHeight + 1, j = startColumn, k = i
            Dim rng As Excel.Range = xlWorkSheet.Range(Chr(j + 64) & i)
            Dim cellWidth As Single = rng.Width
            Dim cellHeight As Single = rng.Height

            'Init data for drawing chart
            If chartReport.Series("Sales").Points.Count > 1 Then
                xlWorkSheet.Cells(i, j + 1) = "Sales"
                For Each point As DataPoint In chartReport.Series("Sales").Points
                    i += 1
                    Dim xValue As String = point.AxisLabel
                    Dim yValue As String = point.YValues(0)
                    xlWorkSheet.Cells(i, j).NumberFormat = "@"
                    xlWorkSheet.Cells(i, j) = xValue
                    xlWorkSheet.Cells(i, j + 1) = yValue
                    Console.WriteLine(xValue & ", " & yValue)
                Next
            Else
                'When only have one point, need to swap axisX and title position
                xlWorkSheet.Cells(i + 1, j) = "Sales"
                Dim point As DataPoint = chartReport.Series("Sales").Points(0)
                i += 1
                Dim xValue As String = Point.AxisLabel
                Dim yValue As String = Point.YValues(0)
                xlWorkSheet.Cells(i, j).NumberFormat = "@"
                xlWorkSheet.Cells(i - 1, j + 1) = xValue
                xlWorkSheet.Cells(i, j + 1) = yValue
                Console.WriteLine(xValue & ", " & yValue)
            End If

            Dim chartPage As Excel.Chart
            Dim xlCharts As Excel.ChartObjects
            Dim myChart As Excel.ChartObject
            Dim chartRange As Excel.Range

            xlCharts = xlWorkSheet.ChartObjects

            'Dim myChart As Excel.Chart = xlWorkSheet.Shapes.AddChart2(-1, Excel.XlChartType.xlColumnClustered).Chart
            myChart = xlCharts.Add(0, 0, 0, 0)   'create chart with default arguments

            ' Set chart position and size
            Dim chartWidth = offset * 2 + boxWidth, chartHeight = 17 'Unit is cell number
            myChart.Width = cellWidth * chartWidth
            myChart.Height = cellHeight * chartHeight
            myChart.Left = rng.Left
            myChart.Top = rng.Top

            chartPage = myChart.Chart
            chartRange = xlWorkSheet.Range(Chr(j + 64) & k, Chr(j + 64 + 1) & i)
            chartPage.SetSourceData(Source:=chartRange)
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered
            chartPage.ApplyDataLabels()

            'Add chart name
            'range = xlWorkSheet.Range("C24:I24")
            range = xlWorkSheet.Range(Chr(startColumn + 2 + 64) & (startRow + boxHeight + chartHeight + 2) & ":" & Chr(startColumn + offset * 2 + boxWidth - 1 - 2 + 64) & (startRow + boxHeight + chartHeight + 2))
            Console.WriteLine(Chr(startColumn + 2 + 64) & (startRow + boxHeight + chartHeight + 2) & ":" & Chr(startColumn + offset * 2 + boxWidth - 1 - 2 + 64) & (startRow + boxHeight + chartHeight + 2))
            range.Merge()
            range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            range.Font.Color = ColorTranslator.ToOle(Color.FromArgb(&H29, &HB3, &HAA))
            range.Font.Bold = True
            range.Font.Italic = True
            range.Font.Size = 18
            Dim infor = ""
            If rdByDate.Checked Then
                infor = " on " & dtDate.Value.ToString(dtDate.CustomFormat)
            Else
                infor = " in " & If(rdByMonth.Checked, dtMonth.Value.ToString(dtMonth.CustomFormat), dtYear.Value.ToString(dtYear.CustomFormat))
            End If
            range.Value = labTitle.Text & infor

            'exporting chart as picture file
            'xlWorkSheet.ChartObjects(1).chart.Export(FileName:=
            '"C:\Users\DELL\Downloads\excel_chart_export.bmp", FilterName:="BMP")

            xlApp.DisplayAlerts = False
            Dim saved = True
            Try
                xlWorkSheet.SaveAs(path)
            Catch ex As Exception
                saved = False
            End Try

            If saved Then
                Dim notifyFrm = New SaveFileNotification()
                notifyFrm.path = path
                notifyFrm.ShowDialog(Me)
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

    Private Sub rdByYear_CheckedChanged(sender As Object, e As EventArgs) Handles rdByYear.CheckedChanged
        dtYear.Enabled = rdByYear.Checked
        If rdByYear.Checked Then
            GetValue()
        End If
    End Sub
    Private Sub rdByMonth_CheckedChanged(sender As Object, e As EventArgs) Handles rdByMonth.CheckedChanged
        dtMonth.Enabled = rdByMonth.Checked
        If rdByMonth.Checked Then
            GetValue()
        End If
    End Sub

    Private Sub rdByDate_CheckedChanged(sender As Object, e As EventArgs) Handles rdByDate.CheckedChanged
        dtDate.Enabled = rdByDate.Checked
        If rdByDate.Checked Then
            GetValue()
        End If
    End Sub
    Private Sub dtMonth_DropDown(sender As Object, e As EventArgs) Handles dtMonth.DropDown
        ' Temporarily set the format to Short to display the calendar dropdown
        Me.dtMonth.Format = DateTimePickerFormat.Short

        ' Set the format back to Custom to prevent the user from selecting a day
        Me.dtMonth.Format = DateTimePickerFormat.Custom
        Me.dtMonth.CustomFormat = "MM/yyyy"
    End Sub

    Private Sub dtYear_DropDown(sender As Object, e As EventArgs) Handles dtYear.DropDown
        ' Temporarily set the format to Short to display the calendar dropdown
        Me.dtYear.Format = DateTimePickerFormat.Short

        ' Set the format back to Custom to prevent the user from selecting a day
        Me.dtYear.Format = DateTimePickerFormat.Custom
        Me.dtYear.CustomFormat = "yyyy"
    End Sub

    Private Sub bStatistic_Click(sender As Object, e As EventArgs) Handles bStatistic.Click
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