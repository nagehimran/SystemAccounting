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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }
        private void BindCombo()
        {

            Retrive_Class.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Retrive_Class.con;
            cmd.CommandText = "select * from Jops";
            comboBox5.Items.Clear();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBox5.Items.Add(reader[2].ToString());
            }
            Retrive_Class.CloseConnection();
        }
        #region BindCombo4
        private void BindCombo4()
        {
            Retrive_Class.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Retrive_Class.con;
            cmd.CommandText = "select * from Nationality";
            comboBox2.Items.Clear();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader[1].ToString());
            }
            Retrive_Class.CloseConnection();
        }
        #endregion
        #region BindComboSearch
        private void BindComboSearch()
        {
            Retrive_Class.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Retrive_Class.con;
            cmd.CommandText = "select * from Employees";
            comboBox1.Items.Clear();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader[8].ToString());
            }
            Retrive_Class.CloseConnection();
        }
        #endregion
        #region Cleartxt
        private void Cleartxt()
        {
            //textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";


        }

        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            //Retrive_Class.OpenConnection();
            Retrive_Class.Employees.SearchData(comboBox1.Text);
          
            textBox2.Text = Retrive_Class.Employees.Emloy_ID;
            comboBox5.Text = Retrive_Class.Employees.Job;
            textBox8.Text = Retrive_Class.Employees.Employee_FullName;
            dateTimePicker2.Text = Retrive_Class.Employees.DateOfBirth;
            comboBox4.Text = Retrive_Class.Employees.Gender;
            textBox12.Text = Retrive_Class.Employees.Phone;
            textBox6.Text = Retrive_Class.Employees.First_Name;
            textBox5.Text = Retrive_Class.Employees.Second_Name;
            comboBox2.Text = Retrive_Class.Employees.Nationality;
            textBox9.Text = Retrive_Class.Employees.Mail;
            textBox10.Text = Retrive_Class.Employees.Blood_Kind;
            textBox13.Text = Retrive_Class.Employees.Notes;
            dateTimePicker1.Text = Retrive_Class.Employees.WDate;
            textBox4.Text = Retrive_Class.Employees.Nation_ID;
            textBox7.Text = Retrive_Class.Employees.PlaceOf_Birth;
            comboBox3.Text = Retrive_Class.Employees.Martial_Status;
            textBox11.Text = Retrive_Class.Employees.Mobile;
            textBox14.Text = Retrive_Class.Employees.User_Name;
            textBox3.Text = Retrive_Class.Employees.PassWord;
            Retrive_Class.CloseConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cleartxt();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            #region CheckData

            #endregion

            #region SaveData
            Retrive_Class.OpenConnection();
            Retrive_Class.Employees.SaveData(textBox2.Text, comboBox5.Text, textBox8.Text, dateTimePicker2.Value.Date,
                comboBox4.Text, textBox12.Text, dateTimePicker1.Value.Date, textBox6.Text, textBox5.Text, comboBox2.Text, textBox9.Text,
            textBox10.Text, textBox13.Text,textBox4.Text,textBox7.Text, comboBox3.Text, textBox11.Text, textBox14.Text, textBox3.Text);
            Retrive_Class.CloseConnection();
            Cleartxt();
            BindComboSearch();
            #endregion
        }

        private void button4_Click(object sender, EventArgs e)
        {
            #region CheckData

            #endregion

            #region UpdateData
            Retrive_Class.OpenConnection();
            Retrive_Class.Employees.updateData(comboBox1.Text,textBox2.Text, comboBox5.Text, textBox8.Text, dateTimePicker2.Value.Date,
                comboBox4.Text, textBox12.Text,dateTimePicker1.Value.Date, textBox5.Text,
           comboBox2.Text, textBox9.Text, textBox10.Text,textBox13.Text, textBox4.Text, textBox7.Text, comboBox3.Text, textBox11.Text, textBox14.Text, textBox3.Text);
            Retrive_Class.CloseConnection();
            Cleartxt();
            #endregion
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            BindComboSearch();
            BindCombo4();
           
            BindCombo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cleartxt();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
           Empolyees_Search s = new Empolyees_Search();
            s.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox8.Text = textBox3.Text + "" + textBox5.Text;
        }
    }
}
