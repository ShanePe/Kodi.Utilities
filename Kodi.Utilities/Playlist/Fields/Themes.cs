using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Themes Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocation("themes",
        typeof(string),
        SmartPlayList.Types.Albums,
        SmartPlayList.Types.Mixed)]
    public class Themes : IRule
    { }
}