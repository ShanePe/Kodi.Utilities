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
    /// Role Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocationAttribute("role",
        typeof(string),
        SmartPlayList.Types.Artists)]
    public class Role : IRule
    {
    }
}
