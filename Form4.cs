using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SystemAccounting.bin.Debug;
using CrystalDecisions.Shared;

namespace SystemAccounting
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crystal9 cyRpt1 = new Crystal9();

            cyRpt1.Load(Application.StartupPath + "\\Crystal9.rpt");
            cyRpt1.SetDatabaseLogon("DB_9B0A2E_Safwa_admin", "123asd!@#", @"SQL5009.Smarterasp.net", "DB_9B0A2E_Safwa");
            rpt.ReportSource = cyRpt1;
            ParameterField pram = new ParameterField();
          
            pram.Name = "@Date";
         
            ParameterDiscreteValue pValue = new ParameterDiscreteValue();
            
            pValue.Value = "'" + textBox1.Text + "'";
           
            pram.CurrentValues.Clear();
            pram.CurrentValues.Add(pValue);
            rpt.ParameterFieldInfo.Add(pram);
            //rpt.ReportSource = cyRpt1;
            rpt.Refresh(); 
        }
    }
}
