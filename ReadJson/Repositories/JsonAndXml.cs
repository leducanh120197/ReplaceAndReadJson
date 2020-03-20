using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ReadJson
{
    class JsonAndXml
    {
        public static Tuple<string, string> AnalysisFileContent(string url, string pathSystax, string fileType)
        {
            FileStream fs = new FileStream(url, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            string strContent = reader.ReadToEnd();
            string strOut = "";

            if (fileType == "*.json")
            {
                JObject obj = JObject.Parse(strContent);
                IEnumerable<JToken> pricyProducts = obj.SelectTokens(pathSystax);
                foreach (JToken item in pricyProducts)
                {
                    strOut += item + "\n";
                }
            }
            if(fileType == "*.xml")
            {
                XPathDocument docNav = new XPathDocument(url);
                XPathNavigator nav = docNav.CreateNavigator();
                //string strExpression = "/bookstore/book";

                XPathNodeIterator NodeIter = nav.Select(pathSystax);
                while (NodeIter.MoveNext())
                {
                    strOut += NodeIter.Current.Value + "\n";
                };
            }
            return new Tuple<string, string> (strContent, strOut);
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
        public static string GetOnlyNameToJtoken(JToken token)
        {
            string str = token.ToObject<JProperty>().Name.ToString();
            return str;
        }
        public static string CheckHasValues()
        {
            string str = "";
            return str;
        }
    }
}
