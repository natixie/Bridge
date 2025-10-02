using OresundbronTicketLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace OresundBronTests
{
    [TestClass]
    public class OresundCarTests
    {
        [TestMethod]
        public void OresundCar_Price_WithoutBrobizzReturns460()
        {
            var car = new OresundCar();

            // False fordi der testes for prisen uden brobizz rabat
            var price = car.Price(false);

            Assert.AreEqual(460.0, price, 0.01);
        }

        //Test for at prisen med brobizz rabat er 178 kr
        [TestMethod]
        public void OresundCar_Price_WithBrobizzReturns178()
        {
            var car = new OresundCar();

            var price = car.Price(true);

            Assert.AreEqual(178.0, price, 0.01);
        }


        [TestMethod]
        public void OresundCar_VehicleTypeReturnsStringOresundCar()
        {
            var car = new OresundCar();

            var vehicleType = car.VehicleType();

            Assert.AreEqual("Oresund Car", vehicleType);
        }
    }
}
