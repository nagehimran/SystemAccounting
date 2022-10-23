﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using SystemAccounting.bin.Debug;

namespace SystemAccounting
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CrystalReport2 cyRpt1 = new CrystalReport2();

            cyRpt1.Load(Application.StartupPath + "\\CrystalReport9.rpt");
            cyRpt1.SetDatabaseLogon("DB_9B0A2E_Safwa_admin", "123asd!@#", @"SQL5009.Smarterasp.net", "DB_9B0A2E_Safwa");
            rpt.ReportSource = cyRpt1;
            rpt.Refresh();
        }
    }
}
