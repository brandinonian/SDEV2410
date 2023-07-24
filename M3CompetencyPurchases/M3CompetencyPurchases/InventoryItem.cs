using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3CompetencyPurchases
{
    internal class InventoryItem
    {
        private int id;
        private string name;
        private double price;
        private int qty;
        public InventoryItem(int id, string name, double price, int qty)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
        }
        public override string ToString()
        {
            return $"Item {id} {name}, {price:C}, quantity: {qty}";
        }
        public double qtyPurchase()
        {
            int num;
            Console.WriteLine(ToString());
            Console.Write("How many do you want? ");
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                num = 0;
                Console.WriteLine(e.Message);
            }
            if (num < qty)
            {
                qty -= num;
                return num * price;
            }
            else
            {
                Console.WriteLine("Not enough inventory");
                return 0;
            }
        }
    }
}
