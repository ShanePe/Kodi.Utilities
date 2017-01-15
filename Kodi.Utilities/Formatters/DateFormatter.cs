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
    [FormatterTypeAttribute(typeof(DateTime))]
    public class DateFormatter : IFormatter
    {
        public override IOperator[] GetAvailableOperators()
        {
            return new IOperator[]
            {
                new After(),
                new Before()
            };
        }

        public override string GetFormattedValue(object value)
        {
            DateTime date = (DateTime)value;
            return date.ToString("dd MM yyyy");
        }
    }
}
