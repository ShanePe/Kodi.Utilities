using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Playlist.Fields
{
    [FieldAllocationAttribute("airdate",
        typeof(DateTime),
        SmartPlayList.Types.Mixed,
        SmartPlayList.Types.TVShows)]
    public class AirDate : IRule
    { }
}