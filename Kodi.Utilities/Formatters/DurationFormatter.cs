using Kodi.Utilities.Attributes;
using Kodi.Utilities.Data;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Operators;
using System;

namespace Kodi.Utilities.Formatters
{
    /// <summary>
    /// Handles duration fields
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IFormatter" />
    [FormatterType(typeof(Duration))]
    public class DurationFormatter : IFormatter
    {
        /// <summary>
        /// Gets the available operators.
        /// </summary>
        /// <returns></returns>
        public override IOperator[] GetAvailableOperators()
        {
            return new IOperator[]
            {
                new After(),
                new Before(),
                new InTheLast(),
                new NotInTheLast()
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

            Duration d = (Duration)value;
            return d.ToString();
        }

        /// <summary>
        /// Sets the value to the correct underlying type.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <exception cref="System.InvalidCastException"></exception>
        public override object SetToType(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new InvalidCastException();

            DateTime dt = DateTime.Now;

            if (DateTime.TryParse(value, out dt))
                return new Duration(dt);

            string[] parts = value.Split(' ');

            if (parts.Length != 2)
                throw new InvalidCastException();

            return new Duration(
                int.Parse(parts[0].Trim()),
                (Duration.Periods)Enum.Parse(typeof(Duration.Periods), parts[1].Trim(), true));
        }
    }
}
