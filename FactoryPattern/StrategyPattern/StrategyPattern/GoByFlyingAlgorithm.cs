using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StrategyPattern
{
    public class GoByFlyingAlgorithm : IGoAlgorithm
    {
        public void go()
        {
            MessageBox.Show("Now, I'm flying.");
        }
    }
}
