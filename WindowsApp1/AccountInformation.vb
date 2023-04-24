Imports LibraryDataset
Imports LibraryCommon
Imports System.IO

Public Class AccountInformation
    Dim conn As New connCommon()
    Dim clsPMSAnalysis As New clsAccount(conn.connSales.ConnectionString)
    Dim clsCBB As New clsCBB(conn.connSales.ConnectionString)

    Public isView As Boolean = True
    Public employeeCode As Long = -1
    Public employeeUsername As String
    Public employeePassword As String = ""
    Private isShow As Boolean = False

    Private Sub AccountInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataStatus = clsCBB.GetCBBStatusOfAccount().CBBStatus

        For Each row As DataRow In dataStatus.Rows
            Dim item = New CBBItem(row(0), row(1))
            cbbStatus.Items.Add(item)
        Next
        cbbStatus.SelectedIndex = -1

        If employeeUsername IsNot Nothing Then
            Dim result = clsPMSAnalysis.GetAccountByUsername(employeeUsername).Rows
            If result.Count > 0 Then
                Dim account = result(0)
                txtCode.Text = account(0)
                txtPassword.Text = account(1)
                employeePassword = account(1)

                For Each item As CBBItem In cbbStatus.Items
                    If item.PropItemId = account(2) Then
                        cbbStatus.SelectedItem = item
                    End If
                Next

            End If
        End If

        If isView Then
            txtCode.Enabled = False
            txtPassword.Enabled = False
            cbbStatus.Enabled = False
            bSave.Visible = False
            bCancel.Visible = False
        Else
            If txtCode.Text <> "" Then
                txtCode.Enabled = False
            End If
        End If
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        If checkLogicData() Then
            Dim result As Integer
            Dim type As String = "Update"
            If txtCode.Enabled = False Then
                If txtPassword.Text.Equals(employeePassword) Then
                    result = clsPMSAnalysis.UpdateAccountStatus(txtCode.Text, CType(cbbStatus.SelectedItem, CBBItem).PropItemId, LoginForm.PropUsername)
                Else
                    result = clsPMSAnalysis.UpdateAccount(txtCode.Text, txtPassword.Text, CType(cbbStatus.SelectedItem, CBBItem).PropItemId, LoginForm.PropUsername)
                End If

            Else
                result = clsPMSAnalysis.AddAccount(txtCode.Text, txtPassword.Text, CType(cbbStatus.SelectedItem, CBBItem).PropItemId, LoginForm.PropUsername, employeeCode)
                type = "Add"
            End If

            If result = 1 Then
                MsgBox(type & " employee account successful!")
                Dim caller As EmployeeCategory = CType(Application.OpenForms("EmployeeCategory"), EmployeeCategory)
                caller.setAccountName(txtCode.Text)
                Me.Close()
            Else
                MsgBox(txtCode.Text & ", " & employeeUsername & ", " & employeeCode)
                MsgBox("There is an error when interact with database!")
            End If
        End If
    End Sub
    Private Function checkLogicData() As Boolean
        If txtCode.Text = "" Or txtPassword.Text = "" Or cbbStatus.SelectedIndex = -1 Then
            MsgBox("You need to enter all the fields!")
            Return False

        ElseIf clsPMSAnalysis.CheckUsernameExists(txtCode.Text) And txtCode.Enabled = True Then
            MsgBox("Account name already exists in the system! Let enter other account name")
            Return False
        End If

        Return True
    End Function
    Private Sub bCancel_Click(sender As Object, e As EventArgs) Handles bCancel.Click
        Me.Close()
    End Sub
    Private Sub labShowPassword_Click(sender As Object, e As EventArgs) Handles labShowPassword.Click
        isShow = Not isShow
        Dim pathFileExe = Application.StartupPath
        If isShow Then
            labShowPassword.Image = Image.FromFile(Path.Combine(pathFileExe, "../../Images/view2.png"))
            txtPassword.UseSystemPasswordChar = False
        Else
            labShowPassword.Image = Image.FromFile(Path.Combine(pathFileExe, "../../Images/hide2.png"))
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

End Class