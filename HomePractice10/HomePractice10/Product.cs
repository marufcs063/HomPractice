using System;
using System.Collections.Generic;
using System.Text;

namespace HomePractice10
{
    class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }

        protected double price;
        public string feature { get; set; }
        public double Price
        {
            get 
            {
                return price;
            }
            set
            {
                if (value < 0)
                    price = 0;
                else
                    price = value;
            }

        }

        public virtual string PriceFormate()
        {
            return $"Tk. {price.ToString("0.000")}";
        }


        public virtual double CalculateDiscunt()
        {
            return  price*(10/100.0);
        }
    }
}
