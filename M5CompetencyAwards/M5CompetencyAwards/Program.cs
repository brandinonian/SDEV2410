using System.Collections;
using System;

namespace M5CompetencyAwards
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Module 5 Competency Exercise: Awards Proessing by Brandon Phillips");

            bool repeat = false;

            // array list for customers/sales reps
            ArrayList list = new ArrayList();

            // customers
            list.Add(new Customer("Ann", "Adams", "C987", 2));
            list.Add(new Customer("Dan", "Dawson", "C123", 1));

            // sales reps
            list.Add(new SalesRep("Brandon", "Phillips", "S345", 5, 2500));
            list.Add(new SalesRep("Sam", "Smith", "S654", 7, 5000));

            // for loop to process 3 months of data
            // display the person, ask user to input new sales, display new sales, calculate/display commission for sales reps, process awards and display
            for (int m = 1; m < 4; m++)
            {
                Console.WriteLine($"\n----- Sales for month {m} -----");
                foreach (Person person in list)
                {
                    // display user
                    Console.WriteLine(person.ToString());

                    // ask for new sales, loops on exceptions
                    person.SetNewSales();

                    // display new sales
                    Console.WriteLine($"New sales total: {person.GetTotalSales():C}");

                    // if sales rep calculate commission
                    if (person is SalesRep)
                    {
                        decimal commission = ((SalesRep)person).CalcCommission(person.GetNewSales());
                        Console.WriteLine($"Commission total: {commission:C}");
                    }

                    // process awards
                    decimal bonus = person.ProcessAwards(m);
                    if (bonus != 0)
                    {
                        if (person is Customer)
                        {
                            Console.WriteLine($"Cash back bonus: {bonus:C}");
                        }
                        else if (person is SalesRep)
                        {
                            Console.WriteLine($"Monthly bonus: {bonus:C}");
                        } 
                    }
                }
            }

            // display total

            // exit program
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}