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
    public partial class FormPhieuDiemSinhVien : Form
    {
        public FormPhieuDiemSinhVien()
        {
            InitializeComponent();
        }
        int vtkh;
        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormPhieuDiemSinhVien_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.SINHVIEN1' table. You can move, or remove it, as needed.
            this.sINHVIEN1TableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIEN1TableAdapter.Fill(this.dS.SINHVIEN1);
            
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENCN";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mKhoa;

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
                cbKhoa.SelectedIndex = vtkh;
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
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                
                vtkh = cbKhoa.SelectedIndex;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            
            string masv = "";
            if (txtMaSV.Text != string.Empty)
            {
                if (Program.CheckSV(txtMaSV.Text.Trim(), Program.connstr))
                {
                    masv = cbMaSV.SelectedValue.ToString();
                    Xrpt_PhieuDiemSinhVien obj = new Xrpt_PhieuDiemSinhVien(masv);
                    obj.lblMaSinhVien.Text = masv;
                    cbMaSV.SelectedValue = masv;
                    ReportPrintTool print = new ReportPrintTool(obj);
                    print.ShowPreviewDialog();
                }
                else
                {
                    MessageBox.Show("Sinh viên không có trong khoa hoặc bạn nhập sai mã SV!");
                }
            }
            else
            {
                masv = cbMaSV.SelectedValue.ToString();
                Xrpt_PhieuDiemSinhVien obj = new Xrpt_PhieuDiemSinhVien(masv);
                obj.lblMaSinhVien.Text = cbMaSV.SelectedValue.ToString();
                obj.lblTen.Text = cbMaSV.Text;
                ReportPrintTool print = new ReportPrintTool(obj);
                print.ShowPreviewDialog();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtTest.Text = cbMaSV.SelectedValue.ToString();
            }
            catch { }
        }
    }
}
