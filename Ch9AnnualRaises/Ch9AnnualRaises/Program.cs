namespace Ch9AnnualRaises
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ch. 9 Console Project: Annual Raises by Brandon Phillips");

            // employees using struct
            Employee emp1 = new Employee("Brandon", "Phillips", "hourly", 32.75, 6, 10, 2015);
            Employee emp2 = new Employee("John", "Doe", "salaried", 75000, 9, 27, 2013);
            Employee temp;

            // calculate raises loop
            for (int k = 1; k < 3; k++)
            {   // loop through pay cycles
                Console.WriteLine($"\nPay cycle {k}");
                for (int m = 1; m < 3; m++)
                {   // loop through employees
                    if (m == 1) temp = emp1;
                    else temp = emp2;
                    // display employee info before raise
                    Console.WriteLine($"{temp.Display()}");
                    // calculate pay raise for temp
                    temp.CalculateRaise(2020, 3, 3);
                    Console.WriteLine("After calculating raise: ");
                    // display employee info after pay raise
                    Console.WriteLine($"{temp.Display()}\n");
                }  // end of loop for employees
                Console.WriteLine("Completed looping through employees\n");
            }  // end of loop for pay cycles
            Console.WriteLine("Completed looping through pay cycles");

            // employee using class
            EmployeeClass empC1 = new EmployeeClass("Brandon", "Phillips", "hourly", 32.75, 6, 10, 2015);
            EmployeeClass empC2 = new EmployeeClass("John", "Doe", "salaried", 75000, 9, 27, 2013);
            EmployeeClass tempC;

            // calculate raises loop pt 2
            Console.WriteLine("\n------- Part 2, Class -------");
            for (int k = 1; k < 3; k++)
            {   // loop through pay cycles
                Console.WriteLine($"\nPay cycle {k}");
                for (int m = 1; m < 3; m++)
                {   // loop through employees
                    if (m == 1) tempC = empC1;
                    else tempC = empC2;
                    // display employee info before raise
                    Console.WriteLine($"{tempC.Display()}");
                    // calculate pay raise for temp
                    tempC.CalculateRaise(2020, 3, 3);
                    Console.WriteLine("After calculating raise: ");
                    // display employee info after pay raise
                    Console.WriteLine($"{tempC.Display()}\n");
                }  // end of loop for employees
                Console.WriteLine("Completed looping through employees\n");
            }  // end of loop for pay cycles
            Console.WriteLine("Completed looping through pay cycles");

            // exit program
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}