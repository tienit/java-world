using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Lession_001
{
    class Dogs : AbstractAnimal, IRunnable, IEatable
    {
        protected override string Get_Declaration()
        {
            return "Dogs are loyal animals.";
        }

        protected override int Get_Number_Of_Legs()
        {
            return 4;
        }

        protected override string Get_Remark()
        {
            return base.Get_Remark();
        }

        protected override string Get_HelloWorld()
        {
            return base.Get_HelloWorld();
        }

        public string Run()
        {
            return "Dogs can run by 4 legs.";
        }

        public string CanEat()
        {
            return "Dog meat is favorite meal of Vietnamese.";
        }
    }
}
