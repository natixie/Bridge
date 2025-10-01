using System.Security.Cryptography.X509Certificates;

namespace Bridge
{
    public class Car
    {
        /// <summary>
        /// Properties for VehicleType Car som skal returnere en fixed pris og string "Car"
        /// </summary>
        public string Licenseplate {  get; set; }
        public DateTime Date { get; set; }
        /// <summary>
        /// Lavede en constructor for at få parametrene licenseplate og DateTime date ind i test metoderne.
        /// </summary>
        /// <param name="licenseplate"></param>
        /// <param name="date"></param>
        //Laver en constructor for at teste det i CarTests da jeg lavede en fejl tidligere
        public Car(string licenseplate, DateTime date)
        {
            Licenseplate = licenseplate;
            Date = date;
        }
        
        /// <summary>
        /// Returnering af fixed pris på 230 kr
        /// </summary>
        /// <returns></returns>
        public double Price()
        {
            //Returnere en fixed pris
            return 230;
        }
        /// <summary>
        /// Returnering af Vehicle Type "Car"
        /// </summary>
        /// <returns></returns>
        public string VehicleType()
        {
            return "Car";
        }

    }
}
