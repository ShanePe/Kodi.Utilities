using Kodi.Utilities.Attributes;
using Kodi.Utilities.Collection;
using Kodi.Utilities.Exceptions;
using Kodi.Utilities.Extensions;
using Kodi.Utilities.Playlist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using lta = Kodi.Utilities.Attributes.ListTypeAllocationAttribute;

namespace Kodi.Utilities.Interfaces
{
    /// <summary>
    /// Abstract class to define rule fields and functions
    /// </summary>
    public abstract class IRule:IAllocatable
    {
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
        public abstract string Field { get; }

        /// <summary>
        /// Gets the underlying type.
        /// </summary>
        /// <value>
        /// The underlying type.
        /// </value>
        public abstract Type UnderlyingType { get; }

        /// <summary>
        /// Gets the user readable name.
        /// </summary>
        /// <value>
        /// The name of the friendly.
        /// </value>
        public virtual string FriendlyName
        {
            get { return Field.SplitCamel().ToTitleCase(); }
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
        public virtual bool IsMultipleValuesAllowed
        {
            get { return false; }
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
        private lta GetFieldAllocation()
        {
            return GetAllocation(lta.AppliesTos.SmartPlaylist);
        }

        /// <summary>
        /// Gets the order allocation.
        /// </summary>
        /// <returns></returns>
        private lta GetOrderAllocation()
        {
            return GetAllocation(lta.AppliesTos.OrderBy);
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
        public bool IsFieldForPlaylist(SmartPlayList.Types type)
        {
            return GetFieldAllocation().AllowedTypes.Contains(type);
        }

        /// <summary>
        /// Determines whether [is order by for playlist] [the specified type].
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>
        ///   <c>true</c> if [is order by for playlist] [the specified type]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsOrderByForPlaylist(SmartPlayList.Types type)
        {
            return GetOrderAllocation().AllowedTypes.Contains(type);
        }
        
        #endregion
    }
}
