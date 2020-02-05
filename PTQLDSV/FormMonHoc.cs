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
    public partial class FormMonHoc : Form
    {
        public FormMonHoc()
        {
            InitializeComponent();
        }

        int vitri, vtkh;
        string check;
        bool flag = true;
        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            // TODO: This line of code loads data into the 'dS.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dIEMTableAdapter.Fill(this.dS.DIEM);

            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENCN";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mKhoa;
            vtkh = cbKhoa.SelectedIndex;
            
            if(Program.mGroup=="KETOAN" || Program.mGroup == "KHOA")
            {
                groupBox1.Enabled = false;
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
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                vtkh = cbKhoa.SelectedIndex;
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMH.Position;
            //x1.Enabled = false;
            bdsMH.AddNew();
            //txtMaKhoa.Text = makh;
            txtMaMH.ReadOnly = txtTenMH.ReadOnly = false;
            btnAdd.Enabled = btnReload.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnClose.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            gcMH.Enabled = false;
            cbKhoa.Enabled = false;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsD.Count > 0)
            {
                MessageBox.Show("Có môn học ứng với điểm của sinh viên!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa môn học này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsMH.RemoveCurrent();
                    this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp!\n" + ex.Message, "", MessageBoxButtons.OK);
                }
            }
            btnClose.Enabled = true;
            btnUndo.Enabled = false;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn đối tượng edit!");
                return;
            }
            vitri = bdsMH.Position;
            //groupBox1.Enabled = true;
            txtTenMH.ReadOnly = txtMaMH.ReadOnly = false;
            btnAdd.Enabled = btnClose.Enabled = btnReload.Enabled = btnDelete.Enabled = btnEdit.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            gcMH.Enabled = false;
            check = txtMaMH.Text;
            flag = false;
            cbKhoa.Enabled = false;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Không được đê trống mã môn học!");
                txtMaMH.Focus();
                return;
            }
            //string connectionString = "Data Source=DESKTOP-OT9F85F\\SERVER1;Initial Catalog=QLDSV;Persist Security Info=True;User ID=SON;Password=123";
            if(flag == true)
            {
                if (Program.dsMonHoc(txtMaMH.Text, Program.connstr))
                {
                    MessageBox.Show("Đã tồn tại MH ứng với mã này!");
                    return;
                }
            }
            
            if (txtMaMH.Text.ToLower().Trim() != check.ToLower().Trim())
            {
                if (Program.dsMonHoc(txtMaMH.Text, Program.connstr))
                {
                    MessageBox.Show("Đã tồn tại môn học ứng với mã này!");
                    return;
                }
            }
            if (txtTenMH.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống tên môn học!");
                txtTenMH.Focus();
                return;
            }

            try
            {
                bdsMH.EndEdit();
                bdsMH.ResetCurrentItem();
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Update(this.dS.MONHOC);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi MH\n" + ex.Message, "", MessageBoxButtons.OK);

            }
            
            gcMH.Enabled = true;
            txtMaMH.ReadOnly = txtTenMH.ReadOnly = true;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReload.Enabled = btnClose.Enabled = btnSave.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
            cbKhoa.Enabled = true;
            flag = true;
            dS.EnforceConstraints = false;
            //this.gIANGVIENTableAdapter.Update(this.dS.GIANGVIEN);
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMH.CancelEdit();
            if (btnAdd.Enabled == false)
            {
                bdsMH.Position = vitri;
            }
            gcMH.Enabled = true;
            //groupBox1.Enabled = true;
            txtMaMH.ReadOnly = txtTenMH.ReadOnly = true;
            btnAdd.Enabled = btnDelete.Enabled = btnReload.Enabled = btnEdit.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
            cbKhoa.Enabled = true;
            
            dS.EnforceConstraints = false;
            //this.gIANGVIENTableAdapter.Update(this.dS.GIANGVIEN);
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dS.EnforceConstraints = false;
            //this.gIANGVIENTableAdapter.Update(this.dS.GIANGVIEN);
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
        }
    }
}
