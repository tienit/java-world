using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public class StreetRacer: Vehicle
    {
        public StreetRacer()
        {
            SetAlgorithm(new GoByDrivingAlgorithm());
        }
    }
}
