using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Exceptions
{
    /// <summary>
    /// Handles invalid data on playlist rule parse.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class RuleParseException : Exception
    {
        public RuleParseException(string failedOn, string type, string withValue)
            : base($"Invalid {failedOn} for {type} : {withValue}") { }
    }
}
