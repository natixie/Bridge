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
            set
            {
                // license plate værdien må ikke være tom og/eller mere end 7 characters, hvis den er skal den kaste fejlen og sige "License plate must not be longer than 7 characters"
                if (!string.IsNullOrEmpty(value) && value.Length > 7)
                {
                    throw new ArgumentException("License plate must not be longer than 7 characters");
                }

                _licensePlate = value;
            }
        }



        public DateTime Date { get; set; }

        public abstract double Price();

        public abstract string VehicleType();



    }
}
