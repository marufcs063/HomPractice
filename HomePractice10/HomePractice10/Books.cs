using System;
using System.Collections.Generic;
using System.Text;

namespace HomePractice10
{
    class Books : Product
    {
        public string Author;

        public override string PriceFormate()
        {
            return $"Tk. {price}";
        }
    }
}
