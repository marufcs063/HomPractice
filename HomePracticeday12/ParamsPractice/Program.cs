using System;

namespace ParamsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var math = new Math();
            var x = math.Average(2, 3);
            var y = math.Average(2, 3, 5);
            var z = math.Average(2, 3, 4, 5, 6, 7, 8, 9);
            var z2 = math.Average(new int[] { 2, 3, 4, 5, 6, 7, 8, 9 });

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(z2);

            math.Objects("abc", "efg", "hij", "klm", "nop", "qrs", "stu", "vwx", "yz");
        }
    }
}
