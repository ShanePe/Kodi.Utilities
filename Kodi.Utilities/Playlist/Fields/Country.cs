using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Country Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocation("country",
        typeof(string),
        SmartPlayList.Types.Movies,
        SmartPlayList.Types.Mixed)]
    public class Country : IRule
    { }
}