using System;

namespace Kodi.Utilities.Exceptions
{
    /// <summary>
    /// Exception to handle an invalid type.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class InvalidTypeException : NotSupportedException
    {
        public InvalidTypeException(string got, Type expected)
           : base($"Invalid type for field got : {got} for type {expected.ToString()}")
        {
        }
    }
}
