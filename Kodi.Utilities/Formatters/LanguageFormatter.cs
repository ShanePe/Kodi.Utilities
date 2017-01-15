﻿using Kodi.Utilities.Attributes;
using Kodi.Utilities.Data;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Operators;
using System;

namespace Kodi.Utilities.Formatters
{
    /// <summary>
    /// Handles Language Fields.
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IFormatter" />
    [FormatterType(typeof(ISO6392Language))]
    public class LanguageFormatter : IFormatter
    {
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

        public override object SetToType(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new InvalidCastException($"{value} is not a valid language code or name.");

            ISO6392Language language = ISO6392LanguageFactory.GetByCode(value.Trim());
            if (language == null)
                language = ISO6392LanguageFactory.GetByName(value.Trim());

            if (language == null)
                throw new InvalidCastException($"{value} is not a valid language code or name.");

            return language;
        }
    }
}
