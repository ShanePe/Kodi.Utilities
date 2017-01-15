using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Exceptions
{

    /// <summary>
    /// Exception for when the field does not have the <see cref="FieldAllocationAttribute"/> 
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class MissingFieldAttributeException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MissingFieldAttributeException"/> class.
        /// </summary>
        /// <param name="rule">The rule.</param>
        public MissingFieldAttributeException(IRule rule)
            : base($"Missing field allocation attribute on field {nameof(IRule)}") { }
    }
}
