using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Exceptions
{
    public class MissingFormatterTypeAttrException : Exception
    {
        public MissingFormatterTypeAttrException(Type type)
            : base($"Could not find the FormatterTypeAttribute for {type.ToString()}")
        { }
    }
}
