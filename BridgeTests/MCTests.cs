using Bridge;

namespace BridgeTests;

[TestClass]
public class MCTests
{
    [TestMethod]
    public void MC_Price_ReturnsFixedPrice120()
    {
        var mc = new MC("ABC1234", DateTime.Now);
        var price = mc.Price();

        Assert.AreEqual(120, price);
    }

    [TestMethod]
    public void MC_VehicleType_ReturnsStringMC()
    {
        var mc = new MC("ABC1234", DateTime.Now);
        var vehicleType = mc.VehicleType();

        Assert.AreEqual("MC", vehicleType);
    }
    
}
