using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SystemAccounting
{
    class Cl_Validate
    {
        public void TxtClear(Form frm, GroupBox pnl)
        {
            foreach (Control item in frm.Controls)
            {
                if (item is GroupBox)
                {
                    foreach (Control itemGroup in pnl.Controls)
                    {
                        if (itemGroup is TextBox)
                        {
                            itemGroup.Text = "";
                            
                        }

                        if (itemGroup is ComboBox)
                        {
                            itemGroup.Text = "";

                        }
                    }
                }
            }
        }
        public void TxtSure(Form frm, GroupBox pnl)
        {
            foreach (Control item in frm.Controls)
            {
                if (item is GroupBox)
                {
                    foreach (Control itemGroup in pnl.Controls)
                    {
                        if (itemGroup is TextBox)
                        {
                            if (itemGroup.Text == "")
                            {
                                MessageBox.Show("من فضلك أكمل البيانات الناقصة");
                                itemGroup.Focus();
                                return;
                            }

                        }

                        if (itemGroup is ComboBox)
                        {
                            if (itemGroup.Text == "")
                            {
                                MessageBox.Show("من فضلك أكمل البيانات الناقصة");
                                itemGroup.Focus();
                                return;
                            }

                        }
                    }
                }
            }
        }
    }
}
