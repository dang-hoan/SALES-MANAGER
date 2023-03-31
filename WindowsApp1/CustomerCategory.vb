Imports LibraryDataset
Imports LibraryCommon

Public Class CustomerCategory
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsPerson(conn.connSales.ConnectionString)
    Private Sub CustomerCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data = clsPMSAnalysis.GetCustomers()
        dgvCategory.DataSource = data._Person

    End Sub

    Private Sub bEdit_Click(sender As Object, e As EventArgs) Handles bEdit.Click
        setEnable(True)
    End Sub

    Private Sub setEnable(valBoolean As Boolean)
        txtCustomerCode.Enabled = valBoolean
        txtCustomerName.Enabled = valBoolean
        txtPhone.Enabled = valBoolean
        txtAddress.Enabled = valBoolean
        dtBirthDay.Enabled = valBoolean
        rdMale.Enabled = valBoolean
        rdFemale.Enabled = valBoolean
        txtEmail.Enabled = valBoolean
    End Sub

    Private Sub bAdd_Click(sender As Object, e As EventArgs) Handles bAdd.Click

    End Sub

    Private Sub dgvCategory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategory.CellClick
        'Dim dgv As sender As DataGridView
        Dim row As DataGridViewRow = dgvCategory.CurrentRow
        If dgvCategory Is Nothing Then
            Return
        Else
            txtCustomerCode.Text = row.Cells(0).Value.ToString
            txtCustomerName.Text = row.Cells(1).Value.ToString & " " & row.Cells(2).Value.ToString
            dtBirthDay.Text = row.Cells(4).Value.ToString
            txtPhone.Text = row.Cells(5).Value.ToString
            txtEmail.Text = row.Cells(6).Value.ToString
            txtAddress.Text = row.Cells(7).Value.ToString
            If row.Cells(3).Value.ToString() = "Male" Then
                rdMale.Checked = True
            Else
                rdFemale.Checked = True
            End If
        End If
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        setEnable(False)
    End Sub
End Class