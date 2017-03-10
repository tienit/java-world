using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Lession_001
{
    class Plane : AbstractVehicle, IFlyable, IRunnable
    {
        public string Fly()
        {
            return "Flying is my job!";
        }

        public override int Get_Capacity()
        {
            int passengers = 0;//people
            switch (Type)
            {
                case "BOEING_747":
                    passengers = 600;
                    break;
                case "BOEING_777":
                    passengers = 396;
                    break;
                case "BOEING_787":
                    passengers = 290;
                    break;
            }
            return passengers;
        }

        public override double Get_Price()
        {
            double price = 1000000;//USD
            switch (Type)
            {
                case "BOEING_747":
                    price = price * 357;
                    break;
                case "BOEING_777":
                    price = price * 320;
                    break;
                case "BOEING_787":
                    price = price * 189;
                    break;
            }
            return price;
        }

        public string Run()
        {
            return "Planes can also run fast.";
        }
    }
}
