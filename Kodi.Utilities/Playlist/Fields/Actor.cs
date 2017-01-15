using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Actor Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocation("actor",
        typeof(string),
        SmartPlayList.Types.Movies,
        SmartPlayList.Types.TVShows,
        SmartPlayList.Types.Episodes,
        SmartPlayList.Types.Mixed)]
    public class Actor : IRule
    { }
}