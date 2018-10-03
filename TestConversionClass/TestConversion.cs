using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConversionClass;

namespace TestConversionClass
{
    [TestClass]
    public class TestConversion
    {
        [TestMethod]
        public void ConvertOneOunceToGram()
        {
            Assert.AreEqual(28.34952, Conversion.ConvertToGrams(1), 0.1);
        }

        [TestMethod]
        public void ConvertOneOunceToGram2()
        {
            Assert.AreNotEqual(30, Conversion.ConvertToGrams(1), 0.1);
        }

        public void ConvertOneOunceToGram3()
        {
            Assert.AreNotEqual(1, Conversion.ConvertToGrams(1), 0.1);
        }

        [TestMethod]
        public void ConvertOneGramToOunce()
        {
            Assert.AreEqual(0.03527396195, Conversion.ConvertToOunces(1), 0.1);
        }
    }
}
