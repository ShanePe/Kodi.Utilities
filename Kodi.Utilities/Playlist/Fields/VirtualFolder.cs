﻿using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Virtual Folder Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocationAttribute("virtualfolder",
        typeof(string),
        SmartPlayList.Types.Songs,
        SmartPlayList.Types.Albums,
        SmartPlayList.Types.Artists,
        SmartPlayList.Types.Movies,
        SmartPlayList.Types.TVShows,
        SmartPlayList.Types.Episodes,
        SmartPlayList.Types.MusicVideos,
        SmartPlayList.Types.Mixed)]
    public class VirtualFolder : IRule
    {
    }
}
