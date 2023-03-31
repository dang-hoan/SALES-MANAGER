Imports System.Data.SqlClient

Public Class connCommon
    Public connSales As SqlConnection

    Sub New(Optional ByVal strPathConn As String = "")
        Dim strConn As String

        If strPathConn.Length > 0 Then
            strConn = strPathConn
        Else
            strConn = "Data Source=DESKTOP-DKTP37G\CSDL;Initial Catalog=SalesManagerDB;User ID=sa;Password=123456"
        End If

        connSales = New SqlConnection(strConn)
    End Sub


End Class
