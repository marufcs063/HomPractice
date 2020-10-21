using System;

namespace HomePractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region For loop
            var n = Convert.ToInt32(Console.ReadLine()); 
            for(int i=1 ;i<=n;i++)
            {
                Console.WriteLine("Astagfirullah");
            }
            #endregion

            #region while loop

            int x = 1;
            while(x<=n)
            {
                Console.WriteLine("subahanallah");
                x++;
            }

            #endregion

            #region Do while loop
            int a = 1;
            do
            {
                Console.WriteLine("Alhamdulillah");
                a++;

            } while (a <=n);

            #endregion

            #region foreach loop

            int[] p = new int[n];

                foreach (int t in p)
            {
                Console.WriteLine("allahuakbar") ;
            }

            #endregion
        }
    }
}
