using System;
using System.Collections.Generic;
using System.Text;

namespace HomePractice10
{
    class Electronics: Product
    {
        public string BrandName { get; set; }

        public override double CalculateDiscunt()
        {
            return price* (50/100.0);
        }
    }
}
