using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BorwellSoftwareChallenge.Interfaces;

namespace BorwellSoftwareChallenge
{
    class Kernel
    {
        IAreaCalculator _areaCalculator;
        IVolumeCalculator _volumeCalculator;
        IParseDecimalFromInput _decimalParse;
        IPaintCoverageCalculator _paintCalculator;
        char restart = 'Y';

        public Kernel()
        {
            //Instantiate Interface objects 
            _areaCalculator = new AreaCalculator();
            _volumeCalculator = new VolumeCalculator();
            _decimalParse = new ParseDecimalFromInput();
            _paintCalculator = new PaintCoverageCalculator();
        }

        public void Run()
        {
            do
            {
                //Get user input, and parse into decimal
                Console.Write("Please input the length of your room in metres: ");
                decimal length = _decimalParse.ParseDecimal(Console.ReadLine());

                Console.Write("Please input the width of your room in metres: ");
                decimal width = _decimalParse.ParseDecimal(Console.ReadLine());

                Console.Write("Please input the height of your room in metres: ");
                decimal height = _decimalParse.ParseDecimal(Console.ReadLine());

                Console.Write("Please input the area of your doors in m²: ");
                decimal doorArea = _decimalParse.ParseDecimal(Console.ReadLine());

                Console.Write("Please input the area of your windows in m²: ");
                decimal windowArea = _decimalParse.ParseDecimal(Console.ReadLine());

                //Perform calculations from user inputs
                decimal area = _areaCalculator.CalculateArea(width, length);
                decimal trueArea = area - (doorArea + windowArea);
                decimal volume = _volumeCalculator.CalculateVolume(width, length, height);
                decimal paintRequired = _paintCalculator.calculateCoverage(trueArea);

                //Output results of calculations with context
                Console.WriteLine("The total area of your room is: {0}m²", area);
                Console.WriteLine("The total area needing to be painted is: {0}m²", trueArea);
                Console.WriteLine("This would require {0} litres of paint for a single coat", paintRequired);
                Console.WriteLine("The volume of your room is: {0}m³", volume);

                Console.WriteLine("Do you wish to calculate another? (Y/N)");
                restart = Console.ReadKey().KeyChar;
                while ((!restart.Equals('Y')) && (!restart.Equals('N')))                   {
                    Console.WriteLine("Error");
                    Console.WriteLine("Do you wish to calculate another? (YES/NO) ");
                    restart = restart = Console.ReadKey().KeyChar;
                }

        } while (restart.Equals('Y')); 
        }
    }
}
