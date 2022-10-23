namespace SystemAccounting
{
    partial class Items
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Item_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Del_Falge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Minimum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(638, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(99, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 51);
            this.panel1.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 35);
            this.button5.TabIndex = 4;
            this.button5.Text = "اغلاق";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(83, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "حذف";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "تعديل";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "حفظ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "جديد";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(288, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 27);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "الحد الأدنى";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 27);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "فئة الصنف";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(288, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الصنف";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_ID,
            this.Category_ID,
            this.User_ID,
            this.Del_Falge,
            this.Item_Name,
            this.Category_Name,
            this.Item_Minimum});
            this.dataGridView1.Location = new System.Drawing.Point(1, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 253);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Item_ID
            // 
            this.Item_ID.DataPropertyName = "Item_ID";
            this.Item_ID.HeaderText = "الكود";
            this.Item_ID.Name = "Item_ID";
            this.Item_ID.Visible = false;
            this.Item_ID.Width = 300;
            // 
            // Category_ID
            // 
            this.Category_ID.DataPropertyName = "Category_ID";
            this.Category_ID.HeaderText = "كود الفئة";
            this.Category_ID.Name = "Category_ID";
            this.Category_ID.Visible = false;
            // 
            // User_ID
            // 
            this.User_ID.DataPropertyName = "User_ID";
            this.User_ID.HeaderText = "اسم المستخدم";
            this.User_ID.Name = "User_ID";
            this.User_ID.Visible = false;
            // 
            // Del_Falge
            // 
            this.Del_Falge.DataPropertyName = "Del_Flage";
            this.Del_Falge.HeaderText = "حقل الحذف";
            this.Del_Falge.Name = "Del_Falge";
            this.Del_Falge.Visible = false;
            // 
            // Item_Name
            // 
            this.Item_Name.DataPropertyName = "Item_Name";
            this.Item_Name.HeaderText = "اسم الصنف";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.Width = 200;
            // 
            // Category_Name
            // 
            this.Category_Name.DataPropertyName = "Category_Name";
            this.Category_Name.HeaderText = "فئة الصنف";
            this.Category_Name.Name = "Category_Name";
            this.Category_Name.Width = 200;
            // 
            // Item_Minimum
            // 
            this.Item_Minimum.DataPropertyName = "Item_Minimum";
            this.Item_Minimum.HeaderText = "الحد الدنى";
            this.Item_Minimum.Name = "Item_Minimum";
            this.Item_Minimum.Width = 200;
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(674, 446);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Items";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تسجيل الاصناف";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Del_Falge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Minimum;
    }
}