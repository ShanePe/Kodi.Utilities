using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kodi.Utilities.Data;

namespace Kodi.Utilities.Test
{
    /// <summary>
    /// Summary description for LanguagesTests
    /// </summary>
    [TestClass]
    public class LanguagesTest
    {
      
        [TestMethod]
        [Priority(0)]
        public void LanguageCacheBuild()
        {
            Assert.AreEqual(ISO6392LanguageFactory.Languages.Count, 371);
        }

        [TestMethod]
        [Priority(1)]
        public void LanguageCacheRead()
        {
            Assert.AreEqual(ISO6392LanguageFactory.Languages.Count, 371);
        }

        [TestMethod]
        [Priority(1)]
        public void LanguageRead()
        {
            Assert.IsNotNull(ISO6392LanguageFactory.GetByCode("eng"));
        }

        [TestMethod]
        [Priority(1)]
        public void LanguageFailRead()
        {
            Assert.IsNull(ISO6392LanguageFactory.GetByCode("kln"));
        }
    }
}
