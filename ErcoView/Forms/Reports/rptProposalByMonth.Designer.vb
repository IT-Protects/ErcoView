<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptProposalByMonth
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptProposalByMonth))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.SpGetProposalsByMonthTableAdapter = New ErcoView.dsErcoViewTableAdapters.spGetProposalsByMonthTableAdapter()
        Me.DsErcoView1 = New ErcoView.dsErcoView()
        Me.SpGetGroupsTableAdapter = New ErcoView.dsErcoViewTableAdapters.spGetGroupsTableAdapter()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageHeaderBand1 = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.FormattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrlTotalProjects = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrlMonthFooter = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.SpReportRevenueByMonthTableAdapter = New ErcoView.dsErcoViewTableAdapters.spReportRevenueByMonthTableAdapter()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsErcoView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.HeightF = 18.66798!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable2
        '
        Me.XrTable2.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 0.0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(850.5415!, 18.66798!)
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.XrTableCell4, Me.XrTableCell6, Me.XrTableCell8, Me.XrTableCell10, Me.XrTableCell12, Me.XrTableCell14})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.CanGrow = False
        Me.XrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spGetProposalsByMonth.JOB_NUMBER")})
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StyleName = "DataField"
        Me.XrTableCell2.Text = "XrTableCell2"
        Me.XrTableCell2.Weight = 14.46485937621728R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.CanGrow = False
        Me.XrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spGetProposalsByMonth.PROPOSAL_NUMBER")})
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StyleName = "DataField"
        Me.XrTableCell4.Text = "XrTableCell4"
        Me.XrTableCell4.Weight = 20.185773736974735R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.CanGrow = False
        Me.XrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spGetProposalsByMonth.CUSTOMER_TEXT")})
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StyleName = "DataField"
        Me.XrTableCell6.Weight = 41.137521170939706R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.CanGrow = False
        Me.XrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spGetProposalsByMonth.COUNTY")})
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StyleName = "DataField"
        Me.XrTableCell8.Weight = 17.740738763986194R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.CanGrow = False
        Me.XrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spGetProposalsByMonth.PRICE_TOTAL", "{0:$0.00}")})
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StyleName = "DataField"
        Me.XrTableCell10.Text = "XrTableCell10"
        Me.XrTableCell10.Weight = 20.129388190402342R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.CanGrow = False
        Me.XrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spGetProposalsByMonth.CONTRACT_STATUS")})
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.StyleName = "DataField"
        Me.XrTableCell12.Weight = 37.342908835693528R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.CanGrow = False
        Me.XrTableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spGetProposalsByMonth.STATUS")})
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.StyleName = "DataField"
        Me.XrTableCell14.Text = "XrTableCell14"
        Me.XrTableCell14.Weight = 60.675297587635129R
        '
        'SpGetProposalsByMonthTableAdapter
        '
        Me.SpGetProposalsByMonthTableAdapter.ClearBeforeFill = True
        '
        'DsErcoView1
        '
        Me.DsErcoView1.DataSetName = "dsErcoView"
        Me.DsErcoView1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpGetGroupsTableAdapter
        '
        Me.SpGetGroupsTableAdapter.ClearBeforeFill = True
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.White
        Me.Title.BorderColor = System.Drawing.SystemColors.ControlText
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Title.ForeColor = System.Drawing.Color.Navy
        Me.Title.Name = "Title"
        '
        'FieldCaption
        '
        Me.FieldCaption.BackColor = System.Drawing.Color.White
        Me.FieldCaption.BorderColor = System.Drawing.SystemColors.ControlText
        Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.FieldCaption.BorderWidth = 1
        Me.FieldCaption.Font = New System.Drawing.Font("Times New Roman", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.FieldCaption.ForeColor = System.Drawing.Color.Navy
        Me.FieldCaption.Name = "FieldCaption"
        '
        'PageInfo
        '
        Me.PageInfo.BackColor = System.Drawing.Color.White
        Me.PageInfo.BorderColor = System.Drawing.SystemColors.ControlText
        Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PageInfo.BorderWidth = 1
        Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.PageInfo.ForeColor = System.Drawing.Color.Navy
        Me.PageInfo.Name = "PageInfo"
        '
        'DataField
        '
        Me.DataField.BackColor = System.Drawing.Color.White
        Me.DataField.BorderColor = System.Drawing.SystemColors.ControlText
        Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DataField.BorderWidth = 1
        Me.DataField.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.DataField.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DataField.Name = "DataField"
        Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'PageHeaderBand1
        '
        Me.PageHeaderBand1.HeightF = 0.0!
        Me.PageHeaderBand1.Name = "PageHeaderBand1"
        '
        'XrTable1
        '
        Me.XrTable1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(6.000002!, 34.75001!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(887.0!, 40.0!)
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell3, Me.XrTableCell5, Me.XrTableCell7, Me.XrTableCell9, Me.XrTableCell11, Me.XrTableCell13})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.CanGrow = False
        Me.XrTableCell1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StyleName = "FieldCaption"
        Me.XrTableCell1.StylePriority.UseForeColor = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "Job Number"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell1.Weight = 14.464859331387135R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.CanGrow = False
        Me.XrTableCell3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StyleName = "FieldCaption"
        Me.XrTableCell3.StylePriority.UseForeColor = False
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "Proposal Number"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell3.Weight = 20.185765963572351R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.CanGrow = False
        Me.XrTableCell5.ForeColor = System.Drawing.Color.SaddleBrown
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StyleName = "FieldCaption"
        Me.XrTableCell5.StylePriority.UseForeColor = False
        Me.XrTableCell5.Text = "Customer"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell5.Weight = 40.888649565181261R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.CanGrow = False
        Me.XrTableCell7.ForeColor = System.Drawing.Color.SaddleBrown
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StyleName = "FieldCaption"
        Me.XrTableCell7.StylePriority.UseForeColor = False
        Me.XrTableCell7.Text = "County"
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell7.Weight = 17.740741754139428R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.CanGrow = False
        Me.XrTableCell9.ForeColor = System.Drawing.Color.SaddleBrown
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StyleName = "FieldCaption"
        Me.XrTableCell9.StylePriority.UseForeColor = False
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "Total Price"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell9.Weight = 20.378262693433733R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.CanGrow = False
        Me.XrTableCell11.ForeColor = System.Drawing.Color.SaddleBrown
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StyleName = "FieldCaption"
        Me.XrTableCell11.StylePriority.UseForeColor = False
        Me.XrTableCell11.Text = "Contract Status"
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell11.Weight = 37.09401041143628R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.CanGrow = False
        Me.XrTableCell13.ForeColor = System.Drawing.Color.SaddleBrown
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.StyleName = "FieldCaption"
        Me.XrTableCell13.StylePriority.UseForeColor = False
        Me.XrTableCell13.Text = "Job Status"
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell13.Weight = 69.997710280849816R
        '
        'PageFooterBand1
        '
        Me.PageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.XrPageInfo2})
        Me.PageFooterBand1.HeightF = 29.0!
        Me.PageFooterBand1.Name = "PageFooterBand1"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 6.0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(438.0!, 23.0!)
        Me.XrPageInfo1.StyleName = "PageInfo"
        Me.XrPageInfo1.StylePriority.UseForeColor = False
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.XrPageInfo2.Format = "Page {0} of {1}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(456.0!, 6.0!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(438.0!, 23.0!)
        Me.XrPageInfo2.StyleName = "PageInfo"
        Me.XrPageInfo2.StylePriority.UseForeColor = False
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'ReportHeaderBand1
        '
        Me.ReportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2})
        Me.ReportHeaderBand1.HeightF = 36.0!
        Me.ReportHeaderBand1.Name = "ReportHeaderBand1"
        '
        'XrLabel2
        '
        Me.XrLabel2.BorderColor = System.Drawing.Color.MediumBlue
        Me.XrLabel2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(23.95834!, 0.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(638.0!, 33.0!)
        Me.XrLabel2.StyleName = "Title"
        Me.XrLabel2.StylePriority.UseBorderColor = False
        Me.XrLabel2.StylePriority.UseForeColor = False
        Me.XrLabel2.Text = "ERCON INC."
        '
        'XrLabel3
        '
        Me.XrLabel3.BorderColor = System.Drawing.Color.MediumBlue
        Me.XrLabel3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(240.0221!, 33.0!)
        Me.XrLabel3.StyleName = "Title"
        Me.XrLabel3.StylePriority.UseBorderColor = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.Text = "Revenue Report for "
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 0.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'FormattingRule1
        '
        Me.FormattingRule1.Name = "FormattingRule1"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel7, Me.XrLabel5, Me.XrLabel1, Me.XrTable1, Me.XrLabel3})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("BOOK_MONTH", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 74.75001!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand
        '
        'XrLabel7
        '
        Me.XrLabel7.BorderColor = System.Drawing.Color.MediumBlue
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spGetProposalsByMonth.BOOK_YEAR")})
        Me.XrLabel7.ForeColor = System.Drawing.Color.SaddleBrown
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(360.2525!, 0.0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(240.0221!, 33.0!)
        Me.XrLabel7.StyleName = "Title"
        Me.XrLabel7.StylePriority.UseBorderColor = False
        Me.XrLabel7.StylePriority.UseForeColor = False
        Me.XrLabel7.Text = "XrLabel7"
        '
        'XrLabel5
        '
        Me.XrLabel5.BorderColor = System.Drawing.Color.MediumBlue
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spGetProposalsByMonth.BOOK_MONTH")})
        Me.XrLabel5.ForeColor = System.Drawing.Color.SaddleBrown
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(240.0221!, 0.0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(120.2304!, 33.0!)
        Me.XrLabel5.StyleName = "Title"
        Me.XrLabel5.StylePriority.UseBorderColor = False
        Me.XrLabel5.StylePriority.UseForeColor = False
        Me.XrLabel5.Text = "XrLabel5"
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spGetProposalsByMonth.BOOK_MONTH")})
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(910.0001!, 25.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel1.Text = "XrLabel1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel6, Me.xrlTotalProjects, Me.xrlMonthFooter, Me.XrLabel4, Me.XrTable3})
        Me.GroupFooter1.HeightF = 33.08334!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrLabel6
        '
        Me.XrLabel6.BorderColor = System.Drawing.Color.MediumBlue
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrLabel6.ForeColor = System.Drawing.Color.SaddleBrown
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(652.2343!, 9.842524!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(75.00018!, 21.71752!)
        Me.XrLabel6.StyleName = "Title"
        Me.XrLabel6.StylePriority.UseBorderColor = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseForeColor = False
        Me.XrLabel6.Text = "Projects"
        '
        'xrlTotalProjects
        '
        Me.xrlTotalProjects.BorderColor = System.Drawing.Color.MediumBlue
        Me.xrlTotalProjects.CanShrink = True
        Me.xrlTotalProjects.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spGetProposalsByMonth.CITY")})
        Me.xrlTotalProjects.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.xrlTotalProjects.ForeColor = System.Drawing.Color.SaddleBrown
        Me.xrlTotalProjects.LocationFloat = New DevExpress.Utils.PointFloat(623.0673!, 9.842524!)
        Me.xrlTotalProjects.Name = "xrlTotalProjects"
        Me.xrlTotalProjects.SizeF = New System.Drawing.SizeF(28.12506!, 21.71752!)
        Me.xrlTotalProjects.StyleName = "Title"
        Me.xrlTotalProjects.StylePriority.UseBorderColor = False
        Me.xrlTotalProjects.StylePriority.UseFont = False
        Me.xrlTotalProjects.StylePriority.UseForeColor = False
        XrSummary1.FormatString = "{0}"
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Count
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.xrlTotalProjects.Summary = XrSummary1
        Me.xrlTotalProjects.Text = "xrlTotalProjects"
        '
        'xrlMonthFooter
        '
        Me.xrlMonthFooter.BorderColor = System.Drawing.Color.MediumBlue
        Me.xrlMonthFooter.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.xrlMonthFooter.ForeColor = System.Drawing.Color.SaddleBrown
        Me.xrlMonthFooter.LocationFloat = New DevExpress.Utils.PointFloat(473.0673!, 9.842524!)
        Me.xrlMonthFooter.Name = "xrlMonthFooter"
        Me.xrlMonthFooter.SizeF = New System.Drawing.SizeF(31.25009!, 21.71752!)
        Me.xrlMonthFooter.StyleName = "Title"
        Me.xrlMonthFooter.StylePriority.UseBorderColor = False
        Me.xrlMonthFooter.StylePriority.UseFont = False
        Me.xrlMonthFooter.StylePriority.UseForeColor = False
        Me.xrlMonthFooter.Text = "Subtotal for"
        '
        'XrLabel4
        '
        Me.XrLabel4.BorderColor = System.Drawing.Color.MediumBlue
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrLabel4.ForeColor = System.Drawing.Color.SaddleBrown
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(387.6507!, 9.842524!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(83.3334!, 21.71752!)
        Me.XrLabel4.StyleName = "Title"
        Me.XrLabel4.StylePriority.UseBorderColor = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.Text = "Subtotal for"
        '
        'XrTable3
        '
        Me.XrTable3.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(521.5344!, 9.842523!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(78.74017!, 21.71752!)
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell19})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 0.609374843948467R
        '
        'XrTableCell19
        '
        Me.XrTableCell19.CanGrow = False
        Me.XrTableCell19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spGetProposalsByMonth.PRICE_TOTAL")})
        Me.XrTableCell19.ForeColor = System.Drawing.Color.SaddleBrown
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.StyleName = "FieldCaption"
        Me.XrTableCell19.StylePriority.UseForeColor = False
        XrSummary2.FormatString = "{0:$0.00}"
        XrSummary2.IgnoreNullValues = True
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell19.Summary = XrSummary2
        Me.XrTableCell19.Text = "XrTableCell19"
        Me.XrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell19.Weight = 19.596268223747771R
        '
        'SpReportRevenueByMonthTableAdapter
        '
        Me.SpReportRevenueByMonthTableAdapter.ClearBeforeFill = True
        '
        'rptProposalByMonth
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeaderBand1, Me.PageFooterBand1, Me.ReportHeaderBand1, Me.TopMarginBand1, Me.BottomMarginBand1, Me.GroupHeader1, Me.GroupFooter1})
        Me.DataAdapter = Me.SpGetProposalsByMonthTableAdapter
        Me.DataMember = "spReportRevenueByMonth"
        Me.DataSource = Me.DsErcoView1
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.FormattingRule1})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(40, 40, 0, 100)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "12.2"
        Me.Watermark.Font = New System.Drawing.Font("Verdana", 60.0!, System.Drawing.FontStyle.Italic)
        Me.Watermark.Image = CType(resources.GetObject("rptProposalByMonth.Watermark.Image"), System.Drawing.Image)
        Me.Watermark.ImageTransparency = 209
        Me.Watermark.ShowBehind = False
        Me.Watermark.Text = "CONFIDENTIAL"
        Me.Watermark.TextTransparency = 134
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsErcoView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents SpGetProposalsByMonthTableAdapter As ErcoView.dsErcoViewTableAdapters.spGetProposalsByMonthTableAdapter
    Friend WithEvents DsErcoView1 As ErcoView.dsErcoView
    Friend WithEvents SpGetGroupsTableAdapter As ErcoView.dsErcoViewTableAdapters.spGetGroupsTableAdapter
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageHeaderBand1 As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents ReportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents FormattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlTotalProjects As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlMonthFooter As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SpReportRevenueByMonthTableAdapter As ErcoView.dsErcoViewTableAdapters.spReportRevenueByMonthTableAdapter
End Class
