using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public abstract class Vehicle
    {
        private IGoAlgorithm goAlgorithm;

        //public Vehicle()
        //{

        //}

        public void SetAlgorithm(IGoAlgorithm algorithm)
        {
            goAlgorithm = algorithm;
        }

        public void go()
        {
            goAlgorithm.go();
        }
    }
}
