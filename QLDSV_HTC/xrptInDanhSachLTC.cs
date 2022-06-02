using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV_HTC
{
    public partial class xrptInDanhSachLTC : DevExpress.XtraReports.UI.XtraReport
    {
        public xrptInDanhSachLTC()
        {
          
        }
        public xrptInDanhSachLTC(string nienKhoa, int hocKy)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienKhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocKy;
            this.sqlDataSource1.Fill();
        }

    }
}
