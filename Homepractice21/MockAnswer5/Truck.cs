using System;
using System.Collections.Generic;
using System.Text;

namespace MockAnswer5
{
    public class Truck : Vehicle
    {
        public Truck(string name, string color)
            :base(name,color)
        {

        }
        public Truck(string name, string color, int weight)
            :base(name,color,weight)
        {

        }
    }
}
