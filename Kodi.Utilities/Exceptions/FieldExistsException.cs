using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Exceptions
{
    public class FieldExistsException:Exception
    {
        public FieldExistsException(IRule rule)
            : base($"Field {rule.Name} is already assigned to playlist.") { }
    }
}
