using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BorwellSoftwareChallenge.Interfaces;

namespace BorwellSoftwareChallenge
{
    public class AreaCalculator : IAreaCalculator
    {
        public AreaCalculator()
        {
            //Do Nothing
        }

        public decimal CalculateArea(decimal pWidth, decimal pLength)
        {
            decimal area = (pWidth * pLength);
            return area;
        }
    }
}
