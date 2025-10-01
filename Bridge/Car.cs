using System.Security.Cryptography.X509Certificates;

namespace Bridge
{
    /// <summary>
    /// Car class inherits fra Vehicle class 
    /// </summary>
    public class Car : Vehicle
    {
        
        
        /// <summary>
        /// Returnering af fixed pris på 230 kr
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            //Returnere en fixed pris
            return 230;
        }
        /// <summary>
        /// Returnering af Vehicle Type "Car"
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "Car";
        }

    }
}
