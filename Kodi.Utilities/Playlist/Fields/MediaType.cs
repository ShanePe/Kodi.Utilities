using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Media Type Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocation("type",
        typeof(string),
        SmartPlayList.Types.Albums,
        SmartPlayList.Types.Mixed)]
    public class MediaType : IRule
    { }
}