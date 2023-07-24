using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch5ContinentalConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Ch 5 Console Project: Continental Conversion by Brandon Phillips\n");

            CreateMPHTable();
            CreateUSDTable();
            CreateFahrenheitTable();

            // exit program
            WriteLine("\nPress any key to continue...");
            ReadKey();
        }

        static void CreateMPHTable()
        {
            WriteLine("  MPH     KPH\n" + "-----------------");
            for (decimal mph = 25m; mph <= 100m; mph += 5m)
            {
                decimal kph = ConvertToKPH(mph);
                WriteLine($"  {mph:N2}   {kph:N2}");
            }
            WriteLine("\n");
        }

        static void CreateUSDTable()
        {
            WriteLine("  USD     Euro\n" + "-----------------");
            for (decimal usd = 10m; usd <= 100m; usd += 5m)
            {
                decimal euro = ConvertToEuro(usd);
                WriteLine($"  {usd:N2}   {euro:N2}");
            }
            WriteLine("\n");
        }

        static void CreateFahrenheitTable()
        {
            WriteLine("  F temp   C temp\n" + "-----------------");
            for (decimal tempF = 32m; tempF <= 110m; tempF += 2)
            {
                decimal tempC = ConvertToCelsius(tempF);
                WriteLine($"   {tempF:N2}   {tempC:N2}");
            }
        }

        static decimal ConvertToKPH(decimal milesPerHour)
        {
            return decimal.Multiply(milesPerHour, 1.609m);
        }

        static decimal ConvertToEuro(decimal dollar)
        {
            return decimal.Multiply(dollar, 0.89m);
        }

        static decimal ConvertToCelsius(decimal degreesF)
        {
            return decimal.Multiply((degreesF - 32), 0.556m);
        }
    }
}
