using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public class Jet:Vehicle
    {
        public Jet()
        {
            SetAlgorithm(new GoByFlyingFastAlgorithm());
        }
    }
}
