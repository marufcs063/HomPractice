using System;
using System.Collections.Generic;
using System.Text;

namespace Homepractice21
{
    public class Rectangle : Shape
    {
        public double x { get; set; }
        public double y { get; set; }
        public double l { get; set; }
        public double w { get; set; }
        public override double CalculateArea()
        {
            return x * y;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (l + w);
        }
    }
}
