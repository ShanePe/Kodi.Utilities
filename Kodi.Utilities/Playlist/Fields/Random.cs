using System;
using Kodi.Utilities.Data;
using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Validators;
using static Kodi.Utilities.Attributes.ListTypeAllocationAttribute;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Represents the Random Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [ListTypeAllocation(AppliesTos.OrderBy,
        SmartPlayList.Types.Songs,
        SmartPlayList.Types.Albums,
        SmartPlayList.Types.Artists,
        SmartPlayList.Types.Movies,
        SmartPlayList.Types.TVShows,
        SmartPlayList.Types.Episodes,
        SmartPlayList.Types.MusicVideos,
        SmartPlayList.Types.Mixed)]
    public class Random : IRule
    {
        /// <summary>
        /// Gets the name of the field.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public override string Field { get { return "random"; } }

        /// <summary>
        /// Gets the underlying type of the field.
        /// </summary>
        /// <value>
        /// The underlying type.
        /// </value>
        public override Type UnderlyingType { get { return typeof(string); } }

    }
}