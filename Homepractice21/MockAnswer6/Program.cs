using System;

namespace MockAnswer6
{
    class Program
    {
        static void Main(string[] args)
        {
                 
            var N = int.Parse(Console.ReadLine());

            Console.WriteLine(Fib(N));

        }
        public static int Fib(int Nthnumber)
        {
           
            if (Nthnumber <= 2)
                return 1;
            else
                return Fib(Nthnumber - 1) + Fib(Nthnumber - 2);
        }
    }
}
