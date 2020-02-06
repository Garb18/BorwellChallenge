using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BorwellSoftwareChallenge.Interfaces;

namespace BorwellSoftwareChallenge
{
    public class WallAreaCalculator : IWallAreaCalculator
    {
        public WallAreaCalculator() 
        {
            //Do nothing
        }

        public decimal CalculateWallArea(decimal pLength, decimal pWidth, decimal pHeight, decimal pWindowArea, decimal pDoorArea) 
        {
            decimal wallArea = ((2 * pLength * pHeight) + (2 * pWidth * pHeight)) - (pDoorArea + pWindowArea);
            return wallArea;
        }
    }
}
