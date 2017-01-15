﻿using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Operators
{
    /// <summary>
    /// Is not operator
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IOperator" />
    public class IsNot : IOperator
    {
        /// <summary>
        /// Gets the user readable name of the operator
        /// </summary>
        /// <value>
        /// Name
        /// </value>
        public string FriendlyName
        {
            get
            {
                return Name.SplitCamel().ToTitleCase();
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get
            {
                return "IsNot";
            }
        }
    }
}
