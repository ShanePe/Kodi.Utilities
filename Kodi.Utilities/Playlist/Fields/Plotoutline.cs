using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Plot outline field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocation("plotoutline",
        typeof(string),
        SmartPlayList.Types.Movies,
        SmartPlayList.Types.Mixed)]
    public class PlotOutline : IRule
    { }
}