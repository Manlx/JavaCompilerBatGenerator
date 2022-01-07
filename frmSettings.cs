using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using SS = SavedSetting.SavedSettings;
using Serial = SerializerUtil.Serializer<SavedSetting.SavedSettings>;
namespace JavaCompilerBatGenerator
{
    public partial class frmSettings : Form
    {
        Form frmMain;
        public frmSettings(Form Creator)
        {
            InitializeComponent();
        }

        private void btnJFXPath_Click(object sender, EventArgs e)
        {
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            if (SaveFile == null)
                return;
            lblJDKPath.Text = SaveFile.JDKFilePath;
            lblJFXPath.Text = SaveFile.JavaFXFilePath;
        }
    }
}
