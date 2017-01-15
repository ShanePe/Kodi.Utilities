using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Operators
{
    public class Contains : IOperator
    {
        public string FriendlyName
        {
            get
            {
                return Name;
            }
        }

        public string Name
        {
            get
            {
                return "Contains";
            }
        }
    }
}
