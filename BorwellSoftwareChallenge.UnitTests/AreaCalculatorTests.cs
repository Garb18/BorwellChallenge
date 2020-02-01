using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BorwellSoftwareChallenge.Interfaces;

namespace BorwellSoftwareChallenge.UnitTests
{
    [TestClass]
    public class AreaCalculatorTests
    {
        [TestMethod]
        public void Calculate_Area_ReturnsArea()
        {
            //Arrange
             IAreaCalculator _calculator = new AreaCalculator();

            //Act
            decimal area = _calculator.CalculateArea(12, 6);

            //Assert
            Assert.IsTrue(area > 0);
        }

        [TestMethod]
        public void Calculate_Area_ReturnsDecimalAreas()
        {
            //Arrange
            IAreaCalculator _calculator = new AreaCalculator();

            //Act
            decimal area = _calculator.CalculateArea(12.01m, 6.97m);

            //int count = BitConverter.GetBytes(decimal.GetBits(area)[3])[2];

            int precision = 0;

            while (area * (decimal)Math.Pow(10, precision) !=
                     Math.Round(area * (decimal)Math.Pow(10, precision)))
                precision++;

            //Assert
            Assert.IsTrue(precision >= 1);
        }
    }
}