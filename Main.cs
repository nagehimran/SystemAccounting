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
using SystemAccounting.Reports;
namespace SystemAccounting
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        #region CheckStatu
        private void CheckStatu()
        {
            Retrive_Class.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Retrive_Class.con;
            cmd.CommandText = "Select * from permissions where User_Nmae='"+ textBox1.Text +"'";
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                Tickets2.Checked = reader.GetBoolean(1);
                Main_Data2.Checked = reader.GetBoolean(2);
                Employees_Main2.Checked = reader.GetBoolean(3);
                Hospital_Store2.Checked = reader.GetBoolean(4);
                Departments2.Checked = reader.GetBoolean(5);
                Messaging2.Checked = reader.GetBoolean(6);
                Pharmcy2.Checked = reader.GetBoolean(7);
                Reports2.Checked = reader.GetBoolean(8);
                Managment_Admin2.Checked = reader.GetBoolean(9);

            }
            else
            {
                MessageBox.Show("عفوا هذا المستخدم ليس له اى صلاحيات");
                menuStrip1.Enabled = false;
            }
            Retrive_Class.CloseConnection();
        }
        #endregion
        #region CheckPermission
        private void CheckPermission()
        {
            if (Tickets2.Checked==true)
            {
                //تذاكرالمرضىToolStripMenuItem.Enabled = true;
            }
            else
            {
                //تذاكرالمرضىToolStripMenuItem.Enabled =false;   
            }
            /////////////////////////////////////////////////
            if (Main_Data2.Checked==true)
            {
                البياناتالأساسيةToolStripMenuItem.Enabled = true;
            }
            else
            {
                البياناتالأساسيةToolStripMenuItem.Enabled = false;
            }
            /////////////////////////////////////////////////////////
            if (Employees_Main2.Checked==true)
            {
                شئونالعاملينToolStripMenuItem.Enabled = true;
            }
            else
            {
                شئونالعاملينToolStripMenuItem.Enabled = false;
            }
            ////////////////////////////////////////////////////////
            if (Hospital_Store2.Checked==true)
            {
                المخازنToolStripMenuItem.Enabled = true;
            }
            else
            {
                المخازنToolStripMenuItem.Enabled = false;
            }
            ///////////////////////////////////////////////////////
            if (Departments2.Checked==true)
            {
                //الأقسامToolStripMenuItem.Enabled = true;
            }
            else
            {
                //الأقسامToolStripMenuItem.Enabled = false;
            }
            //////////////////////////////////////////////////////
            if (Messaging2.Checked==true)
            {
                //رسائلالنظامToolStripMenuItem.Enabled = true;
            }
            else
            {
                //رسائلالنظامToolStripMenuItem.Enabled = false;
            }
            /////////////////////////////////////////////////////
            if (Pharmcy2.Checked==true)
            {
                //الصيدليةToolStripMenuItem.Enabled = true;
            }
            else
            {
                //الصيدليةToolStripMenuItem.Enabled = false;
            }
            ////////////////////////////////////////////////////
            if (Reports2.Checked==true)
            {
                التقاريرToolStripMenuItem.Enabled = true;
            }
            else
            {
                التقاريرToolStripMenuItem.Enabled = false;
            }
            ////////////////////////////////////////////////////
            if (Managment_Admin2.Checked==true)
            {
                إدارةالنظامToolStripMenuItem.Enabled = true;
            }
            else
            {
                إدارةالنظامToolStripMenuItem.Enabled = false;
            }
        }
        #endregion
        #region BindCombo
        private void BindCombo()
        {
            Retrive_Class.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Retrive_Class.con;
            cmd.CommandText = "select * from Permissions";
            comboBox1.Items.Clear();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["User_Nmae"].ToString());
            }
            Retrive_Class.CloseConnection();
        }
        #endregion
       
        
        public  Label tbtext
        {
            get
            {
                return label12;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            label12.Text = textBox1.Text;
            #region CheckData
            if (textBox1.Text=="")
            {
                MessageBox.Show("أدخل البيانات الناقصة ");
                textBox1.Select();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("أدخل البيانات الناقصة ");
                textBox2.Select();
                return;
            }
            #endregion
            #region CheckUser
            Retrive_Class.OpenConnection();
            Retrive_Class.Login.LoginAsAdmin(textBox1.Text, textBox2.Text);
            menuStrip1.Enabled= true;
            groupBox1.Visible = false;
            Retrive_Class.CloseConnection();
            #endregion
        }

       

       

        private void المرضىToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category pat = new Category();
            pat.MdiParent = this;
            pat.Show();

        }

        private void الجنسياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Items Nat = new Items ();
            Nat.MdiParent = this;
            Nat.Show();
        }

       

        
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (Managment_Admin2.Checked == true)
            {
                button1.Visible = true;
                button12.Visible = false;
                button13.Visible = false;
            }
            if (Managment_Admin2.Checked == false)
            {
                button1.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (Departments2.Checked == false)
            {
                button12.Visible = false;
            }
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            if (Departments2.Checked == true)
            {
                button12.Visible = true;
                button1.Visible = false;
                button13.Visible = false;
            }
            if (Departments2.Checked == false)
            {
                button12.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (Employees_Main2.Checked == false)
            {
                button13.Visible = false;
            }
        }

        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            if (Employees_Main2.Checked == true)
            {
                button13.Visible = true;
                button1.Visible = false;
                button12.Visible = false;
            }
            if (Employees_Main2.Checked == false)
            {
                button13.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            #region GridAdmin
            Retrive_Class.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Retrive_Class.con;
            cmd.CommandText = "select * from Administration";
            dataGridView1.Rows.Clear();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[1].ToString());
            }
            Retrive_Class.CloseConnection();

            #endregion
            #region GridBranch
            Retrive_Class.OpenConnection();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = Retrive_Class.con;
            cmd1.CommandText = "select * from Branch_manager";
            dataGridView2.Rows.Clear();
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                dataGridView2.Rows.Add(reader1[1].ToString());
            }
            Retrive_Class.CloseConnection();
            #endregion
            #region User
            Retrive_Class.OpenConnection();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = Retrive_Class.con;
            cmd2.CommandText = "select * from Users";
            dataGridView3.Rows.Clear();
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                dataGridView3.Rows.Add(reader2[1].ToString());
            }
            Retrive_Class.CloseConnection();
            #endregion
            BindCombo();
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
            CheckStatu();
            CheckPermission();
            #region CheckData
            if (textBox1.Text == "")
            {
                MessageBox.Show("أدخل البيانات الناقصة ");
                textBox1.Select();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("أدخل البيانات الناقصة ");
                textBox2.Select();
                return;
            }
            #endregion
            #region CheckStat
            Retrive_Class.OpenConnection();
            Retrive_Class.Login.LoginAsBranch_manager(textBox1.Text, textBox2.Text);
            menuStrip1.Enabled = true;
            groupBox1.Visible = false;
            Retrive_Class.CloseConnection();
            #endregion
            label12.Text = textBox1.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
            CheckStatu();
            CheckPermission();
            #region CheckData
            if (textBox1.Text == "")
            {
                MessageBox.Show("أدخل البيانات الناقصة ");
                textBox1.Select();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("أدخل البيانات الناقصة ");
                textBox2.Select();
                return;
            }
            #endregion
            #region CheckStat
            Retrive_Class.OpenConnection();
            Retrive_Class.Login.LoginAsEmp(textBox1.Text, textBox2.Text);
            menuStrip1.Enabled = true;
            groupBox1.Visible = false;
            Retrive_Class.CloseConnection();
            #endregion
            label12.Text = textBox1.Text;
        }

     

        private void تسجيلصنفبالمخزنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Store_Items sto = new Store_Items();
            sto.MdiParent = this;
            sto.Show();
        }

     

       

      
        private void button3_Click(object sender, EventArgs e)
        {
            #region LoginAdmin
            Retrive_Class.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Retrive_Class.con;
            cmd.CommandText = "select * from Administration where user_name ='" + textBox3.Text + "' And PassWord='" + textBox4.Text + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                groupBox6.Visible = true;
                Retrive_Class.CloseConnection();
            }
            else
            {
                Error er = new Error();
                er.Show();
                Retrive_Class.CloseConnection();
            }
            #endregion
        }

        private void button7_Click(object sender, EventArgs e)
        {
            #region LoginAsBranchManager
            Retrive_Class.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Retrive_Class.con;
            cmd.CommandText = "select * from Branch_Manager where user_name ='" + textBox10.Text + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                groupBox7.Visible = true;
                groupBox8.Visible = true;
                label10.Text = textBox10.Text;
                Retrive_Class.CloseConnection();
                return;
            }
            else
            {
               
                Retrive_Class.CloseConnection();
            }
            #endregion
            #region LoginAsUser
            Retrive_Class.OpenConnection();
            SqlCommand cmd1= new SqlCommand();
            cmd1.Connection = Retrive_Class.con;
            cmd1.CommandText = "select * from Users where User_Name ='" + textBox10.Text + "'";
            SqlDataReader reader1 = cmd1.ExecuteReader();
            reader1.Read();
            if (reader1.HasRows)
            {
                groupBox7.Visible = true;
                groupBox8.Visible = true;
                label10.Text = textBox10.Text;

                Retrive_Class.CloseConnection();
                return;
            }
            else
            {
                Error er = new Error();
                er.Show();
                Retrive_Class.CloseConnection();
            }
            #endregion


        }

        private void button11_Click(object sender, EventArgs e)
        {
            #region GivePre
            Retrive_Class.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Retrive_Class.con;
            cmd.CommandText = "insert into Permissions (Tickets,Main_Data,Employees_Main,Hospital_Store,Departments,Messaging,"+
           " Pharmcy,Reports,Managment_Admin,User_Nmae) values('" + Tickets.Checked + "','" + Main_Data.Checked + "','" + Employees_Main.Checked + "'," +
            "'" + Hospital_Store.Checked + "','" + Departments.Checked + "','" + Messaging.Checked + "','" + Pharmcy.Checked + "'"+
            ",'" + Reports.Checked + "','" + Managment_Admin.Checked + "','" + textBox10.Text + "')";
            int aff = cmd.ExecuteNonQuery();
            Retrive_Class.CloseConnection();
            Operation_Success s = new Operation_Success();
            s.Show();
            BindCombo();
            #endregion
        }

        private void button8_Click(object sender, EventArgs e)
        {
            #region SearchPer
            Retrive_Class.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Retrive_Class.con;
            cmd.CommandText = "select * from Permissions where User_Nmae = '" + comboBox1.Text + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                Tickets.Checked = reader.GetBoolean(1);
                Main_Data.Checked = reader.GetBoolean(2);
                Employees_Main.Checked = reader.GetBoolean(3);
                Hospital_Store.Checked = reader.GetBoolean(4);
                Departments.Checked = reader.GetBoolean(5);
                Messaging.Checked = reader.GetBoolean(6);
                Pharmcy.Checked = reader.GetBoolean(7);
                Reports.Checked = reader.GetBoolean(8);
                Managment_Admin.Checked = reader.GetBoolean(9);

            }
            else
            {
                MessageBox.Show("عفوا هذا المستخدم ليس له اى صلاحيات");
            }
            Retrive_Class.CloseConnection();
            #endregion
        }

        private void button9_Click(object sender, EventArgs e)
        {
            #region EditPer
            Retrive_Class.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Retrive_Class.con;
            cmd.CommandText = "Update Permissions set Tickets='" + Tickets.Checked + "',Main_Data='" + Main_Data.Checked + "'," +
                "Pharmcy='" + Pharmcy.Checked + "',Reports='" + Reports.Checked + "',Hospital_Store='" + Hospital_Store.Checked + "'," +
                "Departments='" + Departments.Checked + "',Messaging='" + Messaging.Checked + "',Managment_Admin='" + Managment_Admin.Checked + "' where User_Nmae='" + comboBox1.Text + "'";
            int aff = cmd.ExecuteNonQuery();
            Retrive_Class.CloseConnection();
            Operation_Success s = new Operation_Success();
            s.Show();
            #endregion
        }

        private void button10_Click(object sender, EventArgs e)
        {
            #region DeletePre
            Retrive_Class.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Retrive_Class.con;
            cmd.CommandText = "Delete from Permissions where User_Nmae='" + comboBox1.Text + "'";
            int aff = cmd.ExecuteNonQuery();
            Operation_Success s = new Operation_Success();
            s.Show();
            Retrive_Class.CloseConnection();
            BindCombo();
            #endregion
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Retrive_Class.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Retrive_Class.con;
            cmd.CommandText = "insert into Branch_manager (user_name,PassWord) values('" + textBox5.Text + "','" + textBox6.Text + "')";
            int aff = cmd.ExecuteNonQuery();
            Operation_Success s = new Operation_Success();
            s.Show();
            Retrive_Class.CloseConnection();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           groupBox2.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Retrive_Class.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Retrive_Class.con;
            cmd.CommandText = "insert into Users (User_Name,PassWord) values('" + textBox8.Text + "','" + textBox7.Text + "')";
            int aff = cmd.ExecuteNonQuery();
            Operation_Success s = new Operation_Success();
            s.Show();
            Retrive_Class.CloseConnection();
        }

        private void إدارةالنظامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void تقاريرالتذاكرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TicketsReport report = new TicketsReport();
            //report.MdiParent = this;
            //report.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            dataGridView3.Visible = true;
        }

        private void الممرضاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Window.Nurses nu = new Window.Nurses();
            //nu.MdiParent = this;
            //nu.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void البياناتالأساسيةToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void الأصنافالمسجلةبالمخزنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Store_Item sto = new Store_Item();
            sto.MdiParent = this;
            sto.Show();
        }

        private void عمليةايداعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edaa ed = new Edaa(label12.Text);
            ed.MdiParent = this;
            ed.Show();
        }

        private void عمليةصرفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sarf rp = new Sarf(label12.Text);
            rp.MdiParent = this;
            rp.Show();
        }

        private void مصروفاتالتلاميذToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expences ep = new Expences(label12.Text);
            ep.MdiParent = this;
            ep.Show();
        }

        private void عمليةشراءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase fr = new Purchase();
            fr.MdiParent = this;
            fr.Show();
        }

        private void التقاريرToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void شئونالعاملينToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void العياداتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees em = new Employees();
            em.MdiParent = this;
            em.Show();
        }

        private void الاطباءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctors em = new Doctors(label12.Text);
            em.MdiParent=this;
            em.Show();
        }

        private void ارسالرسالةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Message_Sent ms = new Message_Sent();
            ms.MdiParent = this;
            ms.Show();
        }

        private void استقبالرسالةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Message_Recieved re = new Message_Recieved();
            re.MdiParent = this;
            re.Show();
        }

        private void تسجيلالوظائفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jobs jo = new Jobs();
            jo.MdiParent = this;
            jo.Show();
        }

        private void تسجيلالجنسياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nationality na = new Nationality();
            na.MdiParent = this;
            na.Show();
        }

        private void تقاريرالرسومالدراسيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 rp = new Form1();
            rp.MdiParent = this;
            rp.Show();
        }

        private void الموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher ta = new Teacher();
            ta.MdiParent = this;
            ta.Show();
        }

        private void تقريرعملياتالصرفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 rp = new Form3();
            rp.MdiParent = this;
            rp.Show();
        }

        private void تقريريومياوشهرياوسنوىToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 rp = new Form4();
            rp.MdiParent = this;
            rp.Show();
        }

        private void الخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form6 rp = new Form6();
            rp.MdiParent = this;
            rp.Show();
        }
    }
}
