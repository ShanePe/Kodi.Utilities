using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Playlist.Fields
{
    [FieldAllocationAttribute("album",
        typeof(string),
        SmartPlayList.Types.Albums,
        SmartPlayList.Types.Mixed,
        SmartPlayList.Types.MusicVideos,
        SmartPlayList.Types.Songs)]
    public class Album : IRule
    { }
}