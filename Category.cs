using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SystemAccounting
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }
        #region BindGrid
        void BindGrid()
        {

            dataGridView1.DataSource = RetriveData.excutequary("Sp_Item_CategorySelectAll",
                CommandType.StoredProcedure);
        }
        #endregion
        bool _addnew = false;
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_9B0A2E_SafwaDataSet.Item_Category' table. You can move, or remove it, as needed.
           
            BindGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من حفظ فئة جديدة؟", "حفظ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region SureData
                if (textBox1.Text=="")
                {
                    MessageBox.Show("من فضلك أدخل اسم الفئة");
                    return;
                }
                 #endregion
                #region SaveData
                RetriveData.excutenonquary("Sp_Item_CategoryInsert",
                    new parameter("@Category_Name", SqlDbType.NVarChar, textBox1.Text),
                    new parameter("@User_ID", SqlDbType.Int, Login.UserID));
            
                MessageBox.Show("تم الحفظ");
                _addnew = false;
                BindGrid();
                #endregion


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region AddNew
            if (MessageBox.Show("هل انت متأكد من إضافة فئة جديدة", "تأكيد",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                textBox1.Text = "";
                _addnew = true;
                label2.Text = "0";
            }
            #endregion
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            if (label2.Text != "0")
            {
                if (MessageBox.Show("هل انت متأكد من تعديل الفئة", "تعديل",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    #region SureData
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("من فضلك أدخل اسم الفئة");
                        return;
                    }
                    #endregion
                    #region UpdateData
                    RetriveData.excutenonquary("Sp_Item_CategoryUpdate",
                        new parameter("@Category_ID", SqlDbType.Int, int.Parse(label2.Text)),
                        new parameter("@Category_Name", SqlDbType.NVarChar, textBox1.Text),
                        new parameter("@User_ID", SqlDbType.Int, Login.UserID));
                    _addnew = false;
                    MessageBox.Show("تم التعديل");
                    BindGrid();
                    #endregion
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label2.Text != "0")
            {
                if (MessageBox.Show("هل انت متأكد من حذف فئة ", "حذف",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RetriveData.excutenonquary("Sp_Item_CategoryDelete",
                        new parameter("@Category_ID", SqlDbType.Int, int.Parse(label2.Text)));
                        MessageBox.Show("تم الحذف");
                        label2.Text = "0";
                        textBox1.Text = "";
                        BindGrid();
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                label2.Text = row.Cells["Category_ID"].Value.ToString();
                textBox1.Text = row.Cells["Category_Name"].Value.ToString();
            }
        }

      

    }
}
