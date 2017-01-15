﻿using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            : base($"Field {rule.Name} is already assigned to playlist.") { }
    }
}
