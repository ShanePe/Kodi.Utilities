using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Validators;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Episode Number Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocation("numepisodes",
        typeof(int),
        SmartPlayList.Types.TVShows,
        SmartPlayList.Types.Mixed)]
    public class NumEpisodes : IRule
    {
        public override string FriendlyName
        {
            get
            {
                return "Number of episodes";
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