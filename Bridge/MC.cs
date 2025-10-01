using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// MC Class inherits fra Vehicle class 
    /// </summary>
    public class MC : Vehicle
    {
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }


        public MC(string licenseplate, DateTime date)
        {
            Licenseplate = licenseplate;
            Date = date;
        }

        public override double Price()
        {
            return 120;
        }

        public override string VehicleType()
        {
            return "MC";
        }

    }
}
