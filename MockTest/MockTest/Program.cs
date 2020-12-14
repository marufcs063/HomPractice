using System;

namespace MockTest
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var company = new Company<object>();
            company.Work = "";
            company.Name = "";
            company.CallPrivate("Abdullah", args);
        }
    }
}
