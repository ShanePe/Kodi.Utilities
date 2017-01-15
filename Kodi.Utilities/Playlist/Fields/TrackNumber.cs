using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Validators;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Track number field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocation("tracknumber",
        typeof(int),
        SmartPlayList.Types.Songs,
        SmartPlayList.Types.Mixed)]
    public class TrackNumber : IRule
    {
        public override IValidator Validator
        {
            get
            {
                return new PositiveIntValidator();
            }
        }
    }
}