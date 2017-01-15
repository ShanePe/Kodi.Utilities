using Kodi.Utilities.Attributes;
using Kodi.Utilities.Data;
using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Playlist.Fields
{
    [FieldAllocationAttribute("subtitlelanguage",
        typeof(ISO6392Language),
        SmartPlayList.Types.Movies,
        SmartPlayList.Types.Episodes,
        SmartPlayList.Types.MusicVideos,
        SmartPlayList.Types.Mixed)]
    public class SubtitleLanguage : IRule
    { }
}