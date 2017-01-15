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
    /// Audio Count Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocationAttribute("audiocount",
        typeof(int),
        SmartPlayList.Types.Movies,
        SmartPlayList.Types.Episodes,
        SmartPlayList.Types.MusicVideos,
        SmartPlayList.Types.Mixed)]
    public class AudioCount : IRule
    {
    }
}
