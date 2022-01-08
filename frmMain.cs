using Data_Layer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace JavaCompilerBatGenerator
{
    public partial class frmMain : Form
    {
        private frmSettings frmSet;

        public frmMain()
        {
            InitializeComponent();
            frmSet = new frmSettings(this);
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {}

        private void btnOptions_Click(object sender, EventArgs e)
        {
            frmSet.ShowDialog();
        }
    }
}
