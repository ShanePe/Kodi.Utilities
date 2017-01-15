using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Data
{
    public class ISO6392Language
    {
        public string Code { get; set; }
        public string Name { get; set; }

        internal ISO6392Language(string code, string name)
        {
            Code = code;
            Name = name;
        }

        private ISO6392Language() { }
    }
}
