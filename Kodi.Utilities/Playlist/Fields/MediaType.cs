using System;
using Kodi.Utilities.Data;
using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Validators;
using static Kodi.Utilities.Attributes.ListTypeAllocationAttribute;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Represents the MediaType Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [ListTypeAllocation(AppliesTos.SmartPlaylist,
        SmartPlayList.Types.Albums,
		SmartPlayList.Types.Mixed)]
	[ListTypeAllocation(AppliesTos.OrderBy,
		SmartPlayList.Types.Albums)]
    public class MediaType : IRule
    {
        /// <summary>
        /// Gets the name of the field.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public override string Field { get { return "mediatype"; } }

        /// <summary>
        /// Gets the underlying type of the field.
        /// </summary>
        /// <value>
        /// The underlying type.
        /// </value>
        public override Type UnderlyingType { get { return typeof(string); } }
		
    }
}