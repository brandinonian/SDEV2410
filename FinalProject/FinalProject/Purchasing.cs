using System; namespace FinalProject {     public class Purchasing : Item     {         private int discountTier;         private double price;
        private double[] discount = new double[4];
        private double[] volume = new double[3];
        public static double totalCost = 0;         public static double volumeTotal = 0;         public static double cartTotal = 0;          public Purchasing(string id, string name, int qty, int discountTier, double price)             :base(id, name, qty)         {             this.discountTier = discountTier;             this.price = price;              // hardcoded volume discount data             double[] standardDiscount = { .20, .10, .05, 0 };             double[] standardVolume = { 50, 30, 15 };              double[] premiumDiscount = { .12, .08, .03, 0 };             double[] premiumVolume = { 20, 10, 5 };              double[] budgetDiscount = { .20, .10, .05, 0 };             double[] budgetVolume = { 150, 100, 50 };              // set the correct values for discount tier             if (discountTier == 0)
            {
                discount = standardDiscount;
                volume = standardVolume;
            }             else if (discountTier == 1)
            {
                discount = premiumDiscount;
                volume = premiumVolume;
            }             else if (discountTier == 2)
            {
                discount = budgetDiscount;
                volume = budgetVolume;
            }         }          // straight price         public double GetCost() => qty * price;          // volume discount price         public override (double rate, double total) CalculateCost()         {             double rate, total;             if (qty > volume[0])
            {
                rate = discount[0];
            }             else if (qty > volume[1])
            {
                rate = discount[1];
            }             else if (qty > volume[2])
            {
                rate = discount[2];
            }             else rate = discount[3];             total = qty * price * rate;             return (rate, total);         }          // cart discount price         public override double CalculateDiscount()         {
            return GetCost() * .10;         }          public override string ToString() => $"{id} {name}: cost {price:C}, quantity {qty}";          public string DiscountString() => $"Discount options:\n   {volume[0]} at {discount[0] * 100:0.00}%, {volume[1]} at {discount[1] * 100:0.00}%, {volume[2]} at {discount[2] * 100:0.00}%";     } }  