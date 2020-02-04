using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BorwellSoftwareChallenge.Interfaces;

namespace BorwellSoftwareChallenge.UnitTests
{
    [TestClass]
    public class VolumeCalculatorTests
    {
        /* <Summary>
         * Ensures a value is returned
         * </Summary>
         */
        [TestMethod]
        public void Calculate_Volume_ReturnsVolume()
        {
            //Arrange
            IVolumeCalculator _calculator = new VolumeCalculator();

            //Act
            decimal volume = _calculator.CalculateVolume(12, 6, 3);

            //Assert
            Assert.IsTrue(volume > 0);
        }

        /* <Summary>
         * Ensures volume calculation logic works
         * </Summary>
         */
        [TestMethod]
        public void Calculate_Volume_ReturnsVolume_Logic_Test()
        {
            //Arrange
            IVolumeCalculator _calculator = new VolumeCalculator();
            decimal length = 15, width = 20, height = 3;

            //Act
            decimal volume = _calculator.CalculateVolume(length, width, height);

            //Assert
            Assert.IsTrue(volume == (length * width * height), "Volume correctly calculated");
        }

        /* <Summary>
         * Ensures decimal place accuracy isn't lost
         * </Summary>
         */
        [TestMethod]
        public void Calculate_Volume_ReturnsDecimalVolumes()
        {
            //Arrange
            IVolumeCalculator _calculator = new VolumeCalculator();
            int precision = 0;

            //Act
            decimal volume = _calculator.CalculateVolume(12.00050002m, 6.49007002m, 3.045m);


            //Checks how many decimal places the calculation is accurate too
            while (volume * (decimal)Math.Pow(10, precision) !=
                     Math.Round(volume * (decimal)Math.Pow(10, precision)))
                precision++;

            //Assert
            Assert.IsTrue(precision >= 10, "Accurate to at least {0} decimal places", precision);
        }
    }
}
