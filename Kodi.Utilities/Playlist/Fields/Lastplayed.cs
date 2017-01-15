using Kodi.Utilities.Attributes;
using Kodi.Utilities.Data;
using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Last Played Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocation("lastplayed",
        typeof(Duration),
        SmartPlayList.Types.Songs,
        SmartPlayList.Types.Movies,
        SmartPlayList.Types.Episodes,
        SmartPlayList.Types.MusicVideos,
        SmartPlayList.Types.Mixed)]
    public class LastPlayed : IRule
    { }
}