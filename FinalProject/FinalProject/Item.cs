using System;
namespace FinalProject
{
    public abstract class Item : ICalculateCost
    {
        protected string id, name;
        protected int qty;

        public Item(string id, string name, int qty)
        {
            this.id = id;
            this.name = name;
            this.qty = qty;
        }

        public abstract (double rate, double total) CalculateCost();

        public abstract double CalculateDiscount();
    }

}