using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumbers;

namespace RomanNumbers.Test
{
    [TestClass]
    public class RomanNumbersTests
    {
        private IConvertFromArabicToRoman testee;

        [TestInitialize]
        public void Setup()
        {
            testee = new RomanNumbersConversor();
        }

        [TestMethod]
        public void NumberOne()
        {
        }
    }
}
