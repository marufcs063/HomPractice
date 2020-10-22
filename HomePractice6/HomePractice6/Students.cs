using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace HomePractice6
{
    class Students
    {
        public string name { get; set; }
        public string Id { get; set; }

        protected double payment;
        public double Payment
        {
            get
            {
                return payment;
            }
            set
            {
                if (value < 0)
                    payment = 0;
                else
                    payment = value;
            }
        }

        protected double result;

        public double Result
        {
            get
            {
                return result;
            }
            set
            {
                if (value < 0)
                    result = 0;
                else
                    result = value;
            }
        }
        public Students()
        {

        }

        public virtual double Hidden()
        {
            return result - 1.00  ;
        }

        public virtual double payable()
        {
            return payment * 10 / 100.0;
        }
    }
}
