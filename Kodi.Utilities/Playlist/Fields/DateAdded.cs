using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Date Time Added Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocationAttribute("dateadded",
        typeof(DateTime),
        SmartPlayList.Types.Movies)]
    public class DateAdded : IRule
    { }
}