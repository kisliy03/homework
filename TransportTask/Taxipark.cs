using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiTask
{
    public class Taxipark
    {
        public TaxiCar[] cars;
        private int countCars;
        private int capacity { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        public Taxipark(TaxiCar[] cars, string address, string name)
        {
            this.cars = cars;
            this.name = name;
            this.address = address;
            countCars = cars.Length;
            capacity = cars.Length * 2;
        }

        public Taxipark(string address, string name)
        {
            cars = new TaxiCar[10];
            this.name = name;
            this.address = address;
            countCars = 0;
            capacity = 10;
        }

        public Taxipark(Taxipark taxipark)
        {

        }

        public int GetCountCars()
        {
            return countCars;
        }

        private TaxiCar[] Expansion()
        {
            capacity *= 2;
            TaxiCar[] newCars = new TaxiCar[capacity];

            for (int index = 0; index < countCars; index++)
            {
                newCars[index] = cars[index];
            }

            return newCars;
        }

        public void AddCar(TaxiCar car)
        {
            if (countCars >= capacity)
            {
                cars = Expansion();
            }

            cars[countCars++] = car;
        }

        public void DeleteCar(int index)
        {
            for (int i = index; i < countCars - 1; i++)
            {
                cars[i] = cars[i + 1];
            }

            countCars--;
        }

        public double GetTaxiparkCost()
        {
            double cost = 0;

            for (int index = 0; index < countCars; index++)
            {
                cost += cars[index].price;
            }

            return cost;
        }

        public void SortCarsByFuel()
        {
            TaxiCar tempCar;

            for (int i = 0; i < countCars; i++)
            {
                for (int j = i + 1; j < countCars; j++)
                {
                    if(cars[i].fuelConsumption > cars[j].fuelConsumption)
                    {
                        tempCar = cars[i];
                        cars[i] = cars[j];
                        cars[j] = tempCar;
                    }
                }
            }
        }

        public TaxiCar FindCar(string mark, Color color, double engine, double price, double fuelConsumption)
        {
            TaxiCar car = new TaxiCar();

            for (int index = 0; index < countCars; index++)
            {
                if (cars[index].mark == mark &&
                    cars[index].color == color &&
                    cars[index].engine == engine &&
                    cars[index].price == price &&
                    cars[index].fuelConsumption == fuelConsumption)
                {
                    car = cars[index];
                    break;
                }
            }
            
            return car;
        }

        public override string ToString()
        {
            return base.ToString() + 
                "\nName taxipark: " + name +
                "\nAddress: " + address;
        }
    }

}
