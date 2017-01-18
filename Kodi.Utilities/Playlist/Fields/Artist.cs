using System;
using Kodi.Utilities.Data;
using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Validators;
using static Kodi.Utilities.Attributes.ListTypeAllocationAttribute;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Represents the Artist Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [ListTypeAllocation(AppliesTos.SmartPlaylist,
        SmartPlayList.Types.Songs,
		SmartPlayList.Types.Albums,
		SmartPlayList.Types.Artists,
		SmartPlayList.Types.MusicVideos,
		SmartPlayList.Types.Mixed)]
	[ListTypeAllocation(AppliesTos.OrderBy,
		SmartPlayList.Types.Songs,
		SmartPlayList.Types.Albums,
		SmartPlayList.Types.Artists,
		SmartPlayList.Types.MusicVideos,
		SmartPlayList.Types.Mixed)]
    public class Artist : IRule
    {
        /// <summary>
        /// Gets the name of the field.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public override string Field { get { return "artist"; } }

        /// <summary>
        /// Gets the underlying type of the field.
        /// </summary>
        /// <value>
        /// The underlying type.
        /// </value>
        public override Type UnderlyingType { get { return typeof(string); } }
		
    }
}