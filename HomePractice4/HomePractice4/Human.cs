using System;
using System.Collections.Generic;
using System.Text;

namespace HomePractice4
{
    public class Human
    {
        private string name;
        public double weight;
        public double height;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value != "")
                    name = value;
            }

        }


        public Human()
        {
            this.name = "";
        }

        public Human(string name)
        {
            this.name="";
        }

        public double BMI()
        {
            var result = weight/(height * height);
            return result;
        }
    }
}
