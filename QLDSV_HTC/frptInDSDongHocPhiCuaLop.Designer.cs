namespace QLDSV_HTC
{
    partial class frptInDSDongHocPhiCuaLop
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnXemReport = new DevExpress.XtraEditors.SimpleButton();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHocKy = new DevExpress.XtraEditors.SpinEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_HTCDataSet2 = new QLDSV_HTC.QLDSV_HTCDataSet2();
            this.lOPTableAdapter = new QLDSV_HTC.QLDSV_HTCDataSet2TableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV_HTC.QLDSV_HTCDataSet2TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin của lớp cần xem";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnXemReport);
            this.panelControl1.Controls.Add(this.cmbNienKhoa);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.txtHocKy);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.cmbLop);
            this.panelControl1.Location = new System.Drawing.Point(64, 44);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(583, 180);
            this.panelControl1.TabIndex = 1;
            // 
            // btnXemReport
            // 
            this.btnXemReport.Location = new System.Drawing.Point(92, 118);
            this.btnXemReport.Name = "btnXemReport";
            this.btnXemReport.Size = new System.Drawing.Size(75, 23);
            this.btnXemReport.TabIndex = 18;
            this.btnXemReport.Text = "Xem trước";
            this.btnXemReport.Click += new System.EventHandler(this.btnXemReport_Click);
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
            this.cmbNienKhoa.Location = new System.Drawing.Point(92, 58);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(160, 21);
            this.cmbNienKhoa.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Niên khóa:";
            // 
            // txtHocKy
            // 
            this.txtHocKy.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtHocKy.Location = new System.Drawing.Point(92, 92);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHocKy.Size = new System.Drawing.Size(100, 20);
            this.txtHocKy.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Học kỳ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lớp:";
            // 
            // cmbLop
            // 
            this.cmbLop.DataSource = this.lOPBindingSource;
            this.cmbLop.DisplayMember = "TENLOP";
            this.cmbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(92, 26);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(223, 21);
            this.cmbLop.TabIndex = 0;
            this.cmbLop.ValueMember = "MALOP";
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLDSV_HTCDataSet2;
            // 
            // qLDSV_HTCDataSet2
            // 
            this.qLDSV_HTCDataSet2.DataSetName = "QLDSV_HTCDataSet2";
            this.qLDSV_HTCDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.SP_Lay_Hoc_PhiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_HTC.QLDSV_HTCDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frptInDSDongHocPhiCuaLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 343);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.label1);
            this.Name = "frptInDSDongHocPhiCuaLop";
            this.Text = "frptInDSDongHocPhiCuaLop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frptInDSDongHocPhiCuaLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private QLDSV_HTCDataSet2 qLDSV_HTCDataSet2;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSV_HTCDataSet2TableAdapters.LOPTableAdapter lOPTableAdapter;
        private QLDSV_HTCDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SpinEdit txtHocKy;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnXemReport;
    }
}