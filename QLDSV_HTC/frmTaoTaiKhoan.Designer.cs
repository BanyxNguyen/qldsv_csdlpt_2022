namespace QLDSV_HTC
{
    partial class frmTaoTaiKhoan
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
            System.Windows.Forms.Label mAGVLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbNhomQuyen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaGV = new DevExpress.XtraEditors.TextEdit();
            this.layMaGVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_HTCDataSet1 = new QLDSV_HTC.QLDSV_HTCDataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMaGV = new System.Windows.Forms.ComboBox();
            this.layMaGVTableAdapter = new QLDSV_HTC.QLDSV_HTCDataSet1TableAdapters.LayMaGVTableAdapter();
            this.tableAdapterManager = new QLDSV_HTC.QLDSV_HTCDataSet1TableAdapters.TableAdapterManager();
            this.btnTaoTK = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            mAGVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layMaGVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(329, 28);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(41, 13);
            mAGVLabel.TabIndex = 2;
            mAGVLabel.Text = "Mã GV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin tài khoản:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbNhomQuyen);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.txtRePassword);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.txtPassword);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.txtUserName);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(mAGVLabel);
            this.panelControl1.Controls.Add(this.txtMaGV);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.cmbMaGV);
            this.panelControl1.Location = new System.Drawing.Point(81, 64);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(597, 258);
            this.panelControl1.TabIndex = 1;
            // 
            // cmbNhomQuyen
            // 
            this.cmbNhomQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhomQuyen.FormattingEnabled = true;
            this.cmbNhomQuyen.Items.AddRange(new object[] {
            "KHOA",
            "PGV",
            "PKT"});
            this.cmbNhomQuyen.Location = new System.Drawing.Point(106, 199);
            this.cmbNhomQuyen.Name = "cmbNhomQuyen";
            this.cmbNhomQuyen.Size = new System.Drawing.Size(135, 21);
            this.cmbNhomQuyen.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nhóm quyền:";
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(106, 156);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '*';
            this.txtRePassword.Size = new System.Drawing.Size(135, 21);
            this.txtRePassword.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nhập lại mật khẩu";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(106, 111);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(135, 21);
            this.txtPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mật khẩu:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(106, 68);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(135, 21);
            this.txtUserName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên đăng nhập:";
            // 
            // txtMaGV
            // 
            this.txtMaGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.layMaGVBindingSource, "MAGV", true));
            this.txtMaGV.Enabled = false;
            this.txtMaGV.Location = new System.Drawing.Point(376, 25);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(100, 20);
            this.txtMaGV.TabIndex = 3;
            // 
            // layMaGVBindingSource
            // 
            this.layMaGVBindingSource.DataMember = "LayMaGV";
            this.layMaGVBindingSource.DataSource = this.qLDSV_HTCDataSet1;
            // 
            // qLDSV_HTCDataSet1
            // 
            this.qLDSV_HTCDataSet1.DataSetName = "QLDSV_HTCDataSet1";
            this.qLDSV_HTCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên GV";
            // 
            // cmbMaGV
            // 
            this.cmbMaGV.DataSource = this.layMaGVBindingSource;
            this.cmbMaGV.DisplayMember = "HOTEN";
            this.cmbMaGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaGV.FormattingEnabled = true;
            this.cmbMaGV.Location = new System.Drawing.Point(61, 24);
            this.cmbMaGV.Name = "cmbMaGV";
            this.cmbMaGV.Size = new System.Drawing.Size(180, 21);
            this.cmbMaGV.TabIndex = 0;
            this.cmbMaGV.ValueMember = "MAGV";
            // 
            // layMaGVTableAdapter
            // 
            this.layMaGVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LayMaGVTableAdapter = this.layMaGVTableAdapter;
            this.tableAdapterManager.LayTenMonHocTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_HTC.QLDSV_HTCDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Location = new System.Drawing.Point(457, 344);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(75, 23);
            this.btnTaoTK.TabIndex = 3;
            this.btnTaoTK.Text = "Tạo tài khoản";
            this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(229, 344);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            // 
            // frmTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 414);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTaoTK);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.label1);
            this.Name = "frmTaoTaiKhoan";
            this.Text = "frmTaoTaiKhoan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layMaGVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private QLDSV_HTCDataSet1 qLDSV_HTCDataSet1;
        private System.Windows.Forms.BindingSource layMaGVBindingSource;
        private QLDSV_HTCDataSet1TableAdapters.LayMaGVTableAdapter layMaGVTableAdapter;
        private QLDSV_HTCDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbNhomQuyen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtMaGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMaGV;
        private DevExpress.XtraEditors.SimpleButton btnTaoTK;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
    }
}