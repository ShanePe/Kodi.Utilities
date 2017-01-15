using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Playlist.Fields
{
    [FieldAllocationAttribute("tagline",
        typeof(string),
        SmartPlayList.Types.Movies,
        SmartPlayList.Types.Mixed)]
    public class Tagline : IRule
    { }
}