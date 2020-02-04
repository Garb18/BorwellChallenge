using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorwellSoftwareChallenge.Interfaces
{
    public interface IPaintCoverageCalculator
    {
        decimal calculateCoverage(decimal pInput);
    }
}
