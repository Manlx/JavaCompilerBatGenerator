﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FileCollectorAndManager
{
    public class FileCollectorAndManager
    {
        public  FolderBrowserDialog FolderSelector = new FolderBrowserDialog();
        public  string FileSource;
        public  List<string> CompleteFileList = new List<string>();
        public  List<string> CompleteFolderList = new List<string>();
        public  bool SelectFiles(bool SelectSubFiles)
        {
            CompleteFileList = new List<string>();
            if (FolderSelector.ShowDialog() != DialogResult.Yes)
                goto End;
            if (SelectSubFiles)
                CompleteFileList = CollectAllFiles(FolderSelector.SelectedPath + "\\");
            else
                foreach (string x in Directory.GetFiles(FolderSelector.SelectedPath + "\\"))
                    CompleteFileList.Add(x);
                End:
            FolderSelector.Dispose();
            return (CompleteFileList.Count > 0);
        }
        private  List<string> AppendingLists(List<string> ListOne, List<string> ListTwo)
        {
            //ListOne.Add("Going down One Directory");
            foreach (string x in ListTwo)
                ListOne.Add(x);
            return ListOne;
        }
        public  List<string> CollectAllFiles(string DirectoryPath)
        {
            List<string> files = new List<string>();
            foreach (string x in Directory.GetFiles(DirectoryPath + "\\"))
                files.Add(x);
            foreach (string x in Directory.GetDirectories(DirectoryPath + "\\"))
                if ((File.GetAttributes(x) & FileAttributes.Directory) == FileAttributes.Directory)
                    AppendingLists(files, CollectAllFiles(x));
                else
                    files.Add(x);
            return files;
        }
        public  List<string> CollectAllDirectories(string DirectoryPath)
        {
            List<string> Directories = new List<string>();
            Directories.Add(DirectoryPath);
            foreach (string x in Directory.GetDirectories(DirectoryPath + "\\"))
                AppendingLists(Directories, CollectAllDirectories(x)) ;
            return Directories;
        }
        public  int ScanFor(string[] Phrases)
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
        
    }
}
