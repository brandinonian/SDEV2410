using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch4DaysinaMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Ch 4 Console Project: Days in a Month by Brandon Phillips\n");
            // user input
            Write("\nEnter the number of a month: ");
            int monthNum = int.Parse(ReadLine());
            // display days
            WriteLine($"That month has {GetMonthDays(monthNum)} days\n");
            // pause
            WriteLine("Press any key to continue...");
            ReadKey();
        }

        static int GetMonthDays(int month)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return 28;
                default:
                    return 0;
            }
        }
    }
}
