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
    public partial class FormGiangVien : Form
    {
        public FormGiangVien()
        {
            InitializeComponent();
        }
        int vitri, vtkh;
        String makh = "", check;
        bool flag = true;
        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gIANGVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormGiangVien_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.GIANGVIEN' table. You can move, or remove it, as needed.  
            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);
            makh = ((DataRowView)bdsGV[0])["MAKH"].ToString();
            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENCN";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mKhoa;
            vtkh = cbKhoa.SelectedIndex;
            if (Program.mGroup == "KHOA" || Program.mGroup == "KETOAN")
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
            }
            btnSave.Enabled = btnUndo.Enabled = false;
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbKhoa.SelectedIndex == 2)
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
                this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);
                makh = ((DataRowView)bdsGV[0])["MAKH"].ToString();
                vtkh = cbKhoa.SelectedIndex;
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsGV.Position;
            groupBox1.Enabled = false;
            bdsGV.AddNew();
            txtMaKhoa.Text = makh;
            txtMaGV.ReadOnly = txtHoGV.ReadOnly = txtTenGV.ReadOnly = false;
            btnAdd.Enabled = btnReload.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnClose.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            gcGV.Enabled = false;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaGV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn đối tượng edit!");
                return;
            }
            vitri = bdsGV.Position;

            txtMaGV.ReadOnly = txtTenGV.ReadOnly = txtHoGV.ReadOnly = false;
            groupBox1.Enabled = false;
            btnAdd.Enabled = btnClose.Enabled = btnReload.Enabled = btnDelete.Enabled = btnEdit.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            gcGV.Enabled = false;
            flag = false;
            check = txtMaGV.Text;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (txtMaGV.Text.Trim() == "")
            {
                MessageBox.Show("Không được đê trống mã giảng viên!");
                txtMaGV.Focus();
                return;
            }
            /*string connectionString = "Data Source=DESKTOP-OT9F85F\\SERVER1;Initial Catalog=QLDSV;Persist Security Info=True;User ID=SON;Password=123";*/
            if (flag == true)
            {
                if (Program.dsGiangVien(txtMaGV.Text, Program.connstr))
                {
                    MessageBox.Show("Đã tồn tại giảng viên ứng với mã này!");
                    return;
                }
            }
            if (txtMaGV.Text.ToLower().Trim() != check.ToLower().Trim())
            {
                if (Program.dsGiangVien(txtMaGV.Text, Program.connstr))
                {
                    MessageBox.Show("Đã tồn tại giảng viên ứng với mã này!");
                    return;
                }
            }
            if (txtHoGV.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống họ giảng viên");
                txtHoGV.Focus();
                return;
            }
            if (txtTenGV.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống tên giảng viên");
                txtTenGV.Focus();
                return;
            }
            try
            {
                bdsGV.EndEdit();
                bdsGV.ResetCurrentItem();
                this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIANGVIENTableAdapter.Update(this.dS.GIANGVIEN);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi giảng viên\n" + ex.Message, "", MessageBoxButtons.OK);
            }
            txtMaGV.ReadOnly = txtHoGV.ReadOnly = txtTenGV.ReadOnly = true;
            gcGV.Enabled = true;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReload.Enabled = btnClose.Enabled = btnSave.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled= false;

            groupBox1.Enabled = true;
            flag = true;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGV.CancelEdit();
            if (btnAdd.Enabled == false)
            {
                bdsGV.Position = vitri;
            }
            txtMaGV.ReadOnly = txtHoGV.ReadOnly = txtTenGV.ReadOnly = true;
            gcGV.Enabled = true;
            groupBox1.Enabled = true;
            btnAdd.Enabled = btnDelete.Enabled = btnReload.Enabled = btnEdit.Enabled = btnClose.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
            dS.EnforceConstraints = false;
            this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaGV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn đối tượng để xóa!");
                return;
            }
            if (MessageBox.Show ("Bạn có muốn xóa giảng viên này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsGV.RemoveCurrent();
                    this.gIANGVIENTableAdapter.Update(this.dS.GIANGVIEN);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giảng viên!\n" + ex.Message, "", MessageBoxButtons.OK);
                }
            }
            btnClose.Enabled = true;
            btnUndo.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dS.EnforceConstraints = false;
            this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);
            btnClose.Enabled = true;
        }
    }
}
