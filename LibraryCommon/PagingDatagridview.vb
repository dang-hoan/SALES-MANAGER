Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Class PagingDatagridview

    Private _recordsPerPage As Integer = 10
    Private bs As BindingSource = New BindingSource()
    Private tables As BindingList(Of DataTable) = New BindingList(Of DataTable)()
    Public Property RecordsPerPage As Integer
        Get
            Return _recordsPerPage
        End Get
        Set(ByVal value As Integer)
            _recordsPerPage = value
        End Set
    End Property
    Public Sub SetPagedDataSource(ByVal dataTable As DataTable)
        Dim dt As DataTable = Nothing
        Dim counter As Integer = 1

        For Each dr As DataRow In dataTable.Rows
            If counter = 1 Then
                dt = dataTable.Clone()
                tables.Add(dt)
            End If

            dt.Rows.Add(dr.ItemArray)

            counter += 1
            If RecordsPerPage < counter Then
                counter = 1
            End If
        Next

        bindingNav.BindingSource = bs
        bs.DataSource = tables
        AddHandler bs.PositionChanged, AddressOf bs_PositionChanged
        bs_PositionChanged(bs, EventArgs.Empty)
    End Sub

    Private Sub bs_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.dgvData.DataSource = tables(bs.Position)
    End Sub
End Class
