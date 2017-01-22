using Kodi.Utilities.Exceptions;
using Kodi.Utilities.Interfaces;
using System;
using System.Globalization;

namespace Kodi.Utilities.Validators
{
    /// <summary>
    /// Validates that the time is in either x min or hh:mm:ss
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IValidator" />
    public class TimeValidator : IValidator
    {
        /// <summary>
        /// Validates the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <exception cref="InvalidTypeException"></exception>
        /// <exception cref="InvalidTimeFormatException">
        /// </exception>
        public void Validate(object value)
        {
            //Supported formats : X min, hh:mm:ss

            if (value == null)
                return;

            if (!(value is string))
                throw new InvalidTypeException(value.ToString(), typeof(string));

            string time = (string)value;
            if (time.EndsWith(" min", StringComparison.OrdinalIgnoreCase))
            {
                int min;
                if (!int.TryParse(time.ToLower().Replace(" min", string.Empty), out min))
                    throw new InvalidTimeFormatException(time);

                PositiveIntValidator natNumberVal = new PositiveIntValidator();
                natNumberVal.Validate(min);
            }
            else
            {
                string[] formats = new string[] { "hh:mm:ss", "HH:mm:ss" };
                DateTime tester;
                bool valid = false;

                for (int i = 0; i < formats.Length; i++)
                {
                    valid = DateTime.TryParseExact(time, formats[i], CultureInfo.InvariantCulture, DateTimeStyles.None, out tester);
                    if (valid)
                        break;
                }
                if (!valid)
                    throw new InvalidTimeFormatException(time);
            }
        }
    }
}
