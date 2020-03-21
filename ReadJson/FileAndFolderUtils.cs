using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadJson
{
    class FileAndFolderUtils
    {
        public static FileInfo[] GetListFile(string url, string fileType)
        {
            DirectoryInfo direct = new DirectoryInfo(url);
            FileInfo[] Files;
            if (fileType.Length == 0)
            {
                Files = direct.GetFiles();
            }
            else
            {
                Files = direct.GetFiles(fileType);
            }
            return Files;
        }

        public static string ReadFile(string url)
        {
            FileStream fs = new FileStream(url, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            string strContent = reader.ReadToEnd();
            reader.Close();
            fs.Close();
            return strContent;
        }

        public static void WriteFile(string url, string content)
        {
            FileStream fs = new FileStream(url, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(content);
            sw.Close();
            fs.Close();
        }

        public static string ChangeFileName(FileInfo file, string str)
        {
            string dir = file.FullName.Replace(file.Extension, "_replace" + file.Extension);
            return dir;
        }
    }
}
