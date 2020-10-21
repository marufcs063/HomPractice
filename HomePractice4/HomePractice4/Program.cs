using System;

namespace HomePractice4
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Maruf = new Human();
            Maruf.Name = "Abdullah basar maruf";
            Maruf.height = 1.6256;
            Maruf.weight = 50;
            var Bmi= Maruf.BMI();
            Console.WriteLine("Maruf's BMI is: "+Bmi);

            Human mufrad = new Human();
            mufrad.Name = "Abdullah basar maruf";
            mufrad.height = 1.7;
            mufrad.weight = 60;
            var Bmi2 = mufrad.BMI();
            Console.WriteLine("Mufrad's BMI is: " + Bmi2);

        }
    }
}
