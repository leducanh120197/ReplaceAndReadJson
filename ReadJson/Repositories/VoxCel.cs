using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadJson.Repositories
{
    class VoxCel
    {
        public static string WriteJson(Microsoft.Office.Interop.Excel.Range xlRange)
        {
            int columnWhatIsIt = 1;
            int columnLabel = 2;
            int columnMutable = 3;
            //int columnExclusive = 4;
            int columnInput_type = 5;
            int columnName = 6;
            int columnCategories = 7;

            int rowCount = xlRange.Rows.Count;
            List<DataJson> NamIdAttr = new List<DataJson>();
            List<DataJson2> Arrtributes = new List<DataJson2>();
            int countAttributeLine = 0;
            string jsonAttribute = "";
            for (int curentLine = 1; curentLine <= rowCount; curentLine++)
            {
                if (!HasAttribute(xlRange.Cells[curentLine, columnWhatIsIt].Value))
                {
                    Arrtributes = new List<DataJson2>();
                    if (countAttributeLine != 0)
                    {
                        NamIdAttr.Add(new DataJson()
                        {
                            name = xlRange.Cells[curentLine - countAttributeLine, columnLabel].Value,
                            id = curentLine - countAttributeLine - 1,
                            attributes = jsonAttribute
                        });
                    }
                    countAttributeLine = 0;
                }
                else
                {
                    if (IsNextSame(xlRange.Cells[curentLine + 1, columnLabel].Value, xlRange.Cells[curentLine, columnLabel].Value))
                    {
                        Arrtributes.Add(new DataJson2()
                        {
                            id = curentLine * 1000,
                            name = xlRange.Cells[curentLine, columnName].Value,
                            type = xlRange.Cells[curentLine, columnInput_type].Value,
                            mutable = xlRange.Cells[curentLine, columnMutable].Value,
                            values = xlRange.Cells[curentLine, columnCategories].Value
                        });
                        countAttributeLine++;
                    }
                    else
                    {
                        Arrtributes.Add(new DataJson2()
                        {
                            id = curentLine * 1000,
                            name = xlRange.Cells[curentLine, columnName].Value,
                            type = xlRange.Cells[curentLine, columnInput_type].Value,
                            mutable = xlRange.Cells[curentLine, columnMutable].Value,
                            values = xlRange.Cells[curentLine, columnCategories].Value
                        });
                        countAttributeLine++;
                        jsonAttribute = JsonConvert.SerializeObject(Arrtributes.ToArray());
                    }
                }
            }
            string strJsonContent = JsonConvert.SerializeObject(NamIdAttr.ToArray());
            strJsonContent = RemoveQuotationMarksAndBackslashes(strJsonContent);

            string urlOutput = Directory.GetCurrentDirectory() + @"\path2.json";
            File.WriteAllText(urlOutput, strJsonContent);
            return strJsonContent;
        }

        public static bool HasAttribute(string name)
        {
            if (name.IndexOf(" attr") != -1)
            {
                return true;
            }
            return false;
        }
        
        public static bool IsNextSame(string str1, string str2)
        {
            return str1 == str2;
        }
        
        public static string RemoveQuotationMarksAndBackslashes(string strJson)
        {
            strJson = strJson.Replace(@"\", "").Replace("\"[", "[").Replace("]\"", "]");
            strJson = strJson.Replace("\"mutable\":\"FALSE\"", "\"mutable\": false");
            strJson = strJson.Replace("\"mutable\":\"TRUE\"", "\"mutable\": true");
            return strJson;
        }
    }
    public class DataJson
    {
        public string name { get; set; }
        public int id { get; set; }
        public string attributes { get; set; }
    }
    public class DataJson2
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string mutable { get; set; }
        public string values { get; set; }
    }
}
