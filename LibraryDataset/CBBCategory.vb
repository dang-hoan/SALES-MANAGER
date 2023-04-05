Public Class CBBCategory
    Private categoryId As Integer
    Private categoryName As String

    Public Sub New(categoryId As Integer, categoryName As String)
        Me.categoryId = categoryId
        Me.categoryName = categoryName
    End Sub

    Public Property PropCategoryId As Integer
        Get
            Return categoryId
        End Get
        Set(value As Integer)
            categoryId = value
        End Set
    End Property

    Public Property PropCategoryName As String
        Get
            Return categoryName
        End Get
        Set(value As String)
            categoryName = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return categoryName
    End Function


End Class
