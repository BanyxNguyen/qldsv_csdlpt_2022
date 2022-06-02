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

namespace QLDSV_HTC
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_HTCDataSet.Get_Subcriber' table. You can move, or remove it, as needed.
            this.get_SubcriberTableAdapter.Fill(this.qLDSV_HTCDataSet.Get_Subcriber);
            cmbCN.SelectedIndex = 1;
            cmbCN.SelectedIndex = 0;
        }

        private void isSV()
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống.", "Báo lỗi đăng nhập.", MessageBoxButtons.OK);
                txtUserName.Focus();
                return;
            }
            Program.servername = cmbCN.SelectedValue.ToString();

            //Chức năng đăng nhập
            Program.mlogin = txtUserName.Text;
            Program.password = txtPassword.Text;

            if (Program.KetNoi() == 0) return;
         
            // MessageBox.Show("Dang nhap thanh cong");
            Program.frmMain.tabHeThong.Visible = true;
         

            Program.mChiNhanh = cmbCN.SelectedIndex;
            Program.bds_dspm = bds_DSPM;

            //MessageBox.Show(Program.bds_dspm.ToString());

            Program.mLoginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            string strLenh = "EXEC SP_Lay_Thong_Tin_NV_Tu_Login '" + Program.mlogin + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            if (!Program.laSinhVien)
            {
                Program.username = Program.myReader.GetString(0);
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);//Lấy tên nhóm
            }
            Program.myReader.Close();
            Program.conn.Close();
            if (Program.mGroup == "PGV" || Program.mGroup == "KHOA")
            {
                Program.frmMain.tabDanhMuc.Visible = true;
                Program.frmMain.tabNghiepVu.Visible = true;
                Program.frmMain.tabBaoCao.Visible = true;
                Program.frmMain.pageDongHocPhi.Visible = false;
                Program.frmMain.pageInDSHocPhi.Visible = false;
                Program.frmMain.PageDKLTC.Visible = false;
            }
            else
            {
                Program.frmMain.tabNghiepVu.Visible = true;
                if(Program.mGroup == "SV")
                {
                    Program.frmMain.pageDongHocPhi.Visible= Program.frmMain.pageNhapDiem.Visible = false;
                }
                else
                {
                    Program.frmMain.PageDKLTC.Visible = Program.frmMain.pageNhapDiem.Visible = false;
                    Program.frmMain.tabBaoCao.Visible = true;
                    Program.frmMain.pageInBangDiem.Visible = Program.frmMain.pageInDSLTC.Visible = false;
                    
                }
            }
            this.Close();
            Program.frmMain.HienThiMenu();
            //Program.frmChinh.tabBaoCao.Visible = true;
            //Program.frmChinh.tabDanhMuc.Visible = true;
            //Program.frmChinh.tabNghiepVu.Visible = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}