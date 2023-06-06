
Imports System.Data.SqlClient

Public Class clsAccount
    Dim ta As New AccountTableAdapters.AccountTableAdapter
    Dim taAccountStatus As New AccountTableAdapters.StatusTableAdapter
    Dim taPerson As New _PersonTableAdapters.PersonTableAdapter

    Private strConnTrans As String
    Private strAuditTrans As String
    Private conn As New SqlConnection
    Private connTransaction As New SqlConnection

    Public Sub New(ByVal strConn As String, Optional ByVal strConnTransaction As String = Nothing)
        strConnTrans = strConn
        conn = New SqlConnection(strConn)
        connTransaction = New SqlConnection(strConnTransaction)
    End Sub

    Public Function CheckUserExists(ByVal username As String, ByVal password As String) As Boolean
        ta.Connection = conn
        Dim account = ta.GetAccountByUsername(username)

        If account.Rows.Count > 0 Then
            'Verify
            Return SecurePasswordHasher.Verify(password, account.Rows(0)(1))
        Else
            Return False
        End If
    End Function
    Public Function CheckUsernameExists(ByVal username As String) As Boolean
        ta.Connection = conn
        Dim result = ta.CheckUsernameExists(username).Rows.Count
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function GetAccountByUsername(ByVal username As String) As Account.AccountDataTable
        ta.Connection = conn
        Return ta.GetAccountByUsername(username)
    End Function
    Public Function CheckUserWasDeleted(ByVal username As String) As Integer
        ta.Connection = conn
        Dim result = ta.CheckUserWasDeleted(username).Count
        If result > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function AddAccount(ByVal username As String, ByVal password As String, ByVal statusId As Integer, ByVal createUser As String, ByVal id As Long) As Integer
        ta.Connection = conn
        taPerson.Connection = conn
        Dim now = DateTime.Now
        Dim hash = SecurePasswordHasher.Hash(password)
        Dim result = ta.InsertAccount(username, hash, statusId, now, createUser)
        Dim result2 = 1
        If id <> -1 Then
            result2 = taPerson.UpdateUsername(username, now, createUser, id)
        End If
        If result = 1 And result2 = 1 Then
            Return 1
        Else
            Return 0
        End If


    End Function
    Public Function UpdateAccount(ByVal username As String, ByVal password As String, ByVal statusId As Integer, ByVal updateUser As String) As Integer
        ta.Connection = conn
        Dim hash = SecurePasswordHasher.Hash(password)
        Return ta.UpdateAccount(hash, statusId, DateTime.Now, updateUser, username)
    End Function
    Public Function UpdateAccountStatus(ByVal username As String, ByVal statusId As Integer, ByVal updateUser As String) As Integer
        ta.Connection = conn
        Return ta.UpdateAccountStatus(statusId, DateTime.Now, updateUser, username)
    End Function
    Public Function DeleteCompletelyAccount(ByVal username As String) As Integer
        If username IsNot Nothing Then
            ta.Connection = conn
            Return ta.DeleteCompletelyAccount(username)
        Else
            Return 0
        End If
    End Function
    Public Function GetStatusOfAccount(ByVal username As String) As Account.StatusDataTable
        taAccountStatus.Connection = conn
        Return taAccountStatus.GetData(username)
    End Function
End Class
