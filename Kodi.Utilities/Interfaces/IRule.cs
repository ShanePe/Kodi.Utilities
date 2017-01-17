using Kodi.Utilities.Attributes;
using Kodi.Utilities.Collection;
using Kodi.Utilities.Exceptions;
using Kodi.Utilities.Extensions;
using Kodi.Utilities.Playlist;
using System;
using System.Linq;
using System.Reflection;

namespace Kodi.Utilities.Interfaces
{
    /// <summary>
    /// Abstract class to define rule fields and functions
    /// </summary>
    public abstract class IRule
    {
        private FieldAllocationAttribute _attr = null;
        private IFormatter _formatter = null;
        IOperator _operator = null;
        /// <summary>
        /// Sort options
        /// </summary>
        public enum SortOptions { None, Ascending, Descending }

        #region Private
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the operator.
        /// </summary>
        /// <value>
        /// The operator.
        /// </value>
        public IOperator Operator
        {
            get { return _operator; }
            set
            {
                _operator = value;
                if (_operator.NoValue && Values.Count > 0)
                    Values.Clear();
            }
        }
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
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get { return GetFieldAllocation().FieldName; }
        }

        /// <summary>
        /// Gets the underlying type.
        /// </summary>
        /// <value>
        /// The underlying type.
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

        /// <summary>
        /// Gets the validator.
        /// </summary>
        /// <value>
        /// The validator.
        /// </value>
        public virtual IValidator Validator
        {
            get { return null; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is allowed multiple values.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is allowed multiple values ; otherwise, <c>false</c>.
        /// </value>
        public bool IsMultipleValuesAllowed
        {
            get { return GetFieldAllocation().AllowMultipleValues; }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="IRule"/> class.
        /// </summary>
        public IRule()
        {
            Values = new ValueCollection(this);
            Operator = GetAvailableOperators()?[0];
        }
        #endregion

        #region Abstract
        #endregion

        #region Virtual

        #endregion

        #region Methods
        /// <summary>
        /// Gets the field allocation.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="MissingFieldAttributeException"></exception>
        private FieldAllocationAttribute GetFieldAllocation()
        {
            if (_attr == null)
            {
                TypeInfo typeInfo = this.GetType().GetTypeInfo();
                _attr = (FieldAllocationAttribute)
                    typeInfo.GetCustomAttribute<FieldAllocationAttribute>();

                if (_attr == null)
                    throw new MissingFieldAttributeException(this);
            }
            return _attr;
        }

        /// <summary>
        /// Gets the available operators.
        /// </summary>
        /// <returns></returns>
        public IOperator[] GetAvailableOperators()
        {
            if (_formatter == null)
                _formatter = IFormatter.GetFormatter(UnderlyingType);
            return _formatter?.GetAvailableOperators();
        }

        /// <summary>
        /// Determines whether [is allowed for playlist type] [the specified type].
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>
        ///   <c>true</c> if [is allowed for playlist type] [the specified type]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsAllowedForPlaylistType(SmartPlayList.Types type)
        {
            return GetFieldAllocation().AllowedTypes.Contains(type);
        }
        #endregion
    }
}
