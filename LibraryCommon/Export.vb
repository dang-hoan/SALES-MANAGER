
Imports System.ComponentModel
Imports System.Drawing
Imports Microsoft.Office.Interop.Excel
Public Class Export
    Public Function exportToExcel(ByVal path As String, ByVal tables As BindingList(Of Data.DataTable),
                                  ByVal listPrintedColumn As List(Of KeyValuePair(Of Integer, String)), ByVal listLeftFormat As ArrayList,
                                  ByVal title As String) As Integer

        Dim xlApp As Application
        Dim xlWorkBook As Workbook
        Dim xlWorkSheet As Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim startColumn As Integer = 3
        Dim startRow As Integer = 5

        xlApp = New Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")
        xlWorkSheet.Name = title

        Dim headerStyle As Style = xlWorkSheet.Application.ActiveWorkbook.Styles.Add("headerStyle")
        headerStyle.Font.Bold = True
        headerStyle.Interior.Color = ColorTranslator.ToOle(ColorTranslator.FromHtml("#5699d4"))
        headerStyle.Font.Color = 2
        headerStyle.HorizontalAlignment = XlHAlign.xlHAlignCenter

        Dim oddStyle As Style = xlWorkSheet.Application.ActiveWorkbook.Styles.Add("oddStyle")
        oddStyle.Font.Bold = False
        oddStyle.Interior.Color = ColorTranslator.ToOle(Color.LightBlue)
        oddStyle.HorizontalAlignment = XlHAlign.xlHAlignCenter

        Dim evenStyle As Style = xlWorkSheet.Application.ActiveWorkbook.Styles.Add("evenStyle")
        evenStyle.Font.Bold = False
        evenStyle.Interior.Color = ColorTranslator.ToOle(Color.White)
        evenStyle.HorizontalAlignment = XlHAlign.xlHAlignCenter

        Dim dtAll As New Data.DataTable()
        For Each dt As Data.DataTable In tables
            dtAll.Merge(dt)
        Next

        For k As Integer = 0 To listPrintedColumn.Count - 1
            xlWorkSheet.Cells(startRow, k + startColumn) = listPrintedColumn(k).Value
            xlWorkSheet.Cells(startRow, k + startColumn).Style = "headerStyle"
        Next

        For i = 0 To dtAll.Rows.Count - 1
            For j = 0 To listPrintedColumn.Count - 1
                xlWorkSheet.Cells(i + startRow + 1, j + startColumn) = dtAll.Rows(i)(listPrintedColumn(j).Key)
                xlWorkSheet.Cells(i + startRow + 1, j + startColumn).Style = If((i + 1) Mod 2 = 0, "evenStyle", "oddStyle")
            Next
        Next

        'Add borders
        xlWorkSheet.Cells.EntireColumn.AutoFit()
        Dim range = Chr(startColumn + 64) & startRow & ":" & Chr(startColumn + listPrintedColumn.Count - 1 + 64) & (startRow + dtAll.Rows.Count)
        xlWorkSheet.Range(range).Cells.Borders.LineStyle = XlLineStyle.xlContinuous

        'Format left for name field
        For Each column In listLeftFormat
            range = Chr(startColumn + column + 64) & ":" & Chr(startColumn + column + 64)
            xlWorkSheet.Range(range).Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft
        Next

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
            notifyFrm.ShowDialog()
        Else
            MsgBox("We can't export your data because selected file is opening!", Nothing, "Notification")
        End If

        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        Return saved
    End Function

    Private Sub releaseObject(ByVal obj As Object)
        Try
            Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class
