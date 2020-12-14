using System;
using System.Collections.Generic;
using System.Text;

namespace MockAnswer5
{
    public class Bus:Vehicle
    {
        public Bus(string name, string color)
            : base(name, color)
        {

        }
        public Bus(string name, string color, int weight)
            : base(name, color, weight)
        {

        }
    }
}
