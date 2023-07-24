using System;
namespace FinalProject
{
    public interface ICalculateCost
    {
        public (double rate, double total) CalculateCost();
        public double CalculateDiscount();
    }
}

