using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Formatters
{
    [FormatterTypeAttribute(typeof(bool))]
    public class BoolFormatter : IFormatter
    {
        public override IOperator[] GetAvailableOperators()
        {
            return new IOperator[]
            {
                new True(),
                new False()
            };
        }

        public override string GetFormattedValue(object value)
        {
            bool bo = (bool)value;
            return bo.ToString().ToLower();
        }
    }
}
