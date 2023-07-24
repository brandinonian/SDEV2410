using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12VehiclesFleet
{
    internal class Vehicle
    {
        private string make;
        private string model;
        private string color;
        private string engine;
        private int year;
        private int numDoors;

        public Vehicle(string make, string model, string color, string engine, int year, int numDoors)
        {
            this.make = make;
            this.model = model;
            this.color = color;
            this.engine = engine;
            this.year = year;
            this.numDoors = numDoors;
        }

        public override string ToString() => $"{year} {color} {make} {model}, {engine}, {numDoors} doors";

        public int GetYear() => year;

        public string GetMake() => make;
    }
}
