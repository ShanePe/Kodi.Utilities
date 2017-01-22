using Kodi.Utilities.Exceptions;
using Kodi.Utilities.Interfaces;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Kodi.Utilities.Collection
{
    /// <summary>
    /// Collection of values for the rule
    /// </summary>
    /// <seealso cref="System.Collections.Generic.List{System.Object}" />
    [ComVisible(false)]
    public class ValueCollection : List<object>
    {
        private IRule _parentRule = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueCollection"/> class.
        /// </summary>
        /// <param name="parentRule">The parent rule.</param>
        public ValueCollection(IRule parentRule)
        {
            _parentRule = parentRule;
        }

        /// <summary>
        /// Adds the specified o.
        /// </summary>
        /// <param name="o">The o.</param>
        /// <exception cref="InvalidFieldTypeValue"></exception>
        public new void Add(object o)
        {
            if (o == null)
                return;

            if (_parentRule.Operator.NoValue)
                throw new NoValueAllowedForRuleException(_parentRule);
            
            if (o.GetType() != _parentRule.UnderlyingType)
                o = IFormatter.GetFormatter(_parentRule.UnderlyingType).SetToType(o.ToString());
            
            if (_parentRule.Validator != null)
                _parentRule.Validator.Validate(o);

            if (!_parentRule.IsMultipleValuesAllowed && Count > 0)
                Clear();

            if (!Contains(o))
                base.Add(o);
        }

        /// <summary>
        /// Adds the elements of the specified collection to the end of the <see cref="T:System.Collections.Generic.List`1" />.
        /// </summary>
        /// <param name="collection">The collection whose elements should be added to the end of the <see cref="T:System.Collections.Generic.List`1" />. The collection itself cannot be null, but it can contain elements that are null, if type <paramref name="T" /> is a reference type.</param>
        public new void AddRange(IEnumerable<object> collection)
        {
            foreach (object o in collection)
                if (!this.Contains(o))
                    Add(o);
        }


        /// <summary>
        /// Gets the values as string.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetValuesAsString()
        {
            foreach (object o in this)
                yield return IFormatter.Format(_parentRule.UnderlyingType, o);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (object value in this)
            {
                if (sb.Length != 0)
                    sb.Append(" / ");
                sb.Append(IFormatter.Format(_parentRule.UnderlyingType, value));
            }

            return sb.ToString();
        }
    }
}
