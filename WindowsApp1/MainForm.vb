Public Class MainForm

    Private f As Form = Nothing
    Private Sub btnCategoryCustomer_Click(sender As Object, e As EventArgs) Handles btnCategoryCustomer.Click
        Dim frmCustomer As New CustomerCategory
        ShowForm(frmCustomer)
    End Sub

    Private Sub ShowForm(subForm As Form)
        If f IsNot Nothing Then f.Close()
        f = subForm

        subForm.TopLevel = False
        subForm.FormBorderStyle = FormBorderStyle.None
        subForm.Dock = DockStyle.Fill
        srcMain.Controls.Add(subForm)
        srcMain.Tag = subForm
        subForm.Show()
    End Sub

End Class