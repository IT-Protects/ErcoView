Public Class frmList
    Public Event eClickOK()
    Public Event eClickCancel()

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        DialogResult = DialogResult.OK
        RaiseEvent eClickOK()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        'RaiseEvent eClickCancel()
    End Sub

    Private Sub lstItemList_ItemChecking(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ItemCheckingEventArgs) Handles lstItemList.ItemChecking
        If e.OldValue = False Then
            If lstItemList.CheckedItems.Count = 3 Then
                e.Cancel = True
                MsgBox("Max 3 selections allowed")
            End If
        End If
    End Sub
End Class