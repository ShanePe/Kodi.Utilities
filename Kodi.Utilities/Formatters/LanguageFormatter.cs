using Kodi.Utilities.Attributes;
using Kodi.Utilities.Data;
using Kodi.Utilities.Exceptions;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Operators;
using System;

namespace Kodi.Utilities.Formatters
{
    /// <summary>
    /// Handles Language Fields.
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IFormatter" />
    public class LanguageFormatter : IFormatter
    {
        /// <summary>
        /// Gets the underlying type.
        /// </summary>
        /// <value>
        /// The underlying type.
        /// </value>
        public override Type UnderlyingType { get { return typeof(ISO6392Language); } }

        /// <summary>
        /// Gets the available operators.
        /// </summary>
        /// <returns></returns>
        public override IOperator[] GetAvailableOperators()
        {
            return new IOperator[]
            {
                new Is(),
                new IsNot()
            };
        }

        /// <summary>
        /// Gets the formatted value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public override string GetFormattedValue(object value)
        {
            if (value == null)
                return string.Empty;

            ISO6392Language cult = (ISO6392Language)value;
            return cult.Code;
        }

        /// <summary>
        /// Sets the value to the correct underlying type.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <exception cref="Kodi.Utilities.Exceptions.InvalidLanguageException">
        /// </exception>
        public override object SetToType(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new InvalidLanguageException(value);

            ISO6392Language language = ISO6392LanguageFactory.GetByCode(value.Trim());
            if (language == null)
                language = ISO6392LanguageFactory.GetByName(value.Trim());

            if (language == null)
                throw new InvalidLanguageException(value);

            return language;
        }
    }
}
