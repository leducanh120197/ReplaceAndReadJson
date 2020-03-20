using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadJson.Utils
{
    class JsonUtils
    {
        public static string GetJsonStringFromFile(string jsonFile)
        {
            string dataJson = null;
            try
            {
                StreamReader r = new StreamReader(jsonFile);
                dataJson = r.ReadToEnd();
                r.Close();
            }
            catch (System.IO.FileNotFoundException) //not able to catch the exception?
            {
                Console.WriteLine("System.IO.FileNotFoundException");
            }
            return dataJson;
        }

        public static JArray GetJsonArrayFromFile(string filepath)
        {
            using (FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            {
                StreamReader reader = new StreamReader(fs);
                string strContent = reader.ReadToEnd();
                JArray obj = JArray.Parse(strContent);
                return obj;
            }
        }

        public static JObject GetJsonObjectFromFile(string filepath)
        {
            using (FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            {
                StreamReader reader = new StreamReader(fs);
                string strContent = reader.ReadToEnd();
                JObject obj = JObject.Parse(strContent);
                return obj;
            }
        }

        public static JToken GetClassInRegions(JToken regions, string className)
        {
            foreach (JToken region in regions)
            {//                                             points
                if (((string)(region["class"])).Equals(className))
                {
                    return region;
                }
            }
            return null;
        }

        public static string GetTagData(string key, JToken tags)
        {
            try
            {
                foreach (JToken j in tags)
                {

                    if (((string)j).Contains(key))
                    {
                        return (string)j;
                    }
                }
                return "ERROR: this key " + key + " is NOT existed";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return "ERROR:";
        }

        public static void SetJsonStringToFile(string jsonFile)
        {
            using (var streamWriter = new StreamWriter(jsonFile))
            using (var writer = new JsonTextWriter(streamWriter))
            {
                writer.Formatting = Formatting.Indented;

                writer.WriteStartArray();
                {
                    writer.WriteStartObject();
                    {
                        writer.WritePropertyName("foo");
                        writer.WriteValue(1);
                        writer.WritePropertyName("bar");
                        writer.WriteValue(2.3);
                    }
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();
            }

        }
        
        public static int dequy (int n)
        {
            int tong = 0;
            if(n <= 0) {
                return 0;
            }
            else
            {
                tong = n + dequy(n-1);
                return tong;
            }
        }

    }
}
