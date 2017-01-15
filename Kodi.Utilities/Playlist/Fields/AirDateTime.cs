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
    /// Air Date Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocationAttribute("airdatetime",
        typeof(DateTime),
        SmartPlayList.Types.Episodes,
        SmartPlayList.Types.Mixed)]
    public class AirDateTime : IRule
    { }
}