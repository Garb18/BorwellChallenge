using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BorwellSoftwareChallenge.Interfaces;

namespace BorwellSoftwareChallenge
{
    class PaintCoverageCalculator : IPaintCoverageCalculator
    {
        public PaintCoverageCalculator() 
        {
            //Do nothing
        }

        public decimal calculateCoverage(decimal pInput) 
        {
            decimal coverage = pInput / 10;

            return coverage;
        }
    }
}
