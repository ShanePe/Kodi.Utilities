using Kodi.Utilities.Attributes;
using Kodi.Utilities.Exceptions;
using Kodi.Utilities.Formatters;
using Kodi.Utilities.Playlist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Interfaces
{
    public abstract class IFormatter
    {
        public abstract string GetFormattedValue(object value);

        public static string Format(Type underlyType, object value)
        {
            TypeInfo typeInfo = typeof(IFormatter).GetTypeInfo();
            foreach (TypeInfo ti in typeInfo.Assembly.DefinedTypes
                                        .Where(t => typeInfo.IsAssignableFrom(t) && !t.IsAbstract))
            {
                FormatterTypeAttribute attr = (FormatterTypeAttribute)ti.GetCustomAttribute(typeof(FormatterTypeAttribute));
                if (attr == null)
                    throw new MissingFormatterTypeAttrException(ti.AsType());

                if (attr.UnderlyingType == underlyType)
                {
                    IFormatter formatter = (IFormatter)Activator.CreateInstance(ti.AsType());
                    return formatter.GetFormattedValue(value);
                }
            }

            return value.ToString();
        }

    }
}
