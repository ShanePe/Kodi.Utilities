using Kodi.Utilities.Playlist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using lta = Kodi.Utilities.Attributes.ListTypeAllocationAttribute;

namespace Kodi.Utilities.Interfaces
{
    public class IAllocatable
    {
        Dictionary<lta.AppliesTos, lta> _allocationAttr = new Dictionary<lta.AppliesTos, lta>();

        internal lta GetAllocation(lta.AppliesTos appliesTo)
        {
            if (!_allocationAttr.ContainsKey(appliesTo))
            {
                TypeInfo typeInfo = this.GetType().GetTypeInfo();
                lta attr = typeInfo.GetCustomAttributes<lta>()
                                        .FirstOrDefault(a => a.AppliesTo == appliesTo);
                if (attr == null)
                    attr = new lta(appliesTo, new SmartPlayList.Types[0]);

                _allocationAttr.Add(appliesTo, attr);
            }
            return _allocationAttr[appliesTo];
        }
    }
}
