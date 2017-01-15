using Kodi.Utilities.Attributes;
using Kodi.Utilities.Collection;
using Kodi.Utilities.Exceptions;
using Kodi.Utilities.Extensions;
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
    /// <summary>
    /// Abstract class to define rule fields and functions
    /// </summary>
    public abstract class IRule
    {
        /// <summary>
        /// Sort options
        /// </summary>
        public enum SortOptions { None, Ascendingg, Descending }

        #region Private
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the operator.
        /// </summary>
        /// <value>
        /// The operator.
        /// </value>
        public IOperator Operator { get; set; }
        /// <summary>
        /// Gets or sets the sort.
        /// </summary>
        /// <value>
        /// The sort.
        /// </value>
        public SortOptions Sort { get; set; } = SortOptions.None;
        /// <summary>
        /// Gets or sets the values.
        /// </summary>
        /// <value>
        /// The values.
        /// </value>
        public ValueCollection Values { get; set; }
        public string Name
        {
            get { return GetFieldAllocation().FieldName; }
        }

        /// <summary>
        /// Gets the type of the underlying.
        /// </summary>
        /// <value>
        /// The type of the underlying.
        /// </value>
        public Type UnderlyingType
        {
            get { return GetFieldAllocation().UnderlyingType; }
        }

        /// <summary>
        /// Gets the user readable name.
        /// </summary>
        /// <value>
        /// The name of the friendly.
        /// </value>
        public virtual string FriendlyName
        {
            get { return Name.SplitCamel().ToTitleCase(); }
        }

        #endregion

        #region Constructor
        public IRule()
        {
            Values = new ValueCollection(GetFieldAllocation().UnderlyingType);
            Operator = GetAvailableOperators()?[0];
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

        public IOperator[] GetAvailableOperators()
        {
            return IFormatter.GetFormatter(UnderlyingType)?.GetAvailableOperators();
        }

        public bool IsAllowedForPlaylistType(SmartPlayList.Types type)
        {
            return GetFieldAllocation().AllowedTypes.Contains(type);
        }
        #endregion
    }
}
