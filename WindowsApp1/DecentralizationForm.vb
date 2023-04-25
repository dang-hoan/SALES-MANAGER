Imports LibraryDataset
Imports LibraryCommon
Public Class DecentralizationForm
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsRolePermission(conn.connSales.ConnectionString)

    Private Sub DecentralizationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub SetEnable(ByVal valBoolean As Boolean)

    End Sub

    Private Sub Reload()
        Dim dataRole = clsPMSAnalysis.GetAllRoles()

        cbbRole.Items.Clear()
        For Each role In dataRole
            cbbRole.Items.Add(New CBBItem(role(0), role(1)))
        Next

    End Sub

    Private Sub bNewRole_Click(sender As Object, e As EventArgs) Handles bNewRole.Click
        Dim roleName = InputBox("Let's enter new role's name:", "Create new role")
        If roleName <> "" Then
            Dim result = clsPMSAnalysis.AddRole(roleName, LoginForm.PropUsername)
            If result = 1 Then
                MsgBox("Add new role successful!")
                Reload()
            Else
                MsgBox("There is an error when interact with database!")
            End If
        End If
    End Sub

    Private Sub bDeleteRole_Click(sender As Object, e As EventArgs) Handles bDeleteRole.Click
        If cbbRole.Text <> "" Then
            Dim result = clsPMSAnalysis.DeleteRole(CType(cbbRole.SelectedItem, CBBItem).PropItemId, LoginForm.PropUsername)
            If result = 1 Then
                MsgBox("Delete new role successful!")
                Reload()
            Else
                MsgBox("There is an error when interact with database!")
            End If
        End If
    End Sub
End Class