using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kodi.Utilities.Validators;
using Kodi.Utilities.Exceptions;

namespace Kodi.Utilities.Test
{
    [TestClass]
    public class Validators
    {
        [TestMethod]
        public void PositiveIntegersPass()
        {
            PositiveIntValidator validator = new PositiveIntValidator();
            validator.Validate(1);
        }

        [TestMethod]
        [ExpectedException(typeof(NonPositiveIntegerException))]
        public void PositiveIntegersFail()
        {
            PositiveIntValidator validator = new PositiveIntValidator();
            validator.Validate(-1);
        }

        [TestMethod]
        public void TimePass()
        {
            TimeValidator validator = new TimeValidator();
            validator.Validate("10 Min");
            validator.Validate("13:10:02");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTimeFormatException))]
        public void TimeFail()
        {
            TimeValidator validator = new TimeValidator();
            validator.Validate("25:10:02");
        }

        [TestMethod]
        public void RatingPass()
        {
            RatingValidator validator = new RatingValidator();
            validator.Validate(5.3);
            validator.Validate(1);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRatingException))]
        public void RatingFail()
        {
            RatingValidator validator = new RatingValidator();
            validator.Validate(66.5);
        }
    }
}
