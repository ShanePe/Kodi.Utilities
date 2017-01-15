using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Tag field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocationAttribute("tag",
        typeof(string),
        SmartPlayList.Types.Movies,
        SmartPlayList.Types.TVShows,
        SmartPlayList.Types.MusicVideos,
        SmartPlayList.Types.Mixed)]
    public class Tag : IRule
    { }
}