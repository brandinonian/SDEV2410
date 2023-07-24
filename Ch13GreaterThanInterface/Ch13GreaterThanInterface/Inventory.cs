using System;
namespace Ch13GreaterThanInterface
{
	public class Inventory : IGreater
	{
        private int id, qty;
        private string name;
        private double price, value;

		public Inventory(int id, int qty, string name, double price)
        {
            this.id = id;
            this.qty = qty;
            this.name = name;
            this.price = price;
            this.value = qty * price;
        }

        public void SetQty(int q)
        {
            // update qty on hand and total value
            qty = q;
            value = qty * price;
        }

        public override string ToString()
        {
            return $"{id} {name} costs {price:C}, {qty} on hand, total value: {value:C}";
        }

        public bool IsGreater(object obj)
        {
            // cast parameter to inventory type
            Inventory i = (Inventory)obj;

            // compare items, return true if this item has greater value
            if (this.value > i.value)
            {
                return true;
            }
            else { return false; }
        }

        public void DisplayGreater(object obj)
        {
            // cast parameter to inventory type
            Inventory i = (Inventory)obj;

            // display results
            Console.WriteLine($"{this.name} has more warehouse value than {i.name}");
        }
    }
}

