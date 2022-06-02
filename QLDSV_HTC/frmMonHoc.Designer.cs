namespace QLDSV_HTC
{
    partial class frmMonHoc
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label sOTIET_LTLabel;
            System.Windows.Forms.Label sOTIET_THLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonHoc));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.DataSet_Site1 = new QLDSV_HTC.QLDSV_HTCDataSet1();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.MONHOCTableAdapter = new QLDSV_HTC.QLDSV_HTCDataSet1TableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new QLDSV_HTC.QLDSV_HTCDataSet1TableAdapters.TableAdapterManager();
            this.MONHOCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_LT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_TH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtSoTietTH = new DevExpress.XtraEditors.SpinEdit();
            this.txtSoTietLT = new DevExpress.XtraEditors.SpinEdit();
            this.txtTenMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.txtMaMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.bdsLopTinChi = new System.Windows.Forms.BindingSource(this.components);
            this.LOPTINCHITableAdapter = new QLDSV_HTC.QLDSV_HTCDataSet1TableAdapters.LOPTINCHITableAdapter();
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            sOTIET_LTLabel = new System.Windows.Forms.Label();
            sOTIET_THLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Site1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MONHOCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTietTH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTietLT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopTinChi)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(51, 91);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(68, 13);
            mAMHLabel.TabIndex = 1;
            mAMHLabel.Text = "Mã môn học:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(290, 91);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(45, 13);
            tENMHLabel.TabIndex = 3;
            tENMHLabel.Text = "TENMH:";
            // 
            // sOTIET_LTLabel
            // 
            sOTIET_LTLabel.AutoSize = true;
            sOTIET_LTLabel.Location = new System.Drawing.Point(51, 134);
            sOTIET_LTLabel.Name = "sOTIET_LTLabel";
            sOTIET_LTLabel.Size = new System.Drawing.Size(56, 13);
            sOTIET_LTLabel.TabIndex = 5;
            sOTIET_LTLabel.Text = "Số tiết LT:";
            // 
            // sOTIET_THLabel
            // 
            sOTIET_THLabel.AutoSize = true;
            sOTIET_THLabel.Location = new System.Drawing.Point(288, 138);
            sOTIET_THLabel.Name = "sOTIET_THLabel";
            sOTIET_THLabel.Size = new System.Drawing.Size(58, 13);
            sOTIET_THLabel.TabIndex = 7;
            sOTIET_THLabel.Text = "Số tiết TH:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnHieuChinh,
            this.btnGhi,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnReload,
            this.btnThoat});
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHieuChinh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThem.Glyph")));
            this.btnThem.Id = 0;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.Glyph")));
            this.btnHieuChinh.Id = 1;
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGhi.Glyph")));
            this.btnGhi.Id = 2;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.Glyph")));
            this.btnXoa.Id = 3;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.Glyph")));
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Glyph = ((System.Drawing.Image)(resources.GetObject("btnReload.Glyph")));
            this.btnReload.Id = 5;
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThoat.Glyph")));
            this.btnThoat.Id = 6;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(794, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 497);
            this.barDockControlBottom.Size = new System.Drawing.Size(794, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 450);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(794, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 450);
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 47);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(794, 38);
            this.panelControl1.TabIndex = 4;
            // 
            // DataSet_Site1
            // 
            this.DataSet_Site1.DataSetName = "QLDSV_HTCDataSet1";
            this.DataSet_Site1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.DataSet_Site1;
            // 
            // MONHOCTableAdapter
            // 
            this.MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.MONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_HTC.QLDSV_HTCDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // MONHOCGridControl
            // 
            this.MONHOCGridControl.DataSource = this.bdsMonHoc;
            this.MONHOCGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MONHOCGridControl.Location = new System.Drawing.Point(0, 85);
            this.MONHOCGridControl.MainView = this.gridView1;
            this.MONHOCGridControl.MenuManager = this.barManager1;
            this.MONHOCGridControl.Name = "MONHOCGridControl";
            this.MONHOCGridControl.Size = new System.Drawing.Size(794, 218);
            this.MONHOCGridControl.TabIndex = 6;
            this.MONHOCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colSOTIET_LT,
            this.colSOTIET_TH});
            this.gridView1.GridControl = this.MONHOCGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            // 
            // colSOTIET_LT
            // 
            this.colSOTIET_LT.FieldName = "SOTIET_LT";
            this.colSOTIET_LT.Name = "colSOTIET_LT";
            this.colSOTIET_LT.Visible = true;
            this.colSOTIET_LT.VisibleIndex = 2;
            // 
            // colSOTIET_TH
            // 
            this.colSOTIET_TH.FieldName = "SOTIET_TH";
            this.colSOTIET_TH.Name = "colSOTIET_TH";
            this.colSOTIET_TH.Visible = true;
            this.colSOTIET_TH.VisibleIndex = 3;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(sOTIET_THLabel);
            this.panelControl2.Controls.Add(this.txtSoTietTH);
            this.panelControl2.Controls.Add(sOTIET_LTLabel);
            this.panelControl2.Controls.Add(this.txtSoTietLT);
            this.panelControl2.Controls.Add(tENMHLabel);
            this.panelControl2.Controls.Add(this.txtTenMonHoc);
            this.panelControl2.Controls.Add(mAMHLabel);
            this.panelControl2.Controls.Add(this.txtMaMonHoc);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Enabled = false;
            this.panelControl2.Location = new System.Drawing.Point(0, 303);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(794, 194);
            this.panelControl2.TabIndex = 7;
            // 
            // txtSoTietTH
            // 
            this.txtSoTietTH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "SOTIET_TH", true));
            this.txtSoTietTH.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoTietTH.Location = new System.Drawing.Point(344, 135);
            this.txtSoTietTH.MenuManager = this.barManager1;
            this.txtSoTietTH.Name = "txtSoTietTH";
            this.txtSoTietTH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoTietTH.Size = new System.Drawing.Size(99, 20);
            this.txtSoTietTH.TabIndex = 8;
            // 
            // txtSoTietLT
            // 
            this.txtSoTietLT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "SOTIET_LT", true));
            this.txtSoTietLT.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoTietLT.Location = new System.Drawing.Point(118, 131);
            this.txtSoTietLT.MenuManager = this.barManager1;
            this.txtSoTietLT.Name = "txtSoTietLT";
            this.txtSoTietLT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoTietLT.Size = new System.Drawing.Size(100, 20);
            this.txtSoTietLT.TabIndex = 6;
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "TENMH", true));
            this.txtTenMonHoc.Location = new System.Drawing.Point(347, 88);
            this.txtTenMonHoc.MenuManager = this.barManager1;
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(166, 20);
            this.txtTenMonHoc.TabIndex = 4;
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "MAMH", true));
            this.txtMaMonHoc.Location = new System.Drawing.Point(118, 88);
            this.txtMaMonHoc.MenuManager = this.barManager1;
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(100, 20);
            this.txtMaMonHoc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin môn học";
            // 
            // bdsLopTinChi
            // 
            this.bdsLopTinChi.DataMember = "FK_LOPTINCHI_MONHOC";
            this.bdsLopTinChi.DataSource = this.bdsMonHoc;
            // 
            // LOPTINCHITableAdapter
            // 
            this.LOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(794, 520);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.MONHOCGridControl);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMonHoc";
            this.Text = "frmMonHoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Site1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MONHOCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTietTH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTietLT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopTinChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private QLDSV_HTCDataSet1 DataSet_Site1;
        private QLDSV_HTCDataSet1TableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
        private QLDSV_HTCDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl MONHOCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_LT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_TH;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit txtSoTietTH;
        private DevExpress.XtraEditors.SpinEdit txtSoTietLT;
        private DevExpress.XtraEditors.TextEdit txtTenMonHoc;
        private DevExpress.XtraEditors.TextEdit txtMaMonHoc;
        private System.Windows.Forms.BindingSource bdsLopTinChi;
        private QLDSV_HTCDataSet1TableAdapters.LOPTINCHITableAdapter LOPTINCHITableAdapter;
    }
}