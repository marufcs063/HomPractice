using System;

namespace HomePractice3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region jagged array example

            //int[][] jaggedArray2 = new int[3][]
            //{
            //    new int[]{},
            //    new int[]{},
            //    new int[]{}
                
            //};


            #endregion

            #region if else
            Console.WriteLine("Please enter your first number: \n");

            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your 2nd number: \n");

            var b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your checking number: \n");

            var c = Convert.ToInt32(Console.ReadLine());


            var FinalResult = addition(a, b);
            if (FinalResult<c)
            {
                Console.WriteLine("It's less then "+c);
            }
            else
            {
                Console.WriteLine("It's greater then "+c);
            }
         

            

        }
          static int addition(int n1, int n2)
            {
            int result = n1 + n2;
            return result;

            }
        #endregion

    }
}
