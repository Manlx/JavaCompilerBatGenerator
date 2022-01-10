using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FileCollectorAndManager
{
    public class FileCollectorAndManager
    {
        public  string FileSource;//Source Folder from where to start
        public  List<string> CompleteFileList = new List<string>();
        public  List<string> CompleteFolderList = new List<string>();
        public  bool SelectFiles(bool SelectSubFiles)//A method to collect all files in either the source folder or source and sub folders 
        {
            CompleteFileList = new List<string>();
            if (SelectSubFiles)
                CompleteFileList = CollectAllFiles(FileSource + "\\");
            else
                foreach (string x in Directory.GetFiles(FileSource + "\\"))
                    CompleteFileList.Add(x);
            return (CompleteFileList.Count > 0);
        }
        private  List<string> AppendingLists(List<string> ListOne, List<string> ListTwo)// Method to concatinate two lists
        {
            foreach (string x in ListTwo)
                ListOne.Add(x);
            return ListOne;
        }
        public  List<string> CollectAllFiles(string DirectoryPath) //Method to discover all subfiles
        {
            List<string> files = new List<string>();
            try
            {
                foreach (string x in Directory.GetFiles(DirectoryPath + "\\"))
                    files.Add(x);
                foreach (string x in Directory.GetDirectories(DirectoryPath + "\\"))
                    if ((File.GetAttributes(x) & FileAttributes.Directory) == FileAttributes.Directory)
                        AppendingLists(files, CollectAllFiles(x));
                    else
                        files.Add(x);
            }
            catch (Exception E){throw E;}
            
            return files;
        }
        public  List<string> CollectAllDirectories(string DirectoryPath)//Method to discover all folders
        {
            List<string> Directories = new List<string>();
            Directories.Add(DirectoryPath);
            foreach (string x in Directory.GetDirectories(DirectoryPath + "\\"))
                AppendingLists(Directories, CollectAllDirectories(x)) ;
            return Directories;
        }
        public  int ScanFor(string[] Phrases) //Scan through Files for a spesific string phrase
        {
            if (CompleteFileList.Count <= 0)
                return -1;
            int File = 0,Phrase;
            bool Looking = true;
            StreamReader Reader;
            string Line;
            while (Looking && File < CompleteFileList.Count)
            {
                Phrase = 0;
                while (Looking && Phrase < Phrases.Length)
                {
                    Reader = new StreamReader(CompleteFileList[File]);
                    while (Looking && String.IsNullOrEmpty((Line = Reader.ReadLine())))
                        Looking = Line.IndexOf(Phrases[Phrase]) == -1;
                    Phrase++;
                }
                File++;
            }
            return (File >= CompleteFileList.Count) ? -1 : File ;  
        }
        public int ContainsFile(string FileName)// Scans through complete File list and look for a spesific file name
        {
            bool FileFound = false;
            int x = 0;
            if (CompleteFileList.Count == 0)
                goto End;
            
            while (!FileFound && x < CompleteFileList.Count)
            {
                FileFound = CompleteFileList[x].Contains(FileName);
                x++;
            }
            if (FileFound)
                x--;
            End: 
            return (x >= CompleteFileList.Count)?-1:x ;
        }
        
    }
}
