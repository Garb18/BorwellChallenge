using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorwellSoftwareChallenge.Interfaces
{
    public interface IParseFromInput
    {
        decimal ParseDecimal(string input);

        int ParseInteger(string input);

        float ParseFloat(string input);
    }
}
