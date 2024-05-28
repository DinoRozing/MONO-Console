using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MONO___Console.Interfaces;

namespace MONO___Console.Vehicles
{
    public class Car : Vehicle, IAutonomous
    {
        public Car(string make, string model, string color, decimal price, int year)
            : base(make, model, color, price, year) { }

        public int NumberOfDoors { get; set; }

        public bool IsSelfDrivingActive { get; private set; }

        public void StartAutopilot()
        {
            IsSelfDrivingActive = true;
            Console.WriteLine($"{Make} {Model} autopilot activated!");
        }

        public void StopAutopilot()
        {
            IsSelfDrivingActive = false;
            Console.WriteLine($"{Make} {Model} autopilot deactivated!");
        }

        public override void Drive()
        {
            Console.WriteLine($"{Make} {Model} drives perfectly!");
        }
    }
}
