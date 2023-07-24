using Ch12InventorywithInheritance;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ch. 12 Console Project: Inventory with Inheritance by Brandon Phillips");

        // input loop
        // array list to store inventory
        ArrayList inventory = new ArrayList();
        // ask user to enter info about items, add a variable number of items to the list
        string reply = ""; // "y" to repeat
        do
        {
            Console.WriteLine("\nAdd new item to inventory");
            // enter parameters for Inventory constructor
            //
            // Inventory(string id, string name, double price, int qty)
            //
            // string id
            Console.Write("\nEnter item ID: ");
            string id = Console.ReadLine();
            // string name
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            // double price
            bool repeat = false;
            double price = 0;
            do
            {
                repeat = false;
                // try/catch to catch format exceptions
                try
                {
                    Console.Write("Enter price: $");
                    price = double.Parse(Console.ReadLine());

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    repeat = true;
                }
            } while (repeat == true);
            // int qty
            int qty = 0;
            do
            {
                repeat = false;
                // try/catch to catch format exceptions
                try
                {
                    Console.Write("Enter quantity: ");
                    qty = int.Parse(Console.ReadLine());

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    repeat = true;
                }
            } while (repeat == true);
            //
            //ask user which type of item, "f" for food and "c" for clothing
            do
            {

                Console.Write("Which type of item, Food(f) or Clothing(c): ");
                reply = Console.ReadLine();
            } while (reply != "f" && reply != "c");
            // input additional parameters based on the type of item
            //
            // food
            if (reply == "f")
            {
                // int calories
                Console.Write("How many calories? ");
                int calories = int.Parse(Console.ReadLine());
                // bool isPerishable
                // repeats until "y" on "n" is entered
                string perishReply;
                do
                {
                    Console.Write("Does it need refrigeration? (y/n): ");
                    perishReply = Console.ReadLine().ToLower();
                } while (perishReply != "y" && perishReply != "n");
                bool isPerishable;
                if (perishReply == "y")
                {
                    isPerishable = true;
                }
                else { isPerishable = false; }
                //
                //
                // create Food item and add to inventory list
                inventory.Add(new Food(id, name, price, qty, calories, isPerishable));
            }
            //
            // clothing
            else if (reply == "c")
            {
                // string size (should be s, m, x, xl)
                // repeat until valid answer is entered
                string sizeReply;
                do
                {
                    Console.Write("What size? (s/m/x/xl): ");
                    sizeReply = Console.ReadLine();
                } while (sizeReply != "s" && sizeReply != "m" && sizeReply != "x" && sizeReply != "xl");
                //
                //
                // create Clothing item with the appropriate size, add to inventory list
                inventory.Add(new Clothing(id, name, price, qty, sizeReply));
            }
            //
            // ask user to repeat
            // prompts again on invalid input
            do
            {
                Console.Write("\nDo you have more data to enter? (y/n): ");
                reply = Console.ReadLine().ToLower();
            } while (reply != "y" && reply != "n");
            // input "n" to exit the loop
        } while (reply == "y");

        // after loop ends, display all items
        foreach (var item in inventory)
        {
            if (item is Food)
            {
                Food tempF = (Food)item;
                Console.WriteLine(tempF.ToString());
            }
            else if (item is Clothing)
            {
                Clothing tempC = (Clothing)item;
                Console.WriteLine(tempC.ToString());
            }
        }

        // user purchase loop
        do
        {
            Inventory result;
            bool repeat = false;
            do
            {
                // ask user which item they would like to buy
                Console.Write("\nWhich item to you want to buy? (use ID): ");
                string inputID = Console.ReadLine();
                result = FindByID(inventory, inputID);

                // access method to find specific item in inventory
                if (result is Food)
                {
                    Food tempF = (Food)result;
                    Console.Write($"Item found: {tempF.ToString()}");
                    repeat = false;
                }
                else if (result is Clothing)
                {
                    Clothing tempC = (Clothing)result;
                    Console.Write($"Item found: {tempC.ToString()}");
                    repeat = false;
                }
                // display an error if no results are found
                else
                {
                    Console.WriteLine("No results with that ID");
                    repeat = true;
                }
            } while (repeat == true);

            // access Inventory sell method, check qty on hand before processing a sale
            Console.Write("\nHow many would you like to buy? ");
            int inputQty = int.Parse(Console.ReadLine());
            double totalCost = 0;
            double price = result.SellItem(inputQty);
            if (price != 0)
            {
                totalCost = price * inputQty;
                Console.WriteLine($"Cost for this purchase: {totalCost:C}");
            }
            else
            {
                Console.WriteLine("Not enough quantity on hand");
            }

            // ask user if they want to buy another item
            do
            {
                Console.Write("Make another purchase? (y/n): ");
                reply = Console.ReadLine();
            } while (reply != "y" && reply != "n");

        } while (reply == "y");

        // exit program
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    // helper method to find a specific item in the inventory
    // check the item id (string)
    public static Inventory FindByID(ArrayList inventory, string id)
    {
        Inventory res = new Inventory();
        foreach (Inventory item in inventory)
        {
            if (item.GetID() == id)
            {
                res = item;
            }
        }
        return res;
    }
}