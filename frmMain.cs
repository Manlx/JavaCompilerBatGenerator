using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace JavaCompilerBatGenerator
{
    public partial class frmMain : Form
    {
        public SavedSettings SavedFiles;
        private List<string> CorrectFiles;
        frmSettings frmSet;
        public frmMain()
        {
            InitializeComponent();
            frmSet = new frmSettings(this);
            if (SavedFiles != null)
                GetJavaLibs();
            if (CorrectFiles != null) 
                if (CorrectFiles.Count > 0)
                    pnlLibsLoaded.BackColor = Color.FromArgb(00,99,00);
            ChangeComponentStates(false);
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {  //Does a simple check if the item can be moved and if it can does a simple swap
            if (lsbSelectedFiles.SelectedIndex != 0)
            {
                var temp = lsbSelectedFiles.Items[lsbSelectedFiles.SelectedIndex-1];
                lsbSelectedFiles.Items[lsbSelectedFiles.SelectedIndex - 1] = lsbSelectedFiles.Items[lsbSelectedFiles.SelectedIndex];
                lsbSelectedFiles.Items[lsbSelectedFiles.SelectedIndex] = temp;
                lsbSelectedFiles.SelectedIndex--;
            }
        }
        private void ChangeComponentStates(bool State)
        {//Changes state of all effected components
            btnMoveUp.Enabled = State;
            btnMoveDown.Enabled = State;
            btnGenerate.Enabled = State;
        }
        private void ScanForJavaFXDepend()
        {
            int x = 0;
            StreamReader SR;
            string temp;
            while (!chkJavaFX.Checked && x < lsbSelectedFiles.Items.Count)
            {
                SR = new StreamReader($"{lblSourceFile.Text}\\{lsbSelectedFiles.Items[x].ToString()}");
                while ((temp = SR.ReadLine()) != null && !chkJavaFX.Checked)//Checks for main and then for String if spaces are in between
                    chkJavaFX.Checked = !(temp.IndexOf("javafx.application") == -1);
                x++;
            }
        }
        private int ScanFile()
        {//Scans listed files for main entry point for java
            bool LookForMain = true;
            int x = 0;
            StreamReader SR;
            string temp;
            while (LookForMain && x < lsbSelectedFiles.Items.Count)
            {
                SR = new StreamReader($"{lblSourceFile.Text}\\{lsbSelectedFiles.Items[x].ToString()}");
                while ((temp = SR.ReadLine()) != null && LookForMain)//Checks for main and then for String if spaces are in between
                    LookForMain = temp.IndexOf("public static void main") == -1 && temp.IndexOf ("(String[]") == -1;
                
                x++;
            }
            
            if (LookForMain)
                return -1;
            return --x;
        }
        private void btnSelectFiles_Click(object sender, EventArgs e)
        {//Opens dialog and allows user to select files to compile.
            lsbSelectedFiles.Items.Clear();
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.Multiselect = true;
            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                lblSourceFile.Text = Path.GetDirectoryName(myDialog.FileName);
                foreach (var item in myDialog.FileNames)//Checks if file is a proper java source file
                    if (Path.GetExtension(item.ToString()) == ".java")
                        lsbSelectedFiles.Items.Add(Path.GetFileName(item.ToString()));
                ChangeComponentStates(lsbSelectedFiles.Items.Count > 0);
                ScanForJavaFXDepend();
            }
            else
                MessageBox.Show("No file selected");
            myDialog.Dispose();
            
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {//Generates Bat File
            bool Forced = false;//If File is allowed to be scanned
            if (chkScanFiles.Checked)
            {//If scan finds main file the it return the file index in the listbox
                int temp = ScanFile();
                if (temp == -1)// if File was not found further options can be taken
                    if (!(Forced = MessageBox.Show("No Main File found. Force continue", "Possible Error", MessageBoxButtons.YesNo) == DialogResult.Yes))
                        return;
                if (!Forced)//If force then further checks are skipped
                    if (temp != lsbSelectedFiles.Items.Count - 1)
                        if (MessageBox.Show("Main file not in proper order, would you like to fix this potential error?", "Possible Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {//Moves item to correct compile slot
                            lsbSelectedFiles.SelectedIndex = temp;
                            for (int x = temp; x < lsbSelectedFiles.Items.Count; x++)
                                btnMoveDown.PerformClick();
                        }
            }
            //Creates file and writes cmd commands
            StreamWriter fs = new StreamWriter($"{lblSourceFile.Text}\\Run.bat");
            string JavaFXCompilation = "";
            if (chkJavaFX.Checked)
            {
                //JavaFXCompilation = $"--module-path {'"'}{SavedFiles.JavaFXFilePath}{'"'} --add-modules ";
                //for (int x = 0; x < CorrectFiles.Count; x++)
                //{
                //    JavaFXCompilation += $"{Path.GetFileNameWithoutExtension( CorrectFiles[x])}";
                //    if (x < CorrectFiles.Count - 1)
                //        JavaFXCompilation = JavaFXCompilation + ",";
                //}
                JavaFXCompilation = $"--module-path {'"'}{SavedFiles.JavaFXFilePath}{'"'} --add-modules javafx.controls,javafx.fxml";
            }
            
                

            foreach (var item in lsbSelectedFiles.Items)
                fs.WriteLine($"javac {JavaFXCompilation} {((chkIndepthLook.Checked)? "-Xlint:unchecked" : "")} {item.ToString()}");
            fs.WriteLine($"java {JavaFXCompilation} {lsbSelectedFiles.Items[lsbSelectedFiles.Items.Count - 1].ToString()}" );
            fs.WriteLine("pause");
            fs.Close();
            
            MessageBox.Show("File generated successful");
            if (MessageBox.Show("Run Bat","Want to Execute Bat",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Diagnostics.Process ExecuteBat = new System.Diagnostics.Process();
                ExecuteBat.StartInfo.WorkingDirectory = lblSourceFile.Text+"\\";
                ExecuteBat.StartInfo.FileName = $"{lblSourceFile.Text}\\Run.bat";
                ExecuteBat.Start();
            }
                
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {   //Does a simple check if the item can be moved and if it can does a simple swap
            if (lsbSelectedFiles.SelectedIndex != lsbSelectedFiles.Items.Count-1 && lsbSelectedFiles.Items.Count > 1)
            {
                var temp = lsbSelectedFiles.Items[lsbSelectedFiles.SelectedIndex + 1];
                lsbSelectedFiles.Items[lsbSelectedFiles.SelectedIndex + 1] = lsbSelectedFiles.Items[lsbSelectedFiles.SelectedIndex];
                lsbSelectedFiles.Items[lsbSelectedFiles.SelectedIndex] = temp;
                lsbSelectedFiles.SelectedIndex++;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {//Displayes help form
            frmHelp temp = new frmHelp();
            temp.ShowDialog();
        }
        private void btnOptions_Click(object sender, EventArgs e)
        {
            
            frmSet.ShowDialog();
        }
        private void GetJavaLibs()
        {
            string[] Files = Directory.GetFiles(SavedFiles.JavaFXFilePath+"\\");
            CorrectFiles = new List<string>();
            foreach (string x in Files)
            {
                if (Path.GetExtension(x).ToUpper() == ".JAR")
                    CorrectFiles.Add(x);
            }
        }
    }
}
