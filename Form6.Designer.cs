namespace SystemAccounting
{
    partial class Form6
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
            this.rpt = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rpt
            // 
            this.rpt.ActiveViewIndex = -1;
            this.rpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpt.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpt.Location = new System.Drawing.Point(0, 0);
            this.rpt.Name = "rpt";
            this.rpt.Size = new System.Drawing.Size(880, 395);
            this.rpt.TabIndex = 0;
            this.rpt.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 395);
            this.Controls.Add(this.rpt);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpt;
    }
}