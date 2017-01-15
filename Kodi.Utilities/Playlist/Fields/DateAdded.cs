using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using System;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Date Time Added Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocation("dateadded",
        typeof(DateTime),
        SmartPlayList.Types.Movies)]
    public class DateAdded : IRule
    { }
}