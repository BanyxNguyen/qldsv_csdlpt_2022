using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace QLDSV_HTC
{
    public partial class frmNhapDiem : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt_DS_DK = new DataTable();
        string maltc;
        public frmNhapDiem()
        {
            InitializeComponent();
        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'qLDSV_HTCDataSet.Get_Subcriber' table. You can move, or remove it, as needed.
            this.get_SubcriberTableAdapter.Fill(this.datasetchu.Get_Subcriber);
            cmbChinhanh.SelectedIndex = Program.mChiNhanh;
            if (Program.mGroup == "PGV" || Program.mGroup == "KHOA")
            {
                cmbChinhanh.Enabled = true;
                btfillLTC.Enabled = btnhap.Enabled = btGhi.Enabled = true;
            }
            else
            {
                cmbChinhanh.Enabled = false;
                btfillLTC.Enabled = btnhap.Enabled = btGhi.Enabled = false;
            }
        }

        private void sP_Lay_Danh_Sach_LTCGridControl_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChinhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbChinhanh.SelectedValue.ToString();
            if (cmbChinhanh.SelectedIndex != Program.mChiNhanh)
            {
                Program.mlogin = Program.remoteLogin;
                Program.password = Program.remotePassword;
            }
            else
            {
                Program.mlogin = Program.mLoginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);

            }
            else
            {
                this.sP_Lay_Danh_Sach_LTCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_Lay_Danh_Sach_LTCTableAdapter.Fill(this.qLDSV_HTCDataSet1.SP_Lay_Danh_Sach_LTC, nIENKHOAToolStripTextBox.Text, int.Parse(hOCKYToolStripTextBox.Text));

            }
        }

        private void btDSLTC_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_Lay_Danh_Sach_LTCTableAdapter.Fill(
                    this.qLDSV_HTCDataSet1.SP_Lay_Danh_Sach_LTC, 
                    nIENKHOAToolStripTextBox.Text, 
                    new System.Nullable<int>(((int)(
                        System.Convert.ChangeType(hOCKYToolStripTextBox.Text, 
                        typeof(int))))
                    )
                );
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnhap_Click(object sender, EventArgs e)
        {
            try
            {
                maltc = ((DataRowView)bdsLTC[bdsLTC.Position])["MALTC"].ToString();
                //this.sP_DSSV_DANGKY_GETTableAdapter.Fill(
                //    this.qLDSV_HTCDataSet1.SP_DSSV_DANGKY_GET,
                //   Int32.Parse(maltc)
                //);
                string str = "EXEC SP_DSSV_DANGKY_GET " + maltc;
                dt_DS_DK = Program.ExecSqlDataTable(str);
                sP_DSSV_DANGKY_GETGridControl.DataSource = dt_DS_DK;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sP_DSSV_DANGKY_GETGridControl_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_Lay_Danh_Sach_LTCTableAdapter.Fill(
                    this.qLDSV_HTCDataSet1.SP_Lay_Danh_Sach_LTC, 
                    nIENKHOAToolStripTextBox.Text, 
                    new System.Nullable<int>(((int)(
                        System.Convert.ChangeType(hOCKYToolStripTextBox.Text,
                        typeof(int))))
                    )
                );
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btGhi_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MALTC", typeof(int));
            dt.Columns.Add("MASV", typeof(string));
            dt.Columns.Add("DIEM_CC", typeof(float));
            dt.Columns.Add("DIEM_GK", typeof(float));
            dt.Columns.Add("DIEM_CK", typeof(float));

            int maltcint = int.Parse(maltc);

            for(int i = 0; i < dt_DS_DK.Rows.Count; i++)
            {
                var temp = dt_DS_DK.Rows[i];
                dt.Rows.Add(
                    maltcint,
                    temp["MASV"],
                    temp["DIEM_CC"],
                    temp["DIEM_GK"],
                    temp["DIEM_CK"]
                );
            };

            try
            {
                SqlParameter para = new SqlParameter();
                para.SqlDbType = SqlDbType.Structured;
                para.TypeName = "dbo.TYPE_DANGKY";
                para.ParameterName = "@DIEMTHI";
                para.Value = dt;
                Program.KetNoi();

                SqlCommand sqlCommand = new SqlCommand("SP_UPDATE_DIEM", Program.conn);
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(para);
                sqlCommand.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}