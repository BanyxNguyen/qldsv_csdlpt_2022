namespace QLDSV_HTC
{
    partial class frptInBangDiemMonHoc
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
            this.get_SubcriberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_HTCDataSet = new QLDSV_HTC.QLDSV_HTCDataSet();
            this.get_SubcriberTableAdapter = new QLDSV_HTC.QLDSV_HTCDataSetTableAdapters.Get_SubcriberTableAdapter();
            this.tableAdapterManager = new QLDSV_HTC.QLDSV_HTCDataSetTableAdapters.TableAdapterManager();
            this.qLDSV_HTCDataSet1 = new QLDSV_HTC.QLDSV_HTCDataSet1();
            this.layTenMonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layTenMonHocTableAdapter = new QLDSV_HTC.QLDSV_HTCDataSet1TableAdapters.LayTenMonHocTableAdapter();
            this.tableAdapterManager1 = new QLDSV_HTC.QLDSV_HTCDataSet1TableAdapters.TableAdapterManager();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNhom = new DevExpress.XtraEditors.SpinEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXemReport = new DevExpress.XtraEditors.SimpleButton();
            this.txtHocKy = new DevExpress.XtraEditors.SpinEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.get_SubcriberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layTenMonHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // get_SubcriberBindingSource
            // 
            this.get_SubcriberBindingSource.DataMember = "Get_Subcriber";
            this.get_SubcriberBindingSource.DataSource = this.qLDSV_HTCDataSet;
            // 
            // qLDSV_HTCDataSet
            // 
            this.qLDSV_HTCDataSet.DataSetName = "QLDSV_HTCDataSet";
            this.qLDSV_HTCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // layTenMonHocBindingSource
            // 
            this.layTenMonHocBindingSource.DataMember = "LayTenMonHoc";
            this.layTenMonHocBindingSource.DataSource = this.qLDSV_HTCDataSet1;
            // 
            // layTenMonHocTableAdapter
            // 
            this.layTenMonHocTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DANGKYTableAdapter = null;
            this.tableAdapterManager1.GIANGVIENTableAdapter = null;
            this.tableAdapterManager1.KHOATableAdapter = null;
            this.tableAdapterManager1.LayMaGVTableAdapter = null;
            this.tableAdapterManager1.LayTenMonHocTableAdapter = this.layTenMonHocTableAdapter;
            this.tableAdapterManager1.LOPTableAdapter = null;
            this.tableAdapterManager1.LOPTINCHITableAdapter = null;
            this.tableAdapterManager1.MONHOCTableAdapter = null;
            this.tableAdapterManager1.SINHVIENTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QLDSV_HTC.QLDSV_HTCDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cmbMonHoc);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.txtNhom);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.cmbNienKhoa);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.btnXemReport);
            this.panelControl1.Controls.Add(this.txtHocKy);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Location = new System.Drawing.Point(78, 72);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(560, 232);
            this.panelControl1.TabIndex = 0;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DataSource = this.get_SubcriberBindingSource;
            this.cmbChiNhanh.DisplayMember = "TENCN";
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(123, 18);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(258, 21);
            this.cmbChiNhanh.TabIndex = 19;
            this.cmbChiNhanh.ValueMember = "TENSERVER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Khoa:";
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DataSource = this.layTenMonHocBindingSource;
            this.cmbMonHoc.DisplayMember = "TENMH";
            this.cmbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(123, 45);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(195, 21);
            this.cmbMonHoc.TabIndex = 28;
            this.cmbMonHoc.ValueMember = "MAMH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Môn học:";
            // 
            // txtNhom
            // 
            this.txtNhom.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNhom.Location = new System.Drawing.Point(123, 129);
            this.txtNhom.Name = "txtNhom";
            this.txtNhom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNhom.Size = new System.Drawing.Size(100, 20);
            this.txtNhom.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nhóm:";
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Items.AddRange(new object[] {
            "2015-2019",
            "2016-2020",
            "2017-2021",
            "2018-2022",
            "2019-2023"});
            this.cmbNienKhoa.Location = new System.Drawing.Point(123, 74);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(121, 21);
            this.cmbNienKhoa.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Niên khóa:";
            // 
            // btnXemReport
            // 
            this.btnXemReport.Location = new System.Drawing.Point(123, 161);
            this.btnXemReport.Name = "btnXemReport";
            this.btnXemReport.Size = new System.Drawing.Size(75, 23);
            this.btnXemReport.TabIndex = 23;
            this.btnXemReport.Text = "Xem trước";
            this.btnXemReport.Click += new System.EventHandler(this.btnXemReport_Click);
            // 
            // txtHocKy
            // 
            this.txtHocKy.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtHocKy.Location = new System.Drawing.Point(123, 103);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHocKy.Size = new System.Drawing.Size(100, 20);
            this.txtHocKy.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Học kỳ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(358, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nhập thông tin để xem bảng điểm môn học";
            // 
            // frptInBangDiemMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 345);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelControl1);
            this.Name = "frptInBangDiemMonHoc";
            this.Text = "frptInBangDiemMonHoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frptInBangDiemMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.get_SubcriberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layTenMonHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QLDSV_HTCDataSet qLDSV_HTCDataSet;
        private System.Windows.Forms.BindingSource get_SubcriberBindingSource;
        private QLDSV_HTCDataSetTableAdapters.Get_SubcriberTableAdapter get_SubcriberTableAdapter;
        private QLDSV_HTCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLDSV_HTCDataSet1 qLDSV_HTCDataSet1;
        private System.Windows.Forms.BindingSource layTenMonHocBindingSource;
        private QLDSV_HTCDataSet1TableAdapters.LayTenMonHocTableAdapter layTenMonHocTableAdapter;
        private QLDSV_HTCDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SpinEdit txtNhom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnXemReport;
        private DevExpress.XtraEditors.SpinEdit txtHocKy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}