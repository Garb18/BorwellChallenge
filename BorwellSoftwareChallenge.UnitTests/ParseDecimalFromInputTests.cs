using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BorwellSoftwareChallenge.Interfaces;

namespace BorwellSoftwareChallenge.UnitTests
{
    [TestClass]
    public class ParseDecimalFromInputTests
    {
        /* <Summary>
         * Ensures a decimal is returned from string input
         * </Summary>
         */
        [TestMethod]
        public void Parse_Input_Returns_Decimal()
        {
            //Arrange
            IParseDecimalFromInput _parse = new ParseDecimalFromInput();
            string input;

            //Act
            input = "5";
            var output = _parse.ParseDecimal(input);

            //Assert
            Assert.IsTrue(output.GetType() == typeof(decimal), "decimal outputted");
        }
    }
}
