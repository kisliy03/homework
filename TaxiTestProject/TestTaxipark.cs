using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxiTask;

namespace TaxiTestProject
{
    [TestClass]
    public class TestTaxipark
    {
        [TestMethod]
        public void TestGetCountCars()
        {
            Taxipark tp = new Taxipark(new TaxiCar[2] {new TaxiCar(), new TaxiCar() }, "AlmazCompany", "Almaz");

            int expected = 2;
            int actual = tp.GetCountCars();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddCar()
        {
            Taxipark tp = new Taxipark("AlmazCompany", "Almaz");
            tp.AddCar(new TaxiCar());

            int expected = 1;
            int actual = tp.GetCountCars();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDeleteCar()
        {
            Taxipark tp = new Taxipark(new TaxiCar[2] {new TaxiCar(), new TaxiCar() }, "AlmazCompany", "Almaz");
            tp.DeleteCar(1);

            int expected = 1;
            int actual = tp.GetCountCars();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTaxiparkCost()
        {
            TaxiCar car1 = new TaxiCar("Almaz", "BMW", Color.Black, 2.2, 1500, 2.2, 23400);
            TaxiCar car2 = new TaxiCar("Almaz", "Mercedes-Benz", Color.White, 3.2, 2200, 2.0, 34400);
            Taxipark tp = new Taxipark("AlmazCompany", "Almaz");

            tp.AddCar(car1);
            tp.AddCar(car2);

            double expected = 3700;
            double actual = tp.GetTaxiparkCost();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFindCar()
        {
            TaxiCar car1 = new TaxiCar("Almaz", "BMW", Color.Black, 2.2, 1500, 2.2, 23400);
            TaxiCar car2 = new TaxiCar("Almaz", "Mercedes-Benz", Color.White, 3.2, 2200, 2.0, 34400);
            Taxipark tp = new Taxipark("AlmazCompany", "Almaz");

            tp.AddCar(car1);
            tp.AddCar(car2);

            TaxiCar expected = car2;
            TaxiCar actual = tp.FindCar("Mercedes-Benz", Color.White, 3.2, 2200, 2.0);

            Assert.AreEqual(expected, actual);
        }
    }
}
