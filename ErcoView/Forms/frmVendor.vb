Public Class frmVendor 

    Private Sub frmVendor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsErcoView.spGetGroups' table. You can move, or remove it, as needed.
        Me.SpGetGroupsTableAdapter.Fill(Me.DsErcoView.spGetGroups)

    End Sub
End Class