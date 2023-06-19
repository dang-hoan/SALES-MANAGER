
Imports System.Data.SqlClient

Public Class clsPerson
    Dim ta As New PersonTableAdapters.PersonViewTableAdapter
    Dim taRole As New PersonTableAdapters.RoleTableAdapter
    Dim taName As New PersonTableAdapters.NameTableAdapter
    Dim taAccount As New AccountTableAdapters.AccountTableAdapter

    Private conn As New SqlConnection

    Public Sub New(ByVal strConn As String)
        conn = New SqlConnection(strConn)
    End Sub

    Public Function GetName(ByVal userName) As String
        Return taName.GetData(userName).Rows(0)(0)
    End Function

    Public Function GetCustomers() As Person.PersonViewDataTable
        ta.Connection = conn
        Return ta.GetAllCustomers()
    End Function
    Public Function GetEmployees() As Person.PersonViewDataTable
        ta.Connection = conn
        Return ta.GetAllEmployees()
    End Function
    Public Function GetPersonById(ByVal id As Long) As DataRow
        ta.Connection = conn
        Return ta.GetPersonById(id).Rows(0)
    End Function

    Public Function GetAccountNameById(ByVal id As Long) As String
        ta.Connection = conn
        Return ta.GetAccountNameById(id)
    End Function

    Public Function UpdateCustomer(lastName As String, firstName As String,
                                gender As Boolean, birthDate As DateTime, phone As String,
                                email As String, address As String, updateUser As String, id As Long) As Integer
        ta.Connection = conn
        Return ta.UpdateCustomer(lastName, firstName, gender, birthDate, phone, email, address, DateTime.Now, updateUser, id)
    End Function

    Public Function UpdateEmployee(lastName As String, firstName As String,
                                gender As Boolean, birthDate As DateTime, phone As String,
                                email As String, address As String, roleId As Integer, updateUser As String, id As Long) As Integer
        ta.Connection = conn
        Return ta.UpdateEmployee(lastName, firstName, gender, birthDate, phone, email, address, roleId, DateTime.Now, updateUser, id)
    End Function

    Public Function AddCustomer(lastName As String, firstName As String,
                                gender As Boolean, birthDate As Date, phone As String,
                                email As String, address As String, createrUser As String) As Long
        ta.Connection = conn
        taRole.Connection = conn
        Dim id As Integer = -1
        If taRole.GetIdCustomer().Count > 0 Then
            id = taRole.GetIdCustomer().Rows(0)(0)
        End If
        Return ta.InsertUser(lastName, firstName, gender, birthDate, phone, email, address, id, DateTime.Now, createrUser, False)
    End Function
    Public Function AddEmployee(lastName As String, firstName As String,
                                gender As Boolean, birthDate As Date, phone As String,
                                email As String, address As String, roleId As Integer, createrUser As String) As Long
        ta.Connection = conn
        Return ta.InsertUser(lastName, firstName, gender, birthDate, phone, email, address, roleId, DateTime.Now, createrUser, False)
    End Function

    Public Function CheckUsernameExits(ByVal username As String) As Boolean
        Dim ds As New Person
        ta.Connection = conn
        Dim count = ta.GetUsernameMatch(username).Count
        If count > 0 Then
            Return True
        End If
        Return False
    End Function
    Public Function DeleteUser(ByVal deleteUsername As String, ByVal Id As Long) As Integer
        ta.Connection = conn
        Dim result1 = ta.DeleteUser(DateTime.Now, deleteUsername, Id)

        'Update into account table
        Dim result2 = 1
        Dim accountName = ta.GetAccountNameById(Id)
        If accountName IsNot Nothing Then
            result2 = taAccount.DeleteAccount(accountName)
        End If

        If result1 = 1 And result2 = 1 Then
            Return 1
        Else
            Return 0
        End If
    End Function
    Public Function SearchPerson(ByVal sqlCommand As String, Optional isEmployee As Boolean = True) As Person.PersonViewDataTable
        Dim ds As New Person

        Dim cmd = conn.CreateCommand()

        cmd.CommandText = $"SELECT *
                            FROM PersonView
                            WHERE IsDelete = 'False' AND {If(isEmployee, "RoleName NOT IN ('Customer')", "RoleName = 'Customer'")}" & sqlCommand

        ta.Connection = conn

        Dim tmp = cmd.CommandText.ToString()
        Console.WriteLine(tmp)

        ta.Adapter.SelectCommand = cmd
        ta.Adapter.Fill(ds.PersonView)

        Return ds.PersonView

    End Function

End Class
