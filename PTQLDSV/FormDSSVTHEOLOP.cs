using DevExpress.XtraReports.UI;
using PTQLDSV.BaoCao;
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
    public partial class FormDSSVTHEOLOP : Form
    {
        public FormDSSVTHEOLOP()
        {
            InitializeComponent();
        }

        private void FormDSSVTHEOLOP_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENCN";
            cbKhoa.ValueMember = "TENSERVER";
            // Program.vitriIndex = Program.mKhoa;
            cbKhoa.SelectedIndex = Program.mKhoa;

            cbMalop.DataSource = bdsLOP;
            cbMalop.DisplayMember = "TENLOP";
            cbMalop.ValueMember = "MALOP";
            cbMalop.SelectedIndex = 1;
            cbMalop.SelectedIndex = 0;
            if (Program.mGroup == "KHOA")
            {
                cbKhoa.Enabled = false;
            }
            else
            {
                cbKhoa.Enabled = true;
            }
            //lbltest.Text = Program.conn.ConnectionString;
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLOP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string malop = txtMalop.Text.Trim();
            Xrpt_DanhSachSinhVienTheoLop rpt = new Xrpt_DanhSachSinhVienTheoLop(malop);
            
            //rpt.lblTieuDe.Text = ‘DANH SÁCH PHIẾU ‘ +cmbLoai.Text.ToUpper() + ‘ NHÂN VIÊN LẬP TRONG NĂM ‘ &cmbNam.Text;
            rpt.lblLop.Text = cbMalop.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKhoa.SelectedIndex == 2)
            {
                MessageBox.Show("Login không có quyền vào phòng kế toán");
                cbKhoa.SelectedIndex = 0;
                return;
            }
            if (cbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cbKhoa.SelectedValue.ToString();

            if (cbKhoa.SelectedIndex != Program.mKhoa)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối đến khoa khác", "", MessageBoxButtons.OK);
            else
            {
                dS.EnforceConstraints = false;
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
                cbMalop.SelectedIndex = 1;
                cbMalop.SelectedIndex = 0;
            }
        }

        private void cbMalop_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lg.Text = Program.mlogin;
            //pwd.Text = Program.password;
            try
            {               
                txtMalop.Text = cbMalop.SelectedValue.ToString().Trim();   
            }
            catch { }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
