using Bridge;

namespace OresundbronTicketLibrary
{
    /// <summary>
    /// Skal representere en bil som køre over Øresunds broen
    /// </summary>
    public class OresundCar : Car
    {
        //prisen for biler der krydser over Øresundsbroen er 460 kr.
        public override double Price()
        {
            return 460;
        }

        public override double Price(bool brobizz)
        {
            if (brobizz)
            {
                return 178; //pris for biler med brobizz rabat for øresundsbroen
            }

            return 460; //Hvis brobizz rabatten ikke er true, så forbliver det normal pris uden rabat
        
        }

        /// <summary>
        /// Fortæller at det er en Oresund Car som kryder over Øresundsbroen
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "Oresund Car";
        }
        
    }
}
