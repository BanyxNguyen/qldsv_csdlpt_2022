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
using DevExpress.XtraReports.UI;

namespace QLDSV_HTC
{
    public partial class frptInDanhSachLTC : DevExpress.XtraEditors.XtraForm
    {
        public frptInDanhSachLTC()
        {
            InitializeComponent();
           

        }

        private void frptInDanhSachLTC_Load(object sender, EventArgs e)
        {
           // this.get_SubcriberTableAdapter.Connection.ConnectionString = Program.connstr;

            // TODO: This line of code loads data into the 'qLDSV_HTCDataSet.Get_Subcriber' table. You can move, or remove it, as needed.
            this.get_SubcriberTableAdapter.Fill(this.qLDSV_HTCDataSet.Get_Subcriber);
            // TODO: This line of code loads data into the 'qLDSV_HTCDataSet.Get_Subcriber' table. You can move, or remove it, as needed.
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            cmbNienKhoa.SelectedIndex = 0;
            if (Program.mGroup == "PGV") cmbChiNhanh.Enabled = true;
            else cmbChiNhanh.Enabled = false;
        }

     

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
               if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();
            if (cmbChiNhanh.SelectedIndex != Program.mChiNhanh)
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
           
        }

        private void btnXemReport_Click(object sender, EventArgs e)
        {
            xrptInDanhSachLTC rpt = new xrptInDanhSachLTC(cmbNienKhoa.Text, int.Parse(txtHocKy.Text));
            rpt.txtKhoa.Text = cmbChiNhanh.Text;
            rpt.txtNienKhoa.Text = cmbNienKhoa.Text;
            rpt.txtHocKy.Text = txtHocKy.Text;
            rpt.txtNguoiLap.Text = Program.mHoten;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}