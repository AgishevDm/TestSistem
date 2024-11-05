using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace WpfApp3
{
    internal class Read
    {
        string path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;
        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public Read(string Path)
        {
            path = new FileInfo(Path).FullName.ToString();
        }

        public string ReadINI(string Find, string Key)
        {
            var RetVal = new StringBuilder(1000);
            GetPrivateProfileString(Find, Key, "", RetVal, 1000, path);
            return RetVal.ToString();
        }
    }
}