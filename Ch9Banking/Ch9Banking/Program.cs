internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ch 9 Console Project: Banking using Struct by Brandon Phillips");

        // setup account
        int accountID = 0;
        string accountName = "";
        decimal accountBalance = 0;
        decimal accountFee = 0;
        bool restart = false;
        do
        {
            restart = false;
            try
            {
                Console.Write("\nWhat is account ID? ");
                accountID = int.Parse(Console.ReadLine());
                Console.Write("Customer's last name: ");
                accountName = Console.ReadLine();
                Console.Write("What is the balance? $");
                accountBalance = decimal.Parse(Console.ReadLine());
                Console.Write("What is the transaction fee? $");
                accountFee = decimal.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                restart = true;
            }
        } while (restart);
        
        // create bank account with user data
        BankAccount firstAccount = new BankAccount(accountID, accountName, accountBalance, accountFee);
        Console.WriteLine(firstAccount.DisplayBalance());

        // deposit/withdraw loop
        string reply = "";
        do
        {
            Console.Write("\nWhat do you want to do? (b)balance (w)withdraw (d)deposit (x)exit? ");
            reply = Console.ReadLine();
            switch (reply)
            {
                case "b":
                    Console.WriteLine($"{firstAccount.DisplayBalance()}");
                    break;
                case "w":
                    firstAccount.Withdraw();
                    break;
                case "d":
                    firstAccount.Deposit();
                    break;
            }
        } while (reply != "x");

        // exit program
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadLine();
    }
}