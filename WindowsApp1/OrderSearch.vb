Imports LibraryDataset
Imports LibraryCommon

Imports Microsoft.Office.Interop.Excel
Imports System.IO

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

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If dgvOrderSearch Is Nothing Then
            MsgBox("No data to export!")
            Return
        End If

        If dgvOrderSearch.Rows.Count = 0 Then
            MsgBox("No data to export!")
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
            Dim res = exportToExcel(sfd.FileName, dgvOrderSearch, "order search")

            If res Then
                MsgBox("Export successfully in " & sfd.FileName & "!")
            Else
                MsgBox("We can't export your data because selected file is opening!")
            End If
        End If
    End Sub

    Private Function exportToExcel(ByVal path As String, ByVal dgv As DataGridView, ByVal title As String) As Integer
        Dim xlApp As Application
        Dim xlWorkBook As Workbook
        Dim xlWorkSheet As Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

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

        For k As Integer = 1 To dgv.Columns.Count
            xlWorkSheet.Cells(1, k) = dgv.Columns(k - 1).HeaderText
            xlWorkSheet.Cells(1, k).Style = "headerStyle"
        Next
        For i = 0 To dgv.RowCount - 1
            For j = 0 To dgv.ColumnCount - 1
                xlWorkSheet.Cells(i + 2, j + 1) = dgv(j, i).Value.ToString()
                xlWorkSheet.Cells(i + 2, j + 1).Style = If((i + 2) Mod 2 = 0, "evenStyle", "oddStyle")
            Next
        Next
        xlWorkSheet.Cells.EntireColumn.AutoFit()
        Dim range = "A1:" & Chr(dgv.Columns.Count + 64) & (dgv.Rows.Count + 1)
        xlWorkSheet.Range(range).Cells.Borders.LineStyle = XlLineStyle.xlContinuous
        xlApp.DisplayAlerts = False
        Dim saved = True
        Try
            xlWorkSheet.SaveAs(path)
        Catch ex As Exception
            saved = False
        End Try

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