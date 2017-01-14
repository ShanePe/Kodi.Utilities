using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Exceptions
{

    public class MissingFieldAttributeException : Exception
    {
        public MissingFieldAttributeException(IRule rule)
            : base($"Missing field allocation attribute on field {nameof(IRule)}") { }
    }
}
