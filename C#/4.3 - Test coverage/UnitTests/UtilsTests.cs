using NUnit.Framework;
using QACalculator;

namespace UnitTests
{
    [TestFixture]
    public class UtilsTests
    {
        [Test]
        public void ToNumberTest()
        {
            bool expected = true;
            bool actual = Utils.ToNumber("5") == 5;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsNumericTest()
        {
            bool expected = true;
            bool actual = Utils.IsNumeric("5");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidSeperatorTest()
        {
            bool expected = true;
            bool actual = Utils.ValidSeperator("5,3") == ',';
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidSeperatorTest_Returns_False()
        {
            bool expected = false;
            bool actual = Utils.ValidSeperator("5.3") == ',';
            Assert.AreEqual(expected, actual);
        }
    }
}