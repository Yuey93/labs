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
        public void Subtract_ValidString_CalculatesResult()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "5,3";
            int expected = 2;

            // Act
            int result = calculator.Subtract(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Subtract_InvalidString_ReturnsNegative9999()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "5,abc";
            int expected = -9999;

            // Act
            int result = calculator.Subtract(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Multiply_ValidString_CalculatesResult()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "5,3";
            int expected = 15;

            // Act
            int result = calculator.Multiply(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Multiply_InvalidString_ReturnsNegative9999()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "5,abc";
            int expected = -9999;

            // Act
            int result = calculator.Multiply(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_ValidString_CalculatesResult()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "6,3";
            int expected = 2;

            // Act
            int result = calculator.Divide(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_InvalidString_ReturnsNegative9999()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "5,abc";
            int expected = -9999;

            // Act
            int result = calculator.Divide(input);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
