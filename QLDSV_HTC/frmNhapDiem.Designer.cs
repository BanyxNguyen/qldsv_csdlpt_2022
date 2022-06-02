namespace QLDSV_HTC
{
    partial class frmNhapDiem
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
            this.cmbChinhanh = new System.Windows.Forms.ComboBox();
            this.bdsGoc = new System.Windows.Forms.BindingSource(this.components);
            this.datasetchu = new QLDSV_HTC.QLDSV_HTCDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.get_SubcriberTableAdapter = new QLDSV_HTC.QLDSV_HTCDataSetTableAdapters.Get_SubcriberTableAdapter();
            this.tableAdapterManager = new QLDSV_HTC.QLDSV_HTCDataSetTableAdapters.TableAdapterManager();
            this.qLDSV_HTCDataSet1 = new QLDSV_HTC.QLDSV_HTCDataSet1();
            this.tableAdapterManager1 = new QLDSV_HTC.QLDSV_HTCDataSet1TableAdapters.TableAdapterManager();
            this.bdsDSSVDK = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DSSV_DANGKY_GETTableAdapter = new QLDSV_HTC.QLDSV_HTCDataSet1TableAdapters.SP_DSSV_DANGKY_GETTableAdapter();
            this.btGhi = new System.Windows.Forms.Button();
            this.btnhap = new System.Windows.Forms.Button();
            this.sP_DSSV_DANGKY_GETGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_CC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_GK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_CK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsLTC = new System.Windows.Forms.BindingSource(this.components);
            this.sP_Lay_Danh_Sach_LTCTableAdapter = new QLDSV_HTC.QLDSV_HTCDataSet1TableAdapters.SP_Lay_Danh_Sach_LTCTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.nIENKHOAToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nIENKHOAToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.hOCKYToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.hOCKYToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.btfillLTC = new System.Windows.Forms.ToolStripButton();
            this.sP_Lay_Danh_Sach_LTCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetchu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSSVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DSSV_DANGKY_GETGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLTC)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_Lay_Danh_Sach_LTCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbChinhanh
            // 
            this.cmbChinhanh.DataSource = this.bdsGoc;
            this.cmbChinhanh.DisplayMember = "TENCN";
            this.cmbChinhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChinhanh.FormattingEnabled = true;
            this.cmbChinhanh.Location = new System.Drawing.Point(51, 12);
            this.cmbChinhanh.Name = "cmbChinhanh";
            this.cmbChinhanh.Size = new System.Drawing.Size(233, 21);
            this.cmbChinhanh.TabIndex = 4;
            this.cmbChinhanh.ValueMember = "TENSERVER";
            this.cmbChinhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChinhanh_SelectedIndexChanged);
            // 
            // bdsGoc
            // 
            this.bdsGoc.DataMember = "Get_Subcriber";
            this.bdsGoc.DataSource = this.datasetchu;
            // 
            // datasetchu
            // 
            this.datasetchu.DataSetName = "QLDSV_HTCDataSet";
            this.datasetchu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Khoa :";
            // 
            // get_SubcriberTableAdapter
            // 
            this.get_SubcriberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_HTC.QLDSV_HTCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qLDSV_HTCDataSet1
            // 
            this.qLDSV_HTCDataSet1.DataSetName = "QLDSV_HTCDataSet1";
            this.qLDSV_HTCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.DANGKYTableAdapter = null;
            this.tableAdapterManager1.GIANGVIENTableAdapter = null;
            this.tableAdapterManager1.KHOATableAdapter = null;
            this.tableAdapterManager1.LayMaGVTableAdapter = null;
            this.tableAdapterManager1.LayTenMonHocTableAdapter = null;
            this.tableAdapterManager1.LOPTableAdapter = null;
            this.tableAdapterManager1.LOPTINCHITableAdapter = null;
            this.tableAdapterManager1.MONHOCTableAdapter = null;
            this.tableAdapterManager1.SINHVIENTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QLDSV_HTC.QLDSV_HTCDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsDSSVDK
            // 
            this.bdsDSSVDK.DataMember = "SP_DSSV_DANGKY_GET";
            this.bdsDSSVDK.DataSource = this.qLDSV_HTCDataSet1;
            // 
            // sP_DSSV_DANGKY_GETTableAdapter
            // 
            this.sP_DSSV_DANGKY_GETTableAdapter.ClearBeforeFill = true;
            // 
            // btGhi
            // 
            this.btGhi.Location = new System.Drawing.Point(731, 49);
            this.btGhi.Name = "btGhi";
            this.btGhi.Size = new System.Drawing.Size(75, 23);
            this.btGhi.TabIndex = 25;
            this.btGhi.Text = "Lưu điểm";
            this.btGhi.UseVisualStyleBackColor = true;
            this.btGhi.Click += new System.EventHandler(this.btGhi_Click);
            // 
            // btnhap
            // 
            this.btnhap.Location = new System.Drawing.Point(549, 49);
            this.btnhap.Name = "btnhap";
            this.btnhap.Size = new System.Drawing.Size(124, 23);
            this.btnhap.TabIndex = 24;
            this.btnhap.Text = "Lấy DSSV thuộc LTC";
            this.btnhap.UseVisualStyleBackColor = true;
            this.btnhap.Click += new System.EventHandler(this.btnhap_Click);
            // 
            // sP_DSSV_DANGKY_GETGridControl
            // 
            this.sP_DSSV_DANGKY_GETGridControl.DataSource = this.bdsDSSVDK;
            this.sP_DSSV_DANGKY_GETGridControl.Location = new System.Drawing.Point(10, 304);
            this.sP_DSSV_DANGKY_GETGridControl.MainView = this.gridView2;
            this.sP_DSSV_DANGKY_GETGridControl.Name = "sP_DSSV_DANGKY_GETGridControl";
            this.sP_DSSV_DANGKY_GETGridControl.Size = new System.Drawing.Size(899, 368);
            this.sP_DSSV_DANGKY_GETGridControl.TabIndex = 25;
            this.sP_DSSV_DANGKY_GETGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.sP_DSSV_DANGKY_GETGridControl.Click += new System.EventHandler(this.sP_DSSV_DANGKY_GETGridControl_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHOTEN,
            this.colDIEM_CC,
            this.colDIEM_GK,
            this.colDIEM_CK,
            this.gridColumn1});
            this.gridView2.GridControl = this.sP_DSSV_DANGKY_GETGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.AllowEdit = false;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 118;
            // 
            // colHOTEN
            // 
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.OptionsColumn.AllowEdit = false;
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            this.colHOTEN.Width = 233;
            // 
            // colDIEM_CC
            // 
            this.colDIEM_CC.FieldName = "DIEM_CC";
            this.colDIEM_CC.Name = "colDIEM_CC";
            this.colDIEM_CC.Visible = true;
            this.colDIEM_CC.VisibleIndex = 2;
            this.colDIEM_CC.Width = 126;
            // 
            // colDIEM_GK
            // 
            this.colDIEM_GK.FieldName = "DIEM_GK";
            this.colDIEM_GK.Name = "colDIEM_GK";
            this.colDIEM_GK.Visible = true;
            this.colDIEM_GK.VisibleIndex = 3;
            this.colDIEM_GK.Width = 120;
            // 
            // colDIEM_CK
            // 
            this.colDIEM_CK.FieldName = "DIEM_CK";
            this.colDIEM_CK.Name = "colDIEM_CK";
            this.colDIEM_CK.Visible = true;
            this.colDIEM_CK.VisibleIndex = 4;
            this.colDIEM_CK.Width = 86;
            // 
            // bdsLTC
            // 
            this.bdsLTC.DataMember = "SP_Lay_Danh_Sach_LTC";
            this.bdsLTC.DataSource = this.qLDSV_HTCDataSet1;
            // 
            // sP_Lay_Danh_Sach_LTCTableAdapter
            // 
            this.sP_Lay_Danh_Sach_LTCTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nIENKHOAToolStripLabel,
            this.nIENKHOAToolStripTextBox,
            this.hOCKYToolStripLabel,
            this.hOCKYToolStripTextBox,
            this.btfillLTC});
            this.fillToolStrip.Location = new System.Drawing.Point(77, 49);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(435, 25);
            this.fillToolStrip.TabIndex = 26;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // nIENKHOAToolStripLabel
            // 
            this.nIENKHOAToolStripLabel.Name = "nIENKHOAToolStripLabel";
            this.nIENKHOAToolStripLabel.Size = new System.Drawing.Size(65, 22);
            this.nIENKHOAToolStripLabel.Text = "Niên Khóa:";
            // 
            // nIENKHOAToolStripTextBox
            // 
            this.nIENKHOAToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nIENKHOAToolStripTextBox.Name = "nIENKHOAToolStripTextBox";
            this.nIENKHOAToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // hOCKYToolStripLabel
            // 
            this.hOCKYToolStripLabel.Name = "hOCKYToolStripLabel";
            this.hOCKYToolStripLabel.Size = new System.Drawing.Size(47, 22);
            this.hOCKYToolStripLabel.Text = "Học kỳ:";
            // 
            // hOCKYToolStripTextBox
            // 
            this.hOCKYToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hOCKYToolStripTextBox.Name = "hOCKYToolStripTextBox";
            this.hOCKYToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // btfillLTC
            // 
            this.btfillLTC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btfillLTC.Name = "btfillLTC";
            this.btfillLTC.Size = new System.Drawing.Size(107, 22);
            this.btfillLTC.Text = "Lấy danh sách LTC";
            this.btfillLTC.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // sP_Lay_Danh_Sach_LTCGridControl
            // 
            this.sP_Lay_Danh_Sach_LTCGridControl.DataSource = this.bdsLTC;
            this.sP_Lay_Danh_Sach_LTCGridControl.Location = new System.Drawing.Point(10, 78);
            this.sP_Lay_Danh_Sach_LTCGridControl.MainView = this.gridView1;
            this.sP_Lay_Danh_Sach_LTCGridControl.Name = "sP_Lay_Danh_Sach_LTCGridControl";
            this.sP_Lay_Danh_Sach_LTCGridControl.Size = new System.Drawing.Size(899, 220);
            this.sP_Lay_Danh_Sach_LTCGridControl.TabIndex = 26;
            this.sP_Lay_Danh_Sach_LTCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colTENMH,
            this.colNHOM,
            this.colHOTENGV});
            this.gridView1.GridControl = this.sP_Lay_Danh_Sach_LTCGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMALTC
            // 
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 0;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            // 
            // colNHOM
            // 
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 2;
            // 
            // colHOTENGV
            // 
            this.colHOTENGV.FieldName = "HOTENGV";
            this.colHOTENGV.Name = "colHOTENGV";
            this.colHOTENGV.Visible = true;
            this.colHOTENGV.VisibleIndex = 3;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "DIEM_HM";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            // 
            // frmNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 684);
            this.Controls.Add(this.sP_Lay_Danh_Sach_LTCGridControl);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.sP_DSSV_DANGKY_GETGridControl);
            this.Controls.Add(this.btGhi);
            this.Controls.Add(this.btnhap);
            this.Controls.Add(this.cmbChinhanh);
            this.Controls.Add(this.label1);
            this.Name = "frmNhapDiem";
            this.Text = "frmNhapDiem";
            this.Load += new System.EventHandler(this.frmNhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetchu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSSVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DSSV_DANGKY_GETGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLTC)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_Lay_Danh_Sach_LTCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChinhanh;
        private System.Windows.Forms.Label label1;
        private QLDSV_HTCDataSet datasetchu;
        private System.Windows.Forms.BindingSource bdsGoc;
        private QLDSV_HTCDataSetTableAdapters.Get_SubcriberTableAdapter get_SubcriberTableAdapter;
        private QLDSV_HTCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLDSV_HTCDataSet1 qLDSV_HTCDataSet1;
        private QLDSV_HTCDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource bdsDSSVDK;
        private QLDSV_HTCDataSet1TableAdapters.SP_DSSV_DANGKY_GETTableAdapter sP_DSSV_DANGKY_GETTableAdapter;
        private System.Windows.Forms.Button btGhi;
        private System.Windows.Forms.Button btnhap;
        private DevExpress.XtraGrid.GridControl sP_DSSV_DANGKY_GETGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_CC;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_GK;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_CK;
        private System.Windows.Forms.BindingSource bdsLTC;
        private QLDSV_HTCDataSet1TableAdapters.SP_Lay_Danh_Sach_LTCTableAdapter sP_Lay_Danh_Sach_LTCTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel nIENKHOAToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nIENKHOAToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel hOCKYToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox hOCKYToolStripTextBox;
        private System.Windows.Forms.ToolStripButton btfillLTC;
        private DevExpress.XtraGrid.GridControl sP_Lay_Danh_Sach_LTCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENGV;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}