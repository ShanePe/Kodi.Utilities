using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Operators;

namespace Kodi.Utilities.Formatters
{
    /// <summary>
    /// Handles double fields
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IFormatter" />
    [FormatterType(typeof(double))]
    public class DoubleFormatter : IFormatter
    {
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

            double d = (double)value;
            return d.ToString();
        }

        /// <summary>
        /// Sets the value to the correct underlying type.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public override object SetToType(string value)
        {
            if (string.IsNullOrEmpty(value))
                return new double();

            return double.Parse(value);

        }
    }
}
