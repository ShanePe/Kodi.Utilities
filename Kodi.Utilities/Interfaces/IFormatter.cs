using Kodi.Utilities.Attributes;
using Kodi.Utilities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Kodi.Utilities.Interfaces
{
    /// <summary>
    /// Abstract class to handle field value formatting
    /// </summary>
    public abstract class IFormatter
    {
        public static Dictionary<Type, IFormatter> _formatters = new Dictionary<Type, IFormatter>();
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
        /// Sets the value to the correct underlying type.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public abstract object SetToType(string value);

        /// <summary>
        /// Gets the formatter.
        /// </summary>
        /// <param name="underlyingType">The underlying type.</param>
        /// <returns></returns>
        /// <exception cref="MissingFormatterTypeAttrException"></exception>
        public static IFormatter GetFormatter(Type underlyingType)
        {
            if (!_formatters.ContainsKey(underlyingType))
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
                        _formatters.Add(underlyingType, formatter);
                        break;
                    }
                }
                if (!_formatters.ContainsKey(underlyingType))
                    _formatters.Add(underlyingType, null);
            }

            return _formatters[underlyingType];
        }


        /// <summary>
        /// Formats the specified underlying type.
        /// </summary>
        /// <param name="underlyingType">The underlying type.</param>
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
