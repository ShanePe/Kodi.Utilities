using Kodi.Utilities.Exceptions;
using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Validators
{
    /// <summary>
    /// Validates the the value is a natural number
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IValidator" />
    public class PositiveIntValidator : IValidator
    {
        /// <summary>
        /// Validates the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <exception cref="InvalidTypeException"></exception>
        /// <exception cref="NonPositiveIntegerException"></exception>
        public void Validate(object value)
        {
            if (value == null)
                return;

            if (!(value is int))
                throw new InvalidTypeException(value.ToString(), typeof(int));

            if ((int)value < 0)
                throw new NonPositiveIntegerException();
        }
    }
}
