﻿using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Formatters
{
    [FormatterTypeAttribute(typeof(string))]
    class StringFormatter : IFormatter
    {
        public override string GetFormattedValue(object value)
        {
            return value.ToString();
        }
    }
}
