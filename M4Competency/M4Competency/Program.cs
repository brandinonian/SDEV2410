using System.Collections;


namespace M4Competency
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Module 4 Competency Exercise: Customer List by Brandon Phillips");

            // customers array list
            ArrayList customers = new ArrayList();
            char[] trimYN = { ' ', 'e', 's', 'o' };

            // hardcoded customers
            customers.Add(new Customer(7745, "Brandon", "Phillips"));
            customers.Add(new Customer(7789, "Kim", "Smith"));
            customers.Add(new Customer(7712, "Gavin", "Ryver"));

            // print all hardcoded customers
            Console.WriteLine("\nCustomers who were hardcoded:");
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.ToString());
            }

            // user input loop
            string? reply = "";
            do
            {
                Console.Write("\nWhat do you want to do? (a)Add (d)Delete (c)Change (p)Print: ");
                string? choice = Console.ReadLine();
                if (choice != null)
                {
                    // user input switch
                    switch (choice.ToLower())
                    {
                        case "a":
                            {
                                // add entry
                                Console.Write("Enter new ID: ");
                                int id = 0;
                                try
                                {
                                    id = int.Parse(Console.ReadLine());
                                }
                                catch (Exception e)
                                {
                                    id = 0;
                                    Console.WriteLine($"{e.Message}, id set to 0");
                                }
                                Console.Write("Enter new first name: ");
                                string fname = Console.ReadLine();
                                Console.Write("Enter a new last name: ");
                                string lname = Console.ReadLine();

                                // add the customer to the list
                                customers.Add(new Customer(id, fname, lname));


                            }
                            break;
                        case "d":
                            {
                                // delete entry
                                Console.Write("Enter an ID to remove: ");
                                int id;
                                Customer? res = null;
                                try
                                {
                                    id = int.Parse(Console.ReadLine());
                                    res = FindByID(customers, id);
                                    if (res == null)
                                    {
                                        throw new Exception("No customer found...");
                                    }
                                    customers.Remove(res);
                                    Console.WriteLine($"Customer {res.GetId()} deleted");
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }
                            break;
                        case "c":
                            {
                                // change entry
                                Console.Write("Enter an ID to change: ");
                                int id;
                                Customer? res = null;

                                try
                                {
                                    id = int.Parse(Console.ReadLine());
                                    res = FindByID(customers, id);
                                    if (res == null)
                                    {
                                        throw new Exception("No customer found...");
                                    }

                                    // set new first name
                                    Console.Write("Enter a new first name: ");
                                    string firstName = Console.ReadLine();
                                    res.SetFirstName(firstName);

                                    // set new last name
                                    Console.Write("Enter a new last name: ");
                                    string lastName = Console.ReadLine();
                                    res.SetLastName(lastName);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }


                            }
                            break;
                        case "p":
                            {
                                // print all customers
                                foreach (Customer customer in customers)
                                {
                                    Console.WriteLine(customer.ToString());
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("Not a valid option, try again");
                            break;
                    }
                }

                // ask user to restart the loop
                do
                {
                    Console.Write("Would you like to continue? (Y/n): ");
                    string fullReply = Console.ReadLine();
                    string lowerReply = fullReply.ToLower();
                    reply = lowerReply.Trim(trimYN);

                } while (reply != "y" && reply != "n"); // repeat until Y or n is entered
            } while (reply != "n");

            // exit program
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static Customer FindByID(ArrayList customers, int id)
        {
            Customer? res = null;
            foreach (Customer customer in customers)
            {
                if (customer.GetId() == id)
                {
                    res = customer;
                }
            }
            return res;
        }
    }
}