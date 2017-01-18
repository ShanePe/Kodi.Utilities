using System;
using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Operators;

namespace Kodi.Utilities.Formatters
{
    /// <summary>
    /// Handles Text Fields.
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IFormatter" />
    public class StringFormatter : IFormatter
    {
        /// <summary>
        /// Gets the underlying type.
        /// </summary>
        /// <value>
        /// The underlying type.
        /// </value>
        public override Type UnderlyingType { get { return typeof(string); } }

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
            if (value == null)
                return string.Empty;

            return value.ToString();
        }

        public override object SetToType(string value)
        {
            if (string.IsNullOrEmpty(value))
                return string.Empty;

            return value.ToString();
        }
    }
}
