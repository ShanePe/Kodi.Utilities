using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Exceptions
{
    /// <summary>
    /// Handles missing fields
    /// </summary>
    /// <seealso cref="System.Exception" />
    class MissingValueException : Exception
    {
        public MissingValueException(string missing, string on)
            : base($"Value '{missing}' is required on {on}")
        { }
    }
}
