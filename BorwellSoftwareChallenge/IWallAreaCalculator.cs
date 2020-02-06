using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorwellSoftwareChallenge.Interfaces
{
    public interface IWallAreaCalculator
    {
        decimal CalculateWallArea(decimal length, decimal width, decimal height, decimal windowArea, decimal doorArea);
    }
}
