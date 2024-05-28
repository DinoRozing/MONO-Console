using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MONO___Console.Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(string make, string model, string color, decimal price, int year)
            : base(make, model, color, price, year) { }

        public int NumberOfSeats { get; set; }
        public override void Drive()
        {
            Console.WriteLine($"{Make} {Model} drives perfectly!");
        }
    }
}
