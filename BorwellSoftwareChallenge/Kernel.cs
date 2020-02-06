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
        //Initialise class variables
        IAreaCalculator _areaCalculator;
        IVolumeCalculator _volumeCalculator;
        IParseDecimalFromInput _decimalParse;
        IPaintCoverageCalculator _paintCalculator;

        decimal length, width, height, doorArea, windowArea, area, trueArea, volume, paintRequired;

        bool validArea, run;

        public Kernel()
        {
            //Instantiate Interface objects 
            _areaCalculator = new AreaCalculator();
            _volumeCalculator = new VolumeCalculator();
            _decimalParse = new ParseDecimalFromInput();
            _paintCalculator = new PaintCoverageCalculator();

            run = true;
            validArea = false;
        }

        public void Run()
        {
            while (run)
            {
                while (!validArea)
                {
                    //Get user input, and parse into decimal
                    Console.Write("Please input the length of your room in metres: ");
                    length = _decimalParse.ParseDecimal(Console.ReadLine());

                    Console.Write("Please input the width of your room in metres: ");
                    width = _decimalParse.ParseDecimal(Console.ReadLine());

                    Console.Write("Please input the height of your room in metres: ");
                    height = _decimalParse.ParseDecimal(Console.ReadLine());

                    Console.Write("Please input the area of your doors in m²: ");
                    doorArea = _decimalParse.ParseDecimal(Console.ReadLine());

                    Console.Write("Please input the area of your windows in m²: ");
                    windowArea = _decimalParse.ParseDecimal(Console.ReadLine());

                    //Perform calculations from user inputs
                    area = _areaCalculator.CalculateArea(width, length);
                    trueArea = area - (doorArea + windowArea);
                    volume = _volumeCalculator.CalculateVolume(width, length, height);
                    paintRequired = _paintCalculator.calculateCoverage(trueArea);

                    if (trueArea > 0)
                    {
                        validArea = true;
                    }
                    else
                    {
                        Console.WriteLine("Fenestration area cannot exceed room area");
                    }
                }
            
                //Output results of calculations with context
                Console.WriteLine("The floor area of your room is: {0}m²", String.Format("{0:n}", area));
                Console.WriteLine("The wall area needing to be painted is: {0}m²", String.Format("{0:n}", trueArea));
                Console.WriteLine("This would require {0} litres of paint for a single coat", String.Format("{0:n}", paintRequired));
                Console.WriteLine("The volume of your room is: {0}m³", String.Format("{0:n}", volume));

                Console.ReadKey();
            }
        }
    }
}

