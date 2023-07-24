using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch6FixThis
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int answer = num1 + num2;
                Console.WriteLine(answer.ToString());
            }
            catch (FormatException fe)
            {
                // handle exception
            }
        }
    }
}
