using NUnit.Framework;
using QACalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Subtract_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            int expected = 2;
            int actual = calculator.Subtract("5,3");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Subtract_From_Minus_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            int expected = -8;
            int actual = calculator.Subtract("-5,3");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Subtract_InvalidInput_ReturnsZero()
        {
            var calculator = new Calculator();
            int expected = 0;
            int actual = calculator.Subtract("5,a");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Divide_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            int expected = 2;
            int actual = calculator.Divide("10,5");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Divide_Minus_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            int expected = -5;
            int actual = calculator.Divide("10,-2");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Divide_InvalidInput_ReturnsZero()
        {
            var calculator = new Calculator();
            int expected = 0;
            int actual = calculator.Divide("10,a");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Multiply_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            int expected = 50;
            int actual = calculator.Multiply("25,2");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Multiply_InvalidInput_ReturnsZero()
        {
            var calculator = new Calculator();
            int expected = 0;
            int actual = calculator.Multiply("25,a");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Divide_By_Zero_ThrowsException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Divide("10,0"));
        }

        // TDD

        [Test]
        public void TestCalc_EmptyString_ReturnsZero()
        {
            var calculator = new Calculator();
            double expected = 0;
            double actual = calculator.Calc("");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCalc_JustNumber_ReturnsNumber()
        {
            var calculator = new Calculator();
            double expected = 5;
            double actual = calculator.Calc("5");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCalc_TwoNumbersSeparatedByComma_ReturnsSum()
        {
            var calculator = new Calculator();
            double expected = 8;
            double actual = calculator.Calc("5,3");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCalc_TwoNumbersSeparatedByNewLine_ReturnsSum()
        {
            var calculator = new Calculator();
            double expected = 8;
            double actual = calculator.Calc("5\n3");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCalc_ThreeNumbersSeperatedByCommaOrNewLine_ReturnsSum()
        {
            var calculator = new Calculator();
            double expected = 12;
            double actual = calculator.Calc("5\n3,4");
            Assert.AreEqual(expected, actual);
        }
    }
}
