using M3CompetencyPurchases;
using System.Reflection;

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Module 3 Competency Exercise: Purchases by Brandon Phillips\n");

        InventoryItem item = new InventoryItem(123, "soda", 1.19, 50);
        InventoryItem item1 = new InventoryItem(987, "cookie", 1.5, 20);
        Console.WriteLine(item.ToString());
        Console.WriteLine(item1.ToString());

        Customer customer = new Customer("Mark", "Matthews", 768);
        Customer customer1 = new Customer("Jane", "Jones", 567);
        Employee employee = new Employee("Larry", "Lamb", 1234);
        Employee employee1 = new Employee("Nancy", "Nome", 7654);

        object tempObj;

        // loop through purchases
        for (int i = 1; i < 5; i++)
        {
            // assign temporary object
            if (i == 1) tempObj = customer;
            else if (i == 2) tempObj = customer1;
            else if (i == 3) tempObj = employee;
            else tempObj = employee1;

            // process purchases
            Console.WriteLine($"\nProcessing purchases for {tempObj.ToString()}");
            double firstPrice = item.qtyPurchase();
            double secondPrice = item1.qtyPurchase();
            double totalPrice = firstPrice + secondPrice;

            // employee discount
            if (tempObj is Employee) totalPrice *= 0.75;

            // display sale total
            Console.WriteLine($"Total purchase for {tempObj.ToString()}: {totalPrice:C}");

            // display inventory
            Console.WriteLine("\nInventory");
            Console.WriteLine(item.ToString());
            Console.WriteLine(item1.ToString());
        }

        // exit program
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}