namespace SystemAccounting
{
    partial class Message_Recieved
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_User_Sent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_User_Recieved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Co_Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_ID,
            this.Col_Date,
            this.Col_User_Sent,
            this.Col_User_Recieved,
            this.Col_Address,
            this.Co_Message,
            this.Col_Time});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(304, 411);
            this.dataGridView1.TabIndex = 11;
            // 
            // Col_ID
            // 
            this.Col_ID.HeaderText = "الرقم";
            this.Col_ID.Name = "Col_ID";
            this.Col_ID.ReadOnly = true;
            this.Col_ID.Visible = false;
            this.Col_ID.Width = 50;
            // 
            // Col_Date
            // 
            this.Col_Date.HeaderText = "التاريخ";
            this.Col_Date.Name = "Col_Date";
            this.Col_Date.ReadOnly = true;
            // 
            // Col_User_Sent
            // 
            this.Col_User_Sent.HeaderText = "اسم الراسل";
            this.Col_User_Sent.Name = "Col_User_Sent";
            this.Col_User_Sent.ReadOnly = true;
            this.Col_User_Sent.Width = 150;
            // 
            // Col_User_Recieved
            // 
            this.Col_User_Recieved.HeaderText = "اسم المرسل اليه";
            this.Col_User_Recieved.Name = "Col_User_Recieved";
            this.Col_User_Recieved.ReadOnly = true;
            this.Col_User_Recieved.Width = 150;
            // 
            // Col_Address
            // 
            this.Col_Address.HeaderText = "عنوان الرسالة";
            this.Col_Address.Name = "Col_Address";
            this.Col_Address.ReadOnly = true;
            this.Col_Address.Width = 150;
            // 
            // Co_Message
            // 
            this.Co_Message.HeaderText = "الرسالة ";
            this.Co_Message.Name = "Co_Message";
            this.Co_Message.ReadOnly = true;
            this.Co_Message.Width = 150;
            // 
            // Col_Time
            // 
            this.Col_Time.HeaderText = "وقت الارسال";
            this.Col_Time.Name = "Col_Time";
            this.Col_Time.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBox3.Location = new System.Drawing.Point(322, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(551, 234);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "نص الرسالة";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(19, 71);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox6.Size = new System.Drawing.Size(396, 145);
            this.textBox6.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "عنوان الرسالة";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(216, 43);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(199, 22);
            this.textBox5.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "اسم المستخدم";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(216, 15);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(199, 22);
            this.textBox3.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBox2.Location = new System.Drawing.Point(322, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 91);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(330, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 22);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "الرسائل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "اسم المستخدم";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(330, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 22);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(19, 30);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(199, 22);
            this.textBox4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "التاريخ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Location = new System.Drawing.Point(322, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 65);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تأكيد الدخول على نظام الرسائل";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(19, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "......";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "كلمة المرور";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(306, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المستخدم";
            // 
            // Message_Recieved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(898, 448);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Name = "Message_Recieved";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "شاشة استقبال الرسائل";
            this.Load += new System.EventHandler(this.Message_Recieved_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_User_Sent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_User_Recieved;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Co_Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Time;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
    }
}