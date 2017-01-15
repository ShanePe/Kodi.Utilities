using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kodi.Utilities.Extensions
{
    public static class String
    {
        public static string SplitCamel(this string str)
        {
            return Regex.Replace(str, "([A-Z])", " $1").Trim();
        }

        public static string ToTitleCase(this string str)
        {
            if (str.Length == 1)
                return str.ToUpper();
            else
                return string.Concat(str.Remove(1).ToUpper(), str.Substring(1));
        }
    }
}
