using NUnit.Framework;
using QACalculator;
using System;

namespace UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {

        [Test]
        public void Subtract_Returns_Result()
        {
            var calculator = new Calculator();
            int expected = 2;
            int actual = calculator.Subtract("5,3");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Subtract_From_Negative_Returns_Result()
        {
            var calculator = new Calculator();
            int expected = -8;
            int actual = calculator.Subtract("-5,3");
            Assert.AreEqual(expected, actual);
        }

        //[Test]
        //public void subtract3Test()
        //{
        //    var calculator = new Calculator();
        //    int expected = 2;
        //    int actual = calculator.Subtract("4,2");
        //    Assert.AreEqual(expected, actual);
        //}

        [Test]
        public void Divide_Returns_Result()
        {
            var calculator = new Calculator();
            int expected = 5;
            int actual = calculator.Divide("10,2");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Divide_By_Negative_Returns_Negative_Result()
        {
            var calculator = new Calculator();
            int expected = -5;
            int actual = calculator.Divide("10,-2");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Divide_Using_Char_Instead_Of_Int_Returns_Negative_Result()
        {
            var calculator = new Calculator();
            int expected = -9999;
            int actual = calculator.Divide("10,a");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Multiply_Returns_Result()
        {
            var calculator = new Calculator();
            int expected = 50;
            int actual = calculator.Multiply("25,2");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Multiply_Large_Number_Returns_Result()
        {
            var calculator = new Calculator();
            int expected = 600;
            int actual = calculator.Multiply("150,4");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Multiply_By_Negative_Returns_Negative_Result()
        {
            var calculator = new Calculator();
            int expected = -50;
            int actual = calculator.Multiply("25,-2");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Multiply_With_Invalid_Seperator_Returns_Negative_Result()
        {
            var calculator = new Calculator();
            int expected = -9999;
            int actual = calculator.Multiply("25.2");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Divide_By_Zero_Throws_Exception()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Divide("10,0"));
        }
    }
}
