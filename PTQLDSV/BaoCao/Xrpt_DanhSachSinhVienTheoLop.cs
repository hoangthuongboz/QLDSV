using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace PTQLDSV.BaoCao
{
    public partial class Xrpt_DanhSachSinhVienTheoLop : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DanhSachSinhVienTheoLop(string MALOP)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_DSSVTHEOLOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DSSVTHEOLOPTableAdapter.Fill(ds1.SP_DSSVTHEOLOP, MALOP);

        }

    }
}
