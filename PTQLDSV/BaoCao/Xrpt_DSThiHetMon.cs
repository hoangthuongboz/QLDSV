using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace PTQLDSV.BaoCao
{
    public partial class Xrpt_DSThiHetMon : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DSThiHetMon(string malop, string mamh, short lanthi)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_DSTHIHETMONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DSTHIHETMONTableAdapter.Fill(ds1.SP_DSTHIHETMON, malop, mamh, lanthi);
        }

    }
}
