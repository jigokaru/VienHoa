using System.Data;
using VienHoa.IService;

namespace VienHoa.View
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters msSqlConnectionParameters3 = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery3 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table5 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join2 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters msSqlConnectionParameters4 = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery4 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table6 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column13 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column14 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression14 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column15 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression15 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column16 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression16 = new DevExpress.DataAccess.Sql.ColumnExpression();
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            btnSanPham = new DevExpress.XtraBars.BarButtonItem();
            btnDoanhNghiep = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            btnNhaMay = new DevExpress.XtraBars.BarButtonItem();
            btnDuAn = new DevExpress.XtraBars.BarButtonItem();
            btnNguyenLieu = new DevExpress.XtraBars.BarButtonItem();
            btnNhienLieu = new DevExpress.XtraBars.BarButtonItem();
            btnGayNongLenToanCau = new DevExpress.XtraBars.BarButtonItem();
            btnHeSoPhatThaiDien = new DevExpress.XtraBars.BarButtonItem();
            btnLoaiChatThai = new DevExpress.XtraBars.BarButtonItem();
            btnChatThai = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(components);
            chatThaisBindingSource2 = new System.Windows.Forms.BindingSource(components);
            chatThaisBindingSource1 = new System.Windows.Forms.BindingSource(components);
            doanhNghiepsBindingSource = new System.Windows.Forms.BindingSource(components);
            sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(components);
            chatThaisBindingSource = new System.Windows.Forms.BindingSource(components);
            appDbContextBindingSource = new System.Windows.Forms.BindingSource(components);
            doanhNghiepBindingSource = new System.Windows.Forms.BindingSource(components);
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnImport = new DevExpress.XtraEditors.SimpleButton();
            btnThemDuLieu = new DevExpress.XtraEditors.SimpleButton();
            tblMain = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            panel1 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chatThaisBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chatThaisBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doanhNghiepsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chatThaisBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doanhNghiepBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(45, 44, 45, 44);
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, ribbonControl1.SearchEditItem, barButtonItem1, ribbonGalleryBarItem1, barButtonItem2, btnSanPham, btnDoanhNghiep, barButtonItem5, barButtonGroup1, btnNhaMay, btnDuAn, btnNguyenLieu, btnNhienLieu, btnGayNongLenToanCau, btnHeSoPhatThaiDien, btnLoaiChatThai, btnChatThai, barButtonItem3 });
            ribbonControl1.Location = new System.Drawing.Point(0, 0);
            ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            ribbonControl1.MaxItemId = 18;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.OptionsMenuMinWidth = 495;
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1, ribbonPage2 });
            ribbonControl1.Size = new System.Drawing.Size(1311, 231);
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "barButtonItem1";
            barButtonItem1.Id = 1;
            barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonGalleryBarItem1
            // 
            ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            ribbonGalleryBarItem1.Id = 2;
            ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "Doanh Nghiệp";
            barButtonItem2.Hint = "Quản lý";
            barButtonItem2.Id = 3;
            barButtonItem2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem2.ImageOptions.SvgImage");
            barButtonItem2.Name = "barButtonItem2";
            barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipItem2.Text = "Quản lý doanh nghiệp";
            superToolTip2.Items.Add(toolTipItem2);
            barButtonItem2.SuperTip = superToolTip2;
            barButtonItem2.ItemClick += barButtonItem2_ItemClick;
            // 
            // btnSanPham
            // 
            btnSanPham.Caption = "Sản Phẩm";
            btnSanPham.Id = 4;
            btnSanPham.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnSanPham.ImageOptions.Image");
            btnSanPham.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnSanPham.ImageOptions.LargeImage");
            btnSanPham.Name = "btnSanPham";
            btnSanPham.ItemClick += btnSanPham_ItemClick;
            // 
            // btnDoanhNghiep
            // 
            btnDoanhNghiep.Caption = "Doanh Nghiệp";
            btnDoanhNghiep.Id = 5;
            btnDoanhNghiep.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnDoanhNghiep.ImageOptions.SvgImage");
            btnDoanhNghiep.Name = "btnDoanhNghiep";
            btnDoanhNghiep.ItemClick += btnDoanhNghiep_ItemClick;
            // 
            // barButtonItem5
            // 
            barButtonItem5.Caption = "Nhà Máy";
            barButtonItem5.Id = 6;
            barButtonItem5.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem5.ImageOptions.SvgImage");
            barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonGroup1
            // 
            barButtonGroup1.Caption = "barButtonGroup1";
            barButtonGroup1.Id = 7;
            barButtonGroup1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonGroup1.ImageOptions.SvgImage");
            barButtonGroup1.Name = "barButtonGroup1";
            // 
            // btnNhaMay
            // 
            btnNhaMay.Caption = "Nhà Máy";
            btnNhaMay.Id = 8;
            btnNhaMay.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnNhaMay.ImageOptions.SvgImage");
            btnNhaMay.Name = "btnNhaMay";
            btnNhaMay.ItemClick += btnNhaMay_ItemClick;
            // 
            // btnDuAn
            // 
            btnDuAn.Caption = "Dự Án";
            btnDuAn.Id = 9;
            btnDuAn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnDuAn.ImageOptions.SvgImage");
            btnDuAn.Name = "btnDuAn";
            btnDuAn.ItemClick += btnDuAn_ItemClick;
            // 
            // btnNguyenLieu
            // 
            btnNguyenLieu.Caption = "Nguyên Liệu";
            btnNguyenLieu.Id = 10;
            btnNguyenLieu.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnNguyenLieu.ImageOptions.Image");
            btnNguyenLieu.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnNguyenLieu.ImageOptions.LargeImage");
            btnNguyenLieu.Name = "btnNguyenLieu";
            btnNguyenLieu.ItemClick += btnNguyenLieu_ItemClick_1;
            // 
            // btnNhienLieu
            // 
            btnNhienLieu.Caption = "Nhiên Liệu";
            btnNhienLieu.Id = 11;
            btnNhienLieu.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnNhienLieu.ImageOptions.Image");
            btnNhienLieu.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnNhienLieu.ImageOptions.LargeImage");
            btnNhienLieu.Name = "btnNhienLieu";
            btnNhienLieu.ItemClick += btnNhienLieu_ItemClick_1;
            // 
            // btnGayNongLenToanCau
            // 
            btnGayNongLenToanCau.Caption = "Gây nóng lên toàn cầu";
            btnGayNongLenToanCau.Id = 13;
            btnGayNongLenToanCau.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnGayNongLenToanCau.ImageOptions.Image");
            btnGayNongLenToanCau.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnGayNongLenToanCau.ImageOptions.LargeImage");
            btnGayNongLenToanCau.Name = "btnGayNongLenToanCau";
            btnGayNongLenToanCau.ItemClick += btnGayNongLenToanCau_ItemClick;
            // 
            // btnHeSoPhatThaiDien
            // 
            btnHeSoPhatThaiDien.Caption = "Hệ số phát thải điện";
            btnHeSoPhatThaiDien.Id = 14;
            btnHeSoPhatThaiDien.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnHeSoPhatThaiDien.ImageOptions.Image");
            btnHeSoPhatThaiDien.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnHeSoPhatThaiDien.ImageOptions.LargeImage");
            btnHeSoPhatThaiDien.Name = "btnHeSoPhatThaiDien";
            btnHeSoPhatThaiDien.ItemClick += btnHeSoPhatThaiDien_ItemClick;
            // 
            // btnLoaiChatThai
            // 
            btnLoaiChatThai.Caption = "Loại chất thải";
            btnLoaiChatThai.Id = 15;
            btnLoaiChatThai.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnLoaiChatThai.ImageOptions.Image");
            btnLoaiChatThai.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnLoaiChatThai.ImageOptions.LargeImage");
            btnLoaiChatThai.Name = "btnLoaiChatThai";
            btnLoaiChatThai.ItemClick += btnLoaiChatThai_ItemClick;
            // 
            // btnChatThai
            // 
            btnChatThai.Caption = "Chất thải";
            btnChatThai.Id = 16;
            btnChatThai.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnChatThai.ImageOptions.Image");
            btnChatThai.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnChatThai.ImageOptions.LargeImage");
            btnChatThai.Name = "btnChatThai";
            btnChatThai.ItemClick += btnChatThai_ItemClick;
            // 
            // barButtonItem3
            // 
            barButtonItem3.Caption = "Sản Phẩm";
            barButtonItem3.Id = 17;
            barButtonItem3.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItem3.ImageOptions.Image");
            barButtonItem3.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItem3.ImageOptions.LargeImage");
            barButtonItem3.Name = "barButtonItem3";
            barButtonItem3.ItemClick += barButtonItem3_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup3, ribbonPageGroup1, ribbonPageGroup4, ribbonPageGroup5 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Dữ liệu";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(btnSanPham);
            ribbonPageGroup3.ItemLinks.Add(btnNguyenLieu);
            ribbonPageGroup3.ItemLinks.Add(btnNhienLieu);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            ribbonPageGroup3.Text = "Sản Phẩm";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(btnDoanhNghiep);
            ribbonPageGroup1.ItemLinks.Add(btnNhaMay);
            ribbonPageGroup1.ItemLinks.Add(btnDuAn);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "Doanh Nghiệp";
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.ItemLinks.Add(btnGayNongLenToanCau);
            ribbonPageGroup4.ItemLinks.Add(btnHeSoPhatThaiDien);
            ribbonPageGroup4.Name = "ribbonPageGroup4";
            ribbonPageGroup4.Text = "Gây nóng lên toàn cầu";
            // 
            // ribbonPageGroup5
            // 
            ribbonPageGroup5.ItemLinks.Add(btnLoaiChatThai);
            ribbonPageGroup5.ItemLinks.Add(btnChatThai);
            ribbonPageGroup5.Name = "ribbonPageGroup5";
            ribbonPageGroup5.Text = "Chất thải";
            // 
            // ribbonPage2
            // 
            ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2 });
            ribbonPage2.Name = "ribbonPage2";
            ribbonPage2.Text = "Tính toán";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(barButtonItem3);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage4
            // 
            ribbonPage4.Name = "ribbonPage4";
            ribbonPage4.Text = "ribbonPage4";
            // 
            // sqlDataSource2
            // 
            sqlDataSource2.ConnectionName = "localhost_dbVienHoa_Connection";
            msSqlConnectionParameters3.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.Windows;
            msSqlConnectionParameters3.DatabaseName = "dbVienHoa";
            msSqlConnectionParameters3.ServerName = "localhost";
            sqlDataSource2.ConnectionParameters = msSqlConnectionParameters3;
            sqlDataSource2.Name = "sqlDataSource2";
            columnExpression9.ColumnName = "Id";
            table4.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"123\" />";
            table4.Name = "chatThais";
            columnExpression9.Table = table4;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "TenLoaiChatThai";
            table5.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"103\" />";
            table5.Name = "loaiChatThais";
            columnExpression10.Table = table5;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "TenChatThai";
            columnExpression11.Table = table4;
            column11.Expression = columnExpression11;
            selectQuery3.Columns.Add(column9);
            selectQuery3.Columns.Add(column10);
            selectQuery3.Columns.Add(column11);
            selectQuery3.Name = "chatThais";
            relationColumnInfo2.NestedKeyColumn = "Id";
            relationColumnInfo2.ParentKeyColumn = "LoaiChatThaiId";
            join2.KeyColumns.Add(relationColumnInfo2);
            join2.Nested = table5;
            join2.Parent = table4;
            selectQuery3.Relations.Add(join2);
            selectQuery3.Tables.Add(table4);
            selectQuery3.Tables.Add(table5);
            sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] { selectQuery3 });
            sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // chatThaisBindingSource2
            // 
            chatThaisBindingSource2.DataMember = "chatThais";
            chatThaisBindingSource2.DataSource = sqlDataSource2;
            // 
            // chatThaisBindingSource1
            // 
            chatThaisBindingSource1.DataMember = "chatThais";
            chatThaisBindingSource1.DataSource = sqlDataSource2;
            // 
            // doanhNghiepsBindingSource
            // 
            doanhNghiepsBindingSource.DataMember = "doanhNghieps";
            doanhNghiepsBindingSource.DataSource = sqlDataSource1;
            // 
            // sqlDataSource1
            // 
            sqlDataSource1.ConnectionName = "localhost_dbVienHoa_Connection";
            msSqlConnectionParameters4.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.Windows;
            msSqlConnectionParameters4.DatabaseName = "dbVienHoa";
            msSqlConnectionParameters4.ServerName = "localhost";
            sqlDataSource1.ConnectionParameters = msSqlConnectionParameters4;
            sqlDataSource1.Name = "sqlDataSource1";
            columnExpression12.ColumnName = "Id";
            table6.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"163\" />";
            table6.Name = "doanhNghieps";
            columnExpression12.Table = table6;
            column12.Expression = columnExpression12;
            columnExpression13.ColumnName = "TenCongTy";
            columnExpression13.Table = table6;
            column13.Expression = columnExpression13;
            columnExpression14.ColumnName = "DiaChi";
            columnExpression14.Table = table6;
            column14.Expression = columnExpression14;
            columnExpression15.ColumnName = "DienThoai";
            columnExpression15.Table = table6;
            column15.Expression = columnExpression15;
            columnExpression16.ColumnName = "NguoiLienHe";
            columnExpression16.Table = table6;
            column16.Expression = columnExpression16;
            selectQuery4.Columns.Add(column12);
            selectQuery4.Columns.Add(column13);
            selectQuery4.Columns.Add(column14);
            selectQuery4.Columns.Add(column15);
            selectQuery4.Columns.Add(column16);
            selectQuery4.Name = "doanhNghieps";
            selectQuery4.Tables.Add(table6);
            sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] { selectQuery4 });
            sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // chatThaisBindingSource
            // 
            chatThaisBindingSource.DataSource = typeof(Entity.ChatThai);
            // 
            // appDbContextBindingSource
            // 
            appDbContextBindingSource.DataSource = typeof(DataEx.AppDbContext);
            // 
            // doanhNghiepBindingSource
            // 
            doanhNghiepBindingSource.DataSource = typeof(Entity.DoanhNghiep);
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(btnImport);
            panelControl1.Controls.Add(btnThemDuLieu);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Margin = new System.Windows.Forms.Padding(4);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(1281, 59);
            panelControl1.TabIndex = 1;
            // 
            // btnImport
            // 
            btnImport.Location = new System.Drawing.Point(1160, 10);
            btnImport.Margin = new System.Windows.Forms.Padding(4);
            btnImport.Name = "btnImport";
            btnImport.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            btnImport.Size = new System.Drawing.Size(117, 37);
            btnImport.TabIndex = 1;
            btnImport.Text = "Import Data";
            btnImport.Visible = false;
            btnImport.Click += btnImport_Click;
            // 
            // btnThemDuLieu
            // 
            btnThemDuLieu.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnThemDuLieu.ImageOptions.Image");
            btnThemDuLieu.Location = new System.Drawing.Point(1125, 6);
            btnThemDuLieu.Margin = new System.Windows.Forms.Padding(4);
            btnThemDuLieu.Name = "btnThemDuLieu";
            btnThemDuLieu.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            btnThemDuLieu.Size = new System.Drawing.Size(150, 44);
            btnThemDuLieu.TabIndex = 0;
            btnThemDuLieu.Text = "Thêm dữ liệu";
            btnThemDuLieu.Click += btnThemDuLieu_Click;
            // 
            // tblMain
            // 
            tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tblMain.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            tblMain.Location = new System.Drawing.Point(15, 92);
            tblMain.MainView = gridView1;
            tblMain.Margin = new System.Windows.Forms.Padding(4);
            tblMain.MenuManager = ribbonControl1;
            tblMain.Name = "tblMain";
            tblMain.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            tblMain.Size = new System.Drawing.Size(1281, 563);
            tblMain.TabIndex = 0;
            tblMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3 });
            gridView1.DetailHeight = 512;
            gridView1.GridControl = tblMain;
            gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "gridColumn1";
            gridColumn1.MinWidth = 30;
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            gridColumn1.Width = 112;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "gridColumn2";
            gridColumn2.MinWidth = 30;
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            gridColumn2.Width = 112;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "gridColumn3";
            gridColumn3.MinWidth = 30;
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            gridColumn3.Width = 96;
            // 
            // panel1
            // 
            panel1.Controls.Add(panelControl1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(15, 15);
            panel1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            panel1.Name = "panel1";
            panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 18);
            panel1.Size = new System.Drawing.Size(1281, 77);
            panel1.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(tblMain);
            panel3.Controls.Add(panel1);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(0, 231);
            panel3.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            panel3.Name = "panel3";
            panel3.Padding = new System.Windows.Forms.Padding(15);
            panel3.Size = new System.Drawing.Size(1311, 670);
            panel3.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1311, 901);
            Controls.Add(panel3);
            Controls.Add(ribbonControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4);
            MaximumSize = new System.Drawing.Size(1313, 902);
            MinimumSize = new System.Drawing.Size(880, 624);
            Name = "Form1";
            Ribbon = ribbonControl1;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chatThaisBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chatThaisBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)doanhNghiepsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)chatThaisBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)doanhNghiepBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tblMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private System.Windows.Forms.BindingSource doanhNghiepBindingSource;
        private System.Windows.Forms.BindingSource appDbContextBindingSource;
        private System.Windows.Forms.BindingSource chatThaisBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.BindingSource doanhNghiepsBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private System.Windows.Forms.BindingSource chatThaisBindingSource1;
        private System.Windows.Forms.BindingSource chatThaisBindingSource2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnThemDuLieu;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraGrid.GridControl tblMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraBars.BarButtonItem btnSanPham;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnDoanhNghiep;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem btnNhaMay;
        private DevExpress.XtraBars.BarButtonItem btnDuAn;
        private DevExpress.XtraBars.BarButtonItem btnNguyenLieu;
        private DevExpress.XtraBars.BarButtonItem btnNhienLieu;
        private DevExpress.XtraBars.BarButtonItem btnGayNongLenToanCau;
        private DevExpress.XtraBars.BarButtonItem btnHeSoPhatThaiDien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnLoaiChatThai;
        private DevExpress.XtraBars.BarButtonItem btnChatThai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraEditors.SimpleButton btnImport;
    }
}

