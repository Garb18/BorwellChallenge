using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BorwellSoftwareChallenge.Interfaces;

namespace BorwellSoftwareChallenge
{
    public class ParseDecimalFromInput : IParseDecimalFromInput
    {
        public ParseDecimalFromInput()
        {
            //Do nothing
        }

        public decimal ParseDecimal(string pInput)
        {             
            decimal value;

            while (!decimal.TryParse(pInput, out value) || value < 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Not valid, please enter positive numbers only");
                Console.BackgroundColor = ConsoleColor.Black;
                pInput = Console.ReadLine();
            }
            
            return value;
        }
    }
}
