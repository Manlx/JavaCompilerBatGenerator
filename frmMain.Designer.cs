
namespace JavaCompilerBatGenerator
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.chkDisplaySubFiles = new System.Windows.Forms.CheckBox();
            this.chkSubFiles = new System.Windows.Forms.CheckBox();
            this.chkCreateJar = new System.Windows.Forms.CheckBox();
            this.pnlJDK = new System.Windows.Forms.Panel();
            this.pnlJFX = new System.Windows.Forms.Panel();
            this.btnOptions = new System.Windows.Forms.Button();
            this.chkIndepthLook = new System.Windows.Forms.CheckBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lsbSelectedFiles = new System.Windows.Forms.ListBox();
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tthints = new System.Windows.Forms.ToolTip(this.components);
            this.lblMain = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.pnlMain);
            this.groupBox1.Controls.Add(this.chkDisplaySubFiles);
            this.groupBox1.Controls.Add(this.chkSubFiles);
            this.groupBox1.Controls.Add(this.chkCreateJar);
            this.groupBox1.Controls.Add(this.pnlJDK);
            this.groupBox1.Controls.Add(this.pnlJFX);
            this.groupBox1.Controls.Add(this.btnOptions);
            this.groupBox1.Controls.Add(this.chkIndepthLook);
            this.groupBox1.Controls.Add(this.btnHelp);
            this.groupBox1.Controls.Add(this.lsbSelectedFiles);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(541, 535);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compile Code";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMain);
            this.panel1.Location = new System.Drawing.Point(7, 413);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 113);
            this.panel1.TabIndex = 12;
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(454, 383);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(16, 16);
            this.pnlMain.TabIndex = 9;
            this.tthints.SetToolTip(this.pnlMain, "Main Entry point was found");
            // 
            // chkDisplaySubFiles
            // 
            this.chkDisplaySubFiles.AutoSize = true;
            this.chkDisplaySubFiles.Checked = true;
            this.chkDisplaySubFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisplaySubFiles.Location = new System.Drawing.Point(325, 169);
            this.chkDisplaySubFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkDisplaySubFiles.Name = "chkDisplaySubFiles";
            this.chkDisplaySubFiles.Size = new System.Drawing.Size(158, 27);
            this.chkDisplaySubFiles.TabIndex = 11;
            this.chkDisplaySubFiles.Text = "Show Sub Files";
            this.chkDisplaySubFiles.UseVisualStyleBackColor = true;
            // 
            // chkSubFiles
            // 
            this.chkSubFiles.AutoSize = true;
            this.chkSubFiles.Checked = true;
            this.chkSubFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSubFiles.Location = new System.Drawing.Point(325, 142);
            this.chkSubFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkSubFiles.Name = "chkSubFiles";
            this.chkSubFiles.Size = new System.Drawing.Size(166, 27);
            this.chkSubFiles.TabIndex = 10;
            this.chkSubFiles.Text = "Collect SubFiles";
            this.chkSubFiles.UseVisualStyleBackColor = true;
            // 
            // chkCreateJar
            // 
            this.chkCreateJar.AutoSize = true;
            this.chkCreateJar.Checked = true;
            this.chkCreateJar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCreateJar.Location = new System.Drawing.Point(325, 114);
            this.chkCreateJar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkCreateJar.Name = "chkCreateJar";
            this.chkCreateJar.Size = new System.Drawing.Size(150, 27);
            this.chkCreateJar.TabIndex = 9;
            this.chkCreateJar.Text = "Create Jar File";
            this.chkCreateJar.UseVisualStyleBackColor = true;
            // 
            // pnlJDK
            // 
            this.pnlJDK.Location = new System.Drawing.Point(418, 383);
            this.pnlJDK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlJDK.Name = "pnlJDK";
            this.pnlJDK.Size = new System.Drawing.Size(16, 16);
            this.pnlJDK.TabIndex = 8;
            this.tthints.SetToolTip(this.pnlJDK, "Java JDK files Detected");
            // 
            // pnlJFX
            // 
            this.pnlJFX.Location = new System.Drawing.Point(382, 383);
            this.pnlJFX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlJFX.Name = "pnlJFX";
            this.pnlJFX.Size = new System.Drawing.Size(16, 16);
            this.pnlJFX.TabIndex = 7;
            this.tthints.SetToolTip(this.pnlJFX, "JavaFX Files Detected");
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOptions.ForeColor = System.Drawing.Color.White;
            this.btnOptions.Location = new System.Drawing.Point(429, 29);
            this.btnOptions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(46, 49);
            this.btnOptions.TabIndex = 5;
            this.btnOptions.Text = "≡";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // chkIndepthLook
            // 
            this.chkIndepthLook.AutoSize = true;
            this.chkIndepthLook.Location = new System.Drawing.Point(325, 86);
            this.chkIndepthLook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkIndepthLook.Name = "chkIndepthLook";
            this.chkIndepthLook.Size = new System.Drawing.Size(182, 27);
            this.chkIndepthLook.TabIndex = 4;
            this.chkIndepthLook.Text = "In Depth Warnings";
            this.chkIndepthLook.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(483, 29);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(46, 49);
            this.btnHelp.TabIndex = 1;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // lsbSelectedFiles
            // 
            this.lsbSelectedFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lsbSelectedFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbSelectedFiles.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lsbSelectedFiles.FormattingEnabled = true;
            this.lsbSelectedFiles.ItemHeight = 23;
            this.lsbSelectedFiles.Location = new System.Drawing.Point(7, 29);
            this.lsbSelectedFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsbSelectedFiles.Name = "lsbSelectedFiles";
            this.lsbSelectedFiles.Size = new System.Drawing.Size(313, 370);
            this.lsbSelectedFiles.TabIndex = 0;
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSelectFiles.FlatAppearance.BorderSize = 0;
            this.btnSelectFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFiles.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelectFiles.ForeColor = System.Drawing.Color.White;
            this.btnSelectFiles.Location = new System.Drawing.Point(18, 550);
            this.btnSelectFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(253, 59);
            this.btnSelectFiles.TabIndex = 6;
            this.btnSelectFiles.Text = "Select Files";
            this.btnSelectFiles.UseVisualStyleBackColor = false;
            this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(279, 550);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(253, 59);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(6, 9);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(88, 23);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "MainFile:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(550, 618);
            this.Controls.Add(this.btnSelectFiles);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerate);
            this.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bat Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ListBox lsbSelectedFiles;
        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox chkIndepthLook;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Panel pnlJFX;
        private System.Windows.Forms.Panel pnlJDK;
        private System.Windows.Forms.ToolTip tthints;
        private System.Windows.Forms.CheckBox chkCreateJar;
        private System.Windows.Forms.CheckBox chkSubFiles;
        private System.Windows.Forms.CheckBox chkDisplaySubFiles;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMain;
    }
}

