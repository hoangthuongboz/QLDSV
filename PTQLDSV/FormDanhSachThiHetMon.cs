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
    public partial class FormDanhSachThiHetMon : Form
    {
        public FormDanhSachThiHetMon()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormDanhSachThiHetMon_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENCN";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mKhoa;

            cbLop.DataSource = bdsLop;
            cbLop.DisplayMember = "TENLOP";
            cbLop.ValueMember = "MALOP";
            cbLop.SelectedIndex = 1;
            cbLop.SelectedIndex = 0;

            if (Program.mGroup == "KHOA" || Program.mGroup == "KETOAN")
            {
                cbKhoa.Enabled = false;
            }
            else
            {
                cbKhoa.Enabled = true;
            }

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
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
                cbLop.SelectedIndex = 1;
                cbLop.SelectedIndex = 0;
            }
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMalop.Text = cbLop.SelectedValue.ToString();
            }
            catch { }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (txtLanThi.Text.Trim() == "" || short.Parse(txtLanThi.Text) < 1 || short.Parse(txtLanThi.Text) > 2)
            {
                MessageBox.Show("Mỗi sinh viên chỉ được thi 1 môn 2 lần!\nVui lòng nhập đúng lần thi!");
                return;
            }
            string malop = cbLop.SelectedValue.ToString().Trim();
            string monhoc = cbMonHoc.SelectedValue.ToString().Trim();
            short lan = short.Parse(txtLanThi.Text);

            Xrpt_DSThiHetMon obj = new Xrpt_DSThiHetMon(malop, monhoc, lan);
            //rpt.lblTieuDe.Text = ‘DANH SÁCH PHIẾU ‘ +cmbLoai.Text.ToUpper() + ‘ NHÂN VIÊN LẬP TRONG NĂM ‘ &cmbNam.Text;
            obj.lblLop.Text = cbLop.Text;
            obj.lblMH.Text = cbMonHoc.Text;
            obj.lblLanThi.Text = txtLanThi.Text;
            ReportPrintTool print = new ReportPrintTool(obj);
            print.ShowPreviewDialog();
        }
    }
}
