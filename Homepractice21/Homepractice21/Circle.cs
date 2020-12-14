using System;
using System.Collections.Generic;
using System.Text;

namespace Homepractice21
{
    public class Circle : Shape
    {
        public double r { get; set; }  
        public override double CalculateArea()
        {
            return Math.PI*r*r;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI*r;
        }
    }
}
