using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace PTQLDSV.BaoCao
{
    public partial class Xrpt_BangDiemMonHocTheoLop : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_BangDiemMonHocTheoLop(string tenlop, string tenmh, short lan)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_BANGDIEMMONHOCTHEOLOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_BANGDIEMMONHOCTHEOLOPTableAdapter.Fill(ds1.SP_BANGDIEMMONHOCTHEOLOP, tenlop, tenmh, lan);
        }

    }
}
