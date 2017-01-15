using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Validators;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Rating Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocation("rating",
        typeof(int),
        SmartPlayList.Types.Songs,
        SmartPlayList.Types.Albums,
        SmartPlayList.Types.Movies,
        SmartPlayList.Types.TVShows,
        SmartPlayList.Types.Episodes,
        SmartPlayList.Types.Mixed)]
    public class Rating : IRule
    {
        public override IValidator Validator
        {
            get
            {
                return new RatingValidator();
            }
        }
    }
}