﻿using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Virtual Folder Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocation("virtualfolder",
        typeof(string),
        true,
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
