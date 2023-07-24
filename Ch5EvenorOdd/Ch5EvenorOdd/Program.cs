using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch5EvenorOdd
{
    class Program
    {
        static void Main(string[] args)
        {            
            WriteLine("Ch 5 Console Project: Even or Odd by Brandon Phillips\n");

            int evenTotal;
            int oddTotal;

            (evenTotal, oddTotal) = GetIntegers();

            WriteLine($"Number of even totals: {evenTotal}");
            WriteLine($"Number of odd totals: {oddTotal}");

            // exit program
            WriteLine("\nPress any key to continue...");
            ReadKey();
        }

        static (int, int) GetIntegers()
        {
            int evenTotal = 0;
            int oddTotal = 0;
            int userInt;
            int total;
            string reply = "";
            do
            {
                total = 0;
                do
                {
                    Write("Please enter a positive integer (0 to end): ");
                    userInt = int.Parse(ReadLine());
                    if (userInt > 0)
                    {
                        total += userInt;
                    }
                } while (userInt != 0);

                if (total != 0)
                {
                    WriteLine($"The total of those numbers is {total}");
                    if (CheckEven(total))
                    {
                        evenTotal++;
                        WriteLine("That number is even");
                    }
                    else
                    {
                        oddTotal++;
                        WriteLine("That number is odd");
                    }
                    Write("Do you want to continue? (y/n) ");
                    reply = ReadLine();
                }
                else
                {
                    return (evenTotal, oddTotal);
                }
            } while (reply == "y");
            return (evenTotal, oddTotal);
        }

        static bool CheckEven(int num)
        {
            return num % 2 == 0;
        }
    }
}
