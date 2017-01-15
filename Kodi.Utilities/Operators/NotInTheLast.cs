using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Operators
{
    public class NotInTheLast : IOperator
    {
        public string FriendlyName
        {
            get
            {
                return Name.SplitCamel().ToTitleCase();
            }
        }

        public string Name
        {
            get
            {
                return "NotInTheLast";
            }
        }
    }
}
