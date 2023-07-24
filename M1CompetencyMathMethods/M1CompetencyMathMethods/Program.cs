using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace M1CompetencyMathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Module 1 Competency Exercise: Math Methods by Brandon Phillips\n");
            // integers
            Write("Enter an integer: ");
            int firstInt = int.Parse(ReadLine());
            Write("Enter another integer: ");
            int secondInt = int.Parse(ReadLine());
            WriteLine($"Integer total: {calculateTotal(firstInt, secondInt)}");
            calculateAverage(firstInt, secondInt);
            calculatePerimeter(firstInt, secondInt);
            WriteLine($"Integer area: {calculateArea(firstInt, secondInt)}\n");
            // doubles
            Write("Enter a double: ");
            double firstDouble = double.Parse(ReadLine());
            Write("Enter another double: ");
            double secondDouble = double.Parse(ReadLine());
            WriteLine($"Double total: {calculateTotal(firstDouble, secondDouble)}");
            calculateAverage(firstDouble, secondDouble);
            calculatePerimeter(firstDouble, secondDouble);
            WriteLine($"Double area: {calculateArea(firstDouble, secondDouble)}\n");
            // pause
            WriteLine("Press any key to continue...");
            ReadKey();
        }

        static int calculateTotal(int firstNum, int secondNum) => firstNum + secondNum;

        static int calculateArea(int firstNum, int secondNum) => firstNum * secondNum;

        static void calculateAverage(int firstNum, int secondNum)
        {
            int average = (firstNum + secondNum) / 2;
            WriteLine($"Integer average: {average}");
        }

        static void calculatePerimeter(int firstNum, int secondNum)
        {
            int perimeter = (firstNum * 2) + (secondNum * 2);
            WriteLine($"Integer perimeter: {perimeter}");
        }

        static double calculateArea(double firstNum, double secondNum) => firstNum * secondNum;

        static double calculateTotal(double firstNum, double secondNum) => firstNum + secondNum;
        
        static void calculateAverage(double firstNum, double secondNum)
        {
            double average = (firstNum + secondNum) / 2;
            WriteLine($"Double average: {average}");
        }

        static void calculatePerimeter(double firstNum, double secondNum)
        {
            double perimeter = (firstNum * 2) + (secondNum * 2);
            WriteLine($"Double perimeter: {perimeter}");
        }
    }
}
