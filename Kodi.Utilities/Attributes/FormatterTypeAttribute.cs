using System;

namespace Kodi.Utilities.Attributes
{
    /// <summary>
    /// Defines the type of data for the formatter
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [System.AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class FormatterTypeAttribute : Attribute
    {
        readonly Type _underlyingType;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="FormatterTypeAttribute"/> class.
        /// </summary>
        /// <param name="underlyingType">The underlying type.</param>
        public FormatterTypeAttribute(Type underlyingType)
        {
            _underlyingType = underlyingType;
        }


        /// <summary>
        /// Gets the underlying type.
        /// </summary>
        /// <value>
        /// The underlying type.
        /// </value>
        public Type UnderlyingType
        {
            get { return _underlyingType; }
        }
    }
}
