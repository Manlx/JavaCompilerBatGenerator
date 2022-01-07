using System;
using System.Collections.Generic;
using System.Text;
using FileCollectorAndManager;
using FCM = FileCollectorAndManager.FileCollectorAndManager;
namespace FileChecker
{
    public static class FileCheckers
    {
        static bool ScanSubFiles;
        public static bool CheckForJFXDep()
        {
            FCM.SelectFiles(ScanSubFiles);
            return FileCollectorAndManager.FileCollectorAndManager.ScanFor(new string[] { "javafx" }) >= 0;
        }
        public static bool CheckForMain(bool MoveIfFound)
        {
            bool FoundMain = false;
            FCM.SelectFiles(ScanSubFiles);
            int MainIndex = FileCollectorAndManager.FileCollectorAndManager.ScanFor(new string[] { "public static void main(String[]" });
            if (FoundMain = MainIndex >= 0 && MoveIfFound)
            {
                string temp = FCM.CompleteFileList[MainIndex];
                FCM.CompleteFileList[MainIndex] = FCM.CompleteFileList[FCM.CompleteFileList.Count-1];
                FCM.CompleteFileList[FCM.CompleteFileList.Count - 1] = temp;
            }  
            return FoundMain;
        }
    }
}
