using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Playlist.Fields
{
    [FieldAllocationAttribute("actor",
        typeof(string),
        SmartPlayList.Types.Movies,
SmartPlayList.Types.TVShows,
SmartPlayList.Types.Episodes,
SmartPlayList.Types.Mixed)]
    public class Actor : IRule
    { }
}