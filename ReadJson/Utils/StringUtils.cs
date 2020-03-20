using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadJson.Utils
{
    class StringUtils
    {
        public static string ConvertTop1Mid0Bot_1(string s)
        {
            if (s.Equals("top"))
            {
                return "1";
            }
            if (s.Equals("middle"))
            {
                return "0";
            }
            if (s.Equals("bottom"))
            {
                return "-1";
            }
            return "0";
        }
        public static string ConvertYes1No0(string s)
        {
            if (s.Equals("yes"))
            {
                return "1";
            }
            else if (s.Equals("no"))
            {
                return "0";
            }
            return "0";
        }

    }
}
