using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BorwellSoftwareChallenge.Interfaces;

namespace BorwellSoftwareChallenge.UnitTests
{
    [TestClass]
    public class ParseFromInputTests
    {
        /* <Summary>
         * Ensures a decimal is returned from string input
         * </Summary>
         */
        [TestMethod]
        public void Parse_Input_Returns_Decimal()
        {
            //Arrange
            IParseFromInput _parse = new ParseFromInput();
            string input;

            //Act
            input = "5";
            var output = _parse.ParseDecimal(input);

            //Assert
            Assert.IsTrue(output.GetType() == typeof(decimal), "decimal outputted");
        }

        /* <Summary>
         * Ensures no accuracy is lost upon conversion
         * </Summary>
         */
        [TestMethod]
        public void Parse_Input_Returns_Decimal_Accurately()
        {
            //Arrange
            IParseFromInput _parse = new ParseFromInput();
            string input = "5243.5315678465477777771";
            int precision = 0;

            //Act
            var output = _parse.ParseDecimal(input);
            // Checks how many decimal places the calculation is accurate too
            while (output * (decimal)Math.Pow(10, precision) !=
                     Math.Round(output * (decimal)Math.Pow(10, precision)))
                precision++;

            //Assert
            Assert.IsTrue(precision >= 10, "Accurate to at least {0} decimal places", precision);
        }
    }
}
