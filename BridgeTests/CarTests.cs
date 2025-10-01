using Bridge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BridgeTests
{
    /// <summary>
    /// Test metoder for fixed pris på bil med license plate og DateTime sat ind pga. constructoren i Car class
    /// </summary>
    [TestClass]
    public class CarTests
    {
        /// <summary>
        /// Her testes at bilens pris på 230 matcher metoden Price() med 230
        /// </summary>
        [TestMethod]
        public void Car_Price_ReturnsFixedPrice230()
        {
            var car = new Car();
                car.LicensePlate ="ABCD123";
                car.Date = DateTime.Now;

            var price = car.Price();

            //Tjekker at prisen bliver returneret som præcis 230
            Assert.AreEqual(230, price);
        }

        /// <summary>
        /// Her testes at VehicleType() metoden returnere string "Car" med VehicleType
        /// </summary>
        [TestMethod]
        public void Car_VehicleType_ReturnsCarString()
        {
            //skal indføre parametrene fordi jeg har sat dem ind i min constructor også
            var car = new Car();
            car.LicensePlate = "ABCD123";
            car.Date = DateTime.Now;
            var vehicleType = car.VehicleType();

            //Tjekker her at VehicleType beliver returneret med string "Car" ligesom VehicleType() metoden i Car class
            Assert.AreEqual("Car", vehicleType);
        }

    }
}
