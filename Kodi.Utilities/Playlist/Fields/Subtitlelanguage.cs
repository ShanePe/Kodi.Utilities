using System;
using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using static Kodi.Utilities.Attributes.ListTypeAllocationAttribute;
using Kodi.Utilities.Data;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Represents the SubtitleLanguage Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [ListTypeAllocation(AppliesTos.SmartPlaylist,
        SmartPlayList.Types.Movies,
		SmartPlayList.Types.Episodes,
		SmartPlayList.Types.MusicVideos,
		SmartPlayList.Types.Mixed)]
    public class SubtitleLanguage : IRule
    {
        /// <summary>
        /// Gets the name of the field.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public override string Field { get { return "subtitlelanguage"; } }

        /// <summary>
        /// Gets the underlying type of the field.
        /// </summary>
        /// <value>
        /// The underlying type.
        /// </value>
        public override Type UnderlyingType { get { return typeof(ISO6392Language); } }
		
    }
}