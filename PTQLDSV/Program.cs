using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using System.Data;

namespace PTQLDSV
{
    static class Program
    {
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataAdapter da;
        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

        public static String database = "QLDSV";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mKhoa = 0;
        //public static int vitriIndex;
        //public static String MAKH="";
        public static FormMain frmChinh;

        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập
        //public static frmMain frmChinh;

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open) Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" + Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        //k cho sua, them, xoa chi cho xem, co nhieu dong thi chi cho phep di xuong chu k cho di nguoc,chi dung de in bao cao
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        //tai du lieu ve sua roi cap nhap ve csdl lai 
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static DataTable ExecSqlQuery(String cmd, String connectionstring)
        {
            DataTable dt1 = new DataTable();
            conn = new SqlConnection(connectionstring);
            da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt1);
            return dt1;

        }


        public static int ExecSqlNonQuery(String cmd, String connectionstring)
        {
            conn = new SqlConnection(connectionstring);
            SqlCommand Sqlcmd = new SqlCommand();
            Sqlcmd.Connection = conn;
            Sqlcmd.CommandText = cmd;
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 300;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {

                Sqlcmd.ExecuteNonQuery(); conn.Close(); return 1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return 0;
            }
        }

        
        public static bool dsLop(string MALOP, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_DSLOP", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string Mal = (string)reader["MALOP"];
                            Mal = Mal.ToLower();
                            MALOP = MALOP.ToLower();
                            if (MALOP.Trim() == Mal.Trim())
                            {                               
                                return true;
                            }                            
                        }
                        return false;
                    }
                }
            }
        }

        public static bool dsGiangVien(string MAGV, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_DSGIANGVIEN", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            string mgv = (string)reader["MAGV"];
                            mgv = mgv.ToLower();
                            MAGV = MAGV.ToLower();
                            if (MAGV.Trim() == mgv.Trim())
                            {
                                return true;
                            }
                        }
                        return false;
                    }
                }
            }
        }
        //toan bo sinh vien
        public static bool dsSinhVien(string MASV, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_DSSINHVIEN", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string mgv = (string)reader["MASV"];
                            mgv = mgv.ToLower();
                            MASV = MASV.ToLower();
                            if (MASV.Trim() == mgv.Trim())
                            {
                                return true;
                            }
                        }
                        return false;
                    }
                }
            }
        }
        

        public static bool dsMonHoc(string MAMH, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_DSMONHOC", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string mgv = (string)reader["MAMH"];
                            mgv = mgv.ToLower();
                            MAMH = MAMH.ToLower();
                            if (MAMH.Trim() == mgv.Trim())
                            {
                                return true;
                            }
                        }
                        return false;
                    }
                }
            }
        }

        public static Sinhvien GetSinhvien(string MASV, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM SINHVIEN WHERE MASV = @MASV", connection))
                {
                    command.Parameters.Add("@MASV", SqlDbType.Char,12).Value = MASV;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Sinhvien
                            {
                                MASV = (string)reader["MASV"],
                                HO = (string)reader["HO"],
                                TEN = (string)reader["TEN"],
                                MALOP =(string)reader["MALOP"]
                            };
                        }
                        return null;
                    }
                }
            }
        }

        public static List<HocPhi> GetHocPhis(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM HOCPHI", connection))
                {
                    //command.Parameters.Add("@MASV", SqlDbType.Char, 12).Value = MASV;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<HocPhi> list = new List<HocPhi>();
                        while (reader.Read())
                        {
                            HocPhi obj = new HocPhi
                            {
                                MASV = (string)reader["MASV"],
                                NIENKHOA = (string)reader["NIENKHOA"],
                                HOCKY = (int)reader["HOCKY"],
                                HOCPHI = (int)reader["HOCPHI"],
                                SOTIENDADONG = (int)reader["SOTIENDADONG"]
                            };
                            list.Add(obj);
                        }
                        return list;
                    }
                }
            }
        }
        
        //CHECK xem malop nhap vao co trong phan manh k
        public static bool CheckLop(string MAMH, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT MALOP FROM LOP", connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string mgv = (string)reader["MALOP"];
                            mgv = mgv.ToLower();
                            MAMH = MAMH.ToLower();
                            if (MAMH.Trim() == mgv.Trim())
                            {
                                return true;
                            }
                        }
                        return false;
                    }
                }
            }
        }

        public static bool CheckSV(string MAMH, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT MASV FROM SINHVIEN", connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string mgv = (string)reader["MASV"];
                            mgv = mgv.ToLower();
                            MAMH = MAMH.ToLower();
                            if (MAMH.Trim() == mgv.Trim())
                            {
                                return true;
                            }
                        }
                        return false;
                    }
                }
            }
        }

        public static void SetEnableOfButton(Form frm, Boolean Active)
        {

            foreach (Control ctl in frm.Controls)
                if ((ctl) is Button)
                    ctl.Enabled = Active;
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new FormMain();
            Application.Run(frmChinh);

        }
    }
}
