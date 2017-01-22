using Kodi.Utilities.Exceptions;
using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Validators
{
    /// <summary>
    /// Validate that the rating a a number between 0 and 10
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IValidator" />
    public class RatingValidator : IValidator
    {
        /// <summary>
        /// Validates the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <exception cref="InvalidRatingException">
        /// </exception>
        /// <exception cref="InvalidTypeException"></exception>
        public void Validate(object value)
        {
            if (value == null)
                return;
            if (value is int)
            {
                int i = (int)value;
                if (i < 0 || i > 10)
                    throw new InvalidRatingException(i);
            }
            else if (value is double)
            {
                double d = (double)value;
                if (d < 0.0 || d > 10.0)
                    throw new InvalidRatingException(d);
            }
            else
                throw new InvalidTypeException(value.ToString(), typeof(int));


        }
    }
}
