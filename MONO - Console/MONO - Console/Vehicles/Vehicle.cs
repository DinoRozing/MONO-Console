using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MONO___Console.Vehicles
{
    public abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public int Year { get; set; }

        public Vehicle(string make, string model, string color, decimal price, int year)
        {
            Make = make;
            Model = model;
            Color = color;
            Price = price;
            Year = year;
        }

        public void StartEngine() { Console.WriteLine("Starting the engine..."); }
        public void StopEngine() { Console.WriteLine("Shuting off the engine..."); }
        public void DisplayInfo() { Console.WriteLine("Showing information: "); }
        public void Honk() { Console.WriteLine("Honk..."); }
        public void Refuel() { Console.WriteLine("Refueling..."); }

        public abstract void Drive();
    }
}
