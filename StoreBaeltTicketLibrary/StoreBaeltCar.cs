using Bridge;
using System;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltCar : Car
    {
        public override double Price(bool brobizz)
        {
            double price = base.Price();

            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                price *= 0.85; //For at få 15% rabat
            }

            if (brobizz)
            {
                price *= 0.9; //For at få 10% rabat med brobizz
            }

            return price;
        }

        public override string VehicleType()
        {
            return "StoreBaelt Car";
        }
    }

}
