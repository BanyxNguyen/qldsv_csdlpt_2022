using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV_HTC
{
    public partial class xrptInBangDiemMonHoc : DevExpress.XtraReports.UI.XtraReport
    {
        public xrptInBangDiemMonHoc(string nienKhoa,int hocKy,int nhom, string maMon)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienKhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocKy;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = nhom;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = maMon;
            this.sqlDataSource1.Fill();
        }

    }
}
