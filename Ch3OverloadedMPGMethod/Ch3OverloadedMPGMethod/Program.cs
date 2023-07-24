using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch3OverloadedMPGMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Ch 3 Console Project: Overloaded MPG Method by Brandon Phillips\n");

            int milesInt;
            int gallonsInt;
            double milesDouble;
            double gallonsDouble;
            // get integers
            Write("Enter an integer for miles: ");
            milesInt = int.Parse(ReadLine());
            Write("Enter an integer for gallons: ");
            gallonsInt = int.Parse(ReadLine());
            WriteLine($"Integer MPG = {calcMPG(milesInt, gallonsInt)}\n");
            // get doubles
            Write("Enter a double for miles: ");
            milesDouble = double.Parse(ReadLine());
            Write("Enter a double for gallons: ");
            gallonsDouble = double.Parse(ReadLine());
            WriteLine($"Double MPG = {calcMPG(milesDouble, gallonsDouble)}\n");
            // pause
            WriteLine("\nPress any key to continue...");
            ReadKey();
        }

        static int calcMPG(int miles, int gallons)
        {
            return miles / gallons;
        }

        static double calcMPG(double miles, double gallons)
        {
            return miles / gallons;
        }
    }
}
