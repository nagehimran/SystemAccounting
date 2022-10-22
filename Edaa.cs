using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;
namespace SystemAccounting
{
    public partial class Edaa : Form
    {
        public Edaa(string username)
        {
            InitializeComponent();
            textBox2.Text = username;
        }
        bool _addnew = false;
        string newFileName = "";
        string newpathname = "";
        string exsistfilename = "";
        string exsitpathname = "";
        DateTime t = new DateTime();
        DateTime c = new DateTime();
        string strConnString = "Data Source=SQL5009.Smarterasp.net;Initial Catalog=DB_9B0A2E_Safwa;Persist Security Info=True;User ID=DB_9B0A2E_Safwa_admin;Password=123asd!@#;Pooling=False";
        string str;
        SqlCommand com;
        int countt;
        void bindcombo()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection(strConnString);
            cmd.Connection = con;
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sp_ContractorsMange";
            cmd.Parameters.Add("@Mange", SqlDbType.NVarChar).Value = "select";
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            //comboBox3.DataSource = dt;
            //comboBox3.DisplayMember = "ConName";
            //comboBox3.ValueMember = "ConractID";
            //comboBox3.Text = "";
            dr.Close();
        }
        void atugenerate()
        {
            SqlConnection con = new SqlConnection(strConnString);
            str = "select count(*) from edaa";
            com = new SqlCommand(str, con);
            con.Open();
            countt = Convert.ToInt16(com.ExecuteScalar()) + 100;
            textBox3.Text = countt.ToString();
            textBox3.Enabled = false;
            con.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("هل قمت باضافة صورة الفاتورة من فضلك تاكد من مطابقة المبلغ للمبلغ الموجود فى الفاتورة" ,"تأكيد",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
           {
               print1 pr = new print1(textBox3.Text);
               pr.Show();
           }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            t = DateTime.Now;
            c = DateTime.Now;
            textBox4.Text = t.Date.ToLongDateString();
            atugenerate();
            textBox4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string x = openFileDialog1.FileName;
            FileStream Fill = new FileStream(x, FileMode.Open);
            BinaryReader re = new BinaryReader(Fill);
            Byte[] bt = re.ReadBytes((int)Fill.Length);
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection(strConnString);
            cmd.Connection = con;
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sp_edaa";
            cmd.Parameters.Add("@Mange", SqlDbType.NVarChar).Value = "insert";
            cmd.Parameters.Add("@OPID", SqlDbType.Int).Value = textBox3.Text;
            cmd.Parameters.Add("@OPDate", SqlDbType.Date).Value = textBox4.Text;
            cmd.Parameters.Add("@OpType", SqlDbType.NVarChar).Value = comboBox1.Text;
            cmd.Parameters.Add("@OpName", SqlDbType.NVarChar).Value = textBox5.Text;
            cmd.Parameters.Add("@Payed", SqlDbType.Decimal).Value = textBox1.Text;
            cmd.Parameters.Add("@PName", SqlDbType.NVarChar).Value = textBox2.Text;
            cmd.Parameters.Add("@PImage", SqlDbType.Image).Value = bt;
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("تم الحفظ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.FileName.Length != 0)
                {
                    openFileDialog1.ShowDialog();
                    pictureBox1.ImageLocation = openFileDialog1.FileName;
                }


            }
            catch (System.ArgumentException ae)
            {
                //imagename ="";
                MessageBox.Show(ae.Message.ToString());
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.FileName.Length != 0)
                {
                    openFileDialog1.ShowDialog();
                    pictureBox1.ImageLocation = openFileDialog1.FileName;
                }


            }
            catch (System.ArgumentException ae)
            {
                //imagename ="";
                MessageBox.Show(ae.Message.ToString());
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlConnection con = new SqlConnection(strConnString);
                cmd.Connection = con;
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Sp_ContractorsMange";
                cmd.Parameters.AddWithValue("@Mange", "selectbyid");
                //cmd.Parameters.AddWithValue("ConractID", int.Parse(comboBox3.SelectedValue.ToString()));
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SequentialAccess);
                dr.Read();
                exsistfilename = dr.GetString(1);
                System.Data.SqlTypes.SqlBytes Docc = dr.GetSqlBytes(2);
                byte[] Doc = Docc.Value;
                DirectoryInfo di = new DirectoryInfo(Path.GetTempPath() + "\\Test");
                dr.Close();
                if (di.Exists == false)
                {
                    di.Create();
                }
                FileStream fs = new FileStream(di + "\\" + exsistfilename, FileMode.Create, FileAccess.Write);
                fs.Write(Doc, 0, Doc.Length);
                fs.Seek(0, SeekOrigin.Begin);
                fs.Close();
                ProcessStartInfo psi = new ProcessStartInfo(di + "\\" + exsistfilename);
                Process.Start(psi);
                exsitpathname = di + "\\" + exsistfilename;
            }
            catch (System.ArgumentException ae)
            {
                //imagename ="";
                MessageBox.Show(ae.Message.ToString());
            }

        }
    }
}
