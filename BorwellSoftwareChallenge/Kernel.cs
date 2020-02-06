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
        #region Variable Decleration

        //Initialise class variables
        IAreaCalculator _areaCalculator;
        IVolumeCalculator _volumeCalculator;
        IParseFromInput _decimalParse;
        IWallAreaCalculator _wallAreaCalculator;
        IPaintCoverageCalculator _paintCalculator;

        decimal length, width, height, doorArea, windowArea, area, wallArea, volume, paintRequired;

        bool getInput, run;
        #endregion

        #region Constructor
        public Kernel()
        {
            //Instantiate Interface objects 
            _areaCalculator = new AreaCalculator();
            _volumeCalculator = new VolumeCalculator();
            _decimalParse = new ParseFromInput();
            _wallAreaCalculator = new WallAreaCalculator();
            _paintCalculator = new PaintCoverageCalculator();

            run = true;
            getInput = true;
        }
        #endregion

        public void Run()
        {
            #region Inputs
            while (run)
            {
                while (getInput)
                {
                    //Get user input, and parse into decimal
                    Console.Write("Please input the length of your room in metres: ");
                    length = _decimalParse.ParseDecimal(Console.ReadLine());

                    Console.Write("Please input the width of your room in metres: ");
                    width = _decimalParse.ParseDecimal(Console.ReadLine());

                    Console.Write("Please input the height of your room in metres: ");
                    height = _decimalParse.ParseDecimal(Console.ReadLine());

                    Console.Write("Please input the area of your door(s) in m²: ");
                    doorArea = _decimalParse.ParseDecimal(Console.ReadLine());

                    Console.Write("Please input the area of your windows in m²: ");
                    windowArea = _decimalParse.ParseDecimal(Console.ReadLine());

                    //Perform calculations from user inputs
                    area = _areaCalculator.CalculateArea(width, length);
                    wallArea = _wallAreaCalculator.CalculateWallArea(length, width, height, windowArea, doorArea);
                    volume = _volumeCalculator.CalculateVolume(width, length, height);
                    paintRequired = _paintCalculator.calculateCoverage(wallArea);

                    if (wallArea > 0)
                    {
                        getInput = false;
                    }
                    else
                    {
                        Console.WriteLine("Fenestration area cannot exceed room area");
                    }
                }
                #endregion

                #region Outputs
                //Output results of calculations with context
                Console.WriteLine();
                Console.WriteLine("The floor area of your room is: {0}m²", String.Format("{0:n}", area));
                Console.WriteLine("The wall area needing to be painted is: {0}m²", String.Format("{0:n}", wallArea));
                Console.WriteLine("This would require {0} litres of paint for a single coat", String.Format("{0:n}", paintRequired));
                Console.WriteLine("The volume of your room is: {0}m³", String.Format("{0:n}", volume));
                #endregion

                #region Repeat
                //Prompt user if they want to do another calculation
                Console.WriteLine(); 
                Console.WriteLine("Would you like to do another?");
                Console.WriteLine("Please select: y/n?");
                char input = Console.ReadKey().KeyChar;
                while (input != 'y' && input != 'Y' && input != 'N' && input != 'n')
                {
                    Console.WriteLine();
                    Console.WriteLine("Please only input y/n");
                    input = Console.ReadKey().KeyChar;
                }
                if (input == 'n' || input == 'N')
                {
                    run = false;
                }
                else
                {
                    getInput = true;
                }
                #endregion
            }
        }
    }
}

