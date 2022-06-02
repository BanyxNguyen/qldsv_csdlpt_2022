using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV_HTC
{
    public partial class xrptInDanhSachDongHocPhiCuaLop : DevExpress.XtraReports.UI.XtraReport
    {
        public xrptInDanhSachDongHocPhiCuaLop(string maLop,string nienKhoa,int hocKy)
        {
            InitializeComponent();
            //if (Program.mGroup != "PKT")
            //{
            //    Program.servername = "DESKTOP-4KTOHVV\MSSQLSERVER3";
            //    Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
            //         Program.database + ";User ID=" +
            //         Program.mlogin + ";password=" + Program.password;
            //}
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maLop;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = nienKhoa;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = hocKy;
            this.sqlDataSource1.Fill();
        }

    }
}
