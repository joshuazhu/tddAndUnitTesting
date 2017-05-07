using System;
using NUnit.Framework;

namespace LogAn.Test
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        private LogAnalyzer m_analyzer = null;

        [SetUp]
        public void Setup()
        {
            m_analyzer = new LogAnalyzer();
        }

        [Test]
        public void IsValidFileName_validFileLowerCased_ReturnsTrue()
        {
            bool result = m_analyzer.IsValidLogFileName("whatever.slf");
            Assert.IsTrue(result, "filename should be valid");
        }

        [Test]
        public void IsValidFileName_validFileUpperCased_ReturnsTrue()
        {
            bool result = m_analyzer.IsValidLogFileName("whatever.SLF");
            Assert.IsTrue(result, "filename should be valid!");
        }

        [Test]
        public void IsValidFileName_EmptyFileName_ThrowException()
        {
            Assert.Throws<ArgumentException>(() => m_analyzer.IsValidLogFileName(string.Empty));
        }

        [Test]
        [Ignore("there is a problem with this test")]
        public void IsValidFileName_ValidFileIgnore_ReturnsTrue()
        {
            Assert.Throws<ArgumentException>(() => m_analyzer.IsValidLogFileName(string.Empty));
        }

        [Test]
        [Category("Fast Tests")]
        public void IsValidFileName_ValidFile_ReturnsTrue()
        {
            Assert.Throws<ArgumentException>(() => m_analyzer.IsValidLogFileName(string.Empty));
        }

        [TearDown]
        public void TearDown()
        {
            m_analyzer = null;
        }
    }
}
