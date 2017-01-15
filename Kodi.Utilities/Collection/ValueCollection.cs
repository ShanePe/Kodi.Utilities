using Kodi.Utilities.Exceptions;
using Kodi.Utilities.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Collection
{
    /// <summary>
    /// Collection of vlaues for the rule
    /// </summary>
    /// <seealso cref="System.Collections.Generic.List{System.Object}" />
    [ComVisible(false)]
    public class ValueCollection : List<object>
    {
        public Type UnderlyingType { get; set; }

        public ValueCollection(Type underlyingType)
        {
            UnderlyingType = underlyingType;
        }

        public new void Add(object o)
        {
            if (o.GetType() != UnderlyingType)
                throw new InvalidFieldTypeValue(UnderlyingType);

            base.Add(o);
        }

        public IEnumerator<string> GetFormattedValue()
        {
            foreach (object o in this)
                yield return IFormatter.Format(UnderlyingType, o);
        }
    }
}
