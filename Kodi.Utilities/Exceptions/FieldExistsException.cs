using Kodi.Utilities.Interfaces;
using System;

namespace Kodi.Utilities.Exceptions
{
    /// <summary>
    /// Exception for duplicate rules on a playlist
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class FieldExistsException:Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldExistsException"/> class.
        /// </summary>
        /// <param name="rule">The rule.</param>
        public FieldExistsException(IRule rule)
            : base($"Field {rule.Field} is already assigned to playlist.") { }
    }
}
