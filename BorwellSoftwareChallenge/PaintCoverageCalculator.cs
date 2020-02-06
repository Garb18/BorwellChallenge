using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BorwellSoftwareChallenge.Interfaces;

namespace BorwellSoftwareChallenge
{
    public class PaintCoverageCalculator : IPaintCoverageCalculator
    {
        public PaintCoverageCalculator() 
        {
            //Do nothing
        }

        public decimal calculateCoverage(decimal pInput) 
        {
            //Based on B&Qs wall painting calculator, found here: https://www.diy.com/help-advice/wall-painting-calculator/Dev_npcart_100008.art
            decimal coverage = pInput / 10;

            return coverage;
        }
    }
}
