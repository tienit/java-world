using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Lession_001
{
    class Birds : AbstractAnimal, IFlyable, IEatable, IRunnable
    {
        public string CanEat()
        {
            return "Birds can also become food.";
        }

        public string Fly()
        {
            return "Birds can fly in the sky.";
        }

        public string Run()
        {
            return "Birds can also run.";
        }

        public override string Get_Declaration()
        {
            return "Birds are symbols of peace.";
        }

        public override int Get_Number_Of_Legs()
        {
            return 2;
        }
    }
}
