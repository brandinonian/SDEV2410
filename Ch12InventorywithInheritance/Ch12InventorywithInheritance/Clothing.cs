using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12InventorywithInheritance
{
    internal class Clothing : Inventory
    {
        private string size;

        // Inventory constructor:
        //
        // Intentory(string id, string name, double price, int qty)
        //
        public Clothing(string id, string name, double price, int qty, string size)
            : base(id, name, price, qty)
        {
            this.size = size;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, size {size}.";
        }
    }
}
