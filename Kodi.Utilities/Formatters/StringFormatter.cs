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
    /// <summary>
    /// Handles Text Fields.
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IFormatter" />
    [FormatterTypeAttribute(typeof(string))]
    public class StringFormatter : IFormatter
    {
        /// <summary>
        /// Gets the available operators.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the formatted value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public override string GetFormattedValue(object value)
        {
            return value.ToString();
        }
    }
}
