using System;
using System.Collections.Generic;
using System.Text;

namespace MockTest
{
    public class Employee
    {
        public string Name { get; set; }
        public string Work { get; set; }
        private object[] work;
        public void CallPrivate(String name,Object[] works )
        {
            Name = name;
            work[0] = works;

        }
    }
}
