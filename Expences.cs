using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using SystemAccounting;
using System.Configuration;
using SystemAccounting.bin.Debug;
namespace SystemAccounting
{
    public partial class Expences : Form
    {
        public Expences(string username)
        {
            InitializeComponent();
            textBox11.Text = username;
        }
        public static string connection = ConfigurationManager.
   ConnectionStrings["SystemAccounting.Properties.Settings.SystemAccountingCon"].ConnectionString;
        public static SqlConnection conn = new SqlConnection(connection);
        string str;
        SqlCommand com = new SqlCommand();
        int countt;
        DateTime t = new DateTime();
        DateTime c = new DateTime();
        private void BindCombo()
        {
            RetriveData.FillStage(comboBox10);
            RetriveData.FillStu(comboBox7);
        }
        void atugenerate()
        {
            SqlConnection con = new SqlConnection(connection);
            str = "select count([info_id]) from Cust_Account";
            com = new SqlCommand(str, con);
            con.Open();
            countt = Convert.ToInt16(com.ExecuteScalar()) + 100;
            textBox9.Text = countt.ToString();
            //textBox9.Enabled = false;
            con.Close();
        }
        #region CalcItemValue
        void CalcItemValue()
        {
            try
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                if (textBox6.Text == "")
                {
                    textBox6.Text = "0";
                }
                if (textBox2.Text == "")
                {
                    textBox2.Text = "0";
                }
                if (textBox7.Text == "")
                {
                    textBox7.Text = "0";
                }
                textBox8.Text = ((double.Parse(textBox7.Text) + double.Parse(textBox2.Text) + double.Parse(textBox1.Text) + double.Parse(textBox6.Text) + double.Parse(textBox12.Text)) - double.Parse(textBox4.Text)).ToString();
            }
            catch (Exception)
            {


            }
        }
        #endregion
        #region CalcRemain
        void CalcRemain()
        {
            try
            {
                if (textBox3.Text == "0")
                {
                    textBox3.Text = "0";
                }
                if (double.Parse(textBox3.Text) > double.Parse(textBox8.Text))
                {
                    return;
                }
                textBox5.Text = (double.Parse(textBox8.Text) -
                    double.Parse(textBox3.Text)).ToString();
            }
            catch (Exception)
            {
            }
        }
        #endregion
        private void Expences_Load(object sender, EventArgs e)
        {


            t = DateTime.Now;
            c = DateTime.Now;
            textBox10.Text = t.Date.ToLongDateString();

            //textBox3.Enabled = false;
            BindCombo();
        }



        private void comboBox10_SelectedValueChanged(object sender, EventArgs e)
        {

            if (comboBox10.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                comboBox9.DataSource = RetriveData.excutequary("Sp_rowselect"
                    , CommandType.StoredProcedure, new parameter
                    ("@stageID", SqlDbType.Int, int.Parse(comboBox10.SelectedValue.ToString()))
                    );
                comboBox9.DisplayMember = "row";
                comboBox9.ValueMember = "rowID";
                comboBox9.Text = "";

                if (comboBox10.SelectedValue.ToString() == "1")
                {
                    textBox12.Text = "8000";
                }
                if (comboBox10.SelectedValue.ToString() == "2")
                {
                    textBox12.Text = "10000";
                }
                if (comboBox10.SelectedValue.ToString() == "3")
                {
                    textBox12.Text = "14000";
                }
            }
        }

