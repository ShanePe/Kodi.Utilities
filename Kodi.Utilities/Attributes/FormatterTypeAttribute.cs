using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// <param name="underlyingType">Type of the underlying.</param>
        public FormatterTypeAttribute(Type underlyingType)
        {
            _underlyingType = underlyingType;
        }

        /// <summary>
        /// Gets the type of the underlying.
        /// </summary>
        /// <value>
        /// The type of the underlying.
        /// </value>
        public Type UnderlyingType
        {
            get { return _underlyingType; }
        }
    }
}
