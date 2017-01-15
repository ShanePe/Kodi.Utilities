using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Playlist.Fields
{
    [FieldAllocationAttribute("status",
        typeof(string),
        SmartPlayList.Types.TVShows,
        SmartPlayList.Types.Mixed)]
    public class Status : IRule
    { }
}