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
    public partial class FormSinhVien : Form
    {
        public FormSinhVien()
        {
            InitializeComponent();
        }

        
        int vitri, vtkh;
        String malop = "";
        string check = "";
        bool flag = true;
        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            // TODO: This line of code loads data into the 'dS.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dIEMTableAdapter.Fill(this.dS.DIEM);
            // TODO: This line of code loads data into the 'dS.HOCPHI' table. You can move, or remove it, as needed.
            this.hOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.hOCPHITableAdapter.Fill(this.dS.HOCPHI);

            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENCN";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mKhoa;
            vtkh = cbKhoa.SelectedIndex;

            //Lay gia tri dau tien cho cblop
            cbLop.DataSource = bdsLop;
            cbLop.DisplayMember = "TENLOP";
            cbLop.ValueMember = "MALOP";
            cbLop.SelectedIndex = 1;
            cbLop.SelectedIndex = 0;
            malop = ((DataRowView)bdsLop[0])["MALOP"].ToString();
            
            if (Program.mGroup == "KHOA" || Program.mGroup == "KETOAN")
            {
                cbKhoa.Enabled = false;
            }
            else
            {
                cbKhoa.Enabled = true;
            }
            txtMaLop.Text = malop;
            btnSave.Enabled = btnUndo.Enabled = false;
            checkPhai.Enabled = checkNghiHoc.Enabled = false;
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
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
                cbLop.SelectedIndex = 1;
                cbLop.SelectedIndex = 0;
                malop = ((DataRowView)bdsLop[0])["MALOP"].ToString();
                vtkh = cbKhoa.SelectedIndex;
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsSV.Position;
            groupBox1.Enabled = false;
            bdsSV.AddNew();
            txtMaLop.Text = malop;
            txtMaSV.ReadOnly = txtHo.ReadOnly = txtTen.ReadOnly = txtNote.ReadOnly = txtNoiSinh.ReadOnly = txtDiaChi.ReadOnly = dateNgaySinh.ReadOnly = false;
            checkPhai.Enabled = checkNghiHoc.Enabled = true;
            checkPhai.Checked = checkNghiHoc.Checked = false;
            btnAdd.Enabled = btnReload.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnClose.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            gcSV.Enabled = false;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn đối tượng để xóa!");
                return;
            }
            if (bdsHP.Count > 0)
            {
                MessageBox.Show("Sinh viên chưa hoàn thành việc đóng học phí!", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsD.Count > 0)
            {
                MessageBox.Show("Có điểm tồn tại ứng với sinh viên này!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa sinh viên này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsSV.RemoveCurrent();
                    this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên!\n" + ex.Message, "", MessageBoxButtons.OK);
                }
            }

            btnClose.Enabled = true;
            btnUndo.Enabled = false;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn đối tượng edit!");
                return;
            }
            vitri = bdsSV.Position;
            groupBox1.Enabled = flag;
            checkPhai.Enabled = checkNghiHoc.Enabled = true;
            txtMaSV.ReadOnly = txtHo.ReadOnly = txtTen.ReadOnly = txtNote.ReadOnly = txtNoiSinh.ReadOnly = txtDiaChi.ReadOnly = dateNgaySinh.ReadOnly = false;
            btnAdd.Enabled = btnClose.Enabled = btnReload.Enabled = btnDelete.Enabled = btnEdit.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            gcSV.Enabled = false;
            flag = false;
            check = txtMaSV.Text;
            groupBox1.Enabled = false;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Không được đê trống mã sinh viên!");
                txtMaSV.Focus();
                return;
            }
            //string connectionString = "Data Source=DESKTOP-OT9F85F\\SERVER1;Initial Catalog=QLDSV;Persist Security Info=True;User ID=SON;Password=123";
            if(flag == true)
            {
                if (Program.dsSinhVien(txtMaSV.Text, Program.connstr))
                {
                    MessageBox.Show("Đã tồn tại SV ứng với mã này!");
                    return;
                }
            }
            if(txtMaSV.Text.ToLower().Trim() != check.ToLower().Trim())
            {
                if (Program.dsSinhVien(txtMaSV.Text, Program.connstr))
                {
                    MessageBox.Show("Đã tồn tại SV ứng với mã này!");
                    return;
                }
            }
            
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống họ sinh viên!");
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống tên sinh viên!");
                txtTen.Focus();
                return;
            }           
            if (txtNoiSinh.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống nơi sinh!");
                txtNoiSinh.Focus();
                return;
            }
            if (dateNgaySinh.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn ngày sinh!");
                dateNgaySinh.Focus();
                return;
            }
            try
            {
                bdsSV.EndEdit();
                bdsSV.ResetCurrentItem();
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên\n" + ex.Message, "", MessageBoxButtons.OK);
            }
            gcSV.Enabled = true;
            txtMaSV.ReadOnly = txtHo.ReadOnly = txtTen.ReadOnly = txtNote.ReadOnly = txtNoiSinh.ReadOnly = txtDiaChi.ReadOnly = dateNgaySinh.ReadOnly = true;
            checkPhai.Enabled = checkNghiHoc.Enabled = false;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReload.Enabled = btnClose.Enabled = btnSave.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
            flag = true;
            groupBox1.Enabled = true;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSV.CancelEdit();
            if (btnAdd.Enabled == false)
            {
                bdsSV.Position = vitri;
            }
            gcSV.Enabled = true;
            txtMaSV.ReadOnly = txtHo.ReadOnly = txtTen.ReadOnly = txtNote.ReadOnly = txtNoiSinh.ReadOnly = txtDiaChi.ReadOnly = dateNgaySinh.ReadOnly = true;
            checkPhai.Enabled = checkNghiHoc.Enabled = false;
            groupBox1.Enabled = true;
            btnAdd.Enabled = btnDelete.Enabled = btnReload.Enabled = btnEdit.Enabled = btnClose.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
            dS.EnforceConstraints = false;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dS.EnforceConstraints = false;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbLop.SelectedValue.ToString() == "System.Data.DataRowView")
                    return;
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                malop = ((DataRowView)bdsLop[0])["MALOP"].ToString();
            }
            catch (Exception) { };
        }
    }
}
