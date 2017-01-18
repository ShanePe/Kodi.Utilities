using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Operators;
using System;

namespace Kodi.Utilities.Formatters
{
    /// <summary>
    /// Handles boolean fields
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IFormatter" />
    public class BoolFormatter : IFormatter
    {
        /// <summary>
        /// Gets the underlying type.
        /// </summary>
        /// <value>
        /// The underlying type.
        /// </value>
        public override Type UnderlyingType { get { return typeof(bool); } }

        /// <summary>
        /// Gets the available operators.
        /// </summary>
        /// <returns></returns>
        public override IOperator[] GetAvailableOperators()
        {
            return new IOperator[]
            {
                new True(),
                new False()
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

            bool bo = (bool)value;
            return bo.ToString().ToLower();
        }

        /// <summary>
        /// Sets the value to the correct underlying type.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public override object SetToType(string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            bool ret = false;

            if (Boolean.TryParse(value, out ret))
                return ret;

            switch (value.ToLower().Trim())
            {
                case "true":
                case "1":
                case "yes":
                    return true;
                case "false":
                case "0":
                case "no":
                    return false;
                default: throw new InvalidCastException($"'{value}' is not a valid boolean,");
            }
        }
    }
}
