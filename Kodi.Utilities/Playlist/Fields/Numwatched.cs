using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Validators;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Num Watch Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocation("numwatched",
        typeof(int),
        SmartPlayList.Types.TVShows,
        SmartPlayList.Types.Mixed)]
    public class NumWatched : IRule
    {
        public override string FriendlyName
        {
            get
            {
                return "Number of watched episodes";
            }
        }

        public override IValidator Validator
        {
            get
            {
                return new PositiveIntValidator();
            }
        }
    }
}