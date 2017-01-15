using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Playlist.Fields
{
    [FieldAllocationAttribute("comment",
        typeof(string),
        SmartPlayList.Types.Songs,
        SmartPlayList.Types.Mixed)]
    public class Comment : IRule
    { }
}