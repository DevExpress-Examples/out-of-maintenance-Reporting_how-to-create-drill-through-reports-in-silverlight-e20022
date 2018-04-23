Imports Microsoft.VisualBasic
Imports System
Namespace Reports
	Partial Public Class OrderReport
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
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.labelCompany = New DevExpress.XtraReports.UI.XRLabel()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.northwind1 = New Reports.Northwind()
			Me.categoriesTableAdapter = New Reports.NorthwindTableAdapters.CategoriesTableAdapter()
			Me.customersTableAdapter = New Reports.NorthwindTableAdapters.CustomersTableAdapter()
			Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
			Me.xrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
			Me.labelOrderId = New DevExpress.XtraReports.UI.XRLabel()
			Me.ordersTableAdapter = New Reports.NorthwindTableAdapters.OrdersTableAdapter()
			Me.LabelStyle = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DataStyle = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.TitleStyle = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.LabelOddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
			CType(Me.northwind1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2, Me.labelCompany})
			Me.Detail.HeightF = 36.54167F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel2
			' 
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.ContactName")})
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(397.9169F, 0F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(252.0831F, 36.54167F)
			Me.xrLabel2.StyleName = "TitleStyle"
			Me.xrLabel2.StylePriority.UseTextAlignment = False
			Me.xrLabel2.Text = "xrLabel2"
			Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
			' 
			' labelCompany
			' 
			Me.labelCompany.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CompanyName")})
			Me.labelCompany.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.labelCompany.Name = "labelCompany"
			Me.labelCompany.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.labelCompany.SizeF = New System.Drawing.SizeF(397.9169F, 36.54167F)
			Me.labelCompany.StyleName = "TitleStyle"
			Me.labelCompany.StylePriority.UseTextAlignment = False
			Me.labelCompany.Text = "labelCompany"
			Me.labelCompany.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
			Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(535F, 10.00001F)
			Me.xrPageInfo2.Name = "xrPageInfo2"
			Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrPageInfo2.StylePriority.UseTextAlignment = False
			Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			' 
			' xrPageInfo1
			' 
			Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.xrPageInfo1.Name = "xrPageInfo1"
			Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
			Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(198.9583F, 23F)
			' 
			' northwind1
			' 
			Me.northwind1.DataSetName = "Northwind"
			Me.northwind1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' customersTableAdapter
			' 
			Me.customersTableAdapter.ClearBeforeFill = True
			' 
			' DetailReport
			' 
			Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1})
			Me.DetailReport.DataAdapter = Me.ordersTableAdapter
			Me.DetailReport.DataMember = "Customers.CustomersOrders"
			Me.DetailReport.DataSource = Me.northwind1
			Me.DetailReport.Level = 0
			Me.DetailReport.Name = "DetailReport"
			Me.DetailReport.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
			' 
			' Detail1
			' 
			Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLine1, Me.xrLabel16, Me.xrLabel15, Me.xrLabel14, Me.xrLabel13, Me.xrLabel12, Me.xrLabel11, Me.xrLabel10, Me.xrLabel9, Me.xrLabel8, Me.xrLabel7, Me.xrLabel6, Me.xrLabel5, Me.xrLabel4, Me.labelOrderId})
			Me.Detail1.HeightF = 95.40366F
			Me.Detail1.Name = "Detail1"
			' 
			' xrLine1
			' 
			Me.xrLine1.BorderWidth = 1
			Me.xrLine1.LineWidth = 3
			Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLine1.Name = "xrLine1"
			Me.xrLine1.SizeF = New System.Drawing.SizeF(650F, 3.403646F)
			Me.xrLine1.StylePriority.UseBorderWidth = False
			' 
			' xrLabel16
			' 
			Me.xrLabel16.EvenStyleName = "LabelStyle"
			Me.xrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(0F, 49.40368F)
			Me.xrLabel16.Name = "xrLabel16"
			Me.xrLabel16.OddStyleName = "LabelOddStyle"
			Me.xrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel16.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel16.StyleName = "LabelStyle"
			' 
			' xrLabel15
			' 
			Me.xrLabel15.EvenStyleName = "LabelStyle"
			Me.xrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(0F, 26.40356F)
			Me.xrLabel15.Name = "xrLabel15"
			Me.xrLabel15.OddStyleName = "LabelOddStyle"
			Me.xrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel15.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel15.StyleName = "LabelStyle"
			' 
			' xrLabel14
			' 
			Me.xrLabel14.EvenStyleName = "LabelStyle"
			Me.xrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(0F, 72.40359F)
			Me.xrLabel14.Name = "xrLabel14"
			Me.xrLabel14.OddStyleName = "LabelOddStyle"
			Me.xrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel14.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel14.StyleName = "LabelStyle"
			Me.xrLabel14.Text = "Invoice:"
			' 
			' xrLabel13
			' 
			Me.xrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrLabel13.EvenStyleName = "LabelStyle"
			Me.xrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(0.0001072884F, 3.403652F)
			Me.xrLabel13.Name = "xrLabel13"
			Me.xrLabel13.OddStyleName = "LabelOddStyle"
			Me.xrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel13.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel13.StyleName = "LabelStyle"
			Me.xrLabel13.StylePriority.UseBorders = False
			Me.xrLabel13.Text = "Address:"
			' 
			' xrLabel12
			' 
			Me.xrLabel12.EvenStyleName = "LabelStyle"
			Me.xrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(453.75F, 72.40366F)
			Me.xrLabel12.Name = "xrLabel12"
			Me.xrLabel12.OddStyleName = "LabelOddStyle"
			Me.xrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel12.SizeF = New System.Drawing.SizeF(81.24997F, 23F)
			Me.xrLabel12.StyleName = "LabelStyle"
			Me.xrLabel12.Text = "Shipped:"
			' 
			' xrLabel11
			' 
			Me.xrLabel11.EvenStyleName = "LabelStyle"
			Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(453.75F, 49.40367F)
			Me.xrLabel11.Name = "xrLabel11"
			Me.xrLabel11.OddStyleName = "LabelOddStyle"
			Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel11.SizeF = New System.Drawing.SizeF(81.24997F, 23F)
			Me.xrLabel11.StyleName = "LabelStyle"
			Me.xrLabel11.Text = "Required:"
			' 
			' xrLabel10
			' 
			Me.xrLabel10.EvenStyleName = "LabelStyle"
			Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(453.75F, 26.40368F)
			Me.xrLabel10.Name = "xrLabel10"
			Me.xrLabel10.OddStyleName = "LabelOddStyle"
			Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel10.SizeF = New System.Drawing.SizeF(81.24997F, 23F)
			Me.xrLabel10.StyleName = "LabelStyle"
			Me.xrLabel10.Text = "Ordered:"
			' 
			' xrLabel9
			' 
			Me.xrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CustomersOrders.ShippedDate", "{0:M/d/yyyy}")})
			Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(535.0001F, 72.40366F)
			Me.xrLabel9.Name = "xrLabel9"
			Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel9.SizeF = New System.Drawing.SizeF(114.9998F, 23F)
			Me.xrLabel9.StyleName = "DataStyle"
			Me.xrLabel9.Text = "xrLabel9"
			' 
			' xrLabel8
			' 
			Me.xrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CustomersOrders.ShipCountry")})
			Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(100F, 49.40368F)
			Me.xrLabel8.Name = "xrLabel8"
			Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel8.SizeF = New System.Drawing.SizeF(240.625F, 23F)
			Me.xrLabel8.StyleName = "DataStyle"
			Me.xrLabel8.Text = "xrLabel8"
			' 
			' xrLabel7
			' 
			Me.xrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CustomersOrders.ShipCity")})
			Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(100F, 26.40363F)
			Me.xrLabel7.Name = "xrLabel7"
			Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel7.SizeF = New System.Drawing.SizeF(240.625F, 23F)
			Me.xrLabel7.StyleName = "DataStyle"
			Me.xrLabel7.Text = "xrLabel7"
			' 
			' xrLabel6
			' 
			Me.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CustomersOrders.ShipAddress")})
			Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(100.0001F, 3.403664F)
			Me.xrLabel6.Name = "xrLabel6"
			Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel6.SizeF = New System.Drawing.SizeF(351.0415F, 23.00001F)
			Me.xrLabel6.StyleName = "DataStyle"
			Me.xrLabel6.StylePriority.UseBorders = False
			Me.xrLabel6.Text = "xrLabel6"
			' 
			' xrLabel5
			' 
			Me.xrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CustomersOrders.RequiredDate", "{0:M/d/yyyy}")})
			Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(535.0001F, 49.40367F)
			Me.xrLabel5.Name = "xrLabel5"
			Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel5.SizeF = New System.Drawing.SizeF(114.9999F, 23F)
			Me.xrLabel5.StyleName = "DataStyle"
			Me.xrLabel5.Text = "xrLabel5"
			' 
			' xrLabel4
			' 
			Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CustomersOrders.OrderDate", "{0:M/d/yyyy}")})
			Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(535.0001F, 26.40368F)
			Me.xrLabel4.Name = "xrLabel4"
			Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel4.SizeF = New System.Drawing.SizeF(114.9999F, 23F)
			Me.xrLabel4.StyleName = "DataStyle"
			Me.xrLabel4.Text = "xrLabel4"
			' 
			' labelOrderId
			' 
			Me.labelOrderId.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CustomersOrders.OrderID"), New DevExpress.XtraReports.UI.XRBinding("Tag", Nothing, "Customers.CustomersOrders.OrderID")})
			Me.labelOrderId.Font = New System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.labelOrderId.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(204))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(34))))))
			Me.labelOrderId.LocationFloat = New DevExpress.Utils.PointFloat(99.99986F, 72.40366F)
			Me.labelOrderId.Name = "labelOrderId"
			Me.labelOrderId.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.labelOrderId.SizeF = New System.Drawing.SizeF(240.625F, 23F)
			Me.labelOrderId.StyleName = "DataStyle"
			Me.labelOrderId.StylePriority.UseFont = False
			Me.labelOrderId.StylePriority.UseForeColor = False
			Me.labelOrderId.Text = "labelOrderId"
			' 
			' ordersTableAdapter
			' 
			Me.ordersTableAdapter.ClearBeforeFill = True
			' 
			' LabelStyle
			' 
			Me.LabelStyle.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(244))))), (CInt(Fix((CByte(188))))))
			Me.LabelStyle.Font = New System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.LabelStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(46))))), (CInt(Fix((CByte(46))))), (CInt(Fix((CByte(51))))))
			Me.LabelStyle.Name = "LabelStyle"
			Me.LabelStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' DataStyle
			' 
			Me.DataStyle.Font = New System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.DataStyle.Name = "DataStyle"
			Me.DataStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' TitleStyle
			' 
			Me.TitleStyle.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(147))))), (CInt(Fix((CByte(153))))), (CInt(Fix((CByte(148))))))
			Me.TitleStyle.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
			Me.TitleStyle.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.TitleStyle.BorderWidth = 1
			Me.TitleStyle.Font = New System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.TitleStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(244))))), (CInt(Fix((CByte(188))))))
			Me.TitleStyle.Name = "TitleStyle"
			Me.TitleStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F)
			' 
			' LabelOddStyle
			' 
			Me.LabelOddStyle.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(229))))), (CInt(Fix((CByte(201))))), (CInt(Fix((CByte(148))))))
			Me.LabelOddStyle.Font = New System.Drawing.Font("Verdana", 11.25F)
			Me.LabelOddStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(46))))), (CInt(Fix((CByte(46))))), (CInt(Fix((CByte(51))))))
			Me.LabelOddStyle.Name = "LabelOddStyle"
			Me.LabelOddStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' OrderReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport})
			Me.DataAdapter = Me.customersTableAdapter
			Me.DataMember = "Customers"
			Me.DataSource = Me.northwind1
			Me.Font = New System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.LabelStyle, Me.DataStyle, Me.TitleStyle, Me.LabelOddStyle})
			Me.Version = "11.1"
			CType(Me.northwind1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private labelCompany As DevExpress.XtraReports.UI.XRLabel
		Private northwind1 As Northwind
		Private categoriesTableAdapter As NorthwindTableAdapters.CategoriesTableAdapter
		Private customersTableAdapter As NorthwindTableAdapters.CustomersTableAdapter
		Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail1 As DevExpress.XtraReports.UI.DetailBand
		Private ordersTableAdapter As NorthwindTableAdapters.OrdersTableAdapter
		Private xrLabel9 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel8 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel7 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
		Private labelOrderId As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel14 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel13 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel12 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel11 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel10 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel16 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel15 As DevExpress.XtraReports.UI.XRLabel
		Private LabelStyle As DevExpress.XtraReports.UI.XRControlStyle
		Private DataStyle As DevExpress.XtraReports.UI.XRControlStyle
		Private TitleStyle As DevExpress.XtraReports.UI.XRControlStyle
		Private xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
		Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
		Private xrLine1 As DevExpress.XtraReports.UI.XRLine
		Private LabelOddStyle As DevExpress.XtraReports.UI.XRControlStyle
	End Class
End Namespace
