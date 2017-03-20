using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public class FormulaOne: Vehicle
    {
        public FormulaOne()
        {
            SetAlgorithm(new GoByDrivingAlgorithm());
        }
    }
}
