using System;

namespace Kodi.Utilities.Exceptions
{
    /// <summary>
    /// Handles invalid time formatting
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class InvalidTimeFormatException : Exception
    {
        public InvalidTimeFormatException(string got)
            : base($"Invalid time format, supported formats (X min,hh:mm:ss) got {got}")
        {
        }
    }
}
