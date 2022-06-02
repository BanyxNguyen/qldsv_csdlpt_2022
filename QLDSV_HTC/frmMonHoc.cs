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
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        public frmMonHoc()
        {
            InitializeComponent();
        }

     

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            this.DataSet_Site1.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DataSet_Site1.LOPTINCHI' table. You can move, or remove it, as needed.
            this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTINCHITableAdapter.Fill(this.DataSet_Site1.LOPTINCHI);
         
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MONHOCTableAdapter.Fill(this.DataSet_Site1.MONHOC);

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMonHoc.Position;
            panelControl2.Enabled = true;
            bdsMonHoc.AddNew();
           
            txtMaMonHoc.EditValue = "";
            txtTenMonHoc.EditValue = "";
            txtSoTietLT.Value = 0;
            txtSoTietTH.Value = 0;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            MONHOCGridControl.Enabled  = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMonHoc.CancelEdit();
            bdsMonHoc.Position = vitri;
            MONHOCGridControl.Enabled  = true;
            panelControl2.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMonHoc.Position;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            MONHOCGridControl.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.MONHOCTableAdapter.Fill(this.DataSet_Site1.MONHOC);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maMonHoc ="" ;
            if (bdsLopTinChi.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã lập lớp tín chỉ", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thực sự muốn xóa môn học này này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maMonHoc = ((DataRowView)bdsMonHoc[bdsMonHoc.Position])["MAMH"].ToString();
                    bdsMonHoc.RemoveCurrent();
                    this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.MONHOCTableAdapter.Update(this.DataSet_Site1.MONHOC);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa môn học . Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.MONHOCTableAdapter.Fill(this.DataSet_Site1.MONHOC);
                    bdsMonHoc.Position = bdsMonHoc.Find("MAMH", bdsMonHoc);
                    return;
                }
            }
            if (bdsMonHoc.Count == 0) btnXoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (txtMaMonHoc.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được trống", "", MessageBoxButtons.OK);
                txtMaMonHoc.Focus();
                return;
            }
            if (txtSoTietLT.Value == 0)
            {
                MessageBox.Show("Số tiết LT phải lớn hơn 0", "", MessageBoxButtons.OK);
                txtSoTietLT.Focus();
                return;
            }
            if (txtSoTietTH.Value == 0)
            {
                MessageBox.Show("Số tiết TH phải lớn hơn 0", "", MessageBoxButtons.OK);
                txtSoTietTH.Focus();
                return;
            }

            try
            {
                bdsMonHoc.EndEdit();
                bdsMonHoc.ResetCurrentItem();
                this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.MONHOCTableAdapter.Update(this.DataSet_Site1.MONHOC);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            MONHOCGridControl.Enabled  = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;

            panelControl2.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}