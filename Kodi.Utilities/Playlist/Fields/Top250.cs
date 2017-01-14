using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Playlist.Fields
{
    [FieldAllocationAttribute("top250",
        SmartPlayList.Types.Albums,
        SmartPlayList.Types.Episodes,
        SmartPlayList.Types.Mixed,
        SmartPlayList.Types.Movies,
        SmartPlayList.Types.MusicVideos,
        SmartPlayList.Types.Songs,
        SmartPlayList.Types.TVShows)]
    public class Top250 : IRule
    { }
}