using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QLDSV_HTC
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }
        public void HienThiMenu()
        {
            MANV.Text = "Mã SV/GV : " + Program.username;
            HOTEN.Text = "Họ tên : " + Program.mHoten;
            NHOM.Text = "Nhóm : " + Program.mGroup;
            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            // Phân quyền
        }
        private void frmMain_Load_1(object sender, EventArgs e)
        {
            btnDangNhap.PerformClick();
        }

        private void btnLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLop));
            if (frm != null) frm.Activate();
            else
            {
                frmLop f = new frmLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDongHocPhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDongHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                frmDongHocPhi f = new frmDongHocPhi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangKyLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangKyLTC));
            if (frm != null) frm.Activate();
            else
            {
                frmDangKyLTC f = new frmDangKyLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSinhVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLopTinChi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLTC));
            if (frm != null) frm.Activate();
            else
            {
                frmLTC f = new frmLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnInDanhSachLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frptInDanhSachLTC));
            if (frm != null) frm.Activate();
            else
            {
                frptInDanhSachLTC f = new frptInDanhSachLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnInBangDiemMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frptInBangDiemMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frptInBangDiemMonHoc f = new frptInBangDiemMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnInDSDongHocPhiCuaLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frptInDSDongHocPhiCuaLop));
            if (frm != null) frm.Activate();
            else
            {
                frptInDSDongHocPhiCuaLop f = new frptInDSDongHocPhiCuaLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhapDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmNhapDiem f = new frmNhapDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoTaiKhoan f = new frmTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (MessageBox.Show("Bạn có thực sự muốn đăng xuất", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Program.frmMain.tabBaoCao.Visible = Program.frmMain.tabHeThong.Visible
               = Program.frmMain.tabDanhMuc.Visible = Program.frmMain.tabNghiepVu.Visible = false;
                btnDangNhap.Enabled = true;
                btnDangNhap.PerformClick();
            }
        }
    }
}