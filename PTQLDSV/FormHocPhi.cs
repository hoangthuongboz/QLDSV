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
    public partial class FormHocPhi : Form
    {
        public FormHocPhi()
        {
            InitializeComponent();
        }
        int vitri;
        //string connectionString = "Data Source=DESKTOP-OT9F85F\\SERVER3;Initial Catalog=QLDSV;Persist Security Info=True;User ID=THUAN;Password=123";
        private void btnView_Click(object sender, EventArgs e)
        {
            //string hoten, malop;
            

            Sinhvien sv = Program.GetSinhvien(txtMaSV.Text.Trim(), Program.connstr);
            if (sv == null)
            {
                MessageBox.Show("Vui long nhap dung ma sv!");
            }
            else
            {
                txtHoVaTen.Text = sv.HO + " " + sv.TEN;
                txtLop.Text = sv.MALOP;
                cbMaSV.SelectedValue = txtMaSV.Text.Trim();
            }

            
        }

        private void hOCPHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsHP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormHocPhi_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            
            // TODO: This line of code loads data into the 'dS.HOCPHI' table. You can move, or remove it, as needed.
            this.hOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.hOCPHITableAdapter.Fill(this.dS.HOCPHI);

            //lbltest.Text = Program.conn.ConnectionString;

            try
            {
                dgvHocPhi.DataSource = Program.GetHocPhis(Program.connstr);
                Sinhvien sv = Program.GetSinhvien(cbMaSV.Text.Trim(), Program.connstr);
                if (sv == null)
                {
                    //MessageBox.Show("Vui long nhap dung ma sv!");
                    return;
                }
                else
                {
                    txtHoVaTen.Text = sv.HO + " " + sv.TEN;
                    txtLop.Text = sv.MALOP;
                }
            }
            catch
            {

            }
            btnSave.Enabled = btnUndo.Enabled = false;
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
                     
            try
            {
                Sinhvien sv = Program.GetSinhvien(cbMaSV.Text.Trim(), Program.connstr);
                if (sv == null)
                {
                    //MessageBox.Show("Vui long nhap dung ma sv!");
                    return;
                }
                else
                {
                    txtHoVaTen.Text = sv.HO + " " + sv.TEN;
                    txtLop.Text = sv.MALOP;
                }
                dS.EnforceConstraints = false;
                this.hOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.hOCPHITableAdapter.Fill(this.dS.HOCPHI);
            
            }
            catch (Exception) { };
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsHP.Position;
            //groupBox1.Enabled = false;
            bdsHP.AddNew();
            
            cbMaSV.Enabled = false;
            txtMaSV.ReadOnly = true;
            txtNK.ReadOnly = false;
            nudHK.ReadOnly = nudHP.ReadOnly = nudSTDD.ReadOnly = false;
            nudHK.Value = 2;
            nudHK.DownButton();
            nudHP.Value = 100;
            nudHP.DownButton();
            nudSTDD.Value = 100;
            nudSTDD.DownButton();
            btnAdd.Enabled = btnReload.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnClose.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            gcHP.Enabled = false;
            btnView.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsHP.CancelEdit();
            if (btnAdd.Enabled == false)
            {
                bdsHP.Position = vitri;
            }
            gcHP.Enabled = true;
            cbMaSV.Enabled = true;
            txtMaSV.ReadOnly = false;
            txtNK.ReadOnly = true;
            nudHK.ReadOnly = nudHP.ReadOnly = nudSTDD.ReadOnly = true;
            groupBox1.Enabled = true;
            btnAdd.Enabled = btnDelete.Enabled = btnReload.Enabled = btnEdit.Enabled = btnClose.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
            btnView.Enabled = true;
            dS.EnforceConstraints = false;           
            this.hOCPHITableAdapter.Fill(this.dS.HOCPHI);
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtNK.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn đối tượng edit!");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa học phí của sinh viên này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsHP.RemoveCurrent();
                    this.hOCPHITableAdapter.Update(this.dS.HOCPHI);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa học phí sinh viên!\n" + ex.Message, "", MessageBoxButtons.OK);
                }
            }

            btnClose.Enabled = true;
            btnUndo.Enabled = false;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtNK.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn đối tượng edit!");
                return;
            }
            vitri = bdsHP.Position;
            cbMaSV.Enabled = false;
            txtMaSV.ReadOnly = true;
            txtNK.ReadOnly = false;
            btnView.Enabled = false;
            nudHK.ReadOnly = nudHP.ReadOnly = nudSTDD.ReadOnly = false;
            groupBox1.Enabled = true;           
            btnAdd.Enabled = btnClose.Enabled = btnReload.Enabled = btnDelete.Enabled = btnEdit.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            gcHP.Enabled = false;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtNK.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống niên khóa!");
                txtNK.Focus();
                return;
            }

            try
            {
                dS.EnforceConstraints = false;
                bdsHP.EndEdit();
                bdsHP.ResetCurrentItem();
                this.hOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.hOCPHITableAdapter.Update(this.dS.HOCPHI);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi học phí!\n" + ex.Message, "", MessageBoxButtons.OK);
            }
            gcHP.Enabled = true;
            
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReload.Enabled = btnClose.Enabled = btnSave.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
            gcHP.Enabled = true;
            cbMaSV.Enabled = true;
            txtMaSV.ReadOnly = false;
            txtNK.ReadOnly = true;
            nudHK.ReadOnly = nudHP.ReadOnly = nudSTDD.ReadOnly = true;
            btnView.Enabled = true;
            groupBox1.Enabled = true;
            dS.EnforceConstraints = false;
            this.hOCPHITableAdapter.Fill(this.dS.HOCPHI);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dS.EnforceConstraints = false;
            this.hOCPHITableAdapter.Fill(this.dS.HOCPHI);
        }
    }
}
