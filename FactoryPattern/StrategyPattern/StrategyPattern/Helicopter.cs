using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public class Helicopter: Vehicle
    {
        public Helicopter()
        {
            SetAlgorithm(new GoByFlyingAlgorithm());
        }
    }
}
