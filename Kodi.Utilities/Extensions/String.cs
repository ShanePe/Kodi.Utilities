using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kodi.Utilities.Extensions
{
    /// <summary>
    /// Holder to string extension methods.
    /// </summary>
    public static class String
    {
        /// <summary>
        /// Splits the to words based on the camel case.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        public static string SplitCamel(this string str)
        {
            return Regex.Replace(str, "([A-Z])", " $1").Trim();
        }

        /// <summary>
        /// Makes the first letter of the string upper case.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        public static string ToTitleCase(this string str)
        {
            if (str.Length == 1)
                return str.ToUpper();
            else
                return string.Concat(str.Remove(1).ToUpper(), str.Substring(1));
        }
    }
}
