namespace Bridge
{
    public class Car
    {
        public string Licenseplate {  get; set; }
        public DateTime Date { get; set; }

        
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
