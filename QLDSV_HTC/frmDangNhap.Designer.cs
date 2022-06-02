namespace QLDSV_HTC
{
    partial class frmDangNhap
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label tENCNLabel;
            this.qLDSV_HTCDataSet = new QLDSV_HTC.QLDSV_HTCDataSet();
            this.bds_DSPM = new System.Windows.Forms.BindingSource(this.components);
            this.get_SubcriberTableAdapter = new QLDSV_HTC.QLDSV_HTCDataSetTableAdapters.Get_SubcriberTableAdapter();
            this.tableAdapterManager = new QLDSV_HTC.QLDSV_HTCDataSetTableAdapters.TableAdapterManager();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.cmbCN = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tENCNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(36, 116);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 13);
            label2.TabIndex = 17;
            label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(36, 69);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 13);
            label1.TabIndex = 15;
            label1.Text = "Tên đăng nhập:";
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Location = new System.Drawing.Point(36, 21);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(55, 13);
            tENCNLabel.TabIndex = 13;
            tENCNLabel.Text = "Tên khoa:";
            // 
            // qLDSV_HTCDataSet
            // 
            this.qLDSV_HTCDataSet.DataSetName = "QLDSV_HTCDataSet";
            this.qLDSV_HTCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_DSPM
            // 
            this.bds_DSPM.DataMember = "Get_Subcriber";
            this.bds_DSPM.DataSource = this.qLDSV_HTCDataSet;
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
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(81, 222);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(270, 222);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtPassword);
            this.panelControl1.Controls.Add(label2);
            this.panelControl1.Controls.Add(this.txtUserName);
            this.panelControl1.Controls.Add(label1);
            this.panelControl1.Controls.Add(tENCNLabel);
            this.panelControl1.Controls.Add(this.cmbCN);
            this.panelControl1.Location = new System.Drawing.Point(21, 51);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(387, 151);
            this.panelControl1.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(122, 113);
            this.txtPassword.Name = "txtPassword";
            // 
            // 
            // 
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(228, 20);
            this.txtPassword.TabIndex = 18;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(122, 66);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(228, 20);
            this.txtUserName.TabIndex = 16;
            // 
            // cmbCN
            // 
            this.cmbCN.DataSource = this.bds_DSPM;
            this.cmbCN.DisplayMember = "TENCN";
            this.cmbCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCN.FormattingEnabled = true;
            this.cmbCN.Location = new System.Drawing.Point(122, 18);
            this.cmbCN.Name = "cmbCN";
            this.cmbCN.Size = new System.Drawing.Size(228, 21);
            this.cmbCN.TabIndex = 14;
            this.cmbCN.ValueMember = "TENSERVER";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 262);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDangNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLDSV_HTCDataSet qLDSV_HTCDataSet;
        private System.Windows.Forms.BindingSource bds_DSPM;
        private QLDSV_HTCDataSetTableAdapters.Get_SubcriberTableAdapter get_SubcriberTableAdapter;
        private QLDSV_HTCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private System.Windows.Forms.ComboBox cmbCN;
    }
}