        private void comboBox9_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (comboBox9.SelectedValue.ToString() != "System.Data.DataRowView")
            //{
            //    comboBox8.DataSource = RetriveData.excutequary("Sp_Classselect"
            //          , CommandType.StoredProcedure, new parameter
            //          ("@stageID", SqlDbType.Int, int.Parse(comboBox10.SelectedValue.ToString())),
            //          new parameter("@rowID", SqlDbType.Int, int.Parse(comboBox9.SelectedValue.ToString())));
            //    comboBox8.DisplayMember = "class";
            //    comboBox8.ValueMember = "ID";
            //    comboBox8.Text = "";
            //}
        }

        private void comboBox8_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (comboBox8.SelectedValue.ToString() != "System.Data.DataRowView")
            //{
            //    DataTable dt = new DataTable();
            //    comboBox7.DataSource = RetriveData.excutequary("Sp_Stu1select"
            //          , CommandType.StoredProcedure, new parameter
            //          ("@stageID", SqlDbType.Int, int.Parse(comboBox10.SelectedValue.ToString())),
            //          new parameter("@rowID", SqlDbType.Int, int.Parse(comboBox9.SelectedValue.ToString())),
            //         new parameter("@ClassID", SqlDbType.Int, int.Parse(comboBox8.SelectedValue.ToString())));
            //    comboBox7.DisplayMember = "fullname";
            //    comboBox7.ValueMember = "ID";
            //    comboBox7.Text = "";

            //    //textBox1.Text =dt.Rows[0]["Byear1433"].ToString();
            //    //textBox6.Text = dt.Rows[0]["Byear1434"].ToString();
            //    //textBox2.Text = dt.Rows[0]["Byear1435"].ToString();
            //    //textBox7.Text = dt.Rows[0]["Nyear1436"].ToString();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string info_id = textBox9.Text;
            string Cust_Name = comboBox7.Text;
            string Date = textBox10.Text;
            string Byear1433 = textBox1.Text;
            string Byear1434 = textBox6.Text;
            string Byear1435 = textBox2.Text;
            string Nyear1436 = textBox7.Text;
            string Nyear1437 = textBox12.Text;
            string Total = textBox8.Text;
            string payed = textBox3.Text;
            string remaind = textBox5.Text;
            string opponent = textBox4.Text;
            string ID = comboBox7.SelectedValue.ToString();
            string UserName = textBox11.Text;
            if (double.Parse(Byear1433) > 0)
            {
                MessageBox.Show(" لابد من سداد الملبغ المتبقى من عام 1433 اولا ");
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                Byear1433 = (double.Parse(Byear1433) - double.Parse(payed)).ToString();
            }

            SqlConnection con = new SqlConnection(connection);

            string str = " insert into Cust_Account(Cust_ID,info_id,Cust_Name,Payed_Value,Remain_Value,Date_Payed,User_ID,Del_Flage)" +
                  "values(@Cust_ID,@info_id,@Cust_Name,@Payed_Value,@Remain_Value,@Date_Payed,@User_ID,0)";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = str;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Cust_ID", ID);
                    cmd.Parameters.AddWithValue("@info_id", info_id);
                    cmd.Parameters.AddWithValue("@Cust_Name", Cust_Name);
                    cmd.Parameters.AddWithValue("@Payed_Value", payed);
                    cmd.Parameters.AddWithValue("@Remain_Value", remaind);
                    cmd.Parameters.AddWithValue("@Date_Payed", Date);
                    cmd.Parameters.AddWithValue("@User_ID", UserName);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw ex;

                    }
                    //MessageBox.Show("تم الحفظ بنجاح");
                    //textBox3.Text = "";
                    //textBox4.Text = "";
                    //textBox5.Text = "";
                }
            }


            string sqlStatement = "update Stu1  set info_id=@info_id,Date=@Date,Byear1433=@Byear1433, Byear1434=@Byear1434,Byear1435=@Byear1435, Nyear1436=@Nyear1436,Total=@Total, payed=@payed, remaind=@remaind,opponent=@opponent where [ID]=@ID ";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = sqlStatement;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@info_id", info_id);
                    cmd.Parameters.AddWithValue("@Date", Date);
                    cmd.Parameters.AddWithValue("@Byear1433", Byear1433);
                    cmd.Parameters.AddWithValue("@Byear1434", Byear1434);
                    cmd.Parameters.AddWithValue("@Byear1435", Byear1435);
                    cmd.Parameters.AddWithValue("@Nyear1436", Nyear1436);
                    cmd.Parameters.AddWithValue("@Nyear1437", Nyear1437);
                    cmd.Parameters.AddWithValue("@Total", Total);
                    cmd.Parameters.AddWithValue("@payed", payed);
                    cmd.Parameters.AddWithValue("@remaind", remaind);
                    cmd.Parameters.AddWithValue("@opponent", opponent);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw ex;

                    }
                    MessageBox.Show("تم الحفظ بنجاح");
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {


            print1 pr = new print1(comboBox7.SelectedValue.ToString());
            pr.Text = "فاتورة استلام نقدية";
            pr.Show();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox7.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                DataTable dt = new DataTable();
                dt = RetriveData.excutequary("Sp_Stu1selectbyid"
                      , CommandType.StoredProcedure,

                     new parameter("@ID", SqlDbType.Int, int.Parse(comboBox7.SelectedValue.ToString())));
                //comboBox7.DisplayMember = "fullname";
                //comboBox7.ValueMember = "ID";
                //comboBox7.Text = "";
                atugenerate();
                textBox1.Text = dt.Rows[0]["Byear1433"].ToString();
                textBox6.Text = dt.Rows[0]["Byear1434"].ToString();
                textBox2.Text = dt.Rows[0]["Byear1435"].ToString();
                textBox7.Text = dt.Rows[0]["Nyear1436"].ToString();
                textBox12.Text = dt.Rows[0]["Nyear1437"].ToString();
                comboBox10.Text = dt.Rows[0]["stageID"].ToString();
                comboBox9.Text = dt.Rows[0]["rowID"].ToString();
                comboBox8.Text = dt.Rows[0]["ClassID"].ToString();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CalcRemain();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            if (textBox6.Text == "")
            {
                textBox6.Text = "0";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            if (textBox7.Text == "")
            {
                textBox7.Text = "0";
            }
            string Byear1433 = textBox1.Text;
            string Byear1434 = textBox6.Text;
            string Byear1435 = textBox2.Text;
            string Nyear1436 = textBox7.Text;
            string Nyear1437 = textBox12.Text;
            string payed = textBox3.Text;
            string remaind = textBox5.Text;
            string opponent = textBox4.Text;
            string ID = comboBox7.SelectedValue.ToString();
            if (double.Parse(Byear1433) > 0)
            {
                MessageBox.Show(" لابد من سداد الملبغ المتبقى من عام 1433 اولا ");
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;

            }
            if (double.Parse(Byear1433) == 0)
            {
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
            }
            CalcItemValue();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            if (textBox6.Text == "")
            {
                textBox6.Text = "0";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            if (textBox7.Text == "")
            {
                textBox7.Text = "0";
            }
            string Byear1433 = textBox1.Text;
            string Byear1434 = textBox6.Text;
            string Byear1435 = textBox2.Text;
            string Nyear1436 = textBox7.Text;
            string Nyear1437 = textBox12.Text;
            string payed = textBox3.Text;
            string remaind = textBox5.Text;
            string opponent = textBox4.Text;
            string ID = comboBox7.SelectedValue.ToString();

            if (double.Parse(Byear1434) > 0)
            {
                MessageBox.Show(" لابد من سداد الملبغ المتبقى من عام 1434 اولا ");
                //button1.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;

            }
            if (double.Parse(Byear1434) == 0)
            {

                button5.Enabled = true;
                button6.Enabled = true;
            }
            CalcItemValue();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            if (textBox6.Text == "")
            {
                textBox6.Text = "0";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            if (textBox7.Text == "")
            {
                textBox7.Text = "0";
            }
            if (textBox12.Text == "")
            {
                textBox12.Text = "0";
            }

            string Byear1433 = textBox1.Text;
            string Byear1434 = textBox6.Text;
            string Byear1435 = textBox2.Text;
            string Nyear1436 = textBox7.Text;
            string Nyear1437 = textBox12.Text;
            string payed = textBox3.Text;
            string remaind = textBox5.Text;
            string opponent = textBox4.Text;
            string ID = comboBox7.SelectedValue.ToString();
            if (double.Parse(Byear1435) > 0)
            {
                MessageBox.Show(" لابد من سداد الملبغ المتبقى من عام 1435 اولا ");
                //button4.Enabled = false;
                //button1.Enabled = false;
                button6.Enabled = false;

            }
            if (double.Parse(Byear1435) == 0)
            {
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
            }
            CalcItemValue();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            CalcItemValue();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string info_id = textBox9.Text;
            string Cust_Name = comboBox7.Text;
            string Date = textBox10.Text;
            string Byear1433 = textBox1.Text;
            string Byear1434 = textBox6.Text;
            string Byear1435 = textBox2.Text;
            string Nyear1436 = textBox7.Text;
            string Nyear1437 = textBox12.Text;
            string Total = textBox8.Text;
            string payed = textBox3.Text;
            string remaind = textBox5.Text;
            string opponent = textBox4.Text;
            string ID = comboBox7.SelectedValue.ToString();
            string UserName = textBox11.Text;
            //if (double.Parse(Byear1434) > 0)
            //{
            //    MessageBox.Show(" لابد من سداد الملبغ المتبقى من عام 1434 اولا ");
            //    button1.Enabled = false;
            //    button5.Enabled = false;
            //    button6.Enabled = false;
            //    Byear1434 = (double.Parse(Byear1434) - double.Parse(payed)).ToString();
            //}
            //if (double.Parse(payed) > double.Parse(Byear1433))
            //{
            //    Byear1434= (double.Parse(payed) - double.Parse(Byear1433)).ToString();
            //}
            //if (double.Parse(payed) <= double.Parse(Byear1433))
            //{
            //    Byear1433 = (double.Parse(payed) - double.Parse(Byear1433)).ToString();
            //}
            SqlConnection con = new SqlConnection(connection);
            string str = "IF NOT EXISTS(select * from Cust_Account where info_id=@info_id and Cust_Name=@Cust_Name)Begin" +
        " insert into Cust_Account(Cust_ID,info_id,Cust_Name,Payed_Value,Remain_Value,Date_Payed,User_ID,Del_Flage)" +
               "values(@Cust_ID,@info_id,@Cust_Name,@Payed_Value,@Remain_Value,@Date_Payed,@User_ID,0)";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = str;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Cust_ID", ID);
                    cmd.Parameters.AddWithValue("@info_id", info_id);
                    cmd.Parameters.AddWithValue("@Cust_Name", Cust_Name);
                    cmd.Parameters.AddWithValue("@Payed_Value", payed);
                    cmd.Parameters.AddWithValue("@Remain_Value", remaind);
                    cmd.Parameters.AddWithValue("@Date_Payed", Date);
                    cmd.Parameters.AddWithValue("@User_ID", UserName);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw ex;

                    }
                    //MessageBox.Show("تم الحفظ بنجاح");
                    //textBox3.Text = "";
                    //textBox4.Text = "";
                    //textBox5.Text = "";
                }
            }


            string sqlStatement = "update Stu1  set info_id=@info_id,Date=@Date,  Byear1433=@Byear1433, Byear1434=@Byear1434,Byear1435=@Byear1435, Nyear1436=@Nyear1436,Total=@Total, payed=@payed, remaind=@remaind,opponent=@opponent,UserName=@UserName where [ID]=@ID ";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = sqlStatement;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@info_id", info_id);
                    cmd.Parameters.AddWithValue("@Date", Date);
                    cmd.Parameters.AddWithValue("@Byear1433", Byear1433);
                    cmd.Parameters.AddWithValue("@Byear1434", Byear1434);
                    cmd.Parameters.AddWithValue("@Byear1435", Byear1435);
                    cmd.Parameters.AddWithValue("@Nyear1436", Nyear1436);
                    cmd.Parameters.AddWithValue("@Nyear1437", Nyear1437);
                    cmd.Parameters.AddWithValue("@Total", Total);
                    cmd.Parameters.AddWithValue("@payed", payed);
                    cmd.Parameters.AddWithValue("@remaind", remaind);
                    cmd.Parameters.AddWithValue("@opponent", opponent);
                    cmd.Parameters.AddWithValue("@UserName", UserName);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw ex;

                    }
                    MessageBox.Show("تم الحفظ بنجاح");
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            string info_id = textBox9.Text;
            string Cust_Name = comboBox7.Text;
            string Date = textBox10.Text;
            string Byear1433 = textBox1.Text;
            string Byear1434 = textBox6.Text;
            string Byear1435 = textBox2.Text;
            string Nyear1436 = textBox7.Text;
            string Nyear1437 = textBox12.Text;
            string Total = textBox8.Text;
            string payed = textBox3.Text;
            string remaind = textBox5.Text;
            string opponent = textBox4.Text;
            string ID = comboBox7.SelectedValue.ToString();
            string UserName = textBox11.Text;
            if (double.Parse(Byear1435) > 0)
            {
                MessageBox.Show(" لابد من سداد الملبغ المتبقى من عام 1435 اولا ");
                button1.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                Byear1435 = (double.Parse(Byear1435) - double.Parse(payed)).ToString();
            }
            //if (double.Parse(payed) > double.Parse(Byear1433))
            //{
            //    Byear1434= (double.Parse(payed) - double.Parse(Byear1433)).ToString();
            //}
            //if (double.Parse(payed) <= double.Parse(Byear1433))
            //{
            //    Byear1433 = (double.Parse(payed) - double.Parse(Byear1433)).ToString();
            //}
            SqlConnection con = new SqlConnection(connection);

            string str = "IF NOT EXISTS(select * from Cust_Account where info_id=@info_id and Cust_Name=@Cust_Name)Begin" +
         " insert into Cust_Account(Cust_ID,info_id,Cust_Name,Payed_Value,Remain_Value,Date_Payed,User_ID,Del_Flage)" +
                "values(@Cust_ID,@info_id,@Cust_Name,@Payed_Value,@Remain_Value,@Date_Payed,@User_ID,0)";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = str;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Cust_ID", ID);
                    cmd.Parameters.AddWithValue("@info_id", info_id);
                    cmd.Parameters.AddWithValue("@Cust_Name", Cust_Name);
                    cmd.Parameters.AddWithValue("@Payed_Value", payed);
                    cmd.Parameters.AddWithValue("@Remain_Value", remaind);
                    cmd.Parameters.AddWithValue("@Date_Payed", Date);
                    cmd.Parameters.AddWithValue("@User_ID", UserName);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw ex;

                    }
                    //MessageBox.Show("تم الحفظ بنجاح");
                    //textBox3.Text = "";
                    //textBox4.Text = "";
                    //textBox5.Text = "";
                }
            }

            string sqlStatement = "update Stu1  set info_id=@info_id,Date=@Date, Byear1433=@Byear1433, Byear1434=@Byear1434,Byear1435=@Byear1435, Nyear1436=@Nyear1436,Total=@Total, payed=@payed, remaind=@remaind,opponent=@opponent,UserName=@UserName where [ID]=@ID ";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = sqlStatement;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@info_id", info_id);
                    cmd.Parameters.AddWithValue("@Date", Date);
                    cmd.Parameters.AddWithValue("@Byear1433", Byear1433);
                    cmd.Parameters.AddWithValue("@Byear1434", Byear1434);
                    cmd.Parameters.AddWithValue("@Byear1435", Byear1435);
                    cmd.Parameters.AddWithValue("@Nyear1436", Nyear1436);
                    cmd.Parameters.AddWithValue("@Nyear1437", Nyear1437);
                    cmd.Parameters.AddWithValue("@Total", Total);
                    cmd.Parameters.AddWithValue("@payed", payed);
                    cmd.Parameters.AddWithValue("@remaind", remaind);
                    cmd.Parameters.AddWithValue("@opponent", opponent);
                    cmd.Parameters.AddWithValue("@UserName", UserName);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw ex;

                    }
                    MessageBox.Show("تم الحفظ بنجاح");
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string info_id = textBox9.Text;
            string Cust_Name = comboBox7.Text;
            string Date = textBox10.Text;
            string Byear1433 = textBox1.Text;
            string Byear1434 = textBox6.Text;
            string Byear1435 = textBox2.Text;
            string Nyear1436 = textBox7.Text;
            string Nyear1437 = textBox12.Text;
            string Total = textBox8.Text;
            string payed = textBox3.Text;
            string remaind = textBox5.Text;
            string opponent = textBox4.Text;
            string ID = comboBox7.SelectedValue.ToString();
            string UserName = textBox11.Text;
            if (double.Parse(Nyear1436) > 0)
            {
                //MessageBox.Show(" لابد من سداد الملبغ المتبقى من عام 1436 اولا ");
                button1.Enabled = false;
                button5.Enabled = false;
                button4.Enabled = false;
                Nyear1436 = (double.Parse(Nyear1436) - double.Parse(payed)).ToString();
            }

            SqlConnection con = new SqlConnection(connection);
            string str = "IF NOT EXISTS(select 1 from  Cust_Account where info_id=@info_id and Cust_Name=@Cust_Name)Begin" +
        " insert into Cust_Account(Cust_ID,info_id,Cust_Name,Payed_Value,Remain_Value,Date_Payed,User_ID,Del_Flage)" +
               "values(@Cust_ID,@info_id,@Cust_Name,@Payed_Value,@Remain_Value,@Date_Payed,@User_ID,0)end";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = str;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Cust_ID", ID);
                    cmd.Parameters.AddWithValue("@info_id", info_id);
                    cmd.Parameters.AddWithValue("@Cust_Name", Cust_Name);
                    cmd.Parameters.AddWithValue("@Payed_Value", payed);
                    cmd.Parameters.AddWithValue("@Remain_Value", remaind);
                    cmd.Parameters.AddWithValue("@Date_Payed", Date);
                    cmd.Parameters.AddWithValue("@User_ID", UserName);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw ex;

                    }
                    //MessageBox.Show("تم الحفظ بنجاح");
                    //textBox3.Text = "";
                    //textBox4.Text = "";
                    //textBox5.Text = "";
                }
            }
            string sqlStatement = "update Stu1  set info_id=@info_id,Date=@Date,  Byear1433=@Byear1433, Byear1434=@Byear1434,Byear1435=@Byear1435, Nyear1436=@Nyear1436,Total=@Total, payed=@payed, remaind=@remaind,opponent=@opponent,UserName=@UserName where [ID]=@ID ";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = sqlStatement;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@info_id", info_id);
                    cmd.Parameters.AddWithValue("@Date", Date);
                    cmd.Parameters.AddWithValue("@Byear1433", Byear1433);
                    cmd.Parameters.AddWithValue("@Byear1434", Byear1434);
                    cmd.Parameters.AddWithValue("@Byear1435", Byear1435);
                    cmd.Parameters.AddWithValue("@Nyear1436", Nyear1436);
                    cmd.Parameters.AddWithValue("@Nyear1437", Nyear1437);
                    cmd.Parameters.AddWithValue("@Total", Total);
                    cmd.Parameters.AddWithValue("@payed", payed);
                    cmd.Parameters.AddWithValue("@remaind", remaind);
                    cmd.Parameters.AddWithValue("@opponent", opponent);
                    cmd.Parameters.AddWithValue("@UserName", UserName);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw ex;

                    }
                    MessageBox.Show("تم الحفظ بنجاح");
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            print2 pr = new print2(comboBox7.SelectedValue.ToString());

            pr.Show();
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string info_id = textBox9.Text;
            string Cust_Name = comboBox7.Text;
            string Date = textBox10.Text;
            string Byear1433 = textBox1.Text;
            string Byear1434 = textBox6.Text;
            string Byear1435 = textBox2.Text;
            string Nyear1436 = textBox7.Text;
            string Nyear1437 = textBox12.Text;
            string Total = textBox8.Text;
            string payed = textBox3.Text;
            string remaind = textBox5.Text;
            string opponent = textBox4.Text;
            string ID = comboBox7.SelectedValue.ToString();
            string UserName = textBox11.Text;

            string sqlStatement = "update Stu1  set   Byear1433=@Byear1433, Byear1434=@Byear1434,Byear1435=@Byear1435, Nyear1436=@Nyear1436 where [ID]=@ID ";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = sqlStatement;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@info_id", info_id);
                    cmd.Parameters.AddWithValue("@Date", Date);
                    cmd.Parameters.AddWithValue("@Byear1433", Byear1433);
                    cmd.Parameters.AddWithValue("@Byear1434", Byear1434);
                    cmd.Parameters.AddWithValue("@Byear1435", Byear1435);
                    cmd.Parameters.AddWithValue("@Nyear1436", Nyear1436);
                    cmd.Parameters.AddWithValue("@Nyear1437", Nyear1437);
                    cmd.Parameters.AddWithValue("@Total", Total);
                    cmd.Parameters.AddWithValue("@payed", payed);
                    cmd.Parameters.AddWithValue("@remaind", remaind);
                    cmd.Parameters.AddWithValue("@opponent", opponent);
                    cmd.Parameters.AddWithValue("@UserName", UserName);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw ex;

                    }
                    MessageBox.Show("تم الحفظ بنجاح");
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            string info_id = textBox9.Text;
            string Cust_Name = comboBox7.Text;
            string Date = textBox10.Text;
            string Byear1433 = textBox1.Text;
            string Byear1434 = textBox6.Text;
            string Byear1435 = textBox2.Text;
            string Nyear1436 = textBox7.Text;
            string Nyear1437 = textBox12.Text;
            string Total = textBox8.Text;
            string payed = textBox3.Text;
            string remaind = textBox5.Text;
            string opponent = textBox4.Text;
            string ID = comboBox7.SelectedValue.ToString();
            string UserName = textBox11.Text;
            if (double.Parse(Nyear1436) > 0)
            {
                //MessageBox.Show(" لابد من سداد الملبغ المتبقى من عام 1436 اولا ");
                button1.Enabled = false;
                button5.Enabled = false;
                button4.Enabled = false;
                Nyear1436 = (double.Parse(Nyear1436) - double.Parse(payed)).ToString();
            }

            SqlConnection con = new SqlConnection(connection);
            string str = "IF NOT EXISTS(select 1 from  Cust_Account where info_id=@info_id and Cust_Name=@Cust_Name)Begin" +
        " insert into Cust_Account(Cust_ID,info_id,Cust_Name,Payed_Value,Remain_Value,Date_Payed,User_ID,Del_Flage)" +
               "values(@Cust_ID,@info_id,@Cust_Name,@Payed_Value,@Remain_Value,@Date_Payed,@User_ID,0)end";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = str;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Cust_ID", ID);
                    cmd.Parameters.AddWithValue("@info_id", info_id);
                    cmd.Parameters.AddWithValue("@Cust_Name", Cust_Name);
                    cmd.Parameters.AddWithValue("@Payed_Value", payed);
                    cmd.Parameters.AddWithValue("@Remain_Value", remaind);
                    cmd.Parameters.AddWithValue("@Date_Payed", Date);
                    cmd.Parameters.AddWithValue("@User_ID", UserName);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw ex;

                    }
                    //MessageBox.Show("تم الحفظ بنجاح");
                    //textBox3.Text = "";
                    //textBox4.Text = "";
                    //textBox5.Text = "";
                }
            }
            string sqlStatement = "update Stu1  set info_id=@info_id,Date=@Date,  Byear1433=@Byear1433, Byear1434=@Byear1434,Byear1435=@Byear1435, Nyear1436=@Nyear1436,Total=@Total, payed=@payed, remaind=@remaind,opponent=@opponent,UserName=@UserName where [ID]=@ID ";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = sqlStatement;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@info_id", info_id);
                    cmd.Parameters.AddWithValue("@Date", Date);
                    cmd.Parameters.AddWithValue("@Byear1433", Byear1433);
                    cmd.Parameters.AddWithValue("@Byear1434", Byear1434);
                    cmd.Parameters.AddWithValue("@Byear1435", Byear1435);
                    cmd.Parameters.AddWithValue("@Nyear1436", Nyear1436);
                    cmd.Parameters.AddWithValue("@Nyear1437", Nyear1437);
                    cmd.Parameters.AddWithValue("@Total", Total);
                    cmd.Parameters.AddWithValue("@payed", payed);
                    cmd.Parameters.AddWithValue("@remaind", remaind);
                    cmd.Parameters.AddWithValue("@opponent", opponent);
                    cmd.Parameters.AddWithValue("@UserName", UserName);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw ex;

                    }
                    MessageBox.Show("تم الحفظ بنجاح");
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
            }
        }


    }
}
