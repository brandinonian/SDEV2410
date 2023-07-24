namespace FinalProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Final Project: Discount Purchasing and Shipping by Brandon Phillips");

            // Purchasing
            List<Purchasing> purchasingItems = new List<Purchasing>();

            // discount tier stored as an int, 0 = standard, 1 = premium, 2 = budget
            purchasingItems.Add(new Purchasing("P123", "coffee mug", 35, 0, 12.29));
            purchasingItems.Add(new Purchasing("P987", "magnet, large", 50, 0, 3.29));
            purchasingItems.Add(new Purchasing("P547", "stuffed bear", 30, 1, 11.99));
            purchasingItems.Add(new Purchasing("P879", "note cube", 50, 2, 2.50));

            // Shipping
            List<Shipping> shippingItems = new List<Shipping>();

            shippingItems.Add(new Shipping("S678", "Miami FL", 75, 11.5, 8.5, 4, 5.2, 2000));
            shippingItems.Add(new Shipping("S449", "Chicago IL", 39, 5, 5, 5, 12.3, 800));
            shippingItems.Add(new Shipping("S721", "Denver CO", 23, 6.5, 6.5, 3, 2.5, 150));
            shippingItems.Add(new Shipping("S678", "SLC UT", 15, 14, 8, 1, 1.5, 30));

            // Calculate and display each purchasing item
            Console.WriteLine("\nPart 1: Purchasing");
            foreach (Purchasing item in purchasingItems)
            {
                Console.WriteLine("\n" + item);
                Console.WriteLine(item.DiscountString());

                // scoped variables for calculating/displaying costs
                double cost = item.GetCost();
                (double volumeRate, double volumeDiscount) = item.CalculateCost();
                double volumeTotal = cost - volumeDiscount;
                double cartDiscount = item.CalculateDiscount();
                double cartTotal = cost - cartDiscount;

                // straight cost
                Console.WriteLine($"Cost with no discount: {cost:C}");
                Purchasing.totalCost += cost;

                // volume discount
                Console.WriteLine($"Volume rate: {volumeRate * 100:0.00}%, discount: {volumeDiscount:C}");
                Console.WriteLine($"Cost after volume discount: {volumeTotal:C}");
                Purchasing.volumeTotal += volumeTotal;

                // cart discount
                Console.WriteLine($"Whole cart discount: {cartDiscount:C}");
                Console.WriteLine($"Cost after cart discount: {cartTotal:C}");
                Purchasing.cartTotal += cartTotal;
            }

            // display purchasing totals
            Console.WriteLine("\nSummary:");
            Console.WriteLine($"   Straight Cost: {Purchasing.totalCost:C}");
            Console.WriteLine($"Volume Discounts: {Purchasing.volumeTotal:C}");
            Console.WriteLine($"   Cart Discount: {Purchasing.cartTotal:C}");

            // Calculate and display each shipping item
            Console.WriteLine("\nPart 2: Shipping");
            foreach (Shipping item in  shippingItems)
            {
                Console.WriteLine("\n" + item);
                Console.WriteLine(item.RatesString());

                // scoped variables for calculating/displaying costs
                (double zoneRate, double zoneTotal) = item.CalculateCost();
                double flatTotal = item.CalculateDiscount();

                // zone shipping costs
                Console.WriteLine($"Zone rate: {zoneRate:C}, ship cost: {zoneTotal:C}");
                Shipping.totalCost += zoneTotal;

                // flat rate costs
                Console.WriteLine($"Flat rate cost: {flatTotal:C}");
                Shipping.totalFlatCost += flatTotal;
            }

            // display shipping totals
            Console.WriteLine("\nSummary:");
            Console.WriteLine($"Zone shipping costs: {Shipping.totalCost:C}");
            Console.WriteLine($"     Flat rate cost: {Shipping.totalFlatCost:C}");

            // exit program
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}