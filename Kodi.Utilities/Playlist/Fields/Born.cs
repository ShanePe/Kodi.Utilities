using System;
using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using static Kodi.Utilities.Attributes.ListTypeAllocationAttribute;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Represents the Born Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [ListTypeAllocation(AppliesTos.SmartPlaylist,
        SmartPlayList.Types.Artists)]
    public class Born : IRule
    {
        /// <summary>
        /// Gets the name of the field.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public override string Field { get { return "born"; } }

        /// <summary>
        /// Gets the underlying type of the field.
        /// </summary>
        /// <value>
        /// The underlying type.
        /// </value>
        public override Type UnderlyingType { get { return typeof(string); } }
		
    }
}