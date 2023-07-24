using System; namespace FinalProject {     public class Shipping : Item     {         private double length, width, height, weight, distance;         public static double totalCost = 0;         public static double totalFlatCost = 0;          // hardcoded zone shipping values         private double[] zoneRate = { 50, 35, 20, 10 };         private double[] zoneDistance = { 1000, 500, 100 };          public Shipping(string id, string name, int qty, double length, double width, double height, double weight, double distance)             :base(id, name, qty)         {             this.length = length;             this.width = width;             this.height = height;             this.weight = weight;             this.distance = distance;         }          // zone shipping price         public override (double rate, double total) CalculateCost()         {             double rate, total;             if (distance > zoneDistance[0])
            {
                rate = zoneRate[0];
                total = qty * rate;
            }             else if (distance > zoneDistance[1])
            {
                rate = zoneRate[1];
                total = qty * rate;
            }
            else if (distance > zoneDistance[2])
            {
                rate = zoneRate[2];
                total = qty * rate;
            }
            else
            {
                rate = zoneRate[3];                 total = qty * rate;
            }
            return (rate, total);
        }

        // flat rate price
        public override double CalculateDiscount()
        {
            return qty * 35;
        }

        public override string ToString() => $"{id} {name}: {qty} boxes, distance {distance} miles\nSize: {length} x {width} x {height}, weight: {weight}";

        public string RatesString() => $"Zone rates:\n   {zoneDistance[0]} at {zoneRate[0]:C}, {zoneDistance[1]} at {zoneRate[1]:C}, {zoneDistance[2]} at {zoneRate[2]:C}";
    } }  