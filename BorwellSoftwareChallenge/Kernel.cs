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
        string input;

        public Kernel()
        {
            //Instantiate Interface objects 
            _areaCalculator = new AreaCalculator();
            _volumeCalculator = new VolumeCalculator();
            _decimalParse = new ParseDecimalFromInput();            
        }

        public void Run()
        {
            Console.Write("Please input the length of your room in metres: ");

            input = Console.ReadLine();
            decimal length = _decimalParse.ParseDecimal(input);
            
            Console.Write("Please input the width of your room in metres: ");

            input = Console.ReadLine();
            decimal width = _decimalParse.ParseDecimal(input);
            
            Console.Write("Please input the height of your room in metres: ");

            input = Console.ReadLine();
            decimal height = _decimalParse.ParseDecimal(input);

            Console.Write("Please input the area of your doors in m²: ");

            input = Console.ReadLine();
            decimal doorArea = _decimalParse.ParseDecimal(input);

            Console.Write("Please input the area of your windows in m²: ");

            input = Console.ReadLine();
            decimal windowArea = _decimalParse.ParseDecimal(input);

            decimal area = _areaCalculator.CalculateArea(width, length);
            decimal trueArea = area - (doorArea + windowArea);
            decimal volume = _volumeCalculator.CalculateVolume(width, length, height);

            Console.WriteLine("The total area of your room is: {0}m²", area);
            Console.WriteLine("The true area of your room is: {0}m²", trueArea);
            Console.WriteLine("The volume of your room is: {0}m³", volume);
        }
    }
}
