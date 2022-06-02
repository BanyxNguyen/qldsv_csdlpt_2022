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
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace QLDSV_HTC
{
    public partial class frmDangKyLTC : DevExpress.XtraEditors.XtraForm
    {
        public frmDangKyLTC()
        {
            InitializeComponent();
        }
        private void frmDangKyLTC_Load(object sender, EventArgs e)
        {
            this.qLDSV_HTCDataSet1.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLDSV_HTCDataSet1.DANGKY' table. You can move, or remove it, as needed.
            this.DangKyTableAdapter.Fill(this.qLDSV_HTCDataSet1.DANGKY);
            txtMaSV.Text = Program.username;
            btnTimThongTinSV.PerformClick();
        }
        private void btnTimThongTinSV_Click(object sender, EventArgs e)
        {
            try
            {
                this.ThongTinSVTableAdapter.Fill(this.qLDSV_HTCDataSet1.SP_Lay_Thong_Tin_SV_Dong_HP, txtMaSV.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnLayDanhSachLTC_Click(object sender, EventArgs e)
        {
            try
            {
                this.DanhSachLTCTableAdapter.Fill(
                    this.qLDSV_HTCDataSet1.SP_Lay_Danh_Sach_LTC, 
                    nIENKHOAToolStripTextBox.Text, 
                    new System.Nullable<int>(((int)(System.Convert.ChangeType(hOCKYToolStripTextBox.Text, typeof(int)))))
                    );
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string MaLTC = Convert.ToString(gridView1.GetFocusedRowCellValue("MALTC"));
            gridView2.AddNewRow();
            //set a new row cell value. The static GridControl.NewItemRowHandle field allows you to retrieve the added row
            gridView2.SetRowCellValue(GridControl.NewItemRowHandle, gridView2.Columns["MALTC"], MaLTC);
            gridView2.SetRowCellValue(GridControl.NewItemRowHandle, gridView2.Columns["MASV"], txtMaSV.Text);


            try
            {
                bdsDangKy.EndEdit();
                bdsDangKy.ResetCurrentItem();
                this.DangKyTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DangKyTableAdapter.Update(this.qLDSV_HTCDataSet1.DANGKY);
            }
            catch (Exception ex)
            {
                bdsDangKy.RemoveCurrent();
                MessageBox.Show("Lỗi đăng ký lớp tín chỉ.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}