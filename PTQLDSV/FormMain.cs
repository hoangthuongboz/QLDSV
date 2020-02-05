using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PTQLDSV
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private bool KiemTraDangNhap()
        {
            if (Program.mGroup == string.Empty)
            {
                MessageBox.Show("Vui long dang nhap!");
                return false;
            }
            return true;
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDangNhap));
            if (Program.mGroup == "")
            {
                //Form frm = this.CheckExists(typeof(FormDangNhap));
                if (frm != null) frm.Activate();
                else
                {
                    FormDangNhap f = new FormDangNhap();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
            {
                if (frm != null)
                {
                    return;
                }
                else
                {
                    MessageBox.Show("Bạn vui lòng đăng xuất nếu muốn login vào tài khoản mới!");
                }
                
            }           
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                    
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            
            if (Program.mGroup == string.Empty)
            {
                MessageBox.Show("Bạn chưa đăng nhập!");
                Form frm = this.CheckExists(typeof(FormDangNhap));
                if (frm != null) frm.Activate();
                else
                {
                    FormDangNhap f = new FormDangNhap();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
            {
                Program.mGroup = string.Empty;
                Program.frmChinh.MAGV.Text = string.Empty;
                Program.frmChinh.GROUP.Text = string.Empty;
                Program.frmChinh.HoTen.Text = string.Empty;
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn đăng nhập vào tài khoản khác không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Form frm = this.CheckExists(typeof(FormDangNhap));
                    if (frm != null) frm.Activate();
                    else
                    {
                        FormDangNhap f = new FormDangNhap();
                        f.MdiParent = this;
                        f.Show();
                    }
                }
            }
        }

        private void btnGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "KETOAN")
            {
                MessageBox.Show("Login không có quyền vào mục này!");
                return;
            }
            else
            {
                if (KiemTraDangNhap() == true)
                {
                    Form frm = this.CheckExists(typeof(FormGiangVien));
                    if (frm != null) frm.Activate();
                    else
                    {
                        FormGiangVien f = new FormGiangVien();
                        f.MdiParent = this;
                        f.Show();
                    }
                }
            }
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                FormDangNhap f = new FormDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "KETOAN")
            {
                MessageBox.Show("Login không có quyền vào mục này!");
                return;
            }
            else
            {
                if (KiemTraDangNhap() == true)
                {
                    Form frm = this.CheckExists(typeof(FormLop));
                    if (frm != null) frm.Activate();
                    else
                    {
                        FormLop f = new FormLop();
                        f.MdiParent = this;
                        f.Show();
                    }
                }
            }
            
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "KETOAN")
            {
                MessageBox.Show("Login không có quyền vào mục này!");
                return;
            }
            else
            {
                if (KiemTraDangNhap() == true)
                {
                    Form frm = this.CheckExists(typeof(FormMonHoc));
                    if (frm != null) frm.Activate();
                    else
                    {
                        FormMonHoc f = new FormMonHoc();
                        f.MdiParent = this;
                        f.Show();
                    }
                }
            }
            
        }

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "KETOAN")
            {
                MessageBox.Show("Login không có quyền vào mục này!");
                return;
            }
            else
            {
                if (KiemTraDangNhap() == true)
                {
                    Form frm = this.CheckExists(typeof(FormSinhVien));
                    if (frm != null) frm.Activate();
                    else
                    {
                        FormSinhVien f = new FormSinhVien();
                        f.MdiParent = this;
                        f.Show();
                    }
                }
            }
            
        }

        private void btnBDMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "KETOAN")
            {
                MessageBox.Show("Login không có quyền vào mục này!");
                return;
            }
            else{
                if (KiemTraDangNhap() == true)
                {
                    Form frm = this.CheckExists(typeof(FormBangDiemMonHoc));
                    if (frm != null) frm.Activate();
                    else
                    {
                        FormBangDiemMonHoc f = new FormBangDiemMonHoc();
                        f.MdiParent = this;
                        f.Show();
                    }
                }
            }
            
        }

        private void btnDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "KETOAN")
            {
                MessageBox.Show("Login không có quyền vào mục này!");
                return;
            }
            else
            {
                if (KiemTraDangNhap() == true)
                {
                    Form frm = this.CheckExists(typeof(FormDiem));
                    if (frm != null) frm.Activate();
                    else
                    {
                        FormDiem f = new FormDiem();
                        f.MdiParent = this;
                        f.Show();
                    }
                }
            }
            
        }

        private void btnHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(Program.mGroup == "KHOA" || Program.mGroup == "PGV")
            {
                MessageBox.Show("Login không có quyền vào mục này!");
                return;
            }
            else
            {
                if (KiemTraDangNhap() == true)
                {
                    Form frm = this.CheckExists(typeof(FormHocPhi));
                    if (frm != null) frm.Activate();
                    else
                    {
                        FormHocPhi f = new FormHocPhi();
                        f.MdiParent = this;
                        f.Show();
                    }
                }
            }
            
        }

        private void btnDSSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "KETOAN")
            {
                MessageBox.Show("Login không có quyền vào mục này!");
                return;
            }
            else
            {
                if (KiemTraDangNhap() == true)
                {
                    Form frm = this.CheckExists(typeof(FormDSSVTHEOLOP));
                    if (frm != null) frm.Activate();
                    else
                    {
                        FormDSSVTHEOLOP f = new FormDSSVTHEOLOP();
                        f.MdiParent = this;
                        f.Show();
                    }
                }
            }
        }

        private void btnDSTHM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "KETOAN")
            {
                MessageBox.Show("Login không có quyền vào mục này!");
                return;
            }
            else
            {
                if (KiemTraDangNhap() == true)
                {
                    Form frm = this.CheckExists(typeof(FormDanhSachThiHetMon));
                    if (frm != null) frm.Activate();
                    else
                    {
                        FormDanhSachThiHetMon f = new FormDanhSachThiHetMon();
                        f.MdiParent = this;
                        f.Show();
                    }
                }
            }
        }

        private void btnCIoseForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Đóng Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnPhieuDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "KETOAN")
            {
                MessageBox.Show("Login không có quyền vào mục này!");
                return;
            }
            else
            {
                if (KiemTraDangNhap() == true)
                {
                    Form frm = this.CheckExists(typeof(FormPhieuDiemSinhVien));
                    if (frm != null) frm.Activate();
                    else
                    {
                        FormPhieuDiemSinhVien f = new FormPhieuDiemSinhVien();
                        f.MdiParent = this;
                        f.Show();
                    }
                }
            }
        }
    }
}
