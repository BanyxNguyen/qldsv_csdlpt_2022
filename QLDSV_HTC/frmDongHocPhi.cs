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
    public partial class frmDongHocPhi : DevExpress.XtraEditors.XtraForm
    {
        public frmDongHocPhi()
        {
            InitializeComponent();
        }
        private void frmDongHocPhi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_HTCDataSet2.CT_DONGHOCPHI' table. You can move, or remove it, as needed.
            this.qLDSV_HTCDataSet2.EnforceConstraints = false;
            this.CTHP_TableAdapter.Fill(this.qLDSV_HTCDataSet2.CT_DONGHOCPHI);
            txtNienKhoa.SelectedIndex = 1;
        }

     

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.ThongTinSV_TableAdapter.Fill(this.qLDSV_HTCDataSet2.SP_Lay_Thong_Tin_SV_Dong_HP, mASVToolStripTextBox.Text);
                this.HocPhi_TableAdapter.Fill(this.qLDSV_HTCDataSet2.SP_Lay_Hoc_Phi, mASVToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            panelControl2.Enabled = panelControl4.Enabled = true;
          
        }

        private void btnThemHP_Click(object sender, EventArgs e)
        {
            bdsHocPhi.AddNew();
            fillToolStrip.Enabled=btnThemHP.Enabled= panelControl3.Enabled = panelControl4.Enabled = panelControl5.Enabled = false;
        }

        private void btnLuuHP_Click(object sender, EventArgs e)
        {
            if (txtNienKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Niên khóa không được trống", "", MessageBoxButtons.OK);
                txtNienKhoa.Focus();
                return;
            }
            if (txtHocKy.Text.Trim() == "")
            {
                MessageBox.Show("Học kỳ không được trống", "", MessageBoxButtons.OK);
                txtHocKy.Focus();
                return;
            }
            if (txtHocPhi.Text.Trim() == "")
            {
                MessageBox.Show("Học phí không được trống", "", MessageBoxButtons.OK);
                txtHocPhi.Focus();
                return;
            }
            try
            {
                bdsHocPhi.EndEdit();
                bdsHocPhi.ResetCurrentItem();
                this.HocPhi_TableAdapter.Connection.ConnectionString = Program.connstr;
                this.HocPhi_TableAdapter.Update(this.qLDSV_HTCDataSet2.SP_Lay_Hoc_Phi);
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Lỗi ghi học phí.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            fillToolStrip.Enabled = btnThemHP.Enabled = panelControl3.Enabled = panelControl4.Enabled = panelControl5.Enabled = true;

        }

        private void btnThemCTHP_Click(object sender, EventArgs e)
        {

            bdsCTHP.AddNew();
            fillToolStrip.Enabled = btnThemHP.Enabled = panelControl3.Enabled = panelControl2.Enabled = panelControl5.Enabled = false;
        }

        private void btnLuuCTHP_Click(object sender, EventArgs e)
        {
            if (txtNgayDong.Text.Trim() == "")
            {
                MessageBox.Show("Ngày đóng không được trống", "", MessageBoxButtons.OK);
                txtNgayDong.Focus();
                return;
            }
            if (txtSoTienDong.Text.Trim() == "")
            {
                MessageBox.Show("Số tiền đóng không được trống", "", MessageBoxButtons.OK);
                txtSoTienDong.Focus();
                return;
            }
          
            try
            {
                bdsCTHP.EndEdit();
                bdsCTHP.ResetCurrentItem();
                this.CTHP_TableAdapter.Connection.ConnectionString = Program.connstr;
                this.CTHP_TableAdapter.Update(this.qLDSV_HTCDataSet2.CT_DONGHOCPHI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi chi tiết học phí.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            fillToolStrip.Enabled = btnThemHP.Enabled = panelControl3.Enabled = panelControl2.Enabled = panelControl5.Enabled = true;
        }

      
    }
}