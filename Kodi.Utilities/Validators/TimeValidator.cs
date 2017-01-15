using Kodi.Utilities.Exceptions;
using Kodi.Utilities.Interfaces;
using System;
using System.Globalization;

namespace Kodi.Utilities.Validators
{
    public class TimeValidator : IValidator
    {
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
