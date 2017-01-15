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
        public abstract IOperator[] GetAvailableOperators();

        public static IFormatter GetFormatter(Type underlyingType)
        {
            TypeInfo typeInfo = typeof(IFormatter).GetTypeInfo();
            foreach (TypeInfo ti in typeInfo.Assembly.DefinedTypes
                                        .Where(t => typeInfo.IsAssignableFrom(t) && !t.IsAbstract))
            {
                FormatterTypeAttribute attr = (FormatterTypeAttribute)ti.GetCustomAttribute(typeof(FormatterTypeAttribute));
                if (attr == null)
                    throw new MissingFormatterTypeAttrException(ti.AsType());

                if (attr.UnderlyingType == underlyingType)
                {
                    IFormatter formatter = (IFormatter)Activator.CreateInstance(ti.AsType());
                    return formatter;
                }
            }

            return null;
        }

        public static string Format(Type underlyingType, object value)
        {
            IFormatter formatter = GetFormatter(underlyingType);
            if (formatter != null)
                return formatter.GetFormattedValue(value);
            return value.ToString();
        }

    }
}
