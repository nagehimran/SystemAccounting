namespace SystemAccounting
{
    partial class DoctorsSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Co_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctors_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationID_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Work_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Blod_Kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBrith = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceOf_Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Second_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctors_Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Martial_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Co_ID,
            this.Doctors_ID,
            this.NationID_No,
            this.Work_Date,
            this.First_Name,
            this.Specialest,
            this.Nationality,
            this.Blod_Kind,
            this.DateOfBrith,
            this.PlaceOf_Birth,
            this.Second_Name,
            this.Mail,
            this.Mobile,
            this.Phone,
            this.Doctors_Full_Name,
            this.Martial_Status,
            this.Gender,
            this.Notes,
            this.user_name});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 78);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 50;
            this.dataGridView2.Size = new System.Drawing.Size(894, 358);
            this.dataGridView2.TabIndex = 16;
            // 
            // Co_ID
            // 
            this.Co_ID.HeaderText = "الرقم";
            this.Co_ID.Name = "Co_ID";
            // 
            // Doctors_ID
            // 
            this.Doctors_ID.DataPropertyName = "Doctors_ID";
            this.Doctors_ID.HeaderText = "الكود";
            this.Doctors_ID.Name = "Doctors_ID";
            // 
            // NationID_No
            // 
            this.NationID_No.DataPropertyName = "NationID_No";
            this.NationID_No.HeaderText = "رقم الهوية";
            this.NationID_No.Name = "NationID_No";
            // 
            // Work_Date
            // 
            this.Work_Date.DataPropertyName = "Work_Date";
            this.Work_Date.HeaderText = "تاريخ الالتحاق";
            this.Work_Date.Name = "Work_Date";
            // 
            // First_Name
            // 
            this.First_Name.DataPropertyName = "First_Name";
            this.First_Name.HeaderText = "الاسم بالكامل";
            this.First_Name.Name = "First_Name";
            // 
            // Specialest
            // 
            this.Specialest.DataPropertyName = "Specialest";
            this.Specialest.HeaderText = "المرحلة";
            this.Specialest.Name = "Specialest";
            // 
            // Nationality
            // 
            this.Nationality.DataPropertyName = "Nationality";
            this.Nationality.HeaderText = "الصف";
            this.Nationality.Name = "Nationality";
            // 
            // Blod_Kind
            // 
            this.Blod_Kind.DataPropertyName = "Blod_Kind";
            this.Blod_Kind.HeaderText = "الفصل";
            this.Blod_Kind.Name = "Blod_Kind";
            // 
            // DateOfBrith
            // 
            this.DateOfBrith.DataPropertyName = "DateOfBrith";
            this.DateOfBrith.HeaderText = "تاريخ الميلاد";
            this.DateOfBrith.Name = "DateOfBrith";
            this.DateOfBrith.Width = 120;
            // 
            // PlaceOf_Birth
            // 
            this.PlaceOf_Birth.DataPropertyName = "PlaceOf_Birth";
            this.PlaceOf_Birth.HeaderText = "مكان الميلاد";
            this.PlaceOf_Birth.Name = "PlaceOf_Birth";
            // 
            // Second_Name
            // 
            this.Second_Name.DataPropertyName = "Second_Name";
            this.Second_Name.HeaderText = "اسم ولى الامر";
            this.Second_Name.Name = "Second_Name";
            // 
            // Mail
            // 
            this.Mail.DataPropertyName = "Mail";
            this.Mail.HeaderText = "الايميل";
            this.Mail.Name = "Mail";
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "الجوال";
            this.Mobile.Name = "Mobile";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "التليفون";
            this.Phone.Name = "Phone";
            // 
            // Doctors_Full_Name
            // 
            this.Doctors_Full_Name.DataPropertyName = "Doctors_Full_Name";
            this.Doctors_Full_Name.HeaderText = "اسم احد الاقارب";
            this.Doctors_Full_Name.Name = "Doctors_Full_Name";
            this.Doctors_Full_Name.Width = 150;
            // 
            // Martial_Status
            // 
            this.Martial_Status.DataPropertyName = "Martial_Status";
            this.Martial_Status.HeaderText = "الجوال";
            this.Martial_Status.Name = "Martial_Status";
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "التليفون";
            this.Gender.Name = "Gender";
            // 
            // Notes
            // 
            this.Notes.DataPropertyName = "Notes";
            this.Notes.HeaderText = "الملاحظات";
            this.Notes.Name = "Notes";
            // 
            // user_name
            // 
            this.user_name.DataPropertyName = "user_name";
            this.user_name.HeaderText = "مسئول التسجيل";
            this.user_name.Name = "user_name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.comboBox4);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(195, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(504, 69);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "البحث";
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(142, 17);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(76, 44);
            this.button8.TabIndex = 9;
            this.button8.Text = "ابحث";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(6, 17);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 44);
            this.button7.TabIndex = 8;
            this.button7.Text = "عرض لكل الطلاب";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(224, 25);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(134, 24);
            this.comboBox4.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "اختر اسم الطالب";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(808, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 45);
            this.button1.TabIndex = 17;
            this.button1.Text = "العودة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(705, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 45);
            this.button2.TabIndex = 18;
            this.button2.Text = "حذف طالب";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DoctorsSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(894, 436);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Name = "DoctorsSearch";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "شاشة البحث عن الطلاب";
            this.Load += new System.EventHandler(this.DoctorsSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Co_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctors_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationID_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Work_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Blod_Kind;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBrith;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaceOf_Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Second_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctors_Full_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Martial_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
    }
}