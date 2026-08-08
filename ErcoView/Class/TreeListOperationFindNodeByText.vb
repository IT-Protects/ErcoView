Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList.Nodes.Operations


Public Class TreeListOperationFindNodeByText
    Inherits TreeListOperation
    Private foundNode As TreeListNode
    Private column As Columns.TreeListColumn
    Private substr As String

    Public Sub New(ByVal column As Columns.TreeListColumn, ByVal substr As String)
        foundNode = Nothing
        Me.column = column
        Me.substr = substr
    End Sub

    Protected Sub New()
        
    End Sub


    Public Overrides Sub Execute(ByVal node As TreeListNode)
        Dim s As String = node(column).ToString()
        If s.StartsWith(substr) Then
            foundNode = node
        End If
    End Sub

    Public Overrides Function NeedsVisitChildren(ByVal node As TreeListNode) As Boolean
        Return foundNode Is Nothing
    End Function

    Public ReadOnly Property Node() As TreeListNode
        Get
            Return foundNode
        End Get
    End Property
End Class
