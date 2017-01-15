using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Status field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocation("status",
        typeof(string),
        SmartPlayList.Types.TVShows,
        SmartPlayList.Types.Mixed)]
    public class Status : IRule
    { }
}