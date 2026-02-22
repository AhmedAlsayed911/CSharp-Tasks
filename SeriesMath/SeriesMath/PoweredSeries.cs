using System;
using System.Collections.Generic;
using System.Text;

namespace SeriesMath
{
    internal class PoweredSeries : ISeries
    {
        int nxtNumber = 1;
        public int GetNextNumber()
        {
            int d = nxtNumber;
            nxtNumber *= 2;
            return d;
        }
    }
}
