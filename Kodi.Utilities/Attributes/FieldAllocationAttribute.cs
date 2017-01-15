using Kodi.Utilities.Playlist;
using System;

namespace Kodi.Utilities.Attributes
{
    /// <summary>
    /// Field allocation definitions
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [System.AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    sealed class FieldAllocationAttribute : Attribute
    {
        readonly SmartPlayList.Types[] _allowedTypes;
        readonly string _fieldName;
        readonly Type _underlingType;


        /// <summary>
        /// Initializes a new instance of the <see cref="FieldAllocationAttribute" /> class.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="underlyingType">Type of the underlying.</param>
        /// <param name="allowedTypes">The allowed types.</param>
        public FieldAllocationAttribute(string fieldName, Type underlyingType, params SmartPlayList.Types[] allowedTypes)
        {
            _fieldName = fieldName;
            _underlingType = underlyingType;
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
        /// Gets the name of the field.
        /// </summary>
        /// <value>
        /// The name of the field.
        /// </value>
        public string FieldName
        {
            get { return _fieldName; }
        }

        /// <summary>
        /// Gets the type of the underlying.
        /// </summary>
        /// <value>
        /// The type of the underlying.
        /// </value>
        public Type UnderlyingType
        {
            get { return _underlingType; }
        }
    }
}
