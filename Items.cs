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
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }
        #region BindGrid
        void BindGrid()
        {

            dataGridView1.DataSource = RetriveData.excutequary("Sp_ItemsSelectAll",
                CommandType.StoredProcedure);
        }
        #endregion
        bool _addnew = false;
        void BindData()
        {
            comboBox1.DataSource = RetriveData.excutequary("Sp_Item_CategorySelectAll",
                CommandType.StoredProcedure);
            comboBox1.DisplayMember = "Category_Name";
            comboBox1.ValueMember = "Category_ID";
            comboBox1.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            #region AddNew
            if (MessageBox.Show("هل انت متأكد من إضافة فئة جديدة", "تأكيد",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                textBox1.Text = "";
                _addnew = true;
                label4.Text = "0";
            }
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من حفظ فئة جديدة؟", "حفظ",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region SureData
                if (textBox1.Text == "")
                {
                    MessageBox.Show("من فضلك أدخل اسم الصنف");
                    return;
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("من فضلك أدخل الحد الأدنى للصنف");
                    return;
                }
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("من فضلك  اختر فئة الصنف");
                    return;
                }
                #endregion
                #region SaveData
                RetriveData.excutenonquary("Sp_ItemsInsert1",
                    new parameter("@Item_Name",SqlDbType.NVarChar,textBox1.Text),
                    new parameter("@Category_ID", SqlDbType.Int, int.Parse(comboBox1.SelectedValue.ToString())),
                    new parameter("@Item_Minimum",SqlDbType.Int,int.Parse(textBox2.Text)),
                    new parameter("@User_ID", SqlDbType.Int, Login.UserID));
                _addnew = false;
                MessageBox.Show("تم الحفظ");
                BindGrid();
                #endregion


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            BindGrid();
            BindData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            #region UpdateData
            if (label4.Text != "0")
            {
                if (MessageBox.Show("هل أنت متأكد من التعديل؟", "تعديل",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RetriveData.excutenonquary("Sp_ItemsUpdate",
                        new parameter("@Item_ID", SqlDbType.Int, int.Parse(label4.Text)),
                        new parameter("@Item_Name", SqlDbType.NVarChar, textBox1.Text),
                        new parameter("@Category_ID", SqlDbType.Int, int.Parse(comboBox1.SelectedValue.ToString())),
                        new parameter("@Item_Minimum", SqlDbType.Int, int.Parse(textBox2.Text)),
                        new parameter("@User_ID", SqlDbType.Int, Login.UserID));
                    _addnew = false;
                    MessageBox.Show("تم التعديل");
                    label4.Text = "0";
                    BindGrid();

                }
            #endregion
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label4.Text != "0")
            {
                if (MessageBox.Show("هل انت متأكد من حذف بيانات الصنف ", "حذف",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RetriveData.excutenonquary("Sp_ItemsDelete",
                        new parameter("@Item_ID", SqlDbType.Int, int.Parse(label4.Text)));
                    _addnew = false;
                    MessageBox.Show("تم الحذف");
                    label4.Text = "0";

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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                label4.Text = row.Cells["Item_ID"].Value.ToString();
                textBox1.Text = row.Cells["Item_Name"].Value.ToString();
                comboBox1.Text = row.Cells["Category_Name"].Value.ToString();
                textBox2.Text = row.Cells["Item_Minimum"].Value.ToString();
            }
        }
    }
}
