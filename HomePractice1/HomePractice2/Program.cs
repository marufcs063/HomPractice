using System;

namespace HomePractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example 1 - Icrement/Decrement operator
            int i = 3;
            Console.WriteLine(i);
            Console.WriteLine(i++);
            Console.WriteLine(i);

            double a = 1.5;
            Console.WriteLine(a);
            Console.WriteLine(++a);
            Console.WriteLine(a);

            int i2 = 3;
            Console.WriteLine(i2);
            Console.WriteLine(i2--);
            Console.WriteLine(i2);

            double a2 = 1.5;
            Console.WriteLine(a2);
            Console.WriteLine(--a2);
            Console.WriteLine(a2);

            #endregion

            #region Example 2 -Unary plus and minus operators
            Console.WriteLine(+4);
            Console.WriteLine(-4);
            Console.WriteLine(-(-4));

            #endregion

            #region Example 3 math operator
            Console.WriteLine(5*2);
            Console.WriteLine(0.5*2.5);
            Console.WriteLine(0.1m*23.4m);
            
            Console.WriteLine(13/5);
            Console.WriteLine(-13/5);
            Console.WriteLine(13/-5);
            Console.WriteLine(-13/-5);

            Console.WriteLine(16.8f/4.1f);
            Console.WriteLine(16.8d/4.1d);
            Console.WriteLine(16.8m/4.1m);

            Console.WriteLine(5 % 4);
            Console.WriteLine(5%-4);
            Console.WriteLine(-5%4);
            Console.WriteLine(-5%-4);

            var x = 5;
            x += 9;
            Console.WriteLine(x);

            x -= 4;
            Console.WriteLine(x);

            x *= 2;
            Console.WriteLine(x);

            x /= 4;
            Console.WriteLine(x);

            x %= 3;
            Console.WriteLine(x);

            #endregion

            #region Example 4 Bitwise complement operator
            uint t = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
            uint b = ~t;
            Console.WriteLine(Convert.ToString(b, toBase: 2 ));


            #endregion

            #region example 5 shift operators

            uint m = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
            Console.WriteLine($"Before: { Convert.ToString(m,toBase: 2)}");
            uint y = m << 4;
            Console.WriteLine($"After: {Convert.ToString(y, toBase: 2 )}");

            uint n = 0b_1001;
            Console.WriteLine($"Before: { Convert.ToString(n, toBase: 2),4}");
            uint n2 = n >>2;
            Console.WriteLine($"After: {Convert.ToString(n2, toBase: 2),4}");

            #endregion

            #region example 6 logical Operators

            uint a1 = 0b_1111_1000;
            uint b1 = 0b_1001_1101;
            uint c1 = a1 & b1;
            Console.WriteLine(Convert.ToString(c1, toBase: 2));

            uint p = 0b_1111_1000;
            uint q = 0b_1001_1100;
            uint r = p | q;
            Console.WriteLine(Convert.ToString(r, toBase: 2));

            uint w = 0b_1111_0000;
            uint v = 0b_0001_1100;
            uint z = w ^ v;
            Console.WriteLine(Convert.ToString(z, toBase: 2));


            #endregion
        }
    }
}
