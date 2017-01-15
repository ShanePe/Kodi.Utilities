﻿using Kodi.Utilities.Attributes;
using Kodi.Utilities.Data;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Formatters
{
    [FormatterTypeAttribute(typeof(Duration))]
    public class DurationFormatter : IFormatter
    {
        public override IOperator[] GetAvailableOperators()
        {
            return new IOperator[]
            {
                new After(),
                new Before(),
                new InTheLast(),
                new NotInTheLast()
            };
        }
        public override string GetFormattedValue(object value)
        {
            Duration d = (Duration)value;
            return d.ToString();
        }
    }
}