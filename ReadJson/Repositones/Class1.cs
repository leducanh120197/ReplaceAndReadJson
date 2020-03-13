using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadJson
{
    class Class1
    {
        public static Tuple<string, string> ReadJson(string url, string pathSystax)
        {
            string strOut = "";

            FileStream fs = new FileStream(url, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            string strJson = reader.ReadToEnd();

            JObject obj = JObject.Parse(strJson);
            IEnumerable<JToken> pricyProducts = obj.SelectTokens(pathSystax);
            foreach (JToken item in pricyProducts)
            {
                strOut += item + "\n";
            }
            return new Tuple<string, string> (strJson, strOut);
        }
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

        public static Tuple<List<string>, List<string>> ReadConfig(string url)
        {
            StreamReader reader = new StreamReader(url);
            List<string> listA = new List<string>();
            List<string> listB = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                listA.Add(values[0]);
                listB.Add(values[1]);
            }
            return new Tuple<List<string>, List<string>>(listA, listB);
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
        public static string ChangeFileName(FileInfo file)
        {
            string dir = file.FullName.Replace(file.Extension, "_replace" + file.Extension);
            return dir;
        } 
    }
}
