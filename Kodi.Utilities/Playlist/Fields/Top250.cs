using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Top 250 field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocation("top250",
        typeof(int),
        SmartPlayList.Types.Movies,
        SmartPlayList.Types.Mixed)]
    public class Top250 : IRule
    { }
}