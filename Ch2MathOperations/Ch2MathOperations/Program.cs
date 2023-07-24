using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch2MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            WriteLine("Ch 2 Math Operations by Brandon Phillips\n");
            // get user integers
            Write("Enter an integer: ");
            num1 = int.Parse(ReadLine());
            Write("Enter another integer: ");
            num2 = int.Parse(ReadLine());
            // math operations
            WriteLine($"Addition:       {num1} + {num2} = {(num1 + num2)}");
            WriteLine($"Subtraction:    {num1} - {num2} = {(num1 - num2)}");
            WriteLine($"Multiplication: {num1} * {num2} = {(num1 * num2)}");
            WriteLine($"Division:       {num1} / {num2} = {(num1 / num2)}");
            WriteLine($"Modulus:        {num1} % {num2} = {(num1 % num2)}");
            // pause
            WriteLine("\nPress any key to continue...");
            ReadKey();
        }
    }
}