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
using System.Configuration;

namespace SystemAccounting
{
    public partial class Doctors : Form
    {
        public Doctors(string username)
        {
            InitializeComponent();
            textBox14.Text = username;
        }
              public static string connection = ConfigurationManager.
   ConnectionStrings["SystemAccounting.Properties.Settings.SystemAccountingCon"].ConnectionString;
        public static SqlConnection conn = new SqlConnection(connection);
        string str;
        int countt;
        SqlCommand com = new SqlCommand();
        void atugenerate()
        {
            SqlConnection con = new SqlConnection(connection);
            str = "select count(*) from Doctors";
            com = new SqlCommand(str, con);
            con.Open();
            countt = Convert.ToInt16(com.ExecuteScalar()) + 100;
            textBox2.Text = countt.ToString();
            textBox3.Enabled = false;
            con.Close();
        }
        private void BindCombo()
        {
            RetriveData.FillStage(comboBox5);

        }
        //#region BindCombo4
        //private void BindCombo4()
        //{
        //    Retrive_Class.OpenConnection();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = Retrive_Class.con;
        //    cmd.CommandText = "select * from Nationality";
        //    comboBox2.Items.Clear();
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        comboBox2.Items.Add(reader[1].ToString());
        //    }
        //    Retrive_Class.CloseConnection();
        //}
        //#endregion
      
