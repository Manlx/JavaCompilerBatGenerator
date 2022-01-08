using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using DLC = Data_Layer.DLClass;
namespace JavaCompilerBatGenerator
{
    public partial class frmSettings : Form
    {
        Form frmMain;
        public frmSettings(Form Creator)
        {
            frmMain = Creator;
            InitializeComponent();
        }

        private void btnJFXPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                if (DLC.CheckForJFX(folderBrowserDialog.SelectedPath))
                    MessageBox.Show("JFX found");
                else
                    MessageBox.Show("JFX NOT found");
            lblJFXPath.Text = $"Path: {DLC.SaveFile.JFXFilePath}";
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            DLC.LoadSaveFile();
            lblJFXPath.Text = $"Path: {DLC.SaveFile.JFXFilePath}";
            lblJDKPath.Text = $"Path: {DLC.SaveFile.JDKFilePath}";
        }

        private void btnJDKPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                if (DLC.CheckForJDK(folderBrowserDialog.SelectedPath))
                    MessageBox.Show("JDK found");
                else
                    MessageBox.Show("JDK NOT found");
            lblJDKPath.Text = $"Path: {DLC.SaveFile.JDKFilePath}";
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            DLC.SaveSettings();
        }
    }
}
