using System;
using System.Collections.Generic;
using System.Text;

namespace MockAnswer5
{
    public class Vehicle
    {
        public string name { get; set; }
        public string color { get; set; }
        public int weight { get; set; }
        public Vehicle(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        public Vehicle(string name, string color, int weight)
        {
            this.name = name;
            this.color = color;
            this.weight = weight;

        }
    }
}
