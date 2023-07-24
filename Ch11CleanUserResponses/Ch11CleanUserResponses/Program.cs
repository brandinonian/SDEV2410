using System.Collections;
using Ch11CleanUserResponses;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ch 11 Console Project: Clean User Responses");

        string reply = "";
        char[] trimYN = { ' ', 'e', 's', 'o' };
        ArrayList customers = new ArrayList();

        // user input loop
        do
        {
            Console.Write("\nEnter customer ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter the first and last name: ");
            string fullName = Console.ReadLine();

            // split full name into first/last
            string[] names = fullName.Split(' ');
            string firstName, lastName;
            firstName = names[0];
            lastName = names[1];

            // add customer to array list
            customers.Add(new Customer(id, firstName, lastName));

            // ask user to repeat
            Console.Write("Do you have another to enter? (y/n): ");
            string fullReply = Console.ReadLine();

            // trim response and make lowercase
            string lowerReply = fullReply.ToLower();
            reply = lowerReply.Trim(trimYN);

        } while (reply == "y");

        // display customers
        Console.WriteLine();
        foreach (Customer customer in customers)
        {
            Console.WriteLine(customer.Display());
        }

        // exit program
        Console.WriteLine("\nPress any key to exit");
        Console.ReadKey();
    }
}