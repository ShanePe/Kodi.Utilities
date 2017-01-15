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
    /// Episode Number Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocationAttribute("numepisodes",
        typeof(int),
        SmartPlayList.Types.TVShows,
        SmartPlayList.Types.Mixed)]
    public class NumEpisodes : IRule
    {
        public override string FriendlyName
        {
            get
            {
                return "Number of episodes";
            }
        }
    }
}