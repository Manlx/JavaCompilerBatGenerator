using Data_Layer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DL = Data_Layer.DLClass;
namespace JavaCompilerBatGenerator
{
    public partial class frmMain : Form
    {
        frmSettings frmSet;
        public frmMain()
        {
            InitializeComponent();
            frmSet = new frmSettings(this);
            DL.LoadSaveFile();
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;
            string[] Items = DL.GetFiles(dlg.SelectedPath);
            foreach (string Item in Items)
                lsbSelectedFiles.Items.Add(Item);
            if (DL.CheckForJFXDep())
                if (DL.CheckForSavedJFX())
                    pnlJFX.BackColor = Color.Green;
                else
                {
                    MessageBox.Show("No JavaFX ");
                }
            dlg.Dispose();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            frmSet.ShowDialog();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
