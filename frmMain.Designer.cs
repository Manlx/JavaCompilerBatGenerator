
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
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlLibsLoaded = new System.Windows.Forms.Panel();
            this.chkJavaFX = new System.Windows.Forms.CheckBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.chkIndepthLook = new System.Windows.Forms.CheckBox();
            this.chkScanFiles = new System.Windows.Forms.CheckBox();
            this.lblSourceFile = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lsbSelectedFiles = new System.Windows.Forms.ListBox();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMoveUp.FlatAppearance.BorderSize = 0;
            this.btnMoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveUp.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMoveUp.ForeColor = System.Drawing.Color.White;
            this.btnMoveUp.Location = new System.Drawing.Point(10, 397);
            this.btnMoveUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(262, 50);
            this.btnMoveUp.TabIndex = 0;
            this.btnMoveUp.Text = "Move Up";
            this.btnMoveUp.UseVisualStyleBackColor = false;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlLibsLoaded);
            this.groupBox1.Controls.Add(this.chkJavaFX);
            this.groupBox1.Controls.Add(this.btnOptions);
            this.groupBox1.Controls.Add(this.chkIndepthLook);
            this.groupBox1.Controls.Add(this.chkScanFiles);
            this.groupBox1.Controls.Add(this.lblSourceFile);
            this.groupBox1.Controls.Add(this.btnHelp);
            this.groupBox1.Controls.Add(this.lsbSelectedFiles);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(541, 336);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compile Code";
            // 
            // pnlLibsLoaded
            // 
            this.pnlLibsLoaded.Location = new System.Drawing.Point(247, 47);
            this.pnlLibsLoaded.Name = "pnlLibsLoaded";
            this.pnlLibsLoaded.Size = new System.Drawing.Size(12, 13);
            this.pnlLibsLoaded.TabIndex = 7;
            // 
            // chkJavaFX
            // 
            this.chkJavaFX.AutoSize = true;
            this.chkJavaFX.Location = new System.Drawing.Point(267, 42);
            this.chkJavaFX.Name = "chkJavaFX";
            this.chkJavaFX.Size = new System.Drawing.Size(105, 23);
            this.chkJavaFX.TabIndex = 6;
            this.chkJavaFX.Text = "Java FX";
            this.chkJavaFX.UseVisualStyleBackColor = true;
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOptions.ForeColor = System.Drawing.Color.White;
            this.btnOptions.Location = new System.Drawing.Point(432, 14);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(46, 40);
            this.btnOptions.TabIndex = 5;
            this.btnOptions.Text = "≡";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // chkIndepthLook
            // 
            this.chkIndepthLook.AutoSize = true;
            this.chkIndepthLook.Location = new System.Drawing.Point(10, 40);
            this.chkIndepthLook.Name = "chkIndepthLook";
            this.chkIndepthLook.Size = new System.Drawing.Size(215, 23);
            this.chkIndepthLook.TabIndex = 4;
            this.chkIndepthLook.Text = "In Depth Warnings";
            this.chkIndepthLook.UseVisualStyleBackColor = true;
            // 
            // chkScanFiles
            // 
            this.chkScanFiles.AutoSize = true;
            this.chkScanFiles.Checked = true;
            this.chkScanFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkScanFiles.Location = new System.Drawing.Point(267, 14);
            this.chkScanFiles.Name = "chkScanFiles";
            this.chkScanFiles.Size = new System.Drawing.Size(138, 23);
            this.chkScanFiles.TabIndex = 3;
            this.chkScanFiles.Text = "Scan Files";
            this.chkScanFiles.UseVisualStyleBackColor = true;
            // 
            // lblSourceFile
            // 
            this.lblSourceFile.AutoSize = true;
            this.lblSourceFile.Location = new System.Drawing.Point(6, 304);
            this.lblSourceFile.Name = "lblSourceFile";
            this.lblSourceFile.Size = new System.Drawing.Size(141, 19);
            this.lblSourceFile.TabIndex = 2;
            this.lblSourceFile.Text = "Source File:";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(486, 14);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(46, 40);
            this.btnHelp.TabIndex = 1;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lsbSelectedFiles
            // 
            this.lsbSelectedFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lsbSelectedFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbSelectedFiles.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lsbSelectedFiles.FormattingEnabled = true;
            this.lsbSelectedFiles.ItemHeight = 19;
            this.lsbSelectedFiles.Location = new System.Drawing.Point(5, 71);
            this.lsbSelectedFiles.Name = "lsbSelectedFiles";
            this.lsbSelectedFiles.Size = new System.Drawing.Size(535, 230);
            this.lsbSelectedFiles.TabIndex = 0;
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMoveDown.FlatAppearance.BorderSize = 0;
            this.btnMoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveDown.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMoveDown.ForeColor = System.Drawing.Color.White;
            this.btnMoveDown.Location = new System.Drawing.Point(275, 397);
            this.btnMoveDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(265, 50);
            this.btnMoveDown.TabIndex = 5;
            this.btnMoveDown.Text = "Move Down";
            this.btnMoveDown.UseVisualStyleBackColor = false;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSelectFiles.FlatAppearance.BorderSize = 0;
            this.btnSelectFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFiles.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelectFiles.ForeColor = System.Drawing.Color.White;
            this.btnSelectFiles.Location = new System.Drawing.Point(163, 344);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(225, 49);
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
            this.btnGenerate.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(10, 451);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(530, 50);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(550, 507);
            this.Controls.Add(this.btnSelectFiles);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnMoveUp);
            this.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bat Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ListBox lsbSelectedFiles;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.Label lblSourceFile;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox chkScanFiles;
        private System.Windows.Forms.CheckBox chkIndepthLook;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.CheckBox chkJavaFX;
        private System.Windows.Forms.Panel pnlLibsLoaded;
    }
}

