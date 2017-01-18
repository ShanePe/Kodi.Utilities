using Kodi.Utilities.Playlist;
using System;

namespace Kodi.Utilities.Attributes
{
    /// <summary>
    /// Field allocation definitions
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [System.AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    sealed class ListTypeAllocationAttribute : Attribute
    {
        public enum AppliesTos {
            SmartPlaylist,
            OrderBy,
            Group
        }

        readonly SmartPlayList.Types[] _allowedTypes;
        readonly AppliesTos _target;

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTypeAllocationAttribute" /> class.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="allowedTypes">The allowed types.</param>
        public ListTypeAllocationAttribute(AppliesTos target, params SmartPlayList.Types[] allowedTypes)
        {
            _target = target;
            _allowedTypes = allowedTypes;
        }

        /// <summary>
        /// Gets the allowed types.
        /// </summary>
        /// <value>
        /// The allowed types.
        /// </value>
        public SmartPlayList.Types[] AllowedTypes
        {
            get { return _allowedTypes ?? new SmartPlayList.Types[0]; }
        }


        /// <summary>
        /// Gets the applies to.
        /// </summary>
        /// <value>
        /// The applies to.
        /// </value>
        public AppliesTos AppliesTo
        {
            get { return _target; }
        }
        
    }
}
