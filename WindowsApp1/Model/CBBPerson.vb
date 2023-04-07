Public Class CBBPerson
    Private itemId As String
    Private itemName As String

    Public Sub New(itemId As String, itemName As String)
        Me.itemId = itemId
        Me.itemName = itemName
    End Sub

    Public Property PropItemId As String
        Get
            Return itemId
        End Get
        Set(value As String)
            itemId = value
        End Set
    End Property

    Public Property PropItemName As String
        Get
            Return itemName
        End Get
        Set(value As String)
            itemName = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return itemName
    End Function


End Class
