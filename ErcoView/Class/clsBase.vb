Public MustInherit Class clsBase
    Implements IErcoTableHandler

    Public MustOverride Sub InsertRow() Implements IErcoTableHandler.InsertRow
    Public MustOverride Sub SaveEvent() Implements IErcoTableHandler.SaveEvent
    Public MustOverride Function SetValues() As Boolean Implements IErcoTableHandler.SetValues
    Public MustOverride Sub ShowForm() Implements IErcoTableHandler.ShowForm
    Public MustOverride Sub UpdateRow() Implements IErcoTableHandler.UpdateRow

    Public ID As Integer
    Public didUpdate As Boolean

End Class
