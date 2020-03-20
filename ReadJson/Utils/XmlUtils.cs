using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;   

namespace ReadJson.Utils
{
    class XmlUtils
    {
        public static string ReadByToan(string filePath)
        {
            string fileName = filePath.Split(new char[] { '_' }).Last();
            string output = "";
            string aline = "";
            //fileName.Substring(0, fileName.Length - 4);
            string objClassId = "";
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(filePath);
            XmlElement root = xmlDocument.DocumentElement;
            //XmlReader reader = XmlReader.Create(filePath);
            XmlNodeList xmlNodeListObject = root.GetElementsByTagName("object");
            for (int i = 0; i < xmlNodeListObject.Count; i++)
            {
                XmlNodeList xmlNodeListName = root.GetElementsByTagName("name");
                try
                {
                    string valutg = xmlNodeListName[i].InnerXml;
                    if (valutg.ElementAt(0).Equals('3'))
                    {
                        objClassId += "4," + valutg.ElementAt(1);
                    }
                    else
                    {
                        objClassId += valutg.ElementAt(0)
                            + "," + valutg.ElementAt(1);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    //objClassId += ",";
                    objClassId += "4,1";
                }
                XmlNodeList xmlNodeListXmin = root.GetElementsByTagName("xmin");
                XmlNodeList xmlNodeListYmin = root.GetElementsByTagName("ymin");
                XmlNodeList xmlNodeListXmax = root.GetElementsByTagName("xmax");
                XmlNodeList xmlNodeListYmax = root.GetElementsByTagName("ymax");
                try
                {
                    string valutag = xmlNodeListXmin[i].InnerXml;
                    aline += valutag + ",";
                    valutag = xmlNodeListYmin[i].InnerXml;
                    aline += valutag + ",";
                    valutag = xmlNodeListXmax[i].InnerXml;
                    aline += valutag + ",";

                    valutag = xmlNodeListYmax[i].InnerXml;
                    aline += valutag + ",";
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    aline += ",,,,";
                }
                aline += objClassId + Environment.NewLine;

                output += aline;
                aline = objClassId = "";
            }
            //string tagname = reader.Name;
            return output;
        }

    }
}
