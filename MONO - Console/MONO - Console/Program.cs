using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MONO___Console.Vehicles;

namespace MONO___Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Vehicle Service Program!\n");

            Console.WriteLine("Which vehicle do you bring for service?\n");
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Motorcycle");
            Console.WriteLine("3. Truck");
            Console.WriteLine("4. Bus\n");

            int userInput = GetValidChoice();

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Getting your car ready for a service! \nBefore we start, I would like to ask you a couple of questions about the vehicle.");
                    Console.ReadKey();
                    ServiceCar();
                    break;
                case 2:
                    Console.WriteLine("Getting your motorcycle ready for a service! \nBefore we start, I would like to ask you a couple of questions about the vehicle.");
                    Console.ReadKey();
                    ServiceMotorcycle();
                    break;
                case 3:
                    Console.WriteLine("Getting your truck ready for a service!");
                    Console.ReadKey();
                    ServiceTruck();
                    break;
                case 4:
                    Console.WriteLine("Getting your bus ready for a service!");
                    Console.ReadKey();
                    ServiceBus();
                    break;
                default:
                    Console.WriteLine("Invalid selection.");
                    Console.ReadKey();
                    break;
            }
        }

        static int GetValidChoice()
        {
            int choice;
            while (true)
            {
                Console.Write("Enter the number of your choice: \n");
                string input = Console.ReadLine();

                if (int.TryParse(input, out choice) && choice >= 1 && choice <= 4)
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please enter a number between 1 and 4.");
                }
            }
            return choice;
        }

        static void ServiceCar()
        {
            Console.WriteLine("\nHow many doors does your car have? (2 or 4):");
            string numberOfDoorsInput = Console.ReadLine();
            int numberOfDoors;
            if (!int.TryParse(numberOfDoorsInput, out numberOfDoors) || (numberOfDoors != 2 && numberOfDoors != 4))
            {
                Console.WriteLine("Invalid input! Please enter 2 or 4.");
                return;
            }

            Console.WriteLine("\nServicing a car...\n");
            Console.ReadKey();

            Car myCar = new Car("BMW", "F82 440i", "Black", 40000, 2017);
            myCar.NumberOfDoors = numberOfDoors;
            myCar.DisplayInfo();
            myCar.StartEngine();
            myCar.StopEngine();
            myCar.Honk();
            myCar.Refuel();
            myCar.StartAutopilot();
            myCar.StopAutopilot();
            myCar.Drive();

            Console.ReadKey();
            Console.WriteLine("\nYour service is done.");
            Console.ReadKey();
        }

        static void ServiceMotorcycle()
        {
            Console.WriteLine("Does your motorcycle come with an aftermarket exhaust?\n");
            Console.WriteLine("1. Yes, it does.");
            Console.WriteLine("2. No, it doesn't.");
            Console.WriteLine("3. It doesn't even have an exhaust.");

            string exhaustInput = Console.ReadLine();
            int HasCustomExhaust;
            if (!int.TryParse(exhaustInput, out HasCustomExhaust) || (HasCustomExhaust < 1 || HasCustomExhaust > 3))
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 3.");
                return;
            }

            if (HasCustomExhaust == 3)
            {
                Console.WriteLine("Unfortunately we can't perform a service on your vehicle due to the missing part.");
                return;
            }

            if (HasCustomExhaust == 1)
            {
                Console.WriteLine("Great! We will proceed with servicing your motorcycle with the aftermarket exhaust.");
            }
            else if (HasCustomExhaust == 2)
            {
                Console.WriteLine("Alright! We will proceed with servicing your motorcycle without the aftermarket exhaust.");
            }

            Console.WriteLine("\nServicing a motorcycle...");

            Motorcycle myMotorcycle = new Motorcycle("HONDA", "CB 500 FA", "Orange", 5000, 2017);
            myMotorcycle.DisplayInfo();
            myMotorcycle.StartEngine();
            myMotorcycle.StopEngine();
            myMotorcycle.Honk();
            myMotorcycle.Refuel();
            myMotorcycle.Drive();

            Console.ReadKey();
            Console.WriteLine("\nYour service is done.");
            Console.ReadKey();
        }

        static void ServiceBus()
        {
            Console.WriteLine("\nServicing a bus...");

            Bus myBus = new Bus("Volvo", "XC90", "Blue", 60000, 2018);
            myBus.DisplayInfo();
            myBus.StartEngine();
            myBus.StopEngine();
            myBus.Honk();
            myBus.Refuel();
            myBus.Drive();

            Console.ReadKey();
            Console.WriteLine("\nYour service is done.");
            Console.ReadKey();
        }

        static void ServiceTruck()
        {
            Console.WriteLine("\nServicing a truck...");

            Truck myTruck = new Truck("MAN", "TGS", "Red", 80000, 2019);
            myTruck.DisplayInfo();
            myTruck.StartEngine();
            myTruck.StopEngine();
            myTruck.Honk();
            myTruck.Refuel();
            myTruck.Drive();

            Console.ReadKey();
            Console.WriteLine("\nYour service is done.");
            Console.ReadKey();
        }
    }
}
