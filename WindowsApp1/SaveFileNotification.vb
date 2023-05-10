Public Class SaveFileNotification
    Public path As String = ""
    Private Sub SaveFileNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labNotify.Text = "Export successfully in " & path & "! Do you want to open this file?"
    End Sub

    Private Sub bOpenFile_Click(sender As Object, e As EventArgs) Handles bOpenFile.Click
        Dim file As String = path
        If My.Computer.FileSystem.FileExists(file) Then
            Process.Start(file)
        Else
            MsgBox("File isn't exist! Perhaps file has been moved or renamed!")
        End If
        Me.Close()
    End Sub

    Private Sub bExit_Click(sender As Object, e As EventArgs) Handles bExit.Click
        Me.Close()
    End Sub
End Class