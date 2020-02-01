using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BorwellSoftwareChallenge.Interfaces;

namespace BorwellSoftwareChallenge
{
    class ParseDecimalFromInput : IParseDecimalFromInput
    {
        public ParseDecimalFromInput()
        {
            //Do nothing
        }

        public decimal ParseDecimal(string pInput)
        {
            //Instantiate to 0 to prevent void results
            decimal side = 0;

            while (!decimal.TryParse(pInput, out side))
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Not valid, please enter numbers only");
                Console.BackgroundColor = ConsoleColor.Black;
                pInput = Console.ReadLine();
            }

            return side;
        }
    }
}
