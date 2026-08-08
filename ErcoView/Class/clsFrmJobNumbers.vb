Imports System.Data.SqlClient

Public Class clsFrmJobNumbers
    WithEvents oFrmJobNumbers As New frmJobNumbers
    Public currentJobNumber As Integer
    Public currentPID As Integer


    Public Sub ShowJobNumbers()
        oFrmJobNumbers.SpGetJobNumbersTableAdapter.Connection = New SqlClient.SqlConnection(GetConnectionString)
        oFrmJobNumbers.SpGetJobNumbersTableAdapter.Fill(oFrmJobNumbers.DsErcoView.spGetJobNumbers)
        If currentJobNumber <> 0 Then
            oFrmJobNumbers.cmboJobNumbers.EditValue = currentJobNumber
        End If
        oFrmJobNumbers.ShowDialog()
        If currentJobNumber <> 0 Then
            oFrmJobNumbers.cmboJobNumbers.EditValue = currentJobNumber
        End If

    End Sub

    Public Sub oFrmJobNumbers_eClickNewJob() Handles oFrmJobNumbers.eClickNewJob
        GetNewJobNo()
        SaveJob()
        oFrmJobNumbers.Close()
    End Sub

    Public Sub oFrmJobNumbers_eClickOK() Handles oFrmJobNumbers.eClickOK
        currentJobNumber = oFrmJobNumbers.cmboJobNumbers.EditValue
        SaveJob()
        oFrmJobNumbers.Close()
    End Sub

    Public Sub oFrmJobNumbers_eClickDelete() Handles oFrmJobNumbers.eClickDelete
        currentJobNumber = 1
        SaveJob()
        oFrmJobNumbers.Close()
    End Sub

    Public Sub oFrmJobNumbers_eClickCancel() Handles oFrmJobNumbers.eClickCancel
        oFrmJobNumbers.Close()
    End Sub

    Private Sub GetNewJobNo()
        Dim conString As String = GetConnectionString()
        Using connection As SqlConnection = New SqlConnection(conString)
            connection.Open()
            Try
                Dim command As SqlCommand = New SqlCommand("spGetNewJobNumber", connection) With {.CommandType = CommandType.StoredProcedure}
                command.Parameters.Add("@newJob", SqlDbType.Int).Direction = ParameterDirection.Output
                command.ExecuteNonQuery()
                currentJobNumber = command.Parameters("@newJob").Value
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private Sub SaveJob()
        Dim conString As String = GetConnectionString()
        Using connection As SqlConnection = New SqlConnection(conString)
            connection.Open()
            Try
                Dim command As SqlCommand = New SqlCommand("spUpdateJobNumber", connection) With {.CommandType = CommandType.StoredProcedure}
                command.Parameters.AddWithValue("@proposalID", currentPID)
                command.Parameters.AddWithValue("@newJob", currentJobNumber)
                command.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

End Class
