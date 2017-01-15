using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Comment Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocation("comment",
        typeof(string),
        SmartPlayList.Types.Songs,
        SmartPlayList.Types.Mixed)]
    public class Comment : IRule
    { }
}