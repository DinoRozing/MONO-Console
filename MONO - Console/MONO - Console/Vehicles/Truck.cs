using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MONO___Console.Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(string make, string model, string color, decimal price, int year)
            : base(make, model, color, price, year) { }

        public double CargoCapacity { get; set; }
        public override void Drive()
        {
            Console.WriteLine($"{Make} {Model} drives perfectly!");
        }
    }
}
