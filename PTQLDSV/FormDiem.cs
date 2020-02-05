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
    public partial class FormDiem : Form
    {
        public FormDiem()
        {
            InitializeComponent();
        }

        int vitri, vtkh;
        String masv = "";
        
        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormDiem_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.GETDSMONHOC' table. You can move, or remove it, as needed.
            this.gETDSMONHOCTableAdapter.Fill(this.dS.GETDSMONHOC);
            this.gETDSMONHOCTableAdapter.Fill(this.dS.GETDSMONHOC);            
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);           
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            // TODO: This line of code loads data into the 'dS.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dIEMTableAdapter.Fill(this.dS.DIEM);

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
            if (Program.mGroup == "KHOA" || Program.mGroup == "KETOAN")
            {
                cbKhoa.Enabled = false;
            }
            else
            {
                cbKhoa.Enabled = true;
            }
            btnSave.Enabled = btnUndo.Enabled = false;  
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
                //lbltest.Text = Program.conn.ConnectionString;
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
                cbLop.SelectedIndex = 1;
                cbLop.SelectedIndex = 0;
                vtkh = cbKhoa.SelectedIndex;
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (bdsSV.Count<1)
            {
                MessageBox.Show("Lớp này không có sinh viên nên không thể thêm điểm!");
                return;
            }
            vitri = bdsD.Position;
            groupBox1.Enabled = false;
            bdsD.AddNew();
            nudLanThi.Value = 2;
            nudLanThi.DownButton();
            nudDiem.Value = 1;
            nudDiem.DownButton();
            nudDiem.ReadOnly = false;
            btnAdd.Enabled = btnReload.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnClose.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            gcDiem.Enabled = false;
            cbMaSinhVien.SelectedValue = masv;
            cbMaSinhVien.Enabled = false;
            groupBox3.Enabled = false;
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch { };
            
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cbMaSinhVien.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Không được để trống mã sinh viên!");
                cbMaSinhVien.Focus();
                return;
            }
            if (cbMaMonHoc.Text.Trim() == "")
            {
                MessageBox.Show("Không được đê trống mã môn học!");
                cbMaMonHoc.Focus();
                return;
            }
            
            if (nudDiem.Value.ToString() == "")
            {
                MessageBox.Show("Không được để trống điểm thi!");
                nudDiem.Focus();
                return;
            }
            if (nudLanThi.Value.ToString() == "")
            {
                MessageBox.Show("Không được để trống lần thi!");
                nudLanThi.Focus();
                return;
            }

            try
            {
                dS.EnforceConstraints = false;
                bdsD.EndEdit();
                bdsD.ResetCurrentItem();
                this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dIEMTableAdapter.Update(this.dS.DIEM);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi điểm!\n" + ex.Message, "", MessageBoxButtons.OK);
            }
            gcDiem.Enabled = true;
            nudDiem.ReadOnly = nudLanThi.ReadOnly = true;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReload.Enabled = btnClose.Enabled = btnSave.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
            cbMaSinhVien.Enabled = true;
            groupBox1.Enabled = true;
            groupBox3.Enabled = true;
            dS.EnforceConstraints = false;
            this.dIEMTableAdapter.Fill(this.dS.DIEM);
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbLop.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
                txtML.Text = cbLop.SelectedValue.ToString();
                dS.EnforceConstraints = false;
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                
                cbMaSinhVien.SelectedIndex = 1;
                cbMaSinhVien.SelectedIndex = 0;
                this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dIEMTableAdapter.Fill(this.dS.DIEM);
            }
            catch (Exception) { };
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsD.CancelEdit();
            if (btnAdd.Enabled == false)
            {
                bdsD.Position = vitri;
            }
            gcDiem.Enabled = true;
            nudDiem.ReadOnly = nudLanThi.ReadOnly = true;
            groupBox1.Enabled = true;
            btnAdd.Enabled = btnDelete.Enabled = btnReload.Enabled = btnEdit.Enabled = btnClose.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
            cbMaSinhVien.Enabled = true;
            groupBox3.Enabled = true;
            dS.EnforceConstraints = false;
            this.dIEMTableAdapter.Fill(this.dS.DIEM);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dS.EnforceConstraints = false;
            this.dIEMTableAdapter.Fill(this.dS.DIEM);
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSV.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn đối tượng!");
                return;
            }
            vitri = bdsSV.Position;
            groupBox1.Enabled = false;
            cbMaSinhVien.Enabled = false;
            nudDiem.ReadOnly = nudLanThi.ReadOnly = false;
            btnAdd.Enabled = btnClose.Enabled = btnReload.Enabled = btnDelete.Enabled = btnEdit.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            groupBox3.Enabled = false;
            gcDiem.Enabled = false;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSV.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn đối tượng!");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa điểm của sinh viên này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsD.RemoveCurrent();
                    this.dIEMTableAdapter.Update(this.dS.DIEM);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa điểm sinh viên!\n" + ex.Message, "", MessageBoxButtons.OK);
                }
            }

            btnClose.Enabled = true;
            btnUndo.Enabled = false;
        }

        private void cbMaSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbMaSinhVien.SelectedValue.ToString() != null)
                {
                    masv = cbMaSinhVien.SelectedValue.ToString();
                }
            }
            catch
            {
            }
        }

        private void cbMaMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if(txtMalop.Text.Trim()== "" || txtMaSinhVien.Text.Trim()=="")
            {
                MessageBox.Show("Vui lòng không để trống!");
            }
            else
            {
                if (Program.CheckLop(txtMalop.Text, Program.conn.ConnectionString + "Password = 123"))
                {
                    
                    if (Program.CheckSV(txtMaSinhVien.Text, Program.conn.ConnectionString + "Password = 123"))
                    {
                        cbLop.SelectedValue = txtMalop.Text.Trim();
                        cbMaSinhVien.SelectedValue = txtMaSinhVien.Text.Trim();
                    }
                    else
                    {
                        MessageBox.Show("Bạn nhập sai hoặc sinh viên này không tồn tại trong lớp!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Bạn nhập sai học lớp này không tồn tại trong khoa!");
                    return;
                }
            }
            
        }
    }
}
