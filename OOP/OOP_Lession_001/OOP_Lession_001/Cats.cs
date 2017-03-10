using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Lession_001
{
    class Cats : AbstractAnimal, IEatable, IRunnable, IClimbable
    {
        public string CanEat()
        {
            return "Cat meat is favorite meal of Vietnamese.";
        }

        public string Climb()
        {
            return "Cats can climb.";
        }

        public string Run()
        {
            return "Cats run fast.";
        }

        protected override string Get_Declaration()
        {
            return "Cat are mammals.";
        }

        protected override int Get_Number_Of_Legs()
        {
            return 4;
        }
    }
}
