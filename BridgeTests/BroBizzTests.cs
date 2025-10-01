using Bridge;
namespace BridgeTests;

[TestClass]
public class BroBizzTests
{
    [TestMethod]
    public void Car_Price_WithoutBrobizzReturnsFullPrice()
    {
        var car = new Car();

        var price = car.Price(false);

        Assert.AreEqual(230.0, price, 0.01);
        //Testen tillader en difference på op til 0.01 men tester nu at metoden stadig
        //virker uden Brobizz
    }

    [TestMethod]
    public void Car_Price_WithBroBizz_Returns10PercentDiscount()
    {
        var car = new Car();
        double expectedPrice = 230.0 * 0.9; //Bør give 207

        var price = car.Price(true); //siger her at det er true der er Brobizz discount

        Assert.AreEqual(expectedPrice, price, 0.01); 
        //sammenligner den forventede pris med prisen efter brobizz og tillader en fejl på op til 0.01
    }

    [TestMethod]
    public void MC_Price_WithBrobizz_ReturnsFullPrice()
    {
        var mc = new MC();

        var price = mc.Price(false);

        Assert.AreEqual(120.0, price, 0.01);

    }

    [TestMethod]
    public void MC_Price_WithBrobizz_ReturnsPriceWith10PercentDiscount()
    {
        var mc = new MC();
        double expectedPrice = 120.0 * 0.9;
        var price = mc.Price(true);

        Assert.AreEqual(expectedPrice, price, 0.01);
    }


}
