using System;
using Kodi.Utilities.Data;
using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Validators;
using static Kodi.Utilities.Attributes.ListTypeAllocationAttribute;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Represents the Year Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [ListTypeAllocation(AppliesTos.SmartPlaylist,
        SmartPlayList.Types.Songs,
		SmartPlayList.Types.Albums,
		SmartPlayList.Types.Movies,
		SmartPlayList.Types.TVShows,
		SmartPlayList.Types.Episodes,
		SmartPlayList.Types.MusicVideos,
		SmartPlayList.Types.Mixed)]
	[ListTypeAllocation(AppliesTos.OrderBy,
		SmartPlayList.Types.Songs,
		SmartPlayList.Types.Albums,
		SmartPlayList.Types.Movies,
		SmartPlayList.Types.TVShows,
		SmartPlayList.Types.Episodes,
		SmartPlayList.Types.MusicVideos,
		SmartPlayList.Types.Mixed)]
    public class Year : IRule
    {
        /// <summary>
        /// Gets the name of the field.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public override string Field { get { return "year"; } }

        /// <summary>
        /// Gets the underlying type of the field.
        /// </summary>
        /// <value>
        /// The underlying type.
        /// </value>
        public override Type UnderlyingType { get { return typeof(int); } }
				/// <summary>
        /// Gets a value indicating whether this instance is allowed multiple values.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is allowed multiple values ; otherwise, <c>false</c>.
        /// </value>
        public override bool IsMultipleValuesAllowed { get { return true; } }
		
		/// <summary>
        /// Gets the validator.
        /// </summary>
        /// <value>
        /// The validator.
        /// </value>
        public override IValidator Validator { get { return new PositiveIntValidator(); } }

    }
}