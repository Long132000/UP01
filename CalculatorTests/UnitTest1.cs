using _2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace CalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateZ_WhenXNegative_ReturnsMax()
        {
            double x = -5;
            double y = 3;
            double expected = 3;
            double actual = Calculator.CalculateZ(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateZ_WhenXPositive_ReturnsMin()
        {
            double x = 2;
            double y = 4;
            double expected = 2;
            double actual = Calculator.CalculateZ(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateZ_WhenXZero_ReturnsMin()
        {
            double x = 0;
            double y = -1;
            double expected = -1;
            double actual = Calculator.CalculateZ(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}
