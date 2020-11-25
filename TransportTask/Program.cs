using System;

namespace TaxiTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Use();
        }

        public static void Use()
        {
            TaxiCar car1 = new TaxiCar("Almaz", "BMW", Color.Black, 2.9, 1000.6, 12, 2567000);
            TaxiCar car2 = new TaxiCar("Almaz", "Mercedes-benz", Color.White, 3.2, 1200, 8, 5567000);
            TaxiCar car3 = new TaxiCar("Almaz", "Nissan", Color.Yellow, 1.2, 450, 9, 7677000);
            Taxipark cc1 = new Taxipark("Almaz", "Almaz");
            cc1.AddCar(car1);
            cc1.AddCar(car2);
            cc1.AddCar(car3);
            cc1.AddCar(car1);
            cc1.AddCar(car2);
            cc1.AddCar(car3);
            cc1.AddCar(car1);
            cc1.AddCar(car2);
            cc1.AddCar(car3);
            cc1.AddCar(car1);
            cc1.AddCar(car2);
            cc1.AddCar(car3);

            cc1.SortCarsByFuel();

            Console.WriteLine(cc1.FindCar("BMW", Color.Black, 2.9, 1000.6, 12));
        }
    }
}
