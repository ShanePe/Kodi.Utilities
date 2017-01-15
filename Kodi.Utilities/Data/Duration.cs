using Kodi.Utilities.Formatters;
using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Data
{
    public class Duration
    {
        public enum Periods { Days, Weeks, Months }
        public int Unit { get; set; } = 1;
        public Periods Period { get; set; } = Periods.Months;
        public DateTime? Date { get; set; }

        public Duration(DateTime date)
        {
            Date = date;
        }

        public Duration(int unit, Periods period)
        {
            Unit = unit;
            Period = period;
        }

        public override string ToString()
        {
            if (Date.HasValue)
                return IFormatter.Format(typeof(DateTime), Date.Value);
            else
                return $"{Unit.ToString()} {Enum.GetName(typeof(Periods), Period).ToLower()}";
        }
    }
}
