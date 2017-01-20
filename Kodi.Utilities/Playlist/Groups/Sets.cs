using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Playlist.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kodi.Utilities.Attributes.ListTypeAllocationAttribute;

namespace Kodi.Utilities.Playlist.Groups
{
    /// <summary>
    /// Represents groups set
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IGroup" />
    [ListTypeAllocation(AppliesTos.Group,
        SmartPlayList.Types.Movies)]
    public class Sets : IGroup
    {
        /// <summary>
        /// Gets the name.
        /// </summary>S
        /// <value>
        /// The name.
        /// </value>
        public override string Name { get { return "sets"; } }

        /// <summary>
        /// Gets a value indicating whether [allow mixed].
        /// </summary>
        /// <value>
        /// <c>true</c> if [allow mixed]; otherwise, <c>false</c>.
        /// </value>
        public override bool AllowMixed { get { return true; } }
    }
}
