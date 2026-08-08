Public Class frmJobNumbers 
    Public Event eClickNewJob()
    Public Event eClickOK()
    Public Event eClickCancel()
    Public Event eClickDelete()


    Private Sub btnNewJobNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewJobNumber.Click
        RaiseEvent eClickNewJob()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        RaiseEvent eClickOK()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        RaiseEvent eClickCancel()
    End Sub



    Private Sub frmJobNumbers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SpGetJobNumbersTableAdapter.Fill(DsErcoView.spGetJobNumbers)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        RaiseEvent eClickDelete()
    End Sub
End Class