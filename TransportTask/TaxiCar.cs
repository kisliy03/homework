using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiTask
{
    public class TaxiCar : Transport
    {
        public string company { get; set; }

        public TaxiCar() { }

        public TaxiCar(string company, string mark, Color color, double engine, double price, double fuelConsumption, int mileage) :
            base(mark, color, engine, price, fuelConsumption, mileage)
        {
            this.company = company;
        }

        public void Ride()
        {
            Console.WriteLine("Brrrr....");
        }

        public void PaintCar(Color color)
        {
            this.color = color;
        }

        public void ChangePrice(double price)
        {
            this.price = price;
        }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(mark))
            {
                return base.ToString();
            }

            return base.ToString() +
                "\nCompany: " + company;
        }

        public override int GetHashCode()
        {
            return company.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            TaxiCar car = (TaxiCar)obj;
            return (this.company == car.company);
        }
    }
}
