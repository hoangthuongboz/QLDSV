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
    public partial class FormLop : Form
    {
        public FormLop()
        {
            InitializeComponent();
        }

        int vitri, vtkh;
        String makh = "", check;
        bool flag = true;
        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormLop_Load(object sender, EventArgs e)
        {
            //Yeu cau he thong k kt khóa ngoại
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            
            makh = ((DataRowView)bdsLop[0])["MAKH"].ToString();
            
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
                makh = ((DataRowView)bdsLop[0])["MAKH"].ToString();
                vtkh = cbKhoa.SelectedIndex;
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLop.Position;
            groupBox1.Enabled = false;
            bdsLop.AddNew();
            txtMaKhoa.Text = makh;
            txtMalop.ReadOnly = txtTenlop.ReadOnly = false;
            btnAdd.Enabled = btnReload.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnClose.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            gcLop.Enabled = false;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMalop.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn đối tượng để xóa!");
                return;
            }
            if (bdsSV.Count > 0)
            {
                MessageBox.Show("Có sinh viên ở trong lớp!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa lớp này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsLop.RemoveCurrent();
                    this.lOPTableAdapter.Update(this.dS.LOP);
                    
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
            if (txtMalop.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn đối tượng edit!");
                return;
            }
            vitri = bdsLop.Position;
            txtTenlop.ReadOnly = false;
            groupBox1.Enabled = true;
            btnAdd.Enabled = btnClose.Enabled = btnReload.Enabled = btnDelete.Enabled = btnEdit.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            gcLop.Enabled = false;
            flag = false;
            check = txtMalop.Text;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMalop.Text.Trim() == "")
            {
                MessageBox.Show("Không được đê trống mã lớp!");
                txtMalop.Focus();
                return;
            }
            //string connectionString = "Data Source=DESKTOP-OT9F85F\\SERVER1;Initial Catalog=QLDSV;Persist Security Info=True;User ID=SON;Password=123";
            
            if(flag == true)
            {
                if (Program.dsLop(txtMalop.Text, Program.connstr))
                {
                    MessageBox.Show("Đã tồn tại lớp ứng với mã này!");
                    return;
                }
            }
            if (txtMalop.Text.ToLower().Trim() != check.ToLower().Trim())
            {
                if (Program.dsLop(txtMalop.Text, Program.connstr))
                {
                    MessageBox.Show("Đã tồn tại lớp ứng với mã này!");
                    return;
                }
            }
            if (txtTenlop.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống tên lớp!");
                txtTenlop.Focus();
                return;
            }
            
            try
            {
                bdsLop.EndEdit();
                bdsLop.ResetCurrentItem();
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.dS.LOP);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp\n" + ex.Message, "", MessageBoxButtons.OK);
            }
            txtMalop.ReadOnly = txtTenlop.ReadOnly = true;
            gcLop.Enabled = true;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReload.Enabled = btnClose.Enabled = btnSave.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
            flag = true;
            groupBox1.Enabled = true;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.CancelEdit();
            if (btnAdd.Enabled == false)
            {
                bdsLop.Position = vitri;
            }
            txtMalop.ReadOnly = txtTenlop.ReadOnly = true;
            gcLop.Enabled = true;
            groupBox1.Enabled = true;
            btnAdd.Enabled = btnDelete.Enabled = btnReload.Enabled = btnEdit.Enabled = btnClose.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
            dS.EnforceConstraints = false;
            this.lOPTableAdapter.Fill(this.dS.LOP);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dS.EnforceConstraints = false;
            this.lOPTableAdapter.Fill(this.dS.LOP);
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
