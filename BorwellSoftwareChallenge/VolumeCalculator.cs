using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BorwellSoftwareChallenge.Interfaces;

namespace BorwellSoftwareChallenge
{
    public class VolumeCalculator : IVolumeCalculator
    {
        public VolumeCalculator() 
        {
            //Do nothing
        }

        public decimal CalculateVolume(decimal pWidth, decimal pLength, decimal pHeight) 
        {
            decimal volume = pWidth * pLength * pHeight;
            return volume;
        }
    }
}
