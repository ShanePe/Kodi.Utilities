using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Validators;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Subtitle Count Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocation("subtitlecount",
        typeof(int),
        SmartPlayList.Types.Movies,
        SmartPlayList.Types.Episodes,
        SmartPlayList.Types.MusicVideos,
        SmartPlayList.Types.Mixed)]
    public class SubtitleCount : IRule
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
