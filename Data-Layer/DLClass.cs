using FCM = FileCollectorAndManager.FileCollectorAndManager;
using SS = SavedSetting.SavedSettings;
using Seri = SerializerUtil.Serializer<SavedSetting.SavedSettings>;
using System.IO;

namespace Data_Layer
{
    public static class DLClass
    {
        public static SS SaveFile;
        public static Seri Serializer = new Seri("Settings.data");
        public static FCM FileCM = new FCM();
        public static bool LoadedSave = false;
        public static void LoadSaveFile()
        {
            if (LoadedSave)
                return;
            SaveFile = Serializer.DeSerializer();
            if (SaveFile == null)
                SaveFile = new SS();
            LoadedSave = true;
        }
        public static bool SaveSettings()
        {
            return Serializer.Serialize(SaveFile);
        }
        public static bool CheckForJFXDep()
        {
            bool FoundJFX = false;
            FileCM.SelectFiles(true);
            FoundJFX = FileCM.ScanFor(new string[] { "javafx" }) >= 0;
            return FoundJFX;
        }
        public static bool CheckForJFX(string SourceJDK)
        {
            bool FoundJDK = false;
            FCM JFXChecking = new FCM();
            JFXChecking.FileSource = SourceJDK;
            if (!JFXChecking.SelectFiles(true))
                goto End;
            int FileIndex = JFXChecking.ContainsFile("javafx.controls.jar");
            
            FoundJDK = FileIndex >= 0;
            if (!FoundJDK)
                goto End;
            SaveFile.JFXFilePath = Path.GetDirectoryName(JFXChecking.CompleteFileList[FileIndex]);
            End:
            return FoundJDK;
        }
        public static bool CheckForJDK(string SourceJDK)
        {
            bool FoundJDK = false;
            FCM JDKChecking = new FCM();
            JDKChecking.FileSource = SourceJDK;
            if (!JDKChecking.SelectFiles(true))
                goto End;
            int FileIndex = JDKChecking.ContainsFile("javac.exe");
            
            FoundJDK = FileIndex >= 0;
            if (!FoundJDK)
                goto End;
            SaveFile.JDKFilePath = Path.GetDirectoryName(JDKChecking.CompleteFileList[FileIndex]);
            End:
            return FoundJDK;
            
            //return FC.CheckForMain();
        }
    }
}
