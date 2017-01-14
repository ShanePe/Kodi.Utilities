using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Exceptions
{
    public class InvalidRuleCollectionType : Exception
    {
        public InvalidRuleCollectionType(Type t)
            : base($"Invalid type for rule collection : {t.ToString()}") { }
    }
}
