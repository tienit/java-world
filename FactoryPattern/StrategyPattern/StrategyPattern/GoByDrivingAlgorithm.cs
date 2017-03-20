using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StrategyPattern
{
    public class GoByDrivingAlgorithm : IGoAlgorithm
    {
        public void go()
        {
            MessageBox.Show("Now, I', driving.");
        }
    }
}
