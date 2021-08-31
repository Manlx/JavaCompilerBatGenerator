using System;
using System.Drawing;
using System.Windows.Forms;

namespace JavaCompilerBatGenerator
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            //Just display help info on create
            redDisplayHelp.Clear();
            redDisplayHelp.SelectionColor = Color.FromArgb(00,135,215);
            redDisplayHelp.SelectedText = "Select all files ending with '.java'\nThe program will compile them\nfrom ";
            redDisplayHelp.SelectionColor = Color.FromArgb(215, 95, 0);
            redDisplayHelp.SelectedText = "top";
            redDisplayHelp.SelectionColor = Color.FromArgb(00, 135, 215);
            redDisplayHelp.SelectedText = " to ";
            redDisplayHelp.SelectionColor = Color.FromArgb(215, 95, 0);
            redDisplayHelp.SelectedText = "bottom.";
            redDisplayHelp.SelectionColor = Color.FromArgb(00, 135, 215);
            redDisplayHelp.SelectedText = "Thus the last file should be your\nfile that ";
            redDisplayHelp.SelectionColor = Color.FromArgb(215, 95, 0);
            redDisplayHelp.SelectedText = "contains your main entry function.";
            redDisplayHelp.ReadOnly = true;
        }
    }
}
