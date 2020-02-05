using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace PTQLDSV.BaoCao
{
    public partial class Xrpt_PhieuDiemSinhVien : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_PhieuDiemSinhVien(string masv)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_PHIEUDIEMSINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_PHIEUDIEMSINHVIENTableAdapter.Fill(ds1.SP_PHIEUDIEMSINHVIEN, masv);
        }

    }
}
