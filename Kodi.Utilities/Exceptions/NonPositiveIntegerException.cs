using System;

namespace Kodi.Utilities.Exceptions
{
    /// <summary>
    /// Exception to handle non positive integer
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class NonPositiveIntegerException : Exception
    {
        public NonPositiveIntegerException()
         : base("Number needs to be positive (greater or equal to zero)")
        { }
    }
}
