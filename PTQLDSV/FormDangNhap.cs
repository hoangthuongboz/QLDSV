using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTQLDSV
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'qLDSVDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            //this.v_DS_PHANMANHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet.V_DS_PHANMANH);
            string chuoiketnoi = "Data Source=DESKTOP-OT9F85F\\SERVER;Initial Catalog=QLDSV;Integrated Security=True";
            Program.conn.ConnectionString = chuoiketnoi;
            Program.conn.Open();
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT * FROM V_DS_PHANMANH");
            Program.bds_dspm.DataSource = dt;
            cbKhoa.DataSource = dt;
            cbKhoa.DisplayMember = "TENPM";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = 1;
            cbKhoa.SelectedIndex = 0;

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật mã không được trống", "", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin = txtLogin.Text;
            Program.password = txtPass.Text;
            if (Program.KetNoi() == 0)
            {
                return;
            }

            Program.mKhoa = cbKhoa.SelectedIndex;
            //Program.bds_dspm = bdsDSPM;

            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;

            string strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            //khi doc dong dau tien thi contro dang nam trong bo nho trong 
            Program.myReader.Read();

            //doc du lieu cot dau tien
            Program.username = Program.myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);//doc ten
            Program.mGroup = Program.myReader.GetString(2);//doc ten nhom
            Program.myReader.Close();
            Program.conn.Close();
            //MessageBox.Show("Giảng viên: " + Program.mHoten + " - Nhóm: " + Program.mGroup, "", MessageBoxButtons.OK);
            Program.frmChinh.Activate();
            Program.frmChinh.Show();
            Program.frmChinh.MAGV.Text = "Mã giảng viên: " + Program.username;
            Program.frmChinh.HoTen.Text = "Họ tên: " + Program.mHoten;
            Program.frmChinh.GROUP.Text = "Nhóm: " + Program.mGroup;
            this.Close();
        }

        private void tENCNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKhoa.SelectedValue != null)
                Program.servername = cbKhoa.SelectedValue.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
