using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch3TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Ch 3 Console Project: Tip Calculator by Brandon Phillips\n");
            Write("What is the meal price? ");
            double mealPrice = double.Parse(ReadLine());
            CalculateFifteen(mealPrice);
            WriteLine($"Tip of 20% = {CalculateTwenty(mealPrice):C}");
            WriteLine($"Tip of 22% = {CalculateTwentyTwo(mealPrice):C}");
            WriteLine("\nPress any key to continue...");
            ReadKey();

            void CalculateFifteen(double price)
            {
                double tipValue = price * 0.15;
                WriteLine($"Tip of 15% = {tipValue:C}");
            }

            double CalculateTwenty(double price)
            {
                return price * 0.2;
            }

            double CalculateTwentyTwo(double price) => price * 0.22;
        }
    }
}
