
namespace JavaCompilerBatGenerator
{
    partial class frmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            this.redDisplayHelp = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // redDisplayHelp
            // 
            this.redDisplayHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.redDisplayHelp.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.redDisplayHelp.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.redDisplayHelp.Location = new System.Drawing.Point(1, 1);
            this.redDisplayHelp.Margin = new System.Windows.Forms.Padding(5);
            this.redDisplayHelp.Name = "redDisplayHelp";
            this.redDisplayHelp.Size = new System.Drawing.Size(588, 185);
            this.redDisplayHelp.TabIndex = 0;
            this.redDisplayHelp.Text = "Select all files ending with \'.java\'\nThe program will compile them\nfrom top to bo" +
    "ttom.\nThus the last file should be your\nfile that contains your main entry\nfunct" +
    "ion.";
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(591, 187);
            this.Controls.Add(this.redDisplayHelp);
            this.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.Load += new System.EventHandler(this.frmHelp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox redDisplayHelp;
    }
}