Imports LibraryDataset
Imports LibraryCommon
Public Class WarehouseCategory
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsWarehouse(conn.connSales.ConnectionString)
    Dim clsProduct As New clsProduct(conn.connSales.ConnectionString)

    Private warehouseId As Long
    Private isSaved As Boolean = False
    Private Sub WarehouseCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Public Sub Reload()
        dgvCategory.DataSource = clsPMSAnalysis.GetWarehouse()
        setEnable(False)
        setValue()
    End Sub

    Private Sub setValue()
        If dgvCategory.Rows.Count = 0 Then
            addEditDeleteEnabled(False)
            bAdd.Enabled = True
            Return
        Else
            Dim row As DataGridViewRow = dgvCategory.CurrentRow
            If row Is Nothing Then
                row = dgvCategory.Rows(0)
            End If

            txtCode.Text = row.Cells(0).Value.ToString
            txtName.Text = row.Cells(1).Value.ToString
            txtAddress.Text = row.Cells(2).Value.ToString
            txtNumberOfImport.Text = row.Cells(3).Value.ToString
            txtNumberOfExport.Text = row.Cells(4).Value.ToString

            Warehouse.Clear()
            Warehouse.Merge(clsPMSAnalysis.GetProductsOfWarehouse(txtCode.Text))

        End If
    End Sub

    Private Sub bEdit_Click(sender As Object, e As EventArgs) Handles bEdit.Click
        If dgvCategory.Rows.Count = 0 Then
            MsgBox("There isn't any warehouse information to edit!")
        Else
            bAdd.Enabled = False
            setEnable(True)
        End If
    End Sub

    Private Sub setEnable(valBoolean As Boolean)
        txtName.Enabled = valBoolean
        txtAddress.Enabled = valBoolean
        bAddProduct.Enabled = valBoolean
        'txtNumberOfImport.Enabled = valBoolean
        'txtNumberOfExport.Enabled = valBoolean
        dgvProduct.Columns(3).Visible = valBoolean
        dgvProduct.Columns(4).Visible = valBoolean
        bSave.Enabled = valBoolean
    End Sub

    Private Sub addEditDeleteEnabled(valBoolean As Boolean)
        bAdd.Enabled = valBoolean
        bEdit.Enabled = valBoolean
        bDelete.Enabled = valBoolean
    End Sub
    Private Sub clearValue()
        txtCode.Text = ""
        txtName.Text = ""
        txtAddress.Text = ""
        txtNumberOfImport.Text = "0"
        txtNumberOfExport.Text = "0"
        Warehouse.Clear()
    End Sub

    Private Sub bAdd_Click(sender As Object, e As EventArgs) Handles bAdd.Click
        clearValue()
        setEnable(True)
        addEditDeleteEnabled(False)
        warehouseId = clsPMSAnalysis.AddWarehouse("", "", 0, 0, LoginForm.PropUsername)
        isSaved = False
    End Sub

    Private Sub dgvCategory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategory.CellClick
        setEnable(False)
        setValue()
        addEditDeleteEnabled(True)
        If Not isSaved Then
            clsPMSAnalysis.DeleteCompletelyWarehouse(warehouseId)
            clsPMSAnalysis.DeleteCompletelySalesDetail(warehouseId)
        End If
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        If checkLogicData() Then
            Dim result As Integer
            Dim selectedWarehouse = txtCode.Text
            Dim type As String = "Update"

            If txtCode.Text = "" Then          'Add new
                type = "Add"
                selectedWarehouse = warehouseId
            End If
            result = clsPMSAnalysis.UpdateWarehouse(selectedWarehouse, txtName.Text, txtAddress.Text, txtNumberOfImport.Text, txtNumberOfExport.Text, LoginForm.PropUsername)
            If result = 1 Then
                setEnable(False)
                MsgBox(type & " warehouse information successful!")
                Reload()
                bAdd.Enabled = True
                isSaved = True
            Else
                MsgBox("There is an error when interact with database!")
            End If
        End If
    End Sub

    Private Function checkLogicData() As Boolean
        If txtName.Text = "" Or txtAddress.Text = "" Or txtNumberOfImport.Text = "" Or
            txtNumberOfExport.Text = "" Then

            MsgBox("You need to enter all the fields!")
            Return False

        ElseIf Not CheckValue("Warehouse code", txtCode.Text, "Long") Or
            Not CheckValue("Number of import", txtNumberOfImport.Text, "Long") Or
            Not CheckValue("Number of export", txtNumberOfExport.Text, "Long") Then
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

    Private Sub bDelete_Click(sender As Object, e As EventArgs) Handles bDelete.Click
        If dgvCategory.CurrentRow IsNot Nothing Then
            Dim warehouseId = CLng(dgvCategory.CurrentRow.Cells(0).Value.ToString)
            Dim result = clsPMSAnalysis.DeleteWarehouse(warehouseId, LoginForm.PropUsername)
            If result = 1 Then
                MsgBox("Delete warehouse information successful!")
                Reload()
            Else
                MsgBox("There is an error when interact with database!")
            End If

        End If
    End Sub

    Private Sub bAddProduct_Click(sender As Object, e As EventArgs) Handles bAddProduct.Click
        Dim newForm As New AddEditProductForm
        newForm.warehouseId = warehouseId
        If txtCode.Text <> "" Then
            newForm.warehouseId = txtCode.Text
        End If

        If newForm.ShowDialog() = DialogResult.OK Then
            txtNumberOfImport.Text = clsPMSAnalysis.GetWarehouseById(newForm.warehouseId).Rows(0)(3)
        End If
    End Sub

    Private Sub dgvProduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduct.CellContentClick
        Select Case dgvProduct.Columns(e.ColumnIndex).Name
            Case "Edit"
                Dim newForm As New AddEditProductForm
                If (txtCode.Text <> "") Then
                    newForm.warehouseId = txtCode.Text
                Else
                    newForm.warehouseId = warehouseId
                End If
                newForm.productId = dgvProduct.CurrentRow.Cells(0).Value.ToString
                If newForm.ShowDialog() = DialogResult.OK Then

                End If

            Case "Delete"
                Dim result = clsProduct.DeleteProduct(LoginForm.PropUsername, dgvProduct.CurrentRow.Cells(0).Value.ToString)
                If result = 1 Then
                    result = clsProduct.DeleteSalesDetail(dgvProduct.CurrentRow.Cells(0).Value.ToString)
                End If
                If result = 1 Then
                    MsgBox("Delete product information successful!")
                    Dim selectedWarehouse = If(txtCode.Text = "", warehouseId, txtCode.Text)
                    Warehouse.Clear()
                    Warehouse.Merge(clsPMSAnalysis.GetProductsOfWarehouse(selectedWarehouse))
                Else
                    MsgBox("There is an error when interact with database!")
                End If
        End Select
    End Sub

    Private Sub WarehouseCategory_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not isSaved Then
            clsPMSAnalysis.DeleteCompletelyWarehouse(warehouseId)
            clsPMSAnalysis.DeleteCompletelySalesDetail(warehouseId)
        End If
    End Sub

End Class