namespace QLDSV_HTC
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnLopTinChi = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangKyLTC = new DevExpress.XtraBars.BarButtonItem();
            this.btNhapDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnDongHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDanhSachLTC = new DevExpress.XtraBars.BarButtonItem();
            this.btnInBangDiemMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDSDongHocPhiCuaLop = new DevExpress.XtraBars.BarButtonItem();
            this.tabHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tabDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tabNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PageDKLTC = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageNhapDiem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageDongHocPhi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tabBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pageInDSLTC = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageInBangDiem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageInDSHocPhi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MANV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnDangNhap,
            this.btnDangXuat,
            this.btnTaoTaiKhoan,
            this.btnLop,
            this.btnSinhVien,
            this.btnMonHoc,
            this.btnLopTinChi,
            this.btnDangKyLTC,
            this.btNhapDiem,
            this.btnDongHocPhi,
            this.btnInDanhSachLTC,
            this.btnInBangDiemMonHoc,
            this.btnInDSDongHocPhiCuaLop});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 14;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.tabHeThong,
            this.tabDanhMuc,
            this.tabNghiepVu,
            this.tabBaoCao});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(799, 143);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Glyph")));
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.LargeGlyph")));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Glyph")));
            this.btnDangXuat.Id = 2;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Caption = "Tạo tài khoản";
            this.btnTaoTaiKhoan.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTaoTaiKhoan.Glyph")));
            this.btnTaoTaiKhoan.Id = 3;
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTaiKhoan_ItemClick);
            // 
            // btnLop
            // 
            this.btnLop.Caption = "Lớp";
            this.btnLop.Id = 4;
            this.btnLop.Name = "btnLop";
            this.btnLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLop_ItemClick);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Caption = "Sinh viên";
            this.btnSinhVien.Id = 5;
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSinhVien_ItemClick);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Caption = "Môn học";
            this.btnMonHoc.Id = 6;
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMonHoc_ItemClick);
            // 
            // btnLopTinChi
            // 
            this.btnLopTinChi.Caption = "Lớp tín chỉ";
            this.btnLopTinChi.Id = 7;
            this.btnLopTinChi.Name = "btnLopTinChi";
            this.btnLopTinChi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLopTinChi_ItemClick);
            // 
            // btnDangKyLTC
            // 
            this.btnDangKyLTC.Caption = "Đăng ký lớp tín chỉ";
            this.btnDangKyLTC.Id = 8;
            this.btnDangKyLTC.Name = "btnDangKyLTC";
            this.btnDangKyLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangKyLTC_ItemClick);
            // 
            // btNhapDiem
            // 
            this.btNhapDiem.Caption = "Nhập điểm";
            this.btNhapDiem.Id = 9;
            this.btNhapDiem.Name = "btNhapDiem";
            this.btNhapDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // btnDongHocPhi
            // 
            this.btnDongHocPhi.Caption = "Đóng học phí";
            this.btnDongHocPhi.Id = 10;
            this.btnDongHocPhi.Name = "btnDongHocPhi";
            this.btnDongHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDongHocPhi_ItemClick);
            // 
            // btnInDanhSachLTC
            // 
            this.btnInDanhSachLTC.Caption = "In danh sách lớp tín chỉ";
            this.btnInDanhSachLTC.Id = 11;
            this.btnInDanhSachLTC.Name = "btnInDanhSachLTC";
            this.btnInDanhSachLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInDanhSachLTC_ItemClick);
            // 
            // btnInBangDiemMonHoc
            // 
            this.btnInBangDiemMonHoc.Caption = "In bảng điểm môn học";
            this.btnInBangDiemMonHoc.Id = 12;
            this.btnInBangDiemMonHoc.Name = "btnInBangDiemMonHoc";
            this.btnInBangDiemMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInBangDiemMonHoc_ItemClick);
            // 
            // btnInDSDongHocPhiCuaLop
            // 
            this.btnInDSDongHocPhiCuaLop.Caption = "In danh sách đóng học phí của lớp";
            this.btnInDSDongHocPhiCuaLop.Id = 13;
            this.btnInDSDongHocPhiCuaLop.Name = "btnInDSDongHocPhiCuaLop";
            this.btnInDSDongHocPhiCuaLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInDSDongHocPhiCuaLop_ItemClick);
            // 
            // tabHeThong
            // 
            this.tabHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.tabHeThong.Name = "tabHeThong";
            this.tabHeThong.Text = "Hệ thống";
            this.tabHeThong.Visible = false;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTaoTaiKhoan);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // tabDanhMuc
            // 
            this.tabDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.tabDanhMuc.Name = "tabDanhMuc";
            this.tabDanhMuc.Text = "Danh mục";
            this.tabDanhMuc.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLop);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Danh mục lớp";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSinhVien);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Danh sách sinh viên";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.btnMonHoc);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Danh sách môn học";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.btnLopTinChi);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Danh sách lớp tín chỉ";
            // 
            // tabNghiepVu
            // 
            this.tabNghiepVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PageDKLTC,
            this.pageNhapDiem,
            this.pageDongHocPhi});
            this.tabNghiepVu.Name = "tabNghiepVu";
            this.tabNghiepVu.Text = "Nghiệp vụ";
            this.tabNghiepVu.Visible = false;
            // 
            // PageDKLTC
            // 
            this.PageDKLTC.ItemLinks.Add(this.btnDangKyLTC);
            this.PageDKLTC.Name = "PageDKLTC";
            this.PageDKLTC.Text = "ribbonPageGroup6";
            // 
            // pageNhapDiem
            // 
            this.pageNhapDiem.ItemLinks.Add(this.btNhapDiem);
            this.pageNhapDiem.Name = "pageNhapDiem";
            this.pageNhapDiem.Text = "ribbonPageGroup7";
            // 
            // pageDongHocPhi
            // 
            this.pageDongHocPhi.ItemLinks.Add(this.btnDongHocPhi);
            this.pageDongHocPhi.Name = "pageDongHocPhi";
            this.pageDongHocPhi.Text = "ribbonPageGroup8";
            // 
            // tabBaoCao
            // 
            this.tabBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pageInDSLTC,
            this.pageInBangDiem,
            this.pageInDSHocPhi});
            this.tabBaoCao.Name = "tabBaoCao";
            this.tabBaoCao.Text = "Báo cáo";
            this.tabBaoCao.Visible = false;
            // 
            // pageInDSLTC
            // 
            this.pageInDSLTC.ItemLinks.Add(this.btnInDanhSachLTC);
            this.pageInDSLTC.Name = "pageInDSLTC";
            // 
            // pageInBangDiem
            // 
            this.pageInBangDiem.ItemLinks.Add(this.btnInBangDiemMonHoc);
            this.pageInBangDiem.Name = "pageInBangDiem";
            // 
            // pageInDSHocPhi
            // 
            this.pageInDSHocPhi.ItemLinks.Add(this.btnInDSDongHocPhiCuaLop);
            this.pageInDSHocPhi.Name = "pageInDSHocPhi";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(799, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MANV
            // 
            this.MANV.Name = "MANV";
            this.MANV.Size = new System.Drawing.Size(42, 17);
            this.MANV.Text = "MANV";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(45, 17);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(45, 17);
            this.NHOM.Text = "NHOM";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 445);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnTaoTaiKhoan;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MANV;
        private System.Windows.Forms.ToolStripStatusLabel HOTEN;
        private System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraBars.BarButtonItem btnLop;
        private DevExpress.XtraBars.BarButtonItem btnSinhVien;
        private DevExpress.XtraBars.BarButtonItem btnMonHoc;
        private DevExpress.XtraBars.BarButtonItem btnLopTinChi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnDangKyLTC;
        private DevExpress.XtraBars.BarButtonItem btNhapDiem;
        private DevExpress.XtraBars.BarButtonItem btnDongHocPhi;
        public DevExpress.XtraBars.Ribbon.RibbonPage tabHeThong;
        public DevExpress.XtraBars.Ribbon.RibbonPage tabDanhMuc;
        public DevExpress.XtraBars.Ribbon.RibbonPage tabNghiepVu;
        public DevExpress.XtraBars.Ribbon.RibbonPage tabBaoCao;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup PageDKLTC;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup pageNhapDiem;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup pageDongHocPhi;
        private DevExpress.XtraBars.BarButtonItem btnInDanhSachLTC;
        private DevExpress.XtraBars.BarButtonItem btnInBangDiemMonHoc;
        private DevExpress.XtraBars.BarButtonItem btnInDSDongHocPhiCuaLop;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup pageInDSHocPhi;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup pageInDSLTC;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup pageInBangDiem;
    }
}