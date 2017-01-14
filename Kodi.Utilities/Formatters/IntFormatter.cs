using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Formatters
{
    [FormatterTypeAttribute(typeof(int))]
    public class IntFormatter : IFormatter
    {
        public override string GetFormattedValue(object value)
        {
            int i = (int)value;
            return i.ToString();
        }
    }
}
