Public Class CBBProduct
    Private productId As Integer
    Private productName As String

    Public Sub New(productId As Integer, productName As String)
        Me.productId = productId
        Me.productName = productName
    End Sub

    Public Property PropProductId As Integer
        Get
            Return productId
        End Get
        Set(value As Integer)
            productId = value
        End Set
    End Property
    Public Property PropProductName As String
        Get
            Return productName
        End Get
        Set(value As String)
            productName = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return productName
    End Function
End Class
