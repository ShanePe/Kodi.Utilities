﻿using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Playlist.Groups
{
    /// <summary>
    /// Represents Country Group
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IGroup" />
    public class Countries : IGroup
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public override string Name
        {
            get
            {
                return "countries";
            }
        }
    }
}
