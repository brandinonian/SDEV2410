using Ch10Inventory;
using System.Net.Sockets;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ch 10 Console Project: Inventory Array by Brandon Phillips");

        int size = 3; // user input loops this many times
        Item[] inventory = new Item[size];

        // user input loop
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("\n**Add items to inventory**");

            // input name
            Console.Write("\nEnter name of new item: ");
            string name = Console.ReadLine();

            // input id
            Console.Write("Enter ID number of new item: ");
            int id;
            try
            {
                id = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                id = 0;
                Console.WriteLine($"{e.Message}, id set to 0");
            }

            // input price
            Console.Write("Enter price of new item: $");
            double price;
            try
            {
                price = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                price = 0;
                Console.WriteLine($"{e.Message}, price set to 0");
            }

            // input qty
            Console.Write("Enter quantity of new item: ");
            int qty;
            try
            {
                qty = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                qty = 0;
                Console.WriteLine($"{e.Message}, quantity set to 0");
            }

            // update inventory
            inventory[i] = new Item(id, name, qty, price);
        }

        // interact with data
        string? reply = "";

        do
        {
            Console.Write("\nWhat do you want to do: (s)Sell, (r)Restock, (p)Print, (x)Exit?: ");
            reply = Console.ReadLine();

            switch (reply)
            {
                case "s":
                    // sell item
                    {
                        Console.Write("Enter item ID: ");
                        int id;
                        Item item;
                        try
                        {
                            id = int.Parse(Console.ReadLine());
                            item = findItemID(inventory, id);

                            // confirm the item exists
                            if (item == null)
                            {
                                throw new Exception("No items found.");
                            }
                            Console.WriteLine($"Item found: {item.ToString()}");
                            Console.Write("How many sold? ");
                            int qty = 0;
                            qty = int.Parse(Console.ReadLine());
                            if (item.sellItem(qty) == true)
                            {
                                Console.WriteLine(item.ToString());
                            }
                            else
                            {
                                Console.WriteLine("Not enough inventory...no sale");
                            }
                        }

                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;
                    }

                case "r":
                    // restock item
                    {
                        Console.Write("Enter item ID: ");
                        int id;
                        Item item;
                        try
                        {
                            id = int.Parse(Console.ReadLine());
                            item = findItemID(inventory, id);

                            // confirm result
                            if (item == null)
                            {
                                throw new Exception("No items found.");
                            }
                            Console.WriteLine($"Item found: {item}");
                            Console.Write("What is the new quantity? ");
                            int qty = 0;
                            qty = int.Parse(Console.ReadLine());
                            item.setQty(qty);
                            Console.WriteLine(item.ToString());
                        }

                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;
                    }

                case "p":
                    // print all items
                    {
                        foreach (Item item in inventory)
                        {
                            Console.WriteLine(item.ToString());
                        }

                        break;
                    }

                default:
                    // error message for invalid input
                    if (reply != "x")
                    {
                        Console.WriteLine("Invalid option, please try again");
                    }

                    break;
            }

        } while (reply != "x");

        // exit program
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();

    }
    // search inventory by ID
    static Item findItemID(Item[] inventory, int id)
    {
        Item? res = null;
        foreach (Item item in inventory)
        {
            if (item.getId() == id)
            {
                res = item;
            }
        }
        return res;
    }

}