
Imports System.Data.SqlClient

Public Class clsRolePermission
    Dim ta As New RoleTableAdapters.RoleTableAdapter
    Private conn As New SqlConnection

    Public Sub New(ByVal strConn As String)
        conn = New SqlConnection(strConn)
    End Sub

    Public Function GetAllRoles() As Role.RoleDataTable
        Dim ds1 As New Role.RoleDataTable
        ta.Connection = conn
        ta.Fill(ds1)
        Return ds1
    End Function

    Public Function AddRole(ByVal roleName As String, ByVal createUser As String) As Integer
        ta.Connection = conn
        Return ta.InsertRole(roleName, DateTime.Now, createUser)
    End Function

    Public Function UpdateRole(ByVal Id As Long, ByVal roleName As String, ByVal updateUser As String) As Integer
        ta.Connection = conn
        Return ta.UpdateRole(roleName, DateTime.Now, updateUser, Id)
    End Function

    Public Function DeleteRole(ByVal Id As Long, ByVal DeleteUser As String) As Integer
        ta.Connection = conn
        Return ta.DeleteRole(DateTime.Now, DeleteUser, Id)
    End Function

End Class
