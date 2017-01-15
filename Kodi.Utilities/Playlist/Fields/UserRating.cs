using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Playlist.Fields
{
    [FieldAllocationAttribute("userrating",
        typeof(string),
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
