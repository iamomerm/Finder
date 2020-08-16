using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Finder
{
    class Drive
    {
        static string[] System_Directories = { "C:\\Windows", "C:\\Program Files", "C:\\Program Files (x86)", "C:\\Program Data" };

        public static List<String> GetDrives()
        {
            List<String> DriveNames = new List<String>();

            try
            {
                DriveInfo[] Drives = DriveInfo.GetDrives();               

                for (int I = 0; I < Drives.Length; I++) { DriveNames.Add(Drives[I].Name); }

                return DriveNames;
            }

            catch { return DriveNames; /* Empty Array */ }
        }

        public static void GetFiles(List<String> List, string Path, int Threshold, bool SysFiles) /* Recursive */
        {          
            try
            {
                string[] Files = Directory.GetFiles(Path);

                string[] Directories = Directory.GetDirectories(Path);

                for (int I = 0; I < Files.Length; I++)
                {
                    FileInfo Fi = new FileInfo(Files[I]);

                    if (Fi.Length >= (Threshold * 1000000)) { List.Add(Fi.FullName + " " + "*(File Size: " + Fi.Length +")"); }
                }

                foreach (string Dir in Directories) 
                {
                    if (SysFiles == true) { GetFiles(List, Dir, Threshold, SysFiles); }

                    else { if (!(System_Directories.Contains(Dir))) { GetFiles(List, Dir, Threshold, SysFiles); } }       
                } 
            }
            
            catch { /* Pass */ }
        }
    }
}
