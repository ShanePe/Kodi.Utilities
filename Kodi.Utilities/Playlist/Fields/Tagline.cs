using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Tag line field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocation("tagline",
        typeof(string),
        SmartPlayList.Types.Movies,
        SmartPlayList.Types.Mixed)]
    public class Tagline : IRule
    { }
}