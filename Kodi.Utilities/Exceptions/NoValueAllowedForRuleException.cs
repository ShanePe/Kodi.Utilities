using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Exceptions
{
    /// <summary>
    /// handles the no value allowed for rule operator
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class NoValueAllowedForRuleException : Exception
    {
        public NoValueAllowedForRuleException(IRule rule)
            : base($"The rule {rule.Field} does not allow valus for the {rule.Operator.FriendlyName} operator.")
        {
        }
    }
}
