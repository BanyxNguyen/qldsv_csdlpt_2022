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
    public partial class frmTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void layMaGVBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.layMaGVBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_HTCDataSet1);

        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_HTCDataSet1.LayMaGV' table. You can move, or remove it, as needed.
            this.layMaGVTableAdapter.Fill(this.qLDSV_HTCDataSet1.LayMaGV);
            if (Program.mGroup == "PKT")
            {
                cmbNhomQuyen.SelectedIndex = 2;
                cmbNhomQuyen.Enabled = false;
            }
            else if (Program.mGroup == "KHOA")
            {   
                cmbNhomQuyen.SelectedIndex = 0;
                cmbNhomQuyen.Enabled = false;
            }
            else
            {
                cmbNhomQuyen.SelectedIndex = 1;
            }
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtRePassword.Text)
            {
                MessageBox.Show("Kiễm ra lại mật khẩu", "", MessageBoxButtons.OK);
                return;
            }
            if(Program.mGroup=="PGV" && cmbNhomQuyen.SelectedIndex == 2)
            {
                MessageBox.Show("Phòng giáo vụ không được tạo Login thuộc nhóm PKT", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                string LoginName = txtMaGV.Text;
                string UserName = txtUserName.Text.Trim();
                string Password = txtPassword.Text.Trim();
                string Role = cmbNhomQuyen.Text;
                //EXEC sp_procoption @ProcName = N'<procedure name>' , @OptionName = 'startup' , @OptionValue = 'on';

                string strLenhTaoTaiKhoan = "EXEC SP_TAOLOGIN '" + UserName + "','" + Password + "','" + LoginName + "','" + Role + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenhTaoTaiKhoan);
                MessageBox.Show("Tạo tài khoản thành công", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo tài khoản", ex.Message, MessageBoxButtons.OK);
            }

        }
    }
}