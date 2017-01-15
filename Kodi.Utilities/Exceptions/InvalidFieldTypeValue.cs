using System;

namespace Kodi.Utilities.Exceptions
{
    /// <summary>
    /// If field type does not match underlying field type.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class InvalidFieldTypeValue : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidFieldTypeValue"/> class.
        /// </summary>
        /// <param name="rule">The rule.</param>
        /// <param name="type">The type.</param>
        /// <param name="fieldName">Name of the field.</param>
        public InvalidFieldTypeValue(Type type)
            : base($"Invalid type for field expected {type.ToString()}")
        { }
    }
}
