
Imports System.Data.SqlClient

Public Class clsSupplier
    Dim ta As New SupplierTableAdapters.SupplierTableAdapter

    Private strConnTrans As String
    Private strAuditTrans As String
    Private conn As New SqlConnection
    Private connTransaction As New SqlConnection

    Public Sub New(ByVal strConn As String, Optional ByVal strConnTransaction As String = Nothing)
        strConnTrans = strConn
        conn = New SqlConnection(strConn)
        connTransaction = New SqlConnection(strConnTransaction)
    End Sub

    Public Function GetAllSuppliers() As Supplier.SupplierDataTable
        Dim ds1 As New Supplier
        ta.Connection = conn
        ta.Fill(ds1._Supplier)
        Return ds1._Supplier
    End Function

    Public Function AddSupplier(ByVal CompanyName As String, ByVal Address As String,
                                ByVal Phone As String, ByVal Email As String, ByVal Webpage As String,
                                ByVal Description As String, ByVal CreateUser As String) As Integer
        ta.Connection = conn
        Return ta.InsertSupplier(CompanyName, Address, Phone, Email, Webpage, Description,
                                 DateTime.Now, CreateUser)
    End Function

    Public Function UpdateSupplier(ByVal Id As Long, ByVal CompanyName As String, ByVal Address As String,
                                ByVal Phone As String, ByVal Email As String, ByVal Webpage As String,
                                ByVal Description As String, ByVal UpdateUser As String) As Integer
        ta.Connection = conn
        Return ta.UpdateSupplier(CompanyName, Address, Phone, Email, Webpage, Description,
                                 DateTime.Now, UpdateUser, Id)
    End Function

    Public Function DeleteSupplier(ByVal Id As Long, ByVal DeleteUser As String) As Integer
        ta.Connection = conn
        Return ta.DeleteSupplier(DateTime.Now, DeleteUser, Id)
    End Function

End Class
