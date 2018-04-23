Imports Microsoft.VisualBasic
Imports System
Namespace Reports
	Partial Public Class ProductLabels
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
			Dim dataMatrixGenerator1 As New DevExpress.XtraPrinting.BarCode.DataMatrixGenerator()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
			Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
			Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
			Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.northwind1 = New Reports.Northwind()
			Me.productsTableAdapter = New Reports.NorthwindTableAdapters.ProductsTableAdapter()
			CType(Me.northwind1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPanel1})
			Me.Detail.HeightF = 250F
			Me.Detail.MultiColumn.ColumnSpacing = 74F
			Me.Detail.MultiColumn.ColumnWidth = 338F
			Me.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown
			Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnWidth
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPanel1
			' 
			Me.xrPanel1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrPanel1.CanGrow = False
			Me.xrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox1, Me.xrLabel1, Me.xrBarCode1, Me.xrLabel4})
			Me.xrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrPanel1.Name = "xrPanel1"
			Me.xrPanel1.SizeF = New System.Drawing.SizeF(338F, 250F)
			' 
			' xrPictureBox1
			' 
			Me.xrPictureBox1.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrPictureBox1.ImageUrl = "C:\Projects\Icons\iconex_ap\48x48\plain\star_green.png"
			Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(256.125F, 174.2917F)
			Me.xrPictureBox1.Name = "xrPictureBox1"
			Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(71.875F, 65.70833F)
			Me.xrPictureBox1.StylePriority.UseBorders = False
			' 
			' xrLabel1
			' 
			Me.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName")})
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(318F, 29.25F)
			Me.xrLabel1.StylePriority.UseBorders = False
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' xrBarCode1
			' 
			Me.xrBarCode1.AutoModule = True
			Me.xrBarCode1.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrBarCode1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.EAN13", "{0:Product #}")})
			Me.xrBarCode1.Font = New System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.xrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 39.25002F)
			Me.xrBarCode1.Name = "xrBarCode1"
			Me.xrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F)
			Me.xrBarCode1.SizeF = New System.Drawing.SizeF(202.0833F, 200.75F)
			Me.xrBarCode1.StylePriority.UseBorders = False
			Me.xrBarCode1.StylePriority.UseFont = False
			Me.xrBarCode1.StylePriority.UseTextAlignment = False
			Me.xrBarCode1.Symbology = dataMatrixGenerator1
			Me.xrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
			' 
			' xrLabel4
			' 
			Me.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitPrice", "{0:c}")})
			Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(212.0833F, 39.25002F)
			Me.xrLabel4.Name = "xrLabel4"
			Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel4.SizeF = New System.Drawing.SizeF(115.9167F, 29.25F)
			Me.xrLabel4.StylePriority.UseBorders = False
			Me.xrLabel4.StylePriority.UseTextAlignment = False
			Me.xrLabel4.Text = "xrLabel2"
			Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' topMarginBand1
			' 
			Me.topMarginBand1.HeightF = 50F
			Me.topMarginBand1.Name = "topMarginBand1"
			' 
			' bottomMarginBand1
			' 
			Me.bottomMarginBand1.HeightF = 0F
			Me.bottomMarginBand1.Name = "bottomMarginBand1"
			' 
			' northwind1
			' 
			Me.northwind1.DataSetName = "Northwind"
			Me.northwind1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' ProductLabels
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.topMarginBand1, Me.bottomMarginBand1})
			Me.DataAdapter = Me.productsTableAdapter
			Me.DataMember = "Products"
			Me.DataSource = Me.northwind1
			Me.DetailPrintCountOnEmptyDataSource = 8
			Me.Font = New System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Margins = New System.Drawing.Printing.Margins(100, 0, 50, 0)
			Me.Version = "11.1"
			CType(Me.northwind1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private xrPanel1 As DevExpress.XtraReports.UI.XRPanel
		Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
		Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
		Private xrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
		Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
		Private northwind1 As Northwind
		Private productsTableAdapter As NorthwindTableAdapters.ProductsTableAdapter
		Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
