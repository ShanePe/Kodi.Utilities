using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Data;
using Kodi.Utilities.Formatters;

namespace Kodi.Utilities.Test
{
    [TestClass]
    public class Formatters
    {
        [TestMethod]
        public void BoolFormatter()
        {
            IFormatter formatter = IFormatter.GetFormatter(typeof(bool));
            Assert.IsInstanceOfType(formatter, typeof(BoolFormatter));
            Assert.AreEqual(formatter.GetAvailableOperators().Length, 2);
            Assert.AreEqual(formatter.GetFormattedValue(true), "true");
            Assert.AreEqual(formatter.GetFormattedValue(false), "false");
        }

        [TestMethod]
        public void DateFormatter()
        {
            DateTime tester = DateTime.Now;

            IFormatter formatter = IFormatter.GetFormatter(typeof(DateTime));
            Assert.IsInstanceOfType(formatter, typeof(DateFormatter));
            Assert.AreEqual(formatter.GetAvailableOperators().Length, 2);
            Assert.AreEqual(formatter.GetFormattedValue(tester), tester.ToString("dd MM yyyy"));

        }

        [TestMethod]
        public void DurationFormatter()
        {
            DateTime tester = DateTime.Now;
            Duration d1 = new Duration(DateTime.Now);
            Duration d2 = new Duration(2, Duration.Periods.Weeks);

            IFormatter formatter = IFormatter.GetFormatter(typeof(Duration));
            Assert.IsInstanceOfType(formatter, typeof(DurationFormatter));
            Assert.AreEqual(formatter.GetAvailableOperators().Length, 4);
            Assert.AreEqual(formatter.GetFormattedValue(d1), d1.Date.Value.ToString("dd MM yyyy"));
            Assert.AreEqual(formatter.GetFormattedValue(d2), "2 weeks");

        }

        [TestMethod]
        public void IntFormatter()
        {
            IFormatter formatter = IFormatter.GetFormatter(typeof(int));
            Assert.IsInstanceOfType(formatter, typeof(IntFormatter));
            Assert.AreEqual(formatter.GetAvailableOperators().Length, 4);
            Assert.AreEqual(formatter.GetFormattedValue(10), "10");
        }

        [TestMethod]
        public void LanguageFormatter()
        {
            IFormatter formatter = IFormatter.GetFormatter(typeof(ISO6392Language));
            Assert.IsInstanceOfType(formatter, typeof(LanguageFormatter));
            Assert.AreEqual(formatter.GetAvailableOperators().Length, 2);
            Assert.AreEqual(formatter.GetFormattedValue(ISO6392LanguageFactory.GetByCode("eng")), "eng");
        }

        [TestMethod]
        public void StringFormatter()
        {
            IFormatter formatter = IFormatter.GetFormatter(typeof(string));
            Assert.IsInstanceOfType(formatter, typeof(StringFormatter));
            Assert.AreEqual(formatter.GetAvailableOperators().Length, 6);
            Assert.AreEqual(formatter.GetFormattedValue("test"), "test");
        }
    }
}
