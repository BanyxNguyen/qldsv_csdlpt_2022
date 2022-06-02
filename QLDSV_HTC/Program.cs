using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_HTC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_publisher = "Data Source=DESKTOP-SK3SNKM;Initial Catalog=QLDSV_HTC;User ID=sa;Password=sa";
        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";
        public static String database = "QLDSV_HTC";
        public static String remoteLogin = "HTKN";
        public static String remotePassword = "12345";
        public static String mLoginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mChiNhanh = 0;
        public static bool laSinhVien = false;
        public static BindingSource bds_dspm = new BindingSource();


        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";Password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                try
                {
                    string tempMaSV = Program.mlogin; //Lưu tạm mã Sv lấy từ ô tên USername
                    string tempPassword = Program.password; //Pass SV nhập vào

                    Program.mlogin = "HTKNSV";
                    Program.password = "12345";
                    Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                    Program.database + ";User ID=" +
                    Program.mlogin + ";password=" + Program.password;
                    Program.conn.ConnectionString = Program.connstr;
                    Program.conn.Open();


                    string strLenhLaySVLogin = "EXEC SP_SinhVien_Login '" + tempMaSV + "'";
                    Program.myReader = Program.ExecSqlDataReader(strLenhLaySVLogin);
                    if (Program.myReader == null) return 0;
                    Program.myReader.Read();

                    if (tempPassword != Program.myReader.GetString(2)) return 0;//SS pass từ bảng sv và mk sv nhập vào

                    Program.username = Program.myReader.GetString(0);
                    Program.mHoten = Program.myReader.GetString(1);
                    Program.mGroup = "SV";

                    Program.conn.Close();
                    laSinhVien = true;
                    return 1;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message.ToString());
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + err.Message, "", MessageBoxButtons.OK);
                    return 0;
                }

            }
        }

     /*        public static DataTable ExecSqlDatatable(string strlenh)
             {
            DataTable result;
            const string sql = @"
SELECT  1 AS A
UNION
SELECT  2
UNION
SELECT  3
";

            using (var conn = new SqlConnection(FiddleHelper.GetConnectionStringSqlServer()))
            {
                using (SqlCommand command = conn.CreateCommand())
                {
                    conn.Open();
                    command.CommandText = sql;

                    //C# Extension Method: SqlCommand - ExecuteDataTable
                    result = command.ExecuteDataTable(); // return DataSet (3 tables).
                    conn.Close();

                    Console.WriteLine(result.Rows.Count);
                }
            }
            var dt = new DataTable();
                using (var dataAdapter = new SqlDataAdapter(strlenh))
                {
                    dataAdapter.Fill(dt);
                }

                return dt;
                conn.Close();
                da.Dispose();
        }
             */

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            //Khai báo thêm giá trị trả về khi exec sp
            //var returnParameter = sqlcmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            //returnParameter.Direction = ParameterDirection.ReturnValue;
            //
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                //var result = returnParameter.Value;
                return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static frmMain frmMain;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmMain = new frmMain();
            Application.Run(frmMain);
        }
    }
}
