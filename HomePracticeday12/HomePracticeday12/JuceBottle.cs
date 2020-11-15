using System;
using System.Collections.Generic;
using System.Text;

namespace HomePracticeday12
{
    public class JuceBottle:Bottle
    {
        private string Pipe { get; set; }
        private string Belt { get; set; }

        public JuceBottle(int capacity, string color, int amount )
        :base(capacity,color,amount)
        {

        }

        public JuceBottle(int capacity, string color)
            :this(capacity,color,0)
        {

        }
    }
}
