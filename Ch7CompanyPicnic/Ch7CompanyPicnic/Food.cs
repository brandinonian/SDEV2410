using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7CompanyPicnic
{
    internal class Food
    {
        private string name;
        private double price;
        private int qty;

        public Food(string name, double price, int qty)
        {
            this.name = name;
            this.price = price;
            this.qty = qty;
        }

        public void Display()
        {
            Console.WriteLine($"{this.name}, {this.price:C}");
        }
        public double Sell(int num)
        {
            if (qty > num)
            {
                qty -= num;
                return num * price;
            }
            else
            {
                Console.WriteLine("Not enough inventory...");
                return 0;
            }
        }
    }
}
