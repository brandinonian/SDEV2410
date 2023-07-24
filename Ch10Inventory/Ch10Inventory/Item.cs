using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10Inventory
{
    internal class Item
    {
        private int id;
        private string name;
        private int qty;
        private double price;

        public Item()
        {
            this.id = -1;
            this.name = "unspecified item";
            this.qty = 0;
            this.price = 0;
        }

        public Item(int id, string name, int qty, double price)
        {
            this.id = id;
            this.name = name;
            this.qty = qty;
            this.price = price;
        }

        public override string ToString() => $"{id} {name}, price {price:C}, {qty} on hand";

        public int getId() { return id ; }

        public void setQty(int qty)
        {
            this.qty = qty;
        }

        public bool sellItem(int qty)
        {
            if (this.qty >= qty)
            {
                this.qty -= qty;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
