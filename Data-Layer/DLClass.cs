using System;
using System.Collections.Generic;
using System.Text;
using FCM = FileCollectorAndManager.FileCollectorAndManager;
using FC = FileChecker.FileCheckers;
using SS = SavedSetting.SavedSettings;
using Seri = SerializerUtil.Serializer<SavedSetting.SavedSettings>;
namespace Data_Layer
{
    public static class DLClass
    {
        public static SS SaveFile;
        public static Seri Serializer = new Seri("Settings.data");
        public static void LoadSaveFile()
        {

            SaveFile = Serializer.DeSerializer();
        }
        public static bool CheckForJFX()
        {
            bool FoundJFX = false;

            return FoundJFX;
        }
        public static bool CheckForJDK()
        {
            return false;
            //return FC.CheckForMain();
        }
    }
}
