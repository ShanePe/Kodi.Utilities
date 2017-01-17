using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Interfaces
{
    /// <summary>
    /// Defines a group
    /// </summary>
    /// <typeparam name="R"></typeparam>
    public abstract class IGroup
    {
        private bool _mixed = false;

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public abstract string Name { get; }

        /// <summary>
        /// Gets a value indicating whether [allow mixed].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [allow mixed]; otherwise, <c>false</c>.
        /// </value>
        public virtual bool AllowMixed { get { return false; } }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="IGroup"/> is mixed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if mixed; otherwise, <c>false</c>.
        /// </value>
        /// <exception cref="System.Exception"></exception>
        public bool Mixed
        {
            get { return _mixed; }
            set
            {
                if (!AllowMixed && value)
                    throw new Exception($"Group {Name} cannot be set to mixed mode.");
                _mixed = value;
            }
        }
    }
}
