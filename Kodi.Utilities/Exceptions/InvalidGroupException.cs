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
    /// Handles invalid group
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class InvalidGroupException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidGroupException"/> class.
        /// </summary>
        /// <param name="group">The group.</param>
        /// <param name="type">The type.</param>
        public InvalidGroupException(IGroup group, SmartPlayList.Types type)
            : base($"Field {group.FriendlyName} is not a valid group for playlist type {Enum.GetName(typeof(SmartPlayList.Types), type)}")
        { }
    }
}
