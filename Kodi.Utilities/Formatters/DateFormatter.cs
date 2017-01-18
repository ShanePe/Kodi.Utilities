using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Operators;
using System;
using System.Globalization;

namespace Kodi.Utilities.Formatters
{
    /// <summary>
    /// Handles Date Fields
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IFormatter" />
    public class DateFormatter : IFormatter
    {
        private const string _format = "yyyy-MM-dd";

        /// <summary>
        /// Gets the underlying type.
        /// </summary>
        /// <value>
        /// The underlying type.
        /// </value>
        public override Type UnderlyingType { get { return typeof(DateTime); } }
        
        /// <summary>
        /// Gets the available operators.
        /// </summary>
        /// <returns></returns>
        public override IOperator[] GetAvailableOperators()
        {
            return new IOperator[]
            {
                new After(),
                new Before()
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

            DateTime date = (DateTime)value;
            return date.ToString(_format);
        }

        /// <summary>
        /// Sets the value to the correct underlying type.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public override object SetToType(string value)
        {
            DateTime dt = DateTime.Now;

            if (!DateTime.TryParseExact(value, _format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
                throw new Exceptions.InvalidFieldTypeValue(typeof(DateTime));

            return dt;
        }
    }
}
