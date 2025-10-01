using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Abstract class for at MC class og Car class kan inherit fra denne
    /// </summary>
    public abstract class Vehicle
    {
        private string _licensePlate;


        public string LicensePlate
        {
            get => _licensePlate;
            set => _licensePlate = value;
        }

        public DateTime Date { get; set; }

        public abstract double Price();
        public abstract string VehicleType();



    }
}
