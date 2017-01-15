using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Playlist.Fields
{
    [FieldAllocation("userrating",
        typeof(double),
        SmartPlayList.Types.Songs,
        SmartPlayList.Types.Albums,
        SmartPlayList.Types.TVShows,
        SmartPlayList.Types.Episodes,
        SmartPlayList.Types.Movies,
        SmartPlayList.Types.MusicVideos)]
    public class UserRating:IRule
    {
    }
}
