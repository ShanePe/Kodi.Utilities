using Kodi.Utilities.Exceptions;
using Kodi.Utilities.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Collection
{
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
