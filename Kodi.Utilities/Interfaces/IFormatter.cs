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
    /// <summary>
    /// Abstract class to handle field value formatting
    /// </summary>
    public abstract class IFormatter
    {
        /// <summary>
        /// Gets the formatted value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public abstract string GetFormattedValue(object value);
        /// <summary>
        /// Gets the available operators.
        /// </summary>
        /// <returns></returns>
        public abstract IOperator[] GetAvailableOperators();

        /// <summary>
        /// Gets the formatter.
        /// </summary>
        /// <param name="underlyingType">Type of the underlying.</param>
        /// <returns></returns>
        /// <exception cref="Kodi.Utilities.Exceptions.MissingFormatterTypeAttrException"></exception>
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

        /// <summary>
        /// Formats the specified underlying type.
        /// </summary>
        /// <param name="underlyingType">Type of the underlying.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static string Format(Type underlyingType, object value)
        {
            IFormatter formatter = GetFormatter(underlyingType);
            if (formatter != null)
                return formatter.GetFormattedValue(value);
            return value.ToString();
        }

    }
}
