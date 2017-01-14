using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Playlist.Fields
{
    [FieldAllocationAttribute("year",
        typeof(int),
        SmartPlayList.Types.Songs,
SmartPlayList.Types.Albums,
SmartPlayList.Types.Movies,
SmartPlayList.Types.TVShows,
SmartPlayList.Types.Episodes,
SmartPlayList.Types.MusicVideos,
SmartPlayList.Types.Mixed)]
    public class Year : IRule
    { }
}