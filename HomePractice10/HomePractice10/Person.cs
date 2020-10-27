using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace HomePractice10
{
    class Person
    {
        private string name;
        public double weight;
        public double height;
        private double speed;

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
        public double Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
        public Person()
        {
           
        }
        public Person(string name)
         {
            this.name = name;
        }

        public double walk()
        {
            speed = 0;
            return speed;
        }
        public double walk(double speed, int maxSpeed)
        {
            return this.speed = speed > maxSpeed ? maxSpeed : speed;
           
        }
        public void walk(int speed)
        {
            this.speed = speed;
        }
    }
}
