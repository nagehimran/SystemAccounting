using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SystemAccounting
{
    public partial class Message_Recieved : Form
    {
        public Message_Recieved()
        {
            InitializeComponent();
        }
        #region BindComboSearch
        private void BindComboSearch()
        {
            Retrive_Class.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Retrive_Class.con;
            cmd.CommandText = "select * from Messages where User_Recieved='" + textBox4.Text +"'";
            comboBox1.Items.Clear();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader[5].ToString());
            }
            Retrive_Class.CloseConnection();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

            #region checkData
            if (textBox1.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المستخدم");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("من فضلك ادخل كلمة المرور");
                return;
            }
            #endregion
            #region CheckAdmin
            Retrive_Class.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Retrive_Class.con;
            cmd.CommandText = "select * from Administration where user_name=@user_name And PassWord=@PassWord";
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@user_name", textBox1.Text);
            p[1] = new SqlParameter("@PassWord", textBox2.Text);
            cmd.Parameters.AddRange(p);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                textBox4.Text = textBox1.Text;
                Retrive_Class.CloseConnection();
                return;
            }

            else
            {
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                Retrive_Class.CloseConnection();

            }

            #endregion
            #region CheckBranch
            Retrive_Class.OpenConnection();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = Retrive_Class.con;
            cmd1.CommandText = "select * from Branch_manager where user_name=@user_name And PassWord=@PassWord";
            SqlParameter[] p1 = new SqlParameter[2];
            p1[0] = new SqlParameter("@user_name", textBox1.Text);
            p1[1] = new SqlParameter("@PassWord", textBox2.Text);
            cmd1.Parameters.AddRange(p1);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            reader1.Read();
            if (reader1.HasRows)
            {
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                textBox4.Text = textBox1.Text;
                Retrive_Class.CloseConnection();
                return;

            }
            else
            {
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                Retrive_Class.CloseConnection();

            }
            #endregion
            #region CheckUsers
            Retrive_Class.OpenConnection();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = Retrive_Class.con;
            cmd2.CommandText = "select * from Users where User_Name=@User_Name And PassWord=@PassWord";
            SqlParameter[] p2 = new SqlParameter[2];
            p2[0] = new SqlParameter("@User_Name", textBox1.Text);
            p2[1] = new SqlParameter("@PassWord", textBox2.Text);
            cmd2.Parameters.AddRange(p2);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            reader2.Read();
            if (reader2.HasRows)
            {
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                textBox4.Text = textBox1.Text;
                Retrive_Class.CloseConnection();
                return;
            }
            else
            {
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                Retrive_Class.CloseConnection();

            }
            #endregion

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Retrive_Class.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Retrive_Class.con;
            cmd.CommandText = "select * from Messages where Date=@Date And User_Recieved=@User_Recieved";
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@Date", dateTimePicker1.Text);
            p[1] = new SqlParameter("@User_Recieved", textBox4.Text);
            cmd.Parameters.AddRange(p);
            comboBox1.Items.Clear();
            SqlDataReader reader = cmd.ExecuteReader(); 
          while (reader.Read())
            {
                comboBox1.Items.Add(reader[5].ToString());
            }
            Retrive_Class.CloseConnection();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Retrive_Class.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Retrive_Class.con;
            cmd.CommandText = "select * from Messages where Date=@Date And User_Recieved=@User_Recieved";
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@Date", dateTimePicker1.Text);
            p[1] = new SqlParameter("@User_Recieved", textBox4.Text);
            cmd.Parameters.AddRange(p);
            comboBox1.Items.Clear();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
                textBox3.Text = reader[2].ToString();
                textBox5.Text = reader[4].ToString();
                textBox6.Text = reader[5].ToString();
            }
            Retrive_Class.CloseConnection();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Message_Recieved_Load(object sender, EventArgs e)
        {

        }
    }
}
