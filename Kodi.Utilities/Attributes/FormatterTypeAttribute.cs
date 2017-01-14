using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Attributes
{
    [System.AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class FormatterTypeAttribute : Attribute
    {
        readonly Type _underlyingType;
        public FormatterTypeAttribute(Type underlyingType)
        {
            _underlyingType = underlyingType;
        }

        public Type UnderlyingType
        {
            get { return _underlyingType; }
        }
    }
}
