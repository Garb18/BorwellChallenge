using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BorwellSoftwareChallenge.Interfaces;

namespace BorwellSoftwareChallenge.UnitTests
{
    [TestClass]
    public class VolumeCalculatorTests
    {
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

        [TestMethod]
        public void Calculate_Volume_ReturnsDecimalVolumes()
        {
            //Arrange
            IVolumeCalculator _calculator = new VolumeCalculator();

            //Act
            decimal volume = _calculator.CalculateVolume(12.05m, 6.4972m, 3.045m);

            int precision = 0;

            while (volume * (decimal)Math.Pow(10, precision) !=
                     Math.Round(volume * (decimal)Math.Pow(10, precision)))
                precision++;
            //Assert
            Assert.IsTrue(precision >= 1);
        }
    }
}
