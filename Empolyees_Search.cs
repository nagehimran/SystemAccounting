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
    public partial class Empolyees_Search : Form
    {
        public Empolyees_Search()
        {
            InitializeComponent();
        }
        #region BindComboSearch
        private void BindComboSearch()
        {
            Retrive_Class.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Retrive_Class.con;
            cmd.CommandText = "select * from Employees";
            comboBox4.Items.Clear();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBox4.Items.Add(reader[8].ToString());
            }
            Retrive_Class.CloseConnection();
        }
        #endregion

        private void button8_Click(object sender, EventArgs e)
        {
            #region Search
            Retrive_Class.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Retrive_Class.con;
            cmd.CommandText = "select * from Employees where First_Name='" + comboBox4.Text + "'";
            dataGridView2.Rows.Clear();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                dataGridView2.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7],
                    reader[8], reader[9], reader[10], reader[11], reader[12], reader[13], reader[14], reader[15], reader[16],
                    reader[17], reader[18], reader[19]);

            }
            else
            {
                Error err = new Error();
                err.Show();

            }
            Retrive_Class.CloseConnection();
            #endregion
        }

        private void Empolyees_Search_Load(object sender, EventArgs e)
        {
            BindComboSearch();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            #region Search
            Retrive_Class.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Retrive_Class.con;
            cmd.CommandText = "select * from Employees";
            dataGridView2.Rows.Clear();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dataGridView2.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7],
                    reader[8], reader[9], reader[10], reader[11], reader[12], reader[13], reader[14], reader[15], reader[16],
                    reader[17], reader[18], reader[19]);

            }
           
            Retrive_Class.CloseConnection();
            #endregion

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Retrive_Class.OpenConnection();
            Retrive_Class.Employees.DeleteData(comboBox4.Text);
            dataGridView2.Rows.Clear();
            Retrive_Class.CloseConnection();
        }
    }
}
