using System;
using System.Collections.Generic;
using System.Text;

namespace ParamsPractice
{
    public class Math
    {
        public double Average(params int[]items)
        {
            var sum = 0.0;
            foreach(var iteam in items)
            {
                sum += iteam;
            }
            return sum / items.Length;
        }

        public void Objects(params object[]obj)
        {
            for(var i=0;i<obj.Length;i++)
            {
                Console.WriteLine(obj[i]);
            }

        }
    }
}
