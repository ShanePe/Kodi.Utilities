using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kodi.Utilities.Attributes.ListTypeAllocationAttribute;

namespace Kodi.Utilities.Playlist.Groups
{
    /// <summary>
    /// Represents Tags Group
    /// </summary>  
    /// <seealso cref="Kodi.Utilities.Interfaces.IGroup" />
    [ListTypeAllocation(AppliesTos.Group,
        SmartPlayList.Types.MusicVideos,
        SmartPlayList.Types.Movies,
        SmartPlayList.Types.TVShows)]
    public class Tags : IGroup
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public override string Name { get { return "tags"; } }
    }
}
