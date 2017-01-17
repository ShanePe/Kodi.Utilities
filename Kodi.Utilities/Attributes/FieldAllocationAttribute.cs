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
        readonly bool _allowMultipleValues;

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldAllocationAttribute" /> class.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="underlyingType">The underlying type.</param>
        /// <param name="allowMultiValues">if set to <c>true</c> [allow multi values].</param>
        /// <param name="allowedTypes">The allowed types.</param>
        public FieldAllocationAttribute(string fieldName, Type underlyingType, bool allowMultiValues, params SmartPlayList.Types[] allowedTypes)
        {
            _fieldName = fieldName;
            _underlingType = underlyingType;
            _allowedTypes = allowedTypes;
            _allowMultipleValues = allowMultiValues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldAllocationAttribute" /> class.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="underlyingType">The underlying type.</param>
        /// <param name="allowedTypes">The allowed types.</param>
        public FieldAllocationAttribute(string fieldName, Type underlyingType, params SmartPlayList.Types[] allowedTypes)
            : this(fieldName, underlyingType, false, allowedTypes)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldAllocationAttribute"/> class.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="underlyingType">The underlying type.</param>
        public FieldAllocationAttribute(string fieldName, Type underlyingType)
           : this(fieldName, underlyingType, false, null)
        { }

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
        /// Gets the underlying type.
        /// </summary>
        /// <value>
        /// The underlying type.
        /// </value>
        public Type UnderlyingType
        {
            get { return _underlingType; }
        }

        /// <summary>
        /// Gets a value indicating whether multiple values are allowed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if multiple values are allowed; otherwise, <c>false</c>.
        /// </value>
        public bool AllowMultipleValues
        {
            get { return _allowMultipleValues; }
        }
    }
}
