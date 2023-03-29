Public Class Class1
#Region "Const and Variable"
    Public Shared connMeo As SqlConnection
    Public Shared connPhoto As SqlConnection
    Public Shared connDoc As SqlConnection
    Public Shared connTrans As SqlConnection
    Public Shared connCrewDoc As SqlConnection
    Public Shared strSPFolder As String = ""
#End Region

    Sub New(Optional ByVal strPathConn As String = "")
        Dim strConn As String = ""

        'If My.Settings.bolShipVersion = False Then
        Dim dsTb As New dsTable
        dsTb.Clear()
        If strPathConn = "" Then
            strPathConn = ".\Poseidon.dat"        
        End If
        dsTb.Merge(CsvToDataTable(dsTb.dtConn, strPathConn))

        Dim LQMeo = From a In dsTb.dtConn
                 Where a("Name") = "dbMeo"

        If LQMeo.Count <> 0 Then
            strConn = LQMeo.ToList.Item(0)(1).ToString
            connMeo = New SqlConnection(strConn)
        End If

        Dim LQPhoto = From a In dsTb.dtConn
                     Where a("Name") = "dbMeoPic"

        If LQPhoto.Count <> 0 Then
            strConn = LQPhoto.ToList.Item(0)(1).ToString
            connPhoto = New SqlConnection(strConn)
        End If

        Dim LQDoc = From a In dsTb.dtConn
         Where a("Name") = "dbMeoDocument"

        If LQDoc.Count <> 0 Then
            strConn = LQDoc.ToList.Item(0)(1).ToString
            connDoc = New SqlConnection(strConn)
        End If

        Dim LQTrans = From a In dsTb.dtConn
                     Where a("Name") = "dbMeoTrans"

        If LQTrans.Count <> 0 Then
            strConn = LQTrans.ToList.Item(0)(1).ToString
            connTrans = New SqlConnection(strConn)
        End If

        Dim LQCrewDoc = From a In dsTb.dtConn
             Where a("Name") = "dbMeoCrewDoc"

        If LQCrewDoc.Count <> 0 Then
            strConn = LQCrewDoc.ToList.Item(0)(1).ToString
            connCrewDoc = New SqlConnection(strConn)
        End If

        Dim LQSPFolder = From a In dsTb.dtConn
                         Where a("Name") = "SPFolder"


        If LQSPFolder.Count <> 0 Then
            strSPFolder = LQSPFolder.ToList.Item(0)(1).ToString
        End If
        ' End If
    End Sub
End Class
