using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxiTask;

namespace TaxiTestProject
{
    [TestClass]
    public class TestTaxiCar
    {
        [TestMethod]
        public void TestPaintCar()
        {
            TaxiCar car = new TaxiCar("Almaz", "BMW", Color.Black, 2.2, 10000, 10, 40000);

            Color expected = Color.White;
            car.PaintCar(Color.White);
            Color actual = car.color;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestChangePrice()
        {
            TaxiCar car = new TaxiCar("Almaz", "BMW", Color.Black, 2.2, 10000, 10, 40000);

            double expected = 15000;
            car.ChangePrice(15000);
            double actual = car.price;

            Assert.AreEqual(expected, actual);
        }
    }
}
