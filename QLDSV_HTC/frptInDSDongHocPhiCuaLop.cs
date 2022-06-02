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
    public partial class frptInDSDongHocPhiCuaLop : DevExpress.XtraEditors.XtraForm
    {
        public frptInDSDongHocPhiCuaLop()
        {
            InitializeComponent();
        }

        private void frptInDSDongHocPhiCuaLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_HTCDataSet2.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSV_HTCDataSet2.LOP);
            cmbNienKhoa.SelectedIndex = 0;
            cmbLop.SelectedIndex = 0;
        }

        private void btnXemReport_Click(object sender, EventArgs e)
        {
            xrptInDanhSachDongHocPhiCuaLop rpt = new xrptInDanhSachDongHocPhiCuaLop(cmbLop.SelectedValue.ToString(), cmbNienKhoa.Text, int.Parse(txtHocKy.Text));
           
         
                string tempMalop = cmbLop.SelectedValue.ToString();
       
                Program.conn.Open();
                string strLenhLayMaKhoa = "EXEC SP_Lay_Ma_Khoa '" + tempMalop + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenhLayMaKhoa);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                rpt.txtKhoa.Text = Program.myReader.GetString(0);//Lấy mã khoa
                Program.conn.Close();
     
            rpt.txtMaLop.Text = cmbLop.SelectedValue.ToString();
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}