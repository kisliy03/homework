using System;
using System.Collections.Generic;
using System.Text;
public enum Color
{
    Red,
    Green,
    Blue,
    Yellow,
    Brown,
    White,
    Orange,
    Pink,
    Black
}

namespace TaxiTask
{
    public class Transport
    {
        public string mark { get; }
        public Color color { get; set; }
        public double engine { get; }
        public double price { get; set; }
        public double fuelConsumption { get; }
        public int mileage { get; }

        protected Transport() { }

        protected Transport(string mark, Color color, double engine, double price, double fuelConsumption, int mileage)
        {
            this.mark = mark;
            this.color = color;
            this.engine = engine;
            this.price = price;
            this.fuelConsumption = fuelConsumption;
            this.mileage = mileage;
        }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(mark))
            {
                return base.ToString();
            }

            return "Mark: " + mark +
                "\nColor: " + color +
                "\nEngine: " + engine +
                "\nPrice: " + price +
                "\nFuel consumption: " + fuelConsumption +
                "\nMileage: " + mileage;
        }
    }
}
