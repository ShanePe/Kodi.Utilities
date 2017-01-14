using Kodi.Utilities.Playlist;
using System;

namespace Kodi.Utilities.Attributes
{
    [System.AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    sealed class FieldAllocationAttribute : Attribute
    {
        readonly SmartPlayList.Types[] _allowedTypes;
        readonly string _fieldName;
        readonly Type _underlingType;

        public FieldAllocationAttribute(string fieldName, Type underlyingType, params SmartPlayList.Types[] allowedTypes)
        {
            _fieldName = fieldName;
            _underlingType = underlyingType;
            _allowedTypes = allowedTypes;
        }

        public SmartPlayList.Types[] AllowedTypes
        {
            get { return _allowedTypes; }
        }

        public string FieldName
        {
            get { return _fieldName; }
        }

        public Type UnderlyingType
        {
            get { return _underlingType; }
        }

        public int NamedInt { get; set; }
    }
}
