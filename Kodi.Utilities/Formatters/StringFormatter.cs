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
    [FormatterTypeAttribute(typeof(string))]
    public class StringFormatter : IFormatter
    {
        public override IOperator[] GetAvailableOperators()
        {
            return new IOperator[]
            {
                new Contains(),
                new DoesNotContain(),
                new StartsWith(),
                new EndsWith(),
                new Is(),
                new IsNot()
            };
        }

        public override string GetFormattedValue(object value)
        {
            return value.ToString();
        }
    }
}
