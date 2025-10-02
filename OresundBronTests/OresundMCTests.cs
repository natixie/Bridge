using OresundbronTicketLibrary;

namespace OresundBronTests;

[TestClass]
public class OresundMCTests
{

    [TestMethod]
    public void OresundMC_Price_WithoutBrobizzReturns235()
    {
        var mc = new OresundMC();

        var price = mc.Price(false);

        Assert.AreEqual(235.0, price, 0.01);
    }

    [TestMethod]
    public void OresundMC_Price_WithBrobizzReturns92()
    {
        var mc = new OresundMC();

        var price = mc.Price(true);

        Assert.AreEqual(92.0, price, 0.01);
    }

    [TestMethod]
    public void OresundMC_VehicleTypeReturnsStringOresundMC()
    {
        var mc = new OresundMC();

        var vehicleType = mc.VehicleType();

        Assert.AreEqual("Oresund MC", vehicleType);
    }
}
