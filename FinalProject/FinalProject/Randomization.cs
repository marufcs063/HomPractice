using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    public static class Randomization
    {
        public static Random rand = new Random();

        public static void Randomizer(this object[] obj)
        {
            for (int i=obj.Length-1;i>0;i--)
            {
                var j = rand.Next(i + 1);
                object temp = obj[i];
                obj[i] = obj[j];
                obj[j] = temp;
            }

        }
    }
}
