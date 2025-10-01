using System.Security.Cryptography.X509Certificates;

namespace Bridge
{
    public class Car
    {
        public string Licenseplate {  get; set; }
        public DateTime Date { get; set; }

        //Laver en constructor for at teste det i CarTests da jeg lavede en fejl tidligere
        public Car(string licenseplate, DateTime date)
        {
            Licenseplate = licenseplate;
            Date = date;
        }
        public double Price()
        {
            //Returnere en fixed pris
            return 230;
        }
        
        public string VehicleType()
        {
            return "Car";
        }

    }
}
