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
    public partial class frmLTC : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        string MaLTC = "";
        public frmLTC()
        {
            InitializeComponent();
        }

        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLTC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.datasetsite1);

        }

        private void frmLTC_Load(object sender, EventArgs e)
        {
            this.datasetsite1.EnforceConstraints = false;
            this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'qLDSV_HTCDataSet1.LOPTINCHI' table. You can move, or remove it, as needed.
            this.LOPTINCHITableAdapter.Fill(this.datasetsite1.LOPTINCHI);
            // TODO: This line of code loads data into the 'qLDSV_HTCDataSet.Get_Subcriber' table. You can move, or remove it, as needed.
            this.get_SubcriberTableAdapter.Fill(this.datasetchu.Get_Subcriber);
            // TODO: This line of code loads data into the 'qLDSV_HTCDataSet1.DANGKY' table. You can move, or remove it, as needed.
            this.dANGKYTableAdapter.Fill(this.datasetsite1.DANGKY);
            MaLTC = ((DataRowView)bdsLTC[0])["MALTC"].ToString();
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
                this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTINCHITableAdapter.Fill(this.datasetsite1.LOPTINCHI);

            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLTC.Position;
            groupBox2.Enabled = true;
            bdsLTC.AddNew();
            txtNienkhoa.EditValue = "";
            txtHocKy.EditValue = "";
            txtMaKhoa.EditValue = "";
            txtMaMH.EditValue = "";
            txtNhom.EditValue = "";
            txtSoSV.EditValue = "";
            txtmagiang.EditValue = "";
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            lOPTINCHIGridControl.Enabled = cmbChinhanh.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLTC.Position;
            groupBox2.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            lOPTINCHIGridControl.Enabled = cmbChinhanh.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (txtMaLTC.Text.Trim() == "")
            //{
            //    MessageBox.Show("Mã lớp tín chỉ không được trống", "", MessageBoxButtons.OK);
            //    txtMaLTC.Focus();
            //    return;
            //}
            if (txtNienkhoa.Text.Trim() == "")
            {
                MessageBox.Show("Niên khóa không được trống", "", MessageBoxButtons.OK);
                txtNienkhoa.Focus();
                return;
            }
            if (txtHocKy.Text.Trim() == "")
            {
                MessageBox.Show("Học kỳ không được trống", "", MessageBoxButtons.OK);
                txtHocKy.Focus();
                return;
            }

            try
            {
                bdsLTC.EndEdit();
                bdsLTC.ResetCurrentItem();
                this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTINCHITableAdapter.Update(this.datasetsite1.LOPTINCHI);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu danh mục Sinh viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            lOPTINCHIGridControl.Enabled = cmbChinhanh.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;

            groupBox2.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String MaLTC = "";
            if (bdsDK.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp tín chỉ này vì có sinh viên đã đăng kí lớp tín chỉ", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thực sự muốn xóa lớp này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    MaLTC = ((DataRowView)bdsLTC[bdsLTC.Position])["MASV"].ToString();
                    bdsLTC.RemoveCurrent();
                    this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOPTINCHITableAdapter.Update(this.datasetsite1.LOPTINCHI);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên . Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.LOPTINCHITableAdapter.Fill(this.datasetsite1.LOPTINCHI);
                    bdsLTC.Position = bdsLTC.Find("MASV", MaLTC);
                    return;
                }
            }
            if (bdsLTC.Count == 0) btnXoa.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLTC.CancelEdit();
            bdsLTC.Position = vitri;
            lOPTINCHIGridControl.Enabled = cmbChinhanh.Enabled = true;
            groupBox2.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.LOPTINCHITableAdapter.Fill(this.datasetsite1.LOPTINCHI);
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