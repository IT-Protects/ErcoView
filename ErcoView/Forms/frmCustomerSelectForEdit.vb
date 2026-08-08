Public Class frmCustomerSelectForEdit
    Dim _CustomerId1 As String
    Dim _CustomerId2 As String
    Dim _CustomerId3 As String

    Public selectedCustomer As Integer

    Public Sub New(ByVal oCustomerId1 As String, ByVal oCustomerId2 As String, ByVal oCustomerId3 As String)
        InitializeComponent()
        TextEdit1.Text = oCustomerId1
        TextEdit2.Text = oCustomerId2
        TextEdit3.Text = oCustomerId3
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub TextEdit1_DoubleClick(sender As Object, e As EventArgs) Handles TextEdit1.DoubleClick
        selectedCustomer = 1
        DialogResult = Windows.Forms.DialogResult.OK
        Close()
    End Sub

    Private Sub TextEdit2_DoubleClick(sender As Object, e As EventArgs) Handles TextEdit2.DoubleClick
        selectedCustomer = 2
        DialogResult = Windows.Forms.DialogResult.OK
        Close()
    End Sub

    Private Sub TextEdit3_DoubleClick(sender As Object, e As EventArgs) Handles TextEdit3.DoubleClick
        selectedCustomer = 3
        DialogResult = Windows.Forms.DialogResult.OK
        Close()
    End Sub

End Class