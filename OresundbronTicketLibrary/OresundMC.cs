using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundbronTicketLibrary
{
    /// <summary>
    /// Dette repræsentere en motorcykel som kører over Øresundsbroen
    /// </summary>
    public class OresundMC : MC
    {

        public override double Price()
        {
            //Prisen for en motorcykel uden rabat på øresundsbroen er 235 kr
            return 235;
        }

        public override double Price(bool brobizz)
        {
            if (brobizz)
            {
                return 92; //Prisen for en motorcykel med brobizz rabat for øresundsbroen er 92 kr
            }
            return 235; //Hvis der ikke er brobizz rabat er den normale pris for en motorcykel der krydser over Øresundsbroen 235 kr

        }

        //Fortæller at den vehicle som krydser over Øresundsbroen er en Oresund MC
        public override string VehicleType()
        {
            return "Oresund MC";
        }

    }
}
