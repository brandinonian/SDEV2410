using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7Inventory
{
    internal class Inventory
    {
        private string name;
        private int id;
        private int qty;
        private double price;

        public static double totalCost = 0;

        public Inventory(string name, int id, int qty, double price)
        {
            this.name = name;
            this.id = id;
            this.qty = qty;
            this.price = price;
            totalCost += qty * price;
        }

        private string ListID() => ("#" + id + " " + name);
        public void DisplayItem()
        {
            Console.WriteLine($"\n{ListID()}: {qty} at {price:C} each, value {qty * price:C}");
        }

        public double GetTotalCost() => totalCost;
    }
}
