using StoreBaeltTicketLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StoreBaeltTests
{
    [TestClass]
    public class StoreBaeltCarTests
    {
        [TestMethod]
        public void StoreBaeltCar_Price_WeekdayWithoutBrobizzDiscount_ReturnFullPrice()
        {
            var car = new StoreBaeltCar();

            ///Dato sat til d. 2. oktober hvilket er en torsdag (ikke weekend dag)
            car.Date = new DateTime(2025, 10, 2);

            // Siger her false for at indikere at brobizz discount ikke er indkluderet
            var price = car.Price(false);

            //Prisen skal stadig være den normale pris på 230 uden discounts
            Assert.AreEqual(230.0, price, 0.01);
        }

        [TestMethod]
        public void StoreBaeltCar_Price_SaturdayWithoutBrobizz_Returns15percentDiscount()
        {
            var car = new StoreBaeltCar();
            car.Date = new DateTime(2025, 10, 4); //Lørdag d. 4. oktober 2025

            double expectedPrice = 230.0 * 0.85; // 15% rabat forventes at give 195.5

            //Stadig false fordi der bliver testet uden brobizz rabat, men med weekend rabat
            var price = car.Price(false);

            Assert.AreEqual(expectedPrice, price, 0.01);
        }

        // Tester også at søndag virker for weekend rabat
        [TestMethod]
        public void StoreBaeltCar_Price_SundayWithoutBrobizz_Returns15percentDiscount()
        {
            var car = new StoreBaeltCar();
            car.Date = new DateTime(2025, 10, 5); //Søndag d. 5. oktober 2025

            double expectedPrice = 230.0 * 0.85; // 15% rabat forventes at give 195.5

            var price = car.Price(false);

            Assert.AreEqual(expectedPrice, price, 0.01);
        }

        [TestMethod]
        public void StoreBaeltCar_Price_WeekdayWithBrobizz_ReturnsBrobizzDiscount()
        {
            var car = new StoreBaeltCar();
            car.Date = new DateTime(2025, 10, 2); //Torsdag d. 2. oktober

            double expectedPrice = 230.0 * 0.9; // 10 % Brobizz rabat

            // True fordi der nu skal testes for brobizz rabatten på en ugedag
            var price = car.Price(true);

            Assert.AreEqual(expectedPrice, price, 0.01);

        }
        // Tester for lørdag weekends rabat med brobizz rabat
        [TestMethod]
        public void StoreBaeltCar_Price_SaturdayWithBrobizz_ReturnsBothWeekendAndBrobizz()
        {
            var car = new StoreBaeltCar();
            car.Date = new DateTime(2025, 10, 4); //Lørdag d. 4. oktober 2025

            double expectedPrice = 230.0 * 0.85 * 0.9;

            var price = car.Price(true);

            Assert.AreEqual(expectedPrice, price, 0.01);
        }

        [TestMethod]
        public void StoreBaeltCar_Price_SundayWithBrobizz_ReturnsBothWeekendAndBrobizz()
        {
            var car = new StoreBaeltCar();
            car.Date = new DateTime(2025, 10, 5); //Søndag d. 5. oktober 2025

            double expectedPrice = 230.0 * 0.85 * 0.9;

            var price = car.Price(true);

            Assert.AreEqual(expectedPrice, price, 0.01);
        }

        [TestMethod]
        public void StoreBaeltCar_VehicleType_ReturnsStorebaeltCarString()
        {
            var car = new StoreBaeltCar();

            var vehicleType = car.VehicleType();

            Assert.AreEqual("StoreBaelt Car", vehicleType);
        }
    }
}
