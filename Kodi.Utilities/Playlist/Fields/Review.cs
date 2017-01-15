using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Review Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocation("review",
        typeof(string),
        SmartPlayList.Types.Albums,
        SmartPlayList.Types.Mixed)]
    public class Review : IRule
    { }
}