using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using System;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Air Date Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocation("airdate",
        typeof(DateTime),
        SmartPlayList.Types.Episodes,
        SmartPlayList.Types.Mixed)]
    public class AirDate : IRule
    { }
}