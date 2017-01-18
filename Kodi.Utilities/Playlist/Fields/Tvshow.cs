using System;
using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using static Kodi.Utilities.Attributes.ListTypeAllocationAttribute;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Represents the TVShow Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [ListTypeAllocation(AppliesTos.SmartPlaylist,
        SmartPlayList.Types.TVShows,
		SmartPlayList.Types.Episodes,
		SmartPlayList.Types.Mixed)]
    public class TVShow : IRule
    {
        /// <summary>
        /// Gets the name of the field.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public override string Field { get { return "tvshow"; } }

        /// <summary>
        /// Gets the underlying type of the field.
        /// </summary>
        /// <value>
        /// The underlying type.
        /// </value>
        public override Type UnderlyingType { get { return typeof(string); } }
				/// <summary>
        /// Gets a value indicating whether this instance is allowed multiple values.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is allowed multiple values ; otherwise, <c>false</c>.
        /// </value>
        public override bool IsMultipleValuesAllowed { get { return true; } }

    }
}