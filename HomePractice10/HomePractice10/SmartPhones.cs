using System;
using System.Collections.Generic;
using System.Text;

namespace HomePractice10
{
    class SmartPhones : Electronics
    {
        public string ModelNumber { get; set; }

        public override string PriceFormate()
        {
            return $"Tk. {price}";
        }
    }
}
