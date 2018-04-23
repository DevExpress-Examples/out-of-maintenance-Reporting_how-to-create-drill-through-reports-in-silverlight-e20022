Imports Microsoft.VisualBasic
Imports System
Namespace Reports
	Partial Public Class ProductReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim strip1 As New DevExpress.XtraCharts.Strip()
			Dim xyDiagramPane1 As New DevExpress.XtraCharts.XYDiagramPane()
			Dim secondaryAxisY1 As New DevExpress.XtraCharts.SecondaryAxisY()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim pointOptions1 As New DevExpress.XtraCharts.PointOptions()
			Dim sideBySideBarSeriesView1 As New DevExpress.XtraCharts.SideBySideBarSeriesView()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim sideBySideBarSeriesLabel2 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim pointOptions2 As New DevExpress.XtraCharts.PointOptions()
			Dim sideBySideBarSeriesView2 As New DevExpress.XtraCharts.SideBySideBarSeriesView()
			Dim sideBySideBarSeriesLabel3 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.ReportHeader1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrChart1 = New DevExpress.XtraReports.UI.XRChart()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.labelCategory = New DevExpress.XtraReports.UI.XRLabel()
			Me.StyleTitle = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.StyleHeader = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
			Me.labelProductName = New DevExpress.XtraReports.UI.XRLabel()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.productsTableAdapter1 = New Reports.NorthwindTableAdapters.ProductsTableAdapter()
			Me.northwind1 = New Reports.Northwind()
			Me.StyleDetailHeader = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.StyleEvenRow = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.categoriesTableAdapter = New Reports.NorthwindTableAdapters.CategoriesTableAdapter()
			Me.Category = New DevExpress.XtraReports.Parameters.Parameter()
			Me.xrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
			CType(Me.xrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(strip1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagramPane1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(secondaryAxisY1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.northwind1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' xrLabel1
			' 
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(650F, 51.125F)
			Me.xrLabel1.StyleName = "StyleTitle"
			Me.xrLabel1.Text = "Northwind Products"
			' 
			' ReportHeader1
			' 
			Me.ReportHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox2, Me.xrLabel10, Me.xrLabel11, Me.xrLabel8, Me.xrLabel9})
			Me.ReportHeader1.HeightF = 23F
			Me.ReportHeader1.Name = "ReportHeader1"
			' 
			' xrPictureBox2
			' 
			Me.xrPictureBox2.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
			Me.xrPictureBox2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Icon_17")})
			Me.xrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(23.95833F, 0F)
			Me.xrPictureBox2.Name = "xrPictureBox2"
			Me.xrPictureBox2.SizeF = New System.Drawing.SizeF(33.33334F, 23F)
			Me.xrPictureBox2.StyleName = "StyleDetailHeader"
			' 
			' xrLabel10
			' 
			Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(550F, 0F)
			Me.xrLabel10.Name = "xrLabel10"
			Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel10.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel10.StyleName = "StyleDetailHeader"
			Me.xrLabel10.Text = "In Stock"
			Me.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrLabel11
			' 
			Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(450F, 0F)
			Me.xrLabel11.Name = "xrLabel11"
			Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel11.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel11.StyleName = "StyleDetailHeader"
			Me.xrLabel11.Text = "Ordered"
			Me.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrLabel8
			' 
			Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(57.29168F, 0F)
			Me.xrLabel8.Name = "xrLabel8"
			Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel8.SizeF = New System.Drawing.SizeF(292.7083F, 23F)
			Me.xrLabel8.StyleName = "StyleDetailHeader"
			Me.xrLabel8.StylePriority.UseTextAlignment = False
			Me.xrLabel8.Text = "Product Name"
			Me.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrLabel9
			' 
			Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(350F, 0F)
			Me.xrLabel9.Name = "xrLabel9"
			Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel9.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel9.StyleName = "StyleDetailHeader"
			Me.xrLabel9.Text = "Price"
			Me.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPageInfo1
			' 
			Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 9.999974F)
			Me.xrPageInfo1.Name = "xrPageInfo1"
			Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
			Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(198.9583F, 23F)
			' 
			' xrPictureBox1
			' 
			Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture")})
			Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(13.95829F, 32.70833F)
			Me.xrPictureBox1.Name = "xrPictureBox1"
			Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(140F, 104.5833F)
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox3, Me.xrChart1, Me.xrLabel3, Me.labelCategory, Me.xrPictureBox1})
			Me.Detail.HeightF = 537.2916F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrChart1
			' 
			Me.xrChart1.BorderColor = System.Drawing.Color.Black
			Me.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None
			xyDiagram1.AxisX.Alignment = DevExpress.XtraCharts.AxisAlignment.Far
			xyDiagram1.AxisX.Label.Angle = 45
			xyDiagram1.AxisX.Label.Antialiasing = True
			xyDiagram1.AxisX.Label.Visible = False
			xyDiagram1.AxisX.Range.SideMarginsEnabled = True
			xyDiagram1.AxisX.Tickmarks.MinorVisible = False
			xyDiagram1.AxisX.Tickmarks.Visible = False
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1;0"
			xyDiagram1.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Far
			xyDiagram1.AxisY.Range.SideMarginsEnabled = True
			strip1.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(192))))))
			strip1.LegendText = "Minimum Reorder Level"
			strip1.MaxLimit.AxisValueSerializable = "25"
			strip1.MinLimit.AxisValueSerializable = "0"
			strip1.Name = "Min Reorder Level"
			xyDiagram1.AxisY.Strips.AddRange(New DevExpress.XtraCharts.Strip() { strip1})
			xyDiagram1.AxisY.Title.Text = "Units in Stock"
			xyDiagram1.AxisY.Title.Visible = True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagramPane1.Name = "Units on Order"
			xyDiagramPane1.PaneID = 0
			xyDiagram1.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() { xyDiagramPane1})
			secondaryAxisY1.AxisID = 0
			secondaryAxisY1.GridLines.Visible = True
			secondaryAxisY1.Name = "On Order Y"
			secondaryAxisY1.Range.SideMarginsEnabled = True
			secondaryAxisY1.Title.Text = "Units on Order"
			secondaryAxisY1.Title.Visible = True
			secondaryAxisY1.VisibleInPanesSerializable = "0"
			xyDiagram1.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() { secondaryAxisY1})
			Me.xrChart1.Diagram = xyDiagram1
			Me.xrChart1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.LeftOutside
			Me.xrChart1.Legend.Antialiasing = True
			Me.xrChart1.LocationFloat = New DevExpress.Utils.PointFloat(0.0001271566F, 144.5833F)
			Me.xrChart1.Name = "xrChart1"
			Me.xrChart1.PaletteRepository.Add("Susanne", New DevExpress.XtraCharts.Palette("Susanne", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() { New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(64)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(64))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Red, System.Drawing.Color.Red)}))
			series1.ArgumentDataMember = "Categories.CategoriesProducts.ProductName"
			sideBySideBarSeriesLabel1.Antialiasing = True
			sideBySideBarSeriesLabel1.LineVisible = True
			sideBySideBarSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
			sideBySideBarSeriesLabel1.Visible = False
			series1.Label = sideBySideBarSeriesLabel1
			pointOptions1.PointView = DevExpress.XtraCharts.PointView.Argument
			series1.LegendPointOptions = pointOptions1
			series1.Name = "Units in Stock"
			series1.SynchronizePointOptions = False
			series1.ValueDataMembersSerializable = "Categories.CategoriesProducts.UnitsInStock"
			sideBySideBarSeriesView1.ColorEach = True
			series1.View = sideBySideBarSeriesView1
			series2.ArgumentDataMember = "Categories.CategoriesProducts.ProductName"
			sideBySideBarSeriesLabel2.Antialiasing = True
			sideBySideBarSeriesLabel2.LineVisible = True
			series2.Label = sideBySideBarSeriesLabel2
			series2.LegendPointOptions = pointOptions2
			series2.Name = "Units on Order"
			series2.ShowInLegend = False
			series2.SynchronizePointOptions = False
			series2.ValueDataMembersSerializable = "Categories.CategoriesProducts.UnitsOnOrder"
			sideBySideBarSeriesView2.AxisYName = "On Order Y"
			sideBySideBarSeriesView2.ColorEach = True
			sideBySideBarSeriesView2.PaneName = "Units on Order"
			series2.View = sideBySideBarSeriesView2
			Me.xrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
			sideBySideBarSeriesLabel3.LineVisible = True
			Me.xrChart1.SeriesTemplate.Label = sideBySideBarSeriesLabel3
			Me.xrChart1.SeriesTemplate.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending
			Me.xrChart1.SizeF = New System.Drawing.SizeF(649.9999F, 392.7083F)
			' 
			' xrLabel3
			' 
			Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description")})
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(178.9584F, 73.62502F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(461.0416F, 40.95831F)
			Me.xrLabel3.Text = "xrLabel3"
			' 
			' labelCategory
			' 
			Me.labelCategory.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName"), New DevExpress.XtraReports.UI.XRBinding("Bookmark", Nothing, "Categories.CategoryName")})
			Me.labelCategory.LocationFloat = New DevExpress.Utils.PointFloat(178.9584F, 33.95834F)
			Me.labelCategory.Name = "labelCategory"
			Me.labelCategory.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.labelCategory.SizeF = New System.Drawing.SizeF(461.0416F, 39.66667F)
			Me.labelCategory.StyleName = "StyleHeader"
			Me.labelCategory.StylePriority.UseTextAlignment = False
			Me.labelCategory.Text = "labelCategory"
			Me.labelCategory.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
			' 
			' StyleTitle
			' 
			Me.StyleTitle.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(61))))), (CInt(Fix((CByte(60))))), (CInt(Fix((CByte(51))))))
			Me.StyleTitle.Font = New System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.StyleTitle.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(242))))), (CInt(Fix((CByte(240))))), (CInt(Fix((CByte(206))))))
			Me.StyleTitle.Name = "StyleTitle"
			Me.StyleTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.ReportHeader.HeightF = 51.125F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' StyleHeader
			' 
			Me.StyleHeader.BackColor = System.Drawing.Color.Empty
			Me.StyleHeader.Font = New System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.StyleHeader.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(174))))), (CInt(Fix((CByte(49))))), (CInt(Fix((CByte(53))))))
			Me.StyleHeader.Name = "StyleHeader"
			' 
			' Detail1
			' 
			Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel7, Me.xrLabel6, Me.xrLabel5, Me.labelProductName})
			Me.Detail1.HeightF = 23F
			Me.Detail1.Name = "Detail1"
			' 
			' xrLabel7
			' 
			Me.xrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitsOnOrder")})
			Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(450F, 0F)
			Me.xrLabel7.Name = "xrLabel7"
			Me.xrLabel7.OddStyleName = "StyleEvenRow"
			Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel7.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel7.StylePriority.UseTextAlignment = False
			Me.xrLabel7.Text = "xrLabel7"
			Me.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrLabel6
			' 
			Me.xrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitsInStock")})
			Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(550F, 0F)
			Me.xrLabel6.Name = "xrLabel6"
			Me.xrLabel6.OddStyleName = "StyleEvenRow"
			Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel6.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel6.StylePriority.UseTextAlignment = False
			Me.xrLabel6.Text = "xrLabel6"
			Me.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrLabel5
			' 
			Me.xrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitPrice", "{0:c}")})
			Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(350F, 0F)
			Me.xrLabel5.Name = "xrLabel5"
			Me.xrLabel5.OddStyleName = "StyleEvenRow"
			Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel5.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel5.StylePriority.UseTextAlignment = False
			Me.xrLabel5.Text = "xrLabel5"
			Me.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' labelProductName
			' 
			Me.labelProductName.BookmarkParent = Me.labelCategory
			Me.labelProductName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.ProductName"), New DevExpress.XtraReports.UI.XRBinding("Bookmark", Nothing, "Categories.CategoriesProducts.ProductName")})
			Me.labelProductName.LocationFloat = New DevExpress.Utils.PointFloat(23.95833F, 0F)
			Me.labelProductName.Name = "labelProductName"
			Me.labelProductName.OddStyleName = "StyleEvenRow"
			Me.labelProductName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.labelProductName.SizeF = New System.Drawing.SizeF(326.0417F, 23F)
			Me.labelProductName.StylePriority.UseTextAlignment = False
			Me.labelProductName.Text = "labelProductName"
			Me.labelProductName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo2, Me.xrPageInfo1})
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPageInfo2
			' 
			Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(539.9999F, 9.999974F)
			Me.xrPageInfo2.Name = "xrPageInfo2"
			Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrPageInfo2.StylePriority.UseTextAlignment = False
			Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			' 
			' DetailReport
			' 
			Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1, Me.ReportHeader1})
			Me.DetailReport.DataAdapter = Me.productsTableAdapter1
			Me.DetailReport.DataMember = "Categories.CategoriesProducts"
			Me.DetailReport.DataSource = Me.northwind1
			Me.DetailReport.Level = 0
			Me.DetailReport.Name = "DetailReport"
			Me.DetailReport.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
			' 
			' productsTableAdapter1
			' 
			Me.productsTableAdapter1.ClearBeforeFill = True
			' 
			' northwind1
			' 
			Me.northwind1.DataSetName = "Northwind"
			Me.northwind1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' StyleDetailHeader
			' 
			Me.StyleDetailHeader.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(61))))), (CInt(Fix((CByte(60))))), (CInt(Fix((CByte(51))))))
			Me.StyleDetailHeader.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.StyleDetailHeader.BorderWidth = 2
			Me.StyleDetailHeader.Font = New System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.StyleDetailHeader.Name = "StyleDetailHeader"
			Me.StyleDetailHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
			' 
			' StyleEvenRow
			' 
			Me.StyleEvenRow.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(242))))), (CInt(Fix((CByte(240))))), (CInt(Fix((CByte(206))))))
			Me.StyleEvenRow.Name = "StyleEvenRow"
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' Category
			' 
			Me.Category.Name = "Category"
			' 
			' xrPictureBox3
			' 
			Me.xrPictureBox3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Icon_17")})
			Me.xrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(23.95833F, 9.708341F)
			Me.xrPictureBox3.Name = "xrPictureBox3"
			Me.xrPictureBox3.SizeF = New System.Drawing.SizeF(100F, 23F)
			' 
			' ProductReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.DetailReport})
			Me.DataAdapter = Me.categoriesTableAdapter
			Me.DataMember = "Categories"
			Me.DataSource = Me.northwind1
			Me.FilterString = "StartsWith([CategoryName], ?Category)"
			Me.Font = New System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(61))))), (CInt(Fix((CByte(60))))), (CInt(Fix((CByte(51))))))
			Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.Category})
			Me.RequestParameters = False
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.StyleTitle, Me.StyleHeader, Me.StyleDetailHeader, Me.StyleEvenRow})
			Me.Version = "11.1"
			CType(strip1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagramPane1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(secondaryAxisY1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrChart1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.northwind1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private ReportHeader1 As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
		Private xrLabel10 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel11 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel8 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel9 As DevExpress.XtraReports.UI.XRLabel
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
		Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private xrChart1 As DevExpress.XtraReports.UI.XRChart
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private labelCategory As DevExpress.XtraReports.UI.XRLabel
		Private StyleTitle As DevExpress.XtraReports.UI.XRControlStyle
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private StyleHeader As DevExpress.XtraReports.UI.XRControlStyle
		Private Detail1 As DevExpress.XtraReports.UI.DetailBand
		Private xrLabel7 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
		Private labelProductName As DevExpress.XtraReports.UI.XRLabel
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
		Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand
		Private StyleDetailHeader As DevExpress.XtraReports.UI.XRControlStyle
		Private StyleEvenRow As DevExpress.XtraReports.UI.XRControlStyle
		Private productsTableAdapter1 As NorthwindTableAdapters.ProductsTableAdapter
		Private northwind1 As Northwind
		Private categoriesTableAdapter As NorthwindTableAdapters.CategoriesTableAdapter
		Private Category As DevExpress.XtraReports.Parameters.Parameter
		Private xrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox

	End Class
End Namespace
