﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorwellSoftwareChallenge.Interfaces
{
    public interface IVolumeCalculator
    {
        decimal CalculateVolume(decimal width, decimal length, decimal height);
    }
}
