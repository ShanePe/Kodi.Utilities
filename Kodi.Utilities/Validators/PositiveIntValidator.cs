using Kodi.Utilities.Exceptions;
using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Validators
{
    public class PositiveIntValidator : IValidator
    {
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
