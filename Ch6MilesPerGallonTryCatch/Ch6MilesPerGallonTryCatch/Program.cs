using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch6MilesPerGallonTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalMiles = 0;
            double totalGallons = 0;
            int tripsNum = 0;
            string reply = "";

            WriteLine("Ch 6 Console Project: Miles Per Gallon with Try/Catch by Brandon Phillips\n");

            // user input loop
            do
            {
                try
                {
                    Write("How many miles? ");
                    double miles = double.Parse(ReadLine());
                    Write("How many gallons? ");
                    double gallons = double.Parse(ReadLine());
                    try
                    {
                        if (gallons == 0) { throw new DivideByZeroException(); }
                        WriteLine($"MPG = {miles / gallons}");
                        totalMiles += miles;
                        totalGallons += gallons;
                        tripsNum++;
                    }
                    catch (DivideByZeroException)
                    {
                        WriteLine("Cannot divide by zero");
                    }
                }
                catch (FormatException)
                {
                    WriteLine("Incorrect format for double");
                }
                do
                {
                    Write("More data to input? (y/n) ");
                    reply = ReadLine();
                } while (reply != "y" && reply != "n");
            } while (reply == "y");

            // calculate total MPG
            if (tripsNum != 0)
            {
                CalculateTotalMPG(tripsNum, totalMiles, totalGallons);
            }

            // exit program
            WriteLine("\nPress any key to continue...");
            ReadKey();
        }
        static void CalculateTotalMPG(int tripsNum, double totalMiles, double totalGallons)
        {
            double totalMPG = totalMiles / totalGallons;
            WriteLine($"Total MPG for {tripsNum} trips = {totalMPG}");
        }
    }
}
