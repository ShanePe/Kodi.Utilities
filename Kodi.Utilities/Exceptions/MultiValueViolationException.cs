using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Exceptions
{
    /// <summary>
    /// Handles multiple values for rule violation.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class MultiValueViolationException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiValueViolationException"/> class.
        /// </summary>
        /// <param name="rule">The rule.</param>
        public MultiValueViolationException(IRule rule)
            : base($"Rule {rule.FriendlyName} does not allow multiple values.")
        { }
    }
}
