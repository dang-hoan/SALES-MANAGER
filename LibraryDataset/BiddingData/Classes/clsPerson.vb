
Imports System.Data.SqlClient

Public Class clsPerson
    Dim ta As New _PersonTableAdapters.PersonTableAdapter
    Dim taRole As New _PersonTableAdapters.RoleTableAdapter
    Dim taName As New _PersonTableAdapters.NameTableAdapter

    Private strConnTrans As String
    Private strAuditTrans As String
    Private conn As New SqlConnection
    Private connTransaction As New SqlConnection

    Public Sub New(ByVal strConn As String, Optional ByVal strConnTransaction As String = Nothing)
        strConnTrans = strConn
        conn = New SqlConnection(strConn)
        connTransaction = New SqlConnection(strConnTransaction)
    End Sub

    Public Function GetName(ByVal userName) As String
        Return taName.GetData(userName).Rows(0)(0)
    End Function

    Public Function GetCustomers() As _Person
        Dim ds1 As New _Person
        ta.Connection = conn
        ta.FillByCustomers(ds1.Person)
        Return ds1
    End Function
    Public Function GetEmployees() As _Person
        Dim ds1 As New _Person
        ta.Connection = conn
        ta.FillByEmployees(ds1.Person)
        Return ds1
    End Function

    Public Function EditCustomer(userName As String, lastName As String, firstName As String,
                                gender As Boolean, birthDate As DateTime, phone As String,
                                email As String, address As String, updateUser As String, id As Long) As Integer
        ta.Connection = conn
        Return ta.UpdateCustomer(lastName, firstName, gender, birthDate, phone, email, address, DateTime.Now, updateUser, userName, id)
    End Function

    Public Function UpdateEmployee(userName As String, lastName As String, firstName As String,
                                gender As Boolean, birthDate As DateTime, phone As String,
                                email As String, address As String, roleId As Integer, updateUser As String, id As Long) As Integer
        ta.Connection = conn
        Return ta.UpdateEmployee(lastName, firstName, gender, birthDate, phone, email, address, roleId, DateTime.Now, updateUser, userName, id)
    End Function

    Public Function AddCustomer(userName As String, lastName As String, firstName As String,
                                gender As Boolean, birthDate As Date, phone As String,
                                email As String, address As String, createrUser As String) As Integer
        ta.Connection = conn
        taRole.Connection = conn
        Dim id As Integer = -1
        If taRole.GetIdCustomer().Count > 0 Then
            id = taRole.GetIdCustomer().Rows(0)(0)
        End If
        Return ta.InsertUser(userName, lastName, firstName, gender, birthDate, phone, email, address, id, DateTime.Now, createrUser, False)
    End Function
    Public Function AddEmployee(userName As String, lastName As String, firstName As String,
                                gender As Boolean, birthDate As Date, phone As String,
                                email As String, address As String, roleId As Integer, createrUser As String) As Integer
        ta.Connection = conn
        Return ta.InsertUser(userName, lastName, firstName, gender, birthDate, phone, email, address, roleId, DateTime.Now, createrUser, False)
    End Function

    Public Function CheckUsernameExits(ByVal username As String) As Boolean
        Dim ds As New _Person
        ta.Connection = conn
        Dim count = ta.GetUsernameMatch(username).Count
        If count > 0 Then
            Return True
        End If
        Return False
    End Function
    Public Function DeleteUser(ByVal deleteUsername As String, ByVal Id As Long) As Integer
        ta.Connection = conn
        Return ta.DeleteUser(DateTime.Now, deleteUsername, Id)
    End Function
End Class
