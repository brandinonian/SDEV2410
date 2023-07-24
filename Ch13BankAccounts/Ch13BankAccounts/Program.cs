using Ch13BankAccounts;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ch. 13 Console Project: Bank Accounts by Brandon Phillips");

        // array to hold all accounts
        ArrayList accounts = new ArrayList();

        // hardcoded accounts
        // checking
        accounts.Add(new Checking(1234, "Brandon", "Phillips", 5000, 3.50));
        accounts.Add(new Checking(5678, "Gavin", "Kent", 1500, 2.50));

        // savings
        accounts.Add(new Savings(4839, "Eric", "Thorup", 1500, 3));
        accounts.Add(new Savings(7901, "Kim", "Smith", 5000, 5));

        // credit
        accounts.Add(new CreditCard(6012, "James", "Jameson", 250.51, 2500));
        accounts.Add(new CreditCard(5489, "Thomas", "Adams", 1575.75, 5000));

        // loop through all accounts for processing
        foreach (BankAccount a in accounts)
        {
            // display account
            Console.WriteLine("\n" + a);

            // user input to add/pay
            Console.Write("How much to add/pay? ");

            // defaults to 0
            double inputCredit;

            // Exception handling for format errors
            try
            {
                inputCredit = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                inputCredit = 0;
                Console.WriteLine(e.Message);
            }

            // update account with new Credit
            a.Credit(inputCredit);

            // display results
            Console.WriteLine(a);

            // user input to withdraw/charge
            Console.Write("How much to charge/withdraw? ");

            // defaults to 0
            double inputDebit;

            // Exception handling for format errors
            try
            {
                inputDebit = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                inputDebit = 0;
                Console.WriteLine(e.Message);
            }

            // update account with new Debit
            a.Debit(inputDebit);

            // display results
            // Console.WriteLine(a + "\n");
        }

        // exit program
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}