using System.Collections;
using System.Net.Http.Headers;

namespace Ch12VehiclesFleet
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ch. 12 Console Project: Fleet of Vehicles by Brandon Phillips\n");

            // array list
            ArrayList vehicles = new ArrayList();

            // hardcoded vehicles
            Car car0 = new Car("Toyota", "Corolla", "Red", "hybrid", 2019, 4, false);
            Truck truck0 = new Truck("Ford", "F250", "White", "diesel", 2012, 4, 70, false);
            Car car1 = new Car("Acura", "TSX", "Black", "gas", 2008, 4, true);
            Truck truck1 = new Truck("Dodge", "RAM", "Yellow", "diesel", 2019, 2, 70, true);
            Car car2 = new Car("BMW", "M2", "Blue", "gas", 2020, 2, true);
            Truck truck2 = new Truck("GMC", "Sierra", "White", "gas", 2020, 4, 66, false);

            // add vehicles to array list
            vehicles.Add(car0);
            vehicles.Add(truck0);
            vehicles.Add(car1);
            vehicles.Add(truck1);
            vehicles.Add(car2);
            vehicles.Add(truck2);


            // display all vehicles
            foreach (Vehicle vehicle in vehicles)
            {
                // check the vehicle type and print to console
                if (vehicle is Car)
                {
                    Car car = (Car)vehicle;
                    Console.WriteLine(car.ToString());
                }

                else if (vehicle is Truck)
                {
                    Truck truck = (Truck)vehicle;
                    Console.WriteLine(truck.ToString());
                }
            }

            // loop through user options
            string reply = "";
            do
            {
                Console.Write("\nWhat type of vehicle do you want to see, (c)Car or (t)Truck or (d)Done? ");
                reply = Console.ReadLine().ToLower();

                // user input switch
                switch (reply)
                {
                    case "c":
                        // display cars
                        {
                            foreach (Vehicle vehicle in vehicles)
                            {
                                if (vehicle is Car)
                                {
                                    Car car = (Car)vehicle;
                                    Console.WriteLine(car.ToString());
                                }
                            }
                        }
                        break;
                    case "t":
                        // display trucks
                        {
                            foreach (Vehicle vehicle in vehicles)
                            {
                                if (vehicle is Truck)
                                {
                                    Truck truck = (Truck)vehicle;
                                    Console.WriteLine(truck.ToString());
                                }
                            }
                        }
                        break;
                    case "d":
                        break;
                    default:
                        Console.WriteLine("Not a valid option...");
                        break;
                }
            } while (reply != "d");

            // user input loop
            bool repeat = false;
            ArrayList results;
            // restart loop if the program hits an input exception
            do
            {
                // ask user for a year, must be an int
                Console.Write("\nWhich vehicle year? ");
                try
                {
                    int year = int.Parse(Console.ReadLine());

                    // add results to a new Array List
                    results = FindByYear(vehicles, year);

                    // display results in the console
                    foreach (Vehicle result in results)
                    {
                        // check the vehicle type and print to console
                        if (result is Car)
                        {
                            Car car = (Car)result;
                            Console.WriteLine(car.ToString());
                        }

                        else if (result is Truck)
                        {
                            Truck truck = (Truck)result;
                            Console.WriteLine(truck.ToString());
                        }
                    }

                    // ask user for a make
                    Console.Write("\nWhich vehicle make? ");
                    string make = Console.ReadLine();
                    ArrayList newResults = FindByMake(results, make);

                    // display results in the console
                    foreach (Vehicle result in newResults)
                    {
                        // check the vehicle type and print to console
                        if (result is Car)
                        {
                            Car car = (Car)result;
                            Console.WriteLine(car.ToString());
                        }

                        else if (result is Truck)
                        {
                            Truck truck = (Truck)result;
                            Console.WriteLine(truck.ToString());
                        }
                    }
                    repeat = false;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    repeat = true;
                }
            } while (repeat);

            // exit program
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // find vehicle by year
        static ArrayList FindByYear(ArrayList vehicles, int year)
        {
            ArrayList results = new ArrayList();
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.GetYear() == year)
                {
                    results.Add(vehicle);
                }
            }
            return results;
        }

        // find vehicle by make
        static ArrayList FindByMake(ArrayList vehicles, string make)
        {
            ArrayList results = new ArrayList();
            foreach (Vehicle vehicle in vehicles)
            {
                // check results with ToLower to make input easier
                if (vehicle.GetMake().ToLower() == make.ToLower())
                {
                    results.Add(vehicle);
                }
            }
            return results;
        }
    }
}