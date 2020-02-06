using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BorwellSoftwareChallenge.Interfaces;

namespace BorwellSoftwareChallenge.UnitTests
{
    [TestClass]
    public class PaintCoverageCalculatorTests
    {
        /* <Summary>
         * Ensures expected value is returned
         * </Summary>
         */
        [TestMethod]
        public void Paint_Coverage_Returns_Litres_Required()
        {
            //Arrange
            IPaintCoverageCalculator _calculator = new PaintCoverageCalculator();

            //Act
            decimal input = _calculator.calculateCoverage(48.2221m);

            //Assert
            Assert.IsTrue(input == 48.2221m/10, "Coverage correctly calculated");
        }
        /* <Summary>
        * Ensures accuracy is not lost
        * </Summary>
        */
        [TestMethod]
        public void Paint_Coverage_Returns_Decimal_Coverage_Accurately()
        {
            //Arrange
            IPaintCoverageCalculator _calculator = new PaintCoverageCalculator();
            int precision = 0;

            //Act
            decimal input = _calculator.calculateCoverage(48.2226846158841m);
            // Checks how many decimal places the calculation is accurate too
            while (input * (decimal)Math.Pow(10, precision) !=
                     Math.Round(input * (decimal)Math.Pow(10, precision)))
                precision++;

            //Assert
            Assert.IsTrue(precision >= 10, "Accurate to at least {0} decimal places", precision);
        }
    }
}
