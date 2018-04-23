namespace Reports
{
    partial class OrderReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.labelCompany = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.northwind1 = new Reports.Northwind();
            this.categoriesTableAdapter = new Reports.NorthwindTableAdapters.CategoriesTableAdapter();
            this.customersTableAdapter = new Reports.NorthwindTableAdapters.CustomersTableAdapter();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.labelOrderId = new DevExpress.XtraReports.UI.XRLabel();
            this.ordersTableAdapter = new Reports.NorthwindTableAdapters.OrdersTableAdapter();
            this.LabelStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.TitleStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.LabelOddStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            ((System.ComponentModel.ISupportInitialize)(this.northwind1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.labelCompany});
            this.Detail.HeightF = 36.54167F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.ContactName")});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(397.9169F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(252.0831F, 36.54167F);
            this.xrLabel2.StyleName = "TitleStyle";
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "xrLabel2";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // labelCompany
            // 
            this.labelCompany.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.CompanyName")});
            this.labelCompany.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.labelCompany.SizeF = new System.Drawing.SizeF(397.9169F, 36.54167F);
            this.labelCompany.StyleName = "TitleStyle";
            this.labelCompany.StylePriority.UseTextAlignment = false;
            this.labelCompany.Text = "labelCompany";
            this.labelCompany.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2,
            this.xrPageInfo1});
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(535F, 10.00001F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrPageInfo2.StylePriority.UseTextAlignment = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(198.9583F, 23F);
            // 
            // northwind1
            // 
            this.northwind1.DataSetName = "Northwind";
            this.northwind1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1});
            this.DetailReport.DataAdapter = this.ordersTableAdapter;
            this.DetailReport.DataMember = "Customers.CustomersOrders";
            this.DetailReport.DataSource = this.northwind1;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            this.DetailReport.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrLabel16,
            this.xrLabel15,
            this.xrLabel14,
            this.xrLabel13,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.labelOrderId});
            this.Detail1.HeightF = 95.40366F;
            this.Detail1.Name = "Detail1";
            // 
            // xrLine1
            // 
            this.xrLine1.BorderWidth = 1;
            this.xrLine1.LineWidth = 3;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(650F, 3.403646F);
            this.xrLine1.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel16
            // 
            this.xrLabel16.EvenStyleName = "LabelStyle";
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(0F, 49.40368F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.OddStyleName = "LabelOddStyle";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel16.StyleName = "LabelStyle";
            // 
            // xrLabel15
            // 
            this.xrLabel15.EvenStyleName = "LabelStyle";
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(0F, 26.40356F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.OddStyleName = "LabelOddStyle";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel15.StyleName = "LabelStyle";
            // 
            // xrLabel14
            // 
            this.xrLabel14.EvenStyleName = "LabelStyle";
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(0F, 72.40359F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.OddStyleName = "LabelOddStyle";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel14.StyleName = "LabelStyle";
            this.xrLabel14.Text = "Invoice:";
            // 
            // xrLabel13
            // 
            this.xrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel13.EvenStyleName = "LabelStyle";
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(0.0001072884F, 3.403652F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.OddStyleName = "LabelOddStyle";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel13.StyleName = "LabelStyle";
            this.xrLabel13.StylePriority.UseBorders = false;
            this.xrLabel13.Text = "Address:";
            // 
            // xrLabel12
            // 
            this.xrLabel12.EvenStyleName = "LabelStyle";
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(453.75F, 72.40366F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.OddStyleName = "LabelOddStyle";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(81.24997F, 23F);
            this.xrLabel12.StyleName = "LabelStyle";
            this.xrLabel12.Text = "Shipped:";
            // 
            // xrLabel11
            // 
            this.xrLabel11.EvenStyleName = "LabelStyle";
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(453.75F, 49.40367F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.OddStyleName = "LabelOddStyle";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(81.24997F, 23F);
            this.xrLabel11.StyleName = "LabelStyle";
            this.xrLabel11.Text = "Required:";
            // 
            // xrLabel10
            // 
            this.xrLabel10.EvenStyleName = "LabelStyle";
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(453.75F, 26.40368F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.OddStyleName = "LabelOddStyle";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(81.24997F, 23F);
            this.xrLabel10.StyleName = "LabelStyle";
            this.xrLabel10.Text = "Ordered:";
            // 
            // xrLabel9
            // 
            this.xrLabel9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.CustomersOrders.ShippedDate", "{0:M/d/yyyy}")});
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(535.0001F, 72.40366F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(114.9998F, 23F);
            this.xrLabel9.StyleName = "DataStyle";
            this.xrLabel9.Text = "xrLabel9";
            // 
            // xrLabel8
            // 
            this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.CustomersOrders.ShipCountry")});
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(100F, 49.40368F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(240.625F, 23F);
            this.xrLabel8.StyleName = "DataStyle";
            this.xrLabel8.Text = "xrLabel8";
            // 
            // xrLabel7
            // 
            this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.CustomersOrders.ShipCity")});
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(100F, 26.40363F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(240.625F, 23F);
            this.xrLabel7.StyleName = "DataStyle";
            this.xrLabel7.Text = "xrLabel7";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.CustomersOrders.ShipAddress")});
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(100.0001F, 3.403664F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(351.0415F, 23.00001F);
            this.xrLabel6.StyleName = "DataStyle";
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.Text = "xrLabel6";
            // 
            // xrLabel5
            // 
            this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.CustomersOrders.RequiredDate", "{0:M/d/yyyy}")});
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(535.0001F, 49.40367F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(114.9999F, 23F);
            this.xrLabel5.StyleName = "DataStyle";
            this.xrLabel5.Text = "xrLabel5";
            // 
            // xrLabel4
            // 
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.CustomersOrders.OrderDate", "{0:M/d/yyyy}")});
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(535.0001F, 26.40368F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(114.9999F, 23F);
            this.xrLabel4.StyleName = "DataStyle";
            this.xrLabel4.Text = "xrLabel4";
            // 
            // labelOrderId
            // 
            this.labelOrderId.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.CustomersOrders.OrderID"),
            new DevExpress.XtraReports.UI.XRBinding("Tag", null, "Customers.CustomersOrders.OrderID")});
            this.labelOrderId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(34)))));
            this.labelOrderId.LocationFloat = new DevExpress.Utils.PointFloat(99.99986F, 72.40366F);
            this.labelOrderId.Name = "labelOrderId";
            this.labelOrderId.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.labelOrderId.SizeF = new System.Drawing.SizeF(240.625F, 23F);
            this.labelOrderId.StyleName = "DataStyle";
            this.labelOrderId.StylePriority.UseFont = false;
            this.labelOrderId.StylePriority.UseForeColor = false;
            this.labelOrderId.Text = "labelOrderId";
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // LabelStyle
            // 
            this.LabelStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(188)))));
            this.LabelStyle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.LabelStyle.Name = "LabelStyle";
            this.LabelStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DataStyle
            // 
            this.DataStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataStyle.Name = "DataStyle";
            this.DataStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // TitleStyle
            // 
            this.TitleStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(153)))), ((int)(((byte)(148)))));
            this.TitleStyle.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.TitleStyle.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.TitleStyle.BorderWidth = 1;
            this.TitleStyle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(188)))));
            this.TitleStyle.Name = "TitleStyle";
            this.TitleStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            // 
            // LabelOddStyle
            // 
            this.LabelOddStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(201)))), ((int)(((byte)(148)))));
            this.LabelOddStyle.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.LabelOddStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.LabelOddStyle.Name = "LabelOddStyle";
            this.LabelOddStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // OrderReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.DetailReport});
            this.DataAdapter = this.customersTableAdapter;
            this.DataMember = "Customers";
            this.DataSource = this.northwind1;
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.LabelStyle,
            this.DataStyle,
            this.TitleStyle,
            this.LabelOddStyle});
            this.Version = "11.1";
            ((System.ComponentModel.ISupportInitialize)(this.northwind1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel labelCompany;
        private Northwind northwind1;
        private NorthwindTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private NorthwindTableAdapters.CustomersTableAdapter customersTableAdapter;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private NorthwindTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel labelOrderId;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRControlStyle LabelStyle;
        private DevExpress.XtraReports.UI.XRControlStyle DataStyle;
        private DevExpress.XtraReports.UI.XRControlStyle TitleStyle;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRControlStyle LabelOddStyle;
    }
}
