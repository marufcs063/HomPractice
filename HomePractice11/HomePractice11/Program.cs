using System;
using System.Net.NetworkInformation;

namespace HomePractice11
{
    class Program
    {
        static void Main(string[] args)
        {
            #region switch case practice
            var choice = Convert.ToInt32(Console.ReadLine());
            int a = 5;
            int b = 6;
            double c;
            switch(choice)
            {
                case 1:
                    c = a + b;
                    Console.WriteLine($"The addition is = {c}");
                    break;

                case 2:
                    c = a - b;
                    Console.WriteLine($"The sub is = {c}");
                    break;

                case 3:
                    c = a * b;
                    Console.WriteLine($"The mul is = {c}");
                    break;

                case 4:
                    c = a / b;
                    Console.WriteLine($"The div is = {c}");
                    break;
                default:
                    Console.WriteLine("Ki dili ?");
                    break; 
            }
            #endregion
        }
    }
}
