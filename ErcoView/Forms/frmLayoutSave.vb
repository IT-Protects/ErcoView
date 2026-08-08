Public Class frmLayoutSave
    Public permission As Integer


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        If userPermission = 3 Then ' Superintendent
            permission = 3
        Else
            If chkSuperintendentUser.CheckState = CheckState.Unchecked _
                        And chkGeneralUser.CheckState = CheckState.Unchecked Then
                permission = 1
            ElseIf chkGeneralUser.CheckState = CheckState.Checked _
                And chkSuperintendentUser.CheckState = CheckState.Unchecked Then
                permission = 2
            ElseIf chkSuperintendentUser.CheckState = CheckState.Checked Then
                permission = 3
            Else
                permission = -1
            End If
        End If


        DialogResult = Windows.Forms.DialogResult.OK
        Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Close()
    End Sub
End Class