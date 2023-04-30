
Imports System.Data.SqlClient

Public Class clsRolePermission
    Dim ta As New RoleTableAdapters.RoleTableAdapter
    Dim taPermission As New RoleTableAdapters.PermissionTableAdapter
    Dim taRolePermission As New RoleTableAdapters.RolePermissionTableAdapter
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
    Public Function GetRolePermissionByRoleId(ByVal roleId As Long) As Role.PermissionDataTable
        taPermission.Connection = conn
        Return taPermission.GetPermissionsByRoleId(roleId)
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
    Public Function AddPermission(ByVal permissionName As String, ByVal createUser As String) As Long
        taPermission.Connection = conn
        Return taPermission.InsertPermission(permissionName, DateTime.Now, createUser)
    End Function

    Public Function UpdatePermission(ByVal id As Long, ByVal permissionName As String, ByVal updateUser As String) As Integer
        taPermission.Connection = conn
        Return taPermission.UpdatePermission(permissionName, DateTime.Now, updateUser, id)
    End Function

    Public Function CheckPermissionExists(ByVal permissionName As String) As Long?
        taPermission.Connection = conn
        Return taPermission.CheckPermissionExists(permissionName)
    End Function

    Public Function DeletePermisison(ByVal id As Long) As Integer
        taPermission.Connection = conn
        Return taPermission.DeletePermission(id)
    End Function
    Public Function AddRolePermission(ByVal roleId As Long, ByVal permissionId As Long) As Integer
        taRolePermission.Connection = conn
        Return taRolePermission.InsertRolePermission(roleId, permissionId)
    End Function

    Public Function DeleteRolePermisisonByRole(ByVal roleId As Long) As Integer
        taRolePermission.Connection = conn
        Return taRolePermission.DeleteRolePermissionByRole(roleId)
    End Function

End Class
