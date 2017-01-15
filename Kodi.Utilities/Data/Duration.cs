using Kodi.Utilities.Interfaces;
using System;

namespace Kodi.Utilities.Data
{
    /// <summary>
    /// Represents either a date or duration (i.e. 3 weeks)
    /// </summary>
    public class Duration
    {
        public enum Periods { Days, Weeks, Months }
        public int Unit { get; set; } = 1;
        public Periods Period { get; set; } = Periods.Months;
        public DateTime? Date { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Duration"/> class.
        /// </summary>
        /// <param name="date">The date.</param>
        public Duration(DateTime date)
        {
            Date = date;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Duration"/> class.
        /// </summary>
        /// <param name="unit">The unit.</param>
        /// <param name="period">The period.</param>
        public Duration(int unit, Periods period)
        {
            Unit = unit;
            Period = period;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            if (Date.HasValue)
                return IFormatter.Format(typeof(DateTime), Date.Value);
            else
                return $"{Unit.ToString()} {Enum.GetName(typeof(Periods), Period).ToLower()}";
        }
    }
}
