using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Label Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocation("label",
        typeof(string),
        SmartPlayList.Types.Albums,
        SmartPlayList.Types.Mixed)]
    public class Label : IRule
    { }
}