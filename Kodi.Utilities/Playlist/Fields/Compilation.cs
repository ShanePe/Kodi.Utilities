using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Playlist.Fields
{
    [FieldAllocation("compilation",
       typeof(bool),
       SmartPlayList.Types.Albums)]
    public class Compilation : IRule
    {
    }
}
