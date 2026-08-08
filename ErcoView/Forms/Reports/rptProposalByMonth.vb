Imports System.Data.SqlClient

Public Class rptProposalByMonth
    Public Sub New(ByVal month As String, ByVal year As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' xrlMonth.Text = month
        ' xrlYear.Text = year
        xrlMonthFooter.Text = month
        'Dim oConnString As String = GetConnectionString()
        'Me.SpGetProposalsByMonthTableAdapter.Connection = New SqlConnection(oConnString)
        'Me.SpGetProposalsByMonthTableAdapter.Fill(Me.DsErcoView1.spGetProposalsByMonth, 0, "ALL", 2011)
    End Sub
End Class