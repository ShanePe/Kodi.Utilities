using System;

namespace Kodi.Utilities.Exceptions
{
    /// <summary>
    /// Exception to handle invalid user rating
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class InvalidRatingException : Exception
    {
        public InvalidRatingException(double got)
            : base($"Invalid rating, must be between 0.0 and 10.0. got : {got.ToString()}")
        { }

        public InvalidRatingException(int got)
            : base($"Invalid rating, must be between 0.0 and 10.0. got : {got.ToString()}")
        { }

    }
}
