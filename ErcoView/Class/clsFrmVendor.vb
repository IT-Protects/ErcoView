Public Class clsFrmVendor
    Inherits clsFrmCustomer

    Public Sub New()
        isVendor = 1
    End Sub

    Public Overrides Sub InsertRow()
        isVendor = 1
        MyBase.InsertRow()
    End Sub
End Class
