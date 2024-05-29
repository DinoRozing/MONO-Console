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
        static List<ServiceItem> serviceItems = new List<ServiceItem>();
        static int nextId = 1;

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?\n");
                Console.WriteLine("1. Vehicle Service Program");
                Console.WriteLine("2. Buy Service Items");
                Console.WriteLine("3. Exit");

                switch (Console.ReadLine())
                {
                    case "1":
                        VehicleServiceProgram();
                        break;
                    case "2":
                        ManageServiceItems();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice, please try again.");
                        break;
                }
            }
        }

        static void VehicleServiceProgram()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Vehicle Service Program!\n");

            Console.WriteLine("What vehicle are you bringing in for a service?\n");
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Motorcycle");
            Console.WriteLine("3. Truck");
            Console.WriteLine("4. Bus\n");

            int userInput = GetValidChoice(4);

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
                    Console.WriteLine("\nInvalid selection.");
                    Console.ReadKey();
                    break;
            }
        }

        static int GetValidChoice(int maxChoice)
        {
            int choice;
            while (true)
            {
                Console.Write("Enter the number of your choice: \n");
                string input = Console.ReadLine();

                if (int.TryParse(input, out choice) && choice >= 1 && choice <= maxChoice)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"\nInvalid selection. Please enter a number between 1 and {maxChoice}.");
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
                Console.WriteLine("\nInvalid input! Please enter 2 or 4.");
                return;
            }

            Console.WriteLine("\nServicing a car...\n");
            Console.ReadKey();

            Car myCar = new Car("BMW", "F82 440i", "Black", 40000, 2017)
            {
                NumberOfDoors = numberOfDoors
            };
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

            int hasCustomExhaust = GetValidChoice(3);

            if (hasCustomExhaust == 3)
            {
                Console.WriteLine("\nUnfortunately we can't perform a service on your vehicle due to the missing part.");
                Console.ReadKey();
                return;
            }

            if (hasCustomExhaust == 1)
            {
                Console.WriteLine("\nGreat! We will proceed with servicing your motorcycle with the aftermarket exhaust.");
            }
            else if (hasCustomExhaust == 2)
            {
                Console.WriteLine("\nAlright! We will proceed with servicing your motorcycle without the aftermarket exhaust.");
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

        static void ManageServiceItems()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Choose an option:\n");
                Console.WriteLine("1. Buy items");
                Console.WriteLine("2. Remove from cart");
                Console.WriteLine("3. Update cart");
                Console.WriteLine("4. View cart");
                Console.WriteLine("5. Exit");

                switch (Console.ReadLine())
                {
                    case "1":
                        AddItem();
                        break;
                    case "2":
                        RemoveItem();
                        break;
                    case "3":
                        UpdateItem();
                        break;
                    case "4":
                        ViewItems();
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice, please try again.");
                        break;
                }
            }
        }

        static void AddItem()
        {
            Console.Write("What would you like to purchase: ");
            string name = Console.ReadLine();

            ServiceItem newItem = new ServiceItem { Id = nextId++, Name = name };
            serviceItems.Add(newItem);
            Console.WriteLine("\nItem added successfully.");
            Console.ReadKey();
        }

        static void RemoveItem()
        {
            Console.Write("Enter item Id to remove: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                ServiceItem itemToRemove = serviceItems.Find(item => item.Id == id);
                if (itemToRemove != null)
                {
                    serviceItems.Remove(itemToRemove);
                    Console.WriteLine("\nItem removed successfully.");
                }
                else
                {
                    Console.WriteLine("\nItem not found.");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid Id.");
            }
            Console.ReadKey();
        }

        static void UpdateItem()
        {
            Console.Write("Enter item Id to update: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                ServiceItem itemToUpdate = serviceItems.Find(item => item.Id == id);
                if (itemToUpdate != null)
                {
                    Console.Write("Enter new item name: ");
                    itemToUpdate.Name = Console.ReadLine();
                    Console.WriteLine("\nItem updated successfully.");
                }
                else
                {
                    Console.WriteLine("\nItem not found.");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid Id.");
            }
            Console.ReadKey();
        }

        static void ViewItems()
        {
            Console.WriteLine("Your cart:");
            foreach (var item in serviceItems)
            {
                Console.WriteLine($"ID: {item.Id}, Name: {item.Name}");
            }
            Console.ReadKey();
        }
    }
}