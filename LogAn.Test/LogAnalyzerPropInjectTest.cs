using System;
using LogAnalyzerConstuctorInject;
using NUnit.Framework;

namespace LogAn.Test
{
    [TestFixture]
    public class LogAnalyzerExternalDependencyTest
    {
        [Test]
        public void IsValidFileName_NameShorterThan6CharsButSupportedExtension_ReturnsFalse()
        {
            StubExtensionManager myFakerManager = new StubExtensionManager();
            var log = new LogAnalyzerPropInject.LogAnalyzerPropInject
            {
                ExtensionManager = myFakerManager
            };

            bool result = log.IsValidLogFileName("short.ext");
            Assert.IsFalse(result, "File name with less than 5 chars should have failed the method, even if the extension is supported");
        }
    }
}
