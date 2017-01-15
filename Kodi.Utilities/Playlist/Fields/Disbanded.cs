using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Disbanded field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocation("disbanded",
        typeof(string),
        SmartPlayList.Types.Artists)]
    public class Disbanded : IRule
    { }
}