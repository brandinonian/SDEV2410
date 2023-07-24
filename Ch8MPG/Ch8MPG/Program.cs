internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ch 8 Console Project: MPG for Multiple Trips by Brandon Phillips\n");

        double totalGallons = 0;
        double totalMiles = 0;
        int numTrips = 0;
        string reply = "";

        // program
        do
        {
            try
            {
                Console.Write("\nEnter miles travelled (-1 to quit): ");
                double userMiles = double.Parse(Console.ReadLine());
                if (userMiles != -1)
                {
                    if (userMiles <= 0)
                    {
                        throw new Exception("Miles must be > 0");
                    }
                    else
                    {
                        Console.Write("Enter gallons used: ");
                        double userGallons = double.Parse(Console.ReadLine());
                        if (userGallons <= 0)
                        {
                            throw new Exception("Gallons must be > 0");
                        }
                        else
                        {
                            double tripMPG = CalculateMPG(userMiles, userGallons, ref totalMiles, ref totalGallons, ref numTrips);
                            Console.WriteLine($"MPG for this trip is {tripMPG}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                do
                {
                    Console.Write("More trips to enter? (y/n) ");
                    reply = Console.ReadLine();
                } while (reply != "y" && reply != "n");
            }
        } while (reply == "y");
        // calculate total MPG
        if (numTrips == 0)
        {
            Console.WriteLine("No trips entered");
        }
        else
        {
            Console.WriteLine($"\nTotal MPG for {numTrips} trips = {totalMiles / totalGallons}");
        }
        // exit program
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();

        // helper method
        static double CalculateMPG(double miles, double gallons, ref double totalMiles, ref double totalGallons, ref int numTrips)
        {
            totalMiles += miles;
            totalGallons += gallons;
            numTrips += 1;
            return miles / gallons;
        }
    }
}