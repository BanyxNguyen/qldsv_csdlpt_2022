namespace QLDSV_HTC
{
    partial class frptInDanhSachLTC
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
            this.tableAdapterManager = new QLDSV_HTC.QLDSV_HTCDataSetTableAdapters.TableAdapterManager();
            this.get_SubcriberTableAdapter = new QLDSV_HTC.QLDSV_HTCDataSetTableAdapters.Get_SubcriberTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXemReport = new DevExpress.XtraEditors.SimpleButton();
            this.txtHocKy = new DevExpress.XtraEditors.SpinEdit();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.get_SubcriberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_HTC.QLDSV_HTCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // get_SubcriberTableAdapter
            // 
            this.get_SubcriberTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin để xem danh sách lớp tín chỉ";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.btnXemReport);
            this.panelControl1.Controls.Add(this.txtHocKy);
            this.panelControl1.Controls.Add(this.cmbNienKhoa);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Location = new System.Drawing.Point(80, 62);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(526, 233);
            this.panelControl1.TabIndex = 1;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DataSource = this.get_SubcriberBindingSource;
            this.cmbChiNhanh.DisplayMember = "TENCN";
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(85, 20);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(229, 21);
            this.cmbChiNhanh.TabIndex = 14;
            this.cmbChiNhanh.ValueMember = "TENSERVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Khoa:";
            // 
            // btnXemReport
            // 
            this.btnXemReport.Location = new System.Drawing.Point(85, 133);
            this.btnXemReport.Name = "btnXemReport";
            this.btnXemReport.Size = new System.Drawing.Size(75, 23);
            this.btnXemReport.TabIndex = 12;
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
            this.txtHocKy.Location = new System.Drawing.Point(85, 92);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHocKy.Size = new System.Drawing.Size(100, 20);
            this.txtHocKy.TabIndex = 11;
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
            this.cmbNienKhoa.Location = new System.Drawing.Point(85, 57);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(121, 21);
            this.cmbNienKhoa.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Học kỳ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Niên khóa:";
            // 
            // frptInDanhSachLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 351);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.label1);
            this.Name = "frptInDanhSachLTC";
            this.Text = "frptInDanhSachLTC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frptInDanhSachLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.get_SubcriberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QLDSV_HTCDataSet qLDSV_HTCDataSet;
        private QLDSV_HTCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource get_SubcriberBindingSource;
        private QLDSV_HTCDataSetTableAdapters.Get_SubcriberTableAdapter get_SubcriberTableAdapter;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnXemReport;
        private DevExpress.XtraEditors.SpinEdit txtHocKy;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}