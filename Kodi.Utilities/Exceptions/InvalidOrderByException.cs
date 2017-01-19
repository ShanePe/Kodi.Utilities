using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Playlist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Exceptions
{
    /// <summary>
    /// Handles invalid order by on playlist
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class InvalidOrderByException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidOrderByException"/> class.
        /// </summary>
        /// <param name="field">The field.</param>
        /// <param name="type">The type.</param>
        public InvalidOrderByException(IRule field, SmartPlayList.Types type)
            : base($"Field {field.FriendlyName} is not a valid order by for playlist type {Enum.GetName(typeof(SmartPlayList.Types), type)}")
        {  }
    }
}
