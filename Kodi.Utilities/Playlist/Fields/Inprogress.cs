using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Playlist.Fields
{
    [FieldAllocationAttribute("inprogress",
        typeof(bool),
        SmartPlayList.Types.Movies,
SmartPlayList.Types.Episodes,
SmartPlayList.Types.Mixed)]
    public class Inprogress : IRule
    { }
}