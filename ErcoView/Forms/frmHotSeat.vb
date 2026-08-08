Imports System.Data.SqlClient
Public Class frmHotSeat


    Public pID As Int16
    Private Sub frmHotSeat_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim oConnString As String = GetConnectionString()
        SpGetProposalsTableAdapter.Connection = New SqlConnection(oConnString)
        SpGetProposalsTableAdapter.Fill(DsErcoView.spGetProposals, pID)
       
    End Sub
End Class