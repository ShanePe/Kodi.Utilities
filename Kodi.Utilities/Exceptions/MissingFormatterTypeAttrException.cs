using System;

namespace Kodi.Utilities.Exceptions
{
    /// <summary>
    /// Exception for when the formatter does not have the <see cref="FormatterTypeAttribute"/>
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class MissingFormatterTypeAttrException : Exception
    {
        public MissingFormatterTypeAttrException(Type type)
            : base($"Could not find the FormatterTypeAttribute for {type.ToString()}")
        { }
    }
}
