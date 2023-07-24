using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12InventorywithInheritance
{
    internal class Inventory
    {
        private string id;
        private string name;
        private double price;
        private int qty;

        public Inventory(string id, string name, double price, int qty)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
        }

        public Inventory()
        {
            this.qty = 0;
            this.id = "";
            this.name = "";
            this.price = 0;
        }

        public override string ToString()
        {
            return $"{id} {name}: qty {qty}, price {price:C}, ";
        }

        public string GetID() => id;

        public double SellItem(int qty)
        {
            if (qty <= this.qty)
            {
                this.qty -= qty;
                return this.price;
            }
            else
            {
                return 0;
            }
        }
    }
}
