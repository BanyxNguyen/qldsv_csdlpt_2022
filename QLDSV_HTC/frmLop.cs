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
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {

        int vitri = 0;
       // string MaKhoa = "";
        public frmLop()
        {
            InitializeComponent();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {

            this.DataSet_Site1.EnforceConstraints = false;
            this.get_SubcriberTableAdapter.Fill(this.DataSet_SiteGoc.Get_Subcriber);

            this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LopTableAdapter.Fill(this.DataSet_Site1.LOP);

            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.DataSet_Site1.SINHVIEN);

           // MaKhoa = ((DataRowView)bdsLop[0])["MAKHOA"].ToString();
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
     
            if (Program.mGroup == "PGV" || Program.mGroup == "KHOA")
            {
                cmbChiNhanh.Enabled = true;
                btnThem.Enabled = btnHieuChinh.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = btnXoa.Enabled = true;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
                btnThem.Enabled = btnHieuChinh.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            }
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();
            if (Program.mGroup == "PGV"&&cmbChiNhanh.SelectedIndex==2)
            {
                MessageBox.Show("Chỉ phòng kế toán mới có quyền truy cập site này", "", MessageBoxButtons.OK);
                cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
                return;
            }
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
            else
            {
                this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LopTableAdapter.Fill(this.DataSet_Site1.LOP);

            }

            }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          string   MaKhoa = ((DataRowView)bdsLop[0])["MAKHOA"].ToString();
            cmbNienKhoa.SelectedIndex = 0;
            //cmbNienKhoa.Text = "";
            vitri = bdsLop.Position;
            panelControl2.Enabled = true;

            bdsLop.AddNew();
            txtMaKhoa.Text = MaKhoa;
            txtMaLop.EditValue = "";  
            txtTenLop.EditValue = "";

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            lOPGridControl.Enabled= cmbChiNhanh.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {     
            bdsLop.CancelEdit();
            bdsLop.Position = vitri;
            lOPGridControl.Enabled= cmbChiNhanh.Enabled = true;
            panelControl2.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnXoa.Enabled = btnThoat.Enabled= true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;

        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLop.Position;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            lOPGridControl.Enabled=cmbChiNhanh.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.LopTableAdapter.Fill(this.DataSet_Site1.LOP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maLop = "";
            if (bdsSinhVien.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì lớp đang hoạt động và chứa thông tin sinh vien", "", MessageBoxButtons.OK);
                return;
            }
          
            if (MessageBox.Show("Bạn có thực sự muốn xóa lớp học này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maLop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
                    bdsLop.RemoveCurrent();
                    this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LopTableAdapter.Update(this.DataSet_Site1.LOP);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp học . Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.LopTableAdapter.Fill(this.DataSet_Site1.LOP);
                    bdsLop.Position = bdsLop.Find("MALOP", maLop);
                    return;
                }
            }
            if (bdsLop.Count == 0) btnXoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được trống", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được trống", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return;
            }
            if (cmbNienKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Niên khóa không được trống", "", MessageBoxButtons.OK);
                cmbNienKhoa.Focus();
                return;
            }
            ///
            /// Kiểm tra ở site gốc xem có bị trùng mã lớp không

            string tempMalop = txtMaLop.Text.Trim();
            string strCheckMaLop = "DECLARE   @return_value int " +

                    "EXEC    @return_value = [dbo].[SP_Check_Ma_Lop]" +

                    " @MALOP = N'"+ tempMalop + "'" 

                    +"SELECT  'Return Value' = @return_value";

           SqlDataReader result = Program.ExecSqlDataReader(strCheckMaLop);
            if (result == null)
            {
                MessageBox.Show("Lổi server", "", MessageBoxButtons.OK);
                result.Close();
            }
            result.Read();
            int returnvalue = result.GetInt32(0);
            result.Close();
       
            if(returnvalue==1)//bị trùng mã lớp
            {
                MessageBox.Show("Mã lớp đã bị trùng ở máy chủ", "", MessageBoxButtons.OK);
                return;
            }
            /////////

            try
            {
                bdsLop.EndEdit();
                bdsLop.ResetCurrentItem();
                this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LopTableAdapter.Update(this.DataSet_Site1.LOP);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu danh mục lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            lOPGridControl.Enabled = cmbChiNhanh.Enabled = true;
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