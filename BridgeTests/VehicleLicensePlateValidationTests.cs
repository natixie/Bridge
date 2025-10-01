using Bridge;
namespace BridgeTests;

[TestClass]
public class VehicleLicensePlateValidationTests
{
    [TestMethod]
    public void CarLicensePlate_ValidLength_DoesNotThrowException()
    {
        var car = new Car();

        car.LicensePlate = "ABC1234";


        //Bør ikke kaste en exception
        Assert.AreEqual("ABC1234", car.LicensePlate);

    }

    [TestMethod]
    public void Car_LicensePlate_IsExactlySevenCharacters_DoesNotThrowException()
    {
        var car = new Car();

        car.LicensePlate = "ABC1234";

        //Bør ikke kaste en exception
        Assert.AreEqual("ABC1234", car.LicensePlate);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Car_LicensePlate_ExceedsSevenCharacters_ThrowsArgumentException()
    {
        var car = new Car();

        car.LicensePlate = "ABCD1234";
    }

    [TestMethod]
    public void MC_licensePlate_ValidLength_DoesNotThrowException()
    {
        var mc = new MC();
        mc.LicensePlate = "MCA123"; //6 characters hvilket er mindre end 7, bør ikke throw exception
        Assert.AreEqual("MCA123", mc.LicensePlate);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void MC_LicensePlate_ExceedsSevenCharacters_ThrowsArgumentException()
    {
        var mc = new MC();
        mc.LicensePlate = "MCABC1234"; //Mere end 7 characters, bør kaste exception
    }

    [TestMethod]
    public void Vehicle_LicensePlate_NullOrEmpty_DoesNotThrowException()
    {

        //Bør ikke kaste exception
        var car = new Car();
        car.LicensePlate = null;
        Assert.IsNull(car.LicensePlate);

        car.LicensePlate = "";
        Assert.AreEqual("", car.LicensePlate);
    }
}