        #region BindComboSearch
        private void BindComboSearch()
        {
            Retrive_Class.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Retrive_Class.con;
            cmd.CommandText = "select * from Doctors";
            comboBox1.Items.Clear();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader[9].ToString());
            }
            Retrive_Class.CloseConnection();
        }
        #endregion
        #region BindCombo1
        private void BindCombo1()
        {
            //Retrive_Class.OpenConnection();
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = Retrive_Class.con;
            //cmd.CommandText = "select * from Clinic";
            //comboBox5.Items.Clear();
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    comboBox5.Items.Add(reader[1].ToString());
            //}
            //Retrive_Class.CloseConnection();
        }
        #endregion
        #region Cleartxt
        private void Cleartxt()
        {
            //textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            comboBox3.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
            comboBox5.Text = "";


        }

        #endregion
        private void button2_Click(object sender, EventArgs e)
        {
            Cleartxt();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            #region CheckData
            if (textBox7.Text=="")
            {
                MessageBox.Show("من فضلك اكمل البيانات الناقصة");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("من فضلك اكمل البيانات الناقصة");
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("من فضلك اكمل البيانات الناقصة");
                return;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("من فضلك اكمل البيانات الناقصة");
                return;
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("من فضلك اكمل البيانات الناقصة");
                return;
            }
            if (textBox7.Text == "")
            {
                MessageBox.Show("من فضلك اكمل البيانات الناقصة");
                return;
            }
            #endregion
             string fullname = textBox6.Text;
            
            string stageID = comboBox5.SelectedValue.ToString();
            string rowID = comboBox2.SelectedValue.ToString();
            string ClassID = comboBox3.Text;
           

            SqlConnection con = new SqlConnection(connection);
            string str = "insert into Stu1(fullname,stageID,rowID,ClassID)" +
                  "values(@fullname,@stageID,@rowID,@ClassID)";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = str;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@fullname", fullname);
                    cmd.Parameters.AddWithValue("@stageID", stageID);
                    cmd.Parameters.AddWithValue("@rowID", rowID);
                    cmd.Parameters.AddWithValue("@ClassID", ClassID);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw ex;


                    }
                    conn.Close();
                    #region SaveData
                    Retrive_Class.OpenConnection();
                    Retrive_Class.Doctors.SaveData(textBox2.Text, comboBox5.Text, textBox8.Text, dateTimePicker2.Value.Date,
                        textBox3.Text, textBox12.Text, textBox13.Text, dateTimePicker1.Value.Date, textBox6.Text, textBox5.Text,
                   comboBox2.Text, textBox9.Text, comboBox3.Text, textBox4.Text, textBox7.Text, textBox1.Text, textBox11.Text, textBox14.Text);
                    Retrive_Class.CloseConnection();
                    Cleartxt();
                    #endregion
                }
            }
                }
        private void button1_Click(object sender, EventArgs e)
        {
            Retrive_Class.OpenConnection();
            Retrive_Class.Doctors.SearchData(comboBox1.Text);
           
            textBox2.Text = Retrive_Class.Doctors.Doctors_ID;
          dateTimePicker1.Text = Retrive_Class.Doctors.Work_Date;
            textBox4.Text = Retrive_Class.Doctors.NationID_No;
            comboBox5.Text = Retrive_Class.Doctors.Specialest;
            textBox6.Text = Retrive_Class.Doctors.First_Name;
            textBox5.Text = Retrive_Class.Doctors.Second_Name;
            textBox8.Text = Retrive_Class.Doctors.Doctors_FullName;
            comboBox2.Text = Retrive_Class.Doctors.Nationality;
            textBox7.Text = Retrive_Class.Doctors.PlaceOf_Birth;
            //dateTimePicker2.Text = Retrive_Class.Doctors.DateOfBirth;
            textBox9.Text = Retrive_Class.Doctors.Mail;
            textBox1.Text = Retrive_Class.Doctors.Martial_Status;
            textBox3.Text = Retrive_Class.Doctors.Gender;
            comboBox3.Text = Retrive_Class.Doctors.Blod_Kind;
            textBox11.Text = Retrive_Class.Doctors.Mobile;
            textBox12.Text = Retrive_Class.Doctors.Phone;
            textBox13.Text = Retrive_Class.Doctors.Notes;
            textBox14.Text = Retrive_Class.Doctors.user_na;
            Retrive_Class.CloseConnection();
        }

        private void Doctors_Load(object sender, EventArgs e)
        {
            BindComboSearch();
            //BindCombo4();
            BindCombo1();
            BindCombo();
            atugenerate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            #region CheckData
            if (textBox7.Text == "")
            {
                MessageBox.Show("من فضلك أكمل البيانات الناقصة");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("من فضلك أكمل البيانات الناقصة");
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("من فضلك أكمل البيانات الناقصة");
                return;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("من فضلك أكمل البيانات الناقصة");
                return;
            }
            #endregion
                string fullname = textBox6.Text;

                string stageID = comboBox5.SelectedValue.ToString();
                string rowID = comboBox2.SelectedValue.ToString();
                string ClassID = comboBox3.Text;


                SqlConnection con = new SqlConnection(connection);
                string str = "update Stu1 set  stageID=@stageID,rowID=@rowID,ClassID=@ClassID where fullname=@fullname";

                using (SqlConnection conn = new SqlConnection(connection))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = str;
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@fullname", fullname);
                        cmd.Parameters.AddWithValue("@stageID", stageID);
                        cmd.Parameters.AddWithValue("@rowID", rowID);
                        cmd.Parameters.AddWithValue("@ClassID", ClassID);

                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                        catch (SqlException ex)
                        {
                            throw ex;


                        }

                        conn.Close();
                    }
                }
                #region UpdateData
                Retrive_Class.OpenConnection();
                Retrive_Class.Doctors.updateData(comboBox1.Text, textBox2.Text, comboBox5.Text, textBox8.Text, dateTimePicker2.Value.Date,
                    textBox3.Text, textBox12.Text, textBox13.Text, dateTimePicker1.Value.Date, textBox5.Text,
               comboBox2.Text, textBox9.Text, comboBox3.Text, textBox4.Text, textBox7.Text, textBox1.Text, textBox11.Text, textBox14.Text);
                Retrive_Class.CloseConnection();
                Cleartxt();
                #endregion

            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Cleartxt();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           DoctorsSearch s = new DoctorsSearch();
            s.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
                    }

        private void comboBox5_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                comboBox2.DataSource = RetriveData.excutequary("Sp_rowselect"
                      , CommandType.StoredProcedure, new parameter
                      ("@stageID", SqlDbType.Int, int.Parse(comboBox5.SelectedValue.ToString()))
                      );
                comboBox2.DisplayMember = "row";
                comboBox2.ValueMember = "rowID";
                comboBox2.Text = "";
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                comboBox3.DataSource = RetriveData.excutequary("Sp_Classselect"
                      , CommandType.StoredProcedure, new parameter
                      ("@stageID", SqlDbType.Int, int.Parse(comboBox5.SelectedValue.ToString())),
                      new parameter("@rowID", SqlDbType.Int, int.Parse(comboBox2.SelectedValue.ToString())));
                comboBox3.DisplayMember = "class";
                comboBox3.ValueMember = "ID";
                comboBox3.Text = "";
            }
        }

       
    }
}
