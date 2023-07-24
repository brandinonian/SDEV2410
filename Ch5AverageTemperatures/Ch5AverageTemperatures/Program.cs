using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch5AverageTemperatures
{
    class Program
    {
        static void Main(string[] args)
        {
            double highTemp;
            double lowTemp;
            string reply = "";
            WriteLine("Ch 5 Console Project: Average Temperatures by Brandon Phillips\n");
            do
            {
                do
                {
                    Write("Enter a high temperature: ");
                    highTemp = double.Parse(ReadLine());
                } while (highTemp > 120);
                do
                {
                    Write("Enter a low temperature: ");
                    lowTemp = double.Parse(ReadLine());
                } while (lowTemp < -50);
                double averageTemp = (highTemp + lowTemp) / 2;
                WriteLine($"Average for {highTemp} and {lowTemp} is {averageTemp}");
                Write("Do you have more temperatures to enter? (y/n) ");
                reply = ReadLine();
            } while (reply == "y");
            WriteLine("\nPress any key to continue...");
            ReadKey();
        }
    }
}
