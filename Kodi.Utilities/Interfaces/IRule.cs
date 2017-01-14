using Kodi.Utilities.Attributes;
using Kodi.Utilities.Collection;
using Kodi.Utilities.Exceptions;
using Kodi.Utilities.Formatters;
using Kodi.Utilities.Playlist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Interfaces
{
    public abstract class IRule
    {
        public enum Operators { Contains, DoesNotContain, Is, IsNot, StartsWith, EndsWith, LessThan, GreaterThan, After, Before, InTheLast, NotInTheLast }
        public enum SortOptions { None, Asending, Desending }

        #region Private
        #endregion

        #region Properties
        public Operators Operator { get; set; } = Operators.Is;
        public SortOptions Sort { get; set; } = SortOptions.None;
        public ValueCollection Values { get; set; }
        public string Name
        {
            get { return GetFieldAllocation().FieldName; }
        }

        public Type UnderlyingType
        {
            get { return GetFieldAllocation().UnderlyingType; }
        }

        #endregion

        #region Constructor
        public IRule()
        {
            Values = new ValueCollection(GetFieldAllocation().UnderlyingType);
        }
        #endregion

        #region Abstract
        #endregion

        #region Virtual
        #endregion

        #region Methods
        private FieldAllocationAttribute GetFieldAllocation()
        {
            TypeInfo typeInfo = this.GetType().GetTypeInfo();
            FieldAllocationAttribute attr = (FieldAllocationAttribute)
                typeInfo.GetCustomAttribute<FieldAllocationAttribute>();

            if (attr == null)
                throw new MissingFieldAttributeException(this);

            return attr;
        }

        public bool IsAllowedForPlaylistType(SmartPlayList.Types type)
        {
            return GetFieldAllocation().AllowedTypes.Contains(type);
        }
        #endregion
    }
}
