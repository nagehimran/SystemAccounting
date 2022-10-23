using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SystemAccounting.bin.Debug;

namespace SystemAccounting
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            CrystalReport1 cyRpt1 = new CrystalReport1();

            cyRpt1.Load(Application.StartupPath + "\\CrystalReport1.rpt");
            cyRpt1.SetDatabaseLogon("DB_9B0A2E_Safwa_admin", "123asd!@#", @"SQL5009.Smarterasp.net", "DB_9B0A2E_Safwa");
            rpt.ReportSource = cyRpt1;
            rpt.Refresh();
        }
    }
}
