using System;
using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Operators;

namespace Kodi.Utilities.Formatters
{
    /// <summary>
    /// Handles number fields
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IFormatter" />
    public class IntegerFormatter : IFormatter
    {
        /// <summary>
        /// Gets the underlying type.
        /// </summary>
        /// <value>
        /// The underlying type.
        /// </value>
        public override Type UnderlyingType { get { return typeof(int); } }

        /// <summary>
        /// Gets the available operators.
        /// </summary>
        /// <returns></returns>
        public override IOperator[] GetAvailableOperators()
        {
            return new IOperator[]
            {
                new Is(),
                new IsNot(),
                new GreaterThan(),
                new LessThan()
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

            int i = (int)value;
            return i.ToString();
        }

        /// <summary>
        /// Sets the value to the correct underlying type.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public override object SetToType(string value)
        {
            if (string.IsNullOrEmpty(value))
                return new int();

            return int.Parse(value.Trim());
        }
    }
}
