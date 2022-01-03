namespace JavaCompilerBatGenerator
{
    partial class frmSettings
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
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnJFXPath = new System.Windows.Forms.Button();
            this.lblJFXPath = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btnJFXPath);
            this.groupBox1.Controls.Add(this.lblJFXPath);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Java FX:";
            // 
            // btnJFXPath
            // 
            this.btnJFXPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnJFXPath.FlatAppearance.BorderSize = 0;
            this.btnJFXPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJFXPath.Location = new System.Drawing.Point(670, 18);
            this.btnJFXPath.Name = "btnJFXPath";
            this.btnJFXPath.Size = new System.Drawing.Size(62, 26);
            this.btnJFXPath.TabIndex = 2;
            this.btnJFXPath.Text = "...";
            this.btnJFXPath.UseVisualStyleBackColor = false;
            this.btnJFXPath.Click += new System.EventHandler(this.btnJFXPath_Click);
            // 
            // lblJFXPath
            // 
            this.lblJFXPath.AutoSize = true;
            this.lblJFXPath.Location = new System.Drawing.Point(6, 25);
            this.lblJFXPath.Name = "lblJFXPath";
            this.lblJFXPath.Size = new System.Drawing.Size(97, 19);
            this.lblJFXPath.TabIndex = 0;
            this.lblJFXPath.Text = "Java FX:";
            // 
            // frmSettings
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(762, 74);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblJFXPath;
        private System.Windows.Forms.Button btnJFXPath;
    }
}