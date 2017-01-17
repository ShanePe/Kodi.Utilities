using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Playlist.Groups
{
    /// <summary>
    /// Represents none group
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IGroup" />
    public class None : IGroup
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public override string Name
        {
            get
            {
                return "none";
            }
        }
    }
}
