Public Class CBBWareHouse
    Private wareHouseId As Integer
    Private wareHouseName As String

    Public Sub New(wareHouseId As Integer, wareHouseName As String)
        Me.wareHouseId = wareHouseId
        Me.wareHouseName = wareHouseName
    End Sub

    Public Property PropWareHouseId As Integer
        Get
            Return wareHouseId
        End Get
        Set(value As Integer)
            wareHouseId = value
        End Set
    End Property
    Public Property PropWareHouseName As String
        Get
            Return wareHouseName
        End Get
        Set(value As String)
            wareHouseName = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return wareHouseName
    End Function
End Class
