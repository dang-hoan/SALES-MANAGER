
Imports System.Data.SqlClient

Public Class clsPerson
    Dim ta As New PersonTableAdapters.PersonTableAdapter

    Private strConnTrans As String
    Private strAuditTrans As String
    Private conn As New SqlConnection
    Private connTransaction As New SqlConnection

    Public Sub New(ByVal strConn As String, Optional ByVal strConnTransaction As String = Nothing)
        strConnTrans = strConn
        conn = New SqlConnection(strConn)
        connTransaction = New SqlConnection(strConnTransaction)
    End Sub

    Public Function GetCustomers() As Person
        Dim ds1 As New Person
        ta.Connection = conn
        ta.FillByCustomers(ds1._Person)
        Return ds1
    End Function

    Public Function EditCustomer(userName As String, lastName As String, firstName As String,
                                gender As Boolean, birthDate As DateTime, phone As String,
                                email As String, address As String, updateUser As String) As Integer
        ta.Connection = conn
        Return ta.UpdateCustomer(lastName, firstName, gender, birthDate, phone, email, address, DateTime.Now, updateUser, userName)
    End Function

    Public Function AddCustomer(userName As String, lastName As String, firstName As String,
                                gender As Boolean, birthDate As Date, phone As String,
                                email As String, address As String, createrUser As String) As Integer
        ta.Connection = conn
        Return ta.InsertCustomer(userName, lastName, firstName, gender, birthDate, phone, email, address, DateTime.Now, createrUser, False)
    End Function
End Class
