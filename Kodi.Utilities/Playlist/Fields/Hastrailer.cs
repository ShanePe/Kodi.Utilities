using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Has Trailer Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocation("hastrailer",
        typeof(bool),
        SmartPlayList.Types.Movies,
        SmartPlayList.Types.Mixed)]
    public class HasTrailer : IRule
    { }
}