using Kodi.Utilities.Exceptions;
using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Validators
{
    public class RatingValidator : IValidator
    {
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
