using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BorwellSoftwareChallenge.Interfaces;

namespace BorwellSoftwareChallenge.UnitTests
{
    [TestClass]
    public class AreaCalculatorTests
    {
        /* <Summary>
         * Ensures a value is returned
         * </Summary>
         */
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

        /* <Summary>
         * Ensures that area calculation logic works
         * </Summary>
         */
        [TestMethod]
        public void Calculate_Volume_ReturnsArea_Logic_Test()
        {
            //Arrange
            IAreaCalculator _calculator = new AreaCalculator();
            decimal length = 15, width = 20;

            //Act
            decimal volume = _calculator.CalculateArea(length, width);

            //Assert
            Assert.IsTrue(volume == (length * width), "Area correctly calculated");
        }

        /* <Summary>
         * Ensures decimal place accuracy isn't lost
         * </Summary>
         */
        [TestMethod]
        public void Calculate_Area_ReturnsDecimalAreas()
        {
            //Arrange
            IAreaCalculator _calculator = new AreaCalculator();
            int precision = 0;

            //Act
            decimal area = _calculator.CalculateArea(12.000000000000001m, 6.97m);


            //Checks how many decimal places the calculation is accurate too
            while (area * (decimal)Math.Pow(10, precision) !=
                     Math.Round(area * (decimal)Math.Pow(10, precision)))
                precision++;

            //Assert
            Assert.IsTrue(precision >= 10, "Accurate to at least {0} decimal places", precision);
        }
    }
}