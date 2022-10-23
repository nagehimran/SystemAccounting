namespace SystemAccounting
{
    partial class Empolyees_Search
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Co_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Clinic_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Specialest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Doctors_Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Work_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Second_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Nation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Blood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Nation_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Place_Of_Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Matial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 403);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "حذف";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 403);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "العودة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.Col_Clinic_Name,
            this.Col_Specialest,
            this.Col_Doctors_Full_Name,
            this.Col_DateOfBirth,
            this.Col_Gender,
            this.Col_Phone,
            this.Col_Notes,
            this.Col_Work_Date,
            this.Col_First_Name,
            this.Col_Second_Name,
            this.Col_Nation,
            this.Col_Mail,
            this.Col_Blood,
            this.Col_Nation_ID,
            this.Col_Place_Of_Birth,
            this.Col_Matial,
            this.Col_Mobile});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(12, 105);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 50;
            this.dataGridView2.Size = new System.Drawing.Size(534, 292);
            this.dataGridView2.TabIndex = 20;
            // 
            // Co_ID
            // 
            this.Co_ID.HeaderText = "الرقم";
            this.Co_ID.Name = "Co_ID";
            // 
            // Col_Clinic_Name
            // 
            this.Col_Clinic_Name.HeaderText = "الكود";
            this.Col_Clinic_Name.Name = "Col_Clinic_Name";
            // 
            // Col_Specialest
            // 
            this.Col_Specialest.HeaderText = "الوظيفة";
            this.Col_Specialest.Name = "Col_Specialest";
            // 
            // Col_Doctors_Full_Name
            // 
            this.Col_Doctors_Full_Name.HeaderText = "الاسم _ بالكامل";
            this.Col_Doctors_Full_Name.Name = "Col_Doctors_Full_Name";
            this.Col_Doctors_Full_Name.Width = 150;
            // 
            // Col_DateOfBirth
            // 
            this.Col_DateOfBirth.HeaderText = "تاريخ الميلاد";
            this.Col_DateOfBirth.Name = "Col_DateOfBirth";
            this.Col_DateOfBirth.Width = 120;
            // 
            // Col_Gender
            // 
            this.Col_Gender.HeaderText = "النوع";
            this.Col_Gender.Name = "Col_Gender";
            // 
            // Col_Phone
            // 
            this.Col_Phone.HeaderText = "التليفون";
            this.Col_Phone.Name = "Col_Phone";
            // 
            // Col_Notes
            // 
            this.Col_Notes.HeaderText = "الملاحظات";
            this.Col_Notes.Name = "Col_Notes";
            // 
            // Col_Work_Date
            // 
            this.Col_Work_Date.HeaderText = "تاريخ التعيين";
            this.Col_Work_Date.Name = "Col_Work_Date";
            // 
            // Col_First_Name
            // 
            this.Col_First_Name.HeaderText = "الاسم الاول";
            this.Col_First_Name.Name = "Col_First_Name";
            // 
            // Col_Second_Name
            // 
            this.Col_Second_Name.HeaderText = "اسم الاب";
            this.Col_Second_Name.Name = "Col_Second_Name";
            // 
            // Col_Nation
            // 
            this.Col_Nation.HeaderText = "الجنسية";
            this.Col_Nation.Name = "Col_Nation";
            // 
            // Col_Mail
            // 
            this.Col_Mail.HeaderText = "البريد";
            this.Col_Mail.Name = "Col_Mail";
            // 
            // Col_Blood
            // 
            this.Col_Blood.HeaderText = "فصيلة الدم";
            this.Col_Blood.Name = "Col_Blood";
            // 
            // Col_Nation_ID
            // 
            this.Col_Nation_ID.HeaderText = "رقم الهوية";
            this.Col_Nation_ID.Name = "Col_Nation_ID";
            // 
            // Col_Place_Of_Birth
            // 
            this.Col_Place_Of_Birth.HeaderText = "مكان الميلاد";
            this.Col_Place_Of_Birth.Name = "Col_Place_Of_Birth";
            // 
            // Col_Matial
            // 
            this.Col_Matial.HeaderText = "الحالة الاجتماعية";
            this.Col_Matial.Name = "Col_Matial";
            // 
            // Col_Mobile
            // 
            this.Col_Mobile.HeaderText = "رقم الموبايل";
            this.Col_Mobile.Name = "Col_Mobile";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.comboBox4);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(14, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(504, 69);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "البحث";
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(142, 25);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 28);
            this.button8.TabIndex = 9;
            this.button8.Text = "ابحث";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(6, 25);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 28);
            this.button7.TabIndex = 8;
            this.button7.Text = "عرض لكل الموظفين";
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
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "اختر اسم الطبيب";
            // 
            // Empolyees_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(559, 436);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox4);
            this.Name = "Empolyees_Search";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "شاشة البحث عن الموظفين";
            this.Load += new System.EventHandler(this.Empolyees_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Co_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Clinic_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Specialest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Doctors_Full_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Work_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Second_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Nation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Blood;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Nation_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Place_Of_Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Matial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Mobile;
    }
}