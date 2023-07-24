using Ch7Inventory;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ch 7 Console Project: Inventory by Brandon Phillips");
        // create objects
        Inventory[] items = new Inventory[3];

        for (int i = 0; i < items.Length; i++)
        {
            string name;
            int id;
            int qty;
            double price;
            Console.Write("\nEnter the item name: ");
            name = Console.ReadLine();
            Console.Write("Enter the item ID: ");
            try
            {
                id = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                id = 1000;
                Console.WriteLine("Error in item ID, using 1000");
            }
            Console.Write("Enter the item quantity: ");
            try
            {
                qty = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                qty = 1;
                Console.WriteLine("Error in quantity, using 1");
            }
            Console.Write("Enter the item price: ");
            try
            {
                price = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                price = 0.01;
                Console.WriteLine("Error in price, using $0.01");
            }
            items[i] = new Inventory(name, id, qty, price);
            items[i].DisplayItem();
        }
        // display total value
        Console.WriteLine($"\nTotal value of current inventory: {Inventory.totalCost:C}");
        // exit program
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}