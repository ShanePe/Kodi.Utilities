using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Playlist.Fields
{
    [FieldAllocationAttribute("artist",
        typeof(string),
        SmartPlayList.Types.Songs,
SmartPlayList.Types.Albums,
SmartPlayList.Types.Artists,
SmartPlayList.Types.MusicVideos,
SmartPlayList.Types.Mixed)]
    public class Artist : IRule
    { }
}