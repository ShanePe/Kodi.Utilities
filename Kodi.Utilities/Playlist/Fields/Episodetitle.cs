using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Episode Fields
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocation("episodetitle",
        typeof(string),
        SmartPlayList.Types.Episodes,
        SmartPlayList.Types.Mixed)]
    public class EpisodeTitle : IRule
    { }
}