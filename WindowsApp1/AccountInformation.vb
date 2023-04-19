Imports LibraryDataset
Imports LibraryCommon
Public Class AccountInformation
    Dim conn As New connCommon()
    Dim clsCBB As New clsCBB(conn.connSales.ConnectionString)

    Public isView As Boolean = True
    Public employeeCode As String = ""

    Private Sub AccountInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCode.Text = employeeCode
        Dim dataStatus = clsCBB.GetCBBStatusOfAccount().CBBStatus

        For Each row As DataRow In dataStatus.Rows
            cbbStatus.Items.Add(New CBBItem(row(0), row(1)))
        Next

        If isView Then
            txtCode.Enabled = False
            txtPassword.Enabled = False
            cbbStatus.Enabled = False
            bSave.Visible = False
            bCancel.Visible = False
        End If
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        Dim caller As EmployeeCategory = CType(Application.OpenForms("EmployeeCategory"), EmployeeCategory)
        caller.SetEmployeeCode(txtCode.Text)
    End Sub

    Private Sub bCancel_Click(sender As Object, e As EventArgs) Handles bCancel.Click
        Me.Close()
    End Sub
End Class