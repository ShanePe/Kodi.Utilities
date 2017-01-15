using Kodi.Utilities.Attributes;
using Kodi.Utilities.Data;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Operators;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Formatters
{
    [FormatterTypeAttribute(typeof(ISO6392Language))]
    public class LanguageFormatter : IFormatter
    {
        public override IOperator[] GetAvailableOperators()
        {
            return new IOperator[]
            {
                new Is(),
                new IsNot()
            };
        }

        public override string GetFormattedValue(object value)
        {
            ISO6392Language cult = (ISO6392Language)value;
            return cult.Code;
        }
    }
}
