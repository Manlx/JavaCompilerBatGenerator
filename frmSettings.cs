using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace JavaCompilerBatGenerator
{
    public partial class frmSettings : Form
    {
        private const string SettingsName = "Settings.data";
        Form frmMain;
        public frmSettings(Form Creator)
        {
            frmMain = Creator;
            
            InitializeComponent();
            BinaryFormatter BinFor = new BinaryFormatter();
            Stream stream;
            if (File.Exists("Settings.data"))
            {
                stream = new FileStream(SettingsName, FileMode.Open, FileAccess.Read);
                if (stream.Length <= 0)
                    return;
                SavedSettings = (SavedSettings)BinFor.Deserialize(stream);
            
                ((frmMain)frmMain).SavedFiles = SavedSettings;

                stream.Close();
            }
        }
        public SavedSettings SavedSettings { get; set; }
        private void SaveFile()
        {
            BinaryFormatter BinFor = new BinaryFormatter();
            Stream stream = new FileStream(SettingsName, FileMode.Create, FileAccess.Write);
            //if (SavedSettings == null)
            BinFor.Serialize(stream, SavedSettings);
            stream.Close();
        }
        private void UpdateSaveSettings()
        {
            if (SavedSettings == null)
                SavedSettings = new SavedSettings();
            if (Directory.Exists(lblJFXPath.Text))
                SavedSettings.JavaFXFilePath = lblJFXPath.Text;
        }
        private void btnJFXPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {

                lblJFXPath.Text = folderBrowserDialog.SelectedPath;
                folderBrowserDialog.Dispose();
                UpdateSaveSettings();
                SaveFile();
                SavedSettings.JavaFXFilePath = folderBrowserDialog.SelectedPath;
            }
                
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            if (SavedSettings.JavaFXFilePath != "")
                lblJFXPath.Text = SavedSettings.JavaFXFilePath;
            else
                lblJFXPath.Text = "Java FX Path: ";
        }
    }
}
