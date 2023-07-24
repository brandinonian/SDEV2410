using Ch7CompanyPicnic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ch 7 Console Project: Company Picnic");

        Food soda = new Food("soda", 2.00, 50);
        Food hotDog = new Food("hot dog", 1.5, 25);
        Food turkeyLeg = new Food("turkey leg", 5.5, 20);
        CashRegister foodRegister = new CashRegister();
        CashRegister raffleRegister = new CashRegister();
        string reply;
        // purchases loop
        do
        {

            do
            {
                Console.Write("\nWhat are you buying, Raffle Ticket (r) or Food (f): ");
                string answer = Console.ReadLine();
                if (answer == "r")
                {
                    Console.Write("$5 each, how many? ");
                    double cost = 5 * (double.Parse(Console.ReadLine()));
                    Console.Write($"That costs {cost:C}, how much are you paying? $");
                    double cash = double.Parse(Console.ReadLine());
                    double change = raffleRegister.NewSale(cost, cash);
                    Console.WriteLine($"The change is {change:C}");
                }
                else if (answer == "f")
                {
                    Console.WriteLine("Good Choices (s, h or t)");
                    soda.Display();
                    hotDog.Display();
                    turkeyLeg.Display();
                    Console.Write("Which food item do you want? (s, h or t)");
                    string answer1 = Console.ReadLine();
                    if (answer1 == "s")
                    {
                        Console.Write("How many do you want? ");
                        int qty = int.Parse(Console.ReadLine());
                        double cost = soda.Sell(qty);
                        Console.Write($"That costs {cost:C}, how much are you paying? $");
                        double cash = double.Parse(Console.ReadLine());
                        double change = foodRegister.NewSale(cost, cash);
                        Console.WriteLine($"The change is: {change:C}");
                    }
                    else if (answer1 == "h")
                    {
                        Console.Write("How many do you want? ");
                        int qty = int.Parse(Console.ReadLine());
                        double cost = hotDog.Sell(qty);
                        Console.Write($"That costs {cost:C}, how much are you paying? $");
                        double cash = double.Parse(Console.ReadLine());
                        double change = foodRegister.NewSale(cost, cash);
                        Console.WriteLine($"The change is: {change:C}");
                    }
                    else if (answer1 == "t")
                    {
                        Console.Write("How many do you want? ");
                        int qty = int.Parse(Console.ReadLine());
                        double cost = turkeyLeg.Sell(qty);
                        Console.Write($"That costs {cost:C}, how much are you paying? $");
                        double cash = double.Parse(Console.ReadLine());
                        double change = foodRegister.NewSale(cost, cash);
                        Console.WriteLine($"The change is: {change:C}");
                    }
                    else
                    {
                        throw new Exception("Error");
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }
                Console.Write("More purchases (y/n)");
                reply = Console.ReadLine();
            } while (reply != "y" && reply != "n");

        } while (reply == "y");

        // display grand totals
        Console.WriteLine("\nAt the end of the picnic:");
        Console.WriteLine($"Raffle Ticket Total Sales: {raffleRegister.GetTotalSales():C}");
        Console.WriteLine($"Food Total Sales: {foodRegister.GetTotalSales():C}");
        Console.WriteLine($"Grand Total: {CashRegister.grandTotalSales:C}");

        // exit program
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}