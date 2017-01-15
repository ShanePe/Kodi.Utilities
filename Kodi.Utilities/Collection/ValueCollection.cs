using Kodi.Utilities.Interfaces;
using System.Collections.Generic;
using System.Runtime.InteropServices;

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

            if (o.GetType() != _parentRule.UnderlyingType)
                o = IFormatter.GetFormatter(_parentRule.UnderlyingType).SetToType(o.ToString());

            if (_parentRule.Validator != null)
                _parentRule.Validator.Validate(o);

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
        /// Gets the formatted value.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<string> GetFormattedValue()
        {
            foreach (object o in this)
                yield return IFormatter.Format(_parentRule.UnderlyingType, o);
        }
    }
}
