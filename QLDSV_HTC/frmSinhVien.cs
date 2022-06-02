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
    public partial class frmSinhVien : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        string MaSV = "";
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.datasetsite1);

        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            this.datasetsite1.EnforceConstraints = false;
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'qLDSV_HTCDataSet1.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.datasetsite1.SINHVIEN);
            // TODO: This line of code loads data into the 'qLDSV_HTCDataSet.Get_Subcriber' table. You can move, or remove it, as needed.
            this.get_SubcriberTableAdapter.Fill(this.datasetchu.Get_Subcriber);  
            // TODO: This line of code loads data into the 'datasetsite1.DANGKY' table. You can move, or remove it, as needed.
            this.dANGKYTableAdapter.Fill(this.datasetsite1.DANGKY);
            MaSV = ((DataRowView)bdsSV[0])["MASV"].ToString();
            cmbChinhanh.SelectedIndex = Program.mChiNhanh;
            if (Program.mGroup == "PGV" || Program.mGroup == "KHOA")
            {
                cmbChinhanh.Enabled = true;
                btnThem.Enabled = btnHieuChinh.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = btnXoa.Enabled = true;
            }
            else
            {
                cmbChinhanh.Enabled = false;
                btnThem.Enabled = btnHieuChinh.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            }

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
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.datasetsite1.SINHVIEN);

            }
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsSV.Position;
            groupBox2.Enabled = true;
            bdsSV.AddNew();
            txtMaSV.EditValue = "";
            txtHo.EditValue = "";
            txtTen.EditValue = "";
            txtDiachi.EditValue = "";
            txtMaLop.EditValue = "";
            dteNgaySinh.EditValue = "";
            txtPass.EditValue = "";
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            sINHVIENGridControl.Enabled = cmbChinhanh.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsSV.Position;
            groupBox2.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            sINHVIENGridControl.Enabled = cmbChinhanh.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được trống", "", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return;
            }
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được trống", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được trống", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }

            try
            {
                bdsSV.EndEdit();
                bdsSV.ResetCurrentItem();
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Update(this.datasetsite1.SINHVIEN);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu danh mục Sinh viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            sINHVIENGridControl.Enabled = cmbChinhanh.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;

            groupBox2.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String MaSV = "";
            if (bdsDK.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì sinh viên đã đăng kí lớp tín chỉ", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thực sự muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    MaSV = ((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString();
                    bdsSV.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.datasetsite1.SINHVIEN);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên . Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Fill(this.datasetsite1.SINHVIEN);
                    bdsSV.Position = bdsSV.Find("MASV", MaSV);
                    return;
                }
            }
            if (bdsSV.Count == 0) btnXoa.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSV.CancelEdit();
            bdsSV.Position = vitri;
            sINHVIENGridControl.Enabled = cmbChinhanh.Enabled = true;
            groupBox2.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.sINHVIENTableAdapter.Fill(this.datasetsite1.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}