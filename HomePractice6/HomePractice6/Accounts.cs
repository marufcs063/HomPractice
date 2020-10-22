using System;
using System.Collections.Generic;
using System.Text;

namespace HomePractice6
{
    class Accounts : Students
    {
        public double due { get; set; }

        public override double payable()
        {
            return payment*35/100.0;
        }
    }
}
