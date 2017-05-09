using System;
using LogAnalyzerConstuctorInject;
using NUnit.Framework;

namespace LogAn.Test
{
    [TestFixture]
    public class LogAnalyzerExtractOverrideTest
    {
        [Test]
        public void IsValidFileName_NameShorterThan6CharsButSupportedExtension_ReturnsFalse()
        {
            var logan = new TestableLogAnalyzer
            {
                IsSupported = true
            };

            bool result = logan.IsValidLogFileName("short.ext");
            Assert.IsFalse(result, "File name with less than 5 chars should have failed the method, even if the extension is supported");
        }
    }

    class TestableLogAnalyzer : LogAnalyzerExtractOverride.LogAnalyzerExtractOverride
    {
        public bool IsSupported;

        // this is the stub to replace the real FileExtensionManager
        protected override bool IsValid(string fileName)
        {
            return IsSupported;
        }
    }
}
