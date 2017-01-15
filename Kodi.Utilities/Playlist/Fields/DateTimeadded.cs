using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Playlist.Fields
{
    [FieldAllocationAttribute("datetimeadded",
        typeof(DateTime),
        SmartPlayList.Types.Movies)]
    public class DateTimeAdded : IRule
    { }
}