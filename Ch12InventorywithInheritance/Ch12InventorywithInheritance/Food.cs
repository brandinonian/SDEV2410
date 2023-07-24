using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12InventorywithInheritance
{
    internal class Food : Inventory
    {
        private int calories;
        private bool isPerishable;

        // Inventory constructor:
        //
        // Intentory(string id, string name, double price, int qty)
        //
        public Food (string id, string name, double price, int qty, int calories, bool isPerishable)
            : base(id, name, price, qty)
        {
            this.calories = calories;
            this.isPerishable = isPerishable;
        }

        public override string ToString()
        {
            string perish;
            if (isPerishable)
            {
                perish = "Needs refrigeration";
            }
            else
            {
                perish = "Does not need refrigeration";
            }
            return $"{base.ToString()} {calories} calories, {perish}.";
        }
    }
}